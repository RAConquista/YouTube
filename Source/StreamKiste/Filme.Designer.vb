<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filme))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FB14 = New System.Windows.Forms.RadioButton()
        Me.FB13 = New System.Windows.Forms.RadioButton()
        Me.FB12 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FB11 = New System.Windows.Forms.RadioButton()
        Me.FB10 = New System.Windows.Forms.RadioButton()
        Me.FB09 = New System.Windows.Forms.RadioButton()
        Me.FB08 = New System.Windows.Forms.RadioButton()
        Me.RB07 = New System.Windows.Forms.RadioButton()
        Me.RB06 = New System.Windows.Forms.RadioButton()
        Me.RB05 = New System.Windows.Forms.RadioButton()
        Me.RB04 = New System.Windows.Forms.RadioButton()
        Me.RB03 = New System.Windows.Forms.RadioButton()
        Me.RB02 = New System.Windows.Forms.RadioButton()
        Me.RB01 = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FB22 = New System.Windows.Forms.RadioButton()
        Me.FB21 = New System.Windows.Forms.RadioButton()
        Me.FB20 = New System.Windows.Forms.RadioButton()
        Me.FB19 = New System.Windows.Forms.RadioButton()
        Me.FB18 = New System.Windows.Forms.RadioButton()
        Me.FB17 = New System.Windows.Forms.RadioButton()
        Me.FB16 = New System.Windows.Forms.RadioButton()
        Me.FB15 = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.FB23 = New System.Windows.Forms.RadioButton()
        Me.FB24 = New System.Windows.Forms.RadioButton()
        Me.FB25 = New System.Windows.Forms.RadioButton()
        Me.FB26 = New System.Windows.Forms.RadioButton()
        Me.FB27 = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.StreamKiste.My.Resources.Resources.button_black_1153971
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(607, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Hauptmenü"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(244, 413)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.BackgroundImage = Global.StreamKiste.My.Resources.Resources.Silver_Panel
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage1.Controls.Add(Me.FB14)
        Me.TabPage1.Controls.Add(Me.FB13)
        Me.TabPage1.Controls.Add(Me.FB12)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.FB11)
        Me.TabPage1.Controls.Add(Me.FB10)
        Me.TabPage1.Controls.Add(Me.FB09)
        Me.TabPage1.Controls.Add(Me.FB08)
        Me.TabPage1.Controls.Add(Me.RB07)
        Me.TabPage1.Controls.Add(Me.RB06)
        Me.TabPage1.Controls.Add(Me.RB05)
        Me.TabPage1.Controls.Add(Me.RB04)
        Me.TabPage1.Controls.Add(Me.RB03)
        Me.TabPage1.Controls.Add(Me.RB02)
        Me.TabPage1.Controls.Add(Me.RB01)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(236, 387)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Seite 1"
        '
        'FB14
        '
        Me.FB14.AutoSize = True
        Me.FB14.BackColor = System.Drawing.Color.Transparent
        Me.FB14.Checked = True
        Me.FB14.Location = New System.Drawing.Point(15, 320)
        Me.FB14.Name = "FB14"
        Me.FB14.Size = New System.Drawing.Size(89, 17)
        Me.FB14.TabIndex = 30
        Me.FB14.TabStop = True
        Me.FB14.Text = "Dirty Dancing"
        Me.FB14.UseVisualStyleBackColor = False
        '
        'FB13
        '
        Me.FB13.AutoSize = True
        Me.FB13.BackColor = System.Drawing.Color.Transparent
        Me.FB13.Location = New System.Drawing.Point(15, 297)
        Me.FB13.Name = "FB13"
        Me.FB13.Size = New System.Drawing.Size(166, 17)
        Me.FB13.TabIndex = 29
        Me.FB13.Text = "Made of Steel - Hart wie Stahl"
        Me.FB13.UseVisualStyleBackColor = False
        '
        'FB12
        '
        Me.FB12.AutoSize = True
        Me.FB12.BackColor = System.Drawing.Color.Transparent
        Me.FB12.Location = New System.Drawing.Point(15, 274)
        Me.FB12.Name = "FB12"
        Me.FB12.Size = New System.Drawing.Size(103, 17)
        Me.FB12.TabIndex = 28
        Me.FB12.Text = "Friday After Next"
        Me.FB12.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.StreamKiste.My.Resources.Resources.button_black_1153971
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Silver
        Me.Button2.Location = New System.Drawing.Point(123, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Wiedergabe"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FB11
        '
        Me.FB11.AutoSize = True
        Me.FB11.BackColor = System.Drawing.Color.Transparent
        Me.FB11.Location = New System.Drawing.Point(15, 251)
        Me.FB11.Name = "FB11"
        Me.FB11.Size = New System.Drawing.Size(78, 17)
        Me.FB11.TabIndex = 27
        Me.FB11.Text = "Next Friday"
        Me.FB11.UseVisualStyleBackColor = False
        '
        'FB10
        '
        Me.FB10.AutoSize = True
        Me.FB10.BackColor = System.Drawing.Color.Transparent
        Me.FB10.Location = New System.Drawing.Point(15, 228)
        Me.FB10.Name = "FB10"
        Me.FB10.Size = New System.Drawing.Size(53, 17)
        Me.FB10.TabIndex = 26
        Me.FB10.Text = "Friday"
        Me.FB10.UseVisualStyleBackColor = False
        '
        'FB09
        '
        Me.FB09.AutoSize = True
        Me.FB09.BackColor = System.Drawing.Color.Transparent
        Me.FB09.Location = New System.Drawing.Point(15, 205)
        Me.FB09.Name = "FB09"
        Me.FB09.Size = New System.Drawing.Size(178, 17)
        Me.FB09.TabIndex = 25
        Me.FB09.Text = "The Chase - Die Wahnsinnsjagd"
        Me.FB09.UseVisualStyleBackColor = False
        '
        'FB08
        '
        Me.FB08.AutoSize = True
        Me.FB08.BackColor = System.Drawing.Color.Transparent
        Me.FB08.Location = New System.Drawing.Point(15, 182)
        Me.FB08.Name = "FB08"
        Me.FB08.Size = New System.Drawing.Size(135, 17)
        Me.FB08.TabIndex = 24
        Me.FB08.Text = "Unser Willi ist der beste"
        Me.FB08.UseVisualStyleBackColor = False
        '
        'RB07
        '
        Me.RB07.AutoSize = True
        Me.RB07.BackColor = System.Drawing.Color.Transparent
        Me.RB07.Location = New System.Drawing.Point(15, 159)
        Me.RB07.Name = "RB07"
        Me.RB07.Size = New System.Drawing.Size(194, 17)
        Me.RB07.TabIndex = 23
        Me.RB07.Text = "Willi wird das Kind schon schaukeln"
        Me.RB07.UseVisualStyleBackColor = False
        '
        'RB06
        '
        Me.RB06.AutoSize = True
        Me.RB06.BackColor = System.Drawing.Color.Transparent
        Me.RB06.Location = New System.Drawing.Point(15, 136)
        Me.RB06.Name = "RB06"
        Me.RB06.Size = New System.Drawing.Size(76, 17)
        Me.RB06.TabIndex = 22
        Me.RB06.Text = "Der Pate II"
        Me.RB06.UseVisualStyleBackColor = False
        '
        'RB05
        '
        Me.RB05.AutoSize = True
        Me.RB05.BackColor = System.Drawing.Color.Transparent
        Me.RB05.Location = New System.Drawing.Point(15, 113)
        Me.RB05.Name = "RB05"
        Me.RB05.Size = New System.Drawing.Size(73, 17)
        Me.RB05.TabIndex = 21
        Me.RB05.Text = "Der Pate I"
        Me.RB05.UseVisualStyleBackColor = False
        '
        'RB04
        '
        Me.RB04.AutoSize = True
        Me.RB04.BackColor = System.Drawing.Color.Transparent
        Me.RB04.Location = New System.Drawing.Point(15, 90)
        Me.RB04.Name = "RB04"
        Me.RB04.Size = New System.Drawing.Size(103, 17)
        Me.RB04.TabIndex = 20
        Me.RB04.Text = "The Dark Knight"
        Me.RB04.UseVisualStyleBackColor = False
        '
        'RB03
        '
        Me.RB03.AutoSize = True
        Me.RB03.BackColor = System.Drawing.Color.Transparent
        Me.RB03.Location = New System.Drawing.Point(15, 67)
        Me.RB03.Name = "RB03"
        Me.RB03.Size = New System.Drawing.Size(97, 17)
        Me.RB03.TabIndex = 19
        Me.RB03.Text = "Die Verurteilten"
        Me.RB03.UseVisualStyleBackColor = False
        '
        'RB02
        '
        Me.RB02.AutoSize = True
        Me.RB02.BackColor = System.Drawing.Color.Transparent
        Me.RB02.Location = New System.Drawing.Point(15, 42)
        Me.RB02.Name = "RB02"
        Me.RB02.Size = New System.Drawing.Size(160, 17)
        Me.RB02.TabIndex = 18
        Me.RB02.Text = "The Mimic - Dunkle Stimmen"
        Me.RB02.UseVisualStyleBackColor = False
        '
        'RB01
        '
        Me.RB01.AutoSize = True
        Me.RB01.BackColor = System.Drawing.Color.Transparent
        Me.RB01.Checked = True
        Me.RB01.Location = New System.Drawing.Point(15, 19)
        Me.RB01.Name = "RB01"
        Me.RB01.Size = New System.Drawing.Size(170, 17)
        Me.RB01.TabIndex = 17
        Me.RB01.TabStop = True
        Me.RB01.Text = "Thor 3 - Tag der Entscheidung"
        Me.RB01.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.BackgroundImage = Global.StreamKiste.My.Resources.Resources.Silver_Panel
        Me.TabPage2.Controls.Add(Me.FB27)
        Me.TabPage2.Controls.Add(Me.FB26)
        Me.TabPage2.Controls.Add(Me.FB25)
        Me.TabPage2.Controls.Add(Me.FB24)
        Me.TabPage2.Controls.Add(Me.FB23)
        Me.TabPage2.Controls.Add(Me.FB22)
        Me.TabPage2.Controls.Add(Me.FB21)
        Me.TabPage2.Controls.Add(Me.FB20)
        Me.TabPage2.Controls.Add(Me.FB19)
        Me.TabPage2.Controls.Add(Me.FB18)
        Me.TabPage2.Controls.Add(Me.FB17)
        Me.TabPage2.Controls.Add(Me.FB16)
        Me.TabPage2.Controls.Add(Me.FB15)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(236, 387)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Seite 2"
        '
        'FB22
        '
        Me.FB22.AutoSize = True
        Me.FB22.BackColor = System.Drawing.Color.Transparent
        Me.FB22.Location = New System.Drawing.Point(15, 180)
        Me.FB22.Name = "FB22"
        Me.FB22.Size = New System.Drawing.Size(138, 17)
        Me.FB22.TabIndex = 38
        Me.FB22.Text = "Star Trek Into Darkness"
        Me.FB22.UseVisualStyleBackColor = False
        '
        'FB21
        '
        Me.FB21.AutoSize = True
        Me.FB21.BackColor = System.Drawing.Color.Transparent
        Me.FB21.Location = New System.Drawing.Point(15, 157)
        Me.FB21.Name = "FB21"
        Me.FB21.Size = New System.Drawing.Size(64, 17)
        Me.FB21.TabIndex = 37
        Me.FB21.Text = "Timeline"
        Me.FB21.UseVisualStyleBackColor = False
        '
        'FB20
        '
        Me.FB20.AutoSize = True
        Me.FB20.BackColor = System.Drawing.Color.Transparent
        Me.FB20.Location = New System.Drawing.Point(15, 134)
        Me.FB20.Name = "FB20"
        Me.FB20.Size = New System.Drawing.Size(142, 17)
        Me.FB20.TabIndex = 36
        Me.FB20.Text = "Godzilla - Monster Planet"
        Me.FB20.UseVisualStyleBackColor = False
        '
        'FB19
        '
        Me.FB19.AutoSize = True
        Me.FB19.BackColor = System.Drawing.Color.Transparent
        Me.FB19.Location = New System.Drawing.Point(15, 111)
        Me.FB19.Name = "FB19"
        Me.FB19.Size = New System.Drawing.Size(107, 17)
        Me.FB19.TabIndex = 35
        Me.FB19.Text = "The Thing (2011)"
        Me.FB19.UseVisualStyleBackColor = False
        '
        'FB18
        '
        Me.FB18.AutoSize = True
        Me.FB18.BackColor = System.Drawing.Color.Transparent
        Me.FB18.Location = New System.Drawing.Point(15, 88)
        Me.FB18.Name = "FB18"
        Me.FB18.Size = New System.Drawing.Size(143, 17)
        Me.FB18.TabIndex = 34
        Me.FB18.Text = "Star Trek - Der neue Film"
        Me.FB18.UseVisualStyleBackColor = False
        '
        'FB17
        '
        Me.FB17.AutoSize = True
        Me.FB17.BackColor = System.Drawing.Color.Transparent
        Me.FB17.Location = New System.Drawing.Point(15, 65)
        Me.FB17.Name = "FB17"
        Me.FB17.Size = New System.Drawing.Size(163, 17)
        Me.FB17.TabIndex = 33
        Me.FB17.Text = "The Ark - Wir sind nicht allein"
        Me.FB17.UseVisualStyleBackColor = False
        '
        'FB16
        '
        Me.FB16.AutoSize = True
        Me.FB16.BackColor = System.Drawing.Color.Transparent
        Me.FB16.Location = New System.Drawing.Point(15, 42)
        Me.FB16.Name = "FB16"
        Me.FB16.Size = New System.Drawing.Size(178, 17)
        Me.FB16.TabIndex = 32
        Me.FB16.Text = "The Day After - Der Tag danach"
        Me.FB16.UseVisualStyleBackColor = False
        '
        'FB15
        '
        Me.FB15.AutoSize = True
        Me.FB15.BackColor = System.Drawing.Color.Transparent
        Me.FB15.Checked = True
        Me.FB15.Location = New System.Drawing.Point(15, 19)
        Me.FB15.Name = "FB15"
        Me.FB15.Size = New System.Drawing.Size(152, 17)
        Me.FB15.TabIndex = 31
        Me.FB15.TabStop = True
        Me.FB15.Text = "The Core - Der innere Kern"
        Me.FB15.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.StreamKiste.My.Resources.Resources.button_black_1153971
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Silver
        Me.Button3.Location = New System.Drawing.Point(123, 346)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 27)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Wiedergabe"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.BackgroundImage = Global.StreamKiste.My.Resources.Resources.Silver_Panel
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(236, 387)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Seite 3"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(278, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(446, 259)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(37, 454)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(316, 67)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(198, 510)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(155, 42)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'FB23
        '
        Me.FB23.AutoSize = True
        Me.FB23.BackColor = System.Drawing.Color.Transparent
        Me.FB23.Location = New System.Drawing.Point(15, 203)
        Me.FB23.Name = "FB23"
        Me.FB23.Size = New System.Drawing.Size(143, 17)
        Me.FB23.TabIndex = 39
        Me.FB23.Text = "Pepe der Paukerschreck"
        Me.FB23.UseVisualStyleBackColor = False
        '
        'FB24
        '
        Me.FB24.AutoSize = True
        Me.FB24.BackColor = System.Drawing.Color.Transparent
        Me.FB24.Location = New System.Drawing.Point(15, 225)
        Me.FB24.Name = "FB24"
        Me.FB24.Size = New System.Drawing.Size(147, 17)
        Me.FB24.TabIndex = 40
        Me.FB24.Text = "Zum Teufel mit der Penne"
        Me.FB24.UseVisualStyleBackColor = False
        '
        'FB25
        '
        Me.FB25.AutoSize = True
        Me.FB25.BackColor = System.Drawing.Color.Transparent
        Me.FB25.Location = New System.Drawing.Point(15, 248)
        Me.FB25.Name = "FB25"
        Me.FB25.Size = New System.Drawing.Size(148, 17)
        Me.FB25.TabIndex = 41
        Me.FB25.Text = "Zur Hölle mit den Paukern"
        Me.FB25.UseVisualStyleBackColor = False
        '
        'FB26
        '
        Me.FB26.AutoSize = True
        Me.FB26.BackColor = System.Drawing.Color.Transparent
        Me.FB26.Location = New System.Drawing.Point(15, 271)
        Me.FB26.Name = "FB26"
        Me.FB26.Size = New System.Drawing.Size(109, 17)
        Me.FB26.TabIndex = 42
        Me.FB26.Text = "Zärtliche Chaoten"
        Me.FB26.UseVisualStyleBackColor = False
        '
        'FB27
        '
        Me.FB27.AutoSize = True
        Me.FB27.BackColor = System.Drawing.Color.Transparent
        Me.FB27.Location = New System.Drawing.Point(15, 294)
        Me.FB27.Name = "FB27"
        Me.FB27.Size = New System.Drawing.Size(118, 17)
        Me.FB27.TabIndex = 43
        Me.FB27.Text = "Zärtliche Chaoten II"
        Me.FB27.UseVisualStyleBackColor = False
        '
        'Filme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StreamKiste.My.Resources.Resources.Silver_Panel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(736, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Filme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StreamKisteTV: Filme"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents FB13 As System.Windows.Forms.RadioButton
    Friend WithEvents FB12 As System.Windows.Forms.RadioButton
    Friend WithEvents FB11 As System.Windows.Forms.RadioButton
    Friend WithEvents FB10 As System.Windows.Forms.RadioButton
    Friend WithEvents FB09 As System.Windows.Forms.RadioButton
    Friend WithEvents FB08 As System.Windows.Forms.RadioButton
    Friend WithEvents RB07 As System.Windows.Forms.RadioButton
    Friend WithEvents RB06 As System.Windows.Forms.RadioButton
    Friend WithEvents RB05 As System.Windows.Forms.RadioButton
    Friend WithEvents RB04 As System.Windows.Forms.RadioButton
    Friend WithEvents RB03 As System.Windows.Forms.RadioButton
    Friend WithEvents RB02 As System.Windows.Forms.RadioButton
    Friend WithEvents RB01 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FB14 As System.Windows.Forms.RadioButton
    Friend WithEvents FB15 As System.Windows.Forms.RadioButton
    Friend WithEvents FB16 As System.Windows.Forms.RadioButton
    Friend WithEvents FB18 As System.Windows.Forms.RadioButton
    Friend WithEvents FB17 As System.Windows.Forms.RadioButton
    Friend WithEvents FB20 As System.Windows.Forms.RadioButton
    Friend WithEvents FB19 As System.Windows.Forms.RadioButton
    Friend WithEvents FB22 As System.Windows.Forms.RadioButton
    Friend WithEvents FB21 As System.Windows.Forms.RadioButton
    Friend WithEvents FB24 As System.Windows.Forms.RadioButton
    Friend WithEvents FB23 As System.Windows.Forms.RadioButton
    Friend WithEvents FB27 As System.Windows.Forms.RadioButton
    Friend WithEvents FB26 As System.Windows.Forms.RadioButton
    Friend WithEvents FB25 As System.Windows.Forms.RadioButton
End Class
