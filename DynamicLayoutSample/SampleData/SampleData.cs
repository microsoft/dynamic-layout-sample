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

using System;
using System.Collections.Generic;

namespace DynamicLayoutSample
{
    public class SampleData
    {
        public string DataTitle { get; set; }
        public Uri DataImage { get; set; }
    }

    public class SampleModel
    {
        static public List<SampleData> _dataSamples = new List<SampleData> {
            new SampleData
            {
                DataTitle = "One",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?1")
            },
            new SampleData
            {
                DataTitle = "Two",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?2")
            },
            new SampleData
            {
                DataTitle = "Three",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?3")
            },
            new SampleData
            {
                DataTitle = "Four",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?4")
            },
            new SampleData
            {
                DataTitle = "Five",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?5")
            },
            new SampleData
            {
                DataTitle = "Six",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?6")
            },
            new SampleData
            {
                DataTitle = "Seven",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?7")
            },
            new SampleData
            {
                DataTitle = "Eight",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?8")
            },
            new SampleData
            {
                DataTitle = "Nine",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?9")
            },
            new SampleData
            {
                DataTitle = "Ten",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?10")
            },
            new SampleData
            {
                DataTitle = "Eleven",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?11")
            },
            new SampleData
            {
                DataTitle = "Twelve",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?12")
            },
            new SampleData
            {
                DataTitle = "Thirteen",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?13")
            },
            new SampleData
            {
                DataTitle = "Fourteen",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?14")
            },
            new SampleData
            {
                DataTitle = "Fifteen",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?15")
            },
            new SampleData
            {
                DataTitle = "Sisteen",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?16")
            },
            new SampleData
            {
                DataTitle = "Seventeen",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?17")
            },
            new SampleData
            {
                DataTitle = "Eighteen",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?18")
            },
            new SampleData
            {
                DataTitle = "Nineteen",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?19")
            },
            new SampleData
            {
                DataTitle = "Twenty",
                DataImage = new Uri("http://lorempixel.com/300/300/cats?20")
            }
        };

        static public List<SampleData> DataSamples
        {
            get
            {
                return _dataSamples;
            }
        }
    }
}
