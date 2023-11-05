package effective_java.chapter2.item2;

// Telescoping constructor
// the telescoping constructor pattern works, but it is hard to write client code when there are many parameters, and harder still to read it
//public class NutritionFacts {
//    private final int servingSize; // (mL) required
//    private final int servings; // (per container) required
//    private final int calories; // (per serving) optional
//    private final int fat; // (g/serving) optional
//    private final int sodium; // (mg/serving) optional
//    private final int carbohydrate; // (g/serving) optional
//
//    public NutritionFacts(int servingSize, int servings) {
//        this(servingSize, servings, 0);
//    }
//
//    public NutritionFacts(int servingSize, int servings, int calories) {
//        this(servingSize, servings, calories, 0);
//    }
//
//    public NutritionFacts(int servingSize, int servings, int calories, int fat) {
//        this(servingSize, servings, calories, fat, 0);
//    }
//
//    public NutritionFacts(int servingSize, int servings, int calories, int fat, int sodium) {
//        this(servingSize, servings, calories, fat, sodium, 0);
//    }
//
//    public NutritionFacts(int servingSize, int servings, int calories, int fat, int sodium, int carbohydrate) {
//        this.servingSize = servingSize;
//        this.servings = servings;
//        this.calories = calories;
//        this.fat = fat;
//        this.sodium = sodium;
//        this.carbohydrate = carbohydrate;
//    }
//
//    public static void main(String[] args) {
//        NutritionFacts facts = new NutritionFacts(240, 8, 100, 0, 35, 7);
//        System.out.println(facts);
//    }
//}

// JavaBeans Pattern - allows inconsistency, mandates mutability
// Unfortunately, the JavaBeans pattern has serious disadvantages of its own.
// Because construction is split across multiple calls, a JavaBean may be in an inconsistent state partway through its construction
//public class NutritionFacts {
//    private int servingSize = -1;
//    private int servings = -1;
//    private int calories = 0;
//    private int fat = 0;
//    private int sodium = 0;
//    private int carbohydrate = 0;
//
//    public NutritionFacts() {
//
//    }
//
//    public void setServingSize(int servingSize) {
//        this.servingSize = servingSize;
//    }
//
//    public void setServings(int servings) {
//        this.servings = servings;
//    }
//
//    public void setCalories(int calories) {
//        this.calories = calories;
//    }
//
//    public void setFat(int fat) {
//        this.fat = fat;
//    }
//
//    public void setSodium(int sodium) {
//        this.sodium = sodium;
//    }
//
//    public void setCarbohydrate(int carbohydrate) {
//        this.carbohydrate = carbohydrate;
//    }
//
//    public static void main(String[] args) {
//        NutritionFacts facts = new NutritionFacts();
//        facts.setServingSize(240);
//        facts.setServings(8);
//        facts.setCalories(100);
//        facts.setSodium(35);
//        facts.setCarbohydrate(27);
//        System.out.println(facts);
//    }
//}


// Builder Pattern
// Luckily, there is a third alternative that combines the safety of the telescoping constructor pattern with the readability of the JavaBeans pattern. It is a form of the Builder pattern
// The Builder pattern simulates named optional parameters
public class NutritionFacts {
    private final int servingSize;
    private final int servings;
    private final int calories;
    private final int fat;
    private final int sodium;
    private final int carbohydrate;

    public NutritionFacts(Builder builder) {
        servingSize = builder.servingSize;
        servings = builder.servings;
        calories = builder.calories;
        fat = builder.fat;
        sodium = builder.sodium;
        carbohydrate = builder.carbohydrate;
    }

    public static class Builder {
        // Required parameters
        private final int servingSize;
        private final int servings;

        // Optional parameters - initialized to default values
        private int calories = 0;
        private int fat = 0;
        private int sodium = 0;
        private int carbohydrate = 0;

        public Builder(int servingSize, int servings) {
            this.servingSize = servingSize;
            this.servings = servings;
        }

        public Builder calories(int val) {
            this.calories = val;
            return this;
        }

        public Builder fat(int val) {
            this.fat = val;
            return this;
        }

        public Builder sodium(int val) {
            this.sodium = val;
            return this;
        }

        public Builder carbohydrate(int val) {
            this.carbohydrate = val;
            return this;
        }

        public NutritionFacts build() {
            return new NutritionFacts(this);
        }

    }

    public static void main(String[] args) {
        NutritionFacts cola = new Builder(240, 8).calories(100).sodium(35).carbohydrate(27).build();
    }

}









