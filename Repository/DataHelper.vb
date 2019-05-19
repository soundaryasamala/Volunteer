Imports System.Data.SqlClient

Public Class DataHelper



    Public Function ExecuteQuery(ByVal query As String, ByVal paramters As Array) As DataSet

        Using conn As SqlConnection = New SqlConnection(My.Settings.Setting)

            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim dataset As DataSet = New DataSet()

            conn.Open()
            Using dataAdapter As SqlDataAdapter = New SqlDataAdapter()
                dataAdapter.SelectCommand = cmd
                dataAdapter.Fill(dataset, "Table1")


            End Using
            Return dataset

        End Using




    End Function

    Public Function ExecuteNonQuery(ByVal query As String, ByVal paramters As Array)

        Using conn As SqlConnection = New SqlConnection(My.Settings.connString)

            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            cmd.Parameters.AddRange(paramters)

            conn.Open()
            Return cmd.ExecuteNonQuery()

        End Using



    End Function


End Class
