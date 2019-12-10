Public Class frmCiudad

    Dim vNuevo As Boolean = True
    Dim dvCiudad As DataView

    Function DatosValidos() As Boolean

        If txtDescripcion.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar el nombre de la ciudad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescripcion.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If DatosValidos() Then
                If vNuevo = True Then
                    EjecutarSQL("insert into ciudad values(@1,@2)", txtDescripcion.Text.Trim, cboPais.SelectedValue)
                    'Sino, significa que el registro ya existe y se debe actualizar
                Else
                    EjecutarSQL("Update ciudad SET descripcion = @1, id_pais = @2 Where id_pais = @3", txtDescripcion.Text.Trim, cboPais.SelectedValue, CInt(nudCiudad.Value))
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
        'Limpiamos todos los controles
        nudCiudad.Value = 0

        txtDescripcion.Clear()
        cboPais.SelectedItem = -1

        'Tiramos el foco al primer control EDITABLE por el usuario
        nudCiudad.Focus()

        'Levantamos nuevamente la bandera
        vNuevo = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            'Para poder eliminar el registro ya tiene que existir en la bd, sé que ya existe cuando vNuevo = False porque se asignó este valor en el cellDoubleClick de la grilla.
            If MessageBox.Show("Está seguro que desea eliminar el registro?", "Sistema de Gestion Bibliografica", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                If vNuevo = False Then
                    EjecutarSQL("delete from ciudad where id_ciudad = @1", nudCiudad.Value)
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

    Private Sub btnPais_Click(sender As Object, e As EventArgs) Handles btnPais.Click
        frmPais.Show()
    End Sub

    Private Sub tbcCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcCiudad.SelectedIndexChanged
        'Si la pestaña seleccionada es 1, significa que está seleccionada la pestaña de consulta
        If tbcCiudad.SelectedIndex = 1 Then
            'Asignamos el DataTable devuelto por el método "generar_datatabla" a la variable dvArticulos, conviertiéndolo primeramente en DataView
            dvCiudad = generar_datatabla("SELECT c.id_ciudad AS Codigo, c.descripcion AS Descripcion, 
p.nombre_pais AS Pais FROM pais m JOIN pais p 
ON p.id_pais = p.id_pais").DefaultView

            'Asignamos el DataView como origen de datos de la grilla
            dgvConsulta.DataSource = dvCiudad
        End If
    End Sub

    Private Sub frmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Determinamos el origen de datos del combo, haciendo uso de la función "generar_datatabla" que retorna un objeto del tipo DataTable
        'El método "generar_datatabla" recibe como parámetro un SELECT en forma de String

        cboPais.DataSource = generar_datatabla("select * from pais")
        'Campo a mostrar
        cboPais.DisplayMember = "descripcion"
        'Campo de la tabla que identifica al código
        cboPais.ValueMember = "id_pais"
    End Sub

    Private Sub txtBuscarDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarDescripcion.TextChanged

        btnBuscar_Click(Me, New EventArgs)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Primeramente dejamos sin ningún filtro en caso de que ya se haya hecho uno con anterioridad
        dvCiudad.RowFilter = ""

        'Preguntamos si el usuario ingresó algún valor en el TextBox de Búsqueda
        If txtBuscarDescripcion.Text.Trim() <> "" Then
            'Aplicamos un filtro dentro del DataView.
            'El operador like se utiliza con campos del tipo Texto y recurre al caracter % que usa como caracter comodín.
            dvCiudad.RowFilter = "descripcion like '%" & txtBuscarDescripcion.Text.Trim() & "%'"
        End If

        If nudCiudad.Value > 0 Then
            If dvCiudad.RowFilter = "" Then
                dvCiudad.RowFilter = "id_ciudad = " & nudCiudad.Value
            Else
                dvCiudad.RowFilter = dvCiudad.RowFilter & " AND id_ciudad = " & nudCiudad.Value
            End If
        End If
    End Sub
End Class