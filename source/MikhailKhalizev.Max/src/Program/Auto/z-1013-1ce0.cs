using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1ce0-b70b8a0f")]
        public void Method_1013_1ce0()
        {
            ii(0x1013_1ce0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1ce1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1ce2, 1); pushd(edx);                             /* push edx */
            ii(0x1013_1ce3, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1ce4, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1ce5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1ce6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1ce8, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_1cee, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1013_1cf2, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_1cf5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1cf7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1cf8, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1cf9, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1cfa, 1); popd(edx);                              /* pop edx */
            ii(0x1013_1cfb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1cfc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1cfd, 1); retd();                                 /* ret */
        }
    }
}
