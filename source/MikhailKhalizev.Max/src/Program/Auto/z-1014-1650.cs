using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1650-951fc28f")]
        public void Method_1014_1650()
        {
            ii(0x1014_1650, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_1651, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_1652, 1); pushd(edx);                             /* push edx */
            ii(0x1014_1653, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1654, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1655, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_1656, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1658, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_165e, 7); mov(memd_a32[ss, ebp - 0x4], 0x7fff);   /* mov dword [ebp-0x4], 0x7fff */
            ii(0x1014_1665, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1668, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_166a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_166b, 1); popd(edi);                              /* pop edi */
            ii(0x1014_166c, 1); popd(esi);                              /* pop esi */
            ii(0x1014_166d, 1); popd(edx);                              /* pop edx */
            ii(0x1014_166e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_166f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1670, 1); retd(); return;                         /* ret */
        }
    }
}
