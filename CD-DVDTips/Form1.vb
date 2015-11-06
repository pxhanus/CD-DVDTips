'Patricia Hanus
'151106
'CD-DVD Tips
'______________________________________________________________________
Public Class Form1

    Private Sub btnTip_Click(sender As Object, e As EventArgs) Handles btnTip.Click
        Randomize()
        Dim num As Integer = Int(Rnd() * 3 + 1)

        Call DisplayTip(num)

    End Sub
    Sub DisplayTip(ByVal num As Integer)
        Select Case num
            Case 1
                Me.lblTip.Text = "Handle CD/DVDs by the center hole or by the edges."
            Case 2
                Me.lblTip.Text = "Keep CD/DVDs away from extreme temperatures and moisture."
            Case 3
                Me.lblTip.Text = "Store discs in a jewel case or sleeve to prevent scratches."
        End Select
    End Sub
End Class
