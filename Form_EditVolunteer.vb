Public Class Form_EditVolunteer

    Dim Volunteer_Id As Integer
    Private service As VolunteerService
    Public Sub New(ByVal Id As Integer)

        Volunteer_Id = Id
        service = New VolunteerService()
        ' This call is required by the designer.
        InitializeComponent()
        FillForm()

    End Sub

    Private Sub FillForm()
        Dim volunteer As Volunteer = service.GetVolunteer(Volunteer_Id)
        Title.Text = volunteer.Title
        NameField.Text = volunteer.Name
        AddressField.Text = volunteer.Address
        Mobile.Text = volunteer.MobileNo
        HomeNo.Text = volunteer.HomePhoneNo
        'Email.Text = volunteer.Email(0)
        SSN.Text = volunteer.SSN
        DOB.Value = volunteer.Dob
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj1 As Main_Form = New Main_Form()
        obj1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim vol As Volunteer = New Volunteer()
        vol.Title = Title.Text
        vol.Name = NameField.Text
        vol.Address = AddressField.Text
        vol.MobileNo = Mobile.Text
        vol.HomePhoneNo = HomeNo.Text
        vol.Email = New List(Of String)
        vol.Email.Add(Email.Text)
        vol.SSN = SSN.Text
        vol.Dob = DOB.Value

        service.EditVolunteer(Volunteer_Id, vol)

        Dim obj1 As Main_Form = New Main_Form()
        obj1.Show()
        Me.Hide()
    End Sub
End Class