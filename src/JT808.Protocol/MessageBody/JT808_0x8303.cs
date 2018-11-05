﻿using JT808.Protocol.Attributes;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;
using JT808.Protocol.JT808Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 信息点播菜单设置
    /// 0x8303
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8303Formatter))]
    public class JT808_0x8303:JT808Bodies
    {
        /// <summary>
        /// 设置类型
        /// <see cref="JT808.Protocol.Enums.JT808InformationSettingType"/>
        /// </summary>
        public byte SettingType { get; set; }
        /// <summary>
        /// 信息项总数
        /// </summary>
        public byte InformationItemCount { get; set; }
        /// <summary>
        /// 信息点播信息项组成数据
        /// 信息项列表
        /// </summary>
        public List<JT808InformationItemProperty> InformationItems { get; set; }
    }
}
