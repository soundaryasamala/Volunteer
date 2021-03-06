﻿Public Class Volunteer_Form

    Private service As VolunteerService
    Private user As Integer
    Public Sub New(userId As Integer)
        service = New VolunteerService()
        InitializeComponent()
        user = userId
        BindGrid()
    End Sub

    Private Sub BindGrid()

        DataGridView1.DataSource = service.GetVolunteersGrid()

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim obj1 As Add_Volunteer = New Add_Volunteer(user)
        obj1.Show()
        Me.Hide()
    End Sub

    Private Sub Search_text_TextChanged(sender As Object, e As EventArgs) Handles search_text.TextChanged

        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = DataGridView1.DataSource
        bs.Filter = "Name like '%" + search_text.Text + "%'"
        DataGridView1.DataSource = bs
    End Sub


    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        Dim isSelected As Boolean
        For Each row As DataGridViewRow In DataGridView1.Rows
            isSelected = Convert.ToBoolean(row.Cells("CheckBox").Value)
            If isSelected Then
                service.DeleteVolunteer(Convert.ToInt32(row.Cells("ID").Value))
            End If
        Next
        If isSelected = False Then
            MsgBox("No Volunteers are Selected")
        End If
        DataGridView1.DataSource = service.GetVolunteersGrid()


    End Sub


    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        Dim isSelected As Boolean
        For Each row As DataGridViewRow In DataGridView1.Rows
            isSelected = Convert.ToBoolean(row.Cells("CheckBox").Value)
            If isSelected Then
                Dim obj1 As Form_EditVolunteer = New Form_EditVolunteer(user, Convert.ToInt32(row.Cells("ID").Value))
                obj1.Show()
                Me.Hide()
                Exit For
            End If
        Next
        If isSelected = False Then
            MsgBox("No Volunteers are Selected")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj1 As Form_Events = New Form_Events(user)
        obj1.Show()
        Me.Hide()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click

        Dim obj1 As LoginForm = New LoginForm()
        obj1.Show()
        Me.Hide()

    End Sub
End Class