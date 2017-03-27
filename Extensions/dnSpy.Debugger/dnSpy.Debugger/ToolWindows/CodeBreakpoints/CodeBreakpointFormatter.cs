﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.ComponentModel.Composition;
using dnSpy.Contracts.Debugger.Breakpoints.Code;
using dnSpy.Contracts.Debugger.Text;
using dnSpy.Contracts.Text;

namespace dnSpy.Debugger.ToolWindows.CodeBreakpoints {
	[Export(typeof(CodeBreakpointFormatterProvider))]
	sealed class CodeBreakpointFormatterProvider {
		public CodeBreakpointFormatter Create() =>
			CodeBreakpointFormatter.Create_DONT_USE();
	}

	sealed class CodeBreakpointFormatter {
		CodeBreakpointFormatter() { }

		internal static CodeBreakpointFormatter Create_DONT_USE() => new CodeBreakpointFormatter();

		internal void WriteName(IDebugOutputWriter output, CodeBreakpointVM vm) => vm.EngineBreakpointFormatter.WriteName(output);
		internal void WriteCondition(ITextColorWriter output, DbgCodeBreakpoint bp) { }//TODO:
		internal void WriteHitCount(ITextColorWriter output, DbgCodeBreakpoint bp) { }//TODO:
		internal void WriteFilter(ITextColorWriter output, DbgCodeBreakpoint bp) { }//TODO:
		internal void WriteWhenHit(ITextColorWriter output, DbgCodeBreakpoint bp) { }//TODO:
		internal void WriteModule(IDebugOutputWriter output, CodeBreakpointVM vm) => vm.EngineBreakpointFormatter.WriteModule(output);
	}
}