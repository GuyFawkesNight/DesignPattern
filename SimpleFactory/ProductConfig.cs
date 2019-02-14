
/****************************************************************
 * 作    者：HanZT
 * CLR 版本：4.0.30319.42000
 * 创建时间：2019/2/14 9:30:19
 * 当前版本：1.0.0.1
 * 
 * 描述说明：
 *
 * 修改历史：
 *
*****************************************************************
 * Copyright @ HanZT 2019 All rights reserved
*****************************************************************/


namespace SimpleFactory
{
    public class ProductConfig
    {

        public ProductInfo ProductPrimay { get; set; }
    }

    public class ProductInfo
    {
        public string AssemblyName { get; set; }

        public string ProductName { get; set; }
    }
}
