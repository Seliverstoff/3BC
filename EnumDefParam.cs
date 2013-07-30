using System;

namespace BBB
{
	public enum DefParamBlender
	{
		render_blender_path,
		render_blender_scene_path,
		render_blender_scene,
		render_blender_scene_use,
		render_blender_script,
  		render_blender_script_use,
		render_blender_script_arg,
		render_blender_script_arg_use,
  		render_blender_outs,
  		render_blender_outs_use,
  		render_blender_format,
  		render_blender_ext,
  		render_blender_threads,
		render_blender_range,
		render_blender_range_use,
		render_blender_range_start,
		render_blender_range_end,
		render_blender_range_jamp,
		render_blender_range_step 
	}

	public enum DefParamVray
	{
		render_vray_path,
		render_vray_scene_path,
		render_vray_include_list,
		render_vray_include_list_use,
		render_vray_threads,
		render_vray_display_use,
		render_vray_display_srgb,
		render_vray_display_lut,
		render_vray_display_aspect,
		render_vray_display_autoclose,
		render_vray_display_autofocus,
		render_vray_outs_use,
		render_vray_outs,
		render_vray_dimensions,
		render_vray_dimensions_use,
		render_vray_regoin_use,
		render_vray_regoin,
		render_vray_crop_use,
		render_vray_crop,
		render_vray_range,
		render_vray_range_use,
		render_vray_range_start,
		render_vray_range_end,
		render_vray_range_step,
		render_vray_range_jamp,
	}

	public enum DefParamAS
	{
		render_as_path,
		render_as_scene_path,
		render_as_render_settings_use,
		render_as_sets_aa,
		render_as_sets_shapefx,
		render_as_sets_layerfx,
		render_as_sets_halfsize,
		render_as_sets_halffps,
		render_as_sets_fewparticles,
		render_as_sets_extrasmooth,
		render_as_sets_ntscsafe,
		render_as_sets_premultiplay,
		render_as_sets_variablewidth,
		render_as_range_use,
		render_as_range,
		render_as_range_start,
		render_as_range_end,
		render_as_range_step,
		render_as_range_jamp,
		render_as_outs_use,
		render_as_outs,
		render_as_outs_format,
		render_as_varbose_use,
	}

	public enum DefParamVue
	{
		render_vue_path,
  		render_vue_scene_path,
  		render_vue_outs_use,
  		render_vue_outs,
  		render_vue_range_use,
  		render_vue_range,
  		render_vue_range_start,
  		render_vue_range_end,
  		render_vue_range_step,
  		render_vue_range_jamp,
  		render_vue_tile_use,
  		render_vue_tile_value,
  		render_vue_job_use,
  		render_vue_job_value,
	}

	public enum pathType
	{
		File,
		Dir
	}

}

