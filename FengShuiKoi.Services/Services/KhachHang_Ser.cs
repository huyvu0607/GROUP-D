using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Reponsitories.Res;
using FengShuiKoi.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiKoi.Services.Services
{
    public class KhachHang_Ser : IKhachHang
    {
        private readonly KhachHang_Res _reponsitories;

        public KhachHang_Ser(KhachHang_Res reponsitories)
        {
            _reponsitories = reponsitories;
        }

        public bool AddKhachHang(KhachHang account)
        {
            return _reponsitories.AddKhachHang(account);
        }

        public bool DelKhachHang(int Id)
        {
            return _reponsitories.DelKhachHang(Id);
        }

        public bool DelKhachHang(KhachHang account)
        {
            return _reponsitories.DelKhachHang(account);
        }

        public Task<List<KhachHang>> GetAllKhachHang()
        {
            return _reponsitories.GetAllKhachHang();
        }

        public Task<KhachHang> GetKhachHangById(int Id)
        {
            return _reponsitories.GetKhachHangById(Id);
        }

        public bool UpdKhachHang(KhachHang account)
        {
            return _reponsitories.UpdKhachHang(account);
        }
    }
}
