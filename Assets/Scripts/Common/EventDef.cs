
using UIFramework;
using UnityEngine;

namespace EventDef
{
    public class UIMessageOpenEvent : BaseEvent<UIMessageData> { };
    public class UIMessageCloseEvent : BaseEvent { };

    public class UIHomeOpenEvent : BaseEvent { };
    public class UIHomeCloseEvent : BaseEvent { };

    public class UIIntroduceOpenEvent : BaseEvent { };
    public class UIIntroduceCloseEvent : BaseEvent { };

    public class UIVideoOpenEvent : BaseEvent { };
    public class UIVideoCloseEvent : BaseEvent { };

    public class UIBackgroundOpenEvent : BaseEvent { };
    public class UIBackgroundCloseEvent : BaseEvent { };
}