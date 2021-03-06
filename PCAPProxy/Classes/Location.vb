﻿Imports System.IO

Public Class Location
    Public Property x() As Single
    Public Property y() As Single

    Public Shared Function parse(b As IList(Of Byte), ByRef o As Integer) As Location
        Dim pos As New Location

        pos.x = byteHandler.readSingle(b, o)
        pos.y = byteHandler.readSingle(b, o)

        Return pos

    End Function
End Class
