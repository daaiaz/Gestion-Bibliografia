Imports System.Data.SqlClient

Public Class frmMateria


    Dim vNuevo As Boolean = True
    Dim dvMateria As DataView

    Function DatosValidos() As Boolean

        If txtDescripcion.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar el nombre de la materia", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescripcion.Focus()
            Return False
        End If
        Return True

    End Function

    Sub LimpiarFormulario()
        'Limpiamos todos los controles
        nudMateria.Value = 0

        txtDescripcion.Clear()
        cboFacultad.SelectedItem = -1

        'Tiramos el foco al primer control EDITABLE por el usuario
        nudMateria.Focus()

        'Levantamos nuevamente la bandera
        vNuevo = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Try...Catch es una estructura para control de errores
        Try
            If DatosValidos() Then
                If vNuevo = True Then
                    EjecutarSQL("insert into materia values(@1,@2)", txtDescripcion.Text.Trim, cboFacultad.SelectedValue)
                    'Sino, significa que el registro ya existe y se debe actualizar
                Else
                    EjecutarSQL("Update materia SET nombre_materia = @1, id_facultad = @2 Where id_materia = @3", txtDescripcion.Text.Trim, cboFacultad.SelectedValue, CInt(nudMateria.Value))
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
                    EjecutarSQL("delete from materia where id_materia = @1", nudMateria.Value)
                    LimpiarFormulario()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellDoubleClick
        'Instanciamos un objeto del tipo DataTable, que es una tabla en memoria, en la cual volcaremos los datos de la base datos a nuestra aplicación
        Dim dtMateria As DataTable

        'dgvConsulta(0, e.RowIndex) --> Cero hace referencia a la primera columna, y e.RowIndex hace referencia a la fila seleccionada

        dtMateria = generar_datatabla("Select * from materia where id_materia=" & dgvConsulta(0, e.RowIndex).Value)
        'dtMateria = generar_datatabla("Select id_materia as Codigo, nombre_materia as Materia" & dgvConsulta(0, e.RowIndex).Value)

        'Si hay filas en la tabla en memoria
        If dtMateria.Rows.Count > 0 Then
            'Rows(0) hace referencia a la primera fila recuperada de la base de datos, que en este caso es la única, ya que por el where en la sentencia sql estamos recuperando un solo registro. Item("Columna") hace referencia a la columna que queremos recuperar de la tabla, tiene que coincidir con el nombre del campo en la tabla.
            nudMateria.Value = dtMateria.Rows(0).Item("id_materia")
            txtDescripcion.Text = dtMateria.Rows(0).Item("nombre_materia")


            'Para pasar a la primera pestaña (ABM) del tabControl
            tbcMateria.SelectedIndex = 0

            'La bandera que nos permite determinar si un registro es nuevo o no, en este caso como recuperamos datos de la bd asignamos false ya que sabemos el registro no es nuevo.
            vNuevo = False
        End If
    End Sub

    Private Sub tbcMateria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcMateria.SelectedIndexChanged
        'Si la pestaña seleccionada es 1, significa que está seleccionada la pestaña de consulta
        If tbcMateria.SelectedIndex = 1 Then
            'Asignamos el DataTable devuelto por el método "generar_datatabla" a la variable dvArticulos, conviertiéndolo primeramente en DataView
            dvMateria = generar_datatabla("SELECT m.id_materia AS Codigo, m.nombre_materia AS Materia, 
f.nombre_facultad AS Facultad FROM materia m JOIN facultad f 
ON m.id_facultad = f.id_facultad").DefaultView

            'Asignamos el DataView como origen de datos de la grilla
            dgvConsulta.DataSource = dvMateria
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Primeramente dejamos sin ningún filtro en caso de que ya se haya hecho uno con anterioridad
        dvMateria.RowFilter = ""

        'Preguntamos si el usuario ingresó algún valor en el TextBox de Búsqueda
        If txtBuscarDescripcion.Text.Trim() <> "" Then
            'Aplicamos un filtro dentro del DataView.
            'El operador like se utiliza con campos del tipo Texto y recurre al caracter % que usa como caracter comodín.
            dvMateria.RowFilter = "Materia like '%" & txtBuscarDescripcion.Text.Trim() & "%'"
        End If

        If nudMateria.Value > 0 Then
            If dvMateria.RowFilter = "" Then
                dvMateria.RowFilter = "id_materia = " & nudMateria.Value
            Else
                dvMateria.RowFilter = dvMateria.RowFilter & " AND id_materia = " & nudMateria.Value
            End If
        End If
    End Sub

    Private Sub txtBuscarDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarDescripcion.TextChanged
        'Click en el botón buscar
        'btnBuscar.PerformClick()
        btnBuscar_Click(Me, New EventArgs)
    End Sub

    Private Sub frmMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Determinamos el origen de datos del combo, haciendo uso de la función "generar_datatabla" que retorna un objeto del tipo DataTable
        'El método "generar_datatabla" recibe como parámetro un SELECT en forma de String

        cboFacultad.DataSource = generar_datatabla("select * from facultad")
        'Campo a mostrar
        cboFacultad.DisplayMember = "nombre_facultad"
        'Campo de la tabla que identifica al código
        cboFacultad.ValueMember = "id_facultad"

    End Sub

    Private Sub tbpABM_Click(sender As Object, e As EventArgs) Handles tbpABM.Click

    End Sub
End Class