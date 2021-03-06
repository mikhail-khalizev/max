// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
#pragma warning disable IDE1006 // Naming Styles

using System;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions
{
    public class BridgeCpu : ICpu
    {
        public ICpu Implementation { get; set; }

        public BridgeCpu(ICpu implementation)
        {
            Implementation = implementation;
        }

        #region Registers

        public Register eax
        {
            get => Implementation.eax;
            set => Implementation.eax = value;
        }

        public Register ebx
        {
            get => Implementation.ebx;
            set => Implementation.ebx = value;
        }
        public Register ecx
        {
            get => Implementation.ecx;
            set => Implementation.ecx = value;
        }
        public Register edx
        {
            get => Implementation.edx;
            set => Implementation.edx = value;
        }

        public Register esi
        {
            get => Implementation.esi;
            set => Implementation.esi = value;
        }
        public Register edi
        {
            get => Implementation.edi;
            set => Implementation.edi = value;
        }

        public Register ebp
        {
            get => Implementation.ebp;
            set => Implementation.ebp = value;
        }
        public Register esp
        {
            get => Implementation.esp;
            set => Implementation.esp = value;
        }

        public Register ax
        {
            get => Implementation.ax;
            set => Implementation.ax = value;
        }
        public Register bx
        {
            get => Implementation.bx;
            set => Implementation.bx = value;
        }
        public Register cx
        {
            get => Implementation.cx;
            set => Implementation.cx = value;
        }
        public Register dx
        {
            get => Implementation.dx;
            set => Implementation.dx = value;
        }

        public Register si
        {
            get => Implementation.si;
            set => Implementation.si = value;
        }
        public Register di
        {
            get => Implementation.di;
            set => Implementation.di = value;
        }

        public Register bp
        {
            get => Implementation.bp;
            set => Implementation.bp = value;
        }
        public Register sp
        {
            get => Implementation.sp;
            set => Implementation.sp = value;
        }

        public Register al
        {
            get => Implementation.al;
            set => Implementation.al = value;
        }
        public Register bl
        {
            get => Implementation.bl;
            set => Implementation.bl = value;
        }
        public Register cl
        {
            get => Implementation.cl;
            set => Implementation.cl = value;
        }
        public Register dl
        {
            get => Implementation.dl;
            set => Implementation.dl = value;
        }

        public Register ah
        {
            get => Implementation.ah;
            set => Implementation.ah = value;
        }

        public Register bh
        {
            get => Implementation.bh;
            set => Implementation.bh = value;
        }

        public Register ch
        {
            get => Implementation.ch;
            set => Implementation.ch = value;
        }

        public Register dh
        {
            get => Implementation.dh;
            set => Implementation.dh = value;
        }

        public SegmentRegister ds
        {
            get => Implementation.ds;
            set => Implementation.ds = value;
        }

        public SegmentRegister es
        {
            get => Implementation.es;
            set => Implementation.es = value;
        }

        public SegmentRegister cs
        {
            get => Implementation.cs;
            set => Implementation.cs = value;
        }

        public SegmentRegister ss
        {
            get => Implementation.ss;
            set => Implementation.ss = value;
        }

        public SegmentRegister fs
        {
            get => Implementation.fs;
            set => Implementation.fs = value;
        }

        public SegmentRegister gs
        {
            get => Implementation.gs;
            set => Implementation.gs = value;
        }

        public SegmentRegister ldtr
        {
            get => Implementation.ldtr;
            set => Implementation.ldtr = value;
        }

        public SegmentRegister tr
        {
            get => Implementation.tr;
            set => Implementation.tr = value;
        }

        public EflagsRegister eflags
        {
            get => Implementation.eflags;
            set => Implementation.eflags = value;
        }

        public Ia32EferRegister ia32_efer
        {
            get => Implementation.ia32_efer;
            set => Implementation.ia32_efer = value;
        }

        public Cr0Register cr0
        {
            get => Implementation.cr0;
            set => Implementation.cr0 = value;
        }

        public Register cr2
        {
            get => Implementation.cr2;
            set => Implementation.cr2 = value;
        }

        public Register cr3
        {
            get => Implementation.cr3;
            set => Implementation.cr3 = value;
        }

        public Cr4Register cr4
        {
            get => Implementation.cr4;
            set => Implementation.cr4 = value;
        }

        public uint gdtr_base
        {
            get => Implementation.gdtr_base;
            set => Implementation.gdtr_base = value;
        }

        public ushort gdtr_limit
        {
            get => Implementation.gdtr_limit;
            set => Implementation.gdtr_limit = value;
        }

        public uint idtr_base
        {
            get => Implementation.idtr_base;
            set => Implementation.idtr_base = value;
        }

        public ushort idtr_limit
        {
            get => Implementation.idtr_limit;
            set => Implementation.idtr_limit = value;
        }

        /// <inheritdoc />
        public Address eip
        {
            get => Implementation.eip;
            set => Implementation.eip = value;
        }

        /// <inheritdoc />
        public Address CurrentInstructionAddress
        {
            get => Implementation.CurrentInstructionAddress;
            set => Implementation.CurrentInstructionAddress = value;
        }

        #endregion

        #region Memory

        /// <inheritdoc />
        public FpuStackRegister ST(int num)
        {
            return Implementation.ST(num);
        }

        /// <inheritdoc />
        public IMemory Memory => Implementation.Memory;

        /// <inheritdoc />
        public MemoryAccess memb => Implementation.memb;

        /// <inheritdoc />
        public MemoryAccess memw => Implementation.memw;

        /// <inheritdoc />
        public MemoryAccess memd => Implementation.memd;

        /// <inheritdoc />
        public MemoryAccess memq => Implementation.memq;

        /// <inheritdoc />
        public MemoryAccess memt => Implementation.memt;

        /// <inheritdoc />
        public MemoryAccess memo => Implementation.memo;

        /// <inheritdoc />
        public MemoryAccess memb_a16 => Implementation.memb_a16;
        /// <inheritdoc />
        public MemoryAccess memw_a16 => Implementation.memw_a16;
        /// <inheritdoc />
        public MemoryAccess memd_a16 => Implementation.memd_a16;
        /// <inheritdoc />
        public MemoryAccess memq_a16 => Implementation.memq_a16;

        /// <inheritdoc />
        public MemoryAccess memb_a32 => Implementation.memb_a32;
        /// <inheritdoc />
        public MemoryAccess memw_a32 => Implementation.memw_a32;
        /// <inheritdoc />
        public MemoryAccess memd_a32 => Implementation.memd_a32;
        /// <inheritdoc />
        public MemoryAccess memq_a32 => Implementation.memq_a32;
        /// <inheritdoc />
        public MemoryAccess memt_a32 => Implementation.memt_a32;
        /// <inheritdoc />
        public MemoryAccess memo_a32 => Implementation.memo_a32;

        #endregion

        #region C# emulate specific

        /// <inheritdoc />
        public void ii(Address address, uint length) => Implementation.ii(address, length);

        /// <inheritdoc />
        public void invalid()
        {
            Implementation.invalid();
        }

        #endregion

        #region Instructions

        /// <inheritdoc />
        public void aaa()
        {
            Implementation.aaa();
        }

        /// <inheritdoc />
        public void aad()
        {
            Implementation.aad();
        }

        /// <param name="value"></param>
        /// <inheritdoc />
        public void aam(ValueBase value)
        {
            Implementation.aam(value);
        }

        /// <inheritdoc />
        public void aas()
        {
            Implementation.aas();
        }

        /// <inheritdoc />
        public void adc(ValueBase dst, ValueBase src)
        {
            Implementation.adc(dst, src);
        }

        /// <inheritdoc />
        public void adcx()
        {
            Implementation.adcx();
        }

        /// <inheritdoc />
        public void add(ValueBase dst, ValueBase src)
        {
            Implementation.add(dst, src);
        }

        /// <inheritdoc />
        public void addpd()
        {
            Implementation.addpd();
        }

        /// <inheritdoc />
        public void addps()
        {
            Implementation.addps();
        }

        /// <inheritdoc />
        public void addsd()
        {
            Implementation.addsd();
        }

        /// <inheritdoc />
        public void addss()
        {
            Implementation.addss();
        }

        /// <inheritdoc />
        public void addsubpd()
        {
            Implementation.addsubpd();
        }

        /// <inheritdoc />
        public void addsubps()
        {
            Implementation.addsubps();
        }

        /// <inheritdoc />
        public void adox()
        {
            Implementation.adox();
        }

        /// <inheritdoc />
        public void aesdec()
        {
            Implementation.aesdec();
        }

        /// <inheritdoc />
        public void aesdeclast()
        {
            Implementation.aesdeclast();
        }

        /// <inheritdoc />
        public void aesenc()
        {
            Implementation.aesenc();
        }

        /// <inheritdoc />
        public void aesenclast()
        {
            Implementation.aesenclast();
        }

        /// <inheritdoc />
        public void aesimc()
        {
            Implementation.aesimc();
        }

        /// <inheritdoc />
        public void aeskeygenassist()
        {
            Implementation.aeskeygenassist();
        }

        /// <inheritdoc />
        public void and(ValueBase dst, ValueBase src)
        {
            Implementation.and(dst, src);
        }

        /// <inheritdoc />
        public void andn()
        {
            Implementation.andn();
        }

        /// <inheritdoc />
        public void andnpd()
        {
            Implementation.andnpd();
        }

        /// <inheritdoc />
        public void andnps()
        {
            Implementation.andnps();
        }

        /// <inheritdoc />
        public void andpd()
        {
            Implementation.andpd();
        }

        /// <inheritdoc />
        public void andps()
        {
            Implementation.andps();
        }

        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <inheritdoc />
        public void arpl(ValueBase a, ValueBase b)
        {
            Implementation.arpl(a, b);
        }

        /// <inheritdoc />
        public void bextr()
        {
            Implementation.bextr();
        }

        /// <inheritdoc />
        public void blendpd()
        {
            Implementation.blendpd();
        }

        /// <inheritdoc />
        public void blendps()
        {
            Implementation.blendps();
        }

        /// <inheritdoc />
        public void blendvpd()
        {
            Implementation.blendvpd();
        }

        /// <inheritdoc />
        public void blendvps()
        {
            Implementation.blendvps();
        }

        /// <inheritdoc />
        public void blsi()
        {
            Implementation.blsi();
        }

        /// <inheritdoc />
        public void blsmsk()
        {
            Implementation.blsmsk();
        }

        /// <inheritdoc />
        public void blsr()
        {
            Implementation.blsr();
        }

        /// <inheritdoc />
        public void bndcl()
        {
            Implementation.bndcl();
        }

        /// <inheritdoc />
        public void bndcn()
        {
            Implementation.bndcn();
        }

        /// <inheritdoc />
        public void bndcu()
        {
            Implementation.bndcu();
        }

        /// <inheritdoc />
        public void bndldx()
        {
            Implementation.bndldx();
        }

        /// <inheritdoc />
        public void bndmk()
        {
            Implementation.bndmk();
        }

        /// <inheritdoc />
        public void bndmov()
        {
            Implementation.bndmov();
        }

        /// <inheritdoc />
        public void bndstx()
        {
            Implementation.bndstx();
        }

        /// <inheritdoc />
        public void bound()
        {
            Implementation.bound();
        }

        /// <inheritdoc />
        public void bsf()
        {
            Implementation.bsf();
        }

        /// <inheritdoc />
        public void bsr()
        {
            Implementation.bsr();
        }

        /// <inheritdoc />
        public void bswap()
        {
            Implementation.bswap();
        }

        /// <inheritdoc />
        public void bt(ValueBase dst, ValueBase src)
        {
            Implementation.bt(dst, src);
        }

        /// <inheritdoc />
        public void btc(ValueBase dst, ValueBase src)
        {
            Implementation.btc(dst, src);
        }

        /// <inheritdoc />
        public void btr(ValueBase dst, ValueBase src)
        {
            Implementation.btr(dst, src);
        }

        /// <inheritdoc />
        public void bts()
        {
            Implementation.bts();
        }

        /// <inheritdoc />
        public void bzhi()
        {
            Implementation.bzhi();
        }

        /// <inheritdoc />
        public void call(Address address, int offset)
        {
            Implementation.call(address, offset);
        }


        /// <inheritdoc />
        public void callw(Address address, int offset)
        {
            Implementation.callw(address, offset);
        }

        /// <inheritdoc />
        public bool call_up(Address address, int offset)
        {
            return Implementation.call_up(address, offset);
        }

        /// <inheritdoc />
        public bool callw_up(Address address, int offset)
        {
            return Implementation.callw_up(address, offset);
        }

        /// <inheritdoc />
        public bool calld_up(Address address, int offset)
        {
            return Implementation.calld_up(address, offset);
        }

        /// <inheritdoc />
        public void call_abs(ValueBase address)
        {
            Implementation.call_abs(address);
        }

        /// <inheritdoc />
        public void calld(Address address, int offset)
        {
            Implementation.calld(address, offset);
        }

        /// <inheritdoc />
        public void callw_abs(ValueBase address)
        {
            Implementation.callw_abs(address);
        }

        /// <inheritdoc />
        public bool call_abs_up(ValueBase address)
        {
            return Implementation.call_abs_up(address);
        }

        /// <inheritdoc />
        public bool callw_abs_up(ValueBase address)
        {
            return Implementation.callw_abs_up(address);
        }

        /// <inheritdoc />
        public void calld_abs(ValueBase address)
        {
            Implementation.calld_abs(address);
        }

        /// <inheritdoc />
        public void call_far_abs(int segment, ValueBase address)
        {
            Implementation.call_far_abs(segment, address);
        }

        /// <inheritdoc />
        public void calld_far_abs(int segment, ValueBase address)
        {
            Implementation.calld_far_abs(segment, address);
        }

        /// <inheritdoc />
        public bool call_far_abs_up(int segment, ValueBase address)
        {
            return Implementation.call_far_abs_up(segment, address);
        }

        /// <inheritdoc />
        public void callw_far_abs(int segment, ValueBase address)
        {
            Implementation.callw_far_abs(segment, address);
        }

        /// <inheritdoc />
        public bool callw_far_abs_up(int segment, ValueBase address)
        {
            return Implementation.callw_far_abs_up(segment, address);
        }

        /// <inheritdoc />
        public void call_far_ind(MemoryValue src)
        {
            Implementation.call_far_ind(src);
        }

        /// <inheritdoc />
        public void calld_far_ind(MemoryValue src)
        {
            Implementation.calld_far_ind(src);
        }

        /// <inheritdoc />
        public void callw_a16_far_ind(MemoryValue src)
        {
            Implementation.callw_a16_far_ind(src);
        }

        /// <inheritdoc />
        public void calld_a16_far_ind(MemoryValue src)
        {
            Implementation.calld_a16_far_ind(src);
        }

        /// <inheritdoc />
        public void calld_a32_far_ind(MemoryValue src)
        {
            Implementation.calld_a32_far_ind(src);
        }

        /// <inheritdoc />
        public bool call_far_ind_up(MemoryValue src)
        {
            return Implementation.call_far_ind_up(src);
        }

        /// <inheritdoc />
        public bool callw_a16_far_ind_up(MemoryValue src)
        {
            return Implementation.callw_a16_far_ind_up(src);
        }

        /// <inheritdoc />
        public bool calld_a32_far_ind_up(MemoryValue src)
        {
            return Implementation.calld_a32_far_ind_up(src);
        }


        /// <inheritdoc />
        public void cbw()
        {
            Implementation.cbw();
        }

        /// <inheritdoc />
        public void cdq()
        {
            Implementation.cdq();
        }

        /// <inheritdoc />
        public void cdqe()
        {
            Implementation.cdqe();
        }

        /// <inheritdoc />
        public void clac()
        {
            Implementation.clac();
        }

        /// <inheritdoc />
        public void clc()
        {
            Implementation.clc();
        }

        /// <inheritdoc />
        public void cld()
        {
            Implementation.cld();
        }

        /// <inheritdoc />
        public void clflush()
        {
            Implementation.clflush();
        }

        /// <inheritdoc />
        public void clflushopt()
        {
            Implementation.clflushopt();
        }

        /// <inheritdoc />
        public void cli()
        {
            Implementation.cli();
        }

        /// <inheritdoc />
        public void clts()
        {
            Implementation.clts();
        }

        /// <inheritdoc />
        public void clwb()
        {
            Implementation.clwb();
        }

        /// <inheritdoc />
        public void cmc()
        {
            Implementation.cmc();
        }

        /// <inheritdoc />
        public void cmovcc()
        {
            Implementation.cmovcc();
        }

        /// <inheritdoc />
        public void cmp(ValueBase a, ValueBase b)
        {
            Implementation.cmp(a, b);
        }

        /// <inheritdoc />
        public void cmppd()
        {
            Implementation.cmppd();
        }

        /// <inheritdoc />
        public void cmpps()
        {
            Implementation.cmpps();
        }

        /// <inheritdoc />
        public void cmps()
        {
            Implementation.cmps();
        }

        /// <inheritdoc />
        public void cmpsb()
        {
            Implementation.cmpsb();
        }

        /// <inheritdoc />
        public void cmpsb_a16()
        {
            Implementation.cmpsb_a16();
        }

        /// <inheritdoc />
        public void cmpsb_a32()
        {
            Implementation.cmpsb_a32();
        }

        /// <inheritdoc />
        public void cmpsd()
        {
            Implementation.cmpsd();
        }

        /// <inheritdoc />
        public void cmpsd_fp()
        {
            Implementation.cmpsd_fp();
        }

        /// <inheritdoc />
        public void cmpsq()
        {
            Implementation.cmpsq();
        }

        /// <inheritdoc />
        public void cmpss()
        {
            Implementation.cmpss();
        }

        /// <inheritdoc />
        public void cmpsw()
        {
            Implementation.cmpsw();
        }

        /// <inheritdoc />
        public void cmpsw_a16()
        {
            Implementation.cmpsw_a16();
        }

        /// <inheritdoc />
        public void cmpxchg()
        {
            Implementation.cmpxchg();
        }

        /// <inheritdoc />
        public void cmpxchg16b()
        {
            Implementation.cmpxchg16b();
        }

        /// <inheritdoc />
        public void cmpxchg8b()
        {
            Implementation.cmpxchg8b();
        }

        /// <inheritdoc />
        public void comisd()
        {
            Implementation.comisd();
        }

        /// <inheritdoc />
        public void comiss()
        {
            Implementation.comiss();
        }

        /// <inheritdoc />
        public void cpuid()
        {
            Implementation.cpuid();
        }

        /// <inheritdoc />
        public void cqo()
        {
            Implementation.cqo();
        }

        /// <inheritdoc />
        public void crc32()
        {
            Implementation.crc32();
        }

        /// <inheritdoc />
        public void cvtdq2pd()
        {
            Implementation.cvtdq2pd();
        }

        /// <inheritdoc />
        public void cvtdq2ps()
        {
            Implementation.cvtdq2ps();
        }

        /// <inheritdoc />
        public void cvtpd2dq()
        {
            Implementation.cvtpd2dq();
        }

        /// <inheritdoc />
        public void cvtpd2pi()
        {
            Implementation.cvtpd2pi();
        }

        /// <inheritdoc />
        public void cvtpd2ps()
        {
            Implementation.cvtpd2ps();
        }

        /// <inheritdoc />
        public void cvtpi2pd()
        {
            Implementation.cvtpi2pd();
        }

        /// <inheritdoc />
        public void cvtpi2ps()
        {
            Implementation.cvtpi2ps();
        }

        /// <inheritdoc />
        public void cvtps2dq()
        {
            Implementation.cvtps2dq();
        }

        /// <inheritdoc />
        public void cvtps2pd()
        {
            Implementation.cvtps2pd();
        }

        /// <inheritdoc />
        public void cvtps2pi()
        {
            Implementation.cvtps2pi();
        }

        /// <inheritdoc />
        public void cvtsd2si()
        {
            Implementation.cvtsd2si();
        }

        /// <inheritdoc />
        public void cvtsd2ss()
        {
            Implementation.cvtsd2ss();
        }

        /// <inheritdoc />
        public void cvtsi2sd()
        {
            Implementation.cvtsi2sd();
        }

        /// <inheritdoc />
        public void cvtsi2ss()
        {
            Implementation.cvtsi2ss();
        }

        /// <inheritdoc />
        public void cvtss2sd()
        {
            Implementation.cvtss2sd();
        }

        /// <inheritdoc />
        public void cvtss2si()
        {
            Implementation.cvtss2si();
        }

        /// <inheritdoc />
        public void cvttpd2dq()
        {
            Implementation.cvttpd2dq();
        }

        /// <inheritdoc />
        public void cvttpd2pi()
        {
            Implementation.cvttpd2pi();
        }

        /// <inheritdoc />
        public void cvttps2dq()
        {
            Implementation.cvttps2dq();
        }

        /// <inheritdoc />
        public void cvttps2pi()
        {
            Implementation.cvttps2pi();
        }

        /// <inheritdoc />
        public void cvttsd2si()
        {
            Implementation.cvttsd2si();
        }

        /// <inheritdoc />
        public void cvttss2si()
        {
            Implementation.cvttss2si();
        }

        /// <inheritdoc />
        public void cwd()
        {
            Implementation.cwd();
        }

        /// <inheritdoc />
        public void cwde()
        {
            Implementation.cwde();
        }

        /// <inheritdoc />
        public void daa()
        {
            Implementation.daa();
        }

        /// <inheritdoc />
        public void das()
        {
            Implementation.das();
        }

        /// <inheritdoc />
        public void dec(ValueBase value)
        {
            Implementation.dec(value);
        }

        /// <inheritdoc />
        public void div(ValueBase value)
        {
            Implementation.div(value);
        }

        /// <inheritdoc />
        public void divpd()
        {
            Implementation.divpd();
        }

        /// <inheritdoc />
        public void divps()
        {
            Implementation.divps();
        }

        /// <inheritdoc />
        public void divsd()
        {
            Implementation.divsd();
        }

        /// <inheritdoc />
        public void divss()
        {
            Implementation.divss();
        }

        /// <inheritdoc />
        public void dppd()
        {
            Implementation.dppd();
        }

        /// <inheritdoc />
        public void dpps()
        {
            Implementation.dpps();
        }

        /// <inheritdoc />
        public void emms()
        {
            Implementation.emms();
        }

        /// <inheritdoc />
        public void enter(int size, int nestingLevel)
        {
            Implementation.enter(size, nestingLevel);
        }

        /// <inheritdoc />
        public void enterw(int size, int nestingLevel)
        {
            Implementation.enterw(size, nestingLevel);
        }

        /// <inheritdoc />
        public void extractps()
        {
            Implementation.extractps();
        }

        /// <inheritdoc />
        public void f2xm1()
        {
            Implementation.f2xm1();
        }

        /// <inheritdoc />
        public void fabs()
        {
            Implementation.fabs();
        }

        /// <inheritdoc />
        public void fadd(ValueBase value)
        {
            Implementation.fadd(value);
        }

        /// <inheritdoc />
        public void fadd(FpuStackRegister a, FpuStackRegister b)
        {
            Implementation.fadd(a, b);
        }

        /// <inheritdoc />
        public void faddp(FpuStackRegister a, FpuStackRegister b)
        {
            Implementation.faddp(a, b);
        }

        /// <inheritdoc />
        public void fbld()
        {
            Implementation.fbld();
        }

        /// <inheritdoc />
        public void fbstp()
        {
            Implementation.fbstp();
        }

        /// <inheritdoc />
        public void fchs()
        {
            Implementation.fchs();
        }

        /// <inheritdoc />
        public void fclex()
        {
            Implementation.fclex();
        }

        /// <inheritdoc />
        public void fcmovcc()
        {
            Implementation.fcmovcc();
        }

        /// <inheritdoc />
        public void fcom(ValueBase value)
        {
            Implementation.fcom(value);
        }

        /// <inheritdoc />
        public void fcomi()
        {
            Implementation.fcomi();
        }

        /// <inheritdoc />
        public void fcomip()
        {
            Implementation.fcomip();
        }

        /// <inheritdoc />
        public void fcomp(ValueBase value)
        {
            Implementation.fcomp(value);
        }

        /// <inheritdoc />
        public void fcomp(FpuStackRegister a, FpuStackRegister b)
        {
            Implementation.fcomp(a, b);
        }

        /// <inheritdoc />
        public void fcompp()
        {
            Implementation.fcompp();
        }

        /// <inheritdoc />
        public void fcos()
        {
            Implementation.fcos();
        }

        /// <inheritdoc />
        public void fdecstp()
        {
            Implementation.fdecstp();
        }

        /// <inheritdoc />
        public void fdiv(ValueBase value)
        {
            Implementation.fdiv(value);
        }

        /// <inheritdoc />
        public void fdiv(FpuStackRegister a, FpuStackRegister b)
        {
            Implementation.fdiv(a, b);
        }

        /// <inheritdoc />
        public void fdivp(FpuStackRegister a, FpuStackRegister b)
        {
            Implementation.fdivp(a, b);
        }

        /// <inheritdoc />
        public void fdivr(ValueBase value)
        {
            Implementation.fdivr(value);
        }

        /// <inheritdoc />
        public void fdivrp(FpuStackRegister a, FpuStackRegister b)
        {
            Implementation.fdivrp(a, b);
        }

        /// <inheritdoc />
        public void ffree()
        {
            Implementation.ffree();
        }

        /// <inheritdoc />
        public void fiadd()
        {
            Implementation.fiadd();
        }

        /// <inheritdoc />
        public void ficom()
        {
            Implementation.ficom();
        }

        /// <inheritdoc />
        public void ficomp()
        {
            Implementation.ficomp();
        }

        /// <inheritdoc />
        public void fidiv()
        {
            Implementation.fidiv();
        }

        /// <inheritdoc />
        public void fidivr()
        {
            Implementation.fidivr();
        }

        /// <inheritdoc />
        public void fild(ValueBase value)
        {
            Implementation.fild(value);
        }

        /// <inheritdoc />
        public void fimul()
        {
            Implementation.fimul();
        }

        /// <inheritdoc />
        public void fincstp()
        {
            Implementation.fincstp();
        }

        /// <inheritdoc />
        public void finit()
        {
            Implementation.finit();
        }

        /// <inheritdoc />
        public void fist()
        {
            Implementation.fist();
        }

        /// <inheritdoc />
        public void fistp(ValueBase value)
        {
            Implementation.fistp(value);
        }

        /// <inheritdoc />
        public void fisttp()
        {
            Implementation.fisttp();
        }

        /// <inheritdoc />
        public void fisub()
        {
            Implementation.fisub();
        }

        /// <inheritdoc />
        public void fisubr()
        {
            Implementation.fisubr();
        }

        /// <inheritdoc />
        public void fld(ValueBase value)
        {
            Implementation.fld(value);
        }

        /// <inheritdoc />
        public void fld1()
        {
            Implementation.fld1();
        }

        /// <inheritdoc />
        public void fldcw(ValueBase value)
        {
            Implementation.fldcw(value);
        }

        /// <inheritdoc />
        public void fldenv()
        {
            Implementation.fldenv();
        }

        /// <inheritdoc />
        public void fldl2e()
        {
            Implementation.fldl2e();
        }

        /// <inheritdoc />
        public void fldl2t()
        {
            Implementation.fldl2t();
        }

        /// <inheritdoc />
        public void fldlg2()
        {
            Implementation.fldlg2();
        }

        /// <inheritdoc />
        public void fldln2()
        {
            Implementation.fldln2();
        }

        /// <inheritdoc />
        public void fldpi()
        {
            Implementation.fldpi();
        }

        /// <inheritdoc />
        public void fldz()
        {
            Implementation.fldz();
        }

        /// <inheritdoc />
        public void fmul(ValueBase value)
        {
            Implementation.fmul(value);
        }

        /// <inheritdoc />
        public void fmul(FpuStackRegister a, FpuStackRegister b)
        {
            Implementation.fmul(a, b);
        }

        /// <inheritdoc />
        public void fmulp(FpuStackRegister a, FpuStackRegister b)
        {
            Implementation.fmulp(a, b);
        }

        /// <inheritdoc />
        public void fnclex()
        {
            Implementation.fnclex();
        }

        /// <inheritdoc />
        public void fninit()
        {
            Implementation.fninit();
        }

        /// <inheritdoc />
        public void fnop()
        {
            Implementation.fnop();
        }

        /// <inheritdoc />
        public void fnsave(MemoryValue src)
        {
            Implementation.fnsave(src);
        }

        /// <inheritdoc />
        public void fnsavew_a16(MemoryValue src)
        {
            Implementation.fnsavew_a16(src);
        }

        /// <inheritdoc />
        public void fnsetpm()
        {
            Implementation.fnsetpm();
        }

        /// <inheritdoc />
        public void fnstcw(ValueBase value)
        {
            Implementation.fnstcw(value);
        }

        /// <inheritdoc />
        public void fnstenv()
        {
            Implementation.fnstenv();
        }

        /// <inheritdoc />
        public void fnstsw(ValueBase value)
        {
            Implementation.fnstsw(value);
        }

        /// <inheritdoc />
        public void fpatan()
        {
            Implementation.fpatan();
        }

        /// <inheritdoc />
        public void fprem()
        {
            Implementation.fprem();
        }

        /// <inheritdoc />
        public void fprem1()
        {
            Implementation.fprem1();
        }

        /// <inheritdoc />
        public void fptan()
        {
            Implementation.fptan();
        }

        /// <inheritdoc />
        public void frndint()
        {
            Implementation.frndint();
        }

        /// <inheritdoc />
        public void frstor()
        {
            Implementation.frstor();
        }

        /// <inheritdoc />
        public void fsave()
        {
            Implementation.fsave();
        }

        /// <inheritdoc />
        public void fscale()
        {
            Implementation.fscale();
        }

        /// <inheritdoc />
        public void fsin()
        {
            Implementation.fsin();
        }

        /// <inheritdoc />
        public void fsincos()
        {
            Implementation.fsincos();
        }

        /// <inheritdoc />
        public void fsqrt()
        {
            Implementation.fsqrt();
        }

        /// <inheritdoc />
        public void fst(ValueBase value)
        {
            Implementation.fst(value);
        }

        /// <inheritdoc />
        public void fstcw()
        {
            Implementation.fstcw();
        }

        /// <inheritdoc />
        public void fstenv()
        {
            Implementation.fstenv();
        }

        /// <inheritdoc />
        public void fstp(ValueBase value)
        {
            Implementation.fstp(value);
        }

        /// <inheritdoc />
        public void fstsw()
        {
            Implementation.fstsw();
        }

        /// <inheritdoc />
        public void fsub(ValueBase a)
        {
            Implementation.fsub(a);
        }

        /// <inheritdoc />
        public void fsub(FpuStackRegister a, FpuStackRegister b)
        {
            Implementation.fsub(a, b);
        }

        /// <inheritdoc />
        public void fsubp(FpuStackRegister a, FpuStackRegister b)
        {
            Implementation.fsubp(a, b);
        }

        /// <inheritdoc />
        public void fsubr(ValueBase value)
        {
            Implementation.fsubr(value);
        }

        /// <inheritdoc />
        public void fsubrp()
        {
            Implementation.fsubrp();
        }

        /// <inheritdoc />
        public void ftst()
        {
            Implementation.ftst();
        }

        /// <inheritdoc />
        public void fucom()
        {
            Implementation.fucom();
        }

        /// <inheritdoc />
        public void fucomi()
        {
            Implementation.fucomi();
        }

        /// <inheritdoc />
        public void fucomip()
        {
            Implementation.fucomip();
        }

        /// <inheritdoc />
        public void fucomp()
        {
            Implementation.fucomp();
        }

        /// <inheritdoc />
        public void fucompp()
        {
            Implementation.fucompp();
        }

        /// <inheritdoc />
        public void fwait()
        {
            Implementation.fwait();
        }

        /// <inheritdoc />
        public void fxam()
        {
            Implementation.fxam();
        }

        /// <inheritdoc />
        public void fxch(FpuStackRegister a, FpuStackRegister b)
        {
            Implementation.fxch(a, b);
        }

        /// <inheritdoc />
        public void fxrstor()
        {
            Implementation.fxrstor();
        }

        /// <inheritdoc />
        public void fxsave()
        {
            Implementation.fxsave();
        }

        /// <inheritdoc />
        public void fxtract()
        {
            Implementation.fxtract();
        }

        /// <inheritdoc />
        public void fyl2x()
        {
            Implementation.fyl2x();
        }

        /// <inheritdoc />
        public void fyl2xp1()
        {
            Implementation.fyl2xp1();
        }

        /// <inheritdoc />
        public void haddpd()
        {
            Implementation.haddpd();
        }

        /// <inheritdoc />
        public void haddps()
        {
            Implementation.haddps();
        }

        /// <inheritdoc />
        public void hlt()
        {
            Implementation.hlt();
        }

        /// <inheritdoc />
        public void hsubpd()
        {
            Implementation.hsubpd();
        }

        /// <inheritdoc />
        public void hsubps()
        {
            Implementation.hsubps();
        }

        /// <inheritdoc />
        public void idiv(ValueBase value)
        {
            Implementation.idiv(value);
        }

        /// <inheritdoc />
        public void imul(ValueBase value)
        {
            Implementation.imul(value);
        }

        /// <inheritdoc />
        public void imul(ValueBase dst, ValueBase src)
        {
            Implementation.imul(dst, src);
        }

        /// <inheritdoc />
        public void imul(ValueBase dst, ValueBase src, int c)
        {
            Implementation.imul(dst, src, c);
        }

        /// <inheritdoc />
        public void inb(ValueBase dst, ValueBase port)
        {
            Implementation.inb(dst, port);
        }

        /// <inheritdoc />
        public void inw(ValueBase dst, ValueBase port)
        {
            Implementation.inw(dst, port);
        }

        /// <inheritdoc />
        public void inc(ValueBase value)
        {
            Implementation.inc(value);
        }

        /// <inheritdoc />
        public void ins()
        {
            Implementation.ins();
        }

        /// <inheritdoc />
        public void insb()
        {
            Implementation.insb();
        }

        /// <inheritdoc />
        public void insd_a32()
        {
            Implementation.insd_a32();
        }

        /// <inheritdoc />
        public void insertps()
        {
            Implementation.insertps();
        }

        /// <inheritdoc />
        public void insw()
        {
            Implementation.insw();
        }

        /// <inheritdoc />
        public void @int(int number)
        {
            Implementation.@int(number);
        }

        /// <inheritdoc />
        public void int1()
        {
            Implementation.int1();
        }

        /// <inheritdoc />
        public void int3()
        {
            Implementation.int3();
        }

        /// <inheritdoc />
        public void @into()
        {
            Implementation.@into();
        }

        /// <inheritdoc />
        public void invd()
        {
            Implementation.invd();
        }

        /// <inheritdoc />
        public void invlpg(MemoryValue value)
        {
            Implementation.invlpg(value);
        }

        /// <inheritdoc />
        public void invpcid()
        {
            Implementation.invpcid();
        }

        /// <inheritdoc />
        public void iretw()
        {
            Implementation.iretw();
        }

        /// <inheritdoc />
        public void iretd()
        {
            Implementation.iretd();
        }

        /// <inheritdoc />
        public void jmp(Address address, int offset)
        {
            Implementation.jmp(address, offset);
        }

        /// <inheritdoc />
        public bool jmp_abs(ValueBase address)
        {
            return Implementation.jmp_abs(address);
        }

        /// <inheritdoc />
        public Address jmp_abs_switch(ValueBase address)
        {
            return Implementation.jmp_abs_switch(address);
        }

        /// <inheritdoc />
        public bool jmp_far_abs(int segment, Address address)
        {
            return Implementation.jmp_far_abs(segment, address);
        }


        /// <inheritdoc />
        public bool jmp_func(Address address, int offset)
        {
            return Implementation.jmp_func(address, offset);
        }

        /// <inheritdoc />
        public bool jmpd_far_abs(int segment, Address address)
        {
            return Implementation.jmpd_far_abs(segment, address);
        }

        /// <inheritdoc />
        public bool jmp_far_ind(MemoryValue src)
        {
            return Implementation.jmp_far_ind(src);
        }

        /// <inheritdoc />
        public bool jmpd_far_ind(MemoryValue src)
        {
            return Implementation.jmpd_far_ind(src);
        }


        /// <inheritdoc />
        public bool ja(Address address, int offset)
        {
            return Implementation.ja(address, offset);
        }

        /// <inheritdoc />
        public bool ja_func(Address address, int offset)
        {
            return Implementation.ja_func(address, offset);
        }

        /// <inheritdoc />
        public bool jae(Address address, int offset)
        {
            return Implementation.jae(address, offset);
        }

        /// <inheritdoc />
        public bool jae_func(Address address, int offset)
        {
            return Implementation.jae_func(address, offset);
        }

        /// <inheritdoc />
        public bool jb(Address address, int offset)
        {
            return Implementation.jb(address, offset);
        }

        /// <inheritdoc />
        public bool jb_func(Address address, int offset)
        {
            return Implementation.jb_func(address, offset);
        }

        /// <inheritdoc />
        public bool jbe(Address address, int offset)
        {
            return Implementation.jbe(address, offset);
        }

        /// <inheritdoc />
        public bool jbe_func(Address address, int offset)
        {
            return Implementation.jbe_func(address, offset);
        }

        /// <inheritdoc />
        public bool jcxz(Address address, int offset)
        {
            return Implementation.jcxz(address, offset);
        }

        /// <inheritdoc />
        public bool jcxz_func(Address address, int offset)
        {
            return Implementation.jcxz_func(address, offset);
        }

        /// <inheritdoc />
        public bool jecxz(Address address, int offset)
        {
            return Implementation.jecxz(address, offset);
        }

        /// <inheritdoc />
        public bool jecxz_func(Address address, int offset)
        {
            return Implementation.jecxz_func(address, offset);
        }

        /// <inheritdoc />
        public bool jrcxz(Address address, int offset)
        {
            return Implementation.jrcxz(address, offset);
        }

        /// <inheritdoc />
        public bool jg(Address address, int offset)
        {
            return Implementation.jg(address, offset);
        }

        /// <inheritdoc />
        public bool jg_func(Address address, int offset)
        {
            return Implementation.jg_func(address, offset);
        }

        /// <inheritdoc />
        public bool jge(Address address, int offset)
        {
            return Implementation.jge(address, offset);
        }

        /// <inheritdoc />
        public bool jge_func(Address address, int offset)
        {
            return Implementation.jge_func(address, offset);
        }

        /// <inheritdoc />
        public bool jl(Address address, int offset)
        {
            return Implementation.jl(address, offset);
        }

        /// <inheritdoc />
        public bool jl_func(Address address, int offset)
        {
            return Implementation.jl_func(address, offset);
        }

        /// <inheritdoc />
        public bool jle(Address address, int offset)
        {
            return Implementation.jle(address, offset);
        }

        /// <inheritdoc />
        public bool jle_func(Address address, int offset)
        {
            return Implementation.jle_func(address, offset);
        }

        /// <inheritdoc />
        public bool jno(Address address, int offset)
        {
            return Implementation.jno(address, offset);
        }

        /// <inheritdoc />
        public bool jns(Address address, int offset)
        {
            return Implementation.jns(address, offset);
        }

        /// <inheritdoc />
        public bool jns_func(Address address, int offset)
        {
            return Implementation.jns_func(address, offset);
        }

        /// <inheritdoc />
        public bool jnz(Address address, int offset)
        {
            return Implementation.jnz(address, offset);
        }

        /// <inheritdoc />
        public bool jnz_func(Address address, int offset)
        {
            return Implementation.jnz_func(address, offset);
        }

        /// <inheritdoc />
        public bool jo(Address address, int offset)
        {
            return Implementation.jo(address, offset);
        }

        /// <inheritdoc />
        public bool jp(Address address, int offset)
        {
            return Implementation.jp(address, offset);
        }

        /// <inheritdoc />
        public bool jpe(Address address, int offset)
        {
            return Implementation.jpe(address, offset);
        }

        /// <inheritdoc />
        public bool jpo(Address address, int offset)
        {
            return Implementation.jpo(address, offset);
        }

        /// <inheritdoc />
        public bool js(Address address, int offset)
        {
            return Implementation.js(address, offset);
        }

        /// <inheritdoc />
        public bool js_func(Address address, int offset)
        {
            return Implementation.js_func(address, offset);
        }

        /// <inheritdoc />
        public bool jz(Address address, int offset)
        {
            return Implementation.jz(address, offset);
        }

        /// <inheritdoc />
        public bool jz_func(Address address, int offset)
        {
            return Implementation.jz_func(address, offset);
        }

        /// <inheritdoc />
        public void kaddb()
        {
            Implementation.kaddb();
        }

        /// <inheritdoc />
        public void kaddd()
        {
            Implementation.kaddd();
        }

        /// <inheritdoc />
        public void kaddq()
        {
            Implementation.kaddq();
        }

        /// <inheritdoc />
        public void kaddw()
        {
            Implementation.kaddw();
        }

        /// <inheritdoc />
        public void kandb()
        {
            Implementation.kandb();
        }

        /// <inheritdoc />
        public void kandd()
        {
            Implementation.kandd();
        }

        /// <inheritdoc />
        public void kandnb()
        {
            Implementation.kandnb();
        }

        /// <inheritdoc />
        public void kandnd()
        {
            Implementation.kandnd();
        }

        /// <inheritdoc />
        public void kandnq()
        {
            Implementation.kandnq();
        }

        /// <inheritdoc />
        public void kandnw()
        {
            Implementation.kandnw();
        }

        /// <inheritdoc />
        public void kandq()
        {
            Implementation.kandq();
        }

        /// <inheritdoc />
        public void kandw()
        {
            Implementation.kandw();
        }

        /// <inheritdoc />
        public void kmovb()
        {
            Implementation.kmovb();
        }

        /// <inheritdoc />
        public void kmovd()
        {
            Implementation.kmovd();
        }

        /// <inheritdoc />
        public void kmovq()
        {
            Implementation.kmovq();
        }

        /// <inheritdoc />
        public void kmovw()
        {
            Implementation.kmovw();
        }

        /// <inheritdoc />
        public void knotb()
        {
            Implementation.knotb();
        }

        /// <inheritdoc />
        public void knotd()
        {
            Implementation.knotd();
        }

        /// <inheritdoc />
        public void knotq()
        {
            Implementation.knotq();
        }

        /// <inheritdoc />
        public void knotw()
        {
            Implementation.knotw();
        }

        /// <inheritdoc />
        public void korb()
        {
            Implementation.korb();
        }

        /// <inheritdoc />
        public void kord()
        {
            Implementation.kord();
        }

        /// <inheritdoc />
        public void korq()
        {
            Implementation.korq();
        }

        /// <inheritdoc />
        public void kortestb()
        {
            Implementation.kortestb();
        }

        /// <inheritdoc />
        public void kortestd()
        {
            Implementation.kortestd();
        }

        /// <inheritdoc />
        public void kortestq()
        {
            Implementation.kortestq();
        }

        /// <inheritdoc />
        public void kortestw()
        {
            Implementation.kortestw();
        }

        /// <inheritdoc />
        public void korw()
        {
            Implementation.korw();
        }

        /// <inheritdoc />
        public void kshiftlb()
        {
            Implementation.kshiftlb();
        }

        /// <inheritdoc />
        public void kshiftld()
        {
            Implementation.kshiftld();
        }

        /// <inheritdoc />
        public void kshiftlq()
        {
            Implementation.kshiftlq();
        }

        /// <inheritdoc />
        public void kshiftlw()
        {
            Implementation.kshiftlw();
        }

        /// <inheritdoc />
        public void kshiftrb()
        {
            Implementation.kshiftrb();
        }

        /// <inheritdoc />
        public void kshiftrd()
        {
            Implementation.kshiftrd();
        }

        /// <inheritdoc />
        public void kshiftrq()
        {
            Implementation.kshiftrq();
        }

        /// <inheritdoc />
        public void kshiftrw()
        {
            Implementation.kshiftrw();
        }

        /// <inheritdoc />
        public void ktestb()
        {
            Implementation.ktestb();
        }

        /// <inheritdoc />
        public void ktestd()
        {
            Implementation.ktestd();
        }

        /// <inheritdoc />
        public void ktestq()
        {
            Implementation.ktestq();
        }

        /// <inheritdoc />
        public void ktestw()
        {
            Implementation.ktestw();
        }

        /// <inheritdoc />
        public void kunpckbw()
        {
            Implementation.kunpckbw();
        }

        /// <inheritdoc />
        public void kunpckdq()
        {
            Implementation.kunpckdq();
        }

        /// <inheritdoc />
        public void kunpckwd()
        {
            Implementation.kunpckwd();
        }

        /// <inheritdoc />
        public void kxnorb()
        {
            Implementation.kxnorb();
        }

        /// <inheritdoc />
        public void kxnord()
        {
            Implementation.kxnord();
        }

        /// <inheritdoc />
        public void kxnorq()
        {
            Implementation.kxnorq();
        }

        /// <inheritdoc />
        public void kxnorw()
        {
            Implementation.kxnorw();
        }

        /// <inheritdoc />
        public void kxorb()
        {
            Implementation.kxorb();
        }

        /// <inheritdoc />
        public void kxord()
        {
            Implementation.kxord();
        }

        /// <inheritdoc />
        public void kxorq()
        {
            Implementation.kxorq();
        }

        /// <inheritdoc />
        public void kxorw()
        {
            Implementation.kxorw();
        }

        /// <inheritdoc />
        public void lahf()
        {
            Implementation.lahf();
        }

        /// <inheritdoc />
        public void lar(ValueBase dst, ValueBase src)
        {
            Implementation.lar(dst, src);
        }

        /// <inheritdoc />
        public void lddqu()
        {
            Implementation.lddqu();
        }

        /// <inheritdoc />
        public void ldmxcsr()
        {
            Implementation.ldmxcsr();
        }

        /// <inheritdoc />
        public void lea(ValueBase dst, MemoryValue src)
        {
            Implementation.lea(dst, src);
        }

        /// <inheritdoc />
        public void lds(ValueBase dst, MemoryValue src)
        {
            Implementation.lds(dst, src);
        }

        /// <inheritdoc />
        public void les(ValueBase dst, MemoryValue src)
        {
            Implementation.les(dst, src);
        }

        /// <inheritdoc />
        public void lfs(ValueBase dst, MemoryValue src)
        {
            Implementation.lfs(dst, src);
        }

        /// <inheritdoc />
        public void lgs(ValueBase dst, MemoryValue src)
        {
            Implementation.lgs(dst, src);
        }

        /// <inheritdoc />
        public void lss(ValueBase dst, MemoryValue src)
        {
            Implementation.lss(dst, src);
        }

        /// <inheritdoc />
        public void leave()
        {
            Implementation.leave();
        }

        /// <inheritdoc />
        public void leavew()
        {
            Implementation.leavew();
        }

        /// <inheritdoc />
        public void leaved()
        {
            Implementation.leaved();
        }

        /// <inheritdoc />
        public void lfence()
        {
            Implementation.lfence();
        }

        /// <inheritdoc />
        public void lgdt(MemoryValue src)
        {
            Implementation.lgdt(src);
        }

        /// <inheritdoc />
        public void lidt(MemoryValue src)
        {
            Implementation.lidt(src);
        }

        /// <inheritdoc />
        public void lldt(ValueBase value)
        {
            Implementation.lldt(value);
        }

        /// <inheritdoc />
        public void lmsw(ValueBase value)
        {
            Implementation.lmsw(value);
        }

        /// <inheritdoc />
        public void @lock()
        {
            Implementation.@lock();
        }

        /// <inheritdoc />
        public void lods()
        {
            Implementation.lods();
        }

        /// <inheritdoc />
        public void lodsb()
        {
            Implementation.lodsb();
        }

        /// <inheritdoc />
        public void lodsb_a16()
        {
            Implementation.lodsb_a16();
        }

        /// <inheritdoc />
        public void lodsb_a32()
        {
            Implementation.lodsb_a32();
        }

        /// <inheritdoc />
        public void lodsd()
        {
            Implementation.lodsd();
        }

        /// <inheritdoc />
        public void lodsd_a16()
        {
            Implementation.lodsd_a16();
        }

        /// <inheritdoc />
        public void lodsd_a32()
        {
            Implementation.lodsd_a32();
        }

        /// <inheritdoc />
        public void lodsq()
        {
            Implementation.lodsq();
        }

        /// <inheritdoc />
        public void lodsw()
        {
            Implementation.lodsw();
        }

        /// <inheritdoc />
        public void lodsw_a16()
        {
            Implementation.lodsw_a16();
        }

        /// <inheritdoc />
        public bool loop(Address address, int offset)
        {
            return Implementation.loop(address, offset);
        }

        /// <inheritdoc />
        public bool loop_func(Address address, int offset)
        {
            return Implementation.loop_func(address, offset);
        }

        /// <inheritdoc />
        public bool loope(Address address, int offset)
        {
            return Implementation.loope(address, offset);
        }

        /// <inheritdoc />
        public bool loope_func(Address address, int offset)
        {
            return Implementation.loope_func(address, offset);
        }

        /// <inheritdoc />
        public bool loopne(Address address, int offset)
        {
            return Implementation.loopne(address, offset);
        }

        /// <inheritdoc />
        public bool loopne_func(Address address, int offset)
        {
            return Implementation.loopne_func(address, offset);
        }

        /// <inheritdoc />
        public void lsl(ValueBase dst, ValueBase selector)
        {
            Implementation.lsl(dst, selector);
        }

        /// <inheritdoc />
        public void ltr(ValueBase value)
        {
            Implementation.ltr(value);
        }

        /// <inheritdoc />
        public void lzcnt()
        {
            Implementation.lzcnt();
        }

        /// <inheritdoc />
        public void maskmovdqu()
        {
            Implementation.maskmovdqu();
        }

        /// <inheritdoc />
        public void maskmovq()
        {
            Implementation.maskmovq();
        }

        /// <inheritdoc />
        public void maxpd()
        {
            Implementation.maxpd();
        }

        /// <inheritdoc />
        public void maxps()
        {
            Implementation.maxps();
        }

        /// <inheritdoc />
        public void maxsd()
        {
            Implementation.maxsd();
        }

        /// <inheritdoc />
        public void maxss()
        {
            Implementation.maxss();
        }

        /// <inheritdoc />
        public void mfence()
        {
            Implementation.mfence();
        }

        /// <inheritdoc />
        public void minpd()
        {
            Implementation.minpd();
        }

        /// <inheritdoc />
        public void minps()
        {
            Implementation.minps();
        }

        /// <inheritdoc />
        public void minsd()
        {
            Implementation.minsd();
        }

        /// <inheritdoc />
        public void minss()
        {
            Implementation.minss();
        }

        /// <inheritdoc />
        public void monitor()
        {
            Implementation.monitor();
        }

        /// <inheritdoc />
        public void mov(ValueBase dst, ValueBase src)
        {
            Implementation.mov(dst, src);
        }

        /// <inheritdoc />
        public void mov_cr()
        {
            Implementation.mov_cr();
        }

        /// <inheritdoc />
        public void mov_dr()
        {
            Implementation.mov_dr();
        }

        /// <inheritdoc />
        public void movapd()
        {
            Implementation.movapd();
        }

        /// <inheritdoc />
        public void movaps()
        {
            Implementation.movaps();
        }

        /// <inheritdoc />
        public void movbe()
        {
            Implementation.movbe();
        }

        /// <inheritdoc />
        public void movd()
        {
            Implementation.movd();
        }

        /// <inheritdoc />
        public void movddup()
        {
            Implementation.movddup();
        }

        /// <inheritdoc />
        public void movdq2q()
        {
            Implementation.movdq2q();
        }

        /// <inheritdoc />
        public void movdqa()
        {
            Implementation.movdqa();
        }

        /// <inheritdoc />
        public void movdqu()
        {
            Implementation.movdqu();
        }

        /// <inheritdoc />
        public void movhlps()
        {
            Implementation.movhlps();
        }

        /// <inheritdoc />
        public void movhpd()
        {
            Implementation.movhpd();
        }

        /// <inheritdoc />
        public void movhps()
        {
            Implementation.movhps();
        }

        /// <inheritdoc />
        public void movlhps()
        {
            Implementation.movlhps();
        }

        /// <inheritdoc />
        public void movlpd()
        {
            Implementation.movlpd();
        }

        /// <inheritdoc />
        public void movlps()
        {
            Implementation.movlps();
        }

        /// <inheritdoc />
        public void movmskpd()
        {
            Implementation.movmskpd();
        }

        /// <inheritdoc />
        public void movmskps()
        {
            Implementation.movmskps();
        }

        /// <inheritdoc />
        public void movntdq()
        {
            Implementation.movntdq();
        }

        /// <inheritdoc />
        public void movntdqa()
        {
            Implementation.movntdqa();
        }

        /// <inheritdoc />
        public void movnti()
        {
            Implementation.movnti();
        }

        /// <inheritdoc />
        public void movntpd()
        {
            Implementation.movntpd();
        }

        /// <inheritdoc />
        public void movntps()
        {
            Implementation.movntps();
        }

        /// <inheritdoc />
        public void movntq()
        {
            Implementation.movntq();
        }

        /// <inheritdoc />
        public void movq_1()
        {
            Implementation.movq_1();
        }

        /// <inheritdoc />
        public void movq_2()
        {
            Implementation.movq_2();
        }

        /// <inheritdoc />
        public void movq2dq()
        {
            Implementation.movq2dq();
        }

        /// <inheritdoc />
        public void movsb(SegmentRegister segment = null)
        {
            Implementation.movsb(segment);
        }

        /// <inheritdoc />
        public void movsb_a16(SegmentRegister segment = null)
        {
            Implementation.movsb_a16(segment);
        }

        /// <inheritdoc />
        public void movsb_a32(SegmentRegister segment = null)
        {
            Implementation.movsb_a32(segment);
        }

        /// <inheritdoc />
        public void movsw(SegmentRegister segment = null)
        {
            Implementation.movsw(segment);
        }

        /// <inheritdoc />
        public void movsw_a16(SegmentRegister segment = null)
        {
            Implementation.movsw_a16(segment);
        }

        /// <inheritdoc />
        public void movsw_a32(SegmentRegister segment = null)
        {
            Implementation.movsw_a32(segment);
        }

        /// <inheritdoc />
        public void movsd()
        {
            Implementation.movsd();
        }

        /// <inheritdoc />
        public void movsd_a16()
        {
            Implementation.movsd_a16();
        }

        /// <inheritdoc />
        public void movsd_a32(SegmentRegister segment = null)
        {
            Implementation.movsd_a32(segment);
        }

        /// <inheritdoc />
        public void movsd_fp()
        {
            Implementation.movsd_fp();
        }

        /// <inheritdoc />
        public void movshdup()
        {
            Implementation.movshdup();
        }

        /// <inheritdoc />
        public void movsldup()
        {
            Implementation.movsldup();
        }

        /// <inheritdoc />
        public void movsq()
        {
            Implementation.movsq();
        }

        /// <inheritdoc />
        public void movss()
        {
            Implementation.movss();
        }

        /// <inheritdoc />
        public void movsx(ValueBase dst, ValueBase src)
        {
            Implementation.movsx(dst, src);
        }

        /// <inheritdoc />
        public void movsxd()
        {
            Implementation.movsxd();
        }

        /// <inheritdoc />
        public void movupd()
        {
            Implementation.movupd();
        }

        /// <inheritdoc />
        public void movups()
        {
            Implementation.movups();
        }

        /// <inheritdoc />
        public void movzx(ValueBase dst, ValueBase src)
        {
            Implementation.movzx(dst, src);
        }

        /// <inheritdoc />
        public void mpsadbw()
        {
            Implementation.mpsadbw();
        }

        /// <inheritdoc />
        public void mul(ValueBase value)
        {
            Implementation.mul(value);
        }

        /// <inheritdoc />
        public void mulpd()
        {
            Implementation.mulpd();
        }

        /// <inheritdoc />
        public void mulps()
        {
            Implementation.mulps();
        }

        /// <inheritdoc />
        public void mulsd()
        {
            Implementation.mulsd();
        }

        /// <inheritdoc />
        public void mulss()
        {
            Implementation.mulss();
        }

        /// <inheritdoc />
        public void mulx()
        {
            Implementation.mulx();
        }

        /// <inheritdoc />
        public void mwait()
        {
            Implementation.mwait();
        }

        /// <inheritdoc />
        public void neg(ValueBase value)
        {
            Implementation.neg(value);
        }

        /// <inheritdoc />
        public void nop()
        {
            Implementation.nop();
        }

        /// <inheritdoc />
        public void not(ValueBase value)
        {
            Implementation.not(value);
        }

        /// <inheritdoc />
        public void or(ValueBase dst, ValueBase src)
        {
            Implementation.or(dst, src);
        }

        /// <inheritdoc />
        public void orpd()
        {
            Implementation.orpd();
        }

        /// <inheritdoc />
        public void orps()
        {
            Implementation.orps();
        }

        /// <inheritdoc />
        public void outb(ValueBase port, ValueBase value)
        {
            Implementation.outb(port, value);
        }

        /// <inheritdoc />
        public void outw(ValueBase port, ValueBase value)
        {
            Implementation.outw(port, value);
        }

        /// <inheritdoc />
        public void outs()
        {
            Implementation.outs();
        }

        /// <inheritdoc />
        public void outsb(SegmentRegister segment = null)
        {
            Implementation.outsb(segment);
        }

        /// <inheritdoc />
        public void outsb_a16(SegmentRegister segment = null)
        {
            Implementation.outsb_a16(segment);
        }

        /// <inheritdoc />
        public void outsb_a32(SegmentRegister segment = null)
        {
            Implementation.outsb_a32(segment);
        }

        /// <inheritdoc />
        public void outsd()
        {
            Implementation.outsd();
        }

        /// <inheritdoc />
        public void outsw()
        {
            Implementation.outsw();
        }

        /// <inheritdoc />
        public void pabsb()
        {
            Implementation.pabsb();
        }

        /// <inheritdoc />
        public void pabsd()
        {
            Implementation.pabsd();
        }

        /// <inheritdoc />
        public void pabsq()
        {
            Implementation.pabsq();
        }

        /// <inheritdoc />
        public void pabsw()
        {
            Implementation.pabsw();
        }

        /// <inheritdoc />
        public void packssdw()
        {
            Implementation.packssdw();
        }

        /// <inheritdoc />
        public void packsswb()
        {
            Implementation.packsswb();
        }

        /// <inheritdoc />
        public void packusdw()
        {
            Implementation.packusdw();
        }

        /// <inheritdoc />
        public void packuswb()
        {
            Implementation.packuswb();
        }

        /// <inheritdoc />
        public void paddb()
        {
            Implementation.paddb();
        }

        /// <inheritdoc />
        public void paddd()
        {
            Implementation.paddd();
        }

        /// <inheritdoc />
        public void paddq()
        {
            Implementation.paddq();
        }

        /// <inheritdoc />
        public void paddsb()
        {
            Implementation.paddsb();
        }

        /// <inheritdoc />
        public void paddsw()
        {
            Implementation.paddsw();
        }

        /// <inheritdoc />
        public void paddusb()
        {
            Implementation.paddusb();
        }

        /// <inheritdoc />
        public void paddusw()
        {
            Implementation.paddusw();
        }

        /// <inheritdoc />
        public void paddw()
        {
            Implementation.paddw();
        }

        /// <inheritdoc />
        public void palignr()
        {
            Implementation.palignr();
        }

        /// <inheritdoc />
        public void pand()
        {
            Implementation.pand();
        }

        /// <inheritdoc />
        public void pandn()
        {
            Implementation.pandn();
        }

        /// <inheritdoc />
        public void pause()
        {
            Implementation.pause();
        }

        /// <inheritdoc />
        public void pavgb()
        {
            Implementation.pavgb();
        }

        /// <inheritdoc />
        public void pavgw()
        {
            Implementation.pavgw();
        }

        /// <inheritdoc />
        public void pblendvb()
        {
            Implementation.pblendvb();
        }

        /// <inheritdoc />
        public void pblendw()
        {
            Implementation.pblendw();
        }

        /// <inheritdoc />
        public void pclmulqdq()
        {
            Implementation.pclmulqdq();
        }

        /// <inheritdoc />
        public void pcmpeqb()
        {
            Implementation.pcmpeqb();
        }

        /// <inheritdoc />
        public void pcmpeqd()
        {
            Implementation.pcmpeqd();
        }

        /// <inheritdoc />
        public void pcmpeqq()
        {
            Implementation.pcmpeqq();
        }

        /// <inheritdoc />
        public void pcmpeqw()
        {
            Implementation.pcmpeqw();
        }

        /// <inheritdoc />
        public void pcmpestri()
        {
            Implementation.pcmpestri();
        }

        /// <inheritdoc />
        public void pcmpestrm()
        {
            Implementation.pcmpestrm();
        }

        /// <inheritdoc />
        public void pcmpgtb()
        {
            Implementation.pcmpgtb();
        }

        /// <inheritdoc />
        public void pcmpgtd()
        {
            Implementation.pcmpgtd();
        }

        /// <inheritdoc />
        public void pcmpgtq()
        {
            Implementation.pcmpgtq();
        }

        /// <inheritdoc />
        public void pcmpgtw()
        {
            Implementation.pcmpgtw();
        }

        /// <inheritdoc />
        public void pcmpistri()
        {
            Implementation.pcmpistri();
        }

        /// <inheritdoc />
        public void pcmpistrm()
        {
            Implementation.pcmpistrm();
        }

        /// <inheritdoc />
        public void pdep()
        {
            Implementation.pdep();
        }

        /// <inheritdoc />
        public void pext()
        {
            Implementation.pext();
        }

        /// <inheritdoc />
        public void pextrb()
        {
            Implementation.pextrb();
        }

        /// <inheritdoc />
        public void pextrd()
        {
            Implementation.pextrd();
        }

        /// <inheritdoc />
        public void pextrq()
        {
            Implementation.pextrq();
        }

        /// <inheritdoc />
        public void pextrw()
        {
            Implementation.pextrw();
        }

        /// <inheritdoc />
        public void phaddd()
        {
            Implementation.phaddd();
        }

        /// <inheritdoc />
        public void phaddsw()
        {
            Implementation.phaddsw();
        }

        /// <inheritdoc />
        public void phaddw()
        {
            Implementation.phaddw();
        }

        /// <inheritdoc />
        public void phminposuw()
        {
            Implementation.phminposuw();
        }

        /// <inheritdoc />
        public void phsubd()
        {
            Implementation.phsubd();
        }

        /// <inheritdoc />
        public void phsubsw()
        {
            Implementation.phsubsw();
        }

        /// <inheritdoc />
        public void phsubw()
        {
            Implementation.phsubw();
        }

        /// <inheritdoc />
        public void pinsrb()
        {
            Implementation.pinsrb();
        }

        /// <inheritdoc />
        public void pinsrd()
        {
            Implementation.pinsrd();
        }

        /// <inheritdoc />
        public void pinsrq()
        {
            Implementation.pinsrq();
        }

        /// <inheritdoc />
        public void pinsrw()
        {
            Implementation.pinsrw();
        }

        /// <inheritdoc />
        public void pmaddubsw()
        {
            Implementation.pmaddubsw();
        }

        /// <inheritdoc />
        public void pmaddwd()
        {
            Implementation.pmaddwd();
        }

        /// <inheritdoc />
        public void pmaxsb()
        {
            Implementation.pmaxsb();
        }

        /// <inheritdoc />
        public void pmaxsd()
        {
            Implementation.pmaxsd();
        }

        /// <inheritdoc />
        public void pmaxsq()
        {
            Implementation.pmaxsq();
        }

        /// <inheritdoc />
        public void pmaxsw()
        {
            Implementation.pmaxsw();
        }

        /// <inheritdoc />
        public void pmaxub()
        {
            Implementation.pmaxub();
        }

        /// <inheritdoc />
        public void pmaxud()
        {
            Implementation.pmaxud();
        }

        /// <inheritdoc />
        public void pmaxuq()
        {
            Implementation.pmaxuq();
        }

        /// <inheritdoc />
        public void pmaxuw()
        {
            Implementation.pmaxuw();
        }

        /// <inheritdoc />
        public void pminsb()
        {
            Implementation.pminsb();
        }

        /// <inheritdoc />
        public void pminsd()
        {
            Implementation.pminsd();
        }

        /// <inheritdoc />
        public void pminsq()
        {
            Implementation.pminsq();
        }

        /// <inheritdoc />
        public void pminsw()
        {
            Implementation.pminsw();
        }

        /// <inheritdoc />
        public void pminub()
        {
            Implementation.pminub();
        }

        /// <inheritdoc />
        public void pminud()
        {
            Implementation.pminud();
        }

        /// <inheritdoc />
        public void pminuq()
        {
            Implementation.pminuq();
        }

        /// <inheritdoc />
        public void pminuw()
        {
            Implementation.pminuw();
        }

        /// <inheritdoc />
        public void pmovmskb()
        {
            Implementation.pmovmskb();
        }

        /// <inheritdoc />
        public void pmovsx()
        {
            Implementation.pmovsx();
        }

        /// <inheritdoc />
        public void pmovzx()
        {
            Implementation.pmovzx();
        }

        /// <inheritdoc />
        public void pmuldq()
        {
            Implementation.pmuldq();
        }

        /// <inheritdoc />
        public void pmulhrsw()
        {
            Implementation.pmulhrsw();
        }

        /// <inheritdoc />
        public void pmulhuw()
        {
            Implementation.pmulhuw();
        }

        /// <inheritdoc />
        public void pmulhw()
        {
            Implementation.pmulhw();
        }

        /// <inheritdoc />
        public void pmulld()
        {
            Implementation.pmulld();
        }

        /// <inheritdoc />
        public void pmullq()
        {
            Implementation.pmullq();
        }

        /// <inheritdoc />
        public void pmullw()
        {
            Implementation.pmullw();
        }

        /// <inheritdoc />
        public void pmuludq()
        {
            Implementation.pmuludq();
        }

        /// <inheritdoc />
        public ValueBase pop(ValueBase d = null)
        {
            return Implementation.pop(d);
        }

        /// <inheritdoc />
        public ushort popw(ValueBase d = null)
        {
            return Implementation.popw(d);
        }

        /// <inheritdoc />
        public uint popd(ValueBase d = null)
        {
            return Implementation.popd(d);
        }

        /// <inheritdoc />
        public void popa()
        {
            Implementation.popa();
        }

        /// <inheritdoc />
        public void popad()
        {
            Implementation.popad();
        }

        /// <inheritdoc />
        public void popcnt()
        {
            Implementation.popcnt();
        }

        /// <inheritdoc />
        public void popfw()
        {
            Implementation.popfw();
        }

        /// <inheritdoc />
        public void popfd()
        {
            Implementation.popfd();
        }

        /// <inheritdoc />
        public void popfq()
        {
            Implementation.popfq();
        }

        /// <inheritdoc />
        public void por()
        {
            Implementation.por();
        }

        /// <inheritdoc />
        public void prefetchw()
        {
            Implementation.prefetchw();
        }

        /// <inheritdoc />
        public void prefetchh()
        {
            Implementation.prefetchh();
        }

        /// <inheritdoc />
        public void psadbw()
        {
            Implementation.psadbw();
        }

        /// <inheritdoc />
        public void pshufb()
        {
            Implementation.pshufb();
        }

        /// <inheritdoc />
        public void pshufd()
        {
            Implementation.pshufd();
        }

        /// <inheritdoc />
        public void pshufhw()
        {
            Implementation.pshufhw();
        }

        /// <inheritdoc />
        public void pshuflw()
        {
            Implementation.pshuflw();
        }

        /// <inheritdoc />
        public void pshufw()
        {
            Implementation.pshufw();
        }

        /// <inheritdoc />
        public void psignb()
        {
            Implementation.psignb();
        }

        /// <inheritdoc />
        public void psignd()
        {
            Implementation.psignd();
        }

        /// <inheritdoc />
        public void psignw()
        {
            Implementation.psignw();
        }

        /// <inheritdoc />
        public void pslld()
        {
            Implementation.pslld();
        }

        /// <inheritdoc />
        public void pslldq()
        {
            Implementation.pslldq();
        }

        /// <inheritdoc />
        public void psllq()
        {
            Implementation.psllq();
        }

        /// <inheritdoc />
        public void psllw()
        {
            Implementation.psllw();
        }

        /// <inheritdoc />
        public void psrad()
        {
            Implementation.psrad();
        }

        /// <inheritdoc />
        public void psraq()
        {
            Implementation.psraq();
        }

        /// <inheritdoc />
        public void psraw()
        {
            Implementation.psraw();
        }

        /// <inheritdoc />
        public void psrld()
        {
            Implementation.psrld();
        }

        /// <inheritdoc />
        public void psrldq()
        {
            Implementation.psrldq();
        }

        /// <inheritdoc />
        public void psrlq()
        {
            Implementation.psrlq();
        }

        /// <inheritdoc />
        public void psrlw()
        {
            Implementation.psrlw();
        }

        /// <inheritdoc />
        public void psubb()
        {
            Implementation.psubb();
        }

        /// <inheritdoc />
        public void psubd()
        {
            Implementation.psubd();
        }

        /// <inheritdoc />
        public void psubq()
        {
            Implementation.psubq();
        }

        /// <inheritdoc />
        public void psubsb()
        {
            Implementation.psubsb();
        }

        /// <inheritdoc />
        public void psubsw()
        {
            Implementation.psubsw();
        }

        /// <inheritdoc />
        public void psubusb()
        {
            Implementation.psubusb();
        }

        /// <inheritdoc />
        public void psubusw()
        {
            Implementation.psubusw();
        }

        /// <inheritdoc />
        public void psubw()
        {
            Implementation.psubw();
        }

        /// <inheritdoc />
        public void ptest()
        {
            Implementation.ptest();
        }

        /// <inheritdoc />
        public void ptwrite()
        {
            Implementation.ptwrite();
        }

        /// <inheritdoc />
        public void punpckhbw()
        {
            Implementation.punpckhbw();
        }

        /// <inheritdoc />
        public void punpckhdq()
        {
            Implementation.punpckhdq();
        }

        /// <inheritdoc />
        public void punpckhqdq()
        {
            Implementation.punpckhqdq();
        }

        /// <inheritdoc />
        public void punpckhwd()
        {
            Implementation.punpckhwd();
        }

        /// <inheritdoc />
        public void punpcklbw()
        {
            Implementation.punpcklbw();
        }

        /// <inheritdoc />
        public void punpckldq()
        {
            Implementation.punpckldq();
        }

        /// <inheritdoc />
        public void punpcklqdq()
        {
            Implementation.punpcklqdq();
        }

        /// <inheritdoc />
        public void punpcklwd()
        {
            Implementation.punpcklwd();
        }

        /// <inheritdoc />
        public void push(ValueBase s)
        {
            Implementation.push(s);
        }

        /// <inheritdoc />
        public void pushw(ValueBase s)
        {
            Implementation.pushw(s);
        }

        /// <inheritdoc />
        public void pushd(ValueBase s)
        {
            Implementation.pushd(s);
        }

        /// <inheritdoc />
        public void pusha()
        {
            Implementation.pusha();
        }

        /// <inheritdoc />
        public void pushad()
        {
            Implementation.pushad();
        }

        /// <inheritdoc />
        public void pushfw()
        {
            Implementation.pushfw();
        }

        /// <inheritdoc />
        public void pushfd()
        {
            Implementation.pushfd();
        }

        /// <inheritdoc />
        public void pushfq()
        {
            Implementation.pushfq();
        }

        /// <inheritdoc />
        public void pxor()
        {
            Implementation.pxor();
        }

        /// <inheritdoc />
        public void rcl(ValueBase dst, int count)
        {
            Implementation.rcl(dst, count);
        }

        /// <inheritdoc />
        public void rcpps()
        {
            Implementation.rcpps();
        }

        /// <inheritdoc />
        public void rcpss()
        {
            Implementation.rcpss();
        }

        /// <inheritdoc />
        public void rcr(ValueBase dst, int count)
        {
            Implementation.rcr(dst, count);
        }

        /// <inheritdoc />
        public void rdfsbase()
        {
            Implementation.rdfsbase();
        }

        /// <inheritdoc />
        public void rdgsbase()
        {
            Implementation.rdgsbase();
        }

        /// <inheritdoc />
        public void rdmsr()
        {
            Implementation.rdmsr();
        }

        /// <inheritdoc />
        public void rdpid()
        {
            Implementation.rdpid();
        }

        /// <inheritdoc />
        public void rdpkru()
        {
            Implementation.rdpkru();
        }

        /// <inheritdoc />
        public void rdpmc()
        {
            Implementation.rdpmc();
        }

        /// <inheritdoc />
        public void rdrand()
        {
            Implementation.rdrand();
        }

        /// <inheritdoc />
        public void rdseed()
        {
            Implementation.rdseed();
        }

        /// <inheritdoc />
        public void rdtsc()
        {
            Implementation.rdtsc();
        }

        /// <inheritdoc />
        public void rdtscp()
        {
            Implementation.rdtscp();
        }

        /// <inheritdoc />
        public void rep(Action action)
        {
            Implementation.rep(action);
        }

        /// <inheritdoc />
        public void rep_a16(Action action)
        {
            Implementation.rep_a16(action);
        }

        /// <inheritdoc />
        public void repe(Action action)
        {
            Implementation.repe(action);
        }

        /// <inheritdoc />
        public void repe_a16(Action action)
        {
            Implementation.repe_a16(action);
        }

        /// <inheritdoc />
        public void repne(Action action)
        {
            Implementation.repne(action);
        }

        /// <inheritdoc />
        public void repne_a16(Action action)
        {
            Implementation.repne_a16(action);
        }

        /// <inheritdoc />
        public void rep_a32(Action action)
        {
            Implementation.rep_a32(action);
        }

        /// <inheritdoc />
        public void repe_a32(Action action)
        {
            Implementation.repe_a32(action);
        }

        /// <inheritdoc />
        public void repne_a32(Action action)
        {
            Implementation.repne_a32(action);
        }

        /// <inheritdoc />
        public void ret(int allocSize = 0)
        {
            Implementation.ret(allocSize);
        }

        /// <inheritdoc />
        public void retw(int allocSize = 0)
        {
            Implementation.retw(allocSize);
        }

        /// <inheritdoc />
        public void retd(int size = 0)
        {
            Implementation.retd(size);
        }

        /// <inheritdoc />
        public void retf(int size = 0)
        {
            Implementation.retf(size);
        }

        /// <inheritdoc />
        public void retfw(int size = 0)
        {
            Implementation.retfw(size);
        }

        /// <inheritdoc />
        public void retfd(int size = 0)
        {
            Implementation.retfd(size);
        }

        /// <inheritdoc />
        public void rol(ValueBase dst, ValueBase count)
        {
            Implementation.rol(dst, count);
        }

        /// <inheritdoc />
        public void ror(ValueBase dst, ValueBase count)
        {
            Implementation.ror(dst, count);
        }

        /// <inheritdoc />
        public void rorx()
        {
            Implementation.rorx();
        }

        /// <inheritdoc />
        public void roundpd()
        {
            Implementation.roundpd();
        }

        /// <inheritdoc />
        public void roundps()
        {
            Implementation.roundps();
        }

        /// <inheritdoc />
        public void roundsd()
        {
            Implementation.roundsd();
        }

        /// <inheritdoc />
        public void roundss()
        {
            Implementation.roundss();
        }

        /// <inheritdoc />
        public void rsm()
        {
            Implementation.rsm();
        }

        /// <inheritdoc />
        public void rsqrtps()
        {
            Implementation.rsqrtps();
        }

        /// <inheritdoc />
        public void rsqrtss()
        {
            Implementation.rsqrtss();
        }

        /// <inheritdoc />
        public void sahf()
        {
            Implementation.sahf();
        }

        /// <inheritdoc />
        public void sal()
        {
            Implementation.sal();
        }

        /// <inheritdoc />
        public void sar(ValueBase dst, ValueBase count)
        {
            Implementation.sar(dst, count);
        }

        /// <inheritdoc />
        public void sarx()
        {
            Implementation.sarx();
        }

        /// <inheritdoc />
        public void sbb(ValueBase dst, ValueBase src)
        {
            Implementation.sbb(dst, src);
        }

        /// <inheritdoc />
        public void scas()
        {
            Implementation.scas();
        }

        /// <inheritdoc />
        public void scasb()
        {
            Implementation.scasb();
        }

        /// <inheritdoc />
        public void scasb_a16()
        {
            Implementation.scasb_a16();
        }

        /// <inheritdoc />
        public void scasb_a32()
        {
            Implementation.scasb_a32();
        }

        /// <inheritdoc />
        public void scasd()
        {
            Implementation.scasd();
        }

        /// <inheritdoc />
        public void scasd_a16()
        {
            Implementation.scasd_a16();
        }

        /// <inheritdoc />
        public void scasd_a32()
        {
            Implementation.scasd_a32();
        }

        /// <inheritdoc />
        public void scasw()
        {
            Implementation.scasw();
        }

        /// <inheritdoc />
        public void scasw_a16()
        {
            Implementation.scasw_a16();
        }

        /// <inheritdoc />
        public void seta(ValueBase value)
        {
            Implementation.seta(value);
        }

        /// <inheritdoc />
        public void setbe(ValueBase value)
        {
            Implementation.setbe(value);
        }

        /// <inheritdoc />
        public void setg(ValueBase value)
        {
            Implementation.setg(value);
        }

        /// <inheritdoc />
        public void setge(ValueBase value)
        {
            Implementation.setge(value);
        }

        /// <inheritdoc />
        public void setae(ValueBase value)
        {
            Implementation.setae(value);
        }

        /// <inheritdoc />
        public void setle(ValueBase value)
        {
            Implementation.setle(value);
        }

        /// <inheritdoc />
        public void setz(ValueBase value)
        {
            Implementation.setz(value);
        }

        /// <inheritdoc />
        public void setnz(ValueBase value)
        {
            Implementation.setnz(value);
        }

        /// <inheritdoc />
        public void sfence()
        {
            Implementation.sfence();
        }

        /// <inheritdoc />
        public void sgdt()
        {
            Implementation.sgdt();
        }

        /// <inheritdoc />
        public void sha1msg1()
        {
            Implementation.sha1msg1();
        }

        /// <inheritdoc />
        public void sha1msg2()
        {
            Implementation.sha1msg2();
        }

        /// <inheritdoc />
        public void sha1nexte()
        {
            Implementation.sha1nexte();
        }

        /// <inheritdoc />
        public void sha1rnds4()
        {
            Implementation.sha1rnds4();
        }

        /// <inheritdoc />
        public void sha256msg1()
        {
            Implementation.sha256msg1();
        }

        /// <inheritdoc />
        public void sha256msg2()
        {
            Implementation.sha256msg2();
        }

        /// <inheritdoc />
        public void sha256rnds2()
        {
            Implementation.sha256rnds2();
        }

        /// <inheritdoc />
        public void shl(ValueBase dst, ValueBase count)
        {
            Implementation.shl(dst, count);
        }

        /// <inheritdoc />
        public void shld(ValueBase dst, ValueBase src, int count)
        {
            Implementation.shld(dst, src, count);
        }

        /// <inheritdoc />
        public void shlx()
        {
            Implementation.shlx();
        }

        /// <inheritdoc />
        public void shr(ValueBase dst, ValueBase count)
        {
            Implementation.shr(dst, count);
        }

        /// <inheritdoc />
        public void shrd(ValueBase dst, ValueBase src, int count)
        {
            Implementation.shrd(dst, src, count);
        }

        /// <inheritdoc />
        public void shrx()
        {
            Implementation.shrx();
        }

        /// <inheritdoc />
        public void shufpd()
        {
            Implementation.shufpd();
        }

        /// <inheritdoc />
        public void shufps()
        {
            Implementation.shufps();
        }

        /// <inheritdoc />
        public void sidt(MemoryValue src)
        {
            Implementation.sidt(src);
        }

        /// <inheritdoc />
        public void sldt(ValueBase value)
        {
            Implementation.sldt(value);
        }

        /// <inheritdoc />
        public void smsw(ValueBase value)
        {
            Implementation.smsw(value);
        }

        /// <inheritdoc />
        public void sqrtpd()
        {
            Implementation.sqrtpd();
        }

        /// <inheritdoc />
        public void sqrtps()
        {
            Implementation.sqrtps();
        }

        /// <inheritdoc />
        public void sqrtsd()
        {
            Implementation.sqrtsd();
        }

        /// <inheritdoc />
        public void sqrtss()
        {
            Implementation.sqrtss();
        }

        /// <inheritdoc />
        public void stac()
        {
            Implementation.stac();
        }

        /// <inheritdoc />
        public void stc()
        {
            Implementation.stc();
        }

        /// <inheritdoc />
        public void std()
        {
            Implementation.std();
        }

        /// <inheritdoc />
        public void sti()
        {
            Implementation.sti();
        }

        /// <inheritdoc />
        public void stmxcsr()
        {
            Implementation.stmxcsr();
        }

        /// <inheritdoc />
        public void stos()
        {
            Implementation.stos();
        }

        /// <inheritdoc />
        public void stosb()
        {
            Implementation.stosb();
        }

        /// <inheritdoc />
        public void stosb_a16()
        {
            Implementation.stosb_a16();
        }

        /// <inheritdoc />
        public void stosb_a32()
        {
            Implementation.stosb_a32();
        }

        /// <inheritdoc />
        public void stosd()
        {
            Implementation.stosd();
        }

        /// <inheritdoc />
        public void stosd_a16()
        {
            Implementation.stosd_a16();
        }

        /// <inheritdoc />
        public void stosd_a32()
        {
            Implementation.stosd_a32();
        }

        /// <inheritdoc />
        public void stosq()
        {
            Implementation.stosq();
        }

        /// <inheritdoc />
        public void stosw()
        {
            Implementation.stosw();
        }

        /// <inheritdoc />
        public void stosw_a16()
        {
            Implementation.stosw_a16();
        }

        /// <inheritdoc />
        public void stosw_a32()
        {
            Implementation.stosw_a32();
        }

        /// <inheritdoc />
        public void str(ValueBase value)
        {
            Implementation.str(value);
        }

        /// <inheritdoc />
        public void sub(ValueBase dst, ValueBase src)
        {
            Implementation.sub(dst, src);
        }

        /// <inheritdoc />
        public void subpd()
        {
            Implementation.subpd();
        }

        /// <inheritdoc />
        public void subps()
        {
            Implementation.subps();
        }

        /// <inheritdoc />
        public void subsd()
        {
            Implementation.subsd();
        }

        /// <inheritdoc />
        public void subss()
        {
            Implementation.subss();
        }

        /// <inheritdoc />
        public void swapgs()
        {
            Implementation.swapgs();
        }

        /// <inheritdoc />
        public void syscall()
        {
            Implementation.syscall();
        }

        /// <inheritdoc />
        public void sysenter()
        {
            Implementation.sysenter();
        }

        /// <inheritdoc />
        public void sysexit()
        {
            Implementation.sysexit();
        }

        /// <inheritdoc />
        public void sysret()
        {
            Implementation.sysret();
        }

        /// <inheritdoc />
        public void test(ValueBase a, ValueBase b)
        {
            Implementation.test(a, b);
        }

        /// <inheritdoc />
        public void tzcnt()
        {
            Implementation.tzcnt();
        }

        /// <inheritdoc />
        public void ucomisd()
        {
            Implementation.ucomisd();
        }

        /// <inheritdoc />
        public void ucomiss()
        {
            Implementation.ucomiss();
        }

        /// <inheritdoc />
        public void ud()
        {
            Implementation.ud();
        }

        /// <inheritdoc />
        public void unpckhpd()
        {
            Implementation.unpckhpd();
        }

        /// <inheritdoc />
        public void unpckhps()
        {
            Implementation.unpckhps();
        }

        /// <inheritdoc />
        public void unpcklpd()
        {
            Implementation.unpcklpd();
        }

        /// <inheritdoc />
        public void unpcklps()
        {
            Implementation.unpcklps();
        }

        /// <inheritdoc />
        public void valignd()
        {
            Implementation.valignd();
        }

        /// <inheritdoc />
        public void valignq()
        {
            Implementation.valignq();
        }

        /// <inheritdoc />
        public void vblendmpd()
        {
            Implementation.vblendmpd();
        }

        /// <inheritdoc />
        public void vblendmps()
        {
            Implementation.vblendmps();
        }

        /// <inheritdoc />
        public void vbroadcast()
        {
            Implementation.vbroadcast();
        }

        /// <inheritdoc />
        public void vcompresspd()
        {
            Implementation.vcompresspd();
        }

        /// <inheritdoc />
        public void vcompressps()
        {
            Implementation.vcompressps();
        }

        /// <inheritdoc />
        public void vcvtpd2qq()
        {
            Implementation.vcvtpd2qq();
        }

        /// <inheritdoc />
        public void vcvtpd2udq()
        {
            Implementation.vcvtpd2udq();
        }

        /// <inheritdoc />
        public void vcvtpd2uqq()
        {
            Implementation.vcvtpd2uqq();
        }

        /// <inheritdoc />
        public void vcvtph2ps()
        {
            Implementation.vcvtph2ps();
        }

        /// <inheritdoc />
        public void vcvtps2ph()
        {
            Implementation.vcvtps2ph();
        }

        /// <inheritdoc />
        public void vcvtps2qq()
        {
            Implementation.vcvtps2qq();
        }

        /// <inheritdoc />
        public void vcvtps2udq()
        {
            Implementation.vcvtps2udq();
        }

        /// <inheritdoc />
        public void vcvtps2uqq()
        {
            Implementation.vcvtps2uqq();
        }

        /// <inheritdoc />
        public void vcvtqq2pd()
        {
            Implementation.vcvtqq2pd();
        }

        /// <inheritdoc />
        public void vcvtqq2ps()
        {
            Implementation.vcvtqq2ps();
        }

        /// <inheritdoc />
        public void vcvtsd2usi()
        {
            Implementation.vcvtsd2usi();
        }

        /// <inheritdoc />
        public void vcvtss2usi()
        {
            Implementation.vcvtss2usi();
        }

        /// <inheritdoc />
        public void vcvttpd2qq()
        {
            Implementation.vcvttpd2qq();
        }

        /// <inheritdoc />
        public void vcvttpd2udq()
        {
            Implementation.vcvttpd2udq();
        }

        /// <inheritdoc />
        public void vcvttpd2uqq()
        {
            Implementation.vcvttpd2uqq();
        }

        /// <inheritdoc />
        public void vcvttps2qq()
        {
            Implementation.vcvttps2qq();
        }

        /// <inheritdoc />
        public void vcvttps2udq()
        {
            Implementation.vcvttps2udq();
        }

        /// <inheritdoc />
        public void vcvttps2uqq()
        {
            Implementation.vcvttps2uqq();
        }

        /// <inheritdoc />
        public void vcvttsd2usi()
        {
            Implementation.vcvttsd2usi();
        }

        /// <inheritdoc />
        public void vcvttss2usi()
        {
            Implementation.vcvttss2usi();
        }

        /// <inheritdoc />
        public void vcvtudq2pd()
        {
            Implementation.vcvtudq2pd();
        }

        /// <inheritdoc />
        public void vcvtudq2ps()
        {
            Implementation.vcvtudq2ps();
        }

        /// <inheritdoc />
        public void vcvtuqq2pd()
        {
            Implementation.vcvtuqq2pd();
        }

        /// <inheritdoc />
        public void vcvtuqq2ps()
        {
            Implementation.vcvtuqq2ps();
        }

        /// <inheritdoc />
        public void vcvtusi2sd()
        {
            Implementation.vcvtusi2sd();
        }

        /// <inheritdoc />
        public void vcvtusi2ss()
        {
            Implementation.vcvtusi2ss();
        }

        /// <inheritdoc />
        public void vdbpsadbw()
        {
            Implementation.vdbpsadbw();
        }

        /// <inheritdoc />
        public void verr()
        {
            Implementation.verr();
        }

        /// <inheritdoc />
        public void verw()
        {
            Implementation.verw();
        }

        /// <inheritdoc />
        public void vexpandpd()
        {
            Implementation.vexpandpd();
        }

        /// <inheritdoc />
        public void vexpandps()
        {
            Implementation.vexpandps();
        }

        /// <inheritdoc />
        public void vextractf128()
        {
            Implementation.vextractf128();
        }

        /// <inheritdoc />
        public void vextractf32x4()
        {
            Implementation.vextractf32x4();
        }

        /// <inheritdoc />
        public void vextractf32x8()
        {
            Implementation.vextractf32x8();
        }

        /// <inheritdoc />
        public void vextractf64x2()
        {
            Implementation.vextractf64x2();
        }

        /// <inheritdoc />
        public void vextractf64x4()
        {
            Implementation.vextractf64x4();
        }

        /// <inheritdoc />
        public void vextracti128()
        {
            Implementation.vextracti128();
        }

        /// <inheritdoc />
        public void vextracti32x4()
        {
            Implementation.vextracti32x4();
        }

        /// <inheritdoc />
        public void vextracti32x8()
        {
            Implementation.vextracti32x8();
        }

        /// <inheritdoc />
        public void vextracti64x2()
        {
            Implementation.vextracti64x2();
        }

        /// <inheritdoc />
        public void vextracti64x4()
        {
            Implementation.vextracti64x4();
        }

        /// <inheritdoc />
        public void vfixupimmpd()
        {
            Implementation.vfixupimmpd();
        }

        /// <inheritdoc />
        public void vfixupimmps()
        {
            Implementation.vfixupimmps();
        }

        /// <inheritdoc />
        public void vfixupimmsd()
        {
            Implementation.vfixupimmsd();
        }

        /// <inheritdoc />
        public void vfixupimmss()
        {
            Implementation.vfixupimmss();
        }

        /// <inheritdoc />
        public void vfmadd132pd()
        {
            Implementation.vfmadd132pd();
        }

        /// <inheritdoc />
        public void vfmadd132ps()
        {
            Implementation.vfmadd132ps();
        }

        /// <inheritdoc />
        public void vfmadd132sd()
        {
            Implementation.vfmadd132sd();
        }

        /// <inheritdoc />
        public void vfmadd132ss()
        {
            Implementation.vfmadd132ss();
        }

        /// <inheritdoc />
        public void vfmadd213pd()
        {
            Implementation.vfmadd213pd();
        }

        /// <inheritdoc />
        public void vfmadd213ps()
        {
            Implementation.vfmadd213ps();
        }

        /// <inheritdoc />
        public void vfmadd213sd()
        {
            Implementation.vfmadd213sd();
        }

        /// <inheritdoc />
        public void vfmadd213ss()
        {
            Implementation.vfmadd213ss();
        }

        /// <inheritdoc />
        public void vfmadd231pd()
        {
            Implementation.vfmadd231pd();
        }

        /// <inheritdoc />
        public void vfmadd231ps()
        {
            Implementation.vfmadd231ps();
        }

        /// <inheritdoc />
        public void vfmadd231sd()
        {
            Implementation.vfmadd231sd();
        }

        /// <inheritdoc />
        public void vfmadd231ss()
        {
            Implementation.vfmadd231ss();
        }

        /// <inheritdoc />
        public void vfmaddsub132pd()
        {
            Implementation.vfmaddsub132pd();
        }

        /// <inheritdoc />
        public void vfmaddsub132ps()
        {
            Implementation.vfmaddsub132ps();
        }

        /// <inheritdoc />
        public void vfmaddsub213pd()
        {
            Implementation.vfmaddsub213pd();
        }

        /// <inheritdoc />
        public void vfmaddsub213ps()
        {
            Implementation.vfmaddsub213ps();
        }

        /// <inheritdoc />
        public void vfmaddsub231pd()
        {
            Implementation.vfmaddsub231pd();
        }

        /// <inheritdoc />
        public void vfmaddsub231ps()
        {
            Implementation.vfmaddsub231ps();
        }

        /// <inheritdoc />
        public void vfmsub132pd()
        {
            Implementation.vfmsub132pd();
        }

        /// <inheritdoc />
        public void vfmsub132ps()
        {
            Implementation.vfmsub132ps();
        }

        /// <inheritdoc />
        public void vfmsub132sd()
        {
            Implementation.vfmsub132sd();
        }

        /// <inheritdoc />
        public void vfmsub132ss()
        {
            Implementation.vfmsub132ss();
        }

        /// <inheritdoc />
        public void vfmsub213pd()
        {
            Implementation.vfmsub213pd();
        }

        /// <inheritdoc />
        public void vfmsub213ps()
        {
            Implementation.vfmsub213ps();
        }

        /// <inheritdoc />
        public void vfmsub213sd()
        {
            Implementation.vfmsub213sd();
        }

        /// <inheritdoc />
        public void vfmsub213ss()
        {
            Implementation.vfmsub213ss();
        }

        /// <inheritdoc />
        public void vfmsub231pd()
        {
            Implementation.vfmsub231pd();
        }

        /// <inheritdoc />
        public void vfmsub231ps()
        {
            Implementation.vfmsub231ps();
        }

        /// <inheritdoc />
        public void vfmsub231sd()
        {
            Implementation.vfmsub231sd();
        }

        /// <inheritdoc />
        public void vfmsub231ss()
        {
            Implementation.vfmsub231ss();
        }

        /// <inheritdoc />
        public void vfmsubadd132pd()
        {
            Implementation.vfmsubadd132pd();
        }

        /// <inheritdoc />
        public void vfmsubadd132ps()
        {
            Implementation.vfmsubadd132ps();
        }

        /// <inheritdoc />
        public void vfmsubadd213pd()
        {
            Implementation.vfmsubadd213pd();
        }

        /// <inheritdoc />
        public void vfmsubadd213ps()
        {
            Implementation.vfmsubadd213ps();
        }

        /// <inheritdoc />
        public void vfmsubadd231pd()
        {
            Implementation.vfmsubadd231pd();
        }

        /// <inheritdoc />
        public void vfmsubadd231ps()
        {
            Implementation.vfmsubadd231ps();
        }

        /// <inheritdoc />
        public void vfnmadd132pd()
        {
            Implementation.vfnmadd132pd();
        }

        /// <inheritdoc />
        public void vfnmadd132ps()
        {
            Implementation.vfnmadd132ps();
        }

        /// <inheritdoc />
        public void vfnmadd132sd()
        {
            Implementation.vfnmadd132sd();
        }

        /// <inheritdoc />
        public void vfnmadd132ss()
        {
            Implementation.vfnmadd132ss();
        }

        /// <inheritdoc />
        public void vfnmadd213pd()
        {
            Implementation.vfnmadd213pd();
        }

        /// <inheritdoc />
        public void vfnmadd213ps()
        {
            Implementation.vfnmadd213ps();
        }

        /// <inheritdoc />
        public void vfnmadd213sd()
        {
            Implementation.vfnmadd213sd();
        }

        /// <inheritdoc />
        public void vfnmadd213ss()
        {
            Implementation.vfnmadd213ss();
        }

        /// <inheritdoc />
        public void vfnmadd231pd()
        {
            Implementation.vfnmadd231pd();
        }

        /// <inheritdoc />
        public void vfnmadd231ps()
        {
            Implementation.vfnmadd231ps();
        }

        /// <inheritdoc />
        public void vfnmadd231sd()
        {
            Implementation.vfnmadd231sd();
        }

        /// <inheritdoc />
        public void vfnmadd231ss()
        {
            Implementation.vfnmadd231ss();
        }

        /// <inheritdoc />
        public void vfnmsub132pd()
        {
            Implementation.vfnmsub132pd();
        }

        /// <inheritdoc />
        public void vfnmsub132ps()
        {
            Implementation.vfnmsub132ps();
        }

        /// <inheritdoc />
        public void vfnmsub132sd()
        {
            Implementation.vfnmsub132sd();
        }

        /// <inheritdoc />
        public void vfnmsub132ss()
        {
            Implementation.vfnmsub132ss();
        }

        /// <inheritdoc />
        public void vfnmsub213pd()
        {
            Implementation.vfnmsub213pd();
        }

        /// <inheritdoc />
        public void vfnmsub213ps()
        {
            Implementation.vfnmsub213ps();
        }

        /// <inheritdoc />
        public void vfnmsub213sd()
        {
            Implementation.vfnmsub213sd();
        }

        /// <inheritdoc />
        public void vfnmsub213ss()
        {
            Implementation.vfnmsub213ss();
        }

        /// <inheritdoc />
        public void vfnmsub231pd()
        {
            Implementation.vfnmsub231pd();
        }

        /// <inheritdoc />
        public void vfnmsub231ps()
        {
            Implementation.vfnmsub231ps();
        }

        /// <inheritdoc />
        public void vfnmsub231sd()
        {
            Implementation.vfnmsub231sd();
        }

        /// <inheritdoc />
        public void vfnmsub231ss()
        {
            Implementation.vfnmsub231ss();
        }

        /// <inheritdoc />
        public void vfpclasspd()
        {
            Implementation.vfpclasspd();
        }

        /// <inheritdoc />
        public void vfpclassps()
        {
            Implementation.vfpclassps();
        }

        /// <inheritdoc />
        public void vfpclasssd()
        {
            Implementation.vfpclasssd();
        }

        /// <inheritdoc />
        public void vfpclassss()
        {
            Implementation.vfpclassss();
        }

        /// <inheritdoc />
        public void vgatherdpd()
        {
            Implementation.vgatherdpd();
        }

        /// <inheritdoc />
        public void vgatherdpd_s()
        {
            Implementation.vgatherdpd_s();
        }

        /// <inheritdoc />
        public void vgatherdps()
        {
            Implementation.vgatherdps();
        }

        /// <inheritdoc />
        public void vgatherdps_s()
        {
            Implementation.vgatherdps_s();
        }

        /// <inheritdoc />
        public void vgatherqpd()
        {
            Implementation.vgatherqpd();
        }

        /// <inheritdoc />
        public void vgatherqpd_s()
        {
            Implementation.vgatherqpd_s();
        }

        /// <inheritdoc />
        public void vgatherqps()
        {
            Implementation.vgatherqps();
        }

        /// <inheritdoc />
        public void vgatherqps_s()
        {
            Implementation.vgatherqps_s();
        }

        /// <inheritdoc />
        public void vgetexppd()
        {
            Implementation.vgetexppd();
        }

        /// <inheritdoc />
        public void vgetexpps()
        {
            Implementation.vgetexpps();
        }

        /// <inheritdoc />
        public void vgetexpsd()
        {
            Implementation.vgetexpsd();
        }

        /// <inheritdoc />
        public void vgetexpss()
        {
            Implementation.vgetexpss();
        }

        /// <inheritdoc />
        public void vgetmantpd()
        {
            Implementation.vgetmantpd();
        }

        /// <inheritdoc />
        public void vgetmantps()
        {
            Implementation.vgetmantps();
        }

        /// <inheritdoc />
        public void vgetmantsd()
        {
            Implementation.vgetmantsd();
        }

        /// <inheritdoc />
        public void vgetmantss()
        {
            Implementation.vgetmantss();
        }

        /// <inheritdoc />
        public void vinsertf128()
        {
            Implementation.vinsertf128();
        }

        /// <inheritdoc />
        public void vinsertf32x4()
        {
            Implementation.vinsertf32x4();
        }

        /// <inheritdoc />
        public void vinsertf32x8()
        {
            Implementation.vinsertf32x8();
        }

        /// <inheritdoc />
        public void vinsertf64x2()
        {
            Implementation.vinsertf64x2();
        }

        /// <inheritdoc />
        public void vinsertf64x4()
        {
            Implementation.vinsertf64x4();
        }

        /// <inheritdoc />
        public void vinserti128()
        {
            Implementation.vinserti128();
        }

        /// <inheritdoc />
        public void vinserti32x4()
        {
            Implementation.vinserti32x4();
        }

        /// <inheritdoc />
        public void vinserti32x8()
        {
            Implementation.vinserti32x8();
        }

        /// <inheritdoc />
        public void vinserti64x2()
        {
            Implementation.vinserti64x2();
        }

        /// <inheritdoc />
        public void vinserti64x4()
        {
            Implementation.vinserti64x4();
        }

        /// <inheritdoc />
        public void vmaskmov()
        {
            Implementation.vmaskmov();
        }

        /// <inheritdoc />
        public void vmovdqa32()
        {
            Implementation.vmovdqa32();
        }

        /// <inheritdoc />
        public void vmovdqa64()
        {
            Implementation.vmovdqa64();
        }

        /// <inheritdoc />
        public void vmovdqu16()
        {
            Implementation.vmovdqu16();
        }

        /// <inheritdoc />
        public void vmovdqu32()
        {
            Implementation.vmovdqu32();
        }

        /// <inheritdoc />
        public void vmovdqu64()
        {
            Implementation.vmovdqu64();
        }

        /// <inheritdoc />
        public void vmovdqu8()
        {
            Implementation.vmovdqu8();
        }

        /// <inheritdoc />
        public void vpblendd()
        {
            Implementation.vpblendd();
        }

        /// <inheritdoc />
        public void vpblendmb()
        {
            Implementation.vpblendmb();
        }

        /// <inheritdoc />
        public void vpblendmd()
        {
            Implementation.vpblendmd();
        }

        /// <inheritdoc />
        public void vpblendmq()
        {
            Implementation.vpblendmq();
        }

        /// <inheritdoc />
        public void vpblendmw()
        {
            Implementation.vpblendmw();
        }

        /// <inheritdoc />
        public void vpbroadcast()
        {
            Implementation.vpbroadcast();
        }

        /// <inheritdoc />
        public void vpbroadcastb()
        {
            Implementation.vpbroadcastb();
        }

        /// <inheritdoc />
        public void vpbroadcastd()
        {
            Implementation.vpbroadcastd();
        }

        /// <inheritdoc />
        public void vpbroadcastm()
        {
            Implementation.vpbroadcastm();
        }

        /// <inheritdoc />
        public void vpbroadcastq()
        {
            Implementation.vpbroadcastq();
        }

        /// <inheritdoc />
        public void vpbroadcastw()
        {
            Implementation.vpbroadcastw();
        }

        /// <inheritdoc />
        public void vpcmpb()
        {
            Implementation.vpcmpb();
        }

        /// <inheritdoc />
        public void vpcmpd()
        {
            Implementation.vpcmpd();
        }

        /// <inheritdoc />
        public void vpcmpq()
        {
            Implementation.vpcmpq();
        }

        /// <inheritdoc />
        public void vpcmpub()
        {
            Implementation.vpcmpub();
        }

        /// <inheritdoc />
        public void vpcmpud()
        {
            Implementation.vpcmpud();
        }

        /// <inheritdoc />
        public void vpcmpuq()
        {
            Implementation.vpcmpuq();
        }

        /// <inheritdoc />
        public void vpcmpuw()
        {
            Implementation.vpcmpuw();
        }

        /// <inheritdoc />
        public void vpcmpw()
        {
            Implementation.vpcmpw();
        }

        /// <inheritdoc />
        public void vpcompressd()
        {
            Implementation.vpcompressd();
        }

        /// <inheritdoc />
        public void vpcompressq()
        {
            Implementation.vpcompressq();
        }

        /// <inheritdoc />
        public void vpconflictd()
        {
            Implementation.vpconflictd();
        }

        /// <inheritdoc />
        public void vpconflictq()
        {
            Implementation.vpconflictq();
        }

        /// <inheritdoc />
        public void vperm2f128()
        {
            Implementation.vperm2f128();
        }

        /// <inheritdoc />
        public void vperm2i128()
        {
            Implementation.vperm2i128();
        }

        /// <inheritdoc />
        public void vpermb()
        {
            Implementation.vpermb();
        }

        /// <inheritdoc />
        public void vpermd()
        {
            Implementation.vpermd();
        }

        /// <inheritdoc />
        public void vpermi2b()
        {
            Implementation.vpermi2b();
        }

        /// <inheritdoc />
        public void vpermi2d()
        {
            Implementation.vpermi2d();
        }

        /// <inheritdoc />
        public void vpermi2pd()
        {
            Implementation.vpermi2pd();
        }

        /// <inheritdoc />
        public void vpermi2ps()
        {
            Implementation.vpermi2ps();
        }

        /// <inheritdoc />
        public void vpermi2q()
        {
            Implementation.vpermi2q();
        }

        /// <inheritdoc />
        public void vpermi2w()
        {
            Implementation.vpermi2w();
        }

        /// <inheritdoc />
        public void vpermilpd()
        {
            Implementation.vpermilpd();
        }

        /// <inheritdoc />
        public void vpermilps()
        {
            Implementation.vpermilps();
        }

        /// <inheritdoc />
        public void vpermpd()
        {
            Implementation.vpermpd();
        }

        /// <inheritdoc />
        public void vpermps()
        {
            Implementation.vpermps();
        }

        /// <inheritdoc />
        public void vpermq()
        {
            Implementation.vpermq();
        }

        /// <inheritdoc />
        public void vpermt2b()
        {
            Implementation.vpermt2b();
        }

        /// <inheritdoc />
        public void vpermt2d()
        {
            Implementation.vpermt2d();
        }

        /// <inheritdoc />
        public void vpermt2pd()
        {
            Implementation.vpermt2pd();
        }

        /// <inheritdoc />
        public void vpermt2ps()
        {
            Implementation.vpermt2ps();
        }

        /// <inheritdoc />
        public void vpermt2q()
        {
            Implementation.vpermt2q();
        }

        /// <inheritdoc />
        public void vpermt2w()
        {
            Implementation.vpermt2w();
        }

        /// <inheritdoc />
        public void vpermw()
        {
            Implementation.vpermw();
        }

        /// <inheritdoc />
        public void vpexpandd()
        {
            Implementation.vpexpandd();
        }

        /// <inheritdoc />
        public void vpexpandq()
        {
            Implementation.vpexpandq();
        }

        /// <inheritdoc />
        public void vpgatherdd()
        {
            Implementation.vpgatherdd();
        }

        /// <inheritdoc />
        public void vpgatherdd_s()
        {
            Implementation.vpgatherdd_s();
        }

        /// <inheritdoc />
        public void vpgatherdq_s()
        {
            Implementation.vpgatherdq_s();
        }

        /// <inheritdoc />
        public void vpgatherdq()
        {
            Implementation.vpgatherdq();
        }

        /// <inheritdoc />
        public void vpgatherqd()
        {
            Implementation.vpgatherqd();
        }

        /// <inheritdoc />
        public void vpgatherqd_s()
        {
            Implementation.vpgatherqd_s();
        }

        /// <inheritdoc />
        public void vpgatherqq()
        {
            Implementation.vpgatherqq();
        }

        /// <inheritdoc />
        public void vpgatherqq_s()
        {
            Implementation.vpgatherqq_s();
        }

        /// <inheritdoc />
        public void vplzcntd()
        {
            Implementation.vplzcntd();
        }

        /// <inheritdoc />
        public void vplzcntq()
        {
            Implementation.vplzcntq();
        }

        /// <inheritdoc />
        public void vpmadd52huq()
        {
            Implementation.vpmadd52huq();
        }

        /// <inheritdoc />
        public void vpmadd52luq()
        {
            Implementation.vpmadd52luq();
        }

        /// <inheritdoc />
        public void vpmaskmov()
        {
            Implementation.vpmaskmov();
        }

        /// <inheritdoc />
        public void vpmovb2m()
        {
            Implementation.vpmovb2m();
        }

        /// <inheritdoc />
        public void vpmovd2m()
        {
            Implementation.vpmovd2m();
        }

        /// <inheritdoc />
        public void vpmovdb()
        {
            Implementation.vpmovdb();
        }

        /// <inheritdoc />
        public void vpmovdw()
        {
            Implementation.vpmovdw();
        }

        /// <inheritdoc />
        public void vpmovm2b()
        {
            Implementation.vpmovm2b();
        }

        /// <inheritdoc />
        public void vpmovm2d()
        {
            Implementation.vpmovm2d();
        }

        /// <inheritdoc />
        public void vpmovm2q()
        {
            Implementation.vpmovm2q();
        }

        /// <inheritdoc />
        public void vpmovm2w()
        {
            Implementation.vpmovm2w();
        }

        /// <inheritdoc />
        public void vpmovq2m()
        {
            Implementation.vpmovq2m();
        }

        /// <inheritdoc />
        public void vpmovqb()
        {
            Implementation.vpmovqb();
        }

        /// <inheritdoc />
        public void vpmovqd()
        {
            Implementation.vpmovqd();
        }

        /// <inheritdoc />
        public void vpmovqw()
        {
            Implementation.vpmovqw();
        }

        /// <inheritdoc />
        public void vpmovsdb()
        {
            Implementation.vpmovsdb();
        }

        /// <inheritdoc />
        public void vpmovsdw()
        {
            Implementation.vpmovsdw();
        }

        /// <inheritdoc />
        public void vpmovsqb()
        {
            Implementation.vpmovsqb();
        }

        /// <inheritdoc />
        public void vpmovsqd()
        {
            Implementation.vpmovsqd();
        }

        /// <inheritdoc />
        public void vpmovsqw()
        {
            Implementation.vpmovsqw();
        }

        /// <inheritdoc />
        public void vpmovswb()
        {
            Implementation.vpmovswb();
        }

        /// <inheritdoc />
        public void vpmovusdb()
        {
            Implementation.vpmovusdb();
        }

        /// <inheritdoc />
        public void vpmovusdw()
        {
            Implementation.vpmovusdw();
        }

        /// <inheritdoc />
        public void vpmovusqb()
        {
            Implementation.vpmovusqb();
        }

        /// <inheritdoc />
        public void vpmovusqd()
        {
            Implementation.vpmovusqd();
        }

        /// <inheritdoc />
        public void vpmovusqw()
        {
            Implementation.vpmovusqw();
        }

        /// <inheritdoc />
        public void vpmovuswb()
        {
            Implementation.vpmovuswb();
        }

        /// <inheritdoc />
        public void vpmovw2m()
        {
            Implementation.vpmovw2m();
        }

        /// <inheritdoc />
        public void vpmovwb()
        {
            Implementation.vpmovwb();
        }

        /// <inheritdoc />
        public void vpmultishiftqb()
        {
            Implementation.vpmultishiftqb();
        }

        /// <inheritdoc />
        public void vprold()
        {
            Implementation.vprold();
        }

        /// <inheritdoc />
        public void vprolq()
        {
            Implementation.vprolq();
        }

        /// <inheritdoc />
        public void vprolvd()
        {
            Implementation.vprolvd();
        }

        /// <inheritdoc />
        public void vprolvq()
        {
            Implementation.vprolvq();
        }

        /// <inheritdoc />
        public void vprord()
        {
            Implementation.vprord();
        }

        /// <inheritdoc />
        public void vprorq()
        {
            Implementation.vprorq();
        }

        /// <inheritdoc />
        public void vprorvd()
        {
            Implementation.vprorvd();
        }

        /// <inheritdoc />
        public void vprorvq()
        {
            Implementation.vprorvq();
        }

        /// <inheritdoc />
        public void vpscatterdd()
        {
            Implementation.vpscatterdd();
        }

        /// <inheritdoc />
        public void vpscatterdq()
        {
            Implementation.vpscatterdq();
        }

        /// <inheritdoc />
        public void vpscatterqd()
        {
            Implementation.vpscatterqd();
        }

        /// <inheritdoc />
        public void vpscatterqq()
        {
            Implementation.vpscatterqq();
        }

        /// <inheritdoc />
        public void vpsllvd()
        {
            Implementation.vpsllvd();
        }

        /// <inheritdoc />
        public void vpsllvq()
        {
            Implementation.vpsllvq();
        }

        /// <inheritdoc />
        public void vpsllvw()
        {
            Implementation.vpsllvw();
        }

        /// <inheritdoc />
        public void vpsravd()
        {
            Implementation.vpsravd();
        }

        /// <inheritdoc />
        public void vpsravq()
        {
            Implementation.vpsravq();
        }

        /// <inheritdoc />
        public void vpsravw()
        {
            Implementation.vpsravw();
        }

        /// <inheritdoc />
        public void vpsrlvd()
        {
            Implementation.vpsrlvd();
        }

        /// <inheritdoc />
        public void vpsrlvq()
        {
            Implementation.vpsrlvq();
        }

        /// <inheritdoc />
        public void vpsrlvw()
        {
            Implementation.vpsrlvw();
        }

        /// <inheritdoc />
        public void vpternlogd()
        {
            Implementation.vpternlogd();
        }

        /// <inheritdoc />
        public void vpternlogq()
        {
            Implementation.vpternlogq();
        }

        /// <inheritdoc />
        public void vptestmb()
        {
            Implementation.vptestmb();
        }

        /// <inheritdoc />
        public void vptestmd()
        {
            Implementation.vptestmd();
        }

        /// <inheritdoc />
        public void vptestmq()
        {
            Implementation.vptestmq();
        }

        /// <inheritdoc />
        public void vptestmw()
        {
            Implementation.vptestmw();
        }

        /// <inheritdoc />
        public void vptestnmb()
        {
            Implementation.vptestnmb();
        }

        /// <inheritdoc />
        public void vptestnmd()
        {
            Implementation.vptestnmd();
        }

        /// <inheritdoc />
        public void vptestnmq()
        {
            Implementation.vptestnmq();
        }

        /// <inheritdoc />
        public void vptestnmw()
        {
            Implementation.vptestnmw();
        }

        /// <inheritdoc />
        public void vrangepd()
        {
            Implementation.vrangepd();
        }

        /// <inheritdoc />
        public void vrangeps()
        {
            Implementation.vrangeps();
        }

        /// <inheritdoc />
        public void vrangesd()
        {
            Implementation.vrangesd();
        }

        /// <inheritdoc />
        public void vrangess()
        {
            Implementation.vrangess();
        }

        /// <inheritdoc />
        public void vrcp14pd()
        {
            Implementation.vrcp14pd();
        }

        /// <inheritdoc />
        public void vrcp14ps()
        {
            Implementation.vrcp14ps();
        }

        /// <inheritdoc />
        public void vrcp14sd()
        {
            Implementation.vrcp14sd();
        }

        /// <inheritdoc />
        public void vrcp14ss()
        {
            Implementation.vrcp14ss();
        }

        /// <inheritdoc />
        public void vreducepd()
        {
            Implementation.vreducepd();
        }

        /// <inheritdoc />
        public void vreduceps()
        {
            Implementation.vreduceps();
        }

        /// <inheritdoc />
        public void vreducesd()
        {
            Implementation.vreducesd();
        }

        /// <inheritdoc />
        public void vreducess()
        {
            Implementation.vreducess();
        }

        /// <inheritdoc />
        public void vrndscalepd()
        {
            Implementation.vrndscalepd();
        }

        /// <inheritdoc />
        public void vrndscaleps()
        {
            Implementation.vrndscaleps();
        }

        /// <inheritdoc />
        public void vrndscalesd()
        {
            Implementation.vrndscalesd();
        }

        /// <inheritdoc />
        public void vrndscaless()
        {
            Implementation.vrndscaless();
        }

        /// <inheritdoc />
        public void vrsqrt14pd()
        {
            Implementation.vrsqrt14pd();
        }

        /// <inheritdoc />
        public void vrsqrt14ps()
        {
            Implementation.vrsqrt14ps();
        }

        /// <inheritdoc />
        public void vrsqrt14sd()
        {
            Implementation.vrsqrt14sd();
        }

        /// <inheritdoc />
        public void vrsqrt14ss()
        {
            Implementation.vrsqrt14ss();
        }

        /// <inheritdoc />
        public void vscalefpd()
        {
            Implementation.vscalefpd();
        }

        /// <inheritdoc />
        public void vscalefps()
        {
            Implementation.vscalefps();
        }

        /// <inheritdoc />
        public void vscalefsd()
        {
            Implementation.vscalefsd();
        }

        /// <inheritdoc />
        public void vscalefss()
        {
            Implementation.vscalefss();
        }

        /// <inheritdoc />
        public void vscatterdpd()
        {
            Implementation.vscatterdpd();
        }

        /// <inheritdoc />
        public void vscatterdps()
        {
            Implementation.vscatterdps();
        }

        /// <inheritdoc />
        public void vscatterqpd()
        {
            Implementation.vscatterqpd();
        }

        /// <inheritdoc />
        public void vscatterqps()
        {
            Implementation.vscatterqps();
        }

        /// <inheritdoc />
        public void vshuff32x4()
        {
            Implementation.vshuff32x4();
        }

        /// <inheritdoc />
        public void vshuff64x2()
        {
            Implementation.vshuff64x2();
        }

        /// <inheritdoc />
        public void vshufi32x4()
        {
            Implementation.vshufi32x4();
        }

        /// <inheritdoc />
        public void vshufi64x2()
        {
            Implementation.vshufi64x2();
        }

        /// <inheritdoc />
        public void vtestpd()
        {
            Implementation.vtestpd();
        }

        /// <inheritdoc />
        public void vtestps()
        {
            Implementation.vtestps();
        }

        /// <inheritdoc />
        public void vzeroall()
        {
            Implementation.vzeroall();
        }

        /// <inheritdoc />
        public void vzeroupper()
        {
            Implementation.vzeroupper();
        }

        /// <inheritdoc />
        public void wait()
        {
            Implementation.wait();
        }

        /// <inheritdoc />
        public void wbinvd()
        {
            Implementation.wbinvd();
        }

        /// <inheritdoc />
        public void wrfsbase()
        {
            Implementation.wrfsbase();
        }

        /// <inheritdoc />
        public void wrgsbase()
        {
            Implementation.wrgsbase();
        }

        /// <inheritdoc />
        public void wrmsr()
        {
            Implementation.wrmsr();
        }

        /// <inheritdoc />
        public void wrpkru()
        {
            Implementation.wrpkru();
        }

        /// <inheritdoc />
        public void xabort()
        {
            Implementation.xabort();
        }

        /// <inheritdoc />
        public void xacquire()
        {
            Implementation.xacquire();
        }

        /// <inheritdoc />
        public void xadd()
        {
            Implementation.xadd();
        }

        /// <inheritdoc />
        public void xbegin()
        {
            Implementation.xbegin();
        }

        /// <inheritdoc />
        public void xchg(ValueBase a, ValueBase b)
        {
            Implementation.xchg(a, b);
        }

        /// <inheritdoc />
        public void xend()
        {
            Implementation.xend();
        }

        /// <inheritdoc />
        public void xgetbv()
        {
            Implementation.xgetbv();
        }

        /// <inheritdoc />
        public void xlat()
        {
            Implementation.xlat();
        }

        /// <inheritdoc />
        public void xlatb()
        {
            Implementation.xlatb();
        }

        /// <inheritdoc />
        public void xlatb_a16()
        {
            Implementation.xlatb_a16();
        }

        /// <inheritdoc />
        public void xor(ValueBase dst, ValueBase src)
        {
            Implementation.xor(dst, src);
        }

        /// <inheritdoc />
        public void xorpd()
        {
            Implementation.xorpd();
        }

        /// <inheritdoc />
        public void xorps()
        {
            Implementation.xorps();
        }

        /// <inheritdoc />
        public void xrelease()
        {
            Implementation.xrelease();
        }

        /// <inheritdoc />
        public void xrstor()
        {
            Implementation.xrstor();
        }

        /// <inheritdoc />
        public void xrstors()
        {
            Implementation.xrstors();
        }

        /// <inheritdoc />
        public void xsave()
        {
            Implementation.xsave();
        }

        /// <inheritdoc />
        public void xsavec()
        {
            Implementation.xsavec();
        }

        /// <inheritdoc />
        public void xsaveopt()
        {
            Implementation.xsaveopt();
        }

        /// <inheritdoc />
        public void xsaves()
        {
            Implementation.xsaves();
        }

        /// <inheritdoc />
        public void xsetbv()
        {
            Implementation.xsetbv();
        }

        /// <inheritdoc />
        public void xtest()
        {
            Implementation.xtest();
        }

        #endregion
    }
}

#pragma warning restore IDE1006 // Naming Styles
