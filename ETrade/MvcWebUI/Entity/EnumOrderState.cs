﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebUI.Entity
{
    public enum EnumOrderState
    {
        Bekleniyor,
        Onaylandı,
        Hazırlanıyor,
        Gönderildi
    }
}