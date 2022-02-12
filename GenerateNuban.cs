 public abstract class GenerateNuban{
    public abstract string generate(long firstEightDigit);

    public string defaultNuban(){
        return new Nuban(00000000, 1).ToString();
    }
}