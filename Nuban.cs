class Nuban{
    //Length of 9
    public long accountNumber {get; set;}

    //lenght of 1
    public int checkNumber {get; set;}

    public Nuban(long _accountNumber, int _checkNumber){
        accountNumber = _accountNumber;
        checkNumber = _checkNumber;
    }

    public override string ToString(){
        return accountNumber.ToString()+checkNumber.ToString();
    }  

}