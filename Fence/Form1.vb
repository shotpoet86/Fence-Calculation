' Name:         Rectangle.vb
' Programmer:   Austin Parker on June 3, 2020

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged

    End Sub

    Dim dblLength As Double
    Dim dblWidth As Double
    'Creates function to calculate perimeter
    Public Function GetPerimeter() As Double
        Return 2 * (dblLength + dblWidth)

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'get input from user       
        Dim dblRate As Double
        Dim dblPerimeter As Double
        Double.TryParse(txtLength.Text, dblLength)
        Double.TryParse(txtWidth.Text, dblWidth)
        Double.TryParse(txtCost.Text, dblRate)

        'Calculate perimeter of rectangle using GetPerimeter funcion in Rectangle class
        dblPerimeter = GetPerimeter()
        'Calculate and display total cost of installing fence
        lblTotal.Text = (dblRate * dblPerimeter).ToString("C2")
        txtLength.Focus()
        txtLength.SelectAll()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress, txtLength.KeyPress, txtWidth.KeyPress

        ' Accept only numbers, the hyphen, and the Backspace.
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtLength.TextChanged, txtWidth.TextChanged, txtCost.TextChanged

        lblTotal.Text = String.Empty

    End Sub
End Class
