using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MikhailKhalizev.Utils
{
    [DebuggerDisplay("Name = {Name}")]
    public class ProgressStep
    {
        private List<ProgressStep> _childs;
        private int _currChild;


        public ProgressStep()
        { }

        public ProgressStep(IProgress<double> progress)
            : this(progress, 0, 1)
        { }

        public ProgressStep(IProgress<double> progress, double startProgress, double endProgress)
        {
            Progress = progress;
            StartProgress = startProgress;
            EndProgress = endProgress;
        }

        public ProgressStep Parent { get; private set; }
        public string Name { get; set; }

        private IProgress<double> Progress { get; }

        private double StartProgress { get; }
        private double EndProgress { get; }
        private double DurationProgress => EndProgress - StartProgress;

        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        private TimeSpan DurationTime => EndTime - StartTime;

        private DateTime LastReport { get; set; }
        private TimeSpan DurationNoReport { get; set; } = TimeSpan.Zero;


        public static ProgressStep CreateAndStart(IProgress<double> progress)
        {
            var p = new ProgressStep(progress);
            p.StartProcess();
            return p;
        }


        public void SplitToUniformSteps(int count)
        {
            _currChild = -1;
            _childs = new List<ProgressStep>(count);

            for (var i = 0; i < count; i++)
            {
                _childs.Add(new ProgressStep(
                    Progress,
                    StartProgress + (EndProgress - StartProgress) * i / count,
                    StartProgress + (EndProgress - StartProgress) * (i + 1) / count)
                {
                    Parent = this
                });
            }
        }

        public void SplitToDistributionSteps(params double[] percents)
        {
            var total = percents.Sum();
            var count = percents.Length;

            _currChild = -1;
            _childs = new List<ProgressStep>(count);

            for (var i = 0; i < count; i++)
            {
                _childs.Add(new ProgressStep(
                    Progress,
                    StartProgress + (EndProgress - StartProgress) * percents.Take(i).Sum() / total,
                    StartProgress + (EndProgress - StartProgress) * percents.Take(i + 1).Sum() / total)
                {
                    Parent = this
                });
            }
        }


        public ProgressStep StartNextStep(string name = null)
        {
            if (0 <= _currChild && _currChild < _childs.Count)
                _childs[_currChild].EndProcess(false);

            _currChild++;

            while (_childs.Count <= _currChild)
                _childs.Add(new ProgressStep(Progress, EndProgress, EndProgress) { Parent = this });

            var p = _childs[_currChild];
            p.Name = name;
            p.StartProcess();
            return p;
        }


        public void StartProcess()
        {
            if (StartTime == default)
                StartTime = DateTime.UtcNow;

            Report(StartProgress);
        }

        public void ReportProcess(int index, int count)
        {
            if (StartTime == default)
                StartTime = DateTime.UtcNow;

            Report(StartProgress + (EndProgress - StartProgress) * index / count);
        }

        public void EndProcess(bool force = true)
        {
            if (!force && (EndTime != default || StartTime == default))
                return;

            _childs?.LastOrDefault(x => x.StartTime != default)?.EndProcess(false);

            EndTime = DateTime.UtcNow;
            Report(EndProgress);
        }


        public string BuildStatistics() => string.Join(Environment.NewLine, BuildStatisticsInternal());


        private void Report(double v)
        {
            var now = DateTime.UtcNow;
            if (LastReport != default && DurationNoReport < now - LastReport)
                DurationNoReport = now - LastReport;

            LastReport = now;

            Progress?.Report(v);
        }

        private List<string> BuildStatisticsInternal()
        {
            var currentPercent = Math.Abs(DurationProgress / Parent?.DurationProgress ?? 1);
            var recommendPercent = Math.Abs(DurationTime.TotalSeconds / Parent?.DurationTime.TotalSeconds ?? 1);

            var ok = 0.9 < currentPercent / recommendPercent && currentPercent / recommendPercent < 1.1
                || Math.Abs(currentPercent - recommendPercent) < 0.015;

            var flags = new List<string>();
            if (StartTime == default)
                flags.Add("NotStarted");
            if (EndTime == default)
                flags.Add("NotEnded");
            if (1 < DurationNoReport.TotalSeconds && (_childs == null || _childs.Count == 0))
                flags.Add("LongNoReport");
            var flagsStr = string.Join(", ", flags);

            var res = new List<string>();
            var str = $"({Name ?? "null"})  " +
                $"{(0 < flagsStr.Length ? $"({flagsStr})  " : string.Empty)}" +
                $"({(ok ? "ok" : "imbalance")} {currentPercent:P0} -> {recommendPercent:P0})";

            if (_childs == null || _childs.Count == 0)
            {
                res.Add(str);
            }
            else
            {
                var delayBeforePercent = Math.Abs((_childs[0].StartTime - StartTime).TotalSeconds) /
                    DurationTime.TotalSeconds;
                var delayAfterPernent =
                    Math.Abs((EndTime - _childs.Last(x => x.StartTime != default).EndTime).TotalSeconds) /
                    DurationTime.TotalSeconds;

                var add = string.Empty;
                if (0.05 < delayBeforePercent)
                    add += $", before {delayBeforePercent:P0}";

                if (0.05 < delayAfterPernent)
                    add += $", after {delayAfterPernent:P0}";

                if (!string.IsNullOrEmpty(add))
                    str += $"  (childs: {add.TrimStart(',', ' ')})";

                res.Add(str);
                res.AddRange(_childs.SelectMany(x => x.BuildStatisticsInternal()).Select(x => " " + x));
            }

            return res;
        }
    }
}