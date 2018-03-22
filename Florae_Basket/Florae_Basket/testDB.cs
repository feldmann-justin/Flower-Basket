using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florae_Basket
{
    public class FlowerInfo : IEquatable<FlowerInfo>
    {
        public int primaryKey { get; set; }
        public string EnglishName { get; set; }
        public string LatinName { get; set; }
        public string BotFamily { get; set; }

        public bool Equals(FlowerInfo other)
        {
            if (other == null) return false;
            return (this.primaryKey.Equals(other.primaryKey));
        }
    }

    class testDB
    {
        static int key = 0;
        static List<FlowerInfo> flowers = new List<FlowerInfo>();
        public void addIt(string eng, string lat, string bot)
        {
            key++;
            flowers.Add(new FlowerInfo() { primaryKey = key, EnglishName = eng, LatinName = lat, BotFamily = bot });
        }

        public void deleteIt(int id)
        {
            key--;
            flowers.RemoveAt(id);
        }

       public int getFlowerAmount()
        {
            return key;
        }

        public string getFlowerEng(int id)
        {
            return flowers[id].EnglishName;
        }
        public string getFlowerLat(int id)
        {
            return flowers[id].LatinName;
        }
        public string getFlowerBot(int id)
        {
            return flowers[id].BotFamily;
        }
    }
}
