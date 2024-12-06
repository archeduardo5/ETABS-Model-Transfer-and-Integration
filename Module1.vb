Imports LumenWorks.Framework.IO.Csv
Imports System.IO




Module Module1

    Public Function CSVT()

        Dim CVSPath As String = ModelTransfer.CsvFileLocBrowse.Text
        Dim dt As New DataTable

        Using sr As New StringReader(CVSPath)

            Using csvR As New CsvReader(sr, False)
                dt.Load(csvR)
            End Using

            sr.Close()

        End Using

        Return dt
    End Function

End Module
