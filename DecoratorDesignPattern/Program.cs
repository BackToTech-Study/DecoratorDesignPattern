// See https://aka.ms/new-console-template for more information

using DecoratorDesignPattern;
using DecoratorDesignPattern.Chicken;
using DecoratorDesignPattern.Drinks;
using DecoratorDesignPattern.Drinks.Sizes;
using DecoratorDesignPattern.Garnishes;

IMeal meal = new Meal();

meal = new Fires(meal);
meal = new CrispyChickenWings(meal);
meal = new Coke(new LargeDrink(), meal);

var content = string.Join(", ", meal.Content);
var message = $"Order: {content} - {meal.GetPrice()}$";
Console.WriteLine(message);