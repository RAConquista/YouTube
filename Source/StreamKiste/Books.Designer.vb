<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Books))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HB5 = New System.Windows.Forms.RadioButton()
        Me.HB4 = New System.Windows.Forms.RadioButton()
        Me.HB3 = New System.Windows.Forms.RadioButton()
        Me.HB2 = New System.Windows.Forms.RadioButton()
        Me.HB1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.StreamKiste.My.Resources.Resources.button_black_1153971
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(580, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 33)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "Hauptmenü"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.HB5)
        Me.GroupBox1.Controls.Add(Me.HB4)
        Me.GroupBox1.Controls.Add(Me.HB3)
        Me.GroupBox1.Controls.Add(Me.HB2)
        Me.GroupBox1.Controls.Add(Me.HB1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 354)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        '
        'HB5
        '
        Me.HB5.AutoSize = True
        Me.HB5.Location = New System.Drawing.Point(22, 122)
        Me.HB5.Name = "HB5"
        Me.HB5.Size = New System.Drawing.Size(131, 17)
        Me.HB5.TabIndex = 108
        Me.HB5.Text = "Herr der Ringe Band 3"
        Me.HB5.UseVisualStyleBackColor = True
        '
        'HB4
        '
        Me.HB4.AutoSize = True
        Me.HB4.Location = New System.Drawing.Point(22, 99)
        Me.HB4.Name = "HB4"
        Me.HB4.Size = New System.Drawing.Size(131, 17)
        Me.HB4.TabIndex = 107
        Me.HB4.Text = "Herr der Ringe Band 2"
        Me.HB4.UseVisualStyleBackColor = True
        '
        'HB3
        '
        Me.HB3.AutoSize = True
        Me.HB3.Location = New System.Drawing.Point(22, 76)
        Me.HB3.Name = "HB3"
        Me.HB3.Size = New System.Drawing.Size(131, 17)
        Me.HB3.TabIndex = 106
        Me.HB3.Text = "Herr der Ringe Band 1"
        Me.HB3.UseVisualStyleBackColor = True
        '
        'HB2
        '
        Me.HB2.AutoSize = True
        Me.HB2.Location = New System.Drawing.Point(22, 53)
        Me.HB2.Name = "HB2"
        Me.HB2.Size = New System.Drawing.Size(171, 17)
        Me.HB2.TabIndex = 105
        Me.HB2.Text = "Alien Band 2 - Fluss des Todes"
        Me.HB2.UseVisualStyleBackColor = True
        '
        'HB1
        '
        Me.HB1.AutoSize = True
        Me.HB1.Checked = True
        Me.HB1.Location = New System.Drawing.Point(22, 30)
        Me.HB1.Name = "HB1"
        Me.HB1.Size = New System.Drawing.Size(170, 17)
        Me.HB1.TabIndex = 104
        Me.HB1.TabStop = True
        Me.HB1.Text = "Alien Band 1 - In den Schatten"
        Me.HB1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.StreamKiste.My.Resources.Resources.button_black_1153971
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Silver
        Me.Button2.Location = New System.Drawing.Point(119, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 27)
        Me.Button2.TabIndex = 103
        Me.Button2.Text = "Wiedergabe"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.StreamKiste.My.Resources.Resources.banner_oben
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(293, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 236)
        Me.PictureBox1.TabIndex = 104
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(434, 254)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 62)
        Me.PictureBox2.TabIndex = 105
        Me.PictureBox2.TabStop = False
        '
        'Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StreamKiste.My.Resources.Resources.Silver_Panel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(696, 475)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Books"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StreamKisteTV: Hörbucher"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HB2 As System.Windows.Forms.RadioButton
    Friend WithEvents HB1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents HB5 As System.Windows.Forms.RadioButton
    Friend WithEvents HB4 As System.Windows.Forms.RadioButton
    Friend WithEvents HB3 As System.Windows.Forms.RadioButton
End Class
