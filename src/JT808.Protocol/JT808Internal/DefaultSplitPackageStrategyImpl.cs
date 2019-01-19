﻿using System;
using System.Collections.Generic;
using System.Text;
using JT808.Protocol.JT808Properties;

namespace JT808.Protocol.JT808Internal
{
    internal class DefaultSplitPackageStrategyImpl : ISplitPackageStrategy
    {
        private const int N = 256 * 3;

        public IEnumerable<JT808SplitPackageProperty> Processor(ReadOnlySpan<byte> bigData)
        {
            List<JT808SplitPackageProperty> jT808SplitPackagePropertys = new List<JT808SplitPackageProperty>();
            var quotient = bigData.Length / N;
            var remainder = bigData.Length % N;
            if (remainder != 0)
            {
                quotient = quotient + 1;
            }
            for (int i=1;i<= quotient; i++)
            {
                JT808SplitPackageProperty jT808SplitPackageProperty = new JT808SplitPackageProperty();
                jT808SplitPackageProperty.PackgeIndex = i;
                jT808SplitPackageProperty.PackgeCount = quotient;
                if(i == quotient)
                {
                    jT808SplitPackageProperty.Data = bigData.Slice((i - 1) * N).ToArray();
                }
                else
                {
                    jT808SplitPackageProperty.Data = bigData.Slice((i - 1) * N, N).ToArray();
                }
                jT808SplitPackagePropertys.Add(jT808SplitPackageProperty);
            }
            return jT808SplitPackagePropertys;
        }
    }
}
