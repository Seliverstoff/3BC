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


using System;

namespace BBB
{
	public class renderModo : en
	{
		public renderModo ()
		{
			engineName = "MODO render command line (TODOO)";
			label_path = "Modo path";
			filter_scene_file_text = "MODO scene files (*.lxo)";
			filter_scene_file_exec = "*.lxo";
			filter_exec_render_text = "Файл пограммы modo_cl.exe";
			filter_exex_render_exec = "modo_cl.exe";
		}
	}
}

