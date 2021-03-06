﻿using DMPSystem.Core.EventBus.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace DMPSystem.Core.EventBus.HashAlgorithms
{
    /// <summary>
    /// 哈希节点对象
    /// </summary>
    /// <remarks>
    /// 	<para>创建：范亮</para>
    /// 	<para>日期：2016/4/2</para>
    /// </remarks>
    public class ConsistentHashNode
    {
        /// <summary>
        /// 缓存目标类型
        /// </summary>
        /// <remarks>
        /// 	<para>创建：范亮</para>
        /// 	<para>日期：2016/4/2</para>
        /// </remarks>
        public EventTargetType Type
        {
            get;
            set;
        }

        /// <summary>
        /// 主机
        /// </summary>
        /// <remarks>
        /// 	<para>创建：范亮</para>
        /// 	<para>日期：2016/4/2</para>
        /// </remarks>
        public string Host { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        /// <remarks>
        /// 	<para>创建：范亮</para>
        /// 	<para>日期：2016/4/2</para>
        /// </remarks>
        public string Port { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        /// <remarks>
        /// 	<para>创建：范亮</para>
        /// 	<para>日期：2016/4/2</para>
        /// </remarks>
        public string Password { get; set; }

        /// <summary>
        /// 数据库
        /// </summary>
        /// <remarks>
        /// 	<para>创建：范亮</para>
        /// 	<para>日期：2016/4/2</para>
        /// </remarks>
        public string QueueName
        {
            get;
            set;
        }

        public string UseRateLimit
        {
            get; set;
        }

        public string CunsumerNum
        {
            get; 
            set;
        }

        public string UseRetryNum
        {
            get; set;
        }

        private string _maxSize = "50";
        public string MaxSize
        {
            get
            {
                return _maxSize;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _maxSize = value;
                }
            }
        }

        private string _minSize = "1";
        public string MinSize
        {
            get
            {
                return _minSize;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _minSize = value;
                }
            }
        }
    }
}
