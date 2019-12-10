<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPais))
        Me.tbcPais = New System.Windows.Forms.TabControl()
        Me.tbpABM = New System.Windows.Forms.TabPage()
        Me.nudPais = New System.Windows.Forms.NumericUpDown()
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
        Me.tbcPais.SuspendLayout()
        Me.tbpABM.SuspendLayout()
        CType(Me.nudPais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBotonera.SuspendLayout()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcPais
        '
        Me.tbcPais.Controls.Add(Me.tbpABM)
        Me.tbcPais.Controls.Add(Me.tbpConsulta)
        Me.tbcPais.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcPais.Location = New System.Drawing.Point(0, 0)
        Me.tbcPais.Margin = New System.Windows.Forms.Padding(2)
        Me.tbcPais.Name = "tbcPais"
        Me.tbcPais.SelectedIndex = 0
        Me.tbcPais.Size = New System.Drawing.Size(477, 288)
        Me.tbcPais.TabIndex = 1
        '
        'tbpABM
        '
        Me.tbpABM.BackColor = System.Drawing.Color.Bisque
        Me.tbpABM.Controls.Add(Me.nudPais)
        Me.tbpABM.Controls.Add(Me.lblTitulo)
        Me.tbpABM.Controls.Add(Me.gbxBotonera)
        Me.tbpABM.Controls.Add(Me.txtDescripcion)
        Me.tbpABM.Controls.Add(Me.lblDescripcionMateria)
        Me.tbpABM.Controls.Add(Me.lblId)
        Me.tbpABM.Location = New System.Drawing.Point(4, 22)
        Me.tbpABM.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpABM.Name = "tbpABM"
        Me.tbpABM.Padding = New System.Windows.Forms.Padding(2)
        Me.tbpABM.Size = New System.Drawing.Size(469, 262)
        Me.tbpABM.TabIndex = 0
        Me.tbpABM.Text = "ABM"
        '
        'nudPais
        '
        Me.nudPais.Enabled = False
        Me.nudPais.Location = New System.Drawing.Point(102, 45)
        Me.nudPais.Name = "nudPais"
        Me.nudPais.Size = New System.Drawing.Size(120, 20)
        Me.nudPais.TabIndex = 51
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(192, 11)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(50, 20)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "PAIS"
        '
        'gbxBotonera
        '
        Me.gbxBotonera.Controls.Add(Me.btnAgregar)
        Me.gbxBotonera.Controls.Add(Me.btnEliminar)
        Me.gbxBotonera.Controls.Add(Me.btnCancelar)
        Me.gbxBotonera.Location = New System.Drawing.Point(20, 138)
        Me.gbxBotonera.Name = "gbxBotonera"
        Me.gbxBotonera.Size = New System.Drawing.Size(427, 65)
        Me.gbxBotonera.TabIndex = 11
        Me.gbxBotonera.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(64, 21)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(176, 21)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(294, 21)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(102, 78)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(224, 20)
        Me.txtDescripcion.TabIndex = 5
        '
        'lblDescripcionMateria
        '
        Me.lblDescripcionMateria.AutoSize = True
        Me.lblDescripcionMateria.Location = New System.Drawing.Point(17, 78)
        Me.lblDescripcionMateria.Name = "lblDescripcionMateria"
        Me.lblDescripcionMateria.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcionMateria.TabIndex = 6
        Me.lblDescripcionMateria.Text = "Descripción"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(17, 47)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(39, 13)
        Me.lblId.TabIndex = 4
        Me.lblId.Text = "Id Pais"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.BackColor = System.Drawing.Color.Bisque
        Me.tbpConsulta.Controls.Add(Me.btnBuscar)
        Me.tbpConsulta.Controls.Add(Me.txtBuscarDescripcion)
        Me.tbpConsulta.Controls.Add(Me.lblBuscarDescripcion)
        Me.tbpConsulta.Controls.Add(Me.dgvConsulta)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsulta.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(2)
        Me.tbpConsulta.Size = New System.Drawing.Size(469, 262)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(362, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 37)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscarDescripcion
        '
        Me.txtBuscarDescripcion.Location = New System.Drawing.Point(143, 21)
        Me.txtBuscarDescripcion.Name = "txtBuscarDescripcion"
        Me.txtBuscarDescripcion.Size = New System.Drawing.Size(213, 20)
        Me.txtBuscarDescripcion.TabIndex = 5
        '
        'lblBuscarDescripcion
        '
        Me.lblBuscarDescripcion.AutoSize = True
        Me.lblBuscarDescripcion.Location = New System.Drawing.Point(20, 24)
        Me.lblBuscarDescripcion.Name = "lblBuscarDescripcion"
        Me.lblBuscarDescripcion.Size = New System.Drawing.Size(117, 13)
        Me.lblBuscarDescripcion.TabIndex = 4
        Me.lblBuscarDescripcion.Text = "Buscar por Descripción"
        '
        'dgvConsulta
        '
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvConsulta.Location = New System.Drawing.Point(2, 84)
        Me.dgvConsulta.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.RowTemplate.Height = 24
        Me.dgvConsulta.Size = New System.Drawing.Size(465, 176)
        Me.dgvConsulta.TabIndex = 0
        '
        'frmPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 288)
        Me.Controls.Add(Me.tbcPais)
        Me.Name = "frmPais"
        Me.Text = "frmPais"
        Me.tbcPais.ResumeLayout(False)
        Me.tbpABM.ResumeLayout(False)
        Me.tbpABM.PerformLayout()
        CType(Me.nudPais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBotonera.ResumeLayout(False)
        Me.tbpConsulta.ResumeLayout(False)
        Me.tbpConsulta.PerformLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcPais As TabControl
    Friend WithEvents tbpABM As TabPage
    Friend WithEvents nudPais As NumericUpDown
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
End Class
