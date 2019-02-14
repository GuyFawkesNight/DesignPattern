
/****************************************************************
 * 作    者：HanZT
 * CLR 版本：4.0.30319.42000
 * 创建时间：2019/2/13 22:21:34
 * 当前版本：1.0.0.1
 * 
 * 描述说明：
 *
 * 修改历史：
 *
*****************************************************************
 * Copyright @ HanZT 2019 All rights reserved
*****************************************************************/



using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Product
{
    public class ProductC : IProduct
    {
        public string Description()
        {
            return "这是产品C的描述";
        }
    }
}
