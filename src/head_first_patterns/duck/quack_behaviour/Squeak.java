package head_first_patterns.duck.quack_behaviour;

public class Squeak implements QuackBehaviour{
    @Override
    public void quack() {
        System.out.println("SQUEAK");
    }
}
