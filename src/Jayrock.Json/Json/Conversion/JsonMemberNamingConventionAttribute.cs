#region License, Terms and Conditions
//
// Jayrock - JSON and JSON-RPC for Microsoft .NET Framework and Mono
// Written by Atif Aziz (www.raboof.com)
// Copyright (c) 2005 Atif Aziz. All rights reserved.
//
// This library is free software; you can redistribute it and/or modify it under
// the terms of the GNU Lesser General Public License as published by the Free
// Software Foundation; either version 3 of the License, or (at your option)
// any later version.
//
// This library is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
// FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
// details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this library; if not, write to the Free Software Foundation, Inc.,
// 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA 
//
#endregion

namespace Jayrock.Json.Conversion
{
    #region Imports

    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;

    #endregion

    [ Serializable ]
    public enum NamingConvention
    {
        None,
        Camel,      // worldWideWeb
        Pascal,     // WorldWideWeb
        Upper,      // WORLDWIDEWEB
        Lower       // worldwideweb
    }
    [ Serializable ]
    public enum UnderscoreConvention
    {
        None,
        Prefix,     // _WorldWideWeb   (if Pascal)
        Separate    // World_Wide_Web  (if Pascal)
    }

    [ Serializable ]
    [ AttributeUsage(AttributeTargets.Property | AttributeTargets.Field) ]
    public sealed class JsonMemberNamingConventionAttribute : Attribute, IPropertyDescriptorCustomization
    {
        private NamingConvention _convention;
        private UnderscoreConvention _underscores;

        public JsonMemberNamingConventionAttribute() :
            this(NamingConvention.None) {}

        public JsonMemberNamingConventionAttribute(NamingConvention convention) :
            this(convention, UnderscoreConvention.None) {}

        public JsonMemberNamingConventionAttribute(NamingConvention naming, UnderscoreConvention underscores)
        {
            _convention = naming;
            _underscores = underscores;
        }

        public NamingConvention Convention
        {
            get { return _convention; }
            set { _convention = value; }
        }

        public UnderscoreConvention Underscores 
        {
            get { return _underscores; }
            set { _underscores = value; }
        }

        void IPropertyDescriptorCustomization.Apply(PropertyDescriptor property)
        {
            if (property == null) 
                throw new ArgumentNullException("property");

            if (Convention == NamingConvention.None && Underscores == UnderscoreConvention.None)
                return;

            string name = property.Name;

            switch (Underscores)
            {
                case UnderscoreConvention.Prefix:
                    if (name.Length > 0 && name[0] != '_')
                        name = '_' + name;
                    break;
                case UnderscoreConvention.Separate:
                    for (int i = 1; i < name.Length; ++i)
                    {
                        if (char.IsUpper(name[i])) {
                            name = name.Substring(0, i) + '_' + name.Substring(i);
                            ++i;
                        }
                    }
                    break;
            }

            switch (Convention)
            {
                case NamingConvention.Pascal:
                    name = char.ToUpper(name[0], CultureInfo.InvariantCulture) + name.Substring(1); break;
                case NamingConvention.Camel:
                    name = char.ToLower(name[0], CultureInfo.InvariantCulture) + name.Substring(1); break;
                case NamingConvention.Upper:
                    name = name.ToUpper(CultureInfo.InvariantCulture); break;
                case NamingConvention.Lower:
                    name = name.ToLower(CultureInfo.InvariantCulture); break;
            }

            SetName(property, name);
        }

        private static void SetName(PropertyDescriptor property, string name)
        {
            Debug.Assert(property != null);
            Debug.Assert(name != null);
            Debug.Assert(name.Length > 0);

            IPropertyCustomization customization = (IPropertyCustomization) property;
            customization.SetName(name);
        }
    }
}