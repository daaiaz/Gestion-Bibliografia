Imports System.Data.SqlClient
Public Class frmLibro
    Dim vNuevo As Boolean = True
    Dim dvLibro As DataView
    Private Sub lblTitulo_Click(sender As Object, e As EventArgs)


    End Sub
    Function DatosValidos() As Boolean

        If txtisbn.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar el nombre del libro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtisbn.Focus()
            Return False
        End If
        Return True

    End Function
    Sub LimpiarFormulario()
        'Limpiamos todos los controles
        nudLibro.Value = 0

        txtisbn.Clear()
        cboAutor.SelectedItem = -1
        cboEditorial.SelectedItem = -1
        txtFormato.Clear()
        txtTitulo.Clear()
        nudNroPag.Value = 0
        txtEdicion.Clear()
        cboCategoria.SelectedItem = -1
        cboIdioma.SelectedItem = -1


        'Tiramos el foco al primer control EDITABLE por el usuario
        nudLibro.Focus()

        'Levantamos nuevamente la bandera
        vNuevo = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Try...Catch es una estructura para control de errores
        Try
            If DatosValidos() Then
                If vNuevo = True Then
                    EjecutarSQL("insert into libro values(@1,@2,@3,@4,@5,@6,@7,@8,@9)", txtisbn.Text.Trim, cboAutor.SelectedValue, cboEditorial.SelectedValue, txtFormato.Text.Trim, txtTitulo.Text.Trim, nudNroPag.Value, txtEdicion.Text.Trim, cboCategoria.SelectedValue, cboIdioma.SelectedValue)
                    'Sino, significa que el registro ya existe y se debe actualizar
                Else
                    EjecutarSQL("Update libro SET isbn = @1, id_autor = @2, id_editorial = @3, formato = @4, titulo = @5, nro_paginas = @6, nro_edicion = @7, id_categoria = @8, id_idioma = @9  Where id_libro = @10", txtisbn.Text.Trim, cboAutor.SelectedValue, cboEditorial.SelectedValue, txtFormato.Text.Trim, txtTitulo.Text.Trim, CInt(nudNroPag.Value), txtEdicion.Text.Trim, cboCategoria.SelectedValue, cboIdioma.SelectedValue)
                End If

                MessageBox.Show("Registro guardado con éxito!!!")
                LimpiarFormulario()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            'Cerrar la conexión
            conexion.Close()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            'Para poder eliminar el registro ya tiene que existir en la bd, sé que ya existe cuando vNuevo = False porque se asignó este valor en el cellDoubleClick de la grilla.
            If MessageBox.Show("Está seguro que desea eliminar el registro?", "Sistema de Gestion Bibliografica", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                If vNuevo = False Then
                    EjecutarSQL("delete from libro where id_libro = @1", nudLibro.Value)
                    LimpiarFormulario()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Primeramente dejamos sin ningún filtro en caso de que ya se haya hecho uno con anterioridad
        dvLibro.RowFilter = ""

        'Preguntamos si el usuario ingresó algún valor en el TextBox de Búsqueda
        If txtBuscarISBN.Text.Trim() <> "" Then
            'Aplicamos un filtro dentro del DataView.
            'El operador like se utiliza con campos del tipo Texto y recurre al caracter % que usa como caracter comodín.
            dvLibro.RowFilter = "ISBN like '%" & txtBuscarISBN.Text.Trim() & "%'"
        End If

        If nudLibro.Value > 0 Then
            If dvLibro.RowFilter = "" Then
                dvLibro.RowFilter = "id_libro = " & nudLibro.Value
            Else
                dvLibro.RowFilter = dvLibro.RowFilter & " AND id_libro = " & nudLibro.Value
            End If
        End If
    End Sub

    Private Sub dtgLibro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgLibro.CellContentClick
        'Instanciamos un objeto del tipo DataTable, que es una tabla en memoria, en la cual volcaremos los datos de la base datos a nuestra aplicación
        Dim dtLibro As DataTable

        'dgvConsulta(0, e.RowIndex) --> Cero hace referencia a la primera columna, y e.RowIndex hace referencia a la fila seleccionada

        dtLibro = generar_datatabla("Select * from libro where id_libro=" & dtgLibro(0, e.RowIndex).Value)
        'dtMateria = generar_datatabla("Select id_materia as Codigo, nombre_materia as Materia" & dgvConsulta(0, e.RowIndex).Value)

        'Si hay filas en la tabla en memoria
        If dtLibro.Rows.Count > 0 Then
            'Rows(0) hace referencia a la primera fila recuperada de la base de datos, que en este caso es la única, ya que por el where en la sentencia sql estamos recuperando un solo registro. Item("Columna") hace referencia a la columna que queremos recuperar de la tabla, tiene que coincidir con el nombre del campo en la tabla.
            nudLibro.Value = dtLibro.Rows(0).Item("id_libro")
            txtisbn.Text = dtLibro.Rows(0).Item("isbn")
            cboAutor.SelectedValue = dtLibro.Rows(0).Item("id_autor")
            cboEditorial.SelectedValue = dtLibro.Rows(0).Item("id_autor")
            cboIdioma.SelectedValue = dtLibro.Rows(0).Item("id_editorial")
            txtFormato.Text = dtLibro.Rows(0).Item("formato")
            txtTitulo.Text = dtLibro.Rows(0).Item("titulo")
            nudNroPag.Value = dtLibro.Rows(0).Item("nro_paginas")
            txtEdicion.Text = dtLibro.Rows(0).Item("nro_edicion")
            cboCategoria.SelectedValue = dtLibro.Rows(0).Item("id_categoria")

            'Para pasar a la primera pestaña (ABM) del tabControl
            tbcLibro.SelectedIndex = 0

            'La bandera que nos permite determinar si un registro es nuevo o no, en este caso como recuperamos datos de la bd asignamos false ya que sabemos el registro no es nuevo.
            vNuevo = False
        End If
    End Sub

    Private Sub tbcLibro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcLibro.SelectedIndexChanged
        'Si la pestaña seleccionada es 1, significa que está seleccionada la pestaña de consulta
        If tbcLibro.SelectedIndex = 1 Then
            'Asignamos el DataTable devuelto por el método "generar_datatabla" a la variable dvArticulos, conviertiéndolo primeramente en DataView

            'dvLibro = generar_datatabla("SELECT l.id_libro AS Codigo, l.isbn AS Libro, 
            'a.nombre AS Autor FROM libro l JOIN autor a
            'ON l.id_autor = a.id_autor").DefaultView

            'dvLibro = generar_datatabla("SELECT l.id_libro AS Codigo, l.isbn AS Libro, 
            'e.nombre AS Editorial FROM libro l JOIN editorial e
            'ON l.id_editorial = e.id_editorial").DefaultView

            'dvLibro = generar_datatabla("SELECT l.id_libro AS Codigo, l.isbn AS Libro, 
            'c.descripcion AS Categoria FROM libro l JOIN categoria c
            'ON l.id_categoria = c.id_categoria").DefaultView

            'dvLibro = generar_datatabla("SELECT l.id_libro AS Codigo, l.isbn AS Libro, 
            'i.descripcion AS Idioma FROM libro l JOIN idioma i
            'ON l.id_idioma = i.id_idioma").DefaultView

            'dvLibro = generar_datatabla("SELECT l.id_libro AS codigo, l.isbn AS isbn, l.titulo AS titulo, a.nombre AS autor, e.nombre AS editorial, l.formato AS Formato, l.nro_paginas AS Nro_paginas, l.nro_edicion AS nro_edicion, c.descripcion AS categoria, i.descripcion AS idioma FROM libro l JOIN autor a ON a.id_autor = l.id_autor JOIN editorial e ON e.id_editorial = l.id_editorial JOIN categoria c ON c.id_categoria = l.id_categoria JOIN editorial i ON i.id_idioma = l.id_idioma").DefaultView
            dvLibro = generar_datatabla("SELECT l.id_libro AS Codigo, l.isbn AS ISBN, l.titulo AS Titulo, a.nombre AS Autor, e.nombre AS Editorial, l.formato AS Formato, l.nro_paginas AS NroPag, l.nro_edicion AS NroEdicion, c.descripcion AS Categoria, i.descripcion AS Idioma FROM libro l JOIN autor a ON a.id_autor = l.id_autor JOIN editorial e ON e.id_editorial = l.id_editorial JOIN categoria c ON c.id_categoria = l.id_categoria JOIN idioma i ON i.id_idioma = l.id_idioma").DefaultView


            'Asignamos el DataView como origen de datos de la grilla
            dtgLibro.DataSource = dvLibro
        End If
    End Sub

    Private Sub txtBuscarISBN_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarISBN.TextChanged
        'Click en el botón buscar
        'btnBuscar.PerformClick()
        btnBuscar_Click(Me, New EventArgs)
    End Sub

    Private Sub frmLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Determinamos el origen de datos del combo, haciendo uso de la función "generar_datatabla" que retorna un objeto del tipo DataTable
        'El método "generar_datatabla" recibe como parámetro un SELECT en forma de String

        cboAutor.DataSource = generar_datatabla("select * from autor")
        'Campo a mostrar
        cboAutor.DisplayMember = "nombre"
        'Campo de la tabla que identifica al código
        cboAutor.ValueMember = "id_autor"


        cboEditorial.DataSource = generar_datatabla("select * from editorial")
        'Campo a mostrar
        cboEditorial.DisplayMember = "nombre"
        'Campo de la tabla que identifica al código
        cboEditorial.ValueMember = "id_editorial"

        cboCategoria.DataSource = generar_datatabla("select * from categoria")
        'Campo a mostrar
        cboCategoria.DisplayMember = "descripcion"
        'Campo de la tabla que identifica al código
        cboCategoria.ValueMember = "id_categoria"


        cboIdioma.DataSource = generar_datatabla("select * from idioma")
        'Campo a mostrar
        cboIdioma.DisplayMember = "descripcion"
        'Campo de la tabla que identifica al código
        cboIdioma.ValueMember = "id_idioma"


    End Sub
End Class