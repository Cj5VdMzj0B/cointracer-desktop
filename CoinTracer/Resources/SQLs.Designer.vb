﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    '-Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    'Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    'mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    '''<summary>
    '''  Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class SQLs
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("CoinTracer.SQLs", GetType(SQLs).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        '''  Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die alter table [Szenarien] add column [Coins4Coins] BOOLEAN DEFAULT &apos;0&apos; ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_01() As String
            Get
                Return ResourceManager.GetString("db_v39_01", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE TABLE IF NOT EXISTS [Bestaende] (
        '''[ID] INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL,
        '''[TradeID] INTEGER  NULL,
        '''[Zeitpunkt] TIMESTAMP  NULL,
        '''[PlattformID] INTEGER  NULL,
        '''[Bestand] NUMERIC  NULL, 
        '''[KontoID] INTEGER  NULL,
        '''[BestandEUR] NUMERIC  NULL); ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_02() As String
            Get
                Return ResourceManager.GetString("db_v39_02", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE INDEX IF NOT EXISTS [IDX_Bestaende_ZeitpunktKontoPlattform] ON [Bestaende] (
        '''[Zeitpunkt]  ASC,
        '''[KontoID]  ASC,
        '''[PlattformID]  ASC); ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_03() As String
            Get
                Return ResourceManager.GetString("db_v39_03", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die DROP TABLE IF EXISTS [ApiDaten_tmp] ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_04() As String
            Get
                Return ResourceManager.GetString("db_v39_04", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE TABLE [ApiDaten_tmp] (
        '''[ID] INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL,
        '''[PlattformID] INTEGER  NULL,
        '''[Zeitpunkt] TIMESTAMP  NOT NULL,
        '''[Bezeichnung] VARCHAR(150)  NULL,
        '''[ApiKey] VARCHAR(250)  NULL,
        '''[ApiSecret] VARCHAR(350)  NULL,
        '''[Salt] VARCHAR(250)  NULL,
        '''[Aktiv] BOOLEAN DEFAULT &apos;1&apos;,
        '''[LastImportTimestamp] INTEGER DEFAULT &apos;0&apos; NULL, 
        '''[ExtendedInfo] VARCHAR(2048) DEFAULT &apos;&apos; NULL) ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_05() As String
            Get
                Return ResourceManager.GetString("db_v39_05", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die INSERT INTO [ApiDaten_tmp] SELECT ID, PlattformID, Zeitpunkt, Bezeichnung, ApiKey, ApiSecret, Salt, Aktiv, LastImportTimestamp, ExtendedInfo FROM [ApiDaten] ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_06() As String
            Get
                Return ResourceManager.GetString("db_v39_06", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die DROP TABLE [ApiDaten] ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_07() As String
            Get
                Return ResourceManager.GetString("db_v39_07", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die ALTER TABLE [ApiDaten_tmp] RENAME TO [ApiDaten] ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_08() As String
            Get
                Return ResourceManager.GetString("db_v39_08", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die ALTER TABLE [Trades] ADD COLUMN [InZeitpunkt] TIMESTAMP ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_09() As String
            Get
                Return ResourceManager.GetString("db_v39_09", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die UPDATE Trades SET InZeitpunkt = Date(Zeitpunkt) ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_10() As String
            Get
                Return ResourceManager.GetString("db_v39_10", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE TABLE IF NOT EXISTS [Out2In] (
        '''[ID] INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL,
        '''[SzenarioID] INTEGER NOT NULL,
        '''[KalkulationID] INTEGER NOT NULL,
        '''[MainOutTradeID] INTEGER NOT NULL,
        '''[OutTradeID] INTEGER NOT NULL,
        '''[InTradeID] INTEGER NOT NULL,
        '''[InZeitpunkt] TIMESTAMP NULL,
        '''[MainBetrag] NUMERIC DEFAULT &apos;0&apos; NULL,
        '''[Betrag] NUMERIC DEFAULT &apos;0&apos; NULL,
        '''[WertEUR] NUMERIC NULL,
        '''[Level] INTEGER NOT NULL DEFAULT &apos;0&apos;,
        '''[IstFiat] BOOLEAN DEFAULT &apos;0&apos;, 
        '''[IstTransfer] BOOLEAN DEFAULT &apos;0&apos;, 
        '''[IstLangzeit] B [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_11() As String
            Get
                Return ResourceManager.GetString("db_v39_11", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE INDEX IF NOT EXISTS [IDX_Out2In_Kalkulation] ON [Out2In]([KalkulationID]  ASC) ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_12() As String
            Get
                Return ResourceManager.GetString("db_v39_12", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE INDEX IF NOT EXISTS [IDX_Out2In_Szenario_MainOutTrade] ON [Out2In]([SzenarioID] ASC, [MainOutTradeID] ASC, [Level] ASC) ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_13() As String
            Get
                Return ResourceManager.GetString("db_v39_13", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE INDEX IF NOT EXISTS [IDX_Out2In_Szenario_InTrade] ON [Out2In]([SzenarioID] ASC, [InTradeID] ASC, [Level] ASC) ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_14() As String
            Get
                Return ResourceManager.GetString("db_v39_14", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die DROP VIEW IF EXISTS [VW_InCoins] ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_15() As String
            Get
                Return ResourceManager.GetString("db_v39_15", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE VIEW IF NOT EXISTS [VW_InCoins] AS 
        '''select
        '''	t.ID TradeID,
        '''	t.BetragNachGebuehr Betrag,
        '''	t.ZielKontoID KontoID,
        '''	case 
        '''		when t.TradeTypID = 5 and (pt.Eigen and ps.Eigen) then
        '''			case
        '''				when ps.Boerse and pt.Boerse then 37
        '''				when ps.Boerse and not pt.Boerse then 101
        '''				else 69
        '''			end
        '''		when t.TradeTypID in (3, 4) and not ks.IstFiat and not kt.IstFiat then 19
        '''		else t.TradeTypID
        '''	end InTypID,
        '''	t.ZielPlattformID PlattformID,
        '''	t.ZeitpunktZiel Zeitpunkt,
        '''	t.InZeitpunkt InZeitpunkt,
        ''' [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_16() As String
            Get
                Return ResourceManager.GetString("db_v39_16", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die DROP VIEW IF EXISTS [VW_OutCoins] ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_17() As String
            Get
                Return ResourceManager.GetString("db_v39_17", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE VIEW IF NOT EXISTS [VW_OutCoins] AS 
        '''select
        '''	t.ID TradeID,
        '''	t.QuellBetrag Betrag,
        '''	t.QuellKontoID KontoID,
        '''	case
        '''		when t.TradeTypID = 5 and (pt.Eigen and ps.Eigen) then
        '''			case
        '''				when ps.Boerse and pt.Boerse then 37
        '''				when ps.Boerse and not pt.Boerse then 101
        '''				else 69
        '''			end
        '''		when t.TradeTypID in (3, 4) and not ks.IstFiat and not kt.IstFiat then 19
        '''		else t.TradeTypID
        '''	end OutTypID,
        '''	t.QuellPlattformID PlattformID,
        '''	t.Zeitpunkt
        '''from Trades as t
        '''inner join Konten as ks on ks [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_18() As String
            Get
                Return ResourceManager.GetString("db_v39_18", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die delete from TradeTypen where ID in (19, 37, 69, 101) ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_19() As String
            Get
                Return ResourceManager.GetString("db_v39_19", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die insert into TradeTypen(ID, Bezeichnung, Code, Beschreibung, SortID) values
        '''	(19, &apos;Kauf Coins für Coins&apos;,&apos;BUYC4C&apos;, &apos;Kauf von Coins mit Coins als Zahlmittel&apos;, 19),
        '''	(37, &apos;Transfer Börse zu Börse&apos;,&apos;TRNSP2P&apos;, &apos;Transfer von Coins zwischen zwei Börsen&apos;, 37),
        '''	(69, &apos;Transfer Wallet zu Börse&apos;,&apos;TRNSW2P&apos;, &apos;Transfer von Coins von einem Wallet auf eine Börse&apos;, 69),
        '''	(101, &apos;Transfer Börse zu Wallet&apos;,&apos;TRNSP2W&apos;, &apos;Transfer von Coins von einer Börse auf eine Wallet&apos;, 101) ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_20() As String
            Get
                Return ResourceManager.GetString("db_v39_20", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die DROP VIEW IF EXISTS [VW_Gainings] ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_21() As String
            Get
                Return ResourceManager.GetString("db_v39_21", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE VIEW IF NOT EXISTS [VW_Gainings] AS
        '''select
        '''t.Zeitpunkt Zeitpunkt,
        '''case t.TradeTypID
        '''	when 3 then case when qk.IstFiat then 0 else case when sz.Coins4Coins then round(t.WertEUR * coalesce(sum(o2i.MainBetrag), 0) / t.BetragNachGebuehr - coalesce(sum(o2i.WertEUR), 0), 2) else round(0, 2) end end
        '''	when 4 then case when zk.IstFiat then round(t.WertEUR * coalesce(sum(o2i.MainBetrag), 0) / t.QuellBetrag - coalesce(sum(o2i.WertEUR), 0), 2) else case when sz.Coins4Coins then round(t.WertEUR * coalesce(su [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_22() As String
            Get
                Return ResourceManager.GetString("db_v39_22", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die DROP VIEW IF EXISTS [VW_GainingsReport2] ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_23() As String
            Get
                Return ResourceManager.GetString("db_v39_23", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE VIEW [VW_GainingsReport2] AS 
        '''select 
        '''t.ID Vorgang,
        '''t.Zeitpunkt Zeitpunkt,
        '''tt.Bezeichnung Art,
        '''case t.TradeTypID
        '''	when 5 then qp.Bezeichnung || &apos; → &apos; || zp.Bezeichnung
        '''	else qp.Bezeichnung 
        '''end Plattform,
        '''case t.TradeTypID
        '''	when 3 then zk.Bezeichnung
        '''	else qk.Bezeichnung 
        '''end [Coin-Art],
        '''case t.TradeTypID
        '''	when 3 then round(t.BetragNachGebuehr, 8)
        '''	else round(t.QuellBetrag, 8) 
        '''end [Coin-Menge],
        '''case t.TradeTypID
        '''	when 3 then qk.Bezeichnung
        '''	when 5 then &apos;-&apos;
        '''	else zk.Bezeichnung 
        ''' [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_24() As String
            Get
                Return ResourceManager.GetString("db_v39_24", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die ALTER TABLE [ApiDaten] ADD COLUMN [CallDelay] INTEGER NOT NULL DEFAULT 0 ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_25() As String
            Get
                Return ResourceManager.GetString("db_v39_25", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die UPDATE [ApiDaten] SET [CallDelay] = 2000 WHERE PlattformID = 207 ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_26() As String
            Get
                Return ResourceManager.GetString("db_v39_26", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die UPDATE [ApiDaten] SET [CallDelay] = 11000 WHERE PlattformID = 206 ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property db_v39_27() As String
            Get
                Return ResourceManager.GetString("db_v39_27", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
