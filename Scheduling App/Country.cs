using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_App
{
    public class Country
    {
        public int CountryId { get; }
        public string CountryName { get; }
        public DateTime CreateDate { get; }
        public string CreatedBy { get; }
        public DateTime LastUpdate { get; }
        public string LastUpdateBy { get; }

        public Country(int countryId, string countryName, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CountryId = countryId;
            CountryName = countryName;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
    }
}
