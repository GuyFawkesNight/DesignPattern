
/****************************************************************
 * 作    者：HanZT
 * CLR 版本：4.0.30319.42000
 * 创建时间：2019/2/13 17:03:18
 * 当前版本：1.0.0.1
 * 
 * 描述说明：单例模式 实现 v4.0： 多线程 饱汉式
 *
 * 修改历史：
 *
*****************************************************************
 * Copyright @ HanZT 2019 All rights reserved
*****************************************************************/



namespace Singleton
{
    public class Singleton_V4
    {
        
        public static readonly Singleton_V4 Instance = new Singleton_V4();

        public int par1 { get; set; }

        public int par2 { get; set; }

        private Singleton_V4() { }

        //静态构造器不支持参数传递，可以通过实例化后的属性赋值
        public void InitParams(int par1,int par2)
        {
            this.par1 = par1;
            this.par2 = par2;
        }
    }

    //上面的代码可以转化为下面的代码
    //public class Singleton_V4
    //{
    //    private static readonly Singleton_V4_1 instance;

    //     1.静态构造器只有在获取属性时才会执行，进行实例化 
    //     2.静态构造器可以保证多线程下只有一个线程执行
    //    static Singleton_V4()
    //    {
    //        instance = new Singleton_V4_1();
    //    }

    //    private Singleton_V4() { }
    //}
}
