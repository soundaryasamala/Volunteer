Public Class EditEvent

    Dim userId As Integer
    Dim eventId As Integer

    Dim service As EventService
    Public Sub New(ByVal user As Integer, ByVal eventinfo As Integer)

        userId = user
        eventId = eventinfo
        ' This call is required by the designer.
        InitializeComponent()
        service = New EventService()
        FillForm()

    End Sub

    Private Sub FillForm()
        Dim events As Events = service.GetEvent(userId, eventId)
        EventName.Text = events.Name
        EventType.Text = events.Type
        Notes.Text = events.Notes
        EventDate.Value = events.EventDate

        DataGridView1.DataSource = events.EventVolunteerDetails

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim events As Events = New Events()

        events.Name = EventName.Text
        events.Type = EventType.Text
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
            vol.ShiftEnd = r.Cells("Shift Start Time").Value
            vol.ShiftStart = r.Cells("Shift End Time").Value
            vol.Hours = r.Cells("Hours").Value
            vol.Expenses = r.Cells("Expenses").Value
            vol.Reimbursements = r.Cells("Reimbursements").Value
            events.EventVolunteerDetails.Add(vol)
        Next

        service.UpdateEvent(userId, eventId, events)


        Dim obj1 As Form_Events = New Form_Events(userId)
        obj1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim obj1 As Form_Events = New Form_Events(userId)
        obj1.Show()
        Me.Hide()
    End Sub
End Class