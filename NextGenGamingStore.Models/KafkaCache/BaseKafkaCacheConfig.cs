﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGenGamingStore.Models.KafkaCache
{
    public abstract class BaseKafkaCacheConfig
    {
        public string BootstrapServer { get; set; } = string.Empty;


        public string Topic { get; set; } = string.Empty;
    }
}
