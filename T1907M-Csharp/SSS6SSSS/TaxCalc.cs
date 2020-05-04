using System;

namespace buoi2.SSS6SSSS
{
    public delegate float TaxMoney(float salary);
    public class TaxCalc
    {
        public static float vietNam(float salary)
        {
            return 10 * salary / 100;
        }
        public static float NuocNgoai(float salary)
        {
            return 15 * salary / 100;
        }
        public static float Other(float salary)
        {
            return 5 * salary / 100;
        }
//viet ham tra ve 1 ham 

        public static TaxMoney GetTax(string country)
        {
            if (country == "VN")
            {
                return vietNam;
            }else if (country == "Us")
            {
                return NuocNgoai;
            }
            else
            {
                return Other;
            }
        }
    }
}