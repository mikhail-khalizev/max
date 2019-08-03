using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d0b8e89-6b1f-43da-8e96-e1165c47f534")]
        public void Method_100c_fb73()
        {
            ii(0x100c_fb73, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_fb78, 5); calld(Definitions.sys_check_available_stack_size, 0x961d5); /* call 0x10165d52 */
            ii(0x100c_fb7d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_fb7e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_fb7f, 1); pushd(esi);                             /* push esi */
            ii(0x100c_fb80, 1); pushd(edi);                             /* push edi */
            ii(0x100c_fb81, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_fb82, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_fb84, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_fb8a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_fb8d, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100c_fb90, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_fb93, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x100c_fb96, 2); if(jzd(0x100c_fbb6, 0x1e)) goto l_0x100c_fbb6; /* jz 0x100cfbb6 */
            ii(0x100c_fb98, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_fb9a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_fb9c, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100c_fb9f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_fba2, 2); mov(ecx, memd_a32[ds, edx]);            /* mov ecx, [edx] */
            ii(0x100c_fba4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_fba6, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100c_fba8, 5); calld(/* sys */ 0x1016_98f4, 0x99d47);  /* call 0x101698f4 */
            ii(0x100c_fbad, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100c_fbb0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_fbb3, 3); mov(memb_a32[ds, edx + 0x37], al);      /* mov [edx+0x37], al */
        l_0x100c_fbb6:
            ii(0x100c_fbb6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_fbb8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_fbb9, 1); popd(edi);                              /* pop edi */
            ii(0x100c_fbba, 1); popd(esi);                              /* pop esi */
            ii(0x100c_fbbb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_fbbc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_fbbd, 1); retd(); return;                         /* ret */
        }
    }
}
