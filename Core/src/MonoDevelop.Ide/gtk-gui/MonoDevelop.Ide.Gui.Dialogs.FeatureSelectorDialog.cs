// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    
    public partial class FeatureSelectorDialog {
        
        private Gtk.VBox vbox5;
        
        private Gtk.Label label3;
        
        private MonoDevelop.Ide.Gui.Dialogs.CombineEntryFeatureSelector featureList;
        
        private Gtk.Button button1547;
        
        private Gtk.Button button1548;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget MonoDevelop.Ide.Gui.Dialogs.FeatureSelectorDialog
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.FeatureSelectorDialog";
            this.Title = Mono.Unix.Catalog.GetString("New Project Features");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Internal child MonoDevelop.Ide.Gui.Dialogs.FeatureSelectorDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox5 = new Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 6;
            this.vbox5.BorderWidth = ((uint)(6));
            // Container child vbox5.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("<b>Project features</b>");
            this.label3.UseMarkup = true;
            this.vbox5.Add(this.label3);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox5[this.label3]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.featureList = new MonoDevelop.Ide.Gui.Dialogs.CombineEntryFeatureSelector();
            this.featureList.Events = ((Gdk.EventMask)(256));
            this.featureList.Name = "featureList";
            this.vbox5.Add(this.featureList);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox5[this.featureList]));
            w3.Position = 1;
            w1.Add(this.vbox5);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(w1[this.vbox5]));
            w4.Position = 0;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.FeatureSelectorDialog.ActionArea
            Gtk.HButtonBox w5 = this.ActionArea;
            w5.Name = "GtkDialog_ActionArea";
            w5.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child GtkDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button1547 = new Gtk.Button();
            this.button1547.CanFocus = true;
            this.button1547.Name = "button1547";
            this.button1547.UseUnderline = true;
            this.button1547.Label = Mono.Unix.Catalog.GetString("button1547");
            this.AddActionWidget(this.button1547, 0);
            Gtk.ButtonBox.ButtonBoxChild w6 = ((Gtk.ButtonBox.ButtonBoxChild)(w5[this.button1547]));
            w6.Expand = false;
            w6.Fill = false;
            // Container child GtkDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button1548 = new Gtk.Button();
            this.button1548.CanFocus = true;
            this.button1548.Name = "button1548";
            this.button1548.UseUnderline = true;
            this.button1548.Label = Mono.Unix.Catalog.GetString("button1548");
            this.AddActionWidget(this.button1548, 0);
            Gtk.ButtonBox.ButtonBoxChild w7 = ((Gtk.ButtonBox.ButtonBoxChild)(w5[this.button1548]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 585;
            this.DefaultHeight = 435;
            this.Show();
        }
    }
}
