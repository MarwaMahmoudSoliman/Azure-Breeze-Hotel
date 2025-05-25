namespace Hotel_Manager
{
    partial class Frontend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frontend));
            resPanel = new MetroFramework.Controls.MetroTabControl();
            reservationPage = new MetroFramework.Controls.MetroTabPage();
            rightMPanel = new MetroFramework.Controls.MetroPanel();
            resEditButton = new MetroFramework.Controls.MetroComboBox();
            newButton = new MetroFramework.Controls.MetroButton();
            deleteButton = new MetroFramework.Controls.MetroButton();
            editButton = new MetroFramework.Controls.MetroButton();
            updateButton = new MetroFramework.Controls.MetroButton();
            middlePanel = new MetroFramework.Controls.MetroPanel();
            smsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            foodSupplyCheckBox = new MetroFramework.Controls.MetroCheckBox();
            checkinCheckBox = new MetroFramework.Controls.MetroCheckBox();
            foodMenuButton = new MetroFramework.Controls.MetroButton();
            qtGuestComboBox = new MetroFramework.Controls.MetroComboBox();
            finalizeButton = new MetroFramework.Controls.MetroButton();
            metroLabel12 = new MetroFramework.Controls.MetroLabel();
            submitButton = new MetroFramework.Controls.MetroButton();
            depDatePicker = new DateTimePicker();
            roomNComboBox = new MetroFramework.Controls.MetroComboBox();
            floorComboBox = new MetroFramework.Controls.MetroComboBox();
            entryDatePicker = new DateTimePicker();
            entryLabel = new MetroFramework.Controls.MetroLabel();
            roomTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            choiceLabel = new MetroFramework.Controls.MetroLabel();
            leftMPanel = new MetroFramework.Controls.MetroPanel();
            emailLabel = new MetroFramework.Controls.MetroLabel();
            nameLabel = new MetroFramework.Controls.MetroLabel();
            emailTextBox = new MetroFramework.Controls.MetroTextBox();
            yearTextBox = new MetroFramework.Controls.MetroTextBox();
            monthComboBox = new MetroFramework.Controls.MetroComboBox();
            genderComboBox = new MetroFramework.Controls.MetroComboBox();
            birthdayLabel = new MetroFramework.Controls.MetroLabel();
            dayComboBox = new MetroFramework.Controls.MetroComboBox();
            phoneNumberLabel = new MetroFramework.Controls.MetroLabel();
            firstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            genderLabel = new MetroFramework.Controls.MetroLabel();
            zipComboBox = new MetroFramework.Controls.MetroTextBox();
            phoneNumberTextBox = new MetroFramework.Controls.MetroTextBox();
            stateComboBox = new MetroFramework.Controls.MetroComboBox();
            lastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            cityTextBox = new MetroFramework.Controls.MetroTextBox();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            aptTextBox = new MetroFramework.Controls.MetroTextBox();
            addLabel = new MetroFramework.Controls.MetroTextBox();
            searchPage = new MetroFramework.Controls.MetroTabPage();
            SearchError = new MetroFramework.Controls.MetroLabel();
            searchDataGridView = new DataGridView();
            searchButton = new MetroFramework.Controls.MetroButton();
            searchTextBox = new MetroFramework.Controls.MetroTextBox();
            metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            resTotalDataGridView = new DataGridView();
            roomPage = new MetroFramework.Controls.MetroTabPage();
            metroLabel13 = new MetroFramework.Controls.MetroLabel();
            metroLabel11 = new MetroFramework.Controls.MetroLabel();
            reservedLabel = new MetroFramework.Controls.MetroLabel();
            roomReservedListBox = new ListBox();
            roomOccupiedListBox = new ListBox();
            occupiedLabel = new MetroFramework.Controls.MetroLabel();
            resPanel.SuspendLayout();
            reservationPage.SuspendLayout();
            rightMPanel.SuspendLayout();
            middlePanel.SuspendLayout();
            leftMPanel.SuspendLayout();
            searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).BeginInit();
            metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).BeginInit();
            roomPage.SuspendLayout();
            SuspendLayout();
            // 
            // resPanel
            // 
            resPanel.Controls.Add(reservationPage);
            resPanel.Controls.Add(searchPage);
            resPanel.Controls.Add(metroTabPage2);
            resPanel.Controls.Add(roomPage);
            resPanel.CustomBackground = false;
            resPanel.FontSize = MetroFramework.MetroTabControlSize.Medium;
            resPanel.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            resPanel.Location = new Point(11, 91);
            resPanel.Margin = new Padding(4, 5, 4, 5);
            resPanel.Name = "resPanel";
            resPanel.Padding = new Point(6, 8);
            resPanel.SelectedIndex = 0;
            resPanel.Size = new Size(1312, 741);
            resPanel.Style = MetroFramework.MetroColorStyle.Green;
            resPanel.StyleManager = null;
            resPanel.TabIndex = 0;
            resPanel.TextAlign = ContentAlignment.MiddleLeft;
            resPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            resPanel.UseStyleColors = false;
            // 
            // reservationPage
            // 
            reservationPage.Controls.Add(rightMPanel);
            reservationPage.Controls.Add(middlePanel);
            reservationPage.Controls.Add(leftMPanel);
            reservationPage.CustomBackground = false;
            reservationPage.HorizontalScrollbar = false;
            reservationPage.HorizontalScrollbarBarColor = true;
            reservationPage.HorizontalScrollbarHighlightOnWheel = false;
            reservationPage.HorizontalScrollbarSize = 15;
            reservationPage.Location = new Point(4, 39);
            reservationPage.Margin = new Padding(4, 5, 4, 5);
            reservationPage.Name = "reservationPage";
            reservationPage.Size = new Size(1304, 698);
            reservationPage.Style = MetroFramework.MetroColorStyle.Green;
            reservationPage.StyleManager = null;
            reservationPage.TabIndex = 0;
            reservationPage.Text = "Reservation";
            reservationPage.Theme = MetroFramework.MetroThemeStyle.Light;
            reservationPage.VerticalScrollbar = false;
            reservationPage.VerticalScrollbarBarColor = true;
            reservationPage.VerticalScrollbarHighlightOnWheel = false;
            reservationPage.VerticalScrollbarSize = 13;
            // 
            // rightMPanel
            // 
            rightMPanel.BackColor = Color.FromArgb(225, 225, 225);
            rightMPanel.BackgroundImageLayout = ImageLayout.None;
            rightMPanel.Controls.Add(resEditButton);
            rightMPanel.Controls.Add(newButton);
            rightMPanel.Controls.Add(deleteButton);
            rightMPanel.Controls.Add(editButton);
            rightMPanel.Controls.Add(updateButton);
            rightMPanel.CustomBackground = false;
            rightMPanel.HorizontalScrollbar = false;
            rightMPanel.HorizontalScrollbarBarColor = true;
            rightMPanel.HorizontalScrollbarHighlightOnWheel = false;
            rightMPanel.HorizontalScrollbarSize = 15;
            rightMPanel.Location = new Point(944, 22);
            rightMPanel.Margin = new Padding(4, 5, 4, 5);
            rightMPanel.Name = "rightMPanel";
            rightMPanel.Size = new Size(353, 648);
            rightMPanel.Style = MetroFramework.MetroColorStyle.Blue;
            rightMPanel.StyleManager = null;
            rightMPanel.TabIndex = 34;
            rightMPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            rightMPanel.VerticalScrollbar = false;
            rightMPanel.VerticalScrollbarBarColor = true;
            rightMPanel.VerticalScrollbarHighlightOnWheel = false;
            rightMPanel.VerticalScrollbarSize = 13;
            // 
            // resEditButton
            // 
            resEditButton.DrawMode = DrawMode.OwnerDrawFixed;
            resEditButton.DropDownStyle = ComboBoxStyle.DropDownList;
            resEditButton.FlatStyle = FlatStyle.Popup;
            resEditButton.FontSize = MetroFramework.MetroLinkSize.Medium;
            resEditButton.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            resEditButton.ForeColor = Color.Green;
            resEditButton.FormattingEnabled = true;
            resEditButton.ItemHeight = 24;
            resEditButton.Items.AddRange(new object[] { "[ID]    [NAME]    [PHONE NUMBER]" });
            resEditButton.Location = new Point(13, 46);
            resEditButton.Margin = new Padding(4, 5, 4, 5);
            resEditButton.Name = "resEditButton";
            resEditButton.Size = new Size(335, 30);
            resEditButton.Style = MetroFramework.MetroColorStyle.Blue;
            resEditButton.StyleManager = null;
            resEditButton.TabIndex = 20;
            resEditButton.Theme = MetroFramework.MetroThemeStyle.Light;
            resEditButton.Visible = false;
            resEditButton.SelectedIndexChanged += resEditButton_SelectedIndexChanged;
            // 
            // newButton
            // 
            newButton.Highlight = false;
            newButton.Location = new Point(13, 578);
            newButton.Margin = new Padding(4, 5, 4, 5);
            newButton.Name = "newButton";
            newButton.Size = new Size(327, 49);
            newButton.Style = MetroFramework.MetroColorStyle.Green;
            newButton.StyleManager = null;
            newButton.TabIndex = 22;
            newButton.Text = "New reservation";
            newButton.Theme = MetroFramework.MetroThemeStyle.Light;
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Highlight = true;
            deleteButton.Location = new Point(13, 442);
            deleteButton.Margin = new Padding(4, 5, 4, 5);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(327, 52);
            deleteButton.Style = MetroFramework.MetroColorStyle.Red;
            deleteButton.StyleManager = null;
            deleteButton.TabIndex = 23;
            deleteButton.Text = "Delete";
            deleteButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Highlight = false;
            editButton.Location = new Point(13, 515);
            editButton.Margin = new Padding(4, 5, 4, 5);
            editButton.Name = "editButton";
            editButton.Size = new Size(327, 49);
            editButton.Style = MetroFramework.MetroColorStyle.Green;
            editButton.StyleManager = null;
            editButton.TabIndex = 18;
            editButton.Text = "Edit existing Reservation";
            editButton.Theme = MetroFramework.MetroThemeStyle.Light;
            editButton.Click += editButton_Click;
            // 
            // updateButton
            // 
            updateButton.Enabled = false;
            updateButton.Highlight = true;
            updateButton.Location = new Point(13, 378);
            updateButton.Margin = new Padding(4, 5, 4, 5);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(327, 52);
            updateButton.Style = MetroFramework.MetroColorStyle.Green;
            updateButton.StyleManager = null;
            updateButton.TabIndex = 19;
            updateButton.Text = "Update";
            updateButton.Theme = MetroFramework.MetroThemeStyle.Light;
            updateButton.Visible = false;
            updateButton.Click += updateButton_Click;
            // 
            // middlePanel
            // 
            middlePanel.BackColor = Color.FromArgb(225, 225, 225);
            middlePanel.BackgroundImageLayout = ImageLayout.None;
            middlePanel.Controls.Add(smsCheckBox);
            middlePanel.Controls.Add(foodSupplyCheckBox);
            middlePanel.Controls.Add(checkinCheckBox);
            middlePanel.Controls.Add(foodMenuButton);
            middlePanel.Controls.Add(qtGuestComboBox);
            middlePanel.Controls.Add(finalizeButton);
            middlePanel.Controls.Add(metroLabel12);
            middlePanel.Controls.Add(submitButton);
            middlePanel.Controls.Add(depDatePicker);
            middlePanel.Controls.Add(roomNComboBox);
            middlePanel.Controls.Add(floorComboBox);
            middlePanel.Controls.Add(entryDatePicker);
            middlePanel.Controls.Add(entryLabel);
            middlePanel.Controls.Add(roomTypeComboBox);
            middlePanel.Controls.Add(choiceLabel);
            middlePanel.CustomBackground = false;
            middlePanel.HorizontalScrollbar = false;
            middlePanel.HorizontalScrollbarBarColor = true;
            middlePanel.HorizontalScrollbarHighlightOnWheel = false;
            middlePanel.HorizontalScrollbarSize = 15;
            middlePanel.Location = new Point(473, 21);
            middlePanel.Margin = new Padding(4, 5, 4, 5);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(460, 648);
            middlePanel.Style = MetroFramework.MetroColorStyle.Blue;
            middlePanel.StyleManager = null;
            middlePanel.TabIndex = 16;
            middlePanel.Theme = MetroFramework.MetroThemeStyle.Light;
            middlePanel.VerticalScrollbar = false;
            middlePanel.VerticalScrollbarBarColor = true;
            middlePanel.VerticalScrollbarHighlightOnWheel = false;
            middlePanel.VerticalScrollbarSize = 13;
            // 
            // smsCheckBox
            // 
            smsCheckBox.AutoSize = true;
            smsCheckBox.BackColor = Color.Transparent;
            smsCheckBox.CustomBackground = false;
            smsCheckBox.FontSize = MetroFramework.MetroLinkSize.Small;
            smsCheckBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            smsCheckBox.Location = new Point(140, 448);
            smsCheckBox.Margin = new Padding(4, 5, 4, 5);
            smsCheckBox.Name = "smsCheckBox";
            smsCheckBox.Size = new Size(86, 17);
            smsCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            smsCheckBox.StyleManager = null;
            smsCheckBox.TabIndex = 35;
            smsCheckBox.Text = "Send sms?";
            smsCheckBox.Theme = MetroFramework.MetroThemeStyle.Light;
            smsCheckBox.UseStyleColors = false;
            smsCheckBox.UseVisualStyleBackColor = false;
            // 
            // foodSupplyCheckBox
            // 
            foodSupplyCheckBox.AutoSize = true;
            foodSupplyCheckBox.BackColor = Color.Transparent;
            foodSupplyCheckBox.CustomBackground = false;
            foodSupplyCheckBox.FontSize = MetroFramework.MetroLinkSize.Small;
            foodSupplyCheckBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            foodSupplyCheckBox.Location = new Point(259, 446);
            foodSupplyCheckBox.Margin = new Padding(4, 5, 4, 5);
            foodSupplyCheckBox.Name = "foodSupplyCheckBox";
            foodSupplyCheckBox.Size = new Size(146, 17);
            foodSupplyCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            foodSupplyCheckBox.StyleManager = null;
            foodSupplyCheckBox.TabIndex = 34;
            foodSupplyCheckBox.Text = "Food/Supply status ?";
            foodSupplyCheckBox.Theme = MetroFramework.MetroThemeStyle.Light;
            foodSupplyCheckBox.UseStyleColors = false;
            foodSupplyCheckBox.UseVisualStyleBackColor = false;
            foodSupplyCheckBox.CheckedChanged += foodSupplyCheckBox_CheckedChanged;
            // 
            // checkinCheckBox
            // 
            checkinCheckBox.AutoSize = true;
            checkinCheckBox.BackColor = Color.Transparent;
            checkinCheckBox.CustomBackground = false;
            checkinCheckBox.FontSize = MetroFramework.MetroLinkSize.Small;
            checkinCheckBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            checkinCheckBox.Location = new Point(21, 448);
            checkinCheckBox.Margin = new Padding(4, 5, 4, 5);
            checkinCheckBox.Name = "checkinCheckBox";
            checkinCheckBox.Size = new Size(82, 17);
            checkinCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            checkinCheckBox.StyleManager = null;
            checkinCheckBox.TabIndex = 33;
            checkinCheckBox.Text = "Check in ?";
            checkinCheckBox.Theme = MetroFramework.MetroThemeStyle.Light;
            checkinCheckBox.UseStyleColors = false;
            checkinCheckBox.UseVisualStyleBackColor = false;
            checkinCheckBox.CheckedChanged += checkinCheckBox_CheckedChanged;
            // 
            // foodMenuButton
            // 
            foodMenuButton.Highlight = false;
            foodMenuButton.Location = new Point(21, 374);
            foodMenuButton.Margin = new Padding(4, 5, 4, 5);
            foodMenuButton.Name = "foodMenuButton";
            foodMenuButton.Size = new Size(419, 52);
            foodMenuButton.Style = MetroFramework.MetroColorStyle.Green;
            foodMenuButton.StyleManager = null;
            foodMenuButton.TabIndex = 23;
            foodMenuButton.Text = "Food and menu";
            foodMenuButton.Theme = MetroFramework.MetroThemeStyle.Light;
            foodMenuButton.Click += foodMenuButton_Click;
            // 
            // qtGuestComboBox
            // 
            qtGuestComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            qtGuestComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            qtGuestComboBox.FontSize = MetroFramework.MetroLinkSize.Medium;
            qtGuestComboBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            qtGuestComboBox.FormattingEnabled = true;
            qtGuestComboBox.ItemHeight = 24;
            qtGuestComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            qtGuestComboBox.Location = new Point(21, 46);
            qtGuestComboBox.Margin = new Padding(4, 5, 4, 5);
            qtGuestComboBox.Name = "qtGuestComboBox";
            qtGuestComboBox.Size = new Size(200, 30);
            qtGuestComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            qtGuestComboBox.StyleManager = null;
            qtGuestComboBox.TabIndex = 25;
            qtGuestComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // finalizeButton
            // 
            finalizeButton.Highlight = false;
            finalizeButton.Location = new Point(21, 519);
            finalizeButton.Margin = new Padding(4, 5, 4, 5);
            finalizeButton.Name = "finalizeButton";
            finalizeButton.Size = new Size(419, 48);
            finalizeButton.Style = MetroFramework.MetroColorStyle.Green;
            finalizeButton.StyleManager = null;
            finalizeButton.TabIndex = 22;
            finalizeButton.Text = "Finalize bill";
            finalizeButton.Theme = MetroFramework.MetroThemeStyle.Light;
            finalizeButton.Click += finalizeButton_Click;
            // 
            // metroLabel12
            // 
            metroLabel12.AutoSize = true;
            metroLabel12.BackColor = Color.Transparent;
            metroLabel12.CustomBackground = false;
            metroLabel12.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel12.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel12.Location = new Point(21, 260);
            metroLabel12.Margin = new Padding(4, 0, 4, 0);
            metroLabel12.Name = "metroLabel12";
            metroLabel12.Size = new Size(120, 20);
            metroLabel12.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel12.StyleManager = null;
            metroLabel12.TabIndex = 32;
            metroLabel12.Text = "Deperture [date]";
            metroLabel12.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel12.UseStyleColors = false;
            // 
            // submitButton
            // 
            submitButton.Highlight = true;
            submitButton.Location = new Point(21, 572);
            submitButton.Margin = new Padding(4, 5, 4, 5);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(419, 55);
            submitButton.Style = MetroFramework.MetroColorStyle.Green;
            submitButton.StyleManager = null;
            submitButton.TabIndex = 17;
            submitButton.Text = "Submit";
            submitButton.Theme = MetroFramework.MetroThemeStyle.Light;
            submitButton.Visible = false;
            submitButton.Click += submitButton_Click;
            // 
            // depDatePicker
            // 
            depDatePicker.CalendarFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            depDatePicker.CustomFormat = "MM-dd-yyyy";
            depDatePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            depDatePicker.Format = DateTimePickerFormat.Custom;
            depDatePicker.Location = new Point(21, 294);
            depDatePicker.Margin = new Padding(4, 5, 4, 5);
            depDatePicker.MaxDate = new DateTime(2025, 4, 27, 23, 59, 0, 0);
            depDatePicker.MinDate = new DateTime(2014, 4, 27, 0, 0, 0, 0);
            depDatePicker.Name = "depDatePicker";
            depDatePicker.Size = new Size(420, 30);
            depDatePicker.TabIndex = 31;
            depDatePicker.Value = new DateTime(2014, 4, 27, 0, 0, 0, 0);
            // 
            // roomNComboBox
            // 
            roomNComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            roomNComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomNComboBox.FontSize = MetroFramework.MetroLinkSize.Medium;
            roomNComboBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            roomNComboBox.FormattingEnabled = true;
            roomNComboBox.ItemHeight = 24;
            roomNComboBox.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510" });
            roomNComboBox.Location = new Point(231, 128);
            roomNComboBox.Margin = new Padding(4, 5, 4, 5);
            roomNComboBox.Name = "roomNComboBox";
            roomNComboBox.Size = new Size(211, 30);
            roomNComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            roomNComboBox.StyleManager = null;
            roomNComboBox.TabIndex = 24;
            roomNComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // floorComboBox
            // 
            floorComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            floorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            floorComboBox.FontSize = MetroFramework.MetroLinkSize.Medium;
            floorComboBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            floorComboBox.FormattingEnabled = true;
            floorComboBox.ItemHeight = 24;
            floorComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            floorComboBox.Location = new Point(21, 128);
            floorComboBox.Margin = new Padding(4, 5, 4, 5);
            floorComboBox.Name = "floorComboBox";
            floorComboBox.Size = new Size(200, 30);
            floorComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            floorComboBox.StyleManager = null;
            floorComboBox.TabIndex = 23;
            floorComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // entryDatePicker
            // 
            entryDatePicker.CalendarFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            entryDatePicker.CustomFormat = "MM-dd-yyyy";
            entryDatePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryDatePicker.Format = DateTimePickerFormat.Custom;
            entryDatePicker.Location = new Point(21, 215);
            entryDatePicker.Margin = new Padding(4, 5, 4, 5);
            entryDatePicker.MaxDate = new DateTime(2025, 4, 27, 23, 59, 0, 0);
            entryDatePicker.MinDate = new DateTime(2014, 5, 11, 0, 0, 0, 0);
            entryDatePicker.Name = "entryDatePicker";
            entryDatePicker.Size = new Size(417, 30);
            entryDatePicker.TabIndex = 26;
            entryDatePicker.Value = new DateTime(2014, 5, 11, 0, 0, 0, 0);
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.BackColor = Color.Transparent;
            entryLabel.CustomBackground = false;
            entryLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            entryLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            entryLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            entryLabel.Location = new Point(21, 181);
            entryLabel.Margin = new Padding(4, 0, 4, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(86, 20);
            entryLabel.Style = MetroFramework.MetroColorStyle.Blue;
            entryLabel.StyleManager = null;
            entryLabel.TabIndex = 30;
            entryLabel.Text = "Entry [date]";
            entryLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            entryLabel.UseStyleColors = false;
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            roomTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomTypeComboBox.FontSize = MetroFramework.MetroLinkSize.Medium;
            roomTypeComboBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            roomTypeComboBox.FormattingEnabled = true;
            roomTypeComboBox.ItemHeight = 24;
            roomTypeComboBox.Items.AddRange(new object[] { "Single", "Double", "Twin", "Duplex", "Suite" });
            roomTypeComboBox.Location = new Point(231, 45);
            roomTypeComboBox.Margin = new Padding(4, 5, 4, 5);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.Size = new Size(211, 30);
            roomTypeComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            roomTypeComboBox.StyleManager = null;
            roomTypeComboBox.TabIndex = 22;
            roomTypeComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            roomTypeComboBox.SelectedIndexChanged += roomTypeComboBox_SelectedIndexChanged;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.BackColor = Color.Transparent;
            choiceLabel.CustomBackground = false;
            choiceLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            choiceLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            choiceLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            choiceLabel.Location = new Point(21, 12);
            choiceLabel.Margin = new Padding(4, 0, 4, 0);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(91, 20);
            choiceLabel.Style = MetroFramework.MetroColorStyle.Blue;
            choiceLabel.StyleManager = null;
            choiceLabel.TabIndex = 21;
            choiceLabel.Text = "Your choices";
            choiceLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            choiceLabel.UseStyleColors = false;
            // 
            // leftMPanel
            // 
            leftMPanel.BackColor = Color.FromArgb(225, 225, 225);
            leftMPanel.BackgroundImageLayout = ImageLayout.None;
            leftMPanel.Controls.Add(emailLabel);
            leftMPanel.Controls.Add(nameLabel);
            leftMPanel.Controls.Add(emailTextBox);
            leftMPanel.Controls.Add(yearTextBox);
            leftMPanel.Controls.Add(monthComboBox);
            leftMPanel.Controls.Add(genderComboBox);
            leftMPanel.Controls.Add(birthdayLabel);
            leftMPanel.Controls.Add(dayComboBox);
            leftMPanel.Controls.Add(phoneNumberLabel);
            leftMPanel.Controls.Add(firstNameTextBox);
            leftMPanel.Controls.Add(genderLabel);
            leftMPanel.Controls.Add(zipComboBox);
            leftMPanel.Controls.Add(phoneNumberTextBox);
            leftMPanel.Controls.Add(stateComboBox);
            leftMPanel.Controls.Add(lastNameTextBox);
            leftMPanel.Controls.Add(cityTextBox);
            leftMPanel.Controls.Add(metroLabel6);
            leftMPanel.Controls.Add(aptTextBox);
            leftMPanel.Controls.Add(addLabel);
            leftMPanel.CustomBackground = false;
            leftMPanel.HorizontalScrollbar = false;
            leftMPanel.HorizontalScrollbarBarColor = true;
            leftMPanel.HorizontalScrollbarHighlightOnWheel = false;
            leftMPanel.HorizontalScrollbarSize = 15;
            leftMPanel.Location = new Point(4, 22);
            leftMPanel.Margin = new Padding(4, 5, 4, 5);
            leftMPanel.Name = "leftMPanel";
            leftMPanel.Size = new Size(460, 648);
            leftMPanel.Style = MetroFramework.MetroColorStyle.Blue;
            leftMPanel.StyleManager = null;
            leftMPanel.TabIndex = 4;
            leftMPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            leftMPanel.VerticalScrollbar = false;
            leftMPanel.VerticalScrollbarBarColor = true;
            leftMPanel.VerticalScrollbarHighlightOnWheel = false;
            leftMPanel.VerticalScrollbarSize = 13;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.CustomBackground = false;
            emailLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            emailLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            emailLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            emailLabel.Location = new Point(20, 346);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(140, 20);
            emailLabel.Style = MetroFramework.MetroColorStyle.Blue;
            emailLabel.StyleManager = null;
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Your e-mail address";
            emailLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            emailLabel.UseStyleColors = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.CustomBackground = false;
            nameLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            nameLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            nameLabel.Location = new Point(19, 11);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.Style = MetroFramework.MetroColorStyle.Blue;
            nameLabel.StyleManager = null;
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            nameLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            nameLabel.UseStyleColors = false;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.White;
            emailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            emailTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            emailTextBox.Location = new Point(20, 380);
            emailTextBox.Margin = new Padding(4, 5, 4, 5);
            emailTextBox.Multiline = false;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.SelectedText = "";
            emailTextBox.Size = new Size(421, 45);
            emailTextBox.Style = MetroFramework.MetroColorStyle.White;
            emailTextBox.StyleManager = null;
            emailTextBox.TabIndex = 14;
            emailTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            emailTextBox.UseStyleColors = false;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.White;
            yearTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            yearTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            yearTextBox.Location = new Point(307, 129);
            yearTextBox.Margin = new Padding(4, 5, 4, 5);
            yearTextBox.Multiline = false;
            yearTextBox.Name = "yearTextBox";
            yearTextBox.SelectedText = "";
            yearTextBox.Size = new Size(135, 45);
            yearTextBox.Style = MetroFramework.MetroColorStyle.White;
            yearTextBox.StyleManager = null;
            yearTextBox.TabIndex = 9;
            yearTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            yearTextBox.UseStyleColors = false;
            // 
            // monthComboBox
            // 
            monthComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            monthComboBox.FontSize = MetroFramework.MetroLinkSize.Medium;
            monthComboBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            monthComboBox.FormattingEnabled = true;
            monthComboBox.ItemHeight = 24;
            monthComboBox.Items.AddRange(new object[] { "January ", "February ", "March ", "April ", "May ", "June ", "July ", "August ", "September ", "October ", "November ", "December" });
            monthComboBox.Location = new Point(20, 129);
            monthComboBox.Margin = new Padding(4, 5, 4, 5);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(159, 30);
            monthComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            monthComboBox.StyleManager = null;
            monthComboBox.TabIndex = 6;
            monthComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // genderComboBox
            // 
            genderComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FontSize = MetroFramework.MetroLinkSize.Medium;
            genderComboBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.ItemHeight = 24;
            genderComboBox.Items.AddRange(new object[] { "Female", "Male", "Other" });
            genderComboBox.Location = new Point(20, 215);
            genderComboBox.Margin = new Padding(4, 5, 4, 5);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(419, 30);
            genderComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            genderComboBox.StyleManager = null;
            genderComboBox.TabIndex = 11;
            genderComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = Color.Transparent;
            birthdayLabel.CustomBackground = false;
            birthdayLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            birthdayLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            birthdayLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            birthdayLabel.Location = new Point(16, 98);
            birthdayLabel.Margin = new Padding(4, 0, 4, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(64, 20);
            birthdayLabel.Style = MetroFramework.MetroColorStyle.Blue;
            birthdayLabel.StyleManager = null;
            birthdayLabel.TabIndex = 5;
            birthdayLabel.Text = "Birthday";
            birthdayLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            birthdayLabel.UseStyleColors = false;
            // 
            // dayComboBox
            // 
            dayComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            dayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dayComboBox.FontSize = MetroFramework.MetroLinkSize.Medium;
            dayComboBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            dayComboBox.FormattingEnabled = true;
            dayComboBox.ItemHeight = 24;
            dayComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            dayComboBox.Location = new Point(188, 129);
            dayComboBox.Margin = new Padding(4, 5, 4, 5);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(109, 30);
            dayComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            dayComboBox.StyleManager = null;
            dayComboBox.TabIndex = 8;
            dayComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = Color.Transparent;
            phoneNumberLabel.CustomBackground = false;
            phoneNumberLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            phoneNumberLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            phoneNumberLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            phoneNumberLabel.Location = new Point(19, 262);
            phoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(105, 20);
            phoneNumberLabel.Style = MetroFramework.MetroColorStyle.Blue;
            phoneNumberLabel.StyleManager = null;
            phoneNumberLabel.TabIndex = 12;
            phoneNumberLabel.Text = "Phone number";
            phoneNumberLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            phoneNumberLabel.UseStyleColors = false;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.White;
            firstNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            firstNameTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            firstNameTextBox.Location = new Point(20, 41);
            firstNameTextBox.Margin = new Padding(4, 5, 4, 5);
            firstNameTextBox.Multiline = false;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.SelectedText = "";
            firstNameTextBox.Size = new Size(207, 45);
            firstNameTextBox.Style = MetroFramework.MetroColorStyle.White;
            firstNameTextBox.StyleManager = null;
            firstNameTextBox.TabIndex = 2;
            firstNameTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            firstNameTextBox.UseStyleColors = false;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = Color.Transparent;
            genderLabel.CustomBackground = false;
            genderLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            genderLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            genderLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            genderLabel.Location = new Point(17, 181);
            genderLabel.Margin = new Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(57, 20);
            genderLabel.Style = MetroFramework.MetroColorStyle.Blue;
            genderLabel.StyleManager = null;
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Gender";
            genderLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            genderLabel.UseStyleColors = false;
            // 
            // zipComboBox
            // 
            zipComboBox.BackColor = Color.White;
            zipComboBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            zipComboBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            zipComboBox.Location = new Point(229, 581);
            zipComboBox.Margin = new Padding(4, 5, 4, 5);
            zipComboBox.Multiline = false;
            zipComboBox.Name = "zipComboBox";
            zipComboBox.SelectedText = "";
            zipComboBox.Size = new Size(212, 45);
            zipComboBox.Style = MetroFramework.MetroColorStyle.White;
            zipComboBox.StyleManager = null;
            zipComboBox.TabIndex = 20;
            zipComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            zipComboBox.UseStyleColors = false;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.White;
            phoneNumberTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            phoneNumberTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            phoneNumberTextBox.Location = new Point(19, 298);
            phoneNumberTextBox.Margin = new Padding(4, 5, 4, 5);
            phoneNumberTextBox.Multiline = false;
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.SelectedText = "";
            phoneNumberTextBox.Size = new Size(421, 45);
            phoneNumberTextBox.Style = MetroFramework.MetroColorStyle.White;
            phoneNumberTextBox.StyleManager = null;
            phoneNumberTextBox.TabIndex = 13;
            phoneNumberTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            phoneNumberTextBox.UseStyleColors = false;
            phoneNumberTextBox.Leave += phoneNumberTextBox_Leave;
            // 
            // stateComboBox
            // 
            stateComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            stateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stateComboBox.FontSize = MetroFramework.MetroLinkSize.Medium;
            stateComboBox.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            stateComboBox.FormattingEnabled = true;
            stateComboBox.ItemHeight = 24;
            stateComboBox.Items.AddRange(new object[] { "Alabama ", "Alaska ", "Arizona ", "Arkansas ", "California ", "Colorado ", "Connecticut ", "Delaware ", "Florida ", "Georgia ", "Hawaii ", "Idaho ", "Illinois Indiana ", "Iowa ", "Kansas ", "Kentucky ", "Louisiana ", "Maine ", "Maryland ", "Massachusetts ", "Michigan ", "Minnesota ", "Mississippi ", "Missouri ", "Montana Nebraska ", "Nevada ", "New Hampshire ", "New Jersey ", "New Mexico ", "New York ", "North Carolina ", "North Dakota ", "Ohio ", "Oklahoma ", "Oregon ", "Pennsylvania Rhode Island ", "South Carolina ", "South Dakota ", "Tennessee ", "Texas ", "Utah ", "Vermont ", "Virginia ", "Washington ", "West Virginia ", "Wisconsin ", "Wyoming" });
            stateComboBox.Location = new Point(20, 581);
            stateComboBox.Margin = new Padding(4, 5, 4, 5);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(199, 30);
            stateComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            stateComboBox.StyleManager = null;
            stateComboBox.TabIndex = 19;
            stateComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.White;
            lastNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            lastNameTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            lastNameTextBox.Location = new Point(235, 41);
            lastNameTextBox.Margin = new Padding(4, 5, 4, 5);
            lastNameTextBox.Multiline = false;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.SelectedText = "";
            lastNameTextBox.Size = new Size(207, 45);
            lastNameTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            lastNameTextBox.StyleManager = null;
            lastNameTextBox.TabIndex = 3;
            lastNameTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            lastNameTextBox.UseStyleColors = false;
            // 
            // cityTextBox
            // 
            cityTextBox.BackColor = Color.White;
            cityTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            cityTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            cityTextBox.Location = new Point(228, 518);
            cityTextBox.Margin = new Padding(4, 5, 4, 5);
            cityTextBox.Multiline = false;
            cityTextBox.Name = "cityTextBox";
            cityTextBox.SelectedText = "";
            cityTextBox.Size = new Size(212, 45);
            cityTextBox.Style = MetroFramework.MetroColorStyle.White;
            cityTextBox.StyleManager = null;
            cityTextBox.TabIndex = 18;
            cityTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            cityTextBox.UseStyleColors = false;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.BackColor = Color.Transparent;
            metroLabel6.CustomBackground = false;
            metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel6.Location = new Point(19, 380);
            metroLabel6.Margin = new Padding(4, 0, 4, 0);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(93, 20);
            metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel6.StyleManager = null;
            metroLabel6.TabIndex = 16;
            metroLabel6.Text = "Your address";
            metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel6.UseStyleColors = false;
            // 
            // aptTextBox
            // 
            aptTextBox.BackColor = Color.White;
            aptTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            aptTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            aptTextBox.Location = new Point(19, 515);
            aptTextBox.Margin = new Padding(4, 5, 4, 5);
            aptTextBox.Multiline = false;
            aptTextBox.Name = "aptTextBox";
            aptTextBox.SelectedText = "";
            aptTextBox.Size = new Size(201, 45);
            aptTextBox.Style = MetroFramework.MetroColorStyle.White;
            aptTextBox.StyleManager = null;
            aptTextBox.TabIndex = 17;
            aptTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            aptTextBox.UseStyleColors = false;
            // 
            // addLabel
            // 
            addLabel.BackColor = Color.White;
            addLabel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            addLabel.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            addLabel.Location = new Point(17, 446);
            addLabel.Margin = new Padding(4, 5, 4, 5);
            addLabel.Multiline = false;
            addLabel.Name = "addLabel";
            addLabel.SelectedText = "";
            addLabel.Size = new Size(421, 45);
            addLabel.Style = MetroFramework.MetroColorStyle.White;
            addLabel.StyleManager = null;
            addLabel.TabIndex = 15;
            addLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            addLabel.UseStyleColors = false;
            // 
            // searchPage
            // 
            searchPage.Controls.Add(SearchError);
            searchPage.Controls.Add(searchDataGridView);
            searchPage.Controls.Add(searchButton);
            searchPage.Controls.Add(searchTextBox);
            searchPage.CustomBackground = false;
            searchPage.HorizontalScrollbar = false;
            searchPage.HorizontalScrollbarBarColor = true;
            searchPage.HorizontalScrollbarHighlightOnWheel = false;
            searchPage.HorizontalScrollbarSize = 15;
            searchPage.Location = new Point(4, 39);
            searchPage.Margin = new Padding(4, 5, 4, 5);
            searchPage.Name = "searchPage";
            searchPage.Size = new Size(1304, 698);
            searchPage.Style = MetroFramework.MetroColorStyle.Blue;
            searchPage.StyleManager = null;
            searchPage.TabIndex = 4;
            searchPage.Text = "Universal Search";
            searchPage.Theme = MetroFramework.MetroThemeStyle.Light;
            searchPage.VerticalScrollbar = false;
            searchPage.VerticalScrollbarBarColor = true;
            searchPage.VerticalScrollbarHighlightOnWheel = false;
            searchPage.VerticalScrollbarSize = 13;
            // 
            // SearchError
            // 
            SearchError.AutoSize = true;
            SearchError.CustomBackground = false;
            SearchError.FontSize = MetroFramework.MetroLabelSize.Tall;
            SearchError.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            SearchError.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            SearchError.Location = new Point(360, 58);
            SearchError.Margin = new Padding(4, 0, 4, 0);
            SearchError.Name = "SearchError";
            SearchError.Size = new Size(313, 150);
            SearchError.Style = MetroFramework.MetroColorStyle.Green;
            SearchError.StyleManager = null;
            SearchError.TabIndex = 19;
            SearchError.Text = "I ran out of entries :( SORRY DUDE.\r\n\r\nYou know, we can make another deal. \r\n\r\nI sure will find something.\r\n";
            SearchError.Theme = MetroFramework.MetroThemeStyle.Light;
            SearchError.UseStyleColors = false;
            SearchError.Visible = false;
            // 
            // searchDataGridView
            // 
            searchDataGridView.AllowUserToAddRows = false;
            searchDataGridView.AllowUserToDeleteRows = false;
            searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Location = new Point(91, 62);
            searchDataGridView.Margin = new Padding(4, 5, 4, 5);
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.ReadOnly = true;
            searchDataGridView.RowHeadersWidth = 51;
            searchDataGridView.Size = new Size(973, 362);
            searchDataGridView.TabIndex = 18;
            searchDataGridView.Visible = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.BackgroundImage = (Image)resources.GetObject("searchButton.BackgroundImage");
            searchButton.BackgroundImageLayout = ImageLayout.Zoom;
            searchButton.Highlight = false;
            searchButton.Location = new Point(1012, 302);
            searchButton.Margin = new Padding(4, 5, 4, 5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(61, 45);
            searchButton.Style = MetroFramework.MetroColorStyle.Blue;
            searchButton.StyleManager = null;
            searchButton.TabIndex = 17;
            searchButton.Theme = MetroFramework.MetroThemeStyle.Light;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.White;
            searchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            searchTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            searchTextBox.Location = new Point(100, 302);
            searchTextBox.Margin = new Padding(4, 5, 4, 5);
            searchTextBox.Multiline = false;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.SelectedText = "";
            searchTextBox.Size = new Size(951, 45);
            searchTextBox.Style = MetroFramework.MetroColorStyle.White;
            searchTextBox.StyleManager = null;
            searchTextBox.TabIndex = 15;
            searchTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            searchTextBox.UseStyleColors = false;
            // 
            // metroTabPage2
            // 
            metroTabPage2.AutoScroll = true;
            metroTabPage2.Controls.Add(resTotalDataGridView);
            metroTabPage2.CustomBackground = false;
            metroTabPage2.HorizontalScrollbar = true;
            metroTabPage2.HorizontalScrollbarBarColor = true;
            metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            metroTabPage2.HorizontalScrollbarSize = 15;
            metroTabPage2.Location = new Point(4, 39);
            metroTabPage2.Margin = new Padding(4, 5, 4, 5);
            metroTabPage2.Name = "metroTabPage2";
            metroTabPage2.Size = new Size(1304, 698);
            metroTabPage2.Style = MetroFramework.MetroColorStyle.Blue;
            metroTabPage2.StyleManager = null;
            metroTabPage2.TabIndex = 3;
            metroTabPage2.Text = "Reservation Adv. view";
            metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabPage2.VerticalScrollbar = true;
            metroTabPage2.VerticalScrollbarBarColor = true;
            metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            metroTabPage2.VerticalScrollbarSize = 13;
            // 
            // resTotalDataGridView
            // 
            resTotalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resTotalDataGridView.Location = new Point(0, 5);
            resTotalDataGridView.Margin = new Padding(4, 5, 4, 5);
            resTotalDataGridView.Name = "resTotalDataGridView";
            resTotalDataGridView.RowHeadersWidth = 51;
            resTotalDataGridView.Size = new Size(1301, 668);
            resTotalDataGridView.TabIndex = 2;
            // 
            // roomPage
            // 
            roomPage.Controls.Add(metroLabel13);
            roomPage.Controls.Add(metroLabel11);
            roomPage.Controls.Add(reservedLabel);
            roomPage.Controls.Add(roomReservedListBox);
            roomPage.Controls.Add(roomOccupiedListBox);
            roomPage.Controls.Add(occupiedLabel);
            roomPage.CustomBackground = false;
            roomPage.HorizontalScrollbar = false;
            roomPage.HorizontalScrollbarBarColor = true;
            roomPage.HorizontalScrollbarHighlightOnWheel = false;
            roomPage.HorizontalScrollbarSize = 15;
            roomPage.Location = new Point(4, 39);
            roomPage.Margin = new Padding(4, 5, 4, 5);
            roomPage.Name = "roomPage";
            roomPage.Size = new Size(1304, 698);
            roomPage.Style = MetroFramework.MetroColorStyle.Blue;
            roomPage.StyleManager = null;
            roomPage.TabIndex = 2;
            roomPage.Text = "Room availibility";
            roomPage.Theme = MetroFramework.MetroThemeStyle.Light;
            roomPage.VerticalScrollbar = false;
            roomPage.VerticalScrollbarBarColor = true;
            roomPage.VerticalScrollbarHighlightOnWheel = false;
            roomPage.VerticalScrollbarSize = 13;
            // 
            // metroLabel13
            // 
            metroLabel13.AutoSize = true;
            metroLabel13.BackColor = Color.Transparent;
            metroLabel13.CustomBackground = false;
            metroLabel13.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel13.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel13.Location = new Point(612, 42);
            metroLabel13.Margin = new Padding(4, 0, 4, 0);
            metroLabel13.Name = "metroLabel13";
            metroLabel13.Size = new Size(506, 20);
            metroLabel13.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel13.StyleManager = null;
            metroLabel13.TabIndex = 10;
            metroLabel13.Text = "Room#| Type  |  ID#   |       Name      |      Phone #      |     Entry       |    Depart";
            metroLabel13.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel13.UseStyleColors = false;
            // 
            // metroLabel11
            // 
            metroLabel11.AutoSize = true;
            metroLabel11.BackColor = Color.Transparent;
            metroLabel11.CustomBackground = false;
            metroLabel11.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel11.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel11.Location = new Point(-4, 42);
            metroLabel11.Margin = new Padding(4, 0, 4, 0);
            metroLabel11.Name = "metroLabel11";
            metroLabel11.Size = new Size(331, 20);
            metroLabel11.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel11.StyleManager = null;
            metroLabel11.TabIndex = 9;
            metroLabel11.Text = "Room#| Type  |  ID#   |       Name      |      Phone #";
            metroLabel11.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel11.UseStyleColors = false;
            // 
            // reservedLabel
            // 
            reservedLabel.AutoSize = true;
            reservedLabel.BackColor = Color.Transparent;
            reservedLabel.CustomBackground = false;
            reservedLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            reservedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            reservedLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            reservedLabel.Location = new Point(612, 6);
            reservedLabel.Margin = new Padding(4, 0, 4, 0);
            reservedLabel.Name = "reservedLabel";
            reservedLabel.Size = new Size(69, 20);
            reservedLabel.Style = MetroFramework.MetroColorStyle.Blue;
            reservedLabel.StyleManager = null;
            reservedLabel.TabIndex = 8;
            reservedLabel.Text = "Reserved";
            reservedLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            reservedLabel.UseStyleColors = false;
            // 
            // roomReservedListBox
            // 
            roomReservedListBox.BackColor = Color.FromArgb(224, 224, 224);
            roomReservedListBox.BorderStyle = BorderStyle.None;
            roomReservedListBox.FormattingEnabled = true;
            roomReservedListBox.HorizontalScrollbar = true;
            roomReservedListBox.IntegralHeight = false;
            roomReservedListBox.Location = new Point(613, 78);
            roomReservedListBox.Margin = new Padding(4, 5, 4, 5);
            roomReservedListBox.Name = "roomReservedListBox";
            roomReservedListBox.Size = new Size(688, 595);
            roomReservedListBox.TabIndex = 7;
            // 
            // roomOccupiedListBox
            // 
            roomOccupiedListBox.BackColor = Color.FromArgb(224, 224, 224);
            roomOccupiedListBox.BorderStyle = BorderStyle.None;
            roomOccupiedListBox.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomOccupiedListBox.FormattingEnabled = true;
            roomOccupiedListBox.HorizontalScrollbar = true;
            roomOccupiedListBox.IntegralHeight = false;
            roomOccupiedListBox.Location = new Point(0, 78);
            roomOccupiedListBox.Margin = new Padding(4, 5, 4, 5);
            roomOccupiedListBox.Name = "roomOccupiedListBox";
            roomOccupiedListBox.Size = new Size(605, 595);
            roomOccupiedListBox.TabIndex = 6;
            // 
            // occupiedLabel
            // 
            occupiedLabel.AutoSize = true;
            occupiedLabel.BackColor = Color.Transparent;
            occupiedLabel.CustomBackground = false;
            occupiedLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            occupiedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            occupiedLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            occupiedLabel.Location = new Point(-4, 6);
            occupiedLabel.Margin = new Padding(4, 0, 4, 0);
            occupiedLabel.Name = "occupiedLabel";
            occupiedLabel.Size = new Size(72, 20);
            occupiedLabel.Style = MetroFramework.MetroColorStyle.Blue;
            occupiedLabel.StyleManager = null;
            occupiedLabel.TabIndex = 5;
            occupiedLabel.Text = "Occupied";
            occupiedLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            occupiedLabel.UseStyleColors = false;
            // 
            // Frontend
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1331, 839);
            Controls.Add(resPanel);
            Location = new Point(0, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Frontend";
            Padding = new Padding(27, 92, 27, 31);
            StartPosition = FormStartPosition.Manual;
            Style = MetroFramework.MetroColorStyle.Green;
            Text = "Frontend";
            FormClosing += frontend_FormClosing;
            Load += MainTab_Load;
            resPanel.ResumeLayout(false);
            reservationPage.ResumeLayout(false);
            rightMPanel.ResumeLayout(false);
            middlePanel.ResumeLayout(false);
            middlePanel.PerformLayout();
            leftMPanel.ResumeLayout(false);
            leftMPanel.PerformLayout();
            searchPage.ResumeLayout(false);
            searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
            metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).EndInit();
            roomPage.ResumeLayout(false);
            roomPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion



        private MetroFramework.Controls.MetroTabControl resPanel;
        private MetroFramework.Controls.MetroTabPage reservationPage;
        private MetroFramework.Controls.MetroPanel leftMPanel;
        private MetroFramework.Controls.MetroTextBox firstNameTextBox;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private MetroFramework.Controls.MetroLabel birthdayLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroComboBox monthComboBox;
        private MetroFramework.Controls.MetroTextBox yearTextBox;
        private MetroFramework.Controls.MetroComboBox dayComboBox;
        private MetroFramework.Controls.MetroTextBox phoneNumberTextBox;
        private MetroFramework.Controls.MetroLabel genderLabel;
        private MetroFramework.Controls.MetroLabel phoneNumberLabel;
        private MetroFramework.Controls.MetroComboBox genderComboBox;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroPanel middlePanel;
        private MetroFramework.Controls.MetroTextBox zipComboBox;
        private MetroFramework.Controls.MetroComboBox stateComboBox;
        private MetroFramework.Controls.MetroTextBox cityTextBox;
        private MetroFramework.Controls.MetroTextBox aptTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox addLabel;
        private MetroFramework.Controls.MetroComboBox roomTypeComboBox;
        private MetroFramework.Controls.MetroLabel choiceLabel;
        private MetroFramework.Controls.MetroComboBox roomNComboBox;
        private MetroFramework.Controls.MetroComboBox floorComboBox;
        private MetroFramework.Controls.MetroButton submitButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton finalizeButton;
        private MetroFramework.Controls.MetroButton newButton;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.DateTimePicker depDatePicker;
        private MetroFramework.Controls.MetroLabel entryLabel;
        private MetroFramework.Controls.MetroButton foodMenuButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroCheckBox checkinCheckBox;
        private MetroFramework.Controls.MetroComboBox resEditButton;
        private MetroFramework.Controls.MetroPanel rightMPanel;

        private MetroFramework.Controls.MetroTabPage roomPage;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
      
        private System.Windows.Forms.DataGridView resTotalDataGridView;
        private MetroFramework.Controls.MetroCheckBox foodSupplyCheckBox;
        private System.Windows.Forms.ListBox roomOccupiedListBox;
        private MetroFramework.Controls.MetroLabel occupiedLabel;
        private MetroFramework.Controls.MetroLabel reservedLabel;
        private System.Windows.Forms.ListBox roomReservedListBox;
        private MetroFramework.Controls.MetroTabPage searchPage;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroComboBox qtGuestComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroLabel SearchError;
        private MetroFramework.Controls.MetroCheckBox smsCheckBox;


     
    }
}