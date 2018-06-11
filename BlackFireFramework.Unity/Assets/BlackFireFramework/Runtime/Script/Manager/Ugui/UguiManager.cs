﻿//----------------------------------------------------
//Copyright © 2008-2018 Mr-Alan. All rights reserved.
//Mail: Mr.Alan.China@[outlook|gmail].com
//Website: www.0x69h.com
//----------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace BlackFireFramework.Unity
{
    /// <summary>
    /// Ugui 管家。
    /// </summary>
	public sealed partial class UguiManager : ManagerBase 
	{
        private UguiManagerGraphicRaycaster m_UguiManagerGraphicRaycaster = null;

        /// <summary>
        /// Ugui的事件流。
        /// </summary>
        public PointerEventData PointerEventData { get { return m_UguiManagerGraphicRaycaster.PointerEventData;  } }
      
        /// <summary>
        /// 射线射击结果列表。
        /// </summary>
        public List<RaycastResult> RaycastResultList { get { return m_UguiManagerGraphicRaycaster.RaycastResultList;  } }


        protected override void OnStart()
        {
            base.OnStart();
            m_UguiManagerGraphicRaycaster = gameObject.AddComponent<UguiManagerGraphicRaycaster>();
        }

    }
}
