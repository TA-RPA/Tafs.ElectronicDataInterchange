//
//  TS204.cs
//
//  Author:
//       Devin Duanne <https://github.com/Foxtrek64/Tafs.ElectronicDataInterchange.git>
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

using Remora.Rest.Core;
using Tafs.EDI.Core.Annotations;
using Tafs.EDI.Core.Annotations.EDI;
using Tafs.EDI.Core.Models.EDI.X12.Segments;

namespace Tafs.EDI.TransactionSets.Transportation
{
    [TransactionSet(Core.EdiFormat.X12, 8010, 204)]
    public sealed record class TS204
    (
        [property: Position(0100)] ST TransactionSetHeader,
        [property: Position(0200)] B2 BeginningShipmentInformationTransaction,
        [property: Position(0300)] B2A SetPurpose,
        [property: Position(0400)] Optional<C3> CurrencyIdentifier,
        [property: Position(0800)] Optional<L11> BusinessInstructionsAndReferenceNumber,
        [property: Position(0900)] Optional<G62> MustRespondByDate,
        [property: Position(1000)] Optional<MS3> InterlineInformation
        [property: Position(1050)] Optional<Loop<>>
    );
}
