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
        Panel1 = New Panel()
        Panel4 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel3 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(150), CByte(0), CByte(0), CByte(0))
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1024, 600)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(FlowLayoutPanel1)
        Panel4.Location = New Point(218, 31)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(794, 557)
        Panel4.TabIndex = 2
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Location = New Point(3, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(788, 551)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(12, 31)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 557)
        Panel3.TabIndex = 1
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.SteelBlue
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(3, 517)
        Button5.Name = "Button5"
        Button5.Size = New Size(194, 37)
        Button5.TabIndex = 3
        Button5.Text = "Settings"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(20, 127)
        Button4.Name = "Button4"
        Button4.Size = New Size(160, 23)
        Button4.TabIndex = 2
        Button4.Text = "Add Account"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.Location = New Point(3, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 23)
        Label3.TabIndex = 1
        Label3.Text = "Total Accounts:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(75, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 50)
        Label2.TabIndex = 0
        Label2.Text = "0"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(150), CByte(0), CByte(0), CByte(0))
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1024, 25)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.ForeColor = Color.White
        Label1.Location = New Point(10, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 15)
        Label1.TabIndex = 2
        Label1.Text = "LoLAccountManager" ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(974, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(25, 25)
        Button2.TabIndex = 1
        Button2.Text = "_"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(999, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(25, 25)
        Button1.TabIndex = 0
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.gangplank_lol_dreadnova_splash_art_uhdpaper_com_4K_194_wp_thumbnail
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1024, 600)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
End Class
