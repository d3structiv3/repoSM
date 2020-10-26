Public Class Form1
    'Autor: destructive'
    Dim LabelArray(10) As Label
    Dim TextBoxArray(10) As TextBox
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 10
            LabelArray(i) = New Label : TextBoxArray(i) = New TextBox
            LabelArray(i).Text = "Mensaje " & i
            LabelArray(i).Width = 120 : TextBoxArray(i).Width = 100
            LabelArray(i).Height = 30 : TextBoxArray(i).Height = 30
            TextBoxArray(i).AutoSize = False
            LabelArray(i).TextAlign = ContentAlignment.MiddleCenter
            LabelArray(i).BorderStyle = BorderStyle.FixedSingle
            LabelArray(i).Font = New Font("Calibri", 10, FontStyle.Bold)
            LabelArray(i).Location = New Point(100, i * 50)
            TextBoxArray(i).Location = New Point(260, i * 50)
            Me.Controls.Add(LabelArray(i)) : Me.Controls.Add(TextBoxArray(i))
        Next
    End Sub
End Class
