﻿using Backend.DAL.Entities.Common.InstrumentalStudies;
using Backend.DAL.Entities.InjuriesDiseasesEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.DAL.Interfaces.Repositories
{
    public interface IInjuriesDiseasesRepository : IGenericRepository<InjuriesDiseases>
    {
        InjuriesDiseases GetFullById(int id);
        List<MRI> GetMRIById(int id);
        List<HeartUltrasound> GetHeartUltrasoundById(int id);

        void InsertHeartUltrasound(int id, HeartUltrasound heartUltrasound);
        void InsertMRI(int id, MRI mri);


    }
}
