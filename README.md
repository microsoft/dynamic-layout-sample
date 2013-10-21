Dynamic Layout Sample
=====================

A Nokia example application demonstrating how to create a dynamic layouts for different size of resolutions and physical screens on Windows Phone 8 platform.

The application presents a number of items on the main page. Layout and size of the items depends on a style applied to the items, the style depending on the resolution of the device. A default style is always loaded and as it's name suggests, it defines a universal style suitable for presenting items in all supported resolutions. In devices with 1080p resolution an additional style is loaded at runtime. This 1080p style overrides some details of the default style, optimizing the layout for a large display with 1080p resolution.

This example application is hosted in GitHub:
https://github.com/nokia-developer/dynamic-layout-sample

Developed with Microsoft Visual Studio Express for Windows Phone 2012.

Compatible with:

 * Windows Phone 8

Tested to work on:

 * Nokia Lumia 925
 * Nokia Lumia 1520 


Instructions
------------

Make sure you have the following installed:

 * Windows 8
 * Windows Phone SDK 8.0
 * NuGet Package Manager (https://nuget.org/), Visual Studio extension to install and update third-party libraries and tools in Visual Studio

To build and run the sample:

 * Open the SLN file
   * File > Open Project, select the file DynamicLayoutSample.sln
 * Install Windows Phone Toolkit for the project.
   * Right click References in Solution Explorer -> select Manage NuGet Packages
   * Search for 'wptoolkit' and install the 'Windows Phone toolkit' package 
 * Select the target 'Emulator WVGA' / 'Emulator 720P'. As there is no dedicated 1080P emulator available, the application uses 'Emulator 720P' to emulate 1080P resolution as they share the same aspect ratio.
 * Press F5 to build the project and run it on the Windows Phone Emulator.

To deploy the sample on Windows Phone 8 device:
 * See the official documentation for deploying and testing applications on Windows Phone devices at http://msdn.microsoft.com/en-us/library/windowsphone/develop/ff402565(v=vs.105).aspx


About the implementation
------------------------

Important folders:

| Folder | Description |
| ------ | ----------- |
| / | Contains the project file, the license information and this file (README.md) |
| DynamicLayoutSample | Root folder for the implementation files.  |
| DynamicLayoutSample/Assets | Graphic assets like icons and tiles. |
| DynamicLayoutSample/Properties | Application property files. |
| DynamicLayoutSample/Resources | Application resources. |
| DynamicLayoutSample/SampleData | Sample model data. |
| DynamicLayoutSample/Themes | Different style definitions for rendering sample items.  |

Important files:

| File | Description |
| ---- | ----------- |
| SampleDataItemTemplate.xaml | Defines the layout of a list item. |
| SampleDataItemStyleDefault.xaml | Defines styles determining each element's look and feel. |
| SampleDataItemStyle1080p.xaml | Redefines styles with 1080p optimized versions. |
| StyleSelector.cs | Determines which styles are used at runtime. |
| ScreenSizeHelper.cs | Determines the device's screen size at runtime. |

Important classes:

| Class | Description |
| ----- | ----------- |
| MainPage | The UI of this example application. |

Additional information on adapting to 1080p resolution and large displays can be found from Nokia Lumia Developer's Library: http://developer.nokia.com/Resources/Library/Lumia/


Known issues
------------

No known issues.


License
-------

    Copyright © 2013 Nokia Corporation. All rights reserved.
    
    Nokia, Nokia Developer, and HERE are trademarks and/or registered trademarks of
    Nokia Corporation. Other product and company names mentioned herein may be
    trademarks or trade names of their respective owners.
    
    License
    Subject to the conditions below, you may use, copy, modify and/or merge copies
    of this software and associated content and documentation files (the “Software”)
    to test, develop, publish, distribute, sub-license and/or sell new software
    derived from or incorporating the Software, solely in connection with Nokia
    devices. Some of the documentation, content and/or software maybe licensed under
    open source software or other licenses. To the extent such documentation,
    content and/or software are included, licenses and/or other terms and conditions
    shall apply in addition and/or instead of this notice. The exact terms of the
    licenses, disclaimers, acknowledgements and notices are reproduced in the
    materials provided, or in other obvious locations. No other license to any other
    intellectual property rights is granted herein.
    
    This file, unmodified, shall be included with all copies or substantial portions
    of the Software that are distributed in source code form.
    
    The Software cannot constitute the primary value of any new software derived
    from or incorporating the Software.
    
    Any person dealing with the Software shall not misrepresent the source of the
    Software.
    
    Disclaimer
    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
    FOR A PARTICULAR PURPOSE, QUALITY AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES (INCLUDING,
    WITHOUT LIMITATION, DIRECT, SPECIAL, INDIRECT, PUNITIVE, CONSEQUENTIAL,
    EXEMPLARY AND/ OR INCIDENTAL DAMAGES) OR OTHER LIABILITY, WHETHER IN AN ACTION
    OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
    SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
    
    Nokia Corporation retains the right to make changes to this document at any
    time, without notice.
  

Version history
---------------

 * 1.0 First public release 
