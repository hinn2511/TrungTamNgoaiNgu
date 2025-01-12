﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamNgoaiNgu.DAL;
using TrungTamNgoaiNgu.DTO;

namespace TrungTamNgoaiNgu.BUS
{
    public class Bus_DSPhongThi
    {
        Dal_PhongThi dal_phongthi = new Dal_PhongThi();

        Dal_DSPhongThi dal_dsphongthi = new Dal_DSPhongThi();

        Dal_KhoaThi dal_khoaThi = new Dal_KhoaThi();

        public List<Dto_KhoaThi> LayDanhSachKhoaThi()
        {
            return dal_khoaThi.DanhSachKhoaThi();
        }

        public List<Dto_PhongThi> LayDanhSachPhongThi(int khoaThiId)
        {
            var dsPhongThi = dal_phongthi.DanhSachPhongThi(khoaThiId);
            return dsPhongThi.Any() ? dsPhongThi : null;
        }

        public List<Dto_DSPhongThi> DanhSachThiSinhTheoPhong(int phongThiId)
        {
            var dsThi = dal_dsphongthi.DanhSachThiSinh(phongThiId);
            int stt = 1;
            foreach (var item in dsThi)
            {
                item.SoThuTu = stt++;
            }
            return dsThi;
        }

        public List<Dto_DSPhongThi> DanhSachThiSinhTheoKhoaVaPhong(int khoaThiId, int phongThiId)
        {
            var dsThi = dal_dsphongthi.DanhSachThiSinh(khoaThiId, phongThiId);
            int stt = 1;
            foreach (var item in dsThi)
            {
                item.SoThuTu = stt++;
            }
            return dsThi;
        }

        public Dto_KetQuaThiWeb KetQuaThiSinhTheoPhongVaMaThiSinh(int phongThiId, int thiSinhId)
        {
            return dal_dsphongthi.KetQuaTheoPhongVaMaThiSinh(phongThiId, thiSinhId);
        }


        public Dto_GiayChungNhan LayGiayChungNhan(int phongThiId, int thiSinhId)
        {
            var cn = dal_dsphongthi.LayGiayChungNhan(phongThiId, thiSinhId);
            cn.DiemThi = (cn.DiemNghe + cn.DiemNoi + cn.DiemDoc + cn.DiemViet) / 10;
            return cn;
        }

        public bool TonTaiSBD(int khoaThi, string sbd)
        {
            return dal_dsphongthi.TonTaiSBD(khoaThi, sbd);
        }

        public Dto_GiayChungNhan LayGiayChungNhan(int khoaThi, string sbd)
        {
            var cn = dal_dsphongthi.LayGiayChungNhan(khoaThi, sbd);
            cn.DiemThi = (cn.DiemNghe + cn.DiemNoi + cn.DiemDoc + cn.DiemViet) / 10;
            return cn;
        }

        public List<Dto_KetQuaThi> LayKetQua(string type, string key)
        {
            switch (type)
            {
                case "sdt":
                    var kqsdt = dal_dsphongthi.KetQuaTheoSDT(key);
                    return kqsdt.Any() ? kqsdt : null;
                default:
                    var kgten = dal_dsphongthi.LayKetQuaTheoTenThiSinh(key);
                    return kgten.Any() ? kgten : null;
            }
        }

        public List<Dto_KetQuaThi> TimKiemThiSinh(string type, string key)
        {
            switch (type)
            {
                case "sdt":
                    return dal_dsphongthi.KetQuaTheoSDT(key);
                default:
                    return dal_dsphongthi.LayKetQuaTheoTenThiSinh(key);
            }
        }

        public string CapNhatDiem(List<Dto_DSPhongThi> dsdiem)
        {
            foreach (var item in dsdiem)
            {
                if (dal_dsphongthi.CapNhatDanhSachThi(convertToEntity(item)))
                    continue;
                else
                    return "failed";
            }
            return "success";
        }

        public DanhSachPhongThi convertToEntity(Dto_DSPhongThi dto)
        {
            DanhSachPhongThi dspt = new DanhSachPhongThi();
            dspt.Id = dto.Id;
            dspt.SBD = dto.SBD;
            dspt.Id_ThiSinh = dto.Id_ThiSinh;
            dspt.Id_PhongThi = dto.Id_PhongThi;
            dspt.DiemNghe = dto.DiemNghe;
            dspt.DiemNoi = dto.DiemNoi;
            dspt.DiemDoc = dto.DiemDoc;
            dspt.DiemViet = dto.DiemViet;
            return dspt;
        }
    }
}
