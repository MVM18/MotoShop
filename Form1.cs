namespace MotoShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           LoadUserControl();
         

		}
        public void LoadUserControl()
        {
            UserLog userLog = new UserLog();

            panel1.Controls.Clear();
            userLog.Dock = DockStyle.Fill;
            panel1.Controls.Add(userLog);
        }

        public void LoadNewAcc()
        {
            NewAcc newAcc = new NewAcc();
            panel1.Controls.Clear();
            newAcc.Dock = DockStyle.Fill;
            panel1.Controls.Add(newAcc);
        }
        public void LoadService()
        {
            Services services = new Services();
            panel1.Controls.Clear();
            services.Dock = DockStyle.Fill;
            panel1.Controls.Add(services);
        }
       

		private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
