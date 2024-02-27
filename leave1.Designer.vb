<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class leave1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(leave1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EMPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LEAVETYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TODATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FROMDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DAYSOFLEAVEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHIFTTIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LEAVEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployDataSet2 = New WindowsApplication1.employDataSet2()
        Me.LEAVETableAdapter = New WindowsApplication1.employDataSet2TableAdapters.LEAVETableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.emid = New System.Windows.Forms.TextBox()
        Me.dol = New System.Windows.Forms.TextBox()
        Me.lt = New System.Windows.Forms.TextBox()
        Me.sta = New System.Windows.Forms.ComboBox()
        Me.td = New System.Windows.Forms.DateTimePicker()
        Me.fd = New System.Windows.Forms.DateTimePicker()
        Me.st = New System.Windows.Forms.ComboBox()
        Me.d = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEAVEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LEAVE APPLY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EMP_ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LEAVE_TYPE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(257, 199)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TO DATE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(664, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DAYS OF LEAVE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(664, 255)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "DESCRIPTION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(664, 141)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "STATUS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(257, 257)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 22)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "FROM DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(664, 199)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 22)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "SHIFT TIME"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(477, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 35)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPIDDataGridViewTextBoxColumn, Me.LEAVETYPEDataGridViewTextBoxColumn, Me.TODATEDataGridViewTextBoxColumn, Me.FROMDATEDataGridViewTextBoxColumn, Me.DAYSOFLEAVEDataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn, Me.SHIFTTIMEDataGridViewTextBoxColumn, Me.DESCRIPTIONDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LEAVEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(214, 422)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(830, 112)
        Me.DataGridView1.TabIndex = 23
        '
        'EMPIDDataGridViewTextBoxColumn
        '
        Me.EMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMP_ID"
        Me.EMPIDDataGridViewTextBoxColumn.HeaderText = "EMP_ID"
        Me.EMPIDDataGridViewTextBoxColumn.Name = "EMPIDDataGridViewTextBoxColumn"
        '
        'LEAVETYPEDataGridViewTextBoxColumn
        '
        Me.LEAVETYPEDataGridViewTextBoxColumn.DataPropertyName = "LEAVETYPE"
        Me.LEAVETYPEDataGridViewTextBoxColumn.HeaderText = "LEAVETYPE"
        Me.LEAVETYPEDataGridViewTextBoxColumn.Name = "LEAVETYPEDataGridViewTextBoxColumn"
        '
        'TODATEDataGridViewTextBoxColumn
        '
        Me.TODATEDataGridViewTextBoxColumn.DataPropertyName = "TODATE"
        Me.TODATEDataGridViewTextBoxColumn.HeaderText = "TODATE"
        Me.TODATEDataGridViewTextBoxColumn.Name = "TODATEDataGridViewTextBoxColumn"
        '
        'FROMDATEDataGridViewTextBoxColumn
        '
        Me.FROMDATEDataGridViewTextBoxColumn.DataPropertyName = "FROMDATE"
        Me.FROMDATEDataGridViewTextBoxColumn.HeaderText = "FROMDATE"
        Me.FROMDATEDataGridViewTextBoxColumn.Name = "FROMDATEDataGridViewTextBoxColumn"
        '
        'DAYSOFLEAVEDataGridViewTextBoxColumn
        '
        Me.DAYSOFLEAVEDataGridViewTextBoxColumn.DataPropertyName = "DAYSOFLEAVE"
        Me.DAYSOFLEAVEDataGridViewTextBoxColumn.HeaderText = "DAYSOFLEAVE"
        Me.DAYSOFLEAVEDataGridViewTextBoxColumn.Name = "DAYSOFLEAVEDataGridViewTextBoxColumn"
        '
        'STATUSDataGridViewTextBoxColumn
        '
        Me.STATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.Name = "STATUSDataGridViewTextBoxColumn"
        '
        'SHIFTTIMEDataGridViewTextBoxColumn
        '
        Me.SHIFTTIMEDataGridViewTextBoxColumn.DataPropertyName = "SHIFTTIME"
        Me.SHIFTTIMEDataGridViewTextBoxColumn.HeaderText = "SHIFTTIME"
        Me.SHIFTTIMEDataGridViewTextBoxColumn.Name = "SHIFTTIMEDataGridViewTextBoxColumn"
        '
        'DESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION"
        Me.DESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION"
        Me.DESCRIPTIONDataGridViewTextBoxColumn.Name = "DESCRIPTIONDataGridViewTextBoxColumn"
        '
        'LEAVEBindingSource
        '
        Me.LEAVEBindingSource.DataMember = "LEAVE"
        Me.LEAVEBindingSource.DataSource = Me.EmployDataSet2
        '
        'EmployDataSet2
        '
        Me.EmployDataSet2.DataSetName = "employDataSet2"
        Me.EmployDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LEAVETableAdapter
        '
        Me.LEAVETableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1251, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'emid
        '
        Me.emid.Location = New System.Drawing.Point(424, 88)
        Me.emid.Margin = New System.Windows.Forms.Padding(2)
        Me.emid.Multiline = True
        Me.emid.Name = "emid"
        Me.emid.Size = New System.Drawing.Size(125, 21)
        Me.emid.TabIndex = 25
        '
        'dol
        '
        Me.dol.Location = New System.Drawing.Point(846, 87)
        Me.dol.Margin = New System.Windows.Forms.Padding(2)
        Me.dol.Multiline = True
        Me.dol.Name = "dol"
        Me.dol.Size = New System.Drawing.Size(125, 20)
        Me.dol.TabIndex = 26
        '
        'lt
        '
        Me.lt.Location = New System.Drawing.Point(424, 144)
        Me.lt.Margin = New System.Windows.Forms.Padding(2)
        Me.lt.Multiline = True
        Me.lt.Name = "lt"
        Me.lt.Size = New System.Drawing.Size(125, 21)
        Me.lt.TabIndex = 27
        '
        'sta
        '
        Me.sta.FormattingEnabled = True
        Me.sta.Items.AddRange(New Object() {"APPROVED", "PENDING", "UNDER PROCCESSING"})
        Me.sta.Location = New System.Drawing.Point(846, 140)
        Me.sta.Name = "sta"
        Me.sta.Size = New System.Drawing.Size(125, 21)
        Me.sta.Sorted = True
        Me.sta.TabIndex = 28
        '
        'td
        '
        Me.td.Location = New System.Drawing.Point(424, 197)
        Me.td.Name = "td"
        Me.td.Size = New System.Drawing.Size(125, 20)
        Me.td.TabIndex = 29
        '
        'fd
        '
        Me.fd.Location = New System.Drawing.Point(424, 258)
        Me.fd.Name = "fd"
        Me.fd.Size = New System.Drawing.Size(125, 20)
        Me.fd.TabIndex = 30
        '
        'st
        '
        Me.st.FormattingEnabled = True
        Me.st.Items.AddRange(New Object() {"DAY SHIFT", "NIGHT SHIFT"})
        Me.st.Location = New System.Drawing.Point(846, 196)
        Me.st.Name = "st"
        Me.st.Size = New System.Drawing.Size(125, 21)
        Me.st.Sorted = True
        Me.st.TabIndex = 33
        '
        'd
        '
        Me.d.Location = New System.Drawing.Point(846, 258)
        Me.d.Margin = New System.Windows.Forms.Padding(2)
        Me.d.Multiline = True
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(125, 50)
        Me.d.TabIndex = 34
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(621, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 35)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'leave1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.th__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 640)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.st)
        Me.Controls.Add(Me.fd)
        Me.Controls.Add(Me.td)
        Me.Controls.Add(Me.sta)
        Me.Controls.Add(Me.lt)
        Me.Controls.Add(Me.dol)
        Me.Controls.Add(Me.emid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "leave1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leave"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEAVEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EmployDataSet2 As WindowsApplication1.employDataSet2
    Friend WithEvents LEAVEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LEAVETableAdapter As WindowsApplication1.employDataSet2TableAdapters.LEAVETableAdapter
    Friend WithEvents EMPIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LEAVETYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TODATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FROMDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DAYSOFLEAVEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SHIFTTIMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents emid As System.Windows.Forms.TextBox
    Friend WithEvents dol As System.Windows.Forms.TextBox
    Friend WithEvents lt As System.Windows.Forms.TextBox
    Friend WithEvents sta As System.Windows.Forms.ComboBox
    Friend WithEvents td As System.Windows.Forms.DateTimePicker
    Friend WithEvents fd As System.Windows.Forms.DateTimePicker
    Friend WithEvents st As System.Windows.Forms.ComboBox
    Friend WithEvents d As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
