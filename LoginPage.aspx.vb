Imports System.Security.Principal
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
       
        Dim bVerify As Boolean
        Dim arole As String
        Dim sec As New ResultsCompiler.Security

        Try

            bVerify = sec.AuthenticateUser(Trim(txtUser.Text), Trim(txtPass.Text))

            If bVerify = True Then
                arole = sec.GetRole(sec.pRole)

                Dim tk As New FormsAuthenticationTicket(1, txtUser.Text, DateTime.Now, DateTime.Now.AddDays(1), False, arole, FormsAuthentication.FormsCookiePath)
                Dim hs As String = FormsAuthentication.Encrypt(tk)
                Dim ck As New HttpCookie(FormsAuthentication.FormsCookieName, hs)
                Response.Cookies.Add(ck)
                Select Case arole
                    Case "Admissions"
                        Session("InstId") = sec.GetPersonsId(txtUser.Text, txtPass.Text)
                        Response.Redirect("AdmissionsOfficer/StudentRegistration.aspx")
                    Case "ExamsOfficer"
                        Session("InstId") = sec.GetPersonsId(txtUser.Text, txtPass.Text)
                        Response.Redirect("ExamsOfficer/Allocations.aspx")
                    Case "Teacher"
                        Session("InstId") = sec.GetPersonsId(txtUser.Text, txtPass.Text)
                        Response.Redirect("InstructorFolder/CognitiveRecord.aspx")
                    Case "sPrincipal"
                        Session("InstId") = sec.GetPersonsId(txtUser.Text, txtPass.Text)
                        Response.Redirect("PrincipalFolder/curriculum.aspx")
                    Case "Student"
                        Session("SID") = sec.GetPersonsId(txtUser.Text, txtPass.Text)
                        Response.Redirect("StudentFolder/MyRegistration.aspx")
                    Case Else
                        Response.Redirect("LoginPage.aspx")
                End Select

            Else
                lblMessage.Text = "Invalid username or Password"
            End If
        Catch EX As Exception
            lblMessage.Text = EX.Message.ToString
            sec = Nothing
            Exit Sub
        End Try
        sec = Nothing
    End Sub

End Class