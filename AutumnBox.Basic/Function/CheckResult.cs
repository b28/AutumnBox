﻿/* =============================================================================*\
*
* Filename: CheckResult
* Description: 
*
* Version: 1.0
* Created: 2017/11/22 19:38:41 (UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutumnBox.Basic.Function
{
    public enum CheckResult : int
    {
        Unfinish = -1,
        OK,
        Error,
        ArgError,
        DeviceStatusError,
        ArgNullError,
    }
}