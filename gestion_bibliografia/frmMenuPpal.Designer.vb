﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ntiNotifcacion = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BibliografíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuMenuPpal.Size = New System.Drawing.Size(800, 28)
        Me.mnuMenuPpal.TabIndex = 0
        Me.mnuMenuPpal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MateriaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'MateriaToolStripMenuItem
        '
        Me.MateriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniMateria, Me.LibroToolStripMenuItem, Me.BibliografíaToolStripMenuItem})
        Me.MateriaToolStripMenuItem.Name = "MateriaToolStripMenuItem"
        Me.MateriaToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.MateriaToolStripMenuItem.Text = "Programas"
        '
        'mniMateria
        '
        Me.mniMateria.Name = "mniMateria"
        Me.mniMateria.Size = New System.Drawing.Size(216, 26)
        Me.mniMateria.Text = "Materia"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 25)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsVersion
        '
        Me.stsVersion.Name = "stsVersion"
        Me.stsVersion.Size = New System.Drawing.Size(181, 20)
        Me.stsVersion.Text = "Versión del sistema 1.0.0.1"
        '
        'ntiNotifcacion
        '
        Me.ntiNotifcacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ntiNotifcacion.Text = "Ayuda"
        Me.ntiNotifcacion.Visible = True
        '
        'LibroToolStripMenuItem
        '
        Me.LibroToolStripMenuItem.Enabled = False
        Me.LibroToolStripMenuItem.Name = "LibroToolStripMenuItem"
        Me.LibroToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.LibroToolStripMenuItem.Text = "Libro"
        '
        'BibliografíaToolStripMenuItem
        '
        Me.BibliografíaToolStripMenuItem.Enabled = False
        Me.BibliografíaToolStripMenuItem.Name = "BibliografíaToolStripMenuItem"
        Me.BibliografíaToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.BibliografíaToolStripMenuItem.Text = "Bibliografía"
        '
        'frmMenuPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mnuMenuPpal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenuPpal
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
    Friend WithEvents LibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BibliografíaToolStripMenuItem As ToolStripMenuItem
End Class
