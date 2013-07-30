using Gtk;
using Gdk;
using Cairo;
using System;

namespace BBB
{
	[System.ComponentModel.ToolboxItem(true)]
	public class DrawingRegion : Gtk.DrawingArea
	{
		public double X1 { set; get; }
		public double Y1 { set; get; }
		public double X2 { set; get; }
		public double Y2 { set; get; }

		public DrawingRegion ()
		{
			// Insert initialization code here.
		}

		protected override bool OnButtonPressEvent (Gdk.EventButton ev)
		{
			// Insert button press handling code here.
			return base.OnButtonPressEvent (ev);
		}

		protected override bool OnExposeEvent (Gdk.EventExpose ev)
		{
			base.OnExposeEvent (ev);
			Cairo.Context cc =  Gdk.CairoHelper.Create(this.GdkWindow);

			cc.SetSourceRGB(0, 0, 0);
			cc.LineWidth = 1;

			//cc.Rectangle(20, 20, Allocation.Width-20, Allocation.Height-20);
			cc.Rectangle(X1, Y1, X2, Y2);

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
			requisition.Height = 650;
			requisition.Width = 850;
		}
	}
}

