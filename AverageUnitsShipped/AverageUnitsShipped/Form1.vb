'Program name: Average Units Shipped
'Date: Jan 25, 2019
'Author: Harry Palmer
'Student #: 100558528
'Description: This is a program created to take input of units shipped per day over
'             the course of a week. After all 7 days are entered and displayed, the 
'             average units shipped are displayed. The user can then Reset or exit the form.
'
Option Strict On

Public Class frmAverageUnitsShipped

    'VARIABLE DECLARATION

    Dim UnitsShippedArray(6) As Integer 'Array

    Dim UserEntry As String             'User entry string

    Dim unitsEntered As Integer         'User Entry post-integer parse
    Dim DayCounter As Integer = 1       'Counter for days
    Dim ArrayCounter As Integer         'Counter to iterate through the array

    Dim Average As Double = 0.0         'Double to hold the average

    'Exit button to exit the form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()  'Exit the form
    End Sub

    'Reset button to reset the form back to the default 
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUnitsEntry.Clear()           'Clear the units entry text box
        txtUnitsShippedDisplay.Clear()  'Clears the display for the units shipped text box
        lblAverageUnits.ResetText()     'Resets the Average units shipped label
        btnEnter.Enabled = True         'Re-enables the Enter button
        txtUnitsEntry.Enabled = True    'Re-enables the Entry text box
        Average = 0.0                   'Resets the value held in the Average variable
        DayCounter = 1                  'Resets back to day 1
        txtUnitsEntry.Focus()           'Sets the focus on the units entry text box 
    End Sub


    'Enter button to enter each day of units shipped to an array, and adding it to the running average
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        lblAverageUnits.ResetText()     'Resets the Average units shipped label to clear any error messages
        UserEntry = txtUnitsEntry.Text 'Set the user entered value to a variable

        If Integer.TryParse(UserEntry, unitsEntered) Then 'Did the user enter a number?

            If (unitsEntered <= 1000 And unitsEntered >= 0) Then 'Is it within the range?

                txtUnitsShippedDisplay.Text += unitsEntered.ToString() + vbCrLf 'Output the value in the multiline textbox
                UnitsShippedArray(DayCounter - 1) = unitsEntered                'Store value in the current array spot

                If (DayCounter < 7) Then    'Are all of the days acounted for already?

                    ' Clear and focus the textbox
                    txtUnitsEntry.Clear()
                    txtUnitsEntry.Focus()

                    DayCounter = DayCounter + 1 'Increment the counter to go to the next day
                    lblDays.Text = "Day " + DayCounter.ToString() 'Update the Day counter label
                Else 'If all 7 days are entered

                    'Disable data entry controls
                    txtUnitsEntry.Enabled = False
                    btnEnter.Enabled = False

                    'Iterate through the array to calculate the total
                    For ArrayCounter = 1 To UnitsShippedArray.Length
                        Average += UnitsShippedArray(ArrayCounter - 1)
                    Next ArrayCounter

                    'Calculate the average given a 7 day week
                    Average = Math.Round(Average / 7, 2)
                    lblAverageUnits.Text = "Average Units shipped: " + Average.ToString()
                End If

            Else 'Value entered is outside of range
                lblAverageUnits.Text = "Please enter a # from 0 to 1000 inclusive."
                txtUnitsEntry.Clear()
            End If

        Else
            'Let user know the value is non-numeric
            lblAverageUnits.Text = "Please enter a valid whole #."
            txtUnitsEntry.Clear()

        End If


    End Sub


End Class
