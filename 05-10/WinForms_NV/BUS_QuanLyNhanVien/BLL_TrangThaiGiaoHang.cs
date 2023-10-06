﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_TrangThaiGiaoHang
    {
        public List<OrderData_TrangThaiGiaoHang> getListFromDAL()
        {
            var api = new API_TrangThaiGiaoHang();
            return api.GetListDataFrom();
        }
    }
}
