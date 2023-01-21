using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarUnitTest
{
    public class UserManagementTest
    {
        [Fact]
        public void CreateUserTest()
        {
            //arrange
            var userManagement = new UserManagement();

            //act
            userManagement.CreateUser(new("rafif", "raihanudin"));

            //assert
            var savedUser = Assert.Single(userManagement.AllUser);
            Assert.NotNull(savedUser);
        }

        [Fact]
        public void CheckFirstName()
        {
            //arrange
            var userManagement = new UserManagement();

            //act
            userManagement.CreateUser(new("Madara", "Uchiha"));

            //assert
            var savedUser = Assert.Single(userManagement.AllUser);

            Assert.Equal("Madara", savedUser.FisrtName);
        }

        [Fact]
        public void VerifyEmailTest()
        {
            //arrange
            var userManagemnet = new UserManagement();

            //act
            userManagemnet.CreateUser(new("Sasuke", "uchiha"));
            var userEmails = userManagemnet.AllUser.ToList().First();
            userManagemnet.VerifyEmail(userEmails.Id);

            //Aserrt
            var savedUser = Assert.Single(userManagemnet.AllUser);
            Assert.True(savedUser.VerifiedEmail);

        }

        [Fact]
        public void UpdatePhoneTest()
        {
            //arrange
            var userManagement = new UserManagement();

            //act
            userManagement.CreateUser(new("Madara", "Uchiha"));

            var fistUser = userManagement.AllUser.ToList().First();
            fistUser.Phone = "08978999";
            userManagement.UpdatePhone(fistUser);

            //Assert
            var savedUser = Assert.Single(userManagement.AllUser);
            Assert.Equal("08978999", savedUser.Phone);
        }
    }
}
