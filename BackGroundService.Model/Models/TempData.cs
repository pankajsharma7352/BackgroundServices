using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundService.Model.Models
{
    public  class TempData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSent { get; set; } = false;
    }
}
