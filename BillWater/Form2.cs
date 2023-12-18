using Microsoft.VisualBasic.ApplicationServices;
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
            if (string.IsNullOrEmpty(Name = ""))
            {
                MessageBox.Show(" ban can nhap ten");
                return;
            }                      
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

            if (lvTable.SelectedItems.Count > 0)
            {
                
                int selectedIndex = lvTable.SelectedItems[0].Index;

                
                DialogResult result = MessageBox.Show("Are you sure you want to update this item?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    users[selectedIndex].Yourname = tbYourname.Text;
                    users[selectedIndex].Phonenumber = Convert.ToInt32(tbPhonenumber.Text);
                    users[selectedIndex].Customtype = cbCustom.Text;
                    users[selectedIndex].Amountofwaterthismonth = Convert.ToInt32(tbAmountofwaterthismonth.Text);
                    users[selectedIndex].Amountofwaterlastmonth = Convert.ToInt32(tbAmountofwaterlastmonth.Text);

 
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
            
            if (lvTable.SelectedItems.Count > 0)
            {
                
                int selectedIndex = lvTable.SelectedItems[0].Index;

                
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
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
            if (lvTable.SelectedItems.Count > 0)
            {
                int selectedIndex = lvTable.SelectedItems[0].Index;
                User selectedUser = users[selectedIndex];

                selectedUser.Amountofwaterthismonth = Convert.ToInt32(tbAmountofwaterthismonth.Text);
                selectedUser.Amountofwaterlastmonth = Convert.ToInt32(tbAmountofwaterlastmonth.Text);
                selectedUser.Amountofwaterconsumed = selectedUser.Amountofwaterthismonth - selectedUser.Amountofwaterlastmonth;
                lbAmountofwaterconsumed.Text = "Amount of water consumed: " + selectedUser.Amountofwaterconsumed.ToString();

                double giaTienBac1 = 5973;
                double giaTienBac2 = 7052;
                double giaTienBac3 = 8699;
                double giaTienBac4 = 15929;
                double giaTienBac5 = 9955;
                double giaTienBac6 = 11615;
                double giaTienBac7 = 22068;

                if (selectedUser.Customtype == "Household customer")
                {
                    if (selectedUser.Amountofwaterconsumed <= 10)
                    {
                        selectedUser.Totalbill = (double)(((selectedUser.Amountofwaterconsumed * giaTienBac1) * 0.1) + ((selectedUser.Amountofwaterconsumed * giaTienBac1) * 0.1) + ((selectedUser.Amountofwaterconsumed * giaTienBac1)));
                    }
                    else
                    {
                        if (selectedUser.Amountofwaterconsumed  > 10 && selectedUser.Amountofwaterconsumed <= 20)
                        {

                            selectedUser.Totalbill = ((double)((10 * giaTienBac1) + ((selectedUser.Amountofwaterconsumed * giaTienBac2) * 0.1) + ((selectedUser.Amountofwaterconsumed * giaTienBac2) * 0.1) + (selectedUser.Amountofwaterconsumed * giaTienBac2)));
                        }
                        else
                        {
                            if (selectedUser.Amountofwaterconsumed > 20 && selectedUser.Amountofwaterconsumed <= 30)
                            {
                                selectedUser.Totalbill = ((double)((10 * giaTienBac1) + (10 * giaTienBac2) + ((selectedUser.Amountofwaterconsumed * giaTienBac3) * 0.1) + (((selectedUser.Amountofwaterconsumed * giaTienBac3) * 0.1))));
                            }
                            else
                            {
                                selectedUser.Totalbill = ((double)((10 * giaTienBac1) + (10 * giaTienBac2) + (10 * giaTienBac3) + ((selectedUser.Amountofwaterconsumed * giaTienBac4) * 0.1) + (((selectedUser.Amountofwaterconsumed * giaTienBac4) * 0.1)) + (selectedUser.Amountofwaterconsumed * giaTienBac4)));
                            }
                        }

                    }
                }
                else if (selectedUser.Customtype == "Administrative agency, public services")
                {
                    selectedUser.Totalbill = ((double)(((selectedUser.Amountofwaterconsumed * giaTienBac5) * 0.1) + ((selectedUser.Amountofwaterconsumed * giaTienBac5) * 0.1) + (selectedUser.Amountofwaterconsumed * giaTienBac5)));
                }
                else if (selectedUser.Customtype == "Production units")
                {
                    selectedUser.Totalbill = (double)(((selectedUser.Amountofwaterconsumed * giaTienBac6) * 0.1) + ((selectedUser.Amountofwaterconsumed * giaTienBac6) * 0.1) + (selectedUser.Amountofwaterconsumed * giaTienBac6));
                }
                else if (selectedUser.Customtype == "Business services")
                {
                    selectedUser.Totalbill = (double)(((selectedUser.Amountofwaterconsumed * giaTienBac7) * 0.1) + (selectedUser.Amountofwaterconsumed * giaTienBac7) + (selectedUser.Amountofwaterconsumed * giaTienBac7));
                }
                lbTotalBill.Text = "Total Bill: " + selectedUser.Totalbill.ToString("C");
            }
        }
        

        private void btArrange_Click(object sender, EventArgs e)
        {
            BubbleSort(users);

            displayListViewUser();
            
        }

        private void BubbleSort(List<User> userList)
        {
            int n = userList.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(userList[j].Yourname, userList[j + 1].Yourname) > 0)
                    {
                        User temp = userList[j];
                        userList[j] = userList[j + 1];
                        userList[j + 1] = temp;
                    }
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = tbSearch.Text.Trim().ToLower();
            List<User> searchResults = users.Where(u => u.Yourname.ToLower().Contains(searchKeyword)
                                                      || u.Phonenumber.ToString().Contains(searchKeyword)
                                                      || u.Customtype.ToLower().Contains(searchKeyword)).ToList();
            if (searchResults.Count > 0)
            {
                StringBuilder resultMessage = new StringBuilder("Search Results:\n");
                foreach (User result in searchResults)
                {
                    resultMessage.AppendLine($"Name: {result.Yourname}, \nPhone: {result.Phonenumber}, \nCustom: {result.Customtype}, \nAmount Of Water This Month: {result.Amountofwaterthismonth}, \nAmount of water last month: {result.Amountofwaterlastmonth}, \nAmount of water consumed: {result.Amountofwaterconsumed}, \nTotal Bill: {result.Totalbill}");
                }
                MessageBox.Show(resultMessage.ToString(), "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No matching results found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
