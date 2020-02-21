<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sklCombo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtLvl = New System.Windows.Forms.TextBox()
        Me.dateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.idCombo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(34, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "School"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(34, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "School Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(34, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data and Time"
        '
        'sklCombo
        '
        Me.sklCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.sklCombo.FormattingEnabled = True
        Me.sklCombo.Location = New System.Drawing.Point(285, 123)
        Me.sklCombo.Name = "sklCombo"
        Me.sklCombo.Size = New System.Drawing.Size(454, 39)
        Me.sklCombo.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(327, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 44)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtLvl
        '
        Me.txtLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtLvl.Location = New System.Drawing.Point(285, 192)
        Me.txtLvl.Name = "txtLvl"
        Me.txtLvl.Size = New System.Drawing.Size(454, 38)
        Me.txtLvl.TabIndex = 7
        '
        'dateTime
        '
        Me.dateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.dateTime.Location = New System.Drawing.Point(285, 272)
        Me.dateTime.Name = "dateTime"
        Me.dateTime.Size = New System.Drawing.Size(454, 38)
        Me.dateTime.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(34, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ID"
        '
        'idCombo
        '
        Me.idCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.idCombo.FormattingEnabled = True
        Me.idCombo.Location = New System.Drawing.Point(285, 47)
        Me.idCombo.Name = "idCombo"
        Me.idCombo.Size = New System.Drawing.Size(454, 39)
        Me.idCombo.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 519)
        Me.Controls.Add(Me.idCombo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dateTime)
        Me.Controls.Add(Me.txtLvl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sklCombo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sklCombo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtLvl As TextBox
    Friend WithEvents dateTime As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents idCombo As ComboBox
End Class
