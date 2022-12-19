using OopPolymorphismOverloading;

BasicMath math1 = new();
BasicMath math2 = new(5, 6);
BasicMath math3 = new(5);
BasicMath math4 = new(numberTwo: 5);

//object initializec
BasicMath math5 = new()
{
    NumberOne = 1,
    NumberTwo = 2
}