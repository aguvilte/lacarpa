Imports System.Data.OleDb


Public Class Stock

    Private daStock As OleDbDataAdapter
    Private daStock2 As OleDbDataAdapter
    Private daStock3 As OleDbDataAdapter

    Private dr As OleDbDataReader

    Private ds As DataSet

    Private vistaDatos As New DataView

    Dim comando As OleDbCommand

    Public nuevoPedido As Boolean = True

    Public indiceProducto As Integer
    Public indiceBebida As Integer
    Public cantidadProducto As Integer
    Public cantidadBebida
    Public numeroMesa As Integer
    Public idVenta As Integer
    Public idProd As Integer
    Public montoTotal As Integer

    Public cantidadStock As Integer


    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectarse()

        'miConexion = New OleDbConnection(cadenaConexion) preguntar si desconectar

        ds = New DataSet
        ds.Tables.Add("Stock")

        daStock = New OleDbDataAdapter
        daStock.SelectCommand = New OleDbCommand("SELECT * FROM stock", Conexion)

        daStock.Fill(ds.Tables("Stock"))

        vistaDatos = ds.Tables("Stock").DefaultView
        dgvStock.DataSource = vistaDatos

        dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvStock.Columns(0).HeaderText = "Nombre"
        dgvStock.Columns(1).HeaderText = "Cantidad (en gramos)"

    End Sub

    Private Sub btnAgregarStock_Click(sender As Object, e As EventArgs) Handles btnAgregarStock.Click
        ds = New DataSet
        Dim row As DataRow
        ds.Tables.Add("Stock")
        ds.Tables.Add("Stock2")

        daStock2 = New OleDbDataAdapter
        daStock = New OleDbDataAdapter
        daStock3 = New OleDbDataAdapter

        daStock2.SelectCommand = New OleDbCommand("SELECT * FROM stock WHERE nombre = '" & cbTipoStock.SelectedItem & "'", Conexion)

        daStock2.Fill(ds.Tables("Stock"))

        cantidadStock = ds.Tables("Stock").Rows(0)("cantidad") + CInt(tbCantidadStock.Text)

        row = ds.Tables("Stock").Rows(0)

        row("nombre") = cbTipoStock.SelectedItem.ToString
        row("cantidad") = cantidadStock

        daStock.UpdateCommand = New OleDbCommand("UPDATE stock SET cantidad= @cant WHERE nombre = @nom", Conexion)
        daStock.UpdateCommand.Parameters.Add("@cant", OleDbType.BigInt, 5, "cantidad")
        daStock.UpdateCommand.Parameters.Add("@nom", OleDbType.VarChar, 10, "nombre")

        daStock.Update(ds.Tables("Stock"))

        daStock3.SelectCommand = New OleDbCommand("SELECT * FROM stock", Conexion)
        daStock3.Fill(ds.Tables("Stock2"))
        vistaDatos = ds.Tables("Stock2").DefaultView
        dgvStock.DataSource = vistaDatos

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        Principal.Show()
    End Sub
End Class