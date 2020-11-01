using LancerEngine.Schemas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace LancerEngine
{
    public class LancerEngine
    {
        public List<ActionRef> LoadGameReferenceData()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceNames = assembly.GetManifestResourceNames();

            string actionsResourceName = resourceNames.Where(x => x.Contains(".actions.json")).Single();

            List<ActionRef> actions;

            using (Stream stream = assembly.GetManifestResourceStream(actionsResourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                actions = JsonConvert.DeserializeObject<List<ActionRef>>(reader.ReadToEnd());
            }

            return actions;
        }
    }
}
