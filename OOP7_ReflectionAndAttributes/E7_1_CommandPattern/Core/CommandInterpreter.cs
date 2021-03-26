using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] parts = args.Split();
            string type = parts[0];
            string[] param = parts.Skip(1).ToArray();

            Type assemblyType = Assembly.GetEntryAssembly().GetTypes().FirstOrDefault(t => t.Name == $"{type}Command");

            ICommand command = (ICommand)Activator.CreateInstance(assemblyType);

            return command.Execute(param);
        }
    }
}
