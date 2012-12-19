﻿using System;

using BetterCms.Module.MediaManager.Models;
using BetterCms.Module.Root.Mvc.Grids.GridOptions;

namespace BetterCms.Module.MediaManager.ViewModels.MediaManager
{
    public class MediaManagerViewModel : SearchableGridOptions
    {
        public Guid CurrentFolderId { get; set; }
        
        public MediaType? FolderType { get; set; }
    }
}