Public Class LoginForm

    Private service As LoginService
    Public Sub New()
        service = New LoginService()
        InitializeComponent()

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim Id As Boolean = service.ValidateLogin(UserId.Text, Password.Text)

        If (Id <> 0) Then

            Dim obj1 As Form_Events = New Form_Events(Id)
            obj1.Show()
            Me.Hide()

        Else
            MsgBox("Invalid User or Password")
        End If


    End Sub
End Class