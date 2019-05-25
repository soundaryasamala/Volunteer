Public Class LoginService

    Private repo As LoginRepository
    Public Sub New()
        repo = New LoginRepository()
    End Sub

    Public Function ValidateLogin(ByVal UserId As String, ByVal Password As String) As Integer

        Return repo.ValidateLogin(UserId, Password)

    End Function

    Friend Function ValidateUser(UserId As String) As Boolean
        Return repo.ValidateUser(UserId)
    End Function

    Friend Sub AddUser(UserId As String, Password As String)
        repo.AddUser(UserId, Password)
    End Sub
End Class
