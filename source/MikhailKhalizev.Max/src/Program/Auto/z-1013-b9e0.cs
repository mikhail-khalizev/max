using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b36b82b9-c727-4dc0-bdde-081c869b4bcb")]
        public void Method_1013_b9e0()
        {
            ii(0x1013_b9e0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_b9e5, 5); calld(Definitions.sys_check_available_stack_size, 0x2a368); /* call 0x10165d52 */
            ii(0x1013_b9ea, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b9eb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b9ec, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b9ed, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b9ee, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b9ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b9f1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_b9f7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b9fa, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_b9fd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_ba00, 5); calld(0x1013_ba3c, 0x37);               /* call 0x1013ba3c */
            ii(0x1013_ba05, 5); mov(edx, 0x101a_cc60);                  /* mov edx, 0x101acc60 */ /* "rb" */
            ii(0x1013_ba0a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_ba0d, 5); calld(Definitions.my_fopen, -0x4c5f3);  /* call 0x100ef41f */
            ii(0x1013_ba12, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_ba14, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_ba17, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1013_ba19, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_ba1c, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1013_ba1f, 2); if(jzd(0x1013_ba27, 0x6)) goto l_0x1013_ba27; /* jz 0x1013ba27 */
            ii(0x1013_ba21, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1013_ba25, 2); jmpd(0x1013_ba2b, 0x4); goto l_0x1013_ba2b; /* jmp 0x1013ba2b */
        l_0x1013_ba27:
            ii(0x1013_ba27, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1013_ba2b:
            ii(0x1013_ba2b, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1013_ba2e, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1013_ba31, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1013_ba34, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_ba36, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_ba37, 1); popd(edi);                              /* pop edi */
            ii(0x1013_ba38, 1); popd(esi);                              /* pop esi */
            ii(0x1013_ba39, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_ba3a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_ba3b, 1); retd(); return;                         /* ret */
        }
    }
}
