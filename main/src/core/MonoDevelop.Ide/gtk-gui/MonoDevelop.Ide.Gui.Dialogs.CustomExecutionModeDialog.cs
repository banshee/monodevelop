// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    internal partial class CustomExecutionModeDialog {
        
        private Gtk.VBox boxEditor;
        
        private Gtk.VBox boxModeSelector;
        
        private Gtk.HBox hbox5;
        
        private Gtk.Label label2;
        
        private MonoDevelop.Ide.Gui.Components.ExecutionModeComboBox comboTargetMode;
        
        private Gtk.HSeparator hseparator1;
        
        private Gtk.Notebook notebook;
        
        private Gtk.VBox boxSave;
        
        private Gtk.HSeparator hseparator;
        
        private Gtk.CheckButton checkSave;
        
        private Gtk.HBox boxName;
        
        private Gtk.Label label4;
        
        private Gtk.Entry entryModeName;
        
        private Gtk.Label label3;
        
        private Gtk.ComboBox comboStore;
        
        private Gtk.CheckButton checkPrompt;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.Dialogs.CustomExecutionModeDialog
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.CustomExecutionModeDialog";
            this.Title = Mono.Unix.Catalog.GetString("Execution Arguments");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.CustomExecutionModeDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.boxEditor = new Gtk.VBox();
            this.boxEditor.Name = "boxEditor";
            this.boxEditor.Spacing = 9;
            this.boxEditor.BorderWidth = ((uint)(6));
            // Container child boxEditor.Gtk.Box+BoxChild
            this.boxModeSelector = new Gtk.VBox();
            this.boxModeSelector.Name = "boxModeSelector";
            this.boxModeSelector.Spacing = 6;
            // Container child boxModeSelector.Gtk.Box+BoxChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Execution Mode:");
            this.hbox5.Add(this.label2);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox5[this.label2]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            this.comboTargetMode = new MonoDevelop.Ide.Gui.Components.ExecutionModeComboBox();
            this.comboTargetMode.Events = ((Gdk.EventMask)(256));
            this.comboTargetMode.Name = "comboTargetMode";
            this.hbox5.Add(this.comboTargetMode);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox5[this.comboTargetMode]));
            w3.Position = 1;
            this.boxModeSelector.Add(this.hbox5);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.boxModeSelector[this.hbox5]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child boxModeSelector.Gtk.Box+BoxChild
            this.hseparator1 = new Gtk.HSeparator();
            this.hseparator1.Name = "hseparator1";
            this.boxModeSelector.Add(this.hseparator1);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.boxModeSelector[this.hseparator1]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            this.boxEditor.Add(this.boxModeSelector);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.boxEditor[this.boxModeSelector]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child boxEditor.Gtk.Box+BoxChild
            this.notebook = new Gtk.Notebook();
            this.notebook.CanFocus = true;
            this.notebook.Name = "notebook";
            this.notebook.CurrentPage = -1;
            this.boxEditor.Add(this.notebook);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.boxEditor[this.notebook]));
            w7.Position = 1;
            // Container child boxEditor.Gtk.Box+BoxChild
            this.boxSave = new Gtk.VBox();
            this.boxSave.Name = "boxSave";
            this.boxSave.Spacing = 6;
            // Container child boxSave.Gtk.Box+BoxChild
            this.hseparator = new Gtk.HSeparator();
            this.hseparator.Name = "hseparator";
            this.boxSave.Add(this.hseparator);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.boxSave[this.hseparator]));
            w8.Position = 0;
            w8.Expand = false;
            w8.Fill = false;
            // Container child boxSave.Gtk.Box+BoxChild
            this.checkSave = new Gtk.CheckButton();
            this.checkSave.CanFocus = true;
            this.checkSave.Name = "checkSave";
            this.checkSave.Label = Mono.Unix.Catalog.GetString("Save this configuration as a custom execution mode");
            this.checkSave.DrawIndicator = true;
            this.checkSave.UseUnderline = true;
            this.boxSave.Add(this.checkSave);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.boxSave[this.checkSave]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            // Container child boxSave.Gtk.Box+BoxChild
            this.boxName = new Gtk.HBox();
            this.boxName.Name = "boxName";
            this.boxName.Spacing = 6;
            // Container child boxName.Gtk.Box+BoxChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("Custom Mode Name:");
            this.boxName.Add(this.label4);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.boxName[this.label4]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child boxName.Gtk.Box+BoxChild
            this.entryModeName = new Gtk.Entry();
            this.entryModeName.CanFocus = true;
            this.entryModeName.Name = "entryModeName";
            this.entryModeName.IsEditable = true;
            this.entryModeName.InvisibleChar = '●';
            this.boxName.Add(this.entryModeName);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.boxName[this.entryModeName]));
            w11.Position = 1;
            // Container child boxName.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Available for:");
            this.boxName.Add(this.label3);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.boxName[this.label3]));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;
            // Container child boxName.Gtk.Box+BoxChild
            this.comboStore = Gtk.ComboBox.NewText();
            this.comboStore.AppendText(Mono.Unix.Catalog.GetString("Only this project"));
            this.comboStore.AppendText(Mono.Unix.Catalog.GetString("Only this solution"));
            this.comboStore.AppendText(Mono.Unix.Catalog.GetString("All solutions"));
            this.comboStore.Name = "comboStore";
            this.comboStore.Active = 0;
            this.boxName.Add(this.comboStore);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.boxName[this.comboStore]));
            w13.Position = 3;
            w13.Expand = false;
            w13.Fill = false;
            this.boxSave.Add(this.boxName);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.boxSave[this.boxName]));
            w14.Position = 2;
            w14.Expand = false;
            w14.Fill = false;
            // Container child boxSave.Gtk.Box+BoxChild
            this.checkPrompt = new Gtk.CheckButton();
            this.checkPrompt.CanFocus = true;
            this.checkPrompt.Name = "checkPrompt";
            this.checkPrompt.Label = Mono.Unix.Catalog.GetString("Always show the parameters window before running this custom mode");
            this.checkPrompt.DrawIndicator = true;
            this.checkPrompt.UseUnderline = true;
            this.boxSave.Add(this.checkPrompt);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.boxSave[this.checkPrompt]));
            w15.Position = 3;
            w15.Expand = false;
            w15.Fill = false;
            this.boxEditor.Add(this.boxSave);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.boxEditor[this.boxSave]));
            w16.PackType = ((Gtk.PackType)(1));
            w16.Position = 2;
            w16.Expand = false;
            w16.Fill = false;
            w1.Add(this.boxEditor);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(w1[this.boxEditor]));
            w17.Position = 0;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.CustomExecutionModeDialog.ActionArea
            Gtk.HButtonBox w18 = this.ActionArea;
            w18.Name = "dialog1_ActionArea";
            w18.Spacing = 10;
            w18.BorderWidth = ((uint)(5));
            w18.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w19 = ((Gtk.ButtonBox.ButtonBoxChild)(w18[this.buttonCancel]));
            w19.Expand = false;
            w19.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w20 = ((Gtk.ButtonBox.ButtonBoxChild)(w18[this.buttonOk]));
            w20.Position = 1;
            w20.Expand = false;
            w20.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 655;
            this.DefaultHeight = 525;
            this.boxName.Hide();
            this.checkPrompt.Hide();
            this.Show();
            this.comboTargetMode.SelectionChanged += new System.EventHandler(this.OnComboTargetModeSelectionChanged);
            this.checkSave.Toggled += new System.EventHandler(this.OnCheckSaveToggled);
            this.entryModeName.Changed += new System.EventHandler(this.OnEntryModeNameChanged);
        }
    }
}
