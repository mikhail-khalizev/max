using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_a2c3-b2c6a7ac")]
        public void Method_100b_a2c3()
        {
            ii(0x100b_a2c3, 5); pushd(0x68);                            /* push 0x68 */
            ii(0x100b_a2c8, 5); calld(Definitions.sys_check_available_stack_size, 0xa_ba85); /* call 0x10165d52 */
            ii(0x100b_a2cd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_a2ce, 1); pushd(esi);                             /* push esi */
            ii(0x100b_a2cf, 1); pushd(edi);                             /* push edi */
            ii(0x100b_a2d0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_a2d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_a2d3, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x100b_a2d9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_a2dc, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_a2df, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100b_a2e2, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a2e6, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a2ea, 5); calld(0x1008_a4dc, -0x2_fe13);          /* call 0x1008a4dc */
            ii(0x100b_a2ef, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a2f1, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a2f3, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a2f6, 3); add(edx, 0x7d);                         /* add edx, 0x7d */
            ii(0x100b_a2f9, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_a2fc, 5); calld(0x100b_8505, -0x1dfc);            /* call 0x100b8505 */
            ii(0x100b_a301, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a303, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a306, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a308, 5); calld(0x100b_a24e, -0xbf);              /* call 0x100ba24e */
            ii(0x100b_a30d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a30f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_a312, 5); calld(0x1008_8dcc, -0x3_154b);          /* call 0x10088dcc */
            ii(0x100b_a317, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a31b, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a31f, 5); calld(0x1008_a4dc, -0x2_fe48);          /* call 0x1008a4dc */
            ii(0x100b_a324, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a326, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a328, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a32b, 6); add(edx, 0x81);                         /* add edx, 0x81 */
            ii(0x100b_a331, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_a334, 5); calld(0x100b_8505, -0x1e34);            /* call 0x100b8505 */
            ii(0x100b_a339, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a33b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a33e, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a340, 5); calld(0x100b_a24e, -0xf7);              /* call 0x100ba24e */
            ii(0x100b_a345, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a347, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_a34a, 5); calld(0x1008_8dcc, -0x3_1583);          /* call 0x10088dcc */
            ii(0x100b_a34f, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a353, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a357, 5); calld(0x1008_a4dc, -0x2_fe80);          /* call 0x1008a4dc */
            ii(0x100b_a35c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a35e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a360, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a363, 6); add(edx, 0x85);                         /* add edx, 0x85 */
            ii(0x100b_a369, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_a36c, 5); calld(0x100b_8505, -0x1e6c);            /* call 0x100b8505 */
            ii(0x100b_a371, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a373, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a376, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a378, 5); calld(0x100b_a24e, -0x12f);             /* call 0x100ba24e */
            ii(0x100b_a37d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a37f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_a382, 5); calld(0x1008_8dcc, -0x3_15bb);          /* call 0x10088dcc */
            ii(0x100b_a387, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a38b, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a38f, 5); calld(0x1008_a4dc, -0x2_feb8);          /* call 0x1008a4dc */
            ii(0x100b_a394, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a396, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a398, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a39b, 6); add(edx, 0x89);                         /* add edx, 0x89 */
            ii(0x100b_a3a1, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_a3a4, 5); calld(0x100b_8505, -0x1ea4);            /* call 0x100b8505 */
            ii(0x100b_a3a9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a3ab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a3ae, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a3b0, 5); calld(0x100b_a24e, -0x167);             /* call 0x100ba24e */
            ii(0x100b_a3b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a3b7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_a3ba, 5); calld(0x1008_8dcc, -0x3_15f3);          /* call 0x10088dcc */
            ii(0x100b_a3bf, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a3c3, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a3c7, 5); calld(0x1008_a4dc, -0x2_fef0);          /* call 0x1008a4dc */
            ii(0x100b_a3cc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a3ce, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a3d0, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a3d3, 6); add(edx, 0x8d);                         /* add edx, 0x8d */
            ii(0x100b_a3d9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_a3dc, 5); calld(0x100b_8505, -0x1edc);            /* call 0x100b8505 */
            ii(0x100b_a3e1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a3e3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a3e6, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a3e8, 5); calld(0x100b_a24e, -0x19f);             /* call 0x100ba24e */
            ii(0x100b_a3ed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a3ef, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_a3f2, 5); calld(0x1008_8dcc, -0x3_162b);          /* call 0x10088dcc */
            ii(0x100b_a3f7, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a3fb, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a3ff, 5); calld(0x1008_a4dc, -0x2_ff28);          /* call 0x1008a4dc */
            ii(0x100b_a404, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a406, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a408, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a40b, 6); add(edx, 0x91);                         /* add edx, 0x91 */
            ii(0x100b_a411, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_a414, 5); calld(0x100b_8505, -0x1f14);            /* call 0x100b8505 */
            ii(0x100b_a419, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a41b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a41e, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a420, 5); calld(0x100b_a24e, -0x1d7);             /* call 0x100ba24e */
            ii(0x100b_a425, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a427, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_a42a, 5); calld(0x1008_8dcc, -0x3_1663);          /* call 0x10088dcc */
            ii(0x100b_a42f, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a433, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a437, 5); calld(0x1008_a4dc, -0x2_ff60);          /* call 0x1008a4dc */
            ii(0x100b_a43c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a43e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a440, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a443, 6); add(edx, 0x95);                         /* add edx, 0x95 */
            ii(0x100b_a449, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_a44c, 5); calld(0x100b_8505, -0x1f4c);            /* call 0x100b8505 */
            ii(0x100b_a451, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a453, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a456, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a458, 5); calld(0x100b_a24e, -0x20f);             /* call 0x100ba24e */
            ii(0x100b_a45d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a45f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_a462, 5); calld(0x1008_8dcc, -0x3_169b);          /* call 0x10088dcc */
            ii(0x100b_a467, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a46b, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a46f, 5); calld(0x1008_a4dc, -0x2_ff98);          /* call 0x1008a4dc */
            ii(0x100b_a474, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a476, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a478, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a47b, 6); add(edx, 0x99);                         /* add edx, 0x99 */
            ii(0x100b_a481, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_a484, 5); calld(0x100b_8505, -0x1f84);            /* call 0x100b8505 */
            ii(0x100b_a489, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a48b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a48e, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a490, 5); calld(0x100b_a24e, -0x247);             /* call 0x100ba24e */
            ii(0x100b_a495, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a497, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_a49a, 5); calld(0x1008_8dcc, -0x3_16d3);          /* call 0x10088dcc */
            ii(0x100b_a49f, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a4a3, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a4a7, 5); calld(0x1008_a4dc, -0x2_ffd0);          /* call 0x1008a4dc */
            ii(0x100b_a4ac, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a4ae, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a4b0, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a4b3, 6); add(edx, 0x9d);                         /* add edx, 0x9d */
            ii(0x100b_a4b9, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_a4bc, 5); calld(0x100b_8505, -0x1fbc);            /* call 0x100b8505 */
            ii(0x100b_a4c1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a4c3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a4c6, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a4c8, 5); calld(0x100b_a24e, -0x27f);             /* call 0x100ba24e */
            ii(0x100b_a4cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a4cf, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_a4d2, 5); calld(0x1008_8dcc, -0x3_170b);          /* call 0x10088dcc */
            ii(0x100b_a4d7, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a4db, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a4df, 5); calld(0x1008_a4dc, -0x3_0008);          /* call 0x1008a4dc */
            ii(0x100b_a4e4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a4e6, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a4e8, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a4eb, 6); add(edx, 0xa1);                         /* add edx, 0xa1 */
            ii(0x100b_a4f1, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_a4f4, 5); calld(0x100b_8505, -0x1ff4);            /* call 0x100b8505 */
            ii(0x100b_a4f9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a4fb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a4fe, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a500, 5); calld(0x100b_a24e, -0x2b7);             /* call 0x100ba24e */
            ii(0x100b_a505, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a507, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_a50a, 5); calld(0x1008_8dcc, -0x3_1743);          /* call 0x10088dcc */
            ii(0x100b_a50f, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a513, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a517, 5); calld(0x1008_a4dc, -0x3_0040);          /* call 0x1008a4dc */
            ii(0x100b_a51c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a51e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a520, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a523, 6); add(edx, 0xa5);                         /* add edx, 0xa5 */
            ii(0x100b_a529, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_a52c, 5); calld(0x100b_8505, -0x202c);            /* call 0x100b8505 */
            ii(0x100b_a531, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a533, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a536, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a538, 5); calld(0x100b_a24e, -0x2ef);             /* call 0x100ba24e */
            ii(0x100b_a53d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a53f, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_a542, 5); calld(0x1008_8dcc, -0x3_177b);          /* call 0x10088dcc */
            ii(0x100b_a547, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a54b, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a54f, 5); calld(0x1008_a4dc, -0x3_0078);          /* call 0x1008a4dc */
            ii(0x100b_a554, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a556, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a558, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a55b, 6); add(edx, 0xa9);                         /* add edx, 0xa9 */
            ii(0x100b_a561, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_a564, 5); calld(0x100b_8505, -0x2064);            /* call 0x100b8505 */
            ii(0x100b_a569, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a56b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a56e, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a570, 5); calld(0x100b_a24e, -0x327);             /* call 0x100ba24e */
            ii(0x100b_a575, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a577, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_a57a, 5); calld(0x1008_8dcc, -0x3_17b3);          /* call 0x10088dcc */
            ii(0x100b_a57f, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a583, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a587, 5); calld(0x1008_a4dc, -0x3_00b0);          /* call 0x1008a4dc */
            ii(0x100b_a58c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a58e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a590, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a593, 6); add(edx, 0xad);                         /* add edx, 0xad */
            ii(0x100b_a599, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100b_a59c, 5); calld(0x100b_8505, -0x209c);            /* call 0x100b8505 */
            ii(0x100b_a5a1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a5a3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a5a6, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a5a8, 5); calld(0x100b_a24e, -0x35f);             /* call 0x100ba24e */
            ii(0x100b_a5ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a5af, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100b_a5b2, 5); calld(0x1008_8dcc, -0x3_17eb);          /* call 0x10088dcc */
            ii(0x100b_a5b7, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a5bb, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a5bf, 5); calld(0x1008_a4dc, -0x3_00e8);          /* call 0x1008a4dc */
            ii(0x100b_a5c4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a5c6, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a5c8, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a5cb, 6); add(edx, 0xb1);                         /* add edx, 0xb1 */
            ii(0x100b_a5d1, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100b_a5d4, 5); calld(0x100b_8505, -0x20d4);            /* call 0x100b8505 */
            ii(0x100b_a5d9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a5db, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a5de, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a5e0, 5); calld(0x100b_a24e, -0x397);             /* call 0x100ba24e */
            ii(0x100b_a5e5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a5e7, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100b_a5ea, 5); calld(0x1008_8dcc, -0x3_1823);          /* call 0x10088dcc */
            ii(0x100b_a5ef, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a5f3, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a5f7, 5); calld(0x1008_a4dc, -0x3_0120);          /* call 0x1008a4dc */
            ii(0x100b_a5fc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a5fe, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a600, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a603, 6); add(edx, 0xb5);                         /* add edx, 0xb5 */
            ii(0x100b_a609, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_a60c, 5); calld(0x100b_8505, -0x210c);            /* call 0x100b8505 */
            ii(0x100b_a611, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a613, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a616, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a618, 5); calld(0x100b_a24e, -0x3cf);             /* call 0x100ba24e */
            ii(0x100b_a61d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a61f, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100b_a622, 5); calld(0x1008_8dcc, -0x3_185b);          /* call 0x10088dcc */
            ii(0x100b_a627, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a62b, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a62f, 5); calld(0x1008_a4dc, -0x3_0158);          /* call 0x1008a4dc */
            ii(0x100b_a634, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a636, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a638, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a63b, 6); add(edx, 0xb9);                         /* add edx, 0xb9 */
            ii(0x100b_a641, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x100b_a644, 5); calld(0x100b_8505, -0x2144);            /* call 0x100b8505 */
            ii(0x100b_a649, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a64b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a64e, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a650, 5); calld(0x100b_a24e, -0x407);             /* call 0x100ba24e */
            ii(0x100b_a655, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a657, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x100b_a65a, 5); calld(0x1008_8dcc, -0x3_1893);          /* call 0x10088dcc */
            ii(0x100b_a65f, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a663, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a667, 5); calld(0x1008_a4dc, -0x3_0190);          /* call 0x1008a4dc */
            ii(0x100b_a66c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a66e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a670, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a673, 6); add(edx, 0xbd);                         /* add edx, 0xbd */
            ii(0x100b_a679, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100b_a67c, 5); calld(0x100b_8505, -0x217c);            /* call 0x100b8505 */
            ii(0x100b_a681, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a683, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a686, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a688, 5); calld(0x100b_a24e, -0x43f);             /* call 0x100ba24e */
            ii(0x100b_a68d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a68f, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100b_a692, 5); calld(0x1008_8dcc, -0x3_18cb);          /* call 0x10088dcc */
            ii(0x100b_a697, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_a69b, 4); movsx(esi, memw_a32[ss, ebp - 0x8]);    /* movsx esi, word [ebp-0x8] */
            ii(0x100b_a69f, 5); calld(0x1008_a4dc, -0x3_01c8);          /* call 0x1008a4dc */
            ii(0x100b_a6a4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_a6a6, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_a6a8, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_a6ab, 6); add(edx, 0xc1);                         /* add edx, 0xc1 */
            ii(0x100b_a6b1, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100b_a6b4, 5); calld(0x100b_8505, -0x21b4);            /* call 0x100b8505 */
            ii(0x100b_a6b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a6bb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a6be, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100b_a6c0, 5); calld(0x100b_a24e, -0x477);             /* call 0x100ba24e */
            ii(0x100b_a6c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_a6c7, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100b_a6ca, 5); calld(0x1008_8dcc, -0x3_1903);          /* call 0x10088dcc */
            ii(0x100b_a6cf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_a6d1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_a6d2, 1); popd(edi);                              /* pop edi */
            ii(0x100b_a6d3, 1); popd(esi);                              /* pop esi */
            ii(0x100b_a6d4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_a6d5, 1); retd();                                 /* ret */
        }
    }
}
