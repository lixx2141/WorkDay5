Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim x As Double
        Dim y As Double
        Dim z As Double

        x = CDbl(txtSideOne.Text)
        y = CDbl(txtSideTwo.Text)
        z = Hypotenuse(x, y)

        'z = Hypotenuse(x) would also be a compile error

        txtHyp.Text = CStr(z)

    End Sub

    Function Hypotenuse(ByVal a As Double, ByVal b As Double) As Double
        Dim c As Double
        c = Math.Sqrt(a ^ 2 + b ^ 2) 
        Return c

        'Return "Hello" would be a compile error
        'Dim cStr As String = Cstr(c) would be a compile error

    End Function
End Class
