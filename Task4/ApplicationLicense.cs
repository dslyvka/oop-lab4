using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class ApplicationLicense
    {
        public bool Common { get; set; }
        public bool Trial { get; set; }
        public bool Pro { get; set; }

        public string TrialKey { get; set; }
        public string ProKey { get; set; }

        public ApplicationLicense(string key)
        {
            this.TrialKey = "Trial";
            this.ProKey = "Pro";

            switch (key)
            {
                case "Trial":
                    this.AllowTrial();
                    break;

                case "Pro":
                    this.AllowPro();
                    break;

                default:
                    this.AllowCommon();
                    break;
            }
        }

        public void AllowCommon()
        {
            this.Common = true;
            Console.WriteLine("Incorrect license key. Your application license is Common.");
        }

        public void AllowTrial()
        {
            this.Trial = true;
            this.Common = false;
            Console.WriteLine("Your application license is Trial");
        }

        public void AllowPro()
        {
            this.Pro = true;
            this.Common = false;
            Console.WriteLine("Your application license is Pro");
        }

    }
}
