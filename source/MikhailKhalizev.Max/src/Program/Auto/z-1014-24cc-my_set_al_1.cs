using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ed1305fd-5c0f-493e-9cec-0077567060e6")]
        public void my_set_al_1()
        {
            ii(0x1014_24cc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_24cd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_24ce, 1); pushd(edx);                             /* push edx */
            ii(0x1014_24cf, 1); pushd(esi);                             /* push esi */
            ii(0x1014_24d0, 1); pushd(edi);                             /* push edi */
            ii(0x1014_24d1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_24d2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_24d4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_24da, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1014_24de, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1014_24e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_24e3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_24e4, 1); popd(edi);                              /* pop edi */
            ii(0x1014_24e5, 1); popd(esi);                              /* pop esi */
            ii(0x1014_24e6, 1); popd(edx);                              /* pop edx */
            ii(0x1014_24e7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_24e8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_24e9, 1); retd(); return;                         /* ret */
        }
    }
}
