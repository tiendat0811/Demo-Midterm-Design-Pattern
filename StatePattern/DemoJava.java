interface Color {
    void changeColor(TrafficLight trafficLight);
}

class Green implements Color {
    public void changeColor(TrafficLight trafficLight) {
        System.out.println("Green light! Can go straight!");
        trafficLight.setColor(new Yellow());
    }
}

class Yellow implements Color {
    public void changeColor(TrafficLight trafficLight) {
        System.out.println("Yellow light! Reduce speed!");
        trafficLight.setColor(new Red());
    }
}

class Red implements Color {
    public void changeColor(TrafficLight trafficLight) {
        System.out.println("Red light! Stop and wait for the green light to go straight!");
        trafficLight.setColor(new Green());
    }
}

class TrafficLight {
    private Color color;
    
    public TrafficLight() {
        color = new Red();
    }

    void setColor(Color newColor) {
        color = newColor;
    }

    public void changeColor() {
        color.changeColor(this);
    }
}

public class DemoJava {
    public static void main(String[] args) {
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