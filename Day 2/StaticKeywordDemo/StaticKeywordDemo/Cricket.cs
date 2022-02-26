using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordDemo
{
    internal class Cricket
    {
         static int score;
        public void totalScore(int x)
        {
            score = score + x;
        }

        static void Main(string[] args)
        {
            Cricket vk = new Cricket();
            Cricket rs = new Cricket();
            Cricket hs = new Cricket();

            vk.totalScore(72);
            rs.totalScore(40);
            hs.totalScore(10);

            Console.WriteLine("Total score by the team = {0}", Cricket.score);
        }
    }
}
