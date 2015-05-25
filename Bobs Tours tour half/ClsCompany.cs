using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace bobs_Tours_tour_half
{
    [Serializable]
    class ClsCompany
    {
        private static Dictionary<string, ClsTours> _TourList = new Dictionary<string, ClsTours>();

        public static Dictionary<string, ClsTours> TourList
        {
            get { return ClsCompany._TourList; }
            //set { ClsCompany._TourList = value; }
        }

        public static void Save()
        {
            using (FileStream lcFileStream = new FileStream("Tours.dat", FileMode.Create))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, _TourList);
            }
        }

        public static void Retrieve()
        {
            using (FileStream lcFileStream = new FileStream("Tours.dat", FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                _TourList = (Dictionary<String, ClsTours>)
                    lcFormatter.Deserialize(lcFileStream);
            }
        }
    }
}
