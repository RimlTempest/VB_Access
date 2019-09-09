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
        Me.GarupaDB = New GarupaAPTool.GarupaDB()
        Me.Q_ScoreTableAdapter = New GarupaAPTool.GarupaDBTableAdapters.Q_ScoreTableAdapter()
        Me.Q_ScoreDataGridView = New System.Windows.Forms.DataGridView()
        Me.BandName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusicName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Difficulty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExitButton = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.PictureBox()
        CType(Me.GarupaDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Q_ScoreDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Q_ScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Q_ScoreDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BandName, Me.MusicName, Me.Difficulty, Me.Level, Me.Count})
        Me.Q_ScoreDataGridView.Location = New System.Drawing.Point(12, 100)
        Me.Q_ScoreDataGridView.Name = "Q_ScoreDataGridView"
        Me.Q_ScoreDataGridView.RowTemplate.Height = 27
        Me.Q_ScoreDataGridView.Size = New System.Drawing.Size(823, 533)
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
        'ExitButton
        '
        Me.ExitButton.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources._Exit
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitButton.Location = New System.Drawing.Point(1192, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(44, 39)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.TabStop = False
        '
        'Title
        '
        Me.Title.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources.Title
        Me.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Title.Location = New System.Drawing.Point(0, -1)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(505, 82)
        Me.Title.TabIndex = 3
        Me.Title.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 815)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Q_ScoreDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Form1"
        CType(Me.GarupaDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Q_ScoreDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
End Class
