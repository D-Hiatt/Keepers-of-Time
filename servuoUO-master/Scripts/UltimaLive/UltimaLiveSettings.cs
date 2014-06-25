/* Copyright (C) 2013 Ian Karlinsey
 * 
 * UltimeLive is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * UltimaLive is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with UltimaLive.  If not, see <http://www.gnu.org/licenses/>. 
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Server;
using Server.Network;
using Server.Targeting;
using Server.Gumps;
using Server.Commands;
using Server.Commands.Generic;
using Server.Mobiles;
using Server.Items;

namespace UltimaLive
{
  public class UltimaLiveSettings
  {
    public const string UNIQUE_SHARD_IDENTIFIER = "Test1"; //Must be 28 characters or less

    public const string ULTIMA_LIVE_ROOT_FOLDER_NAME = "UltimaLive";
    public const string ULTIMA_LIVE_MAP_CHANGES_FOLDER_NAME = "ClientFiles";
    public const string ULTIMA_LIVE_LUMBER_HARVEST_FOLDER_NAME = "LumberHarvest";

    public static string UltimaLiveMapChangesSavePath
    {
      get
      {
        return Path.Combine(UltimaLiveRootPath, ULTIMA_LIVE_MAP_CHANGES_FOLDER_NAME);
      }
    }

    public static string UltimaLiveRootPath
    {
      get
      {
        return Path.Combine(Core.BaseDirectory, ULTIMA_LIVE_ROOT_FOLDER_NAME);
      }
    }

    public static string LumberHarvestFallenTreeSaveLocation
    {
      get
      {
        return Path.Combine(UltimaLiveRootPath, ULTIMA_LIVE_LUMBER_HARVEST_FOLDER_NAME);
      }
    }

  }
}