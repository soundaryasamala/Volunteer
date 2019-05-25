Public Class LoginForm

    Private service As LoginService
    Public Sub New()
        service = New LoginService()
        InitializeComponent()

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim Id As Integer = service.ValidateLogin(UserId.Text, Password.Text)

        If (Id <> 0) Then

            Dim obj1 As Form_Events = New Form_Events(Id)
            obj1.Show()
            Me.Hide()

        Else
            MsgBox("Invalid User or Password")
        End If


    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click

        Dim Id As Integer = service.ValidateUser(UserId.Text)

        If Id = 0 Then
            service.AddUser(UserId.Text, Password.Text)
        Else
            MsgBox("User Already Exist!")
        End If

        UserId.Text = String.Empty
        Password.Text = String.Empty

    End Sub
End Class