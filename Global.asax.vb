Imports System.Web.SessionState
Imports System.Web.Security
Imports System.Security.Principal
Imports System.IO

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)

        ' Fires when the session is started
        Session("InstructorsDataset") = New DataSet
        Session("StudentsDataset") = New DataSet
        Session("SubjectsDataset") = New DataSet
        Session("curr") = 0
        Session("currPhoto") = ""
        Session("AssessmentsDataset") = New DataSet
        Session("dsGrades") = New DataSet
        Session("dsAllocation") = New DataSet
        Session("fname") = ""
        Session("dsPsych") = New DataSet
        Session("dsSessionInfo") = New DataSet
        Session("dsClass") = New DataSet
        Session("GradeId") = ""
        Session("dtGrades") = New DataTable
        Session("SID") =
        Session("SessId") = ""
        Session("Term") = ""
        Session("Clas") = ""
        Session("InstId") = ""
        Session("CurrMaster") = ""
        Session("PhotoPage") = ""
        Session("PhotoGuid") = ""
        Session("PassMark") = 40
        Session("SubjectId") = ""
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use

        If Not IsNothing(HttpContext.Current.User) Then

            If (HttpContext.Current.User.Identity.IsAuthenticated) Then
                If (TypeOf (HttpContext.Current.User.Identity) Is FormsIdentity) Then

                    Dim id As FormsIdentity = HttpContext.Current.User.Identity

                    Dim tk As FormsAuthenticationTicket = id.Ticket
                    Dim udata As String = tk.UserData

                    Dim aroles(1) As String
                    aroles(0) = udata
                    HttpContext.Current.User = New GenericPrincipal(id, aroles)
                End If
            End If

        End If

    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
        Dim files() As String
        files = Directory.GetFiles(Server.MapPath("~\TempFolder"))

        For i As Integer = 0 To files.Length - 1
            File.Delete(files(i))
        Next
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

End Class