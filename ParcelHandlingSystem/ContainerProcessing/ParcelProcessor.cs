using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Models;
using System.IO;
using System.Data;


namespace ParcelHandlingSystem
{
    public class ParcelProcessor
    {
        public const string ConfigFileName = "Container_68465468.xml";
        public Container container;
        public static DataTable tblInsurance;
        public static DataTable tblMail;
        public static DataTable tblRegular;
        public static DataTable tblHeavy;

        public void ReadXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Container));
            StreamReader reader = new StreamReader(Path.Combine(Common.ApplicationPath, ConfigFileName));

            container = (Container)serializer.Deserialize(reader);
            List<Parcel> allParcels = container.parcels;

            var parcelUpToOneKG = from belowoneKg in allParcels
                                  where belowoneKg.Weight <= 1 && belowoneKg.Value <= 1000
                                  select belowoneKg;

            var parcelUpToTenKG = from belowtenKg in allParcels
                                  where belowtenKg.Weight > 1 && belowtenKg.Weight <= 10 && belowtenKg.Value <= 1000
                                  select belowtenKg;

            var parcelOverTenKG = from overtenKg in allParcels
                                  where overtenKg.Weight > 10 && overtenKg.Value <= 1000
                                  select overtenKg;

            var parcelOverThoushand = from overThoushand in allParcels
                                      where overThoushand.Value > 1000
                                      select overThoushand;

            IDepartment insurance = new Insurance();
            tblInsurance = insurance.Handler(parcelOverThoushand);
            IDepartment mail = new Mail();
            tblMail = mail.Handler(parcelUpToOneKG);
            IDepartment regular = new Regular();
            tblRegular = regular.Handler(parcelUpToTenKG);
            IDepartment heavy = new Heavy();
            tblHeavy = heavy.Handler(parcelOverTenKG);
        }
    }
}
