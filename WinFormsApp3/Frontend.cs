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
using System.Configuration;
using Twilio;
using Twilio.Clients;
using WinFormsApp3.Models;



using WinFormsApp3.Context;
using WinFormsApp3.Managers;
using Dapper;
using Microsoft.VisualBasic;
using System.Reflection;
namespace Hotel_Manager
{
    public partial class Frontend : MetroForm
    {
        private bool ToBoolean(object value) =>
             value switch
             {
                 bool b => b,
                 int i => i == 1,
                 string s => s == "1" || s.Equals("true", StringComparison.OrdinalIgnoreCase),
                 _ => false
             };

        string AccountSid = "ACcb86dacb791bef978628a2e16b1f7a24";
        string AuthToken = "3f344a07336d2e0ac5e467f72a1e650d";
        string RecvPhoneNumber = "";
        private readonly string _connectionString = "Data Source=DESKTOP-1K797I9\\SQLSERVER2022;Initial Catalog=FRONTEND_RESERVATIONn;Integrated Security=True;TrustServerCertificate=True;";
        private readonly ReservationManager _reservationManager = new ReservationManager();
        public Frontend()
        {

            InitializeComponent();
            CenterToScreen();
            submitButton.Visible = true; // Ensure visibility
            submitButton.Enabled = true;
            entryDatePicker.MinDate = DateTime.Today;
            depDatePicker.MinDate = DateTime.Today.AddDays(1);

            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();

            this.roomOccupiedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.roomOccupiedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roomOccupiedListBox_DrawItem);
            this.roomReservedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.roomReservedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roomReservedListBox_DrawItem);

        }



        private void roomOccupiedListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            this.roomOccupiedListBox.IntegralHeight = false;
            this.roomOccupiedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomOccupiedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }
        private void roomReservedListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            this.roomReservedListBox.IntegralHeight = false;
            this.roomReservedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomReservedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }


        private string getval;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Getval
        {
            get { return getval; }
            set { getval = value; }
        }

        public string towelS, cleaningS, surpriseS;

        public int foodBill;
        public string birthday = "";

        public string food_menu = "";
        public int totalAmount = 0;
        public int checkin = 0;
        public int foodStatus = 0;
        public Int32 primartyID = 0;
        public Boolean taskFinder = false;
        public Boolean editClicked = false;
        public string FPayment, FCnumber, FcardExpOne, FcardExpTwo, FCardCVC;
        private double finalizedTotalAmount = 0.0;
        private string paymentType;
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;

        private int lunch = 0; private int breakfast = 0; private int dinner = 0;
        private string cleaning; private string towel;
        private string surprise;

        private void MainTab_Load(object sender, EventArgs e)
        {
            foodSupplyCheckBox.Enabled = false;

        }

        public void foodMenuButton_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            if (taskFinder)
            {
                if (breakfast > 0)
                {
                    food_menu.breakfastCheckBox.Checked = true;
                    food_menu.breakfastQTY.Text = Convert.ToString(breakfast);
                }
                if (lunch > 0)
                {
                    food_menu.lunchCheckBox.Checked = true;

                    food_menu.lunchQTY.Text = Convert.ToString(lunch);
                }
                if (dinner > 0)
                {
                    food_menu.dinnerCheckBox.Checked = true;
                    food_menu.dinnerQTY.Text = Convert.ToString(dinner);
                }
                if (cleaning == "1")
                {
                    food_menu.cleaningCheckBox.Checked = true;
                }
                if (towel == "1")
                {
                    food_menu.towelsCheckBox.Checked = true;
                }
                if (surprise == "1")
                {
                    food_menu.surpriseCheckBox.Checked = true;
                }
            }
            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            cleaning = food_menu.Cleaning.Replace(" ", string.Empty) == "Cleaning" ? "1" : "0";
            towel = food_menu.Towel.Replace(" ", string.Empty) == "Towels" ? "1" : "0";

            surprise = food_menu.Surprise.Replace(" ", string.Empty) == "Sweetestsurprise" ? "1" : "0";

            if (breakfast > 0 || lunch > 0 || dinner > 0)
            {
                int bfast = 7 * breakfast;
                int Lnch = 15 * lunch;
                int di_ner = 15 * dinner;
                foodBill = bfast + Lnch + di_ner;
            }
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (roomTypeComboBox.SelectedItem.Equals("Single"))
            {
                totalAmount = 149;
                floorComboBox.SelectedItem = "1";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Double"))
            {
                totalAmount = 299;
                floorComboBox.SelectedItem = "2";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Twin"))
            {
                totalAmount = 349;
                floorComboBox.SelectedItem = "3";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Duplex"))
            {
                totalAmount = 399;
                floorComboBox.SelectedItem = "4";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Suite"))
            {
                totalAmount = 499;
                floorComboBox.SelectedItem = "5";
            }
            int selectedTemp = 0;
            string selected;
            bool temp = int.TryParse(qtGuestComboBox.SelectedItem.ToString(), out selectedTemp);
            if (!temp)
            {
                MessageBox.Show(this, "Enter # of guests first", "Error parsing", MessageBoxButtons.OK);
            }
            else
            {
                selected = qtGuestComboBox.SelectedItem.ToString();
                selectedTemp = Convert.ToInt32(selected);
                if (selectedTemp >= 3)
                {
                    totalAmount += (selectedTemp * 5);
                }
            }


        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editClicked = true;
            entryDatePicker.MinDate = new DateTime(2014, 4, 1);
            entryDatePicker.CustomFormat = "MM-dd-yyyy";
            entryDatePicker.Format = DateTimePickerFormat.Custom;

            depDatePicker.MinDate = new DateTime(2014, 4, 1);
            depDatePicker.CustomFormat = "MM-dd-yyyy";
            depDatePicker.Format = DateTimePickerFormat.Custom;

            submitButton.Visible = false;
            updateButton.Visible = true;
            deleteButton.Visible = true;
            resEditButton.Visible = true;

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
        }


        private void finalizeButton_Click(object sender, EventArgs e)
        {
            if (breakfast == 0 && lunch == 0 && dinner == 0 && cleaning == "0" && towel == "0" && surprise == "0")
            {
                foodSupplyCheckBox.Checked = true;
            }
            updateButton.Enabled = true;

            FinalizePayment finalizebil = new FinalizePayment();
            finalizebil.totalAmountFromFrontend = totalAmount;
            finalizebil.foodBill = foodBill;
            if (taskFinder)
            {
                finalizebil.paymentComboBox.SelectedItem = FPayment.Replace(" ", string.Empty);
                finalizebil.phoneNComboBox.Text = FCnumber;
                finalizebil.monthComboBox.SelectedItem = FcardExpOne;
                finalizebil.yearComboBox.SelectedItem = FcardExpTwo;
                finalizebil.cvcComboBox.Text = FCardCVC;
            }

            finalizebil.ShowDialog();

            finalizedTotalAmount = finalizebil.FinalTotalFinalized;
            paymentType = finalizebil.PaymentType;
            paymentCardNumber = finalizebil.PaymentCardNumber;
            MM_YY_Of_Card = finalizebil.MM_YY_Of_Card1;
            CVC_Of_Card = finalizebil.CVC_Of_Card1;
            CardType = finalizebil.CardType1;
            MessageBox.Show($"editClicked value: {editClicked}");

            if (!editClicked)
            {
                submitButton.Visible = true;
                submitButton.Enabled = true;




            }
        }




        private void submitButton_Click(object sender, EventArgs e)
        {

            try
            {
                // Build the birthday
                string birthdayString = $"{monthComboBox.SelectedItem}-{dayComboBox.SelectedIndex + 1}-{yearTextBox.Text}";
                bool ToBoolean(object value) =>
                    value switch
                    {
                        bool b => b,                           // If it's already a boolean
                        int i => i == 1,                       // If it's an integer (1 = true)
                        string s => s == "1" || s.ToLower() == "true",  // Handle string values
                        _ => false                              // Default to false for any other type
                    };


                var newReservation = new WinFormsApp3.Models.Reservation
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    BirthDay = birthdayString,
                    Gender = genderComboBox.SelectedItem?.ToString(),
                    PhoneNumber = phoneNumberTextBox.Text,
                    EmailAddress = emailTextBox.Text,
                    NumberGuest = qtGuestComboBox.SelectedIndex + 1,
                    StreetAddress = addLabel.Text,
                    AptSuite = aptTextBox.Text,
                    City = cityTextBox.Text,
                    State = stateComboBox.SelectedItem?.ToString(),
                    ZipCode = zipComboBox.Text,
                    RoomType = roomTypeComboBox.SelectedItem?.ToString(),
                    RoomFloor = floorComboBox.SelectedItem?.ToString(),
                    RoomNumber = roomNComboBox.SelectedItem?.ToString(),
                    TotalBill = finalizedTotalAmount,
                    PaymentType = paymentType,
                    CardType = CardType,
                    CardNumber = paymentCardNumber,
                    CardExp = MM_YY_Of_Card,
                    CardCvc = CVC_Of_Card,
                    ArrivalTime = DateTime.Parse(entryDatePicker.Text),
                    LeavingTime = DateTime.Parse(depDatePicker.Text),

                    // Safely convert checkboxes or boolean-like values
                    CheckIn = ToBoolean(checkin),
                    Breakfast = breakfast,
                    Lunch = lunch,
                    Dinner = dinner,
                    SupplyStatus = ToBoolean(foodStatus),
                    Cleaning = ToBoolean(cleaning),
                    Towel = ToBoolean(towel),
                    s_surprise = ToBoolean(surprise),

                    FoodBill = foodBill
                };

                if (_reservationManager.Add(newReservation))
                    MessageBox.Show("Reservation Added!");
                else
                    MessageBox.Show("Failed to Add Reservation.");

                // Refresh UI
                ComboBoxItemsFromDataBase();
                LoadForDataGridView();
                reset_frontend();
                GetOccupiedRoom();
                ReservedRoom();
                getChecked();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void newButton_Click(object sender, EventArgs e)
        {
            submitButton.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;
            resEditButton.Visible = false;
            reset_frontend();
        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }
        public void ClearAllComboBox(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control == roomTypeComboBox)
                {
                    continue;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control.HasChildren)
                {
                    ClearAllComboBox(control);
                }
            }
        }
        private void reset_frontend()
        {
            try
            {

                resEditButton.Items.Clear();
                checkinCheckBox.Checked = false;
                foodSupplyCheckBox.Checked = false;

                ClearAllComboBox(this);
                ClearAllTextBoxes(this);

                ComboBoxItemsFromDataBase();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void frontend_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)

        {
            //private readonly string _connectionString = "Data Source=DESKTOP-1K797I9\\SQLSERVER2022;Initial Catalog=FRONTEND_RESERVATIONn;Integrated Security=True;TrustServerCertificate=True;";
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {

                    connection.Open();


                    var reservation = connection.QueryFirstOrDefault<Reservation>(
                        "SELECT * FROM Reservations WHERE Id = @Id",
                        new { Id = primartyID });

                    if (reservation != null)
                    {

                        var confirm = MessageBox.Show(this, $"Are you sure you want to delete reservation ID: {primartyID}?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirm == DialogResult.Yes)
                        {

                            var rowsAffected = connection.Execute("DELETE FROM Reservations WHERE Id = @Id",
                                                                  new { Id = primartyID });

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show(this, $"Reservation with ID: {primartyID} has been deleted.",
                                    "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(this, "Failed to delete reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Reservation not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }




        private void updateButton_Click(object sender, EventArgs e)


        {
            if (primartyID > 0)
            {
                var reservation = _reservationManager.GetByID(primartyID);
                if (reservation != null)
                {
                    reservation.PhoneNumber = phoneNumberTextBox.Text;
                    bool isUpdated = _reservationManager.Update(reservation);

                    if (isUpdated)
                    {
                        MessageBox.Show("Reservation updated successfully!");
                        LoadForDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Update failed!");
                    }
                }
            }


        }

        // Helper method to safely convert to boolean




        private void checkinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkinCheckBox.Checked)
            {
                checkinCheckBox.Text = "Checked in";
                checkin = 1; // Assign integer value
            }
            else
            {
                checkin = 0; // Assign integer value
                checkinCheckBox.Text = "Check in ?";
            }
        }

        private void resEditButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            getChecked();

            // Extract ID using regex to capture numeric values only
            var match = System.Text.RegularExpressions.Regex.Match(resEditButton.Text, @"^\d+");
            if (!match.Success)
            {
                MessageBox.Show("Unable to extract reservation ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            primartyID = Convert.ToInt32(match.Value);
            MessageBox.Show($"Extracted ID: {primartyID}");

            try
            {
                using (var context = new FRONTEND_RESERVATIONContext())
                {
                    var reservation = context.Reservations.FirstOrDefault(r => r.Id == primartyID);
                    if (reservation == null)
                    {
                        MessageBox.Show("Reservation not found.");
                        return;
                    }

                    taskFinder = true;


                    firstNameTextBox.Text = reservation.FirstName ?? "";
                    lastNameTextBox.Text = reservation.LastName ?? "";
                    phoneNumberTextBox.Text = reservation.PhoneNumber ?? "";

                    checkinCheckBox.Checked = reservation.CheckIn;
                    genderComboBox.SelectedItem = reservation.Gender ?? "Not Specified";

                    if (DateTime.TryParse(reservation.BirthDay, out DateTime birthDate))
                    {
                        monthComboBox.SelectedItem = birthDate.Month.ToString("00");
                        dayComboBox.SelectedItem = birthDate.Day.ToString("00");
                        yearTextBox.Text = birthDate.Year.ToString();
                    }

                    qtGuestComboBox.SelectedItem = reservation.NumberGuest.ToString();

                    roomTypeComboBox.SelectedItem = reservation.RoomType?.Trim() ?? "";
                    floorComboBox.SelectedItem = reservation.RoomFloor?.Trim() ?? "";
                    roomNComboBox.SelectedItem = reservation.RoomNumber?.Trim() ?? "";

                    entryDatePicker.Value = reservation.ArrivalTime;
                    depDatePicker.Value = reservation.LeavingTime;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}");
            }
        }







        private void ComboBoxItemsFromDataBase()

        {
            try
            {
                resEditButton.Items.Clear(); // Clear existing items

                using (var context = new FRONTEND_RESERVATIONContext())
                {
                    var reservations = context.Reservations
                        .Select(r => $"{r.Id} | {r.FirstName} {r.LastName} | {r.PhoneNumber}")
                        .ToList();

                    resEditButton.Items.AddRange(reservations.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void LoadForDataGridView()
        {
            try
            {
                var reservations = _reservationManager.GetAll();
                resTotalDataGridView.DataSource = reservations;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void foodSupplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (foodSupplyCheckBox.Checked)
            {
                foodSupplyCheckBox.Text = "Food/Supply: Complete";
                foodStatus = 1;
            }
            else
            {
                foodStatus = 0;
                foodSupplyCheckBox.Text = "Food/Supply status?";
            }
        }
        private void GetOccupiedRoom()
        {
            roomOccupiedListBox.Items.Clear();

            try
            {
                using (var context = new FRONTEND_RESERVATIONContext())
                {

                    var occupiedRooms = context.Reservations
                        .Where(r => r.CheckIn == true)
                        .ToList();

                    foreach (var reservation in occupiedRooms)
                    {
                        string roomDetails = $"[{reservation.RoomNumber.Trim()}] " +
                                             $"{reservation.RoomType.Trim()} " +
                                             $"{reservation.Id} " +
                                             $"[{reservation.FirstName.Trim()} {reservation.LastName.Trim()}] " +
                                             $"{reservation.PhoneNumber.Trim()}";

                        roomOccupiedListBox.Items.Add(roomDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReservedRoom()
        {
            try
            {
                using (var context = new FRONTEND_RESERVATIONContext())
                {
                    roomReservedListBox.Items.Clear();

                    var reservedRooms = context.Reservations
                        .Where(r => r.CheckIn == false)
                        .Select(r => new
                        {
                            RoomNumber = r.RoomNumber.Trim(),
                            RoomType = r.RoomType.Trim(),
                            Id = r.Id.ToString().Trim(),
                            FirstName = r.FirstName.Trim(),
                            LastName = r.LastName.Trim(),
                            PhoneNumber = r.PhoneNumber.Trim(),
                            ArrivalDate = r.ArrivalTime.ToString("MM-dd-yyyy"),
                            LeavingDate = r.LeavingTime.ToString("MM-dd-yyyy")
                        })
                        .ToList();

                    foreach (var room in reservedRooms)
                    {
                        roomReservedListBox.Items.Add($"[{room.RoomNumber}] {room.RoomType} {room.Id} {room.FirstName} {room.LastName} {room.PhoneNumber} {room.ArrivalDate} {room.LeavingDate}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        private void getChecked()
        {
            try
            {
                using (var context = new FRONTEND_RESERVATIONContext())
                {
                    // Retrieve room numbers where check_in is true
                    var takenRoomList = context.Reservations
                        .Where(r => r.CheckIn == true)
                        .Select(r => r.RoomNumber.Trim())
                        .ToList();

                    // Remove occupied rooms from the combo box
                    foreach (var room in takenRoomList)
                    {
                        if (roomNComboBox.Items.Contains(room))
                        {
                            roomNComboBox.Items.Remove(room);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            RecvPhoneNumber = "+1" + phoneNumberTextBox.Text.Replace(" ", string.Empty);
            long getphn = Convert.ToInt64(phoneNumberTextBox.Text);
            string formatString = String.Format("{0:(000)000-0000}", getphn);
            phoneNumberTextBox.Text = formatString;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {


            try
            {
                string searchText = searchTextBox.Text;

                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    db.Open();


                    string query = @"
                SELECT * FROM Reservations
                WHERE
                    CAST(Id AS NVARCHAR) LIKE @Search OR
                    FirstName LIKE @Search OR
                    LastName LIKE @Search OR
                    Gender LIKE @Search OR
                    State LIKE @Search OR
                    City LIKE @Search OR
                    RoomNumber LIKE @Search OR
                    RoomType LIKE @Search OR
                    EmailAddress LIKE @Search OR
                    PhoneNumber LIKE @Search";


                    var results = db.Query<Reservation>(query, new { Search = $"%{searchText}%" }).ToList();


                    if (results.Any())
                    {
                        searchButton.Location = new Point(752, 7);
                        searchTextBox.Location = new Point(68, 7);
                        searchDataGridView.Visible = true;
                        SearchError.Visible = false;

                        searchDataGridView.DataSource = results;
                    }
                    else
                    {
                        searchDataGridView.Visible = false;
                        SearchError.Visible = true;
                        SearchError.Text = $"SORRY DUDE :(\nI ran out of gas trying to search for {searchText}\nI sure will find it next time.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred during search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}