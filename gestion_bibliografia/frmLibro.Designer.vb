<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLibro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibro))
        Me.tbcLibro = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnEditorial = New System.Windows.Forms.Button()
        Me.btnIdioma = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.txtEdicion = New System.Windows.Forms.TextBox()
        Me.lblEdicion = New System.Windows.Forms.Label()
        Me.nudNroPag = New System.Windows.Forms.NumericUpDown()
        Me.lblPagina = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblTítulo = New System.Windows.Forms.Label()
        Me.txtFormato = New System.Windows.Forms.TextBox()
        Me.lblFormato = New System.Windows.Forms.Label()
        Me.lblEditorial = New System.Windows.Forms.Label()
        Me.cboEditorial = New System.Windows.Forms.ComboBox()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.cboAutor = New System.Windows.Forms.ComboBox()
        Me.nudLibro = New System.Windows.Forms.NumericUpDown()
        Me.lblIdioma = New System.Windows.Forms.Label()
        Me.cboIdioma = New System.Windows.Forms.ComboBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbxBotonera = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtisbn = New System.Windows.Forms.TextBox()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblLibro = New System.Windows.Forms.Label()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.dtgLibro = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscarISBN = New System.Windows.Forms.TextBox()
        Me.lblBuscarISBN = New System.Windows.Forms.Label()
        Me.tbcLibro.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.nudNroPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBotonera.SuspendLayout()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.dtgLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcLibro
        '
        Me.tbcLibro.Controls.Add(Me.TabPage1)
        Me.tbcLibro.Controls.Add(Me.tbpConsulta)
        Me.tbcLibro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcLibro.Location = New System.Drawing.Point(0, 0)
        Me.tbcLibro.Name = "tbcLibro"
        Me.tbcLibro.SelectedIndex = 0
        Me.tbcLibro.Size = New System.Drawing.Size(780, 504)
        Me.tbcLibro.TabIndex = 75
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Bisque
        Me.TabPage1.Controls.Add(Me.btnEditorial)
        Me.TabPage1.Controls.Add(Me.btnIdioma)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.lblCategoria)
        Me.TabPage1.Controls.Add(Me.cboCategoria)
        Me.TabPage1.Controls.Add(Me.txtEdicion)
        Me.TabPage1.Controls.Add(Me.lblEdicion)
        Me.TabPage1.Controls.Add(Me.nudNroPag)
        Me.TabPage1.Controls.Add(Me.lblPagina)
        Me.TabPage1.Controls.Add(Me.txtTitulo)
        Me.TabPage1.Controls.Add(Me.lblTítulo)
        Me.TabPage1.Controls.Add(Me.txtFormato)
        Me.TabPage1.Controls.Add(Me.lblFormato)
        Me.TabPage1.Controls.Add(Me.lblEditorial)
        Me.TabPage1.Controls.Add(Me.cboEditorial)
        Me.TabPage1.Controls.Add(Me.lblAutor)
        Me.TabPage1.Controls.Add(Me.cboAutor)
        Me.TabPage1.Controls.Add(Me.nudLibro)
        Me.TabPage1.Controls.Add(Me.lblIdioma)
        Me.TabPage1.Controls.Add(Me.cboIdioma)
        Me.TabPage1.Controls.Add(Me.lblTitulo)
        Me.TabPage1.Controls.Add(Me.gbxBotonera)
        Me.TabPage1.Controls.Add(Me.txtisbn)
        Me.TabPage1.Controls.Add(Me.lblISBN)
        Me.TabPage1.Controls.Add(Me.lblLibro)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(772, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ABM"
        '
        'btnEditorial
        '
        Me.btnEditorial.Location = New System.Drawing.Point(341, 194)
        Me.btnEditorial.Name = "btnEditorial"
        Me.btnEditorial.Size = New System.Drawing.Size(70, 28)
        Me.btnEditorial.TabIndex = 100
        Me.btnEditorial.Text = "Editorial"
        Me.btnEditorial.UseVisualStyleBackColor = True
        '
        'btnIdioma
        '
        Me.btnIdioma.Location = New System.Drawing.Point(686, 193)
        Me.btnIdioma.Name = "btnIdioma"
        Me.btnIdioma.Size = New System.Drawing.Size(78, 28)
        Me.btnIdioma.TabIndex = 98
        Me.btnIdioma.Text = "Idioma"
        Me.btnIdioma.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(686, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 28)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Categoria"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(415, 230)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(69, 17)
        Me.lblCategoria.TabIndex = 96
        Me.lblCategoria.Text = "Categoría"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(505, 225)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(176, 25)
        Me.cboCategoria.TabIndex = 95
        '
        'txtEdicion
        '
        Me.txtEdicion.Location = New System.Drawing.Point(505, 167)
        Me.txtEdicion.Name = "txtEdicion"
        Me.txtEdicion.Size = New System.Drawing.Size(175, 23)
        Me.txtEdicion.TabIndex = 93
        '
        'lblEdicion
        '
        Me.lblEdicion.AutoSize = True
        Me.lblEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicion.Location = New System.Drawing.Point(417, 168)
        Me.lblEdicion.Name = "lblEdicion"
        Me.lblEdicion.Size = New System.Drawing.Size(81, 17)
        Me.lblEdicion.TabIndex = 94
        Me.lblEdicion.Text = "Nro Edición"
        '
        'nudNroPag
        '
        Me.nudNroPag.Location = New System.Drawing.Point(505, 141)
        Me.nudNroPag.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.nudNroPag.Name = "nudNroPag"
        Me.nudNroPag.Size = New System.Drawing.Size(59, 23)
        Me.nudNroPag.TabIndex = 92
        '
        'lblPagina
        '
        Me.lblPagina.AutoSize = True
        Me.lblPagina.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagina.Location = New System.Drawing.Point(416, 144)
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Size = New System.Drawing.Size(79, 17)
        Me.lblPagina.TabIndex = 91
        Me.lblPagina.Text = "Nro Página"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(505, 115)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(175, 23)
        Me.txtTitulo.TabIndex = 89
        '
        'lblTítulo
        '
        Me.lblTítulo.AutoSize = True
        Me.lblTítulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTítulo.Location = New System.Drawing.Point(415, 116)
        Me.lblTítulo.Name = "lblTítulo"
        Me.lblTítulo.Size = New System.Drawing.Size(43, 17)
        Me.lblTítulo.TabIndex = 90
        Me.lblTítulo.Text = "Título"
        '
        'txtFormato
        '
        Me.txtFormato.Location = New System.Drawing.Point(163, 224)
        Me.txtFormato.Name = "txtFormato"
        Me.txtFormato.Size = New System.Drawing.Size(176, 23)
        Me.txtFormato.TabIndex = 87
        '
        'lblFormato
        '
        Me.lblFormato.AutoSize = True
        Me.lblFormato.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormato.Location = New System.Drawing.Point(78, 228)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(60, 17)
        Me.lblFormato.TabIndex = 88
        Me.lblFormato.Text = "Formato"
        '
        'lblEditorial
        '
        Me.lblEditorial.AutoSize = True
        Me.lblEditorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditorial.Location = New System.Drawing.Point(77, 199)
        Me.lblEditorial.Name = "lblEditorial"
        Me.lblEditorial.Size = New System.Drawing.Size(59, 17)
        Me.lblEditorial.TabIndex = 86
        Me.lblEditorial.Text = "Editorial"
        '
        'cboEditorial
        '
        Me.cboEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEditorial.FormattingEnabled = True
        Me.cboEditorial.Location = New System.Drawing.Point(163, 197)
        Me.cboEditorial.Name = "cboEditorial"
        Me.cboEditorial.Size = New System.Drawing.Size(176, 25)
        Me.cboEditorial.TabIndex = 85
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.Location = New System.Drawing.Point(77, 169)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(42, 17)
        Me.lblAutor.TabIndex = 84
        Me.lblAutor.Text = "Autor"
        '
        'cboAutor
        '
        Me.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAutor.FormattingEnabled = True
        Me.cboAutor.Location = New System.Drawing.Point(162, 167)
        Me.cboAutor.Name = "cboAutor"
        Me.cboAutor.Size = New System.Drawing.Size(177, 25)
        Me.cboAutor.TabIndex = 83
        '
        'nudLibro
        '
        Me.nudLibro.Enabled = False
        Me.nudLibro.Location = New System.Drawing.Point(162, 115)
        Me.nudLibro.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.nudLibro.Name = "nudLibro"
        Me.nudLibro.Size = New System.Drawing.Size(62, 23)
        Me.nudLibro.TabIndex = 82
        '
        'lblIdioma
        '
        Me.lblIdioma.AutoSize = True
        Me.lblIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdioma.Location = New System.Drawing.Point(415, 197)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(49, 17)
        Me.lblIdioma.TabIndex = 81
        Me.lblIdioma.Text = "Idioma"
        '
        'cboIdioma
        '
        Me.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdioma.FormattingEnabled = True
        Me.cboIdioma.Location = New System.Drawing.Point(504, 193)
        Me.cboIdioma.Name = "cboIdioma"
        Me.cboIdioma.Size = New System.Drawing.Size(176, 25)
        Me.cboIdioma.TabIndex = 80
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(20, 32)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(63, 20)
        Me.lblTitulo.TabIndex = 79
        Me.lblTitulo.Text = "LIBRO"
        '
        'gbxBotonera
        '
        Me.gbxBotonera.Controls.Add(Me.btnAgregar)
        Me.gbxBotonera.Controls.Add(Me.btnEliminar)
        Me.gbxBotonera.Controls.Add(Me.btnCancelar)
        Me.gbxBotonera.Location = New System.Drawing.Point(178, 319)
        Me.gbxBotonera.Name = "gbxBotonera"
        Me.gbxBotonera.Size = New System.Drawing.Size(428, 87)
        Me.gbxBotonera.TabIndex = 78
        Me.gbxBotonera.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(23, 21)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(87, 39)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(163, 21)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(88, 39)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(310, 21)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 39)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtisbn
        '
        Me.txtisbn.Location = New System.Drawing.Point(162, 141)
        Me.txtisbn.Name = "txtisbn"
        Me.txtisbn.Size = New System.Drawing.Size(177, 23)
        Me.txtisbn.TabIndex = 76
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.Location = New System.Drawing.Point(77, 143)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(39, 17)
        Me.lblISBN.TabIndex = 77
        Me.lblISBN.Text = "ISBN"
        '
        'lblLibro
        '
        Me.lblLibro.AutoSize = True
        Me.lblLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibro.Location = New System.Drawing.Point(77, 115)
        Me.lblLibro.Name = "lblLibro"
        Me.lblLibro.Size = New System.Drawing.Size(55, 17)
        Me.lblLibro.TabIndex = 75
        Me.lblLibro.Text = "Id Libro"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.dtgLibro)
        Me.tbpConsulta.Controls.Add(Me.btnBuscar)
        Me.tbpConsulta.Controls.Add(Me.txtBuscarISBN)
        Me.tbpConsulta.Controls.Add(Me.lblBuscarISBN)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConsulta.Size = New System.Drawing.Size(772, 478)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'dtgLibro
        '
        Me.dtgLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLibro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgLibro.Location = New System.Drawing.Point(3, 95)
        Me.dtgLibro.Name = "dtgLibro"
        Me.dtgLibro.Size = New System.Drawing.Size(766, 380)
        Me.dtgLibro.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(265, 39)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(25, 27)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscarISBN
        '
        Me.txtBuscarISBN.Location = New System.Drawing.Point(16, 43)
        Me.txtBuscarISBN.Name = "txtBuscarISBN"
        Me.txtBuscarISBN.Size = New System.Drawing.Size(233, 20)
        Me.txtBuscarISBN.TabIndex = 8
        '
        'lblBuscarISBN
        '
        Me.lblBuscarISBN.AutoSize = True
        Me.lblBuscarISBN.Location = New System.Drawing.Point(14, 26)
        Me.lblBuscarISBN.Name = "lblBuscarISBN"
        Me.lblBuscarISBN.Size = New System.Drawing.Size(86, 13)
        Me.lblBuscarISBN.TabIndex = 7
        Me.lblBuscarISBN.Text = "Buscar por ISBN"
        '
        'frmLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(780, 504)
        Me.Controls.Add(Me.tbcLibro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLibro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libros"
        Me.tbcLibro.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.nudNroPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBotonera.ResumeLayout(False)
        Me.tbpConsulta.ResumeLayout(False)
        Me.tbpConsulta.PerformLayout()
        CType(Me.dtgLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcLibro As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents lblCategoria As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents txtEdicion As TextBox
    Friend WithEvents lblEdicion As Label
    Friend WithEvents nudNroPag As NumericUpDown
    Friend WithEvents lblPagina As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents lblTítulo As Label
    Friend WithEvents txtFormato As TextBox
    Friend WithEvents lblFormato As Label
    Friend WithEvents lblEditorial As Label
    Friend WithEvents cboEditorial As ComboBox
    Friend WithEvents lblAutor As Label
    Friend WithEvents cboAutor As ComboBox
    Friend WithEvents nudLibro As NumericUpDown
    Friend WithEvents lblIdioma As Label
    Friend WithEvents cboIdioma As ComboBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbxBotonera As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtisbn As TextBox
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblLibro As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscarISBN As TextBox
    Friend WithEvents lblBuscarISBN As Label
    Friend WithEvents dtgLibro As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnIdioma As Button
    Friend WithEvents btnEditorial As Button
End Class
