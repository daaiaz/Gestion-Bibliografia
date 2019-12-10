Public Class frmCategoria
    Dim vNuevo As Boolean = True
    Dim dvCategoria As DataView

    Function DatosValidos() As Boolean

        If txtDescripcion.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar el nombre de la categoria", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescripcion.Focus()
            Return False
        End If
        Return True

    End Function
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            If DatosValidos() Then
                If vNuevo = True Then
                    EjecutarSQL("insert into categoria values(@1)", txtDescripcion.Text.Trim)

                Else
                    EjecutarSQL("Update categoria SET descripcion = @1 Where id_categoria = @2", txtDescripcion.Text.Trim, CInt(nudCategoria.Value))
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

    Private Sub LimpiarFormulario()
        nudCategoria.Value = 0

        txtDescripcion.Clear()


        nudCategoria.Focus()

        'Levantamos nuevamente la bandera
        vNuevo = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            'Para poder eliminar el registro ya tiene que existir en la bd, sé que ya existe cuando vNuevo = False porque se asignó este valor en el cellDoubleClick de la grilla.
            If MessageBox.Show("Está seguro que desea eliminar el registro?", "Sistema de Gestion Bibliografica", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                If vNuevo = False Then
                    EjecutarSQL("delete from categoria where id_categoria = @1", nudCategoria.Value)
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
        dvCategoria.RowFilter = ""

        'Preguntamos si el usuario ingresó algún valor en el TextBox de Búsqueda
        If txtBuscarDescripcion.Text.Trim() <> "" Then
            'Aplicamos un filtro dentro del DataView.
            'El operador like se utiliza con campos del tipo Texto y recurre al caracter % que usa como caracter comodín.
            dvCategoria.RowFilter = "descripcion like '%" & txtBuscarDescripcion.Text.Trim() & "%'"
        End If

        If nudCategoria.Value > 0 Then
            If dvCategoria.RowFilter = "" Then
                dvCategoria.RowFilter = "id_categoria = " & nudCategoria.Value
            Else
                dvCategoria.RowFilter = dvCategoria.RowFilter & " AND id_categoria = " & nudCategoria.Value
            End If
        End If
    End Sub

    Private Sub txtBuscarDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarDescripcion.TextChanged
        btnBuscar_Click(Me, New EventArgs)
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub tbcCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcCategoria.SelectedIndexChanged
        'Si la pestaña seleccionada es 1, significa que está seleccionada la pestaña de consulta
        If tbcCategoria.SelectedIndex = 1 Then
            'Asignamos el DataTable devuelto por el método "generar_datatabla" a la variable dvArticulos, conviertiéndolo primeramente en DataView
            dvCategoria = generar_datatabla("SELECT c.id_categoria AS Codigo, c.descripcion AS Descripcion FROM categoria c ").DefaultView

            'Asignamos el DataView como origen de datos de la grilla
            dgvConsulta.DataSource = dvCategoria
        End If
    End Sub

    Private Sub dgvConsulta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellContentClick

    End Sub

    Private Sub dgvConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellDoubleClick
        'Instanciamos un objeto del tipo DataTable, que es una tabla en memoria, en la cual volcaremos los datos de la base datos a nuestra aplicación
        Dim dtCategoria As DataTable

        'dgvConsulta(0, e.RowIndex) --> Cero hace referencia a la primera columna, y e.RowIndex hace referencia a la fila seleccionada

        dtCategoria = generar_datatabla("Select * from categoria where id_categoria=" & dgvConsulta(0, e.RowIndex).Value)
        'dtMateria = generar_datatabla("Select id_materia as Codigo, nombre_materia as Materia" & dgvConsulta(0, e.RowIndex).Value)

        'Si hay filas en la tabla en memoria
        If dtCategoria.Rows.Count > 0 Then
            'Rows(0) hace referencia a la primera fila recuperada de la base de datos, que en este caso es la única, ya que por el where en la sentencia sql estamos recuperando un solo registro. Item("Columna") hace referencia a la columna que queremos recuperar de la tabla, tiene que coincidir con el nombre del campo en la tabla.
            nudCategoria.Value = dtCategoria.Rows(0).Item("id_categoria")
            txtDescripcion.Text = dtCategoria.Rows(0).Item("descripcion")


            'Para pasar a la primera pestaña (ABM) del tabControl
            tbcCategoria.SelectedIndex = 0

            'La bandera que nos permite determinar si un registro es nuevo o no, en este caso como recuperamos datos de la bd asignamos false ya que sabemos el registro no es nuevo.
            vNuevo = False
        End If
    End Sub
End Class