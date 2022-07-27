<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_helloworld
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Click = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Click
        '
        Me.btn_Click.Location = New System.Drawing.Point(12, 12)
        Me.btn_Click.Name = "btn_Click"
        Me.btn_Click.Size = New System.Drawing.Size(75, 23)
        Me.btn_Click.TabIndex = 0
        Me.btn_Click.Text = "Click"
        Me.btn_Click.UseVisualStyleBackColor = True
        '
        'frm_helloworld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(106, 51)
        Me.Controls.Add(Me.btn_Click)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_helloworld"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hello World"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Click As Button
End Class
