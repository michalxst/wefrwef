using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qreency
{
    public class Xchange
    {
        public string disclaimer { set; get; }
        public string license { set; get; }
        public string timestamp { set; get; }
        public string Base { set; get; }
        public rates rates { set; get; }
    }
    public class rates
    {
        public string AED { set; get; }
        public string CAD { set; get; }
        public string EUR { set; get; }
        public string GBP { set; get; }
        public string PLN { set; get; }
    
        //public long timestamp { set; get; }
        //  public string Base { set; get; }
        //   public int rates { set; get; }

        //     public override string ToString()
        //   {
        //     return $"{this.disclaimer}: {this.license}";
        //  return $"{this.disclaimer}: {this.license}  {this.timestamp}: {this.Base}: {this.rates}";

    }
}
