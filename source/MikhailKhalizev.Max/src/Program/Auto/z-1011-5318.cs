using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("77b11331-9c23-41a3-a5be-7cdc2fdee529")]
        public void Method_1011_5318()
        {
            ii(0x1011_5318, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_5319, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_531a, 1); pushd(edx);                             /* push edx */
            ii(0x1011_531b, 1); pushd(esi);                             /* push esi */
            ii(0x1011_531c, 1); pushd(edi);                             /* push edi */
            ii(0x1011_531d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_531e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5320, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_5326, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_532a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_532d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_532f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_5330, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5331, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5332, 1); popd(edx);                              /* pop edx */
            ii(0x1011_5333, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_5334, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_5335, 1); retd(); return;                         /* ret */
        }
    }
}
