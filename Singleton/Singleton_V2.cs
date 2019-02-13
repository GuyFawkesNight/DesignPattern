
/****************************************************************
 * 作    者：HanZT
 * CLR 版本：4.0.30319.42000
 * 创建时间：2019/2/13 15:12:06
 * 当前版本：1.0.0.1
 * 
 * 描述说明：单例模式 实现v 2.0 :单线程 饱汉式
 *
 * 修改历史：
 *
*****************************************************************
 * Copyright @ HanZT 2019 All rights reserved
*****************************************************************/



using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton_V2
    {
        private static  Singleton_V2 instance = new Singleton_V2();

        private Singleton_V2() { }

        public static Singleton_V2 GetInstance()
        {
            return instance;
        }

        public static Singleton_V2 Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
