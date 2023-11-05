package effective_java.chapter2.item4;

//  a class can be made non-instantiable by including a private constructor
public class UtilityClass {
    // Suppress default constructor for non-instantiability
    private UtilityClass() {
        throw new AssertionError();
    }
}
