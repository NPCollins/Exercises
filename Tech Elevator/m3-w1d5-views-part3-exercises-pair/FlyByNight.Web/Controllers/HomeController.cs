using FlyByNight.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNight.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/BankAccountList
        public ActionResult BankAccountList()
        {
            List<BankAccount> model = GetBankAccounts();

            return View("BankAccountList", model);
        }

        // GET: Home/BankAccountDetail/{id}
        public ActionResult BankAccountDetail(string id)
        {
            List<BankAccount> accounts = GetBankAccounts();
            BankAccount model = null;

            foreach (var account in accounts)
            {
                if (id.ToLower() == account.Id.ToLower())
                {
                    model = account;
                    break;
                }
            }

            return View("BankAccountDetail", model);
        }







        // DONT MODIFY THESE
        private List<BankAccount> GetBankAccounts()
        {
            List<BankAccount> accounts = new List<BankAccount>();

            BankAccount acct = new BankAccount()
            {
                Id = "interest-free-checking",
                AccountNickname = "Interest Free Checking",
                AccountNumber = "XXXX1234",
                AccountType = "Checking",
                Balance = new DollarAmount(4300, 23),
            };
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(-6, 23), Date = new DateTime(2016, 06, 10), Description = "Starbucks" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(-12, 10), Date = new DateTime(2016, 06, 12), Description = "Best Buy" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(-132, 03), Date = new DateTime(2016, 06, 13), Description = "Costco" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(-253, 23), Date = new DateTime(2016, 06, 15), Description = "Ty Phun" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(1253, 23), Date = new DateTime(2016, 06, 15), Description = "Payroll" });
            accounts.Add(acct);

            acct = new BankAccount()
            {
                Id = "save-a-lot-savings",
                AccountNickname = "Save-A-Lot Savings",
                AccountNumber = "XXXX5678",
                AccountType = "Savings",
                Balance = new DollarAmount(12132, 01),
            };
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(-16, 23), Date = new DateTime(2016, 03, 10), Description = "Transfer" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(16, 10), Date = new DateTime(2016, 04, 12), Description = "Deposit" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(-122, 03), Date = new DateTime(2016, 05, 13), Description = "Costco" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(1223, 23), Date = new DateTime(2016, 06, 15), Description = "Transfer" });
            accounts.Add(acct);

            acct = new BankAccount()
            {
                Id = "high-interest-savings",
                AccountNickname = "High-Interest Savings",
                AccountNumber = "XXXX1111",
                AccountType = "Savings",
                Balance = new DollarAmount(32, 99),
            };
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(100, 03), Date = new DateTime(2016, 06, 11), Description = "Deposit" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(-67, 23), Date = new DateTime(2016, 06, 12), Description = "Transfer" });
            accounts.Add(acct);

            acct = new BankAccount()
            {
                Id = "priority-checking",
                AccountNickname = "Priority Checking",
                AccountNumber = "XXXX9999",
                AccountType = "Checking",
                Balance = new DollarAmount(500, 10),
            };
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(1300, 03), Date = new DateTime(2016, 06, 11), Description = "Deposit" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(167, 23), Date = new DateTime(2016, 06, 12), Description = "Deposit" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(-267, 23), Date = new DateTime(2016, 06, 12), Description = "Amazon.com" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(-6, 23), Date = new DateTime(2016, 06, 12), Description = "Redbox" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(-7, 23), Date = new DateTime(2016, 06, 12), Description = "Starbucks" });
            acct.Transactions.Add(new Transaction() { Amount = new DollarAmount(-167, 23), Date = new DateTime(2016, 06, 12), Description = "Gas Bill" });
            accounts.Add(acct);


            return accounts;
        }

    }
}