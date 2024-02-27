<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class V
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(V))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EMPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WORKDAYSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALSALARYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPSALARYBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployDataSet4 = New WindowsApplication1.employDataSet4()
        Me.EMPSALARYBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployDataSet3 = New WindowsApplication1.employDataSet3()
        Me.EMPSALARYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployDataSet1 = New WindowsApplication1.employDataSet1()
        Me.EMP_SALARYTableAdapter = New WindowsApplication1.employDataSet1TableAdapters.EMP_SALARYTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.EMP_SALARYTableAdapter1 = New WindowsApplication1.employDataSet3TableAdapters.EMP_SALARYTableAdapter()
        Me.EMP_SALARYTableAdapter2 = New WindowsApplication1.employDataSet4TableAdapters.EMP_SALARYTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.IDTXT = New System.Windows.Forms.TextBox()
        Me.FNTXT = New System.Windows.Forms.TextBox()
        Me.LNTXT = New System.Windows.Forms.TextBox()
        Me.CTXT = New System.Windows.Forms.TextBox()
        Me.PTXT = New System.Windows.Forms.ComboBox()
        Me.WDTXT = New System.Windows.Forms.TextBox()
        Me.TSTXT = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPSALARYBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPSALARYBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPSALARYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SALARY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FIRST NAME "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(683, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LAST NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 205)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CONTACT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(683, 205)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "POSITION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 275)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "WORK DAYS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(683, 274)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "TOTAL SALARY"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(523, 331)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 40)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "UPDATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(861, 331)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 40)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "HOME"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(468, 80)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 22)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "EMP_ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPIDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.CONTACTDataGridViewTextBoxColumn, Me.POSITIONDataGridViewTextBoxColumn, Me.WORKDAYSDataGridViewTextBoxColumn, Me.TOTALSALARYDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EMPSALARYBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(287, 415)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(733, 150)
        Me.DataGridView1.TabIndex = 17
        '
        'EMPIDDataGridViewTextBoxColumn
        '
        Me.EMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMP_ID"
        Me.EMPIDDataGridViewTextBoxColumn.HeaderText = "EMP_ID"
        Me.EMPIDDataGridViewTextBoxColumn.Name = "EMPIDDataGridViewTextBoxColumn"
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        '
        'CONTACTDataGridViewTextBoxColumn
        '
        Me.CONTACTDataGridViewTextBoxColumn.DataPropertyName = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.HeaderText = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.Name = "CONTACTDataGridViewTextBoxColumn"
        '
        'POSITIONDataGridViewTextBoxColumn
        '
        Me.POSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION"
        Me.POSITIONDataGridViewTextBoxColumn.HeaderText = "POSITION"
        Me.POSITIONDataGridViewTextBoxColumn.Name = "POSITIONDataGridViewTextBoxColumn"
        '
        'WORKDAYSDataGridViewTextBoxColumn
        '
        Me.WORKDAYSDataGridViewTextBoxColumn.DataPropertyName = "WORKDAYS"
        Me.WORKDAYSDataGridViewTextBoxColumn.HeaderText = "WORKDAYS"
        Me.WORKDAYSDataGridViewTextBoxColumn.Name = "WORKDAYSDataGridViewTextBoxColumn"
        '
        'TOTALSALARYDataGridViewTextBoxColumn
        '
        Me.TOTALSALARYDataGridViewTextBoxColumn.DataPropertyName = "TOTALSALARY"
        Me.TOTALSALARYDataGridViewTextBoxColumn.HeaderText = "TOTALSALARY"
        Me.TOTALSALARYDataGridViewTextBoxColumn.Name = "TOTALSALARYDataGridViewTextBoxColumn"
        '
        'EMPSALARYBindingSource2
        '
        Me.EMPSALARYBindingSource2.DataMember = "EMP_SALARY"
        Me.EMPSALARYBindingSource2.DataSource = Me.EmployDataSet4
        '
        'EmployDataSet4
        '
        Me.EmployDataSet4.DataSetName = "employDataSet4"
        Me.EmployDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPSALARYBindingSource1
        '
        Me.EMPSALARYBindingSource1.DataMember = "EMP_SALARY"
        Me.EMPSALARYBindingSource1.DataSource = Me.EmployDataSet3
        '
        'EmployDataSet3
        '
        Me.EmployDataSet3.DataSetName = "employDataSet3"
        Me.EmployDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPSALARYBindingSource
        '
        Me.EMPSALARYBindingSource.DataMember = "EMP_SALARY"
        Me.EMPSALARYBindingSource.DataSource = Me.EmployDataSet1
        '
        'EmployDataSet1
        '
        Me.EmployDataSet1.DataSetName = "employDataSet1"
        Me.EmployDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMP_SALARYTableAdapter
        '
        Me.EMP_SALARYTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(366, 331)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 40)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "ADD"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'EMP_SALARYTableAdapter1
        '
        Me.EMP_SALARYTableAdapter1.ClearBeforeFill = True
        '
        'EMP_SALARYTableAdapter2
        '
        Me.EMP_SALARYTableAdapter2.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1255, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(746, 81)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(66, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "search"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'IDTXT
        '
        Me.IDTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTXT.Location = New System.Drawing.Point(581, 79)
        Me.IDTXT.Margin = New System.Windows.Forms.Padding(2)
        Me.IDTXT.Name = "IDTXT"
        Me.IDTXT.Size = New System.Drawing.Size(125, 23)
        Me.IDTXT.TabIndex = 34
        '
        'FNTXT
        '
        Me.FNTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNTXT.Location = New System.Drawing.Point(495, 136)
        Me.FNTXT.Margin = New System.Windows.Forms.Padding(2)
        Me.FNTXT.Name = "FNTXT"
        Me.FNTXT.Size = New System.Drawing.Size(125, 23)
        Me.FNTXT.TabIndex = 35
        '
        'LNTXT
        '
        Me.LNTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNTXT.Location = New System.Drawing.Point(855, 136)
        Me.LNTXT.Margin = New System.Windows.Forms.Padding(2)
        Me.LNTXT.Name = "LNTXT"
        Me.LNTXT.Size = New System.Drawing.Size(125, 23)
        Me.LNTXT.TabIndex = 36
        '
        'CTXT
        '
        Me.CTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTXT.Location = New System.Drawing.Point(495, 204)
        Me.CTXT.Margin = New System.Windows.Forms.Padding(2)
        Me.CTXT.Name = "CTXT"
        Me.CTXT.Size = New System.Drawing.Size(125, 23)
        Me.CTXT.TabIndex = 37
        '
        'PTXT
        '
        Me.PTXT.FormattingEnabled = True
        Me.PTXT.Items.AddRange(New Object() {"MANAGER", "SUPERVISOR", "WORKER"})
        Me.PTXT.Location = New System.Drawing.Point(855, 205)
        Me.PTXT.Name = "PTXT"
        Me.PTXT.Size = New System.Drawing.Size(125, 21)
        Me.PTXT.Sorted = True
        Me.PTXT.TabIndex = 38
        '
        'WDTXT
        '
        Me.WDTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WDTXT.Location = New System.Drawing.Point(495, 274)
        Me.WDTXT.Margin = New System.Windows.Forms.Padding(2)
        Me.WDTXT.Name = "WDTXT"
        Me.WDTXT.Size = New System.Drawing.Size(125, 23)
        Me.WDTXT.TabIndex = 39
        '
        'TSTXT
        '
        Me.TSTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSTXT.Location = New System.Drawing.Point(855, 274)
        Me.TSTXT.Margin = New System.Windows.Forms.Padding(2)
        Me.TSTXT.Name = "TSTXT"
        Me.TSTXT.Size = New System.Drawing.Size(125, 23)
        Me.TSTXT.TabIndex = 40
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gray
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(687, 331)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 40)
        Me.Button5.TabIndex = 41
        Me.Button5.Text = "DELETE"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'V
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2023_04_10_at_18_50_59
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 640)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TSTXT)
        Me.Controls.Add(Me.WDTXT)
        Me.Controls.Add(Me.PTXT)
        Me.Controls.Add(Me.CTXT)
        Me.Controls.Add(Me.LNTXT)
        Me.Controls.Add(Me.FNTXT)
        Me.Controls.Add(Me.IDTXT)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "V"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPSALARYBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPSALARYBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPSALARYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EmployDataSet1 As WindowsApplication1.employDataSet1
    Friend WithEvents EMPSALARYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMP_SALARYTableAdapter As WindowsApplication1.employDataSet1TableAdapters.EMP_SALARYTableAdapter
    Friend WithEvents EMPIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTACTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POSITIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WORKDAYSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALSALARYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents EmployDataSet3 As WindowsApplication1.employDataSet3
    Friend WithEvents EMPSALARYBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EMP_SALARYTableAdapter1 As WindowsApplication1.employDataSet3TableAdapters.EMP_SALARYTableAdapter
    Friend WithEvents EmployDataSet4 As WindowsApplication1.employDataSet4
    Friend WithEvents EMPSALARYBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents EMP_SALARYTableAdapter2 As WindowsApplication1.employDataSet4TableAdapters.EMP_SALARYTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents IDTXT As System.Windows.Forms.TextBox
    Friend WithEvents FNTXT As System.Windows.Forms.TextBox
    Friend WithEvents LNTXT As System.Windows.Forms.TextBox
    Friend WithEvents CTXT As System.Windows.Forms.TextBox
    Friend WithEvents PTXT As System.Windows.Forms.ComboBox
    Friend WithEvents WDTXT As System.Windows.Forms.TextBox
    Friend WithEvents TSTXT As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
