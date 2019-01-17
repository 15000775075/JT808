﻿using JT808.Protocol.Attributes;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 备份服务器无线通信拨号密码
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0x0016Formatter))]
    public class JT808_0x8103_0x0016 : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0x0016;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; }
        /// <summary>
        /// 备份服务器无线通信拨号密码
        /// </summary>
        public string ParamValue { get; set; }
    }
}
