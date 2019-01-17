﻿using JT808.Protocol.Extensions;
using JT808.Protocol.MessageBody;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.JT808Formatters.MessageBodyFormatters
{
    public class JT808_0x8103_0x0018Formatter : IJT808Formatter<JT808_0x8103_0x0018>
    {
        public JT808_0x8103_0x0018 Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JT808_0x8103_0x0018 jT808_0x8103_0x0018 = new JT808_0x8103_0x0018();
            jT808_0x8103_0x0018.ParamLength = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset);
            jT808_0x8103_0x0018.ParamValue = JT808BinaryExtensions.ReadUInt32Little(bytes, ref offset);
            readSize = offset;
            return jT808_0x8103_0x0018;
        }

        public int Serialize(ref byte[] bytes, int offset, JT808_0x8103_0x0018 value)
        {
            offset += JT808BinaryExtensions.WriteByteLittle(bytes, offset, value.ParamLength);
            offset += JT808BinaryExtensions.WriteUInt32Little(bytes, offset, value.ParamValue);
            return offset;
        }
    }
}
