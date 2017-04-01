Imports System.Data.OleDb

Public Class NuevoEditar

    Private da As OleDbDataAdapter
    Private ds As DataSet
    Private guardarNuevoEdit As Boolean
    Private vistaDatos As New DataView
    Private indiceProducto As Integer


    Private Sub NuevoEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectarse()


        da = New OleDbDataAdapter
        da.SelectCommand = New OleDbCommand("SELECT nombre FROM productos", Conexion)
        ds = New DataSet
        ds.Tables.Add("Productos")
        ds.Tables.Add("ProductosTipos")

        da.Fill(ds.Tables("Productos"))


        CbNombre.DataSource = ds.Tables("Productos").DefaultView
        CbNombre.ValueMember = "nombre"



    End Sub
    Private Sub CbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNombre.SelectedIndexChanged
        ds = New DataSet
        ds.Tables.Add("ProductosTipos")

        indiceProducto = CbNombre.SelectedIndex + 1

        da = New OleDbDataAdapter
        da.SelectCommand = New OleDbCommand("SELECT tipo_producto FROM productos_tipos WHERE id_producto =" & indiceProducto, Conexion)

        da.Fill(ds.Tables("ProductosTipos"))

        CbTipo.DataSource = ds.Tables("ProductosTipos").DefaultView
        CbTipo.ValueMember = "tipo_producto"


    End Sub

    Private Sub CbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipo.SelectedIndexChanged
        ds = New DataSet
        ds.Tables.Add("PreciosProductos")


        da = New OleDbDataAdapter
        da.SelectCommand = New OleDbCommand("SELECT precio FROM productos_tipos WHERE id_producto =" & indiceProducto & " AND tipo_producto ='" & CbTipo.Text & "'", Conexion)


        da.Fill(ds.Tables("PreciosProductos"))

        CbPrecio.DataSource = ds.Tables("PreciosProductos").DefaultView
        CbPrecio.ValueMember = "precio"


    End Sub

    Private Sub BtNueGuardar_Click(sender As Object, e As EventArgs) Handles BtNueGuardar.Click
        Dim row As DataRow

        If guardarNuevoEdit = False Then

            row = ds.Tables("productos").Rows(0)
            'row = ds.Tables("productos_tipos").Rows(0)
            row("nombre") = CbNombre.Text
            'row("tipo_producto") = CbTipo.Text
            'row("precio") = CbPrecio.Text

            da.UpdateCommand = New OleDbCommand("UPDATE productosSET nombre = @nom", Conexion)
            da.UpdateCommand.Parameters.Add("@nom", OleDbType.VarChar, 50, "nombre")
            'da.UpdateCommand.Parameters.Add("@tip", OleDbType.VarChar, 50, "tipo_producto")
            'da.UpdateCommand.Parameters.Add("@prec", OleDbType.Integer, 50, "precio")
        End If

        da.Update(ds.Tables("productos"))
        'da.Update(ds.Tables("productos_tipos"))
    End Sub
End Class