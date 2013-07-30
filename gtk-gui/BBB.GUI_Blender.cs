
// This file has been generated by the GUI designer. Do not modify.
namespace BBB
{
	public partial class GUI_Blender
	{
		private global::Gtk.Table table1;
		private global::Gtk.CheckButton checkbutton_ext;
		private global::Gtk.CheckButton checkbutton_scene_use;
		private global::Gtk.CheckButton checkbutton_use_outs;
		private global::Gtk.CheckButton checkbutton_use_script;
		private global::Gtk.CheckButton checkbutton_use_script_arg;
		private global::Gtk.ComboBox combobox_format;
		private global::BBB.comboList combolist_scene;
		private global::Gtk.Entry entry_script_arg;
		private global::BBB.fileOpenDlg fileopendlg_blender_path;
		private global::BBB.fileOpenDlg fileopendlg_outs;
		private global::BBB.fileOpenDlg fileopendlg_scene_path;
		private global::BBB.fileOpenDlg fileopendlg_script;
		private global::BBB.frameRange framerange;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.HSeparator hseparator10;
		private global::Gtk.HSeparator hseparator2;
		private global::Gtk.HSeparator hseparator3;
		private global::Gtk.HSeparator hseparator4;
		private global::Gtk.HSeparator hseparator5;
		private global::Gtk.HSeparator hseparator6;
		private global::Gtk.HSeparator hseparator7;
		private global::Gtk.HSeparator hseparator8;
		private global::Gtk.HSeparator hseparator9;
		private global::Gtk.Label label_blender_path;
		private global::Gtk.Label label_blender_scene;
		private global::Gtk.Label label_format;
		private global::Gtk.Label label_jamp3;
		private global::Gtk.SpinButton spinbutton_threads;
		private global::Gtk.VBox vbox8;
		private global::Gtk.CheckButton checkbutton_range_use;
		private global::Gtk.Alignment alignment7;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BBB.GUI_Blender
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BBB.GUI_Blender";
			// Container child BBB.GUI_Blender.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(15)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(9));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton_ext = new global::Gtk.CheckButton ();
			this.checkbutton_ext.CanFocus = true;
			this.checkbutton_ext.Name = "checkbutton_ext";
			this.checkbutton_ext.Label = global::Mono.Unix.Catalog.GetString ("Убрать расиширение файла");
			this.checkbutton_ext.DrawIndicator = true;
			this.checkbutton_ext.UseUnderline = true;
			this.table1.Add (this.checkbutton_ext);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton_ext]));
			w1.TopAttach = ((uint)(10));
			w1.BottomAttach = ((uint)(11));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton_scene_use = new global::Gtk.CheckButton ();
			this.checkbutton_scene_use.CanFocus = true;
			this.checkbutton_scene_use.Name = "checkbutton_scene_use";
			this.checkbutton_scene_use.Label = global::Mono.Unix.Catalog.GetString ("Указать сцену в файле");
			this.checkbutton_scene_use.DrawIndicator = true;
			this.checkbutton_scene_use.UseUnderline = true;
			this.table1.Add (this.checkbutton_scene_use);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton_scene_use]));
			w2.TopAttach = ((uint)(3));
			w2.BottomAttach = ((uint)(4));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton_use_outs = new global::Gtk.CheckButton ();
			this.checkbutton_use_outs.CanFocus = true;
			this.checkbutton_use_outs.Name = "checkbutton_use_outs";
			this.checkbutton_use_outs.Label = global::Mono.Unix.Catalog.GetString ("Перенаправлять вывод");
			this.checkbutton_use_outs.DrawIndicator = true;
			this.checkbutton_use_outs.UseUnderline = true;
			this.table1.Add (this.checkbutton_use_outs);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton_use_outs]));
			w3.TopAttach = ((uint)(8));
			w3.BottomAttach = ((uint)(9));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton_use_script = new global::Gtk.CheckButton ();
			this.checkbutton_use_script.CanFocus = true;
			this.checkbutton_use_script.Name = "checkbutton_use_script";
			this.checkbutton_use_script.Label = global::Mono.Unix.Catalog.GetString ("Использовать *.py скрипт");
			this.checkbutton_use_script.DrawIndicator = true;
			this.checkbutton_use_script.UseUnderline = true;
			this.table1.Add (this.checkbutton_use_script);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton_use_script]));
			w4.TopAttach = ((uint)(5));
			w4.BottomAttach = ((uint)(6));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton_use_script_arg = new global::Gtk.CheckButton ();
			this.checkbutton_use_script_arg.CanFocus = true;
			this.checkbutton_use_script_arg.Name = "checkbutton_use_script_arg";
			this.checkbutton_use_script_arg.Label = global::Mono.Unix.Catalog.GetString ("Передавать параметры скрипту");
			this.checkbutton_use_script_arg.DrawIndicator = true;
			this.checkbutton_use_script_arg.UseUnderline = true;
			this.table1.Add (this.checkbutton_use_script_arg);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton_use_script_arg]));
			w5.TopAttach = ((uint)(6));
			w5.BottomAttach = ((uint)(7));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.combobox_format = global::Gtk.ComboBox.NewText ();
			this.combobox_format.Name = "combobox_format";
			this.table1.Add (this.combobox_format);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.combobox_format]));
			w6.TopAttach = ((uint)(9));
			w6.BottomAttach = ((uint)(10));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.combolist_scene = new global::BBB.comboList ();
			this.combolist_scene.Events = ((global::Gdk.EventMask)(256));
			this.combolist_scene.Name = "combolist_scene";
			this.table1.Add (this.combolist_scene);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.combolist_scene]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table1.Gtk.Table+TableChild
			this.entry_script_arg = new global::Gtk.Entry ();
			this.entry_script_arg.CanFocus = true;
			this.entry_script_arg.Name = "entry_script_arg";
			this.entry_script_arg.IsEditable = true;
			this.entry_script_arg.InvisibleChar = '●';
			this.table1.Add (this.entry_script_arg);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry_script_arg]));
			w8.TopAttach = ((uint)(6));
			w8.BottomAttach = ((uint)(7));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.fileopendlg_blender_path = new global::BBB.fileOpenDlg ();
			this.fileopendlg_blender_path.Events = ((global::Gdk.EventMask)(256));
			this.fileopendlg_blender_path.Name = "fileopendlg_blender_path";
			this.fileopendlg_blender_path.CheckType = true;
			this.fileopendlg_blender_path.filterName = "Файл программы Blender3D (blender.exe)";
			this.fileopendlg_blender_path.filterExec = "blender.exe";
			this.table1.Add (this.fileopendlg_blender_path);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.fileopendlg_blender_path]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.fileopendlg_outs = new global::BBB.fileOpenDlg ();
			this.fileopendlg_outs.Events = ((global::Gdk.EventMask)(256));
			this.fileopendlg_outs.Name = "fileopendlg_outs";
			this.fileopendlg_outs.CheckType = false;
			this.table1.Add (this.fileopendlg_outs);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.fileopendlg_outs]));
			w10.TopAttach = ((uint)(8));
			w10.BottomAttach = ((uint)(9));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.fileopendlg_scene_path = new global::BBB.fileOpenDlg ();
			this.fileopendlg_scene_path.Events = ((global::Gdk.EventMask)(256));
			this.fileopendlg_scene_path.Name = "fileopendlg_scene_path";
			this.fileopendlg_scene_path.CheckType = true;
			this.fileopendlg_scene_path.filterName = "Файл сцены *.blend";
			this.fileopendlg_scene_path.filterExec = "*.blend";
			this.table1.Add (this.fileopendlg_scene_path);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.fileopendlg_scene_path]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.fileopendlg_script = new global::BBB.fileOpenDlg ();
			this.fileopendlg_script.Events = ((global::Gdk.EventMask)(256));
			this.fileopendlg_script.Name = "fileopendlg_script";
			this.fileopendlg_script.CheckType = true;
			this.fileopendlg_script.filterName = "Файл Python скрипта (*.py)";
			this.fileopendlg_script.filterExec = "*.py";
			this.table1.Add (this.fileopendlg_script);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.fileopendlg_script]));
			w12.TopAttach = ((uint)(5));
			w12.BottomAttach = ((uint)(6));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.framerange = new global::BBB.frameRange ();
			this.framerange.Events = ((global::Gdk.EventMask)(256));
			this.framerange.Name = "framerange";
			this.framerange._end = 0;
			this.framerange._step = 0;
			this.framerange._jamp = 0;
			this.framerange._start = 0;
			this.table1.Add (this.framerange);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.framerange]));
			w13.TopAttach = ((uint)(14));
			w13.BottomAttach = ((uint)(15));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.table1.Add (this.hseparator1);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator1]));
			w14.TopAttach = ((uint)(13));
			w14.BottomAttach = ((uint)(14));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator10 = new global::Gtk.HSeparator ();
			this.hseparator10.Name = "hseparator10";
			this.table1.Add (this.hseparator10);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator10]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.table1.Add (this.hseparator2);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator2]));
			w16.TopAttach = ((uint)(13));
			w16.BottomAttach = ((uint)(14));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.table1.Add (this.hseparator3);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator3]));
			w17.TopAttach = ((uint)(11));
			w17.BottomAttach = ((uint)(12));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator4 = new global::Gtk.HSeparator ();
			this.hseparator4.Name = "hseparator4";
			this.table1.Add (this.hseparator4);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator4]));
			w18.TopAttach = ((uint)(11));
			w18.BottomAttach = ((uint)(12));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator5 = new global::Gtk.HSeparator ();
			this.hseparator5.Name = "hseparator5";
			this.table1.Add (this.hseparator5);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator5]));
			w19.TopAttach = ((uint)(7));
			w19.BottomAttach = ((uint)(8));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator6 = new global::Gtk.HSeparator ();
			this.hseparator6.Name = "hseparator6";
			this.table1.Add (this.hseparator6);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator6]));
			w20.TopAttach = ((uint)(7));
			w20.BottomAttach = ((uint)(8));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator7 = new global::Gtk.HSeparator ();
			this.hseparator7.Name = "hseparator7";
			this.table1.Add (this.hseparator7);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator7]));
			w21.TopAttach = ((uint)(4));
			w21.BottomAttach = ((uint)(5));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator8 = new global::Gtk.HSeparator ();
			this.hseparator8.Name = "hseparator8";
			this.table1.Add (this.hseparator8);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator8]));
			w22.TopAttach = ((uint)(4));
			w22.BottomAttach = ((uint)(5));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator9 = new global::Gtk.HSeparator ();
			this.hseparator9.Name = "hseparator9";
			this.table1.Add (this.hseparator9);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator9]));
			w23.TopAttach = ((uint)(2));
			w23.BottomAttach = ((uint)(3));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label_blender_path = new global::Gtk.Label ();
			this.label_blender_path.Name = "label_blender_path";
			this.label_blender_path.Xalign = 1F;
			this.label_blender_path.LabelProp = global::Mono.Unix.Catalog.GetString ("Путь к Блендеру (blender.exe)");
			this.table1.Add (this.label_blender_path);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.label_blender_path]));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label_blender_scene = new global::Gtk.Label ();
			this.label_blender_scene.Name = "label_blender_scene";
			this.label_blender_scene.Xalign = 1F;
			this.label_blender_scene.LabelProp = global::Mono.Unix.Catalog.GetString ("Файл сцены (*.blend)");
			this.table1.Add (this.label_blender_scene);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.label_blender_scene]));
			w25.TopAttach = ((uint)(1));
			w25.BottomAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label_format = new global::Gtk.Label ();
			this.label_format.Name = "label_format";
			this.label_format.Xalign = 1F;
			this.label_format.LabelProp = global::Mono.Unix.Catalog.GetString ("Формат вывода");
			this.table1.Add (this.label_format);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1 [this.label_format]));
			w26.TopAttach = ((uint)(9));
			w26.BottomAttach = ((uint)(10));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label_jamp3 = new global::Gtk.Label ();
			this.label_jamp3.Name = "label_jamp3";
			this.label_jamp3.Xalign = 1F;
			this.label_jamp3.LabelProp = global::Mono.Unix.Catalog.GetString ("Потоки");
			this.table1.Add (this.label_jamp3);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1 [this.label_jamp3]));
			w27.TopAttach = ((uint)(12));
			w27.BottomAttach = ((uint)(13));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinbutton_threads = new global::Gtk.SpinButton (0D, 100D, 1D);
			this.spinbutton_threads.CanFocus = true;
			this.spinbutton_threads.Name = "spinbutton_threads";
			this.spinbutton_threads.Adjustment.PageIncrement = 10D;
			this.spinbutton_threads.ClimbRate = 1D;
			this.spinbutton_threads.Numeric = true;
			this.table1.Add (this.spinbutton_threads);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1 [this.spinbutton_threads]));
			w28.TopAttach = ((uint)(12));
			w28.BottomAttach = ((uint)(13));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.checkbutton_range_use = new global::Gtk.CheckButton ();
			this.checkbutton_range_use.CanFocus = true;
			this.checkbutton_range_use.Name = "checkbutton_range_use";
			this.checkbutton_range_use.Label = global::Mono.Unix.Catalog.GetString ("Установить диапазон кадров");
			this.checkbutton_range_use.DrawIndicator = true;
			this.checkbutton_range_use.UseUnderline = true;
			this.vbox8.Add (this.checkbutton_range_use);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.checkbutton_range_use]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.vbox8.Add (this.alignment7);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.alignment7]));
			w30.Position = 1;
			this.table1.Add (this.vbox8);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1 [this.vbox8]));
			w31.TopAttach = ((uint)(14));
			w31.BottomAttach = ((uint)(15));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.checkbutton_range_use.Clicked += new global::System.EventHandler (this.OnCheckbuttonRangeUseClicked);
			this.spinbutton_threads.Changed += new global::System.EventHandler (this.OnSpinbuttonThreadsChanged);
			this.framerange.ChangeWidget += new global::System.EventHandler (this.OnFramerangeChangeWidget);
			this.fileopendlg_script.Change += new global::System.EventHandler (this.OnFileopendlgScriptChange);
			this.fileopendlg_scene_path.Change += new global::System.EventHandler (this.OnFileopendlgScenePathChange);
			this.fileopendlg_outs.Change += new global::System.EventHandler (this.OnFileopendlgOutsChange);
			this.fileopendlg_blender_path.Change += new global::System.EventHandler (this.OnFileopendlgBlenderPathChange);
			this.entry_script_arg.Changed += new global::System.EventHandler (this.OnEntryScriptArgChanged);
			this.combolist_scene.Change += new global::System.EventHandler (this.OnCombolistSceneChange);
			this.combobox_format.Changed += new global::System.EventHandler (this.OnComboboxFormatChanged);
			this.checkbutton_use_script_arg.Clicked += new global::System.EventHandler (this.OnCheckbuttonUseScriptArgClicked);
			this.checkbutton_use_script.Clicked += new global::System.EventHandler (this.OnCheckbuttonUseScriptClicked);
			this.checkbutton_use_outs.Clicked += new global::System.EventHandler (this.OnCheckbuttonUseOutsClicked);
			this.checkbutton_scene_use.Clicked += new global::System.EventHandler (this.OnCheckbuttonSceneUseClicked);
			this.checkbutton_ext.Clicked += new global::System.EventHandler (this.OnCheckbuttonExtClicked);
		}
	}
}
