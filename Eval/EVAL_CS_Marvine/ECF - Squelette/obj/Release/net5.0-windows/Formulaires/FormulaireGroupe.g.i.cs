﻿#pragma checksum "..\..\..\..\Formulaires\FormulaireGroupe.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D87074B0EDFFFDA41986F3159E9672222A34DF15"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ECF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ECF {
    
    
    /// <summary>
    /// FormulaireGroupe
    /// </summary>
    public partial class FormulaireGroupe : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labTitreFormulaire;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbNomDuGroupe;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbNombreDeFollowers;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbLogo;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgLogo;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInfoLogo;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Annuler;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Valider;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ECF;component/formulaires/formulairegroupe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labTitreFormulaire = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txbNomDuGroupe = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txbNombreDeFollowers = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
            this.txbNombreDeFollowers.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txbNombreDeFollowers_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbLogo = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
            this.txbLogo.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txbLogo_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.imgLogo = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.lblInfoLogo = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btn_Annuler = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
            this.btn_Annuler.Click += new System.Windows.RoutedEventHandler(this.Retour);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Valider = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Formulaires\FormulaireGroupe.xaml"
            this.btn_Valider.Click += new System.Windows.RoutedEventHandler(this.ActionGroupe);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

