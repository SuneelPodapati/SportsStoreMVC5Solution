using LoggingLibrary;
using Microsoft.Practices.Unity;
using SportsStoreDomainLibrary.Abstract;
using SportsStoreDomainLibrary.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStoreMVC5WebApp.Infrastructure
{
    public class SportsUnityControllerFactory: DefaultControllerFactory
    {
        private UnityContainer _container;
        public SportsUnityControllerFactory()
        {
            _container = new UnityContainer();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            //return base.GetControllerInstance(requestContext, controllerType);
            return controllerType == null ? null : _container.Resolve(controllerType) as IController;
        }
        private void AddBindings()
        {
            //Mapping the Interface with the Class to be initialized in the Controller
            _container.RegisterType<ILogger, Logger>();
            //_container.RegisterType<IProductRepository, MockProduct>();
            _container.RegisterType<IProductRepository, EfProductRepository>();
        }
    }
}