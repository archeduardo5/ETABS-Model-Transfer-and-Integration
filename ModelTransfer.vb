Imports System
Imports System.IO
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports ETABSv17
Imports RAMDATAACCESSLib




Public Class ModelTransfer

    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()

        'FirstScreen.ShowDialog()

        ' TODO : Add constructor code after InitializeComponents

    End Sub

    Public Sub ExportFileBrowse_Click(sender As Object, e As EventArgs) Handles ExportFileBrowseBtn.Click

        'open file dialog

        ExportFileLoc.RestoreDirectory = True
        'If FirstScreen.RhinoFile = True Then
        '    ExportFileLocBrowse.Title = "Select a Rhino File"
        '    ExportFileLocBrowse.Filter = "Rhino Files (*.3dm)|*.3dm"
        'End If

        'If FirstScreen.EtabsFile = True Then
        ExportFileLoc.Title = "Select an Etabs File"
        ExportFileLoc.Filter = "Etabs Files (*.EDB)|*.EDB"
        'End If

        'If FirstScreen.RAMFile = True Then
        '    ExportFileLocBrowse.Title = "Select a RAM File"
        '    ExportFileLocBrowse.Filter = "RAM Files (*.rss)|*.rss"
        'End If

        If ExportFileLoc.ShowDialog() <> System.Windows.Forms.DialogResult.Cancel Then
            ExportFileLocBrowse.Text = ExportFileLoc.FileName
            CsvFileLocBrowse.Text = Path.GetDirectoryName(ExportFileLoc.FileName) & "\" & Path.GetFileNameWithoutExtension(ExportFileLoc.FileName) & ".csv"
            CSVFileLoc.FileName = Path.GetFileNameWithoutExtension(ExportFileLoc.FileName) & ".csv"
        Else
            ExportFileLocBrowse.Text = ""
        End If

    End Sub

    Public Sub ExportOKButton_Click(sender As Object, e As EventArgs) Handles ExportOKButton.Click

        CreateTransferFile()

        'If FirstScreen.RAMFile = True Then
        '    FillRAMData()
        'End If

        'If FirstScreen.EtabsFile = True Then
        EtabsModule.FillEtabsData()
        'End If

        'If FirstScreen.RhinoFile = True Then
        '    FillRhinoData()
        'End If


        Me.Close()
    End Sub

    Sub CSVFileLocBrowseClick(sender As Object, e As System.EventArgs) Handles CsvFileBrowseBtn.Click
        'set open file dialog settings
        'ofdCSVFile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        CSVFileLoc.RestoreDirectory = True
        CSVFileLoc.Title = "Save As"
        CSVFileLoc.Filter = "CSV Files (*.csv)|*.csv"

        If CSVFileLoc.ShowDialog() <> System.Windows.Forms.DialogResult.Cancel Then
            CsvFileLocBrowse.Text = CSVFileLoc.FileName
        Else
            'tbxCSVFile.Text = ""
        End If
    End Sub


    Public Sub CreateTransferFile()


        Dim strRelFilename As String = CsvFileLocBrowse.Text

        'Get the path of the executable (i.e., the main app-directory).
        Dim strStartupPath As String =
   System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)

        'Dim strFullFilename As String = Path.Combine(strStartupPath, strRelFilename)
        'Stop if the CSV doesn't exist
        If Not File.Exists(strRelFilename) Then
            Dim sw As New StreamWriter(strRelFilename)
            sw.Close()
        End If

    End Sub

    Sub FillRAMData()

        Dim strRelFilename As String = CsvFileLocBrowse.Text

        Dim anotherArray(14, 3) As String '...
        'Create some test-data
        For y As Integer = 0 To 14
            For x As Integer = 0 To 3
                anotherArray(y, x) = y.ToString() & ":" & x.ToString()
            Next
        Next

        Dim sb As New Text.StringBuilder
        For y As Integer = 0 To 14
            For x As Integer = 0 To 3
                sb.Append(anotherArray(y, x) + ",")
            Next
            sb.Remove(sb.Length - 1, 1) 'Remove trailing ","
            sb.Append(Environment.NewLine) 'Finish the current line
        Next

        'Write the file
        My.Computer.FileSystem.WriteAllText(strRelFilename, sb.ToString(), False)

    End Sub



    Sub FillRhinoData()

    End Sub


End Class
