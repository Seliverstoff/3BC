
// This file has been generated by the GUI designer. Do not modify.
namespace BBB
{
	public partial class fileOpenDlg
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.Entry entry_path;
		private global::Gtk.Button button_open;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BBB.fileOpenDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BBB.fileOpenDlg";
			// Container child BBB.fileOpenDlg.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entry_path = new global::Gtk.Entry ();
			this.entry_path.CanFocus = true;
			this.entry_path.Name = "entry_path";
			this.entry_path.IsEditable = true;
			this.entry_path.InvisibleChar = '●';
			this.hbox1.Add (this.entry_path);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entry_path]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button_open = new global::Gtk.Button ();
			this.button_open.CanFocus = true;
			this.button_open.Name = "button_open";
			this.button_open.UseUnderline = true;
			// Container child button_open.Gtk.Container+ContainerChild
			global::Gtk.Alignment w2 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w3 = new global::Gtk.HBox ();
			w3.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-directory", global::Gtk.IconSize.Menu);
			w3.Add (w4);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w6 = new global::Gtk.Label ();
			w3.Add (w6);
			w2.Add (w3);
			this.button_open.Add (w2);
			this.hbox1.Add (this.button_open);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button_open]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.entry_path.Changed += new global::System.EventHandler (this.OnEntryPathChanged);
			this.button_open.Clicked += new global::System.EventHandler (this.OnButtonOpenClicked);
		}
	}
}