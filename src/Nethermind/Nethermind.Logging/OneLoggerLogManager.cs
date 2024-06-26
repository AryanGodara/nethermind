// SPDX-FileCopyrightText: 2022 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

using System;

namespace Nethermind.Logging
{
    public class OneLoggerLogManager : ILogManager
    {
        private readonly ILogger _logger;

        public OneLoggerLogManager(ILogger logger)
        {
            _logger = logger;
        }

        public ILogger GetClassLogger(Type type) => _logger;

        public ILogger GetClassLogger<T>() => _logger;

        public ILogger GetClassLogger() => _logger;

        public ILogger GetLogger(string loggerName) => _logger;
    }
}
