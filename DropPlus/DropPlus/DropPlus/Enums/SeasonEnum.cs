using System.ComponentModel;

namespace DropPlus.Enums
{
    public enum SeasonEnum
    {
        [Description("Будь-яка")]
        Any = 0,
        [Description("Зима")]
        Winter = 1,
        [Description("Весна")]
        Spring = 2,
        [Description("Літо")]
        Summer = 3,
        [Description("Осінь")]
        Autumn = 4
    }
}