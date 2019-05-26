Public Class Volunteer


    Public ID As Integer
    Public Title As String
    Public Name As String
    Public Address As String
    Public HomePhoneNo As String
    Public MobileNo As String
    Public Email As New List(Of String)
    Public SSN As String
    Public Dob As Date
    Public Media As New List(Of Media)
    Public Education As New List(Of VolunteerEducation)
    Public WorkStatus As WorkStatus
    Public VeteranStatus As VeteranStatus
    Public DischargeDate As Date
    Public VolunteerStatus As Boolean
    Public HireDate As Date
    Public TerminationDate As Date
    Public ReasonForTermination As String
    Public Skills As List(Of String)
    Public Notes As String
    Public Image As Byte()
    Public Sub New()

    End Sub

    Public Sub New(ByVal index As Integer, ByVal titleText As String, ByVal nameText As String)
        ID = index
        Title = titleText
        Name = nameText

    End Sub


End Class
