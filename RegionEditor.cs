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

