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

    Public Function AddVolunteer()


    End Function

    Public Function DeleteVolunteer()

    End Function

    Public Function GetVolunteer(ByVal id As Integer) As Volunteer

        Return repo.GetVolunteer(id)

    End Function


End Class
