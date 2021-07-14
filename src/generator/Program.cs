using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.OperationNameGenerators;

namespace xtellurian.HubSpot.Generator
{
    class Program
    {
        private static string OutputNamespace(string name) => $"xtellurian.HubSpot.{name}";
        static async Task Main(string[] args)
        {
            Console.WriteLine("Generating C# clients.");


            var apiCollection = await LoadApiCollection();
            var crmApi = apiCollection.GetResultByName("CRM");

            await GenerateFromFeature("Contacts", crmApi.Features["Contacts"]);
            await GenerateFromFeature("Contact Properties", crmApi.Features["Contact Properties"]);
            await GenerateFromFeature("Crm Extensions", crmApi.Features["Crm Extensions"]);
            await GenerateFromFeature("Associations", crmApi.Features["Associations"]);

            Console.WriteLine("Done.");
        }

        private static async Task GenerateFromFeature(string name, Feature feature)
        {
            var fixedName = name.Replace(" ", "");
            using (System.Net.WebClient wclient = new System.Net.WebClient())
            {
                var document = await OpenApiDocument.FromJsonAsync(wclient.DownloadString(feature.OpenApi));
                await GenerateCode(document, fixedName, $"../hubspotdotnet/{fixedName}.cs");
            }
            Console.WriteLine($"Generated '{name}' feature client");
        }

        private static async Task<HubspotApiCollection> LoadApiCollection()
        {
            var text = await File.ReadAllTextAsync("../../hubspot_apis.json");
            return JsonConvert.DeserializeObject<HubspotApiCollection>(text, new StageConverter());
        }

        private static async Task GenerateCode(OpenApiDocument document, string name, string outputPath)
        {
            var settings = new CSharpClientGeneratorSettings
            {

                ClassName = $"{name}Client",
                CSharpGeneratorSettings =
                {
                    Namespace = OutputNamespace(name),
                    ArrayInstanceType = "System.Collections.Generic.List", // this is required because of a type casting error on compilation
                    ArrayType = "System.Collections.Generic.List"
                }
                ,
                OperationNameGenerator = new SingleClientFromPathSegmentsOperationNameGenerator(),

            };

            var generator = new CSharpClientGenerator(document, settings);
            var code = generator.GenerateFile();

            await File.WriteAllTextAsync(outputPath, code);
            Console.WriteLine($"Wrote {code.Count()} characters to {outputPath}");
        }
    }
}
