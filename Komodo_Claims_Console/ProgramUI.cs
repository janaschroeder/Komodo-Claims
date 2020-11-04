using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Komodo_Claims_Console
{
    class ProgramUI
    {
        Claims_Repo _claims_Repo = new Claims_Repo();
        private Queue<Komodo_Claim> ClaimsDirectory = new Queue<Komodo_Claim>();

        public void Run()
        {
            SeedClaims();
            Menu();
        }

        public void SeedClaims()
        {
            Blank_Claim claim1 = new Blank_Claim(
                             1,
                              ClaimType.Car,
                                "Car accident on 465",
                                        400.00,
                                    new DateTime(2018, 04, 26),
                                    new DateTime(2018, 04, 27));
            ClaimsDirectory.Enqueue(claim1)

    Blank_Claim claim2 = new Blank_Claim(
      2,
      ClaimType.Home,
            "House fire in kitchen",
            4000.00,
new DateTime(2018, 04, 11),
new DateTime(2018, 04, 12)
); ;
            ClaimsDirectory.Enqueue(claim2);

            Blank_Claim claim3 = new Blank_Claim(
                3,
              ClaimType.Theft,
                "Stolen pancakes",
                4.00,
                new DateTime(2018, 04, 11),
                new DateTime(2018, 04, 11)
                );
            ClaimsDirectory.Enqueue(claim3);
        }

        public Blank_Claim Claim1 { get => claim1; set => claim1 = true; }


        private void Menu()
        {
            Console.Clear();
            // is running bool set to true
            Public bool isRunning = true;
            While isRunning = input != 4
                { 
                Console.WriteLine("What would you like to do?\n" +
            "1. Display all pending claims\n" +
            "2. Display the next claim\n" +
            "3. Enter a new Claim\n" +
            "4. Exit\n" +
            "Enter a number.");
            string input = Console.ReadLine();
            Int32.Parse(input)
            switch (input)
                {
                    case "1":
                        GetClaims();
                        break;
                    case "2":
                        GetNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Sorry, that's not a valid response. Please enter a number between 1 and 4.");
                        Console.ReadKey();
                        break;

                        Console.Clear();
                        Menu();
                }

            // Case 1: Get All Claims
            // Console.Clear();

            public void GetClaims() {
            foreach (int id in ClaimsDirectory)
            {
                Console.WriteLine$(id   claimTypes claimAmount   dateOfIncident dateOfClaim   isValid);

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }

        // Case 2: Get Next Claim
        public void GetNextClaim()
        {
            Console.WriteLine("Here is the next claim."\n ClaimsDirectory.Peek());
            Console.ReadKey();
        }


        // Case 3: Add New Claim
        private void AddNewClaim()
        {
            GetStartingCount()
                Blank_Claim claimNew = new Blank_Claim()
            {
                Console.WriteLine("What is The claim ID?");
            string idAsString = Console.ReadLine();
            int idAsInt = int.Parse(idAsString);
            claimNew.ID = idAsInt;

            Console.WriteLine("What type of claim is this? Enter 1 for Car, 2 for House, or 3 for Theft.");
            string claimTypeInput = Console.ReadLine();
            int claimTypeAsInt = int.Parse(claimTypeInput);
            claimNew.ClaimType = (ClaimType)claimTypeAsInt;

            Console.WriteLine("Enter a brief description of the incident.");
            claimNew.Description = Console.ReadLine();

            Console.WriteLine("Enter the claim amount--for example, 400.00.");
            string claimAmountAsString = Console.ReadLine();
            double claimAmountAsDouble = double.Parse(claimAmountAsString);
            claimNew.ClaimAmount = claimAmountAsDouble;
            Console.WriteLine("Date of the incident written as yyyy, mm, dd");
            string dateOfIncidentAsString = Console.ReadLine();
            DateTimedateOfIncidentAsDate = DateTime.Parse(dateOfIncidentAsString);
            claimNew.DateOfIncident  = dateOfIncidentAsDateTime;

            Console.WriteLine("Date the claim was filed written as yyyy, mm, dd")
                        string dateOfClaimAsString = Console.ReadLine();
            DateTime  dateOfClaimAsDate = DateTime.Parse(dateOfClaimAsString);
            claimNew.DateOfClaim = dateOfClaimAsDateTime;

            Console.WriteLine("No need to calculate if the claim was filed in time. The computer will display whether the claim is or is not valid when the list of claims is displayed.")
                            Console.ReadKey()
                // ClaimsDirectory.AddClaimToQueue(claimNew);

            ClaimsDirectory.Enqueue(claimNext);
            CheckIfAdded();

            bool wasAdded = (ClaimsDirectory.Count > startingCount) ? V : false;
            if V
                                Console.WriteLine("Claim successfully added.");
            if false
                        Console.WriteLine("Something went wrong. You will need to re-enter the claim.");
            Console.ReadKey();
        }
    }  
}