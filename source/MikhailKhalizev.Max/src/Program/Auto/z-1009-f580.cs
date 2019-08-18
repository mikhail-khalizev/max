using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5ae102c-9b51-462c-bbdc-7e05bda6d8e3")]
        public void Method_1009_f580()
        {
            ii(0x1009_f580, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_f585, 5); calld(Definitions.sys_check_available_stack_size, 0xc_67c8); /* call 0x10165d52 */
            ii(0x1009_f58a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_f58b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_f58c, 1); pushd(edx);                             /* push edx */
            ii(0x1009_f58d, 1); pushd(esi);                             /* push esi */
            ii(0x1009_f58e, 1); pushd(edi);                             /* push edi */
            ii(0x1009_f58f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_f590, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_f592, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1009_f598, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_f59b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_f59e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f5a1, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f5a4, 5); calld(0x1007_6574, -0x2_9035);          /* call 0x10076574 */
            ii(0x1009_f5a9, 5); calld(0x1015_27ed, 0xb_323f);           /* call 0x101527ed */
            ii(0x1009_f5ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_f5b0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_f5b1, 1); popd(edi);                              /* pop edi */
            ii(0x1009_f5b2, 1); popd(esi);                              /* pop esi */
            ii(0x1009_f5b3, 1); popd(edx);                              /* pop edx */
            ii(0x1009_f5b4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_f5b5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_f5b6, 1); retd(); return;                         /* ret */
        }
    }
}
