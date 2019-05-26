<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AddEvent
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Notes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.index = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.volunteer = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Hours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expenses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reimbursements = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EventName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.Logout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD EVENT"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Notes)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.EventDate)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Type)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.EventName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-2, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 404)
        Me.Panel2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.Location = New System.Drawing.Point(601, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Location = New System.Drawing.Point(483, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(137, 139)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(315, 20)
        Me.Notes.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Notes  :"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.index, Me.volunteer, Me.Hours, Me.ShiftStart, Me.ShiftEnd, Me.Expenses, Me.Reimbursements})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(742, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'index
        '
        Me.index.HeaderText = "No."
        Me.index.Name = "index"
        '
        'volunteer
        '
        Me.volunteer.DataPropertyName = "Volunteer"
        Me.volunteer.HeaderText = "Volunteer"
        Me.volunteer.Name = "volunteer"
        '
        'Hours
        '
        Me.Hours.DataPropertyName = "Hours"
        Me.Hours.HeaderText = "Hours"
        Me.Hours.Name = "Hours"
        '
        'ShiftStart
        '
        Me.ShiftStart.DataPropertyName = "ShiftStart"
        Me.ShiftStart.HeaderText = "Shift Start time"
        Me.ShiftStart.Name = "ShiftStart"
        '
        'ShiftEnd
        '
        Me.ShiftEnd.DataPropertyName = "ShiftEnd"
        Me.ShiftEnd.HeaderText = "Shift End Time"
        Me.ShiftEnd.Name = "ShiftEnd"
        '
        'Expenses
        '
        Me.Expenses.DataPropertyName = "Expenses"
        Me.Expenses.HeaderText = "Expenses"
        Me.Expenses.Name = "Expenses"
        '
        'Reimbursements
        '
        Me.Reimbursements.DataPropertyName = "Reimbursements"
        Me.Reimbursements.HeaderText = "Reimbursements"
        Me.Reimbursements.Name = "Reimbursements"
        '
        'EventDate
        '
        Me.EventDate.Location = New System.Drawing.Point(137, 102)
        Me.EventDate.Name = "EventDate"
        Me.EventDate.Size = New System.Drawing.Size(200, 20)
        Me.EventDate.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Date    :"
        '
        'Type
        '
        Me.Type.Location = New System.Drawing.Point(137, 64)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(133, 20)
        Me.Type.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type    :"
        '
        'EventName
        '
        Me.EventName.Location = New System.Drawing.Point(137, 31)
        Me.EventName.Name = "EventName"
        Me.EventName.Size = New System.Drawing.Size(100, 20)
        Me.EventName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name  :"
        '
        'Logout
        '
        Me.Logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Logout.Location = New System.Drawing.Point(718, 14)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(75, 23)
        Me.Logout.TabIndex = 1
        Me.Logout.Text = "Log Out"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Form_AddEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_AddEvent"
        Me.Text = "AddEvent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Notes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EventDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Type As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EventName As TextBox
    Friend WithEvents index As DataGridViewTextBoxColumn
    Friend WithEvents volunteer As DataGridViewComboBoxColumn
    Friend WithEvents Hours As DataGridViewTextBoxColumn
    Friend WithEvents ShiftStart As DataGridViewTextBoxColumn
    Friend WithEvents ShiftEnd As DataGridViewTextBoxColumn
    Friend WithEvents Expenses As DataGridViewTextBoxColumn
    Friend WithEvents Reimbursements As DataGridViewTextBoxColumn
    Friend WithEvents Logout As Button
End Class
