﻿using JT808.Protocol.JT808Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using Xunit;

namespace JT808.Protocol.Test
{
    public class SplitPackageStrategyTest
    {
        [Fact]
        public void Test1()
        {
            ISplitPackageStrategy splitPackageStrategy = new DefaultSplitPackageStrategyImpl();
            byte[] data;
            using (FileStream input = File.OpenRead(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "test.txt")))
            {
                data = new byte[input.Length];
                input.Read(data, 0,(int)input.Length);
            }
            var result=splitPackageStrategy.Processor(data);
        }
    }
}
