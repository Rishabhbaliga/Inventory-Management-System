Imports System.IO
Imports System.Net

Public Class FTP
    Dim fName As String
    Dim downExt As String
    Dim strArr() As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fileExt As String
        Dim filePath As String

        Dim upFileName As String = TextBox1.Text

        OpenFileDialog1.ShowDialog()
        filePath = OpenFileDialog1.FileName

        fileExt = My.Computer.FileSystem.GetFileInfo(filePath).Extension
        Dim fileName As String = My.Computer.FileSystem.GetName(filePath)

        If upFileName = String.Empty Then
            FtpUploadFile(filePath, "ftp://ftp.site4now.net/" & fileName, "rishabh9954", "H9e9rambh5#")
            TextBox1.Clear()
            TextBox2.Clear()
        Else
            FtpUploadFile(filePath, "ftp://ftp.site4now.net/" & upFileName & fileExt, "rishabh9954", "H9e9rambh5#")
            TextBox1.Clear()
            TextBox2.Clear()
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim downPath As String

        Dim downFileName As String = TextBox2.Text

        If fName = String.Empty Then
            MsgBox("Select File Name")
        Else

            FolderBrowserDialog1.ShowDialog()
            downPath = FolderBrowserDialog1.SelectedPath

            If downFileName = String.Empty Then
                FTPDownloadFile(downPath & "/" & fName, "ftp://ftp.site4now.net/" & fName, "rishabh9954", "H9e9rambh5#")
                TextBox1.Clear()
                TextBox2.Clear()
            Else
                FTPDownloadFile(downPath & "/" & downFileName & "." & downExt, "ftp://ftp.site4now.net/" & fName, "rishabh9954", "H9e9rambh5#")
                TextBox1.Clear()
                TextBox2.Clear()
            End If

        End If
    End Sub

    Private Sub FtpUploadFile(ByVal filetoupload As String, ByVal ftpuri As String, ByVal ftpusername As String, ByVal ftppassword As String)
        Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create(ftpuri), FtpWebRequest)

        Try
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile

            ftpRequest.Credentials = New NetworkCredential(ftpusername, ftppassword)

            Dim bytes() As Byte = System.IO.File.ReadAllBytes(filetoupload)

            ftpRequest.ContentLength = bytes.Length
            Using UploadStream As Stream = ftpRequest.GetRequestStream()
                UploadStream.Write(bytes, 0, bytes.Length)
                UploadStream.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show("Process Complete")
        Page_Load()
    End Sub

    Private Sub FTPDownloadFile(ByVal downloadpath As String, ByVal ftpuri As String, ByVal ftpusername As String, ByVal ftppassword As String)
        Dim request As New WebClient()

        request.Credentials = New NetworkCredential(ftpusername, ftppassword)

        Dim bytes() As Byte = request.DownloadData(ftpuri)

        Try
            Dim DownloadStream As FileStream = IO.File.Create(downloadpath)
            DownloadStream.Write(bytes, 0, bytes.Length)
            DownloadStream.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        MessageBox.Show("Process Complete")

    End Sub

    Protected Sub Page_Load() Handles Me.Load
        ListBox1.Items.Clear()
        Dim ftp As FtpWebRequest = DirectCast(WebRequest.Create("ftp://ftp.site4now.net/"), FtpWebRequest)
        ftp.Method = WebRequestMethods.Ftp.ListDirectory
        Dim ftpFiles As New ArrayList()
        ftp.Credentials = New NetworkCredential("rishabh9954", "H9e9rambh5#")
        Dim Response As FtpWebResponse = ftp.GetResponse()
        Dim responseStream As Stream = Response.GetResponseStream()
        Dim reader = New StreamReader(responseStream)
        While Not (reader.EndOfStream)
            ftpFiles.Add(reader.ReadLine())
        End While

        For Each file In ftpFiles
            ListBox1.Items.Add(file)
        Next
        reader.Close()
        responseStream.Close()
        Response.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            fName = ListBox1.SelectedItem.ToString
            'MsgBox(fName)
            strArr = fName.Split(".")
            downExt = strArr(1)
            'MsgBox(downExt)
        Catch ex As Exception
            MsgBox("Please Click On A File Name")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class