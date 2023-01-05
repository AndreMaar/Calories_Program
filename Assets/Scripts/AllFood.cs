using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllFood : MonoBehaviour
{
    public static List<FoodClass> foods;

    public void Awake()
    {
        foods = new List<FoodClass>();
        foods.Add(new FoodClass("Artichokes", 0.45f));
        foods.Add(new FoodClass("Eggplants", 0.28f));
        foods.Add(new FoodClass("Green peas", 0.93f));
        foods.Add(new FoodClass("Canned green peas", 0.41f));
        foods.Add(new FoodClass("Zucchini", 0.22f));
        foods.Add(new FoodClass("Cabbage", 0.23f));
        foods.Add(new FoodClass("Boiled potatoes", 0.60f));
        foods.Add(new FoodClass("Corn", 1.03f));
        foods.Add(new FoodClass("Onion", 0.45f));
        foods.Add(new FoodClass("Carrot", 0.34f));
        foods.Add(new FoodClass("Cucumber", 0.15f));
        foods.Add(new FoodClass("Pickled cucumbers", 0.08f));
        foods.Add(new FoodClass("Pepper", 0.19f));
        foods.Add(new FoodClass("Parsley", 0.23f));
        foods.Add(new FoodClass("Tomatoes", 0.15f));
        foods.Add(new FoodClass("Radish", 0.25f));
        foods.Add(new FoodClass("Salad", 0.15f));
        foods.Add(new FoodClass("Beet", 0.44f));
        foods.Add(new FoodClass("Celery", 0.38f));
        foods.Add(new FoodClass("Pumpkin", 0.24f));
        foods.Add(new FoodClass("Cauliflower", 0.28f));
        foods.Add(new FoodClass("Garlic", 0.60f));
        foods.Add(new FoodClass("Spinach", 0.17f));
        foods.Add(new FoodClass("Avocado", 2.04f));
        foods.Add(new FoodClass("Pineapple", 0.44f));
        foods.Add(new FoodClass("Orange", 0.45f));
        foods.Add(new FoodClass("Watermelon", 0.40f));
        foods.Add(new FoodClass("Banana", 0.90f));
        foods.Add(new FoodClass("Grape", 0.70f));
        foods.Add(new FoodClass("Cherry", 0.25f));
        foods.Add(new FoodClass("Lokhina", 0.37f));
        foods.Add(new FoodClass("Garnet", 0.52f));
        foods.Add(new FoodClass("Grapefruit", 0.35f));
        foods.Add(new FoodClass("Pear", 0.42f));
        foods.Add(new FoodClass("Melon", 0.45f));
        foods.Add(new FoodClass("Blackberry", 0.32f));
        foods.Add(new FoodClass("Strawberry", 0.48f));
        foods.Add(new FoodClass("Fig", 0.56f));
        foods.Add(new FoodClass("Kiwi", 0.50f));
        foods.Add(new FoodClass("Dogwood", 0.41f));
        foods.Add(new FoodClass("Cranberry", 0.33f));
        foods.Add(new FoodClass("Gooseberry", 0.48f));
        foods.Add(new FoodClass("Lemon", 0.30f));
        foods.Add(new FoodClass("Raspberry", 0.45f));
        foods.Add(new FoodClass("Tangerine", 0.41f));
        foods.Add(new FoodClass("Peaches", 0.45f));
        foods.Add(new FoodClass("Plums", 0.44f));
        foods.Add(new FoodClass("Currant", 0.43f));
        foods.Add(new FoodClass("Merry", 0.53f));
        foods.Add(new FoodClass("Bilberry", 0.44f));
        foods.Add(new FoodClass("Apples", 0.45f));
        foods.Add(new FoodClass("Seed", 5.80f));
        foods.Add(new FoodClass("Walnuts Volosky", 6.50f));
        foods.Add(new FoodClass("Cedar nuts", 6.20f));
        foods.Add(new FoodClass("Almond", 6.00f));
        foods.Add(new FoodClass("Pistachios", 6.20f));
        foods.Add(new FoodClass("Hazelnut", 7.05f));
        foods.Add(new FoodClass("Raisins", 2.80f));
        foods.Add(new FoodClass("Fig", 2.90f));
        foods.Add(new FoodClass("Sultana", 3.10f));
        foods.Add(new FoodClass("Dried apricots", 2.93f));
        foods.Add(new FoodClass("Dates", 2.90f));
        foods.Add(new FoodClass("Prunes", 2.20f));
        foods.Add(new FoodClass("Egg", 0.65f));
        foods.Add(new FoodClass("Mushrooms", 0.25f));
        foods.Add(new FoodClass("Cooked mushrooms", 0.25f));
        foods.Add(new FoodClass("Mushrooms in sour cream", 2.30f));
        foods.Add(new FoodClass("Fried mushrooms", 1.65f));
        foods.Add(new FoodClass("Trimmers", 0.30f));
        foods.Add(new FoodClass("Bagels", 3.12f));
        foods.Add(new FoodClass("Butter pastry", 3.00f));
        foods.Add(new FoodClass("Gingerbread", 3.30f));
        foods.Add(new FoodClass("Crackers", 3.30f));
        foods.Add(new FoodClass("Wheat bread", 2.65f));
        foods.Add(new FoodClass("Rye bread", 2.10f));
        foods.Add(new FoodClass("Yogurt", 0.51f));
        foods.Add(new FoodClass("Kefir", 0.38f));
        foods.Add(new FoodClass("Milk", 0.60f));
        foods.Add(new FoodClass("Condensed milk", 3.24f));
        foods.Add(new FoodClass("Ice cream", 2.20f));
        foods.Add(new FoodClass("Ryazanka", 0.85f));
        foods.Add(new FoodClass("Cream", 3.00f));
        foods.Add(new FoodClass("Sour cream", 1.15f));
        foods.Add(new FoodClass("Curds", 3.80f));
        foods.Add(new FoodClass("Curd mass", 2.07f));
        foods.Add(new FoodClass("Low-fat cheese", 0.80f));
        foods.Add(new FoodClass("Cheese", 3.57f));
        foods.Add(new FoodClass("Wheat flour", 3.48f));
        foods.Add(new FoodClass("Rye flour", 3.47f));
        foods.Add(new FoodClass("Semolina", 3.40f));
        foods.Add(new FoodClass("Oat", 3.74f));
        foods.Add(new FoodClass("Pearl", 3.42f));
        foods.Add(new FoodClass("Wheat", 3.52f));
        foods.Add(new FoodClass("Millet", 3.35f));
        foods.Add(new FoodClass("Barley", 3.43f));
        foods.Add(new FoodClass("Cornflakes", 3.69f));
        foods.Add(new FoodClass("Pasta", 3.50f));
        foods.Add(new FoodClass("Muesli", 3.70f));
        foods.Add(new FoodClass("Oat flakes", 3.05f));
        foods.Add(new FoodClass("Millet", 3.51f));
        foods.Add(new FoodClass("Fig", 3.37f));
        foods.Add(new FoodClass("Soy", 3.95f));
        foods.Add(new FoodClass("Bean", 3.28f));
        foods.Add(new FoodClass("Lentil", 3.10f));
        foods.Add(new FoodClass("Barley flakes", 3.15f));
        foods.Add(new FoodClass("Brisket", 5.33f));
        foods.Add(new FoodClass("Shoulder", 3.80f));
        foods.Add(new FoodClass("Dorsal part", 4.59f));
        foods.Add(new FoodClass("Stewed beef", 1.80f));
        foods.Add(new FoodClass("Minced beef", 1.18f));
        foods.Add(new FoodClass("Brisket", 4.05f));
        foods.Add(new FoodClass("Shoulder", 2.08f));
        foods.Add(new FoodClass("Brains", 1.24f));
        foods.Add(new FoodClass("Okovalok", 3.80f));
        foods.Add(new FoodClass("Ham", 3.08f));
        foods.Add(new FoodClass("Liver", 0.87f));
        foods.Add(new FoodClass("Kidneys", 0.59f));
        foods.Add(new FoodClass("Ribs", 4.46f));
        foods.Add(new FoodClass("Heart", 0.82f));
        foods.Add(new FoodClass("Fillet", 1.89f));
        foods.Add(new FoodClass("Ham", 5.43f));
        foods.Add(new FoodClass("Liver", 1.08f));
        foods.Add(new FoodClass("Shoulder", 5.93f));
        foods.Add(new FoodClass("Kidneys", 0.80f));
        foods.Add(new FoodClass("Pork leg", 4.31f));
        foods.Add(new FoodClass("Heart", 0.90f));
        foods.Add(new FoodClass("Fillet", 2.64f));
        foods.Add(new FoodClass("Neck", 5.52f));
        foods.Add(new FoodClass("Schnitzel", 2.52f));
        foods.Add(new FoodClass("Tongue", 2.08f));
        foods.Add(new FoodClass("Brisket", 2.13f));
        foods.Add(new FoodClass("Leg", 1.61f));
        foods.Add(new FoodClass("Ham", 1.55f));
        foods.Add(new FoodClass("Dorsal part", 2.10f));
        foods.Add(new FoodClass("Fillet", 1.58f));
        foods.Add(new FoodClass("Schnitzel", 1.62f));
        foods.Add(new FoodClass("Goose", 3.90f));
        foods.Add(new FoodClass("Turkey", 2.00f));
        foods.Add(new FoodClass("Rabbit", 1.24f));
        foods.Add(new FoodClass("Sausage", 3.80f));
        foods.Add(new FoodClass("Korea", 4.30f));
        foods.Add(new FoodClass("Rabbit", 1.15f));
        foods.Add(new FoodClass("Fried chicken", 2.10f));
        foods.Add(new FoodClass("Duck", 4.05f));
        foods.Add(new FoodClass("Pheasant", 1.43f));
        foods.Add(new FoodClass("Chickens", 1.56f));
        foods.Add(new FoodClass("Ham", 3.65f));
        foods.Add(new FoodClass("Cured meat", 2.64f));
        foods.Add(new FoodClass("Diabetic Sausage", 2.54f));
        foods.Add(new FoodClass("Doctor's sausage", 2.60f));
        foods.Add(new FoodClass("Amateur sausage", 2.91f));
        foods.Add(new FoodClass("Krovyan's sausage", 4.52f));
        foods.Add(new FoodClass("Smoked sausage", 5.07f));
        foods.Add(new FoodClass("Liver pate", 3.14f));
        foods.Add(new FoodClass("Tongue sausage", 2.15f));
        foods.Add(new FoodClass("Fat", 2.48f));
        foods.Add(new FoodClass("Salami", 5.60f));
        foods.Add(new FoodClass("Anchovies", 1.47f));
        foods.Add(new FoodClass("Saveloy", 4.84f));
        foods.Add(new FoodClass("Sausages", 2.04f));
        foods.Add(new FoodClass("Spik", 2.15f));
        foods.Add(new FoodClass("Gorbusha", 1.47f));
        foods.Add(new FoodClass("Granular caviar", 2.50f));
        foods.Add(new FoodClass("Caviar roe", 2.45f));
        foods.Add(new FoodClass("Pollock roe", 1.30f));
        foods.Add(new FoodClass("Squid", 0.75f));
        foods.Add(new FoodClass("Flounder", 0.90f));
        foods.Add(new FoodClass("Carp", 0.87f));
        foods.Add(new FoodClass("Chum salmon", 1.57f));
        foods.Add(new FoodClass("Canned fish", 3.20f));
        foods.Add(new FoodClass("Shrimps", 0.85f));
        foods.Add(new FoodClass("Crabs", 0.70f));
        foods.Add(new FoodClass("Bream", 1.00f));
        foods.Add(new FoodClass("Salmon", 1.45f));
        foods.Add(new FoodClass("Macrorus", 0.60f));
        foods.Add(new FoodClass("Mussels", 0.72f));
        foods.Add(new FoodClass("Pollack", 0.70f));
        foods.Add(new FoodClass("Cape", 1.57f));
        foods.Add(new FoodClass("Seaweed", 0.16f));
        foods.Add(new FoodClass("Weight", 0.44f));
        foods.Add(new FoodClass("Sea bass", 0.95f));
        foods.Add(new FoodClass("River perch", 0.82f));
        foods.Add(new FoodClass("Lobster", 0.82f));
        foods.Add(new FoodClass("Cod liver", 6.13f));
        foods.Add(new FoodClass("Crayfish", 0.75f));
        foods.Add(new FoodClass("Salaka", 0.98f));
        foods.Add(new FoodClass("Sevryuga", 1.37f));
        foods.Add(new FoodClass("Atlantic herring", 0.57f));
        foods.Add(new FoodClass("Salmon", 2.19f));
        foods.Add(new FoodClass("Whitefish", 1.44f));
        foods.Add(new FoodClass("Mackerel", 1.53f));
        foods.Add(new FoodClass("Catfish", 1.54f));
        foods.Add(new FoodClass("Scad", 1.19f));
        foods.Add(new FoodClass("Sterlad", 3.20f));
        foods.Add(new FoodClass("Zander", 0.72f));
        foods.Add(new FoodClass("Cod", 0.59f));
        foods.Add(new FoodClass("Trepang", 0.35f));
        foods.Add(new FoodClass("Tuna", 2.96f));
        foods.Add(new FoodClass("River eel", 5.98f));
        foods.Add(new FoodClass("Trout", 2.08f));
        foods.Add(new FoodClass("Hake", 0.86f));
        foods.Add(new FoodClass("Sprats in oil", 2.50f));
        foods.Add(new FoodClass("Pike", 0.72f));
        foods.Add(new FoodClass("Margarine", 6.75f));
        foods.Add(new FoodClass("Peanut oil", 8.95f));
        foods.Add(new FoodClass("Corn oil", 9.00f));
        foods.Add(new FoodClass("Olive oil", 8.24f));
        foods.Add(new FoodClass("Sunflower oil", 9.00f));
        foods.Add(new FoodClass("Butter", 7.50f));
        foods.Add(new FoodClass("Soybean oil", 9.00f));
        foods.Add(new FoodClass("Melted butter", 8.85f));
        foods.Add(new FoodClass("Ketchup", 0.80f));
        foods.Add(new FoodClass("Mayonnaise", 6.25f));
        foods.Add(new FoodClass("Orange juice", 1.23f));
        foods.Add(new FoodClass("Coffee", 0.01f));  
        foods.Add(new FoodClass("Lemonade", 1.23f));
        foods.Add(new FoodClass("Water", 0));  
        foods.Add(new FoodClass("Carrot juice", 0.68f));
        foods.Add(new FoodClass("Vegetable drink", 0.60f));
        foods.Add(new FoodClass("Red currant juice", 1.25f));
        foods.Add(new FoodClass("Blackcurrant juice", 1.38f));
        foods.Add(new FoodClass("Apple juice", 1.18f));
        foods.Add(new FoodClass("Tea", 0.01f)); 
        foods.Add(new FoodClass("Red wine", 0.74f));
        foods.Add(new FoodClass("Apple wine", 0.37f));
        foods.Add(new FoodClass("Whiskey", 2.40f));
        foods.Add(new FoodClass("Cherry liqueur", 3.00f));
        foods.Add(new FoodClass("Vodka", 2.75f));
        foods.Add(new FoodClass("Gin", 0.33f));
        foods.Add(new FoodClass("Liqueur", 3.25f));
        foods.Add(new FoodClass("Cognac", 2.50f));
        foods.Add(new FoodClass("Beer", 0.45f));
        foods.Add(new FoodClass("Slivyanka", 1.20f));
        foods.Add(new FoodClass("Cider", 0.40f));
        foods.Add(new FoodClass("Dry champagne", 0.85f));
        foods.Add(new FoodClass("Schnapps", 2.00f));
        foods.Add(new FoodClass("Waffles", 3.42f));
        foods.Add(new FoodClass("Jam", 2.94f));
        foods.Add(new FoodClass("Fruit dragee", 3.84f));
        foods.Add(new FoodClass("Marshmallow", 3.00f));
        foods.Add(new FoodClass("Iris", 3.87f));
        foods.Add(new FoodClass("Cocoa", 4.16f));
        foods.Add(new FoodClass("Caramel", 2.96f));
        foods.Add(new FoodClass("Honey", 3.10f));
        foods.Add(new FoodClass("Marmalade", 2.96f));
        foods.Add(new FoodClass("Paste", 3.05f));
        foods.Add(new FoodClass("Butter", 2.70f));
        foods.Add(new FoodClass("Sugar", 3.80f));
        foods.Add(new FoodClass("Almond cake", 5.24f));
        foods.Add(new FoodClass("Halva", 5.10f));
        foods.Add(new FoodClass("Chocolate", 5.40f));
        foods.Add(new FoodClass("Milk chocolate", 5.48f));
    }
}

public class FoodClass
{

    public FoodClass(string name, float calories)
    {
        this.name = name;
        caloriesIn100Grams = calories;
    }

    private string name;
    private int grams;
    private float caloriesIn100Grams;
    private float totalCalories;

    public void SetGrams(int grams)
    {
        this.grams = grams;
        totalCalories = (caloriesIn100Grams * this.grams);
    }

    public string GetName()
    {
        return name;
    }
    public float GetCalories()
    {
        return caloriesIn100Grams;
    }
    public int GetGrams()
    {
        return grams;
    }
    public float GetTotalCalories()
    {
        return totalCalories;
    }
}

