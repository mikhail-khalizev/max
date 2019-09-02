using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1d6e-5e7c7209")]
        public void /* sys */ Method_1018_1d6e()
        {
            ii(0x1018_1d6e, 1); push(esi);                              /* push esi */
            ii(0x1018_1d6f, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_1d71, 3); mov(eax, memd[ds, eax + 2]);            /* mov eax, [eax+0x2] */
            ii(0x1018_1d74, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1018_1d76, 4); movzx(ebx, memb[ds, eax + 4]);          /* movzx ebx, byte [eax+0x4] */
            ii(0x1018_1d7a, 2); test(ebx, ecx);                         /* test ebx, ecx */
            ii(0x1018_1d7c, 2); if(jnz(0x1018_1d86, 8)) goto l_0x1018_1d86; /* jnz 0x10181d86 */
            ii(0x1018_1d7e, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1018_1d80, 3); add(eax, memd[ds, esi + 6]);            /* add eax, [esi+0x6] */
            ii(0x1018_1d83, 3); call_abs(memd[ds, esi + 0xa]);          /* call dword [esi+0xa] */
        l_0x1018_1d86:
            ii(0x1018_1d86, 1); pop(esi);                               /* pop esi */
            ii(0x1018_1d87, 1); ret();                                  /* ret */
        }
    }
}
