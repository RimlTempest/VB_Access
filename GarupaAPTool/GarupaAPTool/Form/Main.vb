Imports System.Security.Permissions

Public Class Main

    'Form Move
    <SecurityPermission(SecurityAction.Demand,
    Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_NCLBUTTONDBLCLK As Integer = &HA3

        If m.Msg = WM_NCLBUTTONDBLCLK Then
            '非クライアント領域がダブルクリックされた時
            m.Result = IntPtr.Zero
            Return
        End If

        MyBase.WndProc(m)

        Const WM_NCHITTEST As Integer = &H84
        Const HTCLIENT As Integer = 1
        Const HTCAPTION As Integer = 2

        If (m.Msg = WM_NCHITTEST) AndAlso (m.Result.ToInt32() = HTCLIENT) Then
            m.Result = New IntPtr(HTCAPTION)
        End If
    End Sub

    Private Sub ExitProc(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'GarupaDB.Score' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.ScoreTableAdapter.Fill(Me.GarupaDB.Score)
        'TODO: このコード行はデータを 'GarupaDB.Q_Score' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Q_ScoreTableAdapter.Fill(Me.GarupaDB.Q_Score)
        Me.MaximizeBox = False
        '初期表示
        DataSet()
    End Sub

    Private Sub SearchData(sender As Object, e As EventArgs) Handles SearchButton.Click
        DataSet()
    End Sub

    '検索処理
    Private Sub DataSet()
        Me.Q_ScoreTableAdapter.Fill(Me.GarupaDB.Q_Score)
        Dim SelRows As DataRow()

        If SearchBox.Text = "" Then
            SelRows = GarupaDB.Q_Score.Select()
        Else
            'Option
            If (Bandflg.Checked) Then
                SelRows = GarupaDB.Q_Score.Select("BandName Like '*" & SearchBox.Text & "*'")
            ElseIf (Musicflg.Checked) Then
                SelRows = GarupaDB.Q_Score.Select("MusicName Like '*" & SearchBox.Text & "*'")
            ElseIf (Diffflg.Checked) Then
                SelRows = GarupaDB.Q_Score.Select("Level Like '*" & SearchBox.Text & "*'")
            ElseIf (Levelflg.Checked) Then
                SelRows = GarupaDB.Q_Score.Select("LevelNum Like '*" & SearchBox.Text & "*'")
            ElseIf (APCountflg.Checked) Then
                SelRows = GarupaDB.Q_Score.Select("Count Like '*" & SearchBox.Text & "*'")
            End If

        End If
        Q_ScoreDataGridView.Rows.Clear()
        For Each aRow As DataRow In SelRows
            Q_ScoreDataGridView.Rows.Add(
                CType(aRow, GarupaDB.Q_ScoreRow).BandName,
                CType(aRow, GarupaDB.Q_ScoreRow).MusicName,
                CType(aRow, GarupaDB.Q_ScoreRow).Level,
                CType(aRow, GarupaDB.Q_ScoreRow).LevelNum,
                CType(aRow, GarupaDB.Q_ScoreRow).Count)
        Next
    End Sub

    '追加処理
    Private Sub AddData(sender As Object, e As EventArgs) Handles AddButton.Click
        Me.ScoreTableAdapter.Fill(Me.GarupaDB.Score)
        Edit.MusicName.Text = ""
        Edit.DiffBox.Items.Add("Expert")
        Edit.DiffBox.Items.Add("Special")
        Edit.DiffBox.Text = Edit.DiffBox.Items(0)

        For i As Integer = 20 To 30
            Edit.LevelBox.Items.Add(i)
        Next

        If Edit.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If

        Dim aRow As DataRow
        aRow = GarupaDB.Score.NewRow()
        aRow.Item("BandID") = Edit.BandBox.SelectedValue
        aRow.Item("MusicName") = Edit.MusicName.Text
        aRow.Item("Level") = Edit.DiffBox.Text
        aRow.Item("LevelNum") = Edit.LevelBox.Text
        aRow.Item("Count") = Edit.CountLabel.Text

        GarupaDB.Score.Rows.Add(aRow)

        ScoreTableAdapter.Update(GarupaDB.Score)

        DataSet()

    End Sub


End Class
