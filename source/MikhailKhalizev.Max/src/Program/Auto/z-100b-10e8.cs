using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_10e8-10446c9d")]
        public void Method_100b_10e8()
        {
            ii(0x100b_10e8, 5); push(0x40);                             /* push 0x40 */
            ii(0x100b_10ed, 5); call(Definitions.sys_check_available_stack_size, 0xb_4c60); /* call 0x10165d52 */
            ii(0x100b_10f2, 1); push(ecx);                              /* push ecx */
            ii(0x100b_10f3, 1); push(esi);                              /* push esi */
            ii(0x100b_10f4, 1); push(edi);                              /* push edi */
            ii(0x100b_10f5, 1); push(ebp);                              /* push ebp */
            ii(0x100b_10f6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_10f8, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100b_10fe, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_1101, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100b_1104, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100b_1107, 3); lea(edx, memd[ss, ebp - 0x2c]);         /* lea edx, [ebp-0x2c] */
            ii(0x100b_110a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_110d, 5); call(0x100a_2d3d, -0xe3d5);             /* call 0x100a2d3d */
            ii(0x100b_1112, 4); or(memb[ss, ebp - 0x10], 1);            /* or byte [ebp-0x10], 0x1 */
            ii(0x100b_1116, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x100b_1119, 5); call(0x1008_a634, -0x2_6aea);           /* call 0x1008a634 */
            ii(0x100b_111e, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100b_1121, 4); and(memb[ss, ebp - 0x10], -2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100b_1125, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_1128, 5); call(0x100b_7c44, 0x6b17);              /* call 0x100b7c44 */
            ii(0x100b_112d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_112f, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100b_1132, 5); call(0x100b_7b28, 0x69f1);              /* call 0x100b7b28 */
            ii(0x100b_1137, 2); jmp(0x100b_1141, 8); goto l_0x100b_1141; /* jmp 0x100b1141 */
        l_0x100b_1139:
            ii(0x100b_1139, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100b_113c, 5); call(0x1007_6bf8, -0x3_a549);           /* call 0x10076bf8 */
        l_0x100b_1141:
            ii(0x100b_1141, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1143, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100b_1146, 5); call(0x1013_ad71, 0x8_9c26);            /* call 0x1013ad71 */
            ii(0x100b_114b, 2); test(al, al);                           /* test al, al */
            ii(0x100b_114d, 2); if(jz(0x100b_11b8, 0x69)) goto l_0x100b_11b8; /* jz 0x100b11b8 */
            ii(0x100b_114f, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100b_1152, 5); call(0x100b_7a14, 0x68bd);              /* call 0x100b7a14 */
            ii(0x100b_1157, 5); call(0x100b_7d68, 0x6c0c);              /* call 0x100b7d68 */
            ii(0x100b_115c, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_115f, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100b_1163, 2); if(jz(0x100b_11b6, 0x51)) goto l_0x100b_11b6; /* jz 0x100b11b6 */
            ii(0x100b_1165, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_1168, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x100b_116c, 3); sub(eax, memd[ss, ebp - 0x2a]);         /* sub eax, [ebp-0x2a] */
            ii(0x100b_116f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_1172, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_1175, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x100b_1179, 3); sub(eax, memd[ss, ebp - 0x2c]);         /* sub eax, [ebp-0x2c] */
            ii(0x100b_117c, 1); cwde();                                 /* cwde */
            ii(0x100b_117d, 5); call(0x100a_5f65, -0xb21d);             /* call 0x100a5f65 */
            ii(0x100b_1182, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_1185, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1187, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x100b_118a, 5); call(0x1013_ad11, 0x8_9b82);            /* call 0x1013ad11 */
            ii(0x100b_118f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1191, 2); if(jnz(0x100b_119c, 9)) goto l_0x100b_119c; /* jnz 0x100b119c */
            ii(0x100b_1193, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_1196, 4); cmp(ax, memw[ss, ebp - 0x18]);          /* cmp ax, [ebp-0x18] */
            ii(0x100b_119a, 2); if(jle(0x100b_11b6, 0x1a)) goto l_0x100b_11b6; /* jle 0x100b11b6 */
        l_0x100b_119c:
            ii(0x100b_119c, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100b_119f, 5); call(0x100b_7a48, 0x68a4);              /* call 0x100b7a48 */
            ii(0x100b_11a4, 3); lea(ebx, memd[ss, ebp - 0x28]);         /* lea ebx, [ebp-0x28] */
            ii(0x100b_11a7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_11a9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_11ab, 5); call(0x100b_7cfc, 0x6b4c);              /* call 0x100b7cfc */
            ii(0x100b_11b0, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_11b3, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x100b_11b6:
            ii(0x100b_11b6, 2); jmp(0x100b_1139, -0x7f); goto l_0x100b_1139; /* jmp 0x100b1139 */
        l_0x100b_11b8:
            ii(0x100b_11b8, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x100b_11bb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_11be, 5); call(0x1008_a5ac, -0x2_6c17);           /* call 0x1008a5ac */
            ii(0x100b_11c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_11c5, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100b_11c8, 5); call(0x100b_7650, 0x6483);              /* call 0x100b7650 */
            ii(0x100b_11cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_11cf, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x100b_11d2, 5); call(0x1008_8d4c, -0x2_848b);           /* call 0x10088d4c */
            ii(0x100b_11d7, 2); jmp(0x100b_11ed, 0x14); goto l_0x100b_11ed; /* jmp 0x100b11ed */
        //  ii(0x100b_11d9, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100b_11db, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
        //  ii(0x100b_11de, 5); call(0x100b_7650, 0x646d);              /* call 0x100b7650 */
        //  ii(0x100b_11e3, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100b_11e5, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
        //  ii(0x100b_11e8, 5); call(0x1008_8d4c, -0x2_84a1);           /* call 0x10088d4c */
        l_0x100b_11ed:
            ii(0x100b_11ed, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_11f0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_11f2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_11f3, 1); pop(edi);                               /* pop edi */
            ii(0x100b_11f4, 1); pop(esi);                               /* pop esi */
            ii(0x100b_11f5, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_11f6, 1); ret();                                  /* ret */
        }
    }
}
