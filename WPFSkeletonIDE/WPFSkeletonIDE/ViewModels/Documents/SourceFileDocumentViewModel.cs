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

namespace WPFSkeletonIDE.ViewModels.Documents
{
    /// <summary>
    /// [ソースコード] Document の ViewModel
    /// </summary>
    public class SourceFileDocumentViewModel : DocumentViewModelBase
    {
        #region Title Property
        public override string Title
        {
            get { return "Source.cs"; }
        }
        #endregion

        #region ContentId Property
        public override string ContentId
        {
            get { return "SourceFileDocumentViewModel"; }   // 実際はファイルのフルパス等を使用するべき
        }
        #endregion
    }
}
