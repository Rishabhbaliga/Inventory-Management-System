<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.customers = New System.Windows.Forms.GroupBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.customer_g = New System.Windows.Forms.DataGridView()
        Me.customerh = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Paid = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.customer_data = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GSTIN = New System.Windows.Forms.TextBox()
        Me.bar_code = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Prod_name = New System.Windows.Forms.TextBox()
        Me.bill_no = New System.Windows.Forms.TextBox()
        Me.Cname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.customers.SuspendLayout()
        CType(Me.customer_g, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.customerh.SuspendLayout()
        CType(Me.customer_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customers
        '
        Me.customers.Controls.Add(Me.Back)
        Me.customers.Controls.Add(Me.customer_g)
        Me.customers.Location = New System.Drawing.Point(2, 1)
        Me.customers.Name = "customers"
        Me.customers.Size = New System.Drawing.Size(1091, 665)
        Me.customers.TabIndex = 0
        Me.customers.TabStop = False
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(330, 551)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(422, 87)
        Me.Back.TabIndex = 1
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'customer_g
        '
        Me.customer_g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customer_g.Location = New System.Drawing.Point(35, 11)
        Me.customer_g.Name = "customer_g"
        Me.customer_g.RowHeadersWidth = 51
        Me.customer_g.RowTemplate.Height = 24
        Me.customer_g.Size = New System.Drawing.Size(1026, 517)
        Me.customer_g.TabIndex = 0
        '
        'customerh
        '
        Me.customerh.Controls.Add(Me.Button2)
        Me.customerh.Controls.Add(Me.Search)
        Me.customerh.Controls.Add(Me.Button1)
        Me.customerh.Controls.Add(Me.Paid)
        Me.customerh.Controls.Add(Me.Label8)
        Me.customerh.Controls.Add(Me.customer_data)
        Me.customerh.Controls.Add(Me.Button4)
        Me.customerh.Controls.Add(Me.Button5)
        Me.customerh.Controls.Add(Me.Button6)
        Me.customerh.Controls.Add(Me.Button7)
        Me.customerh.Controls.Add(Me.GSTIN)
        Me.customerh.Controls.Add(Me.bar_code)
        Me.customerh.Controls.Add(Me.phone)
        Me.customerh.Controls.Add(Me.Prod_name)
        Me.customerh.Controls.Add(Me.bill_no)
        Me.customerh.Controls.Add(Me.Cname)
        Me.customerh.Controls.Add(Me.Label7)
        Me.customerh.Controls.Add(Me.Label6)
        Me.customerh.Controls.Add(Me.Label5)
        Me.customerh.Controls.Add(Me.Label4)
        Me.customerh.Controls.Add(Me.Label3)
        Me.customerh.Controls.Add(Me.Label2)
        Me.customerh.Controls.Add(Me.Label1)
        Me.customerh.Location = New System.Drawing.Point(3, 5)
        Me.customerh.Name = "customerh"
        Me.customerh.Size = New System.Drawing.Size(1091, 659)
        Me.customerh.TabIndex = 3
        Me.customerh.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(739, 303)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 56)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Pending payments"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(739, 370)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(141, 56)
        Me.Search.TabIndex = 12
        Me.Search.Text = "Search Customer"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(592, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 56)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Paid
        '
        Me.Paid.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paid.FormattingEnabled = True
        Me.Paid.Items.AddRange(New Object() {"Select", "Yes", "No"})
        Me.Paid.Location = New System.Drawing.Point(504, 313)
        Me.Paid.Name = "Paid"
        Me.Paid.Size = New System.Drawing.Size(121, 37)
        Me.Paid.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(309, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 29)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Bill Amount Paid"
        '
        'customer_data
        '
        Me.customer_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customer_data.Location = New System.Drawing.Point(35, 433)
        Me.customer_data.Name = "customer_data"
        Me.customer_data.RowHeadersWidth = 51
        Me.customer_data.RowTemplate.Height = 24
        Me.customer_data.Size = New System.Drawing.Size(1019, 216)
        Me.customer_data.TabIndex = 47
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(887, 351)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(158, 75)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Show All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(444, 369)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 56)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(276, 369)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(152, 57)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Update"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(128, 369)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(136, 57)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Add"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GSTIN
        '
        Me.GSTIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GSTIN.Location = New System.Drawing.Point(683, 248)
        Me.GSTIN.Name = "GSTIN"
        Me.GSTIN.Size = New System.Drawing.Size(362, 34)
        Me.GSTIN.TabIndex = 6
        '
        'bar_code
        '
        Me.bar_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar_code.Location = New System.Drawing.Point(682, 171)
        Me.bar_code.Name = "bar_code"
        Me.bar_code.Size = New System.Drawing.Size(363, 34)
        Me.bar_code.TabIndex = 5
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone.Location = New System.Drawing.Point(683, 104)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(362, 34)
        Me.phone.TabIndex = 4
        '
        'Prod_name
        '
        Me.Prod_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prod_name.Location = New System.Drawing.Point(128, 249)
        Me.Prod_name.Name = "Prod_name"
        Me.Prod_name.Size = New System.Drawing.Size(371, 34)
        Me.Prod_name.TabIndex = 3
        '
        'bill_no
        '
        Me.bill_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bill_no.Location = New System.Drawing.Point(128, 177)
        Me.bill_no.Name = "bill_no"
        Me.bill_no.Size = New System.Drawing.Size(371, 34)
        Me.bill_no.TabIndex = 2
        '
        'Cname
        '
        Me.Cname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cname.Location = New System.Drawing.Point(128, 105)
        Me.Cname.Name = "Cname"
        Me.Cname.Size = New System.Drawing.Size(371, 34)
        Me.Cname.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(572, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 29)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "GSTIN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(572, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 58)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Product " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Barcode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(572, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 29)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 58)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 58)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Bill " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 69)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Customer"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 668)
        Me.Controls.Add(Me.customerh)
        Me.Controls.Add(Me.customers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Customer"
        Me.Text = "Customer"
        Me.customers.ResumeLayout(False)
        CType(Me.customer_g, System.ComponentModel.ISupportInitialize).EndInit()
        Me.customerh.ResumeLayout(False)
        Me.customerh.PerformLayout()
        CType(Me.customer_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents customers As GroupBox
    Friend WithEvents Back As Button
    Friend WithEvents customer_g As DataGridView
    Friend WithEvents customerh As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Search As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Paid As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents customer_data As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents GSTIN As TextBox
    Friend WithEvents bar_code As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents Prod_name As TextBox
    Friend WithEvents bill_no As TextBox
    Friend WithEvents Cname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
