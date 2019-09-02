using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_bafc-f97d272b")]
        public void /* sys */ Method_1018_bafc()
        {
            ii(0x1018_bafc, 1); push(ebx);                              /* push ebx */
            ii(0x1018_bafd, 1); push(ecx);                              /* push ecx */
            ii(0x1018_bafe, 3); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1018_bb01, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_bb03, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1018_bb05, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1018_bb07, 5); call(/* sys */ 0x1018_ba98, -0x74);     /* call 0x1018ba98 */
            ii(0x1018_bb0c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bb0e, 2); if(jnz(0x1018_bb53, 0x43)) goto l_0x1018_bb53; /* jnz 0x1018bb53 */
            ii(0x1018_bb10, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1018_bb13, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1018_bb15, 3); mov(memd[ds, ecx + 4], eax);            /* mov [ecx+0x4], eax */
            ii(0x1018_bb18, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_bb1a, 5); call(/* sys */ 0x1018_ba98, -0x87);     /* call 0x1018ba98 */
            ii(0x1018_bb1f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bb21, 2); if(jnz(0x1018_bb53, 0x30)) goto l_0x1018_bb53; /* jnz 0x1018bb53 */
            ii(0x1018_bb23, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1018_bb26, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1018_bb28, 3); mov(memd[ds, ecx + 8], eax);            /* mov [ecx+0x8], eax */
            ii(0x1018_bb2b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_bb2d, 5); call(/* sys */ 0x1018_ba98, -0x9a);     /* call 0x1018ba98 */
            ii(0x1018_bb32, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bb34, 2); if(jnz(0x1018_bb53, 0x1d)) goto l_0x1018_bb53; /* jnz 0x1018bb53 */
            ii(0x1018_bb36, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1018_bb39, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1018_bb3b, 3); mov(memd[ds, ecx + 0xc], eax);          /* mov [ecx+0xc], eax */
            ii(0x1018_bb3e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_bb40, 5); call(/* sys */ 0x1018_ba98, -0xad);     /* call 0x1018ba98 */
            ii(0x1018_bb45, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_bb47, 2); if(jnz(0x1018_bb53, 0xa)) goto l_0x1018_bb53; /* jnz 0x1018bb53 */
            ii(0x1018_bb49, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1018_bb4c, 3); mov(memd[ds, ecx + 0x20], eax);         /* mov [ecx+0x20], eax */
            ii(0x1018_bb4f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_bb51, 2); jmp(0x1018_bb58, 5); goto l_0x1018_bb58; /* jmp 0x1018bb58 */
        l_0x1018_bb53:
            ii(0x1018_bb53, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
        l_0x1018_bb58:
            ii(0x1018_bb58, 3); add(esp, 4);                            /* add esp, 0x4 */
            ii(0x1018_bb5b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_bb5c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_bb5d, 1); ret();                                  /* ret */
        }
    }
}
