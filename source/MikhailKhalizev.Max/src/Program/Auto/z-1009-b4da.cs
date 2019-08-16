using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1cc9da31-fddb-485e-95a1-7f09f92c7cac")]
        public void Method_1009_b4da()
        {
            ii(0x1009_b4da, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_b4df, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a86e); /* call 0x10165d52 */
            ii(0x1009_b4e4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b4e5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b4e6, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b4e7, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b4e8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b4e9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b4eb, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_b4f1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b4f4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_b4f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b4fa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_b4fd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_b500, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_b503, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_b506, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x1009_b509, 2); cmp(al, 0x19);                          /* cmp al, 0x19 */
            ii(0x1009_b50b, 2); if(jnzd(0x1009_b514, 0x7)) goto l_0x1009_b514; /* jnz 0x1009b514 */
            ii(0x1009_b50d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b510, 4); mov(memb_a32[ds, eax + 0x1d], 0);       /* mov byte [eax+0x1d], 0x0 */
        l_0x1009_b514:
            ii(0x1009_b514, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b516, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b517, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b518, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b519, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b51a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b51b, 1); retd(); return;                         /* ret */
        }
    }
}