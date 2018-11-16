﻿using JT808.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using JT808.Protocol.Extensions;

namespace JT808.Protocol.Test.MessageBodySend
{
    public class JT808_0x8203Test
    {
        [Fact]
        public void Test1()
        {
            JT808_0x8203 jT808_0X8203 = new JT808_0x8203();
            jT808_0X8203.AlarmMsgNum = 5554;
            jT808_0X8203.ManualConfirmAlarmType = 123;
            string hex = JT808Serializer.Serialize(jT808_0X8203).ToHexString();
            Assert.Equal("15B20000007B", hex);
        }

        [Fact]
        public void Test2()
        {
            byte[] bytes = "15B20000007B".ToHexBytes();
            JT808_0x8203 jT808_0X8203 = JT808Serializer.Deserialize<JT808_0x8203>(bytes);
            Assert.Equal(5554, jT808_0X8203.AlarmMsgNum);
            Assert.Equal((uint)123, jT808_0X8203.ManualConfirmAlarmType);
        }
    }
}
