using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HundDataAPI.Data.Models
{
    public class HundarResponseModel
    {
        [JsonPropertyName("d")]
        public Hund[] Dogs { get; set; }
    }
}
