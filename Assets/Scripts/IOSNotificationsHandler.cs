using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_IOS
using Unity.Notifications.iOS;
#endif
using UnityEngine;

public class IOSNotificationsHandler : MonoBehaviour
{
#if UNITY_IOS
    public void ScheduleNotification(int minutes)
    {
        iOSNotification notification = new iOSNotification
        {
            Title = "Energy Recharged!",
            Subtitle = "Your energy has recharged",
            Body = "Your energy has recharged, come back to play again!",
            ShowInForeground = true,
            ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound),
            CategoryIdentifier = "category_a",
            ThreadIdentifier = "thread1",
            Trigger = new iOSNotificationTimeIntervalTrigger
            {
                TimeInterval = new TimeSpan(0, minutes, 0),
                Repeats = false
            }
        };
    }
#endif
}
