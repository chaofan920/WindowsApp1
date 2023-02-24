<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.run = New System.Windows.Forms.Button()
        Me.Text_Path = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_select = New System.Windows.Forms.Button()
        Me.Button_close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'run
        '
        Me.run.Location = New System.Drawing.Point(227, 117)
        Me.run.Name = "run"
        Me.run.Size = New System.Drawing.Size(75, 23)
        Me.run.TabIndex = 0
        Me.run.Text = "run"
        Me.run.UseVisualStyleBackColor = True
        '
        'Text_Path
        '
        Me.Text_Path.Location = New System.Drawing.Point(89, 60)
        Me.Text_Path.Name = "Text_Path"
        Me.Text_Path.Size = New System.Drawing.Size(199, 19)
        Me.Text_Path.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Path"
        '
        'Button_select
        '
        Me.Button_select.Location = New System.Drawing.Point(314, 58)
        Me.Button_select.Name = "Button_select"
        Me.Button_select.Size = New System.Drawing.Size(75, 23)
        Me.Button_select.TabIndex = 0
        Me.Button_select.Text = "select"
        Me.Button_select.UseVisualStyleBackColor = True
        '
        'Button_close
        '
        Me.Button_close.Location = New System.Drawing.Point(314, 117)
        Me.Button_close.Name = "Button_close"
        Me.Button_close.Size = New System.Drawing.Size(75, 23)
        Me.Button_close.TabIndex = 4
        Me.Button_close.Text = "close"
        Me.Button_close.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 175)
        Me.Controls.Add(Me.Button_close)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text_Path)
        Me.Controls.Add(Me.Button_select)
        Me.Controls.Add(Me.run)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents run As Button
    Friend WithEvents Text_Path As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_select As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Button_close As Button
End Class
