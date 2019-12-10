<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPpal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPpal))
        Me.mnuMenuPpal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniMateria = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniLibro = New System.Windows.Forms.ToolStripMenuItem()
        Me.BibliografíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ntiNotifcacion = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mnuMenuPpal.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuPpal
        '
        Me.mnuMenuPpal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMenuPpal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.mnuMenuPpal.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuPpal.Name = "mnuMenuPpal"
        Me.mnuMenuPpal.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuMenuPpal.Size = New System.Drawing.Size(867, 24)
        Me.mnuMenuPpal.TabIndex = 0
        Me.mnuMenuPpal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MateriaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'MateriaToolStripMenuItem
        '
        Me.MateriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniMateria, Me.mniLibro, Me.BibliografíaToolStripMenuItem})
        Me.MateriaToolStripMenuItem.Name = "MateriaToolStripMenuItem"
        Me.MateriaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MateriaToolStripMenuItem.Text = "Programas"
        '
        'mniMateria
        '
        Me.mniMateria.Name = "mniMateria"
        Me.mniMateria.Size = New System.Drawing.Size(180, 22)
        Me.mniMateria.Text = "Materia"
        '
        'mniLibro
        '
        Me.mniLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mniLibro.Name = "mniLibro"
        Me.mniLibro.Size = New System.Drawing.Size(180, 22)
        Me.mniLibro.Text = "Libro"
        '
        'BibliografíaToolStripMenuItem
        '
        Me.BibliografíaToolStripMenuItem.Name = "BibliografíaToolStripMenuItem"
        Me.BibliografíaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BibliografíaToolStripMenuItem.Text = "Bibliografía"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 507)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(867, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsVersion
        '
        Me.stsVersion.Name = "stsVersion"
        Me.stsVersion.Size = New System.Drawing.Size(143, 17)
        Me.stsVersion.Text = "Versión del sistema 1.0.0.1"
        '
        'ntiNotifcacion
        '
        Me.ntiNotifcacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ntiNotifcacion.Text = "Ayuda"
        Me.ntiNotifcacion.Visible = True
        '
        'frmMenuPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(867, 529)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mnuMenuPpal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenuPpal
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMenuPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Bibliografías"
        Me.mnuMenuPpal.ResumeLayout(False)
        Me.mnuMenuPpal.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenuPpal As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MateriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stsVersion As ToolStripStatusLabel
    Friend WithEvents mniMateria As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ntiNotifcacion As NotifyIcon
    Friend WithEvents mniLibro As ToolStripMenuItem
    Friend WithEvents BibliografíaToolStripMenuItem As ToolStripMenuItem
End Class
