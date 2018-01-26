﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MineCase.Mod.common
{
    public class ModMetadata
    {
        public string modId;
        public string name;
        public string description = "";

        public string url = "";

        //Never really used for anything and format is undefined. See updateJSON for replacement.
        public string updateUrl = "";
        /**
         * URL to update json file. Format is defined here: https://gist.github.com/LexManos/7aacb9aa991330523884
         */
        public string updateJSON = "";

        public string logoFile = "";
        public string version = "";
        public List<string> authorList = new List<string>();
        public string credits = "";
        public string parent = "";
        public string[] screenshots;

        // this field is not for use in the json (不参与序列化)
        public ModContainer parentMod;
        // this field is not for use in the json (不参与序列化)
        public List<ModContainer> childMods = new List<ModContainer>();

        public bool useDependencyInformation;
        public HashSet<ArtifactVersion> requiredMods = new HashSet<ArtifactVersion>();
        public List<ArtifactVersion> dependencies = new List<ArtifactVersion>();
        public List<ArtifactVersion> dependants = new List<ArtifactVersion>();
        // this field is not for use in the json (不参与序列化)
        public bool autogenerated;

        public ModMetadata()
        {
        }

        public string GetChildModCountString()
        {
            return string.Format("%d child mod%s", childMods.Count, childMods.Count != 1 ? "s" : "");
        }

        public string GetAuthorList()
        {
            return Joiner.on(", ").join(authorList);
        }

        public string GetChildModList()
        {
            return Joiner.on(", ").join(childMods.stream().map(ModContainer::getName).iterator());
        }

        public string PrintableSortingRules()
        {
            return "";
        }
    }
}
