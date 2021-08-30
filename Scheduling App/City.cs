using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_App
{
    public class City
    {
        public int CityId { get; }
        public string CityName { get; }
        public int CountryId { get; }
        public DateTime CreateDate { get; }
        public string CreatedBy { get; }
        public DateTime LastUpdate { get; }
        public string LastUpdateBy { get; }

        public City(int cityId, string cityName, int countryId, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CityId = cityId;
            CityName = cityName;
            CountryId = countryId;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
    }
}