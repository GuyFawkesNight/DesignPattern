
/****************************************************************
 * 作    者：HanZT
 * CLR 版本：4.0.30319.42000
 * 创建时间：2019/2/13 15:03:48
 * 当前版本：1.0.0.1
 * 
 * 描述说明： 单例模式 实现v1.0 ：单线程 饱汉式 
 *
 * 修改历史：
 *
*****************************************************************
 * Copyright @ HanZT 2019 All rights reserved
*****************************************************************/



namespace Singleton
{
    public class Singleton_V1
    {
        private static Singleton_V1 instance;

        private Singleton_V1()
        {

        }

        //公共方法实现实例的获取
        public static Singleton_V1 GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton_V1();
            }

            return instance;
        }

        //公共属性实现实例的获取
        public static Singleton_V1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton_V1();
                }

                return instance;
            }
        }
    }
}
