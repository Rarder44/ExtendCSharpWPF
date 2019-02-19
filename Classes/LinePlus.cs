using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using ExtendCSharp;
namespace ExtendCSharpWPF.Classes
{
    public class LinePlus
    {

        System.Windows.Shapes.Line inter;
        public Point P1
        {
            get
            {
                return new Point(X1, Y1);
            }
            set
            {
                X1 = value.X;
                Y1 = value.Y;
            }
        }
        public Point P2
        {
            get
            {
                return new Point(X2, Y2);
            }
            set
            {
                X2 = value.X;
                Y2 = value.Y;
            }
        }

        public double Lenght
        {
            get
            {
                return P1.Distanza(P2);

            }
        }


        #region Constructor

        public LinePlus()
        {
            inter = new System.Windows.Shapes.Line();
            EventAssotiation();
        }

        public LinePlus(System.Windows.Shapes.Line inter)
        {
            this.inter = inter;
        }

        #endregion

        #region Fields

       /* static public System.Windows.DependencyProperty X1Property;
        
        static public System.Windows.DependencyProperty Y1Property;
        static public System.Windows.DependencyProperty X2Property;
        static public System.Windows.DependencyProperty Y2Property;*/
        #endregion

        #region Properties

        public double X1
        {
            get
            {
                return inter.X1;
            }
            set
            {
                inter.X1 = value;
            }
        }
        public double Y1
        {
            get
            {
                return inter.Y1;
            }
            set
            {
                inter.Y1 = value;
            }
        }
        public double X2
        {
            get
            {
                return inter.X2;
            }
            set
            {
                inter.X2 = value;
            }
        }
        public double Y2
        {
            get
            {
                return inter.Y2;
            }
            set
            {
                inter.Y2 = value;
            }
        }
        public System.Windows.Media.Stretch Stretch
        {
            get
            {
                return inter.Stretch;
            }
            set
            {
                inter.Stretch = value;
            }
        }
        public System.Windows.Media.Geometry RenderedGeometry
        {
            get
            {
                return inter.RenderedGeometry;
            }
        }
        public System.Windows.Media.Transform GeometryTransform
        {
            get
            {
                return inter.GeometryTransform;
            }
        }
        public System.Windows.Media.Brush Fill
        {
            get
            {
                return inter.Fill;
            }
            set
            {
                inter.Fill = value;
            }
        }
        public System.Windows.Media.Brush Stroke
        {
            get
            {
                return inter.Stroke;
            }
            set
            {
                inter.Stroke = value;
            }
        }
        public double StrokeThickness
        {
            get
            {
                return inter.StrokeThickness;
            }
            set
            {
                inter.StrokeThickness = value;
            }
        }
        public System.Windows.Media.PenLineCap StrokeStartLineCap
        {
            get
            {
                return inter.StrokeStartLineCap;
            }
            set
            {
                inter.StrokeStartLineCap = value;
            }
        }
        public System.Windows.Media.PenLineCap StrokeEndLineCap
        {
            get
            {
                return inter.StrokeEndLineCap;
            }
            set
            {
                inter.StrokeEndLineCap = value;
            }
        }
        public System.Windows.Media.PenLineCap StrokeDashCap
        {
            get
            {
                return inter.StrokeDashCap;
            }
            set
            {
                inter.StrokeDashCap = value;
            }
        }
        public System.Windows.Media.PenLineJoin StrokeLineJoin
        {
            get
            {
                return inter.StrokeLineJoin;
            }
            set
            {
                inter.StrokeLineJoin = value;
            }
        }
        public double StrokeMiterLimit
        {
            get
            {
                return inter.StrokeMiterLimit;
            }
            set
            {
                inter.StrokeMiterLimit = value;
            }
        }
        public double StrokeDashOffset
        {
            get
            {
                return inter.StrokeDashOffset;
            }
            set
            {
                inter.StrokeDashOffset = value;
            }
        }
        public System.Windows.Media.DoubleCollection StrokeDashArray
        {
            get
            {
                return inter.StrokeDashArray;
            }
            set
            {
                inter.StrokeDashArray = value;
            }
        }
        public System.Windows.Style Style
        {
            get
            {
                return inter.Style;
            }
            set
            {
                inter.Style = value;
            }
        }
        public bool OverridesDefaultStyle
        {
            get
            {
                return inter.OverridesDefaultStyle;
            }
            set
            {
                inter.OverridesDefaultStyle = value;
            }
        }
        public bool UseLayoutRounding
        {
            get
            {
                return inter.UseLayoutRounding;
            }
            set
            {
                inter.UseLayoutRounding = value;
            }
        }
        public System.Windows.TriggerCollection Triggers
        {
            get
            {
                return inter.Triggers;
            }
        }
        public System.Windows.DependencyObject TemplatedParent
        {
            get
            {
                return inter.TemplatedParent;
            }
        }
        public System.Windows.ResourceDictionary Resources
        {
            get
            {
                return inter.Resources;
            }
            set
            {
                inter.Resources = value;
            }
        }
        public object DataContext
        {
            get
            {
                return inter.DataContext;
            }
            set
            {
                inter.DataContext = value;
            }
        }
        public System.Windows.Data.BindingGroup BindingGroup
        {
            get
            {
                return inter.BindingGroup;
            }
            set
            {
                inter.BindingGroup = value;
            }
        }
        public System.Windows.Markup.XmlLanguage Language
        {
            get
            {
                return inter.Language;
            }
            set
            {
                inter.Language = value;
            }
        }
        public String Name
        {
            get
            {
                return inter.Name;
            }
            set
            {
                inter.Name = value;
            }
        }
        public object Tag
        {
            get
            {
                return inter.Tag;
            }
            set
            {
                inter.Tag = value;
            }
        }
        public System.Windows.Input.InputScope InputScope
        {
            get
            {
                return inter.InputScope;
            }
            set
            {
                inter.InputScope = value;
            }
        }
        public double ActualWidth
        {
            get
            {
                return inter.ActualWidth;
            }
        }
        public double ActualHeight
        {
            get
            {
                return inter.ActualHeight;
            }
        }
        public System.Windows.Media.Transform LayoutTransform
        {
            get
            {
                return inter.LayoutTransform;
            }
            set
            {
                inter.LayoutTransform = value;
            }
        }
        public double Width
        {
            get
            {
                return inter.Width;
            }
            set
            {
                inter.Width = value;
            }
        }
        public double MinWidth
        {
            get
            {
                return inter.MinWidth;
            }
            set
            {
                inter.MinWidth = value;
            }
        }
        public double MaxWidth
        {
            get
            {
                return inter.MaxWidth;
            }
            set
            {
                inter.MaxWidth = value;
            }
        }
        public double Height
        {
            get
            {
                return inter.Height;
            }
            set
            {
                inter.Height = value;
            }
        }
        public double MinHeight
        {
            get
            {
                return inter.MinHeight;
            }
            set
            {
                inter.MinHeight = value;
            }
        }
        public double MaxHeight
        {
            get
            {
                return inter.MaxHeight;
            }
            set
            {
                inter.MaxHeight = value;
            }
        }
        public System.Windows.FlowDirection FlowDirection
        {
            get
            {
                return inter.FlowDirection;
            }
            set
            {
                inter.FlowDirection = value;
            }
        }
        public System.Windows.Thickness Margin
        {
            get
            {
                return inter.Margin;
            }
            set
            {
                inter.Margin = value;
            }
        }
        public System.Windows.HorizontalAlignment HorizontalAlignment
        {
            get
            {
                return inter.HorizontalAlignment;
            }
            set
            {
                inter.HorizontalAlignment = value;
            }
        }
        public System.Windows.VerticalAlignment VerticalAlignment
        {
            get
            {
                return inter.VerticalAlignment;
            }
            set
            {
                inter.VerticalAlignment = value;
            }
        }
        public System.Windows.Style FocusVisualStyle
        {
            get
            {
                return inter.FocusVisualStyle;
            }
            set
            {
                inter.FocusVisualStyle = value;
            }
        }
        public System.Windows.Input.Cursor Cursor
        {
            get
            {
                return inter.Cursor;
            }
            set
            {
                inter.Cursor = value;
            }
        }
        public bool ForceCursor
        {
            get
            {
                return inter.ForceCursor;
            }
            set
            {
                inter.ForceCursor = value;
            }
        }
        public bool IsInitialized
        {
            get
            {
                return inter.IsInitialized;
            }
        }
        public bool IsLoaded
        {
            get
            {
                return inter.IsLoaded;
            }
        }
        public object ToolTip
        {
            get
            {
                return inter.ToolTip;
            }
            set
            {
                inter.ToolTip = value;
            }
        }
        public System.Windows.Controls.ContextMenu ContextMenu
        {
            get
            {
                return inter.ContextMenu;
            }
            set
            {
                inter.ContextMenu = value;
            }
        }
        public System.Windows.DependencyObject Parent
        {
            get
            {
                return inter.Parent;
            }
        }
        public bool HasAnimatedProperties
        {
            get
            {
                return inter.HasAnimatedProperties;
            }
        }
        public System.Windows.Input.InputBindingCollection InputBindings
        {
            get
            {
                return inter.InputBindings;
            }
        }
        public System.Windows.Input.CommandBindingCollection CommandBindings
        {
            get
            {
                return inter.CommandBindings;
            }
        }
        public bool AllowDrop
        {
            get
            {
                return inter.AllowDrop;
            }
            set
            {
                inter.AllowDrop = value;
            }
        }
        public System.Windows.Size DesiredSize
        {
            get
            {
                return inter.DesiredSize;
            }
        }
        public bool IsMeasureValid
        {
            get
            {
                return inter.IsMeasureValid;
            }
        }
        public bool IsArrangeValid
        {
            get
            {
                return inter.IsArrangeValid;
            }
        }
        public System.Windows.Size RenderSize
        {
            get
            {
                return inter.RenderSize;
            }
            set
            {
                inter.RenderSize = value;
            }
        }
        public System.Windows.Media.Transform RenderTransform
        {
            get
            {
                return inter.RenderTransform;
            }
            set
            {
                inter.RenderTransform = value;
            }
        }
        public System.Windows.Point RenderTransformOrigin
        {
            get
            {
                return inter.RenderTransformOrigin;
            }
            set
            {
                inter.RenderTransformOrigin = value;
            }
        }
        public bool IsMouseDirectlyOver
        {
            get
            {
                return inter.IsMouseDirectlyOver;
            }
        }
        public bool IsMouseOver
        {
            get
            {
                return inter.IsMouseOver;
            }
        }
        public bool IsStylusOver
        {
            get
            {
                return inter.IsStylusOver;
            }
        }
        public bool IsKeyboardFocusWithin
        {
            get
            {
                return inter.IsKeyboardFocusWithin;
            }
        }
        public bool IsMouseCaptured
        {
            get
            {
                return inter.IsMouseCaptured;
            }
        }
        public bool IsMouseCaptureWithin
        {
            get
            {
                return inter.IsMouseCaptureWithin;
            }
        }
        public bool IsStylusDirectlyOver
        {
            get
            {
                return inter.IsStylusDirectlyOver;
            }
        }
        public bool IsStylusCaptured
        {
            get
            {
                return inter.IsStylusCaptured;
            }
        }
        public bool IsStylusCaptureWithin
        {
            get
            {
                return inter.IsStylusCaptureWithin;
            }
        }
        public bool IsKeyboardFocused
        {
            get
            {
                return inter.IsKeyboardFocused;
            }
        }
        public bool IsInputMethodEnabled
        {
            get
            {
                return inter.IsInputMethodEnabled;
            }
        }
        public double Opacity
        {
            get
            {
                return inter.Opacity;
            }
            set
            {
                inter.Opacity = value;
            }
        }
        public System.Windows.Media.Brush OpacityMask
        {
            get
            {
                return inter.OpacityMask;
            }
            set
            {
                inter.OpacityMask = value;
            }
        }
        public System.Windows.Media.Effects.BitmapEffect BitmapEffect
        {
            get
            {
                return inter.BitmapEffect;
            }
            set
            {
                inter.BitmapEffect = value;
            }
        }
        public System.Windows.Media.Effects.Effect Effect
        {
            get
            {
                return inter.Effect;
            }
            set
            {
                inter.Effect = value;
            }
        }
        public System.Windows.Media.Effects.BitmapEffectInput BitmapEffectInput
        {
            get
            {
                return inter.BitmapEffectInput;
            }
            set
            {
                inter.BitmapEffectInput = value;
            }
        }
        public System.Windows.Media.CacheMode CacheMode
        {
            get
            {
                return inter.CacheMode;
            }
            set
            {
                inter.CacheMode = value;
            }
        }
        public String Uid
        {
            get
            {
                return inter.Uid;
            }
            set
            {
                inter.Uid = value;
            }
        }
        public System.Windows.Visibility Visibility
        {
            get
            {
                return inter.Visibility;
            }
            set
            {
                inter.Visibility = value;
            }
        }
        public bool ClipToBounds
        {
            get
            {
                return inter.ClipToBounds;
            }
            set
            {
                inter.ClipToBounds = value;
            }
        }
        public System.Windows.Media.Geometry Clip
        {
            get
            {
                return inter.Clip;
            }
            set
            {
                inter.Clip = value;
            }
        }
        public bool SnapsToDevicePixels
        {
            get
            {
                return inter.SnapsToDevicePixels;
            }
            set
            {
                inter.SnapsToDevicePixels = value;
            }
        }
        public bool IsFocused
        {
            get
            {
                return inter.IsFocused;
            }
        }
        public bool IsEnabled
        {
            get
            {
                return inter.IsEnabled;
            }
            set
            {
                inter.IsEnabled = value;
            }
        }
        public bool IsHitTestVisible
        {
            get
            {
                return inter.IsHitTestVisible;
            }
            set
            {
                inter.IsHitTestVisible = value;
            }
        }
        public bool IsVisible
        {
            get
            {
                return inter.IsVisible;
            }
        }
        public bool Focusable
        {
            get
            {
                return inter.Focusable;
            }
            set
            {
                inter.Focusable = value;
            }
        }
        public Int32 PersistId
        {
            get
            {
                return inter.PersistId;
            }
        }
        public bool IsManipulationEnabled
        {
            get
            {
                return inter.IsManipulationEnabled;
            }
            set
            {
                inter.IsManipulationEnabled = value;
            }
        }
        public bool AreAnyTouchesOver
        {
            get
            {
                return inter.AreAnyTouchesOver;
            }
        }
        public bool AreAnyTouchesDirectlyOver
        {
            get
            {
                return inter.AreAnyTouchesDirectlyOver;
            }
        }
        public bool AreAnyTouchesCapturedWithin
        {
            get
            {
                return inter.AreAnyTouchesCapturedWithin;
            }
        }
        public bool AreAnyTouchesCaptured
        {
            get
            {
                return inter.AreAnyTouchesCaptured;
            }
        }
        public IEnumerable<System.Windows.Input.TouchDevice> TouchesCaptured
        {
            get
            {
                return inter.TouchesCaptured;
            }
        }
        public IEnumerable<System.Windows.Input.TouchDevice> TouchesCapturedWithin
        {
            get
            {
                return inter.TouchesCapturedWithin;
            }
        }
        public IEnumerable<System.Windows.Input.TouchDevice> TouchesOver
        {
            get
            {
                return inter.TouchesOver;
            }
        }
        public IEnumerable<System.Windows.Input.TouchDevice> TouchesDirectlyOver
        {
            get
            {
                return inter.TouchesDirectlyOver;
            }
        }
        public System.Windows.DependencyObjectType DependencyObjectType
        {
            get
            {
                return inter.DependencyObjectType;
            }
        }
        public bool IsSealed
        {
            get
            {
                return inter.IsSealed;
            }
        }
        public System.Windows.Threading.Dispatcher Dispatcher
        {
            get
            {
                return inter.Dispatcher;
            }
        }
        #endregion

        #region Methods

        public bool ShouldSerializeStyle()
        {
            return inter.ShouldSerializeStyle();
        }

        public bool ApplyTemplate()
        {
            return inter.ApplyTemplate();
        }

        public void OnApplyTemplate()
        {
            inter.OnApplyTemplate();
        }

        public void BeginStoryboard(System.Windows.Media.Animation.Storyboard storyboard)
        {
            inter.BeginStoryboard(storyboard);
        }

        public void BeginStoryboard(System.Windows.Media.Animation.Storyboard storyboard, System.Windows.Media.Animation.HandoffBehavior handoffBehavior)
        {
            inter.BeginStoryboard(storyboard, handoffBehavior);
        }

        public void BeginStoryboard(System.Windows.Media.Animation.Storyboard storyboard, System.Windows.Media.Animation.HandoffBehavior handoffBehavior, bool isControllable)
        {
            inter.BeginStoryboard(storyboard, handoffBehavior, isControllable);
        }

        public bool ShouldSerializeTriggers()
        {
            return inter.ShouldSerializeTriggers();
        }

        public bool ShouldSerializeResources()
        {
            return inter.ShouldSerializeResources();
        }

        public object FindResource(object resourceKey)
        {
            return inter.FindResource(resourceKey);
        }

        public object TryFindResource(object resourceKey)
        {
            return inter.TryFindResource(resourceKey);
        }

        public void SetResourceReference(System.Windows.DependencyProperty dp, object name)
        {
            inter.SetResourceReference(dp, name);
        }

        public System.Windows.Data.BindingExpression GetBindingExpression(System.Windows.DependencyProperty dp)
        {
            return inter.GetBindingExpression(dp);
        }

        public System.Windows.Data.BindingExpressionBase SetBinding(System.Windows.DependencyProperty dp, System.Windows.Data.BindingBase binding)
        {
            return inter.SetBinding(dp, binding);
        }

        public System.Windows.Data.BindingExpression SetBinding(System.Windows.DependencyProperty dp, String path)
        {
            return inter.SetBinding(dp, path);
        }

        public void BringIntoView()
        {
            inter.BringIntoView();
        }

        public void BringIntoView(System.Windows.Rect targetRectangle)
        {
            inter.BringIntoView(targetRectangle);
        }

        public bool MoveFocus(System.Windows.Input.TraversalRequest request)
        {
            return inter.MoveFocus(request);
        }

        public System.Windows.DependencyObject PredictFocus(System.Windows.Input.FocusNavigationDirection direction)
        {
            return inter.PredictFocus(direction);
        }

        public void BeginInit()
        {
            inter.BeginInit();
        }

        public void EndInit()
        {
            inter.EndInit();
        }

        public void RegisterName(String name, object scopedElement)
        {
            inter.RegisterName(name, scopedElement);
        }

        public void UnregisterName(String name)
        {
            inter.UnregisterName(name);
        }

        public object FindName(String name)
        {
            return inter.FindName(name);
        }

        public void UpdateDefaultStyle()
        {
            inter.UpdateDefaultStyle();
        }

        public void ApplyAnimationClock(System.Windows.DependencyProperty dp, System.Windows.Media.Animation.AnimationClock clock)
        {
            inter.ApplyAnimationClock(dp, clock);
        }

        public void ApplyAnimationClock(System.Windows.DependencyProperty dp, System.Windows.Media.Animation.AnimationClock clock, System.Windows.Media.Animation.HandoffBehavior handoffBehavior)
        {
            inter.ApplyAnimationClock(dp, clock, handoffBehavior);
        }

        public void BeginAnimation(System.Windows.DependencyProperty dp, System.Windows.Media.Animation.AnimationTimeline animation)
        {
            inter.BeginAnimation(dp, animation);
        }

        public void BeginAnimation(System.Windows.DependencyProperty dp, System.Windows.Media.Animation.AnimationTimeline animation, System.Windows.Media.Animation.HandoffBehavior handoffBehavior)
        {
            inter.BeginAnimation(dp, animation, handoffBehavior);
        }

        public object GetAnimationBaseValue(System.Windows.DependencyProperty dp)
        {
            return inter.GetAnimationBaseValue(dp);
        }

        public bool ShouldSerializeInputBindings()
        {
            return inter.ShouldSerializeInputBindings();
        }

        public bool ShouldSerializeCommandBindings()
        {
            return inter.ShouldSerializeCommandBindings();
        }

        public void RaiseEvent(System.Windows.RoutedEventArgs e)
        {
            inter.RaiseEvent(e);
        }

        public void AddHandler(System.Windows.RoutedEvent routedEvent, System.Delegate handler)
        {
            inter.AddHandler(routedEvent, handler);
        }

        public void AddHandler(System.Windows.RoutedEvent routedEvent, System.Delegate handler, bool handledEventsToo)
        {
            inter.AddHandler(routedEvent, handler, handledEventsToo);
        }

        public void RemoveHandler(System.Windows.RoutedEvent routedEvent, System.Delegate handler)
        {
            inter.RemoveHandler(routedEvent, handler);
        }

        public void AddToEventRoute(System.Windows.EventRoute route, System.Windows.RoutedEventArgs e)
        {
            inter.AddToEventRoute(route, e);
        }

        public void InvalidateMeasure()
        {
            inter.InvalidateMeasure();
        }

        public void InvalidateArrange()
        {
            inter.InvalidateArrange();
        }

        public void InvalidateVisual()
        {
            inter.InvalidateVisual();
        }

        public void Measure(System.Windows.Size availableSize)
        {
            inter.Measure(availableSize);
        }

        public void Arrange(System.Windows.Rect finalRect)
        {
            inter.Arrange(finalRect);
        }

        public void UpdateLayout()
        {
            inter.UpdateLayout();
        }

        public System.Windows.Point TranslatePoint(System.Windows.Point point, System.Windows.UIElement relativeTo)
        {
            return inter.TranslatePoint(point, relativeTo);
        }

        public System.Windows.IInputElement InputHitTest(System.Windows.Point point)
        {
            return inter.InputHitTest(point);
        }

        public bool CaptureMouse()
        {
            return inter.CaptureMouse();
        }

        public void ReleaseMouseCapture()
        {
            inter.ReleaseMouseCapture();
        }

        public bool CaptureStylus()
        {
            return inter.CaptureStylus();
        }

        public void ReleaseStylusCapture()
        {
            inter.ReleaseStylusCapture();
        }

        public bool Focus()
        {
            return inter.Focus();
        }

        public bool CaptureTouch(System.Windows.Input.TouchDevice touchDevice)
        {
            return inter.CaptureTouch(touchDevice);
        }

        public bool ReleaseTouchCapture(System.Windows.Input.TouchDevice touchDevice)
        {
            return inter.ReleaseTouchCapture(touchDevice);
        }

        public void ReleaseAllTouchCaptures()
        {
            inter.ReleaseAllTouchCaptures();
        }

        public bool IsAncestorOf(System.Windows.DependencyObject descendant)
        {
            return inter.IsAncestorOf(descendant);
        }

        public bool IsDescendantOf(System.Windows.DependencyObject ancestor)
        {
            return inter.IsDescendantOf(ancestor);
        }

        public System.Windows.DependencyObject FindCommonVisualAncestor(System.Windows.DependencyObject otherVisual)
        {
            return inter.FindCommonVisualAncestor(otherVisual);
        }

        public System.Windows.Media.GeneralTransform TransformToAncestor(System.Windows.Media.Visual ancestor)
        {
            return inter.TransformToAncestor(ancestor);
        }

        public System.Windows.Media.Media3D.GeneralTransform2DTo3D TransformToAncestor(System.Windows.Media.Media3D.Visual3D ancestor)
        {
            return inter.TransformToAncestor(ancestor);
        }

        public System.Windows.Media.GeneralTransform TransformToDescendant(System.Windows.Media.Visual descendant)
        {
            return inter.TransformToDescendant(descendant);
        }

        public System.Windows.Media.GeneralTransform TransformToVisual(System.Windows.Media.Visual visual)
        {
            return inter.TransformToVisual(visual);
        }

        public System.Windows.Point PointToScreen(System.Windows.Point point)
        {
            return inter.PointToScreen(point);
        }

        public System.Windows.Point PointFromScreen(System.Windows.Point point)
        {
            return inter.PointFromScreen(point);
        }

        public bool Equals(object obj)
        {
            return inter.Equals(obj);
        }

        public Int32 GetHashCode()
        {
            return inter.GetHashCode();
        }

        public object GetValue(System.Windows.DependencyProperty dp)
        {
            return inter.GetValue(dp);
        }

        public void SetValue(System.Windows.DependencyProperty dp, object value)
        {
            inter.SetValue(dp, value);
        }

        public void SetCurrentValue(System.Windows.DependencyProperty dp, object value)
        {
            inter.SetCurrentValue(dp, value);
        }

        public void SetValue(System.Windows.DependencyPropertyKey key, object value)
        {
            inter.SetValue(key, value);
        }

        public void ClearValue(System.Windows.DependencyProperty dp)
        {
            inter.ClearValue(dp);
        }

        public void ClearValue(System.Windows.DependencyPropertyKey key)
        {
            inter.ClearValue(key);
        }

        public void CoerceValue(System.Windows.DependencyProperty dp)
        {
            inter.CoerceValue(dp);
        }

        public void InvalidateProperty(System.Windows.DependencyProperty dp)
        {
            inter.InvalidateProperty(dp);
        }

        public object ReadLocalValue(System.Windows.DependencyProperty dp)
        {
            return inter.ReadLocalValue(dp);
        }

        public System.Windows.LocalValueEnumerator GetLocalValueEnumerator()
        {
            return inter.GetLocalValueEnumerator();
        }

        public bool CheckAccess()
        {
            return inter.CheckAccess();
        }

        public void VerifyAccess()
        {
            inter.VerifyAccess();
        }

        public override String ToString()
        {
            return inter.ToString();
        }

        public System.Type GetType()
        {
            return inter.GetType();
        }

        #endregion

        #region Events

        public event EventHandler<System.Windows.Data.DataTransferEventArgs> TargetUpdated;
        public event EventHandler<System.Windows.Data.DataTransferEventArgs> SourceUpdated;
        public event System.Windows.DependencyPropertyChangedEventHandler DataContextChanged;
        public event System.Windows.RequestBringIntoViewEventHandler RequestBringIntoView;
        public event System.Windows.SizeChangedEventHandler SizeChanged;
        public event EventHandler Initialized;
        public event System.Windows.RoutedEventHandler Loaded;
        public event System.Windows.RoutedEventHandler Unloaded;
        public event System.Windows.Controls.ToolTipEventHandler ToolTipOpening;
        public event System.Windows.Controls.ToolTipEventHandler ToolTipClosing;
        public event System.Windows.Controls.ContextMenuEventHandler ContextMenuOpening;
        public event System.Windows.Controls.ContextMenuEventHandler ContextMenuClosing;
        public event System.Windows.Input.MouseButtonEventHandler PreviewMouseDown;
        public event System.Windows.Input.MouseButtonEventHandler MouseDown;
        public event System.Windows.Input.MouseButtonEventHandler PreviewMouseUp;
        public event System.Windows.Input.MouseButtonEventHandler MouseUp;
        public event System.Windows.Input.MouseButtonEventHandler PreviewMouseLeftButtonDown;
        public event System.Windows.Input.MouseButtonEventHandler MouseLeftButtonDown;
        public event System.Windows.Input.MouseButtonEventHandler PreviewMouseLeftButtonUp;
        public event System.Windows.Input.MouseButtonEventHandler MouseLeftButtonUp;
        public event System.Windows.Input.MouseButtonEventHandler PreviewMouseRightButtonDown;
        public event System.Windows.Input.MouseButtonEventHandler MouseRightButtonDown;
        public event System.Windows.Input.MouseButtonEventHandler PreviewMouseRightButtonUp;
        public event System.Windows.Input.MouseButtonEventHandler MouseRightButtonUp;
        public event System.Windows.Input.MouseEventHandler PreviewMouseMove;
        public event System.Windows.Input.MouseEventHandler MouseMove;
        public event System.Windows.Input.MouseWheelEventHandler PreviewMouseWheel;
        public event System.Windows.Input.MouseWheelEventHandler MouseWheel;
        public event System.Windows.Input.MouseEventHandler MouseEnter;
        public event System.Windows.Input.MouseEventHandler MouseLeave;
        public event System.Windows.Input.MouseEventHandler GotMouseCapture;
        public event System.Windows.Input.MouseEventHandler LostMouseCapture;
        public event System.Windows.Input.QueryCursorEventHandler QueryCursor;
        public event System.Windows.Input.StylusDownEventHandler PreviewStylusDown;
        public event System.Windows.Input.StylusDownEventHandler StylusDown;
        public event System.Windows.Input.StylusEventHandler PreviewStylusUp;
        public event System.Windows.Input.StylusEventHandler StylusUp;
        public event System.Windows.Input.StylusEventHandler PreviewStylusMove;
        public event System.Windows.Input.StylusEventHandler StylusMove;
        public event System.Windows.Input.StylusEventHandler PreviewStylusInAirMove;
        public event System.Windows.Input.StylusEventHandler StylusInAirMove;
        public event System.Windows.Input.StylusEventHandler StylusEnter;
        public event System.Windows.Input.StylusEventHandler StylusLeave;
        public event System.Windows.Input.StylusEventHandler PreviewStylusInRange;
        public event System.Windows.Input.StylusEventHandler StylusInRange;
        public event System.Windows.Input.StylusEventHandler PreviewStylusOutOfRange;
        public event System.Windows.Input.StylusEventHandler StylusOutOfRange;
        public event System.Windows.Input.StylusSystemGestureEventHandler PreviewStylusSystemGesture;
        public event System.Windows.Input.StylusSystemGestureEventHandler StylusSystemGesture;
        public event System.Windows.Input.StylusEventHandler GotStylusCapture;
        public event System.Windows.Input.StylusEventHandler LostStylusCapture;
        public event System.Windows.Input.StylusButtonEventHandler StylusButtonDown;
        public event System.Windows.Input.StylusButtonEventHandler StylusButtonUp;
        public event System.Windows.Input.StylusButtonEventHandler PreviewStylusButtonDown;
        public event System.Windows.Input.StylusButtonEventHandler PreviewStylusButtonUp;
        public event System.Windows.Input.KeyEventHandler PreviewKeyDown;
        public event System.Windows.Input.KeyEventHandler KeyDown;
        public event System.Windows.Input.KeyEventHandler PreviewKeyUp;
        public event System.Windows.Input.KeyEventHandler KeyUp;
        public event System.Windows.Input.KeyboardFocusChangedEventHandler PreviewGotKeyboardFocus;
        public event System.Windows.Input.KeyboardFocusChangedEventHandler GotKeyboardFocus;
        public event System.Windows.Input.KeyboardFocusChangedEventHandler PreviewLostKeyboardFocus;
        public event System.Windows.Input.KeyboardFocusChangedEventHandler LostKeyboardFocus;
        public event System.Windows.Input.TextCompositionEventHandler PreviewTextInput;
        public event System.Windows.Input.TextCompositionEventHandler TextInput;
        public event System.Windows.QueryContinueDragEventHandler PreviewQueryContinueDrag;
        public event System.Windows.QueryContinueDragEventHandler QueryContinueDrag;
        public event System.Windows.GiveFeedbackEventHandler PreviewGiveFeedback;
        public event System.Windows.GiveFeedbackEventHandler GiveFeedback;
        public event System.Windows.DragEventHandler PreviewDragEnter;
        public event System.Windows.DragEventHandler DragEnter;
        public event System.Windows.DragEventHandler PreviewDragOver;
        public event System.Windows.DragEventHandler DragOver;
        public event System.Windows.DragEventHandler PreviewDragLeave;
        public event System.Windows.DragEventHandler DragLeave;
        public event System.Windows.DragEventHandler PreviewDrop;
        public event System.Windows.DragEventHandler Drop;
        public event EventHandler<System.Windows.Input.TouchEventArgs> PreviewTouchDown;
        public event EventHandler<System.Windows.Input.TouchEventArgs> TouchDown;
        public event EventHandler<System.Windows.Input.TouchEventArgs> PreviewTouchMove;
        public event EventHandler<System.Windows.Input.TouchEventArgs> TouchMove;
        public event EventHandler<System.Windows.Input.TouchEventArgs> PreviewTouchUp;
        public event EventHandler<System.Windows.Input.TouchEventArgs> TouchUp;
        public event EventHandler<System.Windows.Input.TouchEventArgs> GotTouchCapture;
        public event EventHandler<System.Windows.Input.TouchEventArgs> LostTouchCapture;
        public event EventHandler<System.Windows.Input.TouchEventArgs> TouchEnter;
        public event EventHandler<System.Windows.Input.TouchEventArgs> TouchLeave;
        public event System.Windows.DependencyPropertyChangedEventHandler IsMouseDirectlyOverChanged;
        public event System.Windows.DependencyPropertyChangedEventHandler IsKeyboardFocusWithinChanged;
        public event System.Windows.DependencyPropertyChangedEventHandler IsMouseCapturedChanged;
        public event System.Windows.DependencyPropertyChangedEventHandler IsMouseCaptureWithinChanged;
        public event System.Windows.DependencyPropertyChangedEventHandler IsStylusDirectlyOverChanged;
        public event System.Windows.DependencyPropertyChangedEventHandler IsStylusCapturedChanged;
        public event System.Windows.DependencyPropertyChangedEventHandler IsStylusCaptureWithinChanged;
        public event System.Windows.DependencyPropertyChangedEventHandler IsKeyboardFocusedChanged;
        public event EventHandler LayoutUpdated;
        public event System.Windows.RoutedEventHandler GotFocus;
        public event System.Windows.RoutedEventHandler LostFocus;
        public event System.Windows.DependencyPropertyChangedEventHandler IsEnabledChanged;
        public event System.Windows.DependencyPropertyChangedEventHandler IsHitTestVisibleChanged;
        public event System.Windows.DependencyPropertyChangedEventHandler IsVisibleChanged;
        public event System.Windows.DependencyPropertyChangedEventHandler FocusableChanged;
        public event EventHandler<System.Windows.Input.ManipulationStartingEventArgs> ManipulationStarting;
        public event EventHandler<System.Windows.Input.ManipulationStartedEventArgs> ManipulationStarted;
        public event EventHandler<System.Windows.Input.ManipulationDeltaEventArgs> ManipulationDelta;
        public event EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting;
        public event EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> ManipulationBoundaryFeedback;
        public event EventHandler<System.Windows.Input.ManipulationCompletedEventArgs> ManipulationCompleted;
        private void EventAssotiation()
        {
            /*
            inter.TargetUpdated += TargetUpdated;
            inter.SourceUpdated += SourceUpdated;
            inter.DataContextChanged += DataContextChanged;
            inter.RequestBringIntoView += RequestBringIntoView;
            inter.SizeChanged += SizeChanged;
            inter.Initialized += Initialized;
            inter.Loaded += Loaded;
            inter.Unloaded += Unloaded;
            inter.ToolTipOpening += ToolTipOpening;
            inter.ToolTipClosing += ToolTipClosing;
            inter.ContextMenuOpening += ContextMenuOpening;
            inter.ContextMenuClosing += ContextMenuClosing;
            inter.PreviewMouseDown += PreviewMouseDown;
            inter.MouseDown += MouseDown;
            inter.PreviewMouseUp += PreviewMouseUp;
            inter.MouseUp += MouseUp;
            inter.PreviewMouseLeftButtonDown += PreviewMouseLeftButtonDown;
            inter.MouseLeftButtonDown += MouseLeftButtonDown;
            inter.PreviewMouseLeftButtonUp += PreviewMouseLeftButtonUp;
            inter.MouseLeftButtonUp += MouseLeftButtonUp;
            inter.PreviewMouseRightButtonDown += PreviewMouseRightButtonDown;
            inter.MouseRightButtonDown += MouseRightButtonDown;
            inter.PreviewMouseRightButtonUp += PreviewMouseRightButtonUp;
            inter.MouseRightButtonUp += MouseRightButtonUp;
            inter.PreviewMouseMove += PreviewMouseMove;
            inter.MouseMove += MouseMove;
            inter.PreviewMouseWheel += PreviewMouseWheel;
            inter.MouseWheel += MouseWheel;
            inter.MouseEnter += MouseEnter;
            inter.MouseLeave += MouseLeave;
            inter.GotMouseCapture += GotMouseCapture;
            inter.LostMouseCapture += LostMouseCapture;
            inter.QueryCursor += QueryCursor;
            inter.PreviewStylusDown += PreviewStylusDown;
            inter.StylusDown += StylusDown;
            inter.PreviewStylusUp += PreviewStylusUp;
            inter.StylusUp += StylusUp;
            inter.PreviewStylusMove += PreviewStylusMove;
            inter.StylusMove += StylusMove;
            inter.PreviewStylusInAirMove += PreviewStylusInAirMove;
            inter.StylusInAirMove += StylusInAirMove;
            inter.StylusEnter += StylusEnter;
            inter.StylusLeave += StylusLeave;
            inter.PreviewStylusInRange += PreviewStylusInRange;
            inter.StylusInRange += StylusInRange;
            inter.PreviewStylusOutOfRange += PreviewStylusOutOfRange;
            inter.StylusOutOfRange += StylusOutOfRange;
            inter.PreviewStylusSystemGesture += PreviewStylusSystemGesture;
            inter.StylusSystemGesture += StylusSystemGesture;
            inter.GotStylusCapture += GotStylusCapture;
            inter.LostStylusCapture += LostStylusCapture;
            inter.StylusButtonDown += StylusButtonDown;
            inter.StylusButtonUp += StylusButtonUp;
            inter.PreviewStylusButtonDown += PreviewStylusButtonDown;
            inter.PreviewStylusButtonUp += PreviewStylusButtonUp;
            inter.PreviewKeyDown += PreviewKeyDown;
            inter.KeyDown += KeyDown;
            inter.PreviewKeyUp += PreviewKeyUp;
            inter.KeyUp += KeyUp;
            inter.PreviewGotKeyboardFocus += PreviewGotKeyboardFocus;
            inter.GotKeyboardFocus += GotKeyboardFocus;
            inter.PreviewLostKeyboardFocus += PreviewLostKeyboardFocus;
            inter.LostKeyboardFocus += LostKeyboardFocus;
            inter.PreviewTextInput += PreviewTextInput;
            inter.TextInput += TextInput;
            inter.PreviewQueryContinueDrag += PreviewQueryContinueDrag;
            inter.QueryContinueDrag += QueryContinueDrag;
            inter.PreviewGiveFeedback += PreviewGiveFeedback;
            inter.GiveFeedback += GiveFeedback;
            inter.PreviewDragEnter += PreviewDragEnter;
            inter.DragEnter += DragEnter;
            inter.PreviewDragOver += PreviewDragOver;
            inter.DragOver += DragOver;
            inter.PreviewDragLeave += PreviewDragLeave;
            inter.DragLeave += DragLeave;
            inter.PreviewDrop += PreviewDrop;
            inter.Drop += Drop;
            inter.PreviewTouchDown += PreviewTouchDown;
            inter.TouchDown += TouchDown;
            inter.PreviewTouchMove += PreviewTouchMove;
            inter.TouchMove += TouchMove;
            inter.PreviewTouchUp += PreviewTouchUp;
            inter.TouchUp += TouchUp;
            inter.GotTouchCapture += GotTouchCapture;
            inter.LostTouchCapture += LostTouchCapture;
            inter.TouchEnter += TouchEnter;
            inter.TouchLeave += TouchLeave;
            inter.IsMouseDirectlyOverChanged += IsMouseDirectlyOverChanged;
            inter.IsKeyboardFocusWithinChanged += IsKeyboardFocusWithinChanged;
            inter.IsMouseCapturedChanged += IsMouseCapturedChanged;
            inter.IsMouseCaptureWithinChanged += IsMouseCaptureWithinChanged;
            inter.IsStylusDirectlyOverChanged += IsStylusDirectlyOverChanged;
            inter.IsStylusCapturedChanged += IsStylusCapturedChanged;
            inter.IsStylusCaptureWithinChanged += IsStylusCaptureWithinChanged;
            inter.IsKeyboardFocusedChanged += IsKeyboardFocusedChanged;
            inter.LayoutUpdated += LayoutUpdated;
            inter.GotFocus += GotFocus;
            inter.LostFocus += LostFocus;
            inter.IsEnabledChanged += IsEnabledChanged;
            inter.IsHitTestVisibleChanged += IsHitTestVisibleChanged;
            inter.IsVisibleChanged += IsVisibleChanged;
            inter.FocusableChanged += FocusableChanged;
            inter.ManipulationStarting += ManipulationStarting;
            inter.ManipulationStarted += ManipulationStarted;
            inter.ManipulationDelta += ManipulationDelta;
            inter.ManipulationInertiaStarting += ManipulationInertiaStarting;
            inter.ManipulationBoundaryFeedback += ManipulationBoundaryFeedback;
            inter.ManipulationCompleted += ManipulationCompleted;
            */
        }
        #endregion


        

        public static implicit operator Line(LinePlus d)
        {
            return d.inter;
        }
       

    }
}
