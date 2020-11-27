Public Class frmXlsParam
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnXlsParam As System.Windows.Forms.Button
    Friend WithEvents lblXlsRowDim As System.Windows.Forms.Label
    Friend WithEvents lblXlsColDim As System.Windows.Forms.Label
    Friend WithEvents lblXlsSprdSheet As System.Windows.Forms.Label
    Friend WithEvents nudXlsRowDim As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudXlsColDim As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblXlsParam As System.Windows.Forms.Label
    Friend WithEvents cboXlsSprdSheet As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXlsParam))
        Me.lblXlsParam = New System.Windows.Forms.Label()
        Me.nudXlsRowDim = New System.Windows.Forms.NumericUpDown()
        Me.nudXlsColDim = New System.Windows.Forms.NumericUpDown()
        Me.btnXlsParam = New System.Windows.Forms.Button()
        Me.lblXlsRowDim = New System.Windows.Forms.Label()
        Me.lblXlsColDim = New System.Windows.Forms.Label()
        Me.lblXlsSprdSheet = New System.Windows.Forms.Label()
        Me.cboXlsSprdSheet = New System.Windows.Forms.ComboBox()
        CType(Me.nudXlsRowDim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXlsColDim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblXlsParam
        '
        Me.lblXlsParam.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXlsParam.Location = New System.Drawing.Point(40, 32)
        Me.lblXlsParam.Name = "lblXlsParam"
        Me.lblXlsParam.Size = New System.Drawing.Size(232, 40)
        Me.lblXlsParam.TabIndex = 0
        Me.lblXlsParam.Text = "Please Enter Excel Data Sheet Parameters"
        Me.lblXlsParam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudXlsRowDim
        '
        Me.nudXlsRowDim.Location = New System.Drawing.Point(40, 120)
        Me.nudXlsRowDim.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.nudXlsRowDim.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudXlsRowDim.Name = "nudXlsRowDim"
        Me.nudXlsRowDim.Size = New System.Drawing.Size(75, 20)
        Me.nudXlsRowDim.TabIndex = 2
        Me.nudXlsRowDim.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'nudXlsColDim
        '
        Me.nudXlsColDim.Location = New System.Drawing.Point(200, 120)
        Me.nudXlsColDim.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        Me.nudXlsColDim.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudXlsColDim.Name = "nudXlsColDim"
        Me.nudXlsColDim.Size = New System.Drawing.Size(75, 20)
        Me.nudXlsColDim.TabIndex = 4
        Me.nudXlsColDim.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'btnXlsParam
        '
        Me.btnXlsParam.Location = New System.Drawing.Point(120, 240)
        Me.btnXlsParam.Name = "btnXlsParam"
        Me.btnXlsParam.Size = New System.Drawing.Size(75, 20)
        Me.btnXlsParam.TabIndex = 0
        Me.btnXlsParam.Text = "OK"
        Me.btnXlsParam.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblXlsRowDim
        '
        Me.lblXlsRowDim.Location = New System.Drawing.Point(40, 104)
        Me.lblXlsRowDim.Name = "lblXlsRowDim"
        Me.lblXlsRowDim.Size = New System.Drawing.Size(80, 16)
        Me.lblXlsRowDim.TabIndex = 1
        Me.lblXlsRowDim.Text = "Rows to Read"
        '
        'lblXlsColDim
        '
        Me.lblXlsColDim.Location = New System.Drawing.Point(200, 104)
        Me.lblXlsColDim.Name = "lblXlsColDim"
        Me.lblXlsColDim.Size = New System.Drawing.Size(96, 16)
        Me.lblXlsColDim.TabIndex = 3
        Me.lblXlsColDim.Text = "Columns to Read"
        '
        'lblXlsSprdSheet
        '
        Me.lblXlsSprdSheet.Location = New System.Drawing.Point(88, 168)
        Me.lblXlsSprdSheet.Name = "lblXlsSprdSheet"
        Me.lblXlsSprdSheet.Size = New System.Drawing.Size(120, 16)
        Me.lblXlsSprdSheet.TabIndex = 5
        Me.lblXlsSprdSheet.Text = "Spread Sheet to Read"
        '
        'cboXlsSprdSheet
        '
        Me.cboXlsSprdSheet.Location = New System.Drawing.Point(88, 192)
        Me.cboXlsSprdSheet.Name = "cboXlsSprdSheet"
        Me.cboXlsSprdSheet.Size = New System.Drawing.Size(128, 21)
        Me.cboXlsSprdSheet.TabIndex = 7
        '
        'frmXlsParam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(317, 298)
        Me.Controls.Add(Me.cboXlsSprdSheet)
        Me.Controls.Add(Me.lblXlsSprdSheet)
        Me.Controls.Add(Me.lblXlsColDim)
        Me.Controls.Add(Me.lblXlsRowDim)
        Me.Controls.Add(Me.btnXlsParam)
        Me.Controls.Add(Me.nudXlsColDim)
        Me.Controls.Add(Me.nudXlsRowDim)
        Me.Controls.Add(Me.lblXlsParam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmXlsParam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Xls Data Sheet Parameters"
        CType(Me.nudXlsRowDim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXlsColDim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Close the Form "frmXlsParam" on Button "btnXlsParam" Click
    Private Sub btnXlsParam_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXlsParam.Click
        Me.Close()
    End Sub

    'Close the Form "frmXlsParam" on hitting Enter Button
    Private Sub frmXlsParam_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        Me.Close()
    End Sub
End Class
