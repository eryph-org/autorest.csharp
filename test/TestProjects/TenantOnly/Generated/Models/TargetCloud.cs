// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace TenantOnly
{
    /// <summary> Possible cloud environments. </summary>
    internal readonly partial struct TargetCloud : IEquatable<TargetCloud>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TargetCloud"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TargetCloud(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string USGovValue = "USGov";
        private const string USNatValue = "USNat";
        private const string USSecValue = "USSec";

        /// <summary> USGov. </summary>
        public static TargetCloud USGov { get; } = new TargetCloud(USGovValue);
        /// <summary> USNat. </summary>
        public static TargetCloud USNat { get; } = new TargetCloud(USNatValue);
        /// <summary> USSec. </summary>
        public static TargetCloud USSec { get; } = new TargetCloud(USSecValue);
        /// <summary> Determines if two <see cref="TargetCloud"/> values are the same. </summary>
        public static bool operator ==(TargetCloud left, TargetCloud right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TargetCloud"/> values are not the same. </summary>
        public static bool operator !=(TargetCloud left, TargetCloud right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TargetCloud"/>. </summary>
        public static implicit operator TargetCloud(string value) => new TargetCloud(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TargetCloud other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TargetCloud other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}