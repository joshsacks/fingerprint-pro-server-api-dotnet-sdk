/* 
 * Fingerprint Pro Server API
 *
 * Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. It can be used for data exports, decision-making, and data analysis scenarios. Server API is intended for server-side usage, it's not intended to be used from the client side, whether it's a browser or a mobile device. 
 *
 * OpenAPI spec version: 3
 * Contact: support@fingerprint.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FingerprintPro.ServerSdk.Model
{
    /// <summary>
    /// Contains all information about the request identified by `requestId`, depending on the pricing plan (Pro, Pro Plus, Enterprise)
    /// </summary>
    [DataContract]
    public partial class ProductsResponse : IEquatable<ProductsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsResponse" /> class.
        /// </summary>
        /// <param name="identification">identification.</param>
        /// <param name="botd">botd.</param>
        /// <param name="ipInfo">ipInfo.</param>
        /// <param name="incognito">incognito.</param>
        /// <param name="rootApps">rootApps.</param>
        /// <param name="emulator">emulator.</param>
        /// <param name="clonedApp">clonedApp.</param>
        /// <param name="factoryReset">factoryReset.</param>
        /// <param name="jailbroken">jailbroken.</param>
        /// <param name="frida">frida.</param>
        /// <param name="ipBlocklist">ipBlocklist.</param>
        /// <param name="tor">tor.</param>
        /// <param name="privacySettings">privacySettings.</param>
        /// <param name="virtualMachine">virtualMachine.</param>
        /// <param name="vpn">vpn.</param>
        /// <param name="proxy">proxy.</param>
        /// <param name="tampering">tampering.</param>
        /// <param name="rawDeviceAttributes">rawDeviceAttributes.</param>
        public ProductsResponse(ProductsResponseIdentification identification = default(ProductsResponseIdentification), ProductsResponseBotd botd = default(ProductsResponseBotd), SignalResponseIpInfo ipInfo = default(SignalResponseIpInfo), SignalResponseIncognito incognito = default(SignalResponseIncognito), SignalResponseRootApps rootApps = default(SignalResponseRootApps), SignalResponseEmulator emulator = default(SignalResponseEmulator), SignalResponseClonedApp clonedApp = default(SignalResponseClonedApp), SignalResponseFactoryReset factoryReset = default(SignalResponseFactoryReset), SignalResponseJailbroken jailbroken = default(SignalResponseJailbroken), SignalResponseFrida frida = default(SignalResponseFrida), SignalResponseIpBlocklist ipBlocklist = default(SignalResponseIpBlocklist), SignalResponseTor tor = default(SignalResponseTor), SignalResponsePrivacySettings privacySettings = default(SignalResponsePrivacySettings), SignalResponseVirtualMachine virtualMachine = default(SignalResponseVirtualMachine), SignalResponseVpn vpn = default(SignalResponseVpn), SignalResponseProxy proxy = default(SignalResponseProxy), SignalResponseTampering tampering = default(SignalResponseTampering), SignalResponseRawDeviceAttributes rawDeviceAttributes = default(SignalResponseRawDeviceAttributes))
        {
            this.Identification = identification;
            this.Botd = botd;
            this.IpInfo = ipInfo;
            this.Incognito = incognito;
            this.RootApps = rootApps;
            this.Emulator = emulator;
            this.ClonedApp = clonedApp;
            this.FactoryReset = factoryReset;
            this.Jailbroken = jailbroken;
            this.Frida = frida;
            this.IpBlocklist = ipBlocklist;
            this.Tor = tor;
            this.PrivacySettings = privacySettings;
            this.VirtualMachine = virtualMachine;
            this.Vpn = vpn;
            this.Proxy = proxy;
            this.Tampering = tampering;
            this.RawDeviceAttributes = rawDeviceAttributes;
        }

        /// <summary>
        /// Gets or Sets Identification
        /// </summary>
        [DataMember(Name = "identification", EmitDefaultValue = false)]
        public ProductsResponseIdentification Identification { get; set; }

        /// <summary>
        /// Gets or Sets Botd
        /// </summary>
        [DataMember(Name = "botd", EmitDefaultValue = false)]
        public ProductsResponseBotd Botd { get; set; }

        /// <summary>
        /// Gets or Sets IpInfo
        /// </summary>
        [DataMember(Name = "ipInfo", EmitDefaultValue = false)]
        public SignalResponseIpInfo IpInfo { get; set; }

        /// <summary>
        /// Gets or Sets Incognito
        /// </summary>
        [DataMember(Name = "incognito", EmitDefaultValue = false)]
        public SignalResponseIncognito Incognito { get; set; }

        /// <summary>
        /// Gets or Sets RootApps
        /// </summary>
        [DataMember(Name = "rootApps", EmitDefaultValue = false)]
        public SignalResponseRootApps RootApps { get; set; }

        /// <summary>
        /// Gets or Sets Emulator
        /// </summary>
        [DataMember(Name = "emulator", EmitDefaultValue = false)]
        public SignalResponseEmulator Emulator { get; set; }

        /// <summary>
        /// Gets or Sets ClonedApp
        /// </summary>
        [DataMember(Name = "clonedApp", EmitDefaultValue = false)]
        public SignalResponseClonedApp ClonedApp { get; set; }

        /// <summary>
        /// Gets or Sets FactoryReset
        /// </summary>
        [DataMember(Name = "factoryReset", EmitDefaultValue = false)]
        public SignalResponseFactoryReset FactoryReset { get; set; }

        /// <summary>
        /// Gets or Sets Jailbroken
        /// </summary>
        [DataMember(Name = "jailbroken", EmitDefaultValue = false)]
        public SignalResponseJailbroken Jailbroken { get; set; }

        /// <summary>
        /// Gets or Sets Frida
        /// </summary>
        [DataMember(Name = "frida", EmitDefaultValue = false)]
        public SignalResponseFrida Frida { get; set; }

        /// <summary>
        /// Gets or Sets IpBlocklist
        /// </summary>
        [DataMember(Name = "ipBlocklist", EmitDefaultValue = false)]
        public SignalResponseIpBlocklist IpBlocklist { get; set; }

        /// <summary>
        /// Gets or Sets Tor
        /// </summary>
        [DataMember(Name = "tor", EmitDefaultValue = false)]
        public SignalResponseTor Tor { get; set; }

        /// <summary>
        /// Gets or Sets PrivacySettings
        /// </summary>
        [DataMember(Name = "privacySettings", EmitDefaultValue = false)]
        public SignalResponsePrivacySettings PrivacySettings { get; set; }

        /// <summary>
        /// Gets or Sets VirtualMachine
        /// </summary>
        [DataMember(Name = "virtualMachine", EmitDefaultValue = false)]
        public SignalResponseVirtualMachine VirtualMachine { get; set; }

        /// <summary>
        /// Gets or Sets Vpn
        /// </summary>
        [DataMember(Name = "vpn", EmitDefaultValue = false)]
        public SignalResponseVpn Vpn { get; set; }

        /// <summary>
        /// Gets or Sets Proxy
        /// </summary>
        [DataMember(Name = "proxy", EmitDefaultValue = false)]
        public SignalResponseProxy Proxy { get; set; }

        /// <summary>
        /// Gets or Sets Tampering
        /// </summary>
        [DataMember(Name = "tampering", EmitDefaultValue = false)]
        public SignalResponseTampering Tampering { get; set; }

        /// <summary>
        /// Gets or Sets RawDeviceAttributes
        /// </summary>
        [DataMember(Name = "rawDeviceAttributes", EmitDefaultValue = false)]
        public SignalResponseRawDeviceAttributes RawDeviceAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductsResponse {\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  Botd: ").Append(Botd).Append("\n");
            sb.Append("  IpInfo: ").Append(IpInfo).Append("\n");
            sb.Append("  Incognito: ").Append(Incognito).Append("\n");
            sb.Append("  RootApps: ").Append(RootApps).Append("\n");
            sb.Append("  Emulator: ").Append(Emulator).Append("\n");
            sb.Append("  ClonedApp: ").Append(ClonedApp).Append("\n");
            sb.Append("  FactoryReset: ").Append(FactoryReset).Append("\n");
            sb.Append("  Jailbroken: ").Append(Jailbroken).Append("\n");
            sb.Append("  Frida: ").Append(Frida).Append("\n");
            sb.Append("  IpBlocklist: ").Append(IpBlocklist).Append("\n");
            sb.Append("  Tor: ").Append(Tor).Append("\n");
            sb.Append("  PrivacySettings: ").Append(PrivacySettings).Append("\n");
            sb.Append("  VirtualMachine: ").Append(VirtualMachine).Append("\n");
            sb.Append("  Vpn: ").Append(Vpn).Append("\n");
            sb.Append("  Proxy: ").Append(Proxy).Append("\n");
            sb.Append("  Tampering: ").Append(Tampering).Append("\n");
            sb.Append("  RawDeviceAttributes: ").Append(RawDeviceAttributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if ProductsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductsResponse input)
        {
            if (input == null)
                return false;

            return
                (
                this.Identification == input.Identification ||
                (this.Identification != null &&
                this.Identification.Equals(input.Identification))
                ) &&
                (
                this.Botd == input.Botd ||
                (this.Botd != null &&
                this.Botd.Equals(input.Botd))
                ) &&
                (
                this.IpInfo == input.IpInfo ||
                (this.IpInfo != null &&
                this.IpInfo.Equals(input.IpInfo))
                ) &&
                (
                this.Incognito == input.Incognito ||
                (this.Incognito != null &&
                this.Incognito.Equals(input.Incognito))
                ) &&
                (
                this.RootApps == input.RootApps ||
                (this.RootApps != null &&
                this.RootApps.Equals(input.RootApps))
                ) &&
                (
                this.Emulator == input.Emulator ||
                (this.Emulator != null &&
                this.Emulator.Equals(input.Emulator))
                ) &&
                (
                this.ClonedApp == input.ClonedApp ||
                (this.ClonedApp != null &&
                this.ClonedApp.Equals(input.ClonedApp))
                ) &&
                (
                this.FactoryReset == input.FactoryReset ||
                (this.FactoryReset != null &&
                this.FactoryReset.Equals(input.FactoryReset))
                ) &&
                (
                this.Jailbroken == input.Jailbroken ||
                (this.Jailbroken != null &&
                this.Jailbroken.Equals(input.Jailbroken))
                ) &&
                (
                this.Frida == input.Frida ||
                (this.Frida != null &&
                this.Frida.Equals(input.Frida))
                ) &&
                (
                this.IpBlocklist == input.IpBlocklist ||
                (this.IpBlocklist != null &&
                this.IpBlocklist.Equals(input.IpBlocklist))
                ) &&
                (
                this.Tor == input.Tor ||
                (this.Tor != null &&
                this.Tor.Equals(input.Tor))
                ) &&
                (
                this.PrivacySettings == input.PrivacySettings ||
                (this.PrivacySettings != null &&
                this.PrivacySettings.Equals(input.PrivacySettings))
                ) &&
                (
                this.VirtualMachine == input.VirtualMachine ||
                (this.VirtualMachine != null &&
                this.VirtualMachine.Equals(input.VirtualMachine))
                ) &&
                (
                this.Vpn == input.Vpn ||
                (this.Vpn != null &&
                this.Vpn.Equals(input.Vpn))
                ) &&
                (
                this.Proxy == input.Proxy ||
                (this.Proxy != null &&
                this.Proxy.Equals(input.Proxy))
                ) &&
                (
                this.Tampering == input.Tampering ||
                (this.Tampering != null &&
                this.Tampering.Equals(input.Tampering))
                ) &&
                (
                this.RawDeviceAttributes == input.RawDeviceAttributes ||
                (this.RawDeviceAttributes != null &&
                this.RawDeviceAttributes.Equals(input.RawDeviceAttributes))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Identification != null)
                    hashCode = hashCode * 59 + this.Identification.GetHashCode();
                if (this.Botd != null)
                    hashCode = hashCode * 59 + this.Botd.GetHashCode();
                if (this.IpInfo != null)
                    hashCode = hashCode * 59 + this.IpInfo.GetHashCode();
                if (this.Incognito != null)
                    hashCode = hashCode * 59 + this.Incognito.GetHashCode();
                if (this.RootApps != null)
                    hashCode = hashCode * 59 + this.RootApps.GetHashCode();
                if (this.Emulator != null)
                    hashCode = hashCode * 59 + this.Emulator.GetHashCode();
                if (this.ClonedApp != null)
                    hashCode = hashCode * 59 + this.ClonedApp.GetHashCode();
                if (this.FactoryReset != null)
                    hashCode = hashCode * 59 + this.FactoryReset.GetHashCode();
                if (this.Jailbroken != null)
                    hashCode = hashCode * 59 + this.Jailbroken.GetHashCode();
                if (this.Frida != null)
                    hashCode = hashCode * 59 + this.Frida.GetHashCode();
                if (this.IpBlocklist != null)
                    hashCode = hashCode * 59 + this.IpBlocklist.GetHashCode();
                if (this.Tor != null)
                    hashCode = hashCode * 59 + this.Tor.GetHashCode();
                if (this.PrivacySettings != null)
                    hashCode = hashCode * 59 + this.PrivacySettings.GetHashCode();
                if (this.VirtualMachine != null)
                    hashCode = hashCode * 59 + this.VirtualMachine.GetHashCode();
                if (this.Vpn != null)
                    hashCode = hashCode * 59 + this.Vpn.GetHashCode();
                if (this.Proxy != null)
                    hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                if (this.Tampering != null)
                    hashCode = hashCode * 59 + this.Tampering.GetHashCode();
                if (this.RawDeviceAttributes != null)
                    hashCode = hashCode * 59 + this.RawDeviceAttributes.GetHashCode();
                return hashCode;
            }
        }

    }
}