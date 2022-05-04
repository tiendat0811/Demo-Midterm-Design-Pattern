using System;

internal interface Color
{
	void changeColor(TrafficLight trafficLight);
}

internal class Green : Color
{
	public virtual void changeColor(TrafficLight trafficLight)
	{
		Console.WriteLine("Green light! Can go straight!");
		trafficLight.Color = new Yellow();
	}
}

internal class Yellow : Color
{
	public virtual void changeColor(TrafficLight trafficLight)
	{
		Console.WriteLine("Yellow light! Reduce speed!");
		trafficLight.Color = new Red();
	}
}

internal class Red : Color
{
	public virtual void changeColor(TrafficLight trafficLight)
	{
		Console.WriteLine("Red light! Stop and wait for the green light to go straight!");
		trafficLight.Color = new Green();
	}
}

internal class TrafficLight
{
	private Color color;

	public TrafficLight()
	{
		color = new Red();
	}

	internal virtual Color Color
	{
		set
		{
			color = value;
		}
	}

	public virtual void changeColor()
	{
		color.changeColor(this);
	}
}

public class DemoJava
{
	public static void Main(string[] args)
	{
		TrafficLight trafficLight = new TrafficLight();

		trafficLight.changeColor();
		trafficLight.changeColor();
		trafficLight.changeColor();
		trafficLight.changeColor();
		trafficLight.changeColor();
		trafficLight.changeColor();
		trafficLight.changeColor();
	}
}
