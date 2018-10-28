﻿using JT808.Protocol.Attributes;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 信息服务
    /// 0x8304
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8304Formatter))]
    public class JT808_0x8304:JT808Bodies
    {
        /// <summary>
        /// 信息类型
        /// </summary>
        public byte InformationType { get; set; }
        /// <summary>
        /// 信息长度
        /// </summary>
        public ushort InformationLength { get; set; }
        /// <summary>
        /// 信息内容
        /// 经 GBK 编码
        /// </summary>
        public string InformationContent { get; set; }

    }
}
