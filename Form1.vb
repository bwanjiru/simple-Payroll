Public Class Form1
    Private Sub btnCalculatePayroll_Click(sender As Object, e As EventArgs) Handles btnCalculatePayroll.Click
        Const decHOURLY_PAY_RATE As Integer = 15D
        Const intMAX_SUBSCRIPT As Integer = 5
        Dim intCount As Integer
        Dim dblHoursArray(intMAX_SUBSCRIPT) As Double
        Dim decEmpty As Decimal
        Dim dblTotal As Double
        MessageBox.Show("Please Enter each employee 's hours worked.")
        Do While intCount <= intMAX_SUBSCRIPT
            Try
                dblHoursArray(intCount) = CDbl(InputBox("Employee" & (intCount + 1).ToString() & ":"))
                intCount += 1
            Catch ex As Exception
                MessageBox.Show("Enter a valid number for that employee.")


            End Try
        Loop
        lstBoxOne.Items.Clear()
        For intCount = 0 To dblHoursArray.Length - 1
            decEmpty = CDec(dblHoursArray(intCount) * decHOURLY_PAY_RATE)
            lstBoxOne.Items.Add("Employee " & (intCount + 1).ToString() & " earned " & decEmpty.ToString("c"))
            dblTotal += decEmpty
            lblTotalPayroll.Text = dblTotal
        Next




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstBoxOne.Items.Clear()
        lblTotalPayroll.Text = ""
    End Sub
End Class
