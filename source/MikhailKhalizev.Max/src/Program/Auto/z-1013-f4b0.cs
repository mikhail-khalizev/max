using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_f4b0-1c2ae70e")]
        public void Method_1013_f4b0()
        {
            ii(0x1013_f4b0, 5); push(0x30);                             /* push 0x30 */
            ii(0x1013_f4b5, 5); call(Definitions.sys_check_available_stack_size, 0x2_6898); /* call 0x10165d52 */
            ii(0x1013_f4ba, 1); push(esi);                              /* push esi */
            ii(0x1013_f4bb, 1); push(edi);                              /* push edi */
            ii(0x1013_f4bc, 1); push(ebp);                              /* push ebp */
            ii(0x1013_f4bd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_f4bf, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_f4c5, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_f4c8, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1013_f4cb, 3); mov(memd[ss, ebp - 0xc], ebx);          /* mov [ebp-0xc], ebx */
            ii(0x1013_f4ce, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1013_f4d1, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x1013_f4d6, 5); call(/* sys */ 0x1016_a24c, 0x2_ad71);  /* call 0x1016a24c */
            ii(0x1013_f4db, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1013_f4e1, 5); mov(edx, 0x13);                         /* mov edx, 0x13 */
            ii(0x1013_f4e6, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_f4e8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_f4ea, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_f4ed, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_f4ef, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1013_f4f1, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1013_f4f5, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_f4f8, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1013_f4fb, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1013_f4fe, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_f501, 5); cmp(memw[ss, ebp + 0x10], 0);           /* cmp word [ebp+0x10], 0x0 */
            ii(0x1013_f506, 2); if(jz(0x1013_f51f, 0x17)) goto l_0x1013_f51f; /* jz 0x1013f51f */
            ii(0x1013_f508, 2); push(4);                                /* push 0x4 */
            ii(0x1013_f50a, 4); movsx(ecx, memw[ss, ebp - 8]);          /* movsx ecx, word [ebp-0x8] */
            ii(0x1013_f50e, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x1013_f513, 4); movsx(edx, memw[ss, ebp + 0x10]);       /* movsx edx, word [ebp+0x10] */
            ii(0x1013_f517, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f51a, 5); call(0x1012_b658, -0x1_3ec7);           /* call 0x1012b658 */
        l_0x1013_f51f:
            ii(0x1013_f51f, 5); push(0xa2);                             /* push 0xa2 */
            ii(0x1013_f524, 4); movsx(ecx, memw[ss, ebp - 8]);          /* movsx ecx, word [ebp-0x8] */
            ii(0x1013_f528, 5); mov(ebx, 0x31);                         /* mov ebx, 0x31 */
            ii(0x1013_f52d, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1013_f530, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f533, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1013_f536, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */
            ii(0x1013_f53c, 4); cmp(memb[ss, ebp + 0x14], 0);           /* cmp byte [ebp+0x14], 0x0 */
            ii(0x1013_f540, 2); if(jz(0x1013_f564, 0x22)) goto l_0x1013_f564; /* jz 0x1013f564 */
            ii(0x1013_f542, 2); push(1);                                /* push 0x1 */
            ii(0x1013_f544, 2); push(0x12);                             /* push 0x12 */
            ii(0x1013_f546, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_f54a, 3); sub(eax, 2);                            /* sub eax, 0x2 */
            ii(0x1013_f54d, 1); push(eax);                              /* push eax */
            ii(0x1013_f54e, 5); mov(ecx, 0x12);                         /* mov ecx, 0x12 */
            ii(0x1013_f553, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1013_f558, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1013_f55c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f55f, 5); call(/* sys */ 0x1016_a5a0, 0x2_b03c);  /* call 0x1016a5a0 */
        l_0x1013_f564:
            ii(0x1013_f564, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_f566, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_f567, 1); pop(edi);                               /* pop edi */
            ii(0x1013_f568, 1); pop(esi);                               /* pop esi */
            ii(0x1013_f569, 3); ret(8);                                 /* ret 0x8 */
        }
    }
}
