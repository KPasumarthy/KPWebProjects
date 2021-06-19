'KP : Smart Notes Xls Application cross transfers data to and from Excel
Imports System.IO
Imports System.Collections
Imports System.Drawing
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Windows.Forms
'Imports Microsoft.Office.Interop       'KP : UnComment for Early Binding


Public Class frmAdmin
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Public Sub Initialize()
        Me.mTreeView.LabelEdit = True
        Me.mTreeView.AllowDrop = True
        Me.mTreeView.ContextMenu = Me.mnuContext
        Me.cmbDatabaseType.SelectedIndex = 0

        Me.ofdSNFFiles.InitialDirectory = Me.msSNFFilePath
        Me.ofdSNFFiles.Filter = "Smart notes files (*.snf)|*.snf|All files (*.*)|*.*"
        Me.ofdSNFFiles.FilterIndex = 1
        Me.ofdSNFFiles.RestoreDirectory = True

        Me.sfdSmartNotesFile.InitialDirectory = Me.SNFFolderPath
        Me.sfdSmartNotesFile.Filter = "Smart notes files (*.snf)|*.snf|All files (*.*)|*.*"
        Me.sfdSmartNotesFile.FilterIndex = 1
        Me.sfdSmartNotesFile.RestoreDirectory = True

        'Open File Dialog & Filter Only "XlS" files
        Me.ofdXlsFiles.InitialDirectory = Me.SNFFolderPath
        Me.ofdXlsFiles.Filter = "MS Office Excel Files (*.xls)|*.xls|All files (*.*)|*.*"
        Me.ofdXlsFiles.FilterIndex = 1
        Me.ofdXlsFiles.RestoreDirectory = True

        'Disable Menu Items
        Me.mItemSave.Enabled = False
        Me.mItemSaveAs.Enabled = False
        Me.mItemClose.Enabled = False
        Me.mItemExport.Enabled = False
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
    Friend WithEvents lblServerName As System.Windows.Forms.Label
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents lblDatabaseName As System.Windows.Forms.Label
    Friend WithEvents txtDatabaseName As System.Windows.Forms.TextBox
    Friend WithEvents lblTableName As System.Windows.Forms.Label
    Friend WithEvents txtTableName As System.Windows.Forms.TextBox
    Friend WithEvents lblDatabaseType As System.Windows.Forms.Label
    Friend WithEvents cmbDatabaseType As System.Windows.Forms.ComboBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnSystemDB As System.Windows.Forms.Button
    Friend WithEvents btnDatabase As System.Windows.Forms.Button
    Friend WithEvents pnlLogin As System.Windows.Forms.Panel
    Friend WithEvents mnuContext As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuMain As System.Windows.Forms.MainMenu
    Friend WithEvents mItemNewChild As System.Windows.Forms.MenuItem
    Friend WithEvents mItemDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mItemExpandAll As System.Windows.Forms.MenuItem
    Friend WithEvents mItemCollapseAll As System.Windows.Forms.MenuItem
    Friend WithEvents mItemExit As System.Windows.Forms.MenuItem
    Friend WithEvents mItemOpen As System.Windows.Forms.MenuItem
    Friend WithEvents mItemSaveAs As System.Windows.Forms.MenuItem
    Friend WithEvents mItemSave As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDragDrop As System.Windows.Forms.ContextMenu
    Friend WithEvents mItemAsChild As System.Windows.Forms.MenuItem
    Friend WithEvents mItemAsNextSibling As System.Windows.Forms.MenuItem
    Friend WithEvents mItemAsPrevSibling As System.Windows.Forms.MenuItem
    Friend WithEvents mItemUndoDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mItemEditDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mItemEditNewChild As System.Windows.Forms.MenuItem
    Friend WithEvents mItemEditExpandAll As System.Windows.Forms.MenuItem
    Friend WithEvents mItemEditCollapseAll As System.Windows.Forms.MenuItem
    Friend WithEvents mItemEditRename As System.Windows.Forms.MenuItem
    Friend WithEvents mItemRename As System.Windows.Forms.MenuItem
    Friend WithEvents mItemCopyAbove As System.Windows.Forms.MenuItem
    Friend WithEvents mItemCopyBelow As System.Windows.Forms.MenuItem
    Friend WithEvents mItemCopyAsChild As System.Windows.Forms.MenuItem
    Friend WithEvents mTreeView As System.Windows.Forms.TreeView
    'Friend WithEvents PopupTree1 As Lumedx.SmartNotes.PopupTree
    Friend WithEvents menuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mItemHelpTopics As System.Windows.Forms.MenuItem
    Friend WithEvents mItemNew As System.Windows.Forms.MenuItem
    Friend WithEvents mItemClose As System.Windows.Forms.MenuItem
    Friend WithEvents mItemImport As System.Windows.Forms.MenuItem
    Friend WithEvents mItemImportExcel As System.Windows.Forms.MenuItem
    Friend WithEvents mItemExport As System.Windows.Forms.MenuItem
    Friend WithEvents mItemExport2Excel As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileMenuSprtr02 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileMenuSprtr03 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdmin As System.Windows.Forms.MenuItem
    Friend WithEvents tabEditorPanes As System.Windows.Forms.TabControl
    Friend WithEvents tbpDesign As System.Windows.Forms.TabPage
    Friend WithEvents stbFilePath As System.Windows.Forms.StatusBar
    Friend WithEvents mnuEditMenu As System.Windows.Forms.MenuItem
    Friend WithEvents sfdSmartNotesFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofdXlsFiles As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdSNFFiles As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mnuFileMenuSprtr01 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditMenuSprtr As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCntxtMnuSprtr As System.Windows.Forms.MenuItem
    Friend WithEvents mItemSerialize As System.Windows.Forms.MenuItem
    Friend WithEvents mItemDeSerialize As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.lblServerName = New System.Windows.Forms.Label()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.txtDatabaseName = New System.Windows.Forms.TextBox()
        Me.lblTableName = New System.Windows.Forms.Label()
        Me.txtTableName = New System.Windows.Forms.TextBox()
        Me.lblDatabaseType = New System.Windows.Forms.Label()
        Me.cmbDatabaseType = New System.Windows.Forms.ComboBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnSystemDB = New System.Windows.Forms.Button()
        Me.btnDatabase = New System.Windows.Forms.Button()
        Me.ofdSNFFiles = New System.Windows.Forms.OpenFileDialog()
        Me.mnuMain = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFileMenu = New System.Windows.Forms.MenuItem()
        Me.mItemNew = New System.Windows.Forms.MenuItem()
        Me.mItemOpen = New System.Windows.Forms.MenuItem()
        Me.mItemClose = New System.Windows.Forms.MenuItem()
        Me.mnuFileMenuSprtr01 = New System.Windows.Forms.MenuItem()
        Me.mItemSave = New System.Windows.Forms.MenuItem()
        Me.mItemSaveAs = New System.Windows.Forms.MenuItem()
        Me.mnuFileMenuSprtr02 = New System.Windows.Forms.MenuItem()
        Me.mItemImport = New System.Windows.Forms.MenuItem()
        Me.mItemImportExcel = New System.Windows.Forms.MenuItem()
        Me.mItemExport = New System.Windows.Forms.MenuItem()
        Me.mItemExport2Excel = New System.Windows.Forms.MenuItem()
        Me.mnuFileMenuSprtr03 = New System.Windows.Forms.MenuItem()
        Me.mItemExit = New System.Windows.Forms.MenuItem()
        Me.mnuEditMenu = New System.Windows.Forms.MenuItem()
        Me.mItemEditNewChild = New System.Windows.Forms.MenuItem()
        Me.mItemEditRename = New System.Windows.Forms.MenuItem()
        Me.mItemEditExpandAll = New System.Windows.Forms.MenuItem()
        Me.mItemEditCollapseAll = New System.Windows.Forms.MenuItem()
        Me.mnuEditMenuSprtr = New System.Windows.Forms.MenuItem()
        Me.mItemEditDelete = New System.Windows.Forms.MenuItem()
        Me.mItemUndoDelete = New System.Windows.Forms.MenuItem()
        Me.menuHelp = New System.Windows.Forms.MenuItem()
        Me.mItemHelpTopics = New System.Windows.Forms.MenuItem()
        Me.mnuAdmin = New System.Windows.Forms.MenuItem()
        Me.mItemSerialize = New System.Windows.Forms.MenuItem()
        Me.mItemDeSerialize = New System.Windows.Forms.MenuItem()
        Me.mnuContext = New System.Windows.Forms.ContextMenu()
        Me.mItemNewChild = New System.Windows.Forms.MenuItem()
        Me.mItemRename = New System.Windows.Forms.MenuItem()
        Me.mItemDelete = New System.Windows.Forms.MenuItem()
        Me.mItemExpandAll = New System.Windows.Forms.MenuItem()
        Me.mItemCollapseAll = New System.Windows.Forms.MenuItem()
        Me.sfdSmartNotesFile = New System.Windows.Forms.SaveFileDialog()
        Me.stbFilePath = New System.Windows.Forms.StatusBar()
        Me.mnuDragDrop = New System.Windows.Forms.ContextMenu()
        Me.mItemAsChild = New System.Windows.Forms.MenuItem()
        Me.mItemAsPrevSibling = New System.Windows.Forms.MenuItem()
        Me.mItemAsNextSibling = New System.Windows.Forms.MenuItem()
        Me.mnuCntxtMnuSprtr = New System.Windows.Forms.MenuItem()
        Me.mItemCopyAsChild = New System.Windows.Forms.MenuItem()
        Me.mItemCopyAbove = New System.Windows.Forms.MenuItem()
        Me.mItemCopyBelow = New System.Windows.Forms.MenuItem()
        Me.tabEditorPanes = New System.Windows.Forms.TabControl()
        Me.tbpDesign = New System.Windows.Forms.TabPage()
        Me.mTreeView = New System.Windows.Forms.TreeView()
        Me.ofdXlsFiles = New System.Windows.Forms.OpenFileDialog()
        Me.pnlLogin.SuspendLayout()
        Me.tabEditorPanes.SuspendLayout()
        Me.tbpDesign.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblServerName
        '
        Me.lblServerName.AutoSize = True
        Me.lblServerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerName.ForeColor = System.Drawing.Color.White
        Me.lblServerName.Location = New System.Drawing.Point(52, 82)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.Size = New System.Drawing.Size(84, 13)
        Me.lblServerName.TabIndex = 0
        Me.lblServerName.Text = "Server Name:"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(150, 80)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(202, 20)
        Me.txtServerName.TabIndex = 1
        Me.txtServerName.Text = "aspserver\sql2k"
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabaseName.ForeColor = System.Drawing.Color.White
        Me.lblDatabaseName.Location = New System.Drawing.Point(52, 118)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(101, 13)
        Me.lblDatabaseName.TabIndex = 2
        Me.lblDatabaseName.Text = "Database Name:"
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.Location = New System.Drawing.Point(150, 118)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(202, 20)
        Me.txtDatabaseName.TabIndex = 3
        Me.txtDatabaseName.Text = "cardiodocdev"
        '
        'lblTableName
        '
        Me.lblTableName.AutoSize = True
        Me.lblTableName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableName.ForeColor = System.Drawing.Color.White
        Me.lblTableName.Location = New System.Drawing.Point(52, 156)
        Me.lblTableName.Name = "lblTableName"
        Me.lblTableName.Size = New System.Drawing.Size(79, 13)
        Me.lblTableName.TabIndex = 4
        Me.lblTableName.Text = "Table Name:"
        '
        'txtTableName
        '
        Me.txtTableName.Location = New System.Drawing.Point(150, 154)
        Me.txtTableName.Name = "txtTableName"
        Me.txtTableName.Size = New System.Drawing.Size(202, 20)
        Me.txtTableName.TabIndex = 5
        Me.txtTableName.Text = "sscdsmartnotes"
        '
        'lblDatabaseType
        '
        Me.lblDatabaseType.AutoSize = True
        Me.lblDatabaseType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabaseType.ForeColor = System.Drawing.Color.White
        Me.lblDatabaseType.Location = New System.Drawing.Point(52, 44)
        Me.lblDatabaseType.Name = "lblDatabaseType"
        Me.lblDatabaseType.Size = New System.Drawing.Size(97, 13)
        Me.lblDatabaseType.TabIndex = 6
        Me.lblDatabaseType.Text = "Database Type:"
        '
        'cmbDatabaseType
        '
        Me.cmbDatabaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDatabaseType.Items.AddRange(New Object() {"SQL", "Access"})
        Me.cmbDatabaseType.Location = New System.Drawing.Point(150, 42)
        Me.cmbDatabaseType.Name = "cmbDatabaseType"
        Me.cmbDatabaseType.Size = New System.Drawing.Size(202, 21)
        Me.cmbDatabaseType.TabIndex = 7
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(52, 192)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(73, 13)
        Me.lblUserName.TabIndex = 4
        Me.lblUserName.Text = "User Name:"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(150, 192)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(202, 20)
        Me.txtUserName.TabIndex = 5
        Me.txtUserName.Text = "appapollo"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(54, 230)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(65, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(150, 228)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(202, 20)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.Text = "dna"
        '
        'btnConnect
        '
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ForeColor = System.Drawing.Color.White
        Me.btnConnect.Location = New System.Drawing.Point(168, 270)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 8
        Me.btnConnect.Text = "Connect"
        '
        'pnlLogin
        '
        Me.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pnlLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnlLogin.Controls.Add(Me.btnSystemDB)
        Me.pnlLogin.Controls.Add(Me.lblDatabaseType)
        Me.pnlLogin.Controls.Add(Me.lblServerName)
        Me.pnlLogin.Controls.Add(Me.lblDatabaseName)
        Me.pnlLogin.Controls.Add(Me.lblTableName)
        Me.pnlLogin.Controls.Add(Me.lblUserName)
        Me.pnlLogin.Controls.Add(Me.lblPassword)
        Me.pnlLogin.Controls.Add(Me.cmbDatabaseType)
        Me.pnlLogin.Controls.Add(Me.txtServerName)
        Me.pnlLogin.Controls.Add(Me.txtDatabaseName)
        Me.pnlLogin.Controls.Add(Me.txtTableName)
        Me.pnlLogin.Controls.Add(Me.txtUserName)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.btnConnect)
        Me.pnlLogin.Controls.Add(Me.btnDatabase)
        Me.pnlLogin.Location = New System.Drawing.Point(118, 78)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(402, 318)
        Me.pnlLogin.TabIndex = 9
        Me.pnlLogin.Visible = False
        '
        'btnSystemDB
        '
        Me.btnSystemDB.Location = New System.Drawing.Point(358, 80)
        Me.btnSystemDB.Name = "btnSystemDB"
        Me.btnSystemDB.Size = New System.Drawing.Size(22, 22)
        Me.btnSystemDB.TabIndex = 9
        Me.btnSystemDB.Text = "..."
        Me.btnSystemDB.Visible = False
        '
        'btnDatabase
        '
        Me.btnDatabase.Location = New System.Drawing.Point(358, 118)
        Me.btnDatabase.Name = "btnDatabase"
        Me.btnDatabase.Size = New System.Drawing.Size(22, 22)
        Me.btnDatabase.TabIndex = 9
        Me.btnDatabase.Text = "..."
        Me.btnDatabase.Visible = False
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileMenu, Me.mnuEditMenu, Me.menuHelp, Me.mnuAdmin})
        '
        'mnuFileMenu
        '
        Me.mnuFileMenu.Index = 0
        Me.mnuFileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mItemNew, Me.mItemOpen, Me.mItemClose, Me.mnuFileMenuSprtr01, Me.mItemSave, Me.mItemSaveAs, Me.mnuFileMenuSprtr02, Me.mItemImport, Me.mItemExport, Me.mnuFileMenuSprtr03, Me.mItemExit})
        Me.mnuFileMenu.Text = "&File"
        '
        'mItemNew
        '
        Me.mItemNew.Index = 0
        Me.mItemNew.Text = "New"
        '
        'mItemOpen
        '
        Me.mItemOpen.Index = 1
        Me.mItemOpen.Text = "&Open..."
        '
        'mItemClose
        '
        Me.mItemClose.Index = 2
        Me.mItemClose.Text = "Close"
        '
        'mnuFileMenuSprtr01
        '
        Me.mnuFileMenuSprtr01.Index = 3
        Me.mnuFileMenuSprtr01.Text = "-"
        '
        'mItemSave
        '
        Me.mItemSave.Index = 4
        Me.mItemSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.mItemSave.Text = "&Save"
        '
        'mItemSaveAs
        '
        Me.mItemSaveAs.Index = 5
        Me.mItemSaveAs.Text = "Save &As..."
        '
        'mnuFileMenuSprtr02
        '
        Me.mnuFileMenuSprtr02.Index = 6
        Me.mnuFileMenuSprtr02.Text = "-"
        '
        'mItemImport
        '
        Me.mItemImport.Index = 7
        Me.mItemImport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mItemImportExcel})
        Me.mItemImport.Text = "Import..."
        '
        'mItemImportExcel
        '
        Me.mItemImportExcel.Index = 0
        Me.mItemImportExcel.Text = "Excel"
        '
        'mItemExport
        '
        Me.mItemExport.Enabled = False
        Me.mItemExport.Index = 8
        Me.mItemExport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mItemExport2Excel})
        Me.mItemExport.Text = "Export..."
        '
        'mItemExport2Excel
        '
        Me.mItemExport2Excel.Index = 0
        Me.mItemExport2Excel.Text = "To Excel"
        '
        'mnuFileMenuSprtr03
        '
        Me.mnuFileMenuSprtr03.Index = 9
        Me.mnuFileMenuSprtr03.Text = "-"
        '
        'mItemExit
        '
        Me.mItemExit.Index = 10
        Me.mItemExit.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.mItemExit.Text = "E&xit"
        '
        'mnuEditMenu
        '
        Me.mnuEditMenu.Index = 1
        Me.mnuEditMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mItemEditNewChild, Me.mItemEditRename, Me.mItemEditExpandAll, Me.mItemEditCollapseAll, Me.mnuEditMenuSprtr, Me.mItemEditDelete, Me.mItemUndoDelete})
        Me.mnuEditMenu.Text = "&Edit"
        '
        'mItemEditNewChild
        '
        Me.mItemEditNewChild.Enabled = False
        Me.mItemEditNewChild.Index = 0
        Me.mItemEditNewChild.Text = "New &Child..."
        '
        'mItemEditRename
        '
        Me.mItemEditRename.Enabled = False
        Me.mItemEditRename.Index = 1
        Me.mItemEditRename.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.mItemEditRename.Text = "&Rename"
        '
        'mItemEditExpandAll
        '
        Me.mItemEditExpandAll.Enabled = False
        Me.mItemEditExpandAll.Index = 2
        Me.mItemEditExpandAll.Text = "&Expand All"
        '
        'mItemEditCollapseAll
        '
        Me.mItemEditCollapseAll.Enabled = False
        Me.mItemEditCollapseAll.Index = 3
        Me.mItemEditCollapseAll.Text = "C&ollapse All"
        '
        'mnuEditMenuSprtr
        '
        Me.mnuEditMenuSprtr.Index = 4
        Me.mnuEditMenuSprtr.Text = "-"
        '
        'mItemEditDelete
        '
        Me.mItemEditDelete.Enabled = False
        Me.mItemEditDelete.Index = 5
        Me.mItemEditDelete.Text = "&Delete"
        '
        'mItemUndoDelete
        '
        Me.mItemUndoDelete.Enabled = False
        Me.mItemUndoDelete.Index = 6
        Me.mItemUndoDelete.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.mItemUndoDelete.Text = "&Undo Delete"
        '
        'menuHelp
        '
        Me.menuHelp.Index = 2
        Me.menuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mItemHelpTopics})
        Me.menuHelp.Text = "Help"
        '
        'mItemHelpTopics
        '
        Me.mItemHelpTopics.Index = 0
        Me.mItemHelpTopics.Text = "Help Topics..."
        '
        'mnuAdmin
        '
        Me.mnuAdmin.Index = 3
        Me.mnuAdmin.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mItemSerialize, Me.mItemDeSerialize})
        Me.mnuAdmin.Text = "Admin"
        Me.mnuAdmin.Visible = False
        '
        'mItemSerialize
        '
        Me.mItemSerialize.Index = 0
        Me.mItemSerialize.Text = "Serialize"
        '
        'mItemDeSerialize
        '
        Me.mItemDeSerialize.Index = 1
        Me.mItemDeSerialize.Text = "DeSerialize"
        '
        'mnuContext
        '
        Me.mnuContext.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mItemNewChild, Me.mItemRename, Me.mItemDelete, Me.mItemExpandAll, Me.mItemCollapseAll})
        '
        'mItemNewChild
        '
        Me.mItemNewChild.Index = 0
        Me.mItemNewChild.Text = "New &Child..."
        '
        'mItemRename
        '
        Me.mItemRename.Index = 1
        Me.mItemRename.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.mItemRename.Text = "&Rename"
        '
        'mItemDelete
        '
        Me.mItemDelete.Index = 2
        Me.mItemDelete.Text = "&Delete"
        '
        'mItemExpandAll
        '
        Me.mItemExpandAll.Index = 3
        Me.mItemExpandAll.Text = "E&xpand All"
        '
        'mItemCollapseAll
        '
        Me.mItemCollapseAll.Index = 4
        Me.mItemCollapseAll.Text = "C&ollapse All"
        '
        'stbFilePath
        '
        Me.stbFilePath.Location = New System.Drawing.Point(0, 470)
        Me.stbFilePath.Name = "stbFilePath"
        Me.stbFilePath.Size = New System.Drawing.Size(636, 22)
        Me.stbFilePath.TabIndex = 10
        Me.stbFilePath.Text = "Ready"
        '
        'mnuDragDrop
        '
        Me.mnuDragDrop.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mItemAsChild, Me.mItemAsPrevSibling, Me.mItemAsNextSibling, Me.mnuCntxtMnuSprtr, Me.mItemCopyAsChild, Me.mItemCopyAbove, Me.mItemCopyBelow})
        '
        'mItemAsChild
        '
        Me.mItemAsChild.Index = 0
        Me.mItemAsChild.Text = "Move As Child"
        '
        'mItemAsPrevSibling
        '
        Me.mItemAsPrevSibling.Index = 1
        Me.mItemAsPrevSibling.Text = "Move Above"
        '
        'mItemAsNextSibling
        '
        Me.mItemAsNextSibling.Index = 2
        Me.mItemAsNextSibling.Text = "Move Below"
        '
        'mnuCntxtMnuSprtr
        '
        Me.mnuCntxtMnuSprtr.Index = 3
        Me.mnuCntxtMnuSprtr.Text = "-"
        '
        'mItemCopyAsChild
        '
        Me.mItemCopyAsChild.Index = 4
        Me.mItemCopyAsChild.Text = "Copy As Child"
        '
        'mItemCopyAbove
        '
        Me.mItemCopyAbove.Index = 5
        Me.mItemCopyAbove.Text = "Copy Above"
        '
        'mItemCopyBelow
        '
        Me.mItemCopyBelow.Index = 6
        Me.mItemCopyBelow.Text = "Copy Below"
        '
        'tabEditorPanes
        '
        Me.tabEditorPanes.Controls.Add(Me.tbpDesign)
        Me.tabEditorPanes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabEditorPanes.Location = New System.Drawing.Point(0, 0)
        Me.tabEditorPanes.Name = "tabEditorPanes"
        Me.tabEditorPanes.SelectedIndex = 0
        Me.tabEditorPanes.Size = New System.Drawing.Size(636, 470)
        Me.tabEditorPanes.TabIndex = 11
        Me.tabEditorPanes.Visible = False
        '
        'tbpDesign
        '
        Me.tbpDesign.Controls.Add(Me.mTreeView)
        Me.tbpDesign.Location = New System.Drawing.Point(4, 22)
        Me.tbpDesign.Name = "tbpDesign"
        Me.tbpDesign.Size = New System.Drawing.Size(628, 444)
        Me.tbpDesign.TabIndex = 0
        Me.tbpDesign.Text = "Design"
        '
        'mTreeView
        '
        Me.mTreeView.ContextMenu = Me.mnuContext
        Me.mTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mTreeView.Location = New System.Drawing.Point(0, 0)
        Me.mTreeView.Name = "mTreeView"
        Me.mTreeView.Size = New System.Drawing.Size(628, 444)
        Me.mTreeView.TabIndex = 0
        '
        'frmAdmin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(636, 492)
        Me.Controls.Add(Me.tabEditorPanes)
        Me.Controls.Add(Me.stbFilePath)
        Me.Controls.Add(Me.pnlLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mnuMain
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart Notes Editor"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.tabEditorPanes.ResumeLayout(False)
        Me.tbpDesign.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mCurrentNode As TreeNode
    Private mstrOpenedFileName As String
    Private mbIsDirty As Boolean = False
    Private mDeletedNode As TreeNode
    Private mDeletedNodesParent As TreeNode
    Private mSrcNode As TreeNode
    Private mDestNode As TreeNode

    'Global Variables to Export Smart Notes (SNF) to Excel (Xls)
    Private mColIndx As Integer = 0
    Private mRowIndx As Integer = 0
    Private mArrColIndx() As Integer = {0}
    Private mArrRowIndx() As Integer = {0}
    Private mArrNodeName() As String = {String.Empty}

    'Variables to Import Excel Files
    Private msSNFFilePath As String = Nothing
    Private mStrSNFXLSFilePath As String = Nothing
    Private mObjXlsApplic As Object         'Declare an Object as System Level Application 
    Private mObjXlsWorkBook As Object       'Declare an Object of Workbook, which is an Object of Application
    Private mObjXlsWorkSheet As Object      'Declare an Object of WorkSheet, which is an Object of WorkBook

    ''KP : For Early Binding CommentOut the Above 3 Line and UnComment Below 3 Lines
    'Private mObjXlsApplic As Microsoft.Office.Interop.Excel.Application     'Declare an Object as System Level Application 
    'Private mObjXlsWorkBook As Microsoft.Office.Interop.Excel.Workbook      'Declare an Object of Workbook, which is an Object of Application
    'Private mObjXlsWorkSheet As Microsoft.Office.Interop.Excel.Worksheet    'Declare an Object of WorkSheet, which is an Object of WorkBook

    Public Property SNFFolderPath() As String
        Get
            Return msSNFFilePath
        End Get
        Set(ByVal Value As String)
            Me.msSNFFilePath = Value
        End Set
    End Property

    Private msHelpFilePath As String = Nothing
    Public Property HelpFile() As String
        Get
            Return msHelpFilePath
        End Get
        Set(ByVal Value As String)
            Me.msHelpFilePath = Value
        End Set
    End Property

    Private Sub btnSystemDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystemDB.Click
        If DialogResult.OK = Me.ofdSNFFiles.ShowDialog(Me) Then
            Me.txtServerName.Text = Me.ofdSNFFiles.FileName
        End If
    End Sub

    Private Sub btnDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatabase.Click
        If DialogResult.OK = Me.ofdSNFFiles.ShowDialog(Me) Then
            Me.txtDatabaseName.Text = Me.ofdSNFFiles.FileName
        End If
    End Sub

    Private Sub cmbDatabaseType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDatabaseType.SelectedIndexChanged
        If Me.cmbDatabaseType.SelectedIndex = 1 Then
            Me.btnDatabase.Visible = True
            Me.btnSystemDB.Visible = True
            Me.lblServerName.Text = "System DB:"
        Else
            Me.btnDatabase.Visible = False
            Me.btnSystemDB.Visible = False
            Me.lblServerName.Text = "Server Name:"
        End If
    End Sub



    Private Sub mTreeView_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles mTreeView.DragDrop
        Dim pointDrop As Point
        Dim nodeDest As TreeNode
        Dim nodeSrc As TreeNode

        Try
            If sender Is Me.mTreeView Then
                pointDrop = Me.mTreeView.PointToClient(New Point(e.X, e.Y))
                If (e.Data.GetDataPresent(GetType(TreeNode))) Then
                    nodeSrc = DirectCast(e.Data.GetData(GetType(TreeNode)), TreeNode)
                    nodeDest = Me.mTreeView.GetNodeAt(pointDrop)
                    If Not (nodeSrc Is nodeDest) Then
                        DoNodeDrop(nodeSrc, nodeDest)
                    End If
                End If
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub mTreeView_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles mTreeView.DragEnter

        Try
            If (e.Data.GetDataPresent(GetType(TreeNode))) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub mTreeView_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles mTreeView.DragOver

        Try
            If (e.Data.GetDataPresent(GetType(TreeNode))) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If

            ' scroll when necessary
            If TypeOf sender Is TreeView Then
                Dim tv As TreeView = CType(sender, TreeView)
                Dim pt As Point = tv.PointToClient(New Point(e.X, e.Y))
                Dim delta As Integer = tv.Height - pt.Y

                If delta < tv.Height / 2 And delta > 0 Then
                    Dim tn As TreeNode = tv.GetNodeAt(pt.X, pt.Y)
                    If Not IsNothing(tn) Then
                        If Not (tn.NextVisibleNode Is Nothing) Then
                            tn.NextVisibleNode.EnsureVisible()
                        End If
                    End If
                End If

                If delta > tv.Height / 2 And delta < tv.Height Then
                    Dim tn As TreeNode = tv.GetNodeAt(pt.X, pt.Y)
                    If Not IsNothing(tn) Then
                        If Not (tn.PrevVisibleNode Is Nothing) Then
                            tn.PrevVisibleNode.EnsureVisible()
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub mTreeView_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles mTreeView.ItemDrag
        Dim node As TreeNode
        Try
            node = DirectCast(e.Item, TreeNode)
            Me.mTreeView.DoDragDrop(node, DragDropEffects.Move)
        Catch ex As Exception
            Debug.Assert(False, ex.Message)
        End Try
    End Sub

    Private Sub DoNodeDrop(ByVal nodeSrc As TreeNode, ByVal nodeDest As TreeNode)
        Try
            mSrcNode = nodeSrc
            mDestNode = nodeDest
            Me.mnuDragDrop.Show(Me.mTreeView, Me.tabEditorPanes.PointToClient(Me.Cursor.Position))

        Catch ex As Exception
            ' TODO: handle this
        End Try
    End Sub

    Private Sub mItemNewChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemNewChild.Click
        Try
            Dim newNode As TreeNode = Me.mCurrentNode.Nodes.Add("New Node")
            If Not Me.mCurrentNode.IsExpanded Then
                Me.mCurrentNode.Expand()
            End If
            Me.mbIsDirty = True
            newNode.BeginEdit()
        Catch ex As Exception
            ' just ignore
        End Try

    End Sub

    Private Sub mTreeView_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mTreeView.MouseUp
        If e.Button = MouseButtons.Right Then
            mCurrentNode = Me.mTreeView.GetNodeAt(New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub mItemExpandAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemExpandAll.Click
        Try

            ' begin the waiting
            Cursor.Current = Cursors.WaitCursor

            Me.mCurrentNode.ExpandAll()
        Catch ex As Exception
            ' just ignore
        Finally
            ' end the waiting
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub mItemCollapseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemCollapseAll.Click
        Try

            ' begin the waiting
            Cursor.Current = Cursors.WaitCursor

            Me.mCurrentNode.Collapse()
        Catch ex As Exception
            ' just ignore
        Finally
            ' end the waiting
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub mItemOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemOpen.Click
        Try
            If Me.mbIsDirty Then
                Dim ret As DialogResult = System.Windows.Forms.MessageBox.Show("Do you want to save changes to file?", "Smart Notes Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If ret = DialogResult.Yes Then
                    Me.mItemSave_Click(Nothing, Nothing)
                ElseIf ret = DialogResult.Cancel Then
                    Exit Sub
                ElseIf ret = DialogResult.No Then
                    Me.mbIsDirty = False
                End If
            End If
            If DialogResult.OK = Me.ofdSNFFiles.ShowDialog(Me) Then
                If Not Me.tabEditorPanes.Visible Then
                    Me.tabEditorPanes.Visible = True
                End If
                Me.mstrOpenedFileName = Me.ofdSNFFiles.FileName()
                Me.Text = "Smart Notes Editor - " & (New System.IO.FileInfo(Me.mstrOpenedFileName)).Name.ToString
                Dim tmp As Object = Me.Deserialize(Me.mstrOpenedFileName)
                If File.Exists(Me.mstrOpenedFileName & ".bak") Then
                    File.Delete(Me.mstrOpenedFileName & ".bak")
                End If
                File.Copy(Me.mstrOpenedFileName, Me.mstrOpenedFileName & ".bak")
                Dim root As TreeNode = DirectCast(tmp, TreeNode)
                root.Expand()
                Me.mTreeView.Nodes.Clear()
                Me.mTreeView.Nodes.Add(root)
                Me.tabEditorPanes.SelectedIndex = 0
                'Me.Text = "Smart Notes Editor" & " (" & Me.mstrOpenedFileName & ")"
                Me.stbFilePath.Text = Me.mstrOpenedFileName

                'Enable Menu Items
                Me.mItemSave.Enabled = True
                Me.mItemSaveAs.Enabled = True
                Me.mItemEditCollapseAll.Enabled = True
                Me.mItemEditDelete.Enabled = True
                Me.mItemEditExpandAll.Enabled = True
                Me.mItemEditNewChild.Enabled = True
                Me.mItemEditRename.Enabled = True
                Me.mItemClose.Enabled = True
                Me.mItemExport.Enabled = True
                Me.mTreeView.Select()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mItemSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemSave.Click
        Try
            Me.Serialize(Me.mstrOpenedFileName, Me.mTreeView.Nodes(0))
            Me.mbIsDirty = False
        Catch ex As Exception
        End Try

    End Sub

    Private Sub mItemSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemSaveAs.Click
        Try
            If DialogResult.OK = Me.sfdSmartNotesFile.ShowDialog(Me) Then
                Me.Serialize(Me.sfdSmartNotesFile.FileName(), Me.mTreeView.Nodes(0))
                Me.mstrOpenedFileName = Me.sfdSmartNotesFile.FileName()
                'Me.Text = "Smart Notes Editor" & " (" & Me.mstrOpenedFileName & ")"
                Me.Text = "Smart Notes Editor - " & (New System.IO.FileInfo(Me.mstrOpenedFileName)).Name.ToString
                Me.stbFilePath.Text = Me.mstrOpenedFileName
                Me.mbIsDirty = False
            End If
        Catch ex As Exception

        End Try

        'Enable Save Button 
        If Me.mItemSave.Enabled <> True Then
            Me.mItemSave.Enabled = True
        End If


    End Sub

    Private Sub mItemExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemExit.Click
        Me.Close()
    End Sub

    Private Sub mItemDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemDelete.Click
        Try
            If Not IsNothing(Me.mCurrentNode) Then
                Me.DeleteNode(Me.mCurrentNode)
            End If
        Catch ex As Exception
            ' just ignore
        End Try
    End Sub

    Private Sub DeleteNode(ByVal node As TreeNode)
        If Windows.Forms.MessageBox.Show("Deleting will remove the selected field and its children. Are you sure you want to delete?", "Smart Notes Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.mbIsDirty = True
            Me.mDeletedNode = node
            Me.mDeletedNodesParent = node.Parent
            node.Remove()
            Me.mItemUndoDelete.Enabled = True
        End If
    End Sub

    Private Function Deserialize(ByVal fileName As String) As Object
        Dim fileStr As Stream
        Dim fmtrBin As BinaryFormatter
        Dim obj As Object

        Try
            'create a filestream object
            fileStr = File.Open(fileName, FileMode.Open, FileAccess.Read)

            'create a formatter object based on given type 
            fmtrBin = New BinaryFormatter
            obj = fmtrBin.Deserialize(fileStr)

            'Deserialize the object from stream
            Return obj

        Catch ex As Exception
            Throw
        Finally
            If Not fileStr Is Nothing Then
                fileStr.Close()
            End If
        End Try
    End Function

    Private Sub Serialize(ByVal fileName As String, ByVal value As Object)
        Dim fileStr As Stream
        Dim fmtrBin As BinaryFormatter

        Try
            'create a filestream object
            fileStr = File.Open(fileName, FileMode.Create)

            fmtrBin = New BinaryFormatter
            fmtrBin.Serialize(fileStr, value)

        Catch ex As Exception
            Throw
        Finally
            If Not fileStr Is Nothing Then
                fileStr.Close()
            End If
        End Try

    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            If Me.mbIsDirty Then
                Dim ret As DialogResult = System.Windows.Forms.MessageBox.Show("Do you want to save changes to file?", "Smart Notes Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If ret = DialogResult.Yes Then
                    Me.mItemSave_Click(Nothing, Nothing)
                ElseIf ret = DialogResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub mMoveItemAsChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemAsChild.Click

        Try
            Me.mbIsDirty = True
            Me.mTreeView.Nodes.Remove(Me.mSrcNode)
            If Not (Me.mDestNode Is Nothing) Then
                'nodeDest.Nodes.Add(nodeSrc)        'add as last child node
                mDestNode.Nodes.Insert(0, mSrcNode)                             'add as first child node
            Else
                Me.mTreeView.Nodes.Add(mSrcNode)
            End If
            Me.mTreeView.SelectedNode = mSrcNode
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mCopyItemAsChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemCopyAsChild.Click

        Try
            Me.mbIsDirty = True

            Dim newNode As TreeNode = DirectCast(mSrcNode.Clone(), TreeNode)
            If Not (Me.mDestNode Is Nothing) Then
                mDestNode.Nodes.Add(newNode)                             'add as first child node
            Else
                Me.mTreeView.Nodes.Add(newNode)
            End If
            Me.mTreeView.SelectedNode = newNode
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mMoveItemAsNextSibling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemAsNextSibling.Click

        Try
            Me.mbIsDirty = True
            If Not (Me.mDestNode Is Nothing) Then
                'nodeDest.Nodes.Add(nodeSrc) 
                'add as last child node
                If (mDestNode Is Me.mTreeView.Nodes(0)) Then
                    MessageBox.Show("Cannot move to the root item.", "Smart Notes Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Me.mTreeView.Nodes.Remove(Me.mSrcNode)
                    mDestNode.Parent.Nodes.Insert(mDestNode.Index + 1, mSrcNode)
                    Me.mTreeView.SelectedNode = mSrcNode
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub mMoveItemAsPrevSibling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemAsPrevSibling.Click

        Try
            Me.mbIsDirty = True

            If Not (Me.mDestNode Is Nothing) Then
                If (mDestNode Is Me.mTreeView.Nodes(0)) Then
                    MessageBox.Show("Cannot move to the root item.", "Smart Notes Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Me.mTreeView.Nodes.Remove(Me.mSrcNode)
                    mDestNode.Parent.Nodes.Insert(mDestNode.Index, mSrcNode)
                    Me.mTreeView.SelectedNode = mSrcNode
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub mCopyItemAsNextSibling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemCopyBelow.Click

        Try
            Me.mbIsDirty = True
            Dim newNode As TreeNode = DirectCast(mSrcNode.Clone(), TreeNode)
            If Not (Me.mDestNode Is Nothing) Then
                If (mDestNode Is Me.mTreeView.Nodes(0)) Then
                    MessageBox.Show("Cannot copy to the root item.", "Smart Notes Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    mDestNode.Parent.Nodes.Add(newNode)
                    mDestNode.Parent.Nodes.Remove(newNode)
                    mDestNode.Parent.Nodes.Insert(mDestNode.Index + 1, newNode)
                    Me.mTreeView.SelectedNode = newNode
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub mCopyItemAsPrevSibling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemCopyAbove.Click

        Try
            Me.mbIsDirty = True
            Dim newNode As TreeNode = DirectCast(mSrcNode.Clone(), TreeNode)
            If Not (Me.mDestNode Is Nothing) Then
                If (mDestNode Is Me.mTreeView.Nodes(0)) Then
                    MessageBox.Show("Cannot copy to the root item.", "Smart Notes Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    mDestNode.Parent.Nodes.Add(newNode)
                    mDestNode.Parent.Nodes.Remove(newNode)
                    mDestNode.Parent.Nodes.Insert(mDestNode.Index, newNode)
                    Me.mTreeView.SelectedNode = newNode
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub mItemUndoDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemUndoDelete.Click
        Try
            If IsNothing(Me.mDeletedNodesParent) Then
                Me.mTreeView.Nodes.Add(Me.mDeletedNode)
            Else
                Me.mDeletedNodesParent.Nodes.Insert(Me.mDeletedNode.Index, Me.mDeletedNode)
            End If
            Me.mItemUndoDelete.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mItemEditNewChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemEditNewChild.Click

        Try
            Dim newNode As TreeNode = Me.mTreeView.SelectedNode.Nodes.Add("New Node")
            If Not Me.mTreeView.SelectedNode.IsExpanded Then
                Me.mTreeView.SelectedNode.Expand()
            End If
            Me.mbIsDirty = True
            newNode.BeginEdit()
        Catch ex As Exception
            ' just ignore
        End Try

    End Sub

    Private Sub mItemEditExpandAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemEditExpandAll.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Me.mTreeView.SelectedNode.ExpandAll()
        Catch ex As Exception
            ' just ignore
        Finally
            ' end the waiting
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub mItemEditCollapseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemEditCollapseAll.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Me.mTreeView.SelectedNode.Collapse()
        Catch ex As Exception
            ' just ignore
        Finally
            ' end the waiting
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub mItemEditDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemEditDelete.Click
        Try
            If Not IsNothing(Me.mTreeView.SelectedNode) Then
                Me.DeleteNode(Me.mTreeView.SelectedNode)
            End If
        Catch ex As Exception
            ' just ignore
        End Try
    End Sub




    Private Sub mItemRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemRename.Click
        Try
            Me.mTreeView.LabelEdit = True
            Me.mCurrentNode.BeginEdit()


        Catch ex As Exception
            Console.WriteLine(ex.Message.ToString)
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub mItemEditRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemEditRename.Click
        Try
            Me.mTreeView.LabelEdit = True
            Me.mTreeView.SelectedNode.BeginEdit()
        Catch ex As Exception
            Console.WriteLine(ex.Message.ToString())
        End Try
    End Sub


    Private Sub mTreeView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mTreeView.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Not Me.mTreeView.SelectedNode.Parent Is Nothing Then
                'delete only if it is not a Notes Root.
                Me.DeleteNode(Me.mTreeView.SelectedNode)
            End If
        End If
    End Sub

    '' Get the tree node under the mouse pointer and
    '' save it in the mySelectedNode variable. 
    'Private Sub treeView1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
    '    mySelectedNode = treeView1.GetNodeAt(e.X, e.Y)
    'End Sub

    Private Sub mTreeView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mTreeView.MouseDown
        If (e.Button = MouseButtons.Right) Then
            Me.mTreeView.SelectedNode = Me.mTreeView.GetNodeAt(e.X, e.Y)
        End If
    End Sub

    'Private Sub mTreeView_Click(sender As Object, e As EventArgs) Handles mTreeView.Click

    'End Sub

    Private Sub mTreeView_Click(sender As Object, e As System.EventArgs)
        If Not (Me.mTreeView.SelectedNode Is Nothing) And Not (Me.mTreeView.SelectedNode.Parent Is Nothing) Then
            'treeView1.SelectedNode = mySelectedNode
            mTreeView.LabelEdit = True
            If Not Me.mTreeView.SelectedNode.IsEditing Then
                Me.mTreeView.SelectedNode.BeginEdit()
            End If
        Else
            MessageBox.Show("No tree node selected or selected node is a root node." &
        Microsoft.VisualBasic.ControlChars.Cr &
        "Editing of root nodes is not allowed.", "Invalid selection")
        End If
    End Sub



    'Private Sub mTreeView_AfterLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles mTreeView.AfterLabelEdit
    '    Me.mbIsDirty = True
    '    If Not (e.Label Is Nothing) Then
    '        If e.Label.Length > 0 Then
    '            If e.Label.IndexOfAny(New Char() {"@"c, "."c, ","c, "!"c}) = -1 Then
    '                ' Stop editing without canceling the label change.
    '                e.Node.EndEdit(False)
    '            Else
    '                ' Cancel the label edit action, inform the user, and
    '                ' place the node in edit mode again. 
    '                e.CancelEdit = True
    '                MessageBox.Show("Invalid tree node label." &
    '          Microsoft.VisualBasic.ControlChars.Cr &
    '          "The invalid characters are: '@','.', ',', '!'",
    '          "Node Label Edit")
    '                e.Node.BeginEdit()
    '            End If
    '        Else
    '            ' Cancel the label edit action, inform the user, and
    '            ' place the node in edit mode again. 
    '            e.CancelEdit = True
    '            MessageBox.Show("Invalid tree node label." &
    '       Microsoft.VisualBasic.ControlChars.Cr &
    '       "The label cannot be blank", "Node Label Edit")
    '            e.Node.BeginEdit()
    '        End If
    '    End If
    'End Sub

    'Private Sub mTreeView_AfterLabelEdit(sender As Object, e As System.Windows.Forms.NodeLabelEditEventArgs)
    '    If Not (e.Label Is Nothing) Then
    '        If e.Label.Length > 0 Then
    '            If e.Label.IndexOfAny(New Char() {"@"c, "."c, ","c, "!"c}) = -1 Then
    '                ' Stop editing without canceling the label change.
    '                e.Node.EndEdit(False)
    '            Else
    '                ' Cancel the label edit action, inform the user, and
    '                ' place the node in edit mode again. 
    '                e.CancelEdit = True
    '                MessageBox.Show("Invalid tree node label." &
    '          Microsoft.VisualBasic.ControlChars.Cr &
    '          "The invalid characters are: '@','.', ',', '!'",
    '          "Node Label Edit")
    '                e.Node.BeginEdit()
    '            End If
    '        Else
    '            ' Cancel the label edit action, inform the user, and
    '            ' place the node in edit mode again. 
    '            e.CancelEdit = True
    '            MessageBox.Show("Invalid tree node label." &
    '       Microsoft.VisualBasic.ControlChars.Cr &
    '       "The label cannot be blank", "Node Label Edit")
    '            e.Node.BeginEdit()
    '        End If
    '    End If
    'End Sub
    '''KP : Until Here!!!























    '****** to connect to db and retrieve new data follow the steps**********************
    ' 1) Add reference to Common project
    ' 2) Make the me.pnlLogin visible
    ' 3) Make the Admin menu visible
    ' 4) Uncomment connect_click, MenuItem2_Click, MenuItem3_Click and GetTree functions
    '************************************************************************************

    'Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

    '    Dim oLdac As LDAC
    '    Dim dtShipped, dtBackEnd As DataTable
    '    Dim cur As Cursor = Cursor.Current
    '    Dim oLDACParams As LDACParameters

    '    Try
    '        Select Case Me.cmbDatabaseType.SelectedIndex
    '            Case 0 'sql
    '                oLDACParams = New LDACParameters(BackEndType.SQL, Me.txtDatabaseName.Text, _
    '                    Me.txtUserName.Text, Me.txtPassword.Text, Me.txtServerName.Text)
    '            Case 1 'access
    '                oLDACParams = New LDACParameters(BackEndType.MSAccess, Me.txtDatabaseName.Text, _
    '                    Me.txtUserName.Text, Me.txtPassword.Text, OleDbProvider.Jet40, Me.txtServerName.Text)
    '        End Select
    '        oLdac = LDAC.CreateLDAC(oLDACParams)

    '        Me.pnlLogin.Visible = False

    '        Me.mTreeView.Nodes.Add(GetTree(oLdac))
    '        If Not Me.mTreeView.Visible Then
    '            Me.mTreeView.Visible = True
    '        End If

    '    Catch ex As Exception
    '        Lumedx.Common.Exceptions.ExceptionHandler.Handle(ex)
    '    End Try
    'End Sub

    'Private dtSmartNotes As DataTable
    'Private Function GetTree(ByVal oLdac As LDAC) As TreeNode
    '    Try
    '        dtSmartNotes = oLdac.GetQueryResults("SELECT NoteText, Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9 FROM " & Me.txtTableName.Text)
    '        Dim level, current As TreeNode
    '        Dim root As New TreeNode("Notes Root")
    '        Dim bFound As Boolean
    '        Dim sColumnText As String
    '        For i As Integer = 0 To dtSmartNotes.Rows.Count - 1
    '            level = root
    '            For j As Integer = 1 To dtSmartNotes.Columns.Count - 1 ' ignore 0th column
    '                sColumnText = dtSmartNotes.Rows(i)(j).ToString().Trim()
    '                If sColumnText.Equals(String.Empty) Then
    '                    Exit For
    '                End If
    '                bFound = False
    '                current = Nothing
    '                For Each tmpNode As TreeNode In level.Nodes
    '                    If tmpNode.Text.Equals(sColumnText) Then
    '                        bFound = True
    '                        current = tmpNode
    '                    End If
    '                Next
    '                If Not bFound Then
    '                    current = New TreeNode(sColumnText)
    '                    If Not IsNothing(level) Then
    '                        level.Nodes.Add(current)
    '                    End If
    '                End If
    '                level = current
    '            Next
    '            level.Nodes.Add(New TreeNode(dtSmartNotes.Rows(i)("NoteText").ToString()))
    '        Next
    '        Return root
    '    Catch ex As Exception
    '        Lumedx.Common.Exceptions.ExceptionHandler.Handle(ex)
    '    End Try
    'End Function

    'Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
    '    BinFormatter.Serialize("c:\temp\smartnotes.bin", Me.mTreeView.Nodes(0))
    'End Sub

    'Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
    '    Try
    '        Dim tmp As Object = BinFormatter.Deserialize("c:\temp\smartnotes.bin")
    '        Dim root As TreeNode = DirectCast(tmp, TreeNode)
    '        Me.mTreeView.Nodes.Add(root)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabEditorPanes.SelectedIndexChanged
    '    If Me.tabEditorPanes.SelectedIndex = 1 Then
    '        Try
    '            Cursor.Current = Cursors.WaitCursor

    '            Dim iWidth As Integer = Me.PopupTree1.Initialize(Me.mTreeView.Nodes(0))

    '            ' adjust the width of popuptree control depending on the size of the 
    '            ' longest notes. Also move the notesgrid accordingly
    '            Dim iDiff As Integer = Me.PopupTree1.Width - iWidth
    '            If (iDiff > 0) Then
    '                Me.PopupTree1.Width -= (iDiff - 2)
    '            Else
    '                Me.PopupTree1.Width += (iDiff + 2)
    '            End If

    '        Catch ex As Exception

    '        Finally
    '            Cursor.Current = Cursors.Default
    '        End Try

    '    End If
    'End Sub

    'KP : Commented Out!
    'Private Sub mTreeView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mTreeView.MouseDown
    '    If (e.Button = MouseButtons.Right) Then
    '        Me.mTreeView.SelectedNode = Me.mTreeView.GetNodeAt(e.X, e.Y)
    '    End If
    'End Sub

    Private Sub ToggleDeleteOption()
        Try
            If Me.mTreeView.SelectedNode.Parent Is Nothing Then
                'we are at the Notes Root. disallow a delete
                Me.mItemDelete.Enabled = False
                Me.mItemEditDelete.Enabled = False
            Else
                'this is not the Notes Root. allow a delete.
                Me.mItemDelete.Enabled = True
                Me.mItemEditDelete.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub mItemHelpTopics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mItemHelpTopics.Click
        Try
            If Not Me.msHelpFilePath Is Nothing Then
                System.Windows.Forms.Help.ShowHelp(Me, Me.msHelpFilePath)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MenuItem6_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditMenu.Popup
        ToggleDeleteOption()
    End Sub

    Private Sub mnuContext_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuContext.Popup
        ToggleDeleteOption()
    End Sub

    '********** KP : Logic to Import Data from Excel Spread Sheet to an SNF File *************' 

    'Sub to Import Data from Excel Spread Sheet and Convert it into SNF Files
    Private Sub mItemImportExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mItemImportExcel.Click

        'Prompt for Save before Closing the SNF File
        Try
            If Me.mbIsDirty Then
                Dim ret As DialogResult = System.Windows.Forms.MessageBox.Show("Do you want to save changes to file?", "Smart Notes Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If ret = DialogResult.Yes Then
                    Me.mItemSaveAs_Click(Nothing, Nothing)
                    'strSNFFilePath = Me.mstrOpenedFileName
                ElseIf ret = DialogResult.Cancel Then
                    Exit Sub
                ElseIf ret = DialogResult.No Then
                    Me.mbIsDirty = False
                    Exit Try
                End If
            End If
        Catch ex As Exception
        End Try

        'Clear the Whole TreeView
        Me.mTreeView.Nodes.Clear()
        Me.stbFilePath.Text = String.Empty             'Update the Status Bar
        Me.mItemClose.Enabled = False
        Me.mItemSave.Enabled = False
        Me.mItemSaveAs.Enabled = False
        Me.mItemEditCollapseAll.Enabled = False
        Me.mItemEditDelete.Enabled = False
        Me.mItemEditExpandAll.Enabled = False
        Me.mItemEditNewChild.Enabled = False
        Me.mItemEditRename.Enabled = False
        Me.mItemExport.Enabled = False
        Me.mstrOpenedFileName = Nothing

        'Make the Cursor as Wait Machine
        Me.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        '"blnExitFlag" when set to True Exits Import Functionality
        Dim blnExitFlag As Boolean = False

        'Call the Function to Open Excel File
        blnExitFlag = OpenXlsFile()                      ' "OpenXlsFile()" prompts a File Dialogue Box to open Excel File

        'Exit Import SubRoutine if " blnExitFlag" is True
        If blnExitFlag = True Then
            Exit Sub
        End If


        'Call Function "ReadXlsSheet()" to Read the Xls Sheet and Return Data as an Array
        Dim arrXlsDataSheet(,) As String = ReadXlsSheet()

        'Exit Import SubRoutine if " blnExitFlag" is True
        If arrXlsDataSheet Is Nothing Then
            Exit Sub
        End If

        ''Logic To Convert Xls Data to SNF File
        Try

            ''Call the Sub-Routine "mSubDisplyXlsInSnf" to Create & Display Nodes in an SNF File From Xls Sheet
            DisplayXlsInSnf(arrXlsDataSheet)     'Parse the array "arrXlsDataSheet(,)" as an input to display SNF Nodes

            'Enable Menu Items if the SNF TreeView and Nodes are Visible
            Me.mstrOpenedFileName = Nothing
            Me.mCurrentNode = Me.mTreeView.Nodes(0)
            Me.stbFilePath.Text = Me.mstrOpenedFileName             'Update the Status Bar
            Me.mItemSave.Enabled = False
            Me.mItemSaveAs.Enabled = True
            Me.mItemEditCollapseAll.Enabled = True
            Me.mItemEditDelete.Enabled = True
            Me.mItemEditExpandAll.Enabled = True
            Me.mItemEditNewChild.Enabled = True
            Me.mItemEditRename.Enabled = True
            Me.mnuEditMenu.Enabled = True
            Me.mItemClose.Enabled = True
            Me.mItemExport.Enabled = True
            Me.mTreeView.Select()
            Me.mCurrentNode = Me.mTreeView.Nodes(0)

            'Set the Condition of the Existing SNF File as Not Saved?
            Me.mbIsDirty = True

        Catch ex As Exception

        End Try

    End Sub

    'Function to Prompt for Opening Excel Files
    Private Function OpenXlsFile() As Boolean

        'Make the Cursor as Wait Machine
        Me.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'Declare Boolean Variable
        Dim blnExitFlag As Boolean = False      ' "blnExitFlag" when set to True Exits Import Functionality

        'Try to Open Xls File
        Try

            'If the User has Clicked Cancel, Abort Import Operation Else Open the File to Read
            If Me.ofdXlsFiles.ShowDialog() = DialogResult.Cancel Then

                'Set and Return the "blnExitFlag" to True & Exit Function
                blnExitFlag = True
                Return (blnExitFlag)

            Else

                'Open a File Dialog Box to Filter Only "Xls" Files
                Me.mstrOpenedFileName = Me.ofdXlsFiles.FileName()

                'Create a BackUp of the Existing File
                If File.Exists(Me.mstrOpenedFileName & ".snfbak") Then
                    File.Delete(Me.mstrOpenedFileName & ".snfbak")
                End If

                'If the Excel Sheet Exists Create a Copy and Get User Input
                If File.Exists(Me.mstrOpenedFileName) Then

                    'Create a Back-up Copy of the Existing Excel File 
                    File.Copy(Me.mstrOpenedFileName, Me.mstrOpenedFileName & ".snfbak")

                    'Initialize the Local variable to hold the Initially Opened File name and Prevent Over-Writing any SNF File
                    Me.mstrOpenedFileName = mstrOpenedFileName & ".snfbak"

                Else
                    'Excel File Does not Exist
                    MessageBox.Show("Excel File either does NOT exist (or) can NOT be Opened !", "Error", _
                                     MessageBoxButtons.OK, MessageBoxIcon.Error)

                    'Set and Return the "blnExitFlag" to True & Exit Function
                    blnExitFlag = True
                    Return (blnExitFlag)

                End If

            End If

        Catch ex As Exception

            'Set and Return the "blnExitFlag" to True & Exit Function
            blnExitFlag = True
            Return (blnExitFlag)

        End Try
    End Function

    'Function to Read the Xls Sheet and Return Data Read as an Array
    Private Function ReadXlsSheet() As System.Array

        'Declare & Initialize Variables to Prompt for User Input to Get Xls Data Sheet Parameters
        Dim instFrmXlsParam As New frmXlsParam      'Local Instance of Class "frmXlsParam()"
        Dim xlsRow As Integer                    'Variable to get Value of Xls Data Sheet Row
        Dim xlsCol As Integer                    'Variable to get Value of Xls Data Sheet Column 
        Dim strXlsSprdSht As String                 'Variable to get the Name of Xls Spread Sheet

        'Make the Cursor as Wait Machine
        Me.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'Try to Open Excel Application, WorkBook and then WorkSheet
        Try

            'Early Binding to open an XLS file which is present on Local Harddisk
            mObjXlsApplic = CreateObject("Excel.Application")
            mObjXlsApplic.Visible = False    'KP : Assign "True" to Make the Worksheet Visible

            'Conditional Logic to check if Excel Application, WorkBook and WorkSheet Can be Opened
            If mObjXlsApplic Is Nothing Then
                'Excel Application Cannot be Started - Exit Sub
                MessageBox.Show("Excel Application can NOT be Opened !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            Else
                'Open User Chosen Excel WorkBook 
                mObjXlsWorkBook = mObjXlsApplic.Workbooks.Open(mstrOpenedFileName)

                'Check If the Excel WorkBook Can be Opened or Not
                If mObjXlsWorkBook Is Nothing Then
                    'Excel Work Book Cannot be Opened - Exit Sub
                    MessageBox.Show("Excel Work Book either Does NOT exist or Can NOT be Opened !", "Error", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                Else

                    'Try Opening the User Specified Excel WorkBook
                    Try

                        'Read all the WorkSheets available inside the WorkBook
                        Dim xlsShtCount As Integer        'Declare a Variable to Read the Number of Excel WorkSheets in the WorkBook

                        'Loop to Read Number of WorkSheets in Excel WorkBook
                        For xlsShtCount = 1 To mObjXlsWorkBook.Worksheets.Count
                            'Populate the Combo-Box With the Names of the Excel WorkSheets
                            instFrmXlsParam.cboXlsSprdSheet.Items.Add(mObjXlsWorkBook.Worksheets(xlsShtCount).Name.ToString)
                        Next

                        'Prompt for User Input to Get Xls Data Sheet Parameters
                        instFrmXlsParam.cboXlsSprdSheet.Text = instFrmXlsParam.cboXlsSprdSheet.Items.Item(0)
                        instFrmXlsParam.ShowDialog()            'Prompt for User Input

                        'Initialize Variables after Prompting for User Input to Get Xls Data Sheet Parameters
                        xlsRow = instFrmXlsParam.nudXlsRowDim.Value   'Get Value of Xls Data Sheet Row
                        xlsCol = instFrmXlsParam.nudXlsColDim.Value   'Get Value of Xls Data Sheet Column 
                        strXlsSprdSht = CStr(instFrmXlsParam.cboXlsSprdSheet.SelectedItem) 'Get Name of Xls Spread Sheet

                        'User Specified Excel WorkSheet Exists and Can be Opened inside the Excel WorkBook
                        mObjXlsWorkSheet = mObjXlsWorkBook.Worksheets(strXlsSprdSht)


                    Catch ex As Exception
                        'Exception has Occured!
                        MessageBox.Show("Excel Work Sheet either Does NOT Exist or Can NOT be Opened !", "Error", _
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Exit Function
                    End Try


                End If

            End If

        Catch ex As Exception

            'Cannot Open the Excel Application
            MessageBox.Show("Excel Application can NOT be Opened !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


        'Declare and Intialize an Array to Hold the Data Read from the Xls Sheet
        Dim xlsRowIndex As Integer = 1
        Dim xlsColIndex As Integer = 1
        Dim arrXlsDataSheet(xlsRow, xlsCol) As String

        'Read Data Column-Wise from Xls Spread Sheet (ReDim on 2D Arrays does not Work in VB.NET !)
        For xlsColIndex = 1 To xlsCol
            For xlsRowIndex = 1 To xlsRow

                'Read the Individual Xls Cell Data into an Array
                arrXlsDataSheet(xlsRowIndex - 1, xlsColIndex - 1) = CType(mObjXlsWorkSheet.Cells(xlsRowIndex, xlsColIndex).Value, String)

            Next
        Next

        'Close Xls Sheet and Excel Application
        mObjXlsWorkBook.Close()
        mObjXlsApplic.Quit()
        mObjXlsApplic = Nothing
        mObjXlsWorkBook = Nothing

        'Return the array "arrXlsDataSheet(xlsRow, xlsCol)"
        Return (arrXlsDataSheet)

    End Function

    'Sub-Routine to Create & Display Nodes in an SNF File From Xls Sheet
    Private Sub DisplayXlsInSnf(ByVal arrXlsDataSheet(,) As String)

        'Make the Cursor as Wait Machine
        Me.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'Make the TabControl Visible
        If Not Me.tabEditorPanes.Visible Then
            Me.tabEditorPanes.Visible = True
        End If

        'Intialize the Tree View
        Dim strRootNodeName As String = "Notes Root"
        Me.mTreeView.Nodes.Add(strRootNodeName)
        Me.mCurrentNode = Me.mTreeView.Nodes(0)

        'Declare and Initialize Variables to Process XLSheet Data 
        Dim rowCntr As Integer           'Row Counter
        Dim colCntr As Integer           'Column Counter
        Dim numOfRows As Integer         'Number of Rows
        Dim numOfCols As Integer         'Number of Columns
        Dim ttlElmnts As Integer         'Total Number of Elements in the Array 
        Dim strNodeName As String           'Node Name
        Dim arrIndxRowIndx() As Integer         'Represents - Array of Row Indices of the SNF Nodes
        Dim arrIndxColIndx() As Integer         'Represents - Array of Column Indices of the SNF Nodes
        Dim arrStrCurrentNode() As String      'Represents - Array of Names of the SNF Nodes
        Dim nodeCount As Integer = 0     'Count Variable to Determine Number of Non-Empty Nodes

        'Get the Size of the Array (Number of Columns & Rows)
        ttlElmnts = arrXlsDataSheet.Length           'Total Number of Elements in the 2D Array "arrXlsDataSheet"
        numOfCols = arrXlsDataSheet.GetLength(1)     'Get the Length of Array in 1D, which indicates the Number of Columns
        numOfRows = ttlElmnts / numOfCols

        'Read the Data in the Array "arrXlsDataSheet" both Coulmn-wise and Row-wise
        For rowCntr = 1 To numOfRows
            For colCntr = 1 To numOfCols

                'Assign the Value for the "Node Name"
                strNodeName = arrXlsDataSheet(rowCntr - 1, colCntr - 1)

                'Read the Value of the Cell, If Not Empty, into an Array 
                If strNodeName <> Nothing Then

                    'ReDimension the Arrays to Read the Row and Column Indices and the Value of the Non-Empty Xls Cell
                    ReDim Preserve arrIndxRowIndx(nodeCount)
                    ReDim Preserve arrIndxColIndx(nodeCount)
                    ReDim Preserve arrStrCurrentNode(nodeCount)

                    'Read the Cell Parameters/Coordinates of the Current Non-Empty Node into Respective Arrays
                    arrIndxRowIndx(nodeCount) = rowCntr
                    arrIndxColIndx(nodeCount) = colCntr
                    arrStrCurrentNode(nodeCount) = strNodeName

                    'Increment the Count of Non-Empty Node
                    nodeCount += 1

                End If
            Next
        Next

        'Compute the Max Value of Column Where the Last Non-Empty Cell is Present
        Dim colMax As Integer = 0
        For cntr As Integer = 0 To (arrIndxColIndx.Length - 1)
            'Get Value of the Column in the Column Array
            If arrIndxColIndx(cntr) > colMax Then
                colMax = arrIndxColIndx(cntr)
            End If
        Next

        'Declare Variables to Add New Nodes to SNF Files
        Dim nodeCntr As Integer = 0      'Declare Node Counter Required In For Loop
        Dim arrTrnParents() As TreeNode     'Declare an Array of TreeNode Objects
        Dim trnTempNode As TreeNode        'Declare a Temporary Node instance of TreeNode Class

        'Initialize Variables 
        mCurrentNode = Me.mCurrentNode                  'Initialize the Current Node to the Notes Root
        arrTrnParents = New TreeNode(colMax) {}      'Initialize a Parents Array Containing the Number of Coulmns Read from the 
        arrTrnParents(0) = mCurrentNode

        'Loop to Add Tree Nodes to the Notes Root
        For nodeCntr = 0 To (nodeCount - 1)

            'Get the String Value of the Xls Cell and Create a New Tree Node
            trnTempNode = New TreeNode(arrStrCurrentNode(nodeCntr))

            'Assign the Value of the Temporary Node to the Parent Array
            arrTrnParents(arrIndxColIndx(nodeCntr)) = trnTempNode

            'Add the Node to the Tree Node
            arrTrnParents(arrIndxColIndx(nodeCntr) - 1).Nodes.Add(trnTempNode)

        Next

        'Expand the Current Node 
        If Not Me.mCurrentNode.IsExpanded Then
            Me.mCurrentNode.ExpandAll()
        End If

    End Sub

    'Sub to Create a New SNF File
    Private Sub mItemNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mItemNew.Click

        'Call the Menu Item Close Before Importing
        Me.mItemClose_Click(Nothing, Nothing)

        'Try to Create a Tree View and Node
        Try
            'Intialize the Tree View
            Dim strRootNodeName As String = "Notes Root"
            Me.mTreeView.Nodes.Add(strRootNodeName)

            'Make the TabControl Visible
            If Not Me.tabEditorPanes.Visible Then
                Me.tabEditorPanes.Visible = True
            End If

            'Enable Menu Items if the SNF TreeView and Nodes are Visible
            Me.mItemSave.Enabled = False
            Me.mItemSaveAs.Enabled = True
            Me.mItemEditCollapseAll.Enabled = True
            Me.mItemEditDelete.Enabled = True
            Me.mItemEditExpandAll.Enabled = True
            Me.mItemEditNewChild.Enabled = True
            Me.mItemEditRename.Enabled = True
            Me.mTreeView.Select()
            Me.mItemClose.Enabled = True
            Me.mItemExport.Enabled = True
            Me.stbFilePath.Text = String.Empty   'Me.mstrOpenedFileName - 'Update the Status Bar
            Me.Text = "Smart Notes Editor - New.snf*"

            'Set the Condition of the Existing SNF File as Not Saved?
            Me.mbIsDirty = True

        Catch ex As Exception

        End Try
    End Sub

    'Sub to Close an SNF File
    Private Sub mItemClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mItemClose.Click

        'Declare Path Variable
        Dim strXlsFilePath As String


        'Prompt for Save before Closing the SNF File
        Try
            If Me.mbIsDirty Then
                Dim ret As DialogResult = System.Windows.Forms.MessageBox.Show("Do you want to save changes to file?", "Smart Notes Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If ret = DialogResult.Yes Then
                    'Me.mItemSave_Click(Nothing, Nothing)
                    Me.mItemSaveAs_Click(Nothing, Nothing)
                    strXlsFilePath = Me.mstrOpenedFileName
                ElseIf ret = DialogResult.Cancel Then
                    Exit Sub
                ElseIf ret = DialogResult.No Then
                    Me.mbIsDirty = False
                    Exit Try
                End If
            End If
        Catch ex As Exception

            'Log the Exception
            'Lumedx.Common.Exceptions.ExceptionHandler.Handle(ex, Common.Exceptions.Action.Log)

        End Try

        'Clear the Whole TreeView
        Me.mTreeView.Nodes.Clear()
        Me.stbFilePath.Text = String.Empty       'Update the Status Bar
        Me.mItemClose.Enabled = False
        Me.mItemSave.Enabled = False
        Me.mItemSaveAs.Enabled = False
        Me.mItemExport.Enabled = False
        Me.mItemEditCollapseAll.Enabled = False
        Me.mItemEditDelete.Enabled = False
        Me.mItemEditExpandAll.Enabled = False
        Me.mItemEditNewChild.Enabled = False
        Me.mItemEditRename.Enabled = False
        Me.Text = "Smart Notes Editor"


    End Sub

    'Sub to Export SNF Data to Excel Sheet
    Private Sub mItemExport2Excel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mItemExport2Excel.Click

        'Make the Cursor as Wait Machine
        Me.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'Re-Initialize Variables
        mColIndx = 0
        mRowIndx = 0
        ReDim mArrColIndx(0)
        ReDim mArrRowIndx(0)
        ReDim mArrNodeName(0)

        'Try-Catch Block to open SNF File
        Try

            'Declare & Initialize Varible to read the Nodes Vertically in a Column
            Dim i As Integer = 0
            Dim tndCrrntNode As TreeNode

            'Conditional Statement to read nodes only if the TreeView is not Empty
            If (mTreeView.TopNode.Nodes.Count) <> 0 Then
                Do

                    'Increment Column an Row Indices
                    mColIndx = 1
                    mRowIndx += 1

                    'Read the Value of the Current Node from Tree View and Assign to the Current Node
                    tndCrrntNode = mTreeView.TopNode.Nodes(i)   ''Variable to read Nodes Laterally

                    'Assign Corresponding Values for the Members of Arrays
                    mArrColIndx(mArrColIndx.Length - 1) = mColIndx
                    mArrRowIndx(mArrRowIndx.Length - 1) = mRowIndx
                    mArrNodeName(mArrNodeName.Length - 1) = tndCrrntNode.Text

                    'ReDim and Preserve the Arrays
                    ReDim Preserve mArrColIndx(mArrColIndx.Length + 1)
                    ReDim Preserve mArrRowIndx(mArrRowIndx.Length + 1)
                    ReDim Preserve mArrNodeName(mArrNodeName.Length + 1)

                    ''Recursively Call the Function "ReadLtrlNodes()" to read the Nodes Laterally
                    ReadLtrlNodes(tndCrrntNode)      ''Recursive Function Call for reading Nodes Laterlly

                    'Increment the Vertical Counter
                    i = i + 1
                    If i >= (mTreeView.TopNode.Nodes.Count) Then
                        Exit Do
                    End If
                Loop
            End If

            'Write SNF Data to Excel File
            WriteSNF2Xls()

        Catch ex As Exception

        End Try

    End Sub

    'Public Function ReadLtrlNodes(ByVal mRowIndx As Integer, ByVal mColIndx As Integer, ByVal tndCrrntNode As TreeNode)
    Public Function ReadLtrlNodes(ByVal tndCrrntNode As TreeNode)

        'Make the Cursor as Wait Machine
        Me.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'Increment the Column Value
        mColIndx += 1

        'Varible to read the Nodes Laterally
        Dim j As Integer = 0
        If (tndCrrntNode.Nodes.Count) <> 0 Then
            Do

                'Increment the Row Index
                mRowIndx += 1

                ''Assign Corresponding Values for the Members of Arrays
                mArrColIndx(mArrColIndx.Length - 1) = mColIndx
                mArrRowIndx(mArrRowIndx.Length - 1) = mRowIndx
                mArrNodeName(mArrNodeName.Length - 1) = tndCrrntNode.Nodes(j).Text

                'ReDim and Preserve the Arrays
                ReDim Preserve mArrColIndx(mArrColIndx.Length + 1)
                ReDim Preserve mArrRowIndx(mArrRowIndx.Length + 1)
                ReDim Preserve mArrNodeName(mArrNodeName.Length + 1)

                ''Recursively Call the Function "ReadLtrlNodes()"
                ReadLtrlNodes(tndCrrntNode.Nodes(j))

                'Increment the Lateral Counter
                j += 1
                If j >= (tndCrrntNode.Nodes.Count) Then
                    Exit Do
                End If
            Loop
        End If

        'Decrement Column Value
        mColIndx -= 1

    End Function

    'Write SNF Nodes to Xls
    Public Sub WriteSNF2Xls()

        'Make the Cursor as Wait Machine
        Me.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'Try-Catch Block to open an Xls File
        Try

            'Open Xls Application
            mObjXlsApplic = CreateObject("Excel.Application")
            mObjXlsApplic.Visible = False                        'KP : Assign "True" to Make the Worksheet Visible
            mObjXlsWorkBook = Me.mObjXlsApplic.Workbooks.Add    'Add a Workbook to the Xls Application
            mObjXlsWorkSheet = Me.mObjXlsWorkBook.Sheets.Item(1)   'Activate the "Sheet1" of the Xls WorkBook to Insert Test to the Cells

            'Conditional Logic to check if Excel Application, WorkBook and WorkSheet Can be Opened
            If mObjXlsApplic Is Nothing Then
                'Excel Application Cannot be Started - Exit Sub
                MessageBox.Show("Error in Opening Excel Application !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                'Logic to open Excel WorkBook
                If mObjXlsWorkBook Is Nothing Then
                    'Excel WorkBook Cannot be Opened - Exit Sub
                    MessageBox.Show("Error in Opening Excel Work Book !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    'Logic to open Excel WorkSheet
                    If mObjXlsWorkSheet Is Nothing Then
                        'Excel WorkSheet Cannot be Opened - Exit Sub
                        MessageBox.Show("Error in Opening Excel Work Sheet !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else

                        'Loop to Write the Xls Sheet with the Nodes
                        For i As Integer = 0 To (mArrNodeName.Length - 1)

                            If mArrNodeName(i) <> Nothing Then
                                mObjXlsWorkSheet.Cells(Me.mArrRowIndx(i), Me.mArrColIndx(i)) = mArrNodeName(i)
                            End If

                        Next

                    End If

                End If

            End If

        Catch ex As Exception


            mObjXlsWorkBook.Close()
            mObjXlsApplic.Quit()

            'Cannot Open the Excel Application
            MessageBox.Show("Error in Opening Excel Application !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try


        ''Format Xls Sheet & ReInitialize the Xls Application to Nothing
        Me.mObjXlsWorkSheet.Columns.AutoFit()
        Me.mObjXlsApplic.Visible = True
        Me.mObjXlsWorkSheet = Nothing
        Me.mObjXlsWorkBook = Nothing
        Me.mObjXlsApplic = Nothing

    End Sub


End Class

