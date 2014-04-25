/**
 * Copyright (c) 2013-2014 Microsoft Mobile. All rights reserved.
 *
 * Nokia, Nokia Connecting People, Nokia Developer, and HERE are trademarks
 * and/or registered trademarks of Nokia Corporation. Other product and company
 * names mentioned herein may be trademarks or trade names of their respective
 * owners.
 *
 * See the license text file delivered with this project for more information.
 */

using Microsoft.Phone.Info;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DynamicLayoutSample
{
    /// <summary>
    /// Helper class for determining the screen specifications of the device.
    /// </summary>
    class ScreenSizeHelper
    {
        static private double _screenSize = -1.0f;
        static private double _screenDpiX = 0.0f;
        static private double _screenDpiY = 0.0f;
        static private Size _resolution;

        static public bool IsBigScreen
        {
            get
            {
                // Use WVGA emulator to simulate small screen and 720p emulator to simulate big screen
                if (Microsoft.Devices.Environment.DeviceType == Microsoft.Devices.DeviceType.Emulator)
                {
                    _screenSize = (App.Current.Host.Content.ScaleFactor == 150) ? 6.0f : 0.0f;
                }

                if (_screenSize == -1.0f)
                {
                    try
                    {
                        _screenDpiX = (double)DeviceExtendedProperties.GetValue("RawDpiX");
                        _screenDpiY = (double)DeviceExtendedProperties.GetValue("RawDpiY");
                        _resolution = (Size)DeviceExtendedProperties.GetValue("PhysicalScreenResolution");

                        // calculate screen diagonal in inch
                        _screenSize = Math.Sqrt(Math.Pow(_resolution.Width / _screenDpiX, 2) + Math.Pow(_resolution.Height / _screenDpiY, 2));
                    }
                    catch (Exception e)
                    {
                        // we're on older software with lower screen size, carry on
                        Debug.WriteLine("IsBigScreen error: " + e.Message);
                        _screenSize = 0;
                    }
                }

                return (_screenSize > 5.0f);
            }
        }
    }
}
