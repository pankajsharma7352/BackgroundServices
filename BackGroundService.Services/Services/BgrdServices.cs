using BackGroundService.Data.DatabaseContext;
using BackGroundService.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundService.Services.Services
{
    public class BgrdServices
    {
        private readonly BackgroundContext backgroundContext;

        public BgrdServices(BackgroundContext backgroundContext)
        {
            this.backgroundContext = backgroundContext;
        }

        public string InsertInToTemp(TempDTO tempDTO)
        {
             TempData tempdata = new TempData();
            tempdata.Name = tempDTO.Name;
            tempdata.IsSent = tempDTO.IsSent;

            backgroundContext.TempData.Add(tempdata);
            backgroundContext.SaveChanges();
            return "Data added successfully";
        }

    }
}
