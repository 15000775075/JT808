﻿using JT808.Protocol.Attributes;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 事件报告
    /// 0x0301
    /// </summary>
    [JT808Formatter(typeof(JT808_0x0301Formatter))]
    public class JT808_0x0301:JT808Bodies
    {
        /// <summary>
        /// 事件 ID 
        /// </summary>
        public byte EventId { get; set; }
    }
}
