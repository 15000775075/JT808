﻿using JT808.Protocol.Attributes;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 紧急报警时汇报时间间隔，单位为秒（s），>0
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0x0028Formatter))]
    public class JT808_0x8103_0x0028 : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0x0028;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; } = 4;
        /// <summary>
        /// 紧急报警时汇报时间间隔，单位为秒（s），>0
        /// </summary>
        public uint ParamValue { get; set; }
    }
}
