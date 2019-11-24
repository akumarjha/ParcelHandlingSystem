using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    //[XmlRoot("Address")]
    public class Address
    {
        //[XmlElement]
        public string Street
        {
            get;
            set;
        }
        //[XmlElement]
        public int HouseNumber
        {
            get;
            set;
        }
        //[XmlElement]
        public string PostalCode
        {
            get;
            set;
        }
        //[XmlElement]
        public string City
        {
            get;
            set;
        }
    }

    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //[XmlRoot("Sender")]

    //[Serializable()] 
    //[XmlRoot("Sender")]
    //[XmlInclude(typeof(Company))]
    public class Sender
    {
        //[XmlElement]
        public string Name
        {
            get;
            set;
        }
        //[XmlElement("Address")]
        public Address Address
        {
            get;
            set;
        }
        //[XmlElement]
        public string CcNumber
        {
            get;
            set;
        }
    }

    //[XmlRoot(ElementName = "Sender", Namespace="http://www.w3.org/2001/XMLSchema-instance")]
    public class Company:Sender
    {
    }

    [XmlInclude(typeof(Company))]
    [XmlRoot("Sender")]
    //public class Books : List<Book> { }

    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //[XmlRoot("Receipient")]
    public class Receipient
    {
        //[XmlElement]
        public string Name
        {
            get;
            set;
        }
        //[XmlElement("Address")]
        public Address Address
        {
            get;
            set;
        }
    }

}
