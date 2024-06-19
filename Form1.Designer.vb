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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPrenume = New System.Windows.Forms.TextBox()
        Me.txtNume = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnSalveaza = New System.Windows.Forms.Button()
        Me.BtnIncarca = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 27)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Adauga"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Prenume"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nume"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Id"
        '
        'TxtPrenume
        '
        Me.TxtPrenume.Location = New System.Drawing.Point(104, 111)
        Me.TxtPrenume.Name = "TxtPrenume"
        Me.TxtPrenume.Size = New System.Drawing.Size(129, 20)
        Me.TxtPrenume.TabIndex = 11
        '
        'txtNume
        '
        Me.txtNume.Location = New System.Drawing.Point(104, 71)
        Me.txtNume.Name = "txtNume"
        Me.txtNume.Size = New System.Drawing.Size(129, 20)
        Me.txtNume.TabIndex = 10
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(104, 33)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(129, 20)
        Me.txtId.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(341, 242)
        Me.DataGridView1.TabIndex = 8
        '
        'BtnSalveaza
        '
        Me.BtnSalveaza.Location = New System.Drawing.Point(404, 312)
        Me.BtnSalveaza.Name = "BtnSalveaza"
        Me.BtnSalveaza.Size = New System.Drawing.Size(142, 27)
        Me.BtnSalveaza.TabIndex = 16
        Me.BtnSalveaza.Text = "Salveaza"
        Me.BtnSalveaza.UseVisualStyleBackColor = True
        '
        'BtnIncarca
        '
        Me.BtnIncarca.Location = New System.Drawing.Point(404, 263)
        Me.BtnIncarca.Name = "BtnIncarca"
        Me.BtnIncarca.Size = New System.Drawing.Size(142, 27)
        Me.BtnIncarca.TabIndex = 17
        Me.BtnIncarca.Text = "Incarca date"
        Me.BtnIncarca.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnIncarca)
        Me.Controls.Add(Me.BtnSalveaza)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPrenume)
        Me.Controls.Add(Me.txtNume)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPrenume As TextBox
    Friend WithEvents txtNume As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnSalveaza As Button
    Friend WithEvents BtnIncarca As Button
End Class
