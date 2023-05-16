using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSkeletonApp.ViewModels.AnchorablePanes
{
    /// <summary>
    /// AnchorablePane の ViewModel のベースクラス
    /// </summary>
    public abstract class AnchorablePaneViewModelBase : PropertyChangedBase
    {
        #region Title Property
        /// <summary>
        /// ウィンドウまたはタブのタイトル
        /// </summary>
        public abstract string Title { get; }
        #endregion

        #region ContentId Property
        /// <summary>
        /// Pane を一意に識別するための値 (レイアウトの保存等で使用する)
        /// </summary>
        public abstract string ContentId { get; }
        #endregion

        #region IsVisible Property
        /// <summary>
        /// ウィンドウの表示状態 (true の場合、表示されている)
        /// </summary>
        public bool IsVisible
        {
            get { return _isVisible; }
            set { Set(ref _isVisible, value); }
        }
        private bool _isVisible = true;
        #endregion
    }
}
