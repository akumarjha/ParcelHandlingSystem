using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;

namespace ParcelHandlingSystem
{
    public class Mail: IDepartment
    {
       public readonly DataTable mail;
       public Mail()
       {
           mail = new DataTable("MailTable");
           mail.Columns.Add("Sender Name");
           mail.Columns.Add("Sender Address");
           mail.Columns.Add("Receipint Name");
           mail.Columns.Add("Receipint Address");
           mail.Columns.Add("Weight");
           mail.Columns.Add("Value");
       }

        public DataTable Handler(IEnumerable<Parcel> parcels)
        {
            DataTable dt = CreateMailTable(parcels);
            return dt;
        }
        public DataTable CreateMailTable(IEnumerable<Parcel> parcels)
        {
            DataRow dr = mail.NewRow();

            foreach (Parcel p in parcels)
            {
                DataRow row = mail.NewRow();
                row["Sender Name"] = p.Sender.Name;
                row["Sender Address"] = p.Sender.Address.HouseNumber + "-" + p.Sender.Address.Street + "-" +
                                        p.Sender.Address.PostalCode + "-" + p.Sender.Address.City;
                row["Receipint Name"] = p.Receipient.Name;
                row["Receipint Address"] = p.Receipient.Address.HouseNumber + "-" + p.Receipient.Address.Street + "-" +
                                        p.Receipient.Address.PostalCode + "-" + p.Receipient.Address.City;
                row["Weight"] = p.Weight;
                row["Value"] = p.Value;

                mail.Rows.Add(row);
            }
            return mail;
        }
    }
}
