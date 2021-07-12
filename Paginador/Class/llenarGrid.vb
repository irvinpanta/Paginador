Imports System.Data.SqlClient
Public Class llenarGrid
    Inherits Config

    Private cmd As New SqlCommand

    Public Function llenarGrid(xFlag As Integer, xCriterio As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("[paAviProdudctosConsultar]")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            With cmd
                .Parameters.AddWithValue("@xFlag", xFlag)
                .Parameters.AddWithValue("@xCriterio", xCriterio)
            End With

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

End Class
