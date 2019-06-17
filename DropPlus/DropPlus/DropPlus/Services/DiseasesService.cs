using System;
using System.Collections.Generic;
using System.Linq;
using DropPlus.Models;

namespace DropPlus.Services
{
    public static class DiseasesService
    {
        public static List<DiseaseModel> Diseases { get; set; }

        static DiseasesService()
        {
            Diseases = new List<DiseaseModel>()
            {
                new DiseaseModel() {Name = "серцево-судинна система"},
                new DiseaseModel() {Name = "хвороби шкіри"},
                new DiseaseModel() {Name = "цукровий діабет"},
                new DiseaseModel() {Name = "ожиріння"},
                new DiseaseModel() {Name = "хронічні хвороби шлунку"},
                new DiseaseModel() {Name = "хронічні хвороби печінки"},
                new DiseaseModel() {Name = "хронічні хвороби підшлункової залози"},
                new DiseaseModel() {Name = "астма"},
                new DiseaseModel() {Name = "бронхіт"},
                new DiseaseModel() {Name = "варикоз"},
                new DiseaseModel() {Name = "органи травлення"},
                new DiseaseModel() {Name = "опорно-руховий апара"},
                new DiseaseModel() {Name = "захворювання суглобів"}
            };
        }

        public static DiseaseModel Get(string name)
        {
            return Diseases.First(disease => disease.Name == name);
        }

        public static List<DiseaseModel> GetAll()
        {
            return Diseases;
        }
    }
}