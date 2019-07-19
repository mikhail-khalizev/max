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
        /// <remarks>https://www.felixcloutier.com/x86/AAA.html</remarks>
        aaa,

        /// <summary>
        /// ASCII Adjust AX Before Division.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AAD.html</remarks>
        aad,

        /// <summary>
        /// ASCII Adjust AX After Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AAM.html</remarks>
        aam,

        /// <summary>
        /// ASCII Adjust AL After Subtraction.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AAS.html</remarks>
        aas,

        /// <summary>
        /// Add with Carry.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADC.html</remarks>
        adc,

        /// <summary>
        /// Unsigned Integer Addition of Two Operands with Carry Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADCX.html</remarks>
        adcx,

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADD.html</remarks>
        add,

        /// <summary>
        /// Add Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDPD.html</remarks>
        addpd,

        /// <summary>
        /// Add Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDPS.html</remarks>
        addps,

        /// <summary>
        /// Add Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSD.html</remarks>
        addsd,

        /// <summary>
        /// Add Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSS.html</remarks>
        addss,

        /// <summary>
        /// Packed Double-FP Add/Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSUBPD.html</remarks>
        addsubpd,

        /// <summary>
        /// Packed Single-FP Add/Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSUBPS.html</remarks>
        addsubps,

        /// <summary>
        /// Unsigned Integer Addition of Two Operands with Overflow Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADOX.html</remarks>
        adox,

        /// <summary>
        /// Perform One Round of an AES Decryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESDEC.html</remarks>
        aesdec,

        /// <summary>
        /// Perform Last Round of an AES Decryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESDECLAST.html</remarks>
        aesdeclast,

        /// <summary>
        /// Perform One Round of an AES Encryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESENC.html</remarks>
        aesenc,

        /// <summary>
        /// Perform Last Round of an AES Encryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESENCLAST.html</remarks>
        aesenclast,

        /// <summary>
        /// Perform the AES InvMixColumn Transformation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESIMC.html</remarks>
        aesimc,

        /// <summary>
        /// AES Round Key Generation Assist.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESKEYGENASSIST.html</remarks>
        aeskeygenassist,

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AND.html</remarks>
        and,

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDN.html</remarks>
        andn,

        /// <summary>
        /// Bitwise Logical AND NOT of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDNPD.html</remarks>
        andnpd,

        /// <summary>
        /// Bitwise Logical AND NOT of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDNPS.html</remarks>
        andnps,

        /// <summary>
        /// Bitwise Logical AND of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDPD.html</remarks>
        andpd,

        /// <summary>
        /// Bitwise Logical AND of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDPS.html</remarks>
        andps,

        /// <summary>
        /// Adjust RPL Field of Segment Selector.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ARPL.html</remarks>
        arpl,

        /// <summary>
        /// Count the Number of Leading Zero Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LZCNT.html</remarks>
        bd,

        /// <summary>
        /// Bit Field Extract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BEXTR.html</remarks>
        bextr,

        /// <summary>
        /// Blend Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDPD.html</remarks>
        blendpd,

        /// <summary>
        /// Blend Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDPS.html</remarks>
        blendps,

        /// <summary>
        /// Variable Blend Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDVPD.html</remarks>
        blendvpd,

        /// <summary>
        /// Variable Blend Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDVPS.html</remarks>
        blendvps,

        /// <summary>
        /// Extract Lowest Set Isolated Bit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLSI.html</remarks>
        blsi,

        /// <summary>
        /// Get Mask Up to Lowest Set Bit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLSMSK.html</remarks>
        blsmsk,

        /// <summary>
        /// Reset Lowest Set Bit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLSR.html</remarks>
        blsr,

        /// <summary>
        /// Check Lower Bound.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDCL.html</remarks>
        bndcl,

        /// <summary>
        /// Check Upper Bound.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDCU:BNDCN.html</remarks>
        bndcn,

        /// <summary>
        /// Check Upper Bound.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDCU:BNDCN.html</remarks>
        bndcu,

        /// <summary>
        /// Load Extended Bounds Using Address Translation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDLDX.html</remarks>
        bndldx,

        /// <summary>
        /// Make Bounds.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDMK.html</remarks>
        bndmk,

        /// <summary>
        /// Move Bounds.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDMOV.html</remarks>
        bndmov,

        /// <summary>
        /// Store Extended Bounds Using Address Translation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDSTX.html</remarks>
        bndstx,

        /// <summary>
        /// Check Array Index Against Bounds.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BOUND.html</remarks>
        bound,

        /// <summary>
        /// Bit Scan Forward.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BSF.html</remarks>
        bsf,

        /// <summary>
        /// Bit Scan Reverse.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BSR.html</remarks>
        bsr,

        /// <summary>
        /// Byte Swap.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BSWAP.html</remarks>
        bswap,

        /// <summary>
        /// Bit Test.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BT.html</remarks>
        bt,

        /// <summary>
        /// Bit Test and Complement.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BTC.html</remarks>
        btc,

        /// <summary>
        /// Bit Test and Reset.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BTR.html</remarks>
        btr,

        /// <summary>
        /// Bit Test and Set.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BTS.html</remarks>
        bts,

        /// <summary>
        /// Zero High Bits Starting with Specified Bit Position.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BZHI.html</remarks>
        bzhi,

        /// <summary>
        /// Call Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CALL.html</remarks>
        call,

        /// <summary>
        /// Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CBW:CWDE:CDQE.html</remarks>
        cbw,

        /// <summary>
        /// Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CWD:CDQ:CQO.html</remarks>
        cdq,

        /// <summary>
        /// Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CBW:CWDE:CDQE.html</remarks>
        cdqe,

        /// <summary>
        /// Clear AC Flag in EFLAGS Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLAC.html</remarks>
        clac,

        /// <summary>
        /// Clear Carry Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLC.html</remarks>
        clc,

        /// <summary>
        /// Clear Direction Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLD.html</remarks>
        cld,

        /// <summary>
        /// Flush Cache Line.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLFLUSH.html</remarks>
        clflush,

        /// <summary>
        /// Flush Cache Line Optimized.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLFLUSHOPT.html</remarks>
        clflushopt,

        /// <summary>
        /// Clear Interrupt Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLI.html</remarks>
        cli,

        /// <summary>
        /// Clear Task-Switched Flag in CR0.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLTS.html</remarks>
        clts,

        /// <summary>
        /// Cache Line Write Back.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLWB.html</remarks>
        clwb,

        /// <summary>
        /// Complement Carry Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMC.html</remarks>
        cmc,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmova,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovae,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovb,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovbe,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovc,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmove,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovg,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovge,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovl,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovle,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovna,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovnae,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovnb,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovnbe,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovnc,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovne,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovng,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovnge,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovnl,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovnle,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovno,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovnp,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovns,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovnz,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovo,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovp,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovpe,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovpo,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovs,

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        cmovz,

        /// <summary>
        /// Compare Two Operands.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMP.html</remarks>
        cmp,

        /// <summary>
        /// Compare Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPPD.html</remarks>
        cmppd,

        /// <summary>
        /// Compare Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPPS.html</remarks>
        cmpps,

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html</remarks>
        cmps,

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html</remarks>
        cmpsb,

        /// <summary>
        /// Compare String Operands.
        /// Compare Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html
        /// https://www.felixcloutier.com/x86/CMPSD.html
        /// </remarks>
        cmpsd,

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html</remarks>
        cmpsq,

        /// <summary>
        /// Compare Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPSS.html</remarks>
        cmpss,

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html</remarks>
        cmpsw,

        /// <summary>
        /// Compare and Exchange.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPXCHG.html</remarks>
        cmpxchg,

        /// <summary>
        /// Compare and Exchange Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPXCHG8B:CMPXCHG16B.html</remarks>
        cmpxchg16b,

        /// <summary>
        /// Compare and Exchange Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPXCHG8B:CMPXCHG16B.html</remarks>
        cmpxchg8b,

        /// <summary>
        /// Compare Scalar Ordered Double-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/COMISD.html</remarks>
        comisd,

        /// <summary>
        /// Compare Scalar Ordered Single-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/COMISS.html</remarks>
        comiss,

        /// <summary>
        /// CPU Identification.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CPUID.html</remarks>
        cpuid,

        /// <summary>
        /// Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CWD:CDQ:CQO.html</remarks>
        cqo,

        /// <summary>
        /// Accumulate CRC32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CRC32.html</remarks>
        crc32,

        /// <summary>
        /// Convert Packed Doubleword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTDQ2PD.html</remarks>
        cvtdq2pd,

        /// <summary>
        /// Convert Packed Doubleword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTDQ2PS.html</remarks>
        cvtdq2ps,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPD2DQ.html</remarks>
        cvtpd2dq,

        /// <summary>
        /// Convert Packed Double-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPD2PI.html</remarks>
        cvtpd2pi,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPD2PS.html</remarks>
        cvtpd2ps,

        /// <summary>
        /// Convert Packed Dword Integers to Packed Double-Precision FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPI2PD.html</remarks>
        cvtpi2pd,

        /// <summary>
        /// Convert Packed Dword Integers to Packed Single-Precision FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPI2PS.html</remarks>
        cvtpi2ps,

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPS2DQ.html</remarks>
        cvtps2dq,

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPS2PD.html</remarks>
        cvtps2pd,

        /// <summary>
        /// Convert Packed Single-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPS2PI.html</remarks>
        cvtps2pi,

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Doubleword Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSD2SI.html</remarks>
        cvtsd2si,

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSD2SS.html</remarks>
        cvtsd2ss,

        /// <summary>
        /// Convert Doubleword Integer to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSI2SD.html</remarks>
        cvtsi2sd,

        /// <summary>
        /// Convert Doubleword Integer to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSI2SS.html</remarks>
        cvtsi2ss,

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSS2SD.html</remarks>
        cvtss2sd,

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Doubleword Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSS2SI.html</remarks>
        cvtss2si,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTPD2DQ.html</remarks>
        cvttpd2dq,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTPD2PI.html</remarks>
        cvttpd2pi,

        /// <summary>
        /// Convert with Truncation Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTPS2DQ.html</remarks>
        cvttps2dq,

        /// <summary>
        /// Convert with Truncation Packed Single-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTPS2PI.html</remarks>
        cvttps2pi,

        /// <summary>
        /// Convert with Truncation Scalar Double-Precision Floating-Point Value to Signed Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTSD2SI.html</remarks>
        cvttsd2si,

        /// <summary>
        /// Convert with Truncation Scalar Single-Precision Floating-Point Value to Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTSS2SI.html</remarks>
        cvttss2si,

        /// <summary>
        /// Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CWD:CDQ:CQO.html</remarks>
        cwd,

        /// <summary>
        /// Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CBW:CWDE:CDQE.html</remarks>
        cwde,

        /// <summary>
        /// Decimal Adjust AL after Addition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DAA.html</remarks>
        daa,

        /// <summary>
        /// Decimal Adjust AL after Subtraction.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DAS.html</remarks>
        das,

        /// <summary>
        /// Decrement by 1.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DEC.html</remarks>
        dec,

        /// <summary>
        /// Unsigned Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIV.html</remarks>
        div,

        /// <summary>
        /// Divide Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVPD.html</remarks>
        divpd,

        /// <summary>
        /// Divide Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVPS.html</remarks>
        divps,

        /// <summary>
        /// Divide Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVSD.html</remarks>
        divsd,

        /// <summary>
        /// Divide Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVSS.html</remarks>
        divss,

        /// <summary>
        /// Dot Product of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DPPD.html</remarks>
        dppd,

        /// <summary>
        /// Dot Product of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DPPS.html</remarks>
        dpps,

        /// <summary>
        /// Empty MMX Technology State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/EMMS.html</remarks>
        emms,

        /// <summary>
        /// Make Stack Frame for Procedure Parameters.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ENTER.html</remarks>
        enter,

        /// <summary>
        /// Extract Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/EXTRACTPS.html</remarks>
        extractps,

        /// <summary>
        /// Compute 2x–1.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/F2XM1.html</remarks>
        f2xm1,

        /// <summary>
        /// Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FABS.html</remarks>
        fabs,

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FADD:FADDP:FIADD.html</remarks>
        fadd,

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FADD:FADDP:FIADD.html</remarks>
        faddp,

        /// <summary>
        /// Load Binary Coded Decimal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FBLD.html</remarks>
        fbld,

        /// <summary>
        /// Store BCD Integer and Pop.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FBSTP.html</remarks>
        fbstp,

        /// <summary>
        /// Change Sign.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCHS.html</remarks>
        fchs,

        /// <summary>
        /// Clear Exceptions.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCLEX:FNCLEX.html</remarks>
        fclex,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCMOVcc.html</remarks>
        fcmovb,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCMOVcc.html</remarks>
        fcmovbe,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCMOVcc.html</remarks>
        fcmove,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCMOVcc.html</remarks>
        fcmovnb,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCMOVcc.html</remarks>
        fcmovnbe,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCMOVcc.html</remarks>
        fcmovne,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCMOVcc.html</remarks>
        fcmovnu,

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCMOVcc.html</remarks>
        fcmovu,

        /// <summary>
        /// Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOM:FCOMP:FCOMPP.html</remarks>
        fcom,

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html</remarks>
        fcomi,

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html</remarks>
        fcomip,

        /// <summary>
        /// Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOM:FCOMP:FCOMPP.html</remarks>
        fcomp,

        /// <summary>
        /// Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOM:FCOMP:FCOMPP.html</remarks>
        fcompp,

        /// <summary>
        /// Cosine.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOS.html</remarks>
        fcos,

        /// <summary>
        /// Decrement Stack-Top Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDECSTP.html</remarks>
        fdecstp,

        /// <summary>
        /// Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIV:FDIVP:FIDIV.html</remarks>
        fdiv,

        /// <summary>
        /// Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIV:FDIVP:FIDIV.html</remarks>
        fdivp,

        /// <summary>
        /// Reverse Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIVR:FDIVRP:FIDIVR.html</remarks>
        fdivr,

        /// <summary>
        /// Reverse Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIVR:FDIVRP:FIDIVR.html</remarks>
        fdivrp,

        /// <summary>
        /// Free Floating-Point Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FFREE.html</remarks>
        ffree,

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FADD:FADDP:FIADD.html</remarks>
        fiadd,

        /// <summary>
        /// Compare Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FICOM:FICOMP.html</remarks>
        ficom,

        /// <summary>
        /// Compare Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FICOM:FICOMP.html</remarks>
        ficomp,

        /// <summary>
        /// Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIV:FDIVP:FIDIV.html</remarks>
        fidiv,

        /// <summary>
        /// Reverse Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIVR:FDIVRP:FIDIVR.html</remarks>
        fidivr,

        /// <summary>
        /// Load Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FILD.html</remarks>
        fild,

        /// <summary>
        /// Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FMUL:FMULP:FIMUL.html</remarks>
        fimul,

        /// <summary>
        /// Increment Stack-Top Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FINCSTP.html</remarks>
        fincstp,

        /// <summary>
        /// Initialize Floating-Point Unit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FINIT:FNINIT.html</remarks>
        finit,

        /// <summary>
        /// Store Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FIST:FISTP.html</remarks>
        fist,

        /// <summary>
        /// Store Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FIST:FISTP.html</remarks>
        fistp,

        /// <summary>
        /// Store Integer with Truncation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FISTTP.html</remarks>
        fisttp,

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUB:FSUBP:FISUB.html</remarks>
        fisub,

        /// <summary>
        /// Reverse Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUBR:FSUBRP:FISUBR.html</remarks>
        fisubr,

        /// <summary>
        /// Load Floating Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD.html</remarks>
        fld,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        fld1,

        /// <summary>
        /// Load x87 FPU Control Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLDCW.html</remarks>
        fldcw,

        /// <summary>
        /// Load x87 FPU Environment.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLDENV.html</remarks>
        fldenv,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        fldl2e,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        fldl2t,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        fldlg2,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        fldln2,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        fldpi,

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        fldz,

        /// <summary>
        /// Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FMUL:FMULP:FIMUL.html</remarks>
        fmul,

        /// <summary>
        /// Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FMUL:FMULP:FIMUL.html</remarks>
        fmulp,

        /// <summary>
        /// Clear Exceptions.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCLEX:FNCLEX.html</remarks>
        fnclex,

        /// <summary>
        /// Initialize Floating-Point Unit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FINIT:FNINIT.html</remarks>
        fninit,

        /// <summary>
        /// No Operation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FNOP.html</remarks>
        fnop,

        /// <summary>
        /// Store x87 FPU State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSAVE:FNSAVE.html</remarks>
        fnsave,

        /// <summary>
        /// Store x87 FPU Control Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTCW:FNSTCW.html</remarks>
        fnstcw,

        /// <summary>
        /// Store x87 FPU Environment.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTENV:FNSTENV.html</remarks>
        fnstenv,

        /// <summary>
        /// Store x87 FPU Status Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTSW:FNSTSW.html</remarks>
        fnstsw,

        /// <summary>
        /// Partial Arctangent.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FPATAN.html</remarks>
        fpatan,

        /// <summary>
        /// Partial Remainder.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FPREM.html</remarks>
        fprem,

        /// <summary>
        /// Partial Remainder.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FPREM1.html</remarks>
        fprem1,

        /// <summary>
        /// Partial Tangent.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FPTAN.html</remarks>
        fptan,

        /// <summary>
        /// Round to Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FRNDINT.html</remarks>
        frndint,

        /// <summary>
        /// Restore x87 FPU State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FRSTOR.html</remarks>
        frstor,

        /// <summary>
        /// Store x87 FPU State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSAVE:FNSAVE.html</remarks>
        fsave,

        /// <summary>
        /// Scale.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSCALE.html</remarks>
        fscale,

        /// <summary>
        /// Sine.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSIN.html</remarks>
        fsin,

        /// <summary>
        /// Sine and Cosine.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSINCOS.html</remarks>
        fsincos,

        /// <summary>
        /// Square Root.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSQRT.html</remarks>
        fsqrt,

        /// <summary>
        /// Store Floating Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FST:FSTP.html</remarks>
        fst,

        /// <summary>
        /// Store x87 FPU Control Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTCW:FNSTCW.html</remarks>
        fstcw,

        /// <summary>
        /// Store x87 FPU Environment.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTENV:FNSTENV.html</remarks>
        fstenv,

        /// <summary>
        /// Store Floating Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FST:FSTP.html</remarks>
        fstp,

        /// <summary>
        /// Store x87 FPU Status Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTSW:FNSTSW.html</remarks>
        fstsw,

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUB:FSUBP:FISUB.html</remarks>
        fsub,

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUB:FSUBP:FISUB.html</remarks>
        fsubp,

        /// <summary>
        /// Reverse Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUBR:FSUBRP:FISUBR.html</remarks>
        fsubr,

        /// <summary>
        /// Reverse Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUBR:FSUBRP:FISUBR.html</remarks>
        fsubrp,

        /// <summary>
        /// TEST.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FTST.html</remarks>
        ftst,

        /// <summary>
        /// Unordered Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FUCOM:FUCOMP:FUCOMPP.html</remarks>
        fucom,

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html</remarks>
        fucomi,

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html</remarks>
        fucomip,

        /// <summary>
        /// Unordered Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FUCOM:FUCOMP:FUCOMPP.html</remarks>
        fucomp,

        /// <summary>
        /// Unordered Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FUCOM:FUCOMP:FUCOMPP.html</remarks>
        fucompp,

        /// <summary>
        /// Wait.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WAIT:FWAIT.html</remarks>
        fwait,

        /// <summary>
        /// Examine Floating-Point.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXAM.html</remarks>
        fxam,

        /// <summary>
        /// Exchange Register Contents.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXCH.html</remarks>
        fxch,

        /// <summary>
        /// Restore x87 FPU, MMX, XMM, and MXCSR State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXRSTOR.html</remarks>
        fxrstor,

        /// <summary>
        /// Restore x87 FPU, MMX, XMM, and MXCSR State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXRSTOR.html</remarks>
        fxrstor64,

        /// <summary>
        /// Save x87 FPU, MMX Technology, and SSE State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXSAVE.html</remarks>
        fxsave,

        /// <summary>
        /// Save x87 FPU, MMX Technology, and SSE State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXSAVE.html</remarks>
        fxsave64,

        /// <summary>
        /// Extract Exponent and Significand.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXTRACT.html</remarks>
        fxtract,

        /// <summary>
        /// Compute y ∗ log2x.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FYL2X.html</remarks>
        fyl2x,

        /// <summary>
        /// Compute y ∗ log2(x +1).
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FYL2XP1.html</remarks>
        fyl2xp1,

        /// <summary>
        /// Packed Double-FP Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HADDPD.html</remarks>
        haddpd,

        /// <summary>
        /// Packed Single-FP Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HADDPS.html</remarks>
        haddps,

        /// <summary>
        /// Halt.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HLT.html</remarks>
        hlt,

        /// <summary>
        /// Packed Double-FP Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HSUBPD.html</remarks>
        hsubpd,

        /// <summary>
        /// Packed Single-FP Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HSUBPS.html</remarks>
        hsubps,

        /// <summary>
        /// Permute In-Lane of Quadruples of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMILPS.html</remarks>
        ibvpermilps,

        /// <summary>
        /// Signed Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IDIV.html</remarks>
        idiv,

        /// <summary>
        /// Signed Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IMUL.html</remarks>
        imul,

        /// <summary>
        /// Input from Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IN.html</remarks>
        @in,

        /// <summary>
        /// Increment by 1.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INC.html</remarks>
        inc,

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html</remarks>
        ins,

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html</remarks>
        insb,

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html</remarks>
        insd,

        /// <summary>
        /// Insert Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INSERTPS.html</remarks>
        insertps,

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html</remarks>
        insw,

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html</remarks>
        @int,

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html</remarks>
        int1,

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html</remarks>
        int3,

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html</remarks>
        into,

        /// <summary>
        /// Invalidate Internal Caches.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INVD.html</remarks>
        invd,

        /// <summary>
        /// Invalidate Process-Context Identifier.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INVPCID.html</remarks>
        invpcid,

        /// <summary>
        /// Interrupt Return.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IRET:IRETD.html</remarks>
        iret,

        /// <summary>
        /// Interrupt Return.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IRET:IRETD.html</remarks>
        iretd,

        /// <summary>
        /// Interrupt Return.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IRET:IRETD.html</remarks>
        iretq,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        ja,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jae,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jb,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jbe,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jc,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jcxz,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        je,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jecxz,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jg,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jge,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jl,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jle,

        /// <summary>
        /// Jump.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/JMP.html</remarks>
        jmp,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jna,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jnae,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jnb,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jnbe,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jnc,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jne,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jng,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jnge,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jnl,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jnle,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jno,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jnp,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jns,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jnz,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jo,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jp,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jpe,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jpo,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jrcxz,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        js,

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        jz,

        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html</remarks>
        kaddb,

        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html</remarks>
        kaddd,

        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html</remarks>
        kaddq,

        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html</remarks>
        kaddw,

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html</remarks>
        kandb,

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html</remarks>
        kandd,

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html</remarks>
        kandnb,

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html</remarks>
        kandnd,

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html</remarks>
        kandnq,

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html</remarks>
        kandnw,

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html</remarks>
        kandq,

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html</remarks>
        kandw,

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html</remarks>
        kmovb,

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html</remarks>
        kmovd,

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html</remarks>
        kmovq,

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html</remarks>
        kmovw,

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html</remarks>
        knotb,

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html</remarks>
        knotd,

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html</remarks>
        knotq,

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html</remarks>
        knotw,

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html</remarks>
        korb,

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html</remarks>
        kord,

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html</remarks>
        korq,

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html</remarks>
        kortestb,

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html</remarks>
        kortestd,

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html</remarks>
        kortestq,

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html</remarks>
        kortestw,

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html</remarks>
        korw,

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html</remarks>
        kshiftlb,

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html</remarks>
        kshiftld,

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html</remarks>
        kshiftlq,

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html</remarks>
        kshiftlw,

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html</remarks>
        kshiftrb,

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html</remarks>
        kshiftrd,

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html</remarks>
        kshiftrq,

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html</remarks>
        kshiftrw,

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html</remarks>
        ktestb,

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html</remarks>
        ktestd,

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html</remarks>
        ktestq,

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html</remarks>
        ktestw,

        /// <summary>
        /// Unpack for Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KUNPCKBW:KUNPCKWD:KUNPCKDQ.html</remarks>
        kunpckbw,

        /// <summary>
        /// Unpack for Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KUNPCKBW:KUNPCKWD:KUNPCKDQ.html</remarks>
        kunpckdq,

        /// <summary>
        /// Unpack for Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KUNPCKBW:KUNPCKWD:KUNPCKDQ.html</remarks>
        kunpckwd,

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html</remarks>
        kxnorb,

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html</remarks>
        kxnord,

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html</remarks>
        kxnorq,

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html</remarks>
        kxnorw,

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html</remarks>
        kxorb,

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html</remarks>
        kxord,

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html</remarks>
        kxorq,

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html</remarks>
        kxorw,

        /// <summary>
        /// Load Access Rights Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LAR.html</remarks>
        lar,

        /// <summary>
        /// Load Unaligned Integer 128 Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDDQU.html</remarks>
        lddqu,

        /// <summary>
        /// Load MXCSR Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDMXCSR.html</remarks>
        ldmxcsr,

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html</remarks>
        lds,

        /// <summary>
        /// Load Effective Address.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LEA.html</remarks>
        lea,

        /// <summary>
        /// High Level Procedure Exit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LEAVE.html</remarks>
        leave,

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html</remarks>
        les,

        /// <summary>
        /// Load Fence.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LFENCE.html</remarks>
        lfence,

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html</remarks>
        lfs,

        /// <summary>
        /// Load Global/Interrupt Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LGDT:LIDT.html</remarks>
        lgdt,

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html</remarks>
        lgs,

        /// <summary>
        /// Load Global/Interrupt Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LGDT:LIDT.html</remarks>
        lidt,

        /// <summary>
        /// Load Local Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LLDT.html</remarks>
        lldt,

        /// <summary>
        /// Load Machine Status Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LMSW.html</remarks>
        lmsw,

        /// <summary>
        /// Assert LOCK# Signal Prefix.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LOCK.html</remarks>
        @lock,

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html</remarks>
        lods,

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html</remarks>
        lodsb,

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html</remarks>
        lodsd,

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html</remarks>
        lodsq,

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html</remarks>
        lodsw,

        /// <summary>
        /// Loop According to ECX Counter.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LOOP:LOOPcc.html</remarks>
        loop,

        /// <summary>
        /// Loop According to ECX Counter.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LOOP:LOOPcc.html</remarks>
        loope,

        /// <summary>
        /// Loop According to ECX Counter.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LOOP:LOOPcc.html</remarks>
        loopne,

        /// <summary>
        /// Load Segment Limit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LSL.html</remarks>
        lsl,

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html</remarks>
        lss,

        /// <summary>
        /// Load Task Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LTR.html</remarks>
        ltr,

        /// <summary>
        /// Store Selected Bytes of Double Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MASKMOVDQU.html</remarks>
        maskmovdqu,

        /// <summary>
        /// Store Selected Bytes of Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MASKMOVQ.html</remarks>
        maskmovq,

        /// <summary>
        /// Maximum of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXPD.html</remarks>
        maxpd,

        /// <summary>
        /// Maximum of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXPS.html</remarks>
        maxps,

        /// <summary>
        /// Return Maximum Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXSD.html</remarks>
        maxsd,

        /// <summary>
        /// Return Maximum Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXSS.html</remarks>
        maxss,

        /// <summary>
        /// Minimum of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINPD.html</remarks>
        minpd,

        /// <summary>
        /// Minimum of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINPS.html</remarks>
        minps,

        /// <summary>
        /// Return Minimum Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINSD.html</remarks>
        minsd,

        /// <summary>
        /// Return Minimum Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINSS.html</remarks>
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
        /// </remarks>
        mov,

        /// <summary>
        /// Move Aligned Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVAPD.html</remarks>
        movapd,

        /// <summary>
        /// Move Aligned Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVAPS.html</remarks>
        movaps,

        /// <summary>
        /// Move Doubleword/Move Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVD:MOVQ.html</remarks>
        movd,

        /// <summary>
        /// Replicate Double FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDDUP.html</remarks>
        movddup,

        /// <summary>
        /// Move Aligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQA:VMOVDQA32:VMOVDQA64.html</remarks>
        movdqa,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html</remarks>
        movdqu,

        /// <summary>
        /// Move Packed Single-Precision Floating-Point Values High to Low.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVHLPS.html</remarks>
        movhlps,

        /// <summary>
        /// Move High Packed Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVHPD.html</remarks>
        movhpd,

        /// <summary>
        /// Move High Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVHPS.html</remarks>
        movhps,

        /// <summary>
        /// Move Packed Single-Precision Floating-Point Values Low to High.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVLHPS.html</remarks>
        movlhps,

        /// <summary>
        /// Move Low Packed Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVLPD.html</remarks>
        movlpd,

        /// <summary>
        /// Move Low Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVLPS.html</remarks>
        movlps,

        /// <summary>
        /// Extract Packed Double-Precision Floating-Point Sign Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVMSKPD.html</remarks>
        movmskpd,

        /// <summary>
        /// Extract Packed Single-Precision Floating-Point Sign Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVMSKPS.html</remarks>
        movmskps,

        /// <summary>
        /// Store Packed Integers Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTDQ.html</remarks>
        movntdq,

        /// <summary>
        /// Load Double Quadword Non-Temporal Aligned Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTDQA.html</remarks>
        movntdqa,

        /// <summary>
        /// Store Doubleword Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTI.html</remarks>
        movnti,

        /// <summary>
        /// Store Packed Double-Precision Floating-Point Values Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTPD.html</remarks>
        movntpd,

        /// <summary>
        /// Store Packed Single-Precision Floating-Point Values Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTPS.html</remarks>
        movntps,

        /// <summary>
        /// Store of Quadword Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTQ.html</remarks>
        movntq,

        /// <summary>
        /// Move Doubleword/Move Quadword.
        /// Move Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVD:MOVQ.html
        /// https://www.felixcloutier.com/x86/MOVQ.html
        /// </remarks>
        movq,

        /// <summary>
        /// Move Quadword from MMX Technology to XMM Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVQ2DQ.html</remarks>
        movq2dq,

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html</remarks>
        movs,

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html</remarks>
        movsb,

        /// <summary>
        /// Move Data from String to String.
        /// Move or Merge Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html
        /// https://www.felixcloutier.com/x86/MOVSD.html
        /// </remarks>
        movsd,

        /// <summary>
        /// Replicate Single FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSHDUP.html</remarks>
        movshdup,

        /// <summary>
        /// Replicate Single FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSLDUP.html</remarks>
        movsldup,

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html</remarks>
        movsq,

        /// <summary>
        /// Move or Merge Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSS.html</remarks>
        movss,

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html</remarks>
        movsw,

        /// <summary>
        /// Move with Sign-Extension.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSX:MOVSXD.html</remarks>
        movsx,

        /// <summary>
        /// Move with Sign-Extension.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSX:MOVSXD.html</remarks>
        movsxd,

        /// <summary>
        /// Move Unaligned Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVUPD.html</remarks>
        movupd,

        /// <summary>
        /// Move Unaligned Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVUPS.html</remarks>
        movups,

        /// <summary>
        /// Move with Zero-Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVZX.html</remarks>
        movzx,

        /// <summary>
        /// Compute Multiple Packed Sums of Absolute Difference.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MPSADBW.html</remarks>
        mpsadbw,

        /// <summary>
        /// Unsigned Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MUL.html</remarks>
        mul,

        /// <summary>
        /// Multiply Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULPD.html</remarks>
        mulpd,

        /// <summary>
        /// Multiply Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULPS.html</remarks>
        mulps,

        /// <summary>
        /// Multiply Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULSD.html</remarks>
        mulsd,

        /// <summary>
        /// Multiply Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULSS.html</remarks>
        mulss,

        /// <summary>
        /// Unsigned Multiply Without Affecting Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULX.html</remarks>
        mulx,

        /// <summary>
        /// Monitor Wait.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MWAIT.html</remarks>
        mwait,

        /// <summary>
        /// Two's Complement Negation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/NEG.html</remarks>
        neg,

        /// <summary>
        /// No Operation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/NOP.html</remarks>
        nop,

        /// <summary>
        /// One's Complement Negation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/NOT.html</remarks>
        not,

        /// <summary>
        /// Logical Inclusive OR.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OR.html</remarks>
        or,

        /// <summary>
        /// Bitwise Logical OR of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ORPD.html</remarks>
        orpd,

        /// <summary>
        /// Bitwise Logical OR of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ORPS.html</remarks>
        orps,

        /// <summary>
        /// Output to Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OUT.html</remarks>
        @out,

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html</remarks>
        outs,

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html</remarks>
        outsb,

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html</remarks>
        outsd,

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html</remarks>
        outsw,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html</remarks>
        pabsb,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html</remarks>
        pabsd,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html</remarks>
        pabsw,

        /// <summary>
        /// Pack with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKSSWB:PACKSSDW.html</remarks>
        packssdw,

        /// <summary>
        /// Pack with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKSSWB:PACKSSDW.html</remarks>
        packsswb,

        /// <summary>
        /// Pack with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKUSDW.html</remarks>
        packusdw,

        /// <summary>
        /// Pack with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKUSWB.html</remarks>
        packuswb,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        paddb,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        paddd,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        paddq,

        /// <summary>
        /// Add Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDSB:PADDSW.html</remarks>
        paddsb,

        /// <summary>
        /// Add Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDSB:PADDSW.html</remarks>
        paddsw,

        /// <summary>
        /// Add Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDUSB:PADDUSW.html</remarks>
        paddusb,

        /// <summary>
        /// Add Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDUSB:PADDUSW.html</remarks>
        paddusw,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        paddw,

        /// <summary>
        /// Packed Align Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PALIGNR.html</remarks>
        palignr,

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAND.html</remarks>
        pand,

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PANDN.html</remarks>
        pandn,

        /// <summary>
        /// Spin Loop Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAUSE.html</remarks>
        pause,

        /// <summary>
        /// Average Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAVGB:PAVGW.html</remarks>
        pavgb,

        /// <summary>
        /// Average Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAVGB:PAVGW.html</remarks>
        pavgw,

        /// <summary>
        /// Variable Blend Packed Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PBLENDVB.html</remarks>
        pblendvb,

        /// <summary>
        /// Blend Packed Words.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PBLENDW.html</remarks>
        pblendw,

        /// <summary>
        /// Carry-Less Multiplication Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCLMULQDQ.html</remarks>
        pclmulqdq,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html</remarks>
        pcmpeqb,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html</remarks>
        pcmpeqd,

        /// <summary>
        /// Compare Packed Qword Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQQ.html</remarks>
        pcmpeqq,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html</remarks>
        pcmpeqw,

        /// <summary>
        /// Packed Compare Explicit Length Strings, Return Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPESTRI.html</remarks>
        pcmpestri,

        /// <summary>
        /// Packed Compare Explicit Length Strings, Return Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPESTRM.html</remarks>
        pcmpestrm,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html</remarks>
        pcmpgtb,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html</remarks>
        pcmpgtd,

        /// <summary>
        /// Compare Packed Data for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTQ.html</remarks>
        pcmpgtq,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html</remarks>
        pcmpgtw,

        /// <summary>
        /// Packed Compare Implicit Length Strings, Return Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPISTRI.html</remarks>
        pcmpistri,

        /// <summary>
        /// Packed Compare Implicit Length Strings, Return Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPISTRM.html</remarks>
        pcmpistrm,

        /// <summary>
        /// Parallel Bits Deposit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PDEP.html</remarks>
        pdep,

        /// <summary>
        /// Parallel Bits Extract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXT.html</remarks>
        pext,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html</remarks>
        pextrb,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html</remarks>
        pextrd,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html</remarks>
        pextrq,

        /// <summary>
        /// Extract Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRW.html</remarks>
        pextrw,

        /// <summary>
        /// Packed Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHADDW:PHADDD.html</remarks>
        phaddd,

        /// <summary>
        /// Packed Horizontal Add and Saturate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHADDSW.html</remarks>
        phaddsw,

        /// <summary>
        /// Packed Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHADDW:PHADDD.html</remarks>
        phaddw,

        /// <summary>
        /// Packed Horizontal Word Minimum.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHMINPOSUW.html</remarks>
        phminposuw,

        /// <summary>
        /// Packed Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHSUBW:PHSUBD.html</remarks>
        phsubd,

        /// <summary>
        /// Packed Horizontal Subtract and Saturate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHSUBSW.html</remarks>
        phsubsw,

        /// <summary>
        /// Packed Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHSUBW:PHSUBD.html</remarks>
        phsubw,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html</remarks>
        pinsrb,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html</remarks>
        pinsrd,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html</remarks>
        pinsrq,

        /// <summary>
        /// Insert Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRW.html</remarks>
        pinsrw,

        /// <summary>
        /// Multiply and Add Packed Signed and Unsigned Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMADDUBSW.html</remarks>
        pmaddubsw,

        /// <summary>
        /// Multiply and Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMADDWD.html</remarks>
        pmaddwd,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html</remarks>
        pmaxsb,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html</remarks>
        pmaxsd,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html</remarks>
        pmaxsw,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXUB:PMAXUW.html</remarks>
        pmaxub,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXUD:PMAXUQ.html</remarks>
        pmaxud,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXUB:PMAXUW.html</remarks>
        pmaxuw,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINSB:PMINSW.html</remarks>
        pminsb,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINSD:PMINSQ.html</remarks>
        pminsd,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINSB:PMINSW.html</remarks>
        pminsw,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINUB:PMINUW.html</remarks>
        pminub,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINUD:PMINUQ.html</remarks>
        pminud,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINUB:PMINUW.html</remarks>
        pminuw,

        /// <summary>
        /// Move Byte Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVMSKB.html</remarks>
        pmovmskb,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        pmovsxbd,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        pmovsxbq,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        pmovsxbw,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        pmovsxdq,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        pmovsxwd,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        pmovsxwq,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        pmovzxbd,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        pmovzxbq,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        pmovzxbw,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        pmovzxdq,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        pmovzxwd,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        pmovzxwq,

        /// <summary>
        /// Multiply Packed Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULDQ.html</remarks>
        pmuldq,

        /// <summary>
        /// Packed Multiply High with Round and Scale.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULHRSW.html</remarks>
        pmulhrsw,

        /// <summary>
        /// Multiply Packed Unsigned Integers and Store High Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULHUW.html</remarks>
        pmulhuw,

        /// <summary>
        /// Multiply Packed Signed Integers and Store High Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULHW.html</remarks>
        pmulhw,

        /// <summary>
        /// Multiply Packed Integers and Store Low Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULLD:PMULLQ.html</remarks>
        pmulld,

        /// <summary>
        /// Multiply Packed Signed Integers and Store Low Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULLW.html</remarks>
        pmullw,

        /// <summary>
        /// Multiply Packed Unsigned Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULUDQ.html</remarks>
        pmuludq,

        /// <summary>
        /// Pop a Value from the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POP.html</remarks>
        pop,

        /// <summary>
        /// Pop All General-Purpose Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPA:POPAD.html</remarks>
        popa,

        /// <summary>
        /// Pop All General-Purpose Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPA:POPAD.html</remarks>
        popad,

        /// <summary>
        /// Return the Count of Number of Bits Set to 1.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPCNT.html</remarks>
        popcnt,

        /// <summary>
        /// Pop Stack into EFLAGS Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPF:POPFD:POPFQ.html</remarks>
        popf,

        /// <summary>
        /// Pop Stack into EFLAGS Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPF:POPFD:POPFQ.html</remarks>
        popfd,

        /// <summary>
        /// Pop Stack into EFLAGS Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPF:POPFD:POPFQ.html</remarks>
        popfq,

        /// <summary>
        /// Bitwise Logical OR.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POR.html</remarks>
        por,

        /// <summary>
        /// Prefetch Data Into Caches.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PREFETCHh.html</remarks>
        prefetchnta,

        /// <summary>
        /// Prefetch Data Into Caches.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PREFETCHh.html</remarks>
        prefetcht0,

        /// <summary>
        /// Prefetch Data Into Caches.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PREFETCHh.html</remarks>
        prefetcht1,

        /// <summary>
        /// Prefetch Data Into Caches.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PREFETCHh.html</remarks>
        prefetcht2,

        /// <summary>
        /// Prefetch Data into Caches in Anticipation of a Write.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PREFETCHW.html</remarks>
        prefetchw,

        /// <summary>
        /// Compute Sum of Absolute Differences.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSADBW.html</remarks>
        psadbw,

        /// <summary>
        /// Packed Shuffle Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFB.html</remarks>
        pshufb,

        /// <summary>
        /// Shuffle Packed Doublewords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFD.html</remarks>
        pshufd,

        /// <summary>
        /// Shuffle Packed High Words.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFHW.html</remarks>
        pshufhw,

        /// <summary>
        /// Shuffle Packed Low Words.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFLW.html</remarks>
        pshuflw,

        /// <summary>
        /// Shuffle Packed Words.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFW.html</remarks>
        pshufw,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html</remarks>
        psignb,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html</remarks>
        psignd,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html</remarks>
        psignw,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html</remarks>
        pslld,

        /// <summary>
        /// Shift Double Quadword Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLDQ.html</remarks>
        pslldq,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html</remarks>
        psllq,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html</remarks>
        psllw,

        /// <summary>
        /// Shift Packed Data Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRAW:PSRAD:PSRAQ.html</remarks>
        psrad,

        /// <summary>
        /// Shift Packed Data Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRAW:PSRAD:PSRAQ.html</remarks>
        psraw,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html</remarks>
        psrld,

        /// <summary>
        /// Shift Double Quadword Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLDQ.html</remarks>
        psrldq,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html</remarks>
        psrlq,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html</remarks>
        psrlw,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html</remarks>
        psubb,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html</remarks>
        psubd,

        /// <summary>
        /// Subtract Packed Quadword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBQ.html</remarks>
        psubq,

        /// <summary>
        /// Subtract Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBSB:PSUBSW.html</remarks>
        psubsb,

        /// <summary>
        /// Subtract Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBSB:PSUBSW.html</remarks>
        psubsw,

        /// <summary>
        /// Subtract Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBUSB:PSUBUSW.html</remarks>
        psubusb,

        /// <summary>
        /// Subtract Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBUSB:PSUBUSW.html</remarks>
        psubusw,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html</remarks>
        psubw,

        /// <summary>
        /// Logical Compare.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PTEST.html</remarks>
        ptest,

        /// <summary>
        /// Write Data to a Processor Trace Packet.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PTWRITE.html</remarks>
        ptwrite,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        punpckhbw,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        punpckhdq,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        punpckhqdq,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        punpckhwd,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        punpcklbw,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        punpckldq,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        punpcklqdq,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        punpcklwd,

        /// <summary>
        /// Push Word, Doubleword or Quadword Onto the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSH.html</remarks>
        push,

        /// <summary>
        /// Push All General-Purpose Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSHA:PUSHAD.html</remarks>
        pusha,

        /// <summary>
        /// Push All General-Purpose Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSHA:PUSHAD.html</remarks>
        pushad,

        /// <summary>
        /// Push EFLAGS Register onto the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSHF:PUSHFD:PUSHFQ.html</remarks>
        pushf,

        /// <summary>
        /// Push EFLAGS Register onto the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSHF:PUSHFD:PUSHFQ.html</remarks>
        pushfd,

        /// <summary>
        /// Push EFLAGS Register onto the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSHF:PUSHFD:PUSHFQ.html</remarks>
        pushfq,

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html</remarks>
        rcl,

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html</remarks>
        rcr,

        /// <summary>
        /// Read FS/GS Segment Base.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDFSBASE:RDGSBASE.html</remarks>
        rdfsbase,

        /// <summary>
        /// Read FS/GS Segment Base.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDFSBASE:RDGSBASE.html</remarks>
        rdgsbase,

        /// <summary>
        /// Read Processor ID.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDPID.html</remarks>
        rdpid,

        /// <summary>
        /// Read Protection Key Rights for User Pages.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDPKRU.html</remarks>
        rdpkru,

        /// <summary>
        /// Read Performance-Monitoring Counters.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDPMC.html</remarks>
        rdpmc,

        /// <summary>
        /// Read Random SEED.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDSEED.html</remarks>
        rdseed,

        /// <summary>
        /// Read Time-Stamp Counter.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDTSC.html</remarks>
        rdtsc,

        /// <summary>
        /// Read Time-Stamp Counter and Processor ID.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDTSCP.html</remarks>
        rdtscp,

        /// <summary>
        /// Repeat String Operation Prefix.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/REP:REPE:REPZ:REPNE:REPNZ.html</remarks>
        rep,

        /// <summary>
        /// Repeat String Operation Prefix.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/REP:REPE:REPZ:REPNE:REPNZ.html</remarks>
        repe,

        /// <summary>
        /// Repeat String Operation Prefix.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/REP:REPE:REPZ:REPNE:REPNZ.html</remarks>
        repne,

        /// <summary>
        /// Return from Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RET.html</remarks>
        ret,

        /// <summary>
        /// Return from Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RET.html</remarks>
        retf,

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html</remarks>
        rol,

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html</remarks>
        ror,

        /// <summary>
        /// Rotate Right Logical Without Affecting Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RORX.html</remarks>
        rorx,

        /// <summary>
        /// Resume from System Management Mode.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RSM.html</remarks>
        rsm,

        /// <summary>
        /// Store AH into Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SAHF.html</remarks>
        sahf,

        /// <summary>
        /// Shift.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SAL:SAR:SHL:SHR.html</remarks>
        sal,

        /// <summary>
        /// Shift.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SAL:SAR:SHL:SHR.html</remarks>
        sar,

        /// <summary>
        /// Shift Without Affecting Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SARX:SHLX:SHRX.html</remarks>
        sarx,

        /// <summary>
        /// Integer Subtraction with Borrow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SBB.html</remarks>
        sbb,

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html</remarks>
        scas,

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html</remarks>
        scasb,

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html</remarks>
        scasd,

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html</remarks>
        scasq,

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html</remarks>
        scasw,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        seta,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setae,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setb,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setbe,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setc,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        sete,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setg,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setge,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setl,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setle,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setna,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setnae,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setnb,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setnbe,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setnc,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setne,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setng,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setnge,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setnl,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setnle,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setno,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setnp,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setns,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setnz,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        seto,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setp,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setpe,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setpo,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        sets,

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        setz,

        /// <summary>
        /// Store Fence.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SFENCE.html</remarks>
        sfence,

        /// <summary>
        /// Perform an Intermediate Calculation for the Next Four SHA1 Message Dwords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA1MSG1.html</remarks>
        sha1msg1,

        /// <summary>
        /// Perform a Final Calculation for the Next Four SHA1 Message Dwords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA1MSG2.html</remarks>
        sha1msg2,

        /// <summary>
        /// Calculate SHA1 State Variable E after Four Rounds.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA1NEXTE.html</remarks>
        sha1nexte,

        /// <summary>
        /// Perform Four Rounds of SHA1 Operation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA1RNDS4.html</remarks>
        sha1rnds4,

        /// <summary>
        /// Perform an Intermediate Calculation for the Next Four SHA256 Message Dwords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA256MSG1.html</remarks>
        sha256msg1,

        /// <summary>
        /// Perform a Final Calculation for the Next Four SHA256 Message Dwords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA256MSG2.html</remarks>
        sha256msg2,

        /// <summary>
        /// Perform Two Rounds of SHA256 Operation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA256RNDS2.html</remarks>
        sha256rnds2,

        /// <summary>
        /// Shift.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SAL:SAR:SHL:SHR.html</remarks>
        shl,

        /// <summary>
        /// Double Precision Shift Left.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHLD.html</remarks>
        shld,

        /// <summary>
        /// Shift Without Affecting Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SARX:SHLX:SHRX.html</remarks>
        shlx,

        /// <summary>
        /// Double Precision Shift Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHRD.html</remarks>
        shrd,

        /// <summary>
        /// Shift Without Affecting Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SARX:SHLX:SHRX.html</remarks>
        shrx,

        /// <summary>
        /// Packed Interleave Shuffle of Pairs of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHUFPD.html</remarks>
        shufpd,

        /// <summary>
        /// Packed Interleave Shuffle of Quadruplets of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHUFPS.html</remarks>
        shufps,

        /// <summary>
        /// Store Interrupt Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SIDT.html</remarks>
        sidt,

        /// <summary>
        /// Store Local Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SLDT.html</remarks>
        sldt,

        /// <summary>
        /// Store Machine Status Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SMSW.html</remarks>
        smsw,

        /// <summary>
        /// Square Root of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTPD.html</remarks>
        sqrtpd,

        /// <summary>
        /// Square Root of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTPS.html</remarks>
        sqrtps,

        /// <summary>
        /// Compute Square Root of Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTSD.html</remarks>
        sqrtsd,

        /// <summary>
        /// Compute Square Root of Scalar Single-Precision Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTSS.html</remarks>
        sqrtss,

        /// <summary>
        /// Set AC Flag in EFLAGS Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STAC.html</remarks>
        stac,

        /// <summary>
        /// Set Carry Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STC.html</remarks>
        stc,

        /// <summary>
        /// Set Direction Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STD.html</remarks>
        std,

        /// <summary>
        /// Set Interrupt Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STI.html</remarks>
        sti,

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html</remarks>
        stos,

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html</remarks>
        stosb,

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html</remarks>
        stosd,

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html</remarks>
        stosq,

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html</remarks>
        stosw,

        /// <summary>
        /// Store Task Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STR.html</remarks>
        str,

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUB.html</remarks>
        sub,

        /// <summary>
        /// Subtract Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBPD.html</remarks>
        subpd,

        /// <summary>
        /// Subtract Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBPS.html</remarks>
        subps,

        /// <summary>
        /// Subtract Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBSD.html</remarks>
        subsd,

        /// <summary>
        /// Subtract Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBSS.html</remarks>
        subss,

        /// <summary>
        /// Swap GS Base Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SWAPGS.html</remarks>
        swapgs,

        /// <summary>
        /// Fast System Call.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SYSCALL.html</remarks>
        syscall,

        /// <summary>
        /// Fast System Call.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SYSENTER.html</remarks>
        sysenter,

        /// <summary>
        /// Fast Return from Fast System Call.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SYSEXIT.html</remarks>
        sysexit,

        /// <summary>
        /// Return From Fast System Call.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SYSRET.html</remarks>
        sysret,

        /// <summary>
        /// Logical Compare.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/TEST.html</remarks>
        test,

        /// <summary>
        /// Count the Number of Trailing Zero Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/TZCNT.html</remarks>
        tzcnt,

        /// <summary>
        /// Unordered Compare Scalar Double-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UCOMISD.html</remarks>
        ucomisd,

        /// <summary>
        /// Unordered Compare Scalar Single-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UCOMISS.html</remarks>
        ucomiss,

        /// <summary>
        /// Undefined Instruction.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UD.html</remarks>
        ud01,

        /// <summary>
        /// Undefined Instruction.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UD.html</remarks>
        ud1,

        /// <summary>
        /// Undefined Instruction.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UD.html</remarks>
        ud2,

        /// <summary>
        /// Unpack and Interleave High Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKHPD.html</remarks>
        unpckhpd,

        /// <summary>
        /// Unpack and Interleave High Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKHPS.html</remarks>
        unpckhps,

        /// <summary>
        /// Unpack and Interleave Low Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKLPD.html</remarks>
        unpcklpd,

        /// <summary>
        /// Unpack and Interleave Low Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKLPS.html</remarks>
        unpcklps,

        /// <summary>
        /// Add Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDPD.html</remarks>
        vaddpd,

        /// <summary>
        /// Add Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDPS.html</remarks>
        vaddps,

        /// <summary>
        /// Add Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSD.html</remarks>
        vaddsd,

        /// <summary>
        /// Add Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSS.html</remarks>
        vaddss,

        /// <summary>
        /// Packed Double-FP Add/Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSUBPD.html</remarks>
        vaddsubpd,

        /// <summary>
        /// Packed Single-FP Add/Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSUBPS.html</remarks>
        vaddsubps,

        /// <summary>
        /// Perform One Round of an AES Decryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESDEC.html</remarks>
        vaesdec,

        /// <summary>
        /// Perform Last Round of an AES Decryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESDECLAST.html</remarks>
        vaesdeclast,

        /// <summary>
        /// Perform One Round of an AES Encryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESENC.html</remarks>
        vaesenc,

        /// <summary>
        /// Perform Last Round of an AES Encryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESENCLAST.html</remarks>
        vaesenclast,

        /// <summary>
        /// Perform the AES InvMixColumn Transformation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESIMC.html</remarks>
        vaesimc,

        /// <summary>
        /// AES Round Key Generation Assist.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESKEYGENASSIST.html</remarks>
        vaeskeygenassist,

        /// <summary>
        /// Align Doubleword/Quadword Vectors.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VALIGND:VALIGNQ.html</remarks>
        valignd,

        /// <summary>
        /// Align Doubleword/Quadword Vectors.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VALIGND:VALIGNQ.html</remarks>
        valignq,

        /// <summary>
        /// Bitwise Logical AND NOT of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDNPD.html</remarks>
        vandnpd,

        /// <summary>
        /// Bitwise Logical AND NOT of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDNPS.html</remarks>
        vandnps,

        /// <summary>
        /// Bitwise Logical AND of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDPD.html</remarks>
        vandpd,

        /// <summary>
        /// Bitwise Logical AND of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDPS.html</remarks>
        vandps,

        /// <summary>
        /// Blend Float64/Float32 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBLENDMPD:VBLENDMPS.html</remarks>
        vblendmpd,

        /// <summary>
        /// Blend Float64/Float32 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBLENDMPD:VBLENDMPS.html</remarks>
        vblendmps,

        /// <summary>
        /// Blend Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDPD.html</remarks>
        vblendpd,

        /// <summary>
        /// Blend Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDPS.html</remarks>
        vblendps,

        /// <summary>
        /// Variable Blend Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDVPD.html</remarks>
        vblendvpd,

        /// <summary>
        /// Variable Blend Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDVPS.html</remarks>
        vblendvps,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBROADCAST.html</remarks>
        vbroadcastf128,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBROADCAST.html</remarks>
        vbroadcastf32x2,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBROADCAST.html</remarks>
        vbroadcastf32x4,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBROADCAST.html</remarks>
        vbroadcastf32x8,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBROADCAST.html</remarks>
        vbroadcastf64x2,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBROADCAST.html</remarks>
        vbroadcastf64x4,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCAST.html</remarks>
        vbroadcasti128,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCAST.html</remarks>
        vbroadcasti32x2,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCAST.html</remarks>
        vbroadcasti32x4,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCAST.html</remarks>
        vbroadcasti32x8,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCAST.html</remarks>
        vbroadcasti64x2,

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCAST.html</remarks>
        vbroadcasti64x4,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBROADCAST.html</remarks>
        vbroadcastsd,

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBROADCAST.html</remarks>
        vbroadcastss,

        /// <summary>
        /// Compare Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPPD.html</remarks>
        vcmppd,

        /// <summary>
        /// Compare Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPPS.html</remarks>
        vcmpps,

        /// <summary>
        /// Compare Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPSD.html</remarks>
        vcmpsd,

        /// <summary>
        /// Compare Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPSS.html</remarks>
        vcmpss,

        /// <summary>
        /// Compare Scalar Ordered Double-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/COMISD.html</remarks>
        vcomisd,

        /// <summary>
        /// Compare Scalar Ordered Single-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/COMISS.html</remarks>
        vcomiss,

        /// <summary>
        /// Store Sparse Packed Double-Precision Floating-Point Values into Dense Memory.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCOMPRESSPD.html</remarks>
        vcompresspd,

        /// <summary>
        /// Store Sparse Packed Single-Precision Floating-Point Values into Dense Memory.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCOMPRESSPS.html</remarks>
        vcompressps,

        /// <summary>
        /// Convert Packed Doubleword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTDQ2PD.html</remarks>
        vcvtdq2pd,

        /// <summary>
        /// Convert Packed Doubleword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTDQ2PS.html</remarks>
        vcvtdq2ps,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPD2DQ.html</remarks>
        vcvtpd2dq,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPD2PS.html</remarks>
        vcvtpd2ps,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Quadword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPD2QQ.html</remarks>
        vcvtpd2qq,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Unsigned Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPD2UDQ.html</remarks>
        vcvtpd2udq,

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Unsigned Quadword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPD2UQQ.html</remarks>
        vcvtpd2uqq,

        /// <summary>
        /// Convert 16-bit FP values to Single-Precision FP values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPH2PS.html</remarks>
        vcvtph2ps,

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPS2DQ.html</remarks>
        vcvtps2dq,

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPS2PD.html</remarks>
        vcvtps2pd,

        /// <summary>
        /// Convert Single-Precision FP value to 16-bit FP value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPS2PH.html</remarks>
        vcvtps2ph,

        /// <summary>
        /// Convert Packed Single Precision Floating-Point Values to Packed Singed Quadword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPS2QQ.html</remarks>
        vcvtps2qq,

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Unsigned Doubleword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPS2UDQ.html</remarks>
        vcvtps2udq,

        /// <summary>
        /// Convert Packed Single Precision Floating-Point Values to Packed Unsigned Quadword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPS2UQQ.html</remarks>
        vcvtps2uqq,

        /// <summary>
        /// Convert Packed Quadword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTQQ2PD.html</remarks>
        vcvtqq2pd,

        /// <summary>
        /// Convert Packed Quadword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTQQ2PS.html</remarks>
        vcvtqq2ps,

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Doubleword Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSD2SI.html</remarks>
        vcvtsd2si,

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSD2SS.html</remarks>
        vcvtsd2ss,

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Unsigned Doubleword Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTSD2USI.html</remarks>
        vcvtsd2usi,

        /// <summary>
        /// Convert Doubleword Integer to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSI2SD.html</remarks>
        vcvtsi2sd,

        /// <summary>
        /// Convert Doubleword Integer to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSI2SS.html</remarks>
        vcvtsi2ss,

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSS2SD.html</remarks>
        vcvtss2sd,

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Doubleword Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSS2SI.html</remarks>
        vcvtss2si,

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Unsigned Doubleword Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTSS2USI.html</remarks>
        vcvtss2usi,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTPD2DQ.html</remarks>
        vcvttpd2dq,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Quadword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPD2QQ.html</remarks>
        vcvttpd2qq,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Unsigned Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPD2UDQ.html</remarks>
        vcvttpd2udq,

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Unsigned Quadword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPD2UQQ.html</remarks>
        vcvttpd2uqq,

        /// <summary>
        /// Convert with Truncation Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTPS2DQ.html</remarks>
        vcvttps2dq,

        /// <summary>
        /// Convert with Truncation Packed Single Precision Floating-Point Values to Packed Singed Quadword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPS2QQ.html</remarks>
        vcvttps2qq,

        /// <summary>
        /// Convert with Truncation Packed Single-Precision Floating-Point Values to Packed Unsigned Doubleword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPS2UDQ.html</remarks>
        vcvttps2udq,

        /// <summary>
        /// Convert with Truncation Packed Single Precision Floating-Point Values to Packed Unsigned Quadword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPS2UQQ.html</remarks>
        vcvttps2uqq,

        /// <summary>
        /// Convert with Truncation Scalar Double-Precision Floating-Point Value to Signed Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTSD2SI.html</remarks>
        vcvttsd2si,

        /// <summary>
        /// Convert with Truncation Scalar Double-Precision Floating-Point Value to Unsigned Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTSD2USI.html</remarks>
        vcvttsd2usi,

        /// <summary>
        /// Convert with Truncation Scalar Single-Precision Floating-Point Value to Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTSS2SI.html</remarks>
        vcvttss2si,

        /// <summary>
        /// Convert with Truncation Scalar Single-Precision Floating-Point Value to Unsigned Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTSS2USI.html</remarks>
        vcvttss2usi,

        /// <summary>
        /// Convert Packed Unsigned Doubleword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUDQ2PD.html</remarks>
        vcvtudq2pd,

        /// <summary>
        /// Convert Packed Unsigned Doubleword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUDQ2PS.html</remarks>
        vcvtudq2ps,

        /// <summary>
        /// Convert Packed Unsigned Quadword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUQQ2PD.html</remarks>
        vcvtuqq2pd,

        /// <summary>
        /// Convert Packed Unsigned Quadword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUQQ2PS.html</remarks>
        vcvtuqq2ps,

        /// <summary>
        /// Convert Unsigned Integer to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUSI2SD.html</remarks>
        vcvtusi2sd,

        /// <summary>
        /// Convert Unsigned Integer to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUSI2SS.html</remarks>
        vcvtusi2ss,

        /// <summary>
        /// Double Block Packed Sum-Absolute-Differences (SAD) on Unsigned Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VDBPSADBW.html</remarks>
        vdbpsadbw,

        /// <summary>
        /// Divide Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVPD.html</remarks>
        vdivpd,

        /// <summary>
        /// Divide Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVPS.html</remarks>
        vdivps,

        /// <summary>
        /// Divide Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVSD.html</remarks>
        vdivsd,

        /// <summary>
        /// Divide Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVSS.html</remarks>
        vdivss,

        /// <summary>
        /// Dot Product of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DPPD.html</remarks>
        vdppd,

        /// <summary>
        /// Dot Product of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DPPS.html</remarks>
        vdpps,

        /// <summary>
        /// Verify a Segment for Reading or Writing.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VERR:VERW.html</remarks>
        verr,

        /// <summary>
        /// Verify a Segment for Reading or Writing.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VERR:VERW.html</remarks>
        verw,

        /// <summary>
        /// Load Sparse Packed Double-Precision Floating-Point Values from Dense Memory.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXPANDPD.html</remarks>
        vexpandpd,

        /// <summary>
        /// Load Sparse Packed Single-Precision Floating-Point Values from Dense Memory.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXPANDPS.html</remarks>
        vexpandps,

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html</remarks>
        vextractf128,

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html</remarks>
        vextractf32x4,

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html</remarks>
        vextractf32x8,

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html</remarks>
        vextractf64x2,

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html</remarks>
        vextractf64x4,

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html</remarks>
        vextracti128,

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html</remarks>
        vextracti32x4,

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html</remarks>
        vextracti32x8,

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html</remarks>
        vextracti64x2,

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html</remarks>
        vextracti64x4,

        /// <summary>
        /// Extract Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/EXTRACTPS.html</remarks>
        vextractps,

        /// <summary>
        /// Fix Up Special Packed Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFIXUPIMMPD.html</remarks>
        vfixupimmpd,

        /// <summary>
        /// Fix Up Special Packed Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFIXUPIMMPS.html</remarks>
        vfixupimmps,

        /// <summary>
        /// Fix Up Special Scalar Float64 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFIXUPIMMSD.html</remarks>
        vfixupimmsd,

        /// <summary>
        /// Fix Up Special Scalar Float32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFIXUPIMMSS.html</remarks>
        vfixupimmss,

        /// <summary>
        /// Fused Multiply-Add of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PD:VFMADD213PD:VFMADD231PD.html</remarks>
        vfmadd132pd,

        /// <summary>
        /// Fused Multiply-Add of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PS:VFMADD213PS:VFMADD231PS.html</remarks>
        vfmadd132ps,

        /// <summary>
        /// Fused Multiply-Add of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SD:VFMADD213SD:VFMADD231SD.html</remarks>
        vfmadd132sd,

        /// <summary>
        /// Fused Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SS:VFMADD213SS:VFMADD231SS.html</remarks>
        vfmadd132ss,

        /// <summary>
        /// Fused Multiply-Add of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PD:VFMADD213PD:VFMADD231PD.html</remarks>
        vfmadd213pd,

        /// <summary>
        /// Fused Multiply-Add of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PS:VFMADD213PS:VFMADD231PS.html</remarks>
        vfmadd213ps,

        /// <summary>
        /// Fused Multiply-Add of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SD:VFMADD213SD:VFMADD231SD.html</remarks>
        vfmadd213sd,

        /// <summary>
        /// Fused Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SS:VFMADD213SS:VFMADD231SS.html</remarks>
        vfmadd213ss,

        /// <summary>
        /// Fused Multiply-Add of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PD:VFMADD213PD:VFMADD231PD.html</remarks>
        vfmadd231pd,

        /// <summary>
        /// Fused Multiply-Add of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PS:VFMADD213PS:VFMADD231PS.html</remarks>
        vfmadd231ps,

        /// <summary>
        /// Fused Multiply-Add of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SD:VFMADD213SD:VFMADD231SD.html</remarks>
        vfmadd231sd,

        /// <summary>
        /// Fused Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SS:VFMADD213SS:VFMADD231SS.html</remarks>
        vfmadd231ss,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PD:VFMADDSUB213PD:VFMADDSUB231PD.html</remarks>
        vfmaddsub132pd,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PS:VFMADDSUB213PS:VFMADDSUB231PS.html</remarks>
        vfmaddsub132ps,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PD:VFMADDSUB213PD:VFMADDSUB231PD.html</remarks>
        vfmaddsub213pd,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PS:VFMADDSUB213PS:VFMADDSUB231PS.html</remarks>
        vfmaddsub213ps,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PD:VFMADDSUB213PD:VFMADDSUB231PD.html</remarks>
        vfmaddsub231pd,

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PS:VFMADDSUB213PS:VFMADDSUB231PS.html</remarks>
        vfmaddsub231ps,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PD:VFMSUB213PD:VFMSUB231PD.html</remarks>
        vfmsub132pd,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PS:VFMSUB213PS:VFMSUB231PS.html</remarks>
        vfmsub132ps,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SD:VFMSUB213SD:VFMSUB231SD.html</remarks>
        vfmsub132sd,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SS:VFMSUB213SS:VFMSUB231SS.html</remarks>
        vfmsub132ss,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PD:VFMSUB213PD:VFMSUB231PD.html</remarks>
        vfmsub213pd,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PS:VFMSUB213PS:VFMSUB231PS.html</remarks>
        vfmsub213ps,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SD:VFMSUB213SD:VFMSUB231SD.html</remarks>
        vfmsub213sd,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SS:VFMSUB213SS:VFMSUB231SS.html</remarks>
        vfmsub213ss,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PD:VFMSUB213PD:VFMSUB231PD.html</remarks>
        vfmsub231pd,

        /// <summary>
        /// Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PS:VFMSUB213PS:VFMSUB231PS.html</remarks>
        vfmsub231ps,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SD:VFMSUB213SD:VFMSUB231SD.html</remarks>
        vfmsub231sd,

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SS:VFMSUB213SS:VFMSUB231SS.html</remarks>
        vfmsub231ss,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PD:VFMSUBADD213PD:VFMSUBADD231PD.html</remarks>
        vfmsubadd132pd,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PS:VFMSUBADD213PS:VFMSUBADD231PS.html</remarks>
        vfmsubadd132ps,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PD:VFMSUBADD213PD:VFMSUBADD231PD.html</remarks>
        vfmsubadd213pd,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PS:VFMSUBADD213PS:VFMSUBADD231PS.html</remarks>
        vfmsubadd213ps,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PD:VFMSUBADD213PD:VFMSUBADD231PD.html</remarks>
        vfmsubadd231pd,

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PS:VFMSUBADD213PS:VFMSUBADD231PS.html</remarks>
        vfmsubadd231ps,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PD:VFNMADD213PD:VFNMADD231PD.html</remarks>
        vfnmadd132pd,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PS:VFNMADD213PS:VFNMADD231PS.html</remarks>
        vfnmadd132ps,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SD:VFNMADD213SD:VFNMADD231SD.html</remarks>
        vfnmadd132sd,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SS:VFNMADD213SS:VFNMADD231SS.html</remarks>
        vfnmadd132ss,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PD:VFNMADD213PD:VFNMADD231PD.html</remarks>
        vfnmadd213pd,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PS:VFNMADD213PS:VFNMADD231PS.html</remarks>
        vfnmadd213ps,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SD:VFNMADD213SD:VFNMADD231SD.html</remarks>
        vfnmadd213sd,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SS:VFNMADD213SS:VFNMADD231SS.html</remarks>
        vfnmadd213ss,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PD:VFNMADD213PD:VFNMADD231PD.html</remarks>
        vfnmadd231pd,

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PS:VFNMADD213PS:VFNMADD231PS.html</remarks>
        vfnmadd231ps,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SD:VFNMADD213SD:VFNMADD231SD.html</remarks>
        vfnmadd231sd,

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SS:VFNMADD213SS:VFNMADD231SS.html</remarks>
        vfnmadd231ss,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PD:VFNMSUB213PD:VFNMSUB231PD.html</remarks>
        vfnmsub132pd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PS:VFNMSUB213PS:VFNMSUB231PS.html</remarks>
        vfnmsub132ps,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SD:VFNMSUB213SD:VFNMSUB231SD.html</remarks>
        vfnmsub132sd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SS:VFNMSUB213SS:VFNMSUB231SS.html</remarks>
        vfnmsub132ss,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PD:VFNMSUB213PD:VFNMSUB231PD.html</remarks>
        vfnmsub213pd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PS:VFNMSUB213PS:VFNMSUB231PS.html</remarks>
        vfnmsub213ps,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SD:VFNMSUB213SD:VFNMSUB231SD.html</remarks>
        vfnmsub213sd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SS:VFNMSUB213SS:VFNMSUB231SS.html</remarks>
        vfnmsub213ss,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PD:VFNMSUB213PD:VFNMSUB231PD.html</remarks>
        vfnmsub231pd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PS:VFNMSUB213PS:VFNMSUB231PS.html</remarks>
        vfnmsub231ps,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SD:VFNMSUB213SD:VFNMSUB231SD.html</remarks>
        vfnmsub231sd,

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SS:VFNMSUB213SS:VFNMSUB231SS.html</remarks>
        vfnmsub231ss,

        /// <summary>
        /// Tests Types Of a Packed Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFPCLASSPD.html</remarks>
        vfpclasspd,

        /// <summary>
        /// Tests Types Of a Packed Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFPCLASSPS.html</remarks>
        vfpclassps,

        /// <summary>
        /// Tests Types Of a Scalar Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFPCLASSSD.html</remarks>
        vfpclasssd,

        /// <summary>
        /// Tests Types Of a Scalar Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFPCLASSSS.html</remarks>
        vfpclassss,

        /// <summary>
        /// Gather Packed DP FP Values Using Signed Dword/Qword Indices.
        /// Gather Packed Single, Packed Double with Signed Dword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGATHERDPD:VGATHERQPD.html
        /// https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERDPD.html
        /// </remarks>
        vgatherdpd,

        /// <summary>
        /// Gather Packed Single, Packed Double with Signed Dword.
        /// Gather Packed SP FP values Using Signed Dword/Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERDPD.html
        /// https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERQPS.html
        /// </remarks>
        vgatherdps,

        /// <summary>
        /// Gather Packed DP FP Values Using Signed Dword/Qword Indices.
        /// Gather Packed Single, Packed Double with Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGATHERDPD:VGATHERQPD.html
        /// https://www.felixcloutier.com/x86/VGATHERQPS:VGATHERQPD.html
        /// </remarks>
        vgatherqpd,

        /// <summary>
        /// Gather Packed SP FP values Using Signed Dword/Qword Indices.
        /// Gather Packed Single, Packed Double with Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERQPS.html
        /// https://www.felixcloutier.com/x86/VGATHERQPS:VGATHERQPD.html
        /// </remarks>
        vgatherqps,

        /// <summary>
        /// Convert Exponents of Packed DP FP Values to DP FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETEXPPD.html</remarks>
        vgetexppd,

        /// <summary>
        /// Convert Exponents of Packed SP FP Values to SP FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETEXPPS.html</remarks>
        vgetexpps,

        /// <summary>
        /// Convert Exponents of Scalar DP FP Values to DP FP Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETEXPSD.html</remarks>
        vgetexpsd,

        /// <summary>
        /// Convert Exponents of Scalar SP FP Values to SP FP Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETEXPSS.html</remarks>
        vgetexpss,

        /// <summary>
        /// Extract Float64 Vector of Normalized Mantissas from Float64 Vector.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETMANTPD.html</remarks>
        vgetmantpd,

        /// <summary>
        /// Extract Float32 Vector of Normalized Mantissas from Float32 Vector.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETMANTPS.html</remarks>
        vgetmantps,

        /// <summary>
        /// Extract Float64 of Normalized Mantissas from Float64 Scalar.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETMANTSD.html</remarks>
        vgetmantsd,

        /// <summary>
        /// Extract Float32 Vector of Normalized Mantissa from Float32 Vector.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETMANTSS.html</remarks>
        vgetmantss,

        /// <summary>
        /// Packed Double-FP Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HADDPD.html</remarks>
        vhaddpd,

        /// <summary>
        /// Packed Single-FP Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HADDPS.html</remarks>
        vhaddps,

        /// <summary>
        /// Packed Double-FP Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HSUBPD.html</remarks>
        vhsubpd,

        /// <summary>
        /// Packed Single-FP Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HSUBPS.html</remarks>
        vhsubps,

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html</remarks>
        vinsertf128,

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html</remarks>
        vinsertf32x4,

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html</remarks>
        vinsertf32x8,

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html</remarks>
        vinsertf64x2,

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html</remarks>
        vinsertf64x4,

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html</remarks>
        vinserti128,

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html</remarks>
        vinserti32x4,

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html</remarks>
        vinserti32x8,

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html</remarks>
        vinserti64x2,

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html</remarks>
        vinserti64x4,

        /// <summary>
        /// Insert Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INSERTPS.html</remarks>
        vinsertps,

        /// <summary>
        /// Load Unaligned Integer 128 Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDDQU.html</remarks>
        vlddqu,

        /// <summary>
        /// Load MXCSR Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDMXCSR.html</remarks>
        vldmxcsr,

        /// <summary>
        /// Store Selected Bytes of Double Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MASKMOVDQU.html</remarks>
        vmaskmovdqu,

        /// <summary>
        /// Conditional SIMD Packed Loads and Stores.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VMASKMOV.html</remarks>
        vmaskmovpd,

        /// <summary>
        /// Conditional SIMD Packed Loads and Stores.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VMASKMOV.html</remarks>
        vmaskmovps,

        /// <summary>
        /// Maximum of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXPD.html</remarks>
        vmaxpd,

        /// <summary>
        /// Maximum of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXPS.html</remarks>
        vmaxps,

        /// <summary>
        /// Return Maximum Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXSD.html</remarks>
        vmaxsd,

        /// <summary>
        /// Return Maximum Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXSS.html</remarks>
        vmaxss,

        /// <summary>
        /// Minimum of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINPD.html</remarks>
        vminpd,

        /// <summary>
        /// Minimum of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINPS.html</remarks>
        vminps,

        /// <summary>
        /// Return Minimum Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINSD.html</remarks>
        vminsd,

        /// <summary>
        /// Return Minimum Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINSS.html</remarks>
        vminss,

        /// <summary>
        /// Move Aligned Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVAPD.html</remarks>
        vmovapd,

        /// <summary>
        /// Move Aligned Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVAPS.html</remarks>
        vmovaps,

        /// <summary>
        /// Move Doubleword/Move Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVD:MOVQ.html</remarks>
        vmovd,

        /// <summary>
        /// Replicate Double FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDDUP.html</remarks>
        vmovddup,

        /// <summary>
        /// Move Aligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQA:VMOVDQA32:VMOVDQA64.html</remarks>
        vmovdqa,

        /// <summary>
        /// Move Aligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQA:VMOVDQA32:VMOVDQA64.html</remarks>
        vmovdqa32,

        /// <summary>
        /// Move Aligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQA:VMOVDQA32:VMOVDQA64.html</remarks>
        vmovdqa64,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html</remarks>
        vmovdqu,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html</remarks>
        vmovdqu16,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html</remarks>
        vmovdqu32,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html</remarks>
        vmovdqu64,

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html</remarks>
        vmovdqu8,

        /// <summary>
        /// Move Packed Single-Precision Floating-Point Values High to Low.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVHLPS.html</remarks>
        vmovhlps,

        /// <summary>
        /// Move High Packed Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVHPD.html</remarks>
        vmovhpd,

        /// <summary>
        /// Move High Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVHPS.html</remarks>
        vmovhps,

        /// <summary>
        /// Move Packed Single-Precision Floating-Point Values Low to High.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVLHPS.html</remarks>
        vmovlhps,

        /// <summary>
        /// Move Low Packed Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVLPD.html</remarks>
        vmovlpd,

        /// <summary>
        /// Move Low Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVLPS.html</remarks>
        vmovlps,

        /// <summary>
        /// Extract Packed Double-Precision Floating-Point Sign Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVMSKPD.html</remarks>
        vmovmskpd,

        /// <summary>
        /// Extract Packed Single-Precision Floating-Point Sign Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVMSKPS.html</remarks>
        vmovmskps,

        /// <summary>
        /// Store Packed Integers Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTDQ.html</remarks>
        vmovntdq,

        /// <summary>
        /// Load Double Quadword Non-Temporal Aligned Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTDQA.html</remarks>
        vmovntdqa,

        /// <summary>
        /// Store Packed Double-Precision Floating-Point Values Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTPD.html</remarks>
        vmovntpd,

        /// <summary>
        /// Store Packed Single-Precision Floating-Point Values Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTPS.html</remarks>
        vmovntps,

        /// <summary>
        /// Move Doubleword/Move Quadword.
        /// Move Quadword.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/MOVD:MOVQ.html
        /// https://www.felixcloutier.com/x86/MOVQ.html
        /// </remarks>
        vmovq,

        /// <summary>
        /// Move or Merge Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSD.html</remarks>
        vmovsd,

        /// <summary>
        /// Replicate Single FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSHDUP.html</remarks>
        vmovshdup,

        /// <summary>
        /// Replicate Single FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSLDUP.html</remarks>
        vmovsldup,

        /// <summary>
        /// Move or Merge Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSS.html</remarks>
        vmovss,

        /// <summary>
        /// Move Unaligned Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVUPD.html</remarks>
        vmovupd,

        /// <summary>
        /// Move Unaligned Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVUPS.html</remarks>
        vmovups,

        /// <summary>
        /// Compute Multiple Packed Sums of Absolute Difference.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MPSADBW.html</remarks>
        vmpsadbw,

        /// <summary>
        /// Multiply Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULPD.html</remarks>
        vmulpd,

        /// <summary>
        /// Multiply Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULPS.html</remarks>
        vmulps,

        /// <summary>
        /// Multiply Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULSD.html</remarks>
        vmulsd,

        /// <summary>
        /// Multiply Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULSS.html</remarks>
        vmulss,

        /// <summary>
        /// Bitwise Logical OR of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ORPD.html</remarks>
        vorpd,

        /// <summary>
        /// Bitwise Logical OR of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ORPS.html</remarks>
        vorps,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html</remarks>
        vpabsb,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html</remarks>
        vpabsd,

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html</remarks>
        vpabsw,

        /// <summary>
        /// Pack with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKSSWB:PACKSSDW.html</remarks>
        vpackssdw,

        /// <summary>
        /// Pack with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKSSWB:PACKSSDW.html</remarks>
        vpacksswb,

        /// <summary>
        /// Pack with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKUSDW.html</remarks>
        vpackusdw,

        /// <summary>
        /// Pack with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKUSWB.html</remarks>
        vpackuswb,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        vpaddb,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        vpaddd,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        vpaddq,

        /// <summary>
        /// Add Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDSB:PADDSW.html</remarks>
        vpaddsb,

        /// <summary>
        /// Add Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDSB:PADDSW.html</remarks>
        vpaddsw,

        /// <summary>
        /// Add Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDUSB:PADDUSW.html</remarks>
        vpaddusb,

        /// <summary>
        /// Add Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDUSB:PADDUSW.html</remarks>
        vpaddusw,

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        vpaddw,

        /// <summary>
        /// Packed Align Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PALIGNR.html</remarks>
        vpalignr,

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAND.html</remarks>
        vpand,

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAND.html</remarks>
        vpandd,

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PANDN.html</remarks>
        vpandn,

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PANDN.html</remarks>
        vpandnd,

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PANDN.html</remarks>
        vpandnq,

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAND.html</remarks>
        vpandq,

        /// <summary>
        /// Average Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAVGB:PAVGW.html</remarks>
        vpavgb,

        /// <summary>
        /// Average Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAVGB:PAVGW.html</remarks>
        vpavgw,

        /// <summary>
        /// Blend Packed Dwords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBLENDD.html</remarks>
        vpblendd,

        /// <summary>
        /// Blend Byte/Word Vectors Using an Opmask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBLENDMB:VPBLENDMW.html</remarks>
        vpblendmb,

        /// <summary>
        /// Blend Int32/Int64 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBLENDMD:VPBLENDMQ.html</remarks>
        vpblendmd,

        /// <summary>
        /// Blend Int32/Int64 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBLENDMD:VPBLENDMQ.html</remarks>
        vpblendmq,

        /// <summary>
        /// Blend Byte/Word Vectors Using an Opmask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBLENDMB:VPBLENDMW.html</remarks>
        vpblendmw,

        /// <summary>
        /// Variable Blend Packed Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PBLENDVB.html</remarks>
        vpblendvb,

        /// <summary>
        /// Blend Packed Words.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PBLENDW.html</remarks>
        vpblendw,

        /// <summary>
        /// Load Integer and Broadcast.
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html
        /// </remarks>
        vpbroadcastb,

        /// <summary>
        /// Load Integer and Broadcast.
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html
        /// </remarks>
        vpbroadcastd,

        /// <summary>
        /// Broadcast Mask to Vector Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCASTM.html</remarks>
        vpbroadcastmb2q,

        /// <summary>
        /// Broadcast Mask to Vector Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCASTM.html</remarks>
        vpbroadcastmw2d,

        /// <summary>
        /// Load Integer and Broadcast.
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html
        /// </remarks>
        vpbroadcastq,

        /// <summary>
        /// Load Integer and Broadcast.
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPBROADCAST.html
        /// https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html
        /// </remarks>
        vpbroadcastw,

        /// <summary>
        /// Carry-Less Multiplication Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCLMULQDQ.html</remarks>
        vpclmulqdq,

        /// <summary>
        /// Compare Packed Byte Values Into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPB:VPCMPUB.html</remarks>
        vpcmpb,

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPD:VPCMPUD.html</remarks>
        vpcmpd,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html</remarks>
        vpcmpeqb,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html</remarks>
        vpcmpeqd,

        /// <summary>
        /// Compare Packed Qword Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQQ.html</remarks>
        vpcmpeqq,

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html</remarks>
        vpcmpeqw,

        /// <summary>
        /// Packed Compare Explicit Length Strings, Return Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPESTRI.html</remarks>
        vpcmpestri,

        /// <summary>
        /// Packed Compare Explicit Length Strings, Return Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPESTRM.html</remarks>
        vpcmpestrm,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html</remarks>
        vpcmpgtb,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html</remarks>
        vpcmpgtd,

        /// <summary>
        /// Compare Packed Data for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTQ.html</remarks>
        vpcmpgtq,

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html</remarks>
        vpcmpgtw,

        /// <summary>
        /// Packed Compare Implicit Length Strings, Return Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPISTRI.html</remarks>
        vpcmpistri,

        /// <summary>
        /// Packed Compare Implicit Length Strings, Return Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPISTRM.html</remarks>
        vpcmpistrm,

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPQ:VPCMPUQ.html</remarks>
        vpcmpq,

        /// <summary>
        /// Compare Packed Byte Values Into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPB:VPCMPUB.html</remarks>
        vpcmpub,

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPD:VPCMPUD.html</remarks>
        vpcmpud,

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPQ:VPCMPUQ.html</remarks>
        vpcmpuq,

        /// <summary>
        /// Compare Packed Word Values Into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPW:VPCMPUW.html</remarks>
        vpcmpuw,

        /// <summary>
        /// Compare Packed Word Values Into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPW:VPCMPUW.html</remarks>
        vpcmpw,

        /// <summary>
        /// Store Sparse Packed Doubleword Integer Values into Dense Memory/Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCOMPRESSD.html</remarks>
        vpcompressd,

        /// <summary>
        /// Store Sparse Packed Quadword Integer Values into Dense Memory/Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCOMPRESSQ.html</remarks>
        vpcompressq,

        /// <summary>
        /// Detect Conflicts Within a Vector of Packed Dword/Qword Values into Dense Memory/ Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCONFLICTD:VPCONFLICTQ.html</remarks>
        vpconflictd,

        /// <summary>
        /// Detect Conflicts Within a Vector of Packed Dword/Qword Values into Dense Memory/ Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCONFLICTD:VPCONFLICTQ.html</remarks>
        vpconflictq,

        /// <summary>
        /// Permute Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERM2F128.html</remarks>
        vperm2f128,

        /// <summary>
        /// Permute Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERM2I128.html</remarks>
        vperm2i128,

        /// <summary>
        /// Permute Packed Bytes Elements.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMB.html</remarks>
        vpermb,

        /// <summary>
        /// Permute Packed Doublewords/Words Elements.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMD:VPERMW.html</remarks>
        vpermd,

        /// <summary>
        /// Full Permute of Bytes from Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2B.html</remarks>
        vpermi2b,

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html</remarks>
        vpermi2d,

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html</remarks>
        vpermi2pd,

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html</remarks>
        vpermi2ps,

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html</remarks>
        vpermi2q,

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html</remarks>
        vpermi2w,

        /// <summary>
        /// Permute In-Lane of Pairs of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMILPD.html</remarks>
        vpermilpd,

        /// <summary>
        /// Permute In-Lane of Quadruples of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMILPS.html</remarks>
        vpermilps,

        /// <summary>
        /// Permute Double-Precision Floating-Point Elements.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMPD.html</remarks>
        vpermpd,

        /// <summary>
        /// Permute Single-Precision Floating-Point Elements.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMPS.html</remarks>
        vpermps,

        /// <summary>
        /// Qwords Element Permutation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMQ.html</remarks>
        vpermq,

        /// <summary>
        /// Full Permute of Bytes from Two Tables Overwriting a Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2B.html</remarks>
        vpermt2b,

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html</remarks>
        vpermt2d,

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html</remarks>
        vpermt2pd,

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html</remarks>
        vpermt2ps,

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html</remarks>
        vpermt2q,

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html</remarks>
        vpermt2w,

        /// <summary>
        /// Permute Packed Doublewords/Words Elements.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMD:VPERMW.html</remarks>
        vpermw,

        /// <summary>
        /// Load Sparse Packed Doubleword Integer Values from Dense Memory / Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPEXPANDD.html</remarks>
        vpexpandd,

        /// <summary>
        /// Load Sparse Packed Quadword Integer Values from Dense Memory / Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPEXPANDQ.html</remarks>
        vpexpandq,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html</remarks>
        vpextrb,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html</remarks>
        vpextrd,

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html</remarks>
        vpextrq,

        /// <summary>
        /// Extract Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRW.html</remarks>
        vpextrw,

        /// <summary>
        /// Gather Packed Dword Values Using Signed Dword/Qword Indices.
        /// Gather Packed Dword, Packed Qword with Signed Dword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERQD.html
        /// https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERDQ.html
        /// </remarks>
        vpgatherdd,

        /// <summary>
        /// Gather Packed Dword, Packed Qword with Signed Dword Indices.
        /// Gather Packed Qword Values Using Signed Dword/Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERDQ.html
        /// https://www.felixcloutier.com/x86/VPGATHERDQ:VPGATHERQQ.html
        /// </remarks>
        vpgatherdq,

        /// <summary>
        /// Gather Packed Dword Values Using Signed Dword/Qword Indices.
        /// Gather Packed Dword, Packed Qword with Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERQD.html
        /// https://www.felixcloutier.com/x86/VPGATHERQD:VPGATHERQQ.html
        /// </remarks>
        vpgatherqd,

        /// <summary>
        /// Gather Packed Qword Values Using Signed Dword/Qword Indices.
        /// Gather Packed Dword, Packed Qword with Signed Qword Indices.
        /// </summary>
        /// <remarks>
        /// https://www.felixcloutier.com/x86/VPGATHERDQ:VPGATHERQQ.html
        /// https://www.felixcloutier.com/x86/VPGATHERQD:VPGATHERQQ.html
        /// </remarks>
        vpgatherqq,

        /// <summary>
        /// Packed Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHADDW:PHADDD.html</remarks>
        vphaddd,

        /// <summary>
        /// Packed Horizontal Add and Saturate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHADDSW.html</remarks>
        vphaddsw,

        /// <summary>
        /// Packed Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHADDW:PHADDD.html</remarks>
        vphaddw,

        /// <summary>
        /// Packed Horizontal Word Minimum.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHMINPOSUW.html</remarks>
        vphminposuw,

        /// <summary>
        /// Packed Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHSUBW:PHSUBD.html</remarks>
        vphsubd,

        /// <summary>
        /// Packed Horizontal Subtract and Saturate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHSUBSW.html</remarks>
        vphsubsw,

        /// <summary>
        /// Packed Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHSUBW:PHSUBD.html</remarks>
        vphsubw,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html</remarks>
        vpinsrb,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html</remarks>
        vpinsrd,

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html</remarks>
        vpinsrq,

        /// <summary>
        /// Insert Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRW.html</remarks>
        vpinsrw,

        /// <summary>
        /// Count the Number of Leading Zero Bits for Packed Dword, Packed Qword Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPLZCNTD:VPLZCNTQ.html</remarks>
        vplzcntd,

        /// <summary>
        /// Count the Number of Leading Zero Bits for Packed Dword, Packed Qword Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPLZCNTD:VPLZCNTQ.html</remarks>
        vplzcntq,

        /// <summary>
        /// Packed Multiply of Unsigned 52-bit Unsigned Integers and Add High 52-bit Products to 64-bit Accumulators.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMADD52HUQ.html</remarks>
        vpmadd52huq,

        /// <summary>
        /// Packed Multiply of Unsigned 52-bit Integers and Add the Low 52-bit Products to Qword Accumulators.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMADD52LUQ.html</remarks>
        vpmadd52luq,

        /// <summary>
        /// Multiply and Add Packed Signed and Unsigned Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMADDUBSW.html</remarks>
        vpmaddubsw,

        /// <summary>
        /// Multiply and Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMADDWD.html</remarks>
        vpmaddwd,

        /// <summary>
        /// Conditional SIMD Integer Packed Loads and Stores.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMASKMOV.html</remarks>
        vpmaskmovd,

        /// <summary>
        /// Conditional SIMD Integer Packed Loads and Stores.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMASKMOV.html</remarks>
        vpmaskmovq,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html</remarks>
        vpmaxsb,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html</remarks>
        vpmaxsd,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html</remarks>
        vpmaxsq,

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html</remarks>
        vpmaxsw,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXUB:PMAXUW.html</remarks>
        vpmaxub,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXUD:PMAXUQ.html</remarks>
        vpmaxud,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXUD:PMAXUQ.html</remarks>
        vpmaxuq,

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXUB:PMAXUW.html</remarks>
        vpmaxuw,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINSB:PMINSW.html</remarks>
        vpminsb,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINSD:PMINSQ.html</remarks>
        vpminsd,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINSD:PMINSQ.html</remarks>
        vpminsq,

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINSB:PMINSW.html</remarks>
        vpminsw,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINUB:PMINUW.html</remarks>
        vpminub,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINUD:PMINUQ.html</remarks>
        vpminud,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINUD:PMINUQ.html</remarks>
        vpminuq,

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINUB:PMINUW.html</remarks>
        vpminuw,

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html</remarks>
        vpmovb2m,

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html</remarks>
        vpmovd2m,

        /// <summary>
        /// Down Convert DWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDB:VPMOVSDB:VPMOVUSDB.html</remarks>
        vpmovdb,

        /// <summary>
        /// Down Convert DWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDW:VPMOVSDW:VPMOVUSDW.html</remarks>
        vpmovdw,

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html</remarks>
        vpmovm2b,

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html</remarks>
        vpmovm2d,

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html</remarks>
        vpmovm2q,

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html</remarks>
        vpmovm2w,

        /// <summary>
        /// Move Byte Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVMSKB.html</remarks>
        vpmovmskb,

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html</remarks>
        vpmovq2m,

        /// <summary>
        /// Down Convert QWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQB:VPMOVSQB:VPMOVUSQB.html</remarks>
        vpmovqb,

        /// <summary>
        /// Down Convert QWord to DWord.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQD:VPMOVSQD:VPMOVUSQD.html</remarks>
        vpmovqd,

        /// <summary>
        /// Down Convert QWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQW:VPMOVSQW:VPMOVUSQW.html</remarks>
        vpmovqw,

        /// <summary>
        /// Down Convert DWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDB:VPMOVSDB:VPMOVUSDB.html</remarks>
        vpmovsdb,

        /// <summary>
        /// Down Convert DWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDW:VPMOVSDW:VPMOVUSDW.html</remarks>
        vpmovsdw,

        /// <summary>
        /// Down Convert QWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQB:VPMOVSQB:VPMOVUSQB.html</remarks>
        vpmovsqb,

        /// <summary>
        /// Down Convert QWord to DWord.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQD:VPMOVSQD:VPMOVUSQD.html</remarks>
        vpmovsqd,

        /// <summary>
        /// Down Convert QWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQW:VPMOVSQW:VPMOVUSQW.html</remarks>
        vpmovsqw,

        /// <summary>
        /// Down Convert Word to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVWB:VPMOVSWB:VPMOVUSWB.html</remarks>
        vpmovswb,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        vpmovsxbd,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        vpmovsxbq,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        vpmovsxbw,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        vpmovsxdq,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        vpmovsxwd,

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        vpmovsxwq,

        /// <summary>
        /// Down Convert DWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDB:VPMOVSDB:VPMOVUSDB.html</remarks>
        vpmovusdb,

        /// <summary>
        /// Down Convert DWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDW:VPMOVSDW:VPMOVUSDW.html</remarks>
        vpmovusdw,

        /// <summary>
        /// Down Convert QWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQB:VPMOVSQB:VPMOVUSQB.html</remarks>
        vpmovusqb,

        /// <summary>
        /// Down Convert QWord to DWord.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQD:VPMOVSQD:VPMOVUSQD.html</remarks>
        vpmovusqd,

        /// <summary>
        /// Down Convert QWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQW:VPMOVSQW:VPMOVUSQW.html</remarks>
        vpmovusqw,

        /// <summary>
        /// Down Convert Word to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVWB:VPMOVSWB:VPMOVUSWB.html</remarks>
        vpmovuswb,

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html</remarks>
        vpmovw2m,

        /// <summary>
        /// Down Convert Word to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVWB:VPMOVSWB:VPMOVUSWB.html</remarks>
        vpmovwb,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        vpmovzxbd,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        vpmovzxbq,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        vpmovzxbw,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        vpmovzxdq,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        vpmovzxwd,

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        vpmovzxwq,

        /// <summary>
        /// Multiply Packed Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULDQ.html</remarks>
        vpmuldq,

        /// <summary>
        /// Packed Multiply High with Round and Scale.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULHRSW.html</remarks>
        vpmulhrsw,

        /// <summary>
        /// Multiply Packed Unsigned Integers and Store High Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULHUW.html</remarks>
        vpmulhuw,

        /// <summary>
        /// Multiply Packed Signed Integers and Store High Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULHW.html</remarks>
        vpmulhw,

        /// <summary>
        /// Multiply Packed Integers and Store Low Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULLD:PMULLQ.html</remarks>
        vpmulld,

        /// <summary>
        /// Multiply Packed Integers and Store Low Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULLD:PMULLQ.html</remarks>
        vpmullq,

        /// <summary>
        /// Multiply Packed Signed Integers and Store Low Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULLW.html</remarks>
        vpmullw,

        /// <summary>
        /// Multiply Packed Unsigned Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULUDQ.html</remarks>
        vpmuludq,

        /// <summary>
        /// Bitwise Logical OR.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POR.html</remarks>
        vpor,

        /// <summary>
        /// Bitwise Logical OR.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POR.html</remarks>
        vpord,

        /// <summary>
        /// Bitwise Logical OR.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POR.html</remarks>
        vporq,

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html</remarks>
        vprold,

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html</remarks>
        vprolq,

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html</remarks>
        vprolvd,

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html</remarks>
        vprolvq,

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html</remarks>
        vprord,

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html</remarks>
        vprorq,

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html</remarks>
        vprorvd,

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html</remarks>
        vprorvq,

        /// <summary>
        /// Compute Sum of Absolute Differences.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSADBW.html</remarks>
        vpsadbw,

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html</remarks>
        vpscatterdd,

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html</remarks>
        vpscatterdq,

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html</remarks>
        vpscatterqd,

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html</remarks>
        vpscatterqq,

        /// <summary>
        /// Packed Shuffle Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFB.html</remarks>
        vpshufb,

        /// <summary>
        /// Shuffle Packed Doublewords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFD.html</remarks>
        vpshufd,

        /// <summary>
        /// Shuffle Packed High Words.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFHW.html</remarks>
        vpshufhw,

        /// <summary>
        /// Shuffle Packed Low Words.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFLW.html</remarks>
        vpshuflw,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html</remarks>
        vpsignb,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html</remarks>
        vpsignd,

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html</remarks>
        vpsignw,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html</remarks>
        vpslld,

        /// <summary>
        /// Shift Double Quadword Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLDQ.html</remarks>
        vpslldq,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html</remarks>
        vpsllq,

        /// <summary>
        /// Variable Bit Shift Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSLLVW:VPSLLVD:VPSLLVQ.html</remarks>
        vpsllvd,

        /// <summary>
        /// Variable Bit Shift Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSLLVW:VPSLLVD:VPSLLVQ.html</remarks>
        vpsllvq,

        /// <summary>
        /// Variable Bit Shift Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSLLVW:VPSLLVD:VPSLLVQ.html</remarks>
        vpsllvw,

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html</remarks>
        vpsllw,

        /// <summary>
        /// Shift Packed Data Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRAW:PSRAD:PSRAQ.html</remarks>
        vpsrad,

        /// <summary>
        /// Variable Bit Shift Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRAVW:VPSRAVD:VPSRAVQ.html</remarks>
        vpsravd,

        /// <summary>
        /// Variable Bit Shift Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRAVW:VPSRAVD:VPSRAVQ.html</remarks>
        vpsravq,

        /// <summary>
        /// Variable Bit Shift Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRAVW:VPSRAVD:VPSRAVQ.html</remarks>
        vpsravw,

        /// <summary>
        /// Shift Packed Data Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRAW:PSRAD:PSRAQ.html</remarks>
        vpsraw,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html</remarks>
        vpsrld,

        /// <summary>
        /// Shift Double Quadword Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLDQ.html</remarks>
        vpsrldq,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html</remarks>
        vpsrlq,

        /// <summary>
        /// Variable Bit Shift Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRLVW:VPSRLVD:VPSRLVQ.html</remarks>
        vpsrlvd,

        /// <summary>
        /// Variable Bit Shift Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRLVW:VPSRLVD:VPSRLVQ.html</remarks>
        vpsrlvq,

        /// <summary>
        /// Variable Bit Shift Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRLVW:VPSRLVD:VPSRLVQ.html</remarks>
        vpsrlvw,

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html</remarks>
        vpsrlw,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html</remarks>
        vpsubb,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html</remarks>
        vpsubd,

        /// <summary>
        /// Subtract Packed Quadword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBQ.html</remarks>
        vpsubq,

        /// <summary>
        /// Subtract Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBSB:PSUBSW.html</remarks>
        vpsubsb,

        /// <summary>
        /// Subtract Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBSB:PSUBSW.html</remarks>
        vpsubsw,

        /// <summary>
        /// Subtract Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBUSB:PSUBUSW.html</remarks>
        vpsubusb,

        /// <summary>
        /// Subtract Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBUSB:PSUBUSW.html</remarks>
        vpsubusw,

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html</remarks>
        vpsubw,

        /// <summary>
        /// Bitwise Ternary Logic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTERNLOGD:VPTERNLOGQ.html</remarks>
        vpternlogd,

        /// <summary>
        /// Bitwise Ternary Logic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTERNLOGD:VPTERNLOGQ.html</remarks>
        vpternlogq,

        /// <summary>
        /// Logical Compare.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PTEST.html</remarks>
        vptest,

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html</remarks>
        vptestmb,

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html</remarks>
        vptestmd,

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html</remarks>
        vptestmq,

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html</remarks>
        vptestmw,

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html</remarks>
        vptestnmb,

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html</remarks>
        vptestnmd,

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html</remarks>
        vptestnmq,

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html</remarks>
        vptestnmw,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        vpunpckhbw,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        vpunpckhdq,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        vpunpckhqdq,

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        vpunpckhwd,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        vpunpcklbw,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        vpunpckldq,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        vpunpcklqdq,

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        vpunpcklwd,

        /// <summary>
        /// Range Restriction Calculation For Packed Pairs of Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRANGEPD.html</remarks>
        vrangepd,

        /// <summary>
        /// Range Restriction Calculation For Packed Pairs of Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRANGEPS.html</remarks>
        vrangeps,

        /// <summary>
        /// Range Restriction Calculation From a pair of Scalar Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRANGESD.html</remarks>
        vrangesd,

        /// <summary>
        /// Range Restriction Calculation From a Pair of Scalar Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRANGESS.html</remarks>
        vrangess,

        /// <summary>
        /// Compute Approximate Reciprocals of Packed Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRCP14PD.html</remarks>
        vrcp14pd,

        /// <summary>
        /// Compute Approximate Reciprocals of Packed Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRCP14PS.html</remarks>
        vrcp14ps,

        /// <summary>
        /// Compute Approximate Reciprocal of Scalar Float64 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRCP14SD.html</remarks>
        vrcp14sd,

        /// <summary>
        /// Compute Approximate Reciprocal of Scalar Float32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRCP14SS.html</remarks>
        vrcp14ss,

        /// <summary>
        /// Perform Reduction Transformation on Packed Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VREDUCEPD.html</remarks>
        vreducepd,

        /// <summary>
        /// Perform Reduction Transformation on Packed Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VREDUCEPS.html</remarks>
        vreduceps,

        /// <summary>
        /// Perform a Reduction Transformation on a Scalar Float64 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VREDUCESD.html</remarks>
        vreducesd,

        /// <summary>
        /// Perform a Reduction Transformation on a Scalar Float32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VREDUCESS.html</remarks>
        vreducess,

        /// <summary>
        /// Round Packed Float64 Values To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRNDSCALEPD.html</remarks>
        vrndscalepd,

        /// <summary>
        /// Round Packed Float32 Values To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRNDSCALEPS.html</remarks>
        vrndscaleps,

        /// <summary>
        /// Round Scalar Float64 Value To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRNDSCALESD.html</remarks>
        vrndscalesd,

        /// <summary>
        /// Round Scalar Float32 Value To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRNDSCALESS.html</remarks>
        vrndscaless,

        /// <summary>
        /// Compute Approximate Reciprocals of Square Roots of Packed Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRSQRT14PD.html</remarks>
        vrsqrt14pd,

        /// <summary>
        /// Compute Approximate Reciprocals of Square Roots of Packed Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRSQRT14PS.html</remarks>
        vrsqrt14ps,

        /// <summary>
        /// Compute Approximate Reciprocal of Square Root of Scalar Float64 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRSQRT14SD.html</remarks>
        vrsqrt14sd,

        /// <summary>
        /// Compute Approximate Reciprocal of Square Root of Scalar Float32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRSQRT14SS.html</remarks>
        vrsqrt14ss,

        /// <summary>
        /// Scale Packed Float64 Values With Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCALEFPD.html</remarks>
        vscalefpd,

        /// <summary>
        /// Scale Packed Float32 Values With Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCALEFPS.html</remarks>
        vscalefps,

        /// <summary>
        /// Scale Scalar Float64 Values With Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCALEFSD.html</remarks>
        vscalefsd,

        /// <summary>
        /// Scale Scalar Float32 Value With Float32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCALEFSS.html</remarks>
        vscalefss,

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html</remarks>
        vscatterdpd,

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html</remarks>
        vscatterdps,

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html</remarks>
        vscatterqpd,

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html</remarks>
        vscatterqps,

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html</remarks>
        vshuff32x4,

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html</remarks>
        vshuff64x2,

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html</remarks>
        vshufi32x4,

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html</remarks>
        vshufi64x2,

        /// <summary>
        /// Packed Interleave Shuffle of Pairs of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHUFPD.html</remarks>
        vshufpd,

        /// <summary>
        /// Packed Interleave Shuffle of Quadruplets of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHUFPS.html</remarks>
        vshufps,

        /// <summary>
        /// Square Root of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTPD.html</remarks>
        vsqrtpd,

        /// <summary>
        /// Square Root of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTPS.html</remarks>
        vsqrtps,

        /// <summary>
        /// Compute Square Root of Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTSD.html</remarks>
        vsqrtsd,

        /// <summary>
        /// Compute Square Root of Scalar Single-Precision Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTSS.html</remarks>
        vsqrtss,

        /// <summary>
        /// Subtract Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBPD.html</remarks>
        vsubpd,

        /// <summary>
        /// Subtract Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBPS.html</remarks>
        vsubps,

        /// <summary>
        /// Subtract Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBSD.html</remarks>
        vsubsd,

        /// <summary>
        /// Subtract Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBSS.html</remarks>
        vsubss,

        /// <summary>
        /// Packed Bit Test.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VTESTPD:VTESTPS.html</remarks>
        vtestpd,

        /// <summary>
        /// Packed Bit Test.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VTESTPD:VTESTPS.html</remarks>
        vtestps,

        /// <summary>
        /// Unordered Compare Scalar Double-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UCOMISD.html</remarks>
        vucomisd,

        /// <summary>
        /// Unordered Compare Scalar Single-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UCOMISS.html</remarks>
        vucomiss,

        /// <summary>
        /// Unpack and Interleave High Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKHPD.html</remarks>
        vunpckhpd,

        /// <summary>
        /// Unpack and Interleave High Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKHPS.html</remarks>
        vunpckhps,

        /// <summary>
        /// Unpack and Interleave Low Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKLPD.html</remarks>
        vunpcklpd,

        /// <summary>
        /// Unpack and Interleave Low Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKLPS.html</remarks>
        vunpcklps,

        /// <summary>
        /// Bitwise Logical XOR of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XORPD.html</remarks>
        vxorpd,

        /// <summary>
        /// Bitwise Logical XOR of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XORPS.html</remarks>
        vxorps,

        /// <summary>
        /// Zero All YMM Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VZEROALL.html</remarks>
        vzeroall,

        /// <summary>
        /// Zero Upper Bits of YMM Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VZEROUPPER.html</remarks>
        vzeroupper,

        /// <summary>
        /// Wait.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WAIT:FWAIT.html</remarks>
        wait,

        /// <summary>
        /// Write Back and Invalidate Cache.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WBINVD.html</remarks>
        wbinvd,

        /// <summary>
        /// Write FS/GS Segment Base.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WRFSBASE:WRGSBASE.html</remarks>
        wrfsbase,

        /// <summary>
        /// Write FS/GS Segment Base.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WRFSBASE:WRGSBASE.html</remarks>
        wrgsbase,

        /// <summary>
        /// Write to Model Specific Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WRMSR.html</remarks>
        wrmsr,

        /// <summary>
        /// Write Data to User Page Key Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WRPKRU.html</remarks>
        wrpkru,

        /// <summary>
        /// Transactional Abort.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XABORT.html</remarks>
        xabort,

        /// <summary>
        /// Hardware Lock Elision Prefix Hints.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XACQUIRE:XRELEASE.html</remarks>
        xacquire,

        /// <summary>
        /// Exchange and Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XADD.html</remarks>
        xadd,

        /// <summary>
        /// Transactional Begin.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XBEGIN.html</remarks>
        xbegin,

        /// <summary>
        /// Exchange Register/Memory with Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XCHG.html</remarks>
        xchg,

        /// <summary>
        /// Transactional End.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XEND.html</remarks>
        xend,

        /// <summary>
        /// Get Value of Extended Control Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XGETBV.html</remarks>
        xgetbv,

        /// <summary>
        /// Table Look-up Translation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XLAT:XLATB.html</remarks>
        xlat,

        /// <summary>
        /// Table Look-up Translation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XLAT:XLATB.html</remarks>
        xlatb,

        /// <summary>
        /// Logical Exclusive OR.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XOR.html</remarks>
        xor,

        /// <summary>
        /// Bitwise Logical XOR of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XORPD.html</remarks>
        xorpd,

        /// <summary>
        /// Bitwise Logical XOR of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XORPS.html</remarks>
        xorps,

        /// <summary>
        /// Hardware Lock Elision Prefix Hints.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XACQUIRE:XRELEASE.html</remarks>
        xrelease,

        /// <summary>
        /// Save Processor Extended States Optimized.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XSAVEOPT.html</remarks>
        xsaveopt,

        /// <summary>
        /// Save Processor Extended States Optimized.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XSAVEOPT.html</remarks>
        xsaveopt64,

        /// <summary>
        /// Set Extended Control Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XSETBV.html</remarks>
        xsetbv,

        /// <summary>
        /// Test If In Transactional Execution.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XTEST.html</remarks>
        xtest,
    }
}