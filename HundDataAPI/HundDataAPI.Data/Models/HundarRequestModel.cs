using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HundDataAPI.Data.Models
{
    public class HundarRequestModel
    {
        [JsonPropertyName("txtRegnr")]
        public string SKKRegNr {  get; set; }

        [JsonPropertyName("txtIDnummer")]
        public string IdNumber { get; set; }

        [JsonPropertyName("txtChipnr")]
        public string ChipNr { get; set; }

        [JsonPropertyName("txtHundnamn")]
        public string Name { get; set; }

        [JsonPropertyName("ddlRasIn")]
        public string BreedOfDog { get; set; }

        [JsonPropertyName("ddlKon")]
        public string Gender { get; set; }

        [JsonPropertyName("txtLicensnr")]
        public string LicensNr { get; set; }
    }
}
