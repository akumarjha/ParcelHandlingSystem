using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;

namespace ParcelHandlingSystem
{
    public class Regular: IDepartment
    {
       public readonly DataTable regular;
       public Regular()
       {
           regular = new DataTable("RegularTable");
           regular.Columns.Add("Sender Name");
           regular.Columns.Add("Sender Address");
           regular.Columns.Add("Receipint Name");
           regular.Columns.Add("Receipint Address");
           regular.Columns.Add("Weight");
           regular.Columns.Add("Value");
       }
        public DataTable Handler(IEnumerable<Parcel> parcels)
        {
            DataTable dt = CreateRegularTable(parcels);
            return dt;
        }
        public DataTable CreateRegularTable(IEnumerable<Parcel> parcels)
        {
            DataRow dr = regular.NewRow();

            foreach (Parcel p in parcels)
            {
                DataRow row = regular.NewRow();
                row["Sender Name"] = p.Sender.Name;
                row["Sender Address"] = p.Sender.Address.HouseNumber + "-" + p.Sender.Address.Street + "-" +
                                        p.Sender.Address.PostalCode + "-" + p.Sender.Address.City;
                row["Receipint Name"] = p.Receipient.Name;
                row["Receipint Address"] = p.Receipient.Address.HouseNumber + "-" + p.Receipient.Address.Street + "-" +
                                        p.Receipient.Address.PostalCode + "-" + p.Receipient.Address.City;
                row["Weight"] = p.Weight;
                row["Value"] = p.Value;

                regular.Rows.Add(row);
            }
            return regular;
        }
    }
}
