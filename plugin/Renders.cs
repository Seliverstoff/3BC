using System;
using System.Collections.Generic;

namespace BBB
{
	// Пустой класс для наследования, просто описывает структуру для потомков
	public class en
	{
		public String engineName = String.Empty;
		public String exec = String.Empty;
		public String label_path = String.Empty;

		public String filter_scene_file_text = String.Empty;
		public String filter_scene_file_exec = String.Empty;
		public String filter_exec_render_text = String.Empty;
		public String filter_exex_render_exec = String.Empty;

		public String atr_scene_file = String.Empty;
		public String atr_range_frame = String.Empty;
		public String atr_single_frame = String.Empty;
		public String atr_file_out = String.Empty;
		public String atr_file_format = String.Empty;
		public String[] atr_file_format_list = {};
		public String atr_tile = String.Empty;
		public String atr_step = String.Empty;

		public Boolean script_enable = false;
		public Boolean file_out_enable = false;


		public en()
		{

		}

		public virtual void Print(){
			Console.WriteLine ("Empty Function");
		}

		public virtual void GUI_Settings(){

		}

	}

	// Основной класс, содержит коллекцию наследников от "en"
	// это перечень специфических параметров для каждого рендера
	public class Renders
	{
		public Dictionary<String, en> engine = new Dictionary<string, en>();
		//public enum engEn {Vue, Blender, Modo, Vray, Pixie, Aqsis, DLight, Air, AS };
		public enum engEn {Vray, Blender, Vue, AS};

		public Renders ()
		{
			engine.Add (Enum.GetName(typeof(engEn), 0), new renderVray ());
			engine.Add (Enum.GetName(typeof(engEn), 1), new renderBlender ());
			engine.Add (Enum.GetName(typeof(engEn), 2), new renderVue ());
			engine.Add (Enum.GetName(typeof(engEn), 3), new renderAS ());

			//engine.Add (Enum.GetName(typeof(engEn), 4), new renderPixie ());
			//engine.Add (Enum.GetName(typeof(engEn), 5), new renderAqsis ());
			//engine.Add (Enum.GetName(typeof(engEn), 6), new renderDlight ());
			//engine.Add (Enum.GetName(typeof(engEn), 7), new renderAir ());
			//engine.Add (Enum.GetName(typeof(engEn), 8), new renderAS ());
		}
	}
}

