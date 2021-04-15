'Richard Miller
'2/6/2021
'validating finding sale'

Public Class Sale
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'create local variables
        Dim dblOriginalPrice As Integer
        Dim dblPercentOff As Double
        Dim dblTotalPrice As Double
        txtOriginalPrice.BackColor = Color.White 'changes color when value in text box is incorrect'
        txtPercentOff.BackColor = Color.White 'changes color when value in text box is incorrect'


        'validates the information in the text boxes data type validation'
        If IsNumeric(txtOriginalPrice.Text) Then
            dblOriginalPrice = txtOriginalPrice.Text
        Else
            MessageBox.Show("Please type a number")
            txtOriginalPrice.BackColor = Color.Yellow 'changes color when value in text box is incorrect'
            txtOriginalPrice.Focus()
            Exit Sub
        End If

        If dblOriginalPrice < 0 Or dblOriginalPrice > 100 Then
            MessageBox.Show("Please type a number between 0 and 100")
            txtOriginalPrice.BackColor = Color.Yellow 'changes color when value in text box is incorrect'
            txtOriginalPrice.Focus()
            Exit Sub
        End If

        If IsNumeric(txtPercentOff.Text) Then
            dblPercentOff = txtPercentOff.Text
        Else
            MessageBox.Show("Please type a number")
            txtPercentOff.BackColor = Color.Yellow 'changes color when value in text box is incorrect'
            txtPercentOff.Focus() 'sets the focus back into the errored text box'
            Exit Sub
        End If

        If dblPercentOff < 0 Or dblPercentOff > 100 Then
            MessageBox.Show("Please type a number between 0 and 100")
            txtPercentOff.BackColor = Color.Yellow 'changes color when value in text box is incorrect'
            txtPercentOff.Focus() 'sets the focus back into the errored text box'
            Exit Sub
        End If


        'calculates price with discount'
        dblOriginalPrice = txtOriginalPrice.Text
        dblPercentOff = txtPercentOff.Text
        dblTotalPrice = dblOriginalPrice * (1 - (dblPercentOff / 100))
        lblResult.Text = FormatCurrency(dblTotalPrice)


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear all lines
        txtOriginalPrice.Clear()
        txtPercentOff.Clear()
        lblResult.ResetText()
        txtOriginalPrice.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'close the program
        Close()

    End Sub
End Class
