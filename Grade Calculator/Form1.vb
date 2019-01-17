Imports change
Public Class Form1
    Dim showGrade As Boolean = True
    Dim q1p As Integer = 40
    Dim q2p As Integer = 40
    Dim fep As Integer = 20

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown3.Controls(0).Enabled = False


    End Sub

    Private Sub Label2_DoubleClick(sender As Object, e As EventArgs) Handles Label2.DoubleClick
        TextBox1.Text = "q1"
        Change.ShowDialog()

    End Sub

    Private Sub Label3_DoubleClick(sender As Object, e As EventArgs) Handles Label3.DoubleClick
        TextBox1.Text = "q2"
        Change.ShowDialog()
    End Sub

    Private Sub Label4_DoubleClick(sender As Object, e As EventArgs) Handles Label4.DoubleClick
        TextBox1.Text = "fe"
        Change.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        q1p = Change.TextBox1.Text
        q2p = Change.TextBox2.Text
        fep = Change.TextBox3.Text

        Label2.Text = q1p.ToString + "%"
        Label3.Text = q2p.ToString + "%"
        Label4.Text = fep.ToString + "%"

        If q1p + q2p + fep = 100 Then
            Button1.Enabled = True
            Label2.ForeColor = Color.Green
            Label3.ForeColor = Color.Green
            Label4.ForeColor = Color.Green
        Else
            Button1.Enabled = False
            Label2.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
            Label4.ForeColor = Color.Red
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Calculations_Tick(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NumericUpDown3.Visible = False
        '   1500
        Button1.Enabled = False
        Dim xxxtentacion As Integer = 0
        Do While xxxtentacion < 1500
            ProgressBar1.Value = ProgressBar1.Value + 1
            xxxtentacion = xxxtentacion + 1

        Loop



        Dim grade As Double = 0

        Dim q1m As Double = q1p / 100
        Dim q2m As Double = q2p / 100
        Dim fem As Double = fep / 100
        Dim x As Integer = 0

        '10 point scale 
        If scaleTxt.Text = "10" Then
            If RadioButton1.Checked Then
                ' User wants an A
                grade = grade + q1m * NumericUpDown1.Value
                grade = grade + q2m * NumericUpDown2.Value

                Dim WhatsRequired As Integer = 90 - grade

                If fem * 100 < WhatsRequired Then
                    Dim highest_Grade As String = (fem * 100 + grade).ToString
                    MessageBox.Show("You can not make an A. Sorry! The highest grade you can make is a " + highest_Grade, "Not Possible", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    showGrade = False
                    TimerX.Enabled = True

                Else
                    For i As Integer = 0 To 100
                        If i * fem >= WhatsRequired Then
                            NumericUpDown3.Value = i
                            showGrade = True

                            TimerX.Enabled = True
                            Exit Sub
                        End If
                    Next
                End If
            End If

            If RadioButton2.Checked Then
                ' User wants an B
                grade = grade + q1m * NumericUpDown1.Value
                grade = grade + q2m * NumericUpDown2.Value

                Dim WhatsRequired As Integer = 80 - grade

                If fem * 100 < WhatsRequired Then
                    Dim highest_Grade As String = (fem * 100 + grade).ToString
                    MessageBox.Show("You can not make a B. Sorry! The highest grade you can make is a " + highest_Grade, "Not Possible", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    showGrade = False
                    TimerX.Enabled = True

                Else
                    For i As Integer = 0 To 100
                        If i * fem >= WhatsRequired Then
                            NumericUpDown3.Value = i
                            showGrade = True
                            TimerX.Enabled = True

                            Exit Sub
                        End If
                    Next
                End If
            End If

            If RadioButton3.Checked Then
                ' User wants an C
                grade = grade + q1m * NumericUpDown1.Value
                grade = grade + q2m * NumericUpDown2.Value

                Dim WhatsRequired As Integer = 70 - grade

                If fem * 100 < WhatsRequired Then
                    Dim highest_Grade As String = (fem * 100 + grade).ToString
                    MessageBox.Show("You can not make a C. Sorry! The highest grade you can make is a " + highest_Grade, "Not Possible", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    showGrade = False
                    TimerX.Enabled = True

                Else
                    For i As Integer = 0 To 100
                        If i * fem >= WhatsRequired Then
                            NumericUpDown3.Value = i
                            showGrade = True

                            TimerX.Enabled = True

                            Exit Sub
                        End If
                    Next
                End If
            End If

            If RadioButton4.Checked Then
                ' User wants an D
                grade = grade + q1m * NumericUpDown1.Value
                grade = grade + q2m * NumericUpDown2.Value

                Dim WhatsRequired As Integer = 60 - grade

                If fem * 100 < WhatsRequired Then
                    Dim highest_Grade As String = (fem * 100 + grade).ToString
                    MessageBox.Show("You can not make a D. Sorry! The highest grade you can make is a " + highest_Grade, "Not Possible", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    showGrade = False
                    TimerX.Enabled = True

                Else
                    For i As Integer = 0 To 100
                        If i * fem >= WhatsRequired Then
                            NumericUpDown3.Value = i
                            showGrade = True

                            TimerX.Enabled = True

                            Exit Sub
                        End If
                    Next
                End If
            End If
        End If


        '7 point scale 
        If scaleTxt.Text = "7" Then

            If RadioButton1.Checked Then
                ' User wants an A
                grade = grade + q1m * NumericUpDown1.Value
                grade = grade + q2m * NumericUpDown2.Value

                Dim WhatsRequired As Integer = 93 - grade

                If fem * 100 < WhatsRequired Then
                    Dim highest_Grade As String = (fem * 100 + grade).ToString
                    MessageBox.Show("You can not make an A. Sorry! The highest grade you can make is a " + highest_Grade, "Not Possible", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    showGrade = False
                    TimerX.Enabled = True

                Else
                    For i As Integer = 0 To 100
                        If i * fem >= WhatsRequired Then
                            NumericUpDown3.Value = i
                            showGrade = True

                            TimerX.Enabled = True

                            Exit Sub
                        End If
                    Next
                End If
            End If

            If RadioButton2.Checked Then
                ' User wants an B
                grade = grade + q1m * NumericUpDown1.Value
                grade = grade + q2m * NumericUpDown2.Value

                Dim WhatsRequired As Integer = 85 - grade

                If fem * 100 < WhatsRequired Then
                    Dim highest_Grade As String = (fem * 100 + grade).ToString
                    MessageBox.Show("You can not make a B. Sorry! The highest grade you can make is a " + highest_Grade, "Not Possible", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    showGrade = False
                    TimerX.Enabled = True

                Else
                    For i As Integer = 0 To 100
                        If i * fem >= WhatsRequired Then
                            NumericUpDown3.Value = i
                            showGrade = True

                            TimerX.Enabled = True

                            Exit Sub
                        End If
                    Next
                End If
            End If

            If RadioButton3.Checked Then
                ' User wants an C
                grade = grade + q1m * NumericUpDown1.Value
                grade = grade + q2m * NumericUpDown2.Value

                Dim WhatsRequired As Integer = 77 - grade

                If fem * 100 < WhatsRequired Then
                    Dim highest_Grade As String = (fem * 100 + grade).ToString
                    MessageBox.Show("You can not make a C. Sorry! The highest grade you can make is a " + highest_Grade, "Not Possible", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    showGrade = False
                    TimerX.Enabled = True

                Else
                    For i As Integer = 0 To 100
                        If i * fem >= WhatsRequired Then
                            NumericUpDown3.Value = i
                            showGrade = True

                            TimerX.Enabled = True

                            Exit Sub
                        End If
                    Next
                End If
            End If

            If RadioButton4.Checked Then
                ' User wants an D
                grade = grade + q1m * NumericUpDown1.Value
                grade = grade + q2m * NumericUpDown2.Value

                Dim WhatsRequired As Integer = 70 - grade

                If fem * 100 < WhatsRequired Then
                    Dim highest_Grade As String = (fem * 100 + grade).ToString
                    MessageBox.Show("You can not make a D. Sorry! The highest grade you can make is a " + highest_Grade, "Not Possible", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    showGrade = False
                    TimerX.Enabled = True

                Else
                    For i As Integer = 0 To 100
                        If i * fem >= WhatsRequired Then
                            NumericUpDown3.Value = i
                            showGrade = True

                            TimerX.Enabled = True

                            Exit Sub
                        End If
                    Next
                End If
            End If
        End If


    End Sub

    Private Sub MenuItem2_Click(sender As Object, e As EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub

    Private Sub MenuItem7_Click(sender As Object, e As EventArgs) Handles MenuItem7.Click
        TextBox1.Text = "q1"
        Change.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MenuItem8_Click(sender As Object, e As EventArgs) Handles MenuItem8.Click
        TextBox1.Text = "q2"
        Change.ShowDialog()
    End Sub

    Private Sub MenuItem9_Click(sender As Object, e As EventArgs) Handles MenuItem9.Click
        TextBox1.Text = "fe"
        Change.ShowDialog()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub MenuItem12_Click(sender As Object, e As EventArgs) Handles MenuItem12.Click
        MenuItem11.Enabled = True
        MenuItem12.Enabled = False
        ToolStripStatusLabel1.Text = "Grading Scale: 7 Point"
        scaleTxt.Text = "7"
    End Sub

    Private Sub MenuItem11_Click(sender As Object, e As EventArgs) Handles MenuItem11.Click
        MenuItem12.Enabled = True
        MenuItem11.Enabled = False
        ToolStripStatusLabel1.Text = "Grading Scale: 10 Point"
        scaleTxt.Text = "10"
    End Sub

    Private Sub ToolStripStatusLabel1_MouseDown(sender As Object, e As MouseEventArgs) Handles ToolStripStatusLabel1.MouseDown
        If ToolStripStatusLabel1.Text = "Grading Scale: 10 Point" Then
            MenuItem11.Enabled = True
            MenuItem12.Enabled = False
            ToolStripStatusLabel1.Text = "Grading Scale: 7 Point"
            scaleTxt.Text = "7"
        Else
            MenuItem12.Enabled = True
            MenuItem11.Enabled = False
            ToolStripStatusLabel1.Text = "Grading Scale: 10 Point"
            scaleTxt.Text = "10"
        End If
    End Sub

    Private Sub TimerX_Tick(sender As Object, e As EventArgs) Handles TimerX.Tick
        ProgressBar1.Value = 0
        Button1.Enabled = True
        If showGrade = False Then
            TimerX.Enabled = False
            Exit Sub
        End If
        NumericUpDown3.Visible = True
        TimerX.Enabled = False
    End Sub
End Class
