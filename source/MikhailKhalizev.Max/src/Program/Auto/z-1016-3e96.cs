using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("85ebc95b-a0b4-40af-8e1f-f3dafbc48ecf")]
        public void Method_1016_3e96()
        {
            ii(0x1016_3e96, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1016_3e9b, 5); calld(Definitions.sys_check_available_stack_size, 0x1eb2); /* call 0x10165d52 */
            ii(0x1016_3ea0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_3ea1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_3ea2, 1); pushd(esi);                             /* push esi */
            ii(0x1016_3ea3, 1); pushd(edi);                             /* push edi */
            ii(0x1016_3ea4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_3ea5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_3ea7, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_3ead, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_3eb0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_3eb3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_3eb6, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_3eb9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3ebc, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1016_3ec0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3ec3, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
            ii(0x1016_3ec6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3ec9, 4); mov(dx, memw_a32[ds, eax + 0xa]);       /* mov dx, [eax+0xa] */
            ii(0x1016_3ecd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3ed0, 4); mov(memw_a32[ds, eax + 0x2], dx);       /* mov [eax+0x2], dx */
            ii(0x1016_3ed4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3ed7, 4); mov(dx, memw_a32[ds, eax + 0xc]);       /* mov dx, [eax+0xc] */
            ii(0x1016_3edb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3ede, 4); mov(memw_a32[ds, eax + 0x4], dx);       /* mov [eax+0x4], dx */
            ii(0x1016_3ee2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3ee5, 4); mov(dx, memw_a32[ds, eax + 0xe]);       /* mov dx, [eax+0xe] */
            ii(0x1016_3ee9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3eec, 4); mov(memw_a32[ds, eax + 0x6], dx);       /* mov [eax+0x6], dx */
            ii(0x1016_3ef0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3ef3, 4); mov(dx, memw_a32[ds, eax + 0x10]);      /* mov dx, [eax+0x10] */
            ii(0x1016_3ef7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3efa, 4); mov(memw_a32[ds, eax + 0x8], dx);       /* mov [eax+0x8], dx */
            ii(0x1016_3efe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3f01, 4); mov(dx, memw_a32[ds, eax + 0x12]);      /* mov dx, [eax+0x12] */
            ii(0x1016_3f05, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3f08, 4); mov(memw_a32[ds, eax + 0xa], dx);       /* mov [eax+0xa], dx */
            ii(0x1016_3f0c, 7); mov(memd_a32[ss, ebp - 0xc], 0xc);      /* mov dword [ebp-0xc], 0xc */
            ii(0x1016_3f13, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_3f16, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_3f18, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_3f19, 1); popd(edi);                              /* pop edi */
            ii(0x1016_3f1a, 1); popd(esi);                              /* pop esi */
            ii(0x1016_3f1b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_3f1c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_3f1d, 1); retd(); return;                         /* ret */
        }
    }
}
