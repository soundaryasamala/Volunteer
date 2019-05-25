Imports desktop_app_mark_1
Imports System.Drawing

Public Class VolunteerService

    Private repo As VolunteerRepository
    Public Sub New()
        repo = New VolunteerRepository()
    End Sub
    Public Function GetVolunteers() As List(Of Volunteer)

        Return repo.GetVolunteers()

    End Function

    Public Function GetVolunteersGrid() As DataTable

        Return repo.GetVolunteersGrid()

    End Function

    Public Function AddVolunteer(ByVal vol As Volunteer, ByVal image As Image)

        repo.AddVolunteer(vol, image)

    End Function

    Public Function DeleteVolunteer(ByVal id As Integer)

        repo.DeleteVolunteer(id)
    End Function

    Public Function GetVolunteer(ByVal id As Integer) As Volunteer

        Return repo.GetVolunteer(id)

    End Function

    Public Function EditVolunteer(volunteer_Id As Integer, vol As Volunteer, image As Image)

        repo.EditVolunteer(volunteer_Id, vol, image)

    End Function
End Class
