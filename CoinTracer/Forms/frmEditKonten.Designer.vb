﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditKonten
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditKonten))
        Dim BezeichnungLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim BeschreibungLabel As System.Windows.Forms.Label
        Dim SortIDLabel As System.Windows.Forms.Label
        Dim FixLabel As System.Windows.Forms.Label
        Dim IstFiatLabel As System.Windows.Forms.Label
        Dim EigenLabel As System.Windows.Forms.Label
        Dim IstGebuehrLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim GebuehrKontoIDLabel As System.Windows.Forms.Label
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.pnlEditTrades = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KontenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.KontenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.IstFiatCheckBox = New System.Windows.Forms.CheckBox()
        Me.EigenCheckBox = New System.Windows.Forms.CheckBox()
        Me.IstGebuehrCheckBox = New System.Windows.Forms.CheckBox()
        Me.GebuehrKontoIDTextBox = New System.Windows.Forms.TextBox()
        Me.KontenTableAdapter = New CoinTracer.CoinTracerDataSetTableAdapters.KontenTableAdapter()
        Me.TableAdapterManager = New CoinTracer.CoinTracerDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        BezeichnungLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        BeschreibungLabel = New System.Windows.Forms.Label()
        SortIDLabel = New System.Windows.Forms.Label()
        FixLabel = New System.Windows.Forms.Label()
        IstFiatLabel = New System.Windows.Forms.Label()
        EigenLabel = New System.Windows.Forms.Label()
        IstGebuehrLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        GebuehrKontoIDLabel = New System.Windows.Forms.Label()
        Me.pnlEditTrades.SuspendLayout()
        CType(Me.KontenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KontenBindingNavigator.SuspendLayout()
        CType(Me.KontenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoinTracerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'FixLabel
        '
        resources.ApplyResources(FixLabel, "FixLabel")
        FixLabel.Name = "FixLabel"
        '
        'IstFiatLabel
        '
        resources.ApplyResources(IstFiatLabel, "IstFiatLabel")
        IstFiatLabel.Name = "IstFiatLabel"
        '
        'EigenLabel
        '
        resources.ApplyResources(EigenLabel, "EigenLabel")
        EigenLabel.Name = "EigenLabel"
        '
        'IstGebuehrLabel
        '
        resources.ApplyResources(IstGebuehrLabel, "IstGebuehrLabel")
        IstGebuehrLabel.Name = "IstGebuehrLabel"
        '
        'Label1
        '
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        '
        'GebuehrKontoIDLabel
        '
        resources.ApplyResources(GebuehrKontoIDLabel, "GebuehrKontoIDLabel")
        GebuehrKontoIDLabel.Name = "GebuehrKontoIDLabel"
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
        resources.ApplyResources(Me.pnlEditTrades, "pnlEditTrades")
        Me.pnlEditTrades.Controls.Add(Me.Label3)
        Me.pnlEditTrades.Controls.Add(Me.Label4)
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
        'KontenBindingNavigator
        '
        resources.ApplyResources(Me.KontenBindingNavigator, "KontenBindingNavigator")
        Me.KontenBindingNavigator.AddNewItem = Nothing
        Me.KontenBindingNavigator.BindingSource = Me.KontenBindingSource
        Me.KontenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KontenBindingNavigator.CountItemFormat = "of {0}"
        Me.KontenBindingNavigator.DeleteItem = Nothing
        Me.KontenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.KontenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KontenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KontenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KontenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KontenBindingNavigator.Name = "KontenBindingNavigator"
        Me.KontenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        '
        'KontenBindingSource
        '
        Me.KontenBindingSource.DataMember = "Konten"
        Me.KontenBindingSource.DataSource = Me.CoinTracerDataSet
        '
        'CoinTracerDataSet
        '
        Me.CoinTracerDataSet.DataSetName = "CoinTracerDataSet"
        Me.CoinTracerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        resources.ApplyResources(Me.BindingNavigatorCountItem, "BindingNavigatorCountItem")
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        '
        'BindingNavigatorMoveFirstItem
        '
        resources.ApplyResources(Me.BindingNavigatorMoveFirstItem, "BindingNavigatorMoveFirstItem")
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        '
        'BindingNavigatorMovePreviousItem
        '
        resources.ApplyResources(Me.BindingNavigatorMovePreviousItem, "BindingNavigatorMovePreviousItem")
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        '
        'BindingNavigatorSeparator
        '
        resources.ApplyResources(Me.BindingNavigatorSeparator, "BindingNavigatorSeparator")
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        '
        'BindingNavigatorPositionItem
        '
        resources.ApplyResources(Me.BindingNavigatorPositionItem, "BindingNavigatorPositionItem")
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        '
        'BindingNavigatorSeparator1
        '
        resources.ApplyResources(Me.BindingNavigatorSeparator1, "BindingNavigatorSeparator1")
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        '
        'BindingNavigatorMoveNextItem
        '
        resources.ApplyResources(Me.BindingNavigatorMoveNextItem, "BindingNavigatorMoveNextItem")
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        '
        'BindingNavigatorMoveLastItem
        '
        resources.ApplyResources(Me.BindingNavigatorMoveLastItem, "BindingNavigatorMoveLastItem")
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        '
        'BindingNavigatorSeparator2
        '
        resources.ApplyResources(Me.BindingNavigatorSeparator2, "BindingNavigatorSeparator2")
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        '
        'BindingNavigatorAddNewItem
        '
        resources.ApplyResources(Me.BindingNavigatorAddNewItem, "BindingNavigatorAddNewItem")
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        '
        'BindingNavigatorDeleteItem
        '
        resources.ApplyResources(Me.BindingNavigatorDeleteItem, "BindingNavigatorDeleteItem")
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        '
        'IDTextBox
        '
        resources.ApplyResources(Me.IDTextBox, "IDTextBox")
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontenBindingSource, "ID", True))
        Me.IDTextBox.Name = "IDTextBox"
        '
        'BezeichnungTextBox
        '
        resources.ApplyResources(Me.BezeichnungTextBox, "BezeichnungTextBox")
        Me.BezeichnungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontenBindingSource, "Bezeichnung", True))
        Me.BezeichnungTextBox.Name = "BezeichnungTextBox"
        '
        'CodeTextBox
        '
        resources.ApplyResources(Me.CodeTextBox, "CodeTextBox")
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontenBindingSource, "Code", True))
        Me.CodeTextBox.Name = "CodeTextBox"
        '
        'BeschreibungTextBox
        '
        resources.ApplyResources(Me.BeschreibungTextBox, "BeschreibungTextBox")
        Me.BeschreibungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontenBindingSource, "Beschreibung", True))
        Me.BeschreibungTextBox.Name = "BeschreibungTextBox"
        '
        'SortIDTextBox
        '
        resources.ApplyResources(Me.SortIDTextBox, "SortIDTextBox")
        Me.SortIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontenBindingSource, "SortID", True))
        Me.SortIDTextBox.Name = "SortIDTextBox"
        '
        'FixCheckBox
        '
        resources.ApplyResources(Me.FixCheckBox, "FixCheckBox")
        Me.FixCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.KontenBindingSource, "Fix", True))
        Me.FixCheckBox.Name = "FixCheckBox"
        Me.FixCheckBox.UseVisualStyleBackColor = True
        '
        'IstFiatCheckBox
        '
        resources.ApplyResources(Me.IstFiatCheckBox, "IstFiatCheckBox")
        Me.IstFiatCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.KontenBindingSource, "IstFiat", True))
        Me.IstFiatCheckBox.Name = "IstFiatCheckBox"
        Me.IstFiatCheckBox.UseVisualStyleBackColor = True
        '
        'EigenCheckBox
        '
        resources.ApplyResources(Me.EigenCheckBox, "EigenCheckBox")
        Me.EigenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.KontenBindingSource, "Eigen", True))
        Me.EigenCheckBox.Name = "EigenCheckBox"
        Me.EigenCheckBox.UseVisualStyleBackColor = True
        '
        'IstGebuehrCheckBox
        '
        resources.ApplyResources(Me.IstGebuehrCheckBox, "IstGebuehrCheckBox")
        Me.IstGebuehrCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.KontenBindingSource, "IstGebuehr", True))
        Me.IstGebuehrCheckBox.Name = "IstGebuehrCheckBox"
        Me.IstGebuehrCheckBox.UseVisualStyleBackColor = True
        '
        'GebuehrKontoIDTextBox
        '
        resources.ApplyResources(Me.GebuehrKontoIDTextBox, "GebuehrKontoIDTextBox")
        Me.GebuehrKontoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontenBindingSource, "GebuehrKontoID", True))
        Me.GebuehrKontoIDTextBox.Name = "GebuehrKontoIDTextBox"
        '
        'KontenTableAdapter
        '
        Me.KontenTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.KontenTableAdapter = Me.KontenTableAdapter
        Me.TableAdapterManager.KurseTableAdapter = Nothing
        Me.TableAdapterManager.PlattformenTableAdapter = Nothing
        Me.TableAdapterManager.SzenarienTableAdapter = Nothing
        Me.TableAdapterManager.TradesTableAdapter = Nothing
        Me.TableAdapterManager.TradesWerteTableAdapter = Nothing
        Me.TableAdapterManager.TradeTypenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CoinTracer.CoinTracerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmEditKonten
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.Controls.Add(GebuehrKontoIDLabel)
        Me.Controls.Add(Me.GebuehrKontoIDTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(IstGebuehrLabel)
        Me.Controls.Add(Me.IstGebuehrCheckBox)
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
        Me.Controls.Add(IstFiatLabel)
        Me.Controls.Add(Me.IstFiatCheckBox)
        Me.Controls.Add(EigenLabel)
        Me.Controls.Add(Me.EigenCheckBox)
        Me.Controls.Add(Me.KontenBindingNavigator)
        Me.Controls.Add(Me.pnlEditTrades)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditKonten"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.pnlEditTrades.ResumeLayout(False)
        Me.pnlEditTrades.PerformLayout()
        CType(Me.KontenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KontenBindingNavigator.ResumeLayout(False)
        Me.KontenBindingNavigator.PerformLayout()
        CType(Me.KontenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoinTracerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents pnlEditTrades As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CoinTracerDataSet As CoinTracer.CoinTracerDataSet
    Friend WithEvents KontenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KontenTableAdapter As CoinTracer.CoinTracerDataSetTableAdapters.KontenTableAdapter
    Friend WithEvents TableAdapterManager As CoinTracer.CoinTracerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KontenBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents IstFiatCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EigenCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IstGebuehrCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GebuehrKontoIDTextBox As System.Windows.Forms.TextBox
End Class
