﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementServices.Interfaces
{
    public interface IBusinessLogicFactory
    {
        IUserManager UserManager { get; }
        IEventManager EventManager { get; }
        IFeedbackSender FeedbackSender { get; }
    }
}
