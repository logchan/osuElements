﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace osuElements.Events
{
    public class SampleEvent:Event
    {
        public string FilePath;
        public int Volume;
        public SampleEvent(int startTime,  string filepath, int volume=100, EventLayer layer=EventLayer.Background)
        {
            Type = EventTypes.Sample;
            Layer = layer;
            StartTime = startTime;
            FilePath = filepath;
            Volume = volume;
        }
        public override string ToString() => $"{Type},{StartTime},{(int) Layer},\"{FilePath}\",{Volume}";
    }
}