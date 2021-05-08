namespace MovieAssessment
{
    partial class Form1
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
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.btnUpdateCust = new System.Windows.Forms.Button();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.tbxMID = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.tbxRating = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MoviesTB = new System.Windows.Forms.TabPage();
            this.CustomerTB = new System.Windows.Forms.TabPage();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.RentalsTB = new System.Windows.Forms.TabPage();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.tbxCopies = new System.Windows.Forms.TextBox();
            this.tbxCID = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxPlot = new System.Windows.Forms.TextBox();
            this.tbxLast = new System.Windows.Forms.TextBox();
            this.tbxFirst = new System.Windows.Forms.TextBox();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbxRID = new System.Windows.Forms.TextBox();
            this.lblRID = new System.Windows.Forms.Label();
            this.btn_MovieOut = new System.Windows.Forms.Button();
            this.btn_MoviesRented = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.TabControl.SuspendLayout();
            this.MoviesTB.SuspendLayout();
            this.CustomerTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.RentalsTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovies
            // 
            this.dgvMovies.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(0, 0);
            this.dgvMovies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.Size = new System.Drawing.Size(1219, 391);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellClick);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdateCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCust.Location = new System.Drawing.Point(213, 549);
            this.btnUpdateCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(120, 44);
            this.btnUpdateCust.TabIndex = 2;
            this.btnUpdateCust.Text = "Update Customer";
            this.btnUpdateCust.UseVisualStyleBackColor = false;
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCust.Location = new System.Drawing.Point(347, 549);
            this.btnDeleteCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(120, 44);
            this.btnDeleteCust.TabIndex = 3;
            this.btnDeleteCust.Text = "Delete Customer";
            this.btnDeleteCust.UseVisualStyleBackColor = false;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(85, 742);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(120, 46);
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(341, 743);
            this.btnDeleteMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(120, 44);
            this.btnDeleteMovie.TabIndex = 5;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // tbxMID
            // 
            this.tbxMID.Location = new System.Drawing.Point(353, 710);
            this.tbxMID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMID.Name = "tbxMID";
            this.tbxMID.Size = new System.Drawing.Size(61, 22);
            this.tbxMID.TabIndex = 7;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(488, 506);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(353, 22);
            this.tbxAddress.TabIndex = 8;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(87, 644);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(200, 22);
            this.tbxTitle.TabIndex = 9;
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(213, 710);
            this.tbxCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(131, 22);
            this.tbxCost.TabIndex = 10;
            // 
            // tbxRating
            // 
            this.tbxRating.Location = new System.Drawing.Point(968, 644);
            this.tbxRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxRating.Name = "tbxRating";
            this.tbxRating.Size = new System.Drawing.Size(113, 22);
            this.tbxRating.TabIndex = 11;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(851, 506);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(225, 22);
            this.tbxPhone.TabIndex = 12;
            // 
            // TabControl
            // 
            this.TabControl.AccessibleName = "";
            this.TabControl.Controls.Add(this.MoviesTB);
            this.TabControl.Controls.Add(this.CustomerTB);
            this.TabControl.Controls.Add(this.RentalsTB);
            this.TabControl.Location = new System.Drawing.Point(87, 59);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1229, 423);
            this.TabControl.TabIndex = 13;
            // 
            // MoviesTB
            // 
            this.MoviesTB.Controls.Add(this.dgvMovies);
            this.MoviesTB.Location = new System.Drawing.Point(4, 25);
            this.MoviesTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoviesTB.Name = "MoviesTB";
            this.MoviesTB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoviesTB.Size = new System.Drawing.Size(1221, 394);
            this.MoviesTB.TabIndex = 0;
            this.MoviesTB.Text = "Movies";
            this.MoviesTB.UseVisualStyleBackColor = true;
            // 
            // CustomerTB
            // 
            this.CustomerTB.Controls.Add(this.dgvCustomer);
            this.CustomerTB.Location = new System.Drawing.Point(4, 25);
            this.CustomerTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerTB.Name = "CustomerTB";
            this.CustomerTB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerTB.Size = new System.Drawing.Size(1221, 394);
            this.CustomerTB.TabIndex = 1;
            this.CustomerTB.Text = "Customers";
            this.CustomerTB.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.Size = new System.Drawing.Size(1219, 391);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // RentalsTB
            // 
            this.RentalsTB.Controls.Add(this.dgvRentals);
            this.RentalsTB.Location = new System.Drawing.Point(4, 25);
            this.RentalsTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentalsTB.Name = "RentalsTB";
            this.RentalsTB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentalsTB.Size = new System.Drawing.Size(1221, 394);
            this.RentalsTB.TabIndex = 2;
            this.RentalsTB.Text = "Rentals";
            this.RentalsTB.UseVisualStyleBackColor = true;
            // 
            // dgvRentals
            // 
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Location = new System.Drawing.Point(0, 0);
            this.dgvRentals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.RowHeadersWidth = 51;
            this.dgvRentals.Size = new System.Drawing.Size(1219, 391);
            this.dgvRentals.TabIndex = 0;
            this.dgvRentals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentals_CellClick);
            // 
            // tbxGenre
            // 
            this.tbxGenre.Location = new System.Drawing.Point(296, 644);
            this.tbxGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(184, 22);
            this.tbxGenre.TabIndex = 14;
            // 
            // tbxCopies
            // 
            this.tbxCopies.Location = new System.Drawing.Point(85, 710);
            this.tbxCopies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCopies.Name = "tbxCopies";
            this.tbxCopies.Size = new System.Drawing.Size(119, 22);
            this.tbxCopies.TabIndex = 15;
            // 
            // tbxCID
            // 
            this.tbxCID.Location = new System.Drawing.Point(1085, 506);
            this.tbxCID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCID.Name = "tbxCID";
            this.tbxCID.Size = new System.Drawing.Size(85, 22);
            this.tbxCID.TabIndex = 16;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(851, 644);
            this.tbxYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(108, 22);
            this.tbxYear.TabIndex = 17;
            // 
            // tbxPlot
            // 
            this.tbxPlot.Location = new System.Drawing.Point(488, 644);
            this.tbxPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPlot.Name = "tbxPlot";
            this.tbxPlot.Size = new System.Drawing.Size(348, 22);
            this.tbxPlot.TabIndex = 18;
            // 
            // tbxLast
            // 
            this.tbxLast.Location = new System.Drawing.Point(295, 506);
            this.tbxLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxLast.Name = "tbxLast";
            this.tbxLast.Size = new System.Drawing.Size(184, 22);
            this.tbxLast.TabIndex = 19;
            // 
            // tbxFirst
            // 
            this.tbxFirst.Location = new System.Drawing.Point(85, 506);
            this.tbxFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxFirst.Name = "tbxFirst";
            this.tbxFirst.Size = new System.Drawing.Size(200, 22);
            this.tbxFirst.TabIndex = 20;
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.Location = new System.Drawing.Point(85, 549);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(120, 44);
            this.btnAddCust.TabIndex = 21;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 486);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 486);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(847, 486);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Customer Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 624);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Movie Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 624);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Movie Genre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 624);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Movie Plot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(847, 624);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(964, 624);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Rating";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 690);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Copies issued";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 690);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Rental Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(349, 690);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Movie ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1081, 486);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Customer ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(492, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(378, 50);
            this.label14.TabIndex = 35;
            this.label14.Text = "Rental Video System";
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(213, 743);
            this.btnUpdateMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(120, 44);
            this.btnUpdateMovie.TabIndex = 36;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(569, 743);
            this.btnRent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(120, 44);
            this.btnRent.TabIndex = 37;
            this.btnRent.Text = "Rent Movie";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(697, 743);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(120, 44);
            this.btnReturn.TabIndex = 38;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbxRID
            // 
            this.tbxRID.Location = new System.Drawing.Point(825, 763);
            this.tbxRID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxRID.Name = "tbxRID";
            this.tbxRID.Size = new System.Drawing.Size(73, 22);
            this.tbxRID.TabIndex = 39;
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Location = new System.Drawing.Point(825, 743);
            this.lblRID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(71, 17);
            this.lblRID.TabIndex = 40;
            this.lblRID.Text = "Rented ID";
            // 
            // btn_MovieOut
            // 
            this.btn_MovieOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_MovieOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MovieOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MovieOut.Location = new System.Drawing.Point(1074, 688);
            this.btn_MovieOut.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MovieOut.Name = "btn_MovieOut";
            this.btn_MovieOut.Size = new System.Drawing.Size(160, 44);
            this.btn_MovieOut.TabIndex = 41;
            this.btn_MovieOut.Text = "Movie Out";
            this.btn_MovieOut.UseVisualStyleBackColor = false;
            this.btn_MovieOut.Click += new System.EventHandler(this.btn_MovieOut_Click);
            // 
            // btn_MoviesRented
            // 
            this.btn_MoviesRented.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_MoviesRented.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MoviesRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoviesRented.Location = new System.Drawing.Point(1074, 763);
            this.btn_MoviesRented.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MoviesRented.Name = "btn_MoviesRented";
            this.btn_MoviesRented.Size = new System.Drawing.Size(160, 44);
            this.btn_MoviesRented.TabIndex = 42;
            this.btn_MoviesRented.Text = "Movie Rented";
            this.btn_MoviesRented.UseVisualStyleBackColor = false;
            this.btn_MoviesRented.Click += new System.EventHandler(this.btn_MoviesRented_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1415, 822);
            this.Controls.Add(this.btn_MoviesRented);
            this.Controls.Add(this.btn_MovieOut);
            this.Controls.Add(this.lblRID);
            this.Controls.Add(this.tbxRID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.tbxFirst);
            this.Controls.Add(this.tbxLast);
            this.Controls.Add(this.tbxPlot);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.tbxCID);
            this.Controls.Add(this.tbxCopies);
            this.Controls.Add(this.tbxGenre);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxRating);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxMID);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnDeleteCust);
            this.Controls.Add(this.btnUpdateCust);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.MoviesTB.ResumeLayout(false);
            this.CustomerTB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.RentalsTB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button btnUpdateCust;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.TextBox tbxMID;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.TextBox tbxRating;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MoviesTB;
        private System.Windows.Forms.TabPage CustomerTB;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TabPage RentalsTB;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.TextBox tbxCopies;
        private System.Windows.Forms.TextBox tbxCID;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxPlot;
        private System.Windows.Forms.TextBox tbxLast;
        private System.Windows.Forms.TextBox tbxFirst;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbxRID;
        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.Button btn_MovieOut;
        private System.Windows.Forms.Button btn_MoviesRented;
    }
}

