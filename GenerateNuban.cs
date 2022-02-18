 public abstract class GenerateNuban{
    public abstract string generate(long firstEightDigit);

    public string generate(){
        return new Nuban(00000000, 1).ToString();
    }

    public string generate(long firstEightDigit, int lastnumber){
        return new Nuban(firstEightDigit, lastnumber).ToString();
    }
}