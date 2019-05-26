<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Volunteer_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Volunteer_Form))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LB_Header = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Edit = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.search_text = New System.Windows.Forms.TextBox()
        Me.search_image = New System.Windows.Forms.Label()
        Me.Main_Panel = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel_Header.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Main_Panel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel_Header)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Main_Panel)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(808, 417)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel_Header.Controls.Add(Me.Button1)
        Me.Panel_Header.Controls.Add(Me.LB_Header)
        Me.Panel_Header.Location = New System.Drawing.Point(2, 2)
        Me.Panel_Header.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(806, 56)
        Me.Panel_Header.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 31)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LB_Header
        '
        Me.LB_Header.AutoEllipsis = True
        Me.LB_Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LB_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Header.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LB_Header.Location = New System.Drawing.Point(0, 0)
        Me.LB_Header.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_Header.Name = "LB_Header"
        Me.LB_Header.Size = New System.Drawing.Size(806, 56)
        Me.LB_Header.TabIndex = 0
        Me.LB_Header.Text = "Dashboard"
        Me.LB_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Edit)
        Me.Panel1.Controls.Add(Me.addButton)
        Me.Panel1.Controls.Add(Me.deleteButton)
        Me.Panel1.Controls.Add(Me.searchButton)
        Me.Panel1.Controls.Add(Me.search_text)
        Me.Panel1.Controls.Add(Me.search_image)
        Me.Panel1.Location = New System.Drawing.Point(2, 62)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 45)
        Me.Panel1.TabIndex = 1
        '
        'Edit
        '
        Me.Edit.AutoSize = True
        Me.Edit.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.Location = New System.Drawing.Point(625, 10)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(75, 28)
        Me.Edit.TabIndex = 8
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'addButton
        '
        Me.addButton.AutoSize = True
        Me.addButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.addButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.Image = CType(resources.GetObject("addButton.Image"), System.Drawing.Image)
        Me.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addButton.Location = New System.Drawing.Point(496, 10)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(123, 28)
        Me.addButton.TabIndex = 7
        Me.addButton.Text = "Add Volunteer"
        Me.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.addButton.UseVisualStyleBackColor = False
        '
        'deleteButton
        '
        Me.deleteButton.AutoSize = True
        Me.deleteButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Image = CType(resources.GetObject("deleteButton.Image"), System.Drawing.Image)
        Me.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.deleteButton.Location = New System.Drawing.Point(706, 10)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(87, 28)
        Me.deleteButton.TabIndex = 6
        Me.deleteButton.Text = "Delete "
        Me.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'searchButton
        '
        Me.searchButton.AutoSize = True
        Me.searchButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.searchButton.Location = New System.Drawing.Point(307, 10)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(63, 28)
        Me.searchButton.TabIndex = 5
        Me.searchButton.Text = "Search"
        Me.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'search_text
        '
        Me.search_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_text.Location = New System.Drawing.Point(25, 13)
        Me.search_text.Name = "search_text"
        Me.search_text.Size = New System.Drawing.Size(277, 24)
        Me.search_text.TabIndex = 4
        '
        'search_image
        '
        Me.search_image.BackColor = System.Drawing.SystemColors.ControlLight
        Me.search_image.Image = CType(resources.GetObject("search_image.Image"), System.Drawing.Image)
        Me.search_image.Location = New System.Drawing.Point(6, 10)
        Me.search_image.Name = "search_image"
        Me.search_image.Size = New System.Drawing.Size(23, 24)
        Me.search_image.TabIndex = 3
        '
        'Main_Panel
        '
        Me.Main_Panel.Controls.Add(Me.DataGridView1)
        Me.Main_Panel.Location = New System.Drawing.Point(2, 111)
        Me.Main_Panel.Margin = New System.Windows.Forms.Padding(2)
        Me.Main_Panel.Name = "Main_Panel"
        Me.Main_Panel.Size = New System.Drawing.Size(806, 306)
        Me.Main_Panel.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBox, Me.ID, Me.Title, Me.Name})
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(808, 306)
        Me.DataGridView1.TabIndex = 0
        '
        '
        'CheckBox
        '
        Me.CheckBox.HeaderText = ""
        Me.CheckBox.Name = "CheckBox"
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Title
        '
        Me.Title.DataPropertyName = "Title"
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Name
        '
        Me.Name.DataPropertyName = "Name_"
        Me.Name.HeaderText = "Name"
        Me.Name.Name = "Name"
        Me.Name.ReadOnly = True
        Me.Name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Name.Width = 800
        '
        'Volunteer_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 424)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        ''    Me.Name = "Volunteer_Form"
        Me.Text = "Dashboard"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel_Header.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Main_Panel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel_Header As Panel
    Friend WithEvents LB_Header As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents search_image As Label
    Friend WithEvents search_text As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents Main_Panel As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Edit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
End Class
