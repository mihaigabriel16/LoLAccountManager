<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAccount
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
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Panel2 = New Panel()
        Button2 = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 260)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 15)
        Label5.TabIndex = 9
        Label5.Text = "In-Game Name"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 8
        Label4.Text = "Password"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 7
        Label3.Text = "Username"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(55, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 6
        Label2.Text = "Region"' 
        ' Button1
        ' 
        Button1.Location = New Point(84, 224)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 23)
        Button1.TabIndex = 5
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"EUNE", "EUW", "NA"})
        ComboBox1.Location = New Point(105, 60)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(180, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(105, 147)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(180, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(105, 118)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(180, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(105, 89)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(180, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(300, 25)
        Panel2.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Firebrick
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(275, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(25, 25)
        Button2.TabIndex = 1
        Button2.Text = "X"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 25)
        Label1.TabIndex = 0
        Label1.Text = "Manage Account"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' addAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(300, 260)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "addAccount"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addAccount"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
End Class
