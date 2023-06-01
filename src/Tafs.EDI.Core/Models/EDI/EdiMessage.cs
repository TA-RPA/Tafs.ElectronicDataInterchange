//
//  EdiMessage.cs
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

namespace Tafs.EDI.Core.Models.EDI
{
    /// <summary>
    /// A base class for an EDI Message.
    /// </summary>
    /// <param name="Name">The message id.</param>
    /// <param name="Version">The version the message is designed for.</param>
    /// <param name="Format">The message format, such as X12 or EDIFACT.</param>
    /// <param name="MessagePart">The Message Mart Index.</param>
    public abstract record class EdiMessage
    (
        string Name,
        int Version,
        EdiFormat Format,
        int MessagePart
    );
}
