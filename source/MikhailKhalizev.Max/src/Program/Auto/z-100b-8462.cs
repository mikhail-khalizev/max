using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a641c9d-cef5-4d0b-953a-1426516a013a")]
        public void Method_100b_8462()
        {
            ii(0x100b_8462, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_8467, 5); calld(Definitions.sys_check_available_stack_size, 0xa_d8e6); /* call 0x10165d52 */
            ii(0x100b_846c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_846d, 1); pushd(esi);                             /* push esi */
            ii(0x100b_846e, 1); pushd(edi);                             /* push edi */
            ii(0x100b_846f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8470, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8472, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_8478, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_847b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_847e, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100b_8481, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8484, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_8487, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x100b_848a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_848d, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_8490, 4); mov(memw_a32[ds, edx + 0x2], ax);       /* mov [edx+0x2], ax */
            ii(0x100b_8494, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100b_8498, 5); calld(0x100c_dec2, 0x1_5a25);           /* call 0x100cdec2 */
            ii(0x100b_849d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_849f, 2); if(jnzd(0x100b_84b2, 0x11)) goto l_0x100b_84b2; /* jnz 0x100b84b2 */
            ii(0x100b_84a1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_84a4, 5); mov(memw_a32[ds, eax], 0xffff);         /* mov word [eax], 0xffff */
            ii(0x100b_84a9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_84ac, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
        l_0x100b_84b2:
            ii(0x100b_84b2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_84b5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_84b8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_84bb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_84bd, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_84be, 1); popd(edi);                              /* pop edi */
            ii(0x100b_84bf, 1); popd(esi);                              /* pop esi */
            ii(0x100b_84c0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_84c1, 1); retd(); return;                         /* ret */
        }
    }
}
