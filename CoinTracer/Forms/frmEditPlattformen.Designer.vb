﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditPlattformen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditPlattformen))
        Dim BezeichnungLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim BeschreibungLabel As System.Windows.Forms.Label
        Dim SortIDLabel As System.Windows.Forms.Label
        Dim FixLabel As System.Windows.Forms.Label
        Dim BoerseLabel As System.Windows.Forms.Label
        Dim EigenLabel As System.Windows.Forms.Label
        Dim IstDownLabel As System.Windows.Forms.Label
        Dim ImportZielLabel As System.Windows.Forms.Label
        Dim ImportEindeutigLabel As System.Windows.Forms.Label
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.pnlEditTrades = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PlattformenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.PlattformenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoinTracerDataSet = New CoinTracer.CoinTracerDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.BezeichnungTextBox = New System.Windows.Forms.TextBox()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.BeschreibungTextBox = New System.Windows.Forms.TextBox()
        Me.SortIDTextBox = New System.Windows.Forms.TextBox()
        Me.FixCheckBox = New System.Windows.Forms.CheckBox()
        Me.BoerseCheckBox = New System.Windows.Forms.CheckBox()
        Me.EigenCheckBox = New System.Windows.Forms.CheckBox()
        Me.IstDownCheckBox = New System.Windows.Forms.CheckBox()
        Me.DownSeitDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DownSeitLabel = New System.Windows.Forms.Label()
        Me.pnlDownSeit = New System.Windows.Forms.Panel()
        Me.ImportZielCheckBox = New System.Windows.Forms.CheckBox()
        Me.PlattformenTableAdapter = New CoinTracer.CoinTracerDataSetTableAdapters.PlattformenTableAdapter()
        Me.TableAdapterManager = New CoinTracer.CoinTracerDataSetTableAdapters.TableAdapterManager()
        Me.EnhancedToolTip1 = New CoinTracer.EnhancedToolTip()
        Me.ImportEindeutigCheckBox = New System.Windows.Forms.CheckBox()
        IDLabel = New System.Windows.Forms.Label()
        BezeichnungLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        BeschreibungLabel = New System.Windows.Forms.Label()
        SortIDLabel = New System.Windows.Forms.Label()
        FixLabel = New System.Windows.Forms.Label()
        BoerseLabel = New System.Windows.Forms.Label()
        EigenLabel = New System.Windows.Forms.Label()
        IstDownLabel = New System.Windows.Forms.Label()
        ImportZielLabel = New System.Windows.Forms.Label()
        ImportEindeutigLabel = New System.Windows.Forms.Label()
        Me.pnlEditTrades.SuspendLayout()
        CType(Me.PlattformenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlattformenBindingNavigator.SuspendLayout()
        CType(Me.PlattformenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoinTracerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDownSeit.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        resources.ApplyResources(IDLabel, "IDLabel")
        IDLabel.Name = "IDLabel"
        '
        'BezeichnungLabel
        '
        resources.ApplyResources(BezeichnungLabel, "BezeichnungLabel")
        BezeichnungLabel.Name = "BezeichnungLabel"
        '
        'CodeLabel
        '
        resources.ApplyResources(CodeLabel, "CodeLabel")
        CodeLabel.Name = "CodeLabel"
        '
        'BeschreibungLabel
        '
        resources.ApplyResources(BeschreibungLabel, "BeschreibungLabel")
        BeschreibungLabel.Name = "BeschreibungLabel"
        '
        'SortIDLabel
        '
        resources.ApplyResources(SortIDLabel, "SortIDLabel")
        SortIDLabel.Name = "SortIDLabel"
        Me.EnhancedToolTip1.SetToolTip(SortIDLabel, resources.GetString("SortIDLabel.ToolTip"))
        '
        'FixLabel
        '
        resources.ApplyResources(FixLabel, "FixLabel")
        FixLabel.Name = "FixLabel"
        Me.EnhancedToolTip1.SetToolTip(FixLabel, resources.GetString("FixLabel.ToolTip"))
        '
        'BoerseLabel
        '
        resources.ApplyResources(BoerseLabel, "BoerseLabel")
        BoerseLabel.Name = "BoerseLabel"
        Me.EnhancedToolTip1.SetToolTip(BoerseLabel, resources.GetString("BoerseLabel.ToolTip"))
        '
        'EigenLabel
        '
        resources.ApplyResources(EigenLabel, "EigenLabel")
        EigenLabel.Name = "EigenLabel"
        Me.EnhancedToolTip1.SetToolTip(EigenLabel, resources.GetString("EigenLabel.ToolTip"))
        '
        'IstDownLabel
        '
        resources.ApplyResources(IstDownLabel, "IstDownLabel")
        IstDownLabel.Name = "IstDownLabel"
        Me.EnhancedToolTip1.SetToolTip(IstDownLabel, resources.GetString("IstDownLabel.ToolTip"))
        '
        'ImportZielLabel
        '
        resources.ApplyResources(ImportZielLabel, "ImportZielLabel")
        ImportZielLabel.Name = "ImportZielLabel"
        Me.EnhancedToolTip1.SetToolTip(ImportZielLabel, resources.GetString("ImportZielLabel.ToolTip"))
        '
        'ImportEindeutigLabel
        '
        resources.ApplyResources(ImportEindeutigLabel, "ImportEindeutigLabel")
        ImportEindeutigLabel.Name = "ImportEindeutigLabel"
        Me.EnhancedToolTip1.SetToolTip(ImportEindeutigLabel, resources.GetString("ImportEindeutigLabel.ToolTip"))
        '
        'cmdOK
        '
        resources.ApplyResources(Me.cmdOK, "cmdOK")
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'pnlEditTrades
        '
        Me.pnlEditTrades.Controls.Add(Me.Label3)
        Me.pnlEditTrades.Controls.Add(Me.Label4)
        resources.ApplyResources(Me.pnlEditTrades, "pnlEditTrades")
        Me.pnlEditTrades.Name = "pnlEditTrades"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'PlattformenBindingNavigator
        '
        Me.PlattformenBindingNavigator.AddNewItem = Nothing
        Me.PlattformenBindingNavigator.BindingSource = Me.PlattformenBindingSource
        Me.PlattformenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlattformenBindingNavigator.CountItemFormat = "of {0}"
        Me.PlattformenBindingNavigator.DeleteItem = Nothing
        Me.PlattformenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        resources.ApplyResources(Me.PlattformenBindingNavigator, "PlattformenBindingNavigator")
        Me.PlattformenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlattformenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlattformenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlattformenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlattformenBindingNavigator.Name = "PlattformenBindingNavigator"
        Me.PlattformenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        '
        'PlattformenBindingSource
        '
        Me.PlattformenBindingSource.DataMember = "Plattformen"
        Me.PlattformenBindingSource.DataSource = Me.CoinTracerDataSet
        '
        'CoinTracerDataSet
        '
        Me.CoinTracerDataSet.DataSetName = "CoinTracerDataSet"
        Me.CoinTracerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        resources.ApplyResources(Me.BindingNavigatorCountItem, "BindingNavigatorCountItem")
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorMoveFirstItem, "BindingNavigatorMoveFirstItem")
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorMovePreviousItem, "BindingNavigatorMovePreviousItem")
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        resources.ApplyResources(Me.BindingNavigatorSeparator, "BindingNavigatorSeparator")
        '
        'BindingNavigatorPositionItem
        '
        resources.ApplyResources(Me.BindingNavigatorPositionItem, "BindingNavigatorPositionItem")
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        resources.ApplyResources(Me.BindingNavigatorSeparator1, "BindingNavigatorSeparator1")
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorMoveNextItem, "BindingNavigatorMoveNextItem")
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorMoveLastItem, "BindingNavigatorMoveLastItem")
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        resources.ApplyResources(Me.BindingNavigatorSeparator2, "BindingNavigatorSeparator2")
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorAddNewItem, "BindingNavigatorAddNewItem")
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorDeleteItem, "BindingNavigatorDeleteItem")
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlattformenBindingSource, "ID", True))
        resources.ApplyResources(Me.IDTextBox, "IDTextBox")
        Me.IDTextBox.Name = "IDTextBox"
        Me.EnhancedToolTip1.SetToolTip(Me.IDTextBox, resources.GetString("IDTextBox.ToolTip"))
        '
        'BezeichnungTextBox
        '
        resources.ApplyResources(Me.BezeichnungTextBox, "BezeichnungTextBox")
        Me.BezeichnungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlattformenBindingSource, "Bezeichnung", True))
        Me.BezeichnungTextBox.Name = "BezeichnungTextBox"
        '
        'CodeTextBox
        '
        resources.ApplyResources(Me.CodeTextBox, "CodeTextBox")
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlattformenBindingSource, "Code", True))
        Me.CodeTextBox.Name = "CodeTextBox"
        '
        'BeschreibungTextBox
        '
        resources.ApplyResources(Me.BeschreibungTextBox, "BeschreibungTextBox")
        Me.BeschreibungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlattformenBindingSource, "Beschreibung", True))
        Me.BeschreibungTextBox.Name = "BeschreibungTextBox"
        '
        'SortIDTextBox
        '
        Me.SortIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlattformenBindingSource, "SortID", True))
        resources.ApplyResources(Me.SortIDTextBox, "SortIDTextBox")
        Me.SortIDTextBox.Name = "SortIDTextBox"
        Me.EnhancedToolTip1.SetToolTip(Me.SortIDTextBox, resources.GetString("SortIDTextBox.ToolTip"))
        '
        'FixCheckBox
        '
        Me.FixCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlattformenBindingSource, "Fix", True))
        resources.ApplyResources(Me.FixCheckBox, "FixCheckBox")
        Me.FixCheckBox.Name = "FixCheckBox"
        Me.EnhancedToolTip1.SetToolTip(Me.FixCheckBox, resources.GetString("FixCheckBox.ToolTip"))
        Me.FixCheckBox.UseVisualStyleBackColor = True
        '
        'BoerseCheckBox
        '
        Me.BoerseCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlattformenBindingSource, "Boerse", True))
        resources.ApplyResources(Me.BoerseCheckBox, "BoerseCheckBox")
        Me.BoerseCheckBox.Name = "BoerseCheckBox"
        Me.EnhancedToolTip1.SetToolTip(Me.BoerseCheckBox, resources.GetString("BoerseCheckBox.ToolTip"))
        Me.BoerseCheckBox.UseVisualStyleBackColor = True
        '
        'EigenCheckBox
        '
        Me.EigenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlattformenBindingSource, "Eigen", True))
        resources.ApplyResources(Me.EigenCheckBox, "EigenCheckBox")
        Me.EigenCheckBox.Name = "EigenCheckBox"
        Me.EnhancedToolTip1.SetToolTip(Me.EigenCheckBox, resources.GetString("EigenCheckBox.ToolTip"))
        Me.EigenCheckBox.UseVisualStyleBackColor = True
        '
        'IstDownCheckBox
        '
        Me.IstDownCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlattformenBindingSource, "IstDown", True))
        resources.ApplyResources(Me.IstDownCheckBox, "IstDownCheckBox")
        Me.IstDownCheckBox.Name = "IstDownCheckBox"
        Me.EnhancedToolTip1.SetToolTip(Me.IstDownCheckBox, resources.GetString("IstDownCheckBox.ToolTip"))
        Me.IstDownCheckBox.UseVisualStyleBackColor = True
        '
        'DownSeitDateTimePicker
        '
        resources.ApplyResources(Me.DownSeitDateTimePicker, "DownSeitDateTimePicker")
        Me.DownSeitDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PlattformenBindingSource, "DownSeit", True))
        Me.DownSeitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DownSeitDateTimePicker.Name = "DownSeitDateTimePicker"
        '
        'DownSeitLabel
        '
        resources.ApplyResources(Me.DownSeitLabel, "DownSeitLabel")
        Me.DownSeitLabel.Name = "DownSeitLabel"
        '
        'pnlDownSeit
        '
        Me.pnlDownSeit.Controls.Add(Me.DownSeitLabel)
        Me.pnlDownSeit.Controls.Add(Me.DownSeitDateTimePicker)
        Me.pnlDownSeit.Controls.Add(Me.IstDownCheckBox)
        resources.ApplyResources(Me.pnlDownSeit, "pnlDownSeit")
        Me.pnlDownSeit.Name = "pnlDownSeit"
        '
        'ImportZielCheckBox
        '
        Me.ImportZielCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlattformenBindingSource, "ImportZiel", True))
        resources.ApplyResources(Me.ImportZielCheckBox, "ImportZielCheckBox")
        Me.ImportZielCheckBox.Name = "ImportZielCheckBox"
        Me.EnhancedToolTip1.SetToolTip(Me.ImportZielCheckBox, resources.GetString("ImportZielCheckBox.ToolTip"))
        Me.ImportZielCheckBox.UseVisualStyleBackColor = True
        '
        'PlattformenTableAdapter
        '
        Me.PlattformenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._VersionsTableAdapter = Nothing
        Me.TableAdapterManager.ApiDatenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BestaendeTableAdapter = Nothing
        Me.TableAdapterManager.ImporteTableAdapter = Nothing
        Me.TableAdapterManager.KalkulationenTableAdapter = Nothing
        Me.TableAdapterManager.KonfigurationTableAdapter = Nothing
        Me.TableAdapterManager.KontenTableAdapter = Nothing
        Me.TableAdapterManager.KurseTableAdapter = Nothing
        Me.TableAdapterManager.PlattformenTableAdapter = Me.PlattformenTableAdapter
        Me.TableAdapterManager.SzenarienTableAdapter = Nothing
        Me.TableAdapterManager.TradesTableAdapter = Nothing
        Me.TableAdapterManager.TradesWerteTableAdapter = Nothing
        Me.TableAdapterManager.TradeTxTableAdapter = Nothing
        Me.TableAdapterManager.TradeTypenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CoinTracer.CoinTracerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ImportEindeutigCheckBox
        '
        Me.ImportEindeutigCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlattformenBindingSource, "ImportEindeutig", True))
        resources.ApplyResources(Me.ImportEindeutigCheckBox, "ImportEindeutigCheckBox")
        Me.ImportEindeutigCheckBox.Name = "ImportEindeutigCheckBox"
        Me.EnhancedToolTip1.SetToolTip(Me.ImportEindeutigCheckBox, resources.GetString("ImportEindeutigCheckBox.ToolTip"))
        Me.ImportEindeutigCheckBox.UseVisualStyleBackColor = True
        '
        'frmEditPlattformen
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.Controls.Add(ImportEindeutigLabel)
        Me.Controls.Add(Me.ImportEindeutigCheckBox)
        Me.Controls.Add(Me.ImportZielCheckBox)
        Me.Controls.Add(ImportZielLabel)
        Me.Controls.Add(Me.pnlDownSeit)
        Me.Controls.Add(IstDownLabel)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(BezeichnungLabel)
        Me.Controls.Add(Me.BezeichnungTextBox)
        Me.Controls.Add(CodeLabel)
        Me.Controls.Add(Me.CodeTextBox)
        Me.Controls.Add(BeschreibungLabel)
        Me.Controls.Add(Me.BeschreibungTextBox)
        Me.Controls.Add(SortIDLabel)
        Me.Controls.Add(Me.SortIDTextBox)
        Me.Controls.Add(FixLabel)
        Me.Controls.Add(Me.FixCheckBox)
        Me.Controls.Add(BoerseLabel)
        Me.Controls.Add(Me.BoerseCheckBox)
        Me.Controls.Add(EigenLabel)
        Me.Controls.Add(Me.EigenCheckBox)
        Me.Controls.Add(Me.PlattformenBindingNavigator)
        Me.Controls.Add(Me.pnlEditTrades)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditPlattformen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.pnlEditTrades.ResumeLayout(False)
        Me.pnlEditTrades.PerformLayout()
        CType(Me.PlattformenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlattformenBindingNavigator.ResumeLayout(False)
        Me.PlattformenBindingNavigator.PerformLayout()
        CType(Me.PlattformenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoinTracerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDownSeit.ResumeLayout(False)
        Me.pnlDownSeit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents pnlEditTrades As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CoinTracerDataSet As CoinTracer.CoinTracerDataSet
    Friend WithEvents PlattformenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlattformenTableAdapter As CoinTracer.CoinTracerDataSetTableAdapters.PlattformenTableAdapter
    Friend WithEvents TableAdapterManager As CoinTracer.CoinTracerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlattformenBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BezeichnungTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BeschreibungTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SortIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FixCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BoerseCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EigenCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IstDownCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DownSeitDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DownSeitLabel As System.Windows.Forms.Label
    Friend WithEvents pnlDownSeit As System.Windows.Forms.Panel
    Friend WithEvents ImportZielCheckBox As CheckBox
    Friend WithEvents EnhancedToolTip1 As EnhancedToolTip
    Friend WithEvents ImportEindeutigCheckBox As CheckBox
End Class
