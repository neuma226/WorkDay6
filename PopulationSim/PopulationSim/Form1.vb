Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim CurrentYear As Integer
        Dim CurrentPopulation As Double

        CurrentYear = 2013
        CurrentPopulation = 7000000000.0

        Do While (CurrentPopulation > 600000000.0)
            CurrentPopulation = CurrentPopulation / 2
            CurrentYear = CurrentYear - 50
        Loop

        MessageBox.Show("The year when the population was 6,000,000 people was " & CurrentYear, "Answer")

    End Sub
End Class
