﻿using JT808.Protocol.Attributes;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 终端 RSA 公钥
    /// 0x0A00
    /// </summary>
    [JT808Formatter(typeof(JT808_0x0A00Formatter))]
    public class JT808_0x0A00:JT808Bodies
    {
        /// <summary>
        /// e
        /// 终端 RSA 公钥{e,n}中的 e
        /// </summary>
        public uint E { get; set; }
        /// <summary>
        /// n
        /// RSA 公钥{e,n}中的 n
        /// </summary>
        public byte[] N { get; set; }
    }
}
