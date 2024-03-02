namespace _01Tsymbal;

using System;
using System.ComponentModel;

public class ViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public event ValidateDateInputHandler? ValidateDateInput;
    private Model _model;

    public ViewModel(ValidateDateInputHandler? errorHandler)
    {
        _model = new Model();
        ValidateDateInput += errorHandler;
    }

    private void OnPropertyChange(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public DateTime BirthDate
    {
        get { return _model.BirthDate; }
        set
        {
            if (_model.BirthDate != value)
            {
                _model.BirthDate = value;
                OnPropertyChange("BirthDate");
                OnPropertyChange("Age");
                OnPropertyChange("AsianSing");
                OnPropertyChange("WesternSing");
                OnPropertyChange("AsianSignString");
                OnPropertyChange("WesternSignString");
            }
        }
    }

    private void OnDataInputValidate(string errorMsg)
    {
        if (ValidateDateInput != null)
        {
            ValidateDateInput(this, new DateInputValidator(errorMsg));
        }
    }

    public string WesternSignString
    {
        get { return SignDetector.GetWesternSigns(BirthDate); }
    }

    public string AsianSignString
    {
        get { return SignDetector.GetAsianSigns(BirthDate); }
    }

    public int Age
    {
        get
        {
            DateTime currDay = DateTime.Today;
            int age = currDay.Year - _model.BirthDate.Year;
            if (_model.BirthDate > currDay.AddYears(-age)) age--;
            
            if (age < 0 || age > 135)
            {
                OnDataInputValidate("Impossible age!");
                age = age < 0 ? 0 : 135;
            }

            if (_model.BirthDate.Month == currDay.Month && _model.BirthDate.Day == currDay.Day)
            {
                OnDataInputValidate("Happy birthday!");
            }

            return age;
        }
    }
}