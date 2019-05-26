Public Class EventRepository


    Dim dataHelper As DataHelper

    Public Sub New()
        dataHelper = New DataHelper()
    End Sub

    Public Function GetEvents(ByVal User As Integer) As DataTable

        Dim query As String = $"Select ID,NAME,TYPE FROM EVENTS WHERE USER_ID = {User}"
        Dim dt As DataTable = dataHelper.ExecuteQuery(query, Nothing).Tables(0)
        Return dt

    End Function

    Public Function GetEvent(ByVal User As Integer, ByVal eventId As Integer) As Events

        Dim query As String = $"Select ID,NAME,TYPE,NOTES,EVENT_DATE FROM EVENTS WHERE USER_ID ={User}
                               AND ID = {eventId }"
        Dim dt As DataTable = dataHelper.ExecuteQuery(query, Nothing).Tables(0)
        Dim row As DataRow = dt.Rows(0)
        Dim events As Events = New Events()
        events.Id = row.Item("ID")
        events.Name = row.Item("Name")
        events.Type = row.Item("Type")
        events.Notes = row.Item("Notes")
        events.EventDate = row.Item("EVENT_DATE")
        events.EventVolunteerDetails = New List(Of VolunteerDetails)
        query = $"Select  VOLUNTEER_ID , HOURS ,SHIFT_START_TIME ,SHIFT_END_TIME ,EXPENSES ,
                 REIMBURSEMENTS From Event_volunteer_map WHERE USER_ID ={User} AND EVENT_ID = {eventId }"

        dt = dataHelper.ExecuteQuery(query, Nothing).Tables(0)
        For Each r As DataRow In dt.Rows
            Dim vol As VolunteerDetails = New VolunteerDetails()
            vol.Hours = r.Item("Hours")
            vol.Reimbursements = r.Item("Reimbursements")
            vol.Expenses = r.Item("Expenses")
            vol.ShiftEnd = r.Item("SHIFT_END_TIME")
            vol.ShiftStart = r.Item("SHIFT_START_TIME")
            vol.VolunteerId = r.Item("VOLUNTEER_ID")
            events.EventVolunteerDetails.Add(vol)
        Next



        Return events

    End Function

    Public Sub AddEvent(ByVal User As Integer, ByVal events As Events)

        Dim query As String = $"INSERT INTO EVENTS
	 VALUES ('{User}','{events.Name }','{events.Type }','{events.EventDate }','{events.Notes}');
SELECT  SCOPE_IDENTITY() As Id"


        Dim id As Integer = dataHelper.ExecuteQuery(query, Nothing).Tables(0).Rows(0).Item("Id")

        For Each r As VolunteerDetails In events.EventVolunteerDetails

            query = $"insert into EVENT_VOLUNTEER_MAP values ({User},{id},{r.VolunteerId },{r.Hours },
                      '{r.ShiftStart}','{r.ShiftEnd }',{r.Expenses },{r.Reimbursements })"
            dataHelper.ExecuteNonQuery(query, Nothing)
        Next

    End Sub


    Public Sub DeleteEvent(ByVal User As Integer, ByVal eventId As Integer)

        Dim query As String = $"Delete from events where id = {eventId} ;
           Delete from EVENT_VOLUNTEER_MAP where EVENT_ID= {eventId }"
        dataHelper.ExecuteNonQuery(query, Nothing)


    End Sub

    Public Sub UpdateEvent(ByVal User As Integer, ByVal eventId As Integer, ByVal events As Events)

        Dim query As String = $"UPDATE EVENTS SET NAME = '{events.Name }',TYPE = '{events.Type }',
           NOTES = '{events.Notes }',EVENT_DATE ='{events.EventDate }';
            Delete from EVENT_VOLUNTEER_MAP where user_id = {User} and  event_id = {eventId}"
        dataHelper.ExecuteNonQuery(query, Nothing)

        For Each r As VolunteerDetails In events.EventVolunteerDetails


            query = $"insert into EVENT_VOLUNTEER_MAP values ({User},{eventId},{r.VolunteerId },{r.Hours },
                      '{r.ShiftStart}','{r.ShiftEnd}',{r.Expenses },{r.Reimbursements })"
            dataHelper.ExecuteNonQuery(query, Nothing)
        Next

    End Sub

End Class
