using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllFood : MonoBehaviour
{
    public static List<FoodClass> foods;

    public void Start()
    {
        foods = new List<FoodClass>();
        foods.Add(new FoodClass("Artichokes", 45));
        foods.Add(new FoodClass("Eggplants", 28));
        foods.Add(new FoodClass("Green peas", 93));
        foods.Add(new FoodClass("Canned green peas", 41));
        foods.Add(new FoodClass("Zucchini", 22));
        foods.Add(new FoodClass("Cabbage", 23));
        foods.Add(new FoodClass("Boiled potatoes", 60));
        foods.Add(new FoodClass("Corn", 103));
        foods.Add(new FoodClass("Onion", 45));
        foods.Add(new FoodClass("Carrot", 34));
        foods.Add(new FoodClass("Cucumber", 15));
        foods.Add(new FoodClass("Pickled cucumbers", 8));
        foods.Add(new FoodClass("Pepper", 19));
        foods.Add(new FoodClass("Parsley", 23));
        foods.Add(new FoodClass("Tomatoes", 15));
        foods.Add(new FoodClass("Radish", 25));
        foods.Add(new FoodClass("Salad", 15));
        foods.Add(new FoodClass("Beet", 44));
        foods.Add(new FoodClass("Celery", 38));
        foods.Add(new FoodClass("Pumpkin", 24));
        foods.Add(new FoodClass("Cauliflower", 28));
        foods.Add(new FoodClass("Garlic", 60));
        foods.Add(new FoodClass("Spinach", 17));
        foods.Add(new FoodClass("Avocado", 204));
        foods.Add(new FoodClass("Pineapple", 44));
        foods.Add(new FoodClass("Orange", 45));
        foods.Add(new FoodClass("Watermelon", 40));
        foods.Add(new FoodClass("Banana", 90));
        foods.Add(new FoodClass("Grape", 70));
        foods.Add(new FoodClass("Cherry", 25));
        foods.Add(new FoodClass("Lokhina", 37));
        foods.Add(new FoodClass("Garnet", 52));
        foods.Add(new FoodClass("Grapefruit", 35));
        foods.Add(new FoodClass("Pear", 42));
        foods.Add(new FoodClass("Melon", 45));
        foods.Add(new FoodClass("Blackberry", 32));
        foods.Add(new FoodClass("Strawberry", 48));
        foods.Add(new FoodClass("Fig", 56));
        foods.Add(new FoodClass("Kiwi", 50));
        foods.Add(new FoodClass("Dogwood", 41));
        foods.Add(new FoodClass("Cranberry", 33));
        foods.Add(new FoodClass("Gooseberry", 48));
        foods.Add(new FoodClass("Lemon", 30));
        foods.Add(new FoodClass("Raspberry", 45));
        foods.Add(new FoodClass("Tangerine", 41));
        foods.Add(new FoodClass("Peaches", 45));
        foods.Add(new FoodClass("Plums", 44));
        foods.Add(new FoodClass("Currant", 43));
        foods.Add(new FoodClass("Merry", 53));
        foods.Add(new FoodClass("Bilberry", 44));
        foods.Add(new FoodClass("Apples", 45));
        foods.Add(new FoodClass("Seed", 580));
        foods.Add(new FoodClass("Walnuts Volosky", 650));
        foods.Add(new FoodClass("Cedar nuts", 620));
        foods.Add(new FoodClass("Almond", 600));
        foods.Add(new FoodClass("Pistachios", 620));
        foods.Add(new FoodClass("Hazelnut", 705));
        foods.Add(new FoodClass("Raisins", 280));
        foods.Add(new FoodClass("Fig", 290));
        foods.Add(new FoodClass("Sultana", 310));
        foods.Add(new FoodClass("Dried apricots", 293));
        foods.Add(new FoodClass("Dates", 290));
        foods.Add(new FoodClass("Prunes", 220));
        foods.Add(new FoodClass("Apples", 210));
        foods.Add(new FoodClass("Egg", 65));
        foods.Add(new FoodClass("Mushrooms", 25));
        foods.Add(new FoodClass("Cooked mushrooms", 25));
        foods.Add(new FoodClass("Mushrooms in sour cream", 230));
        foods.Add(new FoodClass("Fried mushrooms", 165));
        foods.Add(new FoodClass("Trimmers", 30));
        foods.Add(new FoodClass("Bagels", 312));
        foods.Add(new FoodClass("Butter pastry", 300));
        foods.Add(new FoodClass("Gingerbread", 330));
        foods.Add(new FoodClass("Crackers", 330));
        foods.Add(new FoodClass("Wheat bread", 265));
        foods.Add(new FoodClass("Rye bread", 210));
        foods.Add(new FoodClass("Yogurt", 51));
        foods.Add(new FoodClass("Kefir", 38));
        foods.Add(new FoodClass("Milk", 60));
        foods.Add(new FoodClass("Condensed milk", 324));
        foods.Add(new FoodClass("Ice cream", 220));
        foods.Add(new FoodClass("Ryazanka", 85));
        foods.Add(new FoodClass("Cream", 300));
        foods.Add(new FoodClass("Sour cream", 115));
        foods.Add(new FoodClass("Curds", 380));
        foods.Add(new FoodClass("Curd mass", 207));
        foods.Add(new FoodClass("Low-fat cheese", 80));
        foods.Add(new FoodClass("Cheese", 357));
        foods.Add(new FoodClass("Green peas", 280));
        foods.Add(new FoodClass("Wheat flour", 348));
        foods.Add(new FoodClass("Rye flour", 347));
        foods.Add(new FoodClass("Semolina", 340));
        foods.Add(new FoodClass("Oat", 374));
        foods.Add(new FoodClass("Pearl", 342));
        foods.Add(new FoodClass("Wheat", 352));
        foods.Add(new FoodClass("Millet", 335));
        foods.Add(new FoodClass("Barley", 343));
        foods.Add(new FoodClass("Cornflakes", 369));
        foods.Add(new FoodClass("Pasta", 350));
        foods.Add(new FoodClass("Muesli", 370));
        foods.Add(new FoodClass("Oat flakes", 305));
        foods.Add(new FoodClass("Millet", 351));
        foods.Add(new FoodClass("Fig", 337));
        foods.Add(new FoodClass("Soy", 395));
        foods.Add(new FoodClass("Bean", 328));
        foods.Add(new FoodClass("Lentil", 310));
        foods.Add(new FoodClass("Barley flakes", 315));
        foods.Add(new FoodClass("Brisket", 533));
        foods.Add(new FoodClass("Shoulder", 380));
        foods.Add(new FoodClass("Dorsal part", 459));
        foods.Add(new FoodClass("Stewed beef", 180));
        foods.Add(new FoodClass("Minced beef", 118));
        foods.Add(new FoodClass("Brisket", 405));
        foods.Add(new FoodClass("Shoulder", 208));
        foods.Add(new FoodClass("Brains", 124));
        foods.Add(new FoodClass("Okovalok", 380));
        foods.Add(new FoodClass("Ham", 308));
        foods.Add(new FoodClass("Liver", 87));
        foods.Add(new FoodClass("Kidneys", 59));
        foods.Add(new FoodClass("Ribs", 446));
        foods.Add(new FoodClass("Heart", 82));
        foods.Add(new FoodClass("Fillet", 189));
        foods.Add(new FoodClass("Ham", 543));
        foods.Add(new FoodClass("Liver", 108));
        foods.Add(new FoodClass("Shoulder", 593));
        foods.Add(new FoodClass("Kidneys", 80));
        foods.Add(new FoodClass("Pork leg", 431));
        foods.Add(new FoodClass("Heart", 90));
        foods.Add(new FoodClass("Fillet", 264));
        foods.Add(new FoodClass("Neck", 552));
        foods.Add(new FoodClass("Schnitzel", 252));
        foods.Add(new FoodClass("Tongue", 208));
        foods.Add(new FoodClass("Brisket", 213));
        foods.Add(new FoodClass("Leg", 161));
        foods.Add(new FoodClass("Ham", 155));
        foods.Add(new FoodClass("Dorsal part", 210));
        foods.Add(new FoodClass("Fillet", 158));
        foods.Add(new FoodClass("Schnitzel", 162));
        foods.Add(new FoodClass("Goose", 390));
        foods.Add(new FoodClass("Turkey", 200));
        foods.Add(new FoodClass("Turkey", 230));
        foods.Add(new FoodClass("Rabbit", 124));
        foods.Add(new FoodClass("Sausage", 380));
        foods.Add(new FoodClass("Korea", 430));
        foods.Add(new FoodClass("Rabbit", 115));
        foods.Add(new FoodClass("Fried chicken", 210));
        foods.Add(new FoodClass("Duck", 405));
        foods.Add(new FoodClass("Pheasant", 143));
        foods.Add(new FoodClass("Chickens", 156));
        foods.Add(new FoodClass("Ham", 365));
        foods.Add(new FoodClass("Cured meat", 264));
        foods.Add(new FoodClass("Diabetic Sausage", 254));
        foods.Add(new FoodClass("Doctor's sausage", 260));
        foods.Add(new FoodClass("Amateur sausage", 291));
        foods.Add(new FoodClass("Krovyan's sausage", 452));
        foods.Add(new FoodClass("Smoked sausage", 507));
        foods.Add(new FoodClass("Liver pate", 314));
        foods.Add(new FoodClass("Tongue sausage", 215));
        foods.Add(new FoodClass("Fat", 248));
        foods.Add(new FoodClass("Salami", 560));
        foods.Add(new FoodClass("Anchovies", 147));
        foods.Add(new FoodClass("Saveloy", 484));
        foods.Add(new FoodClass("Sausages", 204));
        foods.Add(new FoodClass("Spik", 215));
        foods.Add(new FoodClass("Gorbusha", 147));
        foods.Add(new FoodClass("Granular caviar", 250));
        foods.Add(new FoodClass("Caviar roe", 245));
        foods.Add(new FoodClass("Pollock roe", 130));
        foods.Add(new FoodClass("Squid", 75));
        foods.Add(new FoodClass("Flounder", 90));
        foods.Add(new FoodClass("Carp", 87));
        foods.Add(new FoodClass("Chum salmon", 157));
        foods.Add(new FoodClass("Canned fish", 320));
        foods.Add(new FoodClass("Shrimps", 85));
        foods.Add(new FoodClass("Crabs", 70));
        foods.Add(new FoodClass("Bream", 100));
        foods.Add(new FoodClass("Salmon", 145));
        foods.Add(new FoodClass("Macrorus", 60));
        foods.Add(new FoodClass("Mussels", 72));
        foods.Add(new FoodClass("Pollack", 70));
        foods.Add(new FoodClass("Cape", 157));
        foods.Add(new FoodClass("Seaweed", 16));
        foods.Add(new FoodClass("Weight", 44));
        foods.Add(new FoodClass("Sea bass", 95));
        foods.Add(new FoodClass("River perch", 82));
        foods.Add(new FoodClass("Lobster", 82));
        foods.Add(new FoodClass("Cod liver", 613));
        foods.Add(new FoodClass("Crayfish", 75));
        foods.Add(new FoodClass("Salaka", 98));
        foods.Add(new FoodClass("Sevryuga", 137));
        foods.Add(new FoodClass("Atlantic herring", 57));
        foods.Add(new FoodClass("Salmon", 219));
        foods.Add(new FoodClass("Whitefish", 144));
        foods.Add(new FoodClass("Mackerel", 153));
        foods.Add(new FoodClass("Catfish", 154));
        foods.Add(new FoodClass("Scad", 119));
        foods.Add(new FoodClass("Sterlad", 320));
        foods.Add(new FoodClass("Zander", 72));
        foods.Add(new FoodClass("Cod", 59));
        foods.Add(new FoodClass("Trepang", 35));
        foods.Add(new FoodClass("Tuna", 296));
        foods.Add(new FoodClass("River eel", 598));
        foods.Add(new FoodClass("Trout", 208));
        foods.Add(new FoodClass("Hake", 86));
        foods.Add(new FoodClass("Sprats in oil", 250));
        foods.Add(new FoodClass("Pike", 72));
        foods.Add(new FoodClass("Margarine", 675));
        foods.Add(new FoodClass("Peanut oil", 895));
        foods.Add(new FoodClass("Corn oil", 900));
        foods.Add(new FoodClass("Olive oil", 824));
        foods.Add(new FoodClass("Sunflower oil", 900));
        foods.Add(new FoodClass("Butter", 750));
        foods.Add(new FoodClass("Soybean oil", 900));
        foods.Add(new FoodClass("Melted butter", 885));
        foods.Add(new FoodClass("Ketchup", 80));
        foods.Add(new FoodClass("Mayonnaise", 625));
        foods.Add(new FoodClass("Orange juice", 123));
        foods.Add(new FoodClass("Coffee", 1));  
        foods.Add(new FoodClass("Lemonade", 123));
        foods.Add(new FoodClass("Water", 0));  
        foods.Add(new FoodClass("Carrot juice", 68));
        foods.Add(new FoodClass("Vegetable drink", 60));
        foods.Add(new FoodClass("Red currant juice", 125));
        foods.Add(new FoodClass("Blackcurrant juice", 138));
        foods.Add(new FoodClass("Apple juice", 118));
        foods.Add(new FoodClass("Tea", 1)); 
        foods.Add(new FoodClass("Red wine", 74));
        foods.Add(new FoodClass("Apple wine", 37));
        foods.Add(new FoodClass("Whiskey", 240));
        foods.Add(new FoodClass("Cherry liqueur", 300));
        foods.Add(new FoodClass("Vodka", 275));
        foods.Add(new FoodClass("Gin", 33));
        foods.Add(new FoodClass("Liqueur", 325));
        foods.Add(new FoodClass("Cognac", 250));
        foods.Add(new FoodClass("Beer", 45));
        foods.Add(new FoodClass("Slivyanka", 120));
        foods.Add(new FoodClass("Cider", 40));
        foods.Add(new FoodClass("Dry champagne", 85));
        foods.Add(new FoodClass("Schnapps", 200));
        foods.Add(new FoodClass("Waffles", 342));
        foods.Add(new FoodClass("Jam", 294));
        foods.Add(new FoodClass("Fruit dragee", 384));
        foods.Add(new FoodClass("Marshmallow", 300));
        foods.Add(new FoodClass("Iris", 387));
        foods.Add(new FoodClass("Cocoa", 416));
        foods.Add(new FoodClass("Caramel", 296));
        foods.Add(new FoodClass("Honey", 310));
        foods.Add(new FoodClass("Marmalade", 296));
        foods.Add(new FoodClass("Paste", 305));
        foods.Add(new FoodClass("Butter", 270));
        foods.Add(new FoodClass("Sugar", 380));
        foods.Add(new FoodClass("Almond cake", 524));
        foods.Add(new FoodClass("Halva", 510));
        foods.Add(new FoodClass("Chocolate", 540));
        foods.Add(new FoodClass("Milk chocolate", 548));
    }
}

public class FoodClass
{

    public FoodClass(string name, int calories)
    {
        this.name = name;
        this.caloriesIn100Grams = caloriesIn100Grams;
    }

    public string name;
    private int grams;
    private int caloriesIn100Grams;
    private int totalCalories;
    private void SetGrams(int grams)
    {
        this.grams = grams;
        totalCalories = (caloriesIn100Grams / 100) * grams; 
    }
}

