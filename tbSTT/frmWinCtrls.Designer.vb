<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWinCtrls
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
        Me.lblSPKModel = New System.Windows.Forms.Label()
        Me.lblVoskModel = New System.Windows.Forms.Label()
        Me.lblWAVFile = New System.Windows.Forms.Label()
        Me.chkInclParts = New System.Windows.Forms.CheckBox()
        Me.txtSPKModel = New System.Windows.Forms.TextBox()
        Me.txtVoskModel = New System.Windows.Forms.TextBox()
        Me.txtWAVFile = New System.Windows.Forms.TextBox()
        Me.btnSPKModel = New System.Windows.Forms.Button()
        Me.btnVoskModel = New System.Windows.Forms.Button()
        Me.btnWAVFile = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblSPKModel
        '
        Me.lblSPKModel.AutoSize = True
        Me.lblSPKModel.Location = New System.Drawing.Point(12, 17)
        Me.lblSPKModel.Name = "lblSPKModel"
        Me.lblSPKModel.Size = New System.Drawing.Size(63, 13)
        Me.lblSPKModel.TabIndex = 0
        Me.lblSPKModel.Text = "SPK Model:"
        Me.lblSPKModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVoskModel
        '
        Me.lblVoskModel.AutoSize = True
        Me.lblVoskModel.Location = New System.Drawing.Point(12, 46)
        Me.lblVoskModel.Name = "lblVoskModel"
        Me.lblVoskModel.Size = New System.Drawing.Size(66, 13)
        Me.lblVoskModel.TabIndex = 1
        Me.lblVoskModel.Text = "Vosk Model:"
        Me.lblVoskModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWAVFile
        '
        Me.lblWAVFile.AutoSize = True
        Me.lblWAVFile.Location = New System.Drawing.Point(12, 75)
        Me.lblWAVFile.Name = "lblWAVFile"
        Me.lblWAVFile.Size = New System.Drawing.Size(54, 13)
        Me.lblWAVFile.TabIndex = 2
        Me.lblWAVFile.Text = "WAV File:"
        Me.lblWAVFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkInclParts
        '
        Me.chkInclParts.AutoSize = True
        Me.chkInclParts.Location = New System.Drawing.Point(12, 103)
        Me.chkInclParts.Name = "chkInclParts"
        Me.chkInclParts.Size = New System.Drawing.Size(104, 17)
        Me.chkInclParts.TabIndex = 3
        Me.chkInclParts.Text = "Include Partials?"
        Me.chkInclParts.UseVisualStyleBackColor = True
        '
        'txtSPKModel
        '
        Me.txtSPKModel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSPKModel.Location = New System.Drawing.Point(81, 13)
        Me.txtSPKModel.Name = "txtSPKModel"
        Me.txtSPKModel.ReadOnly = True
        Me.txtSPKModel.Size = New System.Drawing.Size(299, 20)
        Me.txtSPKModel.TabIndex = 4
        Me.txtSPKModel.Text = "Load SPK Model"
        '
        'txtVoskModel
        '
        Me.txtVoskModel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVoskModel.Location = New System.Drawing.Point(84, 42)
        Me.txtVoskModel.Name = "txtVoskModel"
        Me.txtVoskModel.ReadOnly = True
        Me.txtVoskModel.Size = New System.Drawing.Size(296, 20)
        Me.txtVoskModel.TabIndex = 5
        Me.txtVoskModel.Text = "Load Vosk Model"
        '
        'txtWAVFile
        '
        Me.txtWAVFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWAVFile.Location = New System.Drawing.Point(72, 71)
        Me.txtWAVFile.Name = "txtWAVFile"
        Me.txtWAVFile.ReadOnly = True
        Me.txtWAVFile.Size = New System.Drawing.Size(308, 20)
        Me.txtWAVFile.TabIndex = 6
        Me.txtWAVFile.Text = "Select WAV File"
        '
        'btnSPKModel
        '
        Me.btnSPKModel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSPKModel.Location = New System.Drawing.Point(386, 12)
        Me.btnSPKModel.Name = "btnSPKModel"
        Me.btnSPKModel.Size = New System.Drawing.Size(75, 23)
        Me.btnSPKModel.TabIndex = 7
        Me.btnSPKModel.Text = "Load"
        Me.btnSPKModel.UseVisualStyleBackColor = True
        '
        'btnVoskModel
        '
        Me.btnVoskModel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoskModel.Location = New System.Drawing.Point(386, 41)
        Me.btnVoskModel.Name = "btnVoskModel"
        Me.btnVoskModel.Size = New System.Drawing.Size(75, 23)
        Me.btnVoskModel.TabIndex = 8
        Me.btnVoskModel.Text = "Load"
        Me.btnVoskModel.UseVisualStyleBackColor = True
        '
        'btnWAVFile
        '
        Me.btnWAVFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWAVFile.Location = New System.Drawing.Point(386, 70)
        Me.btnWAVFile.Name = "btnWAVFile"
        Me.btnWAVFile.Size = New System.Drawing.Size(75, 23)
        Me.btnWAVFile.TabIndex = 9
        Me.btnWAVFile.Text = "Open"
        Me.btnWAVFile.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRun.Location = New System.Drawing.Point(386, 99)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 10
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.Location = New System.Drawing.Point(12, 128)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(449, 179)
        Me.txtOutput.TabIndex = 11
        Me.txtOutput.Text = ""
        '
        'frmWinCtrls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 319)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnWAVFile)
        Me.Controls.Add(Me.btnVoskModel)
        Me.Controls.Add(Me.btnSPKModel)
        Me.Controls.Add(Me.txtWAVFile)
        Me.Controls.Add(Me.txtVoskModel)
        Me.Controls.Add(Me.txtSPKModel)
        Me.Controls.Add(Me.chkInclParts)
        Me.Controls.Add(Me.lblWAVFile)
        Me.Controls.Add(Me.lblVoskModel)
        Me.Controls.Add(Me.lblSPKModel)
        Me.Name = "frmWinCtrls"
        Me.Text = "tbSTT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSPKModel As Label
    Friend WithEvents lblVoskModel As Label
    Friend WithEvents lblWAVFile As Label
    Friend WithEvents chkInclParts As CheckBox
    Friend WithEvents txtSPKModel As TextBox
    Friend WithEvents txtVoskModel As TextBox
    Friend WithEvents txtWAVFile As TextBox
    Friend WithEvents btnSPKModel As Button
    Friend WithEvents btnVoskModel As Button
    Friend WithEvents btnWAVFile As Button
    Friend WithEvents btnRun As Button
    Friend WithEvents txtOutput As RichTextBox
End Class
