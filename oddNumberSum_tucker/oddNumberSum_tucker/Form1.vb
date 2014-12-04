Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim lngFactorial As Long = 0
        Dim intNumber As Integer = Val(Me.txtNumber.Text)

        Dim intC As Integer
        For intC = 1 To intNumber
            If intC Mod 2 <> 0 Then
                lngFactorial = lngFactorial + intC
            End If
        Next intC

        Me.lblResults.Text = "the sum of the odd numbers from 1 to " & intNumber & " is " & lngFactorial
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        Me.lblResults.Text = Nothing
    End Sub
End Class

