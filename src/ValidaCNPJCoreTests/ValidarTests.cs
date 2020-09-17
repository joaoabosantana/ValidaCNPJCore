using NUnit.Framework;
using ValidaCNPJCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValidaCNPJCore.Tests
{
    [TestFixture()]
    public class ValidarTests
    {
        [Test()]
        public void CNPJTest()
        {
            Assert.That(Validar.CNPJ(Convert.ToString(37048599000143)), Is.True);
            Assert.That(Validar.CNPJ(Convert.ToString(37043599000145)), Is.False);
        }
    }
}