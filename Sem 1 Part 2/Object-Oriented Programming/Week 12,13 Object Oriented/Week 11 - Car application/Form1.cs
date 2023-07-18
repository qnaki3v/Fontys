namespace Week_11___Car_application
{
    public partial class CarController : Form
    {
        public CarController()
        {
            Garage garage = new Garage();

            Car fiatPanda = new Car("Fiat Panda", 20, 160);
            Car AudiA4 = new Car("Audi A4", 40, 200);
            Car ferrariF40 = new Car("Ferrari F40", 60, 240);

            garage.AddCar(fiatPanda);
            garage.AddCar(AudiA4);
            garage.AddCar(ferrariF40);

            InitializeComponent();
            lbGarage.DataSource = garage.Cars;
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            Car curr = (Car)lbGarage.SelectedItem;
            MessageBox.Show(curr.Accelerate());
            lblSpeed.Text = curr.SpeedNow();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            Car curr = (Car)lbGarage.SelectedItem;
            MessageBox.Show(curr.UseBreaks());
            lblSpeed.Text = curr.SpeedNow();
        }

        private void lbGarage_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSpeed.Text = lbGarage.SelectedItem.ToString();
        }
    }
}