using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.GoalParserInterpretation
{
    public class CodeFile
    {
        public string Interpret(string command)
        {
            return command.Replace("(al)", "al").Replace("()", "o");
        }
    }
}
