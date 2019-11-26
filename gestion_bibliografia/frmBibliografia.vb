Imports System.Data.SqlClient
Public Class frmBibliografia

    Dim vNuevo As Boolean = True

    Function DatosValidos() As Boolean

        If cboLibro.SelectedValue = "" Then
            MessageBox.Show("Debe seleccionar el libro para agregar a la bibliografia", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboLibro.Focus()
            Return False
        End If
        Return True

    End Function
    Private Sub frmBibliografia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Determinamos el origen de datos del combo, haciendo uso de la función "generar_datatabla" que retorna un objeto del tipo DataTable
        'El método "generar_datatabla" recibe como parámetro un SELECT en forma de String

        cboMateria.DataSource = generar_datatabla("select * from materia")
        'Campo a mostrar
        cboMateria.DisplayMember = "nombre_materia"
        'Campo de la tabla que identifica al código
        cboMateria.ValueMember = "id_materia"

        'Libro
        cboLibro.DataSource = generar_datatabla("select * from libro")
        cboLibro.DisplayMember = "titulo"
        cboLibro.ValueMember = "id_libro"

        'Estado del libro en la bibliografia
        cboEstado.DataSource = generar_datatabla("select * from estado")
        cboEstado.DisplayMember = "descripcion"
        cboEstado.ValueMember = "id_estado"
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            If DatosValidos() Then
                If vNuevo = True Then
                    'Rebizar los parametros no puedo comparar con mi bd
                    EjecutarSQL("insert into bibliografia values(@1,@2,@3,@4)", cboMateria.SelectedValue, dtpFechaCreacion.Value, cboEstado.SelectedValue, txtComentario.Text.Trim)

                Else
                    EjecutarSQL("Update bibliografia SET id_materia = @1, fecha_creacion = @2 id_usuario = @3 comentario = @4 Where id_bibliografia = @5", cboMateria.SelectedValue, cboMateria.SelectedValue, cboEstado.SelectedValue, txtComentario.Text.Trim, CInt(nudBibliografiaId.Value))
                End If

                MessageBox.Show("Registro guardado con éxito!!!")
                '   LimpiarFormulario()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            'Cerrar la conexión
            conexion.Close()
        End Try
    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            'Para poder eliminar el registro ya tiene que existir en la bd, sé que ya existe cuando vNuevo = False porque se asignó este valor en el cellDoubleClick de la grilla.
            If MessageBox.Show("Está seguro que desea eliminar el registro?", "Sistema de Gestion Bibliografica", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                If vNuevo = False Then
                    EjecutarSQL("delete from bibliografia where id_bibliografia = @1", nudBibliografiaId.Value)
                    LimpiarFormulario()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Sub LimpiarFormulario()
        'Limpiamos todos los controles
        nudBibliografiaId.Value = 0

        cboMateria.SelectedItem = -1
        txtComentario.Clear()
        cboLibro.SelectedItem = -1
        cboEstado.SelectedItem = -1

        'Tiramos el foco al primer control EDITABLE por el usuario
        nudBibliografiaId.Focus()

        'Levantamos nuevamente la bandera
        vNuevo = True
    End Sub

End Class