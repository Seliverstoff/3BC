using System;
using System.Collections;
using System.Collections.Generic;
using Gtk;

namespace BBB
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class comboList : Gtk.Bin
	{
		public String Text { 
			set { SetList(value); }
			get { return GetList (); }
		}

		public event EventHandler Change;

		public comboList ()
		{
			this.Build ();
		}

		protected virtual void OnChange(EventArgs e){
			if (Change != null) {
				Change (this, e);
			}
		}

		private void SetList(String tmp){
			String[] arr = tmp.Split(':');
			for(int i=0; arr.Length>i; ++i){
				comboboxentry.AppendText (arr[i]);
			}
		}

		private String GetList(){
			//for(int i=0; comboboxentry.Model.IterNChildren>i; ++i){
				//comboboxentry.te ();
			//}
			//foreach (var item in comboBox1.Items)
			//	textBox2.Text += item.ToString();;

			return String.Empty;
		}

		protected void OnButtonRemoveClicked (object sender, EventArgs e)
		{
			OnChange (EventArgs.Empty);
			comboboxentry.RemoveText (comboboxentry.Active);
		}

		protected void OnButtonAddClicked (object sender, EventArgs e)
		{
			OnChange (EventArgs.Empty);
			comboboxentry.PrependText (comboboxentry.Entry.Text);
		}

		protected void OnComboboxentry1Changed (object sender, EventArgs e)
		{
			OnChange (EventArgs.Empty);
		}
	}
}

