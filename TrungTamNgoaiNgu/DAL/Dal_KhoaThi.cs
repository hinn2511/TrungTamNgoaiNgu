﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TrungTamNgoaiNgu.DTO;

namespace TrungTamNgoaiNgu.DAL
{
    public class Dal_KhoaThi
    {
        QLTTNNDataContext context = new QLTTNNDataContext();

        public List<Dto_KhoaThi> DanhSachKhoaThi()
        {
            var dsKhoaThi = context.KhoaThis.Select(kt => new Dto_KhoaThi
            {
                Id = kt.Id,
                TenKhoaThi = kt.TenKhoaThi,
                NgayThi = kt.NgayThi,
            }).ToList();
            return dsKhoaThi;
        }

        public bool DaTaoKhoaThi(DateTime thoigian)
        {
            return context.KhoaThis.Where(kt => kt.NgayThi.Month == thoigian.Month && kt.NgayThi.Year == thoigian.Year).Any();
        }


        public bool ThemKhoaThi(KhoaThi khoaThi)
        {

            context.KhoaThis.InsertOnSubmit(khoaThi);
            try
            {
                context.SubmitChanges();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool XoaKhoaThi(int id)
        {
            var kt = context.KhoaThis.FirstOrDefault(t => t.Id == id);

            if (kt != null)
            {
                context.KhoaThis.DeleteOnSubmit(kt);

                try
                {
                    context.SubmitChanges();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
            return false;

        }

    }
}
