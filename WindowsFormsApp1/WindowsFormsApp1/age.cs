using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class age
    {
        public int Tahun;
        public int Bulan;
        public int Hari;

        public age(DateTime TanggalUlangTahun)
        {
            this.Count(TanggalUlangTahun);
        }

        public age(DateTime TanggalUlangTahun, DateTime TanggalHariIni)
        {
            this.Count(TanggalUlangTahun, TanggalHariIni);
        }

        public age Count(DateTime TanggalUlangTahun)
        {
            return this.Count(TanggalUlangTahun, DateTime.Today);
        }

        public age Count(DateTime TanggalUlangTahun, DateTime TanggalHariIni)
        {
            if ((TanggalHariIni.Year - TanggalUlangTahun.Year) > 0 ||
                (((TanggalHariIni.Year - TanggalUlangTahun.Year) == 0) && ((TanggalUlangTahun.Month < TanggalHariIni.Month) ||
                ((TanggalUlangTahun.Month == TanggalHariIni.Month) && (TanggalUlangTahun.Day <= TanggalHariIni.Day)))))
            {
                int JumlahHariPadaBulanUlangTahun = DateTime.DaysInMonth(TanggalUlangTahun.Year, TanggalUlangTahun.Month);
                int SisaHari = TanggalHariIni.Day + (JumlahHariPadaBulanUlangTahun - TanggalUlangTahun.Day);

                if (TanggalHariIni.Month > TanggalUlangTahun.Month)
                {
                    this.Tahun = TanggalHariIni.Year - TanggalUlangTahun.Year;
                    this.Bulan = TanggalHariIni.Month - (TanggalUlangTahun.Month + 1) + Math.Abs(SisaHari / JumlahHariPadaBulanUlangTahun);
                    this.Hari = (SisaHari % JumlahHariPadaBulanUlangTahun + JumlahHariPadaBulanUlangTahun) % JumlahHariPadaBulanUlangTahun;
                }
                else if (TanggalHariIni.Month == TanggalUlangTahun.Month)
                {
                    if (TanggalHariIni.Day >= TanggalUlangTahun.Day)
                    {
                        this.Tahun = TanggalHariIni.Year - TanggalUlangTahun.Year;
                        this.Bulan = 0;
                        this.Hari = TanggalHariIni.Day - TanggalUlangTahun.Day;
                    }
                    else
                    {
                        this.Tahun = (TanggalHariIni.Year - 1) - TanggalUlangTahun.Year;
                        this.Bulan = 11;
                        this.Hari = DateTime.DaysInMonth(TanggalUlangTahun.Year, TanggalUlangTahun.Month) - (TanggalUlangTahun.Day - TanggalHariIni.Day);
                    }
                }
                else
                {
                    this.Tahun = (TanggalHariIni.Year - 1) - TanggalUlangTahun.Year;
                    this.Bulan = TanggalHariIni.Month + (11 - TanggalUlangTahun.Month) + Math.Abs(SisaHari / JumlahHariPadaBulanUlangTahun);
                    this.Hari = (SisaHari % JumlahHariPadaBulanUlangTahun + JumlahHariPadaBulanUlangTahun) % JumlahHariPadaBulanUlangTahun;
                }
            }
            else
            {
                throw new ArgumentException();
            }
            return this;
        }
    }

}
