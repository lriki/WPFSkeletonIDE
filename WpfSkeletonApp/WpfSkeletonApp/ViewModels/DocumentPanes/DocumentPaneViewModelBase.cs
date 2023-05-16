using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSkeletonApp.ViewModels.DocumentPanes
{
    /// <summary>
    /// DocumentPane の ViewModel のベースクラス
    /// </summary>
    public abstract class DocumentPaneViewModelBase : PropertyChangedBase
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

        #region IsActive Property
        /// <summary>
        /// Pane がアクティブかどうか
        /// </summary>
        public bool IsActive { get; set; }
        #endregion
    }
}

