<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Events
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EventID = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EventName = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EventDescription = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Volunteers = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 57)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(325, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Events"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBox, Me.EventID, Me.EventName, Me.EventDescription})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(959, 446)
        Me.DataGridView1.TabIndex = 1
        '
        'CheckBox
        '
        Me.CheckBox.HeaderText = ""
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.ReadOnly = True
        Me.CheckBox.Width = 40
        '
        'EventID
        '
        Me.EventID.HeaderText = "ID"
        Me.EventID.Name = "EventID"
        Me.EventID.ReadOnly = True
        '
        'EventName
        '
        Me.EventName.HeaderText = "EventName"
        Me.EventName.Name = "EventName"
        Me.EventName.ReadOnly = True
        '
        'EventDescription
        '
        Me.EventDescription.FillWeight = 800.0!
        Me.EventDescription.HeaderText = "Event Description"
        Me.EventDescription.Name = "EventDescription"
        Me.EventDescription.ReadOnly = True
        Me.EventDescription.Width = 800
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Volunteers)
        Me.Panel2.Controls.Add(Me.Delete)
        Me.Panel2.Controls.Add(Me.Edit)
        Me.Panel2.Controls.Add(Me.Add)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 56)
        Me.Panel2.TabIndex = 2
        '
        'Volunteers
        '
        Me.Volunteers.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Volunteers.Location = New System.Drawing.Point(713, 18)
        Me.Volunteers.Name = "Volunteers"
        Me.Volunteers.Size = New System.Drawing.Size(75, 23)
        Me.Volunteers.TabIndex = 5
        Me.Volunteers.Text = "Volunteers"
        Me.Volunteers.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Delete.Location = New System.Drawing.Point(632, 19)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 4
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Edit.Location = New System.Drawing.Point(551, 19)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(75, 23)
        Me.Edit.TabIndex = 3
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Add.Location = New System.Drawing.Point(470, 20)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 23)
        Me.Add.TabIndex = 2
        Me.Add.Text = "Add "
        Me.Add.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(283, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(265, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Form_Events
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_Events"
        Me.Text = "Events"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents EventID As DataGridViewCheckBoxColumn
    Friend WithEvents EventName As DataGridViewCheckBoxColumn
    Friend WithEvents EventDescription As DataGridViewCheckBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Volunteers As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Add As Button
End Class
