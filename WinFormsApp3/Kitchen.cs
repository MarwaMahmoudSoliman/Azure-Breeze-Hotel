using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WinFormsApp3.Context; // Ensure this matches your context's namespace

namespace Hotel_Manager
{
    public partial class Kitchen : MetroForm
    {
        string cleaning, towel, surprise;
        int breakfast, lunch, dinner, foodBill;
        public Int32 primaryID;
        double totalBill;
        bool supply_status = false;

        private FRONTEND_RESERVATIONContext _context;



        public Kitchen()
        {
            InitializeComponent();
            _context = new FRONTEND_RESERVATIONContext();
        }
        private void kitchen_Load(object sender, EventArgs e)
        {
            LoadForDataGridView();
            listBoxFromDataBase();
        }

        private void LoadForDataGridView()
        {

            {
                try
                {
                    var reservations = _context.Reservations
                        .Where(r => r.CheckIn == true && r.SupplyStatus == false)
                        .Select(r => new
                        {
                            r.Id,
                            r.FirstName,
                            r.LastName,
                            r.PhoneNumber,
                            r.RoomType,
                            r.RoomFloor,
                            r.RoomNumber,
                            r.Breakfast,
                            r.Lunch,
                            r.Dinner,
                            r.Cleaning,
                            r.Towel,
                            r.s_surprise,
                            r.SupplyStatus,
                            r.FoodBill
                        }).ToList();

                    if (reservations.Count == 0)
                    {
                        MessageBox.Show("No data available for Kitchen.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    overviewDataGridView.DataSource = new BindingSource { DataSource = reservations };
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error loading data: " + ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }

        }



        private void resetEntries(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    resetEntries(control);
                }
            }
        }



        private void listBoxFromDataBase()
        {

            {
                queueListBox.Items.Clear();

                try
                {
                    using (var context = new FRONTEND_RESERVATIONContext())
                    {
                        var reservations = context.Reservations
                            .Where(r => r.CheckIn == true && r.SupplyStatus == false)
                            .Select(r => new
                            {
                                r.Id,
                                r.FirstName,
                                r.LastName,
                                r.PhoneNumber
                            }).ToList();

                        if (reservations.Count == 0)
                        {
                            MessageBox.Show("No reservations available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        foreach (var reservation in reservations)
                        {
                            queueListBox.Items.Add($"{reservation.Id} | {reservation.FirstName} {reservation.LastName} | {reservation.PhoneNumber}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }
        }



        private void queueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            resetEntries(this);

            // Extract the selected ID from the ListBox
            //string getQueryString = queueListBox.Text.Substring(0, 4).Replace(" ", string.Empty);
            //if (!int.TryParse(getQueryString, out int reservationId))
            //{
            //    MessageBox.Show("Invalid reservation ID.");
            //    return;
            //}// Safer extraction of reservation ID
            string selectedItem = queueListBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedItem))
            {
                MessageBox.Show("Please select a valid reservation.");
                return;
            }

            // Assuming the format is: "ID | FirstName LastName | PhoneNumber"
            string[] parts = selectedItem.Split('|');
            if (parts.Length < 3 || !int.TryParse(parts[0].Trim(), out int reservationId))
            {
                MessageBox.Show("Invalid reservation ID.");
                return;
            }


            try
            {
                using (var context = new FRONTEND_RESERVATIONContext())
                {
                    var reservation = context.Reservations.FirstOrDefault(r => r.Id == reservationId);

                    if (reservation == null)
                    {
                        MessageBox.Show("Reservation not found.");
                        return;
                    }

                    // Set checkboxes
                    cleaningCheckBox.Checked = reservation.Cleaning;
                    towelCheckBox.Checked = reservation.Towel;
                    surpriseCheckBox.Checked = reservation.s_surprise;
                    supplyCheckBox.Checked = reservation.SupplyStatus;

                    // Set meal values
                    breakfast = reservation.Breakfast;
                    lunch = reservation.Lunch;
                    dinner = reservation.Dinner;


                    breakfastTextBox.Text = breakfast > 0 ? breakfast.ToString() : "NONE";
                    lunchTextBox.Text = lunch > 0 ? lunch.ToString() : "NONE";
                    dinnerTextBox.Text = dinner > 0 ? dinner.ToString() : "NONE";

                    // Populate textboxes
                    firstNameTextBox.Text = reservation.FirstName;
                    lastNameTextBox.Text = reservation.LastName;
                    phoneNTextBox.Text = reservation.PhoneNumber;
                    roomTypeTextBox.Text = reservation.RoomType;
                    floorNTextBox.Text = reservation.RoomFloor;
                    roomNTextBox.Text = reservation.RoomNumber;

                    // Calculate bills
                    totalBill = reservation.TotalBill;
                    foodBill = reservation.FoodBill;
                    totalBill -= foodBill;

                    primaryID = reservation.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservation: " + ex.Message);
            }
        }



        private void foodSelectionButton_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            food_menu.needPanel.Visible = false;

            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            int bfast = 0, Lnch = 0, di_ner = 0;
            if (breakfast > 0)
            {
                bfast = 7 * breakfast;
            }
            if (lunch > 0)
            {
                Lnch = 15 * lunch;
            }
            if (dinner > 0)
            {
                di_ner = 15 * dinner;
            }
            foodBill += (bfast + Lnch + di_ner);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new FRONTEND_RESERVATIONContext())
                {

                    var reservation = context.Reservations.FirstOrDefault(r => r.Id == primaryID);
                    if (reservation == null)
                    {
                        MessageBox.Show("Reservation not found.");
                        return;
                    }

                    // Retrieve the reservation to update
                    //var reservation = context.Reservations.FirstOrDefault(r => r.Id == primaryID);

                    //if (reservation == null)
                    //{
                    //    MessageBox.Show(this, "Reservation not found.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    //    return;
                    //}

                    // Update reservation fields
                    reservation.TotalBill = totalBill + foodBill;
                    reservation.Breakfast = breakfast;
                    reservation.Lunch = lunch;
                    reservation.Dinner = dinner;
                    reservation.SupplyStatus = supply_status;
                    reservation.Cleaning = cleaning == "1";
                    reservation.Towel = towel == "1";
                    reservation.s_surprise = surprise == "1";
                    reservation.FoodBill = foodBill;

                    // Save changes to database
                    context.SaveChanges();

                    MessageBox.Show(this, $"Entry successfully updated in database. For the UNIQUE USER ID: {primaryID}", "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    // Refresh UI
                    listBoxFromDataBase();
                    //listBoxFromDatabase();
                    LoadForDataGridView();
                    resetEntries(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error updating reservation: " + ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }



        private void supplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cleaningCheckBox.Checked = false;
            cleaningCheckBox.Text = "Cleaned";
            towelCheckBox.Checked = false;
            towelCheckBox.Text = "Toweled";
            surpriseCheckBox.Checked = false;
            surpriseCheckBox.Text = "Surprised";
            supply_status = true;
        }
        private void kitchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
