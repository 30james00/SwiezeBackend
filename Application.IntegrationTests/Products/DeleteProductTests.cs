using System;
using System.Threading.Tasks;
using Application.Core;
using Application.Products;
using Domain;
using FluentAssertions;
using MediatR;
using NUnit.Framework;
using Persistence;

namespace Application.IntegrationTests.Products
{
    using static Testing;

    public class DeleteProductTests : TestBase
    {
        private readonly Product _product = new Product
        {
            Name = "Carrot",
            Value = 1000,
            Unit = 1234,
            Stock = 2000,
            UnitTypeId = GuidHelper.ToGuid(1),
        };

        private readonly UnitType _unitType = new UnitType
        {
            Id = GuidHelper.ToGuid(1),
            Name = "g"
        };

        [Test]
        public async Task DeleteProduct()
        {
            var vendorId = (await RunAsVendorUserAsync()).Item2;
            _product.VendorId = vendorId;

            await AddAsync(_unitType);
            var productId = (await AddAsync(_product)).Id;

            var result = await SendAsync(new DeleteProductCommand(productId));

            var check = await FindAsync<Product>(productId);

            result.Should().BeOfType<ApiResult<Unit>>();
            check.Should().BeNull();
        }

        [Test]
        public async Task DeleteNonExistingProduct()
        {
            var result = await SendAsync(new DeleteProductCommand(Guid.NewGuid()));

            result.IsSuccess.Should().BeFalse();
        }

        [Test]
        public async Task DeleteProductAsOtherVendor()
        {
            var vendorId = (await RunAsVendorUserAsync()).Item2;
            _product.VendorId = vendorId;

            await RunAsVendor2UserAsync();

            await AddAsync(_unitType);
            var productId = (await AddAsync(_product)).Id;

            var result = await SendAsync(new DeleteProductCommand(productId));

            result.IsForbidden.Should().BeTrue();
        }
    }
}