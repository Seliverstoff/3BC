using System;
using System.Collections;
using System.Collections.Generic;

namespace BBB
{
	public partial class ListEditor : Gtk.Dialog
	{

		String[] valList = {};

		public ListEditor (String strList)
		{
			this.Build ();
			valList = strList.Split (';');

			for(int i=0; i<valList.Length; ++i){
				comboboxentry.AppendText (valList[i]);
			}

			comboboxentry.Active = 0;

			label_out.Text = strList;

		}

		protected void OnButtonRemoveClicked (object sender, EventArgs e)
		{
			int itemS = comboboxentry.Active;
			comboboxentry.RemoveText (itemS);
			comboboxentry.Active = itemS - 1;
		}

		protected void OnButtonAddClicked (object sender, EventArgs e)
		{
			//comboboxentry.InsertText
		}

		protected void OnButtonSaveClicked (object sender, EventArgs e)
		{

		}

		private void RefrasheList(){
			//label_out.Text = String.Empty;
			//int count = comboboxentry.Model.IterNChildren ();
			//for(int i=0; count>i; ++i){
				//label_out.Text += comboboxentry.ge
				//label_out.Text += comboboxentry.Model.GetStringFromIter (i);
				//label_out.Text += comboboxentry.Model.GetValue (i);
				//comboboxentry.InsertText
				//comboboxentry.Model.
			//}

			/*
			TreeStore model = (TreeStore)comboboxentry.Model;

			int count = 0;
			bool res = model.GetIterFirst(out iter);
			while(res)  {
			   count++;
			   res = model.IterNext(ref iter);
			} 

*/

		}

	}
}

