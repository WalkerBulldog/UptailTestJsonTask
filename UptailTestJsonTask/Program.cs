using UptailTestJsonTask;

string filePath = "..\\..\\..\\json1.json";
string jsonValuePath = "Indo-European.Slavic.East-Slavic.[0]";
try
{
    Console.WriteLine(string.Format("Value of {0} is {1}",
    jsonValuePath, JsonValueFinder.GetValue(filePath, jsonValuePath)));
}
catch(Exception e)
{ 
    Console.WriteLine(e.ToString()); 
}


