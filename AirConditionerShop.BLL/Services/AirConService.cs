﻿using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class AirConService
    {
        private AirConRepository _repo = new(); // new luôn

        // các hàm CRUD AIRCON nhưng gọi qua repo
        public List<AirConditioner> GetAllAirCons()
        {
            return _repo.GetAll();
        }

        public void Delete(AirConditioner obj)
        {
            _repo.Delete(obj); // xong, bán cái cho repo
                               // repo bán cái cho dbcontext
        }

        public void Update(AirConditioner obj) => _repo.Update(obj);
        

        public void Add(AirConditioner obj) => _repo.Create(obj);
        
    }
}
