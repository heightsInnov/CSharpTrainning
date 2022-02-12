public class CustomerAccount{
    //Instance variable: Are variables declared outside of methods, constructors, blocks but within a class.

    /*
        Types of variables
        - Instance
        - Local
        - Global
    */

    public string customerName {get; set;}
    public string country {get; set;}
    public long bvn;
    public string accountNumber {get; set;}
    public string accountType {get; set;}
    public string accountTier {get; set;}
    public decimal balance {get; set;}
    public long accountLimit {get; set;}
    public char gender {get; set;}
    public string address {get; set;}
    public int domicileBranch {get; set;}
    public bool isClosed {get; set;}

    //Class Constructors
    /*
        Constructors are class methods with the same name as the class.
        It is used to instantiate/kickstart/create/innitialize members of a class at creation time.
        All classes come with a default constructor:
            A default constructor is a constructor that has no arguement.
            It is created by default and not visible unless manually created or overriden.
    */

    //Default Constructor
    public CustomerAccount(){

    }

    //Arguement Constructor
    public CustomerAccount(string _customerName, char _gender, int _domicileBranch, long _bvn){
        isClosed = false;
        customerName = _customerName;
        gender = _gender;
        domicileBranch = _domicileBranch;
        bvn =_bvn;
        balance = 0L;
    }

    void debit(decimal amount){
        balance = balance - amount;
    }

    void credit(decimal amount){
        balance = balance + amount;
    }

    void closeAccount(){
        isClosed = true;
    }

}