﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMateria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMateria))
        Me.tbcMateria = New System.Windows.Forms.TabControl()
        Me.tbpABM = New System.Windows.Forms.TabPage()
        Me.nudMateria = New System.Windows.Forms.NumericUpDown()
        Me.lblFacultad = New System.Windows.Forms.Label()
        Me.cboFacultad = New System.Windows.Forms.ComboBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbxBotonera = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcionMateria = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscarDescripcion = New System.Windows.Forms.TextBox()
        Me.lblBuscarDescripcion = New System.Windows.Forms.Label()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.tbcMateria.SuspendLayout()
        Me.tbpABM.SuspendLayout()
        CType(Me.nudMateria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBotonera.SuspendLayout()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcMateria
        '
        Me.tbcMateria.Controls.Add(Me.tbpABM)
        Me.tbcMateria.Controls.Add(Me.tbpConsulta)
        Me.tbcMateria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcMateria.Location = New System.Drawing.Point(0, 0)
        Me.tbcMateria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbcMateria.Name = "tbcMateria"
        Me.tbcMateria.SelectedIndex = 0
        Me.tbcMateria.Size = New System.Drawing.Size(660, 348)
        Me.tbcMateria.TabIndex = 0
        '
        'tbpABM
        '
        Me.tbpABM.Controls.Add(Me.nudMateria)
        Me.tbpABM.Controls.Add(Me.lblFacultad)
        Me.tbpABM.Controls.Add(Me.cboFacultad)
        Me.tbpABM.Controls.Add(Me.lblTitulo)
        Me.tbpABM.Controls.Add(Me.gbxBotonera)
        Me.tbpABM.Controls.Add(Me.txtDescripcion)
        Me.tbpABM.Controls.Add(Me.lblDescripcionMateria)
        Me.tbpABM.Controls.Add(Me.lblId)
        Me.tbpABM.Location = New System.Drawing.Point(4, 25)
        Me.tbpABM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbpABM.Name = "tbpABM"
        Me.tbpABM.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbpABM.Size = New System.Drawing.Size(652, 319)
        Me.tbpABM.TabIndex = 0
        Me.tbpABM.Text = "ABM"
        Me.tbpABM.UseVisualStyleBackColor = True
        '
        'nudMateria
        '
        Me.nudMateria.Enabled = False
        Me.nudMateria.Location = New System.Drawing.Point(136, 55)
        Me.nudMateria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudMateria.Name = "nudMateria"
        Me.nudMateria.Size = New System.Drawing.Size(160, 22)
        Me.nudMateria.TabIndex = 51
        '
        'lblFacultad
        '
        Me.lblFacultad.AutoSize = True
        Me.lblFacultad.Location = New System.Drawing.Point(23, 138)
        Me.lblFacultad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacultad.Name = "lblFacultad"
        Me.lblFacultad.Size = New System.Drawing.Size(62, 17)
        Me.lblFacultad.TabIndex = 14
        Me.lblFacultad.Text = "Facultad"
        '
        'cboFacultad
        '
        Me.cboFacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFacultad.FormattingEnabled = True
        Me.cboFacultad.Location = New System.Drawing.Point(133, 135)
        Me.cboFacultad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboFacultad.Name = "cboFacultad"
        Me.cboFacultad.Size = New System.Drawing.Size(299, 24)
        Me.cboFacultad.TabIndex = 13
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(293, 15)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(108, 25)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "MATERIA"
        '
        'gbxBotonera
        '
        Me.gbxBotonera.Controls.Add(Me.btnAgregar)
        Me.gbxBotonera.Controls.Add(Me.btnEliminar)
        Me.gbxBotonera.Controls.Add(Me.btnCancelar)
        Me.gbxBotonera.Location = New System.Drawing.Point(27, 170)
        Me.gbxBotonera.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxBotonera.Name = "gbxBotonera"
        Me.gbxBotonera.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxBotonera.Size = New System.Drawing.Size(569, 80)
        Me.gbxBotonera.TabIndex = 11
        Me.gbxBotonera.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(85, 26)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 28)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(235, 26)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(392, 26)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(136, 96)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(297, 22)
        Me.txtDescripcion.TabIndex = 5
        '
        'lblDescripcionMateria
        '
        Me.lblDescripcionMateria.AutoSize = True
        Me.lblDescripcionMateria.Location = New System.Drawing.Point(23, 96)
        Me.lblDescripcionMateria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcionMateria.Name = "lblDescripcionMateria"
        Me.lblDescripcionMateria.Size = New System.Drawing.Size(82, 17)
        Me.lblDescripcionMateria.TabIndex = 6
        Me.lblDescripcionMateria.Text = "Descripción"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(23, 58)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(70, 17)
        Me.lblId.TabIndex = 4
        Me.lblId.Text = "Id Materia"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.btnBuscar)
        Me.tbpConsulta.Controls.Add(Me.txtBuscarDescripcion)
        Me.tbpConsulta.Controls.Add(Me.lblBuscarDescripcion)
        Me.tbpConsulta.Controls.Add(Me.dgvConsulta)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 25)
        Me.tbpConsulta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbpConsulta.Size = New System.Drawing.Size(652, 319)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(509, 18)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(133, 46)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscarDescripcion
        '
        Me.txtBuscarDescripcion.Location = New System.Drawing.Point(207, 21)
        Me.txtBuscarDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscarDescripcion.Name = "txtBuscarDescripcion"
        Me.txtBuscarDescripcion.Size = New System.Drawing.Size(283, 22)
        Me.txtBuscarDescripcion.TabIndex = 5
        '
        'lblBuscarDescripcion
        '
        Me.lblBuscarDescripcion.AutoSize = True
        Me.lblBuscarDescripcion.Location = New System.Drawing.Point(43, 25)
        Me.lblBuscarDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuscarDescripcion.Name = "lblBuscarDescripcion"
        Me.lblBuscarDescripcion.Size = New System.Drawing.Size(155, 17)
        Me.lblBuscarDescripcion.TabIndex = 4
        Me.lblBuscarDescripcion.Text = "Buscar por Descripción"
        '
        'dgvConsulta
        '
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvConsulta.Location = New System.Drawing.Point(3, 100)
        Me.dgvConsulta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.RowTemplate.Height = 24
        Me.dgvConsulta.Size = New System.Drawing.Size(646, 217)
        Me.dgvConsulta.TabIndex = 0
        '
        'frmMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 348)
        Me.Controls.Add(Me.tbcMateria)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMateria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materia"
        Me.tbcMateria.ResumeLayout(False)
        Me.tbpABM.ResumeLayout(False)
        Me.tbpABM.PerformLayout()
        CType(Me.nudMateria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBotonera.ResumeLayout(False)
        Me.tbpConsulta.ResumeLayout(False)
        Me.tbpConsulta.PerformLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcMateria As TabControl
    Friend WithEvents tbpABM As TabPage
    Friend WithEvents lblFacultad As Label
    Friend WithEvents cboFacultad As ComboBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbxBotonera As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcionMateria As Label
    Friend WithEvents lblId As Label
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscarDescripcion As TextBox
    Friend WithEvents lblBuscarDescripcion As Label
    Friend WithEvents dgvConsulta As DataGridView
    Friend WithEvents nudMateria As NumericUpDown
End Class
