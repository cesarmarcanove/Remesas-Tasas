<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextCAN = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextSELL = New System.Windows.Forms.TextBox
        Me.TextCOST = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextRem2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextRem1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextDIF = New System.Windows.Forms.TextBox
        Me.TextPOR = New System.Windows.Forms.TextBox
        Me.TextMAR = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(468, 121)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 48)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Acerca de..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(468, 213)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 49)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Salir del App"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(468, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 49)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(468, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 49)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Calcular"
        Me.Button1.UseMnemonic = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextCAN)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextSELL)
        Me.GroupBox1.Controls.Add(Me.TextCOST)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 119)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar datos"
        '
        'TextCAN
        '
        Me.TextCAN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextCAN.Location = New System.Drawing.Point(241, 87)
        Me.TextCAN.Name = "TextCAN"
        Me.TextCAN.Size = New System.Drawing.Size(174, 20)
        Me.TextCAN.TabIndex = 20
        Me.TextCAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(68, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Importe Unitaria por persona en $:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(223, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "================================="
        '
        'TextSELL
        '
        Me.TextSELL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSELL.Location = New System.Drawing.Point(241, 48)
        Me.TextSELL.Name = "TextSELL"
        Me.TextSELL.Size = New System.Drawing.Size(174, 20)
        Me.TextSELL.TabIndex = 3
        Me.TextSELL.Text = "8"
        Me.TextSELL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCOST
        '
        Me.TextCOST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCOST.Location = New System.Drawing.Point(241, 22)
        Me.TextCOST.Name = "TextCOST"
        Me.TextCOST.Size = New System.Drawing.Size(174, 20)
        Me.TextCOST.TabIndex = 2
        Me.TextCOST.Text = "600"
        Me.TextCOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero de Personas a Enviar:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la Cantidad a Enviar $:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextRem2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextRem1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextDIF)
        Me.GroupBox2.Controls.Add(Me.TextPOR)
        Me.GroupBox2.Controls.Add(Me.TextMAR)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 178)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(212, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "================================="
        '
        'TextRem2
        '
        Me.TextRem2.Location = New System.Drawing.Point(256, 109)
        Me.TextRem2.Name = "TextRem2"
        Me.TextRem2.Size = New System.Drawing.Size(158, 20)
        Me.TextRem2.TabIndex = 17
        Me.TextRem2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Importe Resta tras Pais Recibidor en $:"
        '
        'TextRem1
        '
        Me.TextRem1.Location = New System.Drawing.Point(256, 83)
        Me.TextRem1.Name = "TextRem1"
        Me.TextRem1.Size = New System.Drawing.Size(158, 20)
        Me.TextRem1.TabIndex = 15
        Me.TextRem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Importe Resta tras Pais Emisor en $:"
        '
        'TextDIF
        '
        Me.TextDIF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextDIF.Location = New System.Drawing.Point(256, 151)
        Me.TextDIF.Name = "TextDIF"
        Me.TextDIF.Size = New System.Drawing.Size(158, 20)
        Me.TextDIF.TabIndex = 13
        Me.TextDIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextPOR
        '
        Me.TextPOR.Location = New System.Drawing.Point(256, 57)
        Me.TextPOR.Name = "TextPOR"
        Me.TextPOR.Size = New System.Drawing.Size(158, 20)
        Me.TextPOR.TabIndex = 12
        Me.TextPOR.Text = "10"
        Me.TextPOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextMAR
        '
        Me.TextMAR.Location = New System.Drawing.Point(256, 31)
        Me.TextMAR.Name = "TextMAR"
        Me.TextMAR.Size = New System.Drawing.Size(158, 20)
        Me.TextMAR.TabIndex = 11
        Me.TextMAR.Text = "20"
        Me.TextMAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Importe Total a pagar en $:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(32, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tasa del Pais Recibidor (Venezuela): "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(55, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tasa del Pais Emisor (ejm Suiza):"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 332)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Remesas (Version Tasas)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextSELL As System.Windows.Forms.TextBox
    Friend WithEvents TextCOST As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextDIF As System.Windows.Forms.TextBox
    Friend WithEvents TextPOR As System.Windows.Forms.TextBox
    Friend WithEvents TextMAR As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextRem2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextRem1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextCAN As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
