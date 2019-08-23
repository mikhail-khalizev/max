using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9096-35e3510e")]
        public void /* sys */ Method_1017_9096()
        {
            ii(0x1017_9096, 2); mov(edi, ecx);                          /* mov edi, ecx */
            ii(0x1017_9098, 1); pop(es);                                /* pop es */
            ii(0x1017_9099, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1017_909b, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_909d, 2); if(jz_func(0x1017_90c3, 0x24)) return;  /* jz 0x101790c3 */
            ii(0x1017_909f, 2); mov(ecx, ebp);                          /* mov ecx, ebp */
            ii(0x1017_90a1, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1017_90a3, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1017_90a5, 1); push(es);                               /* push es */
            ii(0x1017_90a6, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1017_90a8, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1017_90aa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_90ac, 2); repe(() => cmpsb());                    /* repe cmpsb */
            ii(0x1017_90ae, 2); if(jz(0x1017_90b5, 0x5)) goto l_0x1017_90b5; /* jz 0x101790b5 */
            ii(0x1017_90b0, 2); sbb(eax, eax);                          /* sbb eax, eax */
            ii(0x1017_90b2, 3); sbb(eax, -0x1 /* 0xff */);              /* sbb eax, 0xffffffff */
        l_0x1017_90b5:
            ii(0x1017_90b5, 1); pop(es);                                /* pop es */
            ii(0x1017_90b6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_90b8, 2); if(jnz(0x1017_90be, 0x4)) goto l_0x1017_90be; /* jnz 0x101790be */
            ii(0x1017_90ba, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_90bc, 2); if(jmp_func(0x1017_90c5, 0x7)) return;  /* jmp 0x101790c5 */
        l_0x1017_90be:
            ii(0x1017_90be, 3); lea(esi, memd[ds, edx + 0x1]);          /* lea esi, [edx+0x1] */
            ii(0x1017_90c1, 2); if(jmp_func(0x1017_907b, -0x48)) return; /* jmp 0x1017907b */
        }
    }
}
