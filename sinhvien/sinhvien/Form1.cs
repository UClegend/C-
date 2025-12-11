using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Không cần using System.Collections.Generic; lần thứ hai

namespace sinhvien
{
    // tạo class form 1 kế thừa từ lớp from
    public partial class Form1 : Form
    {
        // Khai báo đối tượng quản lý dữ liệu toàn cục
        private DSHocSinh _dsHocSinh;

        // Biến để lưu đường dẫn file hiện tại
        private string _currentFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            // Khởi tạo đối tượng quản lý dữ liệu
            _dsHocSinh = new DSHocSinh();

            if (dataGridView1.Columns.Count == 0)
            {
                // Định nghĩa các cột cho DataGridView
                dataGridView1.Columns.Add("Id", "ID");
                dataGridView1.Columns.Add("HoTen", "Họ tên");
                dataGridView1.Columns.Add("DiemVan", "Điểm Văn");
                dataGridView1.Columns.Add("DiemToan", "Điểm Toán");
                dataGridView1.Columns.Add("DiemTB", "Điểm Trung Bình");
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns["Id"].ReadOnly = true;
            }

            // Tải dữ liệu ban đầu
            HienThiDuLieu(_dsHocSinh.LayToanBoDanhSach());

            // THÊM DÒNG NÀY:
            CapNhatHienThiID();
        }
        public string TaiKhoanDangNhap { get; set; } // <--- THÊM BIẾN NÀY
        // ...


        // Phương thức tiện ích để cập nhật DataGridView từ List<HocSinh>
        private void HienThiDuLieu(List<HocSinh> danhSach)
        {
            dataGridView1.Rows.Clear();
            foreach (var hs in danhSach)
            {
                dataGridView1.Rows.Add(hs.Id, hs.HoTen, hs.DiemVan, hs.DiemToan, hs.DiemTrungBinh());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) { /* Không dùng */ }
        private void label1_Click(object sender, EventArgs e) { /* Không dùng */ }

        // Nút THÊM HỌC SINH
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = tbtHoten.Text;
                if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(tbtDiemvan.Text) || string.IsNullOrWhiteSpace(tbtDiemtoan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ họ tên và điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double diemVan = double.Parse(tbtDiemvan.Text);
                double diemToan = double.Parse(tbtDiemtoan.Text);

                // Gọi lớp quản lý để thực hiện thêm
                _dsHocSinh.ThemHocSinh(hoTen, diemToan, diemVan);

                // Cập nhật lại giao diện
                HienThiDuLieu(_dsHocSinh.LayToanBoDanhSach());

                // Xóa nội dung trong textbox
                tbtHoten.Clear();
                tbtDiemvan.Clear();
                tbtDiemtoan.Clear();

                CapNhatHienThiID();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng điểm (chỉ số)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbtDiemvan_TextChanged(object sender, EventArgs e) { /* Không dùng */ }
        private void tbtHoten_TextChanged(object sender, EventArgs e) { /* Không dùng */ }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào tiêu đề hoặc vùng trống thì bỏ qua
            if (e.RowIndex == -1 || e.RowIndex >= dataGridView1.Rows.Count) return;

            // Lấy dòng hiện tại đang chọn
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            LayIdTiepTheo.Text = row.Cells["Id"].Value.ToString();

            tbtHoten.Text = row.Cells["HoTen"].Value.ToString();
            tbtDiemvan.Text = row.Cells["DiemVan"].Value.ToString();
            tbtDiemtoan.Text = row.Cells["DiemToan"].Value.ToString();
        }

        // Nút LƯU BÀI (Ghi Tap Tin)
        private void btnLuu_Click_Click(object sender, EventArgs e)
        {
            List<HocSinh> dataToSave = _dsHocSinh.LayToanBoDanhSach();

            // Nếu đã có đường dẫn file, tự động lưu đè
            if (!string.IsNullOrEmpty(_currentFilePath))
            {
                try
                {
                    _dsHocSinh.GhiTapTin(_currentFilePath, dataToSave);
                    MessageBox.Show("Đã lưu thay đổi vào file Excel thành công!", "Thông Báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi Lưu File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            // Nếu chưa có đường dẫn, mở hộp thoại Save
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Lưu danh sách sinh viên ra Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _dsHocSinh.GhiTapTin(saveFileDialog.FileName, dataToSave);
                    _currentFilePath = saveFileDialog.FileName;
                    MessageBox.Show("Đã lưu file mới thành công!", "Thông Báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi Lưu File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Nút NHẬP FILE (Đọc Tap Tin)
        private void btnMo_Click_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV files (*.csv)|*.csv";
            openFile.Title = "Mở danh sách học sinh";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Gọi lớp quản lý để đọc dữ liệu
                    _dsHocSinh.DocTapTin(openFile.FileName);

                    // Cập nhật giao diện
                    HienThiDuLieu(_dsHocSinh.LayToanBoDanhSach());

                    CapNhatHienThiID();

                    // CẬP NHẬT: Lưu đường dẫn file vừa mở
                    _currentFilePath = openFile.FileName;

                    MessageBox.Show("Mở file thành công!", "Thông Báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi Mở File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Nút XÓA (Phân biệt Xóa khỏi Bảng và Xóa khỏi File)
        private void btnXoa_Click_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 && dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một học sinh để xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID và Tên của học sinh được chọn
            int rowIndex = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0].Index : dataGridView1.SelectedCells[0].RowIndex;

            // Ngăn chặn việc xóa hàng mới (NewRow)
            if (rowIndex >= dataGridView1.Rows.Count || dataGridView1.Rows[rowIndex].IsNewRow) return;

            int idCanXoa = int.Parse(dataGridView1.Rows[rowIndex].Cells["Id"].Value.ToString());
            string hoTen = dataGridView1.Rows[rowIndex].Cells["HoTen"].Value.ToString();

            // 1. Xác nhận 1: Hỏi có muốn xóa khỏi bảng hiển thị không
            DialogResult ketQua = MessageBox.Show(
                string.Format("Bạn có chắc chắn muốn xóa {0} khỏi BẢNG HIỂN THỊ không?", hoTen),
                "Xác Nhận Xóa Khỏi Bảng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                _dsHocSinh.XoaHocSinh(idCanXoa);

                // -- ĐOẠN NÀY LÀ MẤU CHỐT ĐỂ TÌM RỒI XÓA KHÔNG BỊ LỖI HIỂN THỊ --
                string tuKhoa = textBox1.Text;
                if (string.IsNullOrEmpty(tuKhoa))
                {
                    HienThiDuLieu(_dsHocSinh.LayToanBoDanhSach());
                }
                else
                {
                    // Nếu đang tìm, xóa xong thì hiển thị lại danh sách ĐÃ LỌC
                    HienThiDuLieu(_dsHocSinh.TimKiem(tuKhoa));
                }

                // Cập nhật lại ô hiển thị ID tiếp theo (vì danh sách bị đánh số lại)
                CapNhatHienThiID();
            }
        }

        // Nút TÌM KIẾM (Lọc trên giao diện)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;

            // Gọi lớp quản lý để tìm kiếm
            List<HocSinh> ketQuaTimKiem = _dsHocSinh.TimKiem(keyword);

            // Cập nhật giao diện với kết quả tìm kiếm
            HienThiDuLieu(ketQuaTimKiem);
        }

        private void LayIdTiepTheo_TextChanged(object sender, EventArgs e)
        {
            // Lấy số ID tiếp theo từ class quản lý
            int nextId = _dsHocSinh.LayIdTiepTheo();

            // Giả sử textbox ID của bạn tên là textBox3 (hoặc tbtID, bạn kiểm tra lại tên bên Design nhé)
            LayIdTiepTheo.Text = nextId.ToString();

            // Nên khóa ô này lại không cho nhập tay, vì ID là tự động
            LayIdTiepTheo.ReadOnly = true;
        }
        private void CapNhatHienThiID()
        {
            // Lấy số ID tiếp theo từ class quản lý
            int nextId = _dsHocSinh.LayIdTiepTheo();

            // Cập nhật vào ô Textbox (giả sử tên Textbox  là LayIdTiepTheo)SS
            // Nếu code báo lỗi đỏ chữ LayIdTiepTheo, hãy đổi thành textBox3 hoặc tên đúng bên Design
            LayIdTiepTheo.Text = nextId.ToString();

            // Khóa ô này lại
            LayIdTiepTheo.ReadOnly = true;
        }

        // Nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào trước
            if (string.IsNullOrWhiteSpace(tbtDiemvan.Text) || string.IsNullOrWhiteSpace(tbtDiemtoan.Text))
            {
                MessageBox.Show("Vui lòng chọn học sinh cần sửa để dữ liệu hiện lên trước!", "Chưa có dữ liệu");
                return;
            }

            try
            {
                // 1. Lấy ID cần sửa (Lấy từ TextBox ID đang hiển thị - CHÚ Ý TÊN TEXTBOX CỦA BẠN)
                // Trong code bạn dùng LayIdTiepTheo.Text, nếu đúng là tên TextBox thì OK.
                // Nhưng thường ID đang sửa phải lấy từ dòng đang chọn, hoặc một TextBox ẩn lưu ID.
                // Ở đây tôi giả sử bạn dùng ô LayIdTiepTheo để hiển thị ID đang chọn khi Click vào bảng.

                int idCanSua;
                if (!int.TryParse(LayIdTiepTheo.Text, out idCanSua))
                {
                    MessageBox.Show("ID không hợp lệ!");
                    return;
                }

                // 2. Lấy dữ liệu mới
                string tenMoi = tbtHoten.Text;
                double vanMoi = double.Parse(tbtDiemvan.Text);
                double toanMoi = double.Parse(tbtDiemtoan.Text);

                // 3. Gọi lệnh sửa ở backend
                bool ketQua = _dsHocSinh.SuaHocSinh(idCanSua, tenMoi, vanMoi, toanMoi);

                // --- ĐÃ SỬA LẠI CẤU TRÚC IF/ELSE TẠI ĐÂY ---
                if (ketQua)
                {
                    MessageBox.Show("Sửa thành công!");

                    // Xóa trắng các ô nhập liệu
                    tbtHoten.Clear();
                    tbtDiemvan.Clear();
                    tbtDiemtoan.Clear();

                    // Cập nhật lại giao diện
                    string tuKhoa = textBox1.Text;
                    if (string.IsNullOrEmpty(tuKhoa))
                    {
                        HienThiDuLieu(_dsHocSinh.LayToanBoDanhSach());
                    }
                    else
                    {
                        HienThiDuLieu(_dsHocSinh.TimKiem(tuKhoa));
                    }

                    // Trả lại trạng thái ID tiếp theo cho lần thêm mới
                    CapNhatHienThiID();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ID này để sửa! (Có thể ID đã bị thay đổi)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập liệu: " + ex.Message);
            }
        }
    }
}