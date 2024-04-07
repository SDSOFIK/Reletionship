using ReletionshipRepstryType.WebApp.Models;

namespace ReletionshipRepstryType.WebApp.ViewModel
{
    public class EmployeeVm
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime JoiningDate { get; set; }
        public Boolean Ssc { get; set; }
        public Boolean Hsc { get; set; }
        public Boolean Bsc { get; set; }
        public Boolean Msc { get; set; }
        public string Picture { get; set; } = string.Empty;
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }  
        public CountryVm Country { get; set; }
        public StateVm State { get; set; }
        public CityVm City { get; set; }
    }
}
