﻿/*
    Copyright (C) 2011-2015 de4dot@gmail.com

    This file is part of de4dot.

    de4dot is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    de4dot is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with de4dot.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Reflection;
using dnlib.DotNet;

namespace AssemblyData.methodsrewriter {
	class MMethod {
		public MethodBase methodBase;
		public MethodDef methodDef;
		public MMethod(MethodBase methodBase, MethodDef methodDef) {
			this.methodBase = methodBase;
			this.methodDef = methodDef;
		}

		public bool HasInstructions() {
			return methodDef.Body != null && methodDef.Body.Instructions.Count != 0;
		}

		public override string ToString() {
			return methodDef.ToString();
		}
	}
}
