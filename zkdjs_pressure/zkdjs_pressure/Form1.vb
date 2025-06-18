Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Timer1.Interval = 1 ' 每秒更新一次
        Timer1.Start()
        UpdateCountdown() ' 初始立即更新
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateCountdown()
    End Sub

    Private Sub UpdateCountdown()
        Dim targetDate As New DateTime(2025, 6, 26, 9, 0, 0)
        Dim remaining As TimeSpan = targetDate - DateTime.Now

        ' 处理过期情况
        If remaining.TotalMilliseconds <= 0 Then
            Label3.Text = "000:00:00"
            Return
        End If

        ' 计算总小时数（包含天数转换）
        Dim totalHours As Integer = CInt(Math.Floor(remaining.TotalHours))
        Dim hours As String = totalHours.ToString("D3") ' 3位小时数补零

        ' 获取剩余分钟/秒（扣除已计算的小时部分）
        Dim minutes As String = (remaining.Minutes).ToString("D2")
        Dim seconds As String = (remaining.Seconds).ToString("D2")

        Label3.Text = $"{hours}:{minutes}:{seconds}"

        ' 更新Label5（天数倒计时）
        Dim targetDay As New DateTime(2025, 6, 26)
        Dim currentDate As DateTime = DateTime.Today
        Dim daysRemaining As Integer = CInt((targetDay - currentDate).TotalDays)

        ' 处理过期情况
        If daysRemaining < 0 Then
            daysRemaining = 0
        End If

        Label5.Text = daysRemaining.ToString()
    End Sub
End Class