using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c606-ed3926be")]
        public void /* sys */ Method_1016_c606()
        {
            ii(0x1016_c606, 1); push(ecx);                              /* push ecx */
            ii(0x1016_c607, 1); push(esi);                              /* push esi */
            ii(0x1016_c608, 3); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_c60b, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_c60d, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_c60f, 2); mov(ecx, esp);                          /* mov ecx, esp */
            ii(0x1016_c611, 5); call(/* sys */ 0x1018_798c, 0x1_b376);  /* call 0x1018798c */
            ii(0x1016_c616, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_c618, 5); call(/* sys */ 0x1016_c623, 6);         /* call 0x1016c623 */
            ii(0x1016_c61d, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1016_c620, 1); pop(esi);                               /* pop esi */
            ii(0x1016_c621, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_c622, 1); ret();                                  /* ret */
        }
    }
}
