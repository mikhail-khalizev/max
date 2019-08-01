// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
#pragma warning disable IDE1006 // Naming Styles

using System;
using System.ComponentModel.DataAnnotations;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.Abstractions
{
    public interface IProcessor
    {
        #region Registers

        Register eax { get; set; }
        Register ebx { get; set; }
        Register ecx { get; set; }
        Register edx { get; set; }

        Register ax { get; set; }
        Register bx { get; set; }
        Register cx { get; set; }
        Register dx { get; set; }

        Register al { get; set; }
        Register bl { get; set; }
        Register cl { get; set; }
        Register dl { get; set; }

        Register ah { get; set; }
        Register bh { get; set; }
        Register ch { get; set; }
        Register dh { get; set; }

        Register esi { get; set; }
        Register edi { get; set; }

        Register si { get; set; }
        Register di { get; set; }

        Register ebp { get; set; }
        Register esp { get; set; }

        Register bp { get; set; }
        Register sp { get; set; }


        /// <summary>
        /// Reference Type: Local Data.
        /// Segment Used: Data Segment.
        /// Default Selection Rule: All data references, except when relative to stack or string destination.
        /// </summary>
        SegmentRegister ds { get; set; }

        /// <summary>
        /// Reference Type: Destination Strings.
        /// Segment Used: Data Segment pointed to with the ES register.
        /// Default Selection Rule: Destination of string instructions.
        /// </summary>
        SegmentRegister es { get; set; }

        /// <summary>
        /// Reference Type: Instructions.
        /// Segment Used: Code Segment.
        /// Default Selection Rule: All instruction fetches.
        /// </summary>
        SegmentRegister cs { get; set; }

        /// <summary>
        /// Reference Type: Stack.
        /// Segment Used: Stack Segment.
        /// Default Selection Rule: All stack pushes and pops. Any memory reference which uses the ESP or EBP register as a base register.
        /// </summary>
        SegmentRegister ss { get; set; }

        SegmentRegister fs { get; set; }
        SegmentRegister gs { get; set; }
        
        /// <summary>
        /// Local descriptor table register.
        /// </summary>
        SegmentRegister ldtr { get; set; }
        SegmentRegister tr { get; set; }

        EflagsRegister eflags { get; set; }
        Ia32EferRegister ia32_efer { get; set; }


        /// <summary>
        /// Control Register 0.
        /// </summary>
        /// <remarks>Contains system control flags that control operating mode and states of the processor.</remarks>
        Cr0Register cr0 { get; set; }

        /// <summary>
        /// Control Register 2.
        /// </summary>
        /// <remarks>Contains the page-fault linear address (the linear address that caused a page fault).</remarks>
        Register cr2 { get; set; }

        /// <summary>
        /// Control Register 3.
        /// </summary>
        /// <remarks>
        /// Contains the physical address of the base of the paging-structure hierarchy and two flags (PCD and PWT).
        /// Only the most-significant bits (less the lower 12 bits) of the base address are specified; the lower 12 bits of the address are assumed to be 0. 
        /// 
        /// PCD Page-level Cache Disable (bit 4 of CR3) — Controls the memory type used to access the first paging
        /// structure of the current paging-structure hierarchy.See Section 4.9, “Paging and Memory Typing”. This bit
        /// is not used if paging is disabled, with PAE paging, or with IA-32e paging if CR4.PCIDE= 1.
        /// 
        /// PWT Page-level Write-Through (bit 3 of CR3) — Controls the memory type used to access the first paging
        /// structure of the current paging-structure hierarchy.See Section 4.9, “Paging and Memory Typing”. This bit
        /// is not used if paging is disabled, with PAE paging, or with IA-32e paging if CR4.PCIDE= 1.
        /// </remarks>
        Register cr3 { get; set; }

        /// <summary>
        /// Control Register 4.
        /// </summary>
        /// <remarks>
        /// Contains a group of flags that enable several architectural extensions,
        /// and indicate operating system or executive support for specific processor capabilities.
        /// </remarks>
        Cr4Register cr4 { get; set; }


        /// <summary>
        /// Global Descriptor Table Register (GDTR) Base Address.
        /// </summary>
        uint gdtr_base { get; set; }

        /// <summary>
        /// Global Descriptor Table Register (GDTR) Base Limit.
        /// </summary>
        ushort gdtr_limit { get; set; }
        
        /// <summary>
        /// IDTR Interrupt Descriptor Table Register Base Address.
        /// </summary>
        uint idtr_base { get; set; }

        /// <summary>
        /// IDTR Interrupt Descriptor Table Register Limit.
        /// </summary>
        ushort idtr_limit { get; set; }
        
        /// <summary>
        /// EIP (instruction pointer) register.
        /// </summary>
        /// <remarks>The EIP register contains a 32-bit pointer to the next instruction to be executed.</remarks>
        /// <seealso cref="CurrentInstructionAddress"/>
        Address eip { get; set; }

        /// <summary>
        /// Gets or sets address of current executing instruction.
        /// </summary>
        /// <seealso cref="eip"/>
        Address CurrentInstructionAddress { get; set; }

        #endregion

        #region Memory

        IMemory Memory { get; }
        
        MemoryAccess memb_a16 { get; }
        MemoryAccess memw_a16 { get; }
        MemoryAccess memd_a16 { get; }
        MemoryAccess memq_a16 { get; }
        
        MemoryAccess memb_a32 { get; }
        MemoryAccess memw_a32 { get; }
        MemoryAccess memd_a32 { get; }
        MemoryAccess memq_a32 { get; }

        #endregion

        #region C# emulate specific

        /// <summary>
        /// Set instruction info before execute.
        /// </summary>
        void ii(Address address, uint length);

        void invalid();

        #endregion

        #region Instructions

        /// <summary>
        /// ASCII Adjust After Addition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AAA.html</remarks>
        void aaa();

        /// <summary>
        /// ASCII Adjust AX Before Division.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AAD.html</remarks>
        void aad();

        /// <summary>
        /// ASCII Adjust AX After Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AAM.html</remarks>
        void aam();

        /// <summary>
        /// ASCII Adjust AL After Subtraction.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AAS.html</remarks>
        void aas();

        /// <summary>
        /// Add with Carry.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADC.html</remarks>
        void adc(Value dst, Value src);

        /// <summary>
        /// Unsigned Integer Addition of Two Operands with Carry Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADCX.html</remarks>
        void adcx();

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADD.html</remarks>
        void add(Value dst, Value src);

        /// <summary>
        /// Add Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDPD.html</remarks>
        void addpd();

        /// <summary>
        /// Add Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDPS.html</remarks>
        void addps();

        /// <summary>
        /// Add Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSD.html</remarks>
        void addsd();

        /// <summary>
        /// Add Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSS.html</remarks>
        void addss();

        /// <summary>
        /// Packed Double-FP Add/Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSUBPD.html</remarks>
        void addsubpd();

        /// <summary>
        /// Packed Single-FP Add/Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADDSUBPS.html</remarks>
        void addsubps();

        /// <summary>
        /// Unsigned Integer Addition of Two Operands with Overflow Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ADOX.html</remarks>
        void adox();

        /// <summary>
        /// Perform One Round of an AES Decryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESDEC.html</remarks>
        void aesdec();

        /// <summary>
        /// Perform Last Round of an AES Decryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESDECLAST.html</remarks>
        void aesdeclast();

        /// <summary>
        /// Perform One Round of an AES Encryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESENC.html</remarks>
        void aesenc();

        /// <summary>
        /// Perform Last Round of an AES Encryption Flow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESENCLAST.html</remarks>
        void aesenclast();

        /// <summary>
        /// Perform the AES InvMixColumn Transformation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESIMC.html</remarks>
        void aesimc();

        /// <summary>
        /// AES Round Key Generation Assist.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AESKEYGENASSIST.html</remarks>
        void aeskeygenassist();

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/AND.html</remarks>
        void and(Value dst, Value src);

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDN.html</remarks>
        void andn();

        /// <summary>
        /// Bitwise Logical AND NOT of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDNPD.html</remarks>
        void andnpd();

        /// <summary>
        /// Bitwise Logical AND NOT of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDNPS.html</remarks>
        void andnps();

        /// <summary>
        /// Bitwise Logical AND of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDPD.html</remarks>
        void andpd();

        /// <summary>
        /// Bitwise Logical AND of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ANDPS.html</remarks>
        void andps();

        /// <summary>
        /// Adjust RPL Field of Segment Selector.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ARPL.html</remarks>
        void arpl();

        /// <summary>
        /// Bit Field Extract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BEXTR.html</remarks>
        void bextr();

        /// <summary>
        /// Blend Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDPD.html</remarks>
        void blendpd();

        /// <summary>
        /// Blend Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDPS.html</remarks>
        void blendps();

        /// <summary>
        /// Variable Blend Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDVPD.html</remarks>
        void blendvpd();

        /// <summary>
        /// Variable Blend Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLENDVPS.html</remarks>
        void blendvps();

        /// <summary>
        /// Extract Lowest Set Isolated Bit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLSI.html</remarks>
        void blsi();

        /// <summary>
        /// Get Mask Up to Lowest Set Bit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLSMSK.html</remarks>
        void blsmsk();

        /// <summary>
        /// Reset Lowest Set Bit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BLSR.html</remarks>
        void blsr();

        /// <summary>
        /// Check Lower Bound.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDCL.html</remarks>
        void bndcl();

        /// <summary>
        /// Check Upper Bound.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDCU:BNDCN.html</remarks>
        void bndcn();

        /// <summary>
        /// Check Upper Bound.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDCU:BNDCN.html</remarks>
        void bndcu();

        /// <summary>
        /// Load Extended Bounds Using Address Translation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDLDX.html</remarks>
        void bndldx();

        /// <summary>
        /// Make Bounds.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDMK.html</remarks>
        void bndmk();

        /// <summary>
        /// Move Bounds.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDMOV.html</remarks>
        void bndmov();

        /// <summary>
        /// Store Extended Bounds Using Address Translation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BNDSTX.html</remarks>
        void bndstx();

        /// <summary>
        /// Check Array Index Against Bounds.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BOUND.html</remarks>
        void bound();

        /// <summary>
        /// Bit Scan Forward.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BSF.html</remarks>
        void bsf();

        /// <summary>
        /// Bit Scan Reverse.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BSR.html</remarks>
        void bsr();

        /// <summary>
        /// Byte Swap.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BSWAP.html</remarks>
        void bswap();

        /// <summary>
        /// Bit Test.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BT.html</remarks>
        void bt(Value dst, Value src);

        /// <summary>
        /// Bit Test and Complement.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BTC.html</remarks>
        void btc(Value dst, Value src);

        /// <summary>
        /// Bit Test and Reset.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BTR.html</remarks>
        void btr(Value dst, Value src);

        /// <summary>
        /// Bit Test and Set.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BTS.html</remarks>
        void bts();

        /// <summary>
        /// Zero High Bits Starting with Specified Bit Position.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/BZHI.html</remarks>
        void bzhi();

        /// <summary>
        /// Call Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CALL.html</remarks>
        void callw(Address address, int offset);

        /// <summary>
        /// Call Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CALL.html</remarks>
        void callw_abs(Value address);

        /// <summary>
        /// Call Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CALL.html</remarks>
        void callw_far_abs(int segment, Address address);

        /// <summary>
        /// Call Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CALL.html</remarks>
        void callw_a16_far_ind(SegmentRegister segment, Value address);

        /// <summary>
        /// Call Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CALL.html</remarks>
        void calld_a16_far_ind(SegmentRegister segment, Value address);

        /// <summary>
        /// Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CBW:CWDE:CDQE.html</remarks>
        void cbw();

        /// <summary>
        /// Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CWD:CDQ:CQO.html</remarks>
        void cdq();

        /// <summary>
        /// Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CBW:CWDE:CDQE.html</remarks>
        void cdqe();

        /// <summary>
        /// Clear AC Flag in EFLAGS Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLAC.html</remarks>
        void clac();

        /// <summary>
        /// Clear Carry Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLC.html</remarks>
        void clc();

        /// <summary>
        /// Clear Direction Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLD.html</remarks>
        void cld();

        /// <summary>
        /// Flush Cache Line.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLFLUSH.html</remarks>
        void clflush();

        /// <summary>
        /// Flush Cache Line Optimized.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLFLUSHOPT.html</remarks>
        void clflushopt();

        /// <summary>
        /// Clear Interrupt Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLI.html</remarks>
        void cli();

        /// <summary>
        /// Clear Task-Switched Flag in CR0.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLTS.html</remarks>
        void clts();

        /// <summary>
        /// Cache Line Write Back.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CLWB.html</remarks>
        void clwb();

        /// <summary>
        /// Complement Carry Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMC.html</remarks>
        void cmc();

        /// <summary>
        /// Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMOVcc.html</remarks>
        void cmovcc();

        /// <summary>
        /// Compare Two Operands.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMP.html</remarks>
        void cmp(Value a, Value b);

        /// <summary>
        /// Compare Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPPD.html</remarks>
        void cmppd();

        /// <summary>
        /// Compare Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPPS.html</remarks>
        void cmpps();

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html</remarks>
        void cmps();

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html</remarks>
        void cmpsb_a16();

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html</remarks>
        void cmpsd();

        /// <summary>
        /// Compare Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPSD.html</remarks>
        void cmpsd_fp();

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html</remarks>
        void cmpsq();

        /// <summary>
        /// Compare Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPSS.html</remarks>
        void cmpss();

        /// <summary>
        /// Compare String Operands.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPS:CMPSB:CMPSW:CMPSD:CMPSQ.html</remarks>
        void cmpsw_a16();

        /// <summary>
        /// Compare and Exchange.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPXCHG.html</remarks>
        void cmpxchg();

        /// <summary>
        /// Compare and Exchange Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPXCHG8B:CMPXCHG16B.html</remarks>
        void cmpxchg16b();

        /// <summary>
        /// Compare and Exchange Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CMPXCHG8B:CMPXCHG16B.html</remarks>
        void cmpxchg8b();

        /// <summary>
        /// Compare Scalar Ordered Double-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/COMISD.html</remarks>
        void comisd();

        /// <summary>
        /// Compare Scalar Ordered Single-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/COMISS.html</remarks>
        void comiss();

        /// <summary>
        /// CPU Identification.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CPUID.html</remarks>
        void cpuid();

        /// <summary>
        /// Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CWD:CDQ:CQO.html</remarks>
        void cqo();

        /// <summary>
        /// Accumulate CRC32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CRC32.html</remarks>
        void crc32();

        /// <summary>
        /// Convert Packed Doubleword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTDQ2PD.html</remarks>
        void cvtdq2pd();

        /// <summary>
        /// Convert Packed Doubleword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTDQ2PS.html</remarks>
        void cvtdq2ps();

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPD2DQ.html</remarks>
        void cvtpd2dq();

        /// <summary>
        /// Convert Packed Double-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPD2PI.html</remarks>
        void cvtpd2pi();

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPD2PS.html</remarks>
        void cvtpd2ps();

        /// <summary>
        /// Convert Packed Dword Integers to Packed Double-Precision FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPI2PD.html</remarks>
        void cvtpi2pd();

        /// <summary>
        /// Convert Packed Dword Integers to Packed Single-Precision FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPI2PS.html</remarks>
        void cvtpi2ps();

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPS2DQ.html</remarks>
        void cvtps2dq();

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPS2PD.html</remarks>
        void cvtps2pd();

        /// <summary>
        /// Convert Packed Single-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTPS2PI.html</remarks>
        void cvtps2pi();

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Doubleword Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSD2SI.html</remarks>
        void cvtsd2si();

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSD2SS.html</remarks>
        void cvtsd2ss();

        /// <summary>
        /// Convert Doubleword Integer to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSI2SD.html</remarks>
        void cvtsi2sd();

        /// <summary>
        /// Convert Doubleword Integer to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSI2SS.html</remarks>
        void cvtsi2ss();

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSS2SD.html</remarks>
        void cvtss2sd();

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Doubleword Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTSS2SI.html</remarks>
        void cvtss2si();

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTPD2DQ.html</remarks>
        void cvttpd2dq();

        /// <summary>
        /// Convert with Truncation Packed Double-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTPD2PI.html</remarks>
        void cvttpd2pi();

        /// <summary>
        /// Convert with Truncation Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTPS2DQ.html</remarks>
        void cvttps2dq();

        /// <summary>
        /// Convert with Truncation Packed Single-Precision FP Values to Packed Dword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTPS2PI.html</remarks>
        void cvttps2pi();

        /// <summary>
        /// Convert with Truncation Scalar Double-Precision Floating-Point Value to Signed Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTSD2SI.html</remarks>
        void cvttsd2si();

        /// <summary>
        /// Convert with Truncation Scalar Single-Precision Floating-Point Value to Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CVTTSS2SI.html</remarks>
        void cvttss2si();

        /// <summary>
        /// Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CWD:CDQ:CQO.html</remarks>
        void cwd();

        /// <summary>
        /// Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CBW:CWDE:CDQE.html</remarks>
        void cwde();

        /// <summary>
        /// Decimal Adjust AL after Addition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DAA.html</remarks>
        void daa();

        /// <summary>
        /// Decimal Adjust AL after Subtraction.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DAS.html</remarks>
        void das();

        /// <summary>
        /// Decrement by 1.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DEC.html</remarks>
        void dec(Value value);

        /// <summary>
        /// Unsigned Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIV.html</remarks>
        void div(Value value);

        /// <summary>
        /// Divide Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVPD.html</remarks>
        void divpd();

        /// <summary>
        /// Divide Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVPS.html</remarks>
        void divps();

        /// <summary>
        /// Divide Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVSD.html</remarks>
        void divsd();

        /// <summary>
        /// Divide Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DIVSS.html</remarks>
        void divss();

        /// <summary>
        /// Dot Product of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DPPD.html</remarks>
        void dppd();

        /// <summary>
        /// Dot Product of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/DPPS.html</remarks>
        void dpps();

        /// <summary>
        /// Empty MMX Technology State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/EMMS.html</remarks>
        void emms();

        /// <summary>
        /// Make Stack Frame for Procedure Parameters.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ENTER.html</remarks>
        void enterw(int allocSize, int nestingLevel);

        /// <summary>
        /// Extract Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/EXTRACTPS.html</remarks>
        void extractps();

        /// <summary>
        /// Compute 2x–1.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/F2XM1.html</remarks>
        void f2xm1();

        /// <summary>
        /// Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FABS.html</remarks>
        void fabs();

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FADD:FADDP:FIADD.html</remarks>
        void fadd();

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FADD:FADDP:FIADD.html</remarks>
        void faddp();

        /// <summary>
        /// Load Binary Coded Decimal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FBLD.html</remarks>
        void fbld();

        /// <summary>
        /// Store BCD Integer and Pop.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FBSTP.html</remarks>
        void fbstp();

        /// <summary>
        /// Change Sign.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCHS.html</remarks>
        void fchs();

        /// <summary>
        /// Clear Exceptions.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCLEX:FNCLEX.html</remarks>
        void fclex();

        /// <summary>
        /// Floating-Point Conditional Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCMOVcc.html</remarks>
        void fcmovcc();

        /// <summary>
        /// Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOM:FCOMP:FCOMPP.html</remarks>
        void fcom();

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html</remarks>
        void fcomi();

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html</remarks>
        void fcomip();

        /// <summary>
        /// Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOM:FCOMP:FCOMPP.html</remarks>
        void fcomp();

        /// <summary>
        /// Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOM:FCOMP:FCOMPP.html</remarks>
        void fcompp();

        /// <summary>
        /// Cosine.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOS.html</remarks>
        void fcos();

        /// <summary>
        /// Decrement Stack-Top Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDECSTP.html</remarks>
        void fdecstp();

        /// <summary>
        /// Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIV:FDIVP:FIDIV.html</remarks>
        void fdiv();

        /// <summary>
        /// Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIV:FDIVP:FIDIV.html</remarks>
        void fdivp();

        /// <summary>
        /// Reverse Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIVR:FDIVRP:FIDIVR.html</remarks>
        void fdivr();

        /// <summary>
        /// Reverse Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIVR:FDIVRP:FIDIVR.html</remarks>
        void fdivrp();

        /// <summary>
        /// Free Floating-Point Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FFREE.html</remarks>
        void ffree();

        /// <summary>
        /// Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FADD:FADDP:FIADD.html</remarks>
        void fiadd();

        /// <summary>
        /// Compare Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FICOM:FICOMP.html</remarks>
        void ficom();

        /// <summary>
        /// Compare Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FICOM:FICOMP.html</remarks>
        void ficomp();

        /// <summary>
        /// Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIV:FDIVP:FIDIV.html</remarks>
        void fidiv();

        /// <summary>
        /// Reverse Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FDIVR:FDIVRP:FIDIVR.html</remarks>
        void fidivr();

        /// <summary>
        /// Load Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FILD.html</remarks>
        void fild();

        /// <summary>
        /// Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FMUL:FMULP:FIMUL.html</remarks>
        void fimul();

        /// <summary>
        /// Increment Stack-Top Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FINCSTP.html</remarks>
        void fincstp();

        /// <summary>
        /// Initialize Floating-Point Unit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FINIT:FNINIT.html</remarks>
        void finit();

        /// <summary>
        /// Store Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FIST:FISTP.html</remarks>
        void fist();

        /// <summary>
        /// Store Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FIST:FISTP.html</remarks>
        void fistp();

        /// <summary>
        /// Store Integer with Truncation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FISTTP.html</remarks>
        void fisttp();

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUB:FSUBP:FISUB.html</remarks>
        void fisub();

        /// <summary>
        /// Reverse Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUBR:FSUBRP:FISUBR.html</remarks>
        void fisubr();

        /// <summary>
        /// Load Floating Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD.html</remarks>
        void fld();

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        void fld1();

        /// <summary>
        /// Load x87 FPU Control Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLDCW.html</remarks>
        void fldcw();

        /// <summary>
        /// Load x87 FPU Environment.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLDENV.html</remarks>
        void fldenv();

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        void fldl2e();

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        void fldl2t();

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        void fldlg2();

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        void fldln2();

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        void fldpi();

        /// <summary>
        /// Load Constant.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FLD1:FLDL2T:FLDL2E:FLDPI:FLDLG2:FLDLN2:FLDZ.html</remarks>
        void fldz();

        /// <summary>
        /// Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FMUL:FMULP:FIMUL.html</remarks>
        void fmul();

        /// <summary>
        /// Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FMUL:FMULP:FIMUL.html</remarks>
        void fmulp();

        /// <summary>
        /// Clear Exceptions.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCLEX:FNCLEX.html</remarks>
        void fnclex();

        /// <summary>
        /// Initialize Floating-Point Unit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FINIT:FNINIT.html</remarks>
        void fninit();

        /// <summary>
        /// No Operation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FNOP.html</remarks>
        void fnop();

        /// <summary>
        /// Store x87 FPU State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSAVE:FNSAVE.html</remarks>
        void fnsavew_a16(SegmentRegister segment, Value address);

        /// <summary>
        /// Store x87 FPU Control Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTCW:FNSTCW.html</remarks>
        void fnstcw(Value value);

        /// <summary>
        /// Store x87 FPU Environment.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTENV:FNSTENV.html</remarks>
        void fnstenv();

        /// <summary>
        /// Store x87 FPU Status Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTSW:FNSTSW.html</remarks>
        void fnstsw(Value value);

        /// <summary>
        /// Partial Arctangent.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FPATAN.html</remarks>
        void fpatan();

        /// <summary>
        /// Partial Remainder.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FPREM.html</remarks>
        void fprem();

        /// <summary>
        /// Partial Remainder.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FPREM1.html</remarks>
        void fprem1();

        /// <summary>
        /// Partial Tangent.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FPTAN.html</remarks>
        void fptan();

        /// <summary>
        /// Round to Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FRNDINT.html</remarks>
        void frndint();

        /// <summary>
        /// Restore x87 FPU State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FRSTOR.html</remarks>
        void frstor();

        /// <summary>
        /// Store x87 FPU State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSAVE:FNSAVE.html</remarks>
        void fsave();

        /// <summary>
        /// Scale.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSCALE.html</remarks>
        void fscale();

        /// <summary>
        /// Sine.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSIN.html</remarks>
        void fsin();

        /// <summary>
        /// Sine and Cosine.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSINCOS.html</remarks>
        void fsincos();

        /// <summary>
        /// Square Root.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSQRT.html</remarks>
        void fsqrt();

        /// <summary>
        /// Store Floating Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FST:FSTP.html</remarks>
        void fst();

        /// <summary>
        /// Store x87 FPU Control Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTCW:FNSTCW.html</remarks>
        void fstcw();

        /// <summary>
        /// Store x87 FPU Environment.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTENV:FNSTENV.html</remarks>
        void fstenv();

        /// <summary>
        /// Store Floating Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FST:FSTP.html</remarks>
        void fstp();

        /// <summary>
        /// Store x87 FPU Status Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSTSW:FNSTSW.html</remarks>
        void fstsw();

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUB:FSUBP:FISUB.html</remarks>
        void fsub();

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUB:FSUBP:FISUB.html</remarks>
        void fsubp();

        /// <summary>
        /// Reverse Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUBR:FSUBRP:FISUBR.html</remarks>
        void fsubr();

        /// <summary>
        /// Reverse Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FSUBR:FSUBRP:FISUBR.html</remarks>
        void fsubrp();

        /// <summary>
        /// TEST.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FTST.html</remarks>
        void ftst();

        /// <summary>
        /// Unordered Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FUCOM:FUCOMP:FUCOMPP.html</remarks>
        void fucom();

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html</remarks>
        void fucomi();

        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FCOMI:FCOMIP:FUCOMI:FUCOMIP.html</remarks>
        void fucomip();

        /// <summary>
        /// Unordered Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FUCOM:FUCOMP:FUCOMPP.html</remarks>
        void fucomp();

        /// <summary>
        /// Unordered Compare Floating Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FUCOM:FUCOMP:FUCOMPP.html</remarks>
        void fucompp();

        /// <summary>
        /// Wait.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WAIT:FWAIT.html</remarks>
        void fwait();

        /// <summary>
        /// Examine Floating-Point.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXAM.html</remarks>
        void fxam();

        /// <summary>
        /// Exchange Register Contents.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXCH.html</remarks>
        void fxch();

        /// <summary>
        /// Restore x87 FPU, MMX, XMM, and MXCSR State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXRSTOR.html</remarks>
        void fxrstor();

        /// <summary>
        /// Save x87 FPU, MMX Technology, and SSE State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXSAVE.html</remarks>
        void fxsave();

        /// <summary>
        /// Extract Exponent and Significand.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FXTRACT.html</remarks>
        void fxtract();

        /// <summary>
        /// Compute y ∗ log2x.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FYL2X.html</remarks>
        void fyl2x();

        /// <summary>
        /// Compute y ∗ log2(x +1).
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/FYL2XP1.html</remarks>
        void fyl2xp1();

        /// <summary>
        /// Packed Double-FP Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HADDPD.html</remarks>
        void haddpd();

        /// <summary>
        /// Packed Single-FP Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HADDPS.html</remarks>
        void haddps();

        /// <summary>
        /// Halt.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HLT.html</remarks>
        void hlt();

        /// <summary>
        /// Packed Double-FP Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HSUBPD.html</remarks>
        void hsubpd();

        /// <summary>
        /// Packed Single-FP Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/HSUBPS.html</remarks>
        void hsubps();

        /// <summary>
        /// Signed Divide.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IDIV.html</remarks>
        void idiv(Value value);

        /// <summary>
        /// Signed Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IMUL.html</remarks>
        void imul(Value value);

        /// <summary>
        /// Signed Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IMUL.html</remarks>
        void imul(Value dst, Value src, int c);

        /// <summary>
        /// Input from Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IN.html</remarks>
        void inb(Value dst, Value port);

        /// <summary>
        /// Increment by 1.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INC.html</remarks>
        void inc(Value value);

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html</remarks>
        void ins();

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html</remarks>
        void insb();

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html</remarks>
        void insd();

        /// <summary>
        /// Insert Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INSERTPS.html</remarks>
        void insertps();

        /// <summary>
        /// Input from Port to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INS:INSB:INSW:INSD.html</remarks>
        void insw();

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html</remarks>
        void @int(int number);

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html</remarks>
        void int1();

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html</remarks>
        void int3();

        /// <summary>
        /// Call to Interrupt Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INTn:INTO:INT3:INT1.html</remarks>
        void into();

        /// <summary>
        /// Invalidate Internal Caches.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INVD.html</remarks>
        void invd();

        /// <summary>
        /// Invalidate TLB Entries.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INVLPG.html</remarks>
        void invlpg();

        /// <summary>
        /// Invalidate Process-Context Identifier.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/INVPCID.html</remarks>
        void invpcid();

        /// <summary>
        /// Interrupt Return.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IRET:IRETD.html</remarks>
        void iretw();

        /// <summary>
        /// Interrupt Return.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/IRET:IRETD.html</remarks>
        void iretd();


        /// <summary>
        /// Jump.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/JMP.html</remarks>
        void jmpw(Address address, int offset);

        /// <summary>
        /// Jump.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/JMP.html</remarks>
        void jmpw_func(Address address, int offset);

        /// <summary>
        /// Jump.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/JMP.html</remarks>
        void jmpw_abs(Value address);

        /// <summary>
        /// Jump.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/JMP.html</remarks>
        int jmpw_abs_switch(Value address);

        /// <summary>
        /// Jump.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/JMP.html</remarks>
        void jmpw_far_abs(int segment, Address address);

        /// <summary>
        /// Call Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/CALL.html</remarks>
        void jmpw_a16_far_ind(SegmentRegister segment, Value address);

        /// <summary>
        /// Jump.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/JMP.html</remarks>
        void jmpd_func(Address address, int offset);


        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jaw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jaw_func(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jaew(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        void jaew_func(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jbw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        void jbw_func(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jbew(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        void jbew_func(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jcw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jcxzw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        void jcxzw_func(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jecxzw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jrcxz(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jew(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jgw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jgew(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jlw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jlew(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        void jlew_func(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jnaw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jnaew(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jnbw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jnbe(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jnc(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jne(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jng(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jnge(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jnl(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jnle(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jno(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jnp(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jnsw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        void jnsw_func(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jnzw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        void jnzw_func(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jow(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jp(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jpe(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jpo(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jsw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        bool jzw(Address address, int offset);

        /// <summary>
        /// Jump if Condition Is Met.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/Jcc.html</remarks>
        void jzw_func(Address address, int offset);


        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html</remarks>
        void kaddb();

        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html</remarks>
        void kaddd();

        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html</remarks>
        void kaddq();

        /// <summary>
        /// ADD Two Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KADDW:KADDB:KADDQ:KADDD.html</remarks>
        void kaddw();

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html</remarks>
        void kandb();

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html</remarks>
        void kandd();

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html</remarks>
        void kandnb();

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html</remarks>
        void kandnd();

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html</remarks>
        void kandnq();

        /// <summary>
        /// Bitwise Logical AND NOT Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDNW:KANDNB:KANDNQ:KANDND.html</remarks>
        void kandnw();

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html</remarks>
        void kandq();

        /// <summary>
        /// Bitwise Logical AND Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KANDW:KANDB:KANDQ:KANDD.html</remarks>
        void kandw();

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html</remarks>
        void kmovb();

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html</remarks>
        void kmovd();

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html</remarks>
        void kmovq();

        /// <summary>
        /// Move from and to Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KMOVW:KMOVB:KMOVQ:KMOVD.html</remarks>
        void kmovw();

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html</remarks>
        void knotb();

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html</remarks>
        void knotd();

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html</remarks>
        void knotq();

        /// <summary>
        /// NOT Mask Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KNOTW:KNOTB:KNOTQ:KNOTD.html</remarks>
        void knotw();

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html</remarks>
        void korb();

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html</remarks>
        void kord();

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html</remarks>
        void korq();

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html</remarks>
        void kortestb();

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html</remarks>
        void kortestd();

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html</remarks>
        void kortestq();

        /// <summary>
        /// OR Masks And Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORTESTW:KORTESTB:KORTESTQ:KORTESTD.html</remarks>
        void kortestw();

        /// <summary>
        /// Bitwise Logical OR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KORW:KORB:KORQ:KORD.html</remarks>
        void korw();

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html</remarks>
        void kshiftlb();

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html</remarks>
        void kshiftld();

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html</remarks>
        void kshiftlq();

        /// <summary>
        /// Shift Left Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTLW:KSHIFTLB:KSHIFTLQ:KSHIFTLD.html</remarks>
        void kshiftlw();

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html</remarks>
        void kshiftrb();

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html</remarks>
        void kshiftrd();

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html</remarks>
        void kshiftrq();

        /// <summary>
        /// Shift Right Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KSHIFTRW:KSHIFTRB:KSHIFTRQ:KSHIFTRD.html</remarks>
        void kshiftrw();

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html</remarks>
        void ktestb();

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html</remarks>
        void ktestd();

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html</remarks>
        void ktestq();

        /// <summary>
        /// Packed Bit Test Masks and Set Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KTESTW:KTESTB:KTESTQ:KTESTD.html</remarks>
        void ktestw();

        /// <summary>
        /// Unpack for Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KUNPCKBW:KUNPCKWD:KUNPCKDQ.html</remarks>
        void kunpckbw();

        /// <summary>
        /// Unpack for Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KUNPCKBW:KUNPCKWD:KUNPCKDQ.html</remarks>
        void kunpckdq();

        /// <summary>
        /// Unpack for Mask Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KUNPCKBW:KUNPCKWD:KUNPCKDQ.html</remarks>
        void kunpckwd();

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html</remarks>
        void kxnorb();

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html</remarks>
        void kxnord();

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html</remarks>
        void kxnorq();

        /// <summary>
        /// Bitwise Logical XNOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXNORW:KXNORB:KXNORQ:KXNORD.html</remarks>
        void kxnorw();

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html</remarks>
        void kxorb();

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html</remarks>
        void kxord();

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html</remarks>
        void kxorq();

        /// <summary>
        /// Bitwise Logical XOR Masks.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/KXORW:KXORB:KXORQ:KXORD.html</remarks>
        void kxorw();

        /// <summary>
        /// Load Status Flags into AH Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LAHF.html</remarks>
        void lahf();

        /// <summary>
        /// Load Access Rights Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LAR.html</remarks>
        void lar(Value dst, Value src);

        /// <summary>
        /// Load Unaligned Integer 128 Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDDQU.html</remarks>
        void lddqu();

        /// <summary>
        /// Load MXCSR Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDMXCSR.html</remarks>
        void ldmxcsr();

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html</remarks>
        void lds(Value dst, SegmentRegister segment, Value offset);

        /// <summary>
        /// Load Effective Address.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LEA.html</remarks>
        void lea(Value dst, Value src);

        /// <summary>
        /// High Level Procedure Exit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LEAVE.html</remarks>
        void leavew();

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html</remarks>
        void les(Value dst, SegmentRegister segment, Value offset);

        /// <summary>
        /// Load Fence.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LFENCE.html</remarks>
        void lfence();

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html</remarks>
        void lfs();

        /// <summary>
        /// Load Global/Interrupt Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LGDT:LIDT.html</remarks>
        void lgdtw_a16(SegmentRegister segment, Value address);

        /// <summary>
        /// Load Global/Interrupt Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LGDT:LIDT.html</remarks>
        void lgdtd_a16(SegmentRegister segment, Value address);

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html</remarks>
        void lgs();

        /// <summary>
        /// Load Global/Interrupt Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LGDT:LIDT.html</remarks>
        void lidtw_a16(SegmentRegister segment, Value address);

        /// <summary>
        /// Load Local Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LLDT.html</remarks>
        void lldt(Value value);

        /// <summary>
        /// Load Machine Status Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LMSW.html</remarks>
        void lmsw(Value value);

        /// <summary>
        /// Assert LOCK# Signal Prefix.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LOCK.html</remarks>
        void @lock();

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html</remarks>
        void lods();

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html</remarks>
        void lodsb_a16();

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html</remarks>
        void lodsd_a16();

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html</remarks>
        void lodsd_a32();

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html</remarks>
        void lodsq();

        /// <summary>
        /// Load String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LODS:LODSB:LODSW:LODSD:LODSQ.html</remarks>
        void lodsw_a16();

        /// <summary>
        /// Loop According to ECX Counter.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LOOP:LOOPcc.html</remarks>
        bool loopw_a16(Address address, int offset);

        /// <summary>
        /// Loop According to ECX Counter.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LOOP:LOOPcc.html</remarks>
        bool loopew_a16(Address address, int offset);

        /// <summary>
        /// Loop According to ECX Counter.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LOOP:LOOPcc.html</remarks>
        bool loopnew_a16(Address address, int offset);

        /// <summary>
        /// Loop According to ECX Counter.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LOOP:LOOPcc.html</remarks>
        bool loopw_a16_func(Address address, int offset);

        /// <summary>
        /// Load Segment Limit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LSL.html</remarks>
        void lsl(Value dst, Value selector);

        /// <summary>
        /// Load Far Pointer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LDS:LES:LFS:LGS:LSS.html</remarks>
        void lss(Value dst, SegmentRegister segment, Value offset);

        /// <summary>
        /// Load Task Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LTR.html</remarks>
        void ltr(Value value);

        /// <summary>
        /// Count the Number of Leading Zero Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/LZCNT.html</remarks>
        void lzcnt();

        /// <summary>
        /// Store Selected Bytes of Double Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MASKMOVDQU.html</remarks>
        void maskmovdqu();

        /// <summary>
        /// Store Selected Bytes of Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MASKMOVQ.html</remarks>
        void maskmovq();

        /// <summary>
        /// Maximum of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXPD.html</remarks>
        void maxpd();

        /// <summary>
        /// Maximum of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXPS.html</remarks>
        void maxps();

        /// <summary>
        /// Return Maximum Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXSD.html</remarks>
        void maxsd();

        /// <summary>
        /// Return Maximum Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MAXSS.html</remarks>
        void maxss();

        /// <summary>
        /// Memory Fence.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MFENCE.html</remarks>
        void mfence();

        /// <summary>
        /// Minimum of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINPD.html</remarks>
        void minpd();

        /// <summary>
        /// Minimum of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINPS.html</remarks>
        void minps();

        /// <summary>
        /// Return Minimum Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINSD.html</remarks>
        void minsd();

        /// <summary>
        /// Return Minimum Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MINSS.html</remarks>
        void minss();

        /// <summary>
        /// Set Up Monitor Address.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MONITOR.html</remarks>
        void monitor();

        /// <summary>
        /// Move.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOV.html</remarks>
        void mov(Value dst, Value src);

        /// <summary>
        /// Move to/from Control Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOV-1.html</remarks>
        void mov_cr();

        /// <summary>
        /// Move to/from Debug Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOV-2.html</remarks>
        void mov_dr();

        /// <summary>
        /// Move Aligned Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVAPD.html</remarks>
        void movapd();

        /// <summary>
        /// Move Aligned Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVAPS.html</remarks>
        void movaps();

        /// <summary>
        /// Move Data After Swapping Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVBE.html</remarks>
        void movbe();

        /// <summary>
        /// Move Doubleword/Move Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVD:MOVQ.html</remarks>
        void movd();

        /// <summary>
        /// Replicate Double FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDDUP.html</remarks>
        void movddup();

        /// <summary>
        /// Move Quadword from XMM to MMX Technology Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQ2Q.html</remarks>
        void movdq2q();

        /// <summary>
        /// Move Aligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQA:VMOVDQA32:VMOVDQA64.html</remarks>
        void movdqa();

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html</remarks>
        void movdqu();

        /// <summary>
        /// Move Packed Single-Precision Floating-Point Values High to Low.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVHLPS.html</remarks>
        void movhlps();

        /// <summary>
        /// Move High Packed Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVHPD.html</remarks>
        void movhpd();

        /// <summary>
        /// Move High Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVHPS.html</remarks>
        void movhps();

        /// <summary>
        /// Move Packed Single-Precision Floating-Point Values Low to High.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVLHPS.html</remarks>
        void movlhps();

        /// <summary>
        /// Move Low Packed Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVLPD.html</remarks>
        void movlpd();

        /// <summary>
        /// Move Low Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVLPS.html</remarks>
        void movlps();

        /// <summary>
        /// Extract Packed Double-Precision Floating-Point Sign Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVMSKPD.html</remarks>
        void movmskpd();

        /// <summary>
        /// Extract Packed Single-Precision Floating-Point Sign Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVMSKPS.html</remarks>
        void movmskps();

        /// <summary>
        /// Store Packed Integers Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTDQ.html</remarks>
        void movntdq();

        /// <summary>
        /// Load Double Quadword Non-Temporal Aligned Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTDQA.html</remarks>
        void movntdqa();

        /// <summary>
        /// Store Doubleword Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTI.html</remarks>
        void movnti();

        /// <summary>
        /// Store Packed Double-Precision Floating-Point Values Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTPD.html</remarks>
        void movntpd();

        /// <summary>
        /// Store Packed Single-Precision Floating-Point Values Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTPS.html</remarks>
        void movntps();

        /// <summary>
        /// Store of Quadword Using Non-Temporal Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVNTQ.html</remarks>
        void movntq();

        /// <summary>
        /// Move Doubleword/Move Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVD:MOVQ.html</remarks>
        void movq_1();

        /// <summary>
        /// Move Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVQ.html</remarks>
        void movq_2();

        /// <summary>
        /// Move Quadword from MMX Technology to XMM Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVQ2DQ.html</remarks>
        void movq2dq();

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html</remarks>
        void movsb_a16(SegmentRegister segment = null);

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html</remarks>
        void movsw_a16(SegmentRegister segment = null);

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html</remarks>
        void movsw_a32(SegmentRegister segment = null);

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html</remarks>
        void movsd_a16();

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html</remarks>
        void movsd_a32(SegmentRegister segment = null);

        /// <summary>
        /// Move or Merge Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSD.html</remarks>
        void movsd_fp();

        /// <summary>
        /// Replicate Single FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSHDUP.html</remarks>
        void movshdup();

        /// <summary>
        /// Replicate Single FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSLDUP.html</remarks>
        void movsldup();

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html</remarks>
        void movsq();

        /// <summary>
        /// Move or Merge Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSS.html</remarks>
        void movss();

        /// <summary>
        /// Move Data from String to String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVS:MOVSB:MOVSW:MOVSD:MOVSQ.html</remarks>
        void movsw();

        /// <summary>
        /// Move with Sign-Extension.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSX:MOVSXD.html</remarks>
        void movsx(Value dst, Value src);

        /// <summary>
        /// Move with Sign-Extension.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVSX:MOVSXD.html</remarks>
        void movsxd();

        /// <summary>
        /// Move Unaligned Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVUPD.html</remarks>
        void movupd();

        /// <summary>
        /// Move Unaligned Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVUPS.html</remarks>
        void movups();

        /// <summary>
        /// Move with Zero-Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVZX.html</remarks>
        void movzx(Value dst, Value src);

        /// <summary>
        /// Compute Multiple Packed Sums of Absolute Difference.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MPSADBW.html</remarks>
        void mpsadbw();

        /// <summary>
        /// Unsigned Multiply.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MUL.html</remarks>
        void mul(Value value);

        /// <summary>
        /// Multiply Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULPD.html</remarks>
        void mulpd();

        /// <summary>
        /// Multiply Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULPS.html</remarks>
        void mulps();

        /// <summary>
        /// Multiply Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULSD.html</remarks>
        void mulsd();

        /// <summary>
        /// Multiply Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULSS.html</remarks>
        void mulss();

        /// <summary>
        /// Unsigned Multiply Without Affecting Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MULX.html</remarks>
        void mulx();

        /// <summary>
        /// Monitor Wait.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MWAIT.html</remarks>
        void mwait();

        /// <summary>
        /// Two's Complement Negation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/NEG.html</remarks>
        void neg(Value value);

        /// <summary>
        /// No Operation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/NOP.html</remarks>
        void nop();

        /// <summary>
        /// One's Complement Negation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/NOT.html</remarks>
        void not(Value value);

        /// <summary>
        /// Logical Inclusive OR.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OR.html</remarks>
        void or(Value dst, Value src);

        /// <summary>
        /// Bitwise Logical OR of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ORPD.html</remarks>
        void orpd();

        /// <summary>
        /// Bitwise Logical OR of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ORPS.html</remarks>
        void orps();

        /// <summary>
        /// Output to Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OUT.html</remarks>
        void outb(Value port, Value value);

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html</remarks>
        void outs();

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html</remarks>
        void outsb_a16(SegmentRegister segment = null);

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html</remarks>
        void outsd();

        /// <summary>
        /// Output String to Port.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/OUTS:OUTSB:OUTSW:OUTSD.html</remarks>
        void outsw();

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html</remarks>
        void pabsb();

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html</remarks>
        void pabsd();

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html</remarks>
        void pabsq();

        /// <summary>
        /// Packed Absolute Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PABSB:PABSW:PABSD:PABSQ.html</remarks>
        void pabsw();

        /// <summary>
        /// Pack with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKSSWB:PACKSSDW.html</remarks>
        void packssdw();

        /// <summary>
        /// Pack with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKSSWB:PACKSSDW.html</remarks>
        void packsswb();

        /// <summary>
        /// Pack with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKUSDW.html</remarks>
        void packusdw();

        /// <summary>
        /// Pack with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PACKUSWB.html</remarks>
        void packuswb();

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        void paddb();

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        void paddd();

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        void paddq();

        /// <summary>
        /// Add Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDSB:PADDSW.html</remarks>
        void paddsb();

        /// <summary>
        /// Add Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDSB:PADDSW.html</remarks>
        void paddsw();

        /// <summary>
        /// Add Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDUSB:PADDUSW.html</remarks>
        void paddusb();

        /// <summary>
        /// Add Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDUSB:PADDUSW.html</remarks>
        void paddusw();

        /// <summary>
        /// Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PADDB:PADDW:PADDD:PADDQ.html</remarks>
        void paddw();

        /// <summary>
        /// Packed Align Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PALIGNR.html</remarks>
        void palignr();

        /// <summary>
        /// Logical AND.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAND.html</remarks>
        void pand();

        /// <summary>
        /// Logical AND NOT.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PANDN.html</remarks>
        void pandn();

        /// <summary>
        /// Spin Loop Hint.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAUSE.html</remarks>
        void pause();

        /// <summary>
        /// Average Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAVGB:PAVGW.html</remarks>
        void pavgb();

        /// <summary>
        /// Average Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PAVGB:PAVGW.html</remarks>
        void pavgw();

        /// <summary>
        /// Variable Blend Packed Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PBLENDVB.html</remarks>
        void pblendvb();

        /// <summary>
        /// Blend Packed Words.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PBLENDW.html</remarks>
        void pblendw();

        /// <summary>
        /// Carry-Less Multiplication Quadword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCLMULQDQ.html</remarks>
        void pclmulqdq();

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html</remarks>
        void pcmpeqb();

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html</remarks>
        void pcmpeqd();

        /// <summary>
        /// Compare Packed Qword Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQQ.html</remarks>
        void pcmpeqq();

        /// <summary>
        /// Compare Packed Data for Equal.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPEQB:PCMPEQW:PCMPEQD.html</remarks>
        void pcmpeqw();

        /// <summary>
        /// Packed Compare Explicit Length Strings, Return Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPESTRI.html</remarks>
        void pcmpestri();

        /// <summary>
        /// Packed Compare Explicit Length Strings, Return Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPESTRM.html</remarks>
        void pcmpestrm();

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html</remarks>
        void pcmpgtb();

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html</remarks>
        void pcmpgtd();

        /// <summary>
        /// Compare Packed Data for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTQ.html</remarks>
        void pcmpgtq();

        /// <summary>
        /// Compare Packed Signed Integers for Greater Than.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPGTB:PCMPGTW:PCMPGTD.html</remarks>
        void pcmpgtw();

        /// <summary>
        /// Packed Compare Implicit Length Strings, Return Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPISTRI.html</remarks>
        void pcmpistri();

        /// <summary>
        /// Packed Compare Implicit Length Strings, Return Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PCMPISTRM.html</remarks>
        void pcmpistrm();

        /// <summary>
        /// Parallel Bits Deposit.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PDEP.html</remarks>
        void pdep();

        /// <summary>
        /// Parallel Bits Extract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXT.html</remarks>
        void pext();

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html</remarks>
        void pextrb();

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html</remarks>
        void pextrd();

        /// <summary>
        /// Extract Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRB:PEXTRD:PEXTRQ.html</remarks>
        void pextrq();

        /// <summary>
        /// Extract Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PEXTRW.html</remarks>
        void pextrw();

        /// <summary>
        /// Packed Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHADDW:PHADDD.html</remarks>
        void phaddd();

        /// <summary>
        /// Packed Horizontal Add and Saturate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHADDSW.html</remarks>
        void phaddsw();

        /// <summary>
        /// Packed Horizontal Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHADDW:PHADDD.html</remarks>
        void phaddw();

        /// <summary>
        /// Packed Horizontal Word Minimum.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHMINPOSUW.html</remarks>
        void phminposuw();

        /// <summary>
        /// Packed Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHSUBW:PHSUBD.html</remarks>
        void phsubd();

        /// <summary>
        /// Packed Horizontal Subtract and Saturate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHSUBSW.html</remarks>
        void phsubsw();

        /// <summary>
        /// Packed Horizontal Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PHSUBW:PHSUBD.html</remarks>
        void phsubw();

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html</remarks>
        void pinsrb();

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html</remarks>
        void pinsrd();

        /// <summary>
        /// Insert Byte/Dword/Qword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRB:PINSRD:PINSRQ.html</remarks>
        void pinsrq();

        /// <summary>
        /// Insert Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PINSRW.html</remarks>
        void pinsrw();

        /// <summary>
        /// Multiply and Add Packed Signed and Unsigned Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMADDUBSW.html</remarks>
        void pmaddubsw();

        /// <summary>
        /// Multiply and Add Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMADDWD.html</remarks>
        void pmaddwd();

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html</remarks>
        void pmaxsb();

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html</remarks>
        void pmaxsd();

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html</remarks>
        void pmaxsq();

        /// <summary>
        /// Maximum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXSB:PMAXSW:PMAXSD:PMAXSQ.html</remarks>
        void pmaxsw();

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXUB:PMAXUW.html</remarks>
        void pmaxub();

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXUD:PMAXUQ.html</remarks>
        void pmaxud();

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXUD:PMAXUQ.html</remarks>
        void pmaxuq();

        /// <summary>
        /// Maximum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMAXUB:PMAXUW.html</remarks>
        void pmaxuw();

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINSB:PMINSW.html</remarks>
        void pminsb();

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINSD:PMINSQ.html</remarks>
        void pminsd();

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINSD:PMINSQ.html</remarks>
        void pminsq();

        /// <summary>
        /// Minimum of Packed Signed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINSB:PMINSW.html</remarks>
        void pminsw();

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINUB:PMINUW.html</remarks>
        void pminub();

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINUD:PMINUQ.html</remarks>
        void pminud();

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINUD:PMINUQ.html</remarks>
        void pminuq();

        /// <summary>
        /// Minimum of Packed Unsigned Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMINUB:PMINUW.html</remarks>
        void pminuw();

        /// <summary>
        /// Move Byte Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVMSKB.html</remarks>
        void pmovmskb();

        /// <summary>
        /// Packed Move with Sign Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVSX.html</remarks>
        void pmovsx();

        /// <summary>
        /// Packed Move with Zero Extend.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMOVZX.html</remarks>
        void pmovzx();

        /// <summary>
        /// Multiply Packed Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULDQ.html</remarks>
        void pmuldq();

        /// <summary>
        /// Packed Multiply High with Round and Scale.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULHRSW.html</remarks>
        void pmulhrsw();

        /// <summary>
        /// Multiply Packed Unsigned Integers and Store High Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULHUW.html</remarks>
        void pmulhuw();

        /// <summary>
        /// Multiply Packed Signed Integers and Store High Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULHW.html</remarks>
        void pmulhw();

        /// <summary>
        /// Multiply Packed Integers and Store Low Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULLD:PMULLQ.html</remarks>
        void pmulld();

        /// <summary>
        /// Multiply Packed Integers and Store Low Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULLD:PMULLQ.html</remarks>
        void pmullq();

        /// <summary>
        /// Multiply Packed Signed Integers and Store Low Result.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULLW.html</remarks>
        void pmullw();

        /// <summary>
        /// Multiply Packed Unsigned Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PMULUDQ.html</remarks>
        void pmuludq();

        /// <summary>
        /// Pop a Value from the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POP.html</remarks>
        ushort popw(Value d = null);

        /// <summary>
        /// Pop a Value from the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POP.html</remarks>
        uint popd(Value d = null);

        /// <summary>
        /// Pop All General-Purpose Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPA:POPAD.html</remarks>
        void popa();

        /// <summary>
        /// Pop All General-Purpose Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPA:POPAD.html</remarks>
        void popad();

        /// <summary>
        /// Return the Count of Number of Bits Set to 1.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPCNT.html</remarks>
        void popcnt();

        /// <summary>
        /// Pop Stack into EFLAGS Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPF:POPFD:POPFQ.html</remarks>
        void popfw();

        /// <summary>
        /// Pop Stack into EFLAGS Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPF:POPFD:POPFQ.html</remarks>
        void popfd();

        /// <summary>
        /// Pop Stack into EFLAGS Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POPF:POPFD:POPFQ.html</remarks>
        void popfq();

        /// <summary>
        /// Bitwise Logical OR.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/POR.html</remarks>
        void por();

        /// <summary>
        /// Prefetch Data into Caches in Anticipation of a Write.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PREFETCHW.html</remarks>
        void prefetchw();

        /// <summary>
        /// Prefetch Data Into Caches.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PREFETCHh.html</remarks>
        void prefetchh();

        /// <summary>
        /// Compute Sum of Absolute Differences.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSADBW.html</remarks>
        void psadbw();

        /// <summary>
        /// Packed Shuffle Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFB.html</remarks>
        void pshufb();

        /// <summary>
        /// Shuffle Packed Doublewords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFD.html</remarks>
        void pshufd();

        /// <summary>
        /// Shuffle Packed High Words.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFHW.html</remarks>
        void pshufhw();

        /// <summary>
        /// Shuffle Packed Low Words.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFLW.html</remarks>
        void pshuflw();

        /// <summary>
        /// Shuffle Packed Words.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSHUFW.html</remarks>
        void pshufw();

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html</remarks>
        void psignb();

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html</remarks>
        void psignd();

        /// <summary>
        /// Packed SIGN.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSIGNB:PSIGNW:PSIGND.html</remarks>
        void psignw();

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html</remarks>
        void pslld();

        /// <summary>
        /// Shift Double Quadword Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLDQ.html</remarks>
        void pslldq();

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html</remarks>
        void psllq();

        /// <summary>
        /// Shift Packed Data Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSLLW:PSLLD:PSLLQ.html</remarks>
        void psllw();

        /// <summary>
        /// Shift Packed Data Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRAW:PSRAD:PSRAQ.html</remarks>
        void psrad();

        /// <summary>
        /// Shift Packed Data Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRAW:PSRAD:PSRAQ.html</remarks>
        void psraq();

        /// <summary>
        /// Shift Packed Data Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRAW:PSRAD:PSRAQ.html</remarks>
        void psraw();

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html</remarks>
        void psrld();

        /// <summary>
        /// Shift Double Quadword Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLDQ.html</remarks>
        void psrldq();

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html</remarks>
        void psrlq();

        /// <summary>
        /// Shift Packed Data Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSRLW:PSRLD:PSRLQ.html</remarks>
        void psrlw();

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html</remarks>
        void psubb();

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html</remarks>
        void psubd();

        /// <summary>
        /// Subtract Packed Quadword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBQ.html</remarks>
        void psubq();

        /// <summary>
        /// Subtract Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBSB:PSUBSW.html</remarks>
        void psubsb();

        /// <summary>
        /// Subtract Packed Signed Integers with Signed Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBSB:PSUBSW.html</remarks>
        void psubsw();

        /// <summary>
        /// Subtract Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBUSB:PSUBUSW.html</remarks>
        void psubusb();

        /// <summary>
        /// Subtract Packed Unsigned Integers with Unsigned Saturation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBUSB:PSUBUSW.html</remarks>
        void psubusw();

        /// <summary>
        /// Subtract Packed Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PSUBB:PSUBW:PSUBD.html</remarks>
        void psubw();

        /// <summary>
        /// Logical Compare.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PTEST.html</remarks>
        void ptest();

        /// <summary>
        /// Write Data to a Processor Trace Packet.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PTWRITE.html</remarks>
        void ptwrite();

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        void punpckhbw();

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        void punpckhdq();

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        void punpckhqdq();

        /// <summary>
        /// Unpack High Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKHBW:PUNPCKHWD:PUNPCKHDQ:PUNPCKHQDQ.html</remarks>
        void punpckhwd();

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        void punpcklbw();

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        void punpckldq();

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        void punpcklqdq();

        /// <summary>
        /// Unpack Low Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUNPCKLBW:PUNPCKLWD:PUNPCKLDQ:PUNPCKLQDQ.html</remarks>
        void punpcklwd();

        /// <summary>
        /// Push Word, Doubleword or Quadword Onto the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSH.html</remarks>
        void pushw(Value s);

        /// <summary>
        /// Push Word, Doubleword or Quadword Onto the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSH.html</remarks>
        void pushd(Value s);

        /// <summary>
        /// Push All General-Purpose Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSHA:PUSHAD.html</remarks>
        void pusha();

        /// <summary>
        /// Push All General-Purpose Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSHA:PUSHAD.html</remarks>
        void pushad();

        /// <summary>
        /// Push EFLAGS Register onto the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSHF:PUSHFD:PUSHFQ.html</remarks>
        void pushfw();

        /// <summary>
        /// Push EFLAGS Register onto the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSHF:PUSHFD:PUSHFQ.html</remarks>
        void pushfd();

        /// <summary>
        /// Push EFLAGS Register onto the Stack.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PUSHF:PUSHFD:PUSHFQ.html</remarks>
        void pushfq();

        /// <summary>
        /// Logical Exclusive OR.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/PXOR.html</remarks>
        void pxor();

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html</remarks>
        void rcl(Value dst, int count);

        /// <summary>
        /// Compute Reciprocals of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RCPPS.html</remarks>
        void rcpps();

        /// <summary>
        /// Compute Reciprocal of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RCPSS.html</remarks>
        void rcpss();

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html</remarks>
        void rcr(Value dst, int count);

        /// <summary>
        /// Read FS/GS Segment Base.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDFSBASE:RDGSBASE.html</remarks>
        void rdfsbase();

        /// <summary>
        /// Read FS/GS Segment Base.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDFSBASE:RDGSBASE.html</remarks>
        void rdgsbase();

        /// <summary>
        /// Read from Model Specific Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDMSR.html</remarks>
        void rdmsr();

        /// <summary>
        /// Read Processor ID.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDPID.html</remarks>
        void rdpid();

        /// <summary>
        /// Read Protection Key Rights for User Pages.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDPKRU.html</remarks>
        void rdpkru();

        /// <summary>
        /// Read Performance-Monitoring Counters.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDPMC.html</remarks>
        void rdpmc();

        /// <summary>
        /// Read Random Number.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDRAND.html</remarks>
        void rdrand();

        /// <summary>
        /// Read Random SEED.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDSEED.html</remarks>
        void rdseed();

        /// <summary>
        /// Read Time-Stamp Counter.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDTSC.html</remarks>
        void rdtsc();

        /// <summary>
        /// Read Time-Stamp Counter and Processor ID.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RDTSCP.html</remarks>
        void rdtscp();

        /// <summary>
        /// Repeat String Operation Prefix.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/REP:REPE:REPZ:REPNE:REPNZ.html</remarks>
        void rep_a16(Action action);

        /// <summary>
        /// Repeat String Operation Prefix.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/REP:REPE:REPZ:REPNE:REPNZ.html</remarks>
        void rep_a32(Action action);

        /// <summary>
        /// Repeat String Operation Prefix.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/REP:REPE:REPZ:REPNE:REPNZ.html</remarks>
        void repe_a16(Action action);

        /// <summary>
        /// Repeat String Operation Prefix.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/REP:REPE:REPZ:REPNE:REPNZ.html</remarks>
        void repne_a16(Action action);

        /// <summary>
        /// Return from Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RET.html</remarks>
        void retw(int allocSize = 0);

        /// <summary>
        /// Return from Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RET.html</remarks>
        void retd();

        /// <summary>
        /// Return from Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RET.html</remarks>
        void retfw(int size = 0);

        /// <summary>
        /// Return from Procedure.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RET.html</remarks>
        void retfd(int size = 0);

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html</remarks>
        void rol(Value dst, int count);

        /// <summary>
        /// Rotate.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RCL:RCR:ROL:ROR.html</remarks>
        void ror(Value dst, int count);

        /// <summary>
        /// Rotate Right Logical Without Affecting Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RORX.html</remarks>
        void rorx();

        /// <summary>
        /// Round Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ROUNDPD.html</remarks>
        void roundpd();

        /// <summary>
        /// Round Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ROUNDPS.html</remarks>
        void roundps();

        /// <summary>
        /// Round Scalar Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ROUNDSD.html</remarks>
        void roundsd();

        /// <summary>
        /// Round Scalar Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/ROUNDSS.html</remarks>
        void roundss();

        /// <summary>
        /// Resume from System Management Mode.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RSM.html</remarks>
        void rsm();

        /// <summary>
        /// Compute Reciprocals of Square Roots of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RSQRTPS.html</remarks>
        void rsqrtps();

        /// <summary>
        /// Compute Reciprocal of Square Root of Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/RSQRTSS.html</remarks>
        void rsqrtss();

        /// <summary>
        /// Store AH into Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SAHF.html</remarks>
        void sahf();

        /// <summary>
        /// Shift.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SAL:SAR:SHL:SHR.html</remarks>
        void sal();

        /// <summary>
        /// Shift.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SAL:SAR:SHL:SHR.html</remarks>
        void sar(Value dst, int count);

        /// <summary>
        /// Shift Without Affecting Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SARX:SHLX:SHRX.html</remarks>
        void sarx();

        /// <summary>
        /// Integer Subtraction with Borrow.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SBB.html</remarks>
        void sbb(Value dst, Value src);

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html</remarks>
        void scas();

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html</remarks>
        void scasb_a16();

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html</remarks>
        void scasd();

        /// <summary>
        /// Scan String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SCAS:SCASB:SCASW:SCASD.html</remarks>
        void scasw_a16();

        /// <summary>
        /// Set Byte on Condition.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SETcc.html</remarks>
        void seta(Value value);

        /// <summary>
        /// Store Fence.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SFENCE.html</remarks>
        void sfence();

        /// <summary>
        /// Store Global Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SGDT.html</remarks>
        void sgdt();

        /// <summary>
        /// Perform an Intermediate Calculation for the Next Four SHA1 Message Dwords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA1MSG1.html</remarks>
        void sha1msg1();

        /// <summary>
        /// Perform a Final Calculation for the Next Four SHA1 Message Dwords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA1MSG2.html</remarks>
        void sha1msg2();

        /// <summary>
        /// Calculate SHA1 State Variable E after Four Rounds.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA1NEXTE.html</remarks>
        void sha1nexte();

        /// <summary>
        /// Perform Four Rounds of SHA1 Operation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA1RNDS4.html</remarks>
        void sha1rnds4();

        /// <summary>
        /// Perform an Intermediate Calculation for the Next Four SHA256 Message Dwords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA256MSG1.html</remarks>
        void sha256msg1();

        /// <summary>
        /// Perform a Final Calculation for the Next Four SHA256 Message Dwords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA256MSG2.html</remarks>
        void sha256msg2();

        /// <summary>
        /// Perform Two Rounds of SHA256 Operation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHA256RNDS2.html</remarks>
        void sha256rnds2();

        /// <summary>
        /// Shift.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SAL:SAR:SHL:SHR.html</remarks>
        void shl(Value dst, Value count);

        /// <summary>
        /// Double Precision Shift Left.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHLD.html</remarks>
        void shld(Value dst, Value src, int count);

        /// <summary>
        /// Shift Without Affecting Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SARX:SHLX:SHRX.html</remarks>
        void shlx();

        /// <summary>
        /// Shift.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SAL:SAR:SHL:SHR.html</remarks>
        void shr(Value dst, Value count);

        /// <summary>
        /// Double Precision Shift Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHRD.html</remarks>
        void shrd(Value dst, Value src, int count);

        /// <summary>
        /// Shift Without Affecting Flags.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SARX:SHLX:SHRX.html</remarks>
        void shrx();

        /// <summary>
        /// Packed Interleave Shuffle of Pairs of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHUFPD.html</remarks>
        void shufpd();

        /// <summary>
        /// Packed Interleave Shuffle of Quadruplets of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SHUFPS.html</remarks>
        void shufps();

        /// <summary>
        /// Store Interrupt Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SIDT.html</remarks>
        void sidt();

        /// <summary>
        /// Store Local Descriptor Table Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SLDT.html</remarks>
        void sldt();

        /// <summary>
        /// Store Machine Status Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SMSW.html</remarks>
        void smsw(Value value);

        /// <summary>
        /// Square Root of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTPD.html</remarks>
        void sqrtpd();

        /// <summary>
        /// Square Root of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTPS.html</remarks>
        void sqrtps();

        /// <summary>
        /// Compute Square Root of Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTSD.html</remarks>
        void sqrtsd();

        /// <summary>
        /// Compute Square Root of Scalar Single-Precision Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SQRTSS.html</remarks>
        void sqrtss();

        /// <summary>
        /// Set AC Flag in EFLAGS Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STAC.html</remarks>
        void stac();

        /// <summary>
        /// Set Carry Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STC.html</remarks>
        void stc();

        /// <summary>
        /// Set Direction Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STD.html</remarks>
        void std();

        /// <summary>
        /// Set Interrupt Flag.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STI.html</remarks>
        void sti();

        /// <summary>
        /// Store MXCSR Register State.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STMXCSR.html</remarks>
        void stmxcsr();

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html</remarks>
        void stos();

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html</remarks>
        void stosb_a16();

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html</remarks>
        void stosd_a16();

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html</remarks>
        void stosd_a32();

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html</remarks>
        void stosq();

        /// <summary>
        /// Store String.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STOS:STOSB:STOSW:STOSD:STOSQ.html</remarks>
        void stosw_a16();

        /// <summary>
        /// Store Task Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/STR.html</remarks>
        void str(Value value);

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUB.html</remarks>
        void sub(Value dst, Value src);

        /// <summary>
        /// Subtract Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBPD.html</remarks>
        void subpd();

        /// <summary>
        /// Subtract Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBPS.html</remarks>
        void subps();

        /// <summary>
        /// Subtract Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBSD.html</remarks>
        void subsd();

        /// <summary>
        /// Subtract Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SUBSS.html</remarks>
        void subss();

        /// <summary>
        /// Swap GS Base Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SWAPGS.html</remarks>
        void swapgs();

        /// <summary>
        /// Fast System Call.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SYSCALL.html</remarks>
        void syscall();

        /// <summary>
        /// Fast System Call.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SYSENTER.html</remarks>
        void sysenter();

        /// <summary>
        /// Fast Return from Fast System Call.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SYSEXIT.html</remarks>
        void sysexit();

        /// <summary>
        /// Return From Fast System Call.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/SYSRET.html</remarks>
        void sysret();

        /// <summary>
        /// Logical Compare.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/TEST.html</remarks>
        void test(Value a, Value b);

        /// <summary>
        /// Count the Number of Trailing Zero Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/TZCNT.html</remarks>
        void tzcnt();

        /// <summary>
        /// Unordered Compare Scalar Double-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UCOMISD.html</remarks>
        void ucomisd();

        /// <summary>
        /// Unordered Compare Scalar Single-Precision Floating-Point Values and Set EFLAGS.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UCOMISS.html</remarks>
        void ucomiss();

        /// <summary>
        /// Undefined Instruction.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UD.html</remarks>
        void ud();

        /// <summary>
        /// Unpack and Interleave High Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKHPD.html</remarks>
        void unpckhpd();

        /// <summary>
        /// Unpack and Interleave High Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKHPS.html</remarks>
        void unpckhps();

        /// <summary>
        /// Unpack and Interleave Low Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKLPD.html</remarks>
        void unpcklpd();

        /// <summary>
        /// Unpack and Interleave Low Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/UNPCKLPS.html</remarks>
        void unpcklps();

        /// <summary>
        /// Align Doubleword/Quadword Vectors.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VALIGND:VALIGNQ.html</remarks>
        void valignd();

        /// <summary>
        /// Align Doubleword/Quadword Vectors.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VALIGND:VALIGNQ.html</remarks>
        void valignq();

        /// <summary>
        /// Blend Float64/Float32 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBLENDMPD:VBLENDMPS.html</remarks>
        void vblendmpd();

        /// <summary>
        /// Blend Float64/Float32 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBLENDMPD:VBLENDMPS.html</remarks>
        void vblendmps();

        /// <summary>
        /// Load with Broadcast Floating-Point Data.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VBROADCAST.html</remarks>
        void vbroadcast();

        /// <summary>
        /// Store Sparse Packed Double-Precision Floating-Point Values into Dense Memory.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCOMPRESSPD.html</remarks>
        void vcompresspd();

        /// <summary>
        /// Store Sparse Packed Single-Precision Floating-Point Values into Dense Memory.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCOMPRESSPS.html</remarks>
        void vcompressps();

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Quadword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPD2QQ.html</remarks>
        void vcvtpd2qq();

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Unsigned Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPD2UDQ.html</remarks>
        void vcvtpd2udq();

        /// <summary>
        /// Convert Packed Double-Precision Floating-Point Values to Packed Unsigned Quadword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPD2UQQ.html</remarks>
        void vcvtpd2uqq();

        /// <summary>
        /// Convert 16-bit FP values to Single-Precision FP values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPH2PS.html</remarks>
        void vcvtph2ps();

        /// <summary>
        /// Convert Single-Precision FP value to 16-bit FP value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPS2PH.html</remarks>
        void vcvtps2ph();

        /// <summary>
        /// Convert Packed Single Precision Floating-Point Values to Packed Singed Quadword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPS2QQ.html</remarks>
        void vcvtps2qq();

        /// <summary>
        /// Convert Packed Single-Precision Floating-Point Values to Packed Unsigned Doubleword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPS2UDQ.html</remarks>
        void vcvtps2udq();

        /// <summary>
        /// Convert Packed Single Precision Floating-Point Values to Packed Unsigned Quadword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTPS2UQQ.html</remarks>
        void vcvtps2uqq();

        /// <summary>
        /// Convert Packed Quadword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTQQ2PD.html</remarks>
        void vcvtqq2pd();

        /// <summary>
        /// Convert Packed Quadword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTQQ2PS.html</remarks>
        void vcvtqq2ps();

        /// <summary>
        /// Convert Scalar Double-Precision Floating-Point Value to Unsigned Doubleword Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTSD2USI.html</remarks>
        void vcvtsd2usi();

        /// <summary>
        /// Convert Scalar Single-Precision Floating-Point Value to Unsigned Doubleword Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTSS2USI.html</remarks>
        void vcvtss2usi();

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Quadword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPD2QQ.html</remarks>
        void vcvttpd2qq();

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Unsigned Doubleword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPD2UDQ.html</remarks>
        void vcvttpd2udq();

        /// <summary>
        /// Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Unsigned Quadword Integers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPD2UQQ.html</remarks>
        void vcvttpd2uqq();

        /// <summary>
        /// Convert with Truncation Packed Single Precision Floating-Point Values to Packed Singed Quadword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPS2QQ.html</remarks>
        void vcvttps2qq();

        /// <summary>
        /// Convert with Truncation Packed Single-Precision Floating-Point Values to Packed Unsigned Doubleword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPS2UDQ.html</remarks>
        void vcvttps2udq();

        /// <summary>
        /// Convert with Truncation Packed Single Precision Floating-Point Values to Packed Unsigned Quadword Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTPS2UQQ.html</remarks>
        void vcvttps2uqq();

        /// <summary>
        /// Convert with Truncation Scalar Double-Precision Floating-Point Value to Unsigned Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTSD2USI.html</remarks>
        void vcvttsd2usi();

        /// <summary>
        /// Convert with Truncation Scalar Single-Precision Floating-Point Value to Unsigned Integer.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTTSS2USI.html</remarks>
        void vcvttss2usi();

        /// <summary>
        /// Convert Packed Unsigned Doubleword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUDQ2PD.html</remarks>
        void vcvtudq2pd();

        /// <summary>
        /// Convert Packed Unsigned Doubleword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUDQ2PS.html</remarks>
        void vcvtudq2ps();

        /// <summary>
        /// Convert Packed Unsigned Quadword Integers to Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUQQ2PD.html</remarks>
        void vcvtuqq2pd();

        /// <summary>
        /// Convert Packed Unsigned Quadword Integers to Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUQQ2PS.html</remarks>
        void vcvtuqq2ps();

        /// <summary>
        /// Convert Unsigned Integer to Scalar Double-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUSI2SD.html</remarks>
        void vcvtusi2sd();

        /// <summary>
        /// Convert Unsigned Integer to Scalar Single-Precision Floating-Point Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VCVTUSI2SS.html</remarks>
        void vcvtusi2ss();

        /// <summary>
        /// Double Block Packed Sum-Absolute-Differences (SAD) on Unsigned Bytes.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VDBPSADBW.html</remarks>
        void vdbpsadbw();

        /// <summary>
        /// Verify a Segment for Reading or Writing.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VERR:VERW.html</remarks>
        void verr();

        /// <summary>
        /// Verify a Segment for Reading or Writing.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VERR:VERW.html</remarks>
        void verw();

        /// <summary>
        /// Load Sparse Packed Double-Precision Floating-Point Values from Dense Memory.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXPANDPD.html</remarks>
        void vexpandpd();

        /// <summary>
        /// Load Sparse Packed Single-Precision Floating-Point Values from Dense Memory.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXPANDPS.html</remarks>
        void vexpandps();

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html</remarks>
        void vextractf128();

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html</remarks>
        void vextractf32x4();

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html</remarks>
        void vextractf32x8();

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html</remarks>
        void vextractf64x2();

        /// <summary>
        /// Extra ct Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTF128:VEXTRACTF32x4:VEXTRACTF64x2:VEXTRACTF32x8:VEXTRACTF64x4.html</remarks>
        void vextractf64x4();

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html</remarks>
        void vextracti128();

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html</remarks>
        void vextracti32x4();

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html</remarks>
        void vextracti32x8();

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html</remarks>
        void vextracti64x2();

        /// <summary>
        /// Extract packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VEXTRACTI128:VEXTRACTI32x4:VEXTRACTI64x2:VEXTRACTI32x8:VEXTRACTI64x4.html</remarks>
        void vextracti64x4();

        /// <summary>
        /// Fix Up Special Packed Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFIXUPIMMPD.html</remarks>
        void vfixupimmpd();

        /// <summary>
        /// Fix Up Special Packed Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFIXUPIMMPS.html</remarks>
        void vfixupimmps();

        /// <summary>
        /// Fix Up Special Scalar Float64 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFIXUPIMMSD.html</remarks>
        void vfixupimmsd();

        /// <summary>
        /// Fix Up Special Scalar Float32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFIXUPIMMSS.html</remarks>
        void vfixupimmss();

        /// <summary>
        /// Fused Multiply-Add of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PD:VFMADD213PD:VFMADD231PD.html</remarks>
        void vfmadd132pd();

        /// <summary>
        /// Fused Multiply-Add of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PS:VFMADD213PS:VFMADD231PS.html</remarks>
        void vfmadd132ps();

        /// <summary>
        /// Fused Multiply-Add of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SD:VFMADD213SD:VFMADD231SD.html</remarks>
        void vfmadd132sd();

        /// <summary>
        /// Fused Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SS:VFMADD213SS:VFMADD231SS.html</remarks>
        void vfmadd132ss();

        /// <summary>
        /// Fused Multiply-Add of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PD:VFMADD213PD:VFMADD231PD.html</remarks>
        void vfmadd213pd();

        /// <summary>
        /// Fused Multiply-Add of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PS:VFMADD213PS:VFMADD231PS.html</remarks>
        void vfmadd213ps();

        /// <summary>
        /// Fused Multiply-Add of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SD:VFMADD213SD:VFMADD231SD.html</remarks>
        void vfmadd213sd();

        /// <summary>
        /// Fused Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SS:VFMADD213SS:VFMADD231SS.html</remarks>
        void vfmadd213ss();

        /// <summary>
        /// Fused Multiply-Add of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PD:VFMADD213PD:VFMADD231PD.html</remarks>
        void vfmadd231pd();

        /// <summary>
        /// Fused Multiply-Add of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132PS:VFMADD213PS:VFMADD231PS.html</remarks>
        void vfmadd231ps();

        /// <summary>
        /// Fused Multiply-Add of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SD:VFMADD213SD:VFMADD231SD.html</remarks>
        void vfmadd231sd();

        /// <summary>
        /// Fused Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADD132SS:VFMADD213SS:VFMADD231SS.html</remarks>
        void vfmadd231ss();

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PD:VFMADDSUB213PD:VFMADDSUB231PD.html</remarks>
        void vfmaddsub132pd();

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PS:VFMADDSUB213PS:VFMADDSUB231PS.html</remarks>
        void vfmaddsub132ps();

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PD:VFMADDSUB213PD:VFMADDSUB231PD.html</remarks>
        void vfmaddsub213pd();

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PS:VFMADDSUB213PS:VFMADDSUB231PS.html</remarks>
        void vfmaddsub213ps();

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PD:VFMADDSUB213PD:VFMADDSUB231PD.html</remarks>
        void vfmaddsub231pd();

        /// <summary>
        /// Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMADDSUB132PS:VFMADDSUB213PS:VFMADDSUB231PS.html</remarks>
        void vfmaddsub231ps();

        /// <summary>
        /// Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PD:VFMSUB213PD:VFMSUB231PD.html</remarks>
        void vfmsub132pd();

        /// <summary>
        /// Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PS:VFMSUB213PS:VFMSUB231PS.html</remarks>
        void vfmsub132ps();

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SD:VFMSUB213SD:VFMSUB231SD.html</remarks>
        void vfmsub132sd();

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SS:VFMSUB213SS:VFMSUB231SS.html</remarks>
        void vfmsub132ss();

        /// <summary>
        /// Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PD:VFMSUB213PD:VFMSUB231PD.html</remarks>
        void vfmsub213pd();

        /// <summary>
        /// Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PS:VFMSUB213PS:VFMSUB231PS.html</remarks>
        void vfmsub213ps();

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SD:VFMSUB213SD:VFMSUB231SD.html</remarks>
        void vfmsub213sd();

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SS:VFMSUB213SS:VFMSUB231SS.html</remarks>
        void vfmsub213ss();

        /// <summary>
        /// Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PD:VFMSUB213PD:VFMSUB231PD.html</remarks>
        void vfmsub231pd();

        /// <summary>
        /// Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132PS:VFMSUB213PS:VFMSUB231PS.html</remarks>
        void vfmsub231ps();

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SD:VFMSUB213SD:VFMSUB231SD.html</remarks>
        void vfmsub231sd();

        /// <summary>
        /// Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUB132SS:VFMSUB213SS:VFMSUB231SS.html</remarks>
        void vfmsub231ss();

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PD:VFMSUBADD213PD:VFMSUBADD231PD.html</remarks>
        void vfmsubadd132pd();

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PS:VFMSUBADD213PS:VFMSUBADD231PS.html</remarks>
        void vfmsubadd132ps();

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PD:VFMSUBADD213PD:VFMSUBADD231PD.html</remarks>
        void vfmsubadd213pd();

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PS:VFMSUBADD213PS:VFMSUBADD231PS.html</remarks>
        void vfmsubadd213ps();

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PD:VFMSUBADD213PD:VFMSUBADD231PD.html</remarks>
        void vfmsubadd231pd();

        /// <summary>
        /// Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFMSUBADD132PS:VFMSUBADD213PS:VFMSUBADD231PS.html</remarks>
        void vfmsubadd231ps();

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PD:VFNMADD213PD:VFNMADD231PD.html</remarks>
        void vfnmadd132pd();

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PS:VFNMADD213PS:VFNMADD231PS.html</remarks>
        void vfnmadd132ps();

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SD:VFNMADD213SD:VFNMADD231SD.html</remarks>
        void vfnmadd132sd();

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SS:VFNMADD213SS:VFNMADD231SS.html</remarks>
        void vfnmadd132ss();

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PD:VFNMADD213PD:VFNMADD231PD.html</remarks>
        void vfnmadd213pd();

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PS:VFNMADD213PS:VFNMADD231PS.html</remarks>
        void vfnmadd213ps();

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SD:VFNMADD213SD:VFNMADD231SD.html</remarks>
        void vfnmadd213sd();

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SS:VFNMADD213SS:VFNMADD231SS.html</remarks>
        void vfnmadd213ss();

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PD:VFNMADD213PD:VFNMADD231PD.html</remarks>
        void vfnmadd231pd();

        /// <summary>
        /// Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132PS:VFNMADD213PS:VFNMADD231PS.html</remarks>
        void vfnmadd231ps();

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SD:VFNMADD213SD:VFNMADD231SD.html</remarks>
        void vfnmadd231sd();

        /// <summary>
        /// Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMADD132SS:VFNMADD213SS:VFNMADD231SS.html</remarks>
        void vfnmadd231ss();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PD:VFNMSUB213PD:VFNMSUB231PD.html</remarks>
        void vfnmsub132pd();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PS:VFNMSUB213PS:VFNMSUB231PS.html</remarks>
        void vfnmsub132ps();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SD:VFNMSUB213SD:VFNMSUB231SD.html</remarks>
        void vfnmsub132sd();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SS:VFNMSUB213SS:VFNMSUB231SS.html</remarks>
        void vfnmsub132ss();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PD:VFNMSUB213PD:VFNMSUB231PD.html</remarks>
        void vfnmsub213pd();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PS:VFNMSUB213PS:VFNMSUB231PS.html</remarks>
        void vfnmsub213ps();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SD:VFNMSUB213SD:VFNMSUB231SD.html</remarks>
        void vfnmsub213sd();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SS:VFNMSUB213SS:VFNMSUB231SS.html</remarks>
        void vfnmsub213ss();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PD:VFNMSUB213PD:VFNMSUB231PD.html</remarks>
        void vfnmsub231pd();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132PS:VFNMSUB213PS:VFNMSUB231PS.html</remarks>
        void vfnmsub231ps();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SD:VFNMSUB213SD:VFNMSUB231SD.html</remarks>
        void vfnmsub231sd();

        /// <summary>
        /// Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFNMSUB132SS:VFNMSUB213SS:VFNMSUB231SS.html</remarks>
        void vfnmsub231ss();

        /// <summary>
        /// Tests Types Of a Packed Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFPCLASSPD.html</remarks>
        void vfpclasspd();

        /// <summary>
        /// Tests Types Of a Packed Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFPCLASSPS.html</remarks>
        void vfpclassps();

        /// <summary>
        /// Tests Types Of a Scalar Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFPCLASSSD.html</remarks>
        void vfpclasssd();

        /// <summary>
        /// Tests Types Of a Scalar Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VFPCLASSSS.html</remarks>
        void vfpclassss();

        /// <summary>
        /// Gather Packed DP FP Values Using Signed Dword/Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGATHERDPD:VGATHERQPD.html</remarks>
        void vgatherdpd();

        /// <summary>
        /// Gather Packed Single, Packed Double with Signed Dword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERDPD.html</remarks>
        void vgatherdpd_s();

        /// <summary>
        /// Gather Packed SP FP values Using Signed Dword/Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERQPS.html</remarks>
        void vgatherdps();

        /// <summary>
        /// Gather Packed Single, Packed Double with Signed Dword.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERDPD.html</remarks>
        void vgatherdps_s();

        /// <summary>
        /// Gather Packed DP FP Values Using Signed Dword/Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGATHERDPD:VGATHERQPD.html</remarks>
        void vgatherqpd();

        /// <summary>
        /// Gather Packed Single, Packed Double with Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGATHERQPS:VGATHERQPD.html</remarks>
        void vgatherqpd_s();

        /// <summary>
        /// Gather Packed SP FP values Using Signed Dword/Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGATHERDPS:VGATHERQPS.html</remarks>
        void vgatherqps();

        /// <summary>
        /// Gather Packed Single, Packed Double with Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGATHERQPS:VGATHERQPD.html</remarks>
        void vgatherqps_s();

        /// <summary>
        /// Convert Exponents of Packed DP FP Values to DP FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETEXPPD.html</remarks>
        void vgetexppd();

        /// <summary>
        /// Convert Exponents of Packed SP FP Values to SP FP Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETEXPPS.html</remarks>
        void vgetexpps();

        /// <summary>
        /// Convert Exponents of Scalar DP FP Values to DP FP Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETEXPSD.html</remarks>
        void vgetexpsd();

        /// <summary>
        /// Convert Exponents of Scalar SP FP Values to SP FP Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETEXPSS.html</remarks>
        void vgetexpss();

        /// <summary>
        /// Extract Float64 Vector of Normalized Mantissas from Float64 Vector.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETMANTPD.html</remarks>
        void vgetmantpd();

        /// <summary>
        /// Extract Float32 Vector of Normalized Mantissas from Float32 Vector.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETMANTPS.html</remarks>
        void vgetmantps();

        /// <summary>
        /// Extract Float64 of Normalized Mantissas from Float64 Scalar.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETMANTSD.html</remarks>
        void vgetmantsd();

        /// <summary>
        /// Extract Float32 Vector of Normalized Mantissa from Float32 Vector.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VGETMANTSS.html</remarks>
        void vgetmantss();

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html</remarks>
        void vinsertf128();

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html</remarks>
        void vinsertf32x4();

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html</remarks>
        void vinsertf32x8();

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html</remarks>
        void vinsertf64x2();

        /// <summary>
        /// Insert Packed Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTF128:VINSERTF32x4:VINSERTF64x2:VINSERTF32x8:VINSERTF64x4.html</remarks>
        void vinsertf64x4();

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html</remarks>
        void vinserti128();

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html</remarks>
        void vinserti32x4();

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html</remarks>
        void vinserti32x8();

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html</remarks>
        void vinserti64x2();

        /// <summary>
        /// Insert Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VINSERTI128:VINSERTI32x4:VINSERTI64x2:VINSERTI32x8:VINSERTI64x4.html</remarks>
        void vinserti64x4();

        /// <summary>
        /// Conditional SIMD Packed Loads and Stores.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VMASKMOV.html</remarks>
        void vmaskmov();

        /// <summary>
        /// Move Aligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQA:VMOVDQA32:VMOVDQA64.html</remarks>
        void vmovdqa32();

        /// <summary>
        /// Move Aligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQA:VMOVDQA32:VMOVDQA64.html</remarks>
        void vmovdqa64();

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html</remarks>
        void vmovdqu16();

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html</remarks>
        void vmovdqu32();

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html</remarks>
        void vmovdqu64();

        /// <summary>
        /// Move Unaligned Packed Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/MOVDQU:VMOVDQU8:VMOVDQU16:VMOVDQU32:VMOVDQU64.html</remarks>
        void vmovdqu8();

        /// <summary>
        /// Blend Packed Dwords.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBLENDD.html</remarks>
        void vpblendd();

        /// <summary>
        /// Blend Byte/Word Vectors Using an Opmask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBLENDMB:VPBLENDMW.html</remarks>
        void vpblendmb();

        /// <summary>
        /// Blend Int32/Int64 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBLENDMD:VPBLENDMQ.html</remarks>
        void vpblendmd();

        /// <summary>
        /// Blend Int32/Int64 Vectors Using an OpMask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBLENDMD:VPBLENDMQ.html</remarks>
        void vpblendmq();

        /// <summary>
        /// Blend Byte/Word Vectors Using an Opmask Control.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBLENDMB:VPBLENDMW.html</remarks>
        void vpblendmw();

        /// <summary>
        /// Load Integer and Broadcast.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCAST.html</remarks>
        void vpbroadcast();

        /// <summary>
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html</remarks>
        void vpbroadcastb();

        /// <summary>
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html</remarks>
        void vpbroadcastd();

        /// <summary>
        /// Broadcast Mask to Vector Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCASTM.html</remarks>
        void vpbroadcastm();

        /// <summary>
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html</remarks>
        void vpbroadcastq();

        /// <summary>
        /// Load with Broadcast Integer Data from General Purpose Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPBROADCASTB:VPBROADCASTW:VPBROADCASTD:VPBROADCASTQ.html</remarks>
        void vpbroadcastw();

        /// <summary>
        /// Compare Packed Byte Values Into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPB:VPCMPUB.html</remarks>
        void vpcmpb();

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPD:VPCMPUD.html</remarks>
        void vpcmpd();

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPQ:VPCMPUQ.html</remarks>
        void vpcmpq();

        /// <summary>
        /// Compare Packed Byte Values Into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPB:VPCMPUB.html</remarks>
        void vpcmpub();

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPD:VPCMPUD.html</remarks>
        void vpcmpud();

        /// <summary>
        /// Compare Packed Integer Values into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPQ:VPCMPUQ.html</remarks>
        void vpcmpuq();

        /// <summary>
        /// Compare Packed Word Values Into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPW:VPCMPUW.html</remarks>
        void vpcmpuw();

        /// <summary>
        /// Compare Packed Word Values Into Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCMPW:VPCMPUW.html</remarks>
        void vpcmpw();

        /// <summary>
        /// Store Sparse Packed Doubleword Integer Values into Dense Memory/Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCOMPRESSD.html</remarks>
        void vpcompressd();

        /// <summary>
        /// Store Sparse Packed Quadword Integer Values into Dense Memory/Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCOMPRESSQ.html</remarks>
        void vpcompressq();

        /// <summary>
        /// Detect Conflicts Within a Vector of Packed Dword/Qword Values into Dense Memory/ Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCONFLICTD:VPCONFLICTQ.html</remarks>
        void vpconflictd();

        /// <summary>
        /// Detect Conflicts Within a Vector of Packed Dword/Qword Values into Dense Memory/ Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPCONFLICTD:VPCONFLICTQ.html</remarks>
        void vpconflictq();

        /// <summary>
        /// Permute Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERM2F128.html</remarks>
        void vperm2f128();

        /// <summary>
        /// Permute Integer Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERM2I128.html</remarks>
        void vperm2i128();

        /// <summary>
        /// Permute Packed Bytes Elements.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMB.html</remarks>
        void vpermb();

        /// <summary>
        /// Permute Packed Doublewords/Words Elements.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMD:VPERMW.html</remarks>
        void vpermd();

        /// <summary>
        /// Full Permute of Bytes from Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2B.html</remarks>
        void vpermi2b();

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html</remarks>
        void vpermi2d();

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html</remarks>
        void vpermi2pd();

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html</remarks>
        void vpermi2ps();

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html</remarks>
        void vpermi2q();

        /// <summary>
        /// Full Permute From Two Tables Overwriting the Index.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMI2W:VPERMI2D:VPERMI2Q:VPERMI2PS:VPERMI2PD.html</remarks>
        void vpermi2w();

        /// <summary>
        /// Permute In-Lane of Pairs of Double-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMILPD.html</remarks>
        void vpermilpd();

        /// <summary>
        /// Permute In-Lane of Quadruples of Single-Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMILPS.html</remarks>
        void vpermilps();

        /// <summary>
        /// Permute Double-Precision Floating-Point Elements.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMPD.html</remarks>
        void vpermpd();

        /// <summary>
        /// Permute Single-Precision Floating-Point Elements.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMPS.html</remarks>
        void vpermps();

        /// <summary>
        /// Qwords Element Permutation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMQ.html</remarks>
        void vpermq();

        /// <summary>
        /// Full Permute of Bytes from Two Tables Overwriting a Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2B.html</remarks>
        void vpermt2b();

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html</remarks>
        void vpermt2d();

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html</remarks>
        void vpermt2pd();

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html</remarks>
        void vpermt2ps();

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html</remarks>
        void vpermt2q();

        /// <summary>
        /// Full Permute from Two Tables Overwriting one Table.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMT2W:VPERMT2D:VPERMT2Q:VPERMT2PS:VPERMT2PD.html</remarks>
        void vpermt2w();

        /// <summary>
        /// Permute Packed Doublewords/Words Elements.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPERMD:VPERMW.html</remarks>
        void vpermw();

        /// <summary>
        /// Load Sparse Packed Doubleword Integer Values from Dense Memory / Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPEXPANDD.html</remarks>
        void vpexpandd();

        /// <summary>
        /// Load Sparse Packed Quadword Integer Values from Dense Memory / Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPEXPANDQ.html</remarks>
        void vpexpandq();

        /// <summary>
        /// Gather Packed Dword Values Using Signed Dword/Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERQD.html</remarks>
        void vpgatherdd();

        /// <summary>
        /// Gather Packed Dword, Packed Qword with Signed Dword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERDQ.html</remarks>
        void vpgatherdd_s();

        /// <summary>
        /// Gather Packed Dword, Packed Qword with Signed Dword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERDQ.html</remarks>
        void vpgatherdq_s();

        /// <summary>
        /// Gather Packed Qword Values Using Signed Dword/Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPGATHERDQ:VPGATHERQQ.html</remarks>
        void vpgatherdq();

        /// <summary>
        /// Gather Packed Dword Values Using Signed Dword/Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPGATHERDD:VPGATHERQD.html</remarks>
        void vpgatherqd();

        /// <summary>
        /// Gather Packed Dword, Packed Qword with Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPGATHERQD:VPGATHERQQ.html</remarks>
        void vpgatherqd_s();

        /// <summary>
        /// Gather Packed Qword Values Using Signed Dword/Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPGATHERDQ:VPGATHERQQ.html</remarks>
        void vpgatherqq();

        /// <summary>
        /// Gather Packed Dword, Packed Qword with Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPGATHERQD:VPGATHERQQ.html</remarks>
        void vpgatherqq_s();

        /// <summary>
        /// Count the Number of Leading Zero Bits for Packed Dword, Packed Qword Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPLZCNTD:VPLZCNTQ.html</remarks>
        void vplzcntd();

        /// <summary>
        /// Count the Number of Leading Zero Bits for Packed Dword, Packed Qword Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPLZCNTD:VPLZCNTQ.html</remarks>
        void vplzcntq();

        /// <summary>
        /// Packed Multiply of Unsigned 52-bit Unsigned Integers and Add High 52-bit Products to 64-bit Accumulators.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMADD52HUQ.html</remarks>
        void vpmadd52huq();

        /// <summary>
        /// Packed Multiply of Unsigned 52-bit Integers and Add the Low 52-bit Products to Qword Accumulators.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMADD52LUQ.html</remarks>
        void vpmadd52luq();

        /// <summary>
        /// Conditional SIMD Integer Packed Loads and Stores.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMASKMOV.html</remarks>
        void vpmaskmov();

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html</remarks>
        void vpmovb2m();

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html</remarks>
        void vpmovd2m();

        /// <summary>
        /// Down Convert DWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDB:VPMOVSDB:VPMOVUSDB.html</remarks>
        void vpmovdb();

        /// <summary>
        /// Down Convert DWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDW:VPMOVSDW:VPMOVUSDW.html</remarks>
        void vpmovdw();

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html</remarks>
        void vpmovm2b();

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html</remarks>
        void vpmovm2d();

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html</remarks>
        void vpmovm2q();

        /// <summary>
        /// Convert a Mask Register to a Vector Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVM2B:VPMOVM2W:VPMOVM2D:VPMOVM2Q.html</remarks>
        void vpmovm2w();

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html</remarks>
        void vpmovq2m();

        /// <summary>
        /// Down Convert QWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQB:VPMOVSQB:VPMOVUSQB.html</remarks>
        void vpmovqb();

        /// <summary>
        /// Down Convert QWord to DWord.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQD:VPMOVSQD:VPMOVUSQD.html</remarks>
        void vpmovqd();

        /// <summary>
        /// Down Convert QWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQW:VPMOVSQW:VPMOVUSQW.html</remarks>
        void vpmovqw();

        /// <summary>
        /// Down Convert DWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDB:VPMOVSDB:VPMOVUSDB.html</remarks>
        void vpmovsdb();

        /// <summary>
        /// Down Convert DWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDW:VPMOVSDW:VPMOVUSDW.html</remarks>
        void vpmovsdw();

        /// <summary>
        /// Down Convert QWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQB:VPMOVSQB:VPMOVUSQB.html</remarks>
        void vpmovsqb();

        /// <summary>
        /// Down Convert QWord to DWord.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQD:VPMOVSQD:VPMOVUSQD.html</remarks>
        void vpmovsqd();

        /// <summary>
        /// Down Convert QWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQW:VPMOVSQW:VPMOVUSQW.html</remarks>
        void vpmovsqw();

        /// <summary>
        /// Down Convert Word to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVWB:VPMOVSWB:VPMOVUSWB.html</remarks>
        void vpmovswb();

        /// <summary>
        /// Down Convert DWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDB:VPMOVSDB:VPMOVUSDB.html</remarks>
        void vpmovusdb();

        /// <summary>
        /// Down Convert DWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVDW:VPMOVSDW:VPMOVUSDW.html</remarks>
        void vpmovusdw();

        /// <summary>
        /// Down Convert QWord to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQB:VPMOVSQB:VPMOVUSQB.html</remarks>
        void vpmovusqb();

        /// <summary>
        /// Down Convert QWord to DWord.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQD:VPMOVSQD:VPMOVUSQD.html</remarks>
        void vpmovusqd();

        /// <summary>
        /// Down Convert QWord to Word.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVQW:VPMOVSQW:VPMOVUSQW.html</remarks>
        void vpmovusqw();

        /// <summary>
        /// Down Convert Word to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVWB:VPMOVSWB:VPMOVUSWB.html</remarks>
        void vpmovuswb();

        /// <summary>
        /// Convert a Vector Register to a Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVB2M:VPMOVW2M:VPMOVD2M:VPMOVQ2M.html</remarks>
        void vpmovw2m();

        /// <summary>
        /// Down Convert Word to Byte.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMOVWB:VPMOVSWB:VPMOVUSWB.html</remarks>
        void vpmovwb();

        /// <summary>
        /// Select Packed Unaligned Bytes from Quadword Sources.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPMULTISHIFTQB.html</remarks>
        void vpmultishiftqb();

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html</remarks>
        void vprold();

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html</remarks>
        void vprolq();

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html</remarks>
        void vprolvd();

        /// <summary>
        /// Bit Rotate Left.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPROLD:VPROLVD:VPROLQ:VPROLVQ.html</remarks>
        void vprolvq();

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html</remarks>
        void vprord();

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html</remarks>
        void vprorq();

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html</remarks>
        void vprorvd();

        /// <summary>
        /// Bit Rotate Right.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPRORD:VPRORVD:VPRORQ:VPRORVQ.html</remarks>
        void vprorvq();

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html</remarks>
        void vpscatterdd();

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html</remarks>
        void vpscatterdq();

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html</remarks>
        void vpscatterqd();

        /// <summary>
        /// Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSCATTERDD:VPSCATTERDQ:VPSCATTERQD:VPSCATTERQQ.html</remarks>
        void vpscatterqq();

        /// <summary>
        /// Variable Bit Shift Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSLLVW:VPSLLVD:VPSLLVQ.html</remarks>
        void vpsllvd();

        /// <summary>
        /// Variable Bit Shift Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSLLVW:VPSLLVD:VPSLLVQ.html</remarks>
        void vpsllvq();

        /// <summary>
        /// Variable Bit Shift Left Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSLLVW:VPSLLVD:VPSLLVQ.html</remarks>
        void vpsllvw();

        /// <summary>
        /// Variable Bit Shift Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRAVW:VPSRAVD:VPSRAVQ.html</remarks>
        void vpsravd();

        /// <summary>
        /// Variable Bit Shift Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRAVW:VPSRAVD:VPSRAVQ.html</remarks>
        void vpsravq();

        /// <summary>
        /// Variable Bit Shift Right Arithmetic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRAVW:VPSRAVD:VPSRAVQ.html</remarks>
        void vpsravw();

        /// <summary>
        /// Variable Bit Shift Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRLVW:VPSRLVD:VPSRLVQ.html</remarks>
        void vpsrlvd();

        /// <summary>
        /// Variable Bit Shift Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRLVW:VPSRLVD:VPSRLVQ.html</remarks>
        void vpsrlvq();

        /// <summary>
        /// Variable Bit Shift Right Logical.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPSRLVW:VPSRLVD:VPSRLVQ.html</remarks>
        void vpsrlvw();

        /// <summary>
        /// Bitwise Ternary Logic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTERNLOGD:VPTERNLOGQ.html</remarks>
        void vpternlogd();

        /// <summary>
        /// Bitwise Ternary Logic.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTERNLOGD:VPTERNLOGQ.html</remarks>
        void vpternlogq();

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html</remarks>
        void vptestmb();

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html</remarks>
        void vptestmd();

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html</remarks>
        void vptestmq();

        /// <summary>
        /// Logical AND and Set Mask.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTMB:VPTESTMW:VPTESTMD:VPTESTMQ.html</remarks>
        void vptestmw();

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html</remarks>
        void vptestnmb();

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html</remarks>
        void vptestnmd();

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html</remarks>
        void vptestnmq();

        /// <summary>
        /// Logical NAND and Set.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VPTESTNMB:VPTESTNMW:VPTESTNMD:VPTESTNMQ.html</remarks>
        void vptestnmw();

        /// <summary>
        /// Range Restriction Calculation For Packed Pairs of Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRANGEPD.html</remarks>
        void vrangepd();

        /// <summary>
        /// Range Restriction Calculation For Packed Pairs of Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRANGEPS.html</remarks>
        void vrangeps();

        /// <summary>
        /// Range Restriction Calculation From a pair of Scalar Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRANGESD.html</remarks>
        void vrangesd();

        /// <summary>
        /// Range Restriction Calculation From a Pair of Scalar Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRANGESS.html</remarks>
        void vrangess();

        /// <summary>
        /// Compute Approximate Reciprocals of Packed Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRCP14PD.html</remarks>
        void vrcp14pd();

        /// <summary>
        /// Compute Approximate Reciprocals of Packed Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRCP14PS.html</remarks>
        void vrcp14ps();

        /// <summary>
        /// Compute Approximate Reciprocal of Scalar Float64 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRCP14SD.html</remarks>
        void vrcp14sd();

        /// <summary>
        /// Compute Approximate Reciprocal of Scalar Float32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRCP14SS.html</remarks>
        void vrcp14ss();

        /// <summary>
        /// Perform Reduction Transformation on Packed Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VREDUCEPD.html</remarks>
        void vreducepd();

        /// <summary>
        /// Perform Reduction Transformation on Packed Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VREDUCEPS.html</remarks>
        void vreduceps();

        /// <summary>
        /// Perform a Reduction Transformation on a Scalar Float64 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VREDUCESD.html</remarks>
        void vreducesd();

        /// <summary>
        /// Perform a Reduction Transformation on a Scalar Float32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VREDUCESS.html</remarks>
        void vreducess();

        /// <summary>
        /// Round Packed Float64 Values To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRNDSCALEPD.html</remarks>
        void vrndscalepd();

        /// <summary>
        /// Round Packed Float32 Values To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRNDSCALEPS.html</remarks>
        void vrndscaleps();

        /// <summary>
        /// Round Scalar Float64 Value To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRNDSCALESD.html</remarks>
        void vrndscalesd();

        /// <summary>
        /// Round Scalar Float32 Value To Include A Given Number Of Fraction Bits.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRNDSCALESS.html</remarks>
        void vrndscaless();

        /// <summary>
        /// Compute Approximate Reciprocals of Square Roots of Packed Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRSQRT14PD.html</remarks>
        void vrsqrt14pd();

        /// <summary>
        /// Compute Approximate Reciprocals of Square Roots of Packed Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRSQRT14PS.html</remarks>
        void vrsqrt14ps();

        /// <summary>
        /// Compute Approximate Reciprocal of Square Root of Scalar Float64 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRSQRT14SD.html</remarks>
        void vrsqrt14sd();

        /// <summary>
        /// Compute Approximate Reciprocal of Square Root of Scalar Float32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VRSQRT14SS.html</remarks>
        void vrsqrt14ss();

        /// <summary>
        /// Scale Packed Float64 Values With Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCALEFPD.html</remarks>
        void vscalefpd();

        /// <summary>
        /// Scale Packed Float32 Values With Float32 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCALEFPS.html</remarks>
        void vscalefps();

        /// <summary>
        /// Scale Scalar Float64 Values With Float64 Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCALEFSD.html</remarks>
        void vscalefsd();

        /// <summary>
        /// Scale Scalar Float32 Value With Float32 Value.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCALEFSS.html</remarks>
        void vscalefss();

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html</remarks>
        void vscatterdpd();

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html</remarks>
        void vscatterdps();

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html</remarks>
        void vscatterqpd();

        /// <summary>
        /// Scatter Packed Single, Packed Double with Signed Dword and Qword Indices.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSCATTERDPS:VSCATTERDPD:VSCATTERQPS:VSCATTERQPD.html</remarks>
        void vscatterqps();

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html</remarks>
        void vshuff32x4();

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html</remarks>
        void vshuff64x2();

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html</remarks>
        void vshufi32x4();

        /// <summary>
        /// Shuffle Packed Values at 128-bit Granularity.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VSHUFF32x4:VSHUFF64x2:VSHUFI32x4:VSHUFI64x2.html</remarks>
        void vshufi64x2();

        /// <summary>
        /// Packed Bit Test.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VTESTPD:VTESTPS.html</remarks>
        void vtestpd();

        /// <summary>
        /// Packed Bit Test.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VTESTPD:VTESTPS.html</remarks>
        void vtestps();

        /// <summary>
        /// Zero All YMM Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VZEROALL.html</remarks>
        void vzeroall();

        /// <summary>
        /// Zero Upper Bits of YMM Registers.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/VZEROUPPER.html</remarks>
        void vzeroupper();

        /// <summary>
        /// Wait.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WAIT:FWAIT.html</remarks>
        void wait();

        /// <summary>
        /// Write Back and Invalidate Cache.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WBINVD.html</remarks>
        void wbinvd();

        /// <summary>
        /// Write FS/GS Segment Base.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WRFSBASE:WRGSBASE.html</remarks>
        void wrfsbase();

        /// <summary>
        /// Write FS/GS Segment Base.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WRFSBASE:WRGSBASE.html</remarks>
        void wrgsbase();

        /// <summary>
        /// Write to Model Specific Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WRMSR.html</remarks>
        void wrmsr();

        /// <summary>
        /// Write Data to User Page Key Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/WRPKRU.html</remarks>
        void wrpkru();

        /// <summary>
        /// Transactional Abort.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XABORT.html</remarks>
        void xabort();

        /// <summary>
        /// Hardware Lock Elision Prefix Hints.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XACQUIRE:XRELEASE.html</remarks>
        void xacquire();

        /// <summary>
        /// Exchange and Add.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XADD.html</remarks>
        void xadd();

        /// <summary>
        /// Transactional Begin.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XBEGIN.html</remarks>
        void xbegin();

        /// <summary>
        /// Exchange Register/Memory with Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XCHG.html</remarks>
        void xchg(Value a, Value b);

        /// <summary>
        /// Transactional End.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XEND.html</remarks>
        void xend();

        /// <summary>
        /// Get Value of Extended Control Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XGETBV.html</remarks>
        void xgetbv();

        /// <summary>
        /// Table Look-up Translation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XLAT:XLATB.html</remarks>
        void xlat();

        /// <summary>
        /// Table Look-up Translation.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XLAT:XLATB.html</remarks>
        void xlatb_a16();

        /// <summary>
        /// Logical Exclusive OR.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XOR.html</remarks>
        void xor(Value dst, Value src);

        /// <summary>
        /// Bitwise Logical XOR of Packed Double Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XORPD.html</remarks>
        void xorpd();

        /// <summary>
        /// Bitwise Logical XOR of Packed Single Precision Floating-Point Values.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XORPS.html</remarks>
        void xorps();

        /// <summary>
        /// Hardware Lock Elision Prefix Hints.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XACQUIRE:XRELEASE.html</remarks>
        void xrelease();

        /// <summary>
        /// Restore Processor Extended States.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XRSTOR.html</remarks>
        void xrstor();

        /// <summary>
        /// Restore Processor Extended States Supervisor.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XRSTORS.html</remarks>
        void xrstors();

        /// <summary>
        /// Save Processor Extended States.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XSAVE.html</remarks>
        void xsave();

        /// <summary>
        /// Save Processor Extended States with Compaction.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XSAVEC.html</remarks>
        void xsavec();

        /// <summary>
        /// Save Processor Extended States Optimized.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XSAVEOPT.html</remarks>
        void xsaveopt();

        /// <summary>
        /// Save Processor Extended States Supervisor.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XSAVES.html</remarks>
        void xsaves();

        /// <summary>
        /// Set Extended Control Register.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XSETBV.html</remarks>
        void xsetbv();

        /// <summary>
        /// Test If In Transactional Execution.
        /// </summary>
        /// <remarks>https://www.felixcloutier.com/x86/XTEST.html</remarks>
        void xtest();

        #endregion
    }
}

#pragma warning restore IDE1006 // Naming Styles
