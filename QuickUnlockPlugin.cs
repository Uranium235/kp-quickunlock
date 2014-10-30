/**
 * Quick Unlock Plugin for KeePass Password Safe
 * Copyright (C) 2014  Paul Voegler
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
**/

using System;
using KeePass.Plugins;


namespace QuickUnlockPlugin
{
	public static class Defs
	{
		public const string ProductName = @"Quick Unlock Plugin";
		public const string CopyRight = @"© 2014 Paul Voegler";
		public const string VersionString = @"0.1";
	}

	public sealed class QuickUnlockPlugin : Plugin
	{
		private IPluginHost m_host = null;

		public override bool Initialize(IPluginHost host)
		{
			if (host == null)
				return false;

			m_host = host;

			return true;
		}

		public override void Terminate()
		{
		}
	}
}
