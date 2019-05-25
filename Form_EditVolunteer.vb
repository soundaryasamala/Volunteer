Imports System.Data.SqlClient
Imports System.IO

Public Class Form_EditVolunteer

    Dim Volunteer_Id As Integer
    Dim User As Integer
    Private service As VolunteerService
    Public Sub New(ByVal userId As Integer, ByVal Id As Integer)

        Volunteer_Id = Id
        User = userId
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

        Dim constr As String = My.Settings.connString
        Try
            Using conn As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand("SELECT Image FROM Volunteer WHERE Id = @Id", conn)
                    cmd.Parameters.AddWithValue("@Id", Volunteer_Id)
                    conn.Open()
                    Dim bytes As Byte() = CType(cmd.ExecuteScalar(), Byte())
                    conn.Close()
                    PictureBox1.Image = Image.FromStream(New MemoryStream(bytes))
                End Using
            End Using
        Catch e As Exception

        End Try

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj1 As Volunteer_Form = New Volunteer_Form(User)
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

        service.EditVolunteer(Volunteer_Id, vol, PictureBox1.Image)

        Dim obj1 As Volunteer_Form = New Volunteer_Form(User)
        obj1.Show()
        Me.Hide()
    End Sub



    Private Sub EditPhoto_Click(sender As Object, e As EventArgs) Handles EditPhoto.Click

        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class