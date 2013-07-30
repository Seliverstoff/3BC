using System;

namespace BBB
{
	public partial class SplashScreen : Gtk.Window
	{
		public SplashScreen () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		public void PulseSplashProgress()
		{
			SplashProgress.Pulse();
		}
		public void SetSplashLabelText(string text)
		{
			lblSplashStatus.Text = text;
		}

	}
}

