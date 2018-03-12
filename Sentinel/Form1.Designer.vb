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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.DgvTasks = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.DgvEvents = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtSend = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        CType(Me.DgvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.tabControl1.Location = New System.Drawing.Point(-133, -121)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1198, 1191)
        Me.tabControl1.TabIndex = 3
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.Label1)
        Me.tabPage1.Controls.Add(Me.TabControl2)
        Me.tabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.tabPage1.Location = New System.Drawing.Point(4, 51)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(1190, 1136)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Event"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.tabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.TabControl2.Location = New System.Drawing.Point(128, 70)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(933, 912)
        Me.TabControl2.TabIndex = 3
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.DgvTasks)
        Me.tabPage2.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabPage2.Location = New System.Drawing.Point(4, 51)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(925, 857)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Tasks"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'DgvTasks
        '
        Me.DgvTasks.AllowUserToAddRows = False
        Me.DgvTasks.AllowUserToDeleteRows = False
        Me.DgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTasks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column7, Me.Column8, Me.Column9, Me.Column5, Me.Column6, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15})
        Me.DgvTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvTasks.Location = New System.Drawing.Point(3, 3)
        Me.DgvTasks.Name = "DgvTasks"
        Me.DgvTasks.ReadOnly = True
        Me.DgvTasks.Size = New System.Drawing.Size(919, 851)
        Me.DgvTasks.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ShStarting"
        Me.Column4.HeaderText = "Start"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "ShEnd"
        Me.Column7.HeaderText = "End"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column8.DataPropertyName = "ShStarting"
        DataGridViewCellStyle17.Format = "MM/dd hh:mm tt"
        DataGridViewCellStyle17.NullValue = Nothing
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle17
        Me.Column8.FillWeight = 121.8274!
        Me.Column8.HeaderText = "Start / End"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 224
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "ShEnd"
        DataGridViewCellStyle18.Format = "MM/dd hh:mm tt"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle18
        Me.Column9.HeaderText = "End"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Column5.DataPropertyName = "EventIDLabel"
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle19
        Me.Column5.FillWeight = 95.63438!
        Me.Column5.HeaderText = "Contract"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 5
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "EventName"
        Me.Column6.HeaderText = "Contract Name"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle20
        Me.Column10.FillWeight = 95.63438!
        Me.Column10.HeaderText = "Service"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column10.Width = 172
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle21
        Me.Column11.FillWeight = 95.63438!
        Me.Column11.HeaderText = "Notes"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column11.Width = 144
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle22
        Me.Column12.FillWeight = 95.63438!
        Me.Column12.HeaderText = "Leads"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column13.DefaultCellStyle = DataGridViewCellStyle23
        Me.Column13.FillWeight = 95.63438!
        Me.Column13.HeaderText = "Crew"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column14
        '
        Me.Column14.HeaderText = "Status"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Visible = False
        '
        'Column15
        '
        Me.Column15.HeaderText = "Task Id"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.button2)
        Me.TabPage3.Controls.Add(Me.button1)
        Me.TabPage3.Controls.Add(Me.DgvEvents)
        Me.TabPage3.Controls.Add(Me.BtSend)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.TabPage3.Location = New System.Drawing.Point(4, 51)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(925, 857)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Event"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(611, 29)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(108, 60)
        Me.button2.TabIndex = 3
        Me.button2.Text = "button2"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(387, 29)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(114, 61)
        Me.button1.TabIndex = 2
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = True
        '
        'DgvEvents
        '
        Me.DgvEvents.AllowUserToOrderColumns = True
        Me.DgvEvents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEvents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvEvents.ColumnHeadersHeight = 43
        Me.DgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DgvEvents.EnableHeadersVisualStyles = False
        Me.DgvEvents.Location = New System.Drawing.Point(22, 112)
        Me.DgvEvents.Name = "DgvEvents"
        Me.DgvEvents.ReadOnly = True
        Me.DgvEvents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvEvents.RowHeadersVisible = False
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEvents.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.DgvEvents.RowTemplate.Height = 42
        Me.DgvEvents.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEvents.Size = New System.Drawing.Size(876, 718)
        Me.DgvEvents.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "EventIDLabel"
        Me.Column1.HeaderText = "Contract"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Name"
        Me.Column2.HeaderText = "Event Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Date"
        Me.Column3.HeaderText = "Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'BtSend
        '
        Me.BtSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSend.Location = New System.Drawing.Point(63, 29)
        Me.BtSend.Name = "BtSend"
        Me.BtSend.Size = New System.Drawing.Size(239, 62)
        Me.BtSend.TabIndex = 0
        Me.BtSend.Text = "SEND"
        Me.BtSend.UseVisualStyleBackColor = True
        '
        'timer1
        '
        Me.timer1.Interval = 120000
        '
        'timer2
        '
        Me.timer2.Interval = 4500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 994)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "0"
        Me.Label1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(933, 949)
        Me.Controls.Add(Me.tabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Sentinel 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        CType(Me.DgvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DgvEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents timer1 As Timer
    Private WithEvents timer2 As Timer
    Private WithEvents tabPage1 As TabPage
    Private WithEvents TabControl2 As TabControl
    Private WithEvents tabPage2 As TabPage
    Private WithEvents DgvTasks As DataGridView
    Private WithEvents TabPage3 As TabPage
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents DgvEvents As DataGridView
    Private WithEvents Column1 As DataGridViewTextBoxColumn
    Private WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents BtSend As Button
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
