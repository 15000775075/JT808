﻿using JT808.Protocol.Attributes;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 道路运输证 IC 卡认证备份服务器 IP 地址或域名，端口同主服务器
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0x001DFormatter))]
    public class JT808_0x8103_0x001D : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0x001D;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; }
        /// <summary>
        /// 道路运输证 IC 卡认证备份服务器 IP 地址或域名，端口同主服务器
        /// </summary>
        public string ParamValue { get; set; }
    }
}
