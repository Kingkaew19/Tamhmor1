using back.Tamhmor.api.Models;
using back.Tamhmor.api.Repositories.Interfaces;
using back.Tamhmor.api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Tamhmor.api.Services.Implements
{
    public class DoctorService : IDoctorService
    {
        private readonly IBaseRepository baseRepository;
        string searchText;
        public DoctorService(IBaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public List<DoctorModel> getdoctor(int Did)
        {
            var result = baseRepository.QueryStoredProcedure<DoctorModel>("Sp_Doctor", null);

            return result.ToList();
        }
        public List<DoctorModel> departmentdoctor()
        {
            var result = baseRepository.QueryStoredProcedure<DoctorModel>("Sp_departmentDoctor", null);

            return result.ToList();
        }
        public List<DoctorModel> searchdoctor()
        {
            var result = baseRepository.QueryStoredProcedure<DoctorModel>("Sp_searchDoctor", null);

            return result.ToList();
        }

    }
}
