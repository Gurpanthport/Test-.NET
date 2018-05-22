<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Label1 As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addName = New System.Windows.Forms.TextBox()
        Me.addQty = New System.Windows.Forms.TextBox()
        Me.addInventory = New System.Windows.Forms.Button()
        Me.conn = New System.Windows.Forms.Button()
        Me.itemDrop = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.givenQty = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(207, 33)
        Label1.TabIndex = 0
        Label1.Text = "Inventory App"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(408, 283)
        Me.DataGridView1.TabIndex = 1
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(251, 9)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(35, 13)
        Me.Name.TabIndex = 2
        Me.Name.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quantity"
        '
        'addName
        '
        Me.addName.Location = New System.Drawing.Point(310, 9)
        Me.addName.Name = "addName"
        Me.addName.Size = New System.Drawing.Size(100, 20)
        Me.addName.TabIndex = 5
        '
        'addQty
        '
        Me.addQty.Location = New System.Drawing.Point(310, 49)
        Me.addQty.Name = "addQty"
        Me.addQty.Size = New System.Drawing.Size(100, 20)
        Me.addQty.TabIndex = 6
        '
        'addInventory
        '
        Me.addInventory.Location = New System.Drawing.Point(334, 78)
        Me.addInventory.Name = "addInventory"
        Me.addInventory.Size = New System.Drawing.Size(76, 20)
        Me.addInventory.TabIndex = 7
        Me.addInventory.Text = "Add"
        Me.addInventory.UseVisualStyleBackColor = True
        '
        'conn
        '
        Me.conn.Location = New System.Drawing.Point(303, 166)
        Me.conn.Name = "conn"
        Me.conn.Size = New System.Drawing.Size(107, 23)
        Me.conn.TabIndex = 8
        Me.conn.Text = "Connection Check"
        Me.conn.UseVisualStyleBackColor = True
        '
        'itemDrop
        '
        Me.itemDrop.FormattingEnabled = True
        Me.itemDrop.Location = New System.Drawing.Point(233, 124)
        Me.itemDrop.Name = "itemDrop"
        Me.itemDrop.Size = New System.Drawing.Size(177, 21)
        Me.itemDrop.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Select Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Quantity"
        '
        'givenQty
        '
        Me.givenQty.Location = New System.Drawing.Point(23, 100)
        Me.givenQty.Name = "givenQty"
        Me.givenQty.Size = New System.Drawing.Size(100, 20)
        Me.givenQty.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 490)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.givenQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.itemDrop)
        Me.Controls.Add(Me.conn)
        Me.Controls.Add(Me.addInventory)
        Me.Controls.Add(Me.addQty)
        Me.Controls.Add(Me.addName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Label1)
        Me.Name = "Form1"
        Me.Text = "Testing App"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Name As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents addName As TextBox
    Friend WithEvents addQty As TextBox
    Friend WithEvents addInventory As Button
    Friend WithEvents conn As Button
    Friend WithEvents itemDrop As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents givenQty As TextBox
    Friend WithEvents Button1 As Button
End Class
