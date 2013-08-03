//  Backburner Bat Creater (3BC)
//
//  http://seliverstoff.blogspot.ru/search/label/3BC
//
//  Author: Maxim A. Seliverstov (aka Seliverstoff)
//  E-Mail: maxim@seliverstoff.ru
//
//  This program is free software; you can redistribute it and/or
//  modify it under the terms of the GNU General Public License
//  as published by the Free Software Foundation; either version 2
//  of the License, or (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
//  All Rights Reserved. Backburner(R) is a registered trademark of Autodesk, Inc.


using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using Gtk;

namespace BBB
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class GUI_Blender : GUI_renders
	{

		private Dictionary<int, String[]> format_list = new Dictionary<int, String[]> ();
		public Dictionary<String, String> def_out = new Dictionary<String, String> ();

		public GUI_Blender ()
		{
			this.Build ();
			CreateListFormat ();
			SensetiveOutsGroup (checkbutton_use_outs.Active);
			SensetiveScriptGroup (checkbutton_use_script.Active);
			SensitiveRangeGroup (checkbutton_range_use.Active);
		}

		public void SetDef (Dictionary<String, String> def)
		{
			fileopendlg_blender_path.Text = def["render_blender_path"];
			fileopendlg_scene_path.Text = def["render_blender_scene_path"];
			fileopendlg_script.Text = def ["render_blender_script"];
			entry_script_arg.Text = def["render_blender_script_arg"];
			fileopendlg_outs.Text = def ["render_blender_outs"];
			combobox_format.Active = int.Parse (def ["render_blender_format"]);
			spinbutton_threads.Value = int.Parse (def ["render_blender_threads"]);
			framerange.SetValueString (def ["render_blender_range"]);


			framerange._end = int.Parse (def ["render_blender_range_end"]);
			framerange._step = int.Parse (def ["render_blender_range_step"]);
			framerange._jamp = int.Parse (def ["render_blender_range_jamp"]);
			framerange._start = int.Parse (def ["render_blender_range_start"]);
			combolist_scene.Text = def ["render_blender_scene"];

			SetCheckBoxValue (def ["render_blender_ext"], checkbutton_ext);
			SetCheckBoxValue (def ["render_blender_outs_use"], checkbutton_use_outs);
			SetCheckBoxValue (def ["render_blender_script_use"], checkbutton_use_script);
			SetCheckBoxValue (def ["render_blender_scene_use"], checkbutton_scene_use);
			SetCheckBoxValue (def ["render_blender_script_arg_use"], checkbutton_use_script_arg);
			SetCheckBoxValue (def ["render_blender_range_use"], checkbutton_range_use);

			def_out = def;
		}

		public void GetDef ()
		{
			def_out ["render_blender_path"] = fileopendlg_blender_path.Text;
			def_out ["render_blender_scene_path"] = fileopendlg_scene_path.Text;
			def_out ["render_blender_script"] = fileopendlg_script.Text;
			def_out ["render_blender_script_arg"] = entry_script_arg.Text;
			def_out ["render_blender_outs"] = fileopendlg_outs.Text;
			def_out ["render_blender_format"] = combobox_format.Active.ToString();
			def_out ["render_blender_threads"] = spinbutton_threads.Value.ToString();
			def_out ["render_blender_ext"] = GetCheckBoxValue(checkbutton_ext);
			def_out ["render_blender_outs_use"] = GetCheckBoxValue(checkbutton_use_outs);
			def_out ["render_blender_script_use"] = GetCheckBoxValue(checkbutton_use_script);
			def_out ["render_blender_script_arg_use"] = GetCheckBoxValue(checkbutton_use_script_arg);
			def_out ["render_blender_range_use"] = GetCheckBoxValue(checkbutton_range_use);
			def_out ["render_blender_range"] = framerange.GetValueString();
			def_out ["render_blender_range_start"] = framerange._start.ToString();
			def_out ["render_blender_range_end"] = framerange._end.ToString();
			def_out ["render_blender_range_jamp"] = framerange._jamp.ToString();
			def_out ["render_blender_range_step"] = framerange._step.ToString();
			def_out ["render_blender_scene"] = combolist_scene.Text;
			def_out ["render_blender_scene_use"] = GetCheckBoxValue(checkbutton_scene_use);
		}

		private void SetCheckBoxValue (String val, Gtk.CheckButton btn)
		{
			if (val == "1") {
				btn.Active = true;
			}
			if (val == "0") {
				btn.Active = false;
			}
		}

		private String GetCheckBoxValue (Gtk.CheckButton btn)
		{
			String tmp = String.Empty;
			if (btn.Active == true) {
				tmp = "1";
			}
			if (btn.Active == false) {
				tmp = "0";
			}

			return tmp;
		}

		private void CreateListFormat ()
		{

			format_list.Add (0, new String[] { String.Empty, "Ничего не использовать" });
			format_list.Add (1, new String[] { "TGA", "Targa television format (*.tga)" });
			format_list.Add (2, new String[] { "IRIS", "Iris format" });
			format_list.Add (3, new String[] { "HAMX", "Hamx format" });
			format_list.Add (4, new String[] { "FTYPE", "Ftype format" });
			format_list.Add (5, new String[] { "JPEG", "jpeg format" });
			format_list.Add (6, new String[] { "MOVIE", "Move format" });
			format_list.Add (7, new String[] { "IRIZ", "IRIZ format" });
			format_list.Add (8, new String[] { "RAWTGA", "RAWTGA format" });
			format_list.Add (9, new String[] { "AVIRAW", "AVIRAW format" });
			format_list.Add (10, new String[] { "AVIJPEG", "AVIJPEG format" });
			format_list.Add (11, new String[] { "PNG", "PNG format" });
			format_list.Add (12, new String[] { "BMP", "BMP format" });
			format_list.Add (13, new String[] { "FRAMESERVER", "FRAMESERVER format" });
			format_list.Add (14, new String[] { "HDR", "HDR format" });
			format_list.Add (15, new String[] { "TIFF", "TIFF format" });
			format_list.Add (16, new String[] { "EXR", "EXR format" });
			format_list.Add (17, new String[] { "MPEG", "MPEG format" });
			format_list.Add (18, new String[] { "AVICODEC", "AVICODEC format" });
			format_list.Add (19, new String[] { "QUICKTIME", "QUICKTIME format" });
			format_list.Add (20, new String[] { "CINEON", "CINEON format" });
			format_list.Add (21, new String[] { "DPX", "DPX format" });

			combobox_format.Clear ();
			CellRendererText cell = new CellRendererText ();
			combobox_format.PackStart (cell, false);
			combobox_format.AddAttribute (cell, "text", 0);
			ListStore store = new ListStore (typeof(string));
			combobox_format.Model = store;


			foreach (KeyValuePair<int, String[]> kvp in format_list) {
				store.AppendValues (kvp.Value [1]);
			}

		}

		private String GetScript ()
		{	
			String tmp = String.Empty;
			if (File.Exists (fileopendlg_script.Text) && checkbutton_use_script.Active == true) {
				tmp = " -P \"" + fileopendlg_script.Text + "\"" + GetScriptArg();
			}

			return tmp;
		}

		private String GetScriptArg ()
		{	
			String tmp = String.Empty;
			if (entry_script_arg.Text!=String.Empty && checkbutton_use_script_arg.Active==true) {
				tmp = " -- " + entry_script_arg.Text;
				renderEnable = false;
			}else{
				renderEnable = true;
			}

			return tmp;
		}

		private String GetScene ()
		{	
			String tmp = fileopendlg_scene_path.Text.Trim ();

			if (tmp.Length >= 1) {
				return " -S \"" + tmp + "\"";
			} else {
				return String.Empty;
			}
		}

		private String GetJamp ()
		{	
			double tmp = framerange._jamp;

			if (tmp > 0) {
				return " -j " + tmp;
			} else {
				return String.Empty;
			}
		}

		private String GetOuts ()
		{	
			String tmp = String.Empty;
			if (Directory.Exists (fileopendlg_outs.Text) && checkbutton_use_outs.Active == true) {
				tmp = " -o \"" + fileopendlg_outs.Text + "\\\"" + GetFormat() + GetExt();
			}

			return tmp;
		}

		private String GetFormat ()
		{
			String tmp = String.Empty;
			if (combobox_format.Active > 0 && checkbutton_use_outs.Active == true) {
				tmp = " -F " + format_list [combobox_format.Active] [0];
			} else {
				tmp = String.Empty;
			}
			Console.WriteLine ("format out - " + tmp);
			return tmp;
		}

		private String GetExt ()
		{
			String tmp = String.Empty;

			if (checkbutton_ext.Active == true) {
				tmp = " -x 0";
			}

			if (checkbutton_use_outs.Active == false) {
				tmp = String.Empty;
			}

			return tmp;
		}

		private String GetThreads ()
		{
			double tmp = spinbutton_threads.Value;

			if (tmp > 0) {
				return " -t " + tmp;
			} else {
				return String.Empty;
			}
		}

		private void CreateAllArgs ()
		{

			argStr[0] = GetThreads ();
			argStr[0] += GetScript ();
			if(renderEnable == true){
				argStr[0] += GetScene ();
				argStr[1] = GetJamp ();
				argStr[0] += GetOuts ();
			}

			GetDef ();

			OnChangeWidget (EventArgs.Empty);

		}

		private void SensetiveOutsGroup (Boolean vl)
		{
			//fileopendlg_outs.Sensitive = vl;
			//label_format.Sensitive = vl;
			//checkbutton_ext.Sensitive = vl;
			//combobox_format.Sensitive = vl;
		}

		private void SensetiveScriptGroup (Boolean vl)
		{
			fileopendlg_script.Sensitive = vl;
			//SensetiveScriptArgGroup (checkbutton_use_script_arg.Sensitive);
			checkbutton_use_script_arg.Sensitive = vl;
			entry_script_arg.Sensitive = vl;
		}

		private void SensitiveRangeGroup(Boolean vl)
		{
			framerange.Visible = vl;
		}

		private void SensetiveScriptArgGroup(Boolean vl){
			if(checkbutton_use_script.Active!=false){
				entry_script_arg.Sensitive = vl;
			}
		}

		protected void OnEntryScriptChanged (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnCheckbuttonUseScriptClicked (object sender, EventArgs e)
		{
			CreateAllArgs ();
			SensetiveScriptGroup (checkbutton_use_script.Active);
		}

		protected void OnEntrySceneChanged (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnSpinbuttonJumpChanged (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnCheckbuttonUseOutsClicked (object sender, EventArgs e)
		{
			CreateAllArgs ();
			SensetiveOutsGroup (checkbutton_use_outs.Active);
		}

		protected void OnEntryOutsChanged (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnCheckbuttonExtClicked (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnComboboxFormatChanged (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnSpinbuttonThreadsChanged (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnFileopendlgScriptChange (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnFileopendlgOutsChange (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}
		
		protected void OnEntryScriptArgChanged (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnCheckbuttonUseScriptArgClicked (object sender, EventArgs e)
		{
			CreateAllArgs ();
			SensetiveScriptArgGroup (checkbutton_use_script_arg.Active);
		}

		protected void OnFileopendlgBlenderPathChange (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnFileopendlgScenePathChange (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnCheckbuttonRangeUseClicked (object sender, EventArgs e)
		{
			SensitiveRangeGroup (checkbutton_range_use.Active);
			CreateAllArgs ();
		}

		protected void OnFramerangeChangeWidget (object sender, EventArgs e)
		{
			_start = framerange._start;
			_end = framerange._end;
			_jamp = framerange._jamp;
			_step = framerange._step;
			OnChangeFrameRate (EventArgs.Empty);
			CreateAllArgs ();
		}

		protected void OnCheckbuttonSceneUseClicked (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}

		protected void OnCombolistSceneChange (object sender, EventArgs e)
		{
			CreateAllArgs ();
		}
	}
}

