Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String
        Dim idx As Integer
        Dim fName As String
        idx = name.IndexOf(" ")

        fName = name.Substring(0, idx)
        Return fName



        Return "Not Implemented Yet"

    End Function

End Class
