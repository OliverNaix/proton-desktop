using System;
using System.Collections.Generic;
using System.Text;

namespace ProtonKernel.Models
{
    public class Update
    {
        public string Type { get; set; }
        public object Object { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccessStatusCode
        {
            get => StatusCode >= 200 && StatusCode <= 299;
        }
    }
}
