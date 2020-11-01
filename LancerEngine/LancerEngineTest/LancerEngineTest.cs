using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using LancerEngine;
using LancerEngine.Schemas;
using System.Collections.Generic;
using System.IO;
using System;

namespace LancerEngineTest
{
    [TestClass]
    public class LancerEngineTest
    {
        [TestMethod]
        public void TestDeserializeReferenceData()
        {
            var engine = new global::LancerEngine.LancerEngine();

            List<ActionRef> actionRefs = engine.LoadGameReferenceData();
            Assert.AreEqual(actionRefs.Count, 42);
        }
    }
}
