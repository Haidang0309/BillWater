using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace BillWater
{
    public partial class ManagerBill : Form
    {
        List<User> users = new List<User>();
        public ManagerBill()
        {
            InitializeComponent();

            lvTable.View = View.Details;
            lvTable.LabelEdit = true;
            lvTable.AllowColumnReorder = true;
            lvTable.FullRowSelect = true;
            lvTable.GridLines = true;
            lvTable.Sorting = SortOrder.Ascending;

            lvTable.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvTable.Columns.Add("Yourname", -2, HorizontalAlignment.Left);
            lvTable.Columns.Add("Phonenumber", -2, HorizontalAlignment.Left);
            lvTable.Columns.Add("Custom", -2, HorizontalAlignment.Left);
            lvTable.Columns.Add("Amount of water this month", -2, HorizontalAlignment.Left);
            lvTable.Columns.Add("Amount of water lastmonth", -2, HorizontalAlignment.Left);
            lvTable.Columns.Add("amount of water consumed", -2, HorizontalAlignment.Left);
            lvTable.Columns.Add("Total Bill", -2, HorizontalAlignment.Left);
            displayListViewUser();
        }

        private void displayListViewUser()
        {
            lvTable.Items.Clear();
            List<ListViewItem> listItem = new List<ListViewItem>();

            int Index = 1;
            for (int i = 0; i < users.Count; i++)
            {
                ListViewItem item = new ListViewItem(Index + "", Index);
                item.SubItems.Add(users[i].Yourname);
                item.SubItems.Add(users[i].Phonenumber.ToString());
                item.SubItems.Add(users[i].Customtype);
                item.SubItems.Add(users[i].Amountofwaterthismonth.ToString());
                item.SubItems.Add(users[i].Amountofwaterlastmonth.ToString());
                item.SubItems.Add(users[i].Amountofwaterconsumed.ToString());
                item.SubItems.Add(users[i].Totalbill.ToString());

                listItem.Add(item);
                Index++;
            }
            lvTable.Items.AddRange(listItem.ToArray());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Yourname = tbYourname.Text;
            user.Phonenumber = Convert.ToInt32(tbPhonenumber.Text);
            user.Customtype = cbCustom.Text;
            user.Amountofwaterthismonth = Convert.ToInt32(tbAmountofwaterthismonth.Text);
            user.Amountofwaterlastmonth = Convert.ToInt32(tbAmountofwaterlastmonth.Text);
            users.Add(user);
            displayListViewUser();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (lvTable.SelectedItems.Count > 0)
            {
                // Lấy index của mục được chọn
                int selectedIndex = lvTable.SelectedItems[0].Index;

                // Xác nhận việc cập nhật từ người dùng
                DialogResult result = MessageBox.Show("Are you sure you want to update this item?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Cập nhật thông tin người dùng đã chọn
                    users[selectedIndex].Yourname = tbYourname.Text;
                    users[selectedIndex].Phonenumber = Convert.ToInt32(tbPhonenumber.Text);
                    users[selectedIndex].Customtype = cbCustom.Text;
                    users[selectedIndex].Amountofwaterthismonth = Convert.ToInt32(tbAmountofwaterthismonth.Text);
                    users[selectedIndex].Amountofwaterlastmonth = Convert.ToInt32(tbAmountofwaterlastmonth.Text);

                    // Hiển thị lại ListView
                    displayListViewUser();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to update.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (lvTable.SelectedItems.Count > 0)
            {
                // Lấy index của mục được chọn
                int selectedIndex = lvTable.SelectedItems[0].Index;

                // Xác nhận việc xóa từ người dùng
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Xóa mục từ danh sách và hiển thị lại ListView
                    users.RemoveAt(selectedIndex);
                    displayListViewUser();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btTotal_Click(object sender, EventArgs e)
        {

        }

        private void btArrange_Click(object sender, EventArgs e)
        {
            // Sắp xếp danh sách người dùng theo tên (có thể thay đổi dựa vào yêu cầu)
            users = users.OrderBy(u => u.Yourname).ToList();

            // Hiển thị danh sách người dùng đã sắp xếp
            displayListViewUser();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
