using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class frmVehicles : Form
    {

        private List<Vehicle> vehicles = new List<Vehicle>();
        private Vehicle myVehicle = null;

        public frmVehicles()
        {
            InitializeComponent();

            vehicles.Add(new Car("Corolla",
                "Toyota",
                20000,
                5,
                "Oshawa Toyota",
                5,
                "Gas"
                ));

            vehicles.Add(new Bicycle("BMX",
                "Colony",
                600,
                3,
                "SportCheck",
                20,
                "Unpaved"
                ));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtnCar_Click(object sender, EventArgs e)
        {
            grbCars.Enabled = true;
            grbBikes.Enabled = false;
        }

        private void rbtnBicycle_Click(object sender, EventArgs e)
        {
            grbCars.Enabled = false;
            grbBikes.Enabled = true;
        }

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnCar.Checked)
                {
                    Car newCar = new Car(txtName.Text,
                        txtBrand.Text,
                        double.Parse(txtPrice.Text),
                        int.Parse(txtWarranty.Text),
                        txtStore.Text,
                        (int)nrudPassengers.Value,
                        cboFuel.Text);

                    vehicles.Add(newCar);
                }
                else
                {
                    Bicycle newBicycle = new Bicycle(txtName.Text,
                        txtBrand.Text,
                        double.Parse(txtPrice.Text),
                        int.Parse(txtWarranty.Text),
                        txtStore.Text,
                        (int)nrudTireSize.Value,
                        cboTerrain.Text);

                    vehicles.Add(newBicycle);
                }

                txtName.Text = "";
                txtBrand.Text = "";
                txtPrice.Text = "";
                txtWarranty.Text = "";
                txtStore.Text = "";

                cboFuel.Text = "";
                nrudPassengers.Value = 0;

                cboTerrain.Text = "";
                nrudTireSize.Value = 0;

                rbtnCar.Checked = true;
                //rbtnBicycle.Checked = false;

                grbCars.Enabled = true;
                grbBikes.Enabled = false;

                MessageBox.Show($"Total number of vehicles: {vehicles.Count}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Format!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            myVehicle = null;

            foreach (Vehicle v in vehicles)
                if (v.Name.ToLower() == txtSearch.Text.ToLower())
                {
                    myVehicle = v;
                    break;
                }

            if (myVehicle != null)
            {
                btnCalculateInterest.Enabled = true;
                btnMakeSale.Enabled = true;

                txtName.Text = myVehicle.Name;
                txtBrand.Text = myVehicle.Brand;
                txtPrice.Text = myVehicle.Price.ToString();
                txtWarranty.Text = myVehicle.Warranty.ToString();
                txtStore.Text = myVehicle.Store;

                if (myVehicle is Car)
                {
                    nrudPassengers.Value = ((Car)myVehicle).NumberOfPassengers;
                    cboFuel.Text = ((Car)myVehicle).Fuel;

                    grbCars.Enabled = true;
                    grbBikes.Enabled = false;

                    rbtnCar.Checked = true;
                    rbtnBicycle.Checked = false;
                }
                else
                if (myVehicle is Bicycle)
                {
                    nrudTireSize.Value = ((Bicycle)myVehicle).TireSize;
                    cboTerrain.Text = ((Bicycle)myVehicle).Terrain;

                    grbCars.Enabled = false;
                    grbBikes.Enabled = true;

                    rbtnCar.Checked = false;
                    rbtnBicycle.Checked = true;
                }
            }
            else
            {
                btnCalculateInterest.Enabled = false;
                btnMakeSale.Enabled = false;
                
                MessageBox.Show("Vehicle not found!");
            }
        }

        private void btnMakeSale_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myVehicle.MakeSale());
        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myVehicle.CalculateInterest().ToString("C"));
        }
    }
}
