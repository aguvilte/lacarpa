Imports PruebaLaCarpa.Mesas
Imports System.Data.OleDb

Public Class Principal

    Private daMesas As OleDbDataAdapter
    Private ds As DataSet
    Private comando As OleDbCommand

    Dim _numeroMesa As Integer
    Dim mesaOcupadaBoolean As Boolean

    Dim nuevaVentana As Boolean = False

    Public Shared Function NumeroMesa() As Integer
        Return Principal._numeroMesa
    End Function

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip()
        Select Case Login.NivelAcceso
            Case 1
                btStock.Enabled = True
            Case 2
                btStock.Visible = False
        End Select
        MesaOcupada()
    End Sub

    Private Sub MesasClick(numeroMesa As Integer)
        nuevaVentana = True
        _numeroMesa = numeroMesa
        Mesas1.Show()
        Me.Close()
    End Sub

    Private Sub DeliveryClick(numeroDelivery As Integer)
        nuevaVentana = True
        _numeroMesa = numeroDelivery
        Delivery.Show()
        Me.Close()
    End Sub

    Private Sub mesa1_Click(sender As Object, e As EventArgs) Handles mesa1.Click
        MesasClick(1)
    End Sub

    Private Sub mesa2_Click(sender As Object, e As EventArgs) Handles mesa2.Click
        MesasClick(2)
    End Sub

    Private Sub mesa3_Click(sender As Object, e As EventArgs) Handles mesa3.Click
        MesasClick(3)
    End Sub

    Private Sub mesa4_Click(sender As Object, e As EventArgs) Handles mesa4.Click
        MesasClick(4)
    End Sub

    Private Sub mesa5_Click(sender As Object, e As EventArgs) Handles mesa5.Click
        MesasClick(5)
    End Sub

    Private Sub mesa6_Click(sender As Object, e As EventArgs) Handles mesa6.Click
        MesasClick(6)
    End Sub

    Private Sub mesa7_Click(sender As Object, e As EventArgs) Handles mesa7.Click
        MesasClick(7)
    End Sub

    Private Sub mesa8_Click(sender As Object, e As EventArgs) Handles mesa8.Click
        MesasClick(8)
    End Sub

    Private Sub mesa9_Click(sender As Object, e As EventArgs) Handles mesa9.Click
        MesasClick(9)
    End Sub

    Private Sub mesa10_Click(sender As Object, e As EventArgs) Handles mesa10.Click
        MesasClick(10)
    End Sub

    Private Sub mesa11_Click(sender As Object, e As EventArgs) Handles mesa11.Click
        MesasClick(11)
    End Sub

    Private Sub mesa20_Click(sender As Object, e As EventArgs) Handles mesa20.Click
        MesasClick(20)
    End Sub

    Private Sub mesa21_Click(sender As Object, e As EventArgs) Handles mesa21.Click
        MesasClick(21)
    End Sub

    Private Sub mesa22_Click(sender As Object, e As EventArgs) Handles mesa22.Click
        MesasClick(22)
    End Sub

    Private Sub mesa23_Click(sender As Object, e As EventArgs) Handles mesa23.Click
        MesasClick(23)
    End Sub

    Private Sub mesa24_Click(sender As Object, e As EventArgs) Handles mesa24.Click
        MesasClick(24)
    End Sub

    Private Sub mesa25_Click(sender As Object, e As EventArgs) Handles mesa25.Click
        MesasClick(25)
    End Sub

    Private Sub mesa26_Click(sender As Object, e As EventArgs) Handles mesa26.Click
        MesasClick(26)
    End Sub

    Private Sub mesa27_Click(sender As Object, e As EventArgs) Handles mesa27.Click
        MesasClick(27)
    End Sub

    Private Sub mesa28_Click(sender As Object, e As EventArgs) Handles mesa28.Click
        MesasClick(28)
    End Sub

    Private Sub mesa29_Click(sender As Object, e As EventArgs) Handles mesa29.Click
        MesasClick(29)
    End Sub

    Private Sub mesa30_Click(sender As Object, e As EventArgs) Handles mesa30.Click
        MesasClick(30)
    End Sub

    Private Sub mesa31_Click(sender As Object, e As EventArgs) Handles mesa31.Click
        MesasClick(31)
    End Sub

    Private Sub mesa40_Click(sender As Object, e As EventArgs) Handles mesa40.Click
        MesasClick(40)
    End Sub

    Private Sub mesa41_Click(sender As Object, e As EventArgs) Handles mesa41.Click
        MesasClick(41)
    End Sub

    Private Sub mesa42_Click(sender As Object, e As EventArgs) Handles mesa42.Click
        MesasClick(42)
    End Sub

    Private Sub mesa43_Click(sender As Object, e As EventArgs) Handles mesa43.Click
        MesasClick(43)
    End Sub

    Private Sub mesa44_Click(sender As Object, e As EventArgs) Handles mesa44.Click
        MesasClick(44)
    End Sub

    Private Sub mesa45_Click(sender As Object, e As EventArgs) Handles mesa45.Click
        MesasClick(45)
    End Sub

    Private Sub mesa46_Click(sender As Object, e As EventArgs) Handles mesa46.Click
        MesasClick(46)
    End Sub

    Private Sub mesa47_Click(sender As Object, e As EventArgs) Handles mesa47.Click
        MesasClick(47)
    End Sub

    Private Sub mesa48_Click(sender As Object, e As EventArgs) Handles mesa48.Click
        MesasClick(48)
    End Sub

    Private Sub mesa49_Click(sender As Object, e As EventArgs) Handles mesa49.Click
        MesasClick(49)
    End Sub

    Private Sub mesa50_Click(sender As Object, e As EventArgs) Handles mesa50.Click
        MesasClick(50)
    End Sub

    Private Sub mesa51_Click(sender As Object, e As EventArgs) Handles mesa51.Click
        MesasClick(51)
    End Sub

    Public Sub MesaOcupada()
        daMesas = New OleDbDataAdapter
        daMesas.SelectCommand = New OleDbCommand("SELECT ocupada FROM mesas", ConnectionDB.Conexion)
        ds = New DataSet
        ds.Tables.Add("Mesas")
        daMesas.Fill(ds.Tables("Mesas"))
        Dim valorOcupación As String

        'MESAS DEL 1 AL 11
        For i As Integer = 0 To 10
            valorOcupación = ds.Tables("Mesas").Rows(CInt(i)).Item("ocupada").ToString
            SelectModule(i + 1, valorOcupación)
        Next

        'MESAS DEL 20 AL 31
        For i As Integer = 11 To 22
            valorOcupación = ds.Tables("Mesas").Rows(CInt(i)).Item("ocupada").ToString
            SelectModule(i + 9, valorOcupación)
        Next

        'MESAS DEL 40 AL 51
        For i As Integer = 23 To 34
            valorOcupación = ds.Tables("Mesas").Rows(CInt(i)).Item("ocupada").ToString
            SelectModule(i + 17, valorOcupación)
        Next
    End Sub

    Public Sub SelectModule(j As Integer, bool As String)
        Select Case j
            Case 1
                If bool = "True" Then
                    mesa1.Image = My.Resources.table_128_red
                    lblMesa1.ForeColor = Color.DarkRed
                End If
            Case 2
                If bool = "True" Then
                    mesa2.Image = My.Resources.table_128_red
                    lblMesa2.ForeColor = Color.DarkRed
                End If
            Case 3
                If bool = "True" Then
                    mesa3.Image = My.Resources.table_128_red
                    lblMesa3.ForeColor = Color.DarkRed
                End If
            Case 4
                If bool = "True" Then
                    mesa4.Image = My.Resources.table_128_red
                    lblMesa4.ForeColor = Color.DarkRed
                End If
            Case 5
                If bool = "True" Then
                    mesa5.Image = My.Resources.table_128_red
                    lblMesa5.ForeColor = Color.DarkRed
                End If
            Case 6
                If bool = "True" Then
                    mesa6.Image = My.Resources.table_128_red
                    lblMesa6.ForeColor = Color.DarkRed
                End If
            Case 7
                If bool = "True" Then
                    mesa7.Image = My.Resources.table_128_red
                    lblMesa7.ForeColor = Color.DarkRed
                End If
            Case 8
                If bool = "True" Then
                    mesa8.Image = My.Resources.table_128_red
                    lblMesa8.ForeColor = Color.DarkRed
                End If
            Case 9
                If bool = "True" Then
                    mesa9.Image = My.Resources.table_128_red
                    lblMesa9.ForeColor = Color.DarkRed
                End If
            Case 10
                If bool = "True" Then
                    mesa10.Image = My.Resources.table_128_red
                    lblMesa10.ForeColor = Color.DarkRed
                End If
            Case 11
                If bool = "True" Then
                    mesa11.Image = My.Resources.table_128_red
                    lblMesa11.ForeColor = Color.DarkRed
                End If
            Case 20
                If bool = "True" Then
                    mesa20.Image = My.Resources.table_128_red
                    lblMesa20.ForeColor = Color.DarkRed
                End If
            Case 21
                If bool = "True" Then
                    mesa21.Image = My.Resources.table_128_red
                    lblMesa21.ForeColor = Color.DarkRed
                End If
            Case 22
                If bool = "True" Then
                    mesa22.Image = My.Resources.table_128_red
                    lblMesa22.ForeColor = Color.DarkRed
                End If
            Case 23
                If bool = "True" Then
                    mesa23.Image = My.Resources.table_128_red
                    lblMesa23.ForeColor = Color.DarkRed
                End If
            Case 24
                If bool = "True" Then
                    mesa24.Image = My.Resources.table_128_red
                    lblMesa24.ForeColor = Color.DarkRed
                End If
            Case 25
                If bool = "True" Then
                    mesa25.Image = My.Resources.table_128_red
                    lblMesa25.ForeColor = Color.DarkRed
                End If
            Case 26
                If bool = "True" Then
                    mesa26.Image = My.Resources.table_128_red
                    lblMesa26.ForeColor = Color.DarkRed
                End If
            Case 27
                If bool = "True" Then
                    mesa27.Image = My.Resources.table_128_red
                    lblMesa27.ForeColor = Color.DarkRed
                End If
            Case 28
                If bool = "True" Then
                    mesa28.Image = My.Resources.table_128_red
                    lblMesa28.ForeColor = Color.DarkRed
                End If
            Case 29
                If bool = "True" Then
                    mesa29.Image = My.Resources.table_128_red
                    lblMesa29.ForeColor = Color.DarkRed
                End If
            Case 30
                If bool = "True" Then
                    mesa30.Image = My.Resources.table_128_red
                    lblMesa30.ForeColor = Color.DarkRed
                End If
            Case 31
                If bool = "True" Then
                    mesa31.Image = My.Resources.table_128_red
                    lblMesa31.ForeColor = Color.DarkRed
                End If
            Case 40
                If bool = "True" Then
                    mesa40.Image = My.Resources.table_128_red
                    lblMesa40.ForeColor = Color.DarkRed
                End If
            Case 41
                If bool = "True" Then
                    mesa41.Image = My.Resources.table_128_red
                    lblMesa41.ForeColor = Color.DarkRed
                End If
            Case 42
                If bool = "True" Then
                    mesa42.Image = My.Resources.table_128_red
                    lblMesa42.ForeColor = Color.DarkRed
                End If
            Case 43
                If bool = "True" Then
                    mesa43.Image = My.Resources.table_128_red
                    lblMesa43.ForeColor = Color.DarkRed
                End If
            Case 44
                If bool = "True" Then
                    mesa44.Image = My.Resources.table_128_red
                    lblMesa44.ForeColor = Color.DarkRed
                End If
            Case 45
                If bool = "True" Then
                    mesa45.Image = My.Resources.table_128_red
                    lblMesa45.ForeColor = Color.DarkRed
                End If
            Case 46
                If bool = "True" Then
                    mesa46.Image = My.Resources.table_128_red
                    lblMesa46.ForeColor = Color.DarkRed
                End If
            Case 47
                If bool = "True" Then
                    mesa47.Image = My.Resources.table_128_red
                    lblMesa47.ForeColor = Color.DarkRed
                End If
            Case 48
                If bool = "True" Then
                    mesa48.Image = My.Resources.table_128_red
                    lblMesa48.ForeColor = Color.DarkRed
                End If
            Case 49
                If bool = "True" Then
                    mesa49.Image = My.Resources.table_128_red
                    lblMesa49.ForeColor = Color.DarkRed
                End If
            Case 50
                If bool = "True" Then
                    mesa50.Image = My.Resources.table_128_red
                    lblMesa50.ForeColor = Color.DarkRed
                End If
            Case 51
                If bool = "True" Then
                    mesa51.Image = My.Resources.table_128_red
                    lblMesa51.ForeColor = Color.DarkRed
                End If
        End Select
    End Sub

    Private Sub btDetallesVentas_Click(sender As Object, e As EventArgs) Handles btDetallesVentas.Click
        'Estadisticas.Show()
        'Me.Close()
        ToolTip()
    End Sub

    Private Sub btStock_Click(sender As Object, e As EventArgs) Handles btStock.Click
        nuevaVentana = True
        Stock.Show()
        Me.Close()
    End Sub

    Private Sub btnMesaRecepcion_Click(sender As Object, e As EventArgs) Handles btnMesaRecepcion.Click
        nuevaVentana = True
        MesaRecepcion.Show()
        Me.Close()

    End Sub

    Private Sub Bt1delivery_Click(sender As Object, e As EventArgs) Handles Bt1delivery.Click
        DeliveryClick(200)
    End Sub

    Private Sub Bt2delivery_Click(sender As Object, e As EventArgs) Handles Bt2delivery.Click
        DeliveryClick(300)
    End Sub

    Private Sub Bt3delivery_Click(sender As Object, e As EventArgs) Handles Bt3delivery.Click
        DeliveryClick(400)
    End Sub

    Private Sub btConfigurar_Click(sender As Object, e As EventArgs) Handles btConfigurar.Click
        nuevaVentana = True
        PrNuevoEdit.Show()
        Me.Close()
    End Sub

    Private Sub ToolTip()
        Dim toolTip1 As New ToolTip
        toolTip1.ShowAlways = True
        toolTip1.SetToolTip(Me.btDetallesVentas, "Deshabilitado")
    End Sub

    Private Sub btCerrarSesion_Click(sender As Object, e As EventArgs) Handles btCerrarSesion.Click
        If MsgBox("¿Está seguro que quiere cerrar el programa?", MsgBoxStyle.YesNo, "Cerrar programa") = MsgBoxResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If nuevaVentana = False Then
            If MsgBox("¿Está seguro que quiere cerrar el programa?", MsgBoxStyle.YesNo, "Cerrar programa") = MsgBoxResult.Yes Then
                Application.ExitThread()
            End If
        End If
    End Sub
End Class