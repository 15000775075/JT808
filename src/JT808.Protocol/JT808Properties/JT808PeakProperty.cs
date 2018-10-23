﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.JT808Properties
{
    /// <summary>
    /// 顶点项
    /// </summary>
    public class JT808PeakProperty
    {
        /// <summary>
        /// 顶点纬度
        /// 以度为单位的纬度值乘以 10 的 6 次方，精确到百万分之一度
        /// </summary>
        public uint Lat { get; set; }
        /// <summary>
        /// 顶点经度
        /// 以度为单位的经度值乘以 10 的 6 次方，精确到百万分之一度
        /// </summary>
        public uint Lng { get; set; }
    }
}
