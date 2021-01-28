using NUnit.Framework;
using WorkOnlineBeta.DTOS;
using WorkOnlineBeta.Mappers;
using WorkOnlineBeta.Models;

namespace NUnitTestWorkOnlineBeta
{
    public class Tests
    {

        [Test]
        public void TestHashPassExpectSucess()
        {
            string pass = "wsb";
            LoginDTO login = new LoginDTO();
            Assert.AreEqual("Fa5FoR9fydutFC+64UcIn9kbdt4bfjd1UbIlR1wPv3g=", login.hashPassword(pass));
        }
        [Test]
        public void TestHashPassExpectFail()
        {
            string pass = "wsb1";
            LoginDTO login = new LoginDTO();
            Assert.AreNotEqual("Fa5FoR9fydutFC+64UcIn9kbdt4bfjd1UbIlR1wPv3g=", login.hashPassword(pass));
        }

        [Test]
        public void TestCompanyMapper()
        {
            Adress adress = new Adress()
            {
                Id = 1,
                StreetName = "Test",
                StreetNumber = 1,
                ApartmentNumber = 1,
                PostCode = "11-111",
                City = "Test"
            };

            Company company = new Company()
            {
                Id = 1,
                CompanyName = "Test",
                Login = "Test",
                Password = "Test",
                Email = "Test@test.test",
                PhoneNumber = "+48666666666",
                NIP = "5842751989",
                SessionId = "",
                AdressId = 1
            };

            CompanyDTO companyDto = new CompanyDTO()
            {
                Id = 1,
                CompanyName = "Test",
                Email = "Test@test.test",
                PhoneNumber = "+48666666666",
                NIP = "5842751989",
                StreetName = "Test",
                StreetNumber = 1,
                ApartmentNumber = 1,
                PostCode = "11-111",
                City = "Test"
            };


            Assert.AreEqual(companyDto.Id, new CompanyMapper().GetCompanyDTO(company, adress).Id);
            Assert.AreEqual(companyDto.CompanyName, new CompanyMapper().GetCompanyDTO(company, adress).CompanyName);
            Assert.AreEqual(companyDto.Email, new CompanyMapper().GetCompanyDTO(company, adress).Email);
            Assert.AreEqual(companyDto.PhoneNumber, new CompanyMapper().GetCompanyDTO(company, adress).PhoneNumber);
            Assert.AreEqual(companyDto.NIP, new CompanyMapper().GetCompanyDTO(company, adress).NIP);
            Assert.AreEqual(companyDto.StreetName, new CompanyMapper().GetCompanyDTO(company, adress).StreetName);
            Assert.AreEqual(companyDto.StreetNumber, new CompanyMapper().GetCompanyDTO(company, adress).StreetNumber);
            Assert.AreEqual(companyDto.ApartmentNumber, new CompanyMapper().GetCompanyDTO(company, adress).ApartmentNumber);
            Assert.AreEqual(companyDto.PostCode, new CompanyMapper().GetCompanyDTO(company, adress).PostCode);
            Assert.AreEqual(companyDto.City, new CompanyMapper().GetCompanyDTO(company, adress).City);

        }


    }
}