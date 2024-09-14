Public Class Form1
    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' 取消所有关闭操作
        e.Cancel = True
    End Sub
    ' 提供一个方法来关闭窗体
    Public Sub CloseForm()
        ' 关闭窗体的代码
        Me.Dispose()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 设置窗口为最顶层
        Me.TopMost = True ' 窗体置顶
        ' 获取当前日期
        Dim currentDate As Date = Today

        Me.Size = New Size(143, 61)

        ' 设置目标日期为2025年6月26日
        Dim zhongkaoDate As Date = #6/26/2025#
        ' 计算两个日期之间的差异
        Dim daysUntilTarget_zhongkao As Integer = CInt(DateDiff("d", currentDate, zhongkaoDate))
        ' 调用ToString方法
        Label_countdown.Text = daysUntilTarget_zhongkao.ToString()
    End Sub
End Class
