<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Garupa = New System.Windows.Forms.TabPage()
        Me.HowTo = New System.Windows.Forms.TabPage()
        Me.Service = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Garupa.SuspendLayout()
        Me.HowTo.SuspendLayout()
        Me.Service.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(752, 683)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Garupa)
        Me.TabControl1.Controls.Add(Me.HowTo)
        Me.TabControl1.Controls.Add(Me.Service)
        Me.TabControl1.Location = New System.Drawing.Point(37, 93)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(916, 573)
        Me.TabControl1.TabIndex = 15
        '
        'Garupa
        '
        Me.Garupa.Controls.Add(Me.Label1)
        Me.Garupa.Controls.Add(Me.PictureBox2)
        Me.Garupa.Location = New System.Drawing.Point(4, 28)
        Me.Garupa.Name = "Garupa"
        Me.Garupa.Padding = New System.Windows.Forms.Padding(3)
        Me.Garupa.Size = New System.Drawing.Size(908, 541)
        Me.Garupa.TabIndex = 0
        Me.Garupa.Text = "ガルパとは"
        Me.Garupa.UseVisualStyleBackColor = True
        '
        'HowTo
        '
        Me.HowTo.Controls.Add(Me.PictureBox3)
        Me.HowTo.Controls.Add(Me.Label2)
        Me.HowTo.Location = New System.Drawing.Point(4, 28)
        Me.HowTo.Name = "HowTo"
        Me.HowTo.Padding = New System.Windows.Forms.Padding(3)
        Me.HowTo.Size = New System.Drawing.Size(908, 541)
        Me.HowTo.TabIndex = 1
        Me.HowTo.Text = "使い方"
        Me.HowTo.UseVisualStyleBackColor = True
        '
        'Service
        '
        Me.Service.Controls.Add(Me.Label3)
        Me.Service.Controls.Add(Me.PictureBox4)
        Me.Service.Location = New System.Drawing.Point(4, 28)
        Me.Service.Name = "Service"
        Me.Service.Size = New System.Drawing.Size(908, 541)
        Me.Service.TabIndex = 2
        Me.Service.Text = "概要"
        Me.Service.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(578, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 126)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "左のように降ってくるノーツを曲に合わせ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "線と重なったときに押すリズムゲームです。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "有名な曲をカバーしているので初心者でも" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "手の付けやすいリズムゲ" &
    "ームです。"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(534, 126)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "当ツールはAP（ALLPerfect）をした譜面をメモっていくツールとなります。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "難易度はExpert、Special以上のみとなっています。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "使い方" &
    "は追加を押し、APした譜面情報を入力、編集、削除するだけです。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "自分の実績をどんどん入力し、活用していただけると嬉しいです。"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GarupaAPTool.My.Resources.Resources.Play
        Me.PictureBox2.Location = New System.Drawing.Point(17, 78)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(542, 369)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources._Exit
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitButton.Location = New System.Drawing.Point(959, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(44, 39)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources.KSM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 69)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Title
        '
        Me.Title.BackgroundImage = Global.GarupaAPTool.My.Resources.Resources.Title
        Me.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Title.Location = New System.Drawing.Point(75, -1)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(505, 88)
        Me.Title.TabIndex = 13
        Me.Title.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GarupaAPTool.My.Resources.Resources.kusoge
        Me.PictureBox3.Location = New System.Drawing.Point(364, 190)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(598, 345)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.GarupaAPTool.My.Resources.Resources.images
        Me.PictureBox4.Location = New System.Drawing.Point(34, 102)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(394, 308)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(499, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 162)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "当ツールはあくまで個人の制作物です。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "使用はご自由にどうぞ。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "拡散や、販売等は禁止とさせていただきます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ソースコードに関してはGithubにあ" &
    "げています。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://github.com/RimlTempest"
        '
        'Help
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1015, 740)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Help"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Help"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Garupa.ResumeLayout(False)
        Me.Garupa.PerformLayout()
        Me.HowTo.ResumeLayout(False)
        Me.HowTo.PerformLayout()
        Me.Service.ResumeLayout(False)
        Me.Service.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ExitButton As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Title As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Garupa As TabPage
    Friend WithEvents HowTo As TabPage
    Friend WithEvents Service As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
