namespace _01Tsymbal;

public class Model
{
    public DateTime BirthDate { get; set; }

    public Model()
    {
        BirthDate = DateTime.Now.AddDays(-1);
    }

    public string AsianSign { get; set; }
    public string WesternSign { get; set; }
}