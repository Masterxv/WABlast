Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome

Public Class Form1
    Dim tblImport As DataTable
    Dim Driver As IWebDriver
    Dim list As New List(Of String)()

    Private Function cekAlert() As Boolean
        Try
            Driver.SwitchTo.Alert()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub AddToList()
        list.Clear()

        For i As Integer = 0 To Dgv.Rows.Count - 1
            list.Add(Dgv.Rows(i).Cells("DgvNomor").Value)
        Next

        For i As Integer = 0 To Dgv.Rows.Count - 1
            Dgv.Rows(i).Cells("DgvStatus").Value = ""
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        txtPathImage.ReadOnly = True
        txtPathFile.ReadOnly = True
        chkCaption.Enabled = False
        txtCaption.Enabled = False
        btnOpenImage.Enabled = False
        btnOpenFile.Enabled = False
        btnKirim.Enabled = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            Driver = New ChromeDriver
            Driver.Navigate().GoToUrl("https://web.whatsapp.com/")

            btnStart.Text = "Stop"
            btnKirim.Enabled = True

        Else
            Driver.Quit()
            btnStart.Text = "Start"
            btnKirim.Enabled = False
        End If
    End Sub

    Private Sub chkGambar_CheckedChanged(sender As Object, e As EventArgs) Handles chkGambar.CheckedChanged
        If chkGambar.Checked = True Then
            btnOpenImage.Enabled = True
            chkCaption.Enabled = True
        Else
            txtPathImage.Clear()
            btnOpenImage.Enabled = False
            chkCaption.Enabled = False
            chkCaption.Checked = False
            picBox.Image = Nothing
        End If
    End Sub

    Private Sub chkCaption_CheckedChanged(sender As Object, e As EventArgs) Handles chkCaption.CheckedChanged
        If chkCaption.Checked = True Then
            txtCaption.Enabled = True
        Else
            txtCaption.Enabled = False
            txtCaption.Clear()
        End If
    End Sub

    Private Sub btnOpenImage_Click(sender As Object, e As EventArgs) Handles btnOpenImage.Click
        OFD.Title = "Pilih gambar untuk dikirim"
        OFD.Multiselect = False
        OFD.Filter = "Image File (*.png *.jpg *.bmp) | *.png; *.jpg; *.bmp"

        If OFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtPathImage.Text = OFD.FileName

            Dim myFile As String
            For Each myFile In Me.OFD.FileNames
                Dim myStream As FileStream = New FileStream(myFile, FileMode.Open, FileAccess.Read)

                Dim myImageBuffer(myStream.Length) As Byte

                myStream.Read(myImageBuffer, 0, Convert.ToInt32(myStream.Length))

                myStream.Close()

                Dim Streamed As New System.IO.MemoryStream(myImageBuffer)

                picBox.Image = Image.FromStream(Streamed)
                Streamed.Close()
            Next
        End If
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        OFD.Title = "Pilih file untuk dikirim"
        OFD.Multiselect = False
        OFD.Filter = "All files (*.*)|*.*"

        If OFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtPathFile.Text = OFD.FileName
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        With OFD
            .FileName = String.Empty
            .InitialDirectory = "C:\"
            .Title = "Pilih File Excel"
            .Filter = "Excel|*.xls;*.xlsx"
        End With

        Dim result As DialogResult = OFD.ShowDialog()
        'If result = Windows.Forms.DialogResult.OK Then
        Try
            TextBox1.Text = OFD.FileName
            AmbilNamaSheet(TextBox1.Text)
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
        'End If
    End Sub

    Public Sub AmbilNamaSheet(ByVal FileName As String)
        Dim sConn As String
        sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"

        Dim conn As New OleDbConnection(sConn)

        conn.Open()

        Dim dtSheets As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        Dim drSheet As DataRow

        listBox.Items.Clear()
        For Each drSheet In dtSheets.Rows
            listBox.Items.Add(drSheet("TABLE_NAME").ToString())
        Next

        TampilEcxelKeGrid(FileName, listBox.Items(0).ToString)

        conn.Close()
    End Sub

    'Untuk menampilkan data sheet di grid
    Public Sub TampilEcxelKeGrid(ByVal FileName As String, ByVal SheetName As String)
        Dim exConn As OleDbConnection 'MySqlConnection
        Dim dt As DataSet
        Dim cmd As OleDbDataAdapter 'MySqlDataAdapter

        Dim sConn As String
        sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"

        'exConn = New MySql.Data.MySqlClient.MySqlConnection(sConn)
        exConn = New System.Data.OleDb.OleDbConnection(sConn)
        'cmd = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from [" & SheetName & "]", exConn)
        cmd = New System.Data.OleDb.OleDbDataAdapter("select * from [" & SheetName & "]", exConn)
        cmd.TableMappings.Add("Table", SheetName)
        dt = New System.Data.DataSet
        cmd.Fill(dt)
        'tblImport = dt.Tables(0)
        'Dgv.DataSource = tblImport
        Dgv.Rows.Clear()
        For i As Integer = 0 To dt.Tables(0).Rows.Count - 1
            Dgv.Rows.Add()
            Dgv.Rows(Dgv.Rows.Count - 1).Cells("DgvNomor").Value = dt.Tables(0).Rows(i).Item("Nomor")
        Next
        exConn.Close()
    End Sub

    Private Sub listBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox.SelectedIndexChanged
        TampilEcxelKeGrid(TextBox1.Text, listBox.SelectedItem.ToString)
    End Sub

    Private Sub chkFile_CheckedChanged(sender As Object, e As EventArgs) Handles chkFile.CheckedChanged
        If chkFile.Checked = True Then
            btnOpenFile.Enabled = True
        Else
            txtPathFile.Clear()
            btnOpenFile.Enabled = False
        End If
    End Sub

    Private Sub BroadCast()
        PB.Value = 0
        PB.Maximum = list.Count
        lblProses.Text = "0 / " & list.Count

        For i As Integer = 0 To list.Count - 1
            Dim URL As String = "https://web.whatsapp.com/send?phone=" & list(i) & "&text=" & txtPesan.Text & "&source&data&app_absent"
            Driver.Navigate().GoToUrl(URL)

            If cekAlert() = True Then Driver.SwitchTo.Alert.Accept()

            Try
                Threading.Thread.Sleep(3000)
                'CEK JIKA NOMOR HP TIDAK TERDAFTAR
                If txtPesan.Text <> Nothing Then
                    Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()
                End If

                If chkGambar.Checked = True Then
                    'Klik Tombol Attach Image
                    Driver.FindElement(By.CssSelector("span[data-icon='clip']")).Click()
                    'Add file to send by file path
                    Driver.FindElement(By.CssSelector("input[accept='image/*,video/mp4,video/3gpp,video/quicktime']")).SendKeys(txtPathImage.Text)
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub
End Class
