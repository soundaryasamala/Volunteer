﻿Public Class EventRepository


    Public Function GetEvents(ByVal User As Integer) As List(Of Events)

    End Function

    Public Function GetEvent(ByVal User As Integer, ByVal eventId As Integer) As Events

    End Function

    Public Sub AddEvent(ByVal User As Integer, ByVal events As Events)

    End Sub


    Public Sub DeleteEvent(ByVal User As Integer, ByVal eventId As Integer)

    End Sub

    Public Sub UpdateEvent(ByVal User As Integer, ByVal eventId As Integer, ByVal events As Events)

    End Sub

End Class
