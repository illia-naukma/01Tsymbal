namespace _01Tsymbal;

public class SignDetector
{
    public static string GetWesternSigns(DateTime? birthDate)
    {
        if (birthDate == null)
            return string.Empty;

        int month = birthDate.Value.Month;
        int day = birthDate.Value.Day;

        if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
        {
            return "ARIES";
        }

        if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
        {
            return "TAURUS";
        }

        if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
        {
            return "GEMINI";
        }

        if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
        {
            return "CANCER";
        }

        if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
        {
            return "LEO";
        }

        if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
        {
            return "VIRGO";
        }

        if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
        {
            return "LIBRA";
        }

        if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
        {
            return "SCORPIUS";
        }

        if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
        {
            return "SAGITTARIUS";
        }

        if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
        {
            return "CAPRICORN";
        }

        if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
        {
            return "AQUARIUS";
        }

        if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
        {
            return "PISCES";
        }

        return "Impossible date";
    }

    public static string GetAsianSigns(DateTime? birthDate)
    {
        if (birthDate == null)
            return string.Empty;

        int asianHoroscopeIndex = (birthDate.Value.Year - 4) % 12;

        switch (asianHoroscopeIndex)
        {
            case 0:
                return "Rat";
            case 1:
                return "Ox";
            case 2:
                return "Tiger";
            case 3:
                return "Rabbit";
            case 4:
                return "Dragon";
            case 5:
                return "Snake";
            case 6:
                return "Horse";
            case 7:
                return "Goat";
            case 8:
                return "Monkey";
            case 9:
                return "Rooster";
            case 10:
                return "Dog";
            case 11:
                return "Pig";
            default:
                return "Impossible date";
        }
    }
}