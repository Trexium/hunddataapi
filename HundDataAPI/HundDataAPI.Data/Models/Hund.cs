using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HundDataAPI.Data.Models
{
    public class Hund
    {
        [JsonPropertyName("__type")]
        public string SKKType {  get; set; }

        [JsonPropertyName("hundid")]
        public string SKKId { get; set; }

        [JsonPropertyName("Regnr")]
        public string SKKRegNr { get; set; }

        [JsonPropertyName("hundnamn")]
        public string Name { get;set; }

        [JsonPropertyName("IDnummer")]
        public string IdNumber { get; set; }

        [JsonPropertyName("chipnr")]
        public string ChipNr { get; set; }

        [JsonPropertyName("Kon")]
        public string Gender { get; set; }

        [JsonPropertyName("rastext")]
        public string BreedOfDog { get; set; }

        [JsonPropertyName("IsError")]
        public bool IsError { get; set; }

        [JsonPropertyName("ErrorText")]
        public string ErrorText { get; set; }

        [JsonPropertyName("Antal")]
        public string CountString { get; set; }
    }
}
