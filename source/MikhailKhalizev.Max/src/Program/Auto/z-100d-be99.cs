using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_be99-5c0b38e3")]
        public void Method_100d_be99()
        {
            ii(0x100d_be99, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_be9e, 5); calld(Definitions.sys_check_available_stack_size, 0x8_9eaf); /* call 0x10165d52 */
            ii(0x100d_bea3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_bea4, 1); pushd(esi);                             /* push esi */
            ii(0x100d_bea5, 1); pushd(edi);                             /* push edi */
            ii(0x100d_bea6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_bea7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_bea9, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100d_beaf, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_beb2, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100d_beb5, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100d_beb8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_bebb, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_bebe, 5); calld(Definitions.my_2_get_count, -0x5_0b5b); /* call 0x1008b368 */
            ii(0x100d_bec3, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100d_bec7, 2); if(jged(0x100d_bed7, 0xe)) goto l_0x100d_bed7; /* jge 0x100dbed7 */
            ii(0x100d_bec9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_becc, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_becf, 5); calld(Definitions.my_2_get_count, -0x5_0b6c); /* call 0x1008b368 */
            ii(0x100d_bed4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x100d_bed7:
            ii(0x100d_bed7, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_bedb, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_bee2, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100d_bee5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_bee8, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100d_beeb, 5); calld(0x100c_aa88, -0x1_1468);          /* call 0x100caa88 */
            ii(0x100d_bef0, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_bef4, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100d_bef8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_befb, 5); calld(0x100d_0672, -0xb88e);            /* call 0x100d0672 */
            ii(0x100d_bf00, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_bf02, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_bf03, 1); popd(edi);                              /* pop edi */
            ii(0x100d_bf04, 1); popd(esi);                              /* pop esi */
            ii(0x100d_bf05, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_bf06, 1); retd(); return;                         /* ret */
        }
    }
}
