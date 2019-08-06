using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f92a197d-2851-49dc-af25-a1750506e4bf")]
        public void Method_100a_267a()
        {
            ii(0x100a_267a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_267f, 5); calld(Definitions.sys_check_available_stack_size, 0xc36ce); /* call 0x10165d52 */
            ii(0x100a_2684, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2685, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2686, 1); pushd(edx);                             /* push edx */
            ii(0x100a_2687, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2688, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2689, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_268a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_268c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_2692, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_2695, 5); mov(ebx, StringDefinitions.Computer);   /* mov ebx, 0x101a0c17 */
            ii(0x100a_269a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100a_269d, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x100a_269f, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x100a_26a2, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x100a_26a7, 5); calld(0x1010_6205, 0x63b59);            /* call 0x10106205 */
            ii(0x100a_26ac, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_26b0, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_26b6, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x100a_26bb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_26bd, 5); calld(0x100c_50aa, 0x229e8);            /* call 0x100c50aa */
            ii(0x100a_26c2, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100a_26c5, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_26c8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_26ca, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_26cb, 1); popd(edi);                              /* pop edi */
            ii(0x100a_26cc, 1); popd(esi);                              /* pop esi */
            ii(0x100a_26cd, 1); popd(edx);                              /* pop edx */
            ii(0x100a_26ce, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_26cf, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_26d0, 1); retd(); return;                         /* ret */
        }
    }
}
