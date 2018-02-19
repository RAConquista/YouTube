<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiveTV
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LiveTV))
        Me.AxVLCPlugin21 = New AxAXVLC.AxVLCPlugin2()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Sender15 = New System.Windows.Forms.RadioButton()
        Me.Sender14 = New System.Windows.Forms.RadioButton()
        Me.Sender13 = New System.Windows.Forms.RadioButton()
        Me.Sender12 = New System.Windows.Forms.RadioButton()
        Me.Sender11 = New System.Windows.Forms.RadioButton()
        Me.Sender10 = New System.Windows.Forms.RadioButton()
        Me.Sender09 = New System.Windows.Forms.RadioButton()
        Me.Sender08 = New System.Windows.Forms.RadioButton()
        Me.Sender07 = New System.Windows.Forms.RadioButton()
        Me.Sender06 = New System.Windows.Forms.RadioButton()
        Me.Sender05 = New System.Windows.Forms.RadioButton()
        Me.Sender04 = New System.Windows.Forms.RadioButton()
        Me.Sender03 = New System.Windows.Forms.RadioButton()
        Me.Sender02 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Sender01 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxVLCPlugin21
        '
        Me.AxVLCPlugin21.Enabled = True
        Me.AxVLCPlugin21.Location = New System.Drawing.Point(6, 13)
        Me.AxVLCPlugin21.Name = "AxVLCPlugin21"
        Me.AxVLCPlugin21.OcxState = CType(resources.GetObject("AxVLCPlugin21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlugin21.Size = New System.Drawing.Size(465, 339)
        Me.AxVLCPlugin21.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.StreamKiste.My.Resources.Resources.button_black_1153971
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(608, 482)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 28)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "Schließen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.AxVLCPlugin21)
        Me.GroupBox1.Location = New System.Drawing.Point(209, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 358)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Sender15)
        Me.GroupBox2.Controls.Add(Me.Sender14)
        Me.GroupBox2.Controls.Add(Me.Sender13)
        Me.GroupBox2.Controls.Add(Me.Sender12)
        Me.GroupBox2.Controls.Add(Me.Sender11)
        Me.GroupBox2.Controls.Add(Me.Sender10)
        Me.GroupBox2.Controls.Add(Me.Sender09)
        Me.GroupBox2.Controls.Add(Me.Sender08)
        Me.GroupBox2.Controls.Add(Me.Sender07)
        Me.GroupBox2.Controls.Add(Me.Sender06)
        Me.GroupBox2.Controls.Add(Me.Sender05)
        Me.GroupBox2.Controls.Add(Me.Sender04)
        Me.GroupBox2.Controls.Add(Me.Sender03)
        Me.GroupBox2.Controls.Add(Me.Sender02)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Sender01)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 424)
        Me.GroupBox2.TabIndex = 108
        Me.GroupBox2.TabStop = False
        '
        'Sender15
        '
        Me.Sender15.AutoSize = True
        Me.Sender15.Location = New System.Drawing.Point(15, 341)
        Me.Sender15.Name = "Sender15"
        Me.Sender15.Size = New System.Drawing.Size(66, 17)
        Me.Sender15.TabIndex = 123
        Me.Sender15.Text = "NTV HD"
        Me.Sender15.UseVisualStyleBackColor = True
        '
        'Sender14
        '
        Me.Sender14.AutoSize = True
        Me.Sender14.Location = New System.Drawing.Point(15, 318)
        Me.Sender14.Name = "Sender14"
        Me.Sender14.Size = New System.Drawing.Size(64, 17)
        Me.Sender14.TabIndex = 122
        Me.Sender14.Text = "N24 HD"
        Me.Sender14.UseVisualStyleBackColor = True
        '
        'Sender13
        '
        Me.Sender13.AutoSize = True
        Me.Sender13.Location = New System.Drawing.Point(15, 295)
        Me.Sender13.Name = "Sender13"
        Me.Sender13.Size = New System.Drawing.Size(82, 17)
        Me.Sender13.TabIndex = 121
        Me.Sender13.Text = "Phoenix HD"
        Me.Sender13.UseVisualStyleBackColor = True
        '
        'Sender12
        '
        Me.Sender12.AutoSize = True
        Me.Sender12.Location = New System.Drawing.Point(15, 272)
        Me.Sender12.Name = "Sender12"
        Me.Sender12.Size = New System.Drawing.Size(80, 17)
        Me.Sender12.TabIndex = 120
        Me.Sender12.Text = "PotsdamTV"
        Me.Sender12.UseVisualStyleBackColor = True
        '
        'Sender11
        '
        Me.Sender11.AutoSize = True
        Me.Sender11.Location = New System.Drawing.Point(15, 249)
        Me.Sender11.Name = "Sender11"
        Me.Sender11.Size = New System.Drawing.Size(117, 17)
        Me.Sender11.TabIndex = 119
        Me.Sender11.Text = "NDR Mecklenburg "
        Me.Sender11.UseVisualStyleBackColor = True
        '
        'Sender10
        '
        Me.Sender10.AutoSize = True
        Me.Sender10.Location = New System.Drawing.Point(15, 226)
        Me.Sender10.Name = "Sender10"
        Me.Sender10.Size = New System.Drawing.Size(101, 17)
        Me.Sender10.TabIndex = 118
        Me.Sender10.Text = "MDR Thüringen"
        Me.Sender10.UseVisualStyleBackColor = True
        '
        'Sender09
        '
        Me.Sender09.AutoSize = True
        Me.Sender09.Location = New System.Drawing.Point(15, 203)
        Me.Sender09.Name = "Sender09"
        Me.Sender09.Size = New System.Drawing.Size(111, 17)
        Me.Sender09.TabIndex = 117
        Me.Sender09.Text = "RBB Brandenburg"
        Me.Sender09.UseVisualStyleBackColor = True
        '
        'Sender08
        '
        Me.Sender08.AutoSize = True
        Me.Sender08.Location = New System.Drawing.Point(15, 180)
        Me.Sender08.Name = "Sender08"
        Me.Sender08.Size = New System.Drawing.Size(78, 17)
        Me.Sender08.TabIndex = 116
        Me.Sender08.Text = "ARD Alpha"
        Me.Sender08.UseVisualStyleBackColor = True
        '
        'Sender07
        '
        Me.Sender07.AutoSize = True
        Me.Sender07.Location = New System.Drawing.Point(15, 157)
        Me.Sender07.Name = "Sender07"
        Me.Sender07.Size = New System.Drawing.Size(56, 17)
        Me.Sender07.TabIndex = 115
        Me.Sender07.Text = "ORF 2"
        Me.Sender07.UseVisualStyleBackColor = True
        '
        'Sender06
        '
        Me.Sender06.AutoSize = True
        Me.Sender06.Location = New System.Drawing.Point(15, 134)
        Me.Sender06.Name = "Sender06"
        Me.Sender06.Size = New System.Drawing.Size(71, 17)
        Me.Sender06.TabIndex = 114
        Me.Sender06.Text = "3SAT HD"
        Me.Sender06.UseVisualStyleBackColor = True
        '
        'Sender05
        '
        Me.Sender05.AutoSize = True
        Me.Sender05.Location = New System.Drawing.Point(15, 111)
        Me.Sender05.Name = "Sender05"
        Me.Sender05.Size = New System.Drawing.Size(73, 17)
        Me.Sender05.TabIndex = 113
        Me.Sender05.Text = "ARTE HD"
        Me.Sender05.UseVisualStyleBackColor = True
        '
        'Sender04
        '
        Me.Sender04.AutoSize = True
        Me.Sender04.Location = New System.Drawing.Point(15, 88)
        Me.Sender04.Name = "Sender04"
        Me.Sender04.Size = New System.Drawing.Size(69, 17)
        Me.Sender04.TabIndex = 112
        Me.Sender04.Text = "ZDF Neo"
        Me.Sender04.UseVisualStyleBackColor = True
        '
        'Sender03
        '
        Me.Sender03.AutoSize = True
        Me.Sender03.Location = New System.Drawing.Point(15, 65)
        Me.Sender03.Name = "Sender03"
        Me.Sender03.Size = New System.Drawing.Size(67, 17)
        Me.Sender03.TabIndex = 111
        Me.Sender03.Text = "ZDF Info"
        Me.Sender03.UseVisualStyleBackColor = True
        '
        'Sender02
        '
        Me.Sender02.AutoSize = True
        Me.Sender02.Location = New System.Drawing.Point(15, 42)
        Me.Sender02.Name = "Sender02"
        Me.Sender02.Size = New System.Drawing.Size(65, 17)
        Me.Sender02.TabIndex = 110
        Me.Sender02.Text = "ZDF HD"
        Me.Sender02.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(81, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 109
        Me.Button2.Text = "Umschalten"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Sender01
        '
        Me.Sender01.AutoSize = True
        Me.Sender01.Checked = True
        Me.Sender01.Location = New System.Drawing.Point(15, 19)
        Me.Sender01.Name = "Sender01"
        Me.Sender01.Size = New System.Drawing.Size(71, 17)
        Me.Sender01.TabIndex = 0
        Me.Sender01.TabStop = True
        Me.Sender01.Text = "Das Erste"
        Me.Sender01.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(215, 386)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(377, 75)
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(341, 447)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(240, 45)
        Me.PictureBox2.TabIndex = 110
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(12, 447)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(171, 63)
        Me.PictureBox3.TabIndex = 111
        Me.PictureBox3.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(215, 456)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton1.TabIndex = 124
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Free TV"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(215, 479)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton2.TabIndex = 125
        Me.RadioButton2.Text = "Pay TV"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(624, 398)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 23)
        Me.Button3.TabIndex = 126
        Me.Button3.Text = "TV Guide"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(624, 427)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 23)
        Me.Button4.TabIndex = 127
        Me.Button4.Text = "Uhrzeit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LiveTV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StreamKiste.My.Resources.Resources.Silver_Panel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(705, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LiveTV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StreamKisteTV: Free Live-TV"
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxVLCPlugin21 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Sender01 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender12 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender11 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender10 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender09 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender08 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender07 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender06 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender05 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender04 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender03 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender02 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender14 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender13 As System.Windows.Forms.RadioButton
    Friend WithEvents Sender15 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
