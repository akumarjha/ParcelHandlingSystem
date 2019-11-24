using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;

namespace ParcelHandlingSystem
{
    public class Heavy:IDepartment
    {
       public readonly DataTable heavy;
       public Heavy()
       {
           heavy = new DataTable("HeavyTable");
           heavy.Columns.Add("Sender Name");
           heavy.Columns.Add("Sender Address");
           heavy.Columns.Add("Receipint Name");
           heavy.Columns.Add("Receipint Address");
           heavy.Columns.Add("Weight");
           heavy.Columns.Add("Value");
       }
        public DataTable Handler(IEnumerable<Parcel> parcels)
        {
            DataTable dt = CreateHeavyTable(parcels);
            return dt;
        }
        public DataTable CreateHeavyTable(IEnumerable<Parcel> parcels)
        {
            DataRow dr = heavy.NewRow();

            foreach (Parcel p in parcels)
            {
                DataRow row = heavy.NewRow();
                row["Sender Name"] = p.Sender.Name;
                row["Sender Address"] = p.Sender.Address.HouseNumber + "-" + p.Sender.Address.Street + "-" +
                                        p.Sender.Address.PostalCode + "-" + p.Sender.Address.City;
                row["Receipint Name"] = p.Receipient.Name;
                row["Receipint Address"] = p.Receipient.Address.HouseNumber + "-" + p.Receipient.Address.Street + "-" +
                                        p.Receipient.Address.PostalCode + "-" + p.Receipient.Address.City;
                row["Weight"] = p.Weight;
                row["Value"] = p.Value;

                heavy.Rows.Add(row);
            }
            return heavy;
        }
    }
}
