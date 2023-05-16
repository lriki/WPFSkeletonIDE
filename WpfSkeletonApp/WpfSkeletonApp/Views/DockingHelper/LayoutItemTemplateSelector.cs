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
    /// LayoutItem の内容となる DataTemplate を選択するクラス。
    /// XAML 上で DataType プロパティに ViewModel の型を指定した DataTemplate を定義することができる。
    /// </summary>
    [ContentProperty("Items")]
    public class LayoutItemTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// テンプレートのリスト。XAML でこのクラスの個要素として定義した DataTemplate はこのリストに追加される。
        /// </summary>
        public List<DataTemplate> Items { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LayoutItemTemplateSelector()
        {
            Items = new List<DataTemplate>();
        }

        /// <summary>
        /// LayoutItem のコンテンツに適用する DataTemplate を選択する。
        /// </summary>
        public override DataTemplate SelectTemplate(object item, System.Windows.DependencyObject container)
        {
            // item には ViewModel が入っている。
            // ViewModel の型に対応するテンプレートを返す。
            var template = Items.Find((dt) => item.GetType().Equals(dt.DataType));
            if (template != null) return template;

            return base.SelectTemplate(item, container);
        }
    }
}
