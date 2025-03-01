using System.Text;

namespace SortDelegate_Base
{
    internal class StringHelper
    {
        static readonly char delimiter = '-';

        public static string GetDisplayString(IEnumerable<int> nums)
        {
            StringBuilder sb = new StringBuilder();
            bool isFirst = false;

            foreach (int sco in nums)
            {

                if (isFirst)
                {
                  sb.Append(delimiter.ToString() + sco);

                }
                else
                {
                    
                    sb.Append(sco);
                    isFirst = true;
                }
            }

            return sb.ToString();
        }
    }
}
