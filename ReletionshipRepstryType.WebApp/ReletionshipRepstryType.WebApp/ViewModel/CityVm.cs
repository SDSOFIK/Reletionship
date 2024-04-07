using AutoMapper;
using ReletionshipRepstryType.WebApp.Models;

namespace ReletionshipRepstryType.WebApp.ViewModel;
[AutoMap(typeof(City), ReverseMap = true)]
public class CityVm
{
    public int Id { get; set; }
    public string CityName { get; set; } = string.Empty;
    public int StateId { get; set; }
    public StateVm States { get; set; }
}
