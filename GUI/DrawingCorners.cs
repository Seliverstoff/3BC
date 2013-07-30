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

