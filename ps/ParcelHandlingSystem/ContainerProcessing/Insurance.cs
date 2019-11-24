using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;

namespace ParcelHandlingSystem
{
  
   public class Insurance:IDepartment
    {
       public readonly DataTable insurance;
       public Insurance()
       {
           insurance = new DataTable("InsuranceTable");
           insurance.Columns.Add("SignOff", typeof(bool));
           insurance.Columns.Add("Sender Name");
           insurance.Columns.Add("Sender Address");
           insurance.Columns.Add("Receipint Name");
           insurance.Columns.Add("Receipint Address");
           insurance.Columns.Add("Weight");
           insurance.Columns.Add("Value");
       }

        public DataTable Handler(IEnumerable<Parcel> parcels)
        {
           DataTable dt = CreateInsuranceTable(parcels);
           return dt;
        }
        public DataTable CreateInsuranceTable(IEnumerable<Parcel> parcels )
        {
            DataRow dr = insurance.NewRow();

            foreach(Parcel p in parcels)
            {
                DataRow row = insurance.NewRow();
                row["Sender Name"] = p.Sender.Name;
                row["Sender Address"] = p.Sender.Address.HouseNumber + "-" + p.Sender.Address.Street + "-" +
                                        p.Sender.Address.PostalCode + "-" + p.Sender.Address.City;
                row["Receipint Name"] = p.Receipient.Name;
                row["Receipint Address"] = p.Receipient.Address.HouseNumber + "-" + p.Receipient.Address.Street + "-" +
                                        p.Receipient.Address.PostalCode + "-" + p.Receipient.Address.City;
                row["Weight"] = p.Weight;
                row["Value"] = p.Value;

                insurance.Rows.Add(row);
            }
            return insurance;
        }
    }
}
