using back.Tamhmor.api.Models;
using back.Tamhmor.api.Repositories.Interfaces;
using back.Tamhmor.api.Services.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Tamhmor.api.Services.Implements
{
    public class LoginService : ILoginService
    {
        private readonly IBaseRepository baseRepository;
        public LoginService(IBaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public string addUsers(UsersModel usersModel)
        {
            var spParam = new DynamicParameters();
            spParam.Add("@uid", usersModel.Uid);
            spParam.Add("@ufname", usersModel.Ufname);
            spParam.Add("@ulname", usersModel.Ulname);
            spParam.Add("@usex", usersModel.Usex);
            spParam.Add("@uemail", usersModel.Uemail);

            var result = baseRepository.ExecuteStoredProcedure<UsersModel>("Sp_addUsers", spParam);
            if (result != 0)
                return "Add success";
            else
                return "Add unsuccess";
        }
    }
}
