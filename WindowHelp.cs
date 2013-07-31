using System;
using Gtk;
using System.Windows;
using System.Windows.Forms;
using Mono;


namespace BBB
{
	public partial class WindowHelp : Window
	{
		public WindowHelp () : base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

