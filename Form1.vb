Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim str1 As Double = txt1.Text
        Dim str2 As Double = txt2.Text
        Dim Result As String

        Dim str_bmi As Double = str1 / str2 ^ 2

        Label3.Text = Format(str_bmi, "0.00")

        If str_bmi < 18.5 Then
            Result = "Underweight"

        ElseIf str_bmi <= 24.9 And str_bmi >= 18.5 Then
            Result = "Normal weight"

        ElseIf str_bmi <= 29.9 And str_bmi >= 25 Then
            Result = "Overweight"

        ElseIf str_bmi >= 30 Then
            Result = "Overweight"

        Else
            Result = "Please insert number"

        End If
        Label4.Text = Result

    End Sub
End Class