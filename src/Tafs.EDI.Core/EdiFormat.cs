//
//  ElectronicDataInterchangeFormat.cs
//
//  Author:
//       Devin Duanne <https://github.com/Silvenga/EdiWeave/>
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

namespace Tafs.EDI.Core
{
    /// <summary>
    /// Identifies the type of EDI Message.
    /// </summary>
    public enum EdiFormat
    {
        /// <summary>
        /// Used to share business documents in a standard format.
        /// </summary>
        X12,

        /// <summary>
        /// EDI X12 formats used for transmitting HIPAA data.
        /// </summary>
        X12HIPAA,

        /// <summary>
        /// United Nations rules for Electronic Data Interchange for Administration, Commerc, and Transport.
        /// </summary>
        EDIFACT
    }
}
