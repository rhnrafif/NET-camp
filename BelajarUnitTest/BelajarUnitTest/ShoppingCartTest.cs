using MainApps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarUnitTest
{
    public class ShoppingCartTest
    {
        public class DbServiceMock : IDbService
        {
            public bool ProcessResult { get; set; }
            public Product ProductBeingProcessed { get; set; }
            public int ProductIdBeingProcessed { get; set; }

            public bool RemoveCartItem(int? id)
            {
                if (id != null)
                    ProductIdBeingProcessed = Convert.ToInt32(id);

                return ProcessResult;
            }

            public bool SaveCartItem(Product product)
            {
                ProductBeingProcessed = product;
                return ProcessResult;
            }

            public bool UpdateCartItem(Product product)
            {
                ProductBeingProcessed = product;
                return ProcessResult;
            }


        }

        [Fact]
        public void AddProduct_Succes()
        {
            var dbMock = new DbServiceMock();
            dbMock.ProcessResult = true;

            //Arrange
            ShoppingCart shopping = new (dbMock);

            //Act
            var product = new Product(1, "Kopi", 3000);
            var result = shopping.AddProduct(product);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void AddProduct_SuccesEqual()
        {
            var dbMock = new DbServiceMock();
            dbMock.ProcessResult = true;

            //Arrange
            ShoppingCart shopping = new(dbMock);

            //Act
            var product = new Product(1, "Kopi", 3000);
            var result = shopping.AddProduct(product);

            //Assert
            Assert.Equal(product, dbMock.ProductBeingProcessed);
        }

        [Fact]
        public void AddProduct_Failure()
        {
            var dbMock = new DbServiceMock();
            dbMock.ProcessResult = true;

            //Arrange
            ShoppingCart shopping = new(dbMock);

            //Act
            var result = shopping.AddProduct(null);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void AddProduct_FailureById()
        {
            var dbMock = new DbServiceMock();
            dbMock.ProcessResult = true;

            //Arrange
            ShoppingCart shoppingCart = new(dbMock);

            //Act
            var result = shoppingCart.AddProduct(new(0, "Kopi", 9000));

            //Assert
            Assert.False(result);
        }

        //Update Cart

        [Fact]
        public void UpdateProduct_Succes()
        {
            var dbMock = new DbServiceMock();
            dbMock.ProcessResult = true;

            //Arrange
            ShoppingCart shoppingCart = new(dbMock);

            //Act
            var product = new Product(1, "Kopi", 340098);
            var result = shoppingCart.UpdateProduct(product);

            //Assert
            Assert.True(result);

        }

        //Remove
        [Fact]
        public void RemoveProduct_Succes()
        {
            var dbMock = new DbServiceMock();
            dbMock.ProcessResult = true;

            //Arrange
            ShoppingCart shoppingCart = new(dbMock);

            //Act
            var product = new Product(1, "Shoes", 900);
            var result = shoppingCart.DeleteProduct(product.Id);

            //Assert
            Assert.True(result);
            Assert.Equal(product.Id, dbMock.ProductIdBeingProcessed);
        }

        [Fact]
        public void RemoveProduct_Failed()
        {
            var dbMock = new DbServiceMock();
            dbMock.ProcessResult = true;

            //Arrange
            ShoppingCart shoppingCart = new(dbMock);

            //Act
            var result = shoppingCart.DeleteProduct(null);

            //Assert
            Assert.False(result);

        }

        [Fact]
        public void RemoveProduct_Failed_InvaildId()
        {
            var dbMock = new DbServiceMock();
            dbMock.ProcessResult = true;

            //Arrange
            ShoppingCart shoppingCart = new(dbMock);

            //Act
            var result = shoppingCart.DeleteProduct(0);

            //Assert
            Assert.False(result);
        }

    }

    
}
