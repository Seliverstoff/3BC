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

using Gtk;
using Gdk;
using Cairo;
using System;

namespace BBB
{
	[System.ComponentModel.ToolboxItem(true)]
	public class DrawingCorners : Gtk.DrawingArea
	{
		public int type { set; get;}

		public DrawingCorners ()
		{
			// Insert initialization code here.
		}

		protected override bool OnExposeEvent (Gdk.EventExpose ev)
		{
			base.OnExposeEvent (ev);
			Cairo.Context cc =  Gdk.CairoHelper.Create(this.GdkWindow);

			cc.SetSourceRGB(0, 0, 0);
			cc.LineWidth = 1;

			if(type==2){
				cc.Rectangle(-5, 5, Allocation.Width-20, 80);
			}

			if(type==3){
				cc.Rectangle(5, -5, 1000, 25);
			}

			cc.StrokePreserve();

			((IDisposable) cc.Target).Dispose ();                                      
			((IDisposable) cc).Dispose ();

			return true;
		}

		protected override void OnSizeAllocated (Gdk.Rectangle allocation)
		{
			base.OnSizeAllocated (allocation);
			// Insert layout code here.
		}

		protected override void OnSizeRequested (ref Gtk.Requisition requisition)
		{
			// Calculate desired size here.
			//requisition.Height = 50;
			//requisition.Width = 50;
		}
	}
}

