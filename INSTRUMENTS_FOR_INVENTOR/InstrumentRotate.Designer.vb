﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInstrumentRotate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnTurnPos = New System.Windows.Forms.Button()
        Me.btnTurnNeg = New System.Windows.Forms.Button()
        Me.btnAcceptInstrumentAngle = New System.Windows.Forms.Button()
        Me.cbxInstrumentTurnByAngle = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTurnPos
        '
        Me.btnTurnPos.Location = New System.Drawing.Point(4, 44)
        Me.btnTurnPos.Name = "btnTurnPos"
        Me.btnTurnPos.Size = New System.Drawing.Size(70, 50)
        Me.btnTurnPos.TabIndex = 0
        Me.btnTurnPos.Text = "Turn +"
        Me.btnTurnPos.UseVisualStyleBackColor = True
        '
        'btnTurnNeg
        '
        Me.btnTurnNeg.Location = New System.Drawing.Point(80, 44)
        Me.btnTurnNeg.Name = "btnTurnNeg"
        Me.btnTurnNeg.Size = New System.Drawing.Size(73, 50)
        Me.btnTurnNeg.TabIndex = 1
        Me.btnTurnNeg.Text = "Turn -"
        Me.btnTurnNeg.UseVisualStyleBackColor = True
        '
        'btnAcceptValveAngle
        '
        Me.btnAcceptInstrumentAngle.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAcceptInstrumentAngle.Location = New System.Drawing.Point(159, 44)
        Me.btnAcceptInstrumentAngle.Name = "btnAcceptInstrumentAngle"
        Me.btnAcceptInstrumentAngle.Size = New System.Drawing.Size(86, 50)
        Me.btnAcceptInstrumentAngle.TabIndex = 2
        Me.btnAcceptInstrumentAngle.Text = "Accept"
        Me.btnAcceptInstrumentAngle.UseVisualStyleBackColor = False
        '
        'cbxValveTurnByAngle
        '
        Me.cbxInstrumentTurnByAngle.FormattingEnabled = True
        Me.cbxInstrumentTurnByAngle.Items.AddRange(New Object() {"1", "2", "5", "10", "15", "45", "90"})
        Me.cbxInstrumentTurnByAngle.Location = New System.Drawing.Point(96, 6)
        Me.cbxInstrumentTurnByAngle.Name = "cbxInstrumentTurnByAngle"
        Me.cbxInstrumentTurnByAngle.Size = New System.Drawing.Size(120, 28)
        Me.cbxInstrumentTurnByAngle.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "°"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Rotate by"
        '
        'frmValveRotate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 109)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxInstrumentTurnByAngle)
        Me.Controls.Add(Me.btnAcceptInstrumentAngle)
        Me.Controls.Add(Me.btnTurnNeg)
        Me.Controls.Add(Me.btnTurnPos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(280, 165)
        Me.MinimumSize = New System.Drawing.Size(280, 165)
        Me.Name = "frmInstrumentRotate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instrument Rotation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnTurnPos As Button
    Friend WithEvents btnTurnNeg As Button
    Friend WithEvents btnAcceptInstrumentAngle As Button
    Friend WithEvents cbxInstrumentTurnByAngle As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
