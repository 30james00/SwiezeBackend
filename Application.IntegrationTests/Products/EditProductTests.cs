using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Products;
using Application.Products.EditProduct;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence;

namespace Application.IntegrationTests.Products
{
    using static Testing;

    public class EditProductTests : TestBase
    {
        private readonly EditProductCommand _command = new EditProductCommand
        {
            Name = "Carrot",
            Value = 1000,
            Unit = 1234,
            Stock = 2000,
            UnitTypeId = GuidHelper.ToGuid(1),
            Categories = new List<Guid> { GuidHelper.ToGuid(1) },
            Photos = new List<string>()
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

        private readonly Product _product = new Product
        {
            Name = "Carrot",
            Value = 1000,
            Unit = 1234,
            Stock = 2000,
            UnitTypeId = GuidHelper.ToGuid(1),
        };

        [SetUp]
        public async Task SetUp()
        {
            var vendorId = (await RunAsVendorUserAsync()).Item2;

            _product.VendorId = vendorId;
        }

        [Test]
        public async Task EditNewProduct()
        {
            //arrange
            await AddAsync(_unitType);
            await AddAsync(_category);
            _command.Id = (await AddAsync(_product)).Id;

            //act
            var result = await SendAsync(_command);

            //assert
            var newProduct = await FindAsync<Product>(result.Value.Id);

            result.Value.Should().BeOfType<ProductDto>();
            result.Value.Should().BeEquivalentTo(_command, o => o.ExcludingMissingMembers());
            newProduct.Should().BeEquivalentTo(_command, o => o.ExcludingMissingMembers().Excluding(x => x.Photos));
        }

        [Test]
        public async Task EditNewProductAsNotOwner()
        {
            await AddAsync(_unitType);
            await AddAsync(_category);
            _command.Id = (await AddAsync(_product)).Id;

            //log in as other Vendor
            await RunAsVendor2UserAsync();

            var result = await SendAsync(_command);

            result.IsForbidden.Should().BeTrue();
        }

        [Test]
        public async Task EditNonExitingProduct()
        {
            _command.Id = Guid.NewGuid();

            var result = await SendAsync(_command);

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Chosen Product doesn't exist");
        }

        [Test]
        public async Task EditNewProductAsClient()
        {
            await RunAsClientUserAsync();

            await AddAsync(_unitType);
            await AddAsync(_category);
            _command.Id = (await AddAsync(_product)).Id;

            var result = await SendAsync(_command);

            result.Error.Should().Be("Failed to edit new Product - user is not Vendor");
        }

        [Test]
        public async Task EditNewProductWithFakeCategory()
        {
            await AddAsync(_unitType);
            _command.Id = (await AddAsync(_product)).Id;

            var result = await SendAsync(_command);

            result.Error.Should().Be("Chosen Category doesn't exist");
        }

        [Test]
        public async Task EditNewProductWithFakeUnitType()
        {
            await AddAsync(_unitType);
            _command.Id = (await AddAsync(_product)).Id;
            _command.UnitTypeId = GuidHelper.ToGuid(2);

            var result = await SendAsync(_command);

            result.Error.Should().Be("Chosen UnitType doesn't exist");
        }
    }
}