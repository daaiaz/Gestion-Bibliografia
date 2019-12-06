Imports System.Data.SqlClient
Public Class frmBibliografia

    Dim vNuevo As Boolean = True
    Dim Transac As SqlTransaction
    Dim vBibliografiaID As Integer

    Function DatosValidos() As Boolean

        If cboLibro.Text = "" Then
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Se hace el commit de la transacción. Acá recién se confirma en la BD

        If MessageBox.Show("¿Está seguro de confirmar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ConfirmarTransaccion(Transac)
            LimpiarFormulario()
            LimpiarIngresoArticulo()
        End If
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

    Private Sub btnAgregarLibro_Click(sender As Object, e As EventArgs) Handles btnAgregarLibro.Click

        'dgvDetalleBibliografia.Rows.Add()

        'Dim nf As Short = dgvDetalleBibliografia.Rows.Count - 1

        'dgvDetalleBibliografia(0, nf).Value = nudBibliografiaId.Text
        'dgvDetalleBibliografia(1, nf).Value = cboLibro.Text
        'dgvDetalleBibliografia(2, nf).Value = cboEstado.Text





        'Try
        '    If DatosValidos() Then
        '        If vNuevo = True Then
        '            EjecutarSQL("insert into bibliografia_detalle values(@1,@2,@3)", nudBibliografiaId.Value, cboLibro.SelectedValue, cboEstado.SelectedValue)
        '            'Sino, significa que el registro ya existe y se debe actualizar
        '        Else
        '            EjecutarSQL("Update bibliografia_detalle SET id_libro = @1, id_estado = @2 Where id_bibliografia_detalle = @3", cboLibro.SelectedValue, cboEstado.SelectedValue)
        '        End If

        '        MessageBox.Show("Registro guardado con éxito!!!")
        '        LimpiarFormulario()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    'Cerrar la conexión
        '    conexion.Close()
        'End Try

        Try
            'Validamos que se haya seleccionado un Auto
            If cboLibro.Text = "" Then
                cboLibro.Focus()
                MsgBox("Debe seleccionar el Libro.")
                Exit Sub 'Sirve para salir o abandonar una sub rutina. Es parecido al RETURN dentro de una función
            End If

            'vBibliografiaID = TraerValor("select max(cod_bibliografia) from bibliografia", Transac)

            'Como pasó la validación anterior insertamos el registro correspondiente en la tabla Detalle (DetalleVenta)
            EjecutarSQL("insert into bibliografia_detalle values (@1,@2,@3)", cboLibro.SelectedValue, cboEstado.SelectedValue, nudBibliografiaId.Value)

            'Se muestra lo agregado en la grilla del detalle
            ActualizarGrilla()

            'Limpiamos los controles de la sección de Artículos
            LimpiarIngresoArticulo()

        Catch ex As Exception
            MsgBox(ex.Message)

            'Si se produjo alguna excepción, revertimos todo anulando la transacción.
            'AnularTransaccion(Transac)
        End Try



    End Sub

    Private Sub LimpiarIngresoArticulo()
        cboEstado.SelectedIndex = -1
        cboLibro.SelectedIndex = -1

    End Sub

    Private Sub ActualizarGrilla()
        'Se carga la grilla
        'dgvDetalleBibliografia.DataSource = generar_datatabla("select * from bibliografia_detalle where id_bibliografia = " & vBibliografiaID)
        dgvDetalleBibliografia.DataSource = generar_datatabla("SELECT l.titulo AS Libro, e.descripcion AS Estado FROM bibliografia_detalle bd JOIN libro l ON bd.id_libro = l.id_libro JOIN estado e ON bd.id_estado = e.id_estado")
    End Sub

    Private Sub dgvDetalleBibliografia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleBibliografia.CellClick

        'Dim I As Integer = dgvDetalleBibliografia.CurrentRow.Index

        'nudBibliografiaId.Value = dgvDetalleBibliografia(0, I).Value
        'cboLibro.Text = dgvDetalleBibliografia(1, I).Value
        'cboEstado.Text = dgvDetalleBibliografia(2, I).Value
    End Sub
End Class