using System.Collections.Generic;
using Newtonsoft.Json;
using RESTCountries.Models;

namespace SBSC_Challenge.Entities
{
    public class Country
    {
        public Country(){}

        //
        // Summary:
        //     Gets or sets the Flag
        [JsonProperty("flag")]
        public string Flag { get; set; }
        //
        // Summary:
        //     Gets or sets the Translations
        [JsonProperty("translations")]
        public Translations Translations { get; set; }
        //
        // Summary:
        //     Gets or sets the Languages
        [JsonProperty("languages")]
        public IList<Language> Languages { get; set; }
        //
        // Summary:
        //     Gets or sets the Currencies
        [JsonProperty("currencies")]
        public IList<Currency> Currencies { get; set; }
        //
        // Summary:
        //     Gets or sets the Numeric Code
        [JsonProperty("numericCode")]
        public string NumericCode { get; set; }
        //
        // Summary:
        //     Gets or sets the Native Name
        [JsonProperty("nativeName")]
        public string NativeName { get; set; }
        //
        // Summary:
        //     Gets or sets the Borders
        [JsonProperty("borders")]
        public IList<string> Borders { get; set; }
        //
        // Summary:
        //     Gets or sets the Timezones
        [JsonProperty("timezones")]
        public IList<string> Timezones { get; set; }
        //
        // Summary:
        //     Gets or sets the Gini
        [JsonProperty("gini")]
        public double? Gini { get; set; }
        //
        // Summary:
        //     Gets or sets the Area
        [JsonProperty("area")]
        public double? Area { get; set; }
        //
        // Summary:
        //     Gets or sets the Regional Blocs
        [JsonProperty("regionalBlocs")]
        public IList<RegionalBloc> RegionalBlocs { get; set; }
        //
        // Summary:
        //     Gets or sets the Demonym
        [JsonProperty("demonym")]
        public string Demonym { get; set; }
        //
        // Summary:
        //     Gets or sets the Population
        [JsonProperty("population")]
        public int Population { get; set; }
        //
        // Summary:
        //     Gets or sets the Subregion
        [JsonProperty("subregion")]
        public string Subregion { get; set; }
        //
        // Summary:
        //     Gets or sets the Region
        [JsonProperty("region")]
        public string Region { get; set; }
        //
        // Summary:
        //     Gets or sets the Alt Spellings
        [JsonProperty("altSpellings")]
        public IList<string> AltSpellings { get; set; }
        //
        // Summary:
        //     Gets or sets the Capital
        [JsonProperty("capital")]
        public string Capital { get; set; }
        //
        // Summary:
        //     Gets or sets the Calling Codes
        [JsonProperty("callingCodes")]
        public IList<string> CallingCodes { get; set; }
        //
        // Summary:
        //     Gets or sets the Alpha3 Code
        [JsonProperty("alpha3Code")]
        public string Alpha3Code { get; set; }
        //
        // Summary:
        //     Gets or sets the Alpha2 Code
        [JsonProperty("alpha2Code")]
        public string Alpha2Code { get; set; }
        //
        // Summary:
        //     Gets or sets the Top Level Domain
        [JsonProperty("topLevelDomain")]
        public IList<string> TopLevelDomain { get; set; }
        //
        // Summary:
        //     Gets or sets the Name
        [JsonProperty("name")]
        public string Name { get; set; }
        //
        // Summary:
        //     Gets or sets the Latlng(Latitude and Longitude)
        [JsonProperty("latlng")]
        public IList<double> Latlng { get; set; }
        //
        // Summary:
        //     Gets or sets the Cioc(International Olympic Committee Code)
        [JsonProperty("cioc")]
        public string Cioc { get; set; }
    }
}