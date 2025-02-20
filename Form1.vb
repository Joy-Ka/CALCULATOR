Public Class Form1

    'Declaration of Variables'

    Dim firstNumber As Double
    Dim operation As String
    Dim newNumber As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Numbers click events '
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn9.Click

        Input_Output.Text = Input_Output.Text + "9"

    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click

        Input_Output.Text = Input_Output.Text + "8"

    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click

        Input_Output.Text = Input_Output.Text + "7"

    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click

        Input_Output.Text = Input_Output.Text + "6"

    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click

        Input_Output.Text = Input_Output.Text + "5"

    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click

        Input_Output.Text = Input_Output.Text + "4"

    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click

        Input_Output.Text = Input_Output.Text + "3"

    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click

        Input_Output.Text = Input_Output.Text + "2"

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click

        Input_Output.Text = Input_Output.Text + "1"

    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click

        Input_Output.Text = Input_Output.Text + "0"

    End Sub

    Private Sub BtnDecimal_Click(sender As Object, e As EventArgs) Handles BtnDecimal.Click

        Input_Output.Text = Input_Output.Text + "."

    End Sub

    'Arithmetic Manipuation Functions'

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click

        Label1.Text = Input_Output.Text
        Label2.Text = "x"
        Input_Output.Text = ""

    End Sub

    Private Sub BtnDivision_Click(sender As Object, e As EventArgs) Handles BtnDivision.Click

        Label1.Text = Input_Output.Text
        Label2.Text = "/"
        Input_Output.Text = ""
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Label1.Text = Input_Output.Text
        Label2.Text = "+"
        Input_Output.Text = ""

    End Sub

    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles BtnSubtract.Click

        Label1.Text = Input_Output.Text
        Label2.Text = "-"
        Input_Output.Text = ""

    End Sub

    Private Sub BtnPositive_Negative_Click(sender As Object, e As EventArgs) Handles BtnPositive_Negative.Click

    End Sub

    'Input Manipulation Functions'
    Private Sub Input_Output_TextChanged(sender As Object, e As EventArgs) Handles Input_Output.TextChanged

    End Sub

    'Output Manipuation Functions'
    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click

        If Label2.Text = "+" Then
            Input_Output.Text = Val(Label1.Text) + Val(Input_Output.Text)
            Label1.Text = ""
            Label2.Text = "="

        End If

        If Label2.Text = "-" Then
            Input_Output.Text = Val(Label1.Text) - Val(Input_Output.Text)
            Label1.Text = ""
            Label2.Text = "="

        End If

        If Label2.Text = "x" Then
            Input_Output.Text = Val(Label1.Text) * Val(Input_Output.Text)
            Label1.Text = ""
            Label2.Text = "="

        End If

        If Label2.Text = "/" Then
            Input_Output.Text = Val(Label1.Text) / Val(Input_Output.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If
    End Sub

    'Other Functions'
    Private Sub BtnOFF_Click(sender As Object, e As EventArgs) Handles BtnOFF.Click

        Label1.Text = ""
        Input_Output.Text = ""
        Label2.Text = ""

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        Label1.Text = ""
        Input_Output.Text = "0"
        Label2.Text = ""


    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Input_Output.Text = ""
        
    End Sub


End Class