'Author: Ritvik Mayank <mritvik@novell.com>
'Copyright (C) 2005 Novell, Inc (http://www.novell.com)
Option Strict Off
Imports System
Module ConversionOrOperator

    Function Main() As Integer
        Dim A As Integer = 333
        Dim B As Double = 555.555
        Dim R As Boolean
        R = (B > A) Or (A < B)
        If R = 0 Then
            System.Console.WriteLine("#Error With Or Operator") : Return 1
        End If
    End Function
End Module
