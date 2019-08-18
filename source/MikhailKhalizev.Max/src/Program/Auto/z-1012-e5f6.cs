using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5b33ac89-d9c7-4a25-b9b7-076bda2ee86d")]
        public void Method_1012_e5f6()
        {
            ii(0x1012_e5f6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_e5fb, 5); calld(Definitions.sys_check_available_stack_size, 0x3_7752); /* call 0x10165d52 */
            ii(0x1012_e600, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_e601, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_e602, 1); pushd(esi);                             /* push esi */
            ii(0x1012_e603, 1); pushd(edi);                             /* push edi */
            ii(0x1012_e604, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_e605, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_e607, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_e60d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_e610, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_e613, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_e618, 5); calld(/* sys */ 0x1016_a24c, 0x3_bc2f); /* call 0x1016a24c */
            ii(0x1012_e61d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_e620, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1012_e622, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_e625, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e628, 6); mov(eax, memd_a32[ds, eax + 0xde]);     /* mov eax, [eax+0xde] */
            ii(0x1012_e62e, 5); calld(0x100d_4ebc, -0x5_9777);          /* call 0x100d4ebc */
            ii(0x1012_e633, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_e636, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x1012_e638, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1012_e63a, 6); calld_abs(memd_a32[ds, 0x101b_ddf0]);   /* call dword [0x101bddf0] */
            ii(0x1012_e640, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_e642, 3); sub(edx, 0x6);                          /* sub edx, 0x6 */
            ii(0x1012_e645, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_e647, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_e64a, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_e64c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_e64f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e652, 4); mov(ax, memw_a32[ds, eax + 0x34]);      /* mov ax, [eax+0x34] */
            ii(0x1012_e656, 3); add(memd_a32[ss, ebp - 0xc], eax);      /* add [ebp-0xc], eax */
            ii(0x1012_e659, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e65c, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e65f, 5); calld(Definitions.my_1_get_count, -0x8_318c); /* call 0x100ab4d8 */
            ii(0x1012_e664, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1012_e668, 2); if(jled(0x1012_e6a0, 0x36)) goto l_0x1012_e6a0; /* jle 0x1012e6a0 */
            ii(0x1012_e66a, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_e66e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e671, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e674, 5); calld(0x1013_18f8, 0x327f);             /* call 0x101318f8 */
            ii(0x1012_e679, 5); calld(0x1013_19f4, 0x3376);             /* call 0x101319f4 */
            ii(0x1012_e67e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_e680, 2); if(jzd(0x1012_e6a0, 0x1e)) goto l_0x1012_e6a0; /* jz 0x1012e6a0 */
            ii(0x1012_e682, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_e686, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e689, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e68c, 5); calld(0x1013_18f8, 0x3267);             /* call 0x101318f8 */
            ii(0x1012_e691, 5); calld(0x1013_19f4, 0x335e);             /* call 0x101319f4 */
            ii(0x1012_e696, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_e698, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e69b, 5); calld(0x1012_e37c, -0x324);             /* call 0x1012e37c */
        l_0x1012_e6a0:
            ii(0x1012_e6a0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_e6a2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_e6a3, 1); popd(edi);                              /* pop edi */
            ii(0x1012_e6a4, 1); popd(esi);                              /* pop esi */
            ii(0x1012_e6a5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_e6a6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_e6a7, 1); retd(); return;                         /* ret */
        }
    }
}
