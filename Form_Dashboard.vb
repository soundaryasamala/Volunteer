Public Class Main_Form

    Private service As VolunteerService
    Public Sub New()
        service = New VolunteerService()
        InitializeComponent()
        BindGrid()
    End Sub

    Private Sub BindGrid()

        DataGridView1.DataSource = service.GetVolunteersGrid()

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim obj1 As Add_Volunteer = New Add_Volunteer()
        obj1.Show()
        Me.Hide()
    End Sub

    Private Sub Search_text_TextChanged(sender As Object, e As EventArgs) Handles search_text.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class