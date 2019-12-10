<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBibliografia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBibliografia))
        Me.tbcBibliografia = New System.Windows.Forms.TabControl()
        Me.tbpABM = New System.Windows.Forms.TabPage()
        Me.dgvDetalleBibliografia = New System.Windows.Forms.DataGridView()
        Me.gbxLibro = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.lblLibro = New System.Windows.Forms.Label()
        Me.btnAgregarLibro = New System.Windows.Forms.Button()
        Me.cboLibro = New System.Windows.Forms.ComboBox()
        Me.dtpFechaCreacion = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.cboMateria = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscarMateria = New System.Windows.Forms.TextBox()
        Me.lblBuscarMateria = New System.Windows.Forms.Label()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.tbcBibliografia.SuspendLayout()
        Me.tbpABM.SuspendLayout()
        CType(Me.dgvDetalleBibliografia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxLibro.SuspendLayout()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcBibliografia
        '
        Me.tbcBibliografia.Controls.Add(Me.tbpABM)
        Me.tbcBibliografia.Controls.Add(Me.tbpConsulta)
        Me.tbcBibliografia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcBibliografia.Location = New System.Drawing.Point(0, 0)
        Me.tbcBibliografia.Multiline = True
        Me.tbcBibliografia.Name = "tbcBibliografia"
        Me.tbcBibliografia.SelectedIndex = 0
        Me.tbcBibliografia.Size = New System.Drawing.Size(597, 501)
        Me.tbcBibliografia.TabIndex = 0
        '
        'tbpABM
        '
        Me.tbpABM.Controls.Add(Me.btnCancelar)
        Me.tbpABM.Controls.Add(Me.dgvDetalleBibliografia)
        Me.tbpABM.Controls.Add(Me.gbxLibro)
        Me.tbpABM.Controls.Add(Me.dtpFechaCreacion)
        Me.tbpABM.Controls.Add(Me.lblFecha)
        Me.tbpABM.Controls.Add(Me.lblMateria)
        Me.tbpABM.Controls.Add(Me.cboMateria)
        Me.tbpABM.Location = New System.Drawing.Point(4, 22)
        Me.tbpABM.Name = "tbpABM"
        Me.tbpABM.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpABM.Size = New System.Drawing.Size(589, 475)
        Me.tbpABM.TabIndex = 0
        Me.tbpABM.Text = "ABM"
        Me.tbpABM.UseVisualStyleBackColor = True
        '
        'dgvDetalleBibliografia
        '
        Me.dgvDetalleBibliografia.AllowUserToAddRows = False
        Me.dgvDetalleBibliografia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleBibliografia.Location = New System.Drawing.Point(33, 201)
        Me.dgvDetalleBibliografia.Name = "dgvDetalleBibliografia"
        Me.dgvDetalleBibliografia.Size = New System.Drawing.Size(513, 195)
        Me.dgvDetalleBibliografia.TabIndex = 129
        '
        'gbxLibro
        '
        Me.gbxLibro.Controls.Add(Me.lblEstado)
        Me.gbxLibro.Controls.Add(Me.cboEstado)
        Me.gbxLibro.Controls.Add(Me.lblLibro)
        Me.gbxLibro.Controls.Add(Me.btnAgregarLibro)
        Me.gbxLibro.Controls.Add(Me.cboLibro)
        Me.gbxLibro.Location = New System.Drawing.Point(33, 101)
        Me.gbxLibro.Name = "gbxLibro"
        Me.gbxLibro.Size = New System.Drawing.Size(513, 84)
        Me.gbxLibro.TabIndex = 128
        Me.gbxLibro.TabStop = False
        Me.gbxLibro.Text = "Agregue libros a la bibliografía:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(9, 47)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(48, 15)
        Me.lblEstado.TabIndex = 93
        Me.lblEstado.Text = "Estado:"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(88, 46)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(349, 21)
        Me.cboEstado.TabIndex = 92
        '
        'lblLibro
        '
        Me.lblLibro.AutoSize = True
        Me.lblLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibro.Location = New System.Drawing.Point(9, 22)
        Me.lblLibro.Name = "lblLibro"
        Me.lblLibro.Size = New System.Drawing.Size(38, 15)
        Me.lblLibro.TabIndex = 86
        Me.lblLibro.Text = "Libro:"
        '
        'btnAgregarLibro
        '
        Me.btnAgregarLibro.Image = CType(resources.GetObject("btnAgregarLibro.Image"), System.Drawing.Image)
        Me.btnAgregarLibro.Location = New System.Drawing.Point(458, 22)
        Me.btnAgregarLibro.Name = "btnAgregarLibro"
        Me.btnAgregarLibro.Size = New System.Drawing.Size(36, 47)
        Me.btnAgregarLibro.TabIndex = 32
        Me.btnAgregarLibro.UseVisualStyleBackColor = True
        '
        'cboLibro
        '
        Me.cboLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLibro.FormattingEnabled = True
        Me.cboLibro.Location = New System.Drawing.Point(88, 19)
        Me.cboLibro.Name = "cboLibro"
        Me.cboLibro.Size = New System.Drawing.Size(349, 21)
        Me.cboLibro.TabIndex = 27
        '
        'dtpFechaCreacion
        '
        Me.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCreacion.Location = New System.Drawing.Point(113, 55)
        Me.dtpFechaCreacion.Name = "dtpFechaCreacion"
        Me.dtpFechaCreacion.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaCreacion.TabIndex = 114
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(28, 58)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(44, 15)
        Me.lblFecha.TabIndex = 113
        Me.lblFecha.Text = "Fecha:"
        '
        'lblMateria
        '
        Me.lblMateria.AutoSize = True
        Me.lblMateria.Location = New System.Drawing.Point(30, 29)
        Me.lblMateria.Name = "lblMateria"
        Me.lblMateria.Size = New System.Drawing.Size(45, 13)
        Me.lblMateria.TabIndex = 57
        Me.lblMateria.Text = "Materia:"
        '
        'cboMateria
        '
        Me.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMateria.FormattingEnabled = True
        Me.cboMateria.Location = New System.Drawing.Point(113, 26)
        Me.cboMateria.Name = "cboMateria"
        Me.cboMateria.Size = New System.Drawing.Size(225, 21)
        Me.cboMateria.TabIndex = 56
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(471, 415)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.btnBuscar)
        Me.tbpConsulta.Controls.Add(Me.txtBuscarMateria)
        Me.tbpConsulta.Controls.Add(Me.lblBuscarMateria)
        Me.tbpConsulta.Controls.Add(Me.dgvConsulta)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConsulta.Size = New System.Drawing.Size(589, 475)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(382, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 35)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscarMateria
        '
        Me.txtBuscarMateria.Location = New System.Drawing.Point(163, 9)
        Me.txtBuscarMateria.Name = "txtBuscarMateria"
        Me.txtBuscarMateria.Size = New System.Drawing.Size(213, 20)
        Me.txtBuscarMateria.TabIndex = 9
        '
        'lblBuscarMateria
        '
        Me.lblBuscarMateria.AutoSize = True
        Me.lblBuscarMateria.Location = New System.Drawing.Point(40, 12)
        Me.lblBuscarMateria.Name = "lblBuscarMateria"
        Me.lblBuscarMateria.Size = New System.Drawing.Size(95, 13)
        Me.lblBuscarMateria.TabIndex = 8
        Me.lblBuscarMateria.Text = "Buscar por materia"
        '
        'dgvConsulta
        '
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvConsulta.Location = New System.Drawing.Point(3, 70)
        Me.dgvConsulta.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.RowTemplate.Height = 24
        Me.dgvConsulta.Size = New System.Drawing.Size(583, 402)
        Me.dgvConsulta.TabIndex = 7
        '
        'frmBibliografia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 501)
        Me.Controls.Add(Me.tbcBibliografia)
        Me.Name = "frmBibliografia"
        Me.Text = "Bibliografia"
        Me.tbcBibliografia.ResumeLayout(False)
        Me.tbpABM.ResumeLayout(False)
        Me.tbpABM.PerformLayout()
        CType(Me.dgvDetalleBibliografia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxLibro.ResumeLayout(False)
        Me.gbxLibro.PerformLayout()
        Me.tbpConsulta.ResumeLayout(False)
        Me.tbpConsulta.PerformLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcBibliografia As TabControl
    Friend WithEvents tbpABM As TabPage
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscarMateria As TextBox
    Friend WithEvents lblBuscarMateria As Label
    Friend WithEvents dgvConsulta As DataGridView
    Friend WithEvents gbxLibro As GroupBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents lblLibro As Label
    Friend WithEvents btnAgregarLibro As Button
    Friend WithEvents cboLibro As ComboBox
    Friend WithEvents dtpFechaCreacion As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents nudBibliografiaId As NumericUpDown
    Friend WithEvents lblMateria As Label
    Friend WithEvents cboMateria As ComboBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblId As Label
    Friend WithEvents dgvDetalleBibliografia As DataGridView
End Class
