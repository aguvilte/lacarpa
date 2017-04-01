Imports System.Data.OleDb

Public Class Administracion
    Private da As OleDbDataAdapter
    Private ds As DataSet
    Private guardarNuevoEdit As Boolean
    Private posicionFila As Integer = 0

    Private Sub Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectarse()

        da = New OleDbDataAdapter

        da.SelectCommand = New OleDbCommand("SELECT * FROM productos, productos_tipos", Conexion)

        ds = New DataSet
        ds.Tables.Add("productos")
        ds.Tables.Add("productos_tipos")

        da.Fill(ds.Tables("productos"))
        da.Fill(ds.Tables("productos_tipos"))

    End Sub

    Private Sub BtNuevo_Click(sender As Object, e As EventArgs) Handles BtNuevo.Click
        BtEditar.Enabled = False
        BtEliminar.Enabled = False


        TbNombre.Text = ""
        TbPrecio.Text = ""
        TbTipo.Text = ""

        guardarNuevoEdit = True

    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click
        BtNuevo.Enabled = False
        BtEliminar.Enabled = False

        guardarNuevoEdit = False

    End Sub

    Private Sub BtEliminar_Click(sender As Object, e As EventArgs) Handles BtEliminar.Click
        Dim row As DataRow

        row = ds.Tables("productos").Rows(posicionFila)
        row = ds.Tables("productos_tipos").Rows(posicionFila)

        row("nombre") = (TbNombre.Text)
        row("tipo_producto") = TbTipo.Text
        row("precio") = TbPrecio.Text

        da.UpdateCommand = New OleDbCommand("DELETE FROM productos WHERE nombre = @nom", Conexion)
        da.UpdateCommand.Parameters.Add("@nom", OleDbType.VarChar, 100, "nombre")
        da.UpdateCommand = New OleDbCommand("DELETE FROM productos_tipos WHERE tipo_producto = @tip AND precio = @prec", Conexion)
        da.UpdateCommand.Parameters.Add("@tipo_producto", OleDbType.VarChar, 50, "tipo_producto")
        da.UpdateCommand.Parameters.Add("@prec", OleDbType.BigInt, 50, "precio")

        da.Update(ds.Tables("productos"))
        da.Update(ds.Tables("productos_tipos"))

        TbNombre.Text = ""
        TbPrecio.Text = ""
        TbTipo.Text = ""
    End Sub

    Private Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click
        BtEditar.Enabled = True
        BtNuevo.Enabled = True
        BtEliminar.Enabled = True

        Dim row1 As DataRow

        If guardarNuevoEdit = True Then
            row1 = ds.Tables("productos").NewRow
            row1 = ds.Tables("productos_tipos").NewRow

            row1("nombre") = (TbNombre.Text)
            row1("tipo_producto") = TbTipo.Text
            row1("precio") = TbPrecio.Text

            ds.Tables("productos").Rows.Add(row1)
            da.InsertCommand = New OleDbCommand("INSERT INTO productos (nombre) VALUES (@nom)", Conexion)
            da.InsertCommand.Parameters.Add("@nom", OleDbType.VarChar, 100, "nombre")
            da.InsertCommand = New OleDbCommand("INSERT INTO productos_tipos (tipo_producto, precio) VALUES (@tip, @prec)", Conexion)
            da.InsertCommand.Parameters.Add("@tip", OleDbType.VarChar, 50, "tipo_producto")
            da.InsertCommand.Parameters.Add("@prec", OleDbType.BigInt, 30, "precio")

        ElseIf guardarNuevoEdit = False Then
            row1 = ds.Tables("productos").Rows(posicionFila)
            row1 = ds.Tables("productos_tipos").Rows(posicionFila)

            row1("nombre") = (TbNombre.Text)
            row1("tipo_producto") = TbTipo.Text
            row1("precio") = TbPrecio.Text

            da.UpdateCommand = New OleDbCommand("UPDATE productos SET nombre = @nom", Conexion)
            da.UpdateCommand.Parameters.Add("@nom", OleDbType.VarChar, 100, "nombre")
            da.UpdateCommand = New OleDbCommand("UPDATE productos_tipos SET tipo_producto = @tip , precio = @prec", Conexion)

            da.UpdateCommand.Parameters.Add("@tip", OleDbType.VarChar, 50, "tipo_producto")
            da.UpdateCommand.Parameters.Add("@prec", OleDbType.BigInt, 30, "precio")
        End If

        da.Update(ds.Tables("productos"))
        da.Update(ds.Tables("productos_tipos"))
    End Sub
End Class