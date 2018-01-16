﻿using OneBlog.Helpers;
using SS.Toolkit.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneBlog.Data
{
    [DataContract]
    public class StoreApp
    {
        public StoreApp()
        {
            Id = GuidHelper.Gen();
        }
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Icon { get; set; }
        [DataMember]
        public string AppName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string PDB { get; set; }
        [DataMember]
        public string ProductId { get; set; }

        [IgnoreDataMember]
        public StoreCategories Categories { get; set; }
    }
}
