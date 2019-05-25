Public Class Form_AddEvent

    Dim userId As Integer

    Dim service As EventService

    Dim volunteerService As VolunteerService
    Public Sub New(ByRef user As Integer)

        userId = user
        service = New EventService()
        volunteerService = New VolunteerService()
        ' This call is required by the designer.
        InitializeComponent()
        FillVolunteer(0)

    End Sub

    Private Sub FillVolunteer(ByVal index As Integer)

        Dim dt As DataTable = volunteerService.GetVolunteersGrid()

        Dim cbCell As DataGridViewComboBoxCell = DataGridView1.Rows(index).Cells("Volunteer")

        Dim list As List(Of String) = New List(Of String)


        For Each r As DataRow In dt.Rows

            list.Add(r.Item("NAME"))

        Next

        cbCell.Items.AddRange(list.ToArray())

        cbCell.DataSource = dt

        cbCell.DisplayMember = "NAME"

        cbCell.ValueMember = "ID"




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



    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        FillVolunteer(e.RowIndex)
    End Sub


End Class