//
//  C3.cs
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

using Remora.Rest.Core;
using Tafs.EDI.Core.Annotations;
using Tafs.EDI.Core.Models.EDI.X12.Elements;

namespace Tafs.EDI.Core.Models.EDI.X12.Segments
{
    /// <summary>
    /// Defines a Currency Identifier.
    /// </summary>
    /// <param name="BillingCurrency">The billing currency.</param>
    /// <param name="ExchangeRate">A value to be used as a multiplier to convert from <see cref="BillingCurrency"/> to <paramref name="PaymentCurrency"/>.</param>
    /// <param name="PaymentCurrency">The payment currency.</param>
    /// <param name="RatedCurrency">The rated currency.</param>
    public sealed record class C3
    (
        [property: Position(1)] CurrencyCode BillingCurrency,
        [property: Position(2)] Optional<decimal> ExchangeRate,
        [property: Position(3)] Optional<CurrencyCode> PaymentCurrency,
        [property: Position(4)] Optional<CurrencyCode> RatedCurrency
    );
}
