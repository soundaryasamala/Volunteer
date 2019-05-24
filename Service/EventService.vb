Public Class EventService
    Private repo As EventRepository
    Public Sub New()
        repo = New EventRepository()
    End Sub


    Public Function GetEvents(ByVal User As Integer) As DataTable
        Return repo.GetEvents(User)
    End Function

    Public Function GetEvent(ByVal User As Integer, ByVal eventId As Integer) As Events
        Return repo.GetEvent(User, eventId)
    End Function

    Public Sub AddEvent(ByVal User As Integer, ByVal events As Events)
        repo.AddEvent(User, events)
    End Sub


    Public Sub DeleteEvent(ByVal User As Integer, ByVal eventId As Integer)
        repo.DeleteEvent(User, eventId)
    End Sub

    Public Sub UpdateEvent(ByVal User As Integer, ByVal eventId As Integer, ByVal events As Events)
        repo.UpdateEvent(User, eventId, events)
    End Sub


End Class
