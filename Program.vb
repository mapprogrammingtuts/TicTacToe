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

End Module
