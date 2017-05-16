using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        public Company()
        {
        }


        private string companyName;
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }


        private int companyAge = 2;
        public int CompanyAge
        {
            get { return companyAge; }
        }


        private string companyPurpose;
        public string CompanyPurpose
        {
            get { return companyPurpose; }
            set { companyPurpose = value; }
        }


        private bool companyIsProfitable;
        public bool CompanyIsProfitable
        {
            get { return companyIsProfitable; }
            set { companyIsProfitable = value; }
        }

        private bool companyIsSuccessful;
        public bool CompanyIsSuccessful
        {
            get
            {
                if (companyAge > 1 && companyIsProfitable == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
