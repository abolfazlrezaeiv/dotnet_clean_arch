﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Advertisement : IEntity
    {
        public int Id { get; set; }
        public string AdsType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public byte[] photo1 { get; set; }
        public byte[] photo2 { get; set; }
        public DateTime DatePosted { get; set; } = DateTime.UtcNow ;
        public string UserId { get; set; }
        public bool Published { get; set; } = false; 
        public int? Area { get; set; }


    }
}
