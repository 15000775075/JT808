﻿using JT808.Protocol.Attributes;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 色度，0-255
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0x0074Formatter))]
    public class JT808_0x8103_0x0074 : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0x0074;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; } = 4;
        /// <summary>
        /// 饱和度，0-127
        /// </summary>
        public uint ParamValue { get; set; }
    }
}
