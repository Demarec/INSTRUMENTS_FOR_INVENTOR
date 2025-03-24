<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInstrumentRotate
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
        Me.btnTurnPos = New System.Windows.Forms.Button()
        Me.btnTurnNeg = New System.Windows.Forms.Button()
        Me.btnAcceptInstrumentAngle = New System.Windows.Forms.Button()
        Me.cbxInstrumentTurnByAngle = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTurnPos
        '
        Me.btnTurnPos.Location = New System.Drawing.Point(16, 41)
        Me.btnTurnPos.Name = "btnTurnPos"
        Me.btnTurnPos.Size = New System.Drawing.Size(69, 55)
        Me.btnTurnPos.TabIndex = 0
        Me.btnTurnPos.Text = "Turn+"
        Me.btnTurnPos.UseVisualStyleBackColor = True
        '
        'btnTurnNeg
        '
        Me.btnTurnNeg.Location = New System.Drawing.Point(91, 41)
        Me.btnTurnNeg.Name = "btnTurnNeg"
        Me.btnTurnNeg.Size = New System.Drawing.Size(70, 55)
        Me.btnTurnNeg.TabIndex = 1
        Me.btnTurnNeg.Text = "Turn-"
        Me.btnTurnNeg.UseVisualStyleBackColor = True
        '
        'btnAcceptInstrumentAngle
        '
        Me.btnAcceptInstrumentAngle.Location = New System.Drawing.Point(167, 41)
        Me.btnAcceptInstrumentAngle.Name = "btnAcceptInstrumentAngle"
        Me.btnAcceptInstrumentAngle.Size = New System.Drawing.Size(73, 55)
        Me.btnAcceptInstrumentAngle.TabIndex = 2
        Me.btnAcceptInstrumentAngle.Text = "accept"
        Me.btnAcceptInstrumentAngle.UseVisualStyleBackColor = True
        '
        'cbxInstrumentTurnByAngle
        '
        Me.cbxInstrumentTurnByAngle.FormattingEnabled = True
        Me.cbxInstrumentTurnByAngle.Location = New System.Drawing.Point(91, 6)
        Me.cbxInstrumentTurnByAngle.Name = "cbxInstrumentTurnByAngle"
        Me.cbxInstrumentTurnByAngle.Size = New System.Drawing.Size(149, 28)
        Me.cbxInstrumentTurnByAngle.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Angle"
        '
        'frmInstrumentRotate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 114)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxInstrumentTurnByAngle)
        Me.Controls.Add(Me.btnAcceptInstrumentAngle)
        Me.Controls.Add(Me.btnTurnNeg)
        Me.Controls.Add(Me.btnTurnPos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInstrumentRotate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rotate"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTurnPos As Button
    Friend WithEvents btnTurnNeg As Button
    Friend WithEvents btnAcceptInstrumentAngle As Button
    Friend WithEvents cbxInstrumentTurnByAngle As ComboBox
    Friend WithEvents Label1 As Label
End Class
