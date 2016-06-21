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
    /// [プロジェクト設定] Document の ViewModel
    /// </summary>
    public class ProjectSettingDocumentViewModel : DocumentViewModelBase
    {
        #region Title Property
        public override string Title
        {
            get { return "MyProject"; }
        }
        #endregion

        #region ContentId Property
        public override string ContentId
        {
            get { return "ProjectSettingDocumentViewModel"; }   // 実際はファイルのフルパス等を使用するべき
        }
        #endregion
    }
}
