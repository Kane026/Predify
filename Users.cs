using System;
using System.Collections.Generic;
using System.Text;

namespace Predify
{
    public class Users
    {
        List<string> users = new List<string>
        {
            "Dylan",
            "Kane",
            "Emile"
        };

        List<string> friends = new List<string>();

        public void ShowUsers()
        {
            Console.WriteLine("Gebruikers:");
            for (int i = 0; i < users.Count; i++)
                Console.WriteLine($"{i + 1}. {users[i]}\n");
        }

        public void AddFriend()
        {
            Console.WriteLine("Voeg vriend toe:");
            for (int i = 0; i < users.Count; i++)
                Console.WriteLine($"{i + 1}. {users[i]}");
            string friendName = Console.ReadLine();
            if (int.TryParse(friendName, out int keuze) && keuze >= 1 && keuze <= users.Count)
            {
                string vriend = users[keuze - 1];
                friends.Add(vriend);
                Console.WriteLine($"{vriend} is toegevoegd als vriend!\n");
            }
            else
            {
                Console.WriteLine("Ongeldige keuze.");
            }
        }
        

        public void RemoveFriend() {
            Console.WriteLine("Voeg vriend toe:");
            for (int i = 0; i < friends.Count; i++)
                Console.WriteLine($"{i + 1}. {friends[i]}");
            string friendName = Console.ReadLine();
            if (int.TryParse(friendName, out int keuze) && keuze >= 1 && keuze <= friends.Count)
            {
                string vriend = friends[keuze - 1];
                friends.Remove(vriend);
                Console.WriteLine($"{vriend} is verwijderd als vriend!\n");
            }
            else
            {
                Console.WriteLine("Ongeldige keuze.");
            }
        }

        public void ShowFriends() {
            Console.WriteLine("\nVrienden:");
            for (int i = 0; i < friends.Count; i++)
                Console.WriteLine($"{i + 1}. {friends[i]}\n");
        }
    }
}
