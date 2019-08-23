using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5e00-d903819")]
        public void /* sys */ sys_new()
        {
            ii(0x1016_5e00, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_5e01, 1); pushd(edx);                             /* push edx */
            ii(0x1016_5e02, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_5e05, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_5e07, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5e09, 2); if(jnzd(0x1016_5e0e, 0x3)) goto l_0x1016_5e0e; /* jnz 0x10165e0e */
            ii(0x1016_5e0b, 3); lea(edx, eax + 0x1);                    /* lea edx, [eax+0x1] */
        l_0x1016_5e0e:
            ii(0x1016_5e0e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_5e10, 5); calld(Definitions.sys_malloc, 0x51c9);  /* call 0x1016afde */
            ii(0x1016_5e15, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_5e17, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5e19, 2); if(jnzd(0x1016_5e43, 0x28)) goto l_0x1016_5e43; /* jnz 0x10165e43 */
            ii(0x1016_5e1b, 5); mov(eax, memd_a32[ds, 0x1020_a214]);    /* mov eax, [0x1020a214] */
            ii(0x1016_5e20, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_5e23, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5e25, 2); if(jzd(0x1016_5e30, 0x9)) goto l_0x1016_5e30; /* jz 0x10165e30 */
            ii(0x1016_5e27, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_5e29, 3); calld_abs(memd_a32[ss, esp]);           /* call dword [esp] */
            ii(0x1016_5e2c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5e2e, 2); if(jnzd(0x1016_5e0e, -0x22)) goto l_0x1016_5e0e; /* jnz 0x10165e0e */
        l_0x1016_5e30:
            ii(0x1016_5e30, 5); mov(eax, memd_a32[ds, 0x1020_a210]);    /* mov eax, [0x1020a210] */
            ii(0x1016_5e35, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1016_5e39, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5e3b, 2); if(jzd(0x1016_5e43, 0x6)) goto l_0x1016_5e43; /* jz 0x10165e43 */
            ii(0x1016_5e3d, 4); calld_abs(memd_a32[ss, esp + 0x4]);     /* call dword [esp+0x4] */
            ii(0x1016_5e41, 2); jmpd(0x1016_5e0e, -0x35); goto l_0x1016_5e0e; /* jmp 0x10165e0e */
        l_0x1016_5e43:
            ii(0x1016_5e43, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_5e45, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_5e48, 1); popd(edx);                              /* pop edx */
            ii(0x1016_5e49, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_5e4a, 1); retd();                                 /* ret */
        }
    }
}
