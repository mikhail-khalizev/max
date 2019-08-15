using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1b31e006-d5a3-40ab-8913-fd90e9e77f05")]
        public void Method_1011_ac11()
        {
            ii(0x1011_ac11, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_ac16, 5); calld(Definitions.sys_check_available_stack_size, 0x4_b137); /* call 0x10165d52 */
            ii(0x1011_ac1b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_ac1c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_ac1d, 1); pushd(esi);                             /* push esi */
            ii(0x1011_ac1e, 1); pushd(edi);                             /* push edi */
            ii(0x1011_ac1f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_ac20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_ac22, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_ac28, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_ac2b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_ac2e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_ac31, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1011_ac34, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_ac37, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_ac3a, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_ac3d, 5); calld(0x100b_82bc, -0x6_2986);          /* call 0x100b82bc */
            ii(0x1011_ac42, 1); cwde();                                 /* cwde */
            ii(0x1011_ac43, 1); inc(edx);                               /* inc edx */
            ii(0x1011_ac44, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_ac46, 2); if(jged(0x1011_ac9b, 0x53)) goto l_0x1011_ac9b; /* jge 0x1011ac9b */
            ii(0x1011_ac48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_ac4b, 4); mov(ax, memw_a32[ds, eax + 0x16]);      /* mov ax, [eax+0x16] */
            ii(0x1011_ac4f, 1); inc(eax);                               /* inc eax */
            ii(0x1011_ac50, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_ac53, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_ac56, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_ac59, 5); calld(0x100b_827c, -0x6_29e2);          /* call 0x100b827c */
            ii(0x1011_ac5e, 4); movsx(ax, memb_a32[ds, eax]);           /* movsx ax, byte [eax] */
            ii(0x1011_ac62, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_ac65, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_ac68, 4); mov(ax, memw_a32[ds, eax + 0x16]);      /* mov ax, [eax+0x16] */
            ii(0x1011_ac6c, 1); inc(eax);                               /* inc eax */
            ii(0x1011_ac6d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_ac70, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_ac73, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_ac76, 5); calld(0x100b_827c, -0x6_29ff);          /* call 0x100b827c */
            ii(0x1011_ac7b, 5); movsx(ax, memb_a32[ds, eax + 0x1]);     /* movsx ax, byte [eax+0x1] */
            ii(0x1011_ac80, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_ac83, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1011_ac87, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_ac8b, 5); calld(0x1011_9e3a, -0xe56);             /* call 0x10119e3a */
            ii(0x1011_ac90, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_ac93, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_ac96, 5); calld(0x1011_7fb8, -0x2ce3);            /* call 0x10117fb8 */
        l_0x1011_ac9b:
            ii(0x1011_ac9b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_ac9d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_ac9e, 1); popd(edi);                              /* pop edi */
            ii(0x1011_ac9f, 1); popd(esi);                              /* pop esi */
            ii(0x1011_aca0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_aca1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_aca2, 1); retd(); return;                         /* ret */
        }
    }
}
