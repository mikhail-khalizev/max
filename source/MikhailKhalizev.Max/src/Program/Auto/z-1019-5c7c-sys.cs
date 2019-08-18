using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5c7c-fd655e95")]
        public void /* sys */ Method_1019_5c7c()
        {
            ii(0x1019_5c7c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_5c7d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_5c7e, 1); pushd(edx);                             /* push edx */
            ii(0x1019_5c7f, 1); pushd(esi);                             /* push esi */
            ii(0x1019_5c80, 1); pushd(edi);                             /* push edi */
            ii(0x1019_5c81, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_5c82, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1019_5c85, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1019_5c87, 2); mov(edi, memd_a32[ds, eax]);            /* mov edi, [eax] */
            ii(0x1019_5c89, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1019_5c8b, 2); if(jnzd(0x1019_5c95, 0x8)) goto l_0x1019_5c95; /* jnz 0x10195c95 */
            ii(0x1019_5c8d, 3); mov(memd_a32[ss, esp], edi);            /* mov [esp], edi */
            ii(0x1019_5c90, 5); if(jmpd_func(0x1019_5cd7, 0x42)) return; /* jmp 0x10195cd7 */
        l_0x1019_5c95:
            ii(0x1019_5c95, 3); mov(ecx, memd_a32[ds, eax + 0x4]);      /* mov ecx, [eax+0x4] */
            ii(0x1019_5c98, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_5c9a, 2); if(jbed(0x1019_5c9d, 0x1)) goto l_0x1019_5c9d; /* jbe 0x10195c9d */
            ii(0x1019_5c9c, 1); dec(ecx);                               /* dec ecx */
        l_0x1019_5c9d:
            ii(0x1019_5c9d, 3); lea(ebp, edi + 0xc);                    /* lea ebp, [edi+0xc] */
        }
    }
}
