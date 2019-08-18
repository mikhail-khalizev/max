using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("21665415-b409-42db-89c2-6cbee9507a65")]
        public void Method_100d_51e4()
        {
            ii(0x100d_51e4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_51e5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_51e6, 1); pushd(edx);                             /* push edx */
            ii(0x100d_51e7, 1); pushd(esi);                             /* push esi */
            ii(0x100d_51e8, 1); pushd(edi);                             /* push edi */
            ii(0x100d_51e9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_51ea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_51ec, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_51f2, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x100d_51f6, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_51f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_51fb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_51fc, 1); popd(edi);                              /* pop edi */
            ii(0x100d_51fd, 1); popd(esi);                              /* pop esi */
            ii(0x100d_51fe, 1); popd(edx);                              /* pop edx */
            ii(0x100d_51ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_5200, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_5201, 1); retd(); return;                         /* ret */
        }
    }
}
