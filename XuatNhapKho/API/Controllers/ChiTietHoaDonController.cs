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
    public class ChiTietHoaDonController : ApiController
    {
        private IChiTietHoaDonBLL _chiTietHoaDonBLL = new ChiTietHoaDonBLL();
        [HttpPost]
        [Route("ChiTietHoaDon/InsertChiTietHoaDon")]
        public void InsertChiTietHoaDon(ListHoaDon listHoaDon)
        {
            if (listHoaDon == null || listHoaDon.listHoaDon == null || listHoaDon.listHoaDon.Count == 0) return;
            _chiTietHoaDonBLL.InsertListHoaDon(listHoaDon);
        }
    }
}
