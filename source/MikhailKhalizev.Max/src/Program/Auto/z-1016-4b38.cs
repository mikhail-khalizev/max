using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4b38-6b489c29")]
        public void Method_1016_4b38()
        {
            ii(0x1016_4b38, 1); push(ebx);                              /* push ebx */
            ii(0x1016_4b39, 1); push(ecx);                              /* push ecx */
            ii(0x1016_4b3a, 1); push(edx);                              /* push edx */
            ii(0x1016_4b3b, 1); push(esi);                              /* push esi */
            ii(0x1016_4b3c, 1); push(edi);                              /* push edi */
            ii(0x1016_4b3d, 1); push(ebp);                              /* push ebp */
            ii(0x1016_4b3e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4b40, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1016_4b46, 7); mov(memd[ss, ebp - 4], StringDefinitions.Empty62); /* mov dword [ebp-0x4], 0x101b234e */
            ii(0x1016_4b4d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_4b50, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4b52, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_4b53, 1); pop(edi);                               /* pop edi */
            ii(0x1016_4b54, 1); pop(esi);                               /* pop esi */
            ii(0x1016_4b55, 1); pop(edx);                               /* pop edx */
            ii(0x1016_4b56, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_4b57, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_4b58, 1); ret();                                  /* ret */
        }
    }
}
