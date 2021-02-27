using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        //WebAPI startup'taki işlemler burada yapılıyor
        protected override void Load(ContainerBuilder builder)
        {
            //WebAPI startuptaki services.AddSingleton<IProductService,ProductManager>(); ile aynı işlemi yapar
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();//IProductService istendiğinde ProductManager oluştur
            builder.RegisterType<EFProductDAL>().As<IProductDAL>().SingleInstance();//services.AddSingleton<IProductDAL, EFProductDAL>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EFCategoryDAL>().As<ICategoryDAL>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EFUserDAL>().As<IUserDAL>().SingleInstance();
            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
