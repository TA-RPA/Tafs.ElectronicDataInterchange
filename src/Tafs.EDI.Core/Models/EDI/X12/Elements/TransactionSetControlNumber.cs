//
//  TransactionSetControlNumber.cs
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
using System.Diagnostics;
using JetBrains.Annotations;

namespace Tafs.EDI.Core.Models.EDI.X12.Elements
{
    /// <summary>
    /// Defines an EDI X12 Transaction Set Control Number.
    /// </summary>
    /// <remarks>
    /// Identifying control number that must be unique within the transaction
    /// set functional group assigned by the originator for a transaction set.
    /// </remarks>
    [PublicAPI]
    [DebuggerDisplay($"{{{nameof(ToString)}(),nq}}")]
    public readonly struct TransactionSetControlNumber
    {
        private readonly string _value;

        /// <summary>
        /// Gets the length of the control number.
        /// </summary>
        public readonly int Length => _value.Length;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSetControlNumber"/> struct.
        /// </summary>
        /// <param name="value">The underlying value of this <see cref="TransactionSetControlNumber"/>.</param>
        public TransactionSetControlNumber(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (value.Length is < 4 or > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Length must be between 4 and 9 (inclusive)");
            }

            _value = value;
        }

        /// <inheritdoc/>
        public override readonly string ToString() => _value.ToString();
    }
}
