using System;
using System.Data;
using MovieAssessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieDBUnitTest
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            myCRUD crud = new myCRUD();
            DataTable test = crud.ReadEntriesMovies();
            Assert.IsNotNull(test);
        }
        [TestMethod]
        public void TestUpdateMovie()
        {
            Form1 myForm = new Form1();
            string UpdateMessage = myForm.UpdateMovie();
            Assert.IsTrue(UpdateMessage == "Movie Data has been updated :)");
        }
    }
}
