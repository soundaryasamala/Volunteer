Public Class Form_Events

    Dim userId As Integer

    Public Sub New(ByRef user As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        userId = user
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Volunteers_Click(sender As Object, e As EventArgs) Handles Volunteers.Click

    End Sub
End Class