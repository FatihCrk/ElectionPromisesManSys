﻿using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);

            //Merkezi yerden tüm metotlara uygulayabileceğimiz yer.
            //Örneğin PerformanceAspect'i buraya yazabiliriz. 
            // classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger))); hatta tüm metotları bunun gibi loglayabiliriz.

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
