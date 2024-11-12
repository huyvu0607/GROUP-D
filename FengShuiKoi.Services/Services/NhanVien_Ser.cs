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
    public class NhanVien_Ser : INhanVien
    {
        private readonly Avertise_Res _reponsitories;

        public NhanVien_Ser(Avertise_Res reponsitories)
        {
            _reponsitories = reponsitories;
        }

        public bool AddNhanvien(NhanVien account)
        {
            return _reponsitories.AddNhanvien(account);
        }

        public bool DelNhanvien(int Id)
        {
            return _reponsitories.DelNhanvien(Id);
        }

        public bool DelNhanvien(NhanVien account)
        {
            return _reponsitories.DelNhanvien(account);
        }

        public Task<List<NhanVien>> GetAllNhanVien()
        {
            return _reponsitories.GetAllNhanVien();
        }

        public Task<NhanVien> GetNhanvienById(int Id)
        {
            return _reponsitories.GetNhanvienById(Id);
        }

        public bool UpdNhanvien(NhanVien account)
        {
            return _reponsitories.UpdNhanvien(account);
        }
    }
}
