using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4935-7a1ef168")]
        public void Method_100e_4935()
        {
            ii(0x100e_4935, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x100e_493a, 5); calld(Definitions.sys_check_available_stack_size, 0x8_1413); /* call 0x10165d52 */
            ii(0x100e_493f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_4940, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_4941, 1); pushd(edx);                             /* push edx */
            ii(0x100e_4942, 1); pushd(esi);                             /* push esi */
            ii(0x100e_4943, 1); pushd(edi);                             /* push edi */
            ii(0x100e_4944, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_4945, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4947, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x100e_494d, 8); cmp(memw_a32[ds, 0x101b_7f18], 0);      /* cmp word [0x101b7f18], 0x0 */
            ii(0x100e_4955, 2); if(jzd(0x100e_496a, 0x13)) goto l_0x100e_496a; /* jz 0x100e496a */
            ii(0x100e_4957, 10); mov(memd_a32[ds, 0x101b_7f14], 0);     /* mov dword [0x101b7f14], 0x0 */
            ii(0x100e_4961, 9); mov(memw_a32[ds, 0x101b_7f18], 0);      /* mov word [0x101b7f18], 0x0 */
        l_0x100e_496a:
            ii(0x100e_496a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_496b, 1); popd(edi);                              /* pop edi */
            ii(0x100e_496c, 1); popd(esi);                              /* pop esi */
            ii(0x100e_496d, 1); popd(edx);                              /* pop edx */
            ii(0x100e_496e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_496f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_4970, 1); retd(); return;                         /* ret */
        }
    }
}
