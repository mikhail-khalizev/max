using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6391c7d7-dc67-4cc5-be13-db055b07ec10")]
        public void Method_1016_3dd9()
        {
            ii(0x1016_3dd9, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1016_3dde, 5); calld(Definitions.sys_check_available_stack_size, 0x1f6f); /* call 0x10165d52 */
            ii(0x1016_3de3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_3de4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_3de5, 1); pushd(esi);                             /* push esi */
            ii(0x1016_3de6, 1); pushd(edi);                             /* push edi */
            ii(0x1016_3de7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_3de8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_3dea, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_3df0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_3df3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_3df6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3df9, 5); calld(0x1014_4ef4, -0x1ef0a);           /* call 0x10144ef4 */
            ii(0x1016_3dfe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_3e01, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_3e04, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_3e07, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3e0a, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_7524); /* mov dword [eax+0x2], 0x101b7524 */
            ii(0x1016_3e11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_3e14, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_3e17, 4); mov(memw_a32[ds, edx + 0x14], ax);      /* mov [edx+0x14], ax */
            ii(0x1016_3e1b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3e1e, 6); mov(memw_a32[ds, eax + 0x8], 0);        /* mov word [eax+0x8], 0x0 */
            ii(0x1016_3e24, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3e27, 6); mov(memw_a32[ds, eax + 0xa], 0);        /* mov word [eax+0xa], 0x0 */
            ii(0x1016_3e2d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3e30, 6); mov(memw_a32[ds, eax + 0xc], 0);        /* mov word [eax+0xc], 0x0 */
            ii(0x1016_3e36, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3e39, 6); mov(memw_a32[ds, eax + 0xe], 0);        /* mov word [eax+0xe], 0x0 */
            ii(0x1016_3e3f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3e42, 6); mov(memw_a32[ds, eax + 0x10], 0);       /* mov word [eax+0x10], 0x0 */
            ii(0x1016_3e48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3e4b, 6); mov(memw_a32[ds, eax + 0x12], 0);       /* mov word [eax+0x12], 0x0 */
            ii(0x1016_3e51, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3e54, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_3e57, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3e5a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_3e5c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_3e5d, 1); popd(edi);                              /* pop edi */
            ii(0x1016_3e5e, 1); popd(esi);                              /* pop esi */
            ii(0x1016_3e5f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_3e60, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_3e61, 1); retd(); return;                         /* ret */
        }
    }
}