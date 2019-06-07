﻿using ApprovalTests.Reporters.Linux;
using ApprovalTests.Reporters.Mac;

namespace ApprovalTests.Reporters
{
    public class DiffReporter : FirstWorkingReporter
    {
        public static readonly DiffReporter INSTANCE = new DiffReporter();

        public DiffReporter()
            : base(
                WindowsDiffReporter.INSTANCE, LinuxDiffReporter.INSTANCE, MacDiffReporter.INSTANCE)
        {
        }
    }
}