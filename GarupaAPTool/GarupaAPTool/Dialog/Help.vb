Imports System.Security.Permissions
Imports System.Windows.Forms

Public Class Help
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

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ExitProc(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
