﻿Public Class Form_AddEvent

    Dim userId As Integer

    Dim service As EventService

    Dim volunteerService As VolunteerService
    Public Sub New(ByRef user As Integer)

        userId = user
        service = New EventService()
        volunteerService = New VolunteerService()
        ' This call is required by the designer.
        InitializeComponent()
        Me.volunteer.DataSource = volunteerService.GetVolunteersGrid()
        Me.volunteer.DisplayMember = "Name"
        Me.volunteer.ValueMember = "ID"

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim obj1 As Form_Events = New Form_Events(userId)
        obj1.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim events As Events = New Events()



        events.Name = EventName.Text
        events.Type = Type.Text
        events.Notes = Notes.Text
        events.EventDate = EventDate.Value
        events.EventVolunteerDetails = New List(Of VolunteerDetails)

        If (events.Name Is Nothing Or events.Name Is String.Empty) Then
            MsgBox("Enter Event name")
            Return
        End If

        If (events.Type Is Nothing Or events.Type Is String.Empty) Then
            MsgBox("Enter Event Type")
            Return
        End If

        For Each r As DataGridViewRow In DataGridView1.Rows
            If (r.Index <> DataGridView1.Rows.Count - 1) Then

                Dim vol As VolunteerDetails = New VolunteerDetails()
                If r.Cells("Volunteer").Value = Nothing Then
                    MsgBox("Select Volunteer!")
                    Return
                End If
                If r.Cells("Hours").Value = Nothing Or Not IsNumeric(r.Cells("Hours").Value) Then
                    MsgBox("Enter Valid Hours!")
                    Return
                End If
                If r.Cells("ShiftStart").Value = Nothing Or Not IsDate(r.Cells("ShiftStart").Value) Then
                    MsgBox("Enter Valid Shift Start Time!")
                    Return
                End If
                If r.Cells("ShiftEnd").Value = Nothing Or Not IsDate(r.Cells("ShiftEnd").Value) Then
                    MsgBox("Enter Valid Shift Start Time!")
                    Return
                End If
                If r.Cells("Expenses").Value = Nothing Or Not IsNumeric(r.Cells("Expenses").Value) Then
                    MsgBox("Enter Valid Expense amounts!")
                    Return
                End If
                If r.Cells("Reimbursements").Value = Nothing Or Not IsNumeric(r.Cells("Reimbursements").Value) Then
                    MsgBox("Enter Valid Reimbursement amounts!")
                    Return
                End If

                vol.VolunteerId = r.Cells("Volunteer").Value
                vol.ShiftEnd = r.Cells("ShiftStart").Value
                vol.ShiftStart = r.Cells("ShiftEnd").Value
                vol.Hours = r.Cells("Hours").Value
                vol.Expenses = r.Cells("Expenses").Value
                vol.Reimbursements = r.Cells("Reimbursements").Value
                events.EventVolunteerDetails.Add(vol)
            End If
        Next

        service.AddEvent(userId, events)

        Dim obj1 As Form_Events = New Form_Events(userId)
        obj1.Show()
        Me.Hide()

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click

        Dim obj1 As LoginForm = New LoginForm()
        obj1.Show()
        Me.Hide()

    End Sub
End Class