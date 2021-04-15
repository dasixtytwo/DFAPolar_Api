﻿using DFAPolar.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DFAPolar.Domain.Interfaces
{
    public interface IUserService
    {
        Task<UserModel> Authenticate(string email, string password);
        string GenerateJWTToken(UserModel user);
        Task<IEnumerable<UserModel>> GetAll();
        Task<UserModel> GetById(int id);
        Task<UserModel> Create(UserModel user, string password);
        void Update(UserModel user, string password = null);
        void Delete(int id);
    }
}
