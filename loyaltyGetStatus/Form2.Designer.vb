<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.label3 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.button4 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 245)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(47, 13)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Request"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(88, 40)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Getstatus"
        Me.button2.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(588, 270)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(440, 232)
        Me.textBox1.TabIndex = 15
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(12, 270)
        Me.textBox3.Multiline = True
        Me.textBox3.Name = "textBox3"
        Me.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox3.Size = New System.Drawing.Size(474, 219)
        Me.textBox3.TabIndex = 14
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(255, 40)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(75, 23)
        Me.button4.TabIndex = 3
        Me.button4.Text = "AddCredits"
        Me.button4.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.button4)
        Me.groupBox1.Location = New System.Drawing.Point(306, 113)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(394, 91)
        Me.groupBox1.TabIndex = 13
        Me.groupBox1.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(585, 245)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 13)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Result"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 531)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form2"
        Me.Text = "Form1"
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog

End Class
