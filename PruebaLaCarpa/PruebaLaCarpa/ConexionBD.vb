﻿Imports System.Data.OleDb

Module ConnectionDB

    Private cadenaConexion As String
    Private miConexion As OleDbConnection

    Sub Conectarse()
        Try
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vilte\Desktop\Desktop\ProgramaciónFinalFinal\lacarpadb.accdb"
            miConexion = New OleDbConnection(cadenaConexion)
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Desconectarse()
        miConexion.Close()
    End Sub

    Function Conexion() As OleDbConnection
        Return miConexion
    End Function

End Module