using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smogger_beta.Models
{

    public class City
    {
        public string ci_id { get; set; }
        public string co_id { get; set; }
        public string reg_id { get; set; }
        public string ci_name { get; set; }
        public string ci_county { get; set; }
        public string ci_countydesc { get; set; }
        public string ci_city { get; set; }
        public string ci_citydesc { get; set; }
        public string ci_location { get; set; }
        public string ci_locationdesc { get; set; }
        public string ci_lat { get; set; }
        public string ci_long { get; set; }
        public string ci_locationtype { get; set; }
        public string ci_locationparameters { get; set; }
        public string g_index { get; set; }
        public string aqi_id { get; set; }
        public string caqi_id { get; set; }
    }

    public class Detail
    {
        public string o_id { get; set; }
        public string o_station { get; set; }
        public string st_id { get; set; }
        public string o_interval { get; set; }
        public string o_wskaznik { get; set; }
        public string par_id { get; set; }
        public int o_value { get; set; }
        public string o_czas { get; set; }
        public string o_time { get; set; }
        public string g_id { get; set; }
        public string g_index { get; set; }
        public string caqi_value { get; set; }
        public string caqi_id { get; set; }
        public string aqi_value { get; set; }
        public string aqi_id { get; set; }
        public string g_min_val { get; set; }
        public string g_max_val { get; set; }
        public string g_nazwa { get; set; }
        public string par_name { get; set; }
        public string par_desc { get; set; }
        public string par_unit { get; set; }
        public string par_html { get; set; }
        public string parorder { get; set; }
        public string max { get; set; }
    }

    public class Actual
    {
        public string station_id { get; set; }
        public string station_name { get; set; }
        public int station_hour { get; set; }
        public string station_max { get; set; }
        public List<Detail> details { get; set; }
    }

    public class Average
    {
        public string cf_id { get; set; }
        public string ci_id { get; set; }
        public string cf_type { get; set; }
        public string cf_date { get; set; }
        public string cf_max { get; set; }
        public string g_index { get; set; }
        public string caqi_value { get; set; }
        public string caqi_id { get; set; }
        public string aqi_value { get; set; }
        public string aqi_id { get; set; }
        public string cf_details { get; set; }
        public string max { get; set; }
    }

    public class Detail2
    {
        public string fo_id { get; set; }
        public string ci_id { get; set; }
        public string par_id { get; set; }
        public string fo_nazwa { get; set; }
        public string fo_date { get; set; }
        public string fo_time { get; set; }
        public string fo_interval { get; set; }
        public string fo_wskaznik { get; set; }
        public string fo_wartosc { get; set; }
        public string g_id { get; set; }
        public string g_index { get; set; }
        public string caqi_value { get; set; }
        public string caqi_id { get; set; }
        public string aqi_value { get; set; }
        public string aqi_id { get; set; }
        public string par_name { get; set; }
        public string par_desc { get; set; }
        public string par_unit { get; set; }
        public string par_html { get; set; }
        public string parorder { get; set; }
        public int fca_avg_value { get; set; }
        public string max { get; set; }
    }

    public class Wczoraj
    {
        public List<Average> averages { get; set; }
        public string max { get; set; }
        public List<Detail2> details { get; set; }
    }

    public class Average2
    {
        public string cf_id { get; set; }
        public string ci_id { get; set; }
        public string cf_type { get; set; }
        public string cf_date { get; set; }
        public string cf_max { get; set; }
        public string g_index { get; set; }
        public string caqi_value { get; set; }
        public string caqi_id { get; set; }
        public string aqi_value { get; set; }
        public string aqi_id { get; set; }
        public string cf_details { get; set; }
        public string max { get; set; }
    }

    public class Detail3
    {
        public string fo_id { get; set; }
        public string ci_id { get; set; }
        public string par_id { get; set; }
        public string fo_nazwa { get; set; }
        public string fo_date { get; set; }
        public string fo_time { get; set; }
        public string fo_interval { get; set; }
        public string fo_wskaznik { get; set; }
        public string fo_wartosc { get; set; }
        public string g_id { get; set; }
        public string g_index { get; set; }
        public string caqi_value { get; set; }
        public string caqi_id { get; set; }
        public string aqi_value { get; set; }
        public string aqi_id { get; set; }
        public string par_name { get; set; }
        public string par_desc { get; set; }
        public string par_unit { get; set; }
        public string par_html { get; set; }
        public string parorder { get; set; }
        public int fca_avg_value { get; set; }
        public string max { get; set; }
    }

    public class Dzisiaj
    {
        public List<Average2> averages { get; set; }
        public string max { get; set; }
        public List<Detail3> details { get; set; }
    }

    public class Average3
    {
        public string cf_id { get; set; }
        public string ci_id { get; set; }
        public string cf_type { get; set; }
        public string cf_date { get; set; }
        public string cf_max { get; set; }
        public string g_index { get; set; }
        public string caqi_value { get; set; }
        public string caqi_id { get; set; }
        public string aqi_value { get; set; }
        public string aqi_id { get; set; }
        public string cf_details { get; set; }
        public string max { get; set; }
    }

    public class Detail4
    {
        public string fo_id { get; set; }
        public string ci_id { get; set; }
        public string par_id { get; set; }
        public string fo_nazwa { get; set; }
        public string fo_date { get; set; }
        public string fo_time { get; set; }
        public string fo_interval { get; set; }
        public string fo_wskaznik { get; set; }
        public string fo_wartosc { get; set; }
        public string g_id { get; set; }
        public string g_index { get; set; }
        public string caqi_value { get; set; }
        public string caqi_id { get; set; }
        public string aqi_value { get; set; }
        public string aqi_id { get; set; }
        public string par_name { get; set; }
        public string par_desc { get; set; }
        public string par_unit { get; set; }
        public string par_html { get; set; }
        public string parorder { get; set; }
        public int fca_avg_value { get; set; }
        public string max { get; set; }
    }

    public class Jutro
    {
        public List<Average3> averages { get; set; }
        public string max { get; set; }
        public List<Detail4> details { get; set; }
    }

    public class Pojutrze
    {
        public List<object> averages { get; set; }
        public int max { get; set; }
        public List<object> details { get; set; }
    }

    public class Forecast
    {
        public Wczoraj wczoraj { get; set; }
        public Dzisiaj dzisiaj { get; set; }
        public Jutro jutro { get; set; }
        public Pojutrze pojutrze { get; set; }
    }

    public class Message
    {
        public int type { get; set; }
        public string message { get; set; }
    }

    public class DetailDataWrapper
    {
        public City city { get; set; }
        public List<Actual> actual { get; set; }
        public Forecast forecast { get; set; }
        public Message message { get; set; }
    }

    public class PollutionDataWrapper
    {
        public DetailDataWrapper dane { get; set; }
    }
}
