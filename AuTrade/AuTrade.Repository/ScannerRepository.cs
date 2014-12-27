using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AuTrade.Domain;
using System.Data.OleDb;
using System.Configuration;

namespace AuTrade.Repository
{
    public class ScannerRepository
    {

        public static List<ScannerEntity> GetAllRecord()
        {
            List<ScannerEntity> scannerEntityListInstance = new List<ScannerEntity>();

            string sqlCommand = "SELECT * FROM Scanner";

            OleDbConnection oleDbConnectionInstance = new OleDbConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
            OleDbCommand oleDbCommandInstance = new OleDbCommand(sqlCommand, oleDbConnectionInstance);

            oleDbConnectionInstance.Open();

            var oleDbReader = oleDbCommandInstance.ExecuteReader();

            try
            {

                while (oleDbReader.Read())
                {
                    ScannerEntity scannerEntityInstance = new ScannerEntity();

                    scannerEntityInstance.ScannerId = Convert.ToInt32(oleDbReader["ID"].ToString());
                    scannerEntityInstance.ScannerName = oleDbReader["ScannerName"].ToString();
                    scannerEntityInstance.ScanCode = Convert.ToInt32(oleDbReader["ScanCode"].ToString());
                    scannerEntityInstance.InstrumentType = Convert.ToInt32(oleDbReader["InstrumentType"].ToString());
                    scannerEntityInstance.LocationType = oleDbReader["LocationType"].ToString();
                    scannerEntityInstance.StockTypeFilter = Convert.ToInt32(oleDbReader["StockTypeFilter"].ToString());
                    scannerEntityInstance.MinPrice = Convert.ToInt32(oleDbReader["MinPrice"].ToString());
                    scannerEntityInstance.MaxPrice = Convert.ToInt32(oleDbReader["MaxPrice"].ToString());
                    scannerEntityInstance.MarketCapAbove = Convert.ToInt32(oleDbReader["MarketCapAbove"].ToString());
                    scannerEntityInstance.MarketCapBelow = Convert.ToInt32(oleDbReader["MarketCapBelow"].ToString());
                    scannerEntityInstance.Enabled = Convert.ToBoolean(oleDbReader["Enabled"].ToString());

                    scannerEntityListInstance.Add(scannerEntityInstance);
                }
            }
            catch (Exception exception)
            {

                oleDbReader.Close();
                oleDbConnectionInstance.Close();

                throw exception;

            }

            return scannerEntityListInstance;
        }

    }
}
