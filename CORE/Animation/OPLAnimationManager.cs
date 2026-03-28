using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace OPLAnimation.CORE.Animation
{
    /// <summary>
    /// Класс менеджера анимаций
    /// </summary>
    public class OPLAnimationManager()
    {
        #region AnimationObject
        /// <summary>
        /// Объект анимации Thickness
        /// </summary>
        public OPLThicknessAnimationType<ThicknessAnimation> ThicknessAnimationType =
            new(new(new Thickness(0), TimeSpan.FromMilliseconds(300d))
            {
                DecelerationRatio = 0.6d,
                EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseOut },
                From = null
            });

        /// <summary>
        /// Объект анимации Double
        /// </summary>
        public OPLDoubleAnimationType<DoubleAnimation> DoubleAnimationType =
            new(new(0, TimeSpan.FromMilliseconds(250d))
            {
                DecelerationRatio = 0.2d,
                EasingFunction = new QuinticEase() { EasingMode = EasingMode.EaseOut },
                From = null
            });

        /// <summary>
        /// Объект анимации Point
        /// </summary>
        public OPLPointAnimationType<PointAnimation> PointAnimationType =
            new(new(new System.Windows.Point(0, 0), TimeSpan.FromMilliseconds(250d))
            {
                DecelerationRatio = 0.2d,
                EasingFunction = new QuinticEase() { EasingMode = EasingMode.EaseOut },
                From = null
            });

        /// <summary>
        /// Объект анимации Color
        /// </summary>
        public OPLColorAnimationType<ColorAnimation> ColorAnimationType =
            new(new(Colors.Black, TimeSpan.FromMilliseconds(250d))
            {
                DecelerationRatio = 0.2d,
                EasingFunction = new ExponentialEase() { EasingMode = EasingMode.EaseOut },
                From = null
            });

        /// <summary>
        /// Объект анимации Rect
        /// </summary>
        public OPLRectAnimationType<RectAnimation> RectAnimationType =
            new(new(new Rect(), TimeSpan.FromMilliseconds(250d))
            {
                DecelerationRatio = 0.8d,
                EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseOut },
                From = null
            });
        #endregion
    }
}
