﻿namespace eStore_Admin.Application.Responses
{
    public class KeyboardSwitchResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        public bool IsTactile { get; set; }
        public bool IsClicking { get; set; }
    }
}