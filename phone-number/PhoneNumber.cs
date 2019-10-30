using System;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        char[] charactersToRemove = { '+', '-', '.', ' ', '(', ')' };

        foreach (char chaff in charactersToRemove)
        {
            while (phoneNumber.Contains(chaff))
            {
                phoneNumber = phoneNumber.Remove(phoneNumber.IndexOf(chaff), 1);
            }
        }

        if (phoneNumber.Length == 11)
        {
            if (phoneNumber.StartsWith('1'))
                phoneNumber = phoneNumber.Substring(1);
            else
                throw new ArgumentException();
        }

        if (phoneNumber.Length != 10)
            throw new ArgumentException();

        if (phoneNumber.Substring(0, 1) == "0" || phoneNumber.Substring(0, 1) == "1" ||
            phoneNumber.Substring(3, 1) == "0" || phoneNumber.Substring(3, 1) == "1")
            throw new ArgumentException();
        else
            return phoneNumber;

    }
}