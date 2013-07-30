using System;

namespace BBB
{
	public class renderDlight : en
	{
		public renderDlight ()
		{
			engineName = "3Dlight render (TODOO)";
			label_path = "3Dlight path";
			filter_scene_file_text = "RenderMan scene files (*.rib)";
			filter_scene_file_exec = "*.rib";
			filter_exec_render_text = "Файл пограммы renderdl.exe";
			filter_exex_render_exec = "renderdl.exe";
		}
	}
}

