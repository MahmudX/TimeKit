using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKit
{
    public class Options
    {
        public string Title { get; set; }
        public string coverImage { get; set; }
    }

    public class OptionManager
    {
        public static List<Options> GetOptionDetails()
        {
            var options = new List<Options>();

            options.Add(new Options { Title = "Artificial Intelligence", coverImage = "Assets/Ai.png" });
            options.Add(new Options { Title = "Big Data", coverImage = "Assets/BigData.png" });
            options.Add(new Options { Title = "Cloud Pros", coverImage = "Assets/Cloud.png" });
            options.Add(new Options { Title = "Machine Learning", coverImage = "Assets/Machine.png" });
            options.Add(new Options { Title = "Data Protections", coverImage = "Assets/Protection.png" });
            options.Add(new Options { Title = "Web Security", coverImage = "Assets/Security.png" });
            options.Add(new Options { Title = "Data Hero", coverImage = "Assets/Data.png" });
            options.Add(new Options { Title = "Statistic", coverImage = "Assets/Statistic.png" });

            return options;
        }
    }
}
