<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GarupaDB = New GarupaAPTool.GarupaDB()
        Me.Q_ScoreTableAdapter = New GarupaAPTool.GarupaDBTableAdapters.Q_ScoreTableAdapter()
        Me.Q_ScoreDataGridView = New System.Windows.Forms.DataGridView()
        Me.BandName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusicName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Difficulty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.APCountflg = New System.Windows.Forms.RadioButton()
        Me.Levelflg = New System.Windows.Forms.RadioButton()
        Me.Diffflg = New System.Windows.Forms.RadioButton()
        Me.Musicflg = New System.Windows.Forms.RadioButton()
        Me.Bandflg = New System.Windows.Forms.RadioButton()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.PictureBox()
        Me.HelpButton = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ScoreTableAdapter = New GarupaAPTool.GarupaDBTableAdapters.ScoreTableAdapter()
        CType(Me.GarupaDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Q_ScoreDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SearchButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DeleteButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HelpButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GarupaDB
        '
        Me.GarupaDB.DataSetName = "GarupaDB"
        Me.GarupaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Q_ScoreTableAdapter
        '
        Me.Q_ScoreTableAdapter.ClearBeforeFill = True
        '
        'Q_ScoreDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.Q_ScoreDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Q_ScoreDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Q_ScoreDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Q_ScoreDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Q_ScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Q_ScoreDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BandName, Me.MusicName, Me.Difficulty, Me.Level, Me.Count})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Q_ScoreDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.Q_ScoreDataGridView.EnableHeadersVisualStyles = False
        Me.Q_ScoreDataGridView.GridColor = System.Drawing.Color.SpringGreen
        Me.Q_ScoreDataGridView.Location = New System.Drawing.Point(12, 74)
        Me.Q_ScoreDataGridView.Name = "Q_ScoreDataGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Q_ScoreDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.Q_ScoreDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Q_ScoreDataGridView.RowTemplate.Height = 27
        Me.Q_ScoreDataGridView.Size = New System.Drawing.Size(1375, 533)
        Me.Q_ScoreDataGridView.TabIndex = 1
        '
        'BandName
        '
        Me.BandName.HeaderText = "バンド名"
        Me.BandName.Name = "BandName"
        Me.BandName.Width = 200
        '
        'MusicName
        '
        Me.MusicName.HeaderText = "曲名"
        Me.MusicName.Name = "MusicName"
        Me.MusicName.Width = 250
        '
        'Difficulty
        '
        Me.Difficulty.HeaderText = "難易度"
        Me.Difficulty.Name = "Difficulty"
        '
        'Level
        '
        Me.Level.HeaderText = "レベル"
        Me.Level.Name = "Level"
        '
        'Count
        '
        Me.Count.HeaderText = "AP回数"
        Me.Count.Name = "Count"
        Me.Count.Width = 130
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.APCountflg)
        Me.GroupBox1.Controls.Add(Me.Levelflg)
        Me.GroupBox1.Controls.Add(Me.Diffflg)
        Me.GroupBox1.Controls.Add(Me.Musicflg)
        Me.GroupBox1.Controls.Add(Me.Bandflg)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(12, 633)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 204)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "検索オプション"
        '
        'APCountflg
        '
        Me.APCountflg.AutoSize = True
        Me.APCountflg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.APCountflg.Location = New System.Drawing.Point(22, 147)
        Me.APCountflg.Name = "APCountflg"
        Me.APCountflg.Size = New System.Drawing.Size(89, 22)
        Me.APCountflg.TabIndex = 4
        Me.APCountflg.Text = "AP回数"
        Me.APCountflg.UseVisualStyleBackColor = True
        '
        'Levelflg
        '
        Me.Levelflg.AutoSize = True
        Me.Levelflg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Levelflg.Location = New System.Drawing.Point(22, 119)
        Me.Levelflg.Name = "Levelflg"
        Me.Levelflg.Size = New System.Drawing.Size(75, 22)
        Me.Levelflg.TabIndex = 3
        Me.Levelflg.Text = "レベル"
        Me.Levelflg.UseVisualStyleBackColor = True
        '
        'Diffflg
        '
        Me.Diffflg.AutoSize = True
        Me.Diffflg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Diffflg.Location = New System.Drawing.Point(22, 91)
        Me.Diffflg.Name = "Diffflg"
        Me.Diffflg.Size = New System.Drawing.Size(85, 22)
        Me.Diffflg.TabIndex = 2
        Me.Diffflg.Text = "難易度"
        Me.Diffflg.UseVisualStyleBackColor = True
        '
        'Musicflg
        '
        Me.Musicflg.AutoSize = True
        Me.Musicflg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Musicflg.Location = New System.Drawing.Point(22, 63)
        Me.Musicflg.Name = "Musicflg"
        Me.Musicflg.Size = New System.Drawing.Size(67, 22)
        Me.Musicflg.TabIndex = 1
        Me.Musicflg.Text = "曲名"
        Me.Musicflg.UseVisualStyleBackColor = True
        '
        'Bandflg
        '
        Me.Bandflg.AutoSize = True
        Me.Bandflg.Checked = True
        Me.Bandflg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bandflg.Location = New System.Drawing.Point(22, 35)
        Me.Bandflg.Name = "Bandflg"
        Me.Bandflg.Size = New System.Drawing.Size(90, 22)
        Me.Bandflg.TabIndex = 0
        Me.Bandflg.TabStop = True
        Me.Bandflg.Text = "バンド名"
        Me.Bandflg.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(6, 47)
        Me.SearchBox.Multiline = True
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(316, 115)
        Me.SearchBox.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.SearchButton)
        Me.GroupBox2.Controls.Add(Me.SearchBox)
        Me.GroupBox2.Location = New System.Drawing.Point(210, 633)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 253)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "検索"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "検索"
        '
        'SearchButton
        '
        Me.SearchButton.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources.KKR
        Me.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SearchButton.Location = New System.Drawing.Point(347, 47)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(130, 115)
        Me.SearchButton.TabIndex = 6
        Me.SearchButton.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.DeleteButton)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.UpdateButton)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.AddButton)
        Me.GroupBox3.Location = New System.Drawing.Point(728, 633)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(659, 204)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "編集"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(552, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "削除"
        '
        'DeleteButton
        '
        Me.DeleteButton.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources.YKN
        Me.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DeleteButton.Location = New System.Drawing.Point(514, 47)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(120, 115)
        Me.DeleteButton.TabIndex = 11
        Me.DeleteButton.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "更新"
        '
        'UpdateButton
        '
        Me.UpdateButton.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources.AY
        Me.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UpdateButton.Location = New System.Drawing.Point(281, 47)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(120, 115)
        Me.UpdateButton.TabIndex = 9
        Me.UpdateButton.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "追加"
        '
        'AddButton
        '
        Me.AddButton.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources.RN
        Me.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddButton.Location = New System.Drawing.Point(49, 47)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(120, 115)
        Me.AddButton.TabIndex = 0
        Me.AddButton.TabStop = False
        '
        'HelpButton
        '
        Me.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HelpButton.Image = Global.GarupaAPTool.My.Resources.Resources.help
        Me.HelpButton.Location = New System.Drawing.Point(967, -1)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(136, 78)
        Me.HelpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HelpButton.TabIndex = 9
        Me.HelpButton.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources._Exit
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitButton.Location = New System.Drawing.Point(1343, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(44, 39)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources.KSM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 69)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Title
        '
        Me.Title.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources.Title
        Me.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Title.Location = New System.Drawing.Point(77, -1)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(505, 88)
        Me.Title.TabIndex = 3
        Me.Title.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(891, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ヘルプ→"
        '
        'ScoreTableAdapter
        '
        Me.ScoreTableAdapter.ClearBeforeFill = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1399, 886)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Q_ScoreDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.HelpButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Form1"
        CType(Me.GarupaDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Q_ScoreDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SearchButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DeleteButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HelpButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GarupaDB As GarupaDB
    Friend WithEvents Q_ScoreTableAdapter As GarupaDBTableAdapters.Q_ScoreTableAdapter
    Friend WithEvents Q_ScoreDataGridView As DataGridView
    Friend WithEvents BandName As DataGridViewTextBoxColumn
    Friend WithEvents MusicName As DataGridViewTextBoxColumn
    Friend WithEvents Difficulty As DataGridViewTextBoxColumn
    Friend WithEvents Level As DataGridViewTextBoxColumn
    Friend WithEvents Count As DataGridViewTextBoxColumn
    Friend WithEvents ExitButton As PictureBox
    Friend WithEvents Title As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents APCountflg As RadioButton
    Friend WithEvents Levelflg As RadioButton
    Friend WithEvents Diffflg As RadioButton
    Friend WithEvents Musicflg As RadioButton
    Friend WithEvents Bandflg As RadioButton
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchButton As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AddButton As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DeleteButton As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UpdateButton As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HelpButton As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ScoreTableAdapter As GarupaDBTableAdapters.ScoreTableAdapter
End Class
