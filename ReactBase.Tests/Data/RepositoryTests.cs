using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactBase.Data;
using Xunit;

namespace ReactBase.Tests.Data
{
    public class RepositoryTests
    {
        private Repository Repository { get; set; }

        public RepositoryTests()
        {
            Repository = new Repository();
        }

        [Fact]
        public void TestPing()
        {
            var item = Repository.Ping();
            Assert.Equal("Pong", item);
        }
    }
}
