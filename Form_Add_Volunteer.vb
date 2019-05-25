Imports System.Drawing.Drawing2D

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
        service.AddVolunteer(vol, PictureBox1.Image)

        Dim obj1 As Volunteer_Form = New Volunteer_Form(user)
        obj1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim obj1 As Volunteer_Form = New Volunteer_Form(user)
        obj1.Show()
        Me.Hide()
    End Sub

    Private Sub UploadPhoto_Click(sender As Object, e As EventArgs) Handles UploadPhoto.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = ResizeImage(Image.FromFile(OpenFileDialog1.FileName), New Size(PictureBox1.Height, PictureBox1.Width))
        End If
    End Sub

    ' Visual Basic
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
End Class