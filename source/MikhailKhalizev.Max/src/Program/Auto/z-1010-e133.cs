using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e133-128601ab")]
        public void Method_1010_e133()
        {
            ii(0x1010_e133, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_e138, 5); calld(Definitions.sys_check_available_stack_size, 0x5_7c15); /* call 0x10165d52 */
            ii(0x1010_e13d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_e13e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_e13f, 1); pushd(edx);                             /* push edx */
            ii(0x1010_e140, 1); pushd(esi);                             /* push esi */
            ii(0x1010_e141, 1); pushd(edi);                             /* push edi */
            ii(0x1010_e142, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_e143, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_e145, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_e14b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_e14e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_e150, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e153, 3); mov(al, memb_a32[ds, eax + 0x10]);      /* mov al, [eax+0x10] */
            ii(0x1010_e156, 2); add(al, 0x5f);                          /* add al, 0x5f */
            ii(0x1010_e158, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1010_e15b, 5); calld(0x100c_aafc, -0x4_3664);          /* call 0x100caafc */
            ii(0x1010_e160, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e163, 5); calld(0x1010_de32, -0x336);             /* call 0x1010de32 */
            ii(0x1010_e168, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_e16a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_e16b, 1); popd(edi);                              /* pop edi */
            ii(0x1010_e16c, 1); popd(esi);                              /* pop esi */
            ii(0x1010_e16d, 1); popd(edx);                              /* pop edx */
            ii(0x1010_e16e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_e16f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_e170, 1); retd(); return;                         /* ret */
        }
    }
}
