Public Class Form_Events

    Dim userId As Integer
    Dim service As EventService

    Public Sub New(ByVal user As Integer)

        userId = user
        service = New EventService()
        InitializeComponent()
        BindGrid()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BindGrid()

        DataGridView1.DataSource = service.GetEvents(userId)

    End Sub

    Private Sub Volunteers_Click(sender As Object, e As EventArgs) Handles Volunteers.Click

        Dim obj1 As Volunteer_Form = New Volunteer_Form(userId)
        obj1.Show()
        Me.Hide()

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Dim obj1 As Form_AddEvent = New Form_AddEvent(userId)
        obj1.Show()
        Me.Hide()

    End Sub


    Private Sub Search_text_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged

        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = DataGridView1.DataSource
        bs.Filter = "Name like '%" + search.Text + "%'"
        DataGridView1.DataSource = bs
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click

        Dim isSelected As Boolean
        For Each row As DataGridViewRow In DataGridView1.Rows
            isSelected = Convert.ToBoolean(row.Cells("CheckBox").Value)
            If isSelected Then
                Dim obj1 As EditEvent = New EditEvent(userId, Convert.ToInt32(row.Cells("ID").Value))
                obj1.Show()
                Me.Hide()
                Exit For
            End If
        Next
        If isSelected = False Then
            MsgBox("No Events are Selected")
        End If

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        Dim isSelected As Boolean
        For Each row As DataGridViewRow In DataGridView1.Rows
            isSelected = Convert.ToBoolean(row.Cells("CheckBox").Value)
            If isSelected Then
                service.DeleteEvent(userId, Convert.ToInt32(row.Cells("ID").Value))
            End If
        Next
        If isSelected = False Then
            MsgBox("No Events are Selected")
        End If
        DataGridView1.DataSource = service.GetEvents(userId)

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click

        Dim obj1 As LoginForm = New LoginForm()
        obj1.Show()
        Me.Hide()

    End Sub
End Class