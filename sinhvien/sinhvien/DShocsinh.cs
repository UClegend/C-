using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sinhvien
{
    public class DSHocSinh
    {
        private List<HocSinh> _danhSach;
        private int _nextId;

        public DSHocSinh()
        {
            _danhSach = new List<HocSinh>();
            _nextId = 1;
        }

        // --- CHỈ GIỮ LẠI MỘT HÀM NÀY ---
        public int LayIdTiepTheo()
        {
            return _nextId;
        }

        public List<HocSinh> LayToanBoDanhSach()
        {
            return _danhSach;
        }

        private void CapNhatID()
        {
            int tempId = 1;
            foreach (var hs in _danhSach)
            {
                hs.Id = tempId;
                tempId++;
            }
            _nextId = tempId;
        }

        public HocSinh ThemHocSinh(string hoTen, double diemToan, double diemVan)
        {
            HocSinh hs = new HocSinh(_nextId, hoTen, diemToan, diemVan);
            _danhSach.Add(hs);
            _nextId++;
            return hs;
        }

        public bool XoaHocSinh(int idHocSinh)
        {
            HocSinh hsCanXoa = _danhSach.FirstOrDefault(hs => hs.Id == idHocSinh);
            if (hsCanXoa != null)
            {
                _danhSach.Remove(hsCanXoa);
                CapNhatID();
                return true;
            }
            return false;
        }

        public List<HocSinh> TimKiem(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return _danhSach;
            }
            string key = keyword.Trim().ToLower();
            return _danhSach.Where(hs => hs.HoTen.ToLower().Contains(key)).ToList();
        }

        public bool DocTapTin(string filePath)
        {
            if (!File.Exists(filePath)) return false;
            try
            {
                _danhSach.Clear();
                using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
                {
                    string line;
                    bool firstLine = true;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (firstLine) { firstLine = false; continue; }
                        string[] values = line.Split(',');
                        if (values.Length >= 5)
                        {
                            string hoTen = values[1];
                            double diemVan = double.Parse(values[2]);
                            double diemToan = double.Parse(values[3]);
                            _danhSach.Add(new HocSinh(0, hoTen, diemToan, diemVan));
                        }
                    }
                }
                CapNhatID();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đọc file CSV: " + ex.Message);
            }
        }

        public bool GhiTapTin(string filePath, List<HocSinh> dataToSave)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    writer.WriteLine("ID,Họ tên,Điểm Văn,Điểm Toán,Điểm Trung Bình");
                    foreach (HocSinh hs in dataToSave)
                    {
                        writer.WriteLine(string.Join(",", hs.Id, hs.HoTen, hs.DiemVan, hs.DiemToan, hs.DiemTrungBinh()));
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi ghi file CSV: " + ex.Message);
            }
        }

        // Đã xóa hàm LayIdTiepTheo() bị thừa ở đây

        public bool SuaHocSinh(int idCanSua, string tenMoi, double vanMoi, double toanMoi)
        {
            HocSinh hs = _danhSach.FirstOrDefault(h => h.Id == idCanSua);
            if (hs != null)
            {
                hs.HoTen = tenMoi;
                hs.DiemVan = vanMoi;
                hs.DiemToan = toanMoi;
                return true;
            }
            return false;
        }
    }
}