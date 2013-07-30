using System;
using Gtk;

namespace BBB
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class regionArea : Gtk.Bin
	{
		public String Value
		{ 
			set { SetSpins (value); } 
			get { return GetSpins(); }
		}

		public String Use {
			set { SetUse (value); }
			get { return GetUse (); }
		}


		public Boolean CheckBtn { set; get; }
		public int mType { set; get; }
		public event EventHandler ChangeWidget;

		public enum CropType
		{
			tail,
			crop,
			region
		}
		
		public regionArea ()
		{
			this.Build ();

			if(CheckBtn==true){
				checkbutton_label.Visible = false;
			}else{
				checkbutton_label.Visible = true;
			}

			SetSpins (Value);
		}

		private void SetSpins(String tmp){
			if(tmp!=String.Empty){
				String[] arrs = tmp.Split (':');
				if(arrs.Length==4){
					spinbutton_x1.Value = int.Parse (arrs[0]);
					spinbutton_y1.Value = int.Parse (arrs[1]);
					spinbutton_x2.Value = int.Parse (arrs[2]);
					spinbutton_y2.Value = int.Parse (arrs[3]);
				}
			}
		}

		private String GetSpins(){
			String tmp = spinbutton_x1.Value.ToString () + ":" + spinbutton_y1.Value.ToString () 
				+ ":" + spinbutton_x2.Value.ToString () + ":" + spinbutton_y2.Value.ToString ();
			return tmp;
		}

		private void SetUse(String tmp){
			if(tmp=="1"){
				checkbutton_label.Active = true;
			}
			if(tmp=="0"){
				checkbutton_label.Active = false;
			}
		}

		private String GetUse(){
			if(checkbutton_label.Active == true){
				return "1";
			}else{
				return "0";
			}
		}

		protected virtual void OnChangeWidget (EventArgs e)
		{
			if (ChangeWidget != null) {
				ChangeWidget (this, e);
			}
		}

		private void CalcRange ()
		{
			Value = GetSpins ();



			OnChangeWidget (EventArgs.Empty);
		}

		public String labelText
		{
			get { return checkbutton_label.Label; }
			set { checkbutton_label.Label = value; }
		}

		protected void OnButtonEditorClicked (object sender, EventArgs e)
		{
			RegionEditor Dlg = new RegionEditor ();

			if (Dlg.Run() == (int)ResponseType.Accept) 
			{
				// Обработка
			} 
			Dlg.Destroy();
		}

		protected void OnCheckbuttonLabelClicked (object sender, EventArgs e)
		{
			CalcRange ();
		}

		protected void OnSpinbutton3Changed (object sender, EventArgs e)
		{
			CalcRange ();
		}

		protected void OnSpinbutton2Changed (object sender, EventArgs e)
		{
			CalcRange ();
		}

		protected void OnSpinbutton4Changed (object sender, EventArgs e)
		{
			CalcRange ();
		}

		protected void OnSpinbutton5Changed (object sender, EventArgs e)
		{
			CalcRange ();
		}

	}
}

