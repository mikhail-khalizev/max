using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_5358-44b9eb0e")]
        public void Method_1011_5358()
        {
            ii(0x1011_5358, 1); push(ebx);                              /* push ebx */
            ii(0x1011_5359, 1); push(ecx);                              /* push ecx */
            ii(0x1011_535a, 1); push(edx);                              /* push edx */
            ii(0x1011_535b, 1); push(esi);                              /* push esi */
            ii(0x1011_535c, 1); push(edi);                              /* push edi */
            ii(0x1011_535d, 1); push(ebp);                              /* push ebp */
            ii(0x1011_535e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5360, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1011_5366, 4); mov(memb[ss, ebp - 4], 1);              /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_536a, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1011_536d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_536f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_5370, 1); pop(edi);                               /* pop edi */
            ii(0x1011_5371, 1); pop(esi);                               /* pop esi */
            ii(0x1011_5372, 1); pop(edx);                               /* pop edx */
            ii(0x1011_5373, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_5374, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_5375, 1); ret();                                  /* ret */
        }
    }
}
