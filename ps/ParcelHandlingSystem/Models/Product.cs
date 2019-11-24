using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    [XmlRoot("Product")]
   public class Product
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Price")]
        public int Price { get; set; }
        [XmlElement("Description")]
        public Description Description { get; set; }
    }

   [XmlRoot("Description")]
   public class Description
   {
        [XmlElement("Color")]
      public string Color
       {
           get;
           set;
       }
        [XmlElement("Size")]
      public string Size
      {
          get;
          set;
      }
   }
}
