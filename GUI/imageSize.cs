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

namespace BBB
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class imageSize : Gtk.Bin
	{
		public String Value { set; get; }
		public String Use { set; get; }
		public event EventHandler ChangeWidget;

		public imageSize ()
		{
			this.Build ();
		}

		protected virtual void OnChangeWidget (EventArgs e)
		{
			if (ChangeWidget != null) {
				ChangeWidget (this, e);
			}
		}

		private void CalcRange ()
		{
			OnChangeWidget (EventArgs.Empty);
		}

		protected void OnCheckbutton12Clicked (object sender, EventArgs e)
		{
			CalcRange ();
		}

		protected void OnSpinbutton7Changed (object sender, EventArgs e)
		{
			CalcRange ();
		}

		protected void OnSpinbutton6Changed (object sender, EventArgs e)
		{
			CalcRange ();
		}
	}
}

