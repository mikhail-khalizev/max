// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
#pragma warning disable IDE1006 // Naming Styles

using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.Abstractions
{
    public class BridgeProcessor : IProcessor
    {
        public IProcessor Implementation { get; set; }

        public BridgeProcessor(IProcessor implementation)
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

        #endregion

        #region Memory

        public int MemorySize => Implementation.MemorySize;

        public MemoryAccess memb_a16 => Implementation.memb_a16;
        public MemoryAccess memw_a16 => Implementation.memw_a16;
        public MemoryAccess memd_a16 => Implementation.memd_a16;
        public MemoryAccess memq_a16 => Implementation.memq_a16;

        public MemoryAccess memb_a32 => Implementation.memb_a32;
        public MemoryAccess memw_a32 => Implementation.memw_a32;
        public MemoryAccess memd_a32 => Implementation.memd_a32;
        public MemoryAccess memq_a32 => Implementation.memq_a32;

        #endregion

        #region C# emulate specific

        /// <inheritdoc />
        public void ii(Address address, uint length) => Implementation.ii(address, length);

        /// <inheritdoc />
        public void Manage(params object[] blocks) => Implementation.Manage(blocks);

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

        /// <inheritdoc />
        public void aam()
        {
            Implementation.aam();
        }

        /// <inheritdoc />
        public void aas()
        {
            Implementation.aas();
        }

        /// <inheritdoc />
        public void adc()
        {
            Implementation.adc();
        }

        /// <inheritdoc />
        public void adcx()
        {
            Implementation.adcx();
        }

        /// <inheritdoc />
        public void add()
        {
            Implementation.add();
        }

        /// <inheritdoc />
        public void addpd_fp()
        {
            Implementation.addpd_fp();
        }

        /// <inheritdoc />
        public void addps_fp()
        {
            Implementation.addps_fp();
        }

        /// <inheritdoc />
        public void addsd_fp()
        {
            Implementation.addsd_fp();
        }

        /// <inheritdoc />
        public void addss_fp()
        {
            Implementation.addss_fp();
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
        public void and()
        {
            Implementation.and();
        }

        /// <inheritdoc />
        public void andn()
        {
            Implementation.andn();
        }

        /// <inheritdoc />
        public void andnpd_fp()
        {
            Implementation.andnpd_fp();
        }

        /// <inheritdoc />
        public void andnps_fp()
        {
            Implementation.andnps_fp();
        }

        /// <inheritdoc />
        public void andpd_fp()
        {
            Implementation.andpd_fp();
        }

        /// <inheritdoc />
        public void andps_fp()
        {
            Implementation.andps_fp();
        }

        /// <inheritdoc />
        public void arpl()
        {
            Implementation.arpl();
        }

        /// <inheritdoc />
        public void bextr()
        {
            Implementation.bextr();
        }

        /// <inheritdoc />
        public void blendpd_fp()
        {
            Implementation.blendpd_fp();
        }

        /// <inheritdoc />
        public void blendps_fp()
        {
            Implementation.blendps_fp();
        }

        /// <inheritdoc />
        public void blendvpd_fp()
        {
            Implementation.blendvpd_fp();
        }

        /// <inheritdoc />
        public void blendvps_fp()
        {
            Implementation.blendvps_fp();
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
        public void bt()
        {
            Implementation.bt();
        }

        /// <inheritdoc />
        public void btc()
        {
            Implementation.btc();
        }

        /// <inheritdoc />
        public void btr()
        {
            Implementation.btr();
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
        public void call()
        {
            Implementation.call();
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
        public void cmp()
        {
            Implementation.cmp();
        }

        /// <inheritdoc />
        public void cmppd_fp()
        {
            Implementation.cmppd_fp();
        }

        /// <inheritdoc />
        public void cmpps_fp()
        {
            Implementation.cmpps_fp();
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
        public void cmpss_fp()
        {
            Implementation.cmpss_fp();
        }

        /// <inheritdoc />
        public void cmpsw()
        {
            Implementation.cmpsw();
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
        public void comisd_fp()
        {
            Implementation.comisd_fp();
        }

        /// <inheritdoc />
        public void comiss_fp()
        {
            Implementation.comiss_fp();
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
        public void cvtdq2pd_fp()
        {
            Implementation.cvtdq2pd_fp();
        }

        /// <inheritdoc />
        public void cvtdq2ps_fp()
        {
            Implementation.cvtdq2ps_fp();
        }

        /// <inheritdoc />
        public void cvtpd2dq_fp()
        {
            Implementation.cvtpd2dq_fp();
        }

        /// <inheritdoc />
        public void cvtpd2pi()
        {
            Implementation.cvtpd2pi();
        }

        /// <inheritdoc />
        public void cvtpd2ps_fp()
        {
            Implementation.cvtpd2ps_fp();
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
        public void cvtps2dq_fp()
        {
            Implementation.cvtps2dq_fp();
        }

        /// <inheritdoc />
        public void cvtps2pd_fp()
        {
            Implementation.cvtps2pd_fp();
        }

        /// <inheritdoc />
        public void cvtps2pi()
        {
            Implementation.cvtps2pi();
        }

        /// <inheritdoc />
        public void cvtsd2si_fp()
        {
            Implementation.cvtsd2si_fp();
        }

        /// <inheritdoc />
        public void cvtsd2ss_fp()
        {
            Implementation.cvtsd2ss_fp();
        }

        /// <inheritdoc />
        public void cvtsi2sd_fp()
        {
            Implementation.cvtsi2sd_fp();
        }

        /// <inheritdoc />
        public void cvtsi2ss_fp()
        {
            Implementation.cvtsi2ss_fp();
        }

        /// <inheritdoc />
        public void cvtss2sd_fp()
        {
            Implementation.cvtss2sd_fp();
        }

        /// <inheritdoc />
        public void cvtss2si_fp()
        {
            Implementation.cvtss2si_fp();
        }

        /// <inheritdoc />
        public void cvttpd2dq_fp()
        {
            Implementation.cvttpd2dq_fp();
        }

        /// <inheritdoc />
        public void cvttpd2pi()
        {
            Implementation.cvttpd2pi();
        }

        /// <inheritdoc />
        public void cvttps2dq_fp()
        {
            Implementation.cvttps2dq_fp();
        }

        /// <inheritdoc />
        public void cvttps2pi()
        {
            Implementation.cvttps2pi();
        }

        /// <inheritdoc />
        public void cvttsd2si_fp()
        {
            Implementation.cvttsd2si_fp();
        }

        /// <inheritdoc />
        public void cvttss2si_fp()
        {
            Implementation.cvttss2si_fp();
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
        public void dec()
        {
            Implementation.dec();
        }

        /// <inheritdoc />
        public void div()
        {
            Implementation.div();
        }

        /// <inheritdoc />
        public void divpd_fp()
        {
            Implementation.divpd_fp();
        }

        /// <inheritdoc />
        public void divps_fp()
        {
            Implementation.divps_fp();
        }

        /// <inheritdoc />
        public void divsd_fp()
        {
            Implementation.divsd_fp();
        }

        /// <inheritdoc />
        public void divss_fp()
        {
            Implementation.divss_fp();
        }

        /// <inheritdoc />
        public void dppd_fp()
        {
            Implementation.dppd_fp();
        }

        /// <inheritdoc />
        public void dpps_fp()
        {
            Implementation.dpps_fp();
        }

        /// <inheritdoc />
        public void emms()
        {
            Implementation.emms();
        }

        /// <inheritdoc />
        public void enter()
        {
            Implementation.enter();
        }

        /// <inheritdoc />
        public void extractps_fp()
        {
            Implementation.extractps_fp();
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
        public void fadd()
        {
            Implementation.fadd();
        }

        /// <inheritdoc />
        public void faddp()
        {
            Implementation.faddp();
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
        public void fcmovcc_fp()
        {
            Implementation.fcmovcc_fp();
        }

        /// <inheritdoc />
        public void fcom()
        {
            Implementation.fcom();
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
        public void fcomp()
        {
            Implementation.fcomp();
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
        public void fdiv()
        {
            Implementation.fdiv();
        }

        /// <inheritdoc />
        public void fdivp()
        {
            Implementation.fdivp();
        }

        /// <inheritdoc />
        public void fdivr()
        {
            Implementation.fdivr();
        }

        /// <inheritdoc />
        public void fdivrp()
        {
            Implementation.fdivrp();
        }

        /// <inheritdoc />
        public void ffree_fp()
        {
            Implementation.ffree_fp();
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
        public void fild()
        {
            Implementation.fild();
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
        public void finit_fp()
        {
            Implementation.finit_fp();
        }

        /// <inheritdoc />
        public void fist()
        {
            Implementation.fist();
        }

        /// <inheritdoc />
        public void fistp()
        {
            Implementation.fistp();
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
        public void fld()
        {
            Implementation.fld();
        }

        /// <inheritdoc />
        public void fld1()
        {
            Implementation.fld1();
        }

        /// <inheritdoc />
        public void fldcw()
        {
            Implementation.fldcw();
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
        public void fmul()
        {
            Implementation.fmul();
        }

        /// <inheritdoc />
        public void fmulp()
        {
            Implementation.fmulp();
        }

        /// <inheritdoc />
        public void fnclex()
        {
            Implementation.fnclex();
        }

        /// <inheritdoc />
        public void fninit_fp()
        {
            Implementation.fninit_fp();
        }

        /// <inheritdoc />
        public void fnop()
        {
            Implementation.fnop();
        }

        /// <inheritdoc />
        public void fnsave()
        {
            Implementation.fnsave();
        }

        /// <inheritdoc />
        public void fnstcw()
        {
            Implementation.fnstcw();
        }

        /// <inheritdoc />
        public void fnstenv()
        {
            Implementation.fnstenv();
        }

        /// <inheritdoc />
        public void fnstsw()
        {
            Implementation.fnstsw();
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
        public void fst()
        {
            Implementation.fst();
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
        public void fstp()
        {
            Implementation.fstp();
        }

        /// <inheritdoc />
        public void fstsw()
        {
            Implementation.fstsw();
        }

        /// <inheritdoc />
        public void fsub()
        {
            Implementation.fsub();
        }

        /// <inheritdoc />
        public void fsubp()
        {
            Implementation.fsubp();
        }

        /// <inheritdoc />
        public void fsubr()
        {
            Implementation.fsubr();
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
        public void fxam_fp()
        {
            Implementation.fxam_fp();
        }

        /// <inheritdoc />
        public void fxch()
        {
            Implementation.fxch();
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
        public void idiv()
        {
            Implementation.idiv();
        }

        /// <inheritdoc />
        public void imul()
        {
            Implementation.imul();
        }

        /// <inheritdoc />
        public void @in()
        {
            Implementation.@in();
        }

        /// <inheritdoc />
        public void inc()
        {
            Implementation.inc();
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
        public void insd()
        {
            Implementation.insd();
        }

        /// <inheritdoc />
        public void insertps_fp()
        {
            Implementation.insertps_fp();
        }

        /// <inheritdoc />
        public void insw()
        {
            Implementation.insw();
        }

        /// <inheritdoc />
        public void int_n()
        {
            Implementation.int_n();
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
        public void into()
        {
            Implementation.into();
        }

        /// <inheritdoc />
        public void invd()
        {
            Implementation.invd();
        }

        /// <inheritdoc />
        public void invlpg()
        {
            Implementation.invlpg();
        }

        /// <inheritdoc />
        public void invpcid()
        {
            Implementation.invpcid();
        }

        /// <inheritdoc />
        public void iret()
        {
            Implementation.iret();
        }

        /// <inheritdoc />
        public void iretd()
        {
            Implementation.iretd();
        }

        /// <inheritdoc />
        public void jmp()
        {
            Implementation.jmp();
        }

        /// <inheritdoc />
        public void jcc()
        {
            Implementation.jcc();
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
        public void lar()
        {
            Implementation.lar();
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
        public void lds()
        {
            Implementation.lds();
        }

        /// <inheritdoc />
        public void lea(Value.Value dst, MemoryValue src)
        {
            Implementation.lea(dst, src);
        }

        /// <inheritdoc />
        public void leave()
        {
            Implementation.leave();
        }

        /// <inheritdoc />
        public void les()
        {
            Implementation.les();
        }

        /// <inheritdoc />
        public void lfence()
        {
            Implementation.lfence();
        }

        /// <inheritdoc />
        public void lfs()
        {
            Implementation.lfs();
        }

        /// <inheritdoc />
        public void lgdt()
        {
            Implementation.lgdt();
        }

        /// <inheritdoc />
        public void lgs()
        {
            Implementation.lgs();
        }

        /// <inheritdoc />
        public void lidt()
        {
            Implementation.lidt();
        }

        /// <inheritdoc />
        public void lldt()
        {
            Implementation.lldt();
        }

        /// <inheritdoc />
        public void lmsw()
        {
            Implementation.lmsw();
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
        public void lodsd()
        {
            Implementation.lodsd();
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
        public void loop()
        {
            Implementation.loop();
        }

        /// <inheritdoc />
        public void loopcc()
        {
            Implementation.loopcc();
        }

        /// <inheritdoc />
        public void lsl()
        {
            Implementation.lsl();
        }

        /// <inheritdoc />
        public void lss()
        {
            Implementation.lss();
        }

        /// <inheritdoc />
        public void ltr()
        {
            Implementation.ltr();
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
        public void maxpd_fp()
        {
            Implementation.maxpd_fp();
        }

        /// <inheritdoc />
        public void maxps_fp()
        {
            Implementation.maxps_fp();
        }

        /// <inheritdoc />
        public void maxsd_fp()
        {
            Implementation.maxsd_fp();
        }

        /// <inheritdoc />
        public void maxss_fp()
        {
            Implementation.maxss_fp();
        }

        /// <inheritdoc />
        public void mfence()
        {
            Implementation.mfence();
        }

        /// <inheritdoc />
        public void minpd_fp()
        {
            Implementation.minpd_fp();
        }

        /// <inheritdoc />
        public void minps_fp()
        {
            Implementation.minps_fp();
        }

        /// <inheritdoc />
        public void minsd_fp()
        {
            Implementation.minsd_fp();
        }

        /// <inheritdoc />
        public void minss_fp()
        {
            Implementation.minss_fp();
        }

        /// <inheritdoc />
        public void monitor()
        {
            Implementation.monitor();
        }

        /// <inheritdoc />
        public void mov(Value.Value dst, Value.Value src)
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
        public void movapd_fp()
        {
            Implementation.movapd_fp();
        }

        /// <inheritdoc />
        public void movaps_fp()
        {
            Implementation.movaps_fp();
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
        public void movhlps_fp()
        {
            Implementation.movhlps_fp();
        }

        /// <inheritdoc />
        public void movhpd_fp()
        {
            Implementation.movhpd_fp();
        }

        /// <inheritdoc />
        public void movhps_fp()
        {
            Implementation.movhps_fp();
        }

        /// <inheritdoc />
        public void movlhps_fp()
        {
            Implementation.movlhps_fp();
        }

        /// <inheritdoc />
        public void movlpd_fp()
        {
            Implementation.movlpd_fp();
        }

        /// <inheritdoc />
        public void movlps_fp()
        {
            Implementation.movlps_fp();
        }

        /// <inheritdoc />
        public void movmskpd_fp()
        {
            Implementation.movmskpd_fp();
        }

        /// <inheritdoc />
        public void movmskps_fp()
        {
            Implementation.movmskps_fp();
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
        public void movntpd_fp()
        {
            Implementation.movntpd_fp();
        }

        /// <inheritdoc />
        public void movntps_fp()
        {
            Implementation.movntps_fp();
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
        public void movs()
        {
            Implementation.movs();
        }

        /// <inheritdoc />
        public void movsb()
        {
            Implementation.movsb();
        }

        /// <inheritdoc />
        public void movsd()
        {
            Implementation.movsd();
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
        public void movss_fp()
        {
            Implementation.movss_fp();
        }

        /// <inheritdoc />
        public void movsw()
        {
            Implementation.movsw();
        }

        /// <inheritdoc />
        public void movsx(Value.Value dst, Value.Value src)
        {
            Implementation.movsx(dst, src);
        }

        /// <inheritdoc />
        public void movsxd()
        {
            Implementation.movsxd();
        }

        /// <inheritdoc />
        public void movupd_fp()
        {
            Implementation.movupd_fp();
        }

        /// <inheritdoc />
        public void movups_fp()
        {
            Implementation.movups_fp();
        }

        /// <inheritdoc />
        public void movzx(Value.Value dst, Value.Value src)
        {
            Implementation.movzx(dst, src);
        }

        /// <inheritdoc />
        public void mpsadbw()
        {
            Implementation.mpsadbw();
        }

        /// <inheritdoc />
        public void mul()
        {
            Implementation.mul();
        }

        /// <inheritdoc />
        public void mulpd_fp()
        {
            Implementation.mulpd_fp();
        }

        /// <inheritdoc />
        public void mulps_fp()
        {
            Implementation.mulps_fp();
        }

        /// <inheritdoc />
        public void mulsd_fp()
        {
            Implementation.mulsd_fp();
        }

        /// <inheritdoc />
        public void mulss_fp()
        {
            Implementation.mulss_fp();
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
        public void neg()
        {
            Implementation.neg();
        }

        /// <inheritdoc />
        public void nop()
        {
            Implementation.nop();
        }

        /// <inheritdoc />
        public void not()
        {
            Implementation.not();
        }

        /// <inheritdoc />
        public void or()
        {
            Implementation.or();
        }

        /// <inheritdoc />
        public void orpd_fp()
        {
            Implementation.orpd_fp();
        }

        /// <inheritdoc />
        public void orps_fp()
        {
            Implementation.orps_fp();
        }

        /// <inheritdoc />
        public void @out()
        {
            Implementation.@out();
        }

        /// <inheritdoc />
        public void outs()
        {
            Implementation.outs();
        }

        /// <inheritdoc />
        public void outsb()
        {
            Implementation.outsb();
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
        public ushort popw(Value.Value d = null)
        {
            return Implementation.popw(d);
        }

        /// <inheritdoc />
        public uint popd(Value.Value d = null)
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
        public void popf()
        {
            Implementation.popf();
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
        public void pushw(Value.Value s)
        {
            Implementation.pushw(s);
        }

        /// <inheritdoc />
        public void pushd(Value.Value s)
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
        public void rcl(Value.Value dst, int count)
        {
            Implementation.rcl(dst, count);
        }

        /// <inheritdoc />
        public void rcpps_fp()
        {
            Implementation.rcpps_fp();
        }

        /// <inheritdoc />
        public void rcpss_fp()
        {
            Implementation.rcpss_fp();
        }

        /// <inheritdoc />
        public void rcr(Value.Value dst, int count)
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
        public void rep()
        {
            Implementation.rep();
        }

        /// <inheritdoc />
        public void repe()
        {
            Implementation.repe();
        }

        /// <inheritdoc />
        public void repne()
        {
            Implementation.repne();
        }

        /// <inheritdoc />
        public void repnz()
        {
            Implementation.repnz();
        }

        /// <inheritdoc />
        public void repz()
        {
            Implementation.repz();
        }

        public void retw()
        {
            Implementation.retw();
        }

        public void retd()
        {
            Implementation.retd();
        }

        public void retfw()
        {
            Implementation.retfw();
        }

        public void retfd()
        {
            Implementation.retfd();
        }
        
        /// <inheritdoc />
        public void rol(Value.Value dst, int count)
        {
            Implementation.rol(dst, count);
        }

        /// <inheritdoc />
        public void ror(Value.Value dst, int count)
        {
            Implementation.ror(dst, count);
        }

        /// <inheritdoc />
        public void rorx()
        {
            Implementation.rorx();
        }

        /// <inheritdoc />
        public void roundpd_fp()
        {
            Implementation.roundpd_fp();
        }

        /// <inheritdoc />
        public void roundps_fp()
        {
            Implementation.roundps_fp();
        }

        /// <inheritdoc />
        public void roundsd_fp()
        {
            Implementation.roundsd_fp();
        }

        /// <inheritdoc />
        public void roundss_fp()
        {
            Implementation.roundss_fp();
        }

        /// <inheritdoc />
        public void rsm()
        {
            Implementation.rsm();
        }

        /// <inheritdoc />
        public void rsqrtps_fp()
        {
            Implementation.rsqrtps_fp();
        }

        /// <inheritdoc />
        public void rsqrtss_fp()
        {
            Implementation.rsqrtss_fp();
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
        public void sar(Value.Value dst, int count)
        {
            Implementation.sar(dst, count);
        }

        /// <inheritdoc />
        public void sarx()
        {
            Implementation.sarx();
        }

        /// <inheritdoc />
        public void sbb()
        {
            Implementation.sbb();
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
        public void scasd()
        {
            Implementation.scasd();
        }

        /// <inheritdoc />
        public void scasw()
        {
            Implementation.scasw();
        }

        /// <inheritdoc />
        public void setcc()
        {
            Implementation.setcc();
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
        public void shl(Value.Value dst, int count)
        {
            Implementation.shl(dst, count);
        }

        /// <inheritdoc />
        public void shld(Value.Value dst, Value.Value src, int count)
        {
            Implementation.shld(dst, src, count);
        }

        /// <inheritdoc />
        public void shlx()
        {
            Implementation.shlx();
        }

        /// <inheritdoc />
        public void shr(Value.Value dst, int count)
        {
            Implementation.shr(dst, count);
        }

        /// <inheritdoc />
        public void shrd(Value.Value dst, Value.Value src, int count)
        {
            Implementation.shrd(dst, src, count);
        }

        /// <inheritdoc />
        public void shrx()
        {
            Implementation.shrx();
        }

        /// <inheritdoc />
        public void shufpd_fp()
        {
            Implementation.shufpd_fp();
        }

        /// <inheritdoc />
        public void shufps_fp()
        {
            Implementation.shufps_fp();
        }

        /// <inheritdoc />
        public void sidt()
        {
            Implementation.sidt();
        }

        /// <inheritdoc />
        public void sldt()
        {
            Implementation.sldt();
        }

        /// <inheritdoc />
        public void smsw()
        {
            Implementation.smsw();
        }

        /// <inheritdoc />
        public void sqrtpd_fp()
        {
            Implementation.sqrtpd_fp();
        }

        /// <inheritdoc />
        public void sqrtps_fp()
        {
            Implementation.sqrtps_fp();
        }

        /// <inheritdoc />
        public void sqrtsd_fp()
        {
            Implementation.sqrtsd_fp();
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
        public void stosd()
        {
            Implementation.stosd();
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
        public void str()
        {
            Implementation.str();
        }

        /// <inheritdoc />
        public void sub(Value.Value dst, Value.Value val)
        {
            Implementation.sub(dst, val);
        }

        /// <inheritdoc />
        public void subpd_fp()
        {
            Implementation.subpd_fp();
        }

        /// <inheritdoc />
        public void subps_fp()
        {
            Implementation.subps_fp();
        }

        /// <inheritdoc />
        public void subsd_fp()
        {
            Implementation.subsd_fp();
        }

        /// <inheritdoc />
        public void subss_fp()
        {
            Implementation.subss_fp();
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
        public void test()
        {
            Implementation.test();
        }

        /// <inheritdoc />
        public void tzcnt()
        {
            Implementation.tzcnt();
        }

        /// <inheritdoc />
        public void ucomisd_fp()
        {
            Implementation.ucomisd_fp();
        }

        /// <inheritdoc />
        public void ucomiss_fp()
        {
            Implementation.ucomiss_fp();
        }

        /// <inheritdoc />
        public void ud()
        {
            Implementation.ud();
        }

        /// <inheritdoc />
        public void unpckhpd_fp()
        {
            Implementation.unpckhpd_fp();
        }

        /// <inheritdoc />
        public void unpckhps_fp()
        {
            Implementation.unpckhps_fp();
        }

        /// <inheritdoc />
        public void unpcklpd_fp()
        {
            Implementation.unpcklpd_fp();
        }

        /// <inheritdoc />
        public void unpcklps_fp()
        {
            Implementation.unpcklps_fp();
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
        public void vbroadcast_fp()
        {
            Implementation.vbroadcast_fp();
        }

        /// <inheritdoc />
        public void vcompresspd_fp()
        {
            Implementation.vcompresspd_fp();
        }

        /// <inheritdoc />
        public void vcompressps_fp()
        {
            Implementation.vcompressps_fp();
        }

        /// <inheritdoc />
        public void vcvtpd2qq_fp()
        {
            Implementation.vcvtpd2qq_fp();
        }

        /// <inheritdoc />
        public void vcvtpd2udq_fp()
        {
            Implementation.vcvtpd2udq_fp();
        }

        /// <inheritdoc />
        public void vcvtpd2uqq_fp()
        {
            Implementation.vcvtpd2uqq_fp();
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
        public void vcvtps2qq_fp()
        {
            Implementation.vcvtps2qq_fp();
        }

        /// <inheritdoc />
        public void vcvtps2udq_fp()
        {
            Implementation.vcvtps2udq_fp();
        }

        /// <inheritdoc />
        public void vcvtps2uqq_fp()
        {
            Implementation.vcvtps2uqq_fp();
        }

        /// <inheritdoc />
        public void vcvtqq2pd_fp()
        {
            Implementation.vcvtqq2pd_fp();
        }

        /// <inheritdoc />
        public void vcvtqq2ps_fp()
        {
            Implementation.vcvtqq2ps_fp();
        }

        /// <inheritdoc />
        public void vcvtsd2usi_fp()
        {
            Implementation.vcvtsd2usi_fp();
        }

        /// <inheritdoc />
        public void vcvtss2usi_fp()
        {
            Implementation.vcvtss2usi_fp();
        }

        /// <inheritdoc />
        public void vcvttpd2qq_fp()
        {
            Implementation.vcvttpd2qq_fp();
        }

        /// <inheritdoc />
        public void vcvttpd2udq_fp()
        {
            Implementation.vcvttpd2udq_fp();
        }

        /// <inheritdoc />
        public void vcvttpd2uqq_fp()
        {
            Implementation.vcvttpd2uqq_fp();
        }

        /// <inheritdoc />
        public void vcvttps2qq_fp()
        {
            Implementation.vcvttps2qq_fp();
        }

        /// <inheritdoc />
        public void vcvttps2udq_fp()
        {
            Implementation.vcvttps2udq_fp();
        }

        /// <inheritdoc />
        public void vcvttps2uqq_fp()
        {
            Implementation.vcvttps2uqq_fp();
        }

        /// <inheritdoc />
        public void vcvttsd2usi_fp()
        {
            Implementation.vcvttsd2usi_fp();
        }

        /// <inheritdoc />
        public void vcvttss2usi_fp()
        {
            Implementation.vcvttss2usi_fp();
        }

        /// <inheritdoc />
        public void vcvtudq2pd_fp()
        {
            Implementation.vcvtudq2pd_fp();
        }

        /// <inheritdoc />
        public void vcvtudq2ps_fp()
        {
            Implementation.vcvtudq2ps_fp();
        }

        /// <inheritdoc />
        public void vcvtuqq2pd_fp()
        {
            Implementation.vcvtuqq2pd_fp();
        }

        /// <inheritdoc />
        public void vcvtuqq2ps_fp()
        {
            Implementation.vcvtuqq2ps_fp();
        }

        /// <inheritdoc />
        public void vcvtusi2sd_fp()
        {
            Implementation.vcvtusi2sd_fp();
        }

        /// <inheritdoc />
        public void vcvtusi2ss_fp()
        {
            Implementation.vcvtusi2ss_fp();
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
        public void vexpandpd_fp()
        {
            Implementation.vexpandpd_fp();
        }

        /// <inheritdoc />
        public void vexpandps_fp()
        {
            Implementation.vexpandps_fp();
        }

        /// <inheritdoc />
        public void vextractf128_fp()
        {
            Implementation.vextractf128_fp();
        }

        /// <inheritdoc />
        public void vextractf32x4_fp()
        {
            Implementation.vextractf32x4_fp();
        }

        /// <inheritdoc />
        public void vextractf32x8_fp()
        {
            Implementation.vextractf32x8_fp();
        }

        /// <inheritdoc />
        public void vextractf64x2_fp()
        {
            Implementation.vextractf64x2_fp();
        }

        /// <inheritdoc />
        public void vextractf64x4_fp()
        {
            Implementation.vextractf64x4_fp();
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
        public void vfmadd132pd_fp()
        {
            Implementation.vfmadd132pd_fp();
        }

        /// <inheritdoc />
        public void vfmadd132ps_fp()
        {
            Implementation.vfmadd132ps_fp();
        }

        /// <inheritdoc />
        public void vfmadd132sd_fp()
        {
            Implementation.vfmadd132sd_fp();
        }

        /// <inheritdoc />
        public void vfmadd132ss_fp()
        {
            Implementation.vfmadd132ss_fp();
        }

        /// <inheritdoc />
        public void vfmadd213pd_fp()
        {
            Implementation.vfmadd213pd_fp();
        }

        /// <inheritdoc />
        public void vfmadd213ps_fp()
        {
            Implementation.vfmadd213ps_fp();
        }

        /// <inheritdoc />
        public void vfmadd213sd_fp()
        {
            Implementation.vfmadd213sd_fp();
        }

        /// <inheritdoc />
        public void vfmadd213ss_fp()
        {
            Implementation.vfmadd213ss_fp();
        }

        /// <inheritdoc />
        public void vfmadd231pd_fp()
        {
            Implementation.vfmadd231pd_fp();
        }

        /// <inheritdoc />
        public void vfmadd231ps_fp()
        {
            Implementation.vfmadd231ps_fp();
        }

        /// <inheritdoc />
        public void vfmadd231sd_fp()
        {
            Implementation.vfmadd231sd_fp();
        }

        /// <inheritdoc />
        public void vfmadd231ss_fp()
        {
            Implementation.vfmadd231ss_fp();
        }

        /// <inheritdoc />
        public void vfmaddsub132pd_fp()
        {
            Implementation.vfmaddsub132pd_fp();
        }

        /// <inheritdoc />
        public void vfmaddsub132ps_fp()
        {
            Implementation.vfmaddsub132ps_fp();
        }

        /// <inheritdoc />
        public void vfmaddsub213pd_fp()
        {
            Implementation.vfmaddsub213pd_fp();
        }

        /// <inheritdoc />
        public void vfmaddsub213ps_fp()
        {
            Implementation.vfmaddsub213ps_fp();
        }

        /// <inheritdoc />
        public void vfmaddsub231pd_fp()
        {
            Implementation.vfmaddsub231pd_fp();
        }

        /// <inheritdoc />
        public void vfmaddsub231ps_fp()
        {
            Implementation.vfmaddsub231ps_fp();
        }

        /// <inheritdoc />
        public void vfmsub132pd_fp()
        {
            Implementation.vfmsub132pd_fp();
        }

        /// <inheritdoc />
        public void vfmsub132ps_fp()
        {
            Implementation.vfmsub132ps_fp();
        }

        /// <inheritdoc />
        public void vfmsub132sd_fp()
        {
            Implementation.vfmsub132sd_fp();
        }

        /// <inheritdoc />
        public void vfmsub132ss_fp()
        {
            Implementation.vfmsub132ss_fp();
        }

        /// <inheritdoc />
        public void vfmsub213pd_fp()
        {
            Implementation.vfmsub213pd_fp();
        }

        /// <inheritdoc />
        public void vfmsub213ps_fp()
        {
            Implementation.vfmsub213ps_fp();
        }

        /// <inheritdoc />
        public void vfmsub213sd_fp()
        {
            Implementation.vfmsub213sd_fp();
        }

        /// <inheritdoc />
        public void vfmsub213ss_fp()
        {
            Implementation.vfmsub213ss_fp();
        }

        /// <inheritdoc />
        public void vfmsub231pd_fp()
        {
            Implementation.vfmsub231pd_fp();
        }

        /// <inheritdoc />
        public void vfmsub231ps_fp()
        {
            Implementation.vfmsub231ps_fp();
        }

        /// <inheritdoc />
        public void vfmsub231sd_fp()
        {
            Implementation.vfmsub231sd_fp();
        }

        /// <inheritdoc />
        public void vfmsub231ss_fp()
        {
            Implementation.vfmsub231ss_fp();
        }

        /// <inheritdoc />
        public void vfmsubadd132pd_fp()
        {
            Implementation.vfmsubadd132pd_fp();
        }

        /// <inheritdoc />
        public void vfmsubadd132ps_fp()
        {
            Implementation.vfmsubadd132ps_fp();
        }

        /// <inheritdoc />
        public void vfmsubadd213pd_fp()
        {
            Implementation.vfmsubadd213pd_fp();
        }

        /// <inheritdoc />
        public void vfmsubadd213ps_fp()
        {
            Implementation.vfmsubadd213ps_fp();
        }

        /// <inheritdoc />
        public void vfmsubadd231pd_fp()
        {
            Implementation.vfmsubadd231pd_fp();
        }

        /// <inheritdoc />
        public void vfmsubadd231ps_fp()
        {
            Implementation.vfmsubadd231ps_fp();
        }

        /// <inheritdoc />
        public void vfnmadd132pd_fp()
        {
            Implementation.vfnmadd132pd_fp();
        }

        /// <inheritdoc />
        public void vfnmadd132ps_fp()
        {
            Implementation.vfnmadd132ps_fp();
        }

        /// <inheritdoc />
        public void vfnmadd132sd_fp()
        {
            Implementation.vfnmadd132sd_fp();
        }

        /// <inheritdoc />
        public void vfnmadd132ss_fp()
        {
            Implementation.vfnmadd132ss_fp();
        }

        /// <inheritdoc />
        public void vfnmadd213pd_fp()
        {
            Implementation.vfnmadd213pd_fp();
        }

        /// <inheritdoc />
        public void vfnmadd213ps_fp()
        {
            Implementation.vfnmadd213ps_fp();
        }

        /// <inheritdoc />
        public void vfnmadd213sd_fp()
        {
            Implementation.vfnmadd213sd_fp();
        }

        /// <inheritdoc />
        public void vfnmadd213ss_fp()
        {
            Implementation.vfnmadd213ss_fp();
        }

        /// <inheritdoc />
        public void vfnmadd231pd_fp()
        {
            Implementation.vfnmadd231pd_fp();
        }

        /// <inheritdoc />
        public void vfnmadd231ps_fp()
        {
            Implementation.vfnmadd231ps_fp();
        }

        /// <inheritdoc />
        public void vfnmadd231sd_fp()
        {
            Implementation.vfnmadd231sd_fp();
        }

        /// <inheritdoc />
        public void vfnmadd231ss_fp()
        {
            Implementation.vfnmadd231ss_fp();
        }

        /// <inheritdoc />
        public void vfnmsub132pd_fp()
        {
            Implementation.vfnmsub132pd_fp();
        }

        /// <inheritdoc />
        public void vfnmsub132ps_fp()
        {
            Implementation.vfnmsub132ps_fp();
        }

        /// <inheritdoc />
        public void vfnmsub132sd_fp()
        {
            Implementation.vfnmsub132sd_fp();
        }

        /// <inheritdoc />
        public void vfnmsub132ss_fp()
        {
            Implementation.vfnmsub132ss_fp();
        }

        /// <inheritdoc />
        public void vfnmsub213pd_fp()
        {
            Implementation.vfnmsub213pd_fp();
        }

        /// <inheritdoc />
        public void vfnmsub213ps_fp()
        {
            Implementation.vfnmsub213ps_fp();
        }

        /// <inheritdoc />
        public void vfnmsub213sd_fp()
        {
            Implementation.vfnmsub213sd_fp();
        }

        /// <inheritdoc />
        public void vfnmsub213ss_fp()
        {
            Implementation.vfnmsub213ss_fp();
        }

        /// <inheritdoc />
        public void vfnmsub231pd_fp()
        {
            Implementation.vfnmsub231pd_fp();
        }

        /// <inheritdoc />
        public void vfnmsub231ps_fp()
        {
            Implementation.vfnmsub231ps_fp();
        }

        /// <inheritdoc />
        public void vfnmsub231sd_fp()
        {
            Implementation.vfnmsub231sd_fp();
        }

        /// <inheritdoc />
        public void vfnmsub231ss_fp()
        {
            Implementation.vfnmsub231ss_fp();
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
        public void vinsertf128_fp()
        {
            Implementation.vinsertf128_fp();
        }

        /// <inheritdoc />
        public void vinsertf32x4_fp()
        {
            Implementation.vinsertf32x4_fp();
        }

        /// <inheritdoc />
        public void vinsertf32x8_fp()
        {
            Implementation.vinsertf32x8_fp();
        }

        /// <inheritdoc />
        public void vinsertf64x2_fp()
        {
            Implementation.vinsertf64x2_fp();
        }

        /// <inheritdoc />
        public void vinsertf64x4_fp()
        {
            Implementation.vinsertf64x4_fp();
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
        public void vperm2f128_fp()
        {
            Implementation.vperm2f128_fp();
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
        public void vpermilpd_fp()
        {
            Implementation.vpermilpd_fp();
        }

        /// <inheritdoc />
        public void vpermilps_fp()
        {
            Implementation.vpermilps_fp();
        }

        /// <inheritdoc />
        public void vpermpd_fp()
        {
            Implementation.vpermpd_fp();
        }

        /// <inheritdoc />
        public void vpermps_fp()
        {
            Implementation.vpermps_fp();
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
        public void xchg()
        {
            Implementation.xchg();
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
        public void xor()
        {
            Implementation.xor();
        }

        /// <inheritdoc />
        public void xorpd_fp()
        {
            Implementation.xorpd_fp();
        }

        /// <inheritdoc />
        public void xorps_fp()
        {
            Implementation.xorps_fp();
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
