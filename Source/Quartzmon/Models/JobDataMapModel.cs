﻿using System.Collections.Generic;

namespace Quartzmon.Models
{
    public class JobDataMapModel
    {
        public List<JobDataMapItem> Items { get; } = new List<JobDataMapItem>();
        public JobDataMapItem Template { get; set; }
    }
}
