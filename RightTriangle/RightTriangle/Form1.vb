Option Strict On
Public Class Form1
   


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        'Read input from user'
        Dim sideone As Double = CDbl(txtSideOne.Text)
        Dim sidetwo As Double = CDbl(txtSideTwo.Text)
        Dim sidethree As Double
        sidethree = Hypotenuese(sideone, sidetwo)
        txtHyp.Text = CStr(sidethree)





    End Sub
    Function Hypotenuese(ByVal a As Double,
    ByVal b As Double) As Double
        Dim c As Double
        c = Math.Sqrt(a ^ 2 + b ^ 2)
        Return c






    End Function

End Class
