using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("67b841b6-c198-4268-a8ee-cb7f43c7c50d")]
        public void Method_1008_cbf1()
        {
            ii(0x1008_cbf1, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1008_cbf6, 5); calld(Definitions.sys_check_available_stack_size, 0xd_9157); /* call 0x10165d52 */
            ii(0x1008_cbfb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_cbfc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_cbfd, 1); pushd(esi);                             /* push esi */
            ii(0x1008_cbfe, 1); pushd(edi);                             /* push edi */
            ii(0x1008_cbff, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_cc00, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_cc02, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1008_cc08, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_cc0b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_cc0e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_cc11, 3); mov(eax, memd_a32[ds, eax + 0x21]);     /* mov eax, [eax+0x21] */
            ii(0x1008_cc14, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_cc17, 1); inc(eax);                               /* inc eax */
            ii(0x1008_cc18, 1); pushd(eax);                             /* push eax */
            ii(0x1008_cc19, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_cc1c, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x1008_cc1f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_cc22, 1); inc(eax);                               /* inc eax */
            ii(0x1008_cc23, 1); pushd(eax);                             /* push eax */
            ii(0x1008_cc24, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_cc27, 3); mov(eax, memd_a32[ds, eax + 0x11]);     /* mov eax, [eax+0x11] */
            ii(0x1008_cc2a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_cc2d, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1008_cc30, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x1008_cc36, 5); mov(eax, StringDefinitions.CreateASAtII); /* mov eax, 0x101a0476 */
            ii(0x1008_cc3b, 1); pushd(eax);                             /* push eax */
            ii(0x1008_cc3c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_cc3f, 1); pushd(eax);                             /* push eax */
            ii(0x1008_cc40, 5); calld(Definitions.sys_sprintf, 0xd_92bc); /* call 0x10165f01 */
            ii(0x1008_cc45, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1008_cc48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_cc4b, 3); mov(al, memb_a32[ds, eax + 0x25]);      /* mov al, [eax+0x25] */
            ii(0x1008_cc4e, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1008_cc51, 5); if(jmpd_func(0x1008_cd68, 0x112)) return; /* jmp 0x1008cd68 */
        }
    }
}
