using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUITamhmor.Models
{
    public class VeiwModel
    {
        public DoctorModel DoctorModel { get; set; }
        public IEnumerable<GoogleProfile> GoogleProfiles { get; set; }
    }
}
