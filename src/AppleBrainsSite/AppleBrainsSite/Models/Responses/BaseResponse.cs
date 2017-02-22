﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppleBrainsSite.Models.Responses
{
    public abstract class BaseResponse
    {
        public bool IsSuccessful { get; set; }

        public string TransactionId { get; set; }

    }
}