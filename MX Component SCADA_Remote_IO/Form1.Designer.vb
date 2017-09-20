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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblOpen = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblOn1 = New System.Windows.Forms.Label()
        Me.lblOff1 = New System.Windows.Forms.Label()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdOn1 = New System.Windows.Forms.Button()
        Me.cmdOff1 = New System.Windows.Forms.Button()
        Me.AxActUtlType1 = New AxActUtlTypeLib.AxActUtlType()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picDisplay2 = New System.Windows.Forms.PictureBox()
        Me.picDisplay1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdOn2 = New System.Windows.Forms.Button()
        Me.cmdOff2 = New System.Windows.Forms.Button()
        Me.lblOn2 = New System.Windows.Forms.Label()
        Me.lblOff2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblOff3 = New System.Windows.Forms.Label()
        Me.lblOn3 = New System.Windows.Forms.Label()
        Me.picDisplay3 = New System.Windows.Forms.PictureBox()
        Me.cmdOff3 = New System.Windows.Forms.Button()
        Me.cmdOn3 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblOff4 = New System.Windows.Forms.Label()
        Me.lblOn4 = New System.Windows.Forms.Label()
        Me.picDisplay4 = New System.Windows.Forms.PictureBox()
        Me.cmdOff4 = New System.Windows.Forms.Button()
        Me.cmdOn4 = New System.Windows.Forms.Button()
        CType(Me.AxActUtlType1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picDisplay2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisplay1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.picDisplay3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.picDisplay4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOpen
        '
        Me.lblOpen.AutoSize = True
        Me.lblOpen.Location = New System.Drawing.Point(6, 36)
        Me.lblOpen.Name = "lblOpen"
        Me.lblOpen.Size = New System.Drawing.Size(43, 13)
        Me.lblOpen.TabIndex = 0
        Me.lblOpen.Text = "lblOpen"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Location = New System.Drawing.Point(84, 36)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(43, 13)
        Me.lblClose.TabIndex = 1
        Me.lblClose.Text = "lblClose"
        '
        'lblOn1
        '
        Me.lblOn1.AutoSize = True
        Me.lblOn1.Location = New System.Drawing.Point(44, 35)
        Me.lblOn1.Name = "lblOn1"
        Me.lblOn1.Size = New System.Drawing.Size(37, 13)
        Me.lblOn1.TabIndex = 2
        Me.lblOn1.Text = "lblOn1"
        '
        'lblOff1
        '
        Me.lblOff1.AutoSize = True
        Me.lblOff1.Location = New System.Drawing.Point(125, 35)
        Me.lblOff1.Name = "lblOff1"
        Me.lblOff1.Size = New System.Drawing.Size(37, 13)
        Me.lblOff1.TabIndex = 3
        Me.lblOff1.Text = "lblOff1"
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(6, 64)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(75, 23)
        Me.cmdOpen.TabIndex = 4
        Me.cmdOpen.Text = "Open"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(87, 64)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOn1
        '
        Me.cmdOn1.Location = New System.Drawing.Point(6, 67)
        Me.cmdOn1.Name = "cmdOn1"
        Me.cmdOn1.Size = New System.Drawing.Size(75, 23)
        Me.cmdOn1.TabIndex = 6
        Me.cmdOn1.Text = "Y0 ON"
        Me.cmdOn1.UseVisualStyleBackColor = True
        '
        'cmdOff1
        '
        Me.cmdOff1.Location = New System.Drawing.Point(87, 67)
        Me.cmdOff1.Name = "cmdOff1"
        Me.cmdOff1.Size = New System.Drawing.Size(75, 23)
        Me.cmdOff1.TabIndex = 7
        Me.cmdOff1.Text = "Y0 OFF"
        Me.cmdOff1.UseVisualStyleBackColor = True
        '
        'AxActUtlType1
        '
        Me.AxActUtlType1.Enabled = True
        Me.AxActUtlType1.Location = New System.Drawing.Point(522, 29)
        Me.AxActUtlType1.Name = "AxActUtlType1"
        Me.AxActUtlType1.OcxState = CType(resources.GetObject("AxActUtlType1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxActUtlType1.Size = New System.Drawing.Size(32, 32)
        Me.AxActUtlType1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdOpen)
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.lblOpen)
        Me.GroupBox1.Controls.Add(Me.lblClose)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "การเชื่อมต่อ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.picDisplay1)
        Me.GroupBox2.Controls.Add(Me.cmdOn1)
        Me.GroupBox2.Controls.Add(Me.cmdOff1)
        Me.GroupBox2.Controls.Add(Me.lblOn1)
        Me.GroupBox2.Controls.Add(Me.lblOff1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ควบคุม Y0"
        '
        'picDisplay2
        '
        Me.picDisplay2.Location = New System.Drawing.Point(6, 23)
        Me.picDisplay2.Name = "picDisplay2"
        Me.picDisplay2.Size = New System.Drawing.Size(25, 25)
        Me.picDisplay2.TabIndex = 12
        Me.picDisplay2.TabStop = False
        '
        'picDisplay1
        '
        Me.picDisplay1.Location = New System.Drawing.Point(12, 23)
        Me.picDisplay1.Name = "picDisplay1"
        Me.picDisplay1.Size = New System.Drawing.Size(25, 25)
        Me.picDisplay1.TabIndex = 11
        Me.picDisplay1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblOff2)
        Me.GroupBox3.Controls.Add(Me.lblOn2)
        Me.GroupBox3.Controls.Add(Me.picDisplay2)
        Me.GroupBox3.Controls.Add(Me.cmdOff2)
        Me.GroupBox3.Controls.Add(Me.cmdOn2)
        Me.GroupBox3.Location = New System.Drawing.Point(218, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ควบคุม Y1"
        '
        'cmdOn2
        '
        Me.cmdOn2.Location = New System.Drawing.Point(6, 67)
        Me.cmdOn2.Name = "cmdOn2"
        Me.cmdOn2.Size = New System.Drawing.Size(75, 23)
        Me.cmdOn2.TabIndex = 0
        Me.cmdOn2.Text = "Y1 ON"
        Me.cmdOn2.UseVisualStyleBackColor = True
        '
        'cmdOff2
        '
        Me.cmdOff2.Location = New System.Drawing.Point(88, 66)
        Me.cmdOff2.Name = "cmdOff2"
        Me.cmdOff2.Size = New System.Drawing.Size(75, 23)
        Me.cmdOff2.TabIndex = 1
        Me.cmdOff2.Text = "Y1 OFF"
        Me.cmdOff2.UseVisualStyleBackColor = True
        '
        'lblOn2
        '
        Me.lblOn2.AutoSize = True
        Me.lblOn2.Location = New System.Drawing.Point(44, 35)
        Me.lblOn2.Name = "lblOn2"
        Me.lblOn2.Size = New System.Drawing.Size(37, 13)
        Me.lblOn2.TabIndex = 13
        Me.lblOn2.Text = "lblOn2"
        '
        'lblOff2
        '
        Me.lblOff2.AutoSize = True
        Me.lblOff2.Location = New System.Drawing.Point(125, 35)
        Me.lblOff2.Name = "lblOff2"
        Me.lblOff2.Size = New System.Drawing.Size(37, 13)
        Me.lblOff2.TabIndex = 14
        Me.lblOff2.Text = "lblOff2"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblOff3)
        Me.GroupBox4.Controls.Add(Me.lblOn3)
        Me.GroupBox4.Controls.Add(Me.picDisplay3)
        Me.GroupBox4.Controls.Add(Me.cmdOff3)
        Me.GroupBox4.Controls.Add(Me.cmdOn3)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 240)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ควบคุม Y2"
        '
        'lblOff3
        '
        Me.lblOff3.AutoSize = True
        Me.lblOff3.Location = New System.Drawing.Point(125, 28)
        Me.lblOff3.Name = "lblOff3"
        Me.lblOff3.Size = New System.Drawing.Size(37, 13)
        Me.lblOff3.TabIndex = 19
        Me.lblOff3.Text = "lblOff3"
        '
        'lblOn3
        '
        Me.lblOn3.AutoSize = True
        Me.lblOn3.Location = New System.Drawing.Point(44, 28)
        Me.lblOn3.Name = "lblOn3"
        Me.lblOn3.Size = New System.Drawing.Size(37, 13)
        Me.lblOn3.TabIndex = 18
        Me.lblOn3.Text = "lblOn3"
        '
        'picDisplay3
        '
        Me.picDisplay3.Location = New System.Drawing.Point(9, 16)
        Me.picDisplay3.Name = "picDisplay3"
        Me.picDisplay3.Size = New System.Drawing.Size(25, 25)
        Me.picDisplay3.TabIndex = 17
        Me.picDisplay3.TabStop = False
        '
        'cmdOff3
        '
        Me.cmdOff3.Location = New System.Drawing.Point(87, 61)
        Me.cmdOff3.Name = "cmdOff3"
        Me.cmdOff3.Size = New System.Drawing.Size(75, 23)
        Me.cmdOff3.TabIndex = 16
        Me.cmdOff3.Text = "Y2 OFF"
        Me.cmdOff3.UseVisualStyleBackColor = True
        '
        'cmdOn3
        '
        Me.cmdOn3.Location = New System.Drawing.Point(6, 61)
        Me.cmdOn3.Name = "cmdOn3"
        Me.cmdOn3.Size = New System.Drawing.Size(75, 23)
        Me.cmdOn3.TabIndex = 15
        Me.cmdOn3.Text = "Y2 ON"
        Me.cmdOn3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblOff4)
        Me.GroupBox5.Controls.Add(Me.lblOn4)
        Me.GroupBox5.Controls.Add(Me.picDisplay4)
        Me.GroupBox5.Controls.Add(Me.cmdOff4)
        Me.GroupBox5.Controls.Add(Me.cmdOn4)
        Me.GroupBox5.Location = New System.Drawing.Point(218, 240)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ควบคุม Y3"
        '
        'lblOff4
        '
        Me.lblOff4.AutoSize = True
        Me.lblOff4.Location = New System.Drawing.Point(125, 29)
        Me.lblOff4.Name = "lblOff4"
        Me.lblOff4.Size = New System.Drawing.Size(37, 13)
        Me.lblOff4.TabIndex = 19
        Me.lblOff4.Text = "lblOff4"
        '
        'lblOn4
        '
        Me.lblOn4.AutoSize = True
        Me.lblOn4.Location = New System.Drawing.Point(44, 29)
        Me.lblOn4.Name = "lblOn4"
        Me.lblOn4.Size = New System.Drawing.Size(37, 13)
        Me.lblOn4.TabIndex = 18
        Me.lblOn4.Text = "lblOn4"
        '
        'picDisplay4
        '
        Me.picDisplay4.Location = New System.Drawing.Point(6, 16)
        Me.picDisplay4.Name = "picDisplay4"
        Me.picDisplay4.Size = New System.Drawing.Size(25, 25)
        Me.picDisplay4.TabIndex = 17
        Me.picDisplay4.TabStop = False
        '
        'cmdOff4
        '
        Me.cmdOff4.Location = New System.Drawing.Point(87, 61)
        Me.cmdOff4.Name = "cmdOff4"
        Me.cmdOff4.Size = New System.Drawing.Size(75, 23)
        Me.cmdOff4.TabIndex = 16
        Me.cmdOff4.Text = "Y3 OFF"
        Me.cmdOff4.UseVisualStyleBackColor = True
        '
        'cmdOn4
        '
        Me.cmdOn4.Location = New System.Drawing.Point(6, 61)
        Me.cmdOn4.Name = "cmdOn4"
        Me.cmdOn4.Size = New System.Drawing.Size(75, 23)
        Me.cmdOn4.TabIndex = 15
        Me.cmdOn4.Text = "Y3 ON"
        Me.cmdOn4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 411)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AxActUtlType1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxActUtlType1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picDisplay2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisplay1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.picDisplay3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.picDisplay4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblOpen As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lblOn1 As Label
    Friend WithEvents lblOff1 As Label
    Friend WithEvents cmdOpen As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdOn1 As Button
    Friend WithEvents cmdOff1 As Button
    Friend WithEvents AxActUtlType1 As AxActUtlTypeLib.AxActUtlType
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents picDisplay1 As PictureBox
    Friend WithEvents picDisplay2 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdOff2 As Button
    Friend WithEvents cmdOn2 As Button
    Friend WithEvents lblOff2 As Label
    Friend WithEvents lblOn2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblOff3 As Label
    Friend WithEvents lblOn3 As Label
    Friend WithEvents picDisplay3 As PictureBox
    Friend WithEvents cmdOff3 As Button
    Friend WithEvents cmdOn3 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblOff4 As Label
    Friend WithEvents lblOn4 As Label
    Friend WithEvents picDisplay4 As PictureBox
    Friend WithEvents cmdOff4 As Button
    Friend WithEvents cmdOn4 As Button
End Class
