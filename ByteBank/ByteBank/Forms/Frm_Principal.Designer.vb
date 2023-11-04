<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_Principal = New System.Windows.Forms.Label()
        Me.btm_Click = New System.Windows.Forms.Button()
        Me.btm_TesteHeranca = New System.Windows.Forms.Button()
        Me.btm_classebase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Principal
        '
        Me.lbl_Principal.AutoSize = True
        Me.lbl_Principal.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Principal.Name = "lbl_Principal"
        Me.lbl_Principal.Size = New System.Drawing.Size(51, 17)
        Me.lbl_Principal.TabIndex = 0
        Me.lbl_Principal.Text = "Label1"
        '
        'btm_Click
        '
        Me.btm_Click.Location = New System.Drawing.Point(12, 29)
        Me.btm_Click.Name = "btm_Click"
        Me.btm_Click.Size = New System.Drawing.Size(148, 59)
        Me.btm_Click.TabIndex = 1
        Me.btm_Click.Text = "Button1"
        Me.btm_Click.UseVisualStyleBackColor = True
        '
        'btm_TesteHeranca
        '
        Me.btm_TesteHeranca.Location = New System.Drawing.Point(166, 29)
        Me.btm_TesteHeranca.Name = "btm_TesteHeranca"
        Me.btm_TesteHeranca.Size = New System.Drawing.Size(148, 59)
        Me.btm_TesteHeranca.TabIndex = 2
        Me.btm_TesteHeranca.Text = "Button1"
        Me.btm_TesteHeranca.UseVisualStyleBackColor = True
        '
        'btm_classebase
        '
        Me.btm_classebase.Location = New System.Drawing.Point(15, 94)
        Me.btm_classebase.Name = "btm_classebase"
        Me.btm_classebase.Size = New System.Drawing.Size(145, 59)
        Me.btm_classebase.TabIndex = 3
        Me.btm_classebase.Text = "Button1"
        Me.btm_classebase.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btm_classebase)
        Me.Controls.Add(Me.btm_TesteHeranca)
        Me.Controls.Add(Me.btm_Click)
        Me.Controls.Add(Me.lbl_Principal)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Principal As Label
    Friend WithEvents btm_Click As Button
    Friend WithEvents btm_TesteHeranca As Button
    Friend WithEvents btm_classebase As Button
End Class
