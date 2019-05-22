Public Class LoginRepository

    Dim dataHelper As DataHelper

    Public Sub New()
        dataHelper = New DataHelper()
    End Sub

    Public Function ValidateLogin(ByVal UserId As String, ByVal Password As String) As Integer

        Dim query As String = $"Select ID from Login where UserId = '{UserId}' and Password = '{Password }'"

        Dim dt As DataTable = dataHelper.ExecuteQuery(query, Nothing).Tables(0)

        Dim user As Integer = 0

        If (dt.Rows.Count > 0) Then

            user = dt.Rows(0)("ID")

        End If

        Return user


    End Function

End Class
