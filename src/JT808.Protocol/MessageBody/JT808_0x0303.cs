﻿using JT808.Protocol.Attributes;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 信息点播/取消
    /// 0x0303
    /// </summary>
    [JT808Formatter(typeof(JT808_0x0303Formatter))]
    public class JT808_0x0303:JT808Bodies
    {
        /// <summary>
        /// 信息类型
        /// </summary>
        public byte InformationType { get; set; }
        /// <summary>
        /// 点播/取消标志
        /// </summary>
        public byte Flag { get; set; }
    }
}
