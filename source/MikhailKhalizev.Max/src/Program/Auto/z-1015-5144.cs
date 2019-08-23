using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_5144-b70b8a0f")]
        public void Method_1015_5144()
        {
            ii(0x1015_5144, 1); push(ebx);                              /* push ebx */
            ii(0x1015_5145, 1); push(ecx);                              /* push ecx */
            ii(0x1015_5146, 1); push(edx);                              /* push edx */
            ii(0x1015_5147, 1); push(esi);                              /* push esi */
            ii(0x1015_5148, 1); push(edi);                              /* push edi */
            ii(0x1015_5149, 1); push(ebp);                              /* push ebp */
            ii(0x1015_514a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_514c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1015_5152, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1015_5156, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1015_5159, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_515b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_515c, 1); pop(edi);                               /* pop edi */
            ii(0x1015_515d, 1); pop(esi);                               /* pop esi */
            ii(0x1015_515e, 1); pop(edx);                               /* pop edx */
            ii(0x1015_515f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_5160, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_5161, 1); ret();                                  /* ret */
        }
    }
}
