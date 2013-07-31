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
	public partial class GUI_Vue : GUI_renders
	{
		public Dictionary<String, String> def_out = new Dictionary<String, String> ();

		public GUI_Vue ()
		{
			this.Build ();
			argStr[0] = "script_vue";
		}
		
		public void SetDef (Dictionary<String, String> def)
		{
			fileopendlg_vue_path.Text = def["render_vue_path"];
			fileopendlg_scene_path.Text = def["render_vue_scene_path"];
			SetCheckBoxValue(def["render_vue_outs_use"], checkbutton_outs_use);
			fileopendlg_outs.Text = def["render_vue_outs"];
			SetCheckBoxValue(def["render_vue_range_use"], checkbutton_range_use);
			framerange._end = int.Parse(def["render_vue_range_end"]);
			framerange._jamp = int.Parse(def["render_vue_range_jamp"]);
			framerange._step = int.Parse(def["render_vue_range_step"]);
			framerange._start = int.Parse(def["render_vue_range_start"]);
			framerange.SetValueString (def["render_vue_range"]); 
			regionarea.Value = def["render_vue_tile_value"];
			regionarea.Use = def["render_vue_tile_use"];
			SetCheckBoxValue(def["render_vue_job_use"], checkbutton_job_use);
			spinbutton_job.Value = int.Parse(def["render_vue_job_value"]);
			def_out = def;
		}

		public void GetDef ()
		{
			def_out ["render_vue_path"] = fileopendlg_vue_path.Text;
			def_out ["render_vue_scene_path"] = fileopendlg_scene_path.Text;
			def_out ["render_vue_outs_use"] = GetCheckBoxValue (checkbutton_outs_use);
			def_out ["render_vue_outs"] = fileopendlg_outs.Text;
			def_out ["render_vue_range_use"] = GetCheckBoxValue (checkbutton_range_use);
			def_out ["render_vue_range"] = framerange.GetValueString ();
			def_out ["render_vue_range_start"] = framerange._start.ToString();
			def_out ["render_vue_range_end"] = framerange._end.ToString();
			def_out ["render_vue_range_jamp"] = framerange._jamp.ToString();
			def_out ["render_vue_range_step"] = framerange._step.ToString(); 
			def_out ["render_vue_tile_use"] = regionarea.Use;
			def_out ["render_vue_tile_value"] = regionarea.Value;
			def_out ["render_vue_job_use"] = GetCheckBoxValue (checkbutton_job_use);
			def_out ["render_vue_job_value"] = spinbutton_job.Value.ToString (); 
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

		protected void OnFileopendlg1Change (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnFileopendlg3Change (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnFileopendlg2Change (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbutton1Clicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbutton2Clicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnFramerange1ChangeWidget (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnCheckbutton3Clicked (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnSpinbutton1Changed (object sender, EventArgs e)
		{
			Calc ();
		}

		protected void OnRegionareaChangeWidget (object sender, EventArgs e)
		{
			Calc ();
		}
	}
}

