
namespace VehicleApp
{
    partial class frmVehicles
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnBicycle = new System.Windows.Forms.RadioButton();
            this.rbtnCar = new System.Windows.Forms.RadioButton();
            this.grbBikes = new System.Windows.Forms.GroupBox();
            this.cboTerrain = new System.Windows.Forms.ComboBox();
            this.nrudTireSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbCars = new System.Windows.Forms.GroupBox();
            this.cboFuel = new System.Windows.Forms.ComboBox();
            this.nrudPassengers = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateVehicle = new System.Windows.Forms.Button();
            this.btnMakeSale = new System.Windows.Forms.Button();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbBikes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).BeginInit();
            this.grbCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.grbBikes);
            this.groupBox1.Controls.Add(this.grbCars);
            this.groupBox1.Controls.Add(this.txtStore);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWarranty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Information";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnBicycle);
            this.groupBox4.Controls.Add(this.rbtnCar);
            this.groupBox4.Location = new System.Drawing.Point(555, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 100);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Type of Vehicle";
            // 
            // rbtnBicycle
            // 
            this.rbtnBicycle.AutoSize = true;
            this.rbtnBicycle.Location = new System.Drawing.Point(17, 60);
            this.rbtnBicycle.Name = "rbtnBicycle";
            this.rbtnBicycle.Size = new System.Drawing.Size(62, 19);
            this.rbtnBicycle.TabIndex = 1;
            this.rbtnBicycle.Text = "Bicycle";
            this.rbtnBicycle.UseVisualStyleBackColor = true;
            this.rbtnBicycle.Click += new System.EventHandler(this.rbtnBicycle_Click);
            // 
            // rbtnCar
            // 
            this.rbtnCar.AutoSize = true;
            this.rbtnCar.Checked = true;
            this.rbtnCar.Location = new System.Drawing.Point(17, 26);
            this.rbtnCar.Name = "rbtnCar";
            this.rbtnCar.Size = new System.Drawing.Size(43, 19);
            this.rbtnCar.TabIndex = 0;
            this.rbtnCar.TabStop = true;
            this.rbtnCar.Text = "Car";
            this.rbtnCar.UseVisualStyleBackColor = true;
            this.rbtnCar.Click += new System.EventHandler(this.rbtnCar_Click);
            // 
            // grbBikes
            // 
            this.grbBikes.Controls.Add(this.cboTerrain);
            this.grbBikes.Controls.Add(this.nrudTireSize);
            this.grbBikes.Controls.Add(this.label8);
            this.grbBikes.Controls.Add(this.label9);
            this.grbBikes.Enabled = false;
            this.grbBikes.Location = new System.Drawing.Point(316, 193);
            this.grbBikes.Name = "grbBikes";
            this.grbBikes.Size = new System.Drawing.Size(200, 100);
            this.grbBikes.TabIndex = 11;
            this.grbBikes.TabStop = false;
            this.grbBikes.Text = "For Bikes";
            // 
            // cboTerrain
            // 
            this.cboTerrain.FormattingEnabled = true;
            this.cboTerrain.Items.AddRange(new object[] {
            "Paved",
            "Unpaved"});
            this.cboTerrain.Location = new System.Drawing.Point(82, 58);
            this.cboTerrain.Name = "cboTerrain";
            this.cboTerrain.Size = new System.Drawing.Size(112, 23);
            this.cboTerrain.TabIndex = 5;
            // 
            // nrudTireSize
            // 
            this.nrudTireSize.Location = new System.Drawing.Point(82, 22);
            this.nrudTireSize.Name = "nrudTireSize";
            this.nrudTireSize.Size = new System.Drawing.Size(112, 23);
            this.nrudTireSize.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Terrain:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tire Size:";
            // 
            // grbCars
            // 
            this.grbCars.Controls.Add(this.cboFuel);
            this.grbCars.Controls.Add(this.nrudPassengers);
            this.grbCars.Controls.Add(this.label7);
            this.grbCars.Controls.Add(this.label6);
            this.grbCars.Location = new System.Drawing.Point(316, 41);
            this.grbCars.Name = "grbCars";
            this.grbCars.Size = new System.Drawing.Size(200, 100);
            this.grbCars.TabIndex = 10;
            this.grbCars.TabStop = false;
            this.grbCars.Text = "For Cars";
            // 
            // cboFuel
            // 
            this.cboFuel.FormattingEnabled = true;
            this.cboFuel.Items.AddRange(new object[] {
            "Gas",
            "Diesel",
            "Electric",
            "Hybrid"});
            this.cboFuel.Location = new System.Drawing.Point(82, 57);
            this.cboFuel.Name = "cboFuel";
            this.cboFuel.Size = new System.Drawing.Size(112, 23);
            this.cboFuel.TabIndex = 3;
            // 
            // nrudPassengers
            // 
            this.nrudPassengers.Location = new System.Drawing.Point(82, 23);
            this.nrudPassengers.Name = "nrudPassengers";
            this.nrudPassengers.Size = new System.Drawing.Size(112, 23);
            this.nrudPassengers.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fuel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Passangers:";
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(90, 270);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(128, 23);
            this.txtStore.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Store:";
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(90, 217);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(128, 23);
            this.txtWarranty.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Warranty:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(90, 158);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(128, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(90, 101);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(128, 23);
            this.txtBrand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brand:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 23);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnCreateVehicle
            // 
            this.btnCreateVehicle.Location = new System.Drawing.Point(678, 446);
            this.btnCreateVehicle.Name = "btnCreateVehicle";
            this.btnCreateVehicle.Size = new System.Drawing.Size(94, 45);
            this.btnCreateVehicle.TabIndex = 1;
            this.btnCreateVehicle.Text = "Create Vehicle";
            this.btnCreateVehicle.UseVisualStyleBackColor = true;
            this.btnCreateVehicle.Click += new System.EventHandler(this.btnCreateVehicle_Click);
            // 
            // btnMakeSale
            // 
            this.btnMakeSale.Enabled = false;
            this.btnMakeSale.Location = new System.Drawing.Point(32, 446);
            this.btnMakeSale.Name = "btnMakeSale";
            this.btnMakeSale.Size = new System.Drawing.Size(104, 48);
            this.btnMakeSale.TabIndex = 2;
            this.btnMakeSale.Text = "Make Sale";
            this.btnMakeSale.UseVisualStyleBackColor = true;
            this.btnMakeSale.Click += new System.EventHandler(this.btnMakeSale_Click);
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.Enabled = false;
            this.btnCalculateInterest.Location = new System.Drawing.Point(154, 446);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(108, 48);
            this.btnCalculateInterest.TabIndex = 3;
            this.btnCalculateInterest.Text = "Calculate Interest";
            this.btnCalculateInterest.UseVisualStyleBackColor = true;
            this.btnCalculateInterest.Click += new System.EventHandler(this.btnCalculateInterest_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Search by Vehicle Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(576, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 23);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(697, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCalculateInterest);
            this.Controls.Add(this.btnMakeSale);
            this.Controls.Add(this.btnCreateVehicle);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVehicles";
            this.Text = "Vehicles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbBikes.ResumeLayout(false);
            this.grbBikes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).EndInit();
            this.grbCars.ResumeLayout(false);
            this.grbCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateVehicle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbBikes;
        private System.Windows.Forms.GroupBox grbCars;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnBicycle;
        private System.Windows.Forms.RadioButton rbtnCar;
        private System.Windows.Forms.ComboBox cboTerrain;
        private System.Windows.Forms.NumericUpDown nrudTireSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboFuel;
        private System.Windows.Forms.NumericUpDown nrudPassengers;
        private System.Windows.Forms.Button btnMakeSale;
        private System.Windows.Forms.Button btnCalculateInterest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

