<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstScreen))
        Me.RhinoSplash = New System.Windows.Forms.Button()
        Me.RAMSplash = New System.Windows.Forms.Button()
        Me.EtabsSplash = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RhinoSplash
        '
        Me.RhinoSplash.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RhinoSplash.BackgroundImage = CType(resources.GetObject("RhinoSplash.BackgroundImage"), System.Drawing.Image)
        Me.RhinoSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RhinoSplash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RhinoSplash.Location = New System.Drawing.Point(374, 118)
        Me.RhinoSplash.Name = "RhinoSplash"
        Me.RhinoSplash.Size = New System.Drawing.Size(83, 36)
        Me.RhinoSplash.TabIndex = 16
        Me.RhinoSplash.Text = "Rhino"
        Me.RhinoSplash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RhinoSplash.UseVisualStyleBackColor = True
        '
        'RAMSplash
        '
        Me.RAMSplash.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RAMSplash.BackgroundImage = CType(resources.GetObject("RAMSplash.BackgroundImage"), System.Drawing.Image)
        Me.RAMSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RAMSplash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAMSplash.Location = New System.Drawing.Point(225, 118)
        Me.RAMSplash.Name = "RAMSplash"
        Me.RAMSplash.Size = New System.Drawing.Size(83, 36)
        Me.RAMSplash.TabIndex = 15
        Me.RAMSplash.Text = "RAM"
        Me.RAMSplash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RAMSplash.UseVisualStyleBackColor = True
        '
        'EtabsSplash
        '
        Me.EtabsSplash.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.EtabsSplash.BackgroundImage = CType(resources.GetObject("EtabsSplash.BackgroundImage"), System.Drawing.Image)
        Me.EtabsSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EtabsSplash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtabsSplash.Location = New System.Drawing.Point(70, 118)
        Me.EtabsSplash.Name = "EtabsSplash"
        Me.EtabsSplash.Size = New System.Drawing.Size(83, 36)
        Me.EtabsSplash.TabIndex = 15
        Me.EtabsSplash.Text = " Etabs"
        Me.EtabsSplash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EtabsSplash.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Select the source "
        '
        'FirstScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RhinoSplash)
        Me.Controls.Add(Me.EtabsSplash)
        Me.Controls.Add(Me.RAMSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "FirstScreen"
        Me.Text = "Select Software"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RhinoSplash As Button
    Friend WithEvents RAMSplash As Button
    Friend WithEvents EtabsSplash As Button
    Friend WithEvents Label1 As Label
End Class
