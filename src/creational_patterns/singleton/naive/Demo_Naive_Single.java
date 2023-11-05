package creational_patterns.singleton.naive;

public class Demo_Naive_Single {
    public static void main(String[] args) {

        System.out.println("If you see the same value, then singleton was reused (yay!)" + "\n" + "If you see different values, then 2 singletons were created (booo!!)" + "\n\n" + "RESULT:" + "\n");
        Singleton singleton = Singleton.getInstance("FOO");
        Singleton another = Singleton.getInstance("BAR");
        System.out.println(singleton.value);
        System.out.println(another.value);
    }

    public static class Demo_ThreadSafe {
    }
}
