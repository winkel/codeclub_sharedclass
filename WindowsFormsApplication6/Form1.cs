using System;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
	public partial class Form1 : Form
	{
		private readonly SharedState _state;

		public Form1()
		{
			if (!DesignMode)
				throw new InvalidOperationException("Tego konstruktora może używać tylko Visual, nigdy twój kod");

			InitializeComponent();
		}

		public Form1(SharedState state)
		{
			if (state == null) throw new ArgumentNullException("state");
			_state = state;

			InitializeComponent();

			_state.SharedValueChanged += HandleSharedValueChanged;
		}

		private void HandleSharedValueChanged(object sender, EventArgs e)
		{
			// pobierz wartość
			var value = _state.SharedValue;
			// i jakoś jej użyj
			listBox1.Items.Insert(0, String.Format("{0} - {1}", DateTime.Now, value));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var newForm = new Form2(_state);
			newForm.Show();
		}
	}
}