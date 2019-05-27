using AutoMapper;
using DropPlus.Models;
using DropPlus.ViewModels;

namespace DropPlus.AutoMapper
{
    public static class Mapping
    {
        public static void Initialize()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<ResortModel, ResortViewModel>();
                config.CreateMap<ResortViewModel, ResortModel>();

                config.CreateMap<ReviewModel, ReviewViewModel>();
                config.CreateMap<ReviewViewModel, ReviewModel>();

                config.CreateMap<UserModel, UserViewModel>();
                config.CreateMap<UserViewModel, UserModel>();

                config.CreateMap<DiseaseModel, DiseaseViewModel>();
                config.CreateMap<DiseaseViewModel, DiseaseModel>();
            });
        }
    }
}