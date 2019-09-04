using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_bfde-20b78fb7")]
        public void Method_100f_bfde()
        {
            ii(0x100f_bfde, 5); push(0x30);                             /* push 0x30 */
            ii(0x100f_bfe3, 5); call(Definitions.sys_check_available_stack_size, 0x6_9d6a); /* call 0x10165d52 */
            ii(0x100f_bfe8, 1); push(ebx);                              /* push ebx */
            ii(0x100f_bfe9, 1); push(ecx);                              /* push ecx */
            ii(0x100f_bfea, 1); push(edx);                              /* push edx */
            ii(0x100f_bfeb, 1); push(esi);                              /* push esi */
            ii(0x100f_bfec, 1); push(edi);                              /* push edi */
            ii(0x100f_bfed, 1); push(ebp);                              /* push ebp */
            ii(0x100f_bfee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_bff0, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_bff6, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100f_bff9, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x100f_bffd, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_c000, 5); call(Definitions.my_string_ctor, 0x4_5ae3); /* call 0x10141ae8 */
            ii(0x100f_c005, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100f_c008, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x100f_c00c, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_c010, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100f_c013, 6); mov(edx, memd[ds, eax + 0x101b_b444]);  /* mov edx, [eax+0x101bb444] */
            ii(0x100f_c019, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_c01c, 5); call(0x1014_21cb, 0x4_61aa);            /* call 0x101421cb */
            ii(0x100f_c021, 5); mov(edx, StringDefinitions.Control27);  /* mov edx, 0x101a2965 */
            ii(0x100f_c026, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_c029, 5); call(Definitions.my_string_append_char_ptr, 0x4_5d11); /* call 0x10141d3f */
            ii(0x100f_c02e, 5); mov(edx, StringDefinitions.SelectStartingLocation2); /* mov edx, 0x101a2968 */
            ii(0x100f_c033, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_c036, 5); call(Definitions.my_string_append_char_ptr, 0x4_5d04); /* call 0x10141d3f */
            ii(0x100f_c03b, 5); call(0x100c_aa00, -0x3_1640);           /* call 0x100caa00 */
            ii(0x100f_c040, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_c045, 1); push(eax);                              /* push eax */
            ii(0x100f_c046, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100f_c04b, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100f_c050, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_c052, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_c055, 5); call(Definitions.my_strobj_c_str_v2, -0x7_2892); /* call 0x100897c8 */
            ii(0x100f_c05a, 5); call(0x1011_5d23, 0x1_9cc4);            /* call 0x10115d23 */
            ii(0x100f_c05f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_c061, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100f_c064, 5); call(Definitions.my_string_dtor, 0x4_5ac1); /* call 0x10141b2a */
            ii(0x100f_c069, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_c06b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_c06c, 1); pop(edi);                               /* pop edi */
            ii(0x100f_c06d, 1); pop(esi);                               /* pop esi */
            ii(0x100f_c06e, 1); pop(edx);                               /* pop edx */
            ii(0x100f_c06f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_c070, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_c071, 1); ret();                                  /* ret */
        }
    }
}
