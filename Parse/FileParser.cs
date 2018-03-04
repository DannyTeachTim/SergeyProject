using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TeachTim.Enums;

namespace TeachTim.Parse
{
    class FileParser
    {
        public static Codes Parse(string path)
        {
            try
            {

            }
            catch(FileNotFoundException)
            {
                return Codes.FILE_NOT_FOUND;
            }
            catch(FileLoadException)
            {
                return Codes.SECURITY_ERROR;
            }
            catch(Exception)
            {
                return Codes.OTHER_ERROR;
            }
            return Codes.SUCCESS;
        }
    }
}
