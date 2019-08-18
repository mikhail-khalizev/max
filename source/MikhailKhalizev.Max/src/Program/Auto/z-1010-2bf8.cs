using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5e519a20-725a-4b6c-b792-f38267710878")]
        public void Method_1010_2bf8()
        {
            ii(0x1010_2bf8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_2bf9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_2bfa, 1); pushd(edx);                             /* push edx */
            ii(0x1010_2bfb, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2bfc, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2bfd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2bfe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2c00, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_2c06, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1010_2c0a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1010_2c0d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2c0f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_2c10, 1); popd(edi);                              /* pop edi */
            ii(0x1010_2c11, 1); popd(esi);                              /* pop esi */
            ii(0x1010_2c12, 1); popd(edx);                              /* pop edx */
            ii(0x1010_2c13, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_2c14, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_2c15, 1); retd(); return;                         /* ret */
        }
    }
}
