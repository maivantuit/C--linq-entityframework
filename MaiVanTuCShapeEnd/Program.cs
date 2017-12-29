using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiVanTuCShapeEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ModelBanHangZ();
            // Question 1: 
            Console.WriteLine("Dislay list customer with name sort(asc) and age(dec)");
            var kq1 = from kh in db.KhachHangs
                      orderby kh.TenKH ascending
                      , kh.Tuoi descending
                      select kh;
            foreach (var item in kq1)
            {
                Console.WriteLine(item.Tuoi + " - " + item.TenKH);
            }
            // 
           

            // Question 2: 
            var kq2 = (from kh in db.DatHangs
                      where kh.MaDH > 2
                      orderby kh.TenDH
                      select new OrderViewModel() { ID=kh.MaDH, Name = kh.TenDH , NgatDat = kh.NgayDat}).First();
            Console.WriteLine("Dislay makh> 1 and sort name order, the first:");
            //Console.WriteLine(kq2.MaDH + " - " + kq2.TenDH + " - " + kq2.NgayDat);

            var kq2b = (from d in db.DatHangs
                        where d.NgayDat > DateTime.Today
                        select d).First();
            Console.WriteLine("Dislay orderdate> now date and sort name order, the first:");
            Console.WriteLine(kq2b.MaDH + " - " + kq2b.TenDH + " - " + kq2b.NgayDat);

            // Question 3a:
            Console.WriteLine("question 5: insert a customer into table customer: ");

            List<KhachHang> list1 = (from s in db.KhachHangs
                                     select s).ToList();
            foreach (var item in list1)
            {
                Console.WriteLine(item.TenKH);
            }
            KhachHang kh1 = new KhachHang { MaKH = 5, TenKH = "Hạnh Nhân", Tuoi = 19, DiaChi = "Hải Phòng" };
            db.KhachHangs.Add(kh1);
            KhachHang kh2 = new KhachHang { MaKH = 6, TenKH = "Hạnh Nhân2", Tuoi = 20, DiaChi = "Hải Phòng" };
            db.KhachHangs.Add(kh2);
            db.SaveChanges();

            // Question 3b:
            Console.WriteLine("question 5: insert multiple  into order: ");
            List<DatHang> list2 = new List<DatHang>();
            list2.Add(new DatHang { MaKH = 1, MaDH = 5, TenDH = "DonHang5", DiachiDatHang = "44 Cao Thắng" });
            list2.Add(new DatHang { MaKH = 1, MaDH = 6, TenDH = "DonHang6", DiachiDatHang = "44 Cao Thắng" });
            db.DatHangs.AddRange(list2);
            db.SaveChanges();

            // to teacher:
            KhachHang kh10 = new KhachHang { MaKH = 100, TenKH = "Hạnh Nhân100", Tuoi = 19, DiaChi="Hải Phòng" };
            db.KhachHangs.Add(kh10);
            db.SaveChanges();
            List<DatHang> list10 = new List<DatHang>();
            list10.Add(new DatHang { MaKH = 100, MaDH = 101, TenDH = "DonHang101", DiachiDatHang = "44 Cao Thắng", NgayDat = new DateTime(2017,2,20) });
            list10.Add(new DatHang { MaKH = 100, MaDH = 102, TenDH = "DonHang102", DiachiDatHang = "44 Cao Thắng", NgayDat = new DateTime(2017, 2, 20) });                  
            db.DatHangs.AddRange(list10);
            db.SaveChanges();
            // Question 4: Tìm khách hàng có makh == 2, sau đó update khách hàng đó.
            KhachHang khtim = (from kh in db.KhachHangs
                               where kh.MaKH == 2
                               select kh).First();


            if (khtim != null)
            {
                Console.WriteLine("Customer have ID == 2:" + khtim.TenKH);
                khtim.TenKH = "Khánh Nhi Updated";
                khtim.DiaChi = "TPHCM of KH Updated";
            }
            else
            {
                throw new Exception("Not found that customer");
            }
            db.SaveChanges();
            Console.ReadLine();
        }
    }
}
