﻿using System;
using System.Collections.Generic;

namespace eStore_Admin.Application.Filtering.Models
{
    public class MouseFilterModel
    {
        public ICollection<bool?> IsDeletedValues { get; set; }
        public string NameSearchString { get; set; }
        public ICollection<int> ManufacturerIds { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public DateTime CreatedStartDate { get; set; }
        public DateTime CreatedEndDate { get; set; }
        public float? MinWeight { get; set; }
        public float? MaxWeight { get; set; }
        public ICollection<int> ConnectionTypeIds { get; set; }
        public ICollection<int> BacklightIds { get; set; }
    }
}