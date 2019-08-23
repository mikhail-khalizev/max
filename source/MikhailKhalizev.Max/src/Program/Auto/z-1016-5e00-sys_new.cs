using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5e00-d903819")]
        public void /* sys */ sys_new()
        {
            ii(0x1016_5e00, 1); push(ebx);                              /* push ebx */
            ii(0x1016_5e01, 1); push(edx);                              /* push edx */
            ii(0x1016_5e02, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_5e05, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_5e07, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5e09, 2); if(jnz(0x1016_5e0e, 0x3)) goto l_0x1016_5e0e; /* jnz 0x10165e0e */
            ii(0x1016_5e0b, 3); lea(edx, memd[ds, eax + 0x1]);          /* lea edx, [eax+0x1] */
        l_0x1016_5e0e:
            ii(0x1016_5e0e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_5e10, 5); call(Definitions.sys_malloc, 0x51c9);   /* call 0x1016afde */
            ii(0x1016_5e15, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_5e17, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5e19, 2); if(jnz(0x1016_5e43, 0x28)) goto l_0x1016_5e43; /* jnz 0x10165e43 */
            ii(0x1016_5e1b, 5); mov(eax, memd[ds, 0x1020_a214]);        /* mov eax, [0x1020a214] */
            ii(0x1016_5e20, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1016_5e23, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5e25, 2); if(jz(0x1016_5e30, 0x9)) goto l_0x1016_5e30; /* jz 0x10165e30 */
            ii(0x1016_5e27, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_5e29, 3); call_abs(memd[ss, esp]);                /* call dword [esp] */
            ii(0x1016_5e2c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5e2e, 2); if(jnz(0x1016_5e0e, -0x22)) goto l_0x1016_5e0e; /* jnz 0x10165e0e */
        l_0x1016_5e30:
            ii(0x1016_5e30, 5); mov(eax, memd[ds, 0x1020_a210]);        /* mov eax, [0x1020a210] */
            ii(0x1016_5e35, 4); mov(memd[ss, esp + 0x4], eax);          /* mov [esp+0x4], eax */
            ii(0x1016_5e39, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5e3b, 2); if(jz(0x1016_5e43, 0x6)) goto l_0x1016_5e43; /* jz 0x10165e43 */
            ii(0x1016_5e3d, 4); call_abs(memd[ss, esp + 0x4]);          /* call dword [esp+0x4] */
            ii(0x1016_5e41, 2); jmp(0x1016_5e0e, -0x35); goto l_0x1016_5e0e; /* jmp 0x10165e0e */
        l_0x1016_5e43:
            ii(0x1016_5e43, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_5e45, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_5e48, 1); pop(edx);                               /* pop edx */
            ii(0x1016_5e49, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_5e4a, 1); ret();                                  /* ret */
        }
    }
}
