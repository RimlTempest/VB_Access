<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BandBox = New System.Windows.Forms.ComboBox()
        Me.GarupaDB = New GarupaAPTool.GarupaDB()
        Me.ScoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScoreTableAdapter = New GarupaAPTool.GarupaDBTableAdapters.ScoreTableAdapter()
        Me.BandsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BandsTableAdapter = New GarupaAPTool.GarupaDBTableAdapters.BandsTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MusicName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DiffBox = New System.Windows.Forms.ComboBox()
        Me.LevelBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CountLabel = New System.Windows.Forms.Label()
        Me.CountPlus = New System.Windows.Forms.Button()
        Me.CountMinus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BandsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BandsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BandsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarupaDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(764, 535)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(243, 40)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(5, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(111, 32)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(126, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(112, 32)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "キャンセル"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "バンド名："
        '
        'ExitButton
        '
        Me.ExitButton.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources._Exit
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitButton.Location = New System.Drawing.Point(971, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(44, 39)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources.KSM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 69)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Title
        '
        Me.Title.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources.Title
        Me.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Title.Location = New System.Drawing.Point(79, -1)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(505, 88)
        Me.Title.TabIndex = 10
        Me.Title.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GarupaAPTool.My.Resources.Resources.EditAnime
        Me.PictureBox2.Location = New System.Drawing.Point(587, 157)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(415, 299)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'BandBox
        '
        Me.BandBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BandsBindingSource1, "BandD", True))
        Me.BandBox.DataSource = Me.BandsBindingSource3
        Me.BandBox.DisplayMember = "BandName"
        Me.BandBox.FormattingEnabled = True
        Me.BandBox.Location = New System.Drawing.Point(133, 154)
        Me.BandBox.Name = "BandBox"
        Me.BandBox.Size = New System.Drawing.Size(361, 26)
        Me.BandBox.TabIndex = 14
        Me.BandBox.ValueMember = "BandD"
        '
        'GarupaDB
        '
        Me.GarupaDB.DataSetName = "GarupaDB"
        Me.GarupaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScoreBindingSource
        '
        Me.ScoreBindingSource.DataMember = "Score"
        Me.ScoreBindingSource.DataSource = Me.GarupaDB
        '
        'ScoreTableAdapter
        '
        Me.ScoreTableAdapter.ClearBeforeFill = True
        '
        'BandsBindingSource
        '
        Me.BandsBindingSource.DataMember = "Bands"
        Me.BandsBindingSource.DataSource = Me.GarupaDB
        '
        'BandsTableAdapter
        '
        Me.BandsTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "曲名："
        '
        'MusicName
        '
        Me.MusicName.Location = New System.Drawing.Point(133, 249)
        Me.MusicName.Multiline = True
        Me.MusicName.Name = "MusicName"
        Me.MusicName.Size = New System.Drawing.Size(361, 25)
        Me.MusicName.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "難易度："
        '
        'DiffBox
        '
        Me.DiffBox.FormattingEnabled = True
        Me.DiffBox.Location = New System.Drawing.Point(133, 345)
        Me.DiffBox.Name = "DiffBox"
        Me.DiffBox.Size = New System.Drawing.Size(361, 26)
        Me.DiffBox.TabIndex = 18
        '
        'LevelBox
        '
        Me.LevelBox.FormattingEnabled = True
        Me.LevelBox.Location = New System.Drawing.Point(133, 430)
        Me.LevelBox.Name = "LevelBox"
        Me.LevelBox.Size = New System.Drawing.Size(361, 26)
        Me.LevelBox.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "レベル："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 519)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "AP回数："
        '
        'CountLabel
        '
        Me.CountLabel.AutoSize = True
        Me.CountLabel.Location = New System.Drawing.Point(237, 519)
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(17, 18)
        Me.CountLabel.TabIndex = 22
        Me.CountLabel.Text = "1"
        '
        'CountPlus
        '
        Me.CountPlus.Location = New System.Drawing.Point(386, 510)
        Me.CountPlus.Name = "CountPlus"
        Me.CountPlus.Size = New System.Drawing.Size(51, 37)
        Me.CountPlus.TabIndex = 23
        Me.CountPlus.Text = "＋１"
        Me.CountPlus.UseVisualStyleBackColor = True
        '
        'CountMinus
        '
        Me.CountMinus.Location = New System.Drawing.Point(443, 510)
        Me.CountMinus.Name = "CountMinus"
        Me.CountMinus.Size = New System.Drawing.Size(51, 37)
        Me.CountMinus.TabIndex = 24
        Me.CountMinus.Text = "ー１"
        Me.CountMinus.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 519)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "回"
        '
        'BandsBindingSource1
        '
        Me.BandsBindingSource1.DataMember = "Bands"
        Me.BandsBindingSource1.DataSource = Me.GarupaDB
        '
        'BandsBindingSource2
        '
        Me.BandsBindingSource2.DataMember = "Bands"
        Me.BandsBindingSource2.DataSource = Me.GarupaDB
        '
        'BandsBindingSource3
        '
        Me.BandsBindingSource3.DataMember = "Bands"
        Me.BandsBindingSource3.DataSource = Me.GarupaDB
        '
        'Edit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1027, 592)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CountMinus)
        Me.Controls.Add(Me.CountPlus)
        Me.Controls.Add(Me.CountLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LevelBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DiffBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MusicName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BandBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarupaDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ExitButton As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Title As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BandBox As ComboBox
    Friend WithEvents GarupaDB As GarupaDB
    Friend WithEvents ScoreBindingSource As BindingSource
    Friend WithEvents ScoreTableAdapter As GarupaDBTableAdapters.ScoreTableAdapter
    Friend WithEvents BandsBindingSource As BindingSource
    Friend WithEvents BandsTableAdapter As GarupaDBTableAdapters.BandsTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents MusicName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DiffBox As ComboBox
    Friend WithEvents LevelBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CountLabel As Label
    Friend WithEvents CountPlus As Button
    Friend WithEvents CountMinus As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents BandsBindingSource1 As BindingSource
    Friend WithEvents BandsBindingSource2 As BindingSource
    Friend WithEvents BandsBindingSource3 As BindingSource
End Class
