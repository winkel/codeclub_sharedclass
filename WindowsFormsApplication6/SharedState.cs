using System;

namespace WindowsFormsApplication6
{
	public class SharedState
	{
		private string _sharedValue;

		public event EventHandler SharedValueChanged = delegate { };

		public string SharedValue
		{
			get { return _sharedValue; }
			set
			{
				if (_sharedValue != value)
				{
					_sharedValue = value;
					OnSharedValueChanged();
				}
			}
		}

		private void OnSharedValueChanged()
		{
			var handler = SharedValueChanged;
			if (handler != null)
				handler(this, EventArgs.Empty);
		}
	}
}