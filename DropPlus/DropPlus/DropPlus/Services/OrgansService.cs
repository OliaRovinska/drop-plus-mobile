using System.Collections.Generic;
using DropPlus.Models;
using DropPlus.ViewModels;

namespace DropPlus.Services
{
    public static class OrgansService
    {
        public static List<OrganViewModel> Organs { get; set; }

        static OrgansService()
        {
            Organs = new List<OrganViewModel>()
            {
                new OrganViewModel() {Name = "Серце"},
                new OrganViewModel() {Name = "Печінка"},
                new OrganViewModel() {Name = "Легені"},
                new OrganViewModel() {Name = "Суглоби"},
                new OrganViewModel() {Name = "Нирки"}
            };
        }

        public static List<OrganViewModel> GetAll()
        {
            return Organs;
        }
    }
}