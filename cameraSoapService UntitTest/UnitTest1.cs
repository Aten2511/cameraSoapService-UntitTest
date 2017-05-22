using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace cameraSoapService_UntitTest
{
    /// <summary>
    /// This Unit test project is testing the CameraSoapService 
    /// Atena
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        //public CameraSoapDevService.IService1 Service1 { get; set; }

        //[TestInitialize]
        //public void Initialize()
        //{
        //    Service1 = new CameraSoapDevService.IService1();
        //}
        [TestMethod]
        public void TestGetImages()
        {
            using(ServiceReference1.Service1Client client=new ServiceReference1.Service1Client("BasicHttpsBinding_IService1"))
            {

                //Arrange
                var ImgList ="";

                //Act
                ImgList = client.GetLatestImage();

                //Assert
                Assert.IsNotNull(ImgList);
            }
        }

        [TestMethod]
        public void TestGetBookings()
        {
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpsBinding_IService1"))
            {
                //Arrange
                IList<ServiceReference1.Booking> Blist = null;

                //Act
                Blist = client.GetBookings();

                //Assert
                Assert.IsNotNull(Blist);
            }
        }

        [TestMethod]
        public void TestAddBooking()
        {
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpsBinding_IService1"))
            {
                //Arrange
                int rowAfected = 0;

                //Act
                rowAfected = client.SaveBooking("Test SoapService");

                //Assert
                Assert.AreEqual(rowAfected,1);
            }
        }


        [TestMethod]
        public void TestDeleteBooking()
        {
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpsBinding_IService1"))
            {
                //Arrange
                int rowAfected = 0;

                //Act
                rowAfected = client.DeleteBooking(18);

                //Assert
                Assert.AreEqual(rowAfected, 1);
            }
        }
    }
}
