using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI;

public static class Methods
{
    public static List<GuestModel> guests = new List<GuestModel>();
    public static void GetGuestInformation()
    {
        string moreGuestsComing = "";

        do
        {
            GuestModel guest = new GuestModel();

            guest.FirstName = GetInfoFromConsole("What is your first name: ");
            guest.LastName = GetInfoFromConsole("What is your last name: ");
            guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
            moreGuestsComing = GetInfoFromConsole("Are more guests coming (yes/no): ");

            guests.Add(guest);

            Console.Clear();
        } while (moreGuestsComing.ToLower() == "yes");
    }

    public static void PrintGuestInformation()
    {
        foreach (GuestModel guest in guests)
        {
            Console.WriteLine(guest.GuestInfo);
        }
    }

    public static string GetInfoFromConsole(string message)
    {
        string output = "";

        Console.Write(message);
        output = Console.ReadLine();

        return output;
    }
}
