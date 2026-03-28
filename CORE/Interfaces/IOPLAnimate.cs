using OPLAnimation.CORE.Animation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OPLAnimation.CORE.Interfaces
{
    /// <summary>
    /// Интерфейс объекта реализующего настройку анимации настройке OPL
    /// </summary>
    public interface IOPLAnimate
    {
        /// <summary>
        /// Объект менеджера анимаций настроек OPL
        /// </summary>
        public OPLAnimationManager? ManagerAnimation { get; set; }
    }
}
