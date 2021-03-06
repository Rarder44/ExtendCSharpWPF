﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Shapes;

namespace ExtendCSharpWPF.Ribbon
{
    public class RibbonBehavior
    {

        public static bool GetHideRibbonTabs(DependencyObject obj)
        {
            return (bool)obj.GetValue(HideRibbonTabsProperty);
        }

        public static void SetHideRibbonTabs(DependencyObject obj, bool value)
        {
            obj.SetValue(HideRibbonTabsProperty, value);
        }

        // Using a DependencyProperty as the backing store for HideRibbonTabs.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HideRibbonTabsProperty =
            DependencyProperty.RegisterAttached("HideRibbonTabs", typeof(bool), typeof(RibbonBehavior), new UIPropertyMetadata(false, OnHideRibbonTabsChanged));



        public static void OnHideRibbonTabsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d == null || d.GetType() != typeof(System.Windows.Controls.Ribbon.Ribbon)) return;

            (d as System.Windows.Controls.Ribbon.Ribbon).Loaded += ctrl_Loaded;

        }

        static void ctrl_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender == null || sender.GetType() != typeof(System.Windows.Controls.Ribbon.Ribbon)) return;

            System.Windows.Controls.Ribbon.Ribbon _ribbon = (System.Windows.Controls.Ribbon.Ribbon)sender;

            var tabGrid = _ribbon.GetDescendants<Grid>().FirstOrDefault();
            tabGrid.RowDefinitions[1].Height = new GridLength(0, System.Windows.GridUnitType.Pixel);


            foreach (Line line in _ribbon.GetDescendants<Line>())
                line.Visibility = Visibility.Collapsed;

        }
    }
}
