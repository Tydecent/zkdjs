<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Timer1 = New Timer(components)
        Label5 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("幼圆", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(-1, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 30)
        Label1.TabIndex = 0
        Label1.Text = "距语文开考" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label2.Location = New Point(-1, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "剩余"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("DS-Digital", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(51, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(268, 59)
        Label3.TabIndex = 2
        Label3.Text = "HHH:MM:SS"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("华文楷体", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(249, 2)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 31)
        Label5.TabIndex = 4
        Label5.Text = "D"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("华文楷体", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(275, 2)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 31)
        Label4.TabIndex = 5
        Label4.Text = "天"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("隶书", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label6.Location = New Point(17, 75)
        Label6.Name = "Label6"
        Label6.Size = New Size(269, 20)
        Label6.TabIndex = 6
        Label6.Text = "生命可以重来，中考只有一次"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(315, 99)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        Text = "zkdjs"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label

End Class
