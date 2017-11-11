﻿using Microsoft.Xna.Framework.Input;

namespace ZoomLevelKeybind
{
    internal class ModConfig
    {
        public string IncreaseZoomKey { get; set; } = Keys.OemPeriod.ToString();
        public string DecreaseZoomKey { get; set; } = Keys.OemComma.ToString();
        public string IncreaseZoomButton { get; set; } = Buttons.LeftStick.ToString();
        public string DecreaseZoomButton { get; set; } = Buttons.RightStick.ToString();
        public bool SuppressControllerButton { get; set; } = true;
        public bool MoreZoom { get; set; } = true;
        public bool UnlimitedZoom { get; set; } = false;
    }
}