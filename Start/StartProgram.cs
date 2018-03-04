using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TeachTim.Extensions;

namespace TeachTim.Start
{
    public sealed class StartProgram
    {
        public void Start()
        {
            List<string> paths = GetUserInput();

        }

        private List<string> GetUserInput()
        {
            string userInput = Console.ReadLine();
            var listOfPaths = userInput.Split(separator: new char[] { ';' }, options: StringSplitOptions.RemoveEmptyEntries)
                                .RemoveWhiteSpacesAtEnds()
                                .ToList();
            return listOfPaths;
        }
    }
}
