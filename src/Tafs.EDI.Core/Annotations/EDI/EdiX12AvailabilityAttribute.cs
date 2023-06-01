//
//  EdiX12AvailabilityAttribute.cs
//
//  Author:
//       Devin Duanne <dduanne@tafs.com>
//
//  Copyright (c) Tafs, LLC.
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;

namespace Tafs.EDI.Core.Annotations.EDI
{
    /// <summary>
    /// Annotates a member of an EDI element or segment to describe when the element was available.
    /// </summary>
    /// <remarks>
    /// If not specified, version 3010 is assumed for <see cref="Since"/> and the current latest version is assumed for <see cref="Until"/>.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]
    public sealed class EdiX12AvailabilityAttribute : Attribute
    {
        /// <summary>
        /// Gets a value indicating the first time this element became available.
        /// </summary>
        public int Since { get; }

        /// <summary>
        /// Gets a value indicating the last version this element became available.
        /// </summary>
        /// <remarks>If this field is defined, <see cref="ObsoleteAttribute"/> should also be present.</remarks>
        public int? Until { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiX12AvailabilityAttribute"/> class.
        /// </summary>
        /// <param name="since">The EDI version when this element became available.</param>
        public EdiX12AvailabilityAttribute(int since)
        {
            Since = since;
            Until = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiX12AvailabilityAttribute"/> class.
        /// </summary>
        /// <param name="since">The EDI version when this element became available.</param>
        /// <param name="until">The last EDI version this element was available.</param>
        public EdiX12AvailabilityAttribute(int since, int until)
        {
            Since = since;
            Until = until;
        }
    }
}
