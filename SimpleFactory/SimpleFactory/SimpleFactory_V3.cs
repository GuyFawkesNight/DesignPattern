
/****************************************************************
 * 作    者：HanZT
 * CLR 版本：4.0.30319.42000
 * 创建时间：2019/2/13 22:39:28
 * 当前版本：1.0.0.1
 * 
 * 描述说明：通过配置文件和反射完成对产品动态实例化
 *
 * 修改历史：
 *
*****************************************************************
 * Copyright @ HanZT 2019 All rights reserved
*****************************************************************/



using Microsoft.Extensions.Configuration;
using SimpleFactory.Product;
using System;
using System.IO;

namespace SimpleFactory.SimpleFactory
{
    public class SimpleFactory_V3
    {
        public static IProduct CreateInstance()
        {
            var builder = new ConfigurationBuilder()
           //.SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();

            ProductConfig productConfig = new ProductConfig();
            configuration.GetSection("ProductCollection").Bind(productConfig);

            var prodFullName = $"{productConfig.ProductPrimay.AssemblyName}.{productConfig.ProductPrimay.ProductName}";
            var type = Type.GetType(prodFullName);
            return (IProduct)Activator.CreateInstance(type);


        }
    }
}
