class AccountOpeningImpl : GenerateNuban, AccountOpening{

    public CustomerAccount collectKYC(CustomerAccount customerAccount){
        return null;
    }
    public bool validateKYC(string bvn){
        return false;
    }
    public bool checkCustomerExist(string email, string phone){
        return false;
    }
    public CustomerAccount createAccount(CustomerAccount customerAccount){
        return null;
    }

    public override string generate(long firstEightDigit){
        return new Nuban(firstEightDigit, 1).ToString();
    }
}