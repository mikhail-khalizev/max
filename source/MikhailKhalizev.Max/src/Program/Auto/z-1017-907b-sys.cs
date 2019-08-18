using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_907b-9d700d0")]
        public void /* sys */ Method_1017_907b()
        {
        l_0x1017_907b:
            ii(0x1017_907b, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1017_907e, 2); sub(ecx, esi);                          /* sub ecx, esi */
            ii(0x1017_9080, 2); cmp(ecx, ebp);                          /* cmp ecx, ebp */
            ii(0x1017_9082, 2); if(jbd(0x1017_90c3, 0x3f)) goto l_0x1017_90c3; /* jb 0x101790c3 */
            ii(0x1017_9084, 2); mov(edi, esi);                          /* mov edi, esi */
            ii(0x1017_9086, 2); mov(al, memb_a32[ds, ebx]);             /* mov al, [ebx] */
            ii(0x1017_9088, 1); pushd(es);                              /* push es */
            ii(0x1017_9089, 2); if(jecxzd_func(0x1017_9096, 0xb)) return; /* jecxz 0x10179096 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
            ii(0x1017_908b, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_908d, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1017_908f, 2); repne_a32(() => scasb_a32());           /* repne scasb */
            ii(0x1017_9091, 2); if(jnzd_func(0x1017_9096, 0x3)) return; /* jnz 0x10179096 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
            ii(0x1017_9093, 1); dec(edi);                               /* dec edi */
            ii(0x1017_9094, 4); test(ax, 0xcf89);                       /* test ax, 0xcf89 */
            ii(0x1017_9098, 1); popd(es);                               /* pop es */
            ii(0x1017_9099, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1017_909b, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_909d, 2); if(jzd(0x1017_90c3, 0x24)) goto l_0x1017_90c3; /* jz 0x101790c3 */
            ii(0x1017_909f, 2); mov(ecx, ebp);                          /* mov ecx, ebp */
            ii(0x1017_90a1, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1017_90a3, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1017_90a5, 1); pushd(es);                              /* push es */
            ii(0x1017_90a6, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1017_90a8, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1017_90aa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_90ac, 2); repe_a32(() => cmpsb_a32());            /* repe cmpsb */
            ii(0x1017_90ae, 2); if(jzd(0x1017_90b5, 0x5)) goto l_0x1017_90b5; /* jz 0x101790b5 */
            ii(0x1017_90b0, 2); sbb(eax, eax);                          /* sbb eax, eax */
            ii(0x1017_90b2, 3); sbb(eax, -0x1 /* 0xff */);              /* sbb eax, 0xffffffff */
        l_0x1017_90b5:
            ii(0x1017_90b5, 1); popd(es);                               /* pop es */
            ii(0x1017_90b6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_90b8, 2); if(jnzd(0x1017_90be, 0x4)) goto l_0x1017_90be; /* jnz 0x101790be */
            ii(0x1017_90ba, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_90bc, 2); if(jmpd_func(0x1017_90c5, 0x7)) return; /* jmp 0x101790c5 */
        l_0x1017_90be:
            ii(0x1017_90be, 3); lea(esi, edx + 0x1);                    /* lea esi, [edx+0x1] */
            ii(0x1017_90c1, 2); jmpd(0x1017_907b, -0x48); goto l_0x1017_907b; /* jmp 0x1017907b */
        l_0x1017_90c3:
            ii(0x1017_90c3, 2); xor(eax, eax);                          /* xor eax, eax */
        }
    }
}
