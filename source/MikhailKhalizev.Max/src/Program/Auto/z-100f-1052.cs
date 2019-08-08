using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("07d471d2-39d8-4b5f-b200-d07bdf6e717a")]
        public void Method_100f_1052()
        {
            ii(0x100f_1052, 5); pushd(0x60);                            /* push 0x60 */
            ii(0x100f_1057, 5); calld(Definitions.sys_check_available_stack_size, 0x7_4cf6); /* call 0x10165d52 */
            ii(0x100f_105c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_105d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_105e, 1); pushd(edx);                             /* push edx */
            ii(0x100f_105f, 1); pushd(esi);                             /* push esi */
            ii(0x100f_1060, 1); pushd(edi);                             /* push edi */
            ii(0x100f_1061, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_1062, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_1064, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x100f_106a, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x100f_106f, 5); calld(0x100e_883d, -0x8837);            /* call 0x100e883d */
            ii(0x100f_1074, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_1077, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100f_107c, 5); calld(Definitions.sys_new, 0x7_4d7f);   /* call 0x10165e00 */
            ii(0x100f_1081, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_1084, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_1087, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_108a, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_108e, 2); if(jzd(0x100f_10c8, 0x38)) goto l_0x100f_10c8; /* jz 0x100f10c8 */
            ii(0x100f_1090, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x100f_1095, 1); pushd(eax);                             /* push eax */
            ii(0x100f_1096, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_1099, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100f_109d, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_10a0, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x100f_10a3, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_10a6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_10a9, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100f_10ac, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_10af, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_10b2, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100f_10b5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_10b8, 5); calld(0x100c_e39d, -0x2_2d20);          /* call 0x100ce39d */
            ii(0x100f_10bd, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_10c0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_10c3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_10c6, 2); jmpd(0x100f_10ce, 0x6); goto l_0x100f_10ce; /* jmp 0x100f10ce */
        l_0x100f_10c8:
            ii(0x100f_10c8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_10cb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x100f_10ce:
            ii(0x100f_10ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_10d1, 5); mov(memd_a32[ds, 0x101c_393c], eax);    /* mov [0x101c393c], eax */
            ii(0x100f_10d6, 6); mov(ebx, memd_a32[ds, 0x101c_393c]);    /* mov ebx, [0x101c393c] */
            ii(0x100f_10dc, 5); mov(edx, 0x100f_0943);                  /* mov edx, 0x100f0943 */
            ii(0x100f_10e1, 5); mov(eax, memd_a32[ds, 0x101c_393c]);    /* mov eax, [0x101c393c] */
            ii(0x100f_10e6, 5); calld(0x100c_f824, -0x2_18c7);          /* call 0x100cf824 */
            ii(0x100f_10eb, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_10ee, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x100f_10f1, 5); mov(eax, memd_a32[ds, 0x101c_393c]);    /* mov eax, [0x101c393c] */
            ii(0x100f_10f6, 5); calld(0x100c_f85c, -0x2_189f);          /* call 0x100cf85c */
            ii(0x100f_10fb, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_1100, 5); calld(0x100f_0b1b, -0x5ea);             /* call 0x100f0b1b */
            ii(0x100f_1105, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_110c, 2); jmpd(0x100f_1114, 0x6); goto l_0x100f_1114; /* jmp 0x100f1114 */
        l_0x100f_110e:
            ii(0x100f_110e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_1111, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x100f_1114:
            ii(0x100f_1114, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_1118, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x100f_111b, 6); if(jaed(0x100f_12b2, 0x191)) goto l_0x100f_12b2; /* jae 0x100f12b2 */
            ii(0x100f_1121, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_1125, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_1128, 6); mov(eax, memd_a32[ds, eax + 0x101b_8909]); /* mov eax, [eax+0x101b8909] */
            ii(0x100f_112e, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_1131, 5); calld(0x100e_883d, -0x88f9);            /* call 0x100e883d */
            ii(0x100f_1136, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_1139, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_113c, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100f_1140, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_1143, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x100f_1146, 1); inc(eax);                               /* inc eax */
            ii(0x100f_1147, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_114a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_114d, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x100f_1151, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_1154, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x100f_1158, 1); inc(eax);                               /* inc eax */
            ii(0x100f_1159, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100f_115c, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100f_1161, 5); calld(Definitions.sys_new, 0x7_4c9a);   /* call 0x10165e00 */
            ii(0x100f_1166, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100f_1169, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100f_116c, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100f_116f, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100f_1173, 2); if(jzd(0x100f_1195, 0x20)) goto l_0x100f_1195; /* jz 0x100f1195 */
            ii(0x100f_1175, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100f_1179, 1); pushd(eax);                             /* push eax */
            ii(0x100f_117a, 4); movsx(ecx, memw_a32[ss, ebp - 0x1c]);   /* movsx ecx, word [ebp-0x1c] */
            ii(0x100f_117e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_1180, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_1182, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100f_1185, 5); calld(0x100d_7bdc, -0x1_95ae);          /* call 0x100d7bdc */
            ii(0x100f_118a, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100f_118d, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100f_1190, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100f_1193, 2); jmpd(0x100f_119b, 0x6); goto l_0x100f_119b; /* jmp 0x100f119b */
        l_0x100f_1195:
            ii(0x100f_1195, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_1198, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x100f_119b:
            ii(0x100f_119b, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_119f, 3); imul(edx, edx, 0x12);                   /* imul edx, edx, 0x12 */
            ii(0x100f_11a2, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100f_11a5, 6); mov(memd_a32[ds, edx + 0x101b_891a], eax); /* mov [edx+0x101b891a], eax */
            ii(0x100f_11ab, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_11ae, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_11b2, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_11b5, 6); mov(eax, memd_a32[ds, eax + 0x101b_891a]); /* mov eax, [eax+0x101b891a] */
            ii(0x100f_11bb, 5); calld(0x100d_7d74, -0x1_944c);          /* call 0x100d7d74 */
            ii(0x100f_11c0, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_11c4, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_11c7, 8); cmp(memw_a32[ds, eax + 0x101b_890d], -0x1 /* 0xff */); /* cmp word [eax+0x101b890d], 0xffff */
            ii(0x100f_11cf, 6); if(jzd(0x100f_129c, 0xc7)) goto l_0x100f_129c; /* jz 0x100f129c */
            ii(0x100f_11d5, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100f_11da, 5); calld(Definitions.sys_new, 0x7_4c21);   /* call 0x10165e00 */
            ii(0x100f_11df, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100f_11e2, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_11e5, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100f_11e8, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100f_11ec, 2); if(jzd(0x100f_1231, 0x43)) goto l_0x100f_1231; /* jz 0x100f1231 */
            ii(0x100f_11ee, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_11f1, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x100f_11f4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_11f7, 1); pushd(eax);                             /* push eax */
            ii(0x100f_11f8, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_11fb, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x100f_11fe, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_1202, 3); imul(ebx, ebx, 0x12);                   /* imul ebx, ebx, 0x12 */
            ii(0x100f_1205, 6); mov(ebx, memd_a32[ds, ebx + 0x101b_890b]); /* mov ebx, [ebx+0x101b890b] */
            ii(0x100f_120b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_120e, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_1212, 3); imul(edx, edx, 0x12);                   /* imul edx, edx, 0x12 */
            ii(0x100f_1215, 6); mov(edx, memd_a32[ds, edx + 0x101b_890b]); /* mov edx, [edx+0x101b890b] */
            ii(0x100f_121b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_121e, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_1221, 5); calld(Definitions.my_ctor_c17, -0x2_2e17); /* call 0x100ce40f */
            ii(0x100f_1226, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100f_1229, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100f_122c, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100f_122f, 2); jmpd(0x100f_1237, 0x6); goto l_0x100f_1237; /* jmp 0x100f1237 */
        l_0x100f_1231:
            ii(0x100f_1231, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100f_1234, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x100f_1237:
            ii(0x100f_1237, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_123b, 3); imul(edx, edx, 0x12);                   /* imul edx, edx, 0x12 */
            ii(0x100f_123e, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100f_1241, 6); mov(memd_a32[ds, edx + 0x101b_8913], eax); /* mov [edx+0x101b8913], eax */
            ii(0x100f_1247, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100f_124c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_1250, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_1253, 6); mov(eax, memd_a32[ds, eax + 0x101b_8913]); /* mov eax, [eax+0x101b8913] */
            ii(0x100f_1259, 5); calld(0x100d_5194, -0x1_c0ca);          /* call 0x100d5194 */
            ii(0x100f_125e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_1261, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x100f_1264, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_1268, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_126b, 6); mov(eax, memd_a32[ds, eax + 0x101b_8913]); /* mov eax, [eax+0x101b8913] */
            ii(0x100f_1271, 5); calld(0x100c_f85c, -0x2_1a1a);          /* call 0x100cf85c */
            ii(0x100f_1276, 5); calld(0x100d_51e4, -0x1_c097);          /* call 0x100d51e4 */
            ii(0x100f_127b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_127d, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100f_127f, 5); calld(0x100d_5204, -0x1_c080);          /* call 0x100d5204 */
            ii(0x100f_1284, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_1286, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_1288, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_128c, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_128f, 6); mov(eax, memd_a32[ds, eax + 0x101b_8913]); /* mov eax, [eax+0x101b8913] */
            ii(0x100f_1295, 5); calld(0x100c_fa7c, -0x2_181e);          /* call 0x100cfa7c */
            ii(0x100f_129a, 2); jmpd(0x100f_12ad, 0x11); goto l_0x100f_12ad; /* jmp 0x100f12ad */
        l_0x100f_129c:
            ii(0x100f_129c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_12a0, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_12a3, 10); mov(memd_a32[ds, eax + 0x101b_8913], 0); /* mov dword [eax+0x101b8913], 0x0 */
        l_0x100f_12ad:
            ii(0x100f_12ad, 5); jmpd(0x100f_110e, -0x1a4); goto l_0x100f_110e; /* jmp 0x100f110e */
        l_0x100f_12b2:
            ii(0x100f_12b2, 7); mov(memb_a32[ds, 0x101c_3919], 0x1);    /* mov byte [0x101c3919], 0x1 */
            ii(0x100f_12b9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_12bb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_12bc, 1); popd(edi);                              /* pop edi */
            ii(0x100f_12bd, 1); popd(esi);                              /* pop esi */
            ii(0x100f_12be, 1); popd(edx);                              /* pop edx */
            ii(0x100f_12bf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_12c0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_12c1, 1); retd(); return;                         /* ret */
        }
    }
}
