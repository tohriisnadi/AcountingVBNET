<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtKodeOP = New DevExpress.XtraEditors.TextEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPasword1 = New DevExpress.XtraEditors.TextEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.txtKodeOP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPasword1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(13, 69)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 162
        Me.LabelControl2.Text = "Kode Operator"
        '
        'txtKodeOP
        '
        Me.txtKodeOP.Location = New System.Drawing.Point(13, 88)
        Me.txtKodeOP.Name = "txtKodeOP"
        Me.txtKodeOP.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtKodeOP.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeOP.Properties.Appearance.Options.UseBackColor = True
        Me.txtKodeOP.Properties.Appearance.Options.UseFont = True
        Me.txtKodeOP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtKodeOP.Size = New System.Drawing.Size(399, 22)
        Me.txtKodeOP.TabIndex = 161
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(319, 182)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 35)
        Me.btnAdd.TabIndex = 160
        Me.btnAdd.Text = "Login"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(13, 125)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 159
        Me.LabelControl1.Text = "Password"
        '
        'txtPasword1
        '
        Me.txtPasword1.Location = New System.Drawing.Point(13, 144)
        Me.txtPasword1.Name = "txtPasword1"
        Me.txtPasword1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtPasword1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasword1.Properties.Appearance.Options.UseBackColor = True
        Me.txtPasword1.Properties.Appearance.Options.UseFont = True
        Me.txtPasword1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPasword1.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasword1.Size = New System.Drawing.Size(399, 22)
        Me.txtPasword1.TabIndex = 158
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(430, 53)
        Me.PictureEdit1.TabIndex = 157
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 229)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtKodeOP)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPasword1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Login"
        CType(Me.txtKodeOP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPasword1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKodeOP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPasword1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
