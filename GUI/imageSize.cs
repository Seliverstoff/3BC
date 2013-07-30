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

