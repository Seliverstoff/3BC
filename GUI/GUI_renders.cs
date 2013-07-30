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

		public event EventHandler ChangeWidget;
		
		public GUI_renders ()
		{
			//ChangeWidget (EventArgs.Empty);
		}

		protected virtual void OnChangeWidget(EventArgs e){
			if (ChangeWidget != null) {
				ChangeWidget (this, e);
			}
		}
		
	}
}

