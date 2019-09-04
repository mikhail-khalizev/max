using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1650-951fc28f")]
        public void Method_1014_1650()
        {
            ii(0x1014_1650, 1); push(ebx);                              /* push ebx */
            ii(0x1014_1651, 1); push(ecx);                              /* push ecx */
            ii(0x1014_1652, 1); push(edx);                              /* push edx */
            ii(0x1014_1653, 1); push(esi);                              /* push esi */
            ii(0x1014_1654, 1); push(edi);                              /* push edi */
            ii(0x1014_1655, 1); push(ebp);                              /* push ebp */
            ii(0x1014_1656, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1658, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1014_165e, 7); mov(memd[ss, ebp - 4], 0x7fff);         /* mov dword [ebp-0x4], 0x7fff */
            ii(0x1014_1665, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_1668, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_166a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_166b, 1); pop(edi);                               /* pop edi */
            ii(0x1014_166c, 1); pop(esi);                               /* pop esi */
            ii(0x1014_166d, 1); pop(edx);                               /* pop edx */
            ii(0x1014_166e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_166f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_1670, 1); ret();                                  /* ret */
        }
    }
}
