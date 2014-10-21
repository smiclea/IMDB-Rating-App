using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IMDb_Rating_App.Model;
using System.IO;
using System.Text.RegularExpressions;

namespace IMDb_Rating_App.Proxy
{
    public class TemplateReader
    {
        private const string TEMPLATE_PATH = "templates.cfg";


        public List<Template> loadTemplates()
        {
            StreamReader reader = new StreamReader(TEMPLATE_PATH);
            string content = reader.ReadToEnd();
            reader.Dispose();

            MatchCollection namesMatches =  new Regex(@"Name:\s'(.*)'").Matches(content);
            MatchCollection linkMatches =  new Regex(@"Link:\s'(.*)'").Matches(content);
            MatchCollection expressionMatches =  new Regex(@"Expression:\s('|"")(.*)('|"")").Matches(content);

            List<Template> result = new List<Template>();

            for (int i = 0; i < namesMatches.Count; i++)
                result.Add(new Template()
                {
                    Name = namesMatches[i].Groups[1].Value,
                    Link = linkMatches[i].Groups[1].Value,
                    Expression = expressionMatches[i].Groups[2].Value
                });

            return result;
        }
    }
}
