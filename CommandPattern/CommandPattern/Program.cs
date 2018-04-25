using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl;
            ICommand target = new LightonCommand();
            remoteControl = new RemoteControl(target);
            remoteControl.PressLightOn();

            target = new LightoffCommand();
            remoteControl = new RemoteControl(target);
            remoteControl.PressLightOff();

            Console.ReadLine();
        }
    }

    public class RemoteControl
    {
        ICommand target = null;

        public RemoteControl(ICommand command)
        {
            target = command;
        }

        public void PressLightOn()
        {
            target.Execute();
        }

        public void PressLightOff()
        {
            target.Execute();
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class LightonCommand: ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Light on");
        }
    }

    public class LightoffCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Light off");
        }
    }
}
