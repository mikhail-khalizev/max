// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

#pragma warning disable IDE1006 // Naming Styles

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using MikhailKhalizev.Max.Configuration;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.Core
{
    public class Processor : IProcessor, IDisposable
    {
        public ProcessorDto Configuration { get; }

        public Processor(ProcessorDto configuration)
        {
            Configuration = configuration;

            _eax = new SimpleRegister(32);
            _ebx = new SimpleRegister(32);
            _ecx = new SimpleRegister(32);
            _edx = new SimpleRegister(32);

            _ax = new OffsetRegister(_eax, 0, 16);
            _bx = new OffsetRegister(_ebx, 0, 16);
            _cx = new OffsetRegister(_ecx, 0, 16);
            _dx = new OffsetRegister(_edx, 0, 16);

            _al = new OffsetRegister(_eax, 0, 8);
            _bl = new OffsetRegister(_ebx, 0, 8);
            _cl = new OffsetRegister(_ecx, 0, 8);
            _dl = new OffsetRegister(_edx, 0, 8);

            _ah = new OffsetRegister(_eax, 8, 8);
            _bh = new OffsetRegister(_ebx, 8, 8);
            _ch = new OffsetRegister(_ecx, 8, 8);
            _dh = new OffsetRegister(_edx, 8, 8);

            _esi = new SimpleRegister(32);
            _edi = new SimpleRegister(32);

            _si = new OffsetRegister(_esi, 0, 16);
            _di = new OffsetRegister(_edi, 0, 16);

            _ebp = new SimpleRegister(32);
            _esp = new SimpleRegister(32);

            _bp = new OffsetRegister(_ebp, 0, 16);
            _sp = new OffsetRegister(_esp, 0, 16);


            _cr0 = new Cr0RegisterImpl { UInt64 = 0x6000_0010 };
            _cr2 = new SimpleRegister(32);
            _cr3 = new SimpleRegister(32);
            _cr4 = new Cr4RegisterImpl();


            _ds = new SegmentRegisterImpl(this);
            _ds.ResetDataSegment();

            _es = new SegmentRegisterImpl(this);
            _es.ResetDataSegment();

            _cs = new SegmentRegisterImpl(this);
            _cs.ResetCodeSegment();

            _ss = new SegmentRegisterImpl(this);
            _ss.ResetDataSegment();

            _fs = new SegmentRegisterImpl(this);
            _fs.ResetDataSegment();

            _gs = new SegmentRegisterImpl(this);
            _gs.ResetDataSegment();

            _ldtr = new SegmentRegisterImpl(this);
            _ldtr.ResetTaskRegisterSegment();

            _tr = new SegmentRegisterImpl(this);
            _tr.ResetTaskRegisterSegment();

            FPUDataPointer_seg = new SegmentRegisterImpl(this);
            FPUInstructionPointer_seg = new SegmentRegisterImpl(this);


            _eflags = new EflagsRegisterImpl { UInt64 = 0x0000_0002 };
            _ia32Efer = new Ia32EferRegisterImpl();

            gdtr_base = 0;
            gdtr_limit = 0xffff;

            idtr_base = 0;
            idtr_limit = 0xffff;

            eip = 0x0000fff0;

            Memory = new Memory(this);
            
            memb_a16 = new MemoryAccessImpl(Memory, 8, 16);
            memw_a16 = new MemoryAccessImpl(Memory, 16, 16);
            memd_a16 = new MemoryAccessImpl(Memory, 32, 16);
            memq_a16 = new MemoryAccessImpl(Memory, 64, 16);

            memb_a32 = new MemoryAccessImpl(Memory, 8, 32);
            memw_a32 = new MemoryAccessImpl(Memory, 16, 32);
            memd_a32 = new MemoryAccessImpl(Memory, 32, 32);
            memq_a32 = new MemoryAccessImpl(Memory, 64, 32);
        }

        #region Registers

        /// <inheritdoc />
        public Register eax
        {
            get => _eax;
            set => _eax.UInt64 = value.UInt64;
        }
        private readonly Register _eax;

        /// <inheritdoc />
        public Register ebx
        {
            get => _ebx;
            set => _ebx.UInt64 = value.UInt64;
        }
        private readonly Register _ebx;

        /// <inheritdoc />
        public Register ecx
        {
            get => _ecx;
            set => _ecx.UInt64 = value.UInt64;
        }
        private readonly Register _ecx;

        /// <inheritdoc />
        public Register edx
        {
            get => _edx;
            set => _edx.UInt64 = value.UInt64;
        }
        private readonly Register _edx;


        /// <inheritdoc />
        public Register ax
        {
            get => _ax;
            set => _ax.UInt64 = value.UInt64;
        }
        private readonly Register _ax;

        /// <inheritdoc />
        public Register bx
        {
            get => _bx;
            set => _bx.UInt64 = value.UInt64;
        }
        private readonly Register _bx;

        /// <inheritdoc />
        public Register cx
        {
            get => _cx;
            set => _cx.UInt64 = value.UInt64;
        }
        private readonly Register _cx;

        public Register dx
        {
            get => _dx;
            set => _dx.UInt64 = value.UInt64;
        }
        private readonly Register _dx;


        public Register al
        {
            get => _al;
            set => _al.UInt64 = value.UInt64;
        }
        private readonly Register _al;

        public Register bl
        {
            get => _bl;
            set => _bl.UInt64 = value.UInt64;
        }
        private readonly Register _bl;

        public Register cl
        {
            get => _cl;
            set => _cl.UInt64 = value.UInt64;
        }
        private readonly Register _cl;

        public Register dl
        {
            get => _dl;
            set => _dl.UInt64 = value.UInt64;
        }
        private readonly Register _dl;


        public Register ah
        {
            get => _ah;
            set => _ah.UInt64 = value.UInt64;
        }
        private readonly Register _ah;

        public Register bh
        {
            get => _bh;
            set => _bh.UInt64 = value.UInt64;
        }
        private readonly Register _bh;

        public Register ch
        {
            get => _ch;
            set => _ch.UInt64 = value.UInt64;
        }
        private readonly Register _ch;

        public Register dh
        {
            get => _dh;
            set => _dh.UInt64 = value.UInt64;
        }
        private readonly Register _dh;


        public Register esi
        {
            get => _esi;
            set => _esi.UInt64 = value.UInt64;
        }
        private readonly Register _esi;

        public Register edi
        {
            get => _edi;
            set => _edi.UInt64 = value.UInt64;
        }
        private readonly Register _edi;


        public Register si
        {
            get => _si;
            set => _si.UInt64 = value.UInt64;
        }
        private readonly Register _si;

        public Register di
        {
            get => _di;
            set => _di.UInt64 = value.UInt64;
        }
        private readonly Register _di;


        public Register ebp
        {
            get => _ebp;
            set => _ebp.UInt64 = value.UInt64;
        }
        private readonly Register _ebp;

        public Register esp
        {
            get => _esp;
            set => _esp.UInt64 = value.UInt64;
        }
        private readonly Register _esp;


        public Register bp
        {
            get => _bp;
            set => _bp.UInt64 = value.UInt64;
        }
        private readonly Register _bp;

        public Register sp
        {
            get => _sp;
            set => _sp.UInt64 = value.UInt64;
        }
        private readonly Register _sp;


        public SegmentRegister ds
        {
            get => _ds;
            set => _ds.UInt64 = value.UInt64;
        }
        private readonly SegmentRegisterImpl _ds;

        public SegmentRegister es
        {
            get => _es;
            set => _es.UInt64 = value.UInt64;
        }
        private readonly SegmentRegisterImpl _es;

        public SegmentRegister cs
        {
            get => _cs;
            set => _cs.UInt64 = value.UInt64;
        }
        private readonly SegmentRegisterImpl _cs;

        public SegmentRegister ss
        {
            get => _ss;
            set => _ss.UInt64 = value.UInt64;
        }
        private readonly SegmentRegisterImpl _ss;

        public SegmentRegister fs
        {
            get => _fs;
            set => _fs.UInt64 = value.UInt64;
        }
        private readonly SegmentRegisterImpl _fs;

        public SegmentRegister gs
        {
            get => _gs;
            set => _gs.UInt64 = value.UInt64;
        }
        private readonly SegmentRegisterImpl _gs;

        public SegmentRegister ldtr
        {
            get => _ldtr;
            set => _ldtr.UInt64 = value.UInt64;
        }
        private readonly SegmentRegisterImpl _ldtr;

        public SegmentRegister tr
        {
            get => _tr;
            set => _tr.UInt64 = value.UInt64;
        }
        private readonly SegmentRegisterImpl _tr;


        public EflagsRegister eflags
        {
            get => _eflags;
            set => _eflags.UInt64 = value.UInt64;
        }
        private readonly EflagsRegister _eflags;

        public Ia32EferRegister ia32_efer
        {
            get => _ia32Efer;
            set => throw new NotImplementedException();
        }
        private readonly Ia32EferRegister _ia32Efer;


        public Cr0Register cr0
        {
            get => _cr0;
            set => _cr0.UInt64 = value.UInt64;
        }
        private readonly Cr0Register _cr0;

        /// <inheritdoc />
        public Register cr2
        {
            get => _cr2;
            set => _cr2.UInt64 = value.UInt64;
        }
        private readonly Register _cr2;

        /// <inheritdoc />
        public Register cr3
        {
            get => _cr3;
            set => _cr3.UInt64 = value.UInt64;
        }
        private readonly Register _cr3;

        /// <inheritdoc />
        public Cr4Register cr4
        {
            get => _cr4;
            set => throw new NotImplementedException();
        }
        private readonly Cr4Register _cr4;


        public uint gdtr_base { get; set; }

        public ushort gdtr_limit { get; set; }


        public uint idtr_base { get; set; }

        public ushort idtr_limit { get; set; }

        /// <summary>
        /// EIP (instruction pointer) register.
        /// </summary>
        /// <remarks>The EIP register contains a 32-bit pointer to the next instruction to be executed.</remarks>
        /// <seealso cref="CurrentInstructionAddress"/>
        public Address eip { get; set; }

        #endregion

        #region FPU

        // TODO Move to separate class?
        ushort FPUControlWord;
        ushort FPUStatusWord;
        ushort FPUTagWord;
        SegmentRegister FPUDataPointer_seg;
        uint FPUDataPointer_off;
        SegmentRegister FPUInstructionPointer_seg;
        uint FPUInstructionPointer_off;
        int FPULastInstructionOpcode;

        #endregion

        #region Memory

        public Memory Memory { get; }
        IMemory IProcessor.Memory => Memory;

        public MemoryAccess memb_a16 { get; }
        public MemoryAccess memw_a16 { get; }
        public MemoryAccess memd_a16 { get; }
        public MemoryAccess memq_a16 { get; }

        public MemoryAccess memb_a32 { get; }
        public MemoryAccess memw_a32 { get; }
        public MemoryAccess memd_a32 { get; }
        public MemoryAccess memq_a32 { get; }

        #endregion

        #region Helpers

        public void set_sf_zf_pf(Value dst)
        {
            eflags.sf = dst.IsNegative;
            eflags.zf = dst.UInt64 == 0;

            // pf - Сумма единиц в младшем байте + 1.

            var pf = true;
            var x = dst.UInt64;
            for (var i = 0; i < 8; i++)
            {
                pf ^= 0 != (x & 1);
                x >>= 1;
            }

            eflags.pf = pf;
        }

        // Режим IA-32e (IA-32e mode, EM64T) фактически является копией режима AMD64.
        // В режиме IA-32e можно выделить два подрежима:
        // - собственно 64-разрядный режим(64-bit mode);
        // - режим совместимости(compatibility mode), предназначенный для исполнения 32-разрядных программ, созданных для защищённого режима работы процессора.

        // Постепенно Intel отказывается от наименований IA-32, IA-32e и EM64T в пользу 'Intel 64', которое теперь является единственным официальным для этой архитектуры со стороны компании Intel.

        // IA-32 architecture supports three basic operating modes:
        // - protected mode,
        // - real-address mode,
        // - system management mode.

        /// <summary>
        /// IA-32e mode has two sub-modes.
        /// - Compatibility Mode
        /// - 64-Bit Mode
        /// </summary>
        public bool InIa32eMode => cr4.pae && cr0.pg && ia32_efer.lma;

        public bool In64BitMode => _cs.In64BitMode;

        public bool InCompatibilityMode => _cs.InCompatibilityMode;

        public int CPL => cr0.pe ? cs.RPL : 0;


        public SegmentDescriptor get_orig_desc_ref(int selector)
        {
            if ((selector & 0x7) != 0)
                throw new NotImplementedException();

            return get_desc_ref(gdtr_base, gdtr_limit, selector);
        }

        public SegmentDescriptor get_desc_ref(uint dt_base, ushort dt_limit, int selector)
        {
            if (!cr0.pe)
                throw new Exception();

            var offset = selector & 0xfff8u;

            if (dt_limit < offset + 7)
                throw new NotImplementedException(); // #GP(selector) or #GP(error_code(vector_number,1,EXT)) in interrupt

            return new SegmentDescriptor(
                Memory.GetFixSize(dt_base + offset, 8).ToArray());
        }

        public void StoreSegmentDescriptor(int selector, SegmentDescriptor descriptor)
        {
            if ((selector & 0x7) != 0)
                throw new NotImplementedException();

            var offset = selector & 0xfff8u;

            if (gdtr_limit < offset + 7)
                throw new NotImplementedException(); // #GP(selector) or #GP(error_code(vector_number,1,EXT)) in interrupt

            var ms = Memory.GetFixSize(gdtr_base + offset, 8);
            descriptor.Bytes.CopyTo(ms.AsSpan());
        }

        public void jmp_far_prepare(int segmentSelector, Address tempEIP)
        {
            if (!cr0.pe || (cr0.pe && eflags.vm)) /* Real-address or virtual-8086 mode */
            {
                if (cs.fail_limit_check(tempEIP)) // is beyond code segment limit
                    throw new NotImplementedException(); // #GP(0);
                cs.Int32 = segmentSelector;
                eip = tempEIP;
                return;
            }

            if (cr0.pe && !eflags.vm) /* IA-32e mode or protected mode, not virtual-8086 mode */
            {
                /* @todo
                    IF effective address in the CS, DS, ES, FS, GS, or SS segment is illegal
                    or segment selector in target operand NULL
                    THEN #GP(0); FI; */

                var new_cs = new SegmentRegisterImpl(this);
                new_cs.Selector = (segmentSelector);

                if (!ia32_efer.lma)
                {
                    if (!(new_cs.Descriptor.IsTypeCode ||
                          new[]
                          {
                              SystemSegmentTypeIn32BitMode.CallGate16Bit,
                              SystemSegmentTypeIn32BitMode.CallGate32Bit,
                              SystemSegmentTypeIn32BitMode.TaskGate,
                              SystemSegmentTypeIn32BitMode.Tss16BitAvailable,
                              SystemSegmentTypeIn32BitMode.Tss16BitBusy,
                              SystemSegmentTypeIn32BitMode.Tss32BitAvailable,
                              SystemSegmentTypeIn32BitMode.Tss32BitBusy
                          }.Contains(new_cs.Descriptor.SystemSegmentTypeIn32BitMode)))
                        throw new NotImplementedException(); // #GP(segment selector)
                }
                else
                {
                    if (!(new_cs.Descriptor.IsTypeCode ||
                          new[] { SystemSegmentTypeInIa32Mode.CallGate64Bit }.Contains(new_cs.Descriptor
                              .SystemSegmentTypeInIa32eMode)))
                        throw new NotImplementedException(); // #GP(segment selector)
                }

                if (new_cs.Descriptor.IsTypeConformingCode)
                {
                    if (new_cs.Descriptor.l && new_cs.db && ia32_efer.lma)
                        throw new NotImplementedException(); // #GP(new code segment selector)
                    if (CPL < new_cs.Descriptor.DPL)
                        throw new NotImplementedException(); // #GP(segment selector)
                    if (!new_cs.Descriptor.Present)
                        throw new NotImplementedException(); // #GP(segment selector)

                    if ((ia32_efer.lma == false || new_cs.InCompatibilityMode)
                        && new_cs.fail_limit_check(tempEIP))
                        throw new NotImplementedException(); // #GP(0)

                    var cpl = CPL;
                    cs = new_cs;
                    cs.RPL = cpl;
                    eip = tempEIP;
                }
                else if (new_cs.Descriptor.IsTypeNonConformingCode)
                {
                    if (new_cs.l && new_cs.db && ia32_efer.lma)
                        throw new NotImplementedException(); // #GP(new code segment selector)
                    if (CPL < new_cs.RPL || (CPL != new_cs.Descriptor.DPL))
                        throw new NotImplementedException(); // #GP(segment selector)
                    if (!new_cs.Descriptor.Present)
                        throw new NotImplementedException(); // #GP(segment selector)

                    if ((ia32_efer.lma == false || new_cs.InCompatibilityMode) && new_cs.fail_limit_check(tempEIP))
                        throw new NotImplementedException(); // #GP(0)

                    var cpl = CPL;
                    cs = new_cs;
                    cs.RPL = cpl;
                    eip = tempEIP;
                }
                else
                    throw new NotImplementedException();
            }
            else
                throw new NotImplementedException(); // #GP(segment selector)
        }

        public void call_far_prepare(int operandSize, int segmentSelector, Address offset)
        {
            if (!cr0.pe || (cr0.pe && eflags.vm)) /* Real-address or virtual-8086 mode */
            {
                if (operandSize == 32)
                {
                    if ((offset | 0xffff) != 0xffff)
                        throw new NotImplementedException(); // #GP(0)
                    pushd(cs);
                    pushd(eip);
                    cs.Int32 = segmentSelector;
                    eip = offset;
                }
                else /* OperandSize = 16 */
                {
                    pushw(cs);
                    pushw(eip);
                    cs.Int32 = segmentSelector;
                    eip = offset;
                }
            }

            if (cr0.pe && !eflags.vm) /* IA-32e mode or protected mode, not virtual-8086 mode */
            {
                /*    IF segment selector in target operand NULL
                    THEN #GP(0); FI;
                    IF segment selector index not within descriptor table limits
                    THEN #GP(new code segment selector); FI;    */

                var new_cs = new SegmentRegisterImpl(this);
                new_cs.Selector = (segmentSelector);

                if (!ia32_efer.lma)
                {
                    if (!(new_cs.Descriptor.IsTypeCode ||
                          new[]
                          {
                              SystemSegmentTypeIn32BitMode.CallGate16Bit,
                              SystemSegmentTypeIn32BitMode.CallGate32Bit,
                              SystemSegmentTypeIn32BitMode.TaskGate,
                              SystemSegmentTypeIn32BitMode.Tss16BitAvailable,
                              SystemSegmentTypeIn32BitMode.Tss16BitBusy,
                              SystemSegmentTypeIn32BitMode.Tss32BitAvailable,
                              SystemSegmentTypeIn32BitMode.Tss32BitBusy
                          }.Contains(new_cs.Descriptor.SystemSegmentTypeIn32BitMode)))
                        throw new NotImplementedException(); // #GP(segment selector)
                }
                else
                {
                    if (!(new_cs.Descriptor.IsTypeCode ||
                          new[] { SystemSegmentTypeInIa32Mode.CallGate64Bit }.Contains(new_cs.Descriptor
                              .SystemSegmentTypeInIa32eMode)))
                        throw new NotImplementedException(); // #GP(segment selector)
                }

                if (new_cs.Descriptor.IsTypeConformingCode)
                {
                    if (new_cs.Descriptor.l && new_cs.db && ia32_efer.lma)
                        throw new NotImplementedException(); // #GP(new code segment selector)
                    if (CPL < new_cs.Descriptor.DPL)
                        throw new NotImplementedException(); // #GP(new code segment selector)
                    if (new_cs.Descriptor.Present == false)
                        throw new NotImplementedException(); // #GP(new code segment selector)

                    if ((ia32_efer.lma == false || new_cs.InCompatibilityMode)
                        && new_cs.fail_limit_check(offset))
                        throw new NotImplementedException(); // #GP(0)

                    if (operandSize == 32)
                    {
                        pushd(cs);
                        pushd(eip);

                        var cpl = CPL;
                        cs = new_cs;
                        cs.RPL = cpl;
                        eip = offset;
                    }
                    else if (operandSize == 16)
                    {
                        pushw(cs);
                        pushw(eip);

                        var cpl = CPL;
                        cs = new_cs;
                        cs.RPL = cpl;
                        eip = offset;
                    }
                    else /* OperandSize = 64 */
                        throw new NotImplementedException();
                }
                else if (new_cs.Descriptor.IsTypeNonConformingCode)
                {
                    if (new_cs.l && new_cs.db && ia32_efer.lma)
                        throw new NotImplementedException(); // #GP(new code segment selector)
                    if (CPL < new_cs.RPL || (CPL != new_cs.Descriptor.DPL))
                        throw new NotImplementedException(); // #GP(segment selector)
                    if (!new_cs.Descriptor.Present)
                        throw new NotImplementedException(); // #GP(segment selector)

                    if ((ia32_efer.lma == false || new_cs.InCompatibilityMode) && new_cs.fail_limit_check(offset))
                        throw new NotImplementedException(); // #GP(0)

                    if (operandSize == 32)
                    {
                        pushd(cs);
                        pushd(eip);

                        var cpl = CPL;
                        cs = new_cs;
                        cs.RPL = cpl;
                        eip = offset;
                    }
                    else if (operandSize == 16)
                    {
                        pushw(cs);
                        pushw(eip);

                        var cpl = CPL;
                        cs = new_cs;
                        cs.RPL = cpl;
                        eip = offset;
                    }
                    else /* OperandSize = 64 */
                        throw new NotImplementedException();
                }
                else
                    throw new NotImplementedException();
            }
        }

        public void ret_far(int operandSize)
        {
            var cpl = CPL;

            switch (operandSize)
            {
                case 16:
                    eip = popw();
                    popw(cs);
                    break;
                case 32:
                    eip = popd();
                    popd(cs);
                    break;
            }


            if (cr0.pe == false || (cr0.pe && eflags.vm)) /* Real-address or virtual-8086 mode */
            {
                if (operandSize == 16 && cs.fail_limit_check(eip))
                    throw new NotImplementedException();
            }

            /* Protected mode, not virtual-8086 mode */
            if (cr0.pe && eflags.vm == false && ia32_efer.lma == false)
            {
                if (cs.IsNull)
                    throw new NotImplementedException(); // #GP(0)
                if (!cs.Descriptor.IsTypeCode)
                    throw new NotImplementedException(); // #GP(selector)
                if (cs.RPL < cpl)
                    throw new NotImplementedException(); // #GP(selector)
                if (cs.Descriptor.IsTypeConformingCode)
                {
                    if (cs.RPL < cs.Descriptor.DPL)
                        throw new NotImplementedException(); // #GP(selector)
                }
                else if (cs.RPL != cs.Descriptor.DPL)
                    throw new NotImplementedException(); // #GP(selector)

                if (cs.Descriptor.Present == false)
                    throw new NotImplementedException(); // #NP(selector)

                if (cpl < cs.RPL)
                {
                    // RETURN-OUTER-PRIVILEGE-LEVEL
                    throw new NotImplementedException();
                }
                else
                {
                    // RETURN-TO-SAME-PRIVILEGE-LEVEL

                    if (cs.fail_limit_check(eip))
                        throw new NotImplementedException(); // #GP(0)
                }
            }

            /* IA-32e Mode */
            if (cr0.pe && eflags.vm == false && ia32_efer.lma)
                throw new NotImplementedException();
        }

        public void popf_(int operandSize)
        {
            uint flg = 0;
            uint clr_flg = 0;
            uint no_mod_mask = 0;

            switch (operandSize)
            {
                case 32:
                    flg = popd();
                    break;
                case 16:
                    flg = popw();
                    no_mod_mask = 0xffff0000;
                    break;
                default:
                    throw new NotImplementedException();
            }


            // From AMD manual.
            if (cr0.pe == false)
            {
                // REAL_MODE
                no_mod_mask |= EflagsMask.vip | EflagsMask.vif | EflagsMask.vm;
                clr_flg = EflagsMask.rf;
            }
            else if (cr0.pe && eflags.vm == false)
            {
                // PROTECTED_MODE
                no_mod_mask |= EflagsMask.vip | EflagsMask.vif | EflagsMask.vm;
                if (CPL != 0)
                    no_mod_mask |= EflagsMask.iopl;
                if (eflags.iopl < CPL)
                    no_mod_mask |= EflagsMask.@if;
                clr_flg = EflagsMask.rf;
            }
            else
            {
                // VIRTUAL_MODE
                throw new NotImplementedException();
            }

            eflags.UInt64 = ((eflags.UInt64 & (~clr_flg)) & no_mod_mask) | (flg & (~no_mod_mask));
        }

        public void switch_task(
            task_switch_reason ts_reason,
            bool in_interrupt_int_n,
            bool in_interrupt_hw,
            ushort tss_new_selector,
            SegmentDescriptor tss_new_desc,
            bool switch_through_task_gate,
            uint task_gate_dpl)
        {
            if (ts_reason != task_switch_reason.interrupt)
                in_interrupt_int_n = in_interrupt_hw = false;

            // 2.

            uint dpl;
            if (switch_through_task_gate)
                dpl = task_gate_dpl;
            else
                dpl = tss_new_desc.DPL;

            if (ts_reason != task_switch_reason.exception
                && ts_reason != task_switch_reason.iret
                && (ts_reason != task_switch_reason.interrupt || in_interrupt_int_n))
                if (dpl < CPL || dpl < (tss_new_selector & 0x3 /* rpl */))
                    throw new NotImplementedException(); // #GP

            // 3. Checks that the TSS descriptor of the new task is marked present and has a valid limit (greater than or equal to 0x67).
            if (!tss_new_desc.Present || tss_new_desc.Limit < 0x67)
                throw new NotImplementedException(); // #TS

            // 4. Checks that the new task is available (call, jump, exception, or interrupt) or busy (IRET return).
            if (tss_new_desc.IsTssBusy != (ts_reason == task_switch_reason.iret))
                throw new NotImplementedException();

            // 5. Checks that the current (old) TSS, new TSS, and all segment descriptors used in the task switch are paged into system memory.
            // @todo Не понял, о чём это они.

            // 6. If the task switch was initiated with a JMP or IRET instruction, the processor clears the busy (B) flag in the current (old) task’s TSS descriptor.
            var tss_old_selector = tr.Selector;

            if (ts_reason == task_switch_reason.jmp || ts_reason == task_switch_reason.iret)
            {
                var tss_old_desc = get_orig_desc_ref(tss_old_selector);
                tss_old_desc.IsTssBusy = false;
                StoreSegmentDescriptor(tss_old_selector, tss_old_desc);
            }

            // 8. 7.

            if (tr.Descriptor.SystemSegmentTypeIn32BitMode != SystemSegmentTypeIn32BitMode.Tss32BitAvailable &&
                tr.Descriptor.SystemSegmentTypeIn32BitMode != SystemSegmentTypeIn32BitMode.Tss32BitBusy)
                throw new NotImplementedException();

            tss32SaveContext(
                tr.Descriptor.Base,
                ts_reason != task_switch_reason.exception || in_interrupt_hw,
                ts_reason == task_switch_reason.iret);

            // 10.
            if (ts_reason == task_switch_reason.call
                || ts_reason == task_switch_reason.jmp
                || ts_reason == task_switch_reason.exception
                || ts_reason == task_switch_reason.interrupt)
                tss_new_desc.IsTssBusy = true;

            // 11.
            tr.Selector = tss_new_selector;

            // 12.
            if (tr.Descriptor.SystemSegmentTypeIn32BitMode != SystemSegmentTypeIn32BitMode.Tss32BitAvailable &&
                tr.Descriptor.SystemSegmentTypeIn32BitMode != SystemSegmentTypeIn32BitMode.Tss32BitBusy)
                throw new NotImplementedException();

            var ms = Memory.GetFixSize(tr.Descriptor.Base, 104);

            cr3 = ms.GetUInt32(28);
            eip = ms.GetUInt32(32);
            eflags.UInt32 = ms.GetUInt32(36);
            eax = ms.GetUInt32(40);
            ecx = ms.GetUInt32(44);
            edx = ms.GetUInt32(48);
            ebx = ms.GetUInt32(52);
            esp = ms.GetUInt32(56);
            ebp = ms.GetUInt32(60);
            esi = ms.GetUInt32(64);
            edi = ms.GetUInt32(68);

            ldtr.Selector = ms.GetUInt16(96);

            es.Selector = (ms.GetUInt16(72));
            cs.Selector = (ms.GetUInt16(76));
            ss.Selector = (ms.GetUInt16(80));
            ds.Selector = (ms.GetUInt16(84));
            fs.Selector = (ms.GetUInt16(88));
            gs.Selector = (ms.GetUInt16(92));

            // 9.
            if (ts_reason == task_switch_reason.call
                || ts_reason == task_switch_reason.exception
                || ts_reason == task_switch_reason.interrupt)
            {
                eflags.nt = true;

                ms.SetUInt32(ms.GetUInt32(36) | EflagsMask.nt, 36); // set nt flag.
                ms.SetUInt32(tss_old_selector, 0); // 7.4 TASK LINKING
            }

            // end of switch_tasks
        }

        public void int_internal(
            int num,
            bool software_interrupt,
            bool in_interrupt_int_n,
            bool fault_with_error_code,
            uint error_code)
        {
            //if (extra_log)
            //    std::cout << "int_" << std::hex << std::setw(2) << num << std::endl;

            if (!cr0.pe)
            {
                if (idtr_limit < (num << 2) + 3)
                    throw new NotImplementedException(); // #GP;

                // IF stack not large enough for a 6-byte return information
                // THEN #SS; FI;

                pushfw();
                eflags.@if = false; /* Clear interrupt flag */
                eflags.tf = false; /* Clear trap flag */
                eflags.ac = false; /* Clear AC flag */
                pushw(cs);
                pushw(eip);

                /* No error codes are pushed in real-address mode */
                var ms = Memory.GetFixSize(idtr_base + num * 4, 4);
                eip = ms.GetUInt16();
                cs.Selector = (ms.GetUInt16(2));
            }
            else // PE = 1
            {
                if (eflags.vm && eflags.iopl < 3 && in_interrupt_int_n)
                    throw new NotImplementedException(); // #GP(0); (* Bit 0 of error code is 0 because INT n *)

                /* Protected mode, IA-32e mode, or virtual-8086 mode interrupt */
                if (ia32_efer.lma == false)
                {
                    /* Protected mode, or virtual-8086 mode interrupt */

                    var desc = get_desc_ref(idtr_base, idtr_limit, (ushort)(num * 8));

                    if (!(new[]
                    {
                        SystemSegmentTypeIn32BitMode.InterruptGate16Bit,
                        SystemSegmentTypeIn32BitMode.InterruptGate32Bit,
                        SystemSegmentTypeIn32BitMode.TrapGate16Bit,
                        SystemSegmentTypeIn32BitMode.TrapGate32Bit,
                        SystemSegmentTypeIn32BitMode.TaskGate
                    }.Contains(desc.SystemSegmentTypeIn32BitMode)))
                        throw new NotImplementedException(); // #GP(error_code(vector_number,1,EXT));
                    if (software_interrupt && desc.DPL < CPL)
                        throw new NotImplementedException(); // #GP(error_code(vector_number,1,0));
                    if (!desc.Present)
                        throw new NotImplementedException(); // #NP(error_code(vector_number,1,EXT));


                    var size_of_stack_frame_pushes = 0;


                    if (desc.SystemSegmentTypeIn32BitMode == SystemSegmentTypeIn32BitMode.TaskGate)
                    {
                        // TASK-GATE
                        var tss_new_selector = desc.GateSelector;

                        if (((tss_new_selector >> 2) & 0x1) == 1 /* local */
                            || gdtr_limit < (tss_new_selector & 0xfff8) + 7)
                            throw new NotImplementedException(); // #GP(error_code(TSS selector,0,EXT))

                        var tss_new_desc = get_desc_ref(gdtr_base, gdtr_limit, tss_new_selector);
                        size_of_stack_frame_pushes = tss_new_desc.get_system_segment_size;

                        if (tss_new_desc.IsTssBusy)
                            throw new NotImplementedException(); // #GP(TSS selector,0,EXT))
                        if (!tss_new_desc.Present)
                            throw new NotImplementedException(); // #NP(TSS selector,0,EXT))


                        switch_task(
                            fault_with_error_code ? task_switch_reason.exception : task_switch_reason.interrupt,
                            in_interrupt_int_n,
                            !software_interrupt,
                            tss_new_selector,
                            tss_new_desc,
                            true, desc.DPL);


                        if (fault_with_error_code)
                        {
                            // IF stack limit does not allow push of error code
                            // THEN #SS(EXT); FI;

                            // In legacy mode, the size of an IDT entry (16 bits or 32 bits) determines the size of interrupt-stack-frame pushes.

                            if (size_of_stack_frame_pushes == 32)
                                pushd(error_code);
                            else if (size_of_stack_frame_pushes == 16)
                                pushw(error_code);
                            else
                                throw new NotImplementedException();
                        }

                        if (cs.fail_limit_check(eip))
                            throw new NotImplementedException(); // #GP(EXT)
                    }
                    else
                    {
                        // TRAP-OR-INTERRUPT-GATE

                        var new_cs_selector = desc.GateSelector;
                        if (new_cs_selector <= 0x3) // NULL
                            throw new NotImplementedException(); // #GP(EXT)

                        var new_cs = new SegmentRegisterImpl(this);
                        new_cs.Selector = (new_cs_selector);

                        if (!new_cs.Descriptor.IsTypeCode
                            || CPL < new_cs.Descriptor.DPL)
                            throw new NotImplementedException(); // #GP(error_code(new code-segment selector,0,EXT))
                        if (!new_cs.Descriptor.Present)
                            throw new NotImplementedException(); // #NP(error_code(new code-segment selector,0,EXT))

                        var cpl = CPL;

                        if (new_cs.Descriptor.IsTypeNonConformingCode && new_cs.Descriptor.DPL < CPL)
                        {
                            if (eflags.vm)
                                throw new NotImplementedException();

                            // INTER-PRIVILEGE-LEVEL-INTERRUPT;
                            throw new NotImplementedException();
                        }
                        else /* PE = 1, interrupt or trap gate, DPL ≥ CPL */
                        {
                            if (eflags.vm)
                                throw new NotImplementedException(); // #GP(error_code(new code-segment selector,0,EXT))
                            if (new_cs.Descriptor.IsTypeConformingCode || new_cs.Descriptor.DPL == CPL)
                            {
                                // INTRA-PRIVILEGE-LEVEL-INTERRUPT;
                                if (ia32_efer.lma)
                                    throw new NotImplementedException();

                                var new_eip = desc.InterruptOrTrapEip;

                                if (new_cs.fail_limit_check(new_eip))
                                    throw new NotImplementedException(); // #GP(EXT)

                                if (desc.get_system_segment_size != 32)
                                    throw new NotImplementedException();

                                pushfd();
                                pushd(cs);
                                pushd(eip);
                                cs = new_cs;
                                eip = new_eip;
                                if (fault_with_error_code)
                                    pushd(error_code);
                            }
                            else
                                throw new NotImplementedException(); // #GP(error_code(new code-segment selector,0,EXT))
                        }

                        cs.RPL = cpl;
                        if (desc.SystemSegmentTypeIn32BitMode == SystemSegmentTypeIn32BitMode.InterruptGate16Bit ||
                            desc.SystemSegmentTypeIn32BitMode == SystemSegmentTypeIn32BitMode.InterruptGate32Bit)
                            eflags.@if = false;
                        eflags.nt = false;
                        eflags.tf = false;
                        eflags.vm = false;
                        eflags.rf = false;
                    }
                }
                else /* IA-32e mode interrupt */
                    throw new NotImplementedException();
            }
        }

        public void tss32SaveContext(Address address, bool next_eip, bool clr_nt_flag)
        {
            var ms = Memory.GetFixSize(address, 104);

            var ef = eflags.UInt32;
            if (clr_nt_flag)
                ef &= ~EflagsMask.nt;

            var ip = next_eip ? eip : CurrentInstructionAddress;

            ms.SetUInt32(cr3, 28);
            ms.SetUInt32(ip, 32);
            ms.SetUInt32(ef, 36);
            ms.SetUInt32(eax, 40);
            ms.SetUInt32(ecx, 44);
            ms.SetUInt32(edx, 48);
            ms.SetUInt32(ebx, 52);
            ms.SetUInt32(esp, 56);
            ms.SetUInt32(ebp, 60);
            ms.SetUInt32(esi, 64);
            ms.SetUInt32(edi, 68);
            ms.SetUInt32(es.Selector, 72);
            ms.SetUInt32(cs.Selector, 76);
            ms.SetUInt32(ss.Selector, 80);
            ms.SetUInt32(ds.Selector, 84);
            ms.SetUInt32(fs.Selector, 88);
            ms.SetUInt32(gs.Selector, 92);
            ms.SetUInt32(ldtr.Selector, 96);
        }

        public void iret_(int op_size)
        {
            if (cr0.pe == false)
            {
                // REAL-ADDRESS-MODE
                if (op_size == 32)
                {
                    eip = popd();
                    if ((eip | 0xffff) != 0xffff)
                        throw new NotImplementedException(); // #GP(0)
                    popd(cs);

                    var tempEFLAGS = popd();
                    eflags.UInt32 = (tempEFLAGS & 0x257FD5u) | (eflags.UInt32 & 0x1A0000u);
                }
                else
                {
                    eip = popw();
                    popw(cs);

                    var tempEFLAGS = popw();
                    eflags.UInt32 = tempEFLAGS | (eflags.UInt32 & 0xffff0000);
                }
            }
            else
            {
                if (ia32_efer.lma == false)
                {
                    // PROTECTED-MODE

                    if (eflags.vm)
                        // RETURN-FROM-VIRTUAL-8086-MODE
                        throw new NotImplementedException();

                    if (eflags.nt)
                    {
                        // TASK-RETURN
                        var tss_old_ms = Memory.GetFixSize(tr.Descriptor.Base, 104);
                        var tss_new_selector = tss_old_ms.GetUInt16();

                        if (((tss_new_selector >> 2) & 0x1) == 1 /* local */
                                || gdtr_limit < (tss_new_selector & 0xfff8) + 7)
                            throw new NotImplementedException(); // #TS(TSS selector)

                        var tss_new_desc = get_desc_ref(gdtr_base, gdtr_limit, tss_new_selector);
                        if (!new[]
                            {
                                SystemSegmentTypeIn32BitMode.Tss16BitBusy,
                                SystemSegmentTypeIn32BitMode.Tss32BitBusy
                            }.Contains(tss_new_desc.SystemSegmentTypeIn32BitMode)
                        )
                            throw new NotImplementedException(); // #TS(TSS selector)
                        if (!tss_new_desc.Present)
                            throw new NotImplementedException(); // #NP(TSS selector)

                        switch_task(task_switch_reason.iret, false, false,
                                tss_new_selector, tss_new_desc,
                                false, 0);

                        if (cs.fail_limit_check(eip))
                            throw new NotImplementedException(); // #GP(0)

                        return;
                    }

                    var cpl = CPL;

                    if (op_size != 32)
                        throw new NotImplementedException();
                    eip = popd();
                    popd(cs);

                    var tempEFLAGS = popd();

                    if ((tempEFLAGS & EflagsMask.vm) != 0 && CPL == 0)
                        throw new NotImplementedException(); // RETURN-TO-VIRTUAL-8086-MODE;
                    else
                    {
                        // PROTECTED-MODE-RETURN;
                        if (cs.IsNull)
                            throw new NotImplementedException(); // GP(0)
                        if (!cs.Descriptor.IsTypeCode)
                            throw new NotImplementedException(); // #GP(selector)
                        if (cs.RPL < cpl)
                            throw new NotImplementedException(); // #GP(selector)
                        if (cs.Descriptor.IsTypeConformingCode && cs.RPL < cs.Descriptor.DPL)
                            throw new NotImplementedException(); // #GP(selector)
                        if (!cs.Descriptor.Present)
                            throw new NotImplementedException(); // #NP(selector)
                        if (cpl < cs.RPL)
                        {
                            // RETURN-OUTER-PRIVILEGE-LEVEL
                            throw new NotImplementedException();
                        }
                        else
                        {
                            // RETURN-TO-SAME-PRIVILEGE-LEVEL

                            if (cs.fail_limit_check(eip))
                                throw new NotImplementedException(); // #GP(0)

                            var ef_mask =
                                    EflagsMask.cf |
                                    EflagsMask.pf |
                                    EflagsMask.af |
                                    EflagsMask.zf |
                                    EflagsMask.sf |
                                    EflagsMask.tf |
                                    EflagsMask.df |
                                    EflagsMask.of |
                                    EflagsMask.nt;

                            if (32 <= op_size)
                                ef_mask |= EflagsMask.rf | EflagsMask.ac | EflagsMask.id;

                            if (cpl <= eflags.iopl)
                                ef_mask |= EflagsMask.@if;

                            if (cpl == 0)
                            {
                                ef_mask |= EflagsMask.iopl;
                                if (32 <= op_size)
                                    ef_mask |= EflagsMask.vip | EflagsMask.vif;
                            }

                            eflags.UInt32 = (tempEFLAGS & ef_mask) | (eflags.UInt32 & (~ef_mask));
                        }
                    }
                }
                else
                {
                    // IA-32e-MODE
                    throw new NotImplementedException();
                }
            }
        }

        public void paging_fault(Address address)
        {
            cr2 = address;

            var curSave = CurrentInstructionAddress;
            var eipSave = eip;
            var mode = cs.db ? 32 : 16;

            var returnAddress = cs[CurrentInstructionAddress];

            int_internal(0xe, true, false, true, 0);

            correct_function_position(returnAddress);

            check_mode(mode);
            CurrentInstructionAddress = curSave;
            eip = eipSave;
        }

        private void run_irqs()
        {
            // TODO dos::pic.run_irqs();
        }

        private bool jmpw_if(bool cond, Address address, int offset)
        {
            if (cond)
            {
                jmpw(address, offset);
                return true;
            }

            return false;
        }

        private bool jmpd_if(bool cond, Address address, int offset)
        {
            if (cond)
            {
                jmpd(address, offset);
                return true;
            }

            return false;
        }

        private bool jmpw_func_if(bool cond, Address address, int offset)
        {
            if (cond)
            {
                jmpw_func_internal(address, offset, false);
                return true;
            }

            return false;
        }

        private void jmpw_func_internal(Address address, int offset, bool haveReturnAfterInstruction)
        {
            var retAddr = cs[eip];

            eip = eip + offset;
            eip &= 0xffff;

            if (cs.fail_limit_check(eip))
                throw new NotImplementedException();

            run_irqs();
            correct_function_position(retAddr, haveReturnAfterInstruction);
        }

        private void __plus_sp(int s)
        {
            if (ss.db)
                esp += s;
            else
                sp += s;
        }

        private void SaveJumpInfo()
        {
            var from = cs[CurrentInstructionAddress];
            var to = cs[eip];
            if (!callReturnAddresses.Contains(to))
                MethodsInfo.AddJumpAndSave(MethodInfo, from, to, CSharpFunctionDelta);
        }

        #endregion

        #region C# emulate specific

        public MethodInfoDto MethodInfo { get; set; }
        public MethodsInfo MethodsInfo { get; set; }

        /// <summary>
        /// Gets or sets address of current executing instruction.
        /// </summary>
        /// <seealso cref="eip"/>
        public Address CurrentInstructionAddress { get; set; }

        public int CSharpEmulateMode => (int)MethodInfo.Mode;
        public int CSharpFunctionDelta { get; set; }

        public List<Address> callReturnAddresses { get; set; } = new List<Address>();

        // todo rename ExecuteSubMethod
        public event EventHandler<EventArgs> run_func;
        public event EventHandler<(Value value, Value port)> runInb;
        public event EventHandler<(Value port, Value value)> runOutb;

        public void check_mode() => check_mode(CSharpEmulateMode);

        public void check_mode(int mode)
        {
            if (In64BitMode)
                throw new NotImplementedException();
            if (mode != (cs.db ? 32 : 16))
                throw new Exception("Bad mode");
        }

        public void correct_function_position(Address returnAddress, bool haveReturnAfterInstruction = false)
        {
            if (!haveReturnAfterInstruction)
                callReturnAddresses.Add(returnAddress);
            else
                returnAddress = 0 < callReturnAddresses.Count ? callReturnAddresses[callReturnAddresses.Count - 1] : (Address)0;

            try
            {
                var hist = new List<Address>(); // for debug

                while (true)
                {
                    var toRun = cs[eip];
                    hist.Add(toRun);

                    if (toRun == 0)
                        throw new Exception("Переход по нулевому указателю.");

                    Memory.GetMinSize(cs, eip, 1); // Проверим, есть ли у нас доступ к памяти.

                    if (toRun == returnAddress)
                        return;

                    // Шаг первый - ищем среди уже вызванных функций.
                    var index = callReturnAddresses.LastIndexOf(toRun);
                    if (0 <= index)
                        throw new GoUpException();

                    // Шаг второй - если не нашли - значит вызываем новую функцию.
                    try
                    {
                        run_func?.Invoke(this, null);
                    }
                    catch (GoUpException)
                    {
                        // Ignore.
                    }
                }
            }
            finally
            {
                if (!haveReturnAfterInstruction)
                    callReturnAddresses.RemoveAt(callReturnAddresses.Count - 1);
            }
        }

        public class GoUpException : Exception
        { }

        private StreamWriter _stateLog;

        public void ii(Address address, uint length)
        {
            check_mode();

            if (cs.fail_limit_check(eip))
                throw new NotImplementedException();

            var cur = address + CSharpFunctionDelta - cs.Descriptor.Base;

            if (eip != cur)
                throw new InvalidOperationException("Ожидается инструкция другому адресу.");

            CurrentInstructionAddress = cur;
            eip = cur + length;

            if (!cs.db && (0xffff < eip || 0xffff < CurrentInstructionAddress))
                throw new Exception("Bad eip");

            if (!string.IsNullOrEmpty(Configuration.StateOutput))
            {
                if (_stateLog == null)
                    _stateLog = new StreamWriter(Configuration.StateOutput);

                var effAddress = cs[CurrentInstructionAddress];
                var prefix = "";
                if (effAddress != address)
                    prefix = $"    method guid: {{{MethodInfo.Guid}}}, csharp_address: {address}{Environment.NewLine}";

                _stateLog.WriteLine(
                    prefix
                    + "cs[eip]: " + effAddress
                    + ", eax: " + eax
                    + ", ebx: " + ebx
                    + ", ecx: " + ecx
                    + ", edx: " + edx
                    + ", esi: " + esi
                    + ", edi: " + edi
                    + ", esp: " + esp
                    + ", ebp: " + ebp
                    + ", flags: " + eflags
                    + ", cs: " + cs + " " + (Address)cs.Descriptor.Base
                    + ", ss: " + ss + " " + (Address)ss.Descriptor.Base
                    + ", ds: " + ds + " " + (Address)ds.Descriptor.Base
                    + ", es: " + es + " " + (Address)es.Descriptor.Base
                    + ", fs: " + fs + " " + (Address)fs.Descriptor.Base
                    + ", gs: " + gs + " " + (Address)gs.Descriptor.Base);
            }

            //if (memw_a32[0x13_0000] == 0xcccc)
            //{
            //    var debug = 0;
            //}

            //if (cs[eip] == 0x14_db21 && eax == 0xcccc)
            //{
            //    var debug = 0;
            //}
        }

        /// <inheritdoc />
        public void invalid()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Instructions

        /// <inheritdoc />
        public void aaa()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void aad()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void aam()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void aas()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void adc(Value dst, Value src)
        {
            src = new NumericValue(src.UInt64, dst.Bits);

            var ss = src.IsPositive;
            var ds = dst.IsPositive;

            var sv = src.UInt64;
            var dv = dst.UInt64;
            dst.UInt64 = dv + sv + (eflags.cf ? 1u : 0);
            var rv = dst.UInt64;

            var rs = dst.IsPositive;

            eflags.of = (ds == ss) && (ss != rs);
            eflags.cf = rv < sv || rv < dv;
            set_sf_zf_pf(dst);
            // af
        }

        /// <inheritdoc />
        public void adcx()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void add(Value dst, Value src)
        {
            src = new NumericValue(src.UInt64, dst.Bits);

            var ss = src.IsPositive;
            var ds = dst.IsPositive;

            var sv = src.UInt64;
            var dv = dst.UInt64;

            dst.UInt64 = dv + sv;

            var rv = dst.UInt64;
            var rs = dst.IsPositive;

            /* d  s  r  of
             * +  +  +   0
             * +  +  -   1
             * +  -  +   0
             * +  -  -   0
             * -  +  +   0
             * -  +  -   0
             * -  -  +   1
             * -  -  -   0
             */

            eflags.of = (ds == ss) && (ss != rs);
            eflags.cf = rv < sv || rv < dv;
            set_sf_zf_pf(dst);
            // af
        }

        /// <inheritdoc />
        public void addpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void addps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void addsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void addss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void addsubpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void addsubps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void adox()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void aesdec()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void aesdeclast()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void aesenc()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void aesenclast()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void aesimc()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void aeskeygenassist()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void and(Value dst, Value src)
        {
            dst.UInt64 &= src.UInt64;

            eflags.cf = false;
            eflags.of = false;
            set_sf_zf_pf(dst);
        }

        /// <inheritdoc />
        public void andn()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void andnpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void andnps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void andpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void andps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void arpl()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bextr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void blendpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void blendps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void blendvpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void blendvps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void blsi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void blsmsk()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void blsr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bndcl()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bndcn()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bndcu()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bndldx()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bndmk()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bndmov()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bndstx()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bound()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bsf()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bsr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bswap()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bt(Value dst, Value src)
        {
            eflags.cf = 0 != ((dst.UInt32 >> (int)(src.UInt32 % dst.Bits)) & 1);
        }

        /// <inheritdoc />
        public void btc(Value dst, Value src)
        {
            bt(dst, src);
            var x = (1u << (int)(src.UInt32 % dst.Bits));
            dst.UInt32 ^= x;
        }

        /// <inheritdoc />
        public void btr(Value dst, Value src)
        {
            bt(dst, src);
            dst.Int32 &= ~(1 << (int)(src.UInt32 % 32));
        }

        /// <inheritdoc />
        public void bts()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void bzhi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void callw(Address address, int offset)
        {
            var retAddr = cs[eip];
            pushw(eip);

            eip = eip + offset;
            eip &= 0xffff;

            if (cs.fail_limit_check(eip))
                throw new NotImplementedException();

            run_irqs();
            correct_function_position(retAddr);
        }

        /// <inheritdoc />
        public void calld(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void callw_abs(Value address)
        {
            pushw(eip);
            var ret_addr = cs[eip];

            eip = address & 0xffff;
            if (cs.fail_limit_check(eip))
                throw new NotImplementedException();

            run_irqs();
            SaveJumpInfo();
            correct_function_position(ret_addr);
        }

        /// <inheritdoc />
        public void calld_abs(Value address)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void callw_far_abs(int segment, Address address)
        {
            var ret_addr = cs[eip];
            call_far_prepare(16, segment, address & 0xffff);
            run_irqs();
            correct_function_position(ret_addr);
        }

        /// <inheritdoc />
        public void callw_a16_far_ind(SegmentRegister segment, Value address)
        {
            var ret_addr = cs[eip];
            call_far_prepare(16, memw_a16[segment, address + 2].UInt16, memw_a16[segment, address].UInt16);
            run_irqs();
            correct_function_position(ret_addr);
        }

        /// <inheritdoc />
        public void calld_a32_far_ind(SegmentRegister segment, Value address)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void calld_a16_far_ind(SegmentRegister segment, Value address)
        {
            var ret_addr = cs[eip];
            call_far_prepare(32, memw_a16[segment, address + 4].UInt16, memd_a16[segment, address].UInt32);
            run_irqs();
            correct_function_position(ret_addr);
        }

        /// <inheritdoc />
        public void cbw()
        {
            ah = al.IsNegative ? -1 : 0;
        }

        /// <inheritdoc />
        public void cdq()
        {
            edx = eax.IsNegative ? -1 : 0;
        }

        /// <inheritdoc />
        public void cdqe()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void clac()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void clc()
        {
            eflags.cf = false;
        }

        /// <inheritdoc />
        public void cld()
        {
            eflags.df = false;
        }

        /// <inheritdoc />
        public void clflush()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void clflushopt()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cli()
        {
            if (cr0.pe == false)
                eflags.@if = false;
            else
            {
                if (eflags.vm == false)
                {
                    if (CPL <= eflags.iopl)
                        eflags.@if = false;
                    else
                    {
                        if (eflags.iopl < CPL && CPL == 3 && cr4.pvi)
                            eflags.vif = false;
                        else
                            throw new NotImplementedException(); // #GP(0);
                    }
                }
                else
                {
                    if (eflags.iopl == 3)
                        eflags.@if = false;
                    else
                    {
                        if (eflags.iopl < 3 && cr4.vme)
                            eflags.vif = false;
                        else
                            throw new NotImplementedException(); // #GP(0);
                    }
                }
            }
        }

        /// <inheritdoc />
        public void clts()
        {
            if (CPL != 0)
                throw new NotImplementedException(); // #GP(0)
            cr0.ts = false;
        }

        /// <inheritdoc />
        public void clwb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmc()
        {
            eflags.cf = !eflags.cf;
        }

        /// <inheritdoc />
        public void cmovcc()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmp(Value a, Value b)
        {
            eflags.cf = a.UInt64 < b.UInt64;

            var r = new NumericValue(a.UInt64 - b.UInt64, a.Bits);
            var ds = a.IsPositive;
            var ss = b.IsPositive;
            var rs = r.IsPositive;

            /* d  s  r  of
             * +  +  +   0
             * +  +  -   0
             * +  -  +   0
             * +  -  -   1
             * -  +  +   1
             * -  +  -   0
             * -  -  +   0
             * -  -  -   0  */

            eflags.of = (ds != ss) && (ss == rs);
            set_sf_zf_pf(r);
            // af
        }

        /// <inheritdoc />
        public void cmppd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmpps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmpsb_a16()
        {
            cmp(memb_a16[ds, si], memb_a16[es, di]);
            di += eflags.df ? -1 : 1;
            si += eflags.df ? -1 : 1;
        }

        /// <inheritdoc />
        public void cmpsb_a32()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmpsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmpsd_fp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmpsq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmpss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmpsw_a16()
        {
            cmp(memw_a16[ds, si], memw_a16[es, di]);
            di += eflags.df ? -2 : 2;
            si += eflags.df ? -2 : 2;
        }

        /// <inheritdoc />
        public void cmpxchg()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmpxchg16b()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cmpxchg8b()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void comisd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void comiss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cpuid()
        {
            if (eax != 1)
                throw new NotImplementedException();

            eax = 0x402; // Intel 486.
            ebx = 0;
            ecx = 0;
            edx = 1;
        }

        /// <inheritdoc />
        public void cqo()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void crc32()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtdq2pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtdq2ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtpd2dq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtpd2pi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtpd2ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtpi2pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtpi2ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtps2dq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtps2pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtps2pi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtsd2si()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtsd2ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtsi2sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtsi2ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtss2sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvtss2si()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvttpd2dq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvttpd2pi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvttps2dq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvttps2pi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvttsd2si()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cvttss2si()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void cwd()
        {
            dx = ax.IsNegative ? -1 : 0;
        }

        /// <inheritdoc />
        public void cwde()
        {
            movsx(eax, ax);
        }

        /// <inheritdoc />
        public void daa()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void das()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void dec(Value value)
        {
            var r = new NumericValue(value.UInt64 - 1, value.Bits);
            var ds = value.IsPositive;
            var ss = true;
            var rs = r.IsPositive;

            eflags.of = (ds != ss) && (ss == rs);
            set_sf_zf_pf(r);
            // af

            value.UInt64 = r.UInt64;
        }

        /// <inheritdoc />
        public void div(Value value)
        {
            if (value.Bits == 8)
            {
                if (value == 0)
                    throw new NotImplementedException(); // #DE

                var w = ax.UInt16;

                var t = w / value.UInt16;
                if (0xff < t)
                    throw new NotImplementedException(); // #DE

                al = t;
                ah = w % value.UInt16;
                return;
            }

            if (value.Bits == 16)
            {
                if (value == 0)
                    throw new NotImplementedException(); // #DE

                var w = (dx.UInt16 << 16) + ax.UInt16;

                var t = w / value.UInt16;
                if (0xffff < t)
                    throw new NotImplementedException(); // #DE

                ax = t;
                dx = w % value.UInt16;

                return;
            }

            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void divpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void divps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void divsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void divss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void dppd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void dpps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void emms()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void enterw(int allocSize, int nestingLevel)
        {
            if (nestingLevel != 0)
                throw new NotImplementedException();

            pushw(bp);

            if (ss.db)
            {
                ebp = esp;
                esp -= allocSize;
            }
            else
            {
                bp = sp;
                sp -= allocSize;
            }
        }

        /// <inheritdoc />
        public void extractps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void f2xm1()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fabs()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fadd(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void faddp(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fbld()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fbstp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fchs()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fclex()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fcmovcc()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fcom(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fcomi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fcomip()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fcomp(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fcomp(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fcompp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fcos()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fdecstp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fdiv(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fdivp(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fdivr(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fdivrp(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ffree()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fiadd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ficom()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ficomp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fidiv()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fidivr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fild(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fimul()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fincstp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void finit()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fist()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fistp(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fisttp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fisub()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fisubr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fld(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fld1()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fldcw(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fldenv()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fldl2e()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fldl2t()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fldlg2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fldln2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fldpi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fldz()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fmul(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fmul(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fmulp(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fnclex()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fninit()
        {
            FPUControlWord = 0x037F;
            FPUStatusWord = 0;
            FPUTagWord = 0xFFFF;
            FPUDataPointer_seg.UInt16 = 0;
            FPUDataPointer_off = 0;
            FPUInstructionPointer_seg.UInt16 = 0;
            FPUInstructionPointer_off = 0;
            FPULastInstructionOpcode = 0;
        }

        /// <inheritdoc />
        public void fnop()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fnsavew_a16(SegmentRegister segment, Value address)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fnsetpm()
        {
            // Obsoleted instruction. Do nothing.
        }

        /// <inheritdoc />
        public void fnstcw(Value value)
        {
            value.UInt16 = FPUControlWord;
        }

        /// <inheritdoc />
        public void fnstenv()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fnstsw(Value value)
        {
            value.UInt16 = FPUStatusWord;
        }

        /// <inheritdoc />
        public void fpatan()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fprem()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fprem1()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fptan()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void frndint()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void frstor()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fsave()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fscale()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fsin()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fsincos()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fsqrt()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fst(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fstcw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fstenv()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fstp(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fstsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fsub(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fsubp(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fsubr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fsubrp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ftst()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fucom()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fucomi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fucomip()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fucomp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fucompp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fwait()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fxam()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fxch(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fxrstor()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fxsave()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fxtract()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fyl2x()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void fyl2xp1()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void haddpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void haddps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void hlt()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void hsubpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void hsubps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void idiv(Value value)
        {
            switch (value.Bits)
            {
                case 16:

                    if (value == 0)
                        throw new NotImplementedException(); // #DE

                    int w = (dx.UInt16 << 16) + ax.UInt16;

                    int t = w / value.Int16;
                    if (short.MaxValue < t || t < short.MinValue)
                        throw new NotImplementedException(); // #DE

                    ax = t;
                    dx = w % value.Int16;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <inheritdoc />
        public void imul(Value value)
        {
            if (value.Bits == 16)
            {
                var r = ax.Int32 * value.Int32;
                ax = r;
                dx = r >> 16;

                eflags.cf = eflags.of = (ax != r);
                return;
            }

            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void imul(Value dst, Value src)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void imul(Value dst, Value src, int c)
        {
            var r = src.Int32 * c;
            dst.Int32 = r;
            eflags.cf = eflags.of = (r != dst.Int32);
        }

        /// <inheritdoc />
        public void inb(Value dst, Value port)
        {
            runInb?.Invoke(this, (dst, port));
        }

        /// <inheritdoc />
        public void inw(Value dst, Value port)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void inc(Value value)
        {
            var r = new NumericValue(value.UInt64 + 1, value.Bits);

            var ds = value.IsPositive;
            var ss = true;
            var rs = r.IsPositive;

            eflags.of = (ds == ss) && (ss != rs);
            set_sf_zf_pf(r);
            // af

            value.UInt64 = r.UInt64;
        }

        /// <inheritdoc />
        public void ins()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void insb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void insd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void insertps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void insw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void @int(int number)
        {
            var ret_addr = cs[eip];
            int_internal(number, true, true, false, 0);
            run_irqs();
            correct_function_position(ret_addr);
        }

        /// <inheritdoc />
        public void int1()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void int3()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void into()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void invd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void invlpg()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void invpcid()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void iretw()
        {
            iret_(16);
        }

        /// <inheritdoc />
        public void iretd()
        {
            iret_(32);
        }

        /// <inheritdoc />
        public void jmpw(Address address, int offset)
        {
            eip = eip + offset;
            eip &= 0xffff;

            if (cs.fail_limit_check(eip))
                throw new NotImplementedException();
            if (cs[eip] != address + CSharpFunctionDelta)
                throw new NotImplementedException();

            run_irqs();
        }

        /// <inheritdoc />
        public void jmpd(Address address, int offset)
        {
            eip = eip + offset;

            if (cs.fail_limit_check(eip))
                throw new NotImplementedException();
            if (cs[eip] != address + CSharpFunctionDelta)
                throw new NotImplementedException();

            run_irqs();
        }

        /// <inheritdoc />
        public void jmpw_func(Address address, int offset)
        {
            jmpw_func_internal(address, offset, true);
        }

        /// <inheritdoc />
        public void jmpw_abs(Value address)
        {
            eip = address & 0xffff;
            run_irqs();
            SaveJumpInfo();
        }

        /// <inheritdoc />
        public int jmpw_abs_switch(Value address)
        {
            eip = address & 0xffff;
            run_irqs();
            SaveJumpInfo();
            return cs[eip] - CSharpFunctionDelta;
        }

        /// <inheritdoc />
        public void jmpw_far_abs(int segment, Address address)
        {
            jmp_far_prepare(segment, address);
            run_irqs();
        }

        /// <inheritdoc />
        public void jmpw_a16_far_ind(SegmentRegister segment, Value address)
        {
            jmp_far_prepare(memw_a16[segment, address + 2].UInt16, memw_a16[segment, address].UInt16);
            run_irqs();
        }

        /// <inheritdoc />
        public void jmpd_abs(Value address)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public int jmpd_abs_switch(Value address)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void jmpd_far_abs(int segment, Value address)
        {
            jmpw_far_abs(segment, address);
        }

        /// <inheritdoc />
        public void jmpd_a16_far_ind(SegmentRegister segment, Value address)
        {
            jmp_far_prepare(memw_a16[segment, address + 4].UInt16, memd_a16[segment, address].UInt32);
            run_irqs();
        }

        /// <inheritdoc />
        public void jmpd_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jaw(Address address, int offset)
        {
            return jmpw_if(!eflags.cf && !eflags.zf, address, offset);
        }

        /// <inheritdoc />
        public bool jad(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jaw_func(Address address, int offset)
        {
            return jmpw_func_if(!eflags.cf && !eflags.zf, address, offset);
        }

        /// <inheritdoc />
        public bool jad_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jaew(Address address, int offset)
        {
            return jmpw_if(!eflags.cf, address, offset);
        }

        /// <inheritdoc />
        public bool jaed(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void jaew_func(Address address, int offset)
        {
            jmpw_func_if(eflags.cf == false, address, offset);
        }

        /// <inheritdoc />
        public void jaed_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jbw(Address address, int offset)
        {
            return jmpw_if(eflags.cf, address, offset);
        }

        /// <inheritdoc />
        public bool jbd(Address address, int offset)
        {
            return jmpd_if(eflags.cf, address, offset);
        }

        /// <inheritdoc />
        public void jbw_func(Address address, int offset)
        {
            jmpw_func_if(eflags.cf, address, offset);
        }

        /// <inheritdoc />
        public void jbd_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jbew(Address address, int offset)
        {
            return jmpw_if(eflags.cf || eflags.zf, address, offset);
        }

        /// <inheritdoc />
        public bool jbed(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void jbew_func(Address address, int offset)
        {
            jmpw_func_if(eflags.cf || eflags.zf, address, offset);
        }

        /// <inheritdoc />
        public void jbed_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jcw(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jcxzw(Address address, int offset)
        {
            return jmpw_if(cx == 0, address, offset);
        }

        /// <inheritdoc />
        public bool jcxzd(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void jcxzw_func(Address address, int offset)
        {
            jmpw_func_if(cx == 0, address, offset);
        }

        /// <inheritdoc />
        public void jcxzd_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jecxzw(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void jecxzd_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jrcxz(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jew(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jgw(Address address, int offset)
        {
            return jmpw_if(!eflags.zf && eflags.sf == eflags.of, address, offset);
        }

        /// <inheritdoc />
        public bool jgd(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jgew(Address address, int offset)
        {
            return jmpw_if(eflags.sf == eflags.of, address, offset);
        }

        /// <inheritdoc />
        public bool jged(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jlw(Address address, int offset)
        {
            return jmpw_if(eflags.sf != eflags.of, address, offset);
        }

        /// <inheritdoc />
        public bool jld(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void jld_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jlew(Address address, int offset)
        {
            return jmpw_if(eflags.zf || eflags.sf != eflags.of, address, offset);
        }

        /// <inheritdoc />
        public bool jled(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void jlew_func(Address address, int offset)
        {
            jmpw_func_if(eflags.zf || eflags.sf != eflags.of, address, offset);
        }

        /// <inheritdoc />
        public bool jnaw(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jnaew(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jnbw(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jnbe(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jnc(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jne(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jng(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jnge(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jnl(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jnle(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jno(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jnp(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jnsw(Address address, int offset)
        {
            return jmpw_if(!eflags.sf, address, offset);
        }

        /// <inheritdoc />
        public bool jnsd(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void jnsw_func(Address address, int offset)
        {
            jmpw_func_if(!eflags.sf, address, offset);
        }

        /// <inheritdoc />
        public void jnsd_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jnzw(Address address, int offset)
        {
            return jmpw_if(!eflags.zf, address, offset);
        }

        /// <inheritdoc />
        public bool jnzd(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void jnzw_func(Address address, int offset)
        {
            jmpw_func_if(!eflags.zf, address, offset);
        }

        /// <inheritdoc />
        public void jnzd_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jow(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jp(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jpd(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jpe(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jpo(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool jsw(Address address, int offset)
        {
            return jmpw_if(eflags.sf, address, offset);
        }

        /// <inheritdoc />
        public bool jsd(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void jsw_func(Address address, int offset)
        {
            jmpw_func_if(eflags.sf, address, offset);
        }

        /// <inheritdoc />
        public bool jzw(Address address, int offset)
        {
            return jmpw_if(eflags.zf, address, offset);
        }

        /// <inheritdoc />
        public bool jzd(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void jzw_func(Address address, int offset)
        {
            jmpw_func_if(eflags.zf, address, offset);
        }

        /// <inheritdoc />
        public void jzd_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kaddb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kaddd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kaddq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kaddw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kandb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kandd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kandnb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kandnd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kandnq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kandnw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kandq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kandw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kmovb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kmovd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kmovq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kmovw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void knotb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void knotd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void knotq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void knotw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void korb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kord()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void korq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kortestb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kortestd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kortestq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kortestw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void korw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kshiftlb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kshiftld()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kshiftlq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kshiftlw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kshiftrb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kshiftrd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kshiftrq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kshiftrw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ktestb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ktestd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ktestq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ktestw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kunpckbw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kunpckdq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kunpckwd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kxnorb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kxnord()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kxnorq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kxnorw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kxorb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kxord()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kxorq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void kxorw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lahf()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lar(Value dst, Value src)
        {
            var seg = new SegmentRegisterImpl(this);
            seg.Selector = src.UInt16;

            eflags.zf = true; // zf <-> valid

            if (seg.IsNull)
                eflags.zf = false;

            if (eflags.zf)
            {
                var type = seg.Descriptor.SAndType;
                if (type == 0 || (6 <= type && type <= 8) || (type == 0xa) || (0xd <= type && type <= 0xf))
                    eflags.zf = false;
            }

            if (eflags.zf)
            {
                if (seg.Descriptor.IsTypeNonConformingCode
                    && ((seg.Descriptor.DPL < CPL)
                        || (seg.Descriptor.DPL < seg.RPL)))
                    eflags.zf = false;
            }

            if (eflags.zf)
            {
                var d = BinaryHelper.FromBytes(
                    seg.Descriptor.Bytes[7],
                    seg.Descriptor.Bytes[6],
                    seg.Descriptor.Bytes[5],
                    seg.Descriptor.Bytes[4]);

                // 16 - & 0x__ff00
                // 32 - & 0xffff00

                var mask = 0xffffu;
                mask <<= 8;

                dst.UInt32 = d & mask;
            }
        }

        /// <inheritdoc />
        public void lddqu()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ldmxcsr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lds(Value dst, SegmentRegister segment, Value offset)
        {
            var cache = offset.UInt32;
            dst.UInt32 = memd_a32[segment, cache].UInt32;
            ds.Selector = (memw_a32[segment, cache + dst.Bits / 8].UInt16);
        }

        /// <inheritdoc />
        public void lea(Value dst, Value src)
        {
            // MemoryValue src
            // dst.UInt64 = src.Address;

            dst.UInt64 = src.UInt64;
        }

        /// <inheritdoc />
        public void leavew()
        {
            if (ss.db)
                esp = ebp;
            else
                sp = bp;
            popw(bp);
        }

        /// <inheritdoc />
        public void leaved()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void les(Value dst, SegmentRegister segment, Value offset)
        {
            var cache = offset.UInt32;
            dst.UInt32 = memd_a32[segment, cache].UInt32;
            es.Selector = (memw_a32[segment, cache + dst.Bits / 8].UInt16);
        }

        /// <inheritdoc />
        public void lfence()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lfs(Value dst, SegmentRegister segment, Value offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lgdtw_a16(SegmentRegister segment, Value address)
        {
            if (CPL != 0)
                throw new NotImplementedException(); // #GP(0)

            gdtr_limit = memw_a16[segment, address].UInt16;
            gdtr_base = memd_a16[segment, address + 2].UInt32 & 0x00ffffff;
        }

        /// <inheritdoc />
        public void lgdtd_a16(SegmentRegister segment, Value address)
        {
            if (CPL != 0)
                throw new NotImplementedException(); // #GP(0)

            gdtr_limit = memw_a16[segment, address].UInt16;
            gdtr_base = memd_a16[segment, address + 2].UInt32;
        }

        /// <inheritdoc />
        public void lgs(Value dst, SegmentRegister segment, Value offset)
        {
            throw new NotImplementedException();
        }
        
        /// <inheritdoc />
        public void lidtw_a16(SegmentRegister segment, Value address)
        {
            if (CPL != 0)
                throw new NotImplementedException(); // #GP(0)

            idtr_limit = memw_a16[segment, address].UInt16;
            idtr_base = memd_a16[segment, address + 2].UInt32 & 0x00ffffff;
        }

        /// <inheritdoc />
        public void lldt(Value value)
        {
            if (CPL != 0)
                throw new NotImplementedException(); // #GP(0)

            if ((value & 0x4) != 0) // if point to local table
                throw new NotImplementedException(); // #GP(segment selector)

            ldtr.Selector = value.UInt16;

            if (ldtr.IsNull == false)
            {
                if (ldtr.Descriptor.is_type_ldt == false)
                    throw new NotImplementedException(); // #GP(segment selector)

                if (ldtr.Descriptor.Present == false)
                    throw new NotImplementedException(); // #NP(segment selector)
            }
        }

        /// <inheritdoc />
        public void lmsw(Value value)
        {
            var t = cr0.UInt32;
            t = (t & 0xffff0000) | value.UInt32;
            cr0.UInt32 = t;
        }

        /// <inheritdoc />
        public void @lock()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lods()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lodsb_a16()
        {
            al = memb_a16[ds, si];
            si += eflags.df ? -1 : 1;
        }

        /// <inheritdoc />
        public void lodsb_a32()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lodsd_a16()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lodsd_a32()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lodsq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lodsw_a16()
        {
            ax = memw_a16[ds, si];
            si += eflags.df ? -2 : 2;
        }

        /// <inheritdoc />
        public bool loopw_a16(Address address, int offset)
        {
            if (--cx != 0)
            {
                jmpw(address, offset);
                return true;
            }

            return false;
        }

        /// <inheritdoc />
        public bool loopd_a32(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool loopew_a16(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool loopnew_a16(Address address, int offset)
        {
            if (--cx != 0 && !eflags.zf)
            {
                jmpw(address, offset);
                return true;
            }

            return false;
        }

        /// <inheritdoc />
        public bool loopw_a16_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool loopd_a32_func(Address address, int offset)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void lsl(Value dst, Value selector)
        {
            SegmentRegister seg = new SegmentRegisterImpl(this);
            seg.UInt32 = selector.UInt32;

            eflags.zf = true; // zf <-> valid

            if (seg.IsNull)
                eflags.zf = false;

            if (eflags.zf)
            {
                var type = seg.Descriptor.SAndType;
                if (type == 0 || (4 <= type && type <= 8) || (type == 0xa) || (0xc <= type && type <= 0xf))
                    eflags.zf = false;
            }

            if (eflags.zf)
            {
                if (seg.Descriptor.IsTypeNonConformingCode
                    && ((seg.Descriptor.DPL < CPL)
                        || (seg.Descriptor.DPL < seg.RPL)))
                    eflags.zf = false;
            }

            if (eflags.zf)
                dst.UInt32 = seg.Descriptor.Limit;
        }

        /// <inheritdoc />
        public void lss(Value dst, SegmentRegister segment, Value offset)
        {
            var cache = offset.UInt32;
            dst.UInt32 = memd_a32[segment, cache].UInt32;
            ss.Selector = (memw_a32[segment, cache + dst.Bits / 8].UInt16);
        }

        /// <inheritdoc />
        public void ltr(Value val)
        {
            if ((val & 0x4) != 0)
                throw new NotImplementedException(); // #GP(segment selector)

            tr.Selector = val.UInt16;

            if (tr.IsNull)
                throw new NotImplementedException(); // #GP(0)

            if (tr.Descriptor.is_type_tss == false || tr.Descriptor.IsTssBusy)
                throw new NotImplementedException(); // #GP(segment selector)
            if (tr.Descriptor.Present == false)
                throw new NotImplementedException(); // #NP(segment selector)

            tr.Descriptor.IsTssBusy = true;
        }

        /// <inheritdoc />
        public void lzcnt()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void maskmovdqu()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void maskmovq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void maxpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void maxps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void maxsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void maxss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void mfence()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void minpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void minps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void minsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void minss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void monitor()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void mov(Value dst, Value src)
        {
            dst.UInt64 = src.UInt64;
        }

        /// <inheritdoc />
        public void mov_cr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void mov_dr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movapd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movaps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movbe()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movddup()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movdq2q()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movdqa()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movdqu()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movhlps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movhpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movhps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movlhps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movlpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movlps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movmskpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movmskps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movntdq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movntdqa()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movnti()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movntpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movntps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movntq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movq_1()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movq_2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movq2dq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movsb_a16(SegmentRegister segment = null)
        {
            memb_a16[es, di] = memb_a16[segment ?? ds, si];
            di += eflags.df ? -1 : 1;
            si += eflags.df ? -1 : 1;
        }

        /// <inheritdoc />
        public void movsb_a32(SegmentRegister segment = null)
        {
            memb_a32[es, edi] = memb_a32[segment ?? ds, esi];
            edi += eflags.df ? -1 : 1;
            esi += eflags.df ? -1 : 1;
        }

        /// <inheritdoc />
        public void movsw_a16(SegmentRegister segment = null)
        {
            memw_a16[es, di] = memw_a16[segment ?? ds, si];
            di += eflags.df ? -2 : 2;
            si += eflags.df ? -2 : 2;
        }

        /// <inheritdoc />
        public void movsw_a32(SegmentRegister segment = null)
        {
            memw_a32[es, edi] = memw_a32[segment ?? ds, esi];
            edi += eflags.df ? -2 : 2;
            esi += eflags.df ? -2 : 2;
        }

        /// <inheritdoc />
        public void movsd_a16()
        {
            memd_a16[es, di] = memd_a16[ds, si];
            di += eflags.df ? -4 : 4;
            si += eflags.df ? -4 : 4;
        }

        /// <inheritdoc />
        public void movsd_a32(SegmentRegister segment = null)
        {
            memd_a32[es, edi] = memd_a32[segment ?? ds, esi];
            edi += eflags.df ? -4 : 4;
            esi += eflags.df ? -4 : 4;
        }

        /// <inheritdoc />
        public void movsd_fp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movshdup()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movsldup()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movsq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movsx(Value dst, Value src)
        {
            dst.Int64 = src.Int64;
        }

        /// <inheritdoc />
        public void movsxd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movupd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movups()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void movzx(Value dst, Value src)
        {
            dst.UInt64 = src.UInt64;
        }

        /// <inheritdoc />
        public void mpsadbw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void mul(Value value)
        {
            if (value.Bits == 16)
            {
                var r = ax.UInt32 * value.UInt32;
                ax.UInt32 = r;
                dx.UInt32 = (r >> 16);

                eflags.cf = eflags.of = (dx != 0);
                return;
            }

            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void mulpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void mulps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void mulsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void mulss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void mulx()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void mwait()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void neg(Value value)
        {
            eflags.cf = value.UInt64 != 0;
            value.UInt64 = 0 - value.UInt64;
            set_sf_zf_pf(value);
            // af
            // of = ???
        }

        /// <inheritdoc />
        public void nop()
        { }

        /// <inheritdoc />
        public void not(Value value)
        {
            value.UInt64 = ~value.UInt64;
        }

        /// <inheritdoc />
        public void or(Value dst, Value src)
        {
            dst.UInt64 |= src.UInt64;

            eflags.cf = false;
            eflags.of = false;
            set_sf_zf_pf(dst);
        }

        /// <inheritdoc />
        public void orpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void orps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void outb(Value port, Value value)
        {
            runOutb?.Invoke(this, (port, value));
        }

        /// <inheritdoc />
        public void outw(Value port, Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void outs()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void outsb_a16(SegmentRegister segment = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void outsb_a32(SegmentRegister segment = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void outsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void outsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pabsb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pabsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pabsq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pabsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void packssdw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void packsswb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void packusdw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void packuswb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void paddb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void paddd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void paddq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void paddsb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void paddsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void paddusb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void paddusw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void paddw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void palignr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pand()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pandn()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pause()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pavgb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pavgw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pblendvb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pblendw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pclmulqdq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpeqb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpeqd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpeqq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpeqw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpestri()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpestrm()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpgtb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpgtd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpgtq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpgtw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpistri()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pcmpistrm()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pdep()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pext()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pextrb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pextrd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pextrq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pextrw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void phaddd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void phaddsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void phaddw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void phminposuw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void phsubd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void phsubsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void phsubw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pinsrb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pinsrd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pinsrq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pinsrw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmaddubsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmaddwd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmaxsb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmaxsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmaxsq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmaxsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmaxub()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmaxud()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmaxuq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmaxuw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pminsb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pminsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pminsq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pminsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pminub()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pminud()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pminuq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pminuw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmovmskb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmovsx()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmovzx()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmuldq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmulhrsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmulhuw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmulhw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmulld()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmullq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmullw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pmuludq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public ushort popw(Value d = null)
        {
            ushort value;
            if (ss.db)
            {
                esp += 2;
                value = memw_a32[ss, esp - 2].UInt16;
            }
            else
            {
                sp += 2;
                value = memw_a16[ss, sp - 2].UInt16;
            }

            if (d != null)
                d.UInt64 = value;

            return value;
        }

        /// <inheritdoc />
        public uint popd(Value d = null)
        {
            uint value;
            if (ss.db)
            {
                esp += 4;
                value = memd_a32[ss, esp - 4].UInt32;
            }
            else
            {
                sp += 4;
                value = memd_a16[ss, sp - 4].UInt32;
            }

            if (d != null)
                d.UInt64 = value;

            return value;
        }

        /// <inheritdoc />
        public void popa()
        {
            popw(di);
            popw(si);
            popw(bp);

            if (ss.db)
                esp += 2;
            else
                sp += 2;

            popw(bx);
            popw(dx);
            popw(cx);
            popw(ax);
        }

        /// <inheritdoc />
        public void popad()
        {
            popd(edi);
            popd(esi);
            popd(ebp);

            if (ss.db)
                esp += 4;
            else
                sp += 4;

            popd(ebx);
            popd(edx);
            popd(ecx);
            popd(eax);
        }

        /// <inheritdoc />
        public void popcnt()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void popfw()
        {
            popf_(16);
        }

        /// <inheritdoc />
        public void popfd()
        {
            popf_(32);
        }

        /// <inheritdoc />
        public void popfq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void por()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void prefetchw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void prefetchh()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psadbw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pshufb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pshufd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pshufhw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pshuflw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pshufw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psignb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psignd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psignw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pslld()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pslldq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psllq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psllw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psrad()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psraq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psraw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psrld()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psrldq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psrlq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psrlw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psubb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psubd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psubq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psubsb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psubsw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psubusb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psubusw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void psubw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ptest()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ptwrite()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void punpckhbw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void punpckhdq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void punpckhqdq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void punpckhwd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void punpcklbw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void punpckldq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void punpcklqdq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void punpcklwd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pushw(Value s)
        {
            // todo Join popw, popd in one method push ?
            // todo Join pushw, pushd in one method push ?

            var value = s.UInt32;

            if (ss.db)
            {
                esp -= 2;
                if (ss.fail_limit_check(esp, 2))
                    throw new NotImplementedException(); // #SS(0)
                memw_a32[ss, esp] = value;
            }
            else
            {
                sp -= 2;
                if (ss.fail_limit_check(sp, 2))
                    throw new NotImplementedException(); // #SS(0)
                memw_a16[ss, sp] = value;
            }
        }

        /// <inheritdoc />
        public void pushd(Value s)
        {
            var value = s.UInt32;

            if (ss.db)
            {
                esp -= 4;
                if (ss.fail_limit_check(esp, 4))
                    throw new NotImplementedException(); // #SS(0)
                memd_a32[ss, esp] = value;
            }
            else
            {
                sp -= 4;
                if (ss.fail_limit_check(sp, 4))
                    throw new NotImplementedException(); // #SS(0)
                memd_a16[ss, sp] = value;
            }
        }

        /// <inheritdoc />
        public void pusha()
        {
            var t = sp.UInt16;
            pushw(ax);
            pushw(cx);
            pushw(dx);
            pushw(bx);
            pushw(t);
            pushw(bp);
            pushw(si);
            pushw(di);
        }

        /// <inheritdoc />
        public void pushad()
        {
            var t = esp.UInt32;
            pushd(eax);
            pushd(ecx);
            pushd(edx);
            pushd(ebx);
            pushd(t);
            pushd(ebp);
            pushd(esi);
            pushd(edi);
        }

        /// <inheritdoc />
        public void pushfw()
        {
            pushw((ushort)eflags.UInt64);
        }

        /// <inheritdoc />
        public void pushfd()
        {
            pushd((uint)eflags.UInt64);
        }

        /// <inheritdoc />
        public void pushfq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void pxor()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rcl(Value dst, int count)
        {
            int tempCount;

            switch (dst.Bits)
            {
                case 8:
                    tempCount = (count & 0x1f) % 9;
                    break;
                case 16:
                    tempCount = (count & 0x1f) % 17;
                    break;
                case 32:
                    tempCount = count & 0x1f;
                    break;
                case 64:
                    tempCount = count & 0x3f;
                    break;
                default: throw new NotImplementedException();
            }

            var d = dst.UInt64;
            var mask = BinaryHelper.HighBitsMask(dst.Bits); // 0x8000

            if (tempCount != 0)
            {
                var new_cf = 0 != ((d << (tempCount - 1)) & mask);

                d = (d << tempCount) | (d >> (dst.Bits - tempCount + 1));

                if (eflags.cf)
                    d |= 1ul << (tempCount - 1);

                eflags.cf = new_cf;
            }

            if (count == 1)
                eflags.of = (0 < (d & mask)) ^ eflags.cf;

            dst.UInt64 = d;
        }

        /// <inheritdoc />
        public void rcpps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rcpss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rcr(Value dst, int count)
        {
            int tempCount;

            switch (dst.Bits)
            {
                case 8:
                    tempCount = (count & 0x1F) % 9;
                    break;
                case 16:
                    tempCount = (count & 0x1F) % 17;
                    break;
                case 32:
                    tempCount = count & 0x1F;
                    break;
                case 64:
                    tempCount = count & 0x3F;
                    break;
                default: throw new NotImplementedException();
            }

            var d = dst.UInt64;
            var mask = BinaryHelper.HighBitsMask(dst.Bits); // 0x8000

            if (tempCount != 0)
            {
                var new_cf = 0 != ((d >> (tempCount - 1)) & 1);

                d = (d >> tempCount) | (d << (dst.Bits - tempCount + 1));

                if (eflags.cf)
                    d |= 1ul << (dst.Bits - tempCount);

                eflags.cf = new_cf;
            }

            if (count == 1)
                eflags.of = (0 < (d & mask)) ^ eflags.cf;

            dst.UInt64 = d;
        }

        /// <inheritdoc />
        public void rdfsbase()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rdgsbase()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rdmsr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rdpid()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rdpkru()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rdpmc()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rdrand()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rdseed()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rdtsc()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rdtscp()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rep_a16(Action action)
        {
            for (; cx != 0; cx--)
                action();
        }

        /// <inheritdoc />
        public void rep_a32(Action action)
        {
            for (; ecx != 0; ecx--)
                action();
        }

        /// <inheritdoc />
        public void repe_a32(Action action)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void repne_a32(Action action)
        {
            for (eflags.zf = false; ecx != 0 && !eflags.zf; ecx--)
                action();
        }

        /// <inheritdoc />
        public void repe_a16(Action action)
        {
            for (eflags.zf = true; cx != 0 && eflags.zf; cx--)
                action();
        }

        /// <inheritdoc />
        public void repne_a16(Action action)
        {
            for (eflags.zf = false; cx != 0 && !eflags.zf; cx--)
                action();
        }

        /// <inheritdoc />
        public void retw(int allocSize = 0)
        {
            eip = popw();
            if (cs.fail_limit_check(eip))
                throw new NotImplementedException();
            __plus_sp(allocSize);
        }

        /// <inheritdoc />
        public void retd(int size = 0)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void retfw(int size = 0)
        {
            ret_far(16);
            __plus_sp(size);
        }

        /// <inheritdoc />
        public void retfd(int size = 0)
        {
            ret_far(32);
            __plus_sp(size);
        }

        /// <inheritdoc />
        public void rol(Value dst, Value c)
        {
            var count = (int)c.UInt32;

            var countMask = dst.Bits == 64 ? 0x3F : 0x1F;
            var tempCount = (count & countMask) % dst.Bits;

            var d = dst.UInt64;
            var mask = BinaryHelper.HighBitsMask(dst.Bits); // 0x8000

            if (tempCount != 0)
            {
                var new_cf = 0 != ((d << (tempCount - 1)) & mask);
                d = (d << tempCount) | (d >> (dst.Bits - tempCount));
                eflags.cf = new_cf;
            }

            if ((count & countMask) == 1)
                eflags.of = (0 < (d & mask)) ^ eflags.cf;

            dst.UInt64 = d;
        }

        /// <inheritdoc />
        public void ror(Value dst, Value c)
        {
            var count = (int)c.UInt32;

            var countMask = dst.Bits == 64 ? 0x3F : 0x1F;
            var tempCount = (count & countMask) % dst.Bits;

            var d = dst.UInt64;
            var mask = BinaryHelper.HighBitsMask(dst.Bits); // 0x8000

            if (tempCount != 0)
            {
                var new_cf = 0 != ((d >> (tempCount - 1)) & 1);
                d = (d >> tempCount) | (d << (dst.Bits - tempCount));
                eflags.cf = new_cf;
            }

            if ((count & countMask) == 1)
                eflags.of = (0 < (d & mask)) ^ eflags.cf;

            dst.UInt64 = d;
        }

        /// <inheritdoc />
        public void rorx()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void roundpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void roundps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void roundsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void roundss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rsm()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rsqrtps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void rsqrtss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sahf()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sal()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sar(Value dst, Value count)
        {
            var c = (int) count.UInt32;

            if (count == 1)
                eflags.of = false;

            if (count != 0)
            {
                eflags.cf = dst.IsBitSet(c - 1);
                dst.Int64 = dst.Int64 >> c;
                set_sf_zf_pf(dst);
            }
        }

        /// <inheritdoc />
        public void sarx()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sbb(Value dst, Value src)
        {
            src = new NumericValue(src.UInt64, dst.Bits);

            var r = new NumericValue(dst.UInt64 - src.UInt64 - (eflags.cf ? 1u : 0), dst.Bits);
            var ds = dst.IsPositive;
            var ss = src.IsPositive;
            var rs = r.IsPositive;

            if (src.UInt64 == ulong.MaxValue && eflags.cf)
                eflags.cf = true;
            else
                eflags.cf = dst.UInt64 < (src.UInt64 + (eflags.cf ? 1u : 0));

            eflags.of = (ds != ss) && (ss == rs);
            set_sf_zf_pf(r);

            dst.UInt64 = r.UInt64;
        }

        /// <inheritdoc />
        public void scas()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void scasb_a16()
        {
            cmp(al, memb_a16[es, di]);
            di += eflags.df ? -1 : 1;
        }

        /// <inheritdoc />
        public void scasb_a32()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void scasd_a16()
        {
            cmp(eax, memd_a16[es, di]);
            di += eflags.df ? -4 : 4;
        }

        /// <inheritdoc />
        public void scasd_a32()
        {
            cmp(eax, memd_a32[es, edi]);
            edi += eflags.df ? -4 : 4;
        }

        /// <inheritdoc />
        public void scasw_a16()
        {
            cmp(ax, memw_a16[es, di]);
            di += eflags.df ? -2 : 2;
        }

        /// <inheritdoc />
        public void seta(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void setbe(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void setg(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void setge(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void setae(Value value)
        {
            value.Int32 = eflags.cf ? 0 : 1;
        }

        /// <inheritdoc />
        public void setle(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void setz(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void setnz(Value value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sfence()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sgdt()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sha1msg1()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sha1msg2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sha1nexte()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sha1rnds4()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sha256msg1()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sha256msg2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sha256rnds2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void shl(Value dst, Value count_)
        {
            var count = count_.Int32;
            var mask = BinaryHelper.HighBitsMask(dst.Bits); // 0x8000

            if (count != 0)
            {
                eflags.cf = dst.IsBitSet(dst.Bits - count);
                dst.UInt64 = dst.UInt64 << count;
                set_sf_zf_pf(dst);
            }

            if (count == 1)
                eflags.of = (0 < (dst.UInt64 & mask)) ^ eflags.cf;
        }

        /// <inheritdoc />
        public void shld(Value dst, Value src, int count)
        {
            if (dst.Bits == 64)
                count = count % 64;
            else
                count = count % 32;

            if (count != 0 && count <= dst.Bits)
            {
                eflags.cf = dst.IsBitSet(dst.Bits - count);
                var total = ((BigInteger)dst.UInt64 << src.Bits) + src.UInt64;
                dst.UInt64 = (ulong)(total >> (src.Bits - count));
            }
        }

        /// <inheritdoc />
        public void shlx()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void shr(Value dst, Value count)
        {
            var mask = BinaryHelper.HighBitsMask(dst.Bits); // 0x8000

            if (count == 1)
                eflags.of = 0 < (dst.UInt64 & mask);

            if (count != 0)
            {
                eflags.cf = dst.IsBitSet(count.Int32 - 1);
                dst.UInt64 = dst.UInt64 >> count.Int32;
                set_sf_zf_pf(dst);
            }
        }

        /// <inheritdoc />
        public void shrd(Value dst, Value src, int count)
        {
            if (dst.Bits == 64)
                count = count % 64;
            else
                count = count % 32;

            if (count != 0 && count <= dst.Bits)
            {
                eflags.cf = dst.IsBitSet(count - 1);
                var total = ((BigInteger)src.UInt64 << dst.Bits) + dst.UInt64;
                dst.UInt64 = (ulong)(total >> count);
            }
        }

        /// <inheritdoc />
        public void shrx()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void shufpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void shufps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sidt()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sldt()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void smsw(Value value)
        {
            value.UInt32 = cr0.UInt32;
        }

        /// <inheritdoc />
        public void sqrtpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sqrtps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sqrtsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sqrtss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void stac()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void stc()
        {
            eflags.cf = true;
        }

        /// <inheritdoc />
        public void std()
        {
            eflags.df = true;
        }

        /// <inheritdoc />
        public void sti()
        {
            if (cr0.pe == false)
                eflags.@if = true;
            else
            {
                if (eflags.vm == false)
                {
                    if (CPL <= eflags.iopl)
                        eflags.@if = true;
                    else
                    {
                        if (eflags.iopl < CPL && CPL == 3 && eflags.vip == false)
                            eflags.vif = true;
                        else
                            throw new NotImplementedException(); // #GP(0);
                    }
                }
                else
                {
                    if (eflags.iopl == 3)
                        eflags.@if = true;
                    else
                    {
                        if (eflags.iopl < 3 && eflags.vip == false && cr4.vme)
                            eflags.vif = true;
                        else
                            throw new NotImplementedException(); // #GP(0);
                    }
                }
            }

            run_irqs();
        }

        /// <inheritdoc />
        public void stmxcsr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void stos()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void stosb_a16()
        {
            memb_a16[es, di] = al;
            di += eflags.df ? -1 : 1;
        }

        /// <inheritdoc />
        public void stosb_a32()
        {
            memb_a32[es, edi] = al;
            edi += eflags.df ? -1 : 1;
        }

        /// <inheritdoc />
        public void stosd_a16()
        {
            memd_a16[es, di] = eax;
            di += eflags.df ? -4 : 4;
        }

        /// <inheritdoc />
        public void stosd_a32()
        {
            memd_a32[es, edi] = eax;
            edi += eflags.df ? -4 : 4;
        }

        /// <inheritdoc />
        public void stosq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void stosw_a16()
        {
            memw_a16[es, di] = ax;
            di += eflags.df ? -2 : 2;
        }

        /// <inheritdoc />
        public void stosw_a32()
        {
            memw_a32[es, edi] = ax;
            edi += eflags.df ? -2 : 2;
        }

        /// <inheritdoc />
        public void str(Value value)
        {
            value.UInt16 = tr.UInt16;
        }

        /// <inheritdoc />
        public void sub(Value dst, Value src)
        {
            src = new NumericValue(src.UInt64, dst.Bits);
            cmp(dst, src);
            dst.UInt64 = dst.UInt64 - src.UInt64;
        }

        /// <inheritdoc />
        public void subpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void subps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void subsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void subss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void swapgs()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void syscall()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sysenter()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sysexit()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void sysret()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void test(Value a, Value b)
        {
            set_sf_zf_pf(a & b);
            eflags.cf = false;
            eflags.of = false;
        }

        /// <inheritdoc />
        public void tzcnt()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ucomisd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ucomiss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ud()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void unpckhpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void unpckhps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void unpcklpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void unpcklps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void valignd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void valignq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vblendmpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vblendmps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vbroadcast()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcompresspd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcompressps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtpd2qq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtpd2udq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtpd2uqq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtph2ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtps2ph()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtps2qq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtps2udq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtps2uqq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtqq2pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtqq2ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtsd2usi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtss2usi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvttpd2qq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvttpd2udq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvttpd2uqq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvttps2qq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvttps2udq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvttps2uqq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvttsd2usi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvttss2usi()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtudq2pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtudq2ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtuqq2pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtuqq2ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtusi2sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vcvtusi2ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vdbpsadbw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void verr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void verw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vexpandpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vexpandps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vextractf128()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vextractf32x4()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vextractf32x8()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vextractf64x2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vextractf64x4()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vextracti128()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vextracti32x4()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vextracti32x8()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vextracti64x2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vextracti64x4()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfixupimmpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfixupimmps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfixupimmsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfixupimmss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd132pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd132ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd132sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd132ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd213pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd213ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd213sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd213ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd231pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd231ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd231sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmadd231ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmaddsub132pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmaddsub132ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmaddsub213pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmaddsub213ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmaddsub231pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmaddsub231ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub132pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub132ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub132sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub132ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub213pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub213ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub213sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub213ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub231pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub231ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub231sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsub231ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsubadd132pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsubadd132ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsubadd213pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsubadd213ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsubadd231pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfmsubadd231ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd132pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd132ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd132sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd132ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd213pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd213ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd213sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd213ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd231pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd231ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd231sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmadd231ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub132pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub132ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub132sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub132ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub213pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub213ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub213sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub213ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub231pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub231ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub231sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfnmsub231ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfpclasspd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfpclassps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfpclasssd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vfpclassss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgatherdpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgatherdpd_s()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgatherdps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgatherdps_s()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgatherqpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgatherqpd_s()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgatherqps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgatherqps_s()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgetexppd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgetexpps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgetexpsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgetexpss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgetmantpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgetmantps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgetmantsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vgetmantss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vinsertf128()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vinsertf32x4()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vinsertf32x8()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vinsertf64x2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vinsertf64x4()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vinserti128()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vinserti32x4()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vinserti32x8()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vinserti64x2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vinserti64x4()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vmaskmov()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vmovdqa32()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vmovdqa64()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vmovdqu16()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vmovdqu32()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vmovdqu64()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vmovdqu8()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpblendd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpblendmb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpblendmd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpblendmq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpblendmw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpbroadcast()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpbroadcastb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpbroadcastd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpbroadcastm()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpbroadcastq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpbroadcastw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpcmpb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpcmpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpcmpq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpcmpub()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpcmpud()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpcmpuq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpcmpuw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpcmpw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpcompressd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpcompressq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpconflictd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpconflictq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vperm2f128()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vperm2i128()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermi2b()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermi2d()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermi2pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermi2ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermi2q()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermi2w()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermilpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermilps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermt2b()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermt2d()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermt2pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermt2ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermt2q()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermt2w()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpermw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpexpandd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpexpandq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpgatherdd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpgatherdd_s()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpgatherdq_s()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpgatherdq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpgatherqd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpgatherqd_s()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpgatherqq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpgatherqq_s()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vplzcntd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vplzcntq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmadd52huq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmadd52luq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmaskmov()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovb2m()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovd2m()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovdb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovdw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovm2b()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovm2d()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovm2q()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovm2w()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovq2m()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovqb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovqd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovqw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovsdb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovsdw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovsqb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovsqd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovsqw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovswb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovusdb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovusdw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovusqb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovusqd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovusqw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovuswb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovw2m()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmovwb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpmultishiftqb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vprold()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vprolq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vprolvd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vprolvq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vprord()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vprorq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vprorvd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vprorvq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpscatterdd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpscatterdq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpscatterqd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpscatterqq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpsllvd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpsllvq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpsllvw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpsravd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpsravq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpsravw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpsrlvd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpsrlvq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpsrlvw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpternlogd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vpternlogq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vptestmb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vptestmd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vptestmq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vptestmw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vptestnmb()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vptestnmd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vptestnmq()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vptestnmw()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrangepd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrangeps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrangesd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrangess()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrcp14pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrcp14ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrcp14sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrcp14ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vreducepd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vreduceps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vreducesd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vreducess()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrndscalepd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrndscaleps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrndscalesd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrndscaless()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrsqrt14pd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrsqrt14ps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrsqrt14sd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vrsqrt14ss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vscalefpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vscalefps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vscalefsd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vscalefss()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vscatterdpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vscatterdps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vscatterqpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vscatterqps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vshuff32x4()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vshuff64x2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vshufi32x4()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vshufi64x2()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vtestpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vtestps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vzeroall()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void vzeroupper()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void wait()
        {
            // Не нужна.
        }

        /// <inheritdoc />
        public void wbinvd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void wrfsbase()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void wrgsbase()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void wrmsr()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void wrpkru()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xabort()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xacquire()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xadd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xbegin()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xchg(Value a, Value b)
        {
            var x = a.UInt64;
            a.UInt64 = b.UInt64;
            b.UInt64 = x;
        }

        /// <inheritdoc />
        public void xend()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xgetbv()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xlat()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xlatb_a16()
        {
            al = memb_a16[ds, bx + al];
        }

        /// <inheritdoc />
        public void xor(Value dst, Value src)
        {
            dst.UInt64 ^= src.UInt64;

            eflags.cf = false;
            eflags.of = false;
            set_sf_zf_pf(dst);
        }

        /// <inheritdoc />
        public void xorpd()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xorps()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xrelease()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xrstor()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xrstors()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xsave()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xsavec()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xsaveopt()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xsaves()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xsetbv()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void xtest()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDisposable

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _stateLog?.Dispose();
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    public enum task_switch_reason
    {
        jmp,
        call,
        iret,
        exception,
        interrupt
    };
}

#pragma warning restore IDE1006 // Naming Styles