﻿#pragma checksum "C:\Experiment\hactiv8\IoT.Makers.Demo\SmartDemo\SmartAssistant\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "89C086F4C10DE8ED402BA88C3498FC8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartAssistant
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Splitter = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.btnContinuousRecognize = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnContinuousRecognize).Click += this.ContinuousRecognize_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnRecognizeWithUI = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 45 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnRecognizeWithUI).Click += this.RecognizeWithUIWebSearchGrammar_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.listGrammarHelpText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.heardYouSayTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.resultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.WebcamFeed = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                    #line 54 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CaptureElement)this.WebcamFeed).Loaded += this.WebcamFeed_Loaded;
                    #line default
                }
                break;
            case 10:
                {
                    this.speechMediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                    #line 55 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.speechMediaElement).Loaded += this.speechMediaElement_Loaded;
                    #line default
                }
                break;
            case 11:
                {
                    this.ContinuousRecoButtonText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.cbLanguageSelection = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 32 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbLanguageSelection).SelectionChanged += this.cbLanguageSelection_SelectionChanged;
                    #line default
                }
                break;
            case 13:
                {
                    this.StatusPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 14:
                {
                    this.Player1 = (global::Windows.UI.Xaml.Controls.MediaPlayerElement)(target);
                }
                break;
            case 15:
                {
                    this.ListGambar = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 16:
                {
                    this.StatusLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.StatusBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 18:
                {
                    this.StatusBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
