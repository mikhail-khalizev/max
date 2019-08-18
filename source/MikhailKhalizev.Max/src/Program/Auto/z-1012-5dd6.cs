using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d08cec2b-d795-4ca3-9cb7-5a6f58095924")]
        public void Method_1012_5dd6()
        {
            ii(0x1012_5dd6, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_5ddb, 5); calld(Definitions.sys_check_available_stack_size, 0x3_ff72); /* call 0x10165d52 */
            ii(0x1012_5de0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_5de1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_5de2, 1); pushd(esi);                             /* push esi */
            ii(0x1012_5de3, 1); pushd(edi);                             /* push edi */
            ii(0x1012_5de4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_5de5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_5de7, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_5ded, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_5df0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_5df3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_5df6, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_5df9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5dfc, 5); calld(0x1016_186c, 0x3_ba6b);           /* call 0x1016186c */
            ii(0x1012_5e01, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_5e04, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1012_5e06, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5e09, 3); mov(memb_a32[ds, eax + 0x3d], dl);      /* mov [eax+0x3d], dl */
            ii(0x1012_5e0c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_5e0f, 3); mov(dl, memb_a32[ds, eax + 0x1]);       /* mov dl, [eax+0x1] */
            ii(0x1012_5e12, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5e15, 3); mov(memb_a32[ds, eax + 0x3e], dl);      /* mov [eax+0x3e], dl */
            ii(0x1012_5e18, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_5e1b, 3); mov(dl, memb_a32[ds, eax + 0x2]);       /* mov dl, [eax+0x2] */
            ii(0x1012_5e1e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5e21, 3); mov(memb_a32[ds, eax + 0x3f], dl);      /* mov [eax+0x3f], dl */
            ii(0x1012_5e24, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_5e27, 3); mov(dl, memb_a32[ds, eax + 0x3]);       /* mov dl, [eax+0x3] */
            ii(0x1012_5e2a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5e2d, 3); mov(memb_a32[ds, eax + 0x40], dl);      /* mov [eax+0x40], dl */
            ii(0x1012_5e30, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_5e33, 3); mov(dl, memb_a32[ds, eax + 0x4]);       /* mov dl, [eax+0x4] */
            ii(0x1012_5e36, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5e39, 3); mov(memb_a32[ds, eax + 0x5b], dl);      /* mov [eax+0x5b], dl */
            ii(0x1012_5e3c, 7); mov(memd_a32[ss, ebp - 0xc], 0x5);      /* mov dword [ebp-0xc], 0x5 */
            ii(0x1012_5e43, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_5e46, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_5e48, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_5e49, 1); popd(edi);                              /* pop edi */
            ii(0x1012_5e4a, 1); popd(esi);                              /* pop esi */
            ii(0x1012_5e4b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_5e4c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_5e4d, 1); retd(); return;                         /* ret */
        }
    }
}
