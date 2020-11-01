using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LancerEngine.Schemas
{
    public class ActionRef
    {
        [JsonRequired]
        [Description("Internal id")]
        public string Id { get; set; }

        [JsonRequired]
        [Description("Lancer human-friendly name")]
        public string Name { get; set; }

        [DefaultValue(false)]
        [Description("Indicates if the action corresponds to a Reserve item (temporary item for one-mission use)")]
        public bool Reserve { get; set; }

        [JsonRequired]
        [JsonProperty("action_type")]
        [Description("Category of action this falls under")]
        public ActionType Type { get; set; }

        [JsonRequired]
        [Description("Brief action description")]
        public string Description { get; set; }

        [JsonRequired]
        [Description("Full Lancer action description")]
        public string Detail { get; set; }

        [DefaultValue(false)]
        [Description("Indicates if the action can only be performed by pilots (not frames)")]
        public bool Pilot { get; set; }
    }
}
