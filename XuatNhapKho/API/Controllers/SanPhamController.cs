using BLL.BLL.Implement;
using BLL.BLL.Interface;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class SanPhamController : ApiController
    {
        private ISanPhamBLL _sanPhamBLL = new SanPhamBLL();
        [HttpGet]
        [Route("SanPham/GetAll")]
        public List<SanPhamModel> GetAll()
        {
            var listSanPhamModel = _sanPhamBLL.GetAll().ToList();
            return listSanPhamModel;
        }
    }
}
