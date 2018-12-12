﻿using JT808.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using JT808.Protocol.Extensions;
using JT808.Protocol.Test.MessageBody.JT808_0X8900_BodiesImpl;

namespace JT808.Protocol.Test.MessageBody
{
    public class JT808_0x8900Test
    {
        [Fact]
        public void Test1()
        {
            JT808_0x8900 jT808_0X8900 = new JT808_0x8900();
            jT808_0X8900.PassthroughType = 0x0B;
            jT808_0X8900.JT808_0X8900_BodyBase = new JT808_0X8900_Test_BodiesImpl
            {
                Id=12345,
                Sex=0x01
            };
            string hex = JT808Serializer.Serialize(jT808_0X8900).ToHexString();
            Assert.Equal("0B0000303901", hex);
        }

        [Fact]
        public void Test2()
        {
            byte[] bytes = "0B0000303901".ToHexBytes();
            JT808_0x8900 jT808_0X8900 = JT808Serializer.Deserialize<JT808_0x8900>(bytes);
            JT808_0X8900_Test_BodiesImpl jT808_0X8900_Test_BodiesImpl= JT808Serializer.Deserialize<JT808_0X8900_Test_BodiesImpl>(jT808_0X8900.PassthroughData);
            Assert.Equal(0x0B, jT808_0X8900.PassthroughType);
            Assert.Equal((uint)12345, jT808_0X8900_Test_BodiesImpl.Id);
            Assert.Equal(0x01, jT808_0X8900_Test_BodiesImpl.Sex);
        }
    }
}
