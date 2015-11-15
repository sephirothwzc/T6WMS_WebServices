using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;


/// <summary>
/// InitVirtualPathProvider 的摘要说明
/// </summary>
[assembly: PreApplicationStartMethod(typeof(InitVirtualPathProvider), "AppInitialize")]

public static class InitVirtualPathProvider
{

    public static void AppInitialize()
    {
        //DirectoryInfo d = Directory.CreateDirectory(string.Format("c://{0}", DateTime.Now.ToString("yyyyMMddHHmmss"))); 
    }
}