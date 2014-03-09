using System;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
	public partial class Form2 : Form
	{
		private readonly SharedState _state;

		public Form2()
		{
			if (!DesignMode)
				throw new InvalidOperationException("Tego konstruktora może używać tylko Visual, nigdy twój kod");

			InitializeComponent();
		}

		public Form2(SharedState state)
		{
			if (state == null) throw new ArgumentNullException("state");
			_state = state;


			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_state.SharedValue = textBox1.Text;
		}
	}
}