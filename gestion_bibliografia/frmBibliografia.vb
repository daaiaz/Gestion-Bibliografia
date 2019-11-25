Public Class frmBibliografia
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
End Class