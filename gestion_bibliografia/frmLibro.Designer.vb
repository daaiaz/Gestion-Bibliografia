<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibro))
        Me.tbcLibro = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.tbcLibro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbcLibro.Name = "tbcLibro"
        Me.tbcLibro.SelectedIndex = 0
        Me.tbcLibro.Size = New System.Drawing.Size(429, 620)
        Me.tbcLibro.TabIndex = 75
        '
        'TabPage1
        '
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(421, 591)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ABM"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(28, 397)
        Me.lblCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(69, 17)
        Me.lblCategoria.TabIndex = 96
        Me.lblCategoria.Text = "Categoría"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(143, 393)
        Me.cboCategoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(233, 24)
        Me.cboCategoria.TabIndex = 95
        '
        'txtEdicion
        '
        Me.txtEdicion.Location = New System.Drawing.Point(144, 328)
        Me.txtEdicion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEdicion.Name = "txtEdicion"
        Me.txtEdicion.Size = New System.Drawing.Size(232, 22)
        Me.txtEdicion.TabIndex = 93
        '
        'lblEdicion
        '
        Me.lblEdicion.AutoSize = True
        Me.lblEdicion.Location = New System.Drawing.Point(31, 328)
        Me.lblEdicion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEdicion.Name = "lblEdicion"
        Me.lblEdicion.Size = New System.Drawing.Size(81, 17)
        Me.lblEdicion.TabIndex = 94
        Me.lblEdicion.Text = "Nro Edición"
        '
        'nudNroPag
        '
        Me.nudNroPag.Location = New System.Drawing.Point(144, 296)
        Me.nudNroPag.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudNroPag.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.nudNroPag.Name = "nudNroPag"
        Me.nudNroPag.Size = New System.Drawing.Size(79, 22)
        Me.nudNroPag.TabIndex = 92
        '
        'lblPagina
        '
        Me.lblPagina.AutoSize = True
        Me.lblPagina.Location = New System.Drawing.Point(29, 298)
        Me.lblPagina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Size = New System.Drawing.Size(79, 17)
        Me.lblPagina.TabIndex = 91
        Me.lblPagina.Text = "Nro Página"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(144, 264)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(232, 22)
        Me.txtTitulo.TabIndex = 89
        '
        'lblTítulo
        '
        Me.lblTítulo.AutoSize = True
        Me.lblTítulo.Location = New System.Drawing.Point(28, 264)
        Me.lblTítulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTítulo.Name = "lblTítulo"
        Me.lblTítulo.Size = New System.Drawing.Size(43, 17)
        Me.lblTítulo.TabIndex = 90
        Me.lblTítulo.Text = "Título"
        '
        'txtFormato
        '
        Me.txtFormato.Location = New System.Drawing.Point(143, 225)
        Me.txtFormato.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFormato.Name = "txtFormato"
        Me.txtFormato.Size = New System.Drawing.Size(233, 22)
        Me.txtFormato.TabIndex = 87
        '
        'lblFormato
        '
        Me.lblFormato.AutoSize = True
        Me.lblFormato.Location = New System.Drawing.Point(29, 230)
        Me.lblFormato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(60, 17)
        Me.lblFormato.TabIndex = 88
        Me.lblFormato.Text = "Formato"
        '
        'lblEditorial
        '
        Me.lblEditorial.AutoSize = True
        Me.lblEditorial.Location = New System.Drawing.Point(28, 194)
        Me.lblEditorial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEditorial.Name = "lblEditorial"
        Me.lblEditorial.Size = New System.Drawing.Size(59, 17)
        Me.lblEditorial.TabIndex = 86
        Me.lblEditorial.Text = "Editorial"
        '
        'cboEditorial
        '
        Me.cboEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEditorial.FormattingEnabled = True
        Me.cboEditorial.Location = New System.Drawing.Point(143, 191)
        Me.cboEditorial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboEditorial.Name = "cboEditorial"
        Me.cboEditorial.Size = New System.Drawing.Size(233, 24)
        Me.cboEditorial.TabIndex = 85
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(28, 157)
        Me.lblAutor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(42, 17)
        Me.lblAutor.TabIndex = 84
        Me.lblAutor.Text = "Autor"
        '
        'cboAutor
        '
        Me.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAutor.FormattingEnabled = True
        Me.cboAutor.Location = New System.Drawing.Point(141, 154)
        Me.cboAutor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAutor.Name = "cboAutor"
        Me.cboAutor.Size = New System.Drawing.Size(235, 24)
        Me.cboAutor.TabIndex = 83
        '
        'nudLibro
        '
        Me.nudLibro.Enabled = False
        Me.nudLibro.Location = New System.Drawing.Point(141, 90)
        Me.nudLibro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudLibro.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.nudLibro.Name = "nudLibro"
        Me.nudLibro.Size = New System.Drawing.Size(82, 22)
        Me.nudLibro.TabIndex = 82
        '
        'lblIdioma
        '
        Me.lblIdioma.AutoSize = True
        Me.lblIdioma.Location = New System.Drawing.Point(28, 363)
        Me.lblIdioma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(49, 17)
        Me.lblIdioma.TabIndex = 81
        Me.lblIdioma.Text = "Idioma"
        '
        'cboIdioma
        '
        Me.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdioma.FormattingEnabled = True
        Me.cboIdioma.Location = New System.Drawing.Point(143, 360)
        Me.cboIdioma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboIdioma.Name = "cboIdioma"
        Me.cboIdioma.Size = New System.Drawing.Size(233, 24)
        Me.cboIdioma.TabIndex = 80
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(26, 40)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(75, 25)
        Me.lblTitulo.TabIndex = 79
        Me.lblTitulo.Text = "LIBRO"
        '
        'gbxBotonera
        '
        Me.gbxBotonera.Controls.Add(Me.btnAgregar)
        Me.gbxBotonera.Controls.Add(Me.btnEliminar)
        Me.gbxBotonera.Controls.Add(Me.btnCancelar)
        Me.gbxBotonera.Location = New System.Drawing.Point(31, 470)
        Me.gbxBotonera.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxBotonera.Name = "gbxBotonera"
        Me.gbxBotonera.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxBotonera.Size = New System.Drawing.Size(345, 80)
        Me.gbxBotonera.TabIndex = 78
        Me.gbxBotonera.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(18, 26)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(72, 28)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(134, 26)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 28)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(252, 26)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(77, 28)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtisbn
        '
        Me.txtisbn.Location = New System.Drawing.Point(141, 122)
        Me.txtisbn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtisbn.Name = "txtisbn"
        Me.txtisbn.Size = New System.Drawing.Size(235, 22)
        Me.txtisbn.TabIndex = 76
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(28, 125)
        Me.lblISBN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(39, 17)
        Me.lblISBN.TabIndex = 77
        Me.lblISBN.Text = "ISBN"
        '
        'lblLibro
        '
        Me.lblLibro.AutoSize = True
        Me.lblLibro.Location = New System.Drawing.Point(28, 91)
        Me.lblLibro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 25)
        Me.tbpConsulta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpConsulta.Size = New System.Drawing.Size(421, 591)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'dtgLibro
        '
        Me.dtgLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLibro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgLibro.Location = New System.Drawing.Point(4, 119)
        Me.dtgLibro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtgLibro.Name = "dtgLibro"
        Me.dtgLibro.Size = New System.Drawing.Size(413, 468)
        Me.dtgLibro.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(353, 48)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(33, 33)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscarISBN
        '
        Me.txtBuscarISBN.Location = New System.Drawing.Point(22, 53)
        Me.txtBuscarISBN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscarISBN.Name = "txtBuscarISBN"
        Me.txtBuscarISBN.Size = New System.Drawing.Size(309, 22)
        Me.txtBuscarISBN.TabIndex = 8
        '
        'lblBuscarISBN
        '
        Me.lblBuscarISBN.AutoSize = True
        Me.lblBuscarISBN.Location = New System.Drawing.Point(19, 32)
        Me.lblBuscarISBN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuscarISBN.Name = "lblBuscarISBN"
        Me.lblBuscarISBN.Size = New System.Drawing.Size(112, 17)
        Me.lblBuscarISBN.TabIndex = 7
        Me.lblBuscarISBN.Text = "Buscar por ISBN"
        '
        'frmLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 620)
        Me.Controls.Add(Me.tbcLibro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
End Class
