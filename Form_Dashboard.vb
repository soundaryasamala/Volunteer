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

        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = DataGridView1.DataSource
        bs.Filter = "Name like '%" + search_text.Text + "%'"
        DataGridView1.DataSource = bs
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Try


            service.DeleteVolunteer(Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value))
        Catch ex As Exception
            service.DeleteVolunteer(DataGridView1.Rows.Count - 1)


        End Try

        DataGridView1.DataSource = service.GetVolunteersGrid()


    End Sub
End Class