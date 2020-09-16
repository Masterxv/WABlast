<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.DgvNomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPesan = New System.Windows.Forms.TextBox()
        Me.chkGambar = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPathImage = New System.Windows.Forms.TextBox()
        Me.btnOpenImage = New System.Windows.Forms.Button()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.chkCaption = New System.Windows.Forms.CheckBox()
        Me.txtCaption = New System.Windows.Forms.TextBox()
        Me.chkFile = New System.Windows.Forms.CheckBox()
        Me.txtPathFile = New System.Windows.Forms.TextBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnKirim = New System.Windows.Forms.Button()
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.lblProses = New System.Windows.Forms.Label()
        Me.BGW = New System.ComponentModel.BackgroundWorker()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.listBox = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.AllowUserToResizeColumns = False
        Me.Dgv.AllowUserToResizeRows = False
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvNomor, Me.DgvStatus})
        Me.Dgv.Location = New System.Drawing.Point(13, 13)
        Me.Dgv.MultiSelect = False
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(261, 299)
        Me.Dgv.TabIndex = 0
        '
        'DgvNomor
        '
        Me.DgvNomor.HeaderText = "Nomor HP"
        Me.DgvNomor.Name = "DgvNomor"
        Me.DgvNomor.ReadOnly = True
        Me.DgvNomor.Width = 150
        '
        'DgvStatus
        '
        Me.DgvStatus.HeaderText = "Status"
        Me.DgvStatus.Name = "DgvStatus"
        Me.DgvStatus.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pesan"
        '
        'txtPesan
        '
        Me.txtPesan.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesan.Location = New System.Drawing.Point(384, 13)
        Me.txtPesan.Multiline = True
        Me.txtPesan.Name = "txtPesan"
        Me.txtPesan.Size = New System.Drawing.Size(404, 63)
        Me.txtPesan.TabIndex = 2
        '
        'chkGambar
        '
        Me.chkGambar.AutoSize = True
        Me.chkGambar.Location = New System.Drawing.Point(288, 59)
        Me.chkGambar.Name = "chkGambar"
        Me.chkGambar.Size = New System.Drawing.Size(88, 17)
        Me.chkGambar.TabIndex = 3
        Me.chkGambar.Text = "Kirim Gambar"
        Me.chkGambar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lokasi Gambar"
        '
        'txtPathImage
        '
        Me.txtPathImage.Enabled = False
        Me.txtPathImage.Location = New System.Drawing.Point(384, 93)
        Me.txtPathImage.Name = "txtPathImage"
        Me.txtPathImage.Size = New System.Drawing.Size(353, 20)
        Me.txtPathImage.TabIndex = 5
        '
        'btnOpenImage
        '
        Me.btnOpenImage.Location = New System.Drawing.Point(743, 92)
        Me.btnOpenImage.Name = "btnOpenImage"
        Me.btnOpenImage.Size = New System.Drawing.Size(45, 23)
        Me.btnOpenImage.TabIndex = 6
        Me.btnOpenImage.Text = "..."
        Me.btnOpenImage.UseVisualStyleBackColor = True
        '
        'picBox
        '
        Me.picBox.Location = New System.Drawing.Point(423, 120)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(285, 214)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBox.TabIndex = 7
        Me.picBox.TabStop = False
        '
        'chkCaption
        '
        Me.chkCaption.AutoSize = True
        Me.chkCaption.Location = New System.Drawing.Point(288, 342)
        Me.chkCaption.Name = "chkCaption"
        Me.chkCaption.Size = New System.Drawing.Size(90, 17)
        Me.chkCaption.TabIndex = 3
        Me.chkCaption.Text = "Kirim Caption "
        Me.chkCaption.UseVisualStyleBackColor = True
        '
        'txtCaption
        '
        Me.txtCaption.Location = New System.Drawing.Point(384, 340)
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.Size = New System.Drawing.Size(404, 20)
        Me.txtCaption.TabIndex = 5
        '
        'chkFile
        '
        Me.chkFile.AutoSize = True
        Me.chkFile.Location = New System.Drawing.Point(288, 377)
        Me.chkFile.Name = "chkFile"
        Me.chkFile.Size = New System.Drawing.Size(67, 17)
        Me.chkFile.TabIndex = 3
        Me.chkFile.Text = "Kirim File"
        Me.chkFile.UseVisualStyleBackColor = True
        '
        'txtPathFile
        '
        Me.txtPathFile.Enabled = False
        Me.txtPathFile.Location = New System.Drawing.Point(384, 375)
        Me.txtPathFile.Name = "txtPathFile"
        Me.txtPathFile.Size = New System.Drawing.Size(353, 20)
        Me.txtPathFile.TabIndex = 5
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(743, 374)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(45, 23)
        Me.btnOpenFile.TabIndex = 6
        Me.btnOpenFile.Text = "..."
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(13, 414)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(261, 23)
        Me.btnExport.TabIndex = 8
        Me.btnExport.Text = "Export dari Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(632, 407)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 37)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnKirim
        '
        Me.btnKirim.Location = New System.Drawing.Point(713, 407)
        Me.btnKirim.Name = "btnKirim"
        Me.btnKirim.Size = New System.Drawing.Size(75, 37)
        Me.btnKirim.TabIndex = 9
        Me.btnKirim.Text = "Kirim"
        Me.btnKirim.UseVisualStyleBackColor = True
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(287, 414)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(339, 23)
        Me.PB.TabIndex = 10
        '
        'lblProses
        '
        Me.lblProses.AutoSize = True
        Me.lblProses.Location = New System.Drawing.Point(441, 419)
        Me.lblProses.Name = "lblProses"
        Me.lblProses.Size = New System.Drawing.Size(30, 13)
        Me.lblProses.TabIndex = 4
        Me.lblProses.Text = "0 / 0"
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'listBox
        '
        Me.listBox.FormattingEnabled = True
        Me.listBox.Location = New System.Drawing.Point(13, 319)
        Me.listBox.Name = "listBox"
        Me.listBox.Size = New System.Drawing.Size(261, 69)
        Me.listBox.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(13, 392)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(261, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 454)
        Me.Controls.Add(Me.listBox)
        Me.Controls.Add(Me.lblProses)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.btnKirim)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.btnOpenImage)
        Me.Controls.Add(Me.txtCaption)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtPathFile)
        Me.Controls.Add(Me.txtPathImage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkFile)
        Me.Controls.Add(Me.chkCaption)
        Me.Controls.Add(Me.chkGambar)
        Me.Controls.Add(Me.txtPesan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dgv)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv As DataGridView
    Friend WithEvents DgvNomor As DataGridViewTextBoxColumn
    Friend WithEvents DgvStatus As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPesan As TextBox
    Friend WithEvents chkGambar As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPathImage As TextBox
    Friend WithEvents btnOpenImage As Button
    Friend WithEvents picBox As PictureBox
    Friend WithEvents chkCaption As CheckBox
    Friend WithEvents txtCaption As TextBox
    Friend WithEvents chkFile As CheckBox
    Friend WithEvents txtPathFile As TextBox
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnKirim As Button
    Friend WithEvents PB As ProgressBar
    Friend WithEvents lblProses As Label
    Friend WithEvents BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents listBox As ListBox
    Friend WithEvents TextBox1 As TextBox
End Class
