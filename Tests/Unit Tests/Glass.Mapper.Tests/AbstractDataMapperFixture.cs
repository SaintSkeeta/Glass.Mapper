﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NSubstitute;

namespace Glass.Mapper.Tests
{
    [TestFixture]
    public class AbstractDataMapperFixture
    {
        private AbstractDataMapper _dataMapper;

        [SetUp]
        public void Setup()
        {
            _dataMapper = Substitute.For<AbstractDataMapper>();


        }

        #region Method - MapCmsToProperty

        [Test]
        public void MapCmsToProperty_ValueFromCms_WritesToProperty()
        {
            //Assign
            AbstractDataMappingContext context = Substitute.For<AbstractDataMappingContext>();
            var obj = new StubClass();
            context.Object = obj;
            _dataMapper.Property = typeof (StubClass).GetProperties().First(x => x.Name == "AProperty");
            _dataMapper.MapFromCms(Arg.Any<AbstractDataMappingContext>()).Returns("Hello world");

            //Act
            _dataMapper.MapCmsToProperty(context);

            //Assert
            Assert.AreEqual("Hello world", obj.AProperty);


        }

        #endregion

        #region Stubs

        public class StubClass
        {
            public string AProperty { get; set; }
        }

        #endregion

    }
}
