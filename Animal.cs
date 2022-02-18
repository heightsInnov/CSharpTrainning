abstract class Animal{

    protected int numberOfLegs{get; set;}

    public abstract string sound();

    public string feeding(){
        return "It is either a canivore or herbivore";
    }

    public string sell(decimal sellingPrice){
        return sellingPrice.ToString();
    }
}