﻿/*
 * Copyright © 2016 - 2020 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * 
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */

using System.Drawing;

namespace ExtendedControls.Controls
{
    public partial class AstroPlot
    {
        internal class Axis
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
            public PointF Coords { get; set; } = new PointF(0, 0);
        }

        internal void SetAxesCoordinates(int length)
        {
            if (!ShowAxesWidget)
            {
                return;
            }
            else if (centerCoordinates != null)
            {
                ShowAxesWidget = false;
                Axes.Clear();

                Axes.Add(new Axis
                {
                    X = CenterCoordinates[0],
                    Y = CenterCoordinates[1],
                    Z = CenterCoordinates[2]
                });
                Axes.Add(new Axis
                {
                    X = CenterCoordinates[0] + length,
                    Y = CenterCoordinates[1],
                    Z = CenterCoordinates[2]
                });
                Axes.Add(new Axis
                {
                    X = CenterCoordinates[0],
                    Y = CenterCoordinates[1] + (length * -1),
                    Z = CenterCoordinates[2]
                });
                Axes.Add(new Axis
                {
                    X = CenterCoordinates[0],
                    Y = CenterCoordinates[1],
                    Z = CenterCoordinates[2] + (length * -1)
                });

                ShowAxesWidget = true;
            }
        }
    }
}