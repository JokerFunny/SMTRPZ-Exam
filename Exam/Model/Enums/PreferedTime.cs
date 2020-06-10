using System;

namespace Model.Enums
{
    /// <summary>
    /// Enumeration for prefered time of week
    /// </summary>
    [Flags]
    public enum PreferedTime
    {
        /// <summary>
        /// Monday before 12
        /// </summary>
        MondayMorning = 1,

        /// <summary>
        /// Monday after 12
        /// </summary>
        MondayEvening = 2,

        TuesdayMorning = 4,

        TuesdayEvening = 8,

        WednesdayMorning = 16,

        WednesdayEvening = 32,

        ThursdayMorning = 64,

        ThursdayEvening = 128,

        FridayMorning = 256,

        FridayEvening = 512,

        SaturdayMorning = 1024,

        SaturdayEvening = 2048,

        SundayMorning = 4096,

        SundayEvening = 8192
    }
}
