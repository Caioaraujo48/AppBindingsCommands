using System;
using System.ComponenteModel;
using System.ComponenteModel.Implement.Interface;


public class UsuarioViewModel : INotifyPropertyChanged
{
	public event PropertyChangedEvenHandler PropertyChanged;
	
	void OnPropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
	private string name = string.Empty;

	public string Name
	{
		get => name;
		set
		{
			if (name == null)
				return;

			name = value;
			OnPropertyChanged(nameof(name));
			OnPropertyChanged(nameof(DisplayName));
		}
	}
}
