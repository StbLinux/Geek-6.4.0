using Geek.AbpGeek.Auditing;
using Shouldly;
using Xunit;

namespace Geek.AbpGeek.Tests.Auditing
{
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("Geek.AbpGeek.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("Geek.AbpGeek.Auditing.GenericEntityService`1[[Geek.AbpGeek.Storage.BinaryObject, Geek.AbpGeek.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("Geek.AbpGeek.Auditing.XEntityService`1[Geek.AbpGeek.Auditing.AService`5[[Geek.AbpGeek.Storage.BinaryObject, Geek.AbpGeek.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[Geek.AbpGeek.Storage.TestObject, Geek.AbpGeek.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
