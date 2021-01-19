using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Toyota : CarBuilder
    {
        public override void AddBox()
        {
            Drink.box = new Box() { Name = "Top box" };
        }

        public override void AddBody()
        {
            Drink.body = new Body() { Name = "top body" };
        }

        public override void AddMotor()
        {
            Drink.motor = new Motor() { Name = "top motor" };
        }

        public override void AddWheels()
        {
            Drink.wheels = new Wheels() { Name = "top wheels" };
        }
    }

    class Barista
    {
        public MachineAssembly Make(CarBuilder coffeBuilder)
        {
            coffeBuilder.CreateMachine();
            coffeBuilder.AddBox();
            coffeBuilder.AddWheels();
            coffeBuilder.AddMotor();
            coffeBuilder.AddBody();
            return coffeBuilder.Drink;
        }
    }

    abstract class CarBuilder
    {
        public MachineAssembly Drink { get; set; }
        public void CreateMachine()
        {
            Drink = new MachineAssembly();
        }
        public abstract void AddBox();
        public abstract void AddWheels();
        public abstract void AddMotor();
        public abstract void AddBody();
    }

    class MachineAssembly
    {
        public Box box { get; set; }
        public Wheels wheels { get; set; }
        public Motor motor { get; set; }
        public Body body { get; set; }

        public override string ToString()
        {
            string result = box.Name + Environment.NewLine +
                wheels.Name + Environment.NewLine +
                motor.Name + Environment.NewLine +
                body.Name + Environment.NewLine;
            return base.ToString();
        }
    }

    class Box
    {
        public string Name { get; set; }
    }

    class Wheels
    {
        public string Name { get; set; }
    }

    class Motor
    {
        public string Name { get; set; }
    }

    class Body
    {
        public string Name { get; set; }
    }
}
