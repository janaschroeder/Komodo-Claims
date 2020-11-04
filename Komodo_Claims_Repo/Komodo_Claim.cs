using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsDirectory
{
    public enum ClaimType
    { Car = 1, Home, Theft }

    public class Komodo_Claim
    {
        public int ID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public int DaysTookToFile
        {
            get
            { return (int)(DateOfClaim - DateOfIncident).TotalDays; }
        }
        public bool IsValid
        {
            get
            { return DaysTookToFile <= 30 == true; }
        }
        public int StartingCount { get; set; }
        public Blank_Claim() { get; set; }
        public Blank_Claim(int id, ClaimType claimType, string description, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, int startingCount, int daysTookToFile, bool isValid)
        {
            ID = id;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            StartingCount = startingCount;
            DaysTookToFile = daysTookToFile;
        }
    }
}
