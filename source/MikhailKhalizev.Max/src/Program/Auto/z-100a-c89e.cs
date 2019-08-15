using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cb2ed82c-9fcb-4aee-ab95-6d622c58035b")]
        public void Method_100a_c89e()
        {
            ii(0x100a_c89e, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_c8a3, 5); calld(Definitions.sys_check_available_stack_size, 0xb_94aa); /* call 0x10165d52 */
            ii(0x100a_c8a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_c8a9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_c8aa, 1); pushd(esi);                             /* push esi */
            ii(0x100a_c8ab, 1); pushd(edi);                             /* push edi */
            ii(0x100a_c8ac, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_c8ad, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c8af, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_c8b5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_c8b8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_c8bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_c8be, 3); mov(al, memb_a32[ds, eax + 0x19]);      /* mov al, [eax+0x19] */
            ii(0x100a_c8c1, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100a_c8c4, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100a_c8c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_c8c9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_c8ca, 1); popd(edi);                              /* pop edi */
            ii(0x100a_c8cb, 1); popd(esi);                              /* pop esi */
            ii(0x100a_c8cc, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_c8cd, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_c8ce, 1); retd(); return;                         /* ret */
        }
    }
}
