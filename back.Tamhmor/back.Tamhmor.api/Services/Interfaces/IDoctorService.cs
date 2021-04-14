using back.Tamhmor.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Tamhmor.api.Services.Interfaces
{
    public interface IDoctorService
    {
        List<DoctorModel> getdoctor(int Did);
        List<DoctorModel> departmentdoctor();
        List<DoctorModel> searchdoctor();
    }

    
}
