﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs.Category
{
    public class CategoryListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public byte[]? CategoryImage { get; set; }


        public DateTime CreatedAt { get; set; }

        public DateTime UpdateDate { get; set; }

    }
}
