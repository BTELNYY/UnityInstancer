using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityInstancer
{
    public class Command
    {
        /// <summary>
        /// The amount of params this command expects (note that the command invocation itself is not counted)
        /// </summary>
        public virtual int ParameterCount { get; } = 0;

        /// <summary>
        /// The proper syntax for the command
        /// </summary>
        public virtual string Syntax { get; } = "";

        public virtual void Execute(string[] args) 
        {

        }
    }
}
