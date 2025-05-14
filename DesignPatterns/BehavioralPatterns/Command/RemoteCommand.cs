using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Command
{
    public class RemoteCommand
    {
        private readonly List<ICommand> _commands = [];
        public void AddCommand(ICommand command) => _commands.Add(command);

        public void ExecuteAll()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }

            _commands.Clear();
        }
    }
    public interface ICommand
    {
        void Execute();
    }

    public class LightOnCommand(Light light) : ICommand
    {
        private readonly Light _light = light;
        public void Execute() => _light.TurnOn();
    }

    public class FanOnCommand(Fan fan) : ICommand
    {
        private readonly Fan _fan = fan;
        public void Execute() => _fan.TurnOn();
    }

    public class Light
    {
        public void TurnOn() => Console.WriteLine("Light is ON");
        public void TurnOff() => Console.WriteLine("Light is OFF");
    }

    public class Fan
    {
        public void TurnOn() => Console.WriteLine("Fan is ON");
        public void TurnOff() => Console.WriteLine("Fan is OFF");
    }
}
