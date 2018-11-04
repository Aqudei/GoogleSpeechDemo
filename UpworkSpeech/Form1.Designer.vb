<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SpeechToTextButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumSecondsTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SaveAsMP3Button = New System.Windows.Forms.Button()
        Me.PlayImmediatelyButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SpeechToTextButton
        '
        Me.SpeechToTextButton.Location = New System.Drawing.Point(261, 32)
        Me.SpeechToTextButton.Name = "SpeechToTextButton"
        Me.SpeechToTextButton.Size = New System.Drawing.Size(279, 33)
        Me.SpeechToTextButton.TabIndex = 0
        Me.SpeechToTextButton.Text = "Start Speech-To-Text Test"
        Me.SpeechToTextButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(257, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "[Message]"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ResultLabel)
        Me.GroupBox1.Controls.Add(Me.ResultTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumSecondsTextBox)
        Me.GroupBox1.Controls.Add(Me.SpeechToTextButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 165)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Speech-To-Text"
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = True
        Me.ResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultLabel.Location = New System.Drawing.Point(27, 90)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(67, 24)
        Me.ResultLabel.TabIndex = 5
        Me.ResultLabel.Text = "Result:"
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(22, 117)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(532, 29)
        Me.ResultTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 54)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "number of seconds to capture"
        '
        'NumSecondsTextBox
        '
        Me.NumSecondsTextBox.Location = New System.Drawing.Point(20, 36)
        Me.NumSecondsTextBox.Name = "NumSecondsTextBox"
        Me.NumSecondsTextBox.Size = New System.Drawing.Size(41, 29)
        Me.NumSecondsTextBox.TabIndex = 2
        Me.NumSecondsTextBox.Text = "3"
        Me.NumSecondsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SaveAsMP3Button)
        Me.GroupBox2.Controls.Add(Me.PlayImmediatelyButton)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.InputTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 165)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Text-To-Speech"
        '
        'SaveAsMP3Button
        '
        Me.SaveAsMP3Button.Location = New System.Drawing.Point(378, 103)
        Me.SaveAsMP3Button.Name = "SaveAsMP3Button"
        Me.SaveAsMP3Button.Size = New System.Drawing.Size(174, 33)
        Me.SaveAsMP3Button.TabIndex = 7
        Me.SaveAsMP3Button.Text = "Save as MP3"
        Me.SaveAsMP3Button.UseVisualStyleBackColor = True
        '
        'PlayImmediatelyButton
        '
        Me.PlayImmediatelyButton.Location = New System.Drawing.Point(20, 103)
        Me.PlayImmediatelyButton.Name = "PlayImmediatelyButton"
        Me.PlayImmediatelyButton.Size = New System.Drawing.Size(174, 33)
        Me.PlayImmediatelyButton.TabIndex = 6
        Me.PlayImmediatelyButton.Text = "Play Immediately"
        Me.PlayImmediatelyButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Text:"
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(20, 68)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(532, 29)
        Me.InputTextBox.TabIndex = 4
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "mp3"
        Me.SaveFileDialog1.Filter = "MP3 Files|*.mp3"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 361)
        Me.ProgressBar1.MarqueeAnimationSpeed = 25
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(584, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 384)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Google Cloud Speech API  Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SpeechToTextButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ResultLabel As Label
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NumSecondsTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents SaveAsMP3Button As Button
    Friend WithEvents PlayImmediatelyButton As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
