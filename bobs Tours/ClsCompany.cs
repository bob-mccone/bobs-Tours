using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace bobs_Tours
{
    [Serializable]      //Preparing the class for saving
    class ClsCompany    //Name of the class
    {
        private static Dictionary<string, ClsTour> _TourList = new Dictionary<string, ClsTour>();   //Turns the list into a dictionary that is read only by commenting out the set

        public static Dictionary<string, ClsTour> TourList
        {
            get { return ClsCompany._TourList; }
            //set { ClsCompany._TourList = value; }
        }

        public static void Save()   //Save function
        {
            using (FileStream lcFileStream = new FileStream("Tours.dat", FileMode.Create))  //Creates the file
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();    //declares and instantiates the binary formatter
                lcFormatter.Serialize(lcFileStream, _TourList);     //Carrying out the saving
            }
        }

        public static void Retrieve()   //Retrieve function
        {
            using (FileStream lcFileStream = new FileStream("Tours.dat", FileMode.Open))    //Opens the file
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();    //same as above
                _TourList = (Dictionary<String, ClsTour>)       //Carrying out the retrieving
                    lcFormatter.Deserialize(lcFileStream);
            }
        }
    }
}
