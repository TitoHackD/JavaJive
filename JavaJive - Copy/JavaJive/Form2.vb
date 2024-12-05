Imports System.Drawing.Printing

Public Class Form2
    ' Public properties to hold the passed values
    Public Property SubtotalValue As Decimal
    Public Property TaxValue As Decimal
    Public Property TotalValue As Decimal

    ' Method to display the calculated values on Form2
    Public Sub DisplayOrderSummary()
        ' Display the passed values in the labels (formatted as currency)
        lblSubtotal.Text = "Subtotal: " & SubtotalValue.ToString("c")
        lblTax.Text = "Tax: " & TaxValue.ToString("c")
        lblTotal.Text = "Total: " & TotalValue.ToString("c")
    End Sub
    ' Create an instance of PrintDialog and PrintDocument
    Private WithEvents printDialog As New PrintDialog()
    Private WithEvents printDocument As New Printing.PrintDocument()

    ' Button click to initiate the print process
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Show the print dialog so the user can select a printer
        printDialog.Document = printDocument
        If printDialog.ShowDialog() = DialogResult.OK Then
            ' Print the document
            printDocument.Print()
        End If
    End Sub

    ' Handle the PrintPage event to define what gets printed
    Private Sub printDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDocument.PrintPage
        ' Define the content to print here
        ' For example, printing some text:
        Dim printFont As New Font("Arial", 12)
        e.Graphics.DrawString("Hello, this is a test print!", printFont, Brushes.Black, 100, 100)
    End Sub
    Private Sub btnExit2_Click(sender As Object, e As EventArgs) Handles btnExit2.Click
        Me.Close()
    End Sub
End Class