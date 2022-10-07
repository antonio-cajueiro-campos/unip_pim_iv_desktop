using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unip_pim_iv_desktop.Models
{
    internal class DefaultResponse
    {
        public int Status { get; set; }
        public bool Error { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
    }
}
