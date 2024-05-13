Imports System.IO

Public Class Signup_Page


    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        Dim username As String = txt_signUserName.Text
        Dim password As String = txt_signPassword.Text
        Dim name As String = txt_signName.Text
        Dim age As Integer = Convert.ToInt16(txt_signAge.Text)
        Dim sex As String = txt_signSex.Text
        Dim address As String = txt_signAddress.Text

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) AndAlso
           Not String.IsNullOrEmpty(name) AndAlso Not String.IsNullOrEmpty(age) AndAlso
           Not String.IsNullOrEmpty(sex) AndAlso Not String.IsNullOrEmpty(address) Then

            Dim petOwnerObject As New PetOwner(username, password, name, age, sex, address, Nothing)
            SaveUser(petOwnerObject)
            MessageBox.Show("User created successfully!")
            Me.Hide()
            Login_Page.Show()
        Else
            MessageBox.Show("Please fill in all fields.")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdmLog_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Signup_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        closingApplication(e)
    End Sub
End Class
