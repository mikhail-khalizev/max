using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_d67c-efb55223")]
        public void /* sys */ Method_1016_d67c()
        {
            ii(0x1016_d67c, 1); push(ebx);                              /* push ebx */
            ii(0x1016_d67d, 1); push(ecx);                              /* push ecx */
            ii(0x1016_d67e, 1); push(edx);                              /* push edx */
            ii(0x1016_d67f, 1); push(esi);                              /* push esi */
            ii(0x1016_d680, 1); push(edi);                              /* push edi */
            ii(0x1016_d681, 1); push(ebp);                              /* push ebp */
            ii(0x1016_d682, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_d685, 4); mov(edx, memd[ss, esp + 0x2c]);         /* mov edx, [esp+0x2c] */
            ii(0x1016_d689, 6); mov(memd[ds, 0x101b_dea8], edx);        /* mov [0x101bdea8], edx */
            ii(0x1016_d68f, 4); mov(edx, memd[ss, esp + 0x30]);         /* mov edx, [esp+0x30] */
            ii(0x1016_d693, 6); mov(memd[ds, 0x101b_deac], edx);        /* mov [0x101bdeac], edx */
            ii(0x1016_d699, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_d69b, 5); mov(edi, 0x404f_8000);                  /* mov edi, 0x404f8000 */
            ii(0x1016_d6a0, 4); mov(memd[ss, esp + 8], edx);            /* mov [esp+0x8], edx */
        l_0x1016_d6a4:
            ii(0x1016_d6a4, 6); mov(ebx, memd[ds, 0x101b_deac]);        /* mov ebx, [0x101bdeac] */
            ii(0x1016_d6aa, 1); push(ebx);                              /* push ebx */
            ii(0x1016_d6ab, 6); mov(ecx, memd[ds, 0x101b_dea8]);        /* mov ecx, [0x101bdea8] */
            ii(0x1016_d6b1, 1); push(ecx);                              /* push ecx */
            ii(0x1016_d6b2, 4); fild(memd[ss, esp + 0x10]);             /* fild dword [esp+0x10] */
            ii(0x1016_d6b6, 3); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1016_d6b9, 3); fstp(memq[ss, esp]);                    /* fstp qword [esp] */
            ii(0x1016_d6bc, 5); call(/* sys */ 0x1016_c5f6, -0x10cb);   /* call 0x1016c5f6 */
            ii(0x1016_d6c1, 3); fst(memq[ss, esp]);                     /* fst qword [esp] */
            ii(0x1016_d6c4, 6); fcomp(memq[ds, 0x101b_2e6c]);           /* fcomp qword [0x101b2e6c] */
            ii(0x1016_d6ca, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1016_d6cc, 1); sahf();                                 /* sahf */
            ii(0x1016_d6cd, 2); if(jbe(0x1016_d6d8, 9)) goto l_0x1016_d6d8; /* jbe 0x1016d6d8 */
            ii(0x1016_d6cf, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1016_d6d1, 4); mov(memd[ss, esp + 4], edi);            /* mov [esp+0x4], edi */
            ii(0x1016_d6d5, 3); mov(memd[ss, esp], esi);                /* mov [esp], esi */
        l_0x1016_d6d8:
            ii(0x1016_d6d8, 2); fldz();                                 /* fldz */
            ii(0x1016_d6da, 3); fcomp(memq[ss, esp]);                   /* fcomp qword [esp] */
            ii(0x1016_d6dd, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1016_d6df, 1); sahf();                                 /* sahf */
            ii(0x1016_d6e0, 2); if(jbe(0x1016_d6eb, 9)) goto l_0x1016_d6eb; /* jbe 0x1016d6eb */
            ii(0x1016_d6e2, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1016_d6e4, 3); mov(memd[ss, esp], ebp);                /* mov [esp], ebp */
            ii(0x1016_d6e7, 4); mov(memd[ss, esp + 4], ebp);            /* mov [esp+0x4], ebp */
        l_0x1016_d6eb:
            ii(0x1016_d6eb, 3); fld(memq[ss, esp]);                     /* fld qword [esp] */
            ii(0x1016_d6ee, 4); mov(edx, memd[ss, esp + 8]);            /* mov edx, [esp+0x8] */
            ii(0x1016_d6f2, 5); call(Definitions.sys_round, -0x7679);   /* call 0x1016607e */
            ii(0x1016_d6f7, 4); fistp(memd[ss, esp + 0xc]);             /* fistp dword [esp+0xc] */
            ii(0x1016_d6fb, 1); inc(edx);                               /* inc edx */
            ii(0x1016_d6fc, 4); mov(al, memb[ss, esp + 0xc]);           /* mov al, [esp+0xc] */
            ii(0x1016_d700, 4); mov(memd[ss, esp + 8], edx);            /* mov [esp+0x8], edx */
            ii(0x1016_d704, 6); mov(memb[ds, edx + 0x101c_ffdf], al);   /* mov [edx+0x101cffdf], al */
            ii(0x1016_d70a, 3); cmp(edx, 0x40);                         /* cmp edx, 0x40 */
            ii(0x1016_d70d, 2); if(jl(0x1016_d6a4, -0x6b)) goto l_0x1016_d6a4; /* jl 0x1016d6a4 */
            ii(0x1016_d70f, 5); mov(eax, 0x101c_fce0);                  /* mov eax, 0x101cfce0 */
            ii(0x1016_d714, 5); call(Definitions.sys_display_apply_palette, -0xb5d); /* call 0x1016cbbc */
            ii(0x1016_d719, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_d71c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_d71d, 1); pop(edi);                               /* pop edi */
            ii(0x1016_d71e, 1); pop(esi);                               /* pop esi */
            ii(0x1016_d71f, 1); pop(edx);                               /* pop edx */
            ii(0x1016_d720, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_d721, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_d722, 3); ret(8);                                 /* ret 0x8 */
        }
    }
}
