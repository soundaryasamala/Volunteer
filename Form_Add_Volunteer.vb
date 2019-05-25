Public Class Add_Volunteer

    Private service As VolunteerService
    Private user As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        service = New VolunteerService()
        user = userId

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim vol As Volunteer = New Volunteer()
        vol.Title = Title.Text
        vol.Name = Name_Text.Text
        vol.Address = Address.Text
        vol.MobileNo = MobileNo.Text
        vol.HomePhoneNo = HomeNo.Text
        service.AddVolunteer(vol)

        Dim obj1 As Volunteer_Form = New Volunteer_Form(user)
        obj1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim obj1 As Volunteer_Form = New Volunteer_Form(user)
        obj1.Show()
        Me.Hide()
    End Sub
End Class