using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lvNhanVien_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }


        private void btn_remove_Click(object sender, EventArgs e)
        {



            // Kiểm tra xem có mục nào được chọn trong ListView không
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                // Lặp qua tất cả các mục được chọn và xóa chúng
                foreach (ListViewItem selectedItem in lvNhanVien.SelectedItems)
                {
                    lvNhanVien.Items.Remove(selectedItem); // Xóa mục
                }

                MessageBox.Show("Đã xóa các mục được chọn.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hoặc nhiều mục để xóa.", "Thông báo");
            }

      



        }

       

        private void btn_addname_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txt_lastname.Text);
            lvi.SubItems.Add(txt_firstname.Text);
            lvi.SubItems.Add(txt_phone.Text);
            lvNhanVien.Items.Add(lvi);
            txt_lastname.Text = "";
            txt_firstname.Text = "";
            txt_phone.Text = "";

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

          
            if (lvNhanVien.SelectedItems.Count > 0)
            {
         
                ListViewItem selectedItem = lvNhanVien.SelectedItems[0];
                selectedItem.Text = txt_lastname.Text; 
                selectedItem.SubItems[1].Text = txt_firstname.Text; 
                selectedItem.SubItems[2].Text = txt_phone.Text; 

                MessageBox.Show("Đã cập nhật thông tin thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để chỉnh sửa!", "Thông báo");
            }
        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
