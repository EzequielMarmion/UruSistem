﻿Module Modulo
    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String

    Public Function cargoGrilla(ByVal rs As ADODB.Recordset, ByRef dgv As DataGridView) As Boolean
        Dim ok As Boolean
        Dim columna, fila As Integer
        ok = True
        dgv.Rows.Clear()
        dgv.Columns.Clear()
        If rs.State <> 1 Then
            ok = False
        Else
            If rs.RecordCount < 1 Then
                ok = False
            Else
                For columna = 0 To rs.Fields.Count - 1
                    dgv.Columns.Add(rs(columna).Name, rs(columna).Name)
                Next
                rs.MoveFirst()
                fila = 0
                While Not rs.EOF
                    dgv.Rows.Add()
                    For columna = 0 To rs.Fields.Count - 1
                        dgv(columna, fila).Value = rs(columna).Value
                    Next
                    fila = fila + 1
                    rs.MoveNext()
                End While
            End If
        End If
        Return (ok)
    End Function

End Module
