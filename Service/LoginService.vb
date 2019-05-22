Public Class LoginService

    Private repo As LoginRepository
    Public Sub New()
        repo = New LoginRepository()
    End Sub

    Public Function ValidateLogin(ByVal UserId As String, ByVal Password As String) As Integer

        Return repo.ValidateLogin(UserId, Password)

    End Function


End Class
