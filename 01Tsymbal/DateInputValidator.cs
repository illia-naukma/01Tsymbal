namespace _01Tsymbal;

public class DateInputValidator
{
    public string ErrorMsg { get; }

    public DateInputValidator(string errorMsg)
    {
        ErrorMsg = errorMsg;
    }
}

public delegate void ValidateDateInputHandler(object? sender, DateInputValidator e);
