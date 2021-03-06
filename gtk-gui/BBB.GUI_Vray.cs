
// This file has been generated by the GUI designer. Do not modify.
namespace BBB
{
	public partial class GUI_Vray
	{
		private global::Gtk.Table table2;
		private global::Gtk.CheckButton checkbutton_include_use;
		private global::BBB.fileList filelist_include;
		private global::BBB.fileOpenDlg fileopendlg_scene_path;
		private global::BBB.fileOpenDlg fileopendlg_vray_path;
		private global::BBB.frameRange framerange;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.HSeparator hseparator2;
		private global::Gtk.HSeparator hseparator4;
		private global::Gtk.HSeparator hseparator5;
		private global::Gtk.HSeparator hseparator6;
		private global::Gtk.HSeparator hseparator7;
		private global::Gtk.Label label_vray_path;
		private global::Gtk.Label label20;
		private global::Gtk.Label label21;
		private global::Gtk.SpinButton spinbutton_threads;
		private global::Gtk.VBox vbox_display;
		private global::Gtk.CheckButton checkbutton_show_srgb;
		private global::Gtk.CheckButton checkbutton_show_lut;
		private global::Gtk.CheckButton checkbutton_show_aspect;
		private global::Gtk.CheckButton checkbutton_autoclose;
		private global::Gtk.CheckButton checkbutton_autofocus;
		private global::Gtk.VBox vbox_outs;
		private global::BBB.fileOpenDlg fileopendlg_outs_dir;
		private global::BBB.imageSize imagesize;
		private global::BBB.regionArea regionarea_region;
		private global::BBB.regionArea regionarea_crop;
		private global::Gtk.VBox vbox2;
		private global::Gtk.CheckButton checkbutton_display;
		private global::Gtk.VBox vbox4;
		private global::Gtk.CheckButton checkbutton_outs_use;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.VBox vbox7;
		private global::Gtk.CheckButton checkbutton_framerange_use;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BBB.GUI_Vray
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BBB.GUI_Vray";
			// Container child BBB.GUI_Vray.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(10)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.checkbutton_include_use = new global::Gtk.CheckButton ();
			this.checkbutton_include_use.CanFocus = true;
			this.checkbutton_include_use.Name = "checkbutton_include_use";
			this.checkbutton_include_use.Label = global::Mono.Unix.Catalog.GetString ("Присоеденить сцены");
			this.checkbutton_include_use.DrawIndicator = true;
			this.checkbutton_include_use.UseUnderline = true;
			this.table2.Add (this.checkbutton_include_use);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table2 [this.checkbutton_include_use]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(0));
			w1.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table2.Gtk.Table+TableChild
			this.filelist_include = new global::BBB.fileList ();
			this.filelist_include.Events = ((global::Gdk.EventMask)(256));
			this.filelist_include.Name = "filelist_include";
			this.table2.Add (this.filelist_include);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.filelist_include]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fileopendlg_scene_path = new global::BBB.fileOpenDlg ();
			this.fileopendlg_scene_path.Events = ((global::Gdk.EventMask)(256));
			this.fileopendlg_scene_path.Name = "fileopendlg_scene_path";
			this.fileopendlg_scene_path.CheckType = true;
			this.fileopendlg_scene_path.filterName = "Файл сцены для V-ray - *.vrscene";
			this.fileopendlg_scene_path.filterExec = "*.vrscene";
			this.table2.Add (this.fileopendlg_scene_path);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.fileopendlg_scene_path]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fileopendlg_vray_path = new global::BBB.fileOpenDlg ();
			this.fileopendlg_vray_path.Events = ((global::Gdk.EventMask)(256));
			this.fileopendlg_vray_path.Name = "fileopendlg_vray_path";
			this.fileopendlg_vray_path.CheckType = true;
			this.fileopendlg_vray_path.filterName = "Файл программы vray.exe";
			this.fileopendlg_vray_path.filterExec = "vray.exe";
			this.table2.Add (this.fileopendlg_vray_path);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.fileopendlg_vray_path]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.framerange = new global::BBB.frameRange ();
			this.framerange.Events = ((global::Gdk.EventMask)(256));
			this.framerange.Name = "framerange";
			this.framerange._end = 0;
			this.framerange._step = 0;
			this.framerange._jamp = 0;
			this.framerange._start = 0;
			this.table2.Add (this.framerange);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.framerange]));
			w5.TopAttach = ((uint)(9));
			w5.BottomAttach = ((uint)(10));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.table2.Add (this.hseparator1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.hseparator1]));
			w6.TopAttach = ((uint)(6));
			w6.BottomAttach = ((uint)(7));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.table2.Add (this.hseparator2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2 [this.hseparator2]));
			w7.TopAttach = ((uint)(6));
			w7.BottomAttach = ((uint)(7));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hseparator4 = new global::Gtk.HSeparator ();
			this.hseparator4.Name = "hseparator4";
			this.table2.Add (this.hseparator4);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2 [this.hseparator4]));
			w8.TopAttach = ((uint)(4));
			w8.BottomAttach = ((uint)(5));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hseparator5 = new global::Gtk.HSeparator ();
			this.hseparator5.Name = "hseparator5";
			this.table2.Add (this.hseparator5);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2 [this.hseparator5]));
			w9.TopAttach = ((uint)(4));
			w9.BottomAttach = ((uint)(5));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hseparator6 = new global::Gtk.HSeparator ();
			this.hseparator6.Name = "hseparator6";
			this.table2.Add (this.hseparator6);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2 [this.hseparator6]));
			w10.TopAttach = ((uint)(8));
			w10.BottomAttach = ((uint)(9));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hseparator7 = new global::Gtk.HSeparator ();
			this.hseparator7.Name = "hseparator7";
			this.table2.Add (this.hseparator7);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2 [this.hseparator7]));
			w11.TopAttach = ((uint)(8));
			w11.BottomAttach = ((uint)(9));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label_vray_path = new global::Gtk.Label ();
			this.label_vray_path.Name = "label_vray_path";
			this.label_vray_path.Xalign = 1F;
			this.label_vray_path.LabelProp = global::Mono.Unix.Catalog.GetString ("Путь к Vray (vray.exe)");
			this.table2.Add (this.label_vray_path);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2 [this.label_vray_path]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.Xalign = 1F;
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("Количество потоков");
			this.table2.Add (this.label20);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.label20]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table2.Gtk.Table+TableChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.Xalign = 1F;
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("Файл сцены (*.vrscene)");
			this.table2.Add (this.label21);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.label21]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.spinbutton_threads = new global::Gtk.SpinButton (0D, 100D, 1D);
			this.spinbutton_threads.CanFocus = true;
			this.spinbutton_threads.Name = "spinbutton_threads";
			this.spinbutton_threads.Adjustment.PageIncrement = 10D;
			this.spinbutton_threads.ClimbRate = 1D;
			this.spinbutton_threads.Numeric = true;
			this.table2.Add (this.spinbutton_threads);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2 [this.spinbutton_threads]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.vbox_display = new global::Gtk.VBox ();
			this.vbox_display.Name = "vbox_display";
			this.vbox_display.Spacing = 6;
			// Container child vbox_display.Gtk.Box+BoxChild
			this.checkbutton_show_srgb = new global::Gtk.CheckButton ();
			this.checkbutton_show_srgb.CanFocus = true;
			this.checkbutton_show_srgb.Name = "checkbutton_show_srgb";
			this.checkbutton_show_srgb.Label = global::Mono.Unix.Catalog.GetString ("Отображение SRGB");
			this.checkbutton_show_srgb.DrawIndicator = true;
			this.checkbutton_show_srgb.UseUnderline = true;
			this.vbox_display.Add (this.checkbutton_show_srgb);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox_display [this.checkbutton_show_srgb]));
			w16.Position = 0;
			// Container child vbox_display.Gtk.Box+BoxChild
			this.checkbutton_show_lut = new global::Gtk.CheckButton ();
			this.checkbutton_show_lut.CanFocus = true;
			this.checkbutton_show_lut.Name = "checkbutton_show_lut";
			this.checkbutton_show_lut.Label = global::Mono.Unix.Catalog.GetString ("Отображение LUT");
			this.checkbutton_show_lut.DrawIndicator = true;
			this.checkbutton_show_lut.UseUnderline = true;
			this.vbox_display.Add (this.checkbutton_show_lut);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox_display [this.checkbutton_show_lut]));
			w17.Position = 1;
			// Container child vbox_display.Gtk.Box+BoxChild
			this.checkbutton_show_aspect = new global::Gtk.CheckButton ();
			this.checkbutton_show_aspect.CanFocus = true;
			this.checkbutton_show_aspect.Name = "checkbutton_show_aspect";
			this.checkbutton_show_aspect.Label = global::Mono.Unix.Catalog.GetString ("Отображение аспекта разрешения");
			this.checkbutton_show_aspect.DrawIndicator = true;
			this.checkbutton_show_aspect.UseUnderline = true;
			this.vbox_display.Add (this.checkbutton_show_aspect);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox_display [this.checkbutton_show_aspect]));
			w18.Position = 2;
			// Container child vbox_display.Gtk.Box+BoxChild
			this.checkbutton_autoclose = new global::Gtk.CheckButton ();
			this.checkbutton_autoclose.CanFocus = true;
			this.checkbutton_autoclose.Name = "checkbutton_autoclose";
			this.checkbutton_autoclose.Label = global::Mono.Unix.Catalog.GetString ("Атоматическое закрытие окна");
			this.checkbutton_autoclose.DrawIndicator = true;
			this.checkbutton_autoclose.UseUnderline = true;
			this.vbox_display.Add (this.checkbutton_autoclose);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox_display [this.checkbutton_autoclose]));
			w19.Position = 3;
			// Container child vbox_display.Gtk.Box+BoxChild
			this.checkbutton_autofocus = new global::Gtk.CheckButton ();
			this.checkbutton_autofocus.CanFocus = true;
			this.checkbutton_autofocus.Name = "checkbutton_autofocus";
			this.checkbutton_autofocus.Label = global::Mono.Unix.Catalog.GetString ("Автоматическая фокусировка на окно");
			this.checkbutton_autofocus.Active = true;
			this.checkbutton_autofocus.DrawIndicator = true;
			this.checkbutton_autofocus.UseUnderline = true;
			this.vbox_display.Add (this.checkbutton_autofocus);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox_display [this.checkbutton_autofocus]));
			w20.Position = 4;
			this.table2.Add (this.vbox_display);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2 [this.vbox_display]));
			w21.TopAttach = ((uint)(5));
			w21.BottomAttach = ((uint)(6));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.vbox_outs = new global::Gtk.VBox ();
			this.vbox_outs.Name = "vbox_outs";
			this.vbox_outs.Spacing = 6;
			// Container child vbox_outs.Gtk.Box+BoxChild
			this.fileopendlg_outs_dir = new global::BBB.fileOpenDlg ();
			this.fileopendlg_outs_dir.Events = ((global::Gdk.EventMask)(256));
			this.fileopendlg_outs_dir.Name = "fileopendlg_outs_dir";
			this.fileopendlg_outs_dir.CheckType = false;
			this.vbox_outs.Add (this.fileopendlg_outs_dir);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox_outs [this.fileopendlg_outs_dir]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox_outs.Gtk.Box+BoxChild
			this.imagesize = new global::BBB.imageSize ();
			this.imagesize.Events = ((global::Gdk.EventMask)(256));
			this.imagesize.Name = "imagesize";
			this.vbox_outs.Add (this.imagesize);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox_outs [this.imagesize]));
			w23.Position = 1;
			// Container child vbox_outs.Gtk.Box+BoxChild
			this.regionarea_region = new global::BBB.regionArea ();
			this.regionarea_region.Events = ((global::Gdk.EventMask)(256));
			this.regionarea_region.Name = "regionarea_region";
			this.regionarea_region.CheckBtn = false;
			this.regionarea_region.mType = 0;
			this.regionarea_region.labelText = "Регион";
			this.vbox_outs.Add (this.regionarea_region);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox_outs [this.regionarea_region]));
			w24.Position = 2;
			// Container child vbox_outs.Gtk.Box+BoxChild
			this.regionarea_crop = new global::BBB.regionArea ();
			this.regionarea_crop.Events = ((global::Gdk.EventMask)(256));
			this.regionarea_crop.Name = "regionarea_crop";
			this.regionarea_crop.CheckBtn = false;
			this.regionarea_crop.mType = 0;
			this.regionarea_crop.labelText = "Обрезка";
			this.vbox_outs.Add (this.regionarea_crop);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox_outs [this.regionarea_crop]));
			w25.Position = 3;
			this.table2.Add (this.vbox_outs);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2 [this.vbox_outs]));
			w26.TopAttach = ((uint)(7));
			w26.BottomAttach = ((uint)(8));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.checkbutton_display = new global::Gtk.CheckButton ();
			this.checkbutton_display.CanFocus = true;
			this.checkbutton_display.Name = "checkbutton_display";
			this.checkbutton_display.Label = global::Mono.Unix.Catalog.GetString ("Отображать рендер");
			this.checkbutton_display.Active = true;
			this.checkbutton_display.DrawIndicator = true;
			this.checkbutton_display.UseUnderline = true;
			this.vbox2.Add (this.checkbutton_display);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.checkbutton_display]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			this.table2.Add (this.vbox2);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table2 [this.vbox2]));
			w28.TopAttach = ((uint)(5));
			w28.BottomAttach = ((uint)(6));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.checkbutton_outs_use = new global::Gtk.CheckButton ();
			this.checkbutton_outs_use.CanFocus = true;
			this.checkbutton_outs_use.Name = "checkbutton_outs_use";
			this.checkbutton_outs_use.Label = global::Mono.Unix.Catalog.GetString ("Перенастроить вывод");
			this.checkbutton_outs_use.DrawIndicator = true;
			this.checkbutton_outs_use.UseUnderline = true;
			this.vbox4.Add (this.checkbutton_outs_use);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.checkbutton_outs_use]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.vbox4.Add (this.alignment2);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.alignment2]));
			w30.Position = 1;
			this.table2.Add (this.vbox4);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table2 [this.vbox4]));
			w31.TopAttach = ((uint)(7));
			w31.BottomAttach = ((uint)(8));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.checkbutton_framerange_use = new global::Gtk.CheckButton ();
			this.checkbutton_framerange_use.CanFocus = true;
			this.checkbutton_framerange_use.Name = "checkbutton_framerange_use";
			this.checkbutton_framerange_use.Label = global::Mono.Unix.Catalog.GetString ("Задать диапазон");
			this.checkbutton_framerange_use.DrawIndicator = true;
			this.checkbutton_framerange_use.UseUnderline = true;
			this.vbox7.Add (this.checkbutton_framerange_use);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.checkbutton_framerange_use]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			this.table2.Add (this.vbox7);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table2 [this.vbox7]));
			w33.TopAttach = ((uint)(9));
			w33.BottomAttach = ((uint)(10));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.checkbutton_framerange_use.Clicked += new global::System.EventHandler (this.OnCheckbuttonFramerangeUseClicked);
			this.checkbutton_outs_use.Clicked += new global::System.EventHandler (this.OnCheckbuttonOutsUseClicked);
			this.checkbutton_display.Clicked += new global::System.EventHandler (this.OnCheckbuttonDisplayClicked);
			this.fileopendlg_outs_dir.Change += new global::System.EventHandler (this.OnFileopendlgOutsDirChange);
			this.imagesize.ChangeWidget += new global::System.EventHandler (this.OnImagesizeChangeWidget);
			this.regionarea_region.ChangeWidget += new global::System.EventHandler (this.OnRegionareaRegionChangeWidget);
			this.regionarea_crop.ChangeWidget += new global::System.EventHandler (this.OnRegionareaCropChangeWidget);
			this.checkbutton_show_srgb.Clicked += new global::System.EventHandler (this.OnCheckbuttonShowSrgbClicked);
			this.checkbutton_show_lut.Clicked += new global::System.EventHandler (this.OnCheckbuttonShowLutClicked);
			this.checkbutton_show_aspect.Clicked += new global::System.EventHandler (this.OnCheckbuttonShowAspectClicked);
			this.checkbutton_autoclose.Clicked += new global::System.EventHandler (this.OnCheckbuttonAutocloseClicked);
			this.checkbutton_autofocus.Clicked += new global::System.EventHandler (this.OnCheckbuttonAutofocusClicked);
			this.spinbutton_threads.Changed += new global::System.EventHandler (this.OnSpinbuttonThreadsChanged);
			this.framerange.ChangeWidget += new global::System.EventHandler (this.OnFramerangeChangeWidget);
			this.fileopendlg_vray_path.Change += new global::System.EventHandler (this.OnFileopendlgVrayPathChange);
			this.fileopendlg_scene_path.Change += new global::System.EventHandler (this.OnFileopendlgScenePathChange);
			this.checkbutton_include_use.Clicked += new global::System.EventHandler (this.OnCheckbuttonIncludeUseClicked);
		}
	}
}
