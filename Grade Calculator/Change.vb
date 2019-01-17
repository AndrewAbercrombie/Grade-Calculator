Imports form1
Public Class Change
    Dim str As String = "Enter weight for "
    Private Sub Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Change_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        NumericUpDown1.Value = 0
        If Form1.TextBox1.Text = "q1" Then
            str = "Enter weight for quarter one grade - "
        ElseIf Form1.TextBox1.Text = "q2" Then
            str = "Enter weight for quarter two grade - "
        ElseIf Form1.TextBox1.Text = "fe" Then
            str = "Enter weight for final exam frade - "
        End If
        Label1.Text = str
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (NumericUpDown1.Value > 100) Or (NumericUpDown1.Value < 0) Then
            MsgBox("Your a fucking idiot!")
            Exit Sub
        End If


        If Form1.TextBox1.Text = "q1" Then
            TextBox1.Text = NumericUpDown1.Value
        ElseIf Form1.TextBox1.Text = "q2" Then
            TextBox2.Text = NumericUpDown1.Value
        ElseIf Form1.TextBox1.Text = "fe" Then
            TextBox3.Text = NumericUpDown1.Value
        End If
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Change_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub NumericUpDown1_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class