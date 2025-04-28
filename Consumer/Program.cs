using MyNamespace.MySubset;
using System.Text.Json;

namespace Consumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rawResponse = GetOptionalPayloadRawData(1);
            Console.WriteLine($"Parsing case 1: {rawResponse}");
            var parsedResponse = JsonSerializer.Deserialize<OptionalPayload>(rawResponse)!;
            Console.WriteLine($"Result case 1: age = {parsedResponse?.Age}");

        }

        static string GetOptionalPayloadRawData(int testCase)
        {
            // 1: null
            if (testCase == 1)
            {
                return """
{
    "age": null
}
""";
            }

            // 2: explicit undefined
            if (testCase == 2)
            {
                return """
{
    "age": undefined
}
""";
            }

            // 3: implicit undefined
            if (testCase == 3)
            {
                return """
{
}
""";
            }

            // other: integer value
            return """
{
    "age": 5
}
""";
        }
    }
}
