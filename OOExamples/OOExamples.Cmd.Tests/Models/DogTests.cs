using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOExamples.Cmd.Exceptions;
using OOExamples.Cmd.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOExamples.Cmd.Models.Tests
{
    [TestClass()]
    public class DogTests
    {

        [TestMethod()]
        [ExpectedException(typeof(NoBonesException))]
        public void ChewOnBoneTest()
        {
            var dog = new Dog();
            dog.ChewOnBone();
        }
    }
}