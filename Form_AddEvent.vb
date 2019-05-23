Public Class Form_AddEvent

    Dim userId As Integer

    Dim service As EventService
    Public Sub New(ByRef user As Integer)

        userId = user
        ' This call is required by the designer.
        InitializeComponent()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim obj1 As Form_Events = New Form_Events(userId)
        obj1.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim events As Events = New Events()

        service.AddEvent(userId, events)

        Dim obj1 As Form_Events = New Form_Events(userId)
        obj1.Show()
        Me.Hide()

    End Sub
End Class