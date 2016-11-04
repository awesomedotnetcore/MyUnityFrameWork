﻿using UnityEngine;
using UnityEditor;
using NUnit.Framework;

namespace Framework
{
    public class ResourcesTest
    {
        [Test(Description = "资源路径数据存在测试")]
        public void BundleConfigExistTest()
        {
            RecourcesConfigManager.Initialize();

            bool isExist = ConfigManager.GetIsExistData(RecourcesConfigManager.c_configFileName);

            Assert.AreEqual(isExist, true);
        }
    }
}