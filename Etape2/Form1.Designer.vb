<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstproducts = New System.Windows.Forms.ListBox()
        Me.lstPrix = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrix = New System.Windows.Forms.Button()
        Me.btnSupProduct = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Produits Sélectionné"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(505, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Articles et cout total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Produits"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Opérations"
        '
        'lstproducts
        '
        Me.lstproducts.FormattingEnabled = True
        Me.lstproducts.HorizontalScrollbar = True
        Me.lstproducts.ItemHeight = 20
        Me.lstproducts.Location = New System.Drawing.Point(97, 136)
        Me.lstproducts.Name = "lstproducts"
        Me.lstproducts.Size = New System.Drawing.Size(181, 264)
        Me.lstproducts.TabIndex = 4
        '
        'lstPrix
        '
        Me.lstPrix.FormattingEnabled = True
        Me.lstPrix.HorizontalScrollbar = True
        Me.lstPrix.ItemHeight = 20
        Me.lstPrix.Location = New System.Drawing.Point(509, 136)
        Me.lstPrix.Name = "lstPrix"
        Me.lstPrix.Size = New System.Drawing.Size(174, 264)
        Me.lstPrix.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(312, 457)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(175, 42)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Effacer"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPrix
        '
        Me.btnPrix.Location = New System.Drawing.Point(341, 360)
        Me.btnPrix.Name = "btnPrix"
        Me.btnPrix.Size = New System.Drawing.Size(101, 70)
        Me.btnPrix.TabIndex = 7
        Me.btnPrix.Text = "Generer le prix"
        Me.btnPrix.UseVisualStyleBackColor = True
        '
        'btnSupProduct
        '
        Me.btnSupProduct.Location = New System.Drawing.Point(341, 317)
        Me.btnSupProduct.Name = "btnSupProduct"
        Me.btnSupProduct.Size = New System.Drawing.Size(101, 37)
        Me.btnSupProduct.TabIndex = 8
        Me.btnSupProduct.Text = "Retirer"
        Me.btnSupProduct.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(341, 230)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 37)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Pomme"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(341, 171)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 41)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Orange"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 552)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnSupProduct)
        Me.Controls.Add(Me.btnPrix)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstPrix)
        Me.Controls.Add(Me.lstproducts)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents lstproducts As ListBox
    Friend WithEvents lstPrix As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrix As Button
    Friend WithEvents btnSupProduct As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
