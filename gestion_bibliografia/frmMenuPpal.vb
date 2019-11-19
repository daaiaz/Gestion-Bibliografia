Public Class frmMenuPpal
    Private Sub mniMateria_Click(sender As Object, e As EventArgs) Handles mniMateria.Click

        My.Forms.frmMateria.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If MessageBox.Show("¿Está seguro de Salir de la Aplicación?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmMenuPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ntiNotifcacion.BalloonTipText = "Bienvenido al Sistema de Gestión de Bibliografías"
        'ntiNotifcacion.BalloonTipTitle = Me.Text
        'ntiNotifcacion.BalloonTipIcon = ToolTipIcon.Info

        'ntiNotifcacion.ShowBalloonTip(3000)
    End Sub

    Private Sub mniLibro_Click(sender As Object, e As EventArgs) Handles mniLibro.Click
        My.Forms.frmLibro.Show()
    End Sub
End Class