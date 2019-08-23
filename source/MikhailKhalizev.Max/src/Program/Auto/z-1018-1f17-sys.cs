using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1f17-c01c873f")]
        public void /* sys */ Method_1018_1f17()
        {
            ii(0x1018_1f17, 1); push(ebp);                              /* push ebp */
            ii(0x1018_1f18, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_1f1a, 1); push(eax);                              /* push eax */
            ii(0x1018_1f1b, 1); push(ebx);                              /* push ebx */
            ii(0x1018_1f1c, 1); push(edx);                              /* push edx */
            ii(0x1018_1f1d, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1018_1f20, 3); mov(dl, memb[ss, ebp + 0x10]);          /* mov dl, [ebp+0x10] */
            ii(0x1018_1f23, 3); cmp(dl, 0x1);                           /* cmp dl, 0x1 */
            ii(0x1018_1f26, 2); if(jb(0x1018_1f59, 0x31)) goto l_0x1018_1f59; /* jb 0x10181f59 */
            ii(0x1018_1f28, 3); cmp(dl, 0x3);                           /* cmp dl, 0x3 */
            ii(0x1018_1f2b, 2); if(jbe(0x1018_1f34, 0x7)) goto l_0x1018_1f34; /* jbe 0x10181f34 */
            ii(0x1018_1f2d, 3); cmp(dl, 0x4);                           /* cmp dl, 0x4 */
            ii(0x1018_1f30, 2); if(jz(0x1018_1f45, 0x13)) goto l_0x1018_1f45; /* jz 0x10181f45 */
            ii(0x1018_1f32, 2); jmp(0x1018_1f59, 0x25); goto l_0x1018_1f59; /* jmp 0x10181f59 */
        l_0x1018_1f34:
            ii(0x1018_1f34, 2); mov(al, dl);                            /* mov al, dl */
            ii(0x1018_1f36, 2); or(al, 0x40);                           /* or al, 0x40 */
            ii(0x1018_1f38, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_1f3d, 3); lea(edx, memd[ss, ebp + 0x8]);          /* lea edx, [ebp+0x8] */
            ii(0x1018_1f40, 3); or(ah, 0x20);                           /* or ah, 0x20 */
            ii(0x1018_1f43, 2); jmp(0x1018_1f7d, 0x38); goto l_0x1018_1f7d; /* jmp 0x10181f7d */
        l_0x1018_1f45:
            ii(0x1018_1f45, 2); fldz();                                 /* fldz */
            ii(0x1018_1f47, 3); fcomp(memq[ss, ebp + 0x8]);             /* fcomp qword [ebp+0x8] */
            ii(0x1018_1f4a, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1018_1f4c, 1); sahf();                                 /* sahf */
            ii(0x1018_1f4d, 2); if(jbe(0x1018_1f59, 0xa)) goto l_0x1018_1f59; /* jbe 0x10181f59 */
            ii(0x1018_1f4f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1f51, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x1018_1f54, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
            ii(0x1018_1f57, 2); jmp(0x1018_1f85, 0x2c); goto l_0x1018_1f85; /* jmp 0x10181f85 */
        l_0x1018_1f59:
            ii(0x1018_1f59, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_1f5f, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_1f61, 3); or(bh, 0x81);                           /* or bh, 0x81 */
            ii(0x1018_1f64, 3); cmp(edx, 0x6);                          /* cmp edx, 0x6 */
            ii(0x1018_1f67, 2); if(jnz(0x1018_1f78, 0xf)) goto l_0x1018_1f78; /* jnz 0x10181f78 */
            ii(0x1018_1f69, 2); fldz();                                 /* fldz */
            ii(0x1018_1f6b, 3); fcomp(memq[ss, ebp + 0x8]);             /* fcomp qword [ebp+0x8] */
            ii(0x1018_1f6e, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1018_1f70, 1); sahf();                                 /* sahf */
            ii(0x1018_1f71, 2); if(jbe(0x1018_1f78, 0x5)) goto l_0x1018_1f78; /* jbe 0x10181f78 */
            ii(0x1018_1f73, 3); or(dh, 0x11);                           /* or dh, 0x11 */
            ii(0x1018_1f76, 2); mov(ebx, edx);                          /* mov ebx, edx */
        l_0x1018_1f78:
            ii(0x1018_1f78, 3); lea(edx, memd[ss, ebp + 0x8]);          /* lea edx, [ebp+0x8] */
            ii(0x1018_1f7b, 2); mov(eax, ebx);                          /* mov eax, ebx */
        l_0x1018_1f7d:
            ii(0x1018_1f7d, 5); call(/* sys */ 0x1019_6628, 0x1_46a6);  /* call 0x10196628 */
            ii(0x1018_1f82, 3); fstp(memq[ss, ebp - 0x14]);             /* fstp qword [ebp-0x14] */
        l_0x1018_1f85:
            ii(0x1018_1f85, 3); fld(memq[ss, ebp - 0x14]);              /* fld qword [ebp-0x14] */
            ii(0x1018_1f88, 3); lea(esp, memd[ss, ebp - 0xc]);          /* lea esp, [ebp-0xc] */
            ii(0x1018_1f8b, 1); pop(edx);                               /* pop edx */
            ii(0x1018_1f8c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_1f8d, 1); pop(eax);                               /* pop eax */
            ii(0x1018_1f8e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_1f8f, 3); ret(0xc);                               /* ret 0xc */
        }
    }
}
