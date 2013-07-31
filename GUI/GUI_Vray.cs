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
	public partial class GUI_Vray : GUI_renders
	{
		public Dictionary<String, String> def_out = new Dictionary<String, String> ();

		public GUI_Vray ()
		{
			this.Build ();

		}

		public void SetDef (Dictionary<String, String> def)
		{
			fileopendlg_vray_path.Text = def["render_vray_path"];
			fileopendlg_scene_path.Text = def["render_vray_scene_path"];
			SetCheckBoxValue (def["render_vray_include_list_use"], checkbutton_include_use);
			filelist_include.Text = def["render_vray_include_list"];
			spinbutton_threads.Value = int.Parse(def["render_vray_threads"]);
			SetCheckBoxValue(def["render_vray_display_use"], checkbutton_display);
			SetCheckBoxValue(def["render_vray_display_srgb"], checkbutton_show_srgb);
			SetCheckBoxValue(def["render_vray_display_lut"], checkbutton_show_lut);
			SetCheckBoxValue(def["render_vray_display_aspect"], checkbutton_show_aspect);
			SetCheckBoxValue(def["render_vray_display_autoclose"], checkbutton_autoclose);
			SetCheckBoxValue(def["render_vray_display_autofocus"], checkbutton_autofocus);
			SetCheckBoxValue(def["render_vray_outs_use"], checkbutton_outs_use);
			fileopendlg_outs_dir.Text = def["render_vray_outs"];
			imagesize.Value = def["render_vray_dimensions"];
			imagesize.Use = def["render_vray_dimensions_use"];
			regionarea_region.Value = def["render_vray_regoin"];
			regionarea_region.Use = def["render_vray_regoin_use"];
			regionarea_crop.Value = def["render_vray_crop"];
			regionarea_crop.Use = def["render_vray_crop_use"];
			SetCheckBoxValue(def["render_vray_range_use"], checkbutton_framerange_use);
			framerange._end = int.Parse(def["render_vray_range_end"]);
			framerange._jamp = int.Parse(def["render_vray_range_jamp"]);
			framerange._step = int.Parse(def["render_vray_range_step"]);
			framerange._start = int.Parse(def["render_vray_range_start"]);
			framerange.SetValueString (def["render_vray_range"]);

			ShowDisplayGroup (checkbutton_display.Active);
			ShowFramerangeGroup (checkbutton_framerange_use.Active);
			ShowOutsGroup (checkbutton_outs_use.Active);

			def_out = def;
		}

		public void GetDef ()
		{
			def_out["render_vray_path"] = fileopendlg_vray_path.Text;
			def_out["render_vray_scene_path"] = fileopendlg_scene_path.Text;
			def_out["render_vray_include_list_use"] = GetCheckBoxValue(checkbutton_include_use);
			def_out["render_vray_include_list"] = filelist_include.Text;
			def_out["render_vray_threads"] = spinbutton_threads.Value.ToString();
			def_out["render_vray_display_use"] = GetCheckBoxValue(checkbutton_display);
			def_out["render_vray_display_srgb"] = GetCheckBoxValue(checkbutton_show_srgb);
			def_out["render_vray_display_lut"] = GetCheckBoxValue(checkbutton_show_lut);
			def_out["render_vray_display_aspect"] = GetCheckBoxValue(checkbutton_show_aspect);
			def_out["render_vray_display_autoclose"] = GetCheckBoxValue(checkbutton_autoclose);
			def_out["render_vray_display_autofocus"] = GetCheckBoxValue(checkbutton_autofocus);
			def_out["render_vray_outs_use"] = GetCheckBoxValue(checkbutton_outs_use);
			def_out["render_vray_outs"] = fileopendlg_outs_dir.Text;
			def_out["render_vray_dimensions_use"] = imagesize.Use;
			def_out["render_vray_dimensions"] = imagesize.Value;
			def_out["render_vray_regoin_use"] = regionarea_crop.Use;
			def_out["render_vray_regoin"] = regionarea_crop.Value;
			def_out["render_vray_crop_use"] = regionarea_region.Use;
			def_out["render_vray_crop"] = regionarea_region.Value;
			def_out["render_vray_range_use"] = GetCheckBoxValue(checkbutton_framerange_use);
			def_out["render_vray_range"] = framerange.GetValueString ();
			def_out["render_vray_range_start"] = framerange._start.ToString();
			def_out["render_vray_range_end"] = framerange._end.ToString();
			def_out["render_vray_range_jamp"] = framerange._jamp.ToString();
			def_out["render_vray_range_step"] = framerange._step.ToString();
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

		private void Calc(){

			GetDef ();

			OnChangeWidget (EventArgs.Empty);
		}

		private void ShowDisplayGroup(Boolean vl){
			vbox_display.Visible = vl;
		}

		private void ShowOutsGroup(Boolean vl){
			vbox_outs.Visible = vl;
		}

		private void ShowFramerangeGroup(Boolean vl){
			framerange.Visible = vl;
		}

		protected void OnCheckbuttonDisplayClicked (object sender, EventArgs e)
		{
			Calc ();
			ShowDisplayGroup (checkbutton_display.Active);
		}

		protected void OnCheckbuttonOutsUseClicked (object sender, EventArgs e)
		{
			Calc ();
			ShowOutsGroup (checkbutton_outs_use.Active);
		}

		protected void OnCheckbuttonFramerangeUseClicked (object sender, EventArgs e)
		{
			Calc ();
			ShowFramerangeGroup (checkbutton_framerange_use.Active);
		}

		protected void OnFileopendlgVrayPathChange (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnFileopendlgScenePathChange (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnSpinbuttonThreadsChanged (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonIncludeUseClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonShowSrgbClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonShowLutClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonShowAspectClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonAutocloseClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonAutofocusClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnFileopendlgOutsDirChange (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnFramerangeChangeWidget (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnImagesizeChangeWidget (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnRegionareaRegionChangeWidget (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnRegionareaCropChangeWidget (object sender, EventArgs e)
		{
			Calc ();
		}
	}
}

