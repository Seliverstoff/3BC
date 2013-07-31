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

