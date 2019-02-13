
/****************************************************************
 * 作    者：HanZT
 * CLR 版本：4.0.30319.42000
 * 创建时间：2019/2/13 15:18:02
 * 当前版本：1.0.0.1
 * 
 * 描述说明：单例模式 实现 v3.0: 多线程 饱汉式
 *
 * 修改历史：
 *
*****************************************************************
 * Copyright @ HanZT 2019 All rights reserved
*****************************************************************/



namespace Singleton
{
    public class Singleton_V3
    {
        private static Singleton_V3 instance;

        private volatile object lockFlag = new object();

        private Singleton_V3() { }

        public static  Singleton_V3 GetInstance()
        {
            if (instance == null)
            {
                lock (lockFlag)
                {
                    if(instance == null)
                    {
                        instance = new Singleton_V3();
                    }
                }
            }

            return instance;
        }
    }
}
