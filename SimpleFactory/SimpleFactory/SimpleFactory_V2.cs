
/****************************************************************
 * 作    者：HanZT
 * CLR 版本：4.0.30319.42000
 * 创建时间：2019/2/13 22:22:43
 * 当前版本：1.0.0.1
 * 
 * 描述说明：通过传入的枚举变量生成对应的产品
 *
 * 修改历史：
 *
*****************************************************************
 * Copyright @ HanZT 2019 All rights reserved
*****************************************************************/



using SimpleFactory.Product;
using System;


namespace SimpleFactory.SimpleFactory
{
    public class SimpleFactory_V2
    {
        public static IProduct CreateInstance(ProductTypeEnum productType)
        {
            switch (productType)
            {
                case ProductTypeEnum.ProductA:
                    return new ProductA();
                case ProductTypeEnum.ProductB:
                    return new ProductB();
                case ProductTypeEnum.ProductC:
                    return new ProductC();
                default:
                    throw new NotImplementedException("未找到实现的产品");
            }
        }
    }
}
