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
        'TODO: このコード行はデータを 'GarupaDB.Q_Score' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Q_ScoreTableAdapter.Fill(Me.GarupaDB.Q_Score)
        Me.MaximizeBox = False

    End Sub


End Class
