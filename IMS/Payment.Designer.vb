<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.Home = New System.Windows.Forms.Button()
        Me.hpayment = New System.Windows.Forms.DataGridView()
        Me.Back = New System.Windows.Forms.Button()
        Me.paymentsh = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.offline = New System.Windows.Forms.ComboBox()
        Me.online = New System.Windows.Forms.ComboBox()
        Me.bill_no = New System.Windows.Forms.TextBox()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.payment_date = New System.Windows.Forms.TextBox()
        Me.add_e = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Show_all = New System.Windows.Forms.Button()
        Me.spayment = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pending = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Update_amt = New System.Windows.Forms.Button()
        Me.paymentss = New System.Windows.Forms.GroupBox()
        CType(Me.hpayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paymentsh.SuspendLayout()
        CType(Me.spayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paymentss.SuspendLayout()
        Me.SuspendLayout()
        '
        'Home
        '
        Me.Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.Location = New System.Drawing.Point(828, 310)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(125, 58)
        Me.Home.TabIndex = 9
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'hpayment
        '
        Me.hpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.hpayment.Location = New System.Drawing.Point(24, 21)
        Me.hpayment.Name = "hpayment"
        Me.hpayment.RowHeadersWidth = 51
        Me.hpayment.RowTemplate.Height = 24
        Me.hpayment.Size = New System.Drawing.Size(1041, 538)
        Me.hpayment.TabIndex = 0
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(395, 574)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(335, 80)
        Me.Back.TabIndex = 1
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'paymentsh
        '
        Me.paymentsh.Controls.Add(Me.Back)
        Me.paymentsh.Controls.Add(Me.hpayment)
        Me.paymentsh.Location = New System.Drawing.Point(31, 4)
        Me.paymentsh.Name = "paymentsh"
        Me.paymentsh.Size = New System.Drawing.Size(1071, 663)
        Me.paymentsh.TabIndex = 0
        Me.paymentsh.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 69)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Payments"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 58)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Bill " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 29)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 87)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Payment " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(mm-dd-yyyy)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(524, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 29)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Mode"
        '
        'cb1
        '
        Me.cb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"Online", "Offline"})
        Me.cb1.Location = New System.Drawing.Point(548, 130)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(121, 37)
        Me.cb1.TabIndex = 4
        '
        'offline
        '
        Me.offline.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.offline.FormattingEnabled = True
        Me.offline.Items.AddRange(New Object() {"Cash", "Card", "Cheque"})
        Me.offline.Location = New System.Drawing.Point(612, 216)
        Me.offline.Name = "offline"
        Me.offline.Size = New System.Drawing.Size(121, 37)
        Me.offline.TabIndex = 63
        '
        'online
        '
        Me.online.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.online.FormattingEnabled = True
        Me.online.Items.AddRange(New Object() {"Neft", "UPI", "E-Wallets"})
        Me.online.Location = New System.Drawing.Point(612, 183)
        Me.online.Name = "online"
        Me.online.Size = New System.Drawing.Size(121, 37)
        Me.online.TabIndex = 64
        '
        'bill_no
        '
        Me.bill_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bill_no.Location = New System.Drawing.Point(206, 98)
        Me.bill_no.Name = "bill_no"
        Me.bill_no.Size = New System.Drawing.Size(262, 34)
        Me.bill_no.TabIndex = 1
        '
        'amount
        '
        Me.amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.Location = New System.Drawing.Point(206, 159)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(262, 34)
        Me.amount.TabIndex = 2
        '
        'payment_date
        '
        Me.payment_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payment_date.Location = New System.Drawing.Point(206, 237)
        Me.payment_date.Name = "payment_date"
        Me.payment_date.Size = New System.Drawing.Size(262, 34)
        Me.payment_date.TabIndex = 3
        '
        'add_e
        '
        Me.add_e.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_e.Location = New System.Drawing.Point(47, 313)
        Me.add_e.Name = "add_e"
        Me.add_e.Size = New System.Drawing.Size(136, 58)
        Me.add_e.TabIndex = 5
        Me.add_e.Text = "Add"
        Me.add_e.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.Location = New System.Drawing.Point(206, 312)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(136, 60)
        Me.Update.TabIndex = 6
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(369, 312)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(130, 59)
        Me.Delete.TabIndex = 7
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Show_all
        '
        Me.Show_all.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_all.Location = New System.Drawing.Point(812, 215)
        Me.Show_all.Name = "Show_all"
        Me.Show_all.Size = New System.Drawing.Size(158, 75)
        Me.Show_all.TabIndex = 11
        Me.Show_all.Text = "Show All"
        Me.Show_all.UseVisualStyleBackColor = True
        '
        'spayment
        '
        Me.spayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.spayment.Location = New System.Drawing.Point(47, 388)
        Me.spayment.Name = "spayment"
        Me.spayment.RowHeadersWidth = 51
        Me.spayment.RowTemplate.Height = 24
        Me.spayment.Size = New System.Drawing.Size(1008, 265)
        Me.spayment.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(745, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 58)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Pending " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "balance"
        '
        'pending
        '
        Me.pending.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pending.Location = New System.Drawing.Point(845, 119)
        Me.pending.Name = "pending"
        Me.pending.Size = New System.Drawing.Size(210, 34)
        Me.pending.TabIndex = 50
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(674, 312)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(130, 58)
        Me.Search.TabIndex = 10
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Update_amt
        '
        Me.Update_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_amt.Location = New System.Drawing.Point(518, 312)
        Me.Update_amt.Name = "Update_amt"
        Me.Update_amt.Size = New System.Drawing.Size(130, 58)
        Me.Update_amt.TabIndex = 8
        Me.Update_amt.Text = "Update Amount"
        Me.Update_amt.UseVisualStyleBackColor = True
        '
        'paymentss
        '
        Me.paymentss.Controls.Add(Me.Update_amt)
        Me.paymentss.Controls.Add(Me.Search)
        Me.paymentss.Controls.Add(Me.Home)
        Me.paymentss.Controls.Add(Me.pending)
        Me.paymentss.Controls.Add(Me.Label6)
        Me.paymentss.Controls.Add(Me.spayment)
        Me.paymentss.Controls.Add(Me.Show_all)
        Me.paymentss.Controls.Add(Me.Delete)
        Me.paymentss.Controls.Add(Me.Update)
        Me.paymentss.Controls.Add(Me.add_e)
        Me.paymentss.Controls.Add(Me.payment_date)
        Me.paymentss.Controls.Add(Me.amount)
        Me.paymentss.Controls.Add(Me.bill_no)
        Me.paymentss.Controls.Add(Me.online)
        Me.paymentss.Controls.Add(Me.offline)
        Me.paymentss.Controls.Add(Me.cb1)
        Me.paymentss.Controls.Add(Me.Label5)
        Me.paymentss.Controls.Add(Me.Label4)
        Me.paymentss.Controls.Add(Me.Label3)
        Me.paymentss.Controls.Add(Me.Label2)
        Me.paymentss.Controls.Add(Me.Label1)
        Me.paymentss.Location = New System.Drawing.Point(1, 5)
        Me.paymentss.Name = "paymentss"
        Me.paymentss.Size = New System.Drawing.Size(1101, 662)
        Me.paymentss.TabIndex = 2
        Me.paymentss.TabStop = False
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 668)
        Me.Controls.Add(Me.paymentss)
        Me.Controls.Add(Me.paymentsh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Payment"
        Me.Text = "Payment"
        CType(Me.hpayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paymentsh.ResumeLayout(False)
        CType(Me.spayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paymentss.ResumeLayout(False)
        Me.paymentss.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Home As Button
    Friend WithEvents hpayment As DataGridView
    Friend WithEvents Back As Button
    Friend WithEvents paymentsh As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents offline As ComboBox
    Friend WithEvents online As ComboBox
    Friend WithEvents bill_no As TextBox
    Friend WithEvents amount As TextBox
    Friend WithEvents payment_date As TextBox
    Friend WithEvents add_e As Button
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Show_all As Button
    Friend WithEvents spayment As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents pending As TextBox
    Friend WithEvents Search As Button
    Friend WithEvents Update_amt As Button
    Friend WithEvents paymentss As GroupBox
End Class
