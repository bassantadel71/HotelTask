using BLL.EntityManager;
using HotelManagementSystem.UI;

namespace Hotel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private LoginManager em = new LoginManager();

		private void btnSignIn_Click(object sender, EventArgs e)
		{
			try
			{
				string username = txtUserName.Text.Trim();
				string password = txtPassword.Text.Trim();

				if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
				{
					MessageBox.Show("Please enter username and password.", "Warning",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				// frontEnd user login
				try
				{
					var user = em.FrontendLogin(username, password);
					MessageBox.Show($"Welcome {user.user_name}!", "Success",
						MessageBoxButtons.OK, MessageBoxIcon.Information);

					// Open frontend form
					Frontend form = new Frontend();
					form.Show();
					this.Hide();
					MessageBox.Show("right login");
					return;
				}
				catch
				{

				}

				// Kitchen user login
				try
				{
					var user = em.KitchenLogin(username, password);
					MessageBox.Show($"Welcome {user.UserName}!", "Success",
						MessageBoxButtons.OK, MessageBoxIcon.Information);

					//// Open kitchen form
					Kitchen form = new Kitchen();
					form.Show();
					this.Hide();
					MessageBox.Show("right login");
					return;
				}
				catch
				{
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch
			{
				MessageBox.Show("Invalid username or password.", "Access Denied",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLicense_Click(object sender, EventArgs e)
		{
			License open_license = new License();
			open_license.Show();
		}
		

		//private void button1_Click(object sender, EventArgs e)
		//{

		//}

		//private void textBox1_TextChanged(object sender, EventArgs e)
		//{

		//}
	}
}
