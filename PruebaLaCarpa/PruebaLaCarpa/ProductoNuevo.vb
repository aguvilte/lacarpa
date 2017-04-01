Imports System.Data.OleDb


Public Class ProductoNuevo
    Private daNuevo As OleDbDataAdapter
    Private dsNuevo As DataSet
    Private dataReader1 As OleDbDataReader
    Private comando As OleDbCommand

    Private Sub ProductoNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectarse()


        daNuevo = New OleDbDataAdapter
        daNuevo.SelectCommand = New OleDbCommand("SELECT productos.id_producto, nombre, tipo_producto, precio FROM productos INNER JOIN productos_tipos ON productos.id_producto= productos_tipos.id_producto", Conexion)

        dsNuevo = New DataSet
        dsNuevo.Tables.Add("Productos")
        dsNuevo.Tables.Add("ProductosTipos")

        daNuevo.Fill(dsNuevo.Tables("Productos"))
        daNuevo.Fill(dsNuevo.Tables("ProductosTipos"))



    End Sub

    Private Sub BtGuardarNuevo_Click(sender As Object, e As EventArgs) Handles BtGuardarNuevo.Click

        Conectarse()

        Dim fila As DataRow

        fila = dsNuevo.Tables("Productos").NewRow


        fila("nombre") = TbNombre.Text.ToString


        dsNuevo.Tables("Productos").Rows.Add(fila)


        daNuevo.InsertCommand = New OleDbCommand("INSERT INTO productos (nombre) VALUES (@nom)", Conexion)
        daNuevo.InsertCommand.Parameters.Add("@nom", OleDbType.VarChar, 255, "nombre")

        daNuevo.Update(dsNuevo.Tables("Productos"))

        comando = New OleDbCommand("SELECT id_producto FROM productos WHERE nombre='" & TbNombre.Text & "'", Conexion)

        Dim id As Integer

        dataReader1 = comando.ExecuteReader()


        If dataReader1.HasRows Then
            While dataReader1.Read()
                id = dataReader1("id_producto")
            End While

        End If

        Dim fila1 As DataRow
        fila1 = dsNuevo.Tables("ProductosTipos").NewRow

        fila1("id_producto") = id
        fila1("tipo_producto") = TbTipo.Text
        fila1("precio") = TbPrecio.Text

        dsNuevo.Tables("ProductosTipos").Rows.Add(fila1)

        daNuevo.InsertCommand = New OleDbCommand("INSERT INTO productos_tipos (id_producto, tipo_producto, precio) VALUES (@id, @tip, @pre)", Conexion)
        daNuevo.InsertCommand.Parameters.Add("@id", OleDbType.BigInt, 4, "id_producto")
        daNuevo.InsertCommand.Parameters.Add("@tip", OleDbType.VarChar, 255, "tipo_producto")
        daNuevo.InsertCommand.Parameters.Add("@pre", OleDbType.BigInt, 4, "precio")

        daNuevo.Update(dsNuevo.Tables("ProductosTipos"))

        TbNombre.Clear()
        TbPrecio.Clear()
        TbTipo.Clear()


    End Sub


End Class