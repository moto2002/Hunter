﻿//  Desc:        Framework For Game Develop with Unity3d
//  Copyright:   Copyright (C) 2019 Hunter. All rights reserved.
//  ————————————————————————
//  ————————————————————————
//  Author:      Hunter
//  E-mail:      3493000@qq.com
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hunter
{
    public class EventPauseCommand : AbstractGuideCommand
    {
        protected override void OnStart()
        {
            UIMgr.S.topPanelHideMask = PanelHideMask.UnInteractive;
        }

        protected override void OnFinish(bool forceClean)
        {
            UIMgr.S.topPanelHideMask = PanelHideMask.None;
        }
    }
}
