using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSite.Models
{
    public class DbInitializer
    {
        public static void Initialize(BankingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{Id=9258,FirstName="Carson",LastName="Alexander",Birthday=DateTime.Parse("1985-09-01"), Address="180 chemin de la grange, 01360 Béligneux"},
            new User{Id=2349,FirstName="Meredith",LastName="Alonso",Birthday=DateTime.Parse("1986-09-01"), Address="181 chemin de la grange, 01360 Béligneux"},
            new User{Id=8346,FirstName="Arturo",LastName="Anand",Birthday=DateTime.Parse("1978-09-01"), Address="182 chemin de la grange, 01360 Béligneux"},
            new User{Id=5212,FirstName="Gytis",LastName="Barzdukas",Birthday=DateTime.Parse("1961-09-01"), Address="183 chemin de la grange, 01360 Béligneux"},
            new User{Id=9866,FirstName="Yan",LastName="Li",Birthday=DateTime.Parse("1996-09-01"), Address="184 chemin de la grange, 01360 Béligneux"},
            new User{Id=2178,FirstName="Peggy",LastName="Justice",Birthday=DateTime.Parse("1973-09-01"), Address="185 chemin de la grange, 01360 Béligneux"},
            new User{Id=7569,FirstName="Laura",LastName="Norman",Birthday=DateTime.Parse("1979-09-01"), Address="186 chemin de la grange, 01360 Béligneux"},
            new User{Id=6589,FirstName="Nino",LastName="Olivetto",Birthday=DateTime.Parse("1985-09-01"), Address="187 chemin de la grange, 01360 Béligneux"}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var accounts = new Account[]
            {
            new Account{Id=1050,Number="11564678521641",Balance=1280.0f},
            new Account{Id=4022,Number="34343543453451",Balance=1520.0f},
            new Account{Id=4041,Number="14354345433454",Balance=150.0f},
            new Account{Id=1045,Number="15434535454545",Balance=4152.0f},
            new Account{Id=3141,Number="53455923945865",Balance=1650.0f},
            new Account{Id=2021,Number="45345347856631",Balance=162.0f},
            new Account{Id=2042,Number="36589678536361",Balance=6152.0f},
            new Account{Id=2442,Number="19546412476534",Balance=620.0f}
            };
            foreach (Account a in accounts)
            {
                context.Accounts.Add(a);
            }
            context.SaveChanges();

            var userAccounts = new UserAccount[]
            {
            new UserAccount{UserId=9258,AccountId=1050},
            new UserAccount{UserId=2349,AccountId=4022},
            new UserAccount{UserId=8346,AccountId=4041},
            new UserAccount{UserId=5212,AccountId=1045},
            new UserAccount{UserId=9866,AccountId=3141},
            new UserAccount{UserId=2178,AccountId=2021},
            new UserAccount{UserId=7569,AccountId=2042},
            new UserAccount{UserId=6589,AccountId=2442},
            };
            foreach (UserAccount ua in userAccounts)
            {
                context.UserAccounts.Add(ua);
            }
            context.SaveChanges();

            var transactions = new Transaction[]
            {
            new Transaction{AccountId=4041,Date=DateTime.Parse("2021-03-05 14:30"),Amount=-1000.0f},
            new Transaction{AccountId=2042,Date=DateTime.Parse("2021-03-05 14:30"),Amount=1000.0f},
            new Transaction{AccountId=2042,Date=DateTime.Parse("2021-05-02 11:30"),Amount=550.0f},
            new Transaction{AccountId=1045,Date=DateTime.Parse("2021-07-01 16:30"),Amount=100.0f},
            new Transaction{AccountId=4022,Date=DateTime.Parse("2021-09-01 10:30"),Amount=200.0f},
            };
            foreach (Transaction t in transactions)
            {
                context.Transactions.Add(t);
            }
            context.SaveChanges();
        }
    }
}