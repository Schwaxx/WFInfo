﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("44")>  _
        Public Property HKey1() As Integer
            Get
                Return CType(Me("HKey1"),Integer)
            End Get
            Set
                Me("HKey1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Print Screen")>  _
        Public Property HKey1Text() As String
            Get
                Return CType(Me("HKey1Text"),String)
            End Get
            Set
                Me("HKey1Text") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("220")>  _
        Public Property HKey2() As Integer
            Get
                Return CType(Me("HKey2"),Integer)
            End Get
            Set
                Me("HKey2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\")>  _
        Public Property HKey2Text() As String
            Get
                Return CType(Me("HKey2Text"),String)
            End Get
            Set
                Me("HKey2Text") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Animate() As Boolean
            Get
                Return CType(Me("Animate"),Boolean)
            End Get
            Set
                Me("Animate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property PassiveChecks() As Boolean
            Get
                Return CType(Me("PassiveChecks"),Boolean)
            End Get
            Set
                Me("PassiveChecks") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Debug() As Boolean
            Get
                Return CType(Me("Debug"),Boolean)
            End Get
            Set
                Me("Debug") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Alloy Plate,Draco(Ceres) / Malva(Venus)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Argon Crystal,Void Survival / Defence"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"C"& _ 
            "ircuits,Draco(Ceres) / Malva(Venus)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Control Module,Void Survival / Defence"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Cry"& _ 
            "otic,Hieracon(Pluto)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Ferrite,Tikal(Earth)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Gallium,Assur(Uranus) / War(Mars)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"M"& _ 
            "orphics,Wahiba(Mars) / Tolstoj(Mercury)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Nano Spores,ODD / Akkad(Eris)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Neural S"& _ 
            "ensors,Themisto or IO(Jupiter)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Neurodes,Tikal(Earth) / Zabala(Eris)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Orokin Cel"& _ 
            "l,ODS / Draco(Ceres)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Oxium,IO(Jupiter) / Baal(Europa)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Plastids,Ophelia(Uranus)"& _ 
            " / Zabala(Eris)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Polymer Bundle,Ophelia or Assur(Uranus)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Rubedo,Void Survival /"& _ 
            " Defence"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Salvage,Cameria(Jupiter) / Wahiba(Mars)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Tellurium,Ophelia or Caelus(U"& _ 
            "ranus)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Nyth,Plains of Eidolon(Earth)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Sentirum,Plains of Eidolon(Earth)")>  _
        Public Property Resources() As String
            Get
                Return CType(Me("Resources"),String)
            End Get
            Set
                Me("Resources") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("6/1/2017|0")>  _
        Public Property PPMPD() As String
            Get
                Return CType(Me("PPMPD"),String)
            End Get
            Set
                Me("PPMPD") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("6/1/2017|0")>  _
        Public Property ChecksPD() As String
            Get
                Return CType(Me("ChecksPD"),String)
            End Get
            Set
                Me("ChecksPD") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("6.0.0b")>  _
        Public Property Version() As String
            Get
                Return CType(Me("Version"),String)
            End Get
            Set
                Me("Version") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property CheckUpdates() As Boolean
            Get
                Return CType(Me("CheckUpdates"),Boolean)
            End Get
            Set
                Me("CheckUpdates") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("500")>  _
        Public Property StartX() As Integer
            Get
                Return CType(Me("StartX"),Integer)
            End Get
            Set
                Me("StartX") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property StartY() As String
            Get
                Return CType(Me("StartY"),String)
            End Get
            Set
                Me("StartY") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Fullscreen() As Boolean
            Get
                Return CType(Me("Fullscreen"),Boolean)
            End Get
            Set
                Me("Fullscreen") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property LocStorage() As String
            Get
                Return CType(Me("LocStorage"),String)
            End Get
            Set
                Me("LocStorage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property LastFile() As String
            Get
                Return CType(Me("LastFile"),String)
            End Get
            Set
                Me("LastFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SteamSettings() As String
            Get
                Return CType(Me("SteamSettings"),String)
            End Get
            Set
                Me("SteamSettings") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Equipment() As String
            Get
                Return CType(Me("Equipment"),String)
            End Get
            Set
                Me("Equipment") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property NewStyle() As Boolean
            Get
                Return CType(Me("NewStyle"),Boolean)
            End Get
            Set
                Me("NewStyle") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Messages() As Boolean
            Get
                Return CType(Me("Messages"),Boolean)
            End Get
            Set
                Me("Messages") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property LastMessage() As String
            Get
                Return CType(Me("LastMessage"),String)
            End Get
            Set
                Me("LastMessage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("15, 15, 15")>  _
        Public Property cTitleBar() As Global.System.Drawing.Color
            Get
                Return CType(Me("cTitleBar"),Global.System.Drawing.Color)
            End Get
            Set
                Me("cTitleBar") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("27, 27, 27")>  _
        Public Property cBackground() As Global.System.Drawing.Color
            Get
                Return CType(Me("cBackground"),Global.System.Drawing.Color)
            End Get
            Set
                Me("cBackground") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("23, 23, 23")>  _
        Public Property cSideBar() As Global.System.Drawing.Color
            Get
                Return CType(Me("cSideBar"),Global.System.Drawing.Color)
            End Get
            Set
                Me("cSideBar") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("177, 208, 217")>  _
        Public Property cText() As Global.System.Drawing.Color
            Get
                Return CType(Me("cText"),Global.System.Drawing.Color)
            End Get
            Set
                Me("cText") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("23, 23, 23")>  _
        Public Property cTray() As Global.System.Drawing.Color
            Get
                Return CType(Me("cTray"),Global.System.Drawing.Color)
            End Get
            Set
                Me("cTray") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("120")>  _
        Public Property HKey3() As Integer
            Get
                Return CType(Me("HKey3"),Integer)
            End Get
            Set
                Me("HKey3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("F9")>  _
        Public Property HKey3Text() As String
            Get
                Return CType(Me("HKey3Text"),String)
            End Get
            Set
                Me("HKey3Text") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property StartPoint() As Global.System.Drawing.Point
            Get
                Return CType(Me("StartPoint"),Global.System.Drawing.Point)
            End Get
            Set
                Me("StartPoint") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1, 1")>  _
        Public Property RecSize() As Global.System.Drawing.Point
            Get
                Return CType(Me("RecSize"),Global.System.Drawing.Point)
            End Get
            Set
                Me("RecSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TargetAreaSet() As Boolean
            Get
                Return CType(Me("TargetAreaSet"),Boolean)
            End Get
            Set
                Me("TargetAreaSet") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property DisplayPlatinum() As Boolean
            Get
                Return CType(Me("DisplayPlatinum"),Boolean)
            End Get
            Set
                Me("DisplayPlatinum") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property DisplayNames() As Boolean
            Get
                Return CType(Me("DisplayNames"),Boolean)
            End Get
            Set
                Me("DisplayNames") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.WFInfo.My.MySettings
            Get
                Return Global.WFInfo.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
