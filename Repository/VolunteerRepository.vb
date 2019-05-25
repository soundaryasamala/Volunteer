Imports System.Data.SqlClient
Imports System.IO
Imports desktop_app_mark_1

Public Class VolunteerRepository

    Dim dataHelper As DataHelper

    Public Sub New()
        dataHelper = New DataHelper()
    End Sub


    Public Function GetVolunteers() As List(Of Volunteer)

        Dim query As String = "Select ID,TITLE,NAME FROM VOLUNTEER"
        Dim dt As DataTable = dataHelper.ExecuteQuery(query, Nothing).Tables(0)
        Dim volunteers As List(Of Volunteer) = New List(Of Volunteer)

        For Each row As DataRow In dt.Rows

            Dim volunteer As Volunteer = New Volunteer(row.Item("ID"), row.Item("TITLE"), row.Item("NAME"))
            volunteers.Add(volunteer)
        Next

        Return volunteers
    End Function

    Public Function GetVolunteersGrid() As DataTable

        Dim query As String = "Select ID,TITLE,NAME FROM VOLUNTEER"
        Dim dt As DataTable = dataHelper.ExecuteQuery(query, Nothing).Tables(0)

        Return dt
    End Function

    Public Sub EditVolunteer(volunteer_Id As Integer, vol As Volunteer, ByVal image As Image)

        If image Is Nothing Then
            Dim query As String = $"Update Volunteer Set
	 Title = '{vol.Title }',Name ='{vol.Name }',Address = '{vol.Address }',Work_STATUS_ID = 1,PHONE_HOME ='{vol.HomePhoneNo }',PHONE_MOBILE = '{vol.MobileNo}'
	,SOCIAL_SECURITY_NUMBER ='{vol.SSN }',DATE_OF_BIRTH = '{vol.Dob }',VOLUNTEER_STATUS = {Convert.ToInt32(vol.VolunteerStatus) },HIRE_DATE ='{vol.HireDate  }',NOTES = '{vol.Notes }'
     where ID = {volunteer_Id }"
            dataHelper.ExecuteNonQuery(query, Nothing)
        Else

            Using ms As New MemoryStream

                image.Save(ms, image.RawFormat)
                Dim par As SqlParameter = New SqlParameter("@image", ms.ToArray)
                Dim array As SqlParameter() = New SqlParameter(1) {}
                array(0) = par

                Dim query As String = $"Update Volunteer Set
	 Title = '{vol.Title }',Name ='{vol.Name }',Address = '{vol.Address }',Work_STATUS_ID = 1,PHONE_HOME ='{vol.HomePhoneNo }',PHONE_MOBILE = '{vol.MobileNo}'
	,SOCIAL_SECURITY_NUMBER ='{vol.SSN }',DATE_OF_BIRTH = '{vol.Dob }',VOLUNTEER_STATUS = {Convert.ToInt32(vol.VolunteerStatus) },HIRE_DATE ='{vol.HireDate  }',NOTES = '{vol.Notes },Image = @image'
     where ID = {volunteer_Id })"
                dataHelper.ExecuteNonQuery(query, array, True)
            End Using
        End If
    End Sub

    Public Function AddVolunteer(ByVal vol As Volunteer, ByVal image As Image)

        If image Is Nothing Then
            Dim query As String = $"INSERT INTO VOLUNTEER 
	 VALUES ('{vol.Title }','{vol.Name }','{vol.Address }',{1},'{vol.HomePhoneNo }','{vol.MobileNo}'
	,'{vol.SSN }','{vol.Dob }',{Convert.ToInt32(vol.VolunteerStatus) },'{vol.HireDate  }','','')"
            dataHelper.ExecuteNonQuery(query, Nothing)
        Else
            Using ms As New MemoryStream

                image.Save(ms, image.RawFormat)
                Dim par As SqlParameter = New SqlParameter("@image", ms.ToArray)
                Dim array As SqlParameter() = New SqlParameter(1) {}
                array(0) = par

                Dim query As String = $"INSERT INTO VOLUNTEER 
	 VALUES('{vol.Title }','{vol.Name }','{vol.Address }',{1},'{vol.HomePhoneNo }','{vol.MobileNo}'
    ,'{vol.SSN }','{vol.Dob }',{Convert.ToInt32(vol.VolunteerStatus) },'{vol.HireDate  }','','',@image)"
                dataHelper.ExecuteNonQuery(query, array, True)
            End Using

        End If


    End Function

    Public Function DeleteVolunteer(ByVal ID As Integer)

        Dim query As String = $"Delete from volunteer where id = {ID} "
        dataHelper.ExecuteNonQuery(query, Nothing)

    End Function

    Public Function GetVolunteer(ByVal id As Integer) As Volunteer
        Dim query As String = $"SELECT TITLE,NAME,ADDRESS,WORK_STATUS_ID,PHONE_HOME,PHONE_MOBILE,SOCIAL_SECURITY_NUMBER,
	DATE_OF_BIRTH,VOLUNTEER_STATUS,HIRE_DATE,NOTES,PHYSICAL_DISABILITY FROM VOLUNTEER 
    	WHERE ID = {id}"
        Dim Vol As Volunteer = New Volunteer()

        Dim dt As DataTable = dataHelper.ExecuteQuery(query, Nothing).Tables(0)
        Dim row As DataRow = dt.Rows(0)
        Vol.ID = id
        Vol.Title = row.Item("Title")
        Vol.Name = row.Item("Name")
        Vol.HomePhoneNo = row.Item("PHONE_HOME")
        Vol.MobileNo = row.Item("PHONE_MOBILE")
        Vol.Address = row.Item("ADDRESS")
        Vol.SSN = row.Item("SOCIAL_SECURITY_NUMBER")
        Vol.Dob = row.Item("DATE_OF_BIRTH")
        Vol.VolunteerStatus = row.Item("VOLUNTEER_STATUS")
        Vol.HireDate = row.Item("HIRE_DATE")
        Vol.WorkStatus = row.Item("WORK_STATUS_ID")
        Vol.Notes = row.Item("Notes")

        'query = $"SELECT DEGREE_ID,DATE_OF_GRADUATION FROM VOLUNTEER_EDUCATION WHERE VOLUNTEER_ID = {id}"
        'dt = dataHelper.ExecuteQuery(query, Nothing).Tables(0)

        'Vol.Education = New List(Of VolunteerEducation)


        'For Each r As DataRow In dt.Rows
        '    Dim edu As VolunteerEducation = New VolunteerEducation()
        '    edu.DegreeId = row.Item("DEGREE_ID")
        '    edu.DateOfGraduation = row.Item("DATE_OF_GRADUATION")
        '    Vol.Education.Add(edu)
        'Next

        'query = $"SELECT ID,MEDIA FROM MEDIA_MAP,MEDIA WHERE MEDIA_MAP.MEDIA_ID = MEDIA.MEDIA_ID AND VOLUNTEER_ID = {id}"
        'dt = dataHelper.ExecuteQuery(query, Nothing).Tables(0)

        'Vol.Media = New List(Of Media)


        'For Each r As DataRow In dt.Rows
        '    Dim edu As Media = New Media()
        '    edu.ID = row.Item("ID")
        '    edu.Media = row.Item("MEDIA")
        '    Vol.Media.Add(edu)
        'Next

        Return Vol
    End Function


End Class
