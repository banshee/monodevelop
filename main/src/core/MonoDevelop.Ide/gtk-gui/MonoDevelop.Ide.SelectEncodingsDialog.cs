// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide {
    
    internal partial class SelectEncodingsDialog {
        
        private Gtk.Table table5;
        
        private Gtk.Label label106;
        
        private Gtk.Label label107;
        
        private Gtk.ScrolledWindow scrolledwindow10;
        
        private Gtk.TreeView listAvail;
        
        private Gtk.ScrolledWindow scrolledwindow11;
        
        private Gtk.TreeView listSelected;
        
        private Gtk.VBox vbox74;
        
        private Gtk.Label label108;
        
        private Gtk.Button btnAdd;
        
        private Gtk.Button btnRemove;
        
        private Gtk.Label label109;
        
        private Gtk.VBox vbox75;
        
        private Gtk.Button btnUp;
        
        private Gtk.Image image9;
        
        private Gtk.Button btnDown;
        
        private Gtk.Image image10;
        
        private Gtk.Button cancelbutton1;
        
        private Gtk.Button okbutton1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.SelectEncodingsDialog
            this.Name = "MonoDevelop.Ide.SelectEncodingsDialog";
            this.Title = "Select Text Encodings";
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.Modal = true;
            this.BorderWidth = ((uint)(6));
            this.DefaultWidth = 700;
            this.DefaultHeight = 450;
            // Internal child MonoDevelop.Ide.SelectEncodingsDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog-vbox5";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog-vbox5.Gtk.Box+BoxChild
            this.table5 = new Gtk.Table(((uint)(2)), ((uint)(4)), false);
            this.table5.Name = "table5";
            this.table5.RowSpacing = ((uint)(6));
            this.table5.ColumnSpacing = ((uint)(12));
            this.table5.BorderWidth = ((uint)(6));
            // Container child table5.Gtk.Table+TableChild
            this.label106 = new Gtk.Label();
            this.label106.Name = "label106";
            this.label106.Xalign = 0F;
            this.label106.Yalign = 0F;
            this.label106.LabelProp = Mono.Unix.Catalog.GetString("Available encodings:");
            this.label106.WidthChars = 20;
            this.table5.Add(this.label106);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table5[this.label106]));
            w2.XOptions = ((Gtk.AttachOptions)(4));
            w2.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table5.Gtk.Table+TableChild
            this.label107 = new Gtk.Label();
            this.label107.Name = "label107";
            this.label107.Xalign = 0F;
            this.label107.Yalign = 0F;
            this.label107.LabelProp = Mono.Unix.Catalog.GetString("Encodings shown in menu:");
            this.label107.WidthChars = 20;
            this.table5.Add(this.label107);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table5[this.label107]));
            w3.LeftAttach = ((uint)(2));
            w3.RightAttach = ((uint)(3));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table5.Gtk.Table+TableChild
            this.scrolledwindow10 = new Gtk.ScrolledWindow();
            this.scrolledwindow10.Name = "scrolledwindow10";
            this.scrolledwindow10.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow10.Gtk.Container+ContainerChild
            this.listAvail = new Gtk.TreeView();
            this.listAvail.Name = "listAvail";
            this.scrolledwindow10.Add(this.listAvail);
            this.table5.Add(this.scrolledwindow10);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table5[this.scrolledwindow10]));
            w5.TopAttach = ((uint)(1));
            w5.BottomAttach = ((uint)(2));
            // Container child table5.Gtk.Table+TableChild
            this.scrolledwindow11 = new Gtk.ScrolledWindow();
            this.scrolledwindow11.Name = "scrolledwindow11";
            this.scrolledwindow11.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow11.Gtk.Container+ContainerChild
            this.listSelected = new Gtk.TreeView();
            this.listSelected.Name = "listSelected";
            this.scrolledwindow11.Add(this.listSelected);
            this.table5.Add(this.scrolledwindow11);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table5[this.scrolledwindow11]));
            w7.TopAttach = ((uint)(1));
            w7.BottomAttach = ((uint)(2));
            w7.LeftAttach = ((uint)(2));
            w7.RightAttach = ((uint)(3));
            // Container child table5.Gtk.Table+TableChild
            this.vbox74 = new Gtk.VBox();
            this.vbox74.Name = "vbox74";
            this.vbox74.Spacing = 6;
            // Container child vbox74.Gtk.Box+BoxChild
            this.label108 = new Gtk.Label();
            this.label108.Name = "label108";
            this.label108.Xalign = 0F;
            this.label108.Yalign = 0F;
            this.vbox74.Add(this.label108);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox74[this.label108]));
            w8.Position = 0;
            // Container child vbox74.Gtk.Box+BoxChild
            this.btnAdd = new Gtk.Button();
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseUnderline = true;
            // Container child btnAdd.Gtk.Container+ContainerChild
            Gtk.Alignment w9 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w10 = new Gtk.HBox();
            w10.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w11 = new Gtk.Image();
            w11.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-go-forward", Gtk.IconSize.Button, 20);
            w10.Add(w11);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w13 = new Gtk.Label();
            w10.Add(w13);
            w9.Add(w10);
            this.btnAdd.Add(w9);
            this.vbox74.Add(this.btnAdd);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox74[this.btnAdd]));
            w17.Position = 1;
            w17.Expand = false;
            w17.Fill = false;
            // Container child vbox74.Gtk.Box+BoxChild
            this.btnRemove = new Gtk.Button();
            this.btnRemove.Name = "btnRemove";
            // Container child btnRemove.Gtk.Container+ContainerChild
            Gtk.Alignment w18 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w19 = new Gtk.HBox();
            w19.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w20 = new Gtk.Image();
            w20.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-go-back", Gtk.IconSize.SmallToolbar, 18);
            w19.Add(w20);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w22 = new Gtk.Label();
            w19.Add(w22);
            w18.Add(w19);
            this.btnRemove.Add(w18);
            this.vbox74.Add(this.btnRemove);
            Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(this.vbox74[this.btnRemove]));
            w26.Position = 2;
            w26.Expand = false;
            w26.Fill = false;
            // Container child vbox74.Gtk.Box+BoxChild
            this.label109 = new Gtk.Label();
            this.label109.Name = "label109";
            this.label109.Xalign = 0F;
            this.label109.Yalign = 0F;
            this.vbox74.Add(this.label109);
            Gtk.Box.BoxChild w27 = ((Gtk.Box.BoxChild)(this.vbox74[this.label109]));
            w27.Position = 3;
            this.table5.Add(this.vbox74);
            Gtk.Table.TableChild w28 = ((Gtk.Table.TableChild)(this.table5[this.vbox74]));
            w28.TopAttach = ((uint)(1));
            w28.BottomAttach = ((uint)(2));
            w28.LeftAttach = ((uint)(1));
            w28.RightAttach = ((uint)(2));
            w28.XOptions = ((Gtk.AttachOptions)(0));
            w28.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table5.Gtk.Table+TableChild
            this.vbox75 = new Gtk.VBox();
            this.vbox75.Name = "vbox75";
            this.vbox75.Spacing = 6;
            // Container child vbox75.Gtk.Box+BoxChild
            this.btnUp = new Gtk.Button();
            this.btnUp.Name = "btnUp";
            // Container child btnUp.Gtk.Container+ContainerChild
            this.image9 = new Gtk.Image();
            this.image9.Name = "image9";
            this.image9.Xalign = 0F;
            this.image9.Yalign = 0F;
            this.image9.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-go-up", Gtk.IconSize.Button, 20);
            this.btnUp.Add(this.image9);
            this.btnUp.Label = null;
            this.vbox75.Add(this.btnUp);
            Gtk.Box.BoxChild w30 = ((Gtk.Box.BoxChild)(this.vbox75[this.btnUp]));
            w30.Position = 0;
            w30.Expand = false;
            w30.Fill = false;
            // Container child vbox75.Gtk.Box+BoxChild
            this.btnDown = new Gtk.Button();
            this.btnDown.Name = "btnDown";
            // Container child btnDown.Gtk.Container+ContainerChild
            this.image10 = new Gtk.Image();
            this.image10.Name = "image10";
            this.image10.Xalign = 0F;
            this.image10.Yalign = 0F;
            this.image10.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-go-down", Gtk.IconSize.Button, 20);
            this.btnDown.Add(this.image10);
            this.btnDown.Label = null;
            this.vbox75.Add(this.btnDown);
            Gtk.Box.BoxChild w32 = ((Gtk.Box.BoxChild)(this.vbox75[this.btnDown]));
            w32.Position = 1;
            w32.Expand = false;
            w32.Fill = false;
            this.table5.Add(this.vbox75);
            Gtk.Table.TableChild w33 = ((Gtk.Table.TableChild)(this.table5[this.vbox75]));
            w33.TopAttach = ((uint)(1));
            w33.BottomAttach = ((uint)(2));
            w33.LeftAttach = ((uint)(3));
            w33.RightAttach = ((uint)(4));
            w33.XOptions = ((Gtk.AttachOptions)(0));
            w33.YOptions = ((Gtk.AttachOptions)(0));
            w1.Add(this.table5);
            Gtk.Box.BoxChild w34 = ((Gtk.Box.BoxChild)(w1[this.table5]));
            w34.Position = 0;
            // Internal child MonoDevelop.Ide.SelectEncodingsDialog.ActionArea
            Gtk.HButtonBox w35 = this.ActionArea;
            w35.Name = "dialog-action_area5";
            w35.Spacing = 6;
            w35.BorderWidth = ((uint)(5));
            w35.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog-action_area5.Gtk.ButtonBox+ButtonBoxChild
            this.cancelbutton1 = new Gtk.Button();
            this.cancelbutton1.Name = "cancelbutton1";
            this.cancelbutton1.UseStock = true;
            this.cancelbutton1.UseUnderline = true;
            this.cancelbutton1.Label = "gtk-cancel";
            this.AddActionWidget(this.cancelbutton1, -6);
            // Container child dialog-action_area5.Gtk.ButtonBox+ButtonBoxChild
            this.okbutton1 = new Gtk.Button();
            this.okbutton1.Name = "okbutton1";
            this.okbutton1.UseStock = true;
            this.okbutton1.UseUnderline = true;
            this.okbutton1.Label = "gtk-ok";
            this.AddActionWidget(this.okbutton1, -5);
            Gtk.ButtonBox.ButtonBoxChild w37 = ((Gtk.ButtonBox.ButtonBoxChild)(w35[this.okbutton1]));
            w37.Position = 1;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.Response += new Gtk.ResponseHandler(this.OnRespond);
            this.btnUp.Clicked += new System.EventHandler(this.OnUpClicked);
            this.btnDown.Clicked += new System.EventHandler(this.OnDownClicked);
            this.btnAdd.Clicked += new System.EventHandler(this.OnAddClicked);
            this.btnRemove.Clicked += new System.EventHandler(this.OnRemoveClicked);
        }
    }
}
