using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7170-d0206228")]
        public void /* sys */ Method_1018_7170()
        {
            ii(0x1018_7170, 1); push(ebp);                              /* push ebp */
            ii(0x1018_7171, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_7173, 1); push(eax);                              /* push eax */
            ii(0x1018_7174, 1); push(ebx);                              /* push ebx */
            ii(0x1018_7175, 1); push(ecx);                              /* push ecx */
            ii(0x1018_7176, 1); push(edx);                              /* push edx */
            ii(0x1018_7177, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1018_717a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_717c, 3); mov(al, memb[ss, ebp + 0x18]);          /* mov al, [ebp+0x18] */
            ii(0x1018_717f, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1018_7182, 2); if(jg(0x1018_71b3, 0x2f)) goto l_0x1018_71b3; /* jg 0x101871b3 */
            ii(0x1018_7184, 2); test(al, al);                           /* test al, al */
            ii(0x1018_7186, 2); if(jnz(0x1018_71ac, 0x24)) goto l_0x1018_71ac; /* jnz 0x101871ac */
            ii(0x1018_7188, 2); fldz();                                 /* fldz */
            ii(0x1018_718a, 3); fcomp(memq[ss, ebp + 0x10]);            /* fcomp qword [ebp+0x10] */
            ii(0x1018_718d, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1018_718f, 1); sahf();                                 /* sahf */
            ii(0x1018_7190, 2); if(jae(0x1018_719c, 0xa)) goto l_0x1018_719c; /* jae 0x1018719c */
            ii(0x1018_7192, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_7194, 3); mov(memd[ss, ebp - 0x18], ecx);         /* mov [ebp-0x18], ecx */
            ii(0x1018_7197, 3); mov(memd[ss, ebp - 0x14], ecx);         /* mov [ebp-0x14], ecx */
            ii(0x1018_719a, 2); jmp(0x1018_71eb, 0x4f); goto l_0x1018_71eb; /* jmp 0x101871eb */
        l_0x1018_719c:
            ii(0x1018_719c, 2); if(jbe(0x1018_71a5, 0x7)) goto l_0x1018_71a5; /* jbe 0x101871a5 */
            ii(0x1018_719e, 5); mov(eax, 0x8047);                       /* mov eax, 0x8047 */
            ii(0x1018_71a3, 2); jmp(0x1018_71dd, 0x38); goto l_0x1018_71dd; /* jmp 0x101871dd */
        l_0x1018_71a5:
            ii(0x1018_71a5, 5); mov(eax, 0x4047);                       /* mov eax, 0x4047 */
            ii(0x1018_71aa, 2); jmp(0x1018_71dd, 0x31); goto l_0x1018_71dd; /* jmp 0x101871dd */
        l_0x1018_71ac:
            ii(0x1018_71ac, 5); mov(eax, 0x2047);                       /* mov eax, 0x2047 */
            ii(0x1018_71b1, 2); jmp(0x1018_71dd, 0x2a); goto l_0x1018_71dd; /* jmp 0x101871dd */
        l_0x1018_71b3:
            ii(0x1018_71b3, 2); fldz();                                 /* fldz */
            ii(0x1018_71b5, 3); fcomp(memq[ss, ebp + 0x10]);            /* fcomp qword [ebp+0x10] */
            ii(0x1018_71b8, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1018_71ba, 1); sahf();                                 /* sahf */
            ii(0x1018_71bb, 2); if(jb(0x1018_71c7, 0xa)) goto l_0x1018_71c7; /* jb 0x101871c7 */
            ii(0x1018_71bd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_71bf, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
            ii(0x1018_71c2, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x1018_71c5, 2); jmp(0x1018_71eb, 0x24); goto l_0x1018_71eb; /* jmp 0x101871eb */
        l_0x1018_71c7:
            ii(0x1018_71c7, 2); fldz();                                 /* fldz */
            ii(0x1018_71c9, 3); fcomp(memq[ss, ebp + 0x8]);             /* fcomp qword [ebp+0x8] */
            ii(0x1018_71cc, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1018_71ce, 1); sahf();                                 /* sahf */
            ii(0x1018_71cf, 2); if(jae(0x1018_71d8, 0x7)) goto l_0x1018_71d8; /* jae 0x101871d8 */
            ii(0x1018_71d1, 5); mov(eax, 0x8107);                       /* mov eax, 0x8107 */
            ii(0x1018_71d6, 2); jmp(0x1018_71dd, 0x5); goto l_0x1018_71dd; /* jmp 0x101871dd */
        l_0x1018_71d8:
            ii(0x1018_71d8, 5); mov(eax, 0x1107);                       /* mov eax, 0x1107 */
        l_0x1018_71dd:
            ii(0x1018_71dd, 3); lea(ebx, ebp + 0x10);                   /* lea ebx, [ebp+0x10] */
            ii(0x1018_71e0, 3); lea(edx, ebp + 0x8);                    /* lea edx, [ebp+0x8] */
            ii(0x1018_71e3, 5); call(/* sys */ 0x1019_6632, 0xf44a);    /* call 0x10196632 */
            ii(0x1018_71e8, 3); fstp(memq[ss, ebp - 0x18]);             /* fstp qword [ebp-0x18] */
        l_0x1018_71eb:
            ii(0x1018_71eb, 3); fld(memq[ss, ebp - 0x18]);              /* fld qword [ebp-0x18] */
            ii(0x1018_71ee, 3); lea(esp, ebp - 0x10);                   /* lea esp, [ebp-0x10] */
            ii(0x1018_71f1, 1); pop(edx);                               /* pop edx */
            ii(0x1018_71f2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_71f3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_71f4, 1); pop(eax);                               /* pop eax */
            ii(0x1018_71f5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_71f6, 3); ret(0x14);                              /* ret 0x14 */
        }
    }
}
