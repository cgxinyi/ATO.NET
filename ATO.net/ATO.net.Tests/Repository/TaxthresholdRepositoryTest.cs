using ATO.net.Models;
using ATO.net.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Xunit;

namespace ATO.net.Tests.Repository
{
    [TestClass]
    public class TaxthresholdRepositoryTest
    {
        TaxthresholdRepository taxthresholdRepo = new TaxthresholdRepository();
        [TestMethod]
        public void TestHasRows()
        {
            var readerMock = new Mock<IDataReader>();

            readerMock.SetupSequence(_ => _.Read())
                .Returns(true)
            .Returns(false);

            readerMock.Setup(reader => reader.GetOrdinal("taxthresholdId")).Returns(0);
            readerMock.Setup(reader => reader.GetOrdinal("taxMin")).Returns(1);
            readerMock.Setup(reader => reader.GetOrdinal("taxCent")).Returns(2);
            readerMock.Setup(reader => reader.GetOrdinal("taxLump")).Returns(3);

            var commandMock = new Mock<IDbCommand>();
            commandMock.Setup(m => m.ExecuteReader()).Returns(readerMock.Object).Verifiable();

            var connectionMock = new Mock<IDbConnection>();
            connectionMock.Setup(m => m.CreateCommand()).Returns(commandMock.Object);

            var data = new Taxthreshold(() => connectionMock.Object);

            //Act
            Boolean result = taxthresholdRepo.HasRows();

            //Assert - FluentAssertions
            Assert.AreEqual(result, true);
        }

        
    }


}
