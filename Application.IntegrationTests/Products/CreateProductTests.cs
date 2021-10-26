using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Products;
using Application.Products.CreateProduct;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence;

namespace Application.IntegrationTests.Products
{
    using static Testing;

    public class CreateContactTests : TestBase
    {
        private readonly CreateProductCommand _command = new CreateProductCommand
        {
            Name = "Carrot",
            Value = 1000,
            Unit = 1234,
            Stock = 2000,
            UnitTypeId = GuidHelper.ToGuid(1),
            Categories = new List<Guid> { GuidHelper.ToGuid(1) },
        };

        private readonly UnitType _unitType = new UnitType
        {
            Id = GuidHelper.ToGuid(1),
            Name = "g"
        };

        private readonly Category _category = new Category
        {
            Id = GuidHelper.ToGuid(1),
            Name = "Test",
            Description = "Test",
        };

        [Test]
        public async Task CreateNewProduct()
        {
            await RunAsVendorUserAsync();

            await AddAsync(_unitType);
            await AddAsync(_category);

            var result = await SendAsync(_command);

            var product = await FindAsync<Product>(result.Value.Id);

            result.Value.Should().BeOfType<ProductDto>();
            result.Value.Should().BeEquivalentTo(_command, o => o.ExcludingMissingMembers());
            product.Should().BeEquivalentTo(_command, o => o.ExcludingMissingMembers());
        }        
        
        [Test]
        public async Task CreateNewProductAsClient()
        {
            await RunAsClientUserAsync();

            await AddAsync(_unitType);
            await AddAsync(_category);

            var result = await SendAsync(_command);

            result.Error.Should().Be("Failed to create new Product - user is not Vendor");
        }        
        
        [Test]
        public async Task CreateNewProductWithFakeCategory()
        {
            await RunAsVendorUserAsync();

            await AddAsync(_unitType);

            var result = await SendAsync(_command);

            result.Error.Should().Be("Chosen Category doesn't exist");
        }        
        
        [Test]
        public async Task CreateNewProductWithFakeUnitType()
        {
            await RunAsVendorUserAsync();

            await AddAsync(_category);

            var result = await SendAsync(_command);

            result.Error.Should().Be("Chosen UnitType doesn't exist");
        }
    }
}