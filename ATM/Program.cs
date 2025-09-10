// See https://aka.ms/new-console-template for more information

using ATM;

Customer Alisa = new Customer()
{
    customerNo = 1,
    dateOfBirth = "1/1/1990",
    firstName = "Alisa",
    lastName = "Blakeney"
};

Account AlisasAccount = new Account("23498234", 50, "password", Alisa);

Card AlisaCard = new Card()
{
    cardNumber = 023480984356734985,
    owner = Alisa,
    pin = 1234
};

AlisaCard.AddAccount(AlisasAccount);

Branch branch = new Branch();

ATM_Machine atm = new ATM_Machine(1, branch);

ATM_Transaction atm_transaction = new ATM_Transaction(atm, new DateTime());

atm_transaction.Action(AlisaCard);