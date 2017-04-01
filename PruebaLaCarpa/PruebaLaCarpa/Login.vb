Imports System.Data.OleDb

Public Class Login

    Private comando As OleDbCommand
    Private dataReader As OleDbDataReader

    Private tipoAcceso As Integer
    Private second As Integer

    Private usuarioBooleano As Boolean = False
    Private contraseniaBooleano As Boolean = False


    'MÉTODOS PARA VALIDAR CONEXIÓN (DANDO CLIC AL BOTÓN O APRETANDO ENTER)

    Private Sub btIniciar_Click(sender As Object, e As EventArgs) Handles btIniciar.Click
        ValidarConexion()
    End Sub

    Private Sub TbContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles TbContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            ValidarConexion()
        End If
    End Sub

    Private Sub TbUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TbUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            TbContraseña.Focus()
        End If
    End Sub


    'MÉTODO QUE DETERMINA CUÁL ES EL NIVEL DE ACCESO QUE TIENE EL USUARIO INGRESADO

    Public Shared Function NivelAcceso() As Integer
        Return Login.tipoAcceso
    End Function


    'MÉTODOS QUE ACTIVAN EL BOTÓN PARA INGRESAR

    Private Sub TbUsuario_TextChanged(sender As Object, e As EventArgs) Handles TbUsuario.TextChanged
        If TbUsuario.Text <> "" Then
            usuarioBooleano = True
            If contraseniaBooleano = True Then
                btIniciar.Enabled = True
                btIniciar.Visible = True
                Me.Size = New System.Drawing.Size(254, 306)
                End If
            ElseIf TbUsuario.Text = "" Then
            usuarioBooleano = False
            btIniciar.Enabled = False
            btIniciar.Visible = False
            Me.Size = New System.Drawing.Size(254, 190)
        End If

    End Sub

    Private Sub TbContraseña_TextChanged(sender As Object, e As EventArgs) Handles TbContraseña.TextChanged
        If TbContraseña.Text <> "" Then
            contraseniaBooleano = True
            If usuarioBooleano = True Then
                btIniciar.Enabled = True
                btIniciar.Visible = True
                Me.Size = New System.Drawing.Size(254, 306)
            End If
        ElseIf TbContraseña.Text = "" Then
            contraseniaBooleano = False
            btIniciar.Enabled = False
            btIniciar.Visible = False
            Me.Size = New System.Drawing.Size(254, 190)
        End If

    End Sub


    'MÉTODO QUE REALIZA LA CONEXIÓN

    Private Sub ValidarConexion()
        MsgBox("SDSDSD")
        Conectarse()
        comando = New OleDbCommand("SELECT tipo_acceso FROM usuarios WHERE nombre='" & TbUsuario.Text & "' AND contrasenia='" & TbContraseña.Text & "'", Conexion)

        dataReader = comando.ExecuteReader()

        If dataReader.HasRows Then
            While dataReader.Read()
                tipoAcceso = dataReader("tipo_acceso")
            End While
            Principal.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o password incorrectos", MsgBoxStyle.Exclamation)
        End If

        dataReader.Close()
        Desconectarse()
    End Sub

    Private Sub btIniciar_MouseHover(sender As Object, e As EventArgs) Handles btIniciar.MouseHover
        btIniciar.Location = New Point(btIniciar.Location.X - 5, btIniciar.Location.Y - 5)
        btIniciar.Size = New Point(btIniciar.Size.Width + 10, btIniciar.Size.Height + 10)
    End Sub

    Private Sub btIniciar_MouseLeave(sender As Object, e As EventArgs) Handles btIniciar.MouseLeave
        btIniciar.Location = New Point(btIniciar.Location.X + 5, btIniciar.Location.Y + 5)
        btIniciar.Size = New Point(btIniciar.Size.Width - 10, btIniciar.Size.Height - 10)
    End Sub

End Class