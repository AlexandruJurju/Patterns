package head_first_patterns.duck.fly_behaviour;

public class FlyNoWay implements FlyBehaviour {
    @Override
    public void fly() {
        System.out.println("CANT FLY");
    }
}
