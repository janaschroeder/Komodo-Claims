using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims_Repo
{
    using ClaimsDirectory
{
    public class Claims_Repo

    {
        {public void GetStartingCount()
            int startingCount = ClaimsDirectory.Count();
        ClaimsDirectory.Enqueue(Blank_Claim);

            CheckIfAdded();
        bool wasAdded = (ClaimsDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
    public void GetStartingCount()
                           .KeyChar.ToString int startingCount = ClaimsDirectory.Count();
}
    }
}