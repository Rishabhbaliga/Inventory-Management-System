<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventorysearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventorysearch))
        Me.inventorys = New System.Windows.Forms.GroupBox()
        Me.back = New System.Windows.Forms.Button()
        Me.invtry = New System.Windows.Forms.DataGridView()
        Me.inventoryh = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.sinvtry = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.shelf_no = New System.Windows.Forms.TextBox()
        Me.rack_no = New System.Windows.Forms.TextBox()
        Me.bar_code = New System.Windows.Forms.TextBox()
        Me.prod_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.inventorys.SuspendLayout()
        CType(Me.invtry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inventoryh.SuspendLayout()
        CType(Me.sinvtry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inventorys
        '
        Me.inventorys.Controls.Add(Me.back)
        Me.inventorys.Controls.Add(Me.invtry)
        Me.inventorys.Location = New System.Drawing.Point(8, 2)
        Me.inventorys.Name = "inventorys"
        Me.inventorys.Size = New System.Drawing.Size(1036, 560)
        Me.inventorys.TabIndex = 0
        Me.inventorys.TabStop = False
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(412, 477)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(239, 72)
        Me.back.TabIndex = 1
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'invtry
        '
        Me.invtry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.invtry.Location = New System.Drawing.Point(235, 10)
        Me.invtry.Name = "invtry"
        Me.invtry.RowHeadersWidth = 51
        Me.invtry.RowTemplate.Height = 24
        Me.invtry.Size = New System.Drawing.Size(627, 453)
        Me.invtry.TabIndex = 0
        '
        'inventoryh
        '
        Me.inventoryh.Controls.Add(Me.Button7)
        Me.inventoryh.Controls.Add(Me.Button6)
        Me.inventoryh.Controls.Add(Me.Button5)
        Me.inventoryh.Controls.Add(Me.Button4)
        Me.inventoryh.Controls.Add(Me.sinvtry)
        Me.inventoryh.Controls.Add(Me.Button3)
        Me.inventoryh.Controls.Add(Me.Button2)
        Me.inventoryh.Controls.Add(Me.Button1)
        Me.inventoryh.Controls.Add(Me.Label5)
        Me.inventoryh.Controls.Add(Me.shelf_no)
        Me.inventoryh.Controls.Add(Me.rack_no)
        Me.inventoryh.Controls.Add(Me.bar_code)
        Me.inventoryh.Controls.Add(Me.prod_name)
        Me.inventoryh.Controls.Add(Me.Label4)
        Me.inventoryh.Controls.Add(Me.Label3)
        Me.inventoryh.Controls.Add(Me.Label2)
        Me.inventoryh.Controls.Add(Me.Label1)
        Me.inventoryh.Location = New System.Drawing.Point(3, 1)
        Me.inventoryh.Name = "inventoryh"
        Me.inventoryh.Size = New System.Drawing.Size(1039, 560)
        Me.inventoryh.TabIndex = 4
        Me.inventoryh.TabStop = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(843, 322)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(150, 81)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(15, 215)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 81)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(843, 215)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 81)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Show All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'sinvtry
        '
        Me.sinvtry.ColumnHeadersHeight = 29
        Me.sinvtry.Location = New System.Drawing.Point(195, 299)
        Me.sinvtry.Name = "sinvtry"
        Me.sinvtry.RowHeadersWidth = 51
        Me.sinvtry.Size = New System.Drawing.Size(606, 233)
        Me.sinvtry.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(671, 224)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 58)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(445, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 57)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(218, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 58)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(382, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(285, 69)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Inventory"
        '
        'shelf_no
        '
        Me.shelf_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shelf_no.Location = New System.Drawing.Point(711, 161)
        Me.shelf_no.Name = "shelf_no"
        Me.shelf_no.Size = New System.Drawing.Size(323, 34)
        Me.shelf_no.TabIndex = 4
        '
        'rack_no
        '
        Me.rack_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rack_no.Location = New System.Drawing.Point(711, 97)
        Me.rack_no.Name = "rack_no"
        Me.rack_no.Size = New System.Drawing.Size(323, 34)
        Me.rack_no.TabIndex = 3
        '
        'bar_code
        '
        Me.bar_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar_code.Location = New System.Drawing.Point(195, 157)
        Me.bar_code.Name = "bar_code"
        Me.bar_code.Size = New System.Drawing.Size(323, 34)
        Me.bar_code.TabIndex = 2
        '
        'prod_name
        '
        Me.prod_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prod_name.Location = New System.Drawing.Point(195, 97)
        Me.prod_name.Name = "prod_name"
        Me.prod_name.Size = New System.Drawing.Size(323, 34)
        Me.prod_name.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(545, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 29)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Shelf Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(545, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Rack Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Bar Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Product Name"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(15, 322)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(137, 67)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "Reset"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Inventorysearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 563)
        Me.Controls.Add(Me.inventoryh)
        Me.Controls.Add(Me.inventorys)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inventorysearch"
        Me.Text = "Inventory"
        Me.inventorys.ResumeLayout(False)
        CType(Me.invtry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inventoryh.ResumeLayout(False)
        Me.inventoryh.PerformLayout()
        CType(Me.sinvtry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents inventorys As GroupBox
    Friend WithEvents back As Button
    Friend WithEvents invtry As DataGridView
    Friend WithEvents inventoryh As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents sinvtry As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents shelf_no As TextBox
    Friend WithEvents rack_no As TextBox
    Friend WithEvents bar_code As TextBox
    Friend WithEvents prod_name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
End Class
