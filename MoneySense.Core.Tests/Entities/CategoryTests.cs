using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneySense.Core.Domain.Entities;
using MoneySense.Core.Domain.Enums;
using MoneySense.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MoneySense.Core.Tests.Entities
{
    [TestClass]
    public class CategoryTests
    {
        private readonly Category _category;
        private readonly Description _description;
        private readonly Transaction _transaction;
        private readonly Coin _coin;
        public CategoryTests()
        {
            _coin = new Coin(2);
            _description = new Description("Gastos com alimentos no supermercado");
            _transaction = new Transaction(_coin, _description, DateTime.Now);
            _category = new Category("Alimentadação", _description, "🌮", ECategoryType.Income);
        }
        [TestMethod]
        public void ReturnSuccessWhenAddCategory()
        {
            _transaction.AddCategory(_category);
            Assert.IsTrue(_transaction.IsValid);
        }
    }
}
