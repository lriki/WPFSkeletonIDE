using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Markup;
using Xceed.Wpf.AvalonDock.Layout;
using System.Reflection;

namespace WPFSkeletonIDE.Views
{
    /// <summary>
    /// アプリを始めて起動したとき等、各ウィンドウの初期レイアウトを決めるためのクラス
    /// </summary>
    [ContentProperty("Items")]
    public class LayoutInitializer : ILayoutUpdateStrategy
    {
        /// <summary>
        /// LayoutInsertTarget のリスト。XAML でこのクラスの個要素として定義した LayoutInsertTarget はこのリストに追加される。
        /// </summary>
        public List<LayoutInsertTarget> Items { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LayoutInitializer()
        {
            Items = new List<LayoutInsertTarget>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="layout"></param>
        /// <param name="anchorableToShow">配置されようとしている LayoutAnchorable</param>
        /// <param name="destinationContainer"></param>
        /// <returns></returns>
        public bool BeforeInsertAnchorable(LayoutRoot layout, LayoutAnchorable anchorableToShow, ILayoutContainer destinationContainer)
        {
            LayoutAnchorablePane destPane = destinationContainer as LayoutAnchorablePane;
            if (destinationContainer != null &&
                destinationContainer.FindParent<LayoutFloatingWindow>() != null)
                return false;

            var viewModel = anchorableToShow.Content;
            if (viewModel == null) return false;

            var propInfo = viewModel.GetType().GetProperty("ContentId", BindingFlags.Public | BindingFlags.Instance);
            if (viewModel == null) return false;

            var contentId = (string)propInfo.GetValue(viewModel);

            var target = Items.Find((t) => t.ContentId == contentId);
            if (target == null) return false;

            // 選択した名前の領域を取得し、そこにドッキングウィンドウを追加する
            var pane = layout.Descendents().OfType<LayoutAnchorablePane>().FirstOrDefault(d => d.Name == target.TargetLayoutName);
            if (pane != null)
            {
                pane.Children.Add(anchorableToShow);
                return true;
            }
            return false;
        }

        public void AfterInsertAnchorable(LayoutRoot layout, LayoutAnchorable anchorableShown)
        {
        }

        public bool BeforeInsertDocument(LayoutRoot layout, LayoutDocument anchorableToShow, ILayoutContainer destinationContainer)
        {
            return false;
        }

        public void AfterInsertDocument(LayoutRoot layout, LayoutDocument anchorableShown)
        {
        }
    }

    /// <summary>
    /// コンテンツID と インスタンス化された LayoutContent の配置先をペアにするためのデータクラス
    /// </summary>
    public class LayoutInsertTarget
    {
        /// <summary>
        /// コンテンツID
        /// </summary>
        public string ContentId
        {
            get;
            set;
        }

        /// <summary>
        /// インスタンス化された LayoutContent の配置先の名前
        /// </summary>
        public string TargetLayoutName
        {
            get;
            set;
        }
    }
}
