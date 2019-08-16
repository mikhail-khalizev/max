using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5f5ec701-951d-4a72-bc04-df6c20f9c978")]
        public void my_ctor_c16()
        {
            ii(0x100c_ce2a, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_ce2f, 5); calld(Definitions.sys_check_available_stack_size, 0x9_8f1e); /* call 0x10165d52 */
            ii(0x100c_ce34, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_ce35, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_ce36, 1); pushd(esi);                             /* push esi */
            ii(0x100c_ce37, 1); pushd(edi);                             /* push edi */
            ii(0x100c_ce38, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_ce39, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ce3b, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_ce41, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_ce44, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_ce47, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_ce4a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_ce4d, 5); calld(Definitions.my_ctor_c15, -0x15ca); /* call 0x100cb888 */
            ii(0x100c_ce52, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_ce55, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100c_ce58, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_ce5b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_ce5e, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_5a60); /* mov dword [eax+0x2], 0x101b5a60 */
            ii(0x100c_ce65, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_ce68, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_ce6b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ce6e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ce70, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_ce71, 1); popd(edi);                              /* pop edi */
            ii(0x100c_ce72, 1); popd(esi);                              /* pop esi */
            ii(0x100c_ce73, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_ce74, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_ce75, 1); retd(); return;                         /* ret */
        }
    }
}