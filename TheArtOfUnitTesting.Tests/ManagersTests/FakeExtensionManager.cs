using System;
using System.Collections.Generic;
using System.Text;
using TheArtOfUntTesting.Interfaces;

namespace TheArtOfUnitTesting.Tests.ManagersTests
{
    public class FakeExtensionManager : IExtensionManager
    {
        public Exception WillThrow = null;
        public bool WillBeValid = true;
        public bool IsValid(string fileName)
        {
            if (WillThrow != null)
            {
                throw WillThrow;
            }

            return WillBeValid;
        }
    }
