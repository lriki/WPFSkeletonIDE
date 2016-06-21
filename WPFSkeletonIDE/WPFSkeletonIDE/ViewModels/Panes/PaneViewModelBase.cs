using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;

using WPFSkeletonIDE.Models;

namespace WPFSkeletonIDE.ViewModels.Panes
{
    /// <summary>
    /// Pane の ViewModel のベースクラス
    /// </summary>
    public abstract class PaneViewModelBase : ViewModel
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
    }
}
