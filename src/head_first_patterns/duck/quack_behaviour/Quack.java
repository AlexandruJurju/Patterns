package head_first_patterns.duck.quack_behaviour;

public class Quack implements QuackBehaviour{
    @Override
    public void quack() {
        System.out.println("QUACK");
    }
}
