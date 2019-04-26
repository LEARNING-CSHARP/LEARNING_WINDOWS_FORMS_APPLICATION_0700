namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Button_MouseEnter(object sender, System.EventArgs e)
		{
			// دکمه جاری که با ماوس روی آن رفته‌ایم
			System.Windows.Forms.Button
				currentButton = sender as System.Windows.Forms.Button;

			if (currentButton != null)
			{
				currentButton.BackColor =
					System.Drawing.Color.Yellow;
			}
		}

		private void Button_MouseLeave(object sender, System.EventArgs e)
		{
			// دکمه جاری که با ماوس از روی آن خارج شده‌ایم
			System.Windows.Forms.Button
				currentButton = sender as System.Windows.Forms.Button;

			if (currentButton != null)
			{
				currentButton.BackColor =
					System.Drawing.Color.LightGray;
			}
		}
	}
}
