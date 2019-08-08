using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("16a3d499-a14a-48c1-bbe9-d7cc3c4b5b29")]
        public void my_strobj_is_single_ref()
        {
            ii(0x1014_251c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_2521, 5); calld(Definitions.sys_check_available_stack_size, 0x2_382c); /* call 0x10165d52 */
            ii(0x1014_2526, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_2527, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_2528, 1); pushd(edx);                             /* push edx */
            ii(0x1014_2529, 1); pushd(esi);                             /* push esi */
            ii(0x1014_252a, 1); pushd(edi);                             /* push edi */
            ii(0x1014_252b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_252c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_252e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_2534, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_2537, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_253a, 4); cmp(memd_a32[ds, eax + 0x8], 0x1);      /* cmp dword [eax+0x8], 0x1 */
            ii(0x1014_253e, 2); if(jnzd(0x1014_2546, 0x6)) goto l_0x1014_2546; /* jnz 0x10142546 */
            ii(0x1014_2540, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1014_2544, 2); jmpd(0x1014_254a, 0x4); goto l_0x1014_254a; /* jmp 0x1014254a */
        l_0x1014_2546:
            ii(0x1014_2546, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1014_254a:
            ii(0x1014_254a, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1014_254d, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1014_2550, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1014_2553, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_2555, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_2556, 1); popd(edi);                              /* pop edi */
            ii(0x1014_2557, 1); popd(esi);                              /* pop esi */
            ii(0x1014_2558, 1); popd(edx);                              /* pop edx */
            ii(0x1014_2559, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_255a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_255b, 1); retd(); return;                         /* ret */
        }
    }
}
