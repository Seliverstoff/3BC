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

