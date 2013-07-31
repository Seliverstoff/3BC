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
	public partial class GUI_AS : GUI_renders
	{
		public Dictionary<String, String> def_out = new Dictionary<String, String> ();

		public GUI_AS ()
		{
			this.Build ();
		}

		public void SetDef (Dictionary<String, String> def)
		{

			fileopendlg_path.Text = def["render_as_path"];
			fileopendlg_scene_path.Text = def["render_as_scene_path"];
			SetCheckBoxValue(def["render_as_render_settings_use"], checkbutton_rsett_use);
			SetCheckBoxValue(def["render_as_sets_aa"], checkbutton_aa);
			SetCheckBoxValue(def["render_as_sets_shapefx"], checkbutton_shapefx);
			SetCheckBoxValue(def["render_as_sets_layerfx"], checkbutton_layerfx);
			SetCheckBoxValue(def["render_as_sets_halfsize"], checkbutton_halfsize);
			SetCheckBoxValue(def["render_as_sets_halffps"], checkbutton_halffps);
			SetCheckBoxValue(def["render_as_sets_fewparticles"], checkbutton_particles);
			SetCheckBoxValue(def["render_as_sets_extrasmooth"], checkbutton_smooth);
			SetCheckBoxValue(def["render_as_sets_ntscsafe"], checkbutton_ntsc);
			SetCheckBoxValue(def["render_as_sets_premultiplay"], checkbutton_alpha);
			SetCheckBoxValue(def["render_as_sets_variablewidth"], checkbutton_linewidth);
			SetCheckBoxValue(def["render_as_range_use"], checkbutton_range_use);
			fileopendlg_outs.Text = def["render_as_outs"];
			SetCheckBoxValue(def["render_as_outs_use"], checkbutton_outs_use);
			framerange.SetValueString (def["render_as_range"]); 
			framerange._end = int.Parse(def["render_as_range_end"]);
			framerange._jamp = int.Parse(def["render_as_range_jamp"]);
			framerange._step = int.Parse(def["render_as_range_step"]);
			framerange._start = int.Parse(def["render_as_range_start"]);
			combobox_outs_format.Active = int.Parse(def["render_as_outs_format"]);
			SetCheckBoxValue(def["render_as_varbose_use"], checkbutton_verbose);

			ShowRenderSettingsGroup (checkbutton_rsett_use.Active);
			ShowOutsGroup (checkbutton_outs_use.Active);
			ShowRangeGroup (checkbutton_range_use.Active);

			def_out = def;
		}

		public void GetDef ()
		{

			def_out ["render_as_path"] = fileopendlg_path.Text;
			def_out ["render_as_scene_path"] = fileopendlg_scene_path.Text;
			def_out ["render_as_render_settings_use"] = GetCheckBoxValue (checkbutton_rsett_use);
			def_out ["render_as_sets_aa"] = GetCheckBoxValue (checkbutton_aa);
			def_out ["render_as_sets_shapefx"] = GetCheckBoxValue (checkbutton_shapefx);
			def_out ["render_as_sets_layerfx"] = GetCheckBoxValue (checkbutton_layerfx);
			def_out ["render_as_sets_halfsize"] = GetCheckBoxValue (checkbutton_halfsize);
			def_out ["render_as_sets_halffps"] = GetCheckBoxValue (checkbutton_halffps);
			def_out ["render_as_sets_fewparticles"] = GetCheckBoxValue (checkbutton_particles);
			def_out ["render_as_sets_extrasmooth"] = GetCheckBoxValue (checkbutton_smooth);
			def_out ["render_as_sets_ntscsafe"] = GetCheckBoxValue (checkbutton_ntsc);
			def_out ["render_as_sets_premultiplay"] = GetCheckBoxValue (checkbutton_alpha);
			def_out ["render_as_sets_variablewidth"] = GetCheckBoxValue (checkbutton_linewidth);
			def_out ["render_as_outs_use"] = GetCheckBoxValue (checkbutton_outs_use);
			def_out ["render_as_outs"] = fileopendlg_outs.Text;
			def_out ["render_as_range_use"] = GetCheckBoxValue (checkbutton_range_use);
			def_out ["render_as_range_start"] = framerange._start.ToString();
			def_out ["render_as_range_end"] = framerange._end.ToString();
			def_out ["render_as_range_jamp"] = framerange._jamp.ToString();
			def_out ["render_as_range_step"] = framerange._step.ToString(); 
			def_out ["render_as_range"] = framerange.GetValueString ();
			def_out ["render_as_outs_format"] = combobox_outs_format.Active.ToString ();
			def_out ["render_as_varbose_use"] = GetCheckBoxValue (checkbutton_verbose);
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

		private void ShowRenderSettingsGroup(Boolean vl){
			vbox_renders_setting.Visible = vl;
		}

		private void ShowOutsGroup(Boolean vl){
			vbox_outs.Visible = vl;
		}

		private void ShowRangeGroup(Boolean vl){
			framerange.Visible = vl;
		}



		private void Calc(){

			GetDef ();

			OnChangeWidget (EventArgs.Empty);
		}
		
		protected void OnFileopendlgPathChange (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnFileopendlgScenePathChange (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonRsettUseClicked (object sender, EventArgs e)
		{
			ShowRenderSettingsGroup (checkbutton_rsett_use.Active);
			Calc ();
		}

		protected void OnCheckbuttonAaClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonShapefxClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonLayerfxClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonHalfsizeClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonHalffpsClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonParticlesClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonSmoothClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonNtscClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonAlphaClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonLinewidthClicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonRangeUseClicked (object sender, EventArgs e)
		{
			ShowRangeGroup (checkbutton_range_use.Active);
			Calc ();
		}

		protected void OnFramerangeChangeWidget (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonOutsUseClicked (object sender, EventArgs e)
		{
			ShowOutsGroup (checkbutton_outs_use.Active);
			Calc ();
		}

		protected void OnFileopendlgOutsChange (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnComboboxOutsFormatChanged (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbuttonVerboseClicked (object sender, EventArgs e)
		{
			Calc ();
		}
	}
}

