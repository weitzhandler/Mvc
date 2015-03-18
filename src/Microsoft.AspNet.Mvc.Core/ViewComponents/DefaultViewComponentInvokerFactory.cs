// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Framework.Internal;

namespace Microsoft.AspNet.Mvc.ViewComponents
{
    public class DefaultViewComponentInvokerFactory : IViewComponentInvokerFactory
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ITypeActivatorCache _typeActivatorCache;
        private readonly IViewComponentActivator _viewComponentActivator;

        public DefaultViewComponentInvokerFactory(
            IServiceProvider serviceProvider,
            ITypeActivatorCache typeActivatorCache,
            IViewComponentActivator viewComponentActivator)
        {
            _serviceProvider = serviceProvider;
            _typeActivatorCache = typeActivatorCache;
            _viewComponentActivator = viewComponentActivator;
        }

        /// <inheritdoc />
        public IViewComponentInvoker CreateInstance([NotNull] ViewComponentDescriptor viewComponent, object[] args)
        {
            return new DefaultViewComponentInvoker(
                _serviceProvider,
                _typeActivatorCache,
                _viewComponentActivator);
        }
    }
}
