using System;
using System.Collections.Generic;
using System.Linq;

namespace Security
{
    public class Manager : Person
    {
        List<Client> clients = new List<Client>();

        public Manager(string firstName, string lastName, int idNumber) : base(firstName, lastName, idNumber)
        {
        }

        public void AddClient(Client client)
        {
            this.clients.Add(client);
        }

        public Client GetClientByName(string firstName, string lastName)
        {
            var allResults = this.clients.Where(client => client.FirstName.Equals(firstName) && client.LastName.Equals(lastName)).ToList();

            switch (allResults.Count)
            {
                case 0:
                    throw new Exception($"No client with name = {firstName} and lastName = {lastName}");
                case 1:
                    return allResults.First();
                default:
                    throw new Exception($"More than one client with name = {firstName} and lastName = {lastName}");

            }
        }


    }
}
