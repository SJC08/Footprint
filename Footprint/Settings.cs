﻿using Asjc.JsonConfig;

namespace Footprint
{
    public class Settings : JsonConfig
    {
        public static Settings Instance { get; } = Load<Settings>();

        protected override string DefaultPath => $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Settings.json";

        public string Map { get; set; } = "AMap";

        public string Style { get; set; } = "normal";
    }
}
