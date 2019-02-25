Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res1(1, 2) As Integer
        Dim res2(1, 2) As Integer
        Dim res3(1, 2) As Integer

        Dim tmp1 As String = ""
        Dim tmp2 As String = ""
        Dim tmp3 As String = ""

        For getal As Integer = 0 To 1
            For getal2 As Integer = 0 To 2
                res1(getal, getal2) = InputBox("Geef een getal:", "Voer " & getal2 & " getal in: ")
            Next
        Next
        For getal As Integer = 0 To 1
            For getal2 As Integer = 0 To 2
                tmp1 &= res1(getal, getal2) & Space(2)
            Next
            tmp1 &= vbCrLf
        Next
        Label1.Text = tmp1
        For getal As Integer = 0 To 1
            For getal2 As Integer = 0 To 2
                res2(getal, getal2) = InputBox("Geef een getal:", "Voer " & getal2 & " getal in: ")
            Next
        Next
        For getal As Integer = 0 To 1
            For getal2 As Integer = 0 To 2
                tmp2 &= res2(getal, getal2) & Space(2)
            Next
            tmp2 &= vbCrLf
        Next
        Label4.Text = tmp2

        For getal As Integer = 0 To 1
            For getal2 As Integer = 0 To 2
                res3(getal, getal2) = res1(getal, getal2) + res2(getal, getal2)
            Next
        Next
        For getal As Integer = 0 To 1
            For getal2 As Integer = 0 To 2
                tmp3 &= res3(getal, getal2) & Space(2)
            Next
            tmp3 &= vbCrLf
        Next
        Label3.Text = tmp3
    End Sub
End Class

