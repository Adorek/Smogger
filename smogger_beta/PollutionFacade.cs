using smogger_beta.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace smogger_beta
{
    public class PollutionFacade
    {

        //private const int Niewiem = 00;    

        public static async Task PopulateDaneActualAsync(ObservableCollection<Actual> daneActual)
        {
            try
            {

                var actualDataWrapper = await GetPollutionDataWrapperAsync();

                var pomiaryactual = actualDataWrapper.dane.actual;

                foreach (var actualValue in pomiaryactual)
                {
                    actualValue.station_max = String.Format("ms-appx:///Assets/icoMax{0}.png", actualValue.station_max);

                    daneActual.Add(actualValue);
                }

            }
            catch (Exception)
            {

                return;
            }
        }


        public static async Task PopulateDemoActualAsync(ObservableCollection<Detail> daneDetail)
        {
            try
            {

                var detailDataWrapper = await GetPollutionDataWrapperAsync();

                var pomiarydetail = detailDataWrapper.dane.actual[0].details;

                foreach (var detailValue in pomiarydetail)
                {
                    daneDetail.Add(detailValue);
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        private static async Task<PollutionDataWrapper> GetPollutionDataWrapperAsync()
        {

            var sityID = WybraneMiasto();


            string url = String.Format("http://powietrze.malopolska.pl/_powietrzeapi/api/dane?act=danemiasta&ci_id={0}", sityID);


            var jsonMessage = await CallWEBAsync(url);

            // Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(PollutionDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage)); 

            var result = (PollutionDataWrapper)serializer.ReadObject(ms);
            return result;

        }
        private async static Task<string> CallWEBAsync(string url)
        {

            var sityID = WybraneMiasto();

            string completeUrl = String.Format("http://powietrze.malopolska.pl/_powietrzeapi/api/dane?act=danemiasta&ci_id={0}", sityID);

            HttpClient http = new HttpClient();
            var response = await http.GetAsync(completeUrl);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            var serializer = new DataContractJsonSerializer(typeof(PollutionDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (PollutionDataWrapper)serializer.ReadObject(ms);
            return await response.Content.ReadAsStringAsync();
        }
        
        private static int WybraneMiasto()
        {

            ApplicationDataContainer roamingSettings = null;

            const string chosenLoaction = "chosenCity";

            roamingSettings = ApplicationData.Current.RoamingSettings;

            Object value = roamingSettings.Values[chosenLoaction];

            return ((int)value);

        }

    }
}
