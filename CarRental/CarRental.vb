'Jessica McArthur
'RCET0265
'Car Rental
'

Option Explicit On
Option Strict On
Option Compare Binary

Public Class CarRental

    'All the user inputs are validated. 
    'The user is prompted as how to fill in the input as needed 
    'and the invaild text is cleared.
    Function AddressInputValid() As Boolean
        Dim isZipCodeValid As Integer
        Dim isBeginningOdometerInputValid As Integer
        Dim isEndingOdometerInputValid As Integer
        Dim areDaysInputValid As Integer
        'validates customer name input
        If CustomerNameTextBox.Text = "" Then
            ErrorMessage("Enter customer's name")
            CustomerNameTextBox.Focus()
        End If
        'Validates address input
        If AddressTextBox.Text = "" Then
            ErrorMessage("Enter the customer's address")
            AddressTextBox.Focus()
        End If
        'Validates city input
        If CityTextBox.Text = "" Then
            ErrorMessage("Enter the city of the address")
            CityTextBox.Focus()
        End If
        'Validates state input
        If StateTextBox.Text = "" Then
            ErrorMessage("Enter the state of the address")
            StateTextBox.Focus()
        End If
        'Vlaidates zip code input
        If ZipCodeTextBox.Text = "" Then
            ErrorMessage("Enter the zip code of the address")
            ZipCodeTextBox.Focus()
        Else
            Try
                isZipCodeValid = CInt(ZipCodeTextBox.Text)
            Catch ex As Exception
                ErrorMessage("Zip Code must be a number")
                ZipCodeTextBox.Clear()
                ZipCodeTextBox.Focus()
            End Try
        End If
        'Validates beginning odometer input
        If BeginningOdometerReadingTextBox.Text = "" Then
            ErrorMessage("Enter the beginning milage of the vehicle")
            BeginningOdometerReadingTextBox.Focus()
        Else
            Try
                isBeginningOdometerInputValid =
                    CInt(BeginningOdometerReadingTextBox.Text)
            Catch ex As Exception
                ErrorMessage("Beginning milage must be a number")
                BeginningOdometerReadingTextBox.Clear()
                BeginningOdometerReadingTextBox.Focus()
            End Try
        End If
        'Validates ending odometer input
        If EndingOdometerReadingTextBox.Text = "" Then
            ErrorMessage("Enter the ending milage of the vehicle")
            EndingOdometerReadingTextBox.Focus()
        Else
            Try
                isEndingOdometerInputValid =
                    CInt(EndingOdometerReadingTextBox.Text)
            Catch ex As Exception
                ErrorMessage("Ending milage must be a number")
                EndingOdometerReadingTextBox.Clear()
                EndingOdometerReadingTextBox.Focus()
            End Try
        End If
        'Validates that beginning milage is less then ending milage 
        If isBeginningOdometerInputValid > isEndingOdometerInputValid Then
            ErrorMessage("End milage must be larger than beginning milage")
            BeginningOdometerReadingTextBox.Clear()
            BeginningOdometerReadingTextBox.Focus()
        End If
        'Validates number of days input
        If NumberOfDaysTextBox.Text = "" Then
            ErrorMessage("Enter the number of days vehicle is to be rented")
            NumberOfDaysTextBox.Focus()
        Else
            Try
                areDaysInputValid = CInt(NumberOfDaysTextBox.Text)
                If areDaysInputValid = 0 Then
                    ErrorMessage("Vehicle must be rented for at least a day")
                    NumberOfDaysTextBox.Clear()
                    NumberOfDaysTextBox.Focus()
                End If

                If areDaysInputValid > 45 Then
                    ErrorMessage("Vehicle must be rented for less then 45 days")
                    NumberOfDaysTextBox.Clear()
                    NumberOfDaysTextBox.Focus()
                End If
            Catch ex As Exception
                ErrorMessage("Days vehicle rented must be a number")
                NumberOfDaysTextBox.Clear()
                NumberOfDaysTextBox.Focus()
            End Try
        End If

        If ErrorMessage() <> "" Then
            MsgBox(ErrorMessage())
            ErrorMessage(, True)
        End If
    End Function

    'A message box appears to the user telling them of any errors.
    Private Function ErrorMessage(Optional newMessage As String = "",
               Optional clear As Boolean = False) As String
        Static _message As String

        Select Case clear
            Case False
                If newMessage <> "" Then
                    _message &= newMessage & vbCrLf
                End If
            Case Else
                _message = ""
        End Select
        Return _message
    End Function

    'The price for car rental is calculated and displayed.
    Sub Calculation()
        Dim chargePerDay As Decimal = 15
        ' Dim numberOfDays = numnberofdaysTextBox.text
        Dim chargePerMile As Decimal
        Dim distance As Decimal
        Dim discount As Decimal = 1
        Dim sum As Decimal
        Dim totalCharge As Decimal

        'Charge per day
        DayChargeTextBox.Text =
            (CDec(chargePerDay *
            CInt(NumberOfDaysTextBox.Text))).ToString("C")

        'Distance driven per day 
        If KilomtersRadioButton.Checked Then
            distance =
                (CDec(CInt(EndingOdometerReadingTextBox.Text) -
                 CInt(BeginningOdometerReadingTextBox.Text) * 0.62))
        Else
            distance =
                (CDec(EndingOdometerReadingTextBox.Text) -
                CDec(BeginningOdometerReadingTextBox.Text))
        End If

        DistanceDrivenTextBox.Text = CStr(distance) & " mi"

        'milage charge 
        Select Case distance
            Case < 200
                chargePerMile = 0
            Case > 201
                chargePerMile = CDec(0.12)
            Case < 500
                chargePerMile = CDec(0.12)
            Case > 500
                chargePerMile = CDec(0.1)
        End Select

        MilageChargeTextBox.Text =
            (CDec(chargePerMile * distance)).ToString("C")

        'Discounts
        If AAAMemberDiscountCheckBox.Checked Then
            discount -= CDec(0.05)
        End If

        If SeniorCitizenDiscountCheckBox.Checked Then
            discount -= CDec(0.03)
        End If

        'Total price of rental
        sum = CDec(MilageChargeTextBox.Text) + CDec(DayChargeTextBox.Text)
        MinusDiscountTextBox.Text = ((discount * sum) - sum).ToString("C")

        totalCharge = (sum + (CDec(MinusDiscountTextBox.Text)))

        YouOweTextBox.Text = (sum +
            (CDec(MinusDiscountTextBox.Text))).ToString("C")

        'complete order 
        OrdersComplete(1, distance, totalCharge)
    End Sub

    'Counts the number of total sales
    Function OrdersComplete(Optional customers As Integer = 0,
     Optional distance As Decimal = 0,
     Optional profit As Decimal = 0) As String
        Dim customerReport As String
        Static numberOfCumstomers As Integer
        Static distanceDriven As Decimal
        Static moneyMade As Decimal

        numberOfCumstomers += customers
        distanceDriven += CDec(distance)
        moneyMade += CDec(profit)

        customerReport = ("Summary of Sales" & vbNewLine &
            "Total Customers:    " & numberOfCumstomers & vbNewLine &
            "Total Miles Driven:    " & distanceDriven & "mi" & vbNewLine &
            "Total Cost:         $" & moneyMade)

        Return customerReport
    End Function

    'Displays a summary of past orders when called
    Sub Summary()
        MsgBox(OrdersComplete())
    End Sub

    'clears out all inputs and outputs. Sets form to default.  
    Sub Reset()
        'Clears input text boxes 
        CustomerNameTextBox.Clear()
        AddressTextBox.Clear()
        CityTextBox.Clear()
        StateTextBox.Clear()
        ZipCodeTextBox.Clear()
        BeginningOdometerReadingTextBox.Clear()
        EndingOdometerReadingTextBox.Clear()
        NumberOfDaysTextBox.Clear()
        'Clear ouput text boxes
        DistanceDrivenTextBox.Clear()
        MilageChargeTextBox.Clear()
        DayChargeTextBox.Clear()
        MinusDiscountTextBox.Clear()
        YouOweTextBox.Clear()
        'Buttons set default state
        SummaryButton.Enabled = False
        MilesRadioButton.Checked = True
        AAAMemberDiscountCheckBox.Checked = False
        SeniorCitizenDiscountCheckBox.Checked = False
    End Sub

    'When Calculate Button is pressed userinputs are validated and price of rental shown.
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If AddressInputValid() = True Then
        Else
            Calculation()
            SummaryButton.Enabled = True
        End If
    End Sub
    'Shows a summary of all orders. 
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Summary()
        Reset()
    End Sub
    'Sets form to default. Clears all text boxes.
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Reset()
    End Sub
    'Exits program when user selects yes. 
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim message = "Are you sure you want to exit?"
        Dim formatt = MsgBoxStyle.YesNo
        Dim response = MsgBox(message, formatt)

        If response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    'Loads form at default. 
    Private Sub CarRental_Load(sender As Object, e As EventArgs) Handles Me.Load
        Reset()
    End Sub
End Class
