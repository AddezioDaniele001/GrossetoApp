using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossetoApp;

public  class Meteoday
{
    public string time { get; set; }

    public string status  { get; set; }

    public List<KeyValuePair<string,int>> values { get; set; }
}
