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
using System.Collections.Generic;
using System.Collections;

namespace BBB
{
	public class GUI_renders : Gtk.Bin
	{
		public String[] argStr = new String[] { String.Empty, String.Empty};
		public String settingsName = String.Empty;
		public String settingsValue = String.Empty;
		public Dictionary<String, String> defolt_param = new Dictionary<String, String> ();
		public Boolean renderEnable = true;
		public int _start { set; get; }
		public int _end { set; get; }
		public int _jamp { set; get; }
		public int _step { set; get; }

		public event EventHandler ChangeWidget;
		public event EventHandler ChangeFrameRate;
		
		public GUI_renders ()
		{
			//ChangeWidget (EventArgs.Empty);
		}

		protected virtual void OnChangeWidget(EventArgs e){
			if (ChangeWidget != null) {
				ChangeWidget (this, e);
			}
		}

		protected virtual void OnChangeFrameRate(EventArgs e){
			if (ChangeFrameRate != null) {
				ChangeFrameRate (this, e);
			}
		}

	}
}

