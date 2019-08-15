using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("be33920d-c587-466a-a1c8-d9f8b7996b06")]
        public void Method_1008_1116()
        {
            ii(0x1008_1116, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1008_111b, 5); calld(Definitions.sys_check_available_stack_size, 0xe_4c32); /* call 0x10165d52 */
            ii(0x1008_1120, 1); pushd(esi);                             /* push esi */
            ii(0x1008_1121, 1); pushd(edi);                             /* push edi */
            ii(0x1008_1122, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_1123, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_1125, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1008_112b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_112e, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1008_1131, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1008_1134, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1008_1137, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x1008_113b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_113d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_1140, 5); calld(0x1008_a3a8, 0x9263);             /* call 0x1008a3a8 */
            ii(0x1008_1145, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_1148, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_114b, 5); calld(0x100a_26d1, 0x2_1581);           /* call 0x100a26d1 */
            ii(0x1008_1150, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_1153, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_1156, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_1159, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_115c, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_115f, 5); calld(0x1008_9d3c, 0x8bd8);             /* call 0x10089d3c */
            ii(0x1008_1164, 3); sub(eax, 0x16);                         /* sub eax, 0x16 */
            ii(0x1008_1167, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_116a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_116d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_1170, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_1173, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_1176, 5); calld(0x1008_9d3c, 0x8bc1);             /* call 0x10089d3c */
            ii(0x1008_117b, 3); sub(eax, 0x20);                         /* sub eax, 0x20 */
            ii(0x1008_117e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_1181, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_1184, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_1187, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_118a, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_118d, 5); calld(0x1008_9ef8, 0x8d66);             /* call 0x10089ef8 */
            ii(0x1008_1192, 3); sub(eax, 0x2a);                         /* sub eax, 0x2a */
            ii(0x1008_1195, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_1198, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_119b, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_119e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_11a1, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_11a4, 5); calld(0x1008_9a34, 0x888b);             /* call 0x10089a34 */
            ii(0x1008_11a9, 3); sub(eax, 0x2e);                         /* sub eax, 0x2e */
            ii(0x1008_11ac, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_11af, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_11b2, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1008_11b5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_11b8, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_11bb, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xaad0); /* call 0x100766f0 */
            ii(0x1008_11c0, 3); sub(eax, 0x32);                         /* sub eax, 0x32 */
            ii(0x1008_11c3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_11c6, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_11c9, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1008_11cc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_11cf, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1008_11d2, 5); calld(Definitions.my_ctor_0x101b_3b58, 0x9ecd); /* call 0x1008b0a4 */
            ii(0x1008_11d7, 3); sub(eax, 0x36);                         /* sub eax, 0x36 */
            ii(0x1008_11da, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_11dd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_11e0, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1008_11e3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_11e6, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_11e9, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xaafe); /* call 0x100766f0 */
            ii(0x1008_11ee, 3); sub(eax, 0x3e);                         /* sub eax, 0x3e */
            ii(0x1008_11f1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_11f4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_11f7, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1008_11fa, 5); calld(0x1008_b3ec, 0xa1ed);             /* call 0x1008b3ec */
            ii(0x1008_11ff, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_1202, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_1205, 3); add(eax, 0x42);                         /* add eax, 0x42 */
            ii(0x1008_1208, 5); calld(0x1008_b1e4, 0x9fd7);             /* call 0x1008b1e4 */
            ii(0x1008_120d, 3); sub(eax, 0x42);                         /* sub eax, 0x42 */
            ii(0x1008_1210, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_1213, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_1216, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1008_1219, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_121c, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_3c60); /* mov dword [eax+0x2], 0x101b3c60 */
            ii(0x1008_1223, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_1226, 4); mov(memb_a32[ds, eax + 0x15], 0);       /* mov byte [eax+0x15], 0x0 */
            ii(0x1008_122a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_122d, 4); mov(memb_a32[ds, eax + 0x46], 0);       /* mov byte [eax+0x46], 0x0 */
            ii(0x1008_1231, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_1234, 5); calld(0x1008_a370, 0x9137);             /* call 0x1008a370 */
            ii(0x1008_1239, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_123b, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_123e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_1241, 4); mov(memw_a32[ds, eax + 0x13], dx);      /* mov [eax+0x13], dx */
            ii(0x1008_1245, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1008_124a, 5); calld(Definitions.sys_new, 0xe_4bb1);   /* call 0x10165e00 */
            ii(0x1008_124f, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1008_1252, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1008_1255, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1008_1258, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1008_125c, 2); if(jzd(0x1008_127b, 0x1d)) goto l_0x1008_127b; /* jz 0x1008127b */
            ii(0x1008_125e, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x1008_1262, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1008_1265, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1008_1268, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1008_126b, 5); calld(Definitions.my_ctor_c1, -0x6695); /* call 0x1007abdb */
            ii(0x1008_1270, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1008_1273, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1008_1276, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1008_1279, 2); jmpd(0x1008_1281, 0x6); goto l_0x1008_1281; /* jmp 0x10081281 */
        l_0x1008_127b:
            ii(0x1008_127b, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1008_127e, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x1008_1281:
            ii(0x1008_1281, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x1008_1284, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_1287, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_128a, 5); calld(0x1008_9cd8, 0x8a49);             /* call 0x10089cd8 */
            ii(0x1008_128f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1291, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_1294, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_1297, 5); calld(0x1008_9c68, 0x89cc);             /* call 0x10089c68 */
            ii(0x1008_129c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_129e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_12a1, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_12a4, 5); calld(0x1008_9cd8, 0x8a2f);             /* call 0x10089cd8 */
            ii(0x1008_12a9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_12ac, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1008_12af, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1008_12b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_12b4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_12b5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_12b6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_12b7, 1); retd(); return;                         /* ret */
        }
    }
}
