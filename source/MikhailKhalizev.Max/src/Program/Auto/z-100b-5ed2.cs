using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f1932f1b-a4ac-4e83-9e82-5bdfb6077d7f")]
        public void Method_100b_5ed2()
        {
            ii(0x100b_5ed2, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_5ed7, 5); calld(Definitions.sys_check_available_stack_size, 0xa_fe76); /* call 0x10165d52 */
            ii(0x100b_5edc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_5edd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_5ede, 1); pushd(esi);                             /* push esi */
            ii(0x100b_5edf, 1); pushd(edi);                             /* push edi */
            ii(0x100b_5ee0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_5ee1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5ee3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_5ee9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_5eec, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_5eef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5ef2, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_5ef7, 2); if(jzd(0x100b_5f03, 0xa)) goto l_0x100b_5f03; /* jz 0x100b5f03 */
            ii(0x100b_5ef9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5efc, 5); cmp(memw_a32[ds, eax + 0x8], 0x48);     /* cmp word [eax+0x8], 0x48 */
            ii(0x100b_5f01, 2); if(jnzd(0x100b_5f05, 0x2)) goto l_0x100b_5f05; /* jnz 0x100b5f05 */
        l_0x100b_5f03:
            ii(0x100b_5f03, 2); jmpd(0x100b_5f0f, 0xa); goto l_0x100b_5f0f; /* jmp 0x100b5f0f */
        l_0x100b_5f05:
            ii(0x100b_5f05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5f08, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x100b_5f0d, 2); if(jnzd(0x100b_5f15, 0x6)) goto l_0x100b_5f15; /* jnz 0x100b5f15 */
        l_0x100b_5f0f:
            ii(0x100b_5f0f, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_5f13, 2); jmpd(0x100b_5f19, 0x4); goto l_0x100b_5f19; /* jmp 0x100b5f19 */
        l_0x100b_5f15:
            ii(0x100b_5f15, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x100b_5f19:
            ii(0x100b_5f19, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_5f1c, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100b_5f1f, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100b_5f22, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5f24, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_5f25, 1); popd(edi);                              /* pop edi */
            ii(0x100b_5f26, 1); popd(esi);                              /* pop esi */
            ii(0x100b_5f27, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_5f28, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_5f29, 1); retd(); return;                         /* ret */
        }
    }
}