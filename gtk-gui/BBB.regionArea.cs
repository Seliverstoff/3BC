
// This file has been generated by the GUI designer. Do not modify.
namespace BBB
{
	public partial class regionArea
	{
		private global::Gtk.Table table1;
		private global::Gtk.Button button_editor;
		private global::Gtk.CheckButton checkbutton_label;
		private global::BBB.DrawingCorners drawingcorners1;
		private global::BBB.DrawingCorners drawingcorners2;
		private global::Gtk.HBox hbox2;
		private global::Gtk.SpinButton spinbutton_x1;
		private global::Gtk.Label label6;
		private global::Gtk.SpinButton spinbutton_y1;
		private global::Gtk.Label label5;
		private global::Gtk.HBox hbox3;
		private global::Gtk.SpinButton spinbutton_x2;
		private global::Gtk.Label label7;
		private global::Gtk.SpinButton spinbutton_y2;
		private global::Gtk.Label label8;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BBB.regionArea
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BBB.regionArea";
			// Container child BBB.regionArea.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.button_editor = new global::Gtk.Button ();
			this.button_editor.CanFocus = true;
			this.button_editor.Name = "button_editor";
			this.button_editor.UseUnderline = true;
			// Container child button_editor.Gtk.Container+ContainerChild
			global::Gtk.Alignment w1 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w2 = new global::Gtk.HBox ();
			w2.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w2.Add (w3);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w5 = new global::Gtk.Label ();
			w2.Add (w5);
			w1.Add (w2);
			this.button_editor.Add (w1);
			this.table1.Add (this.button_editor);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.button_editor]));
			w9.LeftAttach = ((uint)(3));
			w9.RightAttach = ((uint)(4));
			w9.XOptions = ((global::Gtk.AttachOptions)(0));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton_label = new global::Gtk.CheckButton ();
			this.checkbutton_label.CanFocus = true;
			this.checkbutton_label.Name = "checkbutton_label";
			this.checkbutton_label.Label = global::Mono.Unix.Catalog.GetString ("checkbutton3");
			this.checkbutton_label.DrawIndicator = true;
			this.checkbutton_label.UseUnderline = true;
			this.table1.Add (this.checkbutton_label);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton_label]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.drawingcorners1 = new global::BBB.DrawingCorners ();
			this.drawingcorners1.Name = "drawingcorners1";
			this.drawingcorners1.type = 2;
			this.table1.Add (this.drawingcorners1);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.drawingcorners1]));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.drawingcorners2 = new global::BBB.DrawingCorners ();
			this.drawingcorners2.Name = "drawingcorners2";
			this.drawingcorners2.type = 3;
			this.table1.Add (this.drawingcorners2);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.drawingcorners2]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.spinbutton_x1 = new global::Gtk.SpinButton (0D, 100D, 1D);
			this.spinbutton_x1.CanFocus = true;
			this.spinbutton_x1.Name = "spinbutton_x1";
			this.spinbutton_x1.Adjustment.PageIncrement = 10D;
			this.spinbutton_x1.ClimbRate = 1D;
			this.spinbutton_x1.Numeric = true;
			this.hbox2.Add (this.spinbutton_x1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.spinbutton_x1]));
			w13.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("x1");
			this.hbox2.Add (this.label6);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label6]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.spinbutton_y1 = new global::Gtk.SpinButton (0D, 100D, 1D);
			this.spinbutton_y1.CanFocus = true;
			this.spinbutton_y1.Name = "spinbutton_y1";
			this.spinbutton_y1.Adjustment.PageIncrement = 10D;
			this.spinbutton_y1.ClimbRate = 1D;
			this.spinbutton_y1.Numeric = true;
			this.hbox2.Add (this.spinbutton_y1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.spinbutton_y1]));
			w15.Position = 2;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("y1");
			this.hbox2.Add (this.label5);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label5]));
			w16.Position = 3;
			w16.Expand = false;
			w16.Fill = false;
			this.table1.Add (this.hbox2);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox2]));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.spinbutton_x2 = new global::Gtk.SpinButton (0D, 100D, 1D);
			this.spinbutton_x2.CanFocus = true;
			this.spinbutton_x2.Name = "spinbutton_x2";
			this.spinbutton_x2.Adjustment.PageIncrement = 10D;
			this.spinbutton_x2.ClimbRate = 1D;
			this.spinbutton_x2.Numeric = true;
			this.hbox3.Add (this.spinbutton_x2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.spinbutton_x2]));
			w18.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("x2");
			this.hbox3.Add (this.label7);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label7]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.spinbutton_y2 = new global::Gtk.SpinButton (0D, 100D, 1D);
			this.spinbutton_y2.CanFocus = true;
			this.spinbutton_y2.Name = "spinbutton_y2";
			this.spinbutton_y2.Adjustment.PageIncrement = 10D;
			this.spinbutton_y2.ClimbRate = 1D;
			this.spinbutton_y2.Numeric = true;
			this.hbox3.Add (this.spinbutton_y2);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.spinbutton_y2]));
			w20.Position = 2;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("y2");
			this.hbox3.Add (this.label8);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label8]));
			w21.Position = 3;
			w21.Expand = false;
			w21.Fill = false;
			this.table1.Add (this.hbox3);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox3]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.LeftAttach = ((uint)(2));
			w22.RightAttach = ((uint)(3));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.spinbutton_x2.Changed += new global::System.EventHandler (this.OnSpinbutton4Changed);
			this.spinbutton_y2.Changed += new global::System.EventHandler (this.OnSpinbutton5Changed);
			this.spinbutton_x1.Changed += new global::System.EventHandler (this.OnSpinbutton3Changed);
			this.spinbutton_y1.Changed += new global::System.EventHandler (this.OnSpinbutton2Changed);
			this.checkbutton_label.Clicked += new global::System.EventHandler (this.OnCheckbuttonLabelClicked);
			this.button_editor.Clicked += new global::System.EventHandler (this.OnButtonEditorClicked);
		}
	}
}
