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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Inventory = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Qty = New System.Windows.Forms.TextBox()
        Me.Expdt = New System.Windows.Forms.TextBox()
        Me.imsdata = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.veg_non = New System.Windows.Forms.TextBox()
        Me.Bar_code = New System.Windows.Forms.TextBox()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.Prod_name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.Stock_Table = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.Inventory.SuspendLayout()
        CType(Me.imsdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Inventory)
        Me.GroupBox1.Controls.Add(Me.Back)
        Me.GroupBox1.Controls.Add(Me.Stock_Table)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1106, 719)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Inventory
        '
        Me.Inventory.BackColor = System.Drawing.SystemColors.Control
        Me.Inventory.Controls.Add(Me.Button10)
        Me.Inventory.Controls.Add(Me.Search)
        Me.Inventory.Controls.Add(Me.Button7)
        Me.Inventory.Controls.Add(Me.Button6)
        Me.Inventory.Controls.Add(Me.Button5)
        Me.Inventory.Controls.Add(Me.Label7)
        Me.Inventory.Controls.Add(Me.Qty)
        Me.Inventory.Controls.Add(Me.Expdt)
        Me.Inventory.Controls.Add(Me.imsdata)
        Me.Inventory.Controls.Add(Me.Button4)
        Me.Inventory.Controls.Add(Me.Button3)
        Me.Inventory.Controls.Add(Me.Button2)
        Me.Inventory.Controls.Add(Me.Button1)
        Me.Inventory.Controls.Add(Me.veg_non)
        Me.Inventory.Controls.Add(Me.Bar_code)
        Me.Inventory.Controls.Add(Me.Price)
        Me.Inventory.Controls.Add(Me.Prod_name)
        Me.Inventory.Controls.Add(Me.Label6)
        Me.Inventory.Controls.Add(Me.Label5)
        Me.Inventory.Controls.Add(Me.Label4)
        Me.Inventory.Controls.Add(Me.Label3)
        Me.Inventory.Controls.Add(Me.Label2)
        Me.Inventory.Controls.Add(Me.Label1)
        Me.Inventory.Location = New System.Drawing.Point(-4, -8)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Size = New System.Drawing.Size(1114, 734)
        Me.Inventory.TabIndex = 5
        Me.Inventory.TabStop = False
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(350, 618)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(149, 99)
        Me.Button10.TabIndex = 38
        Me.Button10.Text = "Find Files"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(514, 619)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(139, 97)
        Me.Search.TabIndex = 15
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(883, 280)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(127, 63)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Search Inventory"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(741, 278)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(132, 65)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Update Expiry Date"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(580, 278)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 65)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Update Quantity"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(622, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 29)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Quantity"
        '
        'Qty
        '
        Me.Qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty.Location = New System.Drawing.Point(777, 96)
        Me.Qty.Name = "Qty"
        Me.Qty.Size = New System.Drawing.Size(168, 34)
        Me.Qty.TabIndex = 4
        '
        'Expdt
        '
        Me.Expdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Expdt.Location = New System.Drawing.Point(777, 207)
        Me.Expdt.Name = "Expdt"
        Me.Expdt.Size = New System.Drawing.Size(269, 34)
        Me.Expdt.TabIndex = 6
        '
        'imsdata
        '
        Me.imsdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.imsdata.Location = New System.Drawing.Point(120, 360)
        Me.imsdata.Name = "imsdata"
        Me.imsdata.RowHeadersWidth = 51
        Me.imsdata.RowTemplate.Height = 24
        Me.imsdata.Size = New System.Drawing.Size(890, 244)
        Me.imsdata.TabIndex = 36
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(670, 618)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 97)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Show All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(422, 278)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 66)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Update Price"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(267, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 66)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(120, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 66)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'veg_non
        '
        Me.veg_non.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.veg_non.Location = New System.Drawing.Point(777, 151)
        Me.veg_non.Name = "veg_non"
        Me.veg_non.Size = New System.Drawing.Size(269, 34)
        Me.veg_non.TabIndex = 5
        '
        'Bar_code
        '
        Me.Bar_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar_code.Location = New System.Drawing.Point(187, 207)
        Me.Bar_code.Name = "Bar_code"
        Me.Bar_code.Size = New System.Drawing.Size(359, 34)
        Me.Bar_code.TabIndex = 3
        '
        'Price
        '
        Me.Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.Location = New System.Drawing.Point(187, 149)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(359, 34)
        Me.Price.TabIndex = 2
        '
        'Prod_name
        '
        Me.Prod_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prod_name.Location = New System.Drawing.Point(188, 91)
        Me.Prod_name.Name = "Prod_name"
        Me.Prod_name.Size = New System.Drawing.Size(363, 34)
        Me.Prod_name.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(599, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 29)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Veg/Non Veg"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(599, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 29)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Expiry Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 29)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Bar code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 29)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 29)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(127, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(883, 69)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Inventory Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(435, 637)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(214, 61)
        Me.Back.TabIndex = 1
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Stock_Table
        '
        Me.Stock_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Stock_Table.Location = New System.Drawing.Point(0, 0)
        Me.Stock_Table.Name = "Stock_Table"
        Me.Stock_Table.RowHeadersWidth = 51
        Me.Stock_Table.RowTemplate.Height = 24
        Me.Stock_Table.Size = New System.Drawing.Size(900, 619)
        Me.Stock_Table.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 736)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Inventory Management System"
        Me.GroupBox1.ResumeLayout(False)
        Me.Inventory.ResumeLayout(False)
        Me.Inventory.PerformLayout()
        CType(Me.imsdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Back As Button
    Friend WithEvents Stock_Table As DataGridView
    Friend WithEvents Inventory As GroupBox
    Friend WithEvents Search As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Qty As TextBox
    Friend WithEvents Expdt As TextBox
    Friend WithEvents imsdata As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents veg_non As TextBox
    Friend WithEvents Bar_code As TextBox
    Friend WithEvents Price As TextBox
    Friend WithEvents Prod_name As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button10 As Button
End Class
