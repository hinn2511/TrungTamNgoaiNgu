﻿using System.Collections.Generic;
using System.Linq;
using TrungTamNgoaiNgu.DAL;
using TrungTamNgoaiNgu.DTO;

namespace TrungTamNgoaiNgu.BUS
{
    public class Bus_ThiSinh
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
// Thêm thí sinh dto thisinh2
        public bool ThemTS(Dto_ThiSinh_PhieuDangKy TS2)
        {
            Dto_ThiSinh TS = new Dto_ThiSinh();
            TS.HoTen = TS2.HoTen;
            TS.GioiTinh = TS2.GioiTinh;
            TS.NgaySinh = TS2.NgaySinh;
            TS.NoiSinh = TS2.NoiSinh;
            TS.CMND = TS2.CMND;
            TS.NgayCap = TS2.NgayCap;
            TS.NoiCap = TS2.NoiCap;
            TS.SDT = TS2.SDT;
            TS.Email = TS2.Email;

            if (dal.ThemTs(dtoToEntity(TS))) return true;
            return false;
        }


        public bool XoaTS(int id)
        {
            return dal.XoaTs(id);
        }

        public List<Dto_ThiSinh> TimKiemTS(List<Dto_ThiSinh> dsTs, string key)
        {
            List<Dto_ThiSinh> kq= new List<Dto_ThiSinh>();
            foreach (var item in dsTs)
            {
                if (item.HoTen.Contains(key))
                {
                    kq.Add(item);
                }
            }
            return kq;
        }

        public ThiSinh LayThongTinTS(int id)
        {
           return dal.LayThongTinTS(id);
        }

        public int LayThiSinhVuaThem()
        {
            return dal.MaThiSihhMoiNhat();
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

        public Dto_ThiSinh convertToDto (ThiSinh ts)
        {
            Dto_ThiSinh dto = new Dto_ThiSinh();
            dto.Id = ts.Id;
            dto.HoTen = ts.HoTen;
            dto.GioiTinh=ts.GioiTinh;
            dto.NgaySinh=ts.NgaySinh;
            dto.NoiSinh =ts.NoiSinh;
            dto.CMND = ts.CMND;
            dto.NgayCap=ts.NgayCap;
            dto.NoiCap =ts.NoiCap;
            dto.Email = ts.Email;
            dto.SDT = ts.SDT;
            return dto;

        }
    }
}
