namespace CitiesBR.API.Schema 
{
    public class SearchRequest
    {
        // public string Name {get; set;}
        // public string Population {get; set;}
        // public bool? IsCapital {get; set;}
        // public string State {get; set;}
        // public string StateAbbreviation {get; set;}
        // public int? MaxResultCount {get; set;}
        // public bool? Random {get; set;}
        // public bool? RandomStatistic {get; set;} 
        public string Q {get; set;}
        public string Sort {get; set;}
        public string Order {get; set;}
        public string Page {get; set;}
        public string Per_page {get; set;}
    }    
}
