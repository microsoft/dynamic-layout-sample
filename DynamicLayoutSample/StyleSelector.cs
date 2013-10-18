/*
 * Copyright © 2013 Nokia Corporation. All rights reserved.
 * Nokia and Nokia Connecting People are registered trademarks of Nokia Corporation. 
 * Other product and company names mentioned herein may be trademarks
 * or trade names of their respective owners. 
 * See LICENSE.TXT for license information.
 */

using System;
using System.Windows;

namespace DynamicLayoutSample
{
    /// <summary>
    /// Helper class for setting the style (UI component, font sizes etc.)
    /// based on the device specifications.
    /// </summary>
    class StyleSelector
    {
        static public void SetStyle()
        {
            if (ScreenSizeHelper.IsBigScreen)
            {
                var appTheme = new ResourceDictionary {
                    Source = new Uri("/DynamicLayoutSample;component/Themes/SampleDataItemStyle1080p.xaml", UriKind.Relative)
                };
            
                Application.Current.Resources.MergedDictionaries.Add(appTheme);
            }
        }
    }
}
