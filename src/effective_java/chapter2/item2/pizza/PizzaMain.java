package effective_java.chapter2.item2.pizza;

import static chapter2.item2.pizza.NyPizza.Size.SMALL;
import static chapter2.item2.pizza.Pizza.Topping.*;

public class PizzaMain {
    public static void main(String[] args) {
        NyPizza pizza = new NyPizza.Builder(SMALL).addTopping(SAUSAGE).addTopping(ONION).build();
        Calzone calzone = new Calzone.Builder().addTopping(HAM).sauceInside().build();
    }
}
