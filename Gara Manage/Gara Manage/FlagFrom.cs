using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_Manage
{
    class FlagFrom
    {
        private bool flagTiepNhanSuaChua;
        private bool flagSuaChua;
        private bool flagHoaDonBaoCao;
        private bool flagflagHoaDonSuaChua;
        private bool flagNhapKho;
        private bool flagQuanLyHieuXe;
        private bool flagQuanLyPhuTungSuaChua;
        private bool flagQuanLyPhuTungNhapKho;
        private bool flagQuanLyPhuTungBaoCao;
        private bool flagQuanLyTiencong;
        private bool flagThongKe;

        public bool FlagTiepNhanSuaChua { get => flagTiepNhanSuaChua; set => flagTiepNhanSuaChua = value; }
        public bool FlagSuaChua { get => flagSuaChua; set => flagSuaChua = value; }
        public bool FlagHoaDonBaoCao { get => flagHoaDonBaoCao; set => flagHoaDonBaoCao = value; }
        public bool FlagQuanLyHieuXe { get => flagQuanLyHieuXe; set => flagQuanLyHieuXe = value; }
        public bool FlagQuanLyPhuTungSuaChua { get => flagQuanLyPhuTungSuaChua; set => flagQuanLyPhuTungSuaChua = value; }
        public bool FlagQuanLyTiencong { get => flagQuanLyTiencong; set => flagQuanLyTiencong = value; }
        public bool FlagThongKe { get => flagThongKe; set => flagThongKe = value; }
        public bool FlagQuanLyPhuTungNhapKho { get => flagQuanLyPhuTungNhapKho; set => flagQuanLyPhuTungNhapKho = value; }
        public bool FlagQuanLyPhuTungBaoCao { get => flagQuanLyPhuTungBaoCao; set => flagQuanLyPhuTungBaoCao = value; }
        public bool FlagNhapKho { get => flagNhapKho; set => flagNhapKho = value; }
        public bool FlagHoaDonSuaChua { get => flagflagHoaDonSuaChua; set => flagflagHoaDonSuaChua = value; }

        public FlagFrom () {
            FlagHoaDonBaoCao = false;
            FlagHoaDonSuaChua = false;
            FlagQuanLyPhuTungNhapKho = false;
            FlagQuanLyHieuXe = false;
            FlagQuanLyPhuTungSuaChua = false;
            FlagQuanLyPhuTungNhapKho = false;
            FlagQuanLyPhuTungBaoCao = false;
            FlagQuanLyTiencong = false;
            FlagSuaChua = false;
            FlagThongKe = false;
            FlagTiepNhanSuaChua = false;
        }
    }
}
