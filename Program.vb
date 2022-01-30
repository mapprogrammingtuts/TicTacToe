Imports System

Module Program
    Const PlayerX As Char = "X"
    Const PlayerO As Char = "O"
    Const Empty As Char = " "
    Dim gameOver As Boolean = False
    Dim board(9 - 1) As Char
    'Indexed from 0, max index = 8
    Dim currentPlayer As Char
    Dim winner As Char = Empty
    Sub Main()
        Console.WriteLine("---------------TIC TAC TOE----------------")
        InitializeGame()

        Do

            MakeMove()
            PrintBoard()
            CheckWinner()

        Loop Until gameOver
        PrintGameOverMessage()
    End Sub
    Sub MakeMove()
        Console.WriteLine($"Player {currentPlayer}, Enter your move in the form 'column,row' e.g 2,3")
        Dim move As String = Console.ReadLine() ' col,row
        'Get the first character in the move, parse that as an integer
        'Get the last character in the move, parse that as an integer
        Dim col As Integer = Integer.Parse(move(0)) - 1
        Dim row As Integer = Integer.Parse(move(2)) - 1

        'Now we play at the position of the board

        board(row * 3 + col) = currentPlayer

        If currentPlayer = PlayerO Then
            currentPlayer = PlayerX
        Else
            currentPlayer = PlayerO
        End If


    End Sub

    Sub InitializeGame()
        For i = 0 To 8
            board(i) = Empty
        Next
        gameOver = False
        winner = Empty
        Dim rand As New Random()
        Dim choice = rand.Next(2) ' 0 or 1
        If choice = 0 Then
            currentPlayer = PlayerO
        Else
            currentPlayer = PlayerX
        End If


    End Sub
End Module
