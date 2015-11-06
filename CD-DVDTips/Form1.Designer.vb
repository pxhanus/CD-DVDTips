<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTip = New System.Windows.Forms.Label()
        Me.btnTip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTip
        '
        Me.lblTip.Location = New System.Drawing.Point(12, 9)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(268, 44)
        Me.lblTip.TabIndex = 0
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTip
        '
        Me.btnTip.Location = New System.Drawing.Point(107, 56)
        Me.btnTip.Name = "btnTip"
        Me.btnTip.Size = New System.Drawing.Size(78, 30)
        Me.btnTip.TabIndex = 1
        Me.btnTip.Text = "Tip"
        Me.btnTip.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 98)
        Me.Controls.Add(Me.btnTip)
        Me.Controls.Add(Me.lblTip)
        Me.Name = "Form1"
        Me.Text = "CD/DVD Tips"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents btnTip As System.Windows.Forms.Button

End Class
