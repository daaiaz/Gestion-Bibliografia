Imports System.Data.SqlClient
Public Class frmBibliografia

    Dim vNuevo As Boolean = True
    Dim Transac As SqlTransaction
    Dim vBibliografiaID As Integer

    Dim vLibroID As Integer


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

        'cboMateria.SelectedIndex = -1
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("¿Está seguro de eliminar el libro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Try
                'Borramos el detalle seleccionado
                EjecutarSQL("delete from bibliografia_detalle where id_bibliografia = @1 AND id_libro = @2", Transac, vBibliografiaID, vLibroID)

                'Reponemos la cantidad eliminada en la Existencia del Artículo
                'EjecutarSQL("Update Articulo set existencia = existencia + @1 where ArticuloID = @2", Transac, vCantidad, vArticuloID)

                'Actualizamos el monto de nuestra cabecera, restando el importe del detalle que hemos eliminado
                'EjecutarSQL("update Venta set MontoVenta = MontoVenta - @1 where VentaID = @2", Transac, VImporteDetalle, vVentaID)

                'Se muestra lo agregado en la grilla del detalle
                ActualizarGrilla()

                'Mostramos el total actual. CDec convierte al tipo DECIMAL. Format en este caso nos ayuda a visualizar el importe con separador de miles. En este caso restamos el importe del detalle
                'lblTotalVenta.Text = Format((CDec(lblTotalVenta.Text) - VImporteDetalle), "###,###,###")


            Catch ex As Exception
                MessageBox.Show("Error al momento de eliminar libro" & vbNewLine & ex.Message())
                AnularTransaccion(Transac)
            End Try
        End If
        LimpiarFormulario()
        'Limpiamos todos los controles
        nudBibliografiaId.Value = 0

        cboMateria.SelectedItem = -1
        'txtComentario.Clear()
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
            EjecutarSQL("insert into bibliografia_detalle values (@1,@2,@3,@4,@5)", cboLibro.SelectedValue, cboEstado.SelectedValue, 0, cboMateria.SelectedValue, dtpFechaCreacion.Value)

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

    Sub LimpiarFormulario()
        'Limpiamos todos los controles
        'nudBibliografiaId.Value = 0
        cboMateria.SelectedItem = -1
        cboMateria.SelectedIndex = -1
        'txtComentario.Clear()
        cboLibro.SelectedItem = -1
        cboEstado.SelectedItem = -1

        For h As Integer = dgvDetalleBibliografia.RowCount - 1 To 0 Step -1
            'Por cada iteración se declara una variable del tipo FILA, al cual se le va asignando cada una de las filas de la grilla
            Dim row As DataGridViewRow = dgvDetalleBibliografia.Rows(h)
            'Después de la asignación, se procede a borrar la fila actual. Fijense que el método Remove de un DataGridView espera un parámetro del tipo DataGridViewRow
            dgvDetalleBibliografia.Rows.Remove(row)
        Next


        'Tiramos el foco al primer control EDITABLE por el usuario
        'nudBibliografiaId.Focus()

        'btnHabilitarDetalle.Enabled = True


        'Inhabilitamos los botones para Aceptar y Cancelar
        'btnAceptar.Enabled = False
        'btnCancelar.Enabled = False


    End Sub

    Private Sub LimpiarIngresoArticulo()
        cboEstado.SelectedIndex = -1
        cboLibro.SelectedIndex = -1

    End Sub

    Private Sub ActualizarGrilla()
        'Se carga la grilla
        'dgvDetalleBibliografia.DataSource = generar_datatabla("select * from bibliografia_detalle where id_bibliografia = " & vBibliografiaID)if  

        'Dim sql As String
        'Dim materia As Object

        'materia = cboMateria.SelectedValue
        'Sql = "SELECT l.titulo AS Libro, e.descripcion AS Estado FROM bibliografia_detalle bd JOIN libro l ON bd.id_libro = l.id_libro JOIN estado e ON bd.id_estado = e.id_estado WHERE id_materia = " & Convert.ToString(materia)

        'If (cboMateria.SelectedIndex > -1) Then
        'DetalleBibliografia.DataSource = generar_datatabla(sql, Transac)
        'End If

        dgvDetalleBibliografia.DataSource = generar_datatabla("SELECT m.nombre_materia AS Materia, l.id_libro AS CodLibro, l.titulo AS Libro, e.descripcion AS Estado FROM bibliografia_detalle bd JOIN libro l ON bd.id_libro = l.id_libro JOIN materia m ON bd.id_materia = m.id_materia JOIN estado e ON bd.id_estado = e.id_estado", Transac)

    End Sub

    Private Sub dgvDetalleBibliografia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleBibliografia.CellClick

        'Dim I As Integer = dgvDetalleBibliografia.CurrentRow.Index

        'nudBibliografiaId.Value = dgvDetalleBibliografia(0, I).Value
        'cboLibro.Text = dgvDetalleBibliografia(1, I).Value
        'cboEstado.Text = dgvDetalleBibliografia(2, I).Value
    End Sub

    Private Sub tbpABM_Click(sender As Object, e As EventArgs) Handles tbpABM.Click

    End Sub

    Private Sub gbxLibro_Enter(sender As Object, e As EventArgs) Handles gbxLibro.Enter

    End Sub

    Private Sub cboMateria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMateria.SelectedIndexChanged
        'LimpiarFormulario()
        'ActualizarGrilla()
    End Sub
End Class