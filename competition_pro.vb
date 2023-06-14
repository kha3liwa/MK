Public Class competition_pro



    '================================
    Function NumberToText(ByVal number As Integer) As String
        If IsNumeric(number) Then
            NumberToText = CStr(number)
        Else
            NumberToText = "Invalid input. Please enter a numeric value."
        End If
    End Function
    '================================
    Sub TestNumberToText()
        Dim number As Integer
        Dim textValue As String

        number = 12345
        textValue = NumberToText(number)

        MsgBox("The text value of the number is: " & textValue)
    End Sub
    Function GetQuestionText(ByVal questionNumber As Long, ByVal questions() As String) As String
        If questionNumber >= 1 And questionNumber <= UBound(questions) Then
            GetQuestionText = questions(questionNumber)
        Else
            GetQuestionText = "Invalid question number. Please enter a valid question number."
        End If
    End Function

    Sub TestGetQuestionText()
        Dim questions(0 To 60) As String
        Dim questionNumber As Long
        Dim questionText As String

        ' Populate the questions array with sample questions
        For i = 0 To 60
            questions(i) = "Question " & i
        Next i

        ' Set the question number you want to retrieve
        questionNumber = 5

        ' Call the GetQuestionText function
        questionText = GetQuestionText(questionNumber, questions)

        ' Display the question text in a message box
        MsgBox("The text of question " & questionNumber & " is: " & questionText)
    End Sub

    Private Sub competition_pro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class