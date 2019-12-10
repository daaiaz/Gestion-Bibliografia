Public Class frmIdioma
    Dim vNuevo As Boolean = True
    Dim dvIdioma As DataView

    Function DatosValidos() As Boolean

        If txtDescripcion.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar la descripción del Idioma", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescripcion.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If DatosValidos() Then
                If vNuevo = True Then
                    EjecutarSQL("insert into idioma values(@1)", txtDescripcion.Text.Trim)

                Else
                    EjecutarSQL("Update idioma SET descripcion = @1 Where id_idioma = @2", txtDescripcion.Text.Trim, CInt(nudIdioma.Value))
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
        nudIdioma.Value = 0

        txtDescripcion.Clear()
        nudIdioma.Focus()

        'Levantamos nuevamente la bandera
        vNuevo = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            'Para poder eliminar el registro ya tiene que existir en la bd, sé que ya existe cuando vNuevo = False porque se asignó este valor en el cellDoubleClick de la grilla.
            If MessageBox.Show("Está seguro que desea eliminar el registro?", "Sistema de Gestion Bibliografica", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                If vNuevo = False Then
                    EjecutarSQL("delete from idioma where id_idioma = @1", nudIdioma.Value)
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
        dvIdioma.RowFilter = ""

        'Preguntamos si el usuario ingresó algún valor en el TextBox de Búsqueda
        If txtBuscarDescripcion.Text.Trim() <> "" Then
            'Aplicamos un filtro dentro del DataView.
            'El operador like se utiliza con campos del tipo Texto y recurre al caracter % que usa como caracter comodín.
            dvIdioma.RowFilter = "descripcion like '%" & txtBuscarDescripcion.Text.Trim() & "%'"
        End If

        If nudIdioma.Value > 0 Then
            If dvIdioma.RowFilter = "" Then
                dvIdioma.RowFilter = "id_idioma = " & nudIdioma.Value
            Else
                dvIdioma.RowFilter = dvIdioma.RowFilter & " AND id_idioma = " & nudIdioma.Value
            End If
        End If
    End Sub

    Private Sub txtBuscarDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarDescripcion.TextChanged
        btnBuscar_Click(Me, New EventArgs)
    End Sub

    Private Sub tbcIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcIdioma.SelectedIndexChanged
        'Si la pestaña seleccionada es 1, significa que está seleccionada la pestaña de consulta
        If tbcIdioma.SelectedIndex = 1 Then
            'Asignamos el DataTable devuelto por el método "generar_datatabla" a la variable dvArticulos, conviertiéndolo primeramente en DataView
            dvIdioma = generar_datatabla("SELECT c.id_idioma AS Codigo, c.descripcion AS Descripcion FROM idioma c ").DefaultView

            'Asignamos el DataView como origen de datos de la grilla
            dgvConsulta.DataSource = dvIdioma
        End If
    End Sub
End Class