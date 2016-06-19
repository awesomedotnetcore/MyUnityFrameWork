﻿using UnityEngine;
using System.Collections;

public static class ResourceManager 
{
    private static ResLoadType loadType = ResLoadType.ResourcePath; //默认从resourcePath中读取

    /// <summary>
    /// 游戏内资源读取类型
    /// </summary>
    public static ResLoadType LoadType
    {
        get { return loadType; }
        set
        {
            //资源读取器不能使用默认设置
            loadType = value;
            if (loadType == ResLoadType.UseGameSetting)
            {
                loadType = ResLoadType.ResourcePath;

                Debug.LogWarning("ResourceManager.LoadType don't use ResLoadType.useGameSetting !");
            }
        }
    }

    public static string GetLoadPath()
    {
        switch (loadType)
        {
            case ResLoadType.ResourcePath:
                return "";
            case ResLoadType.StreamingAssetsPath:
                return Application.streamingAssetsPath;
            case ResLoadType.PersistentDataPath:
                return Application.persistentDataPath;
            default:
                return "";
        }
    }
}

public enum ResLoadType
{
    UseGameSetting,
    ResourcePath,
    StreamingAssetsPath,
    PersistentDataPath,
}

public delegate void ResourceLoadCallBack<T>(T resObject);