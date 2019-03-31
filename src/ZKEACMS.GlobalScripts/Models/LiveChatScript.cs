﻿/*!
 * http://www.zkea.net/
 * Copyright 2018 ZKEASOFT
 * http://www.zkea.net/licenses
 */

using Easy;
using Easy.MetaData;
using Easy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZKEACMS.GlobalScripts.Models
{
    public class LiveChatScript : GlobalScript
    {
    }
    class LiveChatScriptMetaData : ViewMetaData<LiveChatScript>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.Location).AsDropDownList().DataSource(() =>
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add(ScriptLocation.Footer.ToString("D"), "页尾");
                data.Add(ScriptLocation.Header.ToString("D"), "页头");
                return data;
            });
            ViewConfig(m => m.Script).AsTextArea();
        }
    }
}