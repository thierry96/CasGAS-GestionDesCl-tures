using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace casGSB
{   
    [TestFixture]
    class UnitTest
    {
        [Test]
        public void getMoisPrecedent()
        {
            Assert.AreEqual("03",casGSB.DateGsb.getMoisPrecedent());
        }

        [Test]
        public void getMoisPrecedentPar()
        {
            Assert.AreEqual("03", casGSB.DateGsb.getMoisPrecedent(DateTime.Today));
        }

        [Test]
        public void getMoisSuivant()
        {
            Assert.AreEqual("05", casGSB.DateGsb.getMoisSuivant());
        }
        [Test]
        public void getMoisSuivantPar()
        {
            Assert.AreEqual("05", casGSB.DateGsb.getMoisSuivant(DateTime.Today));
        }

        [Test]
        public void entre()
        {
            Assert.AreEqual(true , casGSB.DateGsb.entre(01 , 05));
        }
        [Test]
        public void entrePar()
        {
            Assert.AreEqual(true, casGSB.DateGsb.entre(01, 05 , DateTime.Today));
        }

        [Test]
        public void getYear()
        {
            Assert.AreEqual("2015", casGSB.DateGsb.getYear(DateTime.Today));
        }
    }
}
