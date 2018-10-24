﻿using JT808.Protocol.Extensions;
using JT808.Protocol.MessageBody;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.JT808Formatters.MessageBodyFormatters
{
    public class JT808_0x8605Formatter : IJT808Formatter<JT808_0x8605>
    {
        public JT808_0x8605 Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JT808_0x8605 jT808_0X8605 = new JT808_0x8605();
            jT808_0X8605.AreaCount = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset);
            jT808_0X8605.AreaIds = new List<uint>();
            if (jT808_0X8605.AreaCount > 0)
            {
                for (var i = 0; i < jT808_0X8605.AreaCount; i++)
                {
                    jT808_0X8605.AreaIds.Add(JT808BinaryExtensions.ReadUInt32Little(bytes, ref offset));
                }
            }
            readSize = offset;
            return jT808_0X8605;
        }

        public int Serialize(IMemoryOwner<byte> memoryOwner, int offset, JT808_0x8605 value)
        {
            if (value.AreaIds != null)
            {
                offset += JT808BinaryExtensions.WriteByteLittle(memoryOwner, offset, (byte)value.AreaIds.Count);
                foreach (var item in value.AreaIds)
                {
                    offset += JT808BinaryExtensions.WriteUInt32Little(memoryOwner, offset, item);
                }
            }
            return offset;
        }
    }
}
