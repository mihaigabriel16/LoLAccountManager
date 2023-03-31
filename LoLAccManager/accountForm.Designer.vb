<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountForm
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
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        MaskedTextBox1 = New MaskedTextBox()
        Panel1 = New Panel()
        Label2 = New Label()
        Button3 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 23)
        Label1.TabIndex = 0
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources.eye
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(370, 8)
        Button1.Name = "Button1"
        Button1.Size = New Size(23, 23)
        Button1.TabIndex = 3
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.OliveDrab
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(673, 6)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 4
        Button2.Text = "LAUNCH"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(78, 9)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(150, 23)
        TextBox1.TabIndex = 5
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(234, 8)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.ReadOnly = True
        MaskedTextBox1.Size = New Size(130, 23)
        MaskedTextBox1.TabIndex = 6
        MaskedTextBox1.UseSystemPasswordChar = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(399, 8)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 23)
        Panel1.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.ForeColor = Color.White
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 20)
        Label2.TabIndex = 0
        Label2.Text = "Label2"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.SteelBlue
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Location = New Point(605, 6)
        Button3.Name = "Button3"
        Button3.Size = New Size(62, 23)
        Button3.TabIndex = 8
        Button3.Text = "EDIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' accountForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        ClientSize = New Size(760, 40)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(MaskedTextBox1)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "accountForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "accountForm"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
End Class
