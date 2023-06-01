//
//  PositionAttribute.cs
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

namespace Tafs.EDI.Core.Annotations
{
    /// <summary>
    /// Identifies the position of the property within the message.
    /// </summary>
    /// <remarks>
    /// The first position should be 1, not 0.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class PositionAttribute : Attribute
    {
        /// <summary>
        /// Gets the position of the property in the message.
        /// </summary>
        public int Position { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionAttribute"/> class.
        /// </summary>
        /// <param name="position">The position.</param>
        public PositionAttribute(int position)
        {
            Position = position;
        }
    }
}
