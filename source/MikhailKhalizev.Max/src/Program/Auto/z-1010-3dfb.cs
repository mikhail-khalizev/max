using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eeb876d4-8d4c-47f9-baa7-3fafc41e7c05")]
        public void Method_1010_3dfb()
        {
            ii(0x1010_3dfb, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_3e00, 5); calld(Definitions.sys_check_available_stack_size, 0x6_1f4d); /* call 0x10165d52 */
            ii(0x1010_3e05, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_3e06, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_3e07, 1); pushd(esi);                             /* push esi */
            ii(0x1010_3e08, 1); pushd(edi);                             /* push edi */
            ii(0x1010_3e09, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_3e0a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3e0c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_3e12, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_3e15, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_3e18, 5); mov(edx, 0x101b_56fc);                  /* mov edx, 0x101b56fc */
            ii(0x1010_3e1d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3e20, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1010_3e23, 5); calld(Definitions.sys_call_dtor_arr, 0x6_2190); /* call 0x10165fb8 */
            ii(0x1010_3e28, 5); calld(Definitions.sys_delete_arr, 0x6_21ab); /* call 0x10165fd8 */
            ii(0x1010_3e2d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3e30, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_3e33, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_3e36, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3e38, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_3e39, 1); popd(edi);                              /* pop edi */
            ii(0x1010_3e3a, 1); popd(esi);                              /* pop esi */
            ii(0x1010_3e3b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_3e3c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_3e3d, 1); retd(); return;                         /* ret */
        }
    }
}
