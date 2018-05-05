﻿//----------------------------------------------------
//Copyright © 2008-2018 Mr-Alan. All rights reserved.
//Mail: Mr.Alan.China@[outlook|gmail].com
//Website: www.0x69h.com
//----------------------------------------------------

using UnityEditor;

namespace BlackFireFramework.Editor
{
    public static class WindowMenu 
	{
        public const string TopMenuName = "BlackFire/";

        public const string Window = "Window/";

        [MenuItem(TopMenuName+"Package")]
        private static void OnMenuItemClick_Package()
        {
           var window = EditorWindow.GetWindow(typeof(PackageWindow), false, "Package") as PackageWindow;
           window.position = new UnityEngine.Rect((1920f-730f)/2,(1080f-650f)/2,730f,650f);
        }

    }
}
