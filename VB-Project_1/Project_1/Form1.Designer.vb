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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox_Port = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Channel = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Disconnet = New System.Windows.Forms.Button()
        Me.Button_Connet = New System.Windows.Forms.Button()
        Me.ListBox_Code = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_Stop = New System.Windows.Forms.Button()
        Me.Button_Run = New System.Windows.Forms.Button()
        Me.TextBox_Up_Down = New System.Windows.Forms.TextBox()
        Me.TextBox_Y = New System.Windows.Forms.TextBox()
        Me.TextBox_X = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_OpenFile = New System.Windows.Forms.Button()
        Me.Button_Left = New System.Windows.Forms.Button()
        Me.Button_Rigth = New System.Windows.Forms.Button()
        Me.Button_Down = New System.Windows.Forms.Button()
        Me.Button_Up = New System.Windows.Forms.Button()
        Me.TextBox_LoadFile = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button8_Down_Y = New System.Windows.Forms.Button()
        Me.Button_Up_X = New System.Windows.Forms.Button()
        Me.Button_Down_X = New System.Windows.Forms.Button()
        Me.Button_Up_Y = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button_X = New System.Windows.Forms.Button()
        Me.Button_Y = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox_Port
        '
        Me.ComboBox_Port.FormattingEnabled = True
        Me.ComboBox_Port.Items.AddRange(New Object() {"COM4", "COM5"})
        Me.ComboBox_Port.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox_Port.Name = "ComboBox_Port"
        Me.ComboBox_Port.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox_Port.TabIndex = 1
        '
        'ComboBox_Channel
        '
        Me.ComboBox_Channel.FormattingEnabled = True
        Me.ComboBox_Channel.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.ComboBox_Channel.Location = New System.Drawing.Point(100, 19)
        Me.ComboBox_Channel.Name = "ComboBox_Channel"
        Me.ComboBox_Channel.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox_Channel.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Disconnet)
        Me.GroupBox1.Controls.Add(Me.Button_Connet)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Port)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Channel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 55)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Port Name"
        '
        'Button_Disconnet
        '
        Me.Button_Disconnet.Location = New System.Drawing.Point(320, 19)
        Me.Button_Disconnet.Name = "Button_Disconnet"
        Me.Button_Disconnet.Size = New System.Drawing.Size(115, 23)
        Me.Button_Disconnet.TabIndex = 6
        Me.Button_Disconnet.Text = "Disconnet"
        Me.Button_Disconnet.UseVisualStyleBackColor = True
        '
        'Button_Connet
        '
        Me.Button_Connet.Location = New System.Drawing.Point(194, 18)
        Me.Button_Connet.Name = "Button_Connet"
        Me.Button_Connet.Size = New System.Drawing.Size(120, 23)
        Me.Button_Connet.TabIndex = 4
        Me.Button_Connet.Text = "Connet"
        Me.Button_Connet.UseVisualStyleBackColor = True
        '
        'ListBox_Code
        '
        Me.ListBox_Code.FormattingEnabled = True
        Me.ListBox_Code.Location = New System.Drawing.Point(474, 12)
        Me.ListBox_Code.Name = "ListBox_Code"
        Me.ListBox_Code.Size = New System.Drawing.Size(161, 238)
        Me.ListBox_Code.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_Stop)
        Me.GroupBox2.Controls.Add(Me.Button_Run)
        Me.GroupBox2.Controls.Add(Me.TextBox_Up_Down)
        Me.GroupBox2.Controls.Add(Me.TextBox_Y)
        Me.GroupBox2.Controls.Add(Me.TextBox_X)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 136)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "G-Code"
        '
        'Button_Stop
        '
        Me.Button_Stop.Location = New System.Drawing.Point(347, 14)
        Me.Button_Stop.Name = "Button_Stop"
        Me.Button_Stop.Size = New System.Drawing.Size(88, 116)
        Me.Button_Stop.TabIndex = 11
        Me.Button_Stop.Text = "STOP"
        Me.Button_Stop.UseVisualStyleBackColor = True
        '
        'Button_Run
        '
        Me.Button_Run.Location = New System.Drawing.Point(243, 14)
        Me.Button_Run.Name = "Button_Run"
        Me.Button_Run.Size = New System.Drawing.Size(82, 116)
        Me.Button_Run.TabIndex = 10
        Me.Button_Run.Text = "RUN"
        Me.Button_Run.UseVisualStyleBackColor = True
        '
        'TextBox_Up_Down
        '
        Me.TextBox_Up_Down.Location = New System.Drawing.Point(124, 83)
        Me.TextBox_Up_Down.Multiline = True
        Me.TextBox_Up_Down.Name = "TextBox_Up_Down"
        Me.TextBox_Up_Down.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Up_Down.TabIndex = 5
        '
        'TextBox_Y
        '
        Me.TextBox_Y.Location = New System.Drawing.Point(124, 51)
        Me.TextBox_Y.Multiline = True
        Me.TextBox_Y.Name = "TextBox_Y"
        Me.TextBox_Y.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Y.TabIndex = 4
        '
        'TextBox_X
        '
        Me.TextBox_X.Location = New System.Drawing.Point(123, 17)
        Me.TextBox_X.Multiline = True
        Me.TextBox_X.Name = "TextBox_X"
        Me.TextBox_X.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_X.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Z"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X"
        '
        'Button_OpenFile
        '
        Me.Button_OpenFile.Location = New System.Drawing.Point(332, 72)
        Me.Button_OpenFile.Name = "Button_OpenFile"
        Me.Button_OpenFile.Size = New System.Drawing.Size(120, 23)
        Me.Button_OpenFile.TabIndex = 8
        Me.Button_OpenFile.Text = "Open"
        Me.Button_OpenFile.UseVisualStyleBackColor = True
        '
        'Button_Left
        '
        Me.Button_Left.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_Left.Location = New System.Drawing.Point(56, 346)
        Me.Button_Left.Name = "Button_Left"
        Me.Button_Left.Size = New System.Drawing.Size(53, 57)
        Me.Button_Left.TabIndex = 7
        Me.Button_Left.Text = "←"
        Me.Button_Left.UseVisualStyleBackColor = True
        '
        'Button_Rigth
        '
        Me.Button_Rigth.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_Rigth.Location = New System.Drawing.Point(218, 346)
        Me.Button_Rigth.Name = "Button_Rigth"
        Me.Button_Rigth.Size = New System.Drawing.Size(53, 57)
        Me.Button_Rigth.TabIndex = 6
        Me.Button_Rigth.Text = "→"
        Me.Button_Rigth.UseVisualStyleBackColor = True
        '
        'Button_Down
        '
        Me.Button_Down.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_Down.Location = New System.Drawing.Point(136, 445)
        Me.Button_Down.Name = "Button_Down"
        Me.Button_Down.Size = New System.Drawing.Size(53, 57)
        Me.Button_Down.TabIndex = 5
        Me.Button_Down.Text = "↓"
        Me.Button_Down.UseVisualStyleBackColor = True
        '
        'Button_Up
        '
        Me.Button_Up.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_Up.Location = New System.Drawing.Point(136, 256)
        Me.Button_Up.Name = "Button_Up"
        Me.Button_Up.Size = New System.Drawing.Size(53, 57)
        Me.Button_Up.TabIndex = 4
        Me.Button_Up.Text = "↑"
        Me.Button_Up.UseVisualStyleBackColor = True
        '
        'TextBox_LoadFile
        '
        Me.TextBox_LoadFile.Location = New System.Drawing.Point(12, 72)
        Me.TextBox_LoadFile.Name = "TextBox_LoadFile"
        Me.TextBox_LoadFile.Size = New System.Drawing.Size(314, 20)
        Me.TextBox_LoadFile.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(474, 256)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(376, 266)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(641, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(209, 238)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = ""
        '
        'Button8_Down_Y
        '
        Me.Button8_Down_Y.Location = New System.Drawing.Point(303, 273)
        Me.Button8_Down_Y.Name = "Button8_Down_Y"
        Me.Button8_Down_Y.Size = New System.Drawing.Size(75, 23)
        Me.Button8_Down_Y.TabIndex = 15
        Me.Button8_Down_Y.Text = "-Y"
        Me.Button8_Down_Y.UseVisualStyleBackColor = True
        '
        'Button_Up_X
        '
        Me.Button_Up_X.Location = New System.Drawing.Point(303, 313)
        Me.Button_Up_X.Name = "Button_Up_X"
        Me.Button_Up_X.Size = New System.Drawing.Size(75, 23)
        Me.Button_Up_X.TabIndex = 14
        Me.Button_Up_X.Text = "X"
        Me.Button_Up_X.UseVisualStyleBackColor = True
        '
        'Button_Down_X
        '
        Me.Button_Down_X.Location = New System.Drawing.Point(393, 313)
        Me.Button_Down_X.Name = "Button_Down_X"
        Me.Button_Down_X.Size = New System.Drawing.Size(75, 23)
        Me.Button_Down_X.TabIndex = 13
        Me.Button_Down_X.Text = "-X"
        Me.Button_Down_X.UseVisualStyleBackColor = True
        '
        'Button_Up_Y
        '
        Me.Button_Up_Y.Location = New System.Drawing.Point(393, 273)
        Me.Button_Up_Y.Name = "Button_Up_Y"
        Me.Button_Up_Y.Size = New System.Drawing.Size(75, 23)
        Me.Button_Up_Y.TabIndex = 12
        Me.Button_Up_Y.Text = "Y"
        Me.Button_Up_Y.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(136, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 57)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "||"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(485, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "X"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(485, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Y"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(520, 273)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(520, 300)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 20
        '
        'Button_X
        '
        Me.Button_X.Location = New System.Drawing.Point(641, 273)
        Me.Button_X.Name = "Button_X"
        Me.Button_X.Size = New System.Drawing.Size(75, 23)
        Me.Button_X.TabIndex = 21
        Me.Button_X.Text = "Button_X"
        Me.Button_X.UseVisualStyleBackColor = True
        '
        'Button_Y
        '
        Me.Button_Y.Location = New System.Drawing.Point(641, 302)
        Me.Button_Y.Name = "Button_Y"
        Me.Button_Y.Size = New System.Drawing.Size(75, 23)
        Me.Button_Y.TabIndex = 22
        Me.Button_Y.Text = "Button_Y"
        Me.Button_Y.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 534)
        Me.Controls.Add(Me.Button_Y)
        Me.Controls.Add(Me.Button_X)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button8_Down_Y)
        Me.Controls.Add(Me.Button_Up_X)
        Me.Controls.Add(Me.Button_Down_X)
        Me.Controls.Add(Me.Button_Up_Y)
        Me.Controls.Add(Me.Button_Left)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_Down)
        Me.Controls.Add(Me.Button_Rigth)
        Me.Controls.Add(Me.Button_Up)
        Me.Controls.Add(Me.TextBox_LoadFile)
        Me.Controls.Add(Me.Button_OpenFile)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListBox_Code)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRBL Controler"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox_Port As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Channel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_OpenFile As System.Windows.Forms.Button
    Friend WithEvents Button_Disconnet As System.Windows.Forms.Button
    Friend WithEvents Button_Connet As System.Windows.Forms.Button
    Friend WithEvents ListBox_Code As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Up_Down As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Y As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_X As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Down As System.Windows.Forms.Button
    Friend WithEvents Button_Up As System.Windows.Forms.Button
    Friend WithEvents Button_Run As System.Windows.Forms.Button
    Friend WithEvents TextBox_LoadFile As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Stop As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button_Left As System.Windows.Forms.Button
    Friend WithEvents Button_Rigth As System.Windows.Forms.Button
    Friend WithEvents Button8_Down_Y As System.Windows.Forms.Button
    Friend WithEvents Button_Up_X As System.Windows.Forms.Button
    Friend WithEvents Button_Down_X As System.Windows.Forms.Button
    Friend WithEvents Button_Up_Y As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button_X As System.Windows.Forms.Button
    Friend WithEvents Button_Y As System.Windows.Forms.Button


End Class
