﻿using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Dto
{
    public class CustomerDto
    {
        public string Customername { get; set; }
        public string CustomerPassword { get; set; }

        public string CustomerMail { get; set; }
        public int? CustomerPhoneNumber { get; set; }
    }
}
