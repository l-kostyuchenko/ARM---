using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Сервис_Инженера
{
    public class TablUpd
    {
        public string Version;
        public string FileU;
        public string Size;
        public string Target;

        public TablUpd(string Version, string FileU, string Size, string Target)
        {
            this.FileU = FileU;
            this.Size = Size;
            this.Target = Target;
            this.Version = Version; 
        }
    }
}
