using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UptailTestJsonTask
{
    /// <summary>
    /// Class for search any json element value.
    /// </summary>
    public static class JsonValueFinder
    {
        /// <summary>
        /// Gets value of jsonElement.
        /// </summary>
        /// <param name="filePath">Path to json file.</param>
        /// <param name="jsonValuePath">Path to json element.</param>
        /// <returns>Json element value.</returns>
        /// <exception cref="NullReferenceException">File was empty.</exception>
        public static string GetValue(string filePath, string jsonValuePath)
        {
            string json = File.ReadAllText(filePath);
            if (string.IsNullOrEmpty(json))
            {
                throw new NullReferenceException(string.Format("{0} file is empty!", jsonValuePath));
            }
            var jsonObject = JToken.Parse(json);
            var token = jsonObject.SelectToken(jsonValuePath);
            if (token is null)
            {
                throw new NullReferenceException(string.Format("Didn't find any element with {0} path!", jsonValuePath));
            }
            return token.ToString();
        }
    }
}
