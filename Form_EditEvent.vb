Public Class EditEvent

    Dim userId As Integer
    Dim eventId As Integer

    Dim service As EventService
    Public Sub New(ByVal user As Integer, ByVal eventinfo As Integer)

        userId = user
        eventId = eventinfo
        ' This call is required by the designer.
        InitializeComponent()
        FillForm()

    End Sub

    Private Sub FillForm()
        Dim events As Events = service.GetEvent(userId, eventId)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim events As Events = New Events()

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