//Change the name of the namespace to your project name
namespace Polymorphism
{
    internal class Program
    {

        static void Main(string[] arg)
        {

            //Bank Account Example-03


            BankAccount myBankAccount = new BankAccount() {AccountNo="123567896", Balance = 1000, Title="Sadeed Ashraf"};
                       
            myBankAccount.Deposit(500);

            myBankAccount.Withdraw(1000);
            myBankAccount.Withdraw(600);
            myBankAccount.Withdraw(400);
            myBankAccount.Withdraw(600);
            myBankAccount.CheckBalance();







            /*
            //Educational Institution Staff Example-02

            Staff myStaff = new Staff();

            Staff myTeacher = new Teachers() { Name = "Sadeed", Id=222333, subject= "Javascript"};
            Staff myAdministrator = new Administrator() { Name = "Anurag"};

            myTeacher.ShowRole();

            myAdministrator.ShowRole();
            */

            /*
            //Animal Example-01

            Animal myAnimal = new Animal();

            Animal myDog = new Dog();
            Animal myCat = new Cat();



            myAnimal.animalSound();
            myDog.animalSound();
            myCat.animalSound();

            */



            /*
            Cat c1 = new Cat();
            //c1.catSound();
            c1.animalSound();

            Dog d1 = new Dog();
            //d1.dogSound();
            d1.animalSound();
            */
        }

    }


}