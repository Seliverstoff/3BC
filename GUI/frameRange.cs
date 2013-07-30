using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

namespace BBB
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class frameRange : Gtk.Bin
	{
		
		public List<List<int>> Value;

		public int _end
		{
			set { spinbutton_end.Value = value; }
			get { return Convert.ToInt32(spinbutton_end.Value); }
		}

		public int _step
		{
			set { spinbutton_step_task.Value = value; }
			get { return Convert.ToInt32(spinbutton_step_task.Value); }
		}

		public int _jamp
		{
			set { spinbutton_jamp.Value = value; }
			get { return Convert.ToInt32(spinbutton_jamp.Value); }
		}

		public int _start 
		{
			set { spinbutton_start.Value = value;}
			get { return Convert.ToInt32(spinbutton_start.Value); }
		}

		public event EventHandler ChangeWidget;

		public frameRange ()
		{
			this.Build ();
		}

		public String GetValueString ()
		{
			return PrintRange ();
		}

		public void SetValueString (String vl)
		{
			entry_range.Text = vl;
		}

		protected virtual void OnChangeWidget (EventArgs e)
		{
			if (ChangeWidget != null) {
				ChangeWidget (this, e);
			}
		}

		protected void OnButtonCleerClicked (object sender, EventArgs e)
		{
			entry_range.Text = String.Empty;
		}

		private void CalcRange ()
		{
			OnChangeWidget (EventArgs.Empty);
		}

		protected void OnEntryRangeChanged (object sender, EventArgs e)
		{
			Value = new List<List<int>> ();
			List<int> smalList;
			String[] tmp1;
			String[] tmp2 = new String[] { };

			String newStr = Regex.Replace(entry_range.Text, "[^0-9,-]", String.Empty);
			newStr = Regex.Replace(newStr, "[,]{2,}", ",");
			newStr = Regex.Replace(newStr, "[-]{2,}", "-");
			entry_range.Text = newStr;

			tmp1 = entry_range.Text.Split(',');

			String tmpOut = String.Empty;

			for(int i=0; tmp1.Length>i; ++i){
				smalList = new List<int> ();
				tmp2 = new String[] { };
				tmp2 = tmp1[i].Split('-');
				if(tmp1[i]!=String.Empty){

				for (int j=0; tmp2.Length>j; ++j){
					if(tmp2[j]!=String.Empty){
						smalList.Add(int.Parse(tmp2[j]));
					}
				}
				Value.Add(smalList);
				}
			}
			PrintRange();
			SensetiveGroupRange();
			OnChangeWidget (EventArgs.Empty);
		}

		private void SensetiveGroupRange(){
			if(entry_range.Text.Length>=1){
				spinbutton_start.Sensitive = false;
				spinbutton_end.Sensitive = false;
				spinbutton_jamp.Sensitive = false;
				spinbutton_step_task.Sensitive = false;
			}else{
				spinbutton_start.Sensitive = true;
				spinbutton_end.Sensitive = true;
				spinbutton_jamp.Sensitive = true;
				spinbutton_step_task.Sensitive = true;
			}
		}

		private String PrintRange(){
			String tmp = String.Empty;
			if(Value!=null){
			for(int i=0; Value.Count>i; ++i){
				for(int j=0; Value[i].Count>j; ++j){
					tmp += Value [i] [j];
					if (j==0 && Value[i].Count>1){
						tmp += "-";
					}
				}
				if(i<(Value.Count-1)){
					tmp += ",";
				}
			}
			}else{
				tmp = String.Empty;
			}
			return tmp;
		}
		

		protected void OnSpinbuttonStartChanged (object sender, EventArgs e)
		{
			if(spinbutton_start.Value>=spinbutton_end.Value){
				spinbutton_start.Value = spinbutton_end.Value - 1;
			}
			//Console.WriteLine ("my_change = " + spinbutton_start.Value);
			CalcRange ();
		}

		protected void OnSpinbuttonEndChanged (object sender, EventArgs e)
		{
			if(spinbutton_start.Value>=spinbutton_end.Value){
				spinbutton_end.Value = spinbutton_start.Value + 1;
			}
			CalcRange ();
		}

		protected void OnSpinbuttonJampChanged (object sender, EventArgs e)
		{
			CalcRange ();
		}

		protected void OnSpinbuttonStepTaskChanged (object sender, EventArgs e)
		{
			CalcRange ();
		}
	}
}

