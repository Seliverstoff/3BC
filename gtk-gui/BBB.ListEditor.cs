
// This file has been generated by the GUI designer. Do not modify.
namespace BBB
{
	public partial class ListEditor
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.ComboBoxEntry comboboxentry;
		private global::Gtk.Button button_save;
		private global::Gtk.Button button_add;
		private global::Gtk.Button button_remove;
		private global::Gtk.Label label_out;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BBB.ListEditor
			this.Name = "BBB.ListEditor";
			this.Title = global::Mono.Unix.Catalog.GetString ("Редактор списка");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child BBB.ListEditor.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(5));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboboxentry = global::Gtk.ComboBoxEntry.NewText ();
			this.comboboxentry.Name = "comboboxentry";
			this.hbox1.Add (this.comboboxentry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.comboboxentry]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button_save = new global::Gtk.Button ();
			this.button_save.CanFocus = true;
			this.button_save.Name = "button_save";
			this.button_save.UseUnderline = true;
			// Container child button_save.Gtk.Container+ContainerChild
			global::Gtk.Alignment w3 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w4 = new global::Gtk.HBox ();
			w4.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w5 = new global::Gtk.Image ();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-floppy", global::Gtk.IconSize.Menu);
			w4.Add (w5);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w7 = new global::Gtk.Label ();
			w4.Add (w7);
			w3.Add (w4);
			this.button_save.Add (w3);
			this.hbox1.Add (this.button_save);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button_save]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button_add = new global::Gtk.Button ();
			this.button_add.CanFocus = true;
			this.button_add.Name = "button_add";
			this.button_add.UseUnderline = true;
			// Container child button_add.Gtk.Container+ContainerChild
			global::Gtk.Alignment w12 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w13 = new global::Gtk.HBox ();
			w13.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w14 = new global::Gtk.Image ();
			w14.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w13.Add (w14);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w16 = new global::Gtk.Label ();
			w13.Add (w16);
			w12.Add (w13);
			this.button_add.Add (w12);
			this.hbox1.Add (this.button_add);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button_add]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button_remove = new global::Gtk.Button ();
			this.button_remove.CanFocus = true;
			this.button_remove.Name = "button_remove";
			this.button_remove.UseUnderline = true;
			// Container child button_remove.Gtk.Container+ContainerChild
			global::Gtk.Alignment w21 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w22 = new global::Gtk.HBox ();
			w22.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w23 = new global::Gtk.Image ();
			w23.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-remove", global::Gtk.IconSize.Menu);
			w22.Add (w23);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w25 = new global::Gtk.Label ();
			w22.Add (w25);
			w21.Add (w22);
			this.button_remove.Add (w21);
			this.hbox1.Add (this.button_remove);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button_remove]));
			w29.Position = 3;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label_out = new global::Gtk.Label ();
			this.label_out.Name = "label_out";
			this.label_out.Xalign = 0F;
			this.label_out.Wrap = true;
			this.vbox2.Add (this.label_out);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label_out]));
			w31.Position = 1;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			// Internal child BBB.ListEditor.ActionArea
			global::Gtk.HButtonBox w33 = this.ActionArea;
			w33.Name = "dialog1_ActionArea";
			w33.Spacing = 10;
			w33.BorderWidth = ((uint)(5));
			w33.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w34 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w33 [this.buttonCancel]));
			w34.Expand = false;
			w34.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w35 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w33 [this.buttonOk]));
			w35.Position = 1;
			w35.Expand = false;
			w35.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 399;
			this.DefaultHeight = 271;
			this.Show ();
			this.button_save.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.button_add.Clicked += new global::System.EventHandler (this.OnButtonAddClicked);
			this.button_remove.Clicked += new global::System.EventHandler (this.OnButtonRemoveClicked);
		}
	}
}