Imports System.Data.OleDb

Public Class MesaRecepcion
    Private da As OleDbDataAdapter

    Private dr As OleDbDataReader
    Private comando As OleDbCommand

    Private ds As DataSet

    Private vistaDatos As DataView

    Private numeroMesa As Integer
    Private cantidadProducto As Integer
    Private montoTotal As Integer = 0
    Private indiceProducto As Integer
    Private cantidadStock As Integer
    Private mesaOcupadaBoolean As Boolean

    Private Sub Mesas1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectarse()
        ActivarBotonCerrarPedido()

        ds = New DataSet
        da = New OleDbDataAdapter
        CompletarDataGridView()

        'SE COMPLETA EL cbNombreProductos CON LOS PRODUCTOS DISPONIBLES
        ds.Tables.Add("Productos")
        da.SelectCommand = New OleDbCommand("SELECT nombre FROM productos", Conexion)
        da.Fill(ds.Tables("Productos"))
        cbNombreProd.DataSource = ds.Tables("Productos").DefaultView
        cbNombreProd.ValueMember = "nombre"
        cbNombreProd.Text = ""
        cbTipoProd.Text = ""
        cantidadProducto = CInt(tbCantProd.Text)

        'ACTUALIZA MONTO DEL PEDIDO ACTUAL
        CalculaMonto(numeroMesa)

        btnAgregarProd1.Visible = False
        btnAgregarProd2.Visible = False
        btnAgregarProd3.Visible = False
        btnAgregarProd4.Visible = False

        dgvProductos1.DataSource = ""
        dgvProductos2.DataSource = ""
        dgvProductos3.DataSource = ""
        dgvProductos4.DataSource = ""
    End Sub

    'Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
    '    Desconectarse()
    '    Principal.Show()
    '    Me.Close()
    'End Sub

    Private Sub cbNombreProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNombreProd.SelectedIndexChanged
        BuscarIndiceProducto()

        If cbNombreProd.Text = "" Then
            btnAgregarProd1.Visible = False
            btnAgregarProd2.Visible = False
            btnAgregarProd3.Visible = False
            btnAgregarProd4.Visible = False
        Else
            btnAgregarProd1.Visible = True
            btnAgregarProd2.Visible = True
            btnAgregarProd3.Visible = True
            btnAgregarProd4.Visible = True
        End If

        'SE COMPLETA EL cbTipoProductos CON LOS TIPOS DE PRODUCTOS DISPONIBLES
        ds = New DataSet
        ds.Tables.Add("TiposProductos")
        da.SelectCommand = New OleDbCommand("SELECT tipo_producto FROM productos_tipos WHERE id_producto =" & indiceProducto, Conexion)
        da.Fill(ds.Tables("TiposProductos"))
        cbTipoProd.DataSource = ds.Tables("TiposProductos").DefaultView
        cbTipoProd.ValueMember = "tipo_producto"
    End Sub

    Private Sub btnCerrarPedido1_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido1.Click
        CerrarPedido(100)
    End Sub

    Private Sub btnCerrarPedido2_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido2.Click
        CerrarPedido(101)
    End Sub

    Private Sub btnCerrarPedido3_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido3.Click
        CerrarPedido(102)
    End Sub

    Private Sub btnCerrarPedido4_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido4.Click
        CerrarPedido(103)
    End Sub

    Private Sub btnAgregarProd1_Click(sender As Object, e As EventArgs) Handles btnAgregarProd1.Click
        AgregarProducto(100)
    End Sub

    Private Sub btnAgregarProd2_Click(sender As Object, e As EventArgs) Handles btnAgregarProd2.Click
        AgregarProducto(101)
    End Sub

    Private Sub btnAgregarProd3_Click(sender As Object, e As EventArgs) Handles btnAgregarProd3.Click
        AgregarProducto(102)
    End Sub

    Private Sub btnAgregarProd4_Click(sender As Object, e As EventArgs) Handles btnAgregarProd4.Click
        AgregarProducto(103)
    End Sub



    Private Function CalculaMonto(numero As Integer)
        Dim devuelveMonto As Integer
        Dim numeroOriginal As Integer = numero
        numero = 100
        For i As Integer = 0 To 3
            montoTotal = 0
            comando = New OleDbCommand("SELECT precio FROM productos_tipos INNER JOIN mesas_productos ON productos_tipos.id_producto = mesas_productos.id_producto And productos_tipos.tipo_producto = mesas_productos.tipo_producto WHERE mesas_productos.id_mesa = " & numero, Conexion)
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    montoTotal += dr("precio")
                End While
            Else
                If numero = 100 Then
                    btnCerrarPedido1.Enabled = False
                ElseIf numero = 101 Then
                    btnCerrarPedido2.Enabled = False
                ElseIf numero = 102 Then
                    btnCerrarPedido3.Enabled = False
                ElseIf numero = 103 Then
                    btnCerrarPedido4.Enabled = False
                End If
            End If

            If numero = 100 Then
                btnCerrarPedido1.Text = "Cerrar pedido - Monto total: $" & montoTotal
                If numero = numeroOriginal Then
                    devuelveMonto = montoTotal
                End If
            ElseIf numero = 101 Then
                btnCerrarPedido2.Text = "Cerrar pedido - Monto total: $" & montoTotal
                If numero = numeroOriginal Then
                    devuelveMonto = montoTotal
                End If
            ElseIf numero = 102 Then
                btnCerrarPedido3.Text = "Cerrar pedido - Monto total: $" & montoTotal
                If numero = numeroOriginal Then
                    devuelveMonto = montoTotal
                End If
            ElseIf numero = 103 Then
                btnCerrarPedido4.Text = "Cerrar pedido - Monto total: $" & montoTotal
                If numero = numeroOriginal Then
                    devuelveMonto = montoTotal
                End If
            End If

            numero += 1
        Next
        Return devuelveMonto
    End Function

    'Private Sub PintarMesaOcupada()
    '    ds = New DataSet
    '    ds.Tables.Add("Mesas")
    '    da.SelectCommand = New OleDbCommand("SELECT * FROM mesas", Conexion)
    '    da.Fill(ds.Tables("Mesas"))

    '    Dim row As DataRow
    '    row = ds.Tables("Mesas").Rows(0)
    '    If mesaOcupadaBoolean = True Then
    '        row("ocupada") = -1
    '    Else
    '        row("ocupada") = 0
    '    End If

    '    da.UpdateCommand = New OleDbCommand("UPDATE mesas SET ocupada=@ocu WHERE id_mesa=" & numeroMesa, Conexion)
    '    da.UpdateCommand.Parameters.Add("@ocu", OleDbType.Boolean, 10, "ocupada")
    '    da.Update(ds.Tables("Mesas"))
    'End Sub

    Private Sub BuscarIndiceProducto()
        comando = New OleDbCommand("SELECT id_producto FROM productos WHERE nombre = '" & cbNombreProd.Text & "'", Conexion)
        dr = comando.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                indiceProducto = dr("id_producto")
            End While
        End If
    End Sub

    Private Sub CerrarPedido(numero As Integer)
        mesaOcupadaBoolean = False

        If MsgBox("¿Está seguro que quiere cerrar el pedido?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            ds = New DataSet
            ds.Tables.Add("Ventas")
            ds.Tables.Add("MesasProductos")

            Dim row As DataRow
            row = ds.Tables("Ventas").NewRow

            da.InsertCommand = New OleDbCommand("INSERT INTO ventas (fecha, monto) VALUES ('" & DateTime.Now.ToString & "', " & CalculaMonto(numero) & ")", Conexion)
            ds.Tables("Ventas").Rows.Add(row)
            da.Update(ds.Tables("Ventas"))

            da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numero, Conexion)
            da.Fill(ds.Tables("MesasProductos"))
            ds.Tables("MesasProductos").Rows(0).Delete()
            da.DeleteCommand = New OleDbCommand("DELETE FROM mesas_productos WHERE id_mesa = " & numero, Conexion)
            da.Update(ds.Tables("MesasProductos"))

            'PintarMesaOcupada()
            Select Case numero
                Case 100
                    dgvProductos1.DataSource = ""
                    btnCerrarPedido1.Text = "Cerrar pedido - Monto total: $0"
                    btnCerrarPedido1.Enabled = False
                Case 101
                    dgvProductos2.DataSource = ""
                    btnCerrarPedido2.Text = "Cerrar pedido - Monto total: $0"
                    btnCerrarPedido2.Enabled = False
                Case 102
                    dgvProductos3.DataSource = ""
                    btnCerrarPedido3.Text = "Cerrar pedido - Monto total: $0"
                    btnCerrarPedido3.Enabled = False
                Case 103
                    dgvProductos4.DataSource = ""
                    btnCerrarPedido4.Text = "Cerrar pedido - Monto total: $0"
                    btnCerrarPedido4.Enabled = False
            End Select
        End If
    End Sub

    Private Sub AgregarProducto(numero As Integer)
        mesaOcupadaBoolean = True

        Dim row As DataRow
        Dim index As Integer
        Dim cantidad As Integer = CInt(tbCantProd.Text)

        'btnCerrarPedido.Enabled = True

        If cantidad > 0 Then
            ds = New DataSet
            ds.Tables.Add("MesasProductos")
            da.SelectCommand = New OleDbCommand("SELECT * FROM mesas_productos WHERE id_mesa=" & numero, Conexion)
            da.Fill(ds.Tables("MesasProductos"))

            BuscarIndiceProducto()

            cantidadStock = 0

            For index = 1 To cantidad
                row = ds.Tables("MesasProductos").NewRow
                row("id_mesa") = numero
                row("id_producto") = indiceProducto
                row("tipo_producto") = cbTipoProd.Text.ToString

                ds.Tables("MesasProductos").Rows.Add(row)

                da.InsertCommand = New OleDbCommand("INSERT INTO mesas_productos (id_mesa, id_producto, tipo_producto) VALUES (@idMesa, @idProd, @tipoProd)", Conexion)
                da.InsertCommand.Parameters.Add("@idMesa", OleDbType.BigInt, 3, "id_mesa")
                da.InsertCommand.Parameters.Add("@idProd", OleDbType.BigInt, 1, "id_producto")
                da.InsertCommand.Parameters.Add("@tipoProd", OleDbType.VarChar, 30, "tipo_producto")

                cantidadStock += 150
            Next
            da.Update(ds.Tables("MesasProductos"))
        End If

        ds.Tables.Add("MesasProductos2")
        da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numero, Conexion)
        da.Fill(ds.Tables("MesasProductos2"))

        Select Case numero
            Case 100
                dgvProductos1.DataSource = ds.Tables("MesasProductos2").DefaultView
                dgvProductos1.Columns(0).HeaderText = "Nombre de producto"
                dgvProductos1.Columns(1).HeaderText = "Tipo de producto"
                btnCerrarPedido1.Enabled = True
            Case 101
                dgvProductos2.DataSource = ds.Tables("MesasProductos2").DefaultView
                dgvProductos2.Columns(0).HeaderText = "Nombre de producto"
                dgvProductos2.Columns(1).HeaderText = "Tipo de producto"
                btnCerrarPedido2.Enabled = True
            Case 102
                dgvProductos3.DataSource = ds.Tables("MesasProductos2").DefaultView
                dgvProductos3.Columns(0).HeaderText = "Nombre de producto"
                dgvProductos3.Columns(1).HeaderText = "Tipo de producto"
                btnCerrarPedido3.Enabled = True
            Case 103
                dgvProductos4.DataSource = ds.Tables("MesasProductos2").DefaultView
                dgvProductos4.Columns(0).HeaderText = "Nombre de producto"
                dgvProductos4.Columns(1).HeaderText = "Tipo de producto"
                btnCerrarPedido4.Enabled = True
        End Select

        If cbTipoProd.Text = "Carne" Or cbTipoProd.Text = "Pollo" Or cbTipoProd.Text = "Cerdo" Then
            ds.Tables.Add("Stock")
            da.SelectCommand = New OleDbCommand("SELECT * FROM stock WHERE nombre = '" & cbTipoProd.Text & "'", Conexion)
            da.Fill(ds.Tables("Stock"))

            cantidadStock = ds.Tables("Stock").Rows(0)("cantidad") - cantidadStock

            row = ds.Tables("Stock").Rows(0)
            row("nombre") = cbTipoProd.Text
            row("cantidad") = cantidadStock

            da.UpdateCommand = New OleDbCommand("UPDATE stock SET cantidad= @cant WHERE nombre = @nom", Conexion)
            da.UpdateCommand.Parameters.Add("@cant", OleDbType.BigInt, 5, "cantidad")
            da.UpdateCommand.Parameters.Add("@nom", OleDbType.VarChar, 10, "nombre")
            da.Update(ds.Tables("Stock"))
        End If

        CalculaMonto(numero)
        'PintarMesaOcupada()
    End Sub

    Private Sub ActivarBotonCerrarPedido()
        numeroMesa = 100
        For i As Integer = 1 To 4
            comando = New OleDbCommand("SELECT * FROM mesas_productos WHERE id_mesa=" & numeroMesa, Conexion)
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                Select Case numeroMesa
                    Case 100
                        btnCerrarPedido1.Enabled = True
                    Case 101
                        btnCerrarPedido2.Enabled = True
                    Case 102
                        btnCerrarPedido3.Enabled = True
                    Case 103
                        btnCerrarPedido4.Enabled = True
                End Select
            Else
                Select Case numeroMesa
                    Case 100
                        btnCerrarPedido1.Enabled = False
                    Case 101
                        btnCerrarPedido2.Enabled = False
                    Case 102
                        btnCerrarPedido3.Enabled = False
                    Case 103
                        btnCerrarPedido4.Enabled = False
                End Select
            End If
            numeroMesa += 1
        Next

    End Sub

    Private Sub CompletarDataGridView()
        ds.Tables.Add("MesasProductos1")
        numeroMesa = 100
        da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)
        da.Fill(ds.Tables("MesasProductos1"))
        dgvProductos1.DataSource = ds.Tables("MesasProductos1").DefaultView
        dgvProductos1.Columns(0).HeaderText = "Nombre"
        dgvProductos1.Columns(1).HeaderText = "Tipo"
        dgvProductos1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ds.Tables.Add("MesasProductos2")
        numeroMesa = 101
        da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)
        da.Fill(ds.Tables("MesasProductos2"))
        dgvProductos2.DataSource = ds.Tables("MesasProductos2").DefaultView
        dgvProductos2.Columns(0).HeaderText = "Nombre"
        dgvProductos2.Columns(1).HeaderText = "Tipo"
        dgvProductos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ds.Tables.Add("MesasProductos3")
        numeroMesa = 102
        da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)
        da.Fill(ds.Tables("MesasProductos3"))
        dgvProductos3.DataSource = ds.Tables("MesasProductos3").DefaultView
        dgvProductos3.Columns(0).HeaderText = "Nombre"
        dgvProductos3.Columns(1).HeaderText = "Tipo"
        dgvProductos3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ds.Tables.Add("MesasProductos4")
        numeroMesa = 103
        da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)
        da.Fill(ds.Tables("MesasProductos4"))
        dgvProductos4.DataSource = ds.Tables("MesasProductos4").DefaultView
        dgvProductos4.Columns(0).HeaderText = "Nombre"
        dgvProductos4.Columns(1).HeaderText = "Tipo"
        dgvProductos4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

End Class