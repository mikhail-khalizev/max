using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7b4a8f28-d7b6-441e-8b41-56dbc84fc816")]
        public void Method_100e_42e4()
        {
            ii(0x100e_42e4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_42e5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_42e6, 1); pushd(edx);                             /* push edx */
            ii(0x100e_42e7, 1); pushd(esi);                             /* push esi */
            ii(0x100e_42e8, 1); pushd(edi);                             /* push edi */
            ii(0x100e_42e9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_42ea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_42ec, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_42f2, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x100e_42f6, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_42f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_42fb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_42fc, 1); popd(edi);                              /* pop edi */
            ii(0x100e_42fd, 1); popd(esi);                              /* pop esi */
            ii(0x100e_42fe, 1); popd(edx);                              /* pop edx */
            ii(0x100e_42ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_4300, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_4301, 1); retd(); return;                         /* ret */
        }
    }
}
