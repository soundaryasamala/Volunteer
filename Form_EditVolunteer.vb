Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
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
        Try
            DOB.Value = volunteer.Dob
        Catch
            DOB.Value = Date.Now
        End Try

        WorkStatusField.DataSource = [Enum].GetValues(GetType(WorkStatus))
        WorkStatusField.SelectedItem = WorkStatus.Working
        SkillField.DataSource = [Enum].GetValues(GetType(Skills))
        VeteranStausField.DataSource = [Enum].GetValues(GetType(VeteranStatus))
        VolunteerStatusField.DataSource = [Enum].GetValues(GetType(VolunteerStatus))
        EducationField.DataSource = [Enum].GetValues(GetType(Education))

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


        If (vol.Title Is Nothing Or vol.Title Is String.Empty) Then
            MsgBox("Enter Volunteer Title")
            Return
        End If

        If (vol.Name Is Nothing Or vol.Name Is String.Empty) Then
            MsgBox("Enter Volunteer Name")
            Return
        End If

        If (vol.MobileNo Is Nothing Or Not IsNumeric(vol.MobileNo)) Then
            MsgBox("Enter Valid MobileNo")
            Return
        End If

        If (vol.HomePhoneNo Is Nothing Or Not IsNumeric(vol.HomePhoneNo)) Then
            MsgBox("Enter Valid Phone number")
            Return
        End If

        service.EditVolunteer(Volunteer_Id, vol, PictureBox1.Image)

        Dim obj1 As Volunteer_Form = New Volunteer_Form(User)
        obj1.Show()
        Me.Hide()
    End Sub

    Public Shared Function ResizeImage(ByVal image As Image,
      ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                    percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function

    Private Sub EditPhoto_Click(sender As Object, e As EventArgs) Handles EditPhoto.Click

        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = ResizeImage(Image.FromFile(OpenFileDialog1.FileName), New Size(PictureBox1.Height, PictureBox1.Width))

        End If
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click

        Dim obj1 As LoginForm = New LoginForm()
        obj1.Show()
        Me.Hide()

    End Sub
End Class