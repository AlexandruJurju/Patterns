package head_first.duck.quack_behaviour;

public class MuteQuack  implements QuackBehaviour{
    @Override
    public void quack() {
        System.out.println("CANT QUACK");
    }
}
