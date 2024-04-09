using Assignment4_C_.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_C_
{
    public class Operations
    {
        private Assignment4Context dbContext;
        public Operations()
        {
            dbContext = new Assignment4Context();
        }
        public int checkUser(string username, string password)
        {
            var user = dbContext.Users.FirstOrDefault(u => u.Email == username && u.Password == password);
            return user != null ? user.Id : 0; // Return user ID if authentication successful, otherwise 0
        }

        public Account GetAccountDetails(int userId)
        {
            return dbContext.Accounts.FirstOrDefault(a => a.UserId == userId);
        }

        public void AddTransaction(int accountId, decimal amount, string description)
        {
            var account = dbContext.Accounts.FirstOrDefault(a => a.AccountId == accountId);
            if (account != null)
            {
                // Debit the account balance
                account.CurrentBalance = ((double)(account.CurrentBalance ?? 0) - (double)amount);
                // Add transaction
                var trans= new TransactionHistory
                {
                    AccountId = accountId,
                    Amount = amount, 
                    Description = description
                };

                dbContext.TransactionHistories.Add(trans);
                dbContext.SaveChanges();
            }
        }
        public TransactionHistory GetTransactionById(int transId)
        {
            return dbContext.TransactionHistories.FirstOrDefault(t => t.TransactionId == transId);
        }


        public void UpdateTransaction(int transactionId, decimal newAmount, string newDescription)
        {
            var transaction = dbContext.TransactionHistories.FirstOrDefault(t => t.TransactionId == transactionId);
            if (transaction != null)
            {
                decimal oldAmount = (decimal)transaction.Amount;

                transaction.Amount = newAmount;
                transaction.Description = newDescription;
                dbContext.SaveChanges();

                decimal diff = newAmount - oldAmount;

                var account = dbContext.Accounts.FirstOrDefault(a => a.AccountId == transaction.AccountId);
                if (account != null)
                {
                    if (newDescription.ToLower().Contains("deposit"))
                    {
                        account.CurrentBalance += (double)diff;
                    }
                    else if (newDescription.ToLower().Contains("withdraw"))
                    {
                        account.CurrentBalance -= (double)diff;
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        public void DeleteTransaction(int transactionId)
        {
            var trans = dbContext.TransactionHistories.FirstOrDefault(t => t.TransactionId == transactionId);
            if (trans != null)
            {
                // Credit the account balance
                var account = dbContext.Accounts.FirstOrDefault(a => a.AccountId == trans.AccountId);
                if (account != null)
                {
                    account.CurrentBalance += (double)trans.Amount;
                }

                // Delete transaction
                dbContext.TransactionHistories.Remove(trans);
                dbContext.SaveChanges();
            }
        }
        public List<object> GetUserAccountTransactions(int userId)
        {
            var query = from transaction in dbContext.TransactionHistories
                        join account in dbContext.Accounts on transaction.AccountId equals account.AccountId
                        join user in dbContext.Users on account.UserId equals user.Id
                        where account.UserId == userId
                        select new
                        {
                            TransactionId = transaction.TransactionId,
                            AccountId = transaction.AccountId,
                            FirstName = user.Firstname,
                            LastName = user.Lastname,
                            Amount = transaction.Amount,
                            CurrentBalance = account.CurrentBalance,
                            Description = transaction.Description,
                            TransactionDate = transaction.TransactionDate,
                        };

            return query.ToList<object>();
        }
    }
}
