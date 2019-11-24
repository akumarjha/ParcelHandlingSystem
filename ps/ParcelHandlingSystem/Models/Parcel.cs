using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    public class Container
    {
        public int Id
        {
            get;
            set;
        }
        public DateTime ShippingDate
        {
            get;
            set;
        }
        //public Container()
        //{
        //    Parcels = new List<Parcel>();
        //}
        public List<Parcel> parcels
        {
            get;
            set;
        }
    }
    public class Parcel
    {
        public Sender Sender
        {
            get;
            set;
        }
        public Receipient Receipient
        {
            get;
            set;
        }
        //[XmlElement]
        public double Weight
        {
            get;
            set;
        }
        //[XmlElement]
        public double Value
        {
            get;
            set;
        }
        
    }


}
