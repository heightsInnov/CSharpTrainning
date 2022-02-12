public interface AccountOpening{

    CustomerAccount collectKYC(CustomerAccount customerAccount);
    bool validateKYC(string bvn);
    bool checkCustomerExist(string email, string phone);
    CustomerAccount createAccount(CustomerAccount customerAccount);
}