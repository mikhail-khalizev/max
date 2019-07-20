// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo

namespace MikhailKhalizev.Processor.x86.InstructionDecode
{
    public enum MnemonicCode
    {
        /// <summary>
        /// ASCII Adjust After Addition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AAA.html
        /// Page 120 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        aaa,

        /// <summary>
        /// ASCII Adjust AX Before Division.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AAD.html
        /// Page 122 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        aad,

        /// <summary>
        /// ASCII Adjust AX After Multiply.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AAM.html
        /// Page 124 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        aam,

        /// <summary>
        /// ASCII Adjust AL After Subtraction.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AAS.html
        /// Page 126 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        aas,

        /// <summary>
        /// Add with Carry.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADC.html
        /// Page 128 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        adc,

        /// <summary>
        /// Unsigned Integer Addition of Two Operands with Carry Flag.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADCX.html
        /// Page 131 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        adcx,

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADD.html
        /// Page 133 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        add,

        /// <summary>
        /// Add Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDPD.html
        /// Page 135 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        addpd,

        /// <summary>
        /// Add Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDPS.html
        /// Page 138 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        addps,

        /// <summary>
        /// Add Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDSD.html
        /// Page 141 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        addsd,

        /// <summary>
        /// Add Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDSS.html
        /// Page 143 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        addss,

        /// <summary>
        /// Packed Double-FP Add/Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDSUBPD.html
        /// Page 145 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        addsubpd,

        /// <summary>
        /// Packed Single-FP Add/Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDSUBPS.html
        /// Page 147 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        addsubps,

        /// <summary>
        /// Unsigned Integer Addition of Two Operands with Overflow Flag.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADOX.html
        /// Page 150 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        adox,

        /// <summary>
        /// Perform One Round of an AES Decryption Flow.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESDEC.html
        /// Page 152 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        aesdec,

        /// <summary>
        /// Perform Last Round of an AES Decryption Flow.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESDECLAST.html
        /// Page 154 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        aesdeclast,

        /// <summary>
        /// Perform One Round of an AES Encryption Flow.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESENC.html
        /// Page 156 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        aesenc,

        /// <summary>
        /// Perform Last Round of an AES Encryption Flow.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESENCLAST.html
        /// Page 158 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        aesenclast,

        /// <summary>
        /// Perform the AES InvMixColumn Transformation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESIMC.html
        /// Page 160 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        aesimc,

        /// <summary>
        /// AES Round Key Generation Assist.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESKEYGENASSIST.html
        /// Page 161 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        aeskeygenassist,

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AND.html
        /// Page 163 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        and,

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ANDN.html
        /// Page 165 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        andn,

        /// <summary>
        /// Bitwise Logical AND NOT of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ANDNPD.html
        /// Page 172 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        andnpd,

        /// <summary>
        /// Bitwise Logical AND NOT of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ANDNPS.html
        /// Page 175 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        andnps,

        /// <summary>
        /// Bitwise Logical AND of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ANDPD.html
        /// Page 166 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        andpd,

        /// <summary>
        /// Bitwise Logical AND of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ANDPS.html
        /// Page 169 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        andps,

        /// <summary>
        /// Adjust RPL Field of Segment Selector.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ARPL.html
        /// Page 178 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        arpl,

        /// <summary>
        /// Count the Number of Leading Zero Bits.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LZCNT.html
        /// Page 663 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bd,

        /// <summary>
        /// Bit Field Extract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BEXTR.html
        /// Page 180 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bextr,

        /// <summary>
        /// Blend Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BLENDPD.html
        /// Page 181 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        blendpd,

        /// <summary>
        /// Blend Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BLENDPS.html
        /// Page 183 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        blendps,

        /// <summary>
        /// Variable Blend Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BLENDVPD.html
        /// Page 185 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        blendvpd,

        /// <summary>
        /// Variable Blend Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BLENDVPS.html
        /// Page 187 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        blendvps,

        /// <summary>
        /// Extract Lowest Set Isolated Bit.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BLSI.html
        /// Page 190 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        blsi,

        /// <summary>
        /// Get Mask Up to Lowest Set Bit.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BLSMSK.html
        /// Page 191 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        blsmsk,

        /// <summary>
        /// Reset Lowest Set Bit.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BLSR.html
        /// Page 192 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        blsr,

        /// <summary>
        /// Check Lower Bound.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BNDCL.html
        /// Page 193 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bndcl,

        /// <summary>
        /// Check Upper Bound.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BNDCU:BNDCN.html
        /// Page 195 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bndcn,

        /// <summary>
        /// Check Upper Bound.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BNDCU:BNDCN.html
        /// Page 195 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bndcu,

        /// <summary>
        /// Load Extended Bounds Using Address Translation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BNDLDX.html
        /// Page 197 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bndldx,

        /// <summary>
        /// Make Bounds.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BNDMK.html
        /// Page 200 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bndmk,

        /// <summary>
        /// Move Bounds.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BNDMOV.html
        /// Page 202 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bndmov,

        /// <summary>
        /// Store Extended Bounds Using Address Translation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BNDSTX.html
        /// Page 205 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bndstx,

        /// <summary>
        /// Check Array Index Against Bounds.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BOUND.html
        /// Page 208 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bound,

        /// <summary>
        /// Bit Scan Forward.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BSF.html
        /// Page 210 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bsf,

        /// <summary>
        /// Bit Scan Reverse.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BSR.html
        /// Page 212 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bsr,

        /// <summary>
        /// Byte Swap.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BSWAP.html
        /// Page 214 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bswap,

        /// <summary>
        /// Bit Test.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BT.html
        /// Page 215 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bt,

        /// <summary>
        /// Bit Test and Complement.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BTC.html
        /// Page 217 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        btc,

        /// <summary>
        /// Bit Test and Reset.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BTR.html
        /// Page 219 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        btr,

        /// <summary>
        /// Bit Test and Set.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BTS.html
        /// Page 221 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bts,

        /// <summary>
        /// Zero High Bits Starting with Specified Bit Position.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BZHI.html
        /// Page 223 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        bzhi,

        /// <summary>
        /// Call Procedure.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CALL.html
        /// Page 224 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        call,

        /// <summary>
        /// Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CBW:CWDE:CDQE.html
        /// Page 238 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cbw,

        /// <summary>
        /// Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CWD:CDQ:CQO.html
        /// Page 387 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cdq,

        /// <summary>
        /// Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CBW:CWDE:CDQE.html
        /// Page 238 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cdqe,

        /// <summary>
        /// Clear AC Flag in EFLAGS Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CLAC.html
        /// Page 239 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        clac,

        /// <summary>
        /// Clear Carry Flag.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CLC.html
        /// Page 240 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        clc,

        /// <summary>
        /// Clear Direction Flag.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CLD.html
        /// Page 241 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cld,

        /// <summary>
        /// Flush Cache Line.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CLFLUSH.html
        /// Page 244 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        clflush,

        /// <summary>
        /// Flush Cache Line Optimized.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CLFLUSHOPT.html
        /// Page 246 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        clflushopt,

        /// <summary>
        /// Clear Interrupt Flag.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CLI.html
        /// Page 248 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cli,

        /// <summary>
        /// Clear Task-Switched Flag in CR0.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CLTS.html
        /// Page 250 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        clts,

        /// <summary>
        /// Cache Line Write Back.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CLWB.html
        /// Page 251 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        clwb,

        /// <summary>
        /// Complement Carry Flag.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMC.html
        /// Page 253 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmc,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmova,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovae,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovb,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovbe,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovc,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmove,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovg,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovge,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovl,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovle,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovna,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovnae,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovnb,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovnbe,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovnc,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovne,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovng,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovnge,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovnl,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovnle,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovno,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovnp,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovns,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovnz,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovo,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovp,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovpe,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovpo,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovs,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMOVcc.html
        /// Page 254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmovz,

        /// <summary>
        /// Compare Two Operands.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMP.html
        /// Page 258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmp,

        /// <summary>
        /// Compare Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPPD.html
        /// Page 260 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmppd,

        /// <summary>
        /// Compare Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPPS.html
        /// Page 267 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmpps,

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html
        /// Page 274 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmps,

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html
        /// Page 274 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmpsb,

        /// <summary>
        /// Compare String Operands.
        /// Compare Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html
        /// https://www.felixcloutier.com/x86/CMPSD.html
        /// Pages 274, 278 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmpsd,

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html
        /// Page 274 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmpsq,

        /// <summary>
        /// Compare Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPSS.html
        /// Page 282 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmpss,

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html
        /// Page 274 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmpsw,

        /// <summary>
        /// Compare and Exchange.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPXCHG.html
        /// Page 286 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmpxchg,

        /// <summary>
        /// Compare and Exchange Bytes.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPXCHG8B:CMPXCHG16B.html
        /// Page 288 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmpxchg16b,

        /// <summary>
        /// Compare and Exchange Bytes.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPXCHG8B:CMPXCHG16B.html
        /// Page 288 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cmpxchg8b,

        /// <summary>
        /// Compare Scalar Ordered Double-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/COMISD.html
        /// Page 291 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        comisd,

        /// <summary>
        /// Compare Scalar Ordered Single-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/COMISS.html
        /// Page 293 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        comiss,

        /// <summary>
        /// CPU Identification.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CPUID.html
        /// Page 295 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cpuid,

        /// <summary>
        /// Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CWD:CDQ:CQO.html
        /// Page 387 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cqo,

        /// <summary>
        /// Accumulate CRC32 Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CRC32.html
        /// Page 334 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        crc32,

        /// <summary>
        /// Convert Packed Doubleword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTDQ2PD.html
        /// Page 337 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtdq2pd,

        /// <summary>
        /// Convert Packed Doubleword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTDQ2PS.html
        /// Page 341 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtdq2ps,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Doubleword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPD2DQ.html
        /// Page 344 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtpd2dq,

        /// <summary>
        /// Convert Packed Double-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPD2PI.html
        /// Page 348 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtpd2pi,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPD2PS.html
        /// Page 349 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtpd2ps,

        /// <summary>
        /// Convert Packed Dword Integers to Packed Double-Precision FP Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPI2PD.html
        /// Page 353 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtpi2pd,

        /// <summary>
        /// Convert Packed Dword Integers to Packed Single-Precision FP Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPI2PS.html
        /// Page 354 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtpi2ps,

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPS2DQ.html
        /// Page 355 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtps2dq,

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPS2PD.html
        /// Page 358 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtps2pd,

        /// <summary>
        /// Convert Packed Single-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPS2PI.html
        /// Page 361 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtps2pi,

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Doubleword Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSD2SI.html
        /// Page 362 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtsd2si,

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSD2SS.html
        /// Page 364 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtsd2ss,

        /// <summary>
        /// Convert Doubleword Integer to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSI2SD.html
        /// Page 366 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtsi2sd,

        /// <summary>
        /// Convert Doubleword Integer to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSI2SS.html
        /// Page 368 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtsi2ss,

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSS2SD.html
        /// Page 370 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtss2sd,

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Doubleword Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSS2SI.html
        /// Page 372 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvtss2si,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Doubleword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTTPD2DQ.html
        /// Page 374 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvttpd2dq,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTTPD2PI.html
        /// Page 378 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvttpd2pi,

        /// <summary>
        /// Convert with Truncation Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTTPS2DQ.html
        /// Page 379 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvttps2dq,

        /// <summary>
        /// Convert with Truncation Packed Single-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTTPS2PI.html
        /// Page 382 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvttps2pi,

        /// <summary>
        /// Convert with Truncation Scalar Double-Precision Floating-Point Value to Signed Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTTSD2SI.html
        /// Page 383 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvttsd2si,

        /// <summary>
        /// Convert with Truncation Scalar Single-Precision Floating-Point Value to Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTTSS2SI.html
        /// Page 385 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cvttss2si,

        /// <summary>
        /// Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CWD:CDQ:CQO.html
        /// Page 387 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cwd,

        /// <summary>
        /// Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CBW:CWDE:CDQE.html
        /// Page 238 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        cwde,

        /// <summary>
        /// Decimal Adjust AL after Addition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DAA.html
        /// Page 388 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        daa,

        /// <summary>
        /// Decimal Adjust AL after Subtraction.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DAS.html
        /// Page 390 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        das,

        /// <summary>
        /// Decrement by 1.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DEC.html
        /// Page 392 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        dec,

        /// <summary>
        /// Unsigned Divide.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DIV.html
        /// Page 394 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        div,

        /// <summary>
        /// Divide Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DIVPD.html
        /// Page 397 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        divpd,

        /// <summary>
        /// Divide Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DIVPS.html
        /// Page 400 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        divps,

        /// <summary>
        /// Divide Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DIVSD.html
        /// Page 403 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        divsd,

        /// <summary>
        /// Divide Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DIVSS.html
        /// Page 405 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        divss,

        /// <summary>
        /// Dot Product of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DPPD.html
        /// Page 407 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        dppd,

        /// <summary>
        /// Dot Product of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DPPS.html
        /// Page 409 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        dpps,

        /// <summary>
        /// Empty MMX Technology State.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/EMMS.html
        /// Page 412 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        emms,

        /// <summary>
        /// Make Stack Frame for Procedure Parameters.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ENTER.html
        /// Page 413 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        enter,

        /// <summary>
        /// Extract Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/EXTRACTPS.html
        /// Page 416 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        extractps,

        /// <summary>
        /// Compute 2x–1.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/F2XM1.html
        /// Page 418 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        f2xm1,

        /// <summary>
        /// Absolute Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FABS.html
        /// Page 420 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fabs,

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FADD:FADDP:FIADD.html
        /// Page 421 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fadd,

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FADD:FADDP:FIADD.html
        /// Page 421 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        faddp,

        /// <summary>
        /// Load Binary Coded Decimal.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FBLD.html
        /// Page 424 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fbld,

        /// <summary>
        /// Store BCD Integer and Pop.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FBSTP.html
        /// Page 426 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fbstp,

        /// <summary>
        /// Change Sign.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCHS.html
        /// Page 428 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fchs,

        /// <summary>
        /// Clear Exceptions.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCLEX:FNCLEX.html
        /// Page 430 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fclex,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCMOVcc.html
        /// Page 432 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcmovb,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCMOVcc.html
        /// Page 432 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcmovbe,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCMOVcc.html
        /// Page 432 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcmove,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCMOVcc.html
        /// Page 432 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcmovnb,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCMOVcc.html
        /// Page 432 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcmovnbe,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCMOVcc.html
        /// Page 432 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcmovne,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCMOVcc.html
        /// Page 432 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcmovnu,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCMOVcc.html
        /// Page 432 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcmovu,

        /// <summary>
        /// Compare Floating Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCOM:FCOMP:FCOMPP.html
        /// Page 434 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcom,

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html
        /// Page 437 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcomi,

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html
        /// Page 437 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcomip,

        /// <summary>
        /// Compare Floating Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCOM:FCOMP:FCOMPP.html
        /// Page 434 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcomp,

        /// <summary>
        /// Compare Floating Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCOM:FCOMP:FCOMPP.html
        /// Page 434 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcompp,

        /// <summary>
        /// Cosine.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCOS.html
        /// Page 440 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fcos,

        /// <summary>
        /// Decrement Stack-Top Pointer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FDECSTP.html
        /// Page 442 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fdecstp,

        /// <summary>
        /// Divide.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FDIV:FDIVP:FIDIV.html
        /// Page 443 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fdiv,

        /// <summary>
        /// Divide.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FDIV:FDIVP:FIDIV.html
        /// Page 443 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fdivp,

        /// <summary>
        /// Reverse Divide.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FDIVR:FDIVRP:FIDIVR.html
        /// Page 446 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fdivr,

        /// <summary>
        /// Reverse Divide.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FDIVR:FDIVRP:FIDIVR.html
        /// Page 446 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fdivrp,

        /// <summary>
        /// Free Floating-Point Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FFREE.html
        /// Page 449 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ffree,

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FADD:FADDP:FIADD.html
        /// Page 421 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fiadd,

        /// <summary>
        /// Compare Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FICOM:FICOMP.html
        /// Page 450 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ficom,

        /// <summary>
        /// Compare Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FICOM:FICOMP.html
        /// Page 450 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ficomp,

        /// <summary>
        /// Divide.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FDIV:FDIVP:FIDIV.html
        /// Page 443 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fidiv,

        /// <summary>
        /// Reverse Divide.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FDIVR:FDIVRP:FIDIVR.html
        /// Page 446 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fidivr,

        /// <summary>
        /// Load Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FILD.html
        /// Page 452 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fild,

        /// <summary>
        /// Multiply.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FMUL:FMULP:FIMUL.html
        /// Page 470 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fimul,

        /// <summary>
        /// Increment Stack-Top Pointer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FINCSTP.html
        /// Page 454 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fincstp,

        /// <summary>
        /// Initialize Floating-Point Unit.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FINIT:FNINIT.html
        /// Page 455 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        finit,

        /// <summary>
        /// Store Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FIST:FISTP.html
        /// Page 457 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fist,

        /// <summary>
        /// Store Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FIST:FISTP.html
        /// Page 457 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fistp,

        /// <summary>
        /// Store Integer with Truncation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FISTTP.html
        /// Page 460 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fisttp,

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSUB:FSUBP:FISUB.html
        /// Page 504 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fisub,

        /// <summary>
        /// Reverse Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSUBR:FSUBRP:FISUBR.html
        /// Page 507 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fisubr,

        /// <summary>
        /// Load Floating Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FLD.html
        /// Page 462 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fld,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html
        /// Page 464 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fld1,

        /// <summary>
        /// Load x87 FPU Control Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FLDCW.html
        /// Page 466 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fldcw,

        /// <summary>
        /// Load x87 FPU Environment.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FLDENV.html
        /// Page 468 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fldenv,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html
        /// Page 464 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fldl2e,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html
        /// Page 464 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fldl2t,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html
        /// Page 464 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fldlg2,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html
        /// Page 464 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fldln2,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html
        /// Page 464 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fldpi,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html
        /// Page 464 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fldz,

        /// <summary>
        /// Multiply.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FMUL:FMULP:FIMUL.html
        /// Page 470 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fmul,

        /// <summary>
        /// Multiply.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FMUL:FMULP:FIMUL.html
        /// Page 470 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fmulp,

        /// <summary>
        /// Clear Exceptions.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCLEX:FNCLEX.html
        /// Page 430 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fnclex,

        /// <summary>
        /// Initialize Floating-Point Unit.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FINIT:FNINIT.html
        /// Page 455 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fninit,

        /// <summary>
        /// No Operation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FNOP.html
        /// Page 473 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fnop,

        /// <summary>
        /// Store x87 FPU State.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSAVE:FNSAVE.html
        /// Page 485 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fnsave,

        /// <summary>
        /// Store x87 FPU Control Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSTCW:FNSTCW.html
        /// Page 498 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fnstcw,

        /// <summary>
        /// Store x87 FPU Environment.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSTENV:FNSTENV.html
        /// Page 500 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fnstenv,

        /// <summary>
        /// Store x87 FPU Status Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSTSW:FNSTSW.html
        /// Page 502 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fnstsw,

        /// <summary>
        /// Partial Arctangent.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FPATAN.html
        /// Page 474 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fpatan,

        /// <summary>
        /// Partial Remainder.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FPREM.html
        /// Page 476 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fprem,

        /// <summary>
        /// Partial Remainder.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FPREM1.html
        /// Page 478 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fprem1,

        /// <summary>
        /// Partial Tangent.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FPTAN.html
        /// Page 480 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fptan,

        /// <summary>
        /// Round to Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FRNDINT.html
        /// Page 482 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        frndint,

        /// <summary>
        /// Restore x87 FPU State.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FRSTOR.html
        /// Page 483 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        frstor,

        /// <summary>
        /// Store x87 FPU State.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSAVE:FNSAVE.html
        /// Page 485 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fsave,

        /// <summary>
        /// Scale.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSCALE.html
        /// Page 488 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fscale,

        /// <summary>
        /// Sine.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSIN.html
        /// Page 490 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fsin,

        /// <summary>
        /// Sine and Cosine.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSINCOS.html
        /// Page 492 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fsincos,

        /// <summary>
        /// Square Root.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSQRT.html
        /// Page 494 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fsqrt,

        /// <summary>
        /// Store Floating Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FST:FSTP.html
        /// Page 496 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fst,

        /// <summary>
        /// Store x87 FPU Control Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSTCW:FNSTCW.html
        /// Page 498 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fstcw,

        /// <summary>
        /// Store x87 FPU Environment.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSTENV:FNSTENV.html
        /// Page 500 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fstenv,

        /// <summary>
        /// Store Floating Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FST:FSTP.html
        /// Page 496 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fstp,

        /// <summary>
        /// Store x87 FPU Status Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSTSW:FNSTSW.html
        /// Page 502 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fstsw,

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSUB:FSUBP:FISUB.html
        /// Page 504 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fsub,

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSUB:FSUBP:FISUB.html
        /// Page 504 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fsubp,

        /// <summary>
        /// Reverse Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSUBR:FSUBRP:FISUBR.html
        /// Page 507 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fsubr,

        /// <summary>
        /// Reverse Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FSUBR:FSUBRP:FISUBR.html
        /// Page 507 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fsubrp,

        /// <summary>
        /// TEST.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FTST.html
        /// Page 510 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ftst,

        /// <summary>
        /// Unordered Compare Floating Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FUCOM:FUCOMP:FUCOMPP.html
        /// Page 512 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fucom,

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html
        /// Page 437 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fucomi,

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html
        /// Page 437 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fucomip,

        /// <summary>
        /// Unordered Compare Floating Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FUCOM:FUCOMP:FUCOMPP.html
        /// Page 512 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fucomp,

        /// <summary>
        /// Unordered Compare Floating Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FUCOM:FUCOMP:FUCOMPP.html
        /// Page 512 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fucompp,

        /// <summary>
        /// Wait.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/WAIT:FWAIT.html
        /// Page 1923 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fwait,

        /// <summary>
        /// Examine Floating-Point.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FXAM.html
        /// Page 515 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fxam,

        /// <summary>
        /// Exchange Register Contents.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FXCH.html
        /// Page 517 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fxch,

        /// <summary>
        /// Restore x87 FPU, MMX, XMM, and MXCSR State.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FXRSTOR.html
        /// Page 519 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fxrstor,

        /// <summary>
        /// Restore x87 FPU, MMX, XMM, and MXCSR State.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FXRSTOR.html
        /// Page 519 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fxrstor64,

        /// <summary>
        /// Save x87 FPU, MMX Technology, and SSE State.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FXSAVE.html
        /// Page 522 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fxsave,

        /// <summary>
        /// Save x87 FPU, MMX Technology, and SSE State.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FXSAVE.html
        /// Page 522 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fxsave64,

        /// <summary>
        /// Extract Exponent and Significand.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FXTRACT.html
        /// Page 530 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fxtract,

        /// <summary>
        /// Compute y * log2x.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FYL2X.html
        /// Page 532 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fyl2x,

        /// <summary>
        /// Compute y * log2(x +1).
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/FYL2XP1.html
        /// Page 534 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        fyl2xp1,

        /// <summary>
        /// Packed Double-FP Horizontal Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/HADDPD.html
        /// Page 540 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        haddpd,

        /// <summary>
        /// Packed Single-FP Horizontal Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/HADDPS.html
        /// Page 543 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        haddps,

        /// <summary>
        /// Halt.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/HLT.html
        /// Page 546 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        hlt,

        /// <summary>
        /// Packed Double-FP Horizontal Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/HSUBPD.html
        /// Page 547 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        hsubpd,

        /// <summary>
        /// Packed Single-FP Horizontal Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/HSUBPS.html
        /// Page 550 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        hsubps,

        /// <summary>
        /// Permute In-Lane of Quadruples of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMILPS.html
        /// Page 1728 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ibvpermilps,

        /// <summary>
        /// Signed Divide.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/IDIV.html
        /// Page 553 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        idiv,

        /// <summary>
        /// Signed Multiply.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/IMUL.html
        /// Page 556 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        imul,

        /// <summary>
        /// Input from Port.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/IN.html
        /// Page 560 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        @in,

        /// <summary>
        /// Increment by 1.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INC.html
        /// Page 562 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        inc,

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html
        /// Page 564 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ins,

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html
        /// Page 564 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        insb,

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html
        /// Page 564 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        insd,

        /// <summary>
        /// Insert Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INSERTPS.html
        /// Page 567 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        insertps,

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html
        /// Page 564 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        insw,

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html
        /// Page 570 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        @int,

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html
        /// Page 570 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        int1,

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html
        /// Page 570 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        int3,

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html
        /// Page 570 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        into,

        /// <summary>
        /// Invalidate Internal Caches.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INVD.html
        /// Page 583 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        invd,

        /// <summary>
        /// Invalidate Process-Context Identifier.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INVPCID.html
        /// Page 587 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        invpcid,

        /// <summary>
        /// Interrupt Return.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/IRET:IRETD.html
        /// Page 590 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        iret,

        /// <summary>
        /// Interrupt Return.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/IRET:IRETD.html
        /// Page 590 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        iretd,

        /// <summary>
        /// Interrupt Return.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/IRET:IRETD.html
        /// Page 590 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        iretq,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ja,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jae,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jb,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jbe,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jc,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jcxz,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        je,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jecxz,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jg,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jge,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jl,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jle,

        /// <summary>
        /// Jump.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/JMP.html
        /// Page 602 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jmp,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jna,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jnae,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jnb,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jnbe,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jnc,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jne,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jng,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jnge,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jnl,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jnle,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jno,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jnp,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jns,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jnz,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jo,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jp,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jpe,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jpo,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jrcxz,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        js,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/Jcc.html
        /// Page 597 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        jz,

        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html
        /// Page 610 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kaddb,

        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html
        /// Page 610 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kaddd,

        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html
        /// Page 610 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kaddq,

        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html
        /// Page 610 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kaddw,

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html
        /// Page 611 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kandb,

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html
        /// Page 611 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kandd,

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html
        /// Page 612 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kandnb,

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html
        /// Page 612 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kandnd,

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html
        /// Page 612 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kandnq,

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html
        /// Page 612 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kandnw,

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html
        /// Page 611 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kandq,

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html
        /// Page 611 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kandw,

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html
        /// Page 613 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kmovb,

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html
        /// Page 613 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kmovd,

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html
        /// Page 613 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kmovq,

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html
        /// Page 613 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kmovw,

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html
        /// Page 615 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        knotb,

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html
        /// Page 615 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        knotd,

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html
        /// Page 615 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        knotq,

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html
        /// Page 615 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        knotw,

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html
        /// Page 616 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        korb,

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html
        /// Page 616 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kord,

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html
        /// Page 616 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        korq,

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html
        /// Page 617 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kortestb,

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html
        /// Page 617 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kortestd,

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html
        /// Page 617 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kortestq,

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html
        /// Page 617 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kortestw,

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html
        /// Page 616 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        korw,

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html
        /// Page 619 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kshiftlb,

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html
        /// Page 619 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kshiftld,

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html
        /// Page 619 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kshiftlq,

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html
        /// Page 619 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kshiftlw,

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html
        /// Page 621 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kshiftrb,

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html
        /// Page 621 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kshiftrd,

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html
        /// Page 621 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kshiftrq,

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html
        /// Page 621 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kshiftrw,

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html
        /// Page 623 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ktestb,

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html
        /// Page 623 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ktestd,

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html
        /// Page 623 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ktestq,

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html
        /// Page 623 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ktestw,

        /// <summary>
        /// Unpack for Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KUNPCKBW:KUNPCKWD:KUNPCKDQ.html
        /// Page 625 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kunpckbw,

        /// <summary>
        /// Unpack for Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KUNPCKBW:KUNPCKWD:KUNPCKDQ.html
        /// Page 625 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kunpckdq,

        /// <summary>
        /// Unpack for Mask Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KUNPCKBW:KUNPCKWD:KUNPCKDQ.html
        /// Page 625 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kunpckwd,

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html
        /// Page 626 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kxnorb,

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html
        /// Page 626 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kxnord,

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html
        /// Page 626 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kxnorq,

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html
        /// Page 626 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kxnorw,

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html
        /// Page 627 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kxorb,

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html
        /// Page 627 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kxord,

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html
        /// Page 627 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kxorq,

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html
        /// Page 627 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        kxorw,

        /// <summary>
        /// Load Access Rights Byte.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LAR.html
        /// Page 629 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lar,

        /// <summary>
        /// Load Unaligned Integer 128 Bits.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LDDQU.html
        /// Page 632 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lddqu,

        /// <summary>
        /// Load MXCSR Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LDMXCSR.html
        /// Page 634 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ldmxcsr,

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html
        /// Page 635 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lds,

        /// <summary>
        /// Load Effective Address.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LEA.html
        /// Page 639 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lea,

        /// <summary>
        /// High Level Procedure Exit.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LEAVE.html
        /// Page 641 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        leave,

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html
        /// Page 635 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        les,

        /// <summary>
        /// Load Fence.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LFENCE.html
        /// Page 643 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lfence,

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html
        /// Page 635 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lfs,

        /// <summary>
        /// Load Global/Interrupt Descriptor Table Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LGDT:LIDT.html
        /// Page 644 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lgdt,

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html
        /// Page 635 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lgs,

        /// <summary>
        /// Load Global/Interrupt Descriptor Table Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LGDT:LIDT.html
        /// Page 644 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lidt,

        /// <summary>
        /// Load Local Descriptor Table Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LLDT.html
        /// Page 647 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lldt,

        /// <summary>
        /// Load Machine Status Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LMSW.html
        /// Page 649 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lmsw,

        /// <summary>
        /// Assert LOCK# Signal Prefix.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LOCK.html
        /// Page 651 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        @lock,

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html
        /// Page 653 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lods,

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html
        /// Page 653 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lodsb,

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html
        /// Page 653 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lodsd,

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html
        /// Page 653 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lodsq,

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html
        /// Page 653 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lodsw,

        /// <summary>
        /// Loop According to ECX Counter.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LOOP:LOOPcc.html
        /// Page 656 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        loop,

        /// <summary>
        /// Loop According to ECX Counter.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LOOP:LOOPcc.html
        /// Page 656 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        loope,

        /// <summary>
        /// Loop According to ECX Counter.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LOOP:LOOPcc.html
        /// Page 656 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        loopne,

        /// <summary>
        /// Load Segment Limit.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LSL.html
        /// Page 658 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lsl,

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html
        /// Page 635 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        lss,

        /// <summary>
        /// Load Task Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LTR.html
        /// Page 661 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ltr,

        /// <summary>
        /// Store Selected Bytes of Double Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MASKMOVDQU.html
        /// Page 672 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        maskmovdqu,

        /// <summary>
        /// Store Selected Bytes of Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MASKMOVQ.html
        /// Page 674 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        maskmovq,

        /// <summary>
        /// Maximum of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MAXPD.html
        /// Page 676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        maxpd,

        /// <summary>
        /// Maximum of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MAXPS.html
        /// Page 679 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        maxps,

        /// <summary>
        /// Return Maximum Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MAXSD.html
        /// Page 682 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        maxsd,

        /// <summary>
        /// Return Maximum Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MAXSS.html
        /// Page 684 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        maxss,

        /// <summary>
        /// Minimum of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MINPD.html
        /// Page 687 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        minpd,

        /// <summary>
        /// Minimum of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MINPS.html
        /// Page 690 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        minps,

        /// <summary>
        /// Return Minimum Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MINSD.html
        /// Page 693 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        minsd,

        /// <summary>
        /// Return Minimum Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MINSS.html
        /// Page 695 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        minss,

        /// <summary>
        /// Move.
        /// Move to/from Control Registers.
        /// Move to/from Debug Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOV.html
        /// https://www.felixcloutier.com/x86/MOV-1.html
        /// https://www.felixcloutier.com/x86/MOV-2.html
        /// Pages 699, 704, 707 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        mov,

        /// <summary>
        /// Move Aligned Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVAPD.html
        /// Page 709 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movapd,

        /// <summary>
        /// Move Aligned Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVAPS.html
        /// Page 713 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movaps,

        /// <summary>
        /// Move Doubleword/Move Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVD:MOVQ.html
        /// Page 719 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movd,

        /// <summary>
        /// Replicate Double FP Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDDUP.html
        /// Page 723 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movddup,

        /// <summary>
        /// Move Aligned Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDQA:VMOVDQA32:VMOVDQA64.html
        /// Page 730 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movdqa,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html
        /// Page 735 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movdqu,

        /// <summary>
        /// Move Packed Single-Precision Floating-Point Values High to Low.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVHLPS.html
        /// Page 744 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movhlps,

        /// <summary>
        /// Move High Packed Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVHPD.html
        /// Page 746 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movhpd,

        /// <summary>
        /// Move High Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVHPS.html
        /// Page 748 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movhps,

        /// <summary>
        /// Move Packed Single-Precision Floating-Point Values Low to High.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVLHPS.html
        /// Page 750 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movlhps,

        /// <summary>
        /// Move Low Packed Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVLPD.html
        /// Page 752 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movlpd,

        /// <summary>
        /// Move Low Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVLPS.html
        /// Page 754 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movlps,

        /// <summary>
        /// Extract Packed Double-Precision Floating-Point Sign Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVMSKPD.html
        /// Page 756 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movmskpd,

        /// <summary>
        /// Extract Packed Single-Precision Floating-Point Sign Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVMSKPS.html
        /// Page 758 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movmskps,

        /// <summary>
        /// Store Packed Integers Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVNTDQ.html
        /// Page 762 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movntdq,

        /// <summary>
        /// Load Double Quadword Non-Temporal Aligned Hint.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVNTDQA.html
        /// Page 760 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movntdqa,

        /// <summary>
        /// Store Doubleword Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVNTI.html
        /// Page 764 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movnti,

        /// <summary>
        /// Store Packed Double-Precision Floating-Point Values Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVNTPD.html
        /// Page 766 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movntpd,

        /// <summary>
        /// Store Packed Single-Precision Floating-Point Values Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVNTPS.html
        /// Page 768 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movntps,

        /// <summary>
        /// Store of Quadword Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVNTQ.html
        /// Page 770 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movntq,

        /// <summary>
        /// Move Doubleword/Move Quadword.
        /// Move Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVD:MOVQ.html
        /// https://www.felixcloutier.com/x86/MOVQ.html
        /// Pages 719, 771 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movq,

        /// <summary>
        /// Move Quadword from MMX Technology to XMM Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVQ2DQ.html
        /// Page 774 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movq2dq,

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html
        /// Page 775 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movs,

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html
        /// Page 775 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movsb,

        /// <summary>
        /// Move Data from String to String.
        /// Move or Merge Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html
        /// https://www.felixcloutier.com/x86/MOVSD.html
        /// Pages 775, 779 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movsd,

        /// <summary>
        /// Replicate Single FP Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVSHDUP.html
        /// Page 782 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movshdup,

        /// <summary>
        /// Replicate Single FP Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVSLDUP.html
        /// Page 785 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movsldup,

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html
        /// Page 775 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movsq,

        /// <summary>
        /// Move or Merge Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVSS.html
        /// Page 788 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movss,

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html
        /// Page 775 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movsw,

        /// <summary>
        /// Move with Sign-Extension.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVSX:MOVSXD.html
        /// Page 792 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movsx,

        /// <summary>
        /// Move with Sign-Extension.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVSX:MOVSXD.html
        /// Page 792 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movsxd,

        /// <summary>
        /// Move Unaligned Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVUPD.html
        /// Page 794 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movupd,

        /// <summary>
        /// Move Unaligned Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVUPS.html
        /// Page 798 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movups,

        /// <summary>
        /// Move with Zero-Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVZX.html
        /// Page 802 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        movzx,

        /// <summary>
        /// Compute Multiple Packed Sums of Absolute Difference.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MPSADBW.html
        /// Page 804 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        mpsadbw,

        /// <summary>
        /// Unsigned Multiply.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MUL.html
        /// Page 812 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        mul,

        /// <summary>
        /// Multiply Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MULPD.html
        /// Page 814 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        mulpd,

        /// <summary>
        /// Multiply Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MULPS.html
        /// Page 817 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        mulps,

        /// <summary>
        /// Multiply Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MULSD.html
        /// Page 820 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        mulsd,

        /// <summary>
        /// Multiply Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MULSS.html
        /// Page 822 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        mulss,

        /// <summary>
        /// Unsigned Multiply Without Affecting Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MULX.html
        /// Page 824 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        mulx,

        /// <summary>
        /// Monitor Wait.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MWAIT.html
        /// Page 826 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        mwait,

        /// <summary>
        /// Two's Complement Negation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/NEG.html
        /// Page 829 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        neg,

        /// <summary>
        /// No Operation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/NOP.html
        /// Page 831 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        nop,

        /// <summary>
        /// One's Complement Negation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/NOT.html
        /// Page 832 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        not,

        /// <summary>
        /// Logical Inclusive OR.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/OR.html
        /// Page 834 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        or,

        /// <summary>
        /// Bitwise Logical OR of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ORPD.html
        /// Page 836 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        orpd,

        /// <summary>
        /// Bitwise Logical OR of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ORPS.html
        /// Page 839 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        orps,

        /// <summary>
        /// Output to Port.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/OUT.html
        /// Page 842 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        @out,

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html
        /// Page 844 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        outs,

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html
        /// Page 844 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        outsb,

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html
        /// Page 844 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        outsd,

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html
        /// Page 844 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        outsw,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html
        /// Page 848 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pabsb,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html
        /// Page 848 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pabsd,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html
        /// Page 848 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pabsw,

        /// <summary>
        /// Pack with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PACKSSWB:PACKSSDW.html
        /// Page 854 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        packssdw,

        /// <summary>
        /// Pack with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PACKSSWB:PACKSSDW.html
        /// Page 854 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        packsswb,

        /// <summary>
        /// Pack with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PACKUSDW.html
        /// Page 862 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        packusdw,

        /// <summary>
        /// Pack with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PACKUSWB.html
        /// Page 867 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        packuswb,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html
        /// Page 872 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        paddb,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html
        /// Page 872 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        paddd,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html
        /// Page 872 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        paddq,

        /// <summary>
        /// Add Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDSB:PADDSW.html
        /// Page 879 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        paddsb,

        /// <summary>
        /// Add Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDSB:PADDSW.html
        /// Page 879 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        paddsw,

        /// <summary>
        /// Add Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDUSB:PADDUSW.html
        /// Page 883 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        paddusb,

        /// <summary>
        /// Add Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDUSB:PADDUSW.html
        /// Page 883 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        paddusw,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html
        /// Page 872 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        paddw,

        /// <summary>
        /// Packed Align Right.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PALIGNR.html
        /// Page 887 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        palignr,

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PAND.html
        /// Page 891 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pand,

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PANDN.html
        /// Page 894 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pandn,

        /// <summary>
        /// Spin Loop Hint.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PAUSE.html
        /// Page 897 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pause,

        /// <summary>
        /// Average Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PAVGB:PAVGW.html
        /// Page 898 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pavgb,

        /// <summary>
        /// Average Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PAVGB:PAVGW.html
        /// Page 898 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pavgw,

        /// <summary>
        /// Variable Blend Packed Bytes.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PBLENDVB.html
        /// Page 902 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pblendvb,

        /// <summary>
        /// Blend Packed Words.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PBLENDW.html
        /// Page 906 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pblendw,

        /// <summary>
        /// Carry-Less Multiplication Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCLMULQDQ.html
        /// Page 909 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pclmulqdq,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html
        /// Page 912 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpeqb,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html
        /// Page 912 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpeqd,

        /// <summary>
        /// Compare Packed Qword Data for Equal.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPEQQ.html
        /// Page 918 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpeqq,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html
        /// Page 912 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpeqw,

        /// <summary>
        /// Packed Compare Explicit Length Strings, Return Index.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPESTRI.html
        /// Page 921 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpestri,

        /// <summary>
        /// Packed Compare Explicit Length Strings, Return Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPESTRM.html
        /// Page 923 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpestrm,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html
        /// Page 925 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpgtb,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html
        /// Page 925 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpgtd,

        /// <summary>
        /// Compare Packed Data for Greater Than.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPGTQ.html
        /// Page 931 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpgtq,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html
        /// Page 925 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpgtw,

        /// <summary>
        /// Packed Compare Implicit Length Strings, Return Index.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPISTRI.html
        /// Page 934 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpistri,

        /// <summary>
        /// Packed Compare Implicit Length Strings, Return Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPISTRM.html
        /// Page 936 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pcmpistrm,

        /// <summary>
        /// Parallel Bits Deposit.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PDEP.html
        /// Page 938 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pdep,

        /// <summary>
        /// Parallel Bits Extract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PEXT.html
        /// Page 940 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pext,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html
        /// Page 942 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pextrb,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html
        /// Page 942 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pextrd,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html
        /// Page 942 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pextrq,

        /// <summary>
        /// Extract Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PEXTRW.html
        /// Page 945 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pextrw,

        /// <summary>
        /// Packed Horizontal Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHADDW:PHADDD.html
        /// Page 948 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        phaddd,

        /// <summary>
        /// Packed Horizontal Add and Saturate.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHADDSW.html
        /// Page 952 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        phaddsw,

        /// <summary>
        /// Packed Horizontal Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHADDW:PHADDD.html
        /// Page 948 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        phaddw,

        /// <summary>
        /// Packed Horizontal Word Minimum.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHMINPOSUW.html
        /// Page 954 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        phminposuw,

        /// <summary>
        /// Packed Horizontal Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHSUBW:PHSUBD.html
        /// Page 956 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        phsubd,

        /// <summary>
        /// Packed Horizontal Subtract and Saturate.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHSUBSW.html
        /// Page 959 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        phsubsw,

        /// <summary>
        /// Packed Horizontal Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHSUBW:PHSUBD.html
        /// Page 956 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        phsubw,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html
        /// Page 961 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pinsrb,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html
        /// Page 961 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pinsrd,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html
        /// Page 961 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pinsrq,

        /// <summary>
        /// Insert Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PINSRW.html
        /// Page 964 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pinsrw,

        /// <summary>
        /// Multiply and Add Packed Signed and Unsigned Bytes.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMADDUBSW.html
        /// Page 966 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmaddubsw,

        /// <summary>
        /// Multiply and Add Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMADDWD.html
        /// Page 969 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmaddwd,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html
        /// Page 972 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmaxsb,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html
        /// Page 972 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmaxsd,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html
        /// Page 972 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmaxsw,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXUB:PMAXUW.html
        /// Page 979 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmaxub,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXUD:PMAXUQ.html
        /// Page 984 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmaxud,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXUB:PMAXUW.html
        /// Page 979 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmaxuw,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINSB:PMINSW.html
        /// Page 988 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pminsb,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINSD:PMINSQ.html
        /// Page 993 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pminsd,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINSB:PMINSW.html
        /// Page 988 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pminsw,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINUB:PMINUW.html
        /// Page 997 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pminub,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINUD:PMINUQ.html
        /// Page 1002 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pminud,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINUB:PMINUW.html
        /// Page 997 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pminuw,

        /// <summary>
        /// Move Byte Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVMSKB.html
        /// Page 1006 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovmskb,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovsxbd,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovsxbq,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovsxbw,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovsxdq,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovsxwd,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovsxwq,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovzxbd,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovzxbq,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovzxbw,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovzxdq,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovzxwd,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmovzxwq,

        /// <summary>
        /// Multiply Packed Doubleword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULDQ.html
        /// Page 1026 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmuldq,

        /// <summary>
        /// Packed Multiply High with Round and Scale.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULHRSW.html
        /// Page 1029 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmulhrsw,

        /// <summary>
        /// Multiply Packed Unsigned Integers and Store High Result.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULHUW.html
        /// Page 1033 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmulhuw,

        /// <summary>
        /// Multiply Packed Signed Integers and Store High Result.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULHW.html
        /// Page 1037 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmulhw,

        /// <summary>
        /// Multiply Packed Integers and Store Low Result.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULLD:PMULLQ.html
        /// Page 1041 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmulld,

        /// <summary>
        /// Multiply Packed Signed Integers and Store Low Result.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULLW.html
        /// Page 1045 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmullw,

        /// <summary>
        /// Multiply Packed Unsigned Doubleword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULUDQ.html
        /// Page 1049 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pmuludq,

        /// <summary>
        /// Pop a Value from the Stack.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/POP.html
        /// Page 1052 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pop,

        /// <summary>
        /// Pop All General-Purpose Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/POPA:POPAD.html
        /// Page 1057 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        popa,

        /// <summary>
        /// Pop All General-Purpose Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/POPA:POPAD.html
        /// Page 1057 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        popad,

        /// <summary>
        /// Return the Count of Number of Bits Set to 1.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/POPCNT.html
        /// Page 1059 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        popcnt,

        /// <summary>
        /// Pop Stack into EFLAGS Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/POPF:POPFD:POPFQ.html
        /// Page 1061 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        popf,

        /// <summary>
        /// Pop Stack into EFLAGS Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/POPF:POPFD:POPFQ.html
        /// Page 1061 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        popfd,

        /// <summary>
        /// Pop Stack into EFLAGS Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/POPF:POPFD:POPFQ.html
        /// Page 1061 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        popfq,

        /// <summary>
        /// Bitwise Logical OR.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/POR.html
        /// Page 1065 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        por,

        /// <summary>
        /// Prefetch Data Into Caches.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PREFETCHh.html
        /// Page 1068 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        prefetchnta,

        /// <summary>
        /// Prefetch Data Into Caches.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PREFETCHh.html
        /// Page 1068 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        prefetcht0,

        /// <summary>
        /// Prefetch Data Into Caches.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PREFETCHh.html
        /// Page 1068 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        prefetcht1,

        /// <summary>
        /// Prefetch Data Into Caches.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PREFETCHh.html
        /// Page 1068 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        prefetcht2,

        /// <summary>
        /// Prefetch Data into Caches in Anticipation of a Write.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PREFETCHW.html
        /// Page 1070 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        prefetchw,

        /// <summary>
        /// Compute Sum of Absolute Differences.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSADBW.html
        /// Page 1072 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psadbw,

        /// <summary>
        /// Packed Shuffle Bytes.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSHUFB.html
        /// Page 1076 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pshufb,

        /// <summary>
        /// Shuffle Packed Doublewords.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSHUFD.html
        /// Page 1080 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pshufd,

        /// <summary>
        /// Shuffle Packed High Words.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSHUFHW.html
        /// Page 1084 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pshufhw,

        /// <summary>
        /// Shuffle Packed Low Words.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSHUFLW.html
        /// Page 1087 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pshuflw,

        /// <summary>
        /// Shuffle Packed Words.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSHUFW.html
        /// Page 1090 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pshufw,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html
        /// Page 1091 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psignb,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html
        /// Page 1091 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psignd,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html
        /// Page 1091 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psignw,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html
        /// Page 1097 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pslld,

        /// <summary>
        /// Shift Double Quadword Left Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSLLDQ.html
        /// Page 1095 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pslldq,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html
        /// Page 1097 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psllq,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html
        /// Page 1097 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psllw,

        /// <summary>
        /// Shift Packed Data Right Arithmetic.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRAW:PSRAD:PSRAQ.html
        /// Page 1109 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psrad,

        /// <summary>
        /// Shift Packed Data Right Arithmetic.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRAW:PSRAD:PSRAQ.html
        /// Page 1109 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psraw,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html
        /// Page 1121 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psrld,

        /// <summary>
        /// Shift Double Quadword Right Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRLDQ.html
        /// Page 1119 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psrldq,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html
        /// Page 1121 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psrlq,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html
        /// Page 1121 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psrlw,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html
        /// Page 1133 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psubb,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html
        /// Page 1133 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psubd,

        /// <summary>
        /// Subtract Packed Quadword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBQ.html
        /// Page 1140 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psubq,

        /// <summary>
        /// Subtract Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBSB:PSUBSW.html
        /// Page 1143 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psubsb,

        /// <summary>
        /// Subtract Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBSB:PSUBSW.html
        /// Page 1143 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psubsw,

        /// <summary>
        /// Subtract Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBUSB:PSUBUSW.html
        /// Page 1147 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psubusb,

        /// <summary>
        /// Subtract Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBUSB:PSUBUSW.html
        /// Page 1147 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psubusw,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html
        /// Page 1133 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        psubw,

        /// <summary>
        /// Logical Compare.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PTEST.html
        /// Page 1151 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ptest,

        /// <summary>
        /// Write Data to a Processor Trace Packet.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PTWRITE.html
        /// Page 1153 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ptwrite,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html
        /// Page 1155 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        punpckhbw,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html
        /// Page 1155 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        punpckhdq,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html
        /// Page 1155 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        punpckhqdq,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html
        /// Page 1155 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        punpckhwd,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html
        /// Page 1165 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        punpcklbw,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html
        /// Page 1165 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        punpckldq,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html
        /// Page 1165 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        punpcklqdq,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html
        /// Page 1165 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        punpcklwd,

        /// <summary>
        /// Push Word, Doubleword or Quadword Onto the Stack.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUSH.html
        /// Page 1175 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        push,

        /// <summary>
        /// Push All General-Purpose Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUSHA:PUSHAD.html
        /// Page 1178 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pusha,

        /// <summary>
        /// Push All General-Purpose Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUSHA:PUSHAD.html
        /// Page 1178 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pushad,

        /// <summary>
        /// Push EFLAGS Register onto the Stack.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUSHF:PUSHFD:PUSHFQ.html
        /// Page 1180 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pushf,

        /// <summary>
        /// Push EFLAGS Register onto the Stack.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUSHF:PUSHFD:PUSHFQ.html
        /// Page 1180 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pushfd,

        /// <summary>
        /// Push EFLAGS Register onto the Stack.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUSHF:PUSHFD:PUSHFQ.html
        /// Page 1180 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        pushfq,

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html
        /// Page 1185 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rcl,

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html
        /// Page 1185 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rcr,

        /// <summary>
        /// Read FS/GS Segment Base.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RDFSBASE:RDGSBASE.html
        /// Page 1194 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rdfsbase,

        /// <summary>
        /// Read FS/GS Segment Base.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RDFSBASE:RDGSBASE.html
        /// Page 1194 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rdgsbase,

        /// <summary>
        /// Read Processor ID.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RDPID.html
        /// Page 1198 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rdpid,

        /// <summary>
        /// Read Protection Key Rights for User Pages.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RDPKRU.html
        /// Page 1199 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rdpkru,

        /// <summary>
        /// Read Performance-Monitoring Counters.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RDPMC.html
        /// Page 1201 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rdpmc,

        /// <summary>
        /// Read Random SEED.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RDSEED.html
        /// Page 1205 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rdseed,

        /// <summary>
        /// Read Time-Stamp Counter.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RDTSC.html
        /// Page 1207 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rdtsc,

        /// <summary>
        /// Read Time-Stamp Counter and Processor ID.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RDTSCP.html
        /// Page 1209 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rdtscp,

        /// <summary>
        /// Repeat String Operation Prefix.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/REP:REPE:REPZ:REPNE:REPNZ.html
        /// Page 1211 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rep,

        /// <summary>
        /// Repeat String Operation Prefix.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/REP:REPE:REPZ:REPNE:REPNZ.html
        /// Page 1211 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        repe,

        /// <summary>
        /// Repeat String Operation Prefix.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/REP:REPE:REPZ:REPNE:REPNZ.html
        /// Page 1211 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        repne,

        /// <summary>
        /// Return from Procedure.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RET.html
        /// Page 1215 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ret,

        /// <summary>
        /// Return from Procedure.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RET.html
        /// Page 1215 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        retf,

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html
        /// Page 1185 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rol,

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html
        /// Page 1185 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ror,

        /// <summary>
        /// Rotate Right Logical Without Affecting Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RORX.html
        /// Page 1225 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rorx,

        /// <summary>
        /// Resume from System Management Mode.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/RSM.html
        /// Page 1236 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        rsm,

        /// <summary>
        /// Store AH into Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SAHF.html
        /// Page 1242 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sahf,

        /// <summary>
        /// Shift.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SAL:SAR:SHL:SHR.html
        /// Page 1244 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sal,

        /// <summary>
        /// Shift.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SAL:SAR:SHL:SHR.html
        /// Page 1244 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sar,

        /// <summary>
        /// Shift Without Affecting Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SARX:SHLX:SHRX.html
        /// Page 1249 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sarx,

        /// <summary>
        /// Integer Subtraction with Borrow.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SBB.html
        /// Page 1251 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sbb,

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html
        /// Page 1254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        scas,

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html
        /// Page 1254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        scasb,

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html
        /// Page 1254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        scasd,

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html
        /// Page 1254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        scasq,

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html
        /// Page 1254 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        scasw,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        seta,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setae,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setb,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setbe,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setc,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sete,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setg,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setge,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setl,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setle,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setna,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setnae,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setnb,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setnbe,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setnc,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setne,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setng,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setnge,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setnl,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setnle,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setno,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setnp,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setns,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setnz,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        seto,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setp,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setpe,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setpo,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sets,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SETcc.html
        /// Page 1258 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        setz,

        /// <summary>
        /// Store Fence.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SFENCE.html
        /// Page 1261 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sfence,

        /// <summary>
        /// Perform an Intermediate Calculation for the Next Four SHA1 Message Dwords.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHA1MSG1.html
        /// Page 1267 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sha1msg1,

        /// <summary>
        /// Perform a Final Calculation for the Next Four SHA1 Message Dwords.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHA1MSG2.html
        /// Page 1268 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sha1msg2,

        /// <summary>
        /// Calculate SHA1 State Variable E after Four Rounds.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHA1NEXTE.html
        /// Page 1266 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sha1nexte,

        /// <summary>
        /// Perform Four Rounds of SHA1 Operation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHA1RNDS4.html
        /// Page 1264 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sha1rnds4,

        /// <summary>
        /// Perform an Intermediate Calculation for the Next Four SHA256 Message Dwords.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHA256MSG1.html
        /// Page 1271 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sha256msg1,

        /// <summary>
        /// Perform a Final Calculation for the Next Four SHA256 Message Dwords.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHA256MSG2.html
        /// Page 1272 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sha256msg2,

        /// <summary>
        /// Perform Two Rounds of SHA256 Operation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHA256RNDS2.html
        /// Page 1269 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sha256rnds2,

        /// <summary>
        /// Shift.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SAL:SAR:SHL:SHR.html
        /// Page 1244 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        shl,

        /// <summary>
        /// Double Precision Shift Left.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHLD.html
        /// Page 1273 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        shld,

        /// <summary>
        /// Shift Without Affecting Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SARX:SHLX:SHRX.html
        /// Page 1249 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        shlx,

        /// <summary>
        /// Double Precision Shift Right.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHRD.html
        /// Page 1276 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        shrd,

        /// <summary>
        /// Shift Without Affecting Flags.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SARX:SHLX:SHRX.html
        /// Page 1249 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        shrx,

        /// <summary>
        /// Packed Interleave Shuffle of Pairs of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHUFPD.html
        /// Page 1279 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        shufpd,

        /// <summary>
        /// Packed Interleave Shuffle of Quadruplets of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHUFPS.html
        /// Page 1284 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        shufps,

        /// <summary>
        /// Store Interrupt Descriptor Table Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SIDT.html
        /// Page 1288 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sidt,

        /// <summary>
        /// Store Local Descriptor Table Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SLDT.html
        /// Page 1290 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sldt,

        /// <summary>
        /// Store Machine Status Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SMSW.html
        /// Page 1292 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        smsw,

        /// <summary>
        /// Square Root of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SQRTPD.html
        /// Page 1294 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sqrtpd,

        /// <summary>
        /// Square Root of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SQRTPS.html
        /// Page 1297 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sqrtps,

        /// <summary>
        /// Compute Square Root of Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SQRTSD.html
        /// Page 1300 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sqrtsd,

        /// <summary>
        /// Compute Square Root of Scalar Single-Precision Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SQRTSS.html
        /// Page 1302 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sqrtss,

        /// <summary>
        /// Set AC Flag in EFLAGS Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/STAC.html
        /// Page 1304 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        stac,

        /// <summary>
        /// Set Carry Flag.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/STC.html
        /// Page 1305 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        stc,

        /// <summary>
        /// Set Direction Flag.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/STD.html
        /// Page 1306 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        std,

        /// <summary>
        /// Set Interrupt Flag.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/STI.html
        /// Page 1307 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sti,

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html
        /// Page 1310 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        stos,

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html
        /// Page 1310 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        stosb,

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html
        /// Page 1310 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        stosd,

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html
        /// Page 1310 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        stosq,

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html
        /// Page 1310 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        stosw,

        /// <summary>
        /// Store Task Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/STR.html
        /// Page 1314 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        str,

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SUB.html
        /// Page 1316 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sub,

        /// <summary>
        /// Subtract Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SUBPD.html
        /// Page 1318 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        subpd,

        /// <summary>
        /// Subtract Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SUBPS.html
        /// Page 1321 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        subps,

        /// <summary>
        /// Subtract Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SUBSD.html
        /// Page 1324 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        subsd,

        /// <summary>
        /// Subtract Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SUBSS.html
        /// Page 1326 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        subss,

        /// <summary>
        /// Swap GS Base Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SWAPGS.html
        /// Page 1328 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        swapgs,

        /// <summary>
        /// Fast System Call.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SYSCALL.html
        /// Page 1330 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        syscall,

        /// <summary>
        /// Fast System Call.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SYSENTER.html
        /// Page 1332 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sysenter,

        /// <summary>
        /// Fast Return from Fast System Call.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SYSEXIT.html
        /// Page 1335 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sysexit,

        /// <summary>
        /// Return From Fast System Call.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SYSRET.html
        /// Page 1338 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        sysret,

        /// <summary>
        /// Logical Compare.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/TEST.html
        /// Page 1341 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        test,

        /// <summary>
        /// Count the Number of Trailing Zero Bits.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/TZCNT.html
        /// Page 1345 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        tzcnt,

        /// <summary>
        /// Unordered Compare Scalar Double-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UCOMISD.html
        /// Page 1347 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ucomisd,

        /// <summary>
        /// Unordered Compare Scalar Single-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UCOMISS.html
        /// Page 1349 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ucomiss,

        /// <summary>
        /// Undefined Instruction.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UD.html
        /// Page 1351 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ud01,

        /// <summary>
        /// Undefined Instruction.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UD.html
        /// Page 1351 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ud1,

        /// <summary>
        /// Undefined Instruction.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UD.html
        /// Page 1351 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        ud2,

        /// <summary>
        /// Unpack and Interleave High Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UNPCKHPD.html
        /// Page 1356 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        unpckhpd,

        /// <summary>
        /// Unpack and Interleave High Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UNPCKHPS.html
        /// Page 1360 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        unpckhps,

        /// <summary>
        /// Unpack and Interleave Low Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UNPCKLPD.html
        /// Page 1364 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        unpcklpd,

        /// <summary>
        /// Unpack and Interleave Low Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UNPCKLPS.html
        /// Page 1368 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        unpcklps,

        /// <summary>
        /// Add Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDPD.html
        /// Page 135 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaddpd,

        /// <summary>
        /// Add Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDPS.html
        /// Page 138 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaddps,

        /// <summary>
        /// Add Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDSD.html
        /// Page 141 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaddsd,

        /// <summary>
        /// Add Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDSS.html
        /// Page 143 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaddss,

        /// <summary>
        /// Packed Double-FP Add/Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDSUBPD.html
        /// Page 145 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaddsubpd,

        /// <summary>
        /// Packed Single-FP Add/Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ADDSUBPS.html
        /// Page 147 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaddsubps,

        /// <summary>
        /// Perform One Round of an AES Decryption Flow.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESDEC.html
        /// Page 152 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaesdec,

        /// <summary>
        /// Perform Last Round of an AES Decryption Flow.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESDECLAST.html
        /// Page 154 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaesdeclast,

        /// <summary>
        /// Perform One Round of an AES Encryption Flow.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESENC.html
        /// Page 156 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaesenc,

        /// <summary>
        /// Perform Last Round of an AES Encryption Flow.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESENCLAST.html
        /// Page 158 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaesenclast,

        /// <summary>
        /// Perform the AES InvMixColumn Transformation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESIMC.html
        /// Page 160 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaesimc,

        /// <summary>
        /// AES Round Key Generation Assist.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/AESKEYGENASSIST.html
        /// Page 161 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vaeskeygenassist,

        /// <summary>
        /// Align Doubleword/Quadword Vectors.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VALIGND:VALIGNQ.html
        /// Page 1377 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        valignd,

        /// <summary>
        /// Align Doubleword/Quadword Vectors.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VALIGND:VALIGNQ.html
        /// Page 1377 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        valignq,

        /// <summary>
        /// Bitwise Logical AND NOT of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ANDNPD.html
        /// Page 172 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vandnpd,

        /// <summary>
        /// Bitwise Logical AND NOT of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ANDNPS.html
        /// Page 175 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vandnps,

        /// <summary>
        /// Bitwise Logical AND of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ANDPD.html
        /// Page 166 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vandpd,

        /// <summary>
        /// Bitwise Logical AND of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ANDPS.html
        /// Page 169 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vandps,

        /// <summary>
        /// Blend Float64/Float32 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VBLENDMPD:VBLENDMPS.html
        /// Page 1381 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vblendmpd,

        /// <summary>
        /// Blend Float64/Float32 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VBLENDMPD:VBLENDMPS.html
        /// Page 1381 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vblendmps,

        /// <summary>
        /// Blend Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BLENDPD.html
        /// Page 181 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vblendpd,

        /// <summary>
        /// Blend Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BLENDPS.html
        /// Page 183 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vblendps,

        /// <summary>
        /// Variable Blend Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BLENDVPD.html
        /// Page 185 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vblendvpd,

        /// <summary>
        /// Variable Blend Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/BLENDVPS.html
        /// Page 187 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vblendvps,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VBROADCAST.html
        /// Page 1384 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcastf128,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VBROADCAST.html
        /// Page 1384 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcastf32x2,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VBROADCAST.html
        /// Page 1384 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcastf32x4,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VBROADCAST.html
        /// Page 1384 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcastf32x8,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VBROADCAST.html
        /// Page 1384 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcastf64x2,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VBROADCAST.html
        /// Page 1384 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcastf64x4,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// Page 1676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcasti128,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// Page 1676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcasti32x2,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// Page 1676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcasti32x4,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// Page 1676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcasti32x8,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// Page 1676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcasti64x2,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// Page 1676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcasti64x4,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VBROADCAST.html
        /// Page 1384 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcastsd,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VBROADCAST.html
        /// Page 1384 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vbroadcastss,

        /// <summary>
        /// Compare Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPPD.html
        /// Page 260 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcmppd,

        /// <summary>
        /// Compare Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPPS.html
        /// Page 267 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcmpps,

        /// <summary>
        /// Compare Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPSD.html
        /// Page 278 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcmpsd,

        /// <summary>
        /// Compare Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPSS.html
        /// Page 282 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcmpss,

        /// <summary>
        /// Compare Scalar Ordered Double-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/COMISD.html
        /// Page 291 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcomisd,

        /// <summary>
        /// Compare Scalar Ordered Single-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/COMISS.html
        /// Page 293 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcomiss,

        /// <summary>
        /// Store Sparse Packed Double-Precision Floating-Point Values into Dense Memory.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCOMPRESSPD.html
        /// Page 1392 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcompresspd,

        /// <summary>
        /// Store Sparse Packed Single-Precision Floating-Point Values into Dense Memory.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCOMPRESSPS.html
        /// Page 1394 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcompressps,

        /// <summary>
        /// Convert Packed Doubleword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTDQ2PD.html
        /// Page 337 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtdq2pd,

        /// <summary>
        /// Convert Packed Doubleword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTDQ2PS.html
        /// Page 341 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtdq2ps,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Doubleword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPD2DQ.html
        /// Page 344 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtpd2dq,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPD2PS.html
        /// Page 349 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtpd2ps,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Quadword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTPD2QQ.html
        /// Page 1396 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtpd2qq,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Unsigned Doubleword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTPD2UDQ.html
        /// Page 1399 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtpd2udq,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Unsigned Quadword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTPD2UQQ.html
        /// Page 1402 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtpd2uqq,

        /// <summary>
        /// Convert 16-bit FP values to Single-Precision FP values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTPH2PS.html
        /// Page 1405 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtph2ps,

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPS2DQ.html
        /// Page 355 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtps2dq,

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTPS2PD.html
        /// Page 358 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtps2pd,

        /// <summary>
        /// Convert Single-Precision FP value to 16-bit FP value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTPS2PH.html
        /// Page 1408 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtps2ph,

        /// <summary>
        /// Convert Packed Single Precision Floating-Point Values to Packed Singed Quadword Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTPS2QQ.html
        /// Page 1415 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtps2qq,

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Unsigned Doubleword Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTPS2UDQ.html
        /// Page 1412 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtps2udq,

        /// <summary>
        /// Convert Packed Single Precision Floating-Point Values to Packed Unsigned Quadword Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTPS2UQQ.html
        /// Page 1418 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtps2uqq,

        /// <summary>
        /// Convert Packed Quadword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTQQ2PD.html
        /// Page 1421 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtqq2pd,

        /// <summary>
        /// Convert Packed Quadword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTQQ2PS.html
        /// Page 1423 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtqq2ps,

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Doubleword Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSD2SI.html
        /// Page 362 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtsd2si,

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSD2SS.html
        /// Page 364 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtsd2ss,

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Unsigned Doubleword Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTSD2USI.html
        /// Page 1425 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtsd2usi,

        /// <summary>
        /// Convert Doubleword Integer to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSI2SD.html
        /// Page 366 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtsi2sd,

        /// <summary>
        /// Convert Doubleword Integer to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSI2SS.html
        /// Page 368 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtsi2ss,

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSS2SD.html
        /// Page 370 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtss2sd,

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Doubleword Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTSS2SI.html
        /// Page 372 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtss2si,

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Unsigned Doubleword Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTSS2USI.html
        /// Page 1426 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtss2usi,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Doubleword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTTPD2DQ.html
        /// Page 374 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttpd2dq,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Quadword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTTPD2QQ.html
        /// Page 1428 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttpd2qq,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Unsigned Doubleword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTTPD2UDQ.html
        /// Page 1430 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttpd2udq,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Unsigned Quadword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTTPD2UQQ.html
        /// Page 1433 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttpd2uqq,

        /// <summary>
        /// Convert with Truncation Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTTPS2DQ.html
        /// Page 379 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttps2dq,

        /// <summary>
        /// Convert with Truncation Packed Single Precision Floating-Point Values to Packed Singed Quadword Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTTPS2QQ.html
        /// Page 1437 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttps2qq,

        /// <summary>
        /// Convert with Truncation Packed Single-Precision Floating-Point Values to Packed Unsigned Doubleword Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTTPS2UDQ.html
        /// Page 1435 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttps2udq,

        /// <summary>
        /// Convert with Truncation Packed Single Precision Floating-Point Values to Packed Unsigned Quadword Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTTPS2UQQ.html
        /// Page 1439 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttps2uqq,

        /// <summary>
        /// Convert with Truncation Scalar Double-Precision Floating-Point Value to Signed Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTTSD2SI.html
        /// Page 383 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttsd2si,

        /// <summary>
        /// Convert with Truncation Scalar Double-Precision Floating-Point Value to Unsigned Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTTSD2USI.html
        /// Page 1441 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttsd2usi,

        /// <summary>
        /// Convert with Truncation Scalar Single-Precision Floating-Point Value to Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CVTTSS2SI.html
        /// Page 385 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttss2si,

        /// <summary>
        /// Convert with Truncation Scalar Single-Precision Floating-Point Value to Unsigned Integer.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTTSS2USI.html
        /// Page 1442 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvttss2usi,

        /// <summary>
        /// Convert Packed Unsigned Doubleword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTUDQ2PD.html
        /// Page 1444 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtudq2pd,

        /// <summary>
        /// Convert Packed Unsigned Doubleword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTUDQ2PS.html
        /// Page 1446 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtudq2ps,

        /// <summary>
        /// Convert Packed Unsigned Quadword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTUQQ2PD.html
        /// Page 1448 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtuqq2pd,

        /// <summary>
        /// Convert Packed Unsigned Quadword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTUQQ2PS.html
        /// Page 1450 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtuqq2ps,

        /// <summary>
        /// Convert Unsigned Integer to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTUSI2SD.html
        /// Page 1452 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtusi2sd,

        /// <summary>
        /// Convert Unsigned Integer to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VCVTUSI2SS.html
        /// Page 1454 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vcvtusi2ss,

        /// <summary>
        /// Double Block Packed Sum-Absolute-Differences (SAD) on Unsigned Bytes.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VDBPSADBW.html
        /// Page 1456 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vdbpsadbw,

        /// <summary>
        /// Divide Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DIVPD.html
        /// Page 397 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vdivpd,

        /// <summary>
        /// Divide Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DIVPS.html
        /// Page 400 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vdivps,

        /// <summary>
        /// Divide Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DIVSD.html
        /// Page 403 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vdivsd,

        /// <summary>
        /// Divide Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DIVSS.html
        /// Page 405 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vdivss,

        /// <summary>
        /// Dot Product of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DPPD.html
        /// Page 407 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vdppd,

        /// <summary>
        /// Dot Product of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/DPPS.html
        /// Page 409 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vdpps,

        /// <summary>
        /// Verify a Segment for Reading or Writing.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VERR:VERW.html
        /// Page 1464 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        verr,

        /// <summary>
        /// Verify a Segment for Reading or Writing.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VERR:VERW.html
        /// Page 1464 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        verw,

        /// <summary>
        /// Load Sparse Packed Double-Precision Floating-Point Values from Dense Memory.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXPANDPD.html
        /// Page 1460 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vexpandpd,

        /// <summary>
        /// Load Sparse Packed Single-Precision Floating-Point Values from Dense Memory.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXPANDPS.html
        /// Page 1462 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vexpandps,

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html
        /// Page 1466 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vextractf128,

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html
        /// Page 1466 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vextractf32x4,

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html
        /// Page 1466 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vextractf32x8,

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html
        /// Page 1466 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vextractf64x2,

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html
        /// Page 1466 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vextractf64x4,

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html
        /// Page 1472 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vextracti128,

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html
        /// Page 1472 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vextracti32x4,

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html
        /// Page 1472 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vextracti32x8,

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html
        /// Page 1472 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vextracti64x2,

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html
        /// Page 1472 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vextracti64x4,

        /// <summary>
        /// Extract Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/EXTRACTPS.html
        /// Page 416 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vextractps,

        /// <summary>
        /// Fix Up Special Packed Float64 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFIXUPIMMPD.html
        /// Page 1478 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfixupimmpd,

        /// <summary>
        /// Fix Up Special Packed Float32 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFIXUPIMMPS.html
        /// Page 1482 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfixupimmps,

        /// <summary>
        /// Fix Up Special Scalar Float64 Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFIXUPIMMSD.html
        /// Page 1486 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfixupimmsd,

        /// <summary>
        /// Fix Up Special Scalar Float32 Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFIXUPIMMSS.html
        /// Page 1489 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfixupimmss,

        /// <summary>
        /// Fused Multiply-Add of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132PD:VFMADD213PD:VFMADD231PD.html
        /// Page 1492 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd132pd,

        /// <summary>
        /// Fused Multiply-Add of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132PS:VFMADD213PS:VFMADD231PS.html
        /// Page 1499 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd132ps,

        /// <summary>
        /// Fused Multiply-Add of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132SD:VFMADD213SD:VFMADD231SD.html
        /// Page 1506 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd132sd,

        /// <summary>
        /// Fused Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132SS:VFMADD213SS:VFMADD231SS.html
        /// Page 1509 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd132ss,

        /// <summary>
        /// Fused Multiply-Add of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132PD:VFMADD213PD:VFMADD231PD.html
        /// Page 1492 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd213pd,

        /// <summary>
        /// Fused Multiply-Add of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132PS:VFMADD213PS:VFMADD231PS.html
        /// Page 1499 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd213ps,

        /// <summary>
        /// Fused Multiply-Add of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132SD:VFMADD213SD:VFMADD231SD.html
        /// Page 1506 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd213sd,

        /// <summary>
        /// Fused Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132SS:VFMADD213SS:VFMADD231SS.html
        /// Page 1509 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd213ss,

        /// <summary>
        /// Fused Multiply-Add of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132PD:VFMADD213PD:VFMADD231PD.html
        /// Page 1492 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd231pd,

        /// <summary>
        /// Fused Multiply-Add of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132PS:VFMADD213PS:VFMADD231PS.html
        /// Page 1499 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd231ps,

        /// <summary>
        /// Fused Multiply-Add of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132SD:VFMADD213SD:VFMADD231SD.html
        /// Page 1506 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd231sd,

        /// <summary>
        /// Fused Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADD132SS:VFMADD213SS:VFMADD231SS.html
        /// Page 1509 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmadd231ss,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADDSUB132PD:VFMADDSUB213PD:VFMADDSUB231PD.html
        /// Page 1512 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmaddsub132pd,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADDSUB132PS:VFMADDSUB213PS:VFMADDSUB231PS.html
        /// Page 1522 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmaddsub132ps,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADDSUB132PD:VFMADDSUB213PD:VFMADDSUB231PD.html
        /// Page 1512 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmaddsub213pd,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADDSUB132PS:VFMADDSUB213PS:VFMADDSUB231PS.html
        /// Page 1522 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmaddsub213ps,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADDSUB132PD:VFMADDSUB213PD:VFMADDSUB231PD.html
        /// Page 1512 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmaddsub231pd,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMADDSUB132PS:VFMADDSUB213PS:VFMADDSUB231PS.html
        /// Page 1522 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmaddsub231ps,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132PD:VFMSUB213PD:VFMSUB231PD.html
        /// Page 1551 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub132pd,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132PS:VFMSUB213PS:VFMSUB231PS.html
        /// Page 1558 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub132ps,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132SD:VFMSUB213SD:VFMSUB231SD.html
        /// Page 1565 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub132sd,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132SS:VFMSUB213SS:VFMSUB231SS.html
        /// Page 1568 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub132ss,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132PD:VFMSUB213PD:VFMSUB231PD.html
        /// Page 1551 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub213pd,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132PS:VFMSUB213PS:VFMSUB231PS.html
        /// Page 1558 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub213ps,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132SD:VFMSUB213SD:VFMSUB231SD.html
        /// Page 1565 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub213sd,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132SS:VFMSUB213SS:VFMSUB231SS.html
        /// Page 1568 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub213ss,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132PD:VFMSUB213PD:VFMSUB231PD.html
        /// Page 1551 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub231pd,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132PS:VFMSUB213PS:VFMSUB231PS.html
        /// Page 1558 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub231ps,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132SD:VFMSUB213SD:VFMSUB231SD.html
        /// Page 1565 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub231sd,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUB132SS:VFMSUB213SS:VFMSUB231SS.html
        /// Page 1568 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsub231ss,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUBADD132PD:VFMSUBADD213PD:VFMSUBADD231PD.html
        /// Page 1531 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsubadd132pd,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUBADD132PS:VFMSUBADD213PS:VFMSUBADD231PS.html
        /// Page 1541 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsubadd132ps,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUBADD132PD:VFMSUBADD213PD:VFMSUBADD231PD.html
        /// Page 1531 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsubadd213pd,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUBADD132PS:VFMSUBADD213PS:VFMSUBADD231PS.html
        /// Page 1541 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsubadd213ps,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUBADD132PD:VFMSUBADD213PD:VFMSUBADD231PD.html
        /// Page 1531 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsubadd231pd,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFMSUBADD132PS:VFMSUBADD213PS:VFMSUBADD231PS.html
        /// Page 1541 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfmsubadd231ps,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132PD:VFNMADD213PD:VFNMADD231PD.html
        /// Page 1571 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd132pd,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132PS:VFNMADD213PS:VFNMADD231PS.html
        /// Page 1578 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd132ps,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132SD:VFNMADD213SD:VFNMADD231SD.html
        /// Page 1584 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd132sd,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132SS:VFNMADD213SS:VFNMADD231SS.html
        /// Page 1587 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd132ss,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132PD:VFNMADD213PD:VFNMADD231PD.html
        /// Page 1571 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd213pd,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132PS:VFNMADD213PS:VFNMADD231PS.html
        /// Page 1578 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd213ps,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132SD:VFNMADD213SD:VFNMADD231SD.html
        /// Page 1584 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd213sd,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132SS:VFNMADD213SS:VFNMADD231SS.html
        /// Page 1587 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd213ss,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132PD:VFNMADD213PD:VFNMADD231PD.html
        /// Page 1571 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd231pd,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132PS:VFNMADD213PS:VFNMADD231PS.html
        /// Page 1578 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd231ps,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132SD:VFNMADD213SD:VFNMADD231SD.html
        /// Page 1584 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd231sd,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMADD132SS:VFNMADD213SS:VFNMADD231SS.html
        /// Page 1587 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmadd231ss,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132PD:VFNMSUB213PD:VFNMSUB231PD.html
        /// Page 1590 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub132pd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132PS:VFNMSUB213PS:VFNMSUB231PS.html
        /// Page 1596 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub132ps,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132SD:VFNMSUB213SD:VFNMSUB231SD.html
        /// Page 1602 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub132sd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132SS:VFNMSUB213SS:VFNMSUB231SS.html
        /// Page 1605 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub132ss,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132PD:VFNMSUB213PD:VFNMSUB231PD.html
        /// Page 1590 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub213pd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132PS:VFNMSUB213PS:VFNMSUB231PS.html
        /// Page 1596 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub213ps,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132SD:VFNMSUB213SD:VFNMSUB231SD.html
        /// Page 1602 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub213sd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132SS:VFNMSUB213SS:VFNMSUB231SS.html
        /// Page 1605 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub213ss,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132PD:VFNMSUB213PD:VFNMSUB231PD.html
        /// Page 1590 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub231pd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132PS:VFNMSUB213PS:VFNMSUB231PS.html
        /// Page 1596 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub231ps,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132SD:VFNMSUB213SD:VFNMSUB231SD.html
        /// Page 1602 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub231sd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFNMSUB132SS:VFNMSUB213SS:VFNMSUB231SS.html
        /// Page 1605 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfnmsub231ss,

        /// <summary>
        /// Tests Types Of a Packed Float64 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFPCLASSPD.html
        /// Page 1608 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfpclasspd,

        /// <summary>
        /// Tests Types Of a Packed Float32 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFPCLASSPS.html
        /// Page 1611 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfpclassps,

        /// <summary>
        /// Tests Types Of a Scalar Float64 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFPCLASSSD.html
        /// Page 1613 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfpclasssd,

        /// <summary>
        /// Tests Types Of a Scalar Float32 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VFPCLASSSS.html
        /// Page 1615 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vfpclassss,

        /// <summary>
        /// Gather Packed DP FP Values Using Signed Dword/Qword Indices.
        /// Gather Packed Single, Packed Double with Signed Dword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGATHERDPD:VGATHERQPD.html
        /// https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERDPD.html
        /// Pages 1617, 1627 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgatherdpd,

        /// <summary>
        /// Gather Packed SP FP values Using Signed Dword/Qword Indices.
        /// Gather Packed Single, Packed Double with Signed Dword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERQPS.html
        /// https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERDPD.html
        /// Pages 1622, 1627 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgatherdps,

        /// <summary>
        /// Gather Packed DP FP Values Using Signed Dword/Qword Indices.
        /// Gather Packed Single, Packed Double with Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGATHERDPD:VGATHERQPD.html
        /// https://www.felixcloutier.com/x86/VGATHERQPS:VGATHERQPD.html
        /// Pages 1617, 1630 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgatherqpd,

        /// <summary>
        /// Gather Packed SP FP values Using Signed Dword/Qword Indices.
        /// Gather Packed Single, Packed Double with Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERQPS.html
        /// https://www.felixcloutier.com/x86/VGATHERQPS:VGATHERQPD.html
        /// Pages 1622, 1630 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgatherqps,

        /// <summary>
        /// Convert Exponents of Packed DP FP Values to DP FP Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGETEXPPD.html
        /// Page 1633 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgetexppd,

        /// <summary>
        /// Convert Exponents of Packed SP FP Values to SP FP Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGETEXPPS.html
        /// Page 1636 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgetexpps,

        /// <summary>
        /// Convert Exponents of Scalar DP FP Values to DP FP Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGETEXPSD.html
        /// Page 1640 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgetexpsd,

        /// <summary>
        /// Convert Exponents of Scalar SP FP Values to SP FP Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGETEXPSS.html
        /// Page 1642 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgetexpss,

        /// <summary>
        /// Extract Float64 Vector of Normalized Mantissas from Float64 Vector.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGETMANTPD.html
        /// Page 1644 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgetmantpd,

        /// <summary>
        /// Extract Float32 Vector of Normalized Mantissas from Float32 Vector.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGETMANTPS.html
        /// Page 1648 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgetmantps,

        /// <summary>
        /// Extract Float64 of Normalized Mantissas from Float64 Scalar.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGETMANTSD.html
        /// Page 1651 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgetmantsd,

        /// <summary>
        /// Extract Float32 Vector of Normalized Mantissa from Float32 Vector.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGETMANTSS.html
        /// Page 1653 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vgetmantss,

        /// <summary>
        /// Packed Double-FP Horizontal Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/HADDPD.html
        /// Page 540 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vhaddpd,

        /// <summary>
        /// Packed Single-FP Horizontal Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/HADDPS.html
        /// Page 543 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vhaddps,

        /// <summary>
        /// Packed Double-FP Horizontal Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/HSUBPD.html
        /// Page 547 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vhsubpd,

        /// <summary>
        /// Packed Single-FP Horizontal Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/HSUBPS.html
        /// Page 550 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vhsubps,

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html
        /// Page 1655 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vinsertf128,

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html
        /// Page 1655 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vinsertf32x4,

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html
        /// Page 1655 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vinsertf32x8,

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html
        /// Page 1655 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vinsertf64x2,

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html
        /// Page 1655 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vinsertf64x4,

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html
        /// Page 1659 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vinserti128,

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html
        /// Page 1659 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vinserti32x4,

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html
        /// Page 1659 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vinserti32x8,

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html
        /// Page 1659 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vinserti64x2,

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html
        /// Page 1659 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vinserti64x4,

        /// <summary>
        /// Insert Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/INSERTPS.html
        /// Page 567 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vinsertps,

        /// <summary>
        /// Load Unaligned Integer 128 Bits.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LDDQU.html
        /// Page 632 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vlddqu,

        /// <summary>
        /// Load MXCSR Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/LDMXCSR.html
        /// Page 634 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vldmxcsr,

        /// <summary>
        /// Store Selected Bytes of Double Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MASKMOVDQU.html
        /// Page 672 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmaskmovdqu,

        /// <summary>
        /// Conditional SIMD Packed Loads and Stores.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VMASKMOV.html
        /// Page 1663 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmaskmovpd,

        /// <summary>
        /// Conditional SIMD Packed Loads and Stores.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VMASKMOV.html
        /// Page 1663 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmaskmovps,

        /// <summary>
        /// Maximum of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MAXPD.html
        /// Page 676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmaxpd,

        /// <summary>
        /// Maximum of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MAXPS.html
        /// Page 679 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmaxps,

        /// <summary>
        /// Return Maximum Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MAXSD.html
        /// Page 682 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmaxsd,

        /// <summary>
        /// Return Maximum Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MAXSS.html
        /// Page 684 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmaxss,

        /// <summary>
        /// Minimum of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MINPD.html
        /// Page 687 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vminpd,

        /// <summary>
        /// Minimum of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MINPS.html
        /// Page 690 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vminps,

        /// <summary>
        /// Return Minimum Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MINSD.html
        /// Page 693 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vminsd,

        /// <summary>
        /// Return Minimum Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MINSS.html
        /// Page 695 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vminss,

        /// <summary>
        /// Move Aligned Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVAPD.html
        /// Page 709 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovapd,

        /// <summary>
        /// Move Aligned Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVAPS.html
        /// Page 713 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovaps,

        /// <summary>
        /// Move Doubleword/Move Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVD:MOVQ.html
        /// Page 719 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovd,

        /// <summary>
        /// Replicate Double FP Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDDUP.html
        /// Page 723 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovddup,

        /// <summary>
        /// Move Aligned Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDQA:VMOVDQA32:VMOVDQA64.html
        /// Page 730 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovdqa,

        /// <summary>
        /// Move Aligned Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDQA:VMOVDQA32:VMOVDQA64.html
        /// Page 730 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovdqa32,

        /// <summary>
        /// Move Aligned Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDQA:VMOVDQA32:VMOVDQA64.html
        /// Page 730 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovdqa64,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html
        /// Page 735 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovdqu,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html
        /// Page 735 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovdqu16,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html
        /// Page 735 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovdqu32,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html
        /// Page 735 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovdqu64,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html
        /// Page 735 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovdqu8,

        /// <summary>
        /// Move Packed Single-Precision Floating-Point Values High to Low.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVHLPS.html
        /// Page 744 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovhlps,

        /// <summary>
        /// Move High Packed Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVHPD.html
        /// Page 746 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovhpd,

        /// <summary>
        /// Move High Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVHPS.html
        /// Page 748 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovhps,

        /// <summary>
        /// Move Packed Single-Precision Floating-Point Values Low to High.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVLHPS.html
        /// Page 750 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovlhps,

        /// <summary>
        /// Move Low Packed Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVLPD.html
        /// Page 752 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovlpd,

        /// <summary>
        /// Move Low Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVLPS.html
        /// Page 754 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovlps,

        /// <summary>
        /// Extract Packed Double-Precision Floating-Point Sign Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVMSKPD.html
        /// Page 756 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovmskpd,

        /// <summary>
        /// Extract Packed Single-Precision Floating-Point Sign Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVMSKPS.html
        /// Page 758 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovmskps,

        /// <summary>
        /// Store Packed Integers Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVNTDQ.html
        /// Page 762 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovntdq,

        /// <summary>
        /// Load Double Quadword Non-Temporal Aligned Hint.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVNTDQA.html
        /// Page 760 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovntdqa,

        /// <summary>
        /// Store Packed Double-Precision Floating-Point Values Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVNTPD.html
        /// Page 766 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovntpd,

        /// <summary>
        /// Store Packed Single-Precision Floating-Point Values Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVNTPS.html
        /// Page 768 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovntps,

        /// <summary>
        /// Move Doubleword/Move Quadword.
        /// Move Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVD:MOVQ.html
        /// https://www.felixcloutier.com/x86/MOVQ.html
        /// Pages 719, 771 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovq,

        /// <summary>
        /// Move or Merge Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVSD.html
        /// Page 779 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovsd,

        /// <summary>
        /// Replicate Single FP Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVSHDUP.html
        /// Page 782 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovshdup,

        /// <summary>
        /// Replicate Single FP Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVSLDUP.html
        /// Page 785 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovsldup,

        /// <summary>
        /// Move or Merge Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVSS.html
        /// Page 788 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovss,

        /// <summary>
        /// Move Unaligned Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVUPD.html
        /// Page 794 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovupd,

        /// <summary>
        /// Move Unaligned Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVUPS.html
        /// Page 798 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmovups,

        /// <summary>
        /// Compute Multiple Packed Sums of Absolute Difference.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MPSADBW.html
        /// Page 804 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmpsadbw,

        /// <summary>
        /// Multiply Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MULPD.html
        /// Page 814 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmulpd,

        /// <summary>
        /// Multiply Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MULPS.html
        /// Page 817 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmulps,

        /// <summary>
        /// Multiply Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MULSD.html
        /// Page 820 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmulsd,

        /// <summary>
        /// Multiply Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MULSS.html
        /// Page 822 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vmulss,

        /// <summary>
        /// Bitwise Logical OR of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ORPD.html
        /// Page 836 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vorpd,

        /// <summary>
        /// Bitwise Logical OR of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/ORPS.html
        /// Page 839 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vorps,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html
        /// Page 848 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpabsb,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html
        /// Page 848 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpabsd,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html
        /// Page 848 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpabsw,

        /// <summary>
        /// Pack with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PACKSSWB:PACKSSDW.html
        /// Page 854 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpackssdw,

        /// <summary>
        /// Pack with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PACKSSWB:PACKSSDW.html
        /// Page 854 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpacksswb,

        /// <summary>
        /// Pack with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PACKUSDW.html
        /// Page 862 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpackusdw,

        /// <summary>
        /// Pack with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PACKUSWB.html
        /// Page 867 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpackuswb,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html
        /// Page 872 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpaddb,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html
        /// Page 872 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpaddd,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html
        /// Page 872 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpaddq,

        /// <summary>
        /// Add Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDSB:PADDSW.html
        /// Page 879 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpaddsb,

        /// <summary>
        /// Add Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDSB:PADDSW.html
        /// Page 879 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpaddsw,

        /// <summary>
        /// Add Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDUSB:PADDUSW.html
        /// Page 883 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpaddusb,

        /// <summary>
        /// Add Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDUSB:PADDUSW.html
        /// Page 883 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpaddusw,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html
        /// Page 872 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpaddw,

        /// <summary>
        /// Packed Align Right.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PALIGNR.html
        /// Page 887 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpalignr,

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PAND.html
        /// Page 891 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpand,

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PAND.html
        /// Page 891 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpandd,

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PANDN.html
        /// Page 894 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpandn,

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PANDN.html
        /// Page 894 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpandnd,

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PANDN.html
        /// Page 894 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpandnq,

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PAND.html
        /// Page 891 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpandq,

        /// <summary>
        /// Average Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PAVGB:PAVGW.html
        /// Page 898 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpavgb,

        /// <summary>
        /// Average Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PAVGB:PAVGW.html
        /// Page 898 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpavgw,

        /// <summary>
        /// Blend Packed Dwords.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBLENDD.html
        /// Page 1666 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpblendd,

        /// <summary>
        /// Blend Byte/Word Vectors Using an Opmask Control.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBLENDMB:VPBLENDMW.html
        /// Page 1668 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpblendmb,

        /// <summary>
        /// Blend Int32/Int64 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBLENDMD:VPBLENDMQ.html
        /// Page 1670 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpblendmd,

        /// <summary>
        /// Blend Int32/Int64 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBLENDMD:VPBLENDMQ.html
        /// Page 1670 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpblendmq,

        /// <summary>
        /// Blend Byte/Word Vectors Using an Opmask Control.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBLENDMB:VPBLENDMW.html
        /// Page 1668 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpblendmw,

        /// <summary>
        /// Variable Blend Packed Bytes.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PBLENDVB.html
        /// Page 902 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpblendvb,

        /// <summary>
        /// Blend Packed Words.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PBLENDW.html
        /// Page 906 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpblendw,

        /// <summary>
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// Pages 1673, 1676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpbroadcastb,

        /// <summary>
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// Pages 1673, 1676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpbroadcastd,

        /// <summary>
        /// Broadcast Mask to Vector Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCASTM.html
        /// Page 1685 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpbroadcastmb2q,

        /// <summary>
        /// Broadcast Mask to Vector Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCASTM.html
        /// Page 1685 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpbroadcastmw2d,

        /// <summary>
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// Pages 1673, 1676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpbroadcastq,

        /// <summary>
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// Pages 1673, 1676 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpbroadcastw,

        /// <summary>
        /// Carry-Less Multiplication Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCLMULQDQ.html
        /// Page 909 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpclmulqdq,

        /// <summary>
        /// Compare Packed Byte Values Into Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCMPB:VPCMPUB.html
        /// Page 1687 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpb,

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCMPD:VPCMPUD.html
        /// Page 1690 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpd,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html
        /// Page 912 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpeqb,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html
        /// Page 912 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpeqd,

        /// <summary>
        /// Compare Packed Qword Data for Equal.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPEQQ.html
        /// Page 918 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpeqq,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html
        /// Page 912 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpeqw,

        /// <summary>
        /// Packed Compare Explicit Length Strings, Return Index.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPESTRI.html
        /// Page 921 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpestri,

        /// <summary>
        /// Packed Compare Explicit Length Strings, Return Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPESTRM.html
        /// Page 923 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpestrm,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html
        /// Page 925 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpgtb,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html
        /// Page 925 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpgtd,

        /// <summary>
        /// Compare Packed Data for Greater Than.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPGTQ.html
        /// Page 931 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpgtq,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html
        /// Page 925 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpgtw,

        /// <summary>
        /// Packed Compare Implicit Length Strings, Return Index.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPISTRI.html
        /// Page 934 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpistri,

        /// <summary>
        /// Packed Compare Implicit Length Strings, Return Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PCMPISTRM.html
        /// Page 936 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpistrm,

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCMPQ:VPCMPUQ.html
        /// Page 1693 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpq,

        /// <summary>
        /// Compare Packed Byte Values Into Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCMPB:VPCMPUB.html
        /// Page 1687 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpub,

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCMPD:VPCMPUD.html
        /// Page 1690 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpud,

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCMPQ:VPCMPUQ.html
        /// Page 1693 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpuq,

        /// <summary>
        /// Compare Packed Word Values Into Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCMPW:VPCMPUW.html
        /// Page 1696 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpuw,

        /// <summary>
        /// Compare Packed Word Values Into Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCMPW:VPCMPUW.html
        /// Page 1696 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcmpw,

        /// <summary>
        /// Store Sparse Packed Doubleword Integer Values into Dense Memory/Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCOMPRESSD.html
        /// Page 1699 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcompressd,

        /// <summary>
        /// Store Sparse Packed Quadword Integer Values into Dense Memory/Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCOMPRESSQ.html
        /// Page 1701 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpcompressq,

        /// <summary>
        /// Detect Conflicts Within a Vector of Packed Dword/Qword Values into Dense Memory/ Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCONFLICTD:VPCONFLICTQ.html
        /// Page 1703 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpconflictd,

        /// <summary>
        /// Detect Conflicts Within a Vector of Packed Dword/Qword Values into Dense Memory/ Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPCONFLICTD:VPCONFLICTQ.html
        /// Page 1703 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpconflictq,

        /// <summary>
        /// Permute Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERM2F128.html
        /// Page 1706 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vperm2f128,

        /// <summary>
        /// Permute Integer Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERM2I128.html
        /// Page 1708 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vperm2i128,

        /// <summary>
        /// Permute Packed Bytes Elements.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMB.html
        /// Page 1710 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermb,

        /// <summary>
        /// Permute Packed Doublewords/Words Elements.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMD:VPERMW.html
        /// Page 1712 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermd,

        /// <summary>
        /// Full Permute of Bytes from Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMI2B.html
        /// Page 1715 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermi2b,

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html
        /// Page 1717 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermi2d,

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html
        /// Page 1717 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermi2pd,

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html
        /// Page 1717 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermi2ps,

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html
        /// Page 1717 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermi2q,

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html
        /// Page 1717 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermi2w,

        /// <summary>
        /// Permute In-Lane of Pairs of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMILPD.html
        /// Page 1723 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermilpd,

        /// <summary>
        /// Permute In-Lane of Quadruples of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMILPS.html
        /// Page 1728 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermilps,

        /// <summary>
        /// Permute Double-Precision Floating-Point Elements.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMPD.html
        /// Page 1733 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermpd,

        /// <summary>
        /// Permute Single-Precision Floating-Point Elements.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMPS.html
        /// Page 1736 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermps,

        /// <summary>
        /// Qwords Element Permutation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMQ.html
        /// Page 1739 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermq,

        /// <summary>
        /// Full Permute of Bytes from Two Tables Overwriting a Table.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMT2B.html
        /// Page 1742 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermt2b,

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html
        /// Page 1744 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermt2d,

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html
        /// Page 1744 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermt2pd,

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html
        /// Page 1744 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermt2ps,

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html
        /// Page 1744 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermt2q,

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html
        /// Page 1744 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermt2w,

        /// <summary>
        /// Permute Packed Doublewords/Words Elements.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPERMD:VPERMW.html
        /// Page 1712 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpermw,

        /// <summary>
        /// Load Sparse Packed Doubleword Integer Values from Dense Memory / Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPEXPANDD.html
        /// Page 1749 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpexpandd,

        /// <summary>
        /// Load Sparse Packed Quadword Integer Values from Dense Memory / Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPEXPANDQ.html
        /// Page 1751 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpexpandq,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html
        /// Page 942 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpextrb,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html
        /// Page 942 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpextrd,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html
        /// Page 942 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpextrq,

        /// <summary>
        /// Extract Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PEXTRW.html
        /// Page 945 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpextrw,

        /// <summary>
        /// Gather Packed Dword Values Using Signed Dword/Qword Indices.
        /// Gather Packed Dword, Packed Qword with Signed Dword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERQD.html
        /// https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERDQ.html
        /// Pages 1753, 1757 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpgatherdd,

        /// <summary>
        /// Gather Packed Dword, Packed Qword with Signed Dword Indices.
        /// Gather Packed Qword Values Using Signed Dword/Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERDQ.html
        /// https://www.felixcloutier.com/x86/VPGATHERDQ:VPGATHERQQ.html
        /// Pages 1757, 1760 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpgatherdq,

        /// <summary>
        /// Gather Packed Dword Values Using Signed Dword/Qword Indices.
        /// Gather Packed Dword, Packed Qword with Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERQD.html
        /// https://www.felixcloutier.com/x86/VPGATHERQD:VPGATHERQQ.html
        /// Pages 1753, 1764 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpgatherqd,

        /// <summary>
        /// Gather Packed Qword Values Using Signed Dword/Qword Indices.
        /// Gather Packed Dword, Packed Qword with Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPGATHERDQ:VPGATHERQQ.html
        /// https://www.felixcloutier.com/x86/VPGATHERQD:VPGATHERQQ.html
        /// Pages 1760, 1764 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpgatherqq,

        /// <summary>
        /// Packed Horizontal Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHADDW:PHADDD.html
        /// Page 948 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vphaddd,

        /// <summary>
        /// Packed Horizontal Add and Saturate.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHADDSW.html
        /// Page 952 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vphaddsw,

        /// <summary>
        /// Packed Horizontal Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHADDW:PHADDD.html
        /// Page 948 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vphaddw,

        /// <summary>
        /// Packed Horizontal Word Minimum.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHMINPOSUW.html
        /// Page 954 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vphminposuw,

        /// <summary>
        /// Packed Horizontal Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHSUBW:PHSUBD.html
        /// Page 956 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vphsubd,

        /// <summary>
        /// Packed Horizontal Subtract and Saturate.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHSUBSW.html
        /// Page 959 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vphsubsw,

        /// <summary>
        /// Packed Horizontal Subtract.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PHSUBW:PHSUBD.html
        /// Page 956 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vphsubw,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html
        /// Page 961 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpinsrb,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html
        /// Page 961 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpinsrd,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html
        /// Page 961 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpinsrq,

        /// <summary>
        /// Insert Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PINSRW.html
        /// Page 964 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpinsrw,

        /// <summary>
        /// Count the Number of Leading Zero Bits for Packed Dword, Packed Qword Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPLZCNTD:VPLZCNTQ.html
        /// Page 1767 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vplzcntd,

        /// <summary>
        /// Count the Number of Leading Zero Bits for Packed Dword, Packed Qword Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPLZCNTD:VPLZCNTQ.html
        /// Page 1767 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vplzcntq,

        /// <summary>
        /// Packed Multiply of Unsigned 52-bit Unsigned Integers and Add High 52-bit Products to 64-bit Accumulators.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMADD52HUQ.html
        /// Page 1770 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmadd52huq,

        /// <summary>
        /// Packed Multiply of Unsigned 52-bit Integers and Add the Low 52-bit Products to Qword Accumulators.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMADD52LUQ.html
        /// Page 1772 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmadd52luq,

        /// <summary>
        /// Multiply and Add Packed Signed and Unsigned Bytes.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMADDUBSW.html
        /// Page 966 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaddubsw,

        /// <summary>
        /// Multiply and Add Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMADDWD.html
        /// Page 969 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaddwd,

        /// <summary>
        /// Conditional SIMD Integer Packed Loads and Stores.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMASKMOV.html
        /// Page 1774 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaskmovd,

        /// <summary>
        /// Conditional SIMD Integer Packed Loads and Stores.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMASKMOV.html
        /// Page 1774 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaskmovq,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html
        /// Page 972 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaxsb,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html
        /// Page 972 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaxsd,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html
        /// Page 972 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaxsq,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html
        /// Page 972 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaxsw,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXUB:PMAXUW.html
        /// Page 979 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaxub,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXUD:PMAXUQ.html
        /// Page 984 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaxud,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXUD:PMAXUQ.html
        /// Page 984 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaxuq,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMAXUB:PMAXUW.html
        /// Page 979 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmaxuw,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINSB:PMINSW.html
        /// Page 988 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpminsb,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINSD:PMINSQ.html
        /// Page 993 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpminsd,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINSD:PMINSQ.html
        /// Page 993 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpminsq,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINSB:PMINSW.html
        /// Page 988 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpminsw,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINUB:PMINUW.html
        /// Page 997 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpminub,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINUD:PMINUQ.html
        /// Page 1002 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpminud,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINUD:PMINUQ.html
        /// Page 1002 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpminuq,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMINUB:PMINUW.html
        /// Page 997 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpminuw,

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html
        /// Page 1777 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovb2m,

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html
        /// Page 1777 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovd2m,

        /// <summary>
        /// Down Convert DWord to Byte.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVDB:VPMOVSDB:VPMOVUSDB.html
        /// Page 1780 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovdb,

        /// <summary>
        /// Down Convert DWord to Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVDW:VPMOVSDW:VPMOVUSDW.html
        /// Page 1784 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovdw,

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html
        /// Page 1788 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovm2b,

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html
        /// Page 1788 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovm2d,

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html
        /// Page 1788 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovm2q,

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html
        /// Page 1788 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovm2w,

        /// <summary>
        /// Move Byte Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVMSKB.html
        /// Page 1006 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovmskb,

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html
        /// Page 1777 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovq2m,

        /// <summary>
        /// Down Convert QWord to Byte.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVQB:VPMOVSQB:VPMOVUSQB.html
        /// Page 1791 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovqb,

        /// <summary>
        /// Down Convert QWord to DWord.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVQD:VPMOVSQD:VPMOVUSQD.html
        /// Page 1795 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovqd,

        /// <summary>
        /// Down Convert QWord to Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVQW:VPMOVSQW:VPMOVUSQW.html
        /// Page 1799 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovqw,

        /// <summary>
        /// Down Convert DWord to Byte.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVDB:VPMOVSDB:VPMOVUSDB.html
        /// Page 1780 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovsdb,

        /// <summary>
        /// Down Convert DWord to Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVDW:VPMOVSDW:VPMOVUSDW.html
        /// Page 1784 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovsdw,

        /// <summary>
        /// Down Convert QWord to Byte.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVQB:VPMOVSQB:VPMOVUSQB.html
        /// Page 1791 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovsqb,

        /// <summary>
        /// Down Convert QWord to DWord.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVQD:VPMOVSQD:VPMOVUSQD.html
        /// Page 1795 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovsqd,

        /// <summary>
        /// Down Convert QWord to Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVQW:VPMOVSQW:VPMOVUSQW.html
        /// Page 1799 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovsqw,

        /// <summary>
        /// Down Convert Word to Byte.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVWB:VPMOVSWB:VPMOVUSWB.html
        /// Page 1803 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovswb,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovsxbd,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovsxbq,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovsxbw,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovsxdq,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovsxwd,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVSX.html
        /// Page 1008 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovsxwq,

        /// <summary>
        /// Down Convert DWord to Byte.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVDB:VPMOVSDB:VPMOVUSDB.html
        /// Page 1780 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovusdb,

        /// <summary>
        /// Down Convert DWord to Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVDW:VPMOVSDW:VPMOVUSDW.html
        /// Page 1784 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovusdw,

        /// <summary>
        /// Down Convert QWord to Byte.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVQB:VPMOVSQB:VPMOVUSQB.html
        /// Page 1791 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovusqb,

        /// <summary>
        /// Down Convert QWord to DWord.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVQD:VPMOVSQD:VPMOVUSQD.html
        /// Page 1795 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovusqd,

        /// <summary>
        /// Down Convert QWord to Word.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVQW:VPMOVSQW:VPMOVUSQW.html
        /// Page 1799 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovusqw,

        /// <summary>
        /// Down Convert Word to Byte.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVWB:VPMOVSWB:VPMOVUSWB.html
        /// Page 1803 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovuswb,

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html
        /// Page 1777 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovw2m,

        /// <summary>
        /// Down Convert Word to Byte.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPMOVWB:VPMOVSWB:VPMOVUSWB.html
        /// Page 1803 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovwb,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovzxbd,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovzxbq,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovzxbw,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovzxdq,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovzxwd,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMOVZX.html
        /// Page 1017 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmovzxwq,

        /// <summary>
        /// Multiply Packed Doubleword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULDQ.html
        /// Page 1026 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmuldq,

        /// <summary>
        /// Packed Multiply High with Round and Scale.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULHRSW.html
        /// Page 1029 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmulhrsw,

        /// <summary>
        /// Multiply Packed Unsigned Integers and Store High Result.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULHUW.html
        /// Page 1033 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmulhuw,

        /// <summary>
        /// Multiply Packed Signed Integers and Store High Result.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULHW.html
        /// Page 1037 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmulhw,

        /// <summary>
        /// Multiply Packed Integers and Store Low Result.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULLD:PMULLQ.html
        /// Page 1041 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmulld,

        /// <summary>
        /// Multiply Packed Integers and Store Low Result.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULLD:PMULLQ.html
        /// Page 1041 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmullq,

        /// <summary>
        /// Multiply Packed Signed Integers and Store Low Result.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULLW.html
        /// Page 1045 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmullw,

        /// <summary>
        /// Multiply Packed Unsigned Doubleword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PMULUDQ.html
        /// Page 1049 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpmuludq,

        /// <summary>
        /// Bitwise Logical OR.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/POR.html
        /// Page 1065 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpor,

        /// <summary>
        /// Bitwise Logical OR.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/POR.html
        /// Page 1065 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpord,

        /// <summary>
        /// Bitwise Logical OR.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/POR.html
        /// Page 1065 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vporq,

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html
        /// Page 1809 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vprold,

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html
        /// Page 1809 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vprolq,

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html
        /// Page 1809 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vprolvd,

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html
        /// Page 1809 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vprolvq,

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html
        /// Page 1814 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vprord,

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html
        /// Page 1814 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vprorq,

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html
        /// Page 1814 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vprorvd,

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html
        /// Page 1814 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vprorvq,

        /// <summary>
        /// Compute Sum of Absolute Differences.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSADBW.html
        /// Page 1072 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsadbw,

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html
        /// Page 1819 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpscatterdd,

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html
        /// Page 1819 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpscatterdq,

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html
        /// Page 1819 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpscatterqd,

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html
        /// Page 1819 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpscatterqq,

        /// <summary>
        /// Packed Shuffle Bytes.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSHUFB.html
        /// Page 1076 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpshufb,

        /// <summary>
        /// Shuffle Packed Doublewords.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSHUFD.html
        /// Page 1080 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpshufd,

        /// <summary>
        /// Shuffle Packed High Words.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSHUFHW.html
        /// Page 1084 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpshufhw,

        /// <summary>
        /// Shuffle Packed Low Words.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSHUFLW.html
        /// Page 1087 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpshuflw,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html
        /// Page 1091 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsignb,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html
        /// Page 1091 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsignd,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html
        /// Page 1091 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsignw,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html
        /// Page 1097 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpslld,

        /// <summary>
        /// Shift Double Quadword Left Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSLLDQ.html
        /// Page 1095 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpslldq,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html
        /// Page 1097 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsllq,

        /// <summary>
        /// Variable Bit Shift Left Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSLLVW:VPSLLVD:VPSLLVQ.html
        /// Page 1823 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsllvd,

        /// <summary>
        /// Variable Bit Shift Left Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSLLVW:VPSLLVD:VPSLLVQ.html
        /// Page 1823 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsllvq,

        /// <summary>
        /// Variable Bit Shift Left Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSLLVW:VPSLLVD:VPSLLVQ.html
        /// Page 1823 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsllvw,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html
        /// Page 1097 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsllw,

        /// <summary>
        /// Shift Packed Data Right Arithmetic.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRAW:PSRAD:PSRAQ.html
        /// Page 1109 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsrad,

        /// <summary>
        /// Variable Bit Shift Right Arithmetic.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSRAVW:VPSRAVD:VPSRAVQ.html
        /// Page 1828 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsravd,

        /// <summary>
        /// Variable Bit Shift Right Arithmetic.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSRAVW:VPSRAVD:VPSRAVQ.html
        /// Page 1828 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsravq,

        /// <summary>
        /// Variable Bit Shift Right Arithmetic.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSRAVW:VPSRAVD:VPSRAVQ.html
        /// Page 1828 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsravw,

        /// <summary>
        /// Shift Packed Data Right Arithmetic.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRAW:PSRAD:PSRAQ.html
        /// Page 1109 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsraw,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html
        /// Page 1121 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsrld,

        /// <summary>
        /// Shift Double Quadword Right Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRLDQ.html
        /// Page 1119 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsrldq,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html
        /// Page 1121 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsrlq,

        /// <summary>
        /// Variable Bit Shift Right Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSRLVW:VPSRLVD:VPSRLVQ.html
        /// Page 1833 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsrlvd,

        /// <summary>
        /// Variable Bit Shift Right Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSRLVW:VPSRLVD:VPSRLVQ.html
        /// Page 1833 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsrlvq,

        /// <summary>
        /// Variable Bit Shift Right Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPSRLVW:VPSRLVD:VPSRLVQ.html
        /// Page 1833 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsrlvw,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html
        /// Page 1121 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsrlw,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html
        /// Page 1133 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsubb,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html
        /// Page 1133 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsubd,

        /// <summary>
        /// Subtract Packed Quadword Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBQ.html
        /// Page 1140 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsubq,

        /// <summary>
        /// Subtract Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBSB:PSUBSW.html
        /// Page 1143 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsubsb,

        /// <summary>
        /// Subtract Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBSB:PSUBSW.html
        /// Page 1143 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsubsw,

        /// <summary>
        /// Subtract Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBUSB:PSUBUSW.html
        /// Page 1147 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsubusb,

        /// <summary>
        /// Subtract Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBUSB:PSUBUSW.html
        /// Page 1147 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsubusw,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html
        /// Page 1133 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpsubw,

        /// <summary>
        /// Bitwise Ternary Logic.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPTERNLOGD:VPTERNLOGQ.html
        /// Page 1838 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpternlogd,

        /// <summary>
        /// Bitwise Ternary Logic.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPTERNLOGD:VPTERNLOGQ.html
        /// Page 1838 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpternlogq,

        /// <summary>
        /// Logical Compare.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PTEST.html
        /// Page 1151 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vptest,

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html
        /// Page 1841 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vptestmb,

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html
        /// Page 1841 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vptestmd,

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html
        /// Page 1841 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vptestmq,

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html
        /// Page 1841 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vptestmw,

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html
        /// Page 1844 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vptestnmb,

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html
        /// Page 1844 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vptestnmd,

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html
        /// Page 1844 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vptestnmq,

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html
        /// Page 1844 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vptestnmw,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html
        /// Page 1155 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpunpckhbw,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html
        /// Page 1155 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpunpckhdq,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html
        /// Page 1155 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpunpckhqdq,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html
        /// Page 1155 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpunpckhwd,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html
        /// Page 1165 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpunpcklbw,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html
        /// Page 1165 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpunpckldq,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html
        /// Page 1165 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpunpcklqdq,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html
        /// Page 1165 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vpunpcklwd,

        /// <summary>
        /// Range Restriction Calculation For Packed Pairs of Float64 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRANGEPD.html
        /// Page 1848 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrangepd,

        /// <summary>
        /// Range Restriction Calculation For Packed Pairs of Float32 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRANGEPS.html
        /// Page 1853 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrangeps,

        /// <summary>
        /// Range Restriction Calculation From a pair of Scalar Float64 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRANGESD.html
        /// Page 1857 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrangesd,

        /// <summary>
        /// Range Restriction Calculation From a Pair of Scalar Float32 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRANGESS.html
        /// Page 1860 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrangess,

        /// <summary>
        /// Compute Approximate Reciprocals of Packed Float64 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRCP14PD.html
        /// Page 1863 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrcp14pd,

        /// <summary>
        /// Compute Approximate Reciprocals of Packed Float32 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRCP14PS.html
        /// Page 1867 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrcp14ps,

        /// <summary>
        /// Compute Approximate Reciprocal of Scalar Float64 Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRCP14SD.html
        /// Page 1865 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrcp14sd,

        /// <summary>
        /// Compute Approximate Reciprocal of Scalar Float32 Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRCP14SS.html
        /// Page 1869 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrcp14ss,

        /// <summary>
        /// Perform Reduction Transformation on Packed Float64 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VREDUCEPD.html
        /// Page 1871 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vreducepd,

        /// <summary>
        /// Perform Reduction Transformation on Packed Float32 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VREDUCEPS.html
        /// Page 1876 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vreduceps,

        /// <summary>
        /// Perform a Reduction Transformation on a Scalar Float64 Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VREDUCESD.html
        /// Page 1874 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vreducesd,

        /// <summary>
        /// Perform a Reduction Transformation on a Scalar Float32 Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VREDUCESS.html
        /// Page 1878 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vreducess,

        /// <summary>
        /// Round Packed Float64 Values To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRNDSCALEPD.html
        /// Page 1880 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrndscalepd,

        /// <summary>
        /// Round Packed Float32 Values To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRNDSCALEPS.html
        /// Page 1886 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrndscaleps,

        /// <summary>
        /// Round Scalar Float64 Value To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRNDSCALESD.html
        /// Page 1884 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrndscalesd,

        /// <summary>
        /// Round Scalar Float32 Value To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRNDSCALESS.html
        /// Page 1889 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrndscaless,

        /// <summary>
        /// Compute Approximate Reciprocals of Square Roots of Packed Float64 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRSQRT14PD.html
        /// Page 1891 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrsqrt14pd,

        /// <summary>
        /// Compute Approximate Reciprocals of Square Roots of Packed Float32 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRSQRT14PS.html
        /// Page 1895 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrsqrt14ps,

        /// <summary>
        /// Compute Approximate Reciprocal of Square Root of Scalar Float64 Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRSQRT14SD.html
        /// Page 1893 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrsqrt14sd,

        /// <summary>
        /// Compute Approximate Reciprocal of Square Root of Scalar Float32 Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VRSQRT14SS.html
        /// Page 1897 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vrsqrt14ss,

        /// <summary>
        /// Scale Packed Float64 Values With Float64 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSCALEFPD.html
        /// Page 1899 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vscalefpd,

        /// <summary>
        /// Scale Packed Float32 Values With Float32 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSCALEFPS.html
        /// Page 1904 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vscalefps,

        /// <summary>
        /// Scale Scalar Float64 Values With Float64 Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSCALEFSD.html
        /// Page 1902 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vscalefsd,

        /// <summary>
        /// Scale Scalar Float32 Value With Float32 Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSCALEFSS.html
        /// Page 1907 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vscalefss,

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html
        /// Page 1909 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vscatterdpd,

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html
        /// Page 1909 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vscatterdps,

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html
        /// Page 1909 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vscatterqpd,

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html
        /// Page 1909 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vscatterqps,

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html
        /// Page 1913 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vshuff32x4,

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html
        /// Page 1913 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vshuff64x2,

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html
        /// Page 1913 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vshufi32x4,

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html
        /// Page 1913 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vshufi64x2,

        /// <summary>
        /// Packed Interleave Shuffle of Pairs of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHUFPD.html
        /// Page 1279 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vshufpd,

        /// <summary>
        /// Packed Interleave Shuffle of Quadruplets of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SHUFPS.html
        /// Page 1284 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vshufps,

        /// <summary>
        /// Square Root of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SQRTPD.html
        /// Page 1294 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vsqrtpd,

        /// <summary>
        /// Square Root of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SQRTPS.html
        /// Page 1297 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vsqrtps,

        /// <summary>
        /// Compute Square Root of Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SQRTSD.html
        /// Page 1300 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vsqrtsd,

        /// <summary>
        /// Compute Square Root of Scalar Single-Precision Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SQRTSS.html
        /// Page 1302 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vsqrtss,

        /// <summary>
        /// Subtract Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SUBPD.html
        /// Page 1318 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vsubpd,

        /// <summary>
        /// Subtract Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SUBPS.html
        /// Page 1321 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vsubps,

        /// <summary>
        /// Subtract Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SUBSD.html
        /// Page 1324 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vsubsd,

        /// <summary>
        /// Subtract Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/SUBSS.html
        /// Page 1326 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vsubss,

        /// <summary>
        /// Packed Bit Test.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VTESTPD:VTESTPS.html
        /// Page 1918 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vtestpd,

        /// <summary>
        /// Packed Bit Test.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VTESTPD:VTESTPS.html
        /// Page 1918 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vtestps,

        /// <summary>
        /// Unordered Compare Scalar Double-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UCOMISD.html
        /// Page 1347 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vucomisd,

        /// <summary>
        /// Unordered Compare Scalar Single-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UCOMISS.html
        /// Page 1349 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vucomiss,

        /// <summary>
        /// Unpack and Interleave High Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UNPCKHPD.html
        /// Page 1356 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vunpckhpd,

        /// <summary>
        /// Unpack and Interleave High Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UNPCKHPS.html
        /// Page 1360 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vunpckhps,

        /// <summary>
        /// Unpack and Interleave Low Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UNPCKLPD.html
        /// Page 1364 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vunpcklpd,

        /// <summary>
        /// Unpack and Interleave Low Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/UNPCKLPS.html
        /// Page 1368 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vunpcklps,

        /// <summary>
        /// Bitwise Logical XOR of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XORPD.html
        /// Page 1952 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vxorpd,

        /// <summary>
        /// Bitwise Logical XOR of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XORPS.html
        /// Page 1955 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vxorps,

        /// <summary>
        /// Zero All YMM Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VZEROALL.html
        /// Page 1921 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vzeroall,

        /// <summary>
        /// Zero Upper Bits of YMM Registers.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VZEROUPPER.html
        /// Page 1922 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        vzeroupper,

        /// <summary>
        /// Wait.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/WAIT:FWAIT.html
        /// Page 1923 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        wait,

        /// <summary>
        /// Write Back and Invalidate Cache.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/WBINVD.html
        /// Page 1924 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        wbinvd,

        /// <summary>
        /// Write FS/GS Segment Base.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/WRFSBASE:WRGSBASE.html
        /// Page 1926 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        wrfsbase,

        /// <summary>
        /// Write FS/GS Segment Base.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/WRFSBASE:WRGSBASE.html
        /// Page 1926 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        wrgsbase,

        /// <summary>
        /// Write to Model Specific Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/WRMSR.html
        /// Page 1928 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        wrmsr,

        /// <summary>
        /// Write Data to User Page Key Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/WRPKRU.html
        /// Page 1930 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        wrpkru,

        /// <summary>
        /// Transactional Abort.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XABORT.html
        /// Page 1935 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xabort,

        /// <summary>
        /// Hardware Lock Elision Prefix Hints.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XACQUIRE:XRELEASE.html
        /// Page 1931 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xacquire,

        /// <summary>
        /// Exchange and Add.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XADD.html
        /// Page 1937 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xadd,

        /// <summary>
        /// Transactional Begin.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XBEGIN.html
        /// Page 1939 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xbegin,

        /// <summary>
        /// Exchange Register/Memory with Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XCHG.html
        /// Page 1942 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xchg,

        /// <summary>
        /// Transactional End.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XEND.html
        /// Page 1944 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xend,

        /// <summary>
        /// Get Value of Extended Control Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XGETBV.html
        /// Page 1946 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xgetbv,

        /// <summary>
        /// Table Look-up Translation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XLAT:XLATB.html
        /// Page 1948 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xlat,

        /// <summary>
        /// Table Look-up Translation.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XLAT:XLATB.html
        /// Page 1948 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xlatb,

        /// <summary>
        /// Logical Exclusive OR.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XOR.html
        /// Page 1950 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xor,

        /// <summary>
        /// Bitwise Logical XOR of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XORPD.html
        /// Page 1952 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xorpd,

        /// <summary>
        /// Bitwise Logical XOR of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XORPS.html
        /// Page 1955 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xorps,

        /// <summary>
        /// Hardware Lock Elision Prefix Hints.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XACQUIRE:XRELEASE.html
        /// Page 1931 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xrelease,

        /// <summary>
        /// Save Processor Extended States Optimized.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XSAVEOPT.html
        /// Page 1973 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xsaveopt,

        /// <summary>
        /// Save Processor Extended States Optimized.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XSAVEOPT.html
        /// Page 1973 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xsaveopt64,

        /// <summary>
        /// Set Extended Control Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XSETBV.html
        /// Page 1979 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xsetbv,

        /// <summary>
        /// Test If In Transactional Execution.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/XTEST.html
        /// Page 1981 in Intel documentation file '325383-sdm-vol-2abcd.pdf'.
        /// </remarks>
        xtest,
    }
}