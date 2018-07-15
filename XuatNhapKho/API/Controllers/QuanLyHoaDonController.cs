using BLL.BLL.Implement;
using BLL.BLL.Interface;
using Models.Models;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class QuanLyHoaDonController : ApiController
    {
        private IQuanLyHoaDonBLL _quanLyHoaDonBLL = new QuanLyHoaDonBLL();
        [HttpGet]
        [Route("QuanLyHoaDon/GetAll")]
        public List<QuanLyHoaDonModel> GetAll()
        {
            var listQuanLyHoaDon = _quanLyHoaDonBLL.GetAll();
            return listQuanLyHoaDon;
        }
    }
}
