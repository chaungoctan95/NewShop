﻿using System;

namespace NewShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }

        string MetaKeywork { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}