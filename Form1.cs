using System;
using System.Windows.Forms;

namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cboDonViTinh.Items.Count > 0)
            {
                cboDonViTinh.SelectedIndex = 0;
            }
        }

        private bool KiemTraTonTaiMaVT(string maVT)
        {
            foreach (ListViewItem item in lsvVatTu.Items)
            {
                if (item.Text.Equals(maVT, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void ClearInputs()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            if (cboDonViTinh.Items.Count > 0)
            {
                cboDonViTinh.SelectedIndex = 0;
            }
            txtDonGia.Clear();
            txtMaVT.Enabled = true;
            txtMaVT.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maVT = txtMaVT.Text.Trim();
            string tenVT = txtTenVT.Text.Trim();
            string donViTinh = cboDonViTinh.SelectedItem?.ToString() ?? "";
            string donGiaStr = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(maVT))
            {
                MessageBox.Show("Vui lòng nhập Mã vật tư!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return;
            }

            if (KiemTraTonTaiMaVT(maVT))
            {
                MessageBox.Show($"Mã vật tư '{maVT}' đã tồn tại trong danh sách!", "Kiểm tra trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.SelectAll();
                txtMaVT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tenVT))
            {
                MessageBox.Show("Vui lòng nhập Tên vật tư!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVT.Focus();
                return;
            }

            if (!decimal.TryParse(donGiaStr, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá nhập phải là số lớn hơn hoặc bằng 0!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.SelectAll();
                txtDonGia.Focus();
                return;
            }

            ListViewItem item = new ListViewItem(maVT);
            item.SubItems.Add(tenVT);
            item.SubItems.Add(donViTinh);
            item.SubItems.Add(donGia.ToString("N0"));

            lsvVatTu.Items.Add(item);
            MessageBox.Show("Thêm vật tư mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng trong danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tenVT = txtTenVT.Text.Trim();
            string donViTinh = cboDonViTinh.SelectedItem?.ToString() ?? "";
            string donGiaStr = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(tenVT))
            {
                MessageBox.Show("Vui lòng nhập Tên vật tư!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVT.Focus();
                return;
            }

            if (!decimal.TryParse(donGiaStr, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá nhập phải là số hợp lệ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            ListViewItem selectedItem = lsvVatTu.SelectedItems[0];
            selectedItem.SubItems[1].Text = tenVT;
            selectedItem.SubItems[2].Text = donViTinh;
            selectedItem.SubItems[3].Text = donGia.ToString("N0");

            MessageBox.Show("Cập nhật thông tin vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem selectedItem = lsvVatTu.SelectedItems[0];
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa vật tư '{selectedItem.Text} - {selectedItem.SubItems[1].Text}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lsvVatTu.Items.Remove(selectedItem);
                MessageBox.Show("Xóa dòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa TOÀN BỘ danh sách vật tư không?", "Xác nhận xóa tất cả", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                lsvVatTu.Items.Clear();
                MessageBox.Show("Đã xóa toàn bộ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void lsvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvVatTu.SelectedItems[0];
                txtMaVT.Text = item.Text;
                txtTenVT.Text = item.SubItems[1].Text;
                cboDonViTinh.SelectedItem = item.SubItems[2].Text;

                string donGiaFormatted = item.SubItems[3].Text.Replace(",", "").Replace(".", "");
                txtDonGia.Text = donGiaFormatted;

                txtMaVT.Enabled = false;
            }
        }
    }
}