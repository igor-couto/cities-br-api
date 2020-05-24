namespace CitiesBr.Schema 
{
    public class CityRequest
    {
        public string Name {get; set;}
        public string Population {get; set;}
        public bool? IsCapital {get; set;}
        public string State {get; set;}
        public string StateAbbreviation {get; set;}
        public int? MaxResultCount {get; set;}
        public bool? Random {get; set;}
        public bool? RandomStatistic {get; set;} 
    }    
}
