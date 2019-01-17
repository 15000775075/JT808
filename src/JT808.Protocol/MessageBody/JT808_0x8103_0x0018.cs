﻿using JT808.Protocol.Attributes;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 服务器 TCP 端口
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0x0018Formatter))]
    public class JT808_0x8103_0x0018 : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0x0018;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; } = 4;
        /// <summary>
        ///服务器 TCP 端口
        /// </summary>
        public uint ParamValue { get; set; }
    }
}
