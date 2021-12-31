﻿using System.Collections.Generic;
using System.Linq;
using TrungTamNgoaiNgu.DAL;
using TrungTamNgoaiNgu.DTO;

namespace TrungTamNgoaiNgu.BUS
{
    internal class Bus_ThiSinh
    {
        Dal_ThiSinh dal = new Dal_ThiSinh();

        public List<Dto_ThiSinh> LayDanhSachThiSinh()
        {
            return dal.LayDanhSachThiSinh();
        }

        public bool ThemTS(Dto_ThiSinh TS)
        {
            if (dal.ThemTs(dtoToEntity(TS))) return true;
            return false;
        }

        public bool XoaTS(int id)
        {
            return dal.XoaTs(id);
        }

        public List<ThiSinh> TimKiemTS(List<ThiSinh> dsTs, string key)
        {
            var res = dsTs.Where(t => t.HoTen.Contains(key)).ToList();
            return res;
        }

       public ThiSinh LayThongTinTS(int id)
        {
           return dal.LayThongTinTS(id);
        }

        public ThiSinh dtoToEntity (Dto_ThiSinh dto)
        {
            ThiSinh ts = new ThiSinh();
            ts.Id = dto.Id;
            ts.HoTen = dto.HoTen;
            ts.GioiTinh = dto.GioiTinh;
            ts.NgaySinh = dto.NgaySinh;
            ts.NoiSinh  = dto.NoiSinh;
            ts.CMND = dto.CMND;
            ts.NgayCap = dto.NgayCap;
            ts.NoiCap = dto.NoiCap;
            ts.SDT = dto.SDT;
            ts.Email = dto.Email;
            return ts;
        }
    }
}
