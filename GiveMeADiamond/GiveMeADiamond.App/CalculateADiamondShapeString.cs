using System;
using System.Text;

namespace GiveMeADiamond.App
{
    public class CalculateADiamondShapeString : ICalculateADiamondShapeString
    {
        public string printDiamondShapeString(int n)
        {
            if(!(n <= 0|| n % 2 == 0))
            {
                var stringToReturn = new StringBuilder();
                int middleNo = (int) Math.Floor((decimal)n / 2) + 1;
                int count = middleNo - 1;

                for (int i = 1; i <= middleNo; i++)
                {
                    for (int j = 1; j <= count ; j++)
                    {
                        stringToReturn.Append(" ");
                    }
                    count--;
                    for (int j = 1 ; j <= 2* i - 1; j++)
                    {
                        stringToReturn.Append("*");
                    }
                    stringToReturn.Append("\n");
                }

                count = 1;
                for (int i = 1; i <= middleNo - 1 ; i++)
                {
                    for (int j = 1; j <= count; j++)
                    {
                        stringToReturn.Append(" ");
                    }
                    count++;
                    for (int j = 1; j <= 2 * (middleNo - i) - 1; j++)
                    {
                        stringToReturn.Append("*");
                    }
                    stringToReturn.Append("\n");
                }

                return stringToReturn.ToString();
            }

            return null;
        }
    }
}
