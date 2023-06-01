//
//  EdiElementAttribute.cs
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
    /// Identifies an EDI Element.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum)]
    internal class EdiElementAttribute : Attribute, IEdiAttribute
    {
        /// <inheritdoc />
        public EdiFormat Format { get; }

        /// <inheritdoc />
        public int Version { get; }

        /// <inheritdoc />
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiElementAttribute"/> class.
        /// </summary>
        /// <param name="format">The EDI Format (like X12 or EDIFACT).</param>
        /// <param name="version">The EDI Version.</param>
        /// <param name="id">The EDI Identifier.</param>
        public EdiElementAttribute(EdiFormat format, int version, int id)
        {
            Format = format;
            Version = version;
            Id = id;
        }
    }
}
