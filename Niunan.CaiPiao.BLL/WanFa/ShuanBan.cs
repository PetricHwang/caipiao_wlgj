﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niunan.CaiPiao.BLL.WanFa
{
    /// <summary>
    /// 双版
    /// </summary>
    public class ShuanBan : IWanFaBLL
    {
        /// <summary>
        /// 大双，小双，特殊号码13
        /// </summary>
        /// <param name="buycode"></param>
        /// <param name="kjcode"></param>
        /// <returns></returns>
        public bool IsZJ(string buycode, string kjcode)
        {
            bool b = false;
            int x = int.Parse(kjcode);
            if (x%2==0)
            {
                b = true;
            }
            return b;
        }
    }
}
