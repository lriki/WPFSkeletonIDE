using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows;

namespace WpfSkeletonApp.Views.DockingHelper
{
    /// <summary>
    /// LayoutItem のコンテナ (ウィンドウやタブ) のスタイルを選択するクラス。
    /// XAML 上で DataType プロパティに ViewModel の型を指定した DataTemplate を定義することができる。
    /// </summary>
    [ContentProperty("Items")]
    public class LayoutItemContainerStyleSelector : StyleSelector
    {
        /// <summary>
        /// Style のリスト。XAML でこのクラスの個要素として定義した Style はこのリストに追加される。
        /// </summary>
        public List<LayoutItemTypedStyle> Items { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LayoutItemContainerStyleSelector()
        {
            Items = new List<LayoutItemTypedStyle>();
        }

        /// <summary>
        /// スタイル選択時のコールバック
        /// </summary>
        /// <param name="item"></param>
        /// <param name="container"></param>
        /// <returns></returns>
        public override Style SelectStyle(object item, System.Windows.DependencyObject container)
        {
            // item には ViewModel が入っている。
            // ViewModel の型に対応するテンプレートを返す。
            var styleData = Items.Find((s) => s.DataType != null && item.GetType().IsSubclassOf(s.DataType));
            if (styleData != null && styleData.Style != null) return styleData.Style;

            return base.SelectStyle(item, container);
        }
    }

    /// <summary>
    /// ViewModel の型と Style をペアにするためのデータクラス
    /// </summary>
    [ContentProperty("Style")]
    public class LayoutItemTypedStyle
    {
        /// <summary>
        /// ViewModel の型
        /// </summary>
        public Type? DataType
        {
            get;
            set;
        }

        /// <summary>
        /// 対応するスタイル
        /// </summary>
        public Style? Style
        {
            get;
            set;
        }
    }
}
