using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_54bf-f52f88fb")]
        public void /* sys */ Method_1019_54bf()
        {
            ii(0x1019_54bf, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_54c0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_54c1, 1); pushd(edx);                             /* push edx */
            ii(0x1019_54c2, 1); pushd(esi);                             /* push esi */
            ii(0x1019_54c3, 1); pushd(edi);                             /* push edi */
            ii(0x1019_54c4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_54c5, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1019_54c7, 6); mov(esi, memd_a32[ds, 0x101c_1cf8]);    /* mov esi, [0x101c1cf8] */
            ii(0x1019_54cd, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1019_54cf, 2); if(jzd(0x1019_5517, 0x46)) goto l_0x1019_5517; /* jz 0x10195517 */
            ii(0x1019_54d1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_54d3, 2); if(jzd(0x1019_5517, 0x42)) goto l_0x1019_5517; /* jz 0x10195517 */
            ii(0x1019_54d5, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1019_54d7, 1); pushd(es);                              /* push es */
            ii(0x1019_54d8, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1019_54da, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1019_54dc, 2); sub(ecx, ecx);                          /* sub ecx, ecx */
            ii(0x1019_54de, 1); dec(ecx);                               /* dec ecx */
            ii(0x1019_54df, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_54e1, 2); repne_a32(() => scasb_a32());           /* repne scasb */
            ii(0x1019_54e3, 2); not(ecx);                               /* not ecx */
            ii(0x1019_54e5, 1); dec(ecx);                               /* dec ecx */
            ii(0x1019_54e6, 1); popd(es);                               /* pop es */
            ii(0x1019_54e7, 2); mov(edi, ecx);                          /* mov edi, ecx */
            ii(0x1019_54e9, 2); jmpd(0x1019_5511, 0x26); goto l_0x1019_5511; /* jmp 0x10195511 */
        l_0x1019_54eb:
            ii(0x1019_54eb, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1019_54ed, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1019_54ef, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_54f1, 5); calld(/* sys */ 0x1017_d531, -0x1_7fc5); /* call 0x1017d531 */
            ii(0x1019_54f6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_54f8, 2); if(jnzd(0x1019_550e, 0x14)) goto l_0x1019_550e; /* jnz 0x1019550e */
            ii(0x1019_54fa, 3); mov(al, memb_a32[ds, ecx + edi]);       /* mov al, [ecx+edi] */
            ii(0x1019_54fd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1019_5502, 3); cmp(eax, 0x3d);                         /* cmp eax, 0x3d */
            ii(0x1019_5505, 2); if(jnzd(0x1019_550e, 0x7)) goto l_0x1019_550e; /* jnz 0x1019550e */
            ii(0x1019_5507, 3); lea(eax, edi + 0x1);                    /* lea eax, [edi+0x1] */
            ii(0x1019_550a, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1019_550c, 2); jmpd(0x1019_5519, 0xb); goto l_0x1019_5519; /* jmp 0x10195519 */
        l_0x1019_550e:
            ii(0x1019_550e, 3); add(esi, 0x4);                          /* add esi, 0x4 */
        l_0x1019_5511:
            ii(0x1019_5511, 2); mov(ecx, memd_a32[ds, esi]);            /* mov ecx, [esi] */
            ii(0x1019_5513, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_5515, 2); if(jnzd(0x1019_54eb, -0x2c)) goto l_0x1019_54eb; /* jnz 0x101954eb */
        l_0x1019_5517:
            ii(0x1019_5517, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1019_5519:
            ii(0x1019_5519, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_551a, 1); popd(edi);                              /* pop edi */
            ii(0x1019_551b, 1); popd(esi);                              /* pop esi */
            ii(0x1019_551c, 1); popd(edx);                              /* pop edx */
            ii(0x1019_551d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_551e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_551f, 1); retd(); return;                         /* ret */
        }
    }
}
