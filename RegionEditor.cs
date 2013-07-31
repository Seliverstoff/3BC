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
	public partial class RegionEditor : Gtk.Dialog
	{
		public RegionEditor ()
		{
			this.Build ();
		}

		protected void OnSpinbuttonX1Changed (object sender, EventArgs e)
		{
			drawingregion.X1 = spinbutton_x1.Value;
		}

		protected void OnSpinbuttonY1Changed (object sender, EventArgs e)
		{
			drawingregion.Y1 = spinbutton_y1.Value;
		}

		protected void OnSpinbuttonY2Changed (object sender, EventArgs e)
		{
			drawingregion.Y2 = spinbutton_y2.Value;
		}

		protected void OnSpinbuttonX2Changed (object sender, EventArgs e)
		{
			drawingregion.X2 = spinbutton_x2.Value;
		}
	}
}

