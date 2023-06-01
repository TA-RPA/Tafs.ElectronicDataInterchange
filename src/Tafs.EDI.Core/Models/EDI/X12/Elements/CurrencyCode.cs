//
//  CurrencyCode.cs
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
using System.Globalization;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using Tafs.EDI.Core.Annotations.EDI;

namespace Tafs.EDI.Core.Models.EDI.X12.Elements
{
    /// <summary>
    /// Defines a three-letter identifier for a currency code.
    /// </summary>
    [PublicAPI]
    [EdiElement(EdiFormat.X12, 8030, 100)]
    public readonly struct CurrencyCode
    {
        /// <summary>
        /// Gets the three-letter identifier code for this <see cref="CurrencyCode"/>.
        /// </summary>
        /// <seealso href="https://www.stedi.com/edi/x12/element/100"/>
        public readonly string Identifier { get; }

        private static readonly Regex OnlyLetters = new(@"^[a-zA-Z]+$", RegexOptions.Compiled);

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyCode"/> struct.
        /// </summary>
        /// <param name="identifier">A three-letter ISO 4217 currency symbol.</param>
        public CurrencyCode(string identifier)
            : this(identifier, true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyCode"/> struct.
        /// </summary>
        /// <param name="regionInfo">A <see cref="RegionInfo"/> from which to derive the <see cref="RegionInfo.ISOCurrencySymbol"/>.</param>
        public CurrencyCode(RegionInfo regionInfo)
            : this(regionInfo.ISOCurrencySymbol, false)
        {
        }

        private CurrencyCode(string identifier, bool check)
        {
            if (check)
            {
                if (string.IsNullOrWhiteSpace(identifier))
                {
                    throw new ArgumentNullException(nameof(identifier));
                }

                if (identifier.Length != 3)
                {
                    throw new ArgumentException("Length must be exactly three.", nameof(identifier));
                }

                if (!OnlyLetters.IsMatch(identifier))
                {
                    throw new ArgumentException("Only letters A-Z are allowed.");
                }
            }

            Identifier = identifier.ToUpperInvariant();
        }

        /// <inheritdoc />
        public override readonly string ToString()
        {
            return Identifier;
        }

        /// <inheritdoc />
        public override readonly int GetHashCode()
        {
            return Identifier.GetHashCode();
        }

        // Special use

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> indicating that no currency is inolved.
        /// </summary>
        public static readonly CurrencyCode None = new("XXX", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> reserved for testing purposes.
        /// </summary>
        public static readonly CurrencyCode Testing = new("XTS", false);

        // Codes, alphabetized by ISO 4217 currency symbol.

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the UAE Dirham.
        /// </summary>
        public static readonly CurrencyCode UAEDirham = new("AED", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Afghani.
        /// </summary>
        public static readonly CurrencyCode Afghani = new("AFN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Lek.
        /// </summary>
        public static readonly CurrencyCode Lek = new("ALL", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Armendian Dram.
        /// </summary>
        public static readonly CurrencyCode ArmenianDram = new("AMD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Netherlands Antillean Guilder.
        /// </summary>
        public static readonly CurrencyCode NetherlandsAntilleanGuilder = new("ANG", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Kwanza.
        /// </summary>
        public static readonly CurrencyCode Kwanza = new("AOA", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Argentine Peso.
        /// </summary>
        public static readonly CurrencyCode ArgentinePeso = new("ARS", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Australian Dollar.
        /// </summary>
        public static readonly CurrencyCode AustralianDollar = new("AUD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Aruban Florin.
        /// </summary>
        public static readonly CurrencyCode ArubanFlorin = new("AWG", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Azerbaijan Manat.
        /// </summary>
        public static readonly CurrencyCode AzerbaijanManat = new("AZN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Convertible Mark.
        /// </summary>
        public static readonly CurrencyCode ConvertibleMark = new("BAM", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Barbados Dollar.
        /// </summary>
        public static readonly CurrencyCode BarbadosDollar = new("BBD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Taka.
        /// </summary>
        public static readonly CurrencyCode Taka = new("BDT", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Bulgarian Lev.
        /// </summary>
        public static readonly CurrencyCode BulgarianLev = new("BGN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Bahraini Dinar.
        /// </summary>
        public static readonly CurrencyCode BahrainiDinar = new("BHD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Burundi Franc.
        /// </summary>
        public static readonly CurrencyCode BurundiFranc = new("BIF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Bermudian Dollar.
        /// </summary>
        public static readonly CurrencyCode BermudianDollar = new("BMD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Brunei Dollar.
        /// </summary>
        public static readonly CurrencyCode BruneiDollar = new("BND", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Boliviano.
        /// </summary>
        public static readonly CurrencyCode Boliviano = new("BOB", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Mvdol.
        /// </summary>
        public static readonly CurrencyCode Mvdol = new("BOV", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Brazilian Real.
        /// </summary>
        public static readonly CurrencyCode BrazilianReal = new("BRL", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Bahamian Dollar.
        /// </summary>
        public static readonly CurrencyCode BahamianDollar = new("BSD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Ngultrum.
        /// </summary>
        public static readonly CurrencyCode Ngultrum = new("BTN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Pula.
        /// </summary>
        public static readonly CurrencyCode Pula = new("BWP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Belarusian Ruble.
        /// </summary>
        public static readonly CurrencyCode BelarusianRuble = new("BYN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Belize Dollar.
        /// </summary>
        public static readonly CurrencyCode BelizeDollar = new("BZD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Canadian Dollar.
        /// </summary>
        public static readonly CurrencyCode CanadianDollar = new("CAD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Congolese Franc.
        /// </summary>
        public static readonly CurrencyCode CongoleseFranc = new("CDF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the WIR Euro.
        /// </summary>
        public static readonly CurrencyCode WIREuro = new("CHE", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Swiss Franc.
        /// </summary>
        public static readonly CurrencyCode SwissFranc = new("CHF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the WIR Franc.
        /// </summary>
        public static readonly CurrencyCode WIRFranc = new("CHW", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Unidad de Fomento.
        /// </summary>
        public static readonly CurrencyCode UnidadDeFomento = new("CLF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Chilean Peso.
        /// </summary>
        public static readonly CurrencyCode ChileanPeso = new("CLP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Yuan Renminbi.
        /// </summary>
        public static readonly CurrencyCode YuanRenminbi = new("CNY", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Colombian Peso.
        /// </summary>
        public static readonly CurrencyCode ColombianPeso = new("COP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Unidad de Valor Real.
        /// </summary>
        public static readonly CurrencyCode UnidadDeValorReal = new("COU", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Costa Rican Colon.
        /// </summary>
        public static readonly CurrencyCode CostaRicanColon = new("CRC", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Peso Convertible.
        /// </summary>
        public static readonly CurrencyCode PesoConvertible = new("CUC", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Cuban Peso.
        /// </summary>
        public static readonly CurrencyCode CubanPeso = new("CUP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Cabo Verde Escudo.
        /// </summary>
        public static readonly CurrencyCode CaboVerdeEscudo = new("CVE", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Czech Koruna.
        /// </summary>
        public static readonly CurrencyCode CzechKoruna = new("CZK", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Djibouti Franc.
        /// </summary>
        public static readonly CurrencyCode DjiboutiFranc = new("DJF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Danish Krone.
        /// </summary>
        public static readonly CurrencyCode DanishKrone = new("DKK", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Dominican Peso.
        /// </summary>
        public static readonly CurrencyCode DominicanPeso = new("DOP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Algerian Dinar.
        /// </summary>
        public static readonly CurrencyCode AlgerianDinar = new("DZD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Egyptian Pound.
        /// </summary>
        public static readonly CurrencyCode EgyptianPound = new("EGP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Nakfa.
        /// </summary>
        public static readonly CurrencyCode Nakfa = new("ERN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Ethiopian Birr.
        /// </summary>
        public static readonly CurrencyCode EthiopianBirr = new("ETB", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Euro.
        /// </summary>
        public static readonly CurrencyCode Euro = new("EUR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Fiji Dollar.
        /// </summary>
        public static readonly CurrencyCode FijiDollar = new("FJD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Falkland Islands Pound.
        /// </summary>
        public static readonly CurrencyCode FalklandIslandsPound = new("FKP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Pound Sterling.
        /// </summary>
        public static readonly CurrencyCode PoundSterling = new("GBP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Lari.
        /// </summary>
        public static readonly CurrencyCode Lari = new("GEL", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Ghana Cedi.
        /// </summary>
        public static readonly CurrencyCode GhanaCedi = new("GHS", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Gibraltar Pound.
        /// </summary>
        public static readonly CurrencyCode GibraltarPound = new("GIP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Dalasi.
        /// </summary>
        public static readonly CurrencyCode Dalasi = new("GMD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Guinean Franc.
        /// </summary>
        public static readonly CurrencyCode GuineanFranc = new("GNF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Quetzal.
        /// </summary>
        public static readonly CurrencyCode Quetzal = new("GTQ", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Guyana Dollar.
        /// </summary>
        public static readonly CurrencyCode GuyanaDollar = new("GYD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Hong Kong Dollar.
        /// </summary>
        public static readonly CurrencyCode HongKongDollar = new("HKD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Lempira.
        /// </summary>
        public static readonly CurrencyCode Lempira = new("HNL", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Kuna.
        /// </summary>
        public static readonly CurrencyCode Kuna = new("HRK", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Gourde.
        /// </summary>
        public static readonly CurrencyCode Gourde = new("HTG", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Forint.
        /// </summary>
        public static readonly CurrencyCode Forint = new("HUF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Rupiah.
        /// </summary>
        public static readonly CurrencyCode Rupiah = new("IDR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the New Israeli Sheqel.
        /// </summary>
        public static readonly CurrencyCode NewIsraeliSheqel = new("ILS", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Indian Rupee.
        /// </summary>
        public static readonly CurrencyCode IndianRupee = new("INR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Iraqi Dinar.
        /// </summary>
        public static readonly CurrencyCode IraqiDinar = new("IQD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Iranian Rial.
        /// </summary>
        public static readonly CurrencyCode IranianRial = new("IRR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Iceland Krona.
        /// </summary>
        public static readonly CurrencyCode IcelandKrona = new("ISK", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Jamaican Dollar.
        /// </summary>
        public static readonly CurrencyCode JamaicanDollar = new("JMD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Jordanian Dinar.
        /// </summary>
        public static readonly CurrencyCode JordanianDinar = new("JOD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Yen.
        /// </summary>
        public static readonly CurrencyCode Yen = new("JPY", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Kenyan Shilling.
        /// </summary>
        public static readonly CurrencyCode KenyanShilling = new("KES", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Som.
        /// </summary>
        public static readonly CurrencyCode Som = new("KGS", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Riel.
        /// </summary>
        public static readonly CurrencyCode Riel = new("KHR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Comorian Franc.
        /// </summary>
        public static readonly CurrencyCode ComorianFranc = new("KMF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the North Korean Won.
        /// </summary>
        public static readonly CurrencyCode NorthKoreanWon = new("KPW", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Won.
        /// </summary>
        public static readonly CurrencyCode Won = new("KRW", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Kuwaiti Dinar.
        /// </summary>
        public static readonly CurrencyCode KuwaitiDinar = new("KWD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Cayman Islands Dollar.
        /// </summary>
        public static readonly CurrencyCode CaymanIslandsDollar = new("KYD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Tenge.
        /// </summary>
        public static readonly CurrencyCode Tenge = new("KZT", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Lao Kip.
        /// </summary>
        public static readonly CurrencyCode LaoKip = new("LAK", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Lebanese Pound.
        /// </summary>
        public static readonly CurrencyCode LebanesePound = new("LBP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Sri Lanka Rupee.
        /// </summary>
        public static readonly CurrencyCode SriLankaRupee = new("LKR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Liberian Dollar.
        /// </summary>
        public static readonly CurrencyCode LiberianDollar = new("LRD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Loti.
        /// </summary>
        public static readonly CurrencyCode Loti = new("LSL", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Libyan Dinar.
        /// </summary>
        public static readonly CurrencyCode LibyanDinar = new("LYD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Moroccan Dirham.
        /// </summary>
        public static readonly CurrencyCode MoroccanDirham = new("MAD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Moldovan Leu.
        /// </summary>
        public static readonly CurrencyCode MoldovanLeu = new("MDL", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Malagasy Ariary.
        /// </summary>
        public static readonly CurrencyCode MalagasyAriary = new("MGA", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Denar.
        /// </summary>
        public static readonly CurrencyCode Denar = new("MKD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Kyat.
        /// </summary>
        public static readonly CurrencyCode Kyat = new("MMK", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Tugrik.
        /// </summary>
        public static readonly CurrencyCode Tugrik = new("MNT", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Pataca.
        /// </summary>
        public static readonly CurrencyCode Pataca = new("MOP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Ouguiya.
        /// </summary>
        public static readonly CurrencyCode Ouguiya = new("MRU", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Mauritius Rupee.
        /// </summary>
        public static readonly CurrencyCode MauritiusRupee = new("MUR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Rufiyaa.
        /// </summary>
        public static readonly CurrencyCode Rufiyaa = new("MVR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Malawi Kwacha.
        /// </summary>
        public static readonly CurrencyCode MalawiKwacha = new("MWK", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Mexican Peso.
        /// </summary>
        public static readonly CurrencyCode MexicanPeso = new("MXN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Mexican Unidad de Inversion (UDI).
        /// </summary>
        public static readonly CurrencyCode MexicanUnidadDeInversion = new("MXV", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Malaysian Ringgit.
        /// </summary>
        public static readonly CurrencyCode MalaysianRinggit = new("MYR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Mozambique Metical.
        /// </summary>
        public static readonly CurrencyCode MozambiqueMetical = new("MZN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Namibia Dollar.
        /// </summary>
        public static readonly CurrencyCode NamibiaDollar = new("NAD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Naira.
        /// </summary>
        public static readonly CurrencyCode Naira = new("NGN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Cordoba Oro.
        /// </summary>
        public static readonly CurrencyCode CordobaOro = new("NIO", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Norwegian Krone.
        /// </summary>
        public static readonly CurrencyCode NorwegianKrone = new("NOK", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Nepalese Rupee.
        /// </summary>
        public static readonly CurrencyCode NepaleseRupee = new("NPR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the New Zealand Dollar.
        /// </summary>
        public static readonly CurrencyCode NewZealandDollar = new("NZD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Rial Omani.
        /// </summary>
        public static readonly CurrencyCode RialOmani = new("OMR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Balboa.
        /// </summary>
        public static readonly CurrencyCode Balboa = new("PAB", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Sol.
        /// </summary>
        public static readonly CurrencyCode Sol = new("PEN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Kina.
        /// </summary>
        public static readonly CurrencyCode Kina = new("PGK", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Philippine Peso.
        /// </summary>
        public static readonly CurrencyCode PhilippinePeso = new("PHP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Pakistan Rupee.
        /// </summary>
        public static readonly CurrencyCode PakistanRupee = new("PKR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Zloty.
        /// </summary>
        public static readonly CurrencyCode Zloty = new("PLN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Guarani.
        /// </summary>
        public static readonly CurrencyCode Guarani = new("PYG", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Qatari Rial.
        /// </summary>
        public static readonly CurrencyCode QatariRial = new("QAR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Romanian Leu.
        /// </summary>
        public static readonly CurrencyCode RomanianLeu = new("RON", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Serbian Dinar.
        /// </summary>
        public static readonly CurrencyCode SerbianDinar = new("RSD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Russian Ruble.
        /// </summary>
        public static readonly CurrencyCode RussianRuble = new("RUB", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Rwanda Franc.
        /// </summary>
        public static readonly CurrencyCode RwandaFranc = new("RWF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Saudi Riyal.
        /// </summary>
        public static readonly CurrencyCode SaudiRiyal = new("SAR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Solomon Islands Dollar.
        /// </summary>
        public static readonly CurrencyCode SolomonIslandsDollar = new("SBD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Seychelles Rupee.
        /// </summary>
        public static readonly CurrencyCode SeychellesRupee = new("SCR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Sudanese Pound.
        /// </summary>
        public static readonly CurrencyCode SudanesePound = new("SDG", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Swedish Krona.
        /// </summary>
        public static readonly CurrencyCode SwedishKrona = new("SEK", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Singapore Dollar.
        /// </summary>
        public static readonly CurrencyCode SingaporeDollar = new("SGD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Saint Helena Pound.
        /// </summary>
        public static readonly CurrencyCode SaintHelenaPound = new("SHP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Leone.
        /// </summary>
        public static readonly CurrencyCode LeoneSLE = new("SLE", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Leone.
        /// </summary>
        public static readonly CurrencyCode LeoneSLL = new("SLL", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Somali Shilling.
        /// </summary>
        public static readonly CurrencyCode SomaliShilling = new("SOS", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Surinam Dollar.
        /// </summary>
        public static readonly CurrencyCode SurinamDollar = new("SRD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the South Sudanese Pound.
        /// </summary>
        public static readonly CurrencyCode SouthSudanesePound = new("SSP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Dobra.
        /// </summary>
        public static readonly CurrencyCode Dobra = new("STN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the El Salvador Colon.
        /// </summary>
        public static readonly CurrencyCode ElSalvadorColon = new("SVC", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Syrian Pound.
        /// </summary>
        public static readonly CurrencyCode SyrianPound = new("SYP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Lilangeni.
        /// </summary>
        public static readonly CurrencyCode Lilangeni = new("SZL", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Baht.
        /// </summary>
        public static readonly CurrencyCode Baht = new("THB", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Somoni.
        /// </summary>
        public static readonly CurrencyCode Somoni = new("TJS", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Turkmenistan New Manat.
        /// </summary>
        public static readonly CurrencyCode TurkmenistanNewManat = new("TMT", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Tunisian Dinar.
        /// </summary>
        public static readonly CurrencyCode TunisianDinar = new("TND", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Pa'anga.
        /// </summary>
        public static readonly CurrencyCode Paanga = new("TOP", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Turkish Lira.
        /// </summary>
        public static readonly CurrencyCode TurkishLira = new("TRY", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Trinidad and Tobago Dollar.
        /// </summary>
        public static readonly CurrencyCode TrinidadAndTobagoDollar = new("TTD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the New Taiwan Dollar.
        /// </summary>
        public static readonly CurrencyCode NewTaiwanDollar = new("TWD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Tanzanian Shilling.
        /// </summary>
        public static readonly CurrencyCode TanzanianShilling = new("TZS", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Hryvnia.
        /// </summary>
        public static readonly CurrencyCode Hryvnia = new("UAH", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Uganda Shilling.
        /// </summary>
        public static readonly CurrencyCode UgandaShilling = new("UGX", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the US Dollar.
        /// </summary>
        public static readonly CurrencyCode USDollar = new("USD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the US Dollar(Next day).
        /// </summary>
        public static readonly CurrencyCode USDollarNextDay = new("USN", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Uruguay Peso en Unidades Indexadas (UI).
        /// </summary>
        public static readonly CurrencyCode UruguayPesoEnUnidadesIndexadas = new("UYI", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Peso Uruguayo.
        /// </summary>
        public static readonly CurrencyCode PesoUruguayo = new("UYU", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Unidad Previsional.
        /// </summary>
        public static readonly CurrencyCode UnidadPrevisional = new("UYW", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Uzbekistan Sum.
        /// </summary>
        public static readonly CurrencyCode UzbekistanSum = new("UZS", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Bolívar Soberano.
        /// </summary>
        public static readonly CurrencyCode BolivarSoberanoVED = new("VED", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Bolívar Soberano.
        /// </summary>
        public static readonly CurrencyCode BolivarSoberanoVES = new("VES", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Dong.
        /// </summary>
        public static readonly CurrencyCode Dong = new("VND", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Vatu.
        /// </summary>
        public static readonly CurrencyCode Vatu = new("VUV", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Tala.
        /// </summary>
        public static readonly CurrencyCode Tala = new("WST", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the CFA Franc BEAC.
        /// </summary>
        public static readonly CurrencyCode CFAFrancBEAC = new("XAF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Silver.
        /// </summary>
        public static readonly CurrencyCode Silver = new("XAG", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Gold.
        /// </summary>
        public static readonly CurrencyCode Gold = new("XAU", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Bond Markets Unit European Composite Unit(EURCO).
        /// </summary>
        public static readonly CurrencyCode BondMarketsUnitEuropeanCompositeUnit = new("XBA", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Bond Markets Unit European Monetary Unit(E.M.U.-6).
        /// </summary>
        public static readonly CurrencyCode BondMarketsUnitEuropeanMonetaryUnit = new("XBB", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Bond Markets Unit European Unit of Account 9 (E.U.A.-9).
        /// </summary>
        public static readonly CurrencyCode BondMarketsUnitEuropeanUnitOfAccount9 = new("XBC", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Bond Markets Unit European Unit of Account 17 (E.U.A.-17).
        /// </summary>
        public static readonly CurrencyCode BondMarketsUnitEuropeanUnitOfAccount17 = new("XBD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the East Caribbean Dollar.
        /// </summary>
        public static readonly CurrencyCode EastCaribbeanDollar = new("XCD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the SDR (Special Drawing Right).
        /// </summary>
        public static readonly CurrencyCode SDR = new("XDR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the CFA Franc BCEAO.
        /// </summary>
        public static readonly CurrencyCode CFAFrancBCEAO = new("XOF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Palladium.
        /// </summary>
        public static readonly CurrencyCode Palladium = new("XPD", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the CFP Franc.
        /// </summary>
        public static readonly CurrencyCode CFPFranc = new("XPF", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Platinum.
        /// </summary>
        public static readonly CurrencyCode Platinum = new("XPT", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Sucre.
        /// </summary>
        public static readonly CurrencyCode Sucre = new("XSU", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the ADB Unit of Account.
        /// </summary>
        public static readonly CurrencyCode ADBUnitOfAccount = new("XUA", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Yemeni Rial.
        /// </summary>
        public static readonly CurrencyCode YemeniRial = new("YER", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Rand.
        /// </summary>
        public static readonly CurrencyCode Rand = new("ZAR", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Zambian Kwacha.
        /// </summary>
        public static readonly CurrencyCode ZambianKwacha = new("ZMW", false);

        /// <summary>
        /// Gets a <see cref="CurrencyCode"/> for the Zimbabwe Dollar.
        /// </summary>
        public static readonly CurrencyCode ZimbabweDollar = new("ZWL", false);
    }
}
