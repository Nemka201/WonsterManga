using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonsterManga.Domain.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Iso2 { get; set; }
        public string Iso3 { get; set; }
        public string Name { get; set; }
        public string Nicename { get; set; }
        public string IsoNumeric { get; set; }
        public string PhoneCode { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public double Tld { get; set; }
        public double NativeName { get; set; }
        public double Region { get; set; }
        public double Subregion { get; set; }
        public double EmuMember { get; set; }
        public double Currencies { get; set; }
        public double Languages { get; set; }
        public double Translations { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Flag { get; set; }
        public string WikiDataId { get; set; }
    }
}
