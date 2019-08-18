using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_cbc4-698224ab")]
        public void Method_1009_cbc4()
        {
            ii(0x1009_cbc4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_cbc9, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9184); /* call 0x10165d52 */
            ii(0x1009_cbce, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_cbcf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_cbd0, 1); pushd(esi);                             /* push esi */
            ii(0x1009_cbd1, 1); pushd(edi);                             /* push edi */
            ii(0x1009_cbd2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_cbd3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_cbd5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_cbdb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_cbde, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_cbe1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_cbe4, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1009_cbe6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_cbe9, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x1009_cbeb, 2); if(jzd(0x1009_cbf3, 0x6)) goto l_0x1009_cbf3; /* jz 0x1009cbf3 */
            ii(0x1009_cbed, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_cbf1, 2); jmpd(0x1009_cbf7, 0x4); goto l_0x1009_cbf7; /* jmp 0x1009cbf7 */
        l_0x1009_cbf3:
            ii(0x1009_cbf3, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1009_cbf7:
            ii(0x1009_cbf7, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_cbfa, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1009_cbfd, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1009_cc00, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_cc02, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_cc03, 1); popd(edi);                              /* pop edi */
            ii(0x1009_cc04, 1); popd(esi);                              /* pop esi */
            ii(0x1009_cc05, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_cc06, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_cc07, 1); retd(); return;                         /* ret */
        }
    }
}
