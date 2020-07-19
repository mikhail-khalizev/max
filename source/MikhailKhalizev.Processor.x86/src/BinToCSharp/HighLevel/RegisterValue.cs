using System;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class RegisterValue : Value, IEquatable<RegisterValue>
    {
        public RegisterInfo RegisterInfo { get; }

        public RegisterValue(RegisterInfo registerInfo) : base(registerInfo.LengthInBits)
        {
            RegisterInfo = registerInfo;
        }

        
        #region IEquatable

        /// <inheritdoc />
        public bool Equals(RegisterValue other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(RegisterInfo, other.RegisterInfo);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is RegisterValue other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return (RegisterInfo != null ? RegisterInfo.GetHashCode() : 0);
        }

        public static bool operator ==(RegisterValue left, RegisterValue right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RegisterValue left, RegisterValue right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}