// This file is part of CycloneDX CLI Tool
//
// Licensed under the Apache License, Version 2.0 (the “License”);
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an “AS IS” BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// SPDX-License-Identifier: Apache-2.0
// Copyright (c) OWASP Foundation. All Rights Reserved.
using System.Collections.Generic;

namespace CycloneDX.Cli.Commands
{
    public class MergeCommandOptions
    {
        public IList<string> InputFiles { get; set; }
        public string OutputFile { get; set; }
        public BomFormat InputFormat { get; set; }
        public BomFormat OutputFormat { get; set; }
        public bool Hierarchical { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
    }
}