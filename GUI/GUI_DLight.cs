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
	[System.ComponentModel.ToolboxItem(true)]
	public partial class GUI_DLight : GUI_renders
	{
		public GUI_DLight ()
		{
			this.Build ();
		}
	}
}

/*

Usage: renderdl [options] [file1 ... fileN]
  -v                : output version to console
  -h                : output this help
  -q                : don't print the name of files rendered
  -d                : add a framebuffer display
  -D                : add a framebuffer and automatically close it
  -id               : add an i-display interactive framebuffer
  -idf              : add an i-display framebuffer with float output
  -displayvar       : specifies wich variable to display (rgba is default)
  -nd               : no display, ignores framebuffer displays in RIB
  -res x y          : Specify image resolution
  -beep             : beep when finished all RIBs
  -beeps            : beep after each rendered RIB
  -frames f1 f2     : only render frames f1 to f2
  -crop l r t b     : set a crop window in screen space
  -stats[1-3]       : display end of frame statistics
  -statsfile file   : output statistics to 'file'
  -progress         : print rendering progress at each bucket
  -noinit           : do not read '.renderdl' file
  -init             : force reading '.renderdl' file (after -catrib)
  -test             : render a test image
  -maxmessages n    : print at most 'n' error or warning messages
  -filtermessages m : filter out messages in comma separated list

Multi-processing options (please read documentation for details)
  -t n              : launch the render using 'n' threads
  -p n              : same as -t
  -P n              : launch the render using 'n' processes
  -hosts h1,h2,...  : specifies a list of hosts to render on.
  -tiling t         : sets the tiling mode to use (v, h, m or b).
                      This is only meaningful when using processes.
  -ssh              : use 'ssh' instead of 'rsh' to start renders
  -jobscript script : use 'script' to start renders
  -jobscriptparam p : passes 'p' as the first parameter of script

RI filtering options (refer to documentation for further details)
  -rif filter       : adds an RI filter to the filter chain
  -rifargs args     : starts an argument list
  -rifend           : ends and argument list

RIB output options
  -catrib           : output RIB to stdout
  -o file           : when used with -catrib, output RIB to file
  -binary           : encode RIB in binary format
  -gzip             : compress RIB using gzip format
  -callprocedurals  : expand all procedurals and archives
  -archiveprocedurals: replace procedurals by DelayedReadArchive
  -noformat         : perform only minimal formatting of RIB
  -noheader         : disable the structural header

Please refer to user's manual for more informations.



` General options'

    ` -3dfmshave <boolean>'
        Load or unload the 3dfmShave plugin. 

` Render Pass selection options'
    Since all options that change the render pass attributes operate on the currently selected render pass, this option should be specified right after the `-r 3delight' option.

    ` -rp <string>'
        Select <string> as the render pass node used for rendering. If the specified node does not exists, the selected render pass will remain unchanged. 

` Render Pass Camera options'
    The following options control the attributes grouped under the render pass Camera panel:

    ` -cam <string>'
        Select <string> as the camera to be rendered. 
    ` -x <int>'
        Set the rendered image width. 
    ` -y <int>'
        Set the rendered image height. 
    ` -resm <int>'
        Specify the resolution multiplier. The following values are available:

        ` 0'
            Full resolution. 
        ` 1'
            One half of the specified resolution. 
        ` 2'
            One quarter of the specified resolution. 
        ` 3'
            One eighth of the specified resolution. 

    ` -par <float>'
        Specify the pixel aspect ratio of the rendered image. 
    ` -an <boolean>'
        Toggle the rendering of the specified frame sequence on or off. 
    ` -s <int>'
        Set the first frame to render. 
    ` -e <int>'
        Set the last frame to render. 
    ` -inc <int>'
        Defines the frame increment. 
    ` -crop <boolean>'
        Controls if the specified crop window is used for rendering. 
    ` -crminx <float>'
        Set the top right corner position of the crop window in X. 
    ` -crminy <float>'
        Set the top right corner position of the crop window in Y. 
    ` -crmaxx <float>'
        Set the bottom left corner position of the crop window in X. 
    ` -crmaxy <float>'
        Set the bottom left corner position of the crop window in Y. 
    ` -bo <int>'
        Specify the bucket order to be used. The following values are available:

        ` 0'
            Horizontal bucket order. 
        ` 1'
            Vertical bucket order. 
        ` 2'
            Zigzag bucket order. 
        ` 3'
            Spiral bucket order. 
        ` 4'
            Circle bucket order. 

    ` -is <boolean>'
        Toggle the use of imager shaders attached to the specified camera. 

` Render Pass Output options'
    The following options control the attributes grouped under the render pass Output panel:

    ` -rmode <int>'
        Specify the render mode. The following values are available:

        ` 0'
            Render 
        ` 1'
            Save RIB 
        ` 2'
            RIB Archive 

    ` -ribfile <string>'
        Specify the RIB filename to create. 
    ` -ribbin <boolean>'
        Toggle binary RIB output. 
    ` -ribcomp <boolean>'
        Toggle compressed RIB output. 

` Render Pass Quality options'
    The following options control the attributes grouped under the render pass Quality panel:

    ` -psx <int>'
        Specify the pixel samples to use in X. 
    ` -psy <int>'
        Specify the pixel samples to use in Y. 
    ` -sr <float>'
        Define the shading rate to use. 
    ` -pft <int>'
        Specify the pixel filter type. The following values are available:

        ` 0'
            Box filter 
        ` 1'
            Triangle filter 
        ` 2'
            Gaussian filter 
        ` 3'
            Catmull-rom filter 
        ` 4'
            Bessel filter 
        ` 5'
            Sinc 

    ` -pfx <float>'
        Set the pixel filter width in X. 
    ` -pfy <float>'
        Set the pixel filter width in Y. 
    ` -rtmaxd <int>'
        Specify the raytrace maximum depth. 

` Render Pass Motion Blur options'
    The following options control the attributes grouped under the render pass' Motion Blur panel:

    ` -cmb <boolean>'
        Toggle the camera blur on or off. 
    ` -cmbs <int>'
        Set the number of samples for camera blur. 
    ` -tmb <boolean>'
        Toggle the transformation blur on or off. 
    ` -tmbs <int>'
        Set the number of samples for transformation blur. 
    ` -dmb <boolean>'
        Toggle the deformation blur on or off. 
    ` -dmbs <int>'
        Set the number of samples for deformation blur. 
    ` -mbp <int>'
        Set the motion blur position. The following values are available:

        ` 0'
            End on frame 
        ` 1'
            Centered on frame 
        ` 2'
            Start on frame 

    ` -soe <float>'
        Define the shutter opening efficiency. 
    ` -sce <float>'
        Define the shutter closing efficiency. 
    ` -sa <float>'
        Set the shutter angle for motion blur. <float> should be between 1 and 306. 

` Render Pass Primary Display options'
    The following options control the attributes grouped under the render pass Primary Display panel:

    ` -rpd <boolean>'
        Toggle the rendering of the primary display on or off. 
    ` -img <string>'
        Specify the image filename of the primary display. 
    ` -of <string>'
        Specify the primary display output file format (i.e. the display driver to use). Note that when this option is used, there is no need to also use the `-pdd' option. The following values are available: framebuffer, idisplay, tiff, iff, exr, cineon, zfile, bmp, epx, psd, radiance, shadowmap, texture and null. 
    ` -pdd <int>'
        Specify the primary display driver to use. Note that when this option is used, there is no need to also use the `-of' option. The following values are available:

        ` 0'
            Framebuffer 
        ` 1'
            i-display 
        ` 2'
            Maya Render View. This option is not recommended in command line mode. 
        ` 3'
            tiff 
        ` 4'
            iff 
        ` 5'
            exr 
        ` 6'
            cineon 
        ` 7'
            zfile 
        ` 8'
            bmp 
        ` 9'
            eps 
        ` 10'
            psd 
        ` 11'
            radiance 
        ` 12'
            null 
        ` 13'
            shadowmap 
        ` 14'
            texture 

    ` -pdm <string>'
        Specify the primary display mode. 
    ` -pdbd <int>'
        Set the primary display bit depth. The following values are available:

        ` 0'
            8 bits int 
        ` 1'
            16 bits int 
        ` 2'
            32 bits float 
        ` 3'
            Custom Quantize 

    ` -pdqzero <int>'
        Set the zero value for quantization. Only relevant when setting the primary display bit depth to custom quantize. See -pdbd. 
    ` -pdqone <int>'
        Set the one value for quantization. Only relevant when setting the primary display bit depth to custom quantize. See -pdbd. 
    ` -pdqmin <int>'
        Set the minimum value for quantization. Only relevant when setting the primary display bit depth to custom quantize. See -pdbd. 
    ` -pdqmax <int>'
        Set the maximum value for quantization. Only relevant when setting the primary display bit depth to custom quantize. See -pdbd. 
    ` -pdqdit <float>'
        Set the dither value for quantization. Only relevant when setting the primary display bit depth to custom quantize. See -pdbd. 

` Render Pass Secondary Display options'
    The following options control the attributes grouped under the render pass Secondary Display panel:

    ` -rsd <boolean>'
        Toggle the rendering of the secondary displays on or off. 

` Render Pass Shadow Maps options'
    The following options control the attributes grouped under the render pass Shadow Maps panel:

    ` -rsm <boolean>'
        Toggle the shadow map rendering on or off. 
    ` -dssm <boolean>'
        Controls if the displacement shaders are used in the shadow map renderings. 
    ` -sssm <boolean>'
        Controls if the surface shaders are used in the shadow map renderings. 
    ` -assm <boolean>'
        Controls if the atmosphere shaders are used in the shadow map renderings. 
    ` -issm <boolean>'
        Controls if the interior shaders are used in the shadow map renderings. 
    ` -ztr <float>'
        Set the red value for the z threshold. 
    ` -ztg <float>'
        Set the green value for the z threshold. 
    ` -ztb <float>'
        Set the blue value for the z threshold. 

` Render Pass Photon Maps options'
    The following options control the attributes grouped under the render pass `Photon Maps' panel:

    ` -rpm <boolean>'
        Toggle the rendering of the photon maps on or off. 
    ` -nbp <int>'
        Set the number of photons. 
    ` -gpm <string>'
        Specify the global photon map to use. 
    ` -cpm <string>'
        Specify the caustic map to use. 

` Render Pass Render Sets options'
    The following options control the attributes grouped under the render pass `Render Sets' panel:

    ` -sc <string>'
        Specify the shader collection to render. Specify an empty string to use no shader collections. 
    ` -ors <string>'
        Specify the object set to render. Specify an empty string to render all visible objects. 
    ` -lrs <string>'
        Specify the light set to render. Specify an empty string to render all visible lights. 
    ` -cprs <string>'
        Specify the clipping plane set to render. Specify an empty string to render all visible clipping planes. 
    ` -lr <boolean|name(s)>'
    ` -rl <boolean|name(s)>'
        Specify the Maya render layer to render. It is possible to specify multiple layer names, as long as they are separated by a space and the list is surrounded by double quotes. If this parameter is set to `on', `true' or `1', all renderable layers will be rendered. If an empty string, `off', `false' or `0' is specified, the `defaultRenderLayer' (or masterLayer) will be used. When this parameter is not specified, all renderable layers will be rendered, unless the selected render pass specifies which layer is to be rendered with its "Layer To Render" attribute. In this case, only this layer will be rendered, provided it is renderable. If it is not renderable, nothing will be rendered. 

` Render Pass RIB Archives options'
    The following options control the attributes grouped under the render pass RIB Archives panel:

    ` -arl <int>'
        Specify how to archive lighting. The following values are available:

        ` 0'
            No Lighting. 
        ` 1'
            Light Linking. 
        ` Light Sources & Light Linking'

    ` arw <int>'
        Set the archive write mode. The following values are available:

        ` 0'
            Reuse existing archive. 
        ` 1'
            Overwrite existing archive. 

    ` -grar <boolean>'
        Generate RIB archives toggle. 
    ` -iao <boolean>'
        Ignore archived objects toggle. 
    ` -art <boolean>'
        Archive transforms toggle. 
    ` -cgt <boolean>'
        Concatenate geo transforms toggle. 
    ` -args <boolean>'
        Archive geo shaders toggle. 
    ` -args <boolean>'
        Archive geo attributes toggle. 

` Render Pass Search Flags options'
    The following options control the attributes grouped under the render pass Search Flags panel:

    ` -shp <string>'
        Specify the shaders search path. 
    ` -txp <string>'
        Specify the textures search path. 
    ` -prp <string>'
        Specify the procedural search path. 

` Render Pass MEL Scripts options'
    The following options control the attributes grouped under the render pass MEL Scripts panel:

    ` -preRender <string>'
        MEL script executed before rendering. 
    ` -postRender <string>'
        MEL script executed after rendering. 
    ` -preFrame <string>'
        MEL script executed before each frame is rendered. 
    ` -postFrame <string>'
        MEL script executed after each frame is rendered. 
    ` -postOption <string>'
        MEL script executed after the RiOptions are output. 
    ` -preWorld <string>'
        MEL script executed before RiWorldBegin. 

` Render Pass Advanced options'
    The following options control the attributes grouped under the render pass Advanced panel:

    ` -bsx <int>'
        Set the bucket size in X. 
    ` -bsy <int>'
        Set the bucket size in Y. 
    ` -gs <int>'
        Define the grid size. 
    ` -txm <int>'
        Set the size of the texture memory cache, in megabytes. 
    ` -es <int>'
        Define the eye splits. 
    ` -otr <float>'
        Set the red value of the opacity threshold. 
    ` -otg <float>'
        Set the green value of the opacity threshold. 
    ` -otb <float>'
        Set the blue value of the opacity threshold. 
    ` -cpus <int>'
        Define the number of cpus to use. 
    ` -tms <boolean>'
        Toggle the translation of Maya shaders on or off. 
    ` -ums <boolean>'
        Toggle the use of Maya shaders on or off. 

` Render Pass Network Cache options'
    The following options control the attributes grouped under the render pass Network Cache panel:

    ` -unc <boolean>'
        Toggle the use of network cache on or off. 
    ` -ncdir <string>'
        Specify the network cache directory. 
    ` -ncs <int>'
        Specify the network cache size. 

` Render Pass Statistics options'
    The following options control the attributes grouped under the render pass Statistics panel:

    ` -prog <bool>'
        Turn on or of the progress indication of the currently rendered display. 
    ` -statl <int>'
        Set the statistics level. 
    ` -statf <string>'
        Define the statistics file. 




*/