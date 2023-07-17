using SubRenamer.StringLocalization;
using System.Collections.Generic;
using System.IO;

namespace SubRenamer
{
    public enum VsStatus
    {
        /// <summary>
        /// 预备
        /// </summary>
        Ready,

        /// <summary>
        /// 完成
        /// </summary>
        Done,

        /// <summary>
        /// 错误
        /// </summary>
        Fatal,

        /// <summary>
        /// 未匹配
        /// </summary>
        Unmatched,

        /// <summary>
        /// 缺少视频文件
        /// </summary>
        VideoLack,

        /// <summary>
        /// 缺少字幕文件
        /// </summary>
        SubLack
    }

    /// <summary>
    /// 视频/字幕文件项目
    /// </summary>
    public class VsItem
    {
        /// <summary>
        /// 匹配桥梁值
        /// </summary>
        public string MatchKey { get; set; }

        /// <summary>
        /// 视频文件 FullName
        /// </summary>
        public string Video { get; set; }

        public FileInfo VideoFileInfo => (!string.IsNullOrWhiteSpace(Video)) ? new FileInfo(Video) : null;

        /// <summary>
        /// 字幕文件 FullName
        /// </summary>
        public string Sub { get; set; }

        public FileInfo SubFileInfo => (!string.IsNullOrWhiteSpace(Sub)) ? new FileInfo(Sub) : null;

        /// <summary>
        /// 当前状态
        /// </summary>
        public VsStatus Status { get; set; } = VsStatus.Unmatched;

        public string GetStatusStr()
        {
            var rm = _string.ResourceManager;
            var transDict = new Dictionary<VsStatus, string> {
                { VsStatus.Done, rm.GetString("status_success") },
                { VsStatus.Fatal, rm.GetString("status_failed") },
                { VsStatus.Ready, rm.GetString("status_matched") },
                { VsStatus.Unmatched, rm.GetString("status_unmatched") },
                { VsStatus.VideoLack, rm.GetString("status_miss_video") },
                { VsStatus.SubLack, rm.GetString("status_miss_sub") },
            };

            return transDict[Status];
        }

        public bool IsEmpty => string.IsNullOrEmpty(MatchKey) && string.IsNullOrEmpty(Video) && string.IsNullOrEmpty(Sub);
    }
}
