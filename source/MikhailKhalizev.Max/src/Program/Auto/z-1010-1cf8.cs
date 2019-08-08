using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7728bd20-029a-4c01-b012-fe99c264ef68")]
        public void Method_1010_1cf8()
        {
            ii(0x1010_1cf8, 5); pushd(0x168);                           /* push 0x168 */
            ii(0x1010_1cfd, 5); calld(Definitions.sys_check_available_stack_size, 0x6_4050); /* call 0x10165d52 */
            ii(0x1010_1d02, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_1d03, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_1d04, 1); pushd(edx);                             /* push edx */
            ii(0x1010_1d05, 1); pushd(esi);                             /* push esi */
            ii(0x1010_1d06, 1); pushd(edi);                             /* push edi */
            ii(0x1010_1d07, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_1d08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_1d0a, 6); sub(esp, 0x138);                        /* sub esp, 0x138 */
            ii(0x1010_1d10, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_1d13, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_1d17, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_1d1a, 5); mov(edx, 0x101c_35b4);                  /* mov edx, 0x101c35b4 */
            ii(0x1010_1d1f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_1d21, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x1010_1d24, 5); calld(0x1009_cb74, -0x6_51b5);          /* call 0x1009cb74 */
            ii(0x1010_1d29, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_1d2b, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_1d2d, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1010_1d30, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_1d33, 5); calld(0x1009_cab0, -0x6_5288);          /* call 0x1009cab0 */
            ii(0x1010_1d38, 5); calld(0x100e_0a00, -0x2_133d);          /* call 0x100e0a00 */
            ii(0x1010_1d3d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_1d3f, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_1d41, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1010_1d44, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1010_1d47, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_1d4a, 5); calld(0x100e_0970, -0x2_13df);          /* call 0x100e0970 */
            ii(0x1010_1d4f, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1010_1d53, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_1d56, 5); calld(Definitions.my_ctor_0x101b38f8, -0x8_b66b); /* call 0x100766f0 */
            ii(0x1010_1d5b, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1010_1d5e, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1010_1d62, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1010_1d66, 6); lea(eax, ebp - 0x110);                  /* lea eax, [ebp-0x110] */
            ii(0x1010_1d6c, 5); calld(0x1014_89fa, 0x4_6c89);           /* call 0x101489fa */
            ii(0x1010_1d71, 6); mov(memd_a32[ss, ebp - 0x114], eax);    /* mov [ebp-0x114], eax */
            ii(0x1010_1d77, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1010_1d7b, 6); lea(eax, ebp - 0x118);                  /* lea eax, [ebp-0x118] */
            ii(0x1010_1d81, 5); calld(Definitions.my_ctor_0x101b4184, -0x8_b296); /* call 0x10076af0 */
            ii(0x1010_1d86, 7); mov(memb_a32[ds, 0x101c_391e], 0xc);    /* mov byte [0x101c391e], 0xc */
            ii(0x1010_1d8d, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1010_1d90, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x1010_1d93, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_1d96, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_1d9a, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_1da0, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1010_1da6, 5); calld(0x100c_b60c, -0x3_679f);          /* call 0x100cb60c */
            ii(0x1010_1dab, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1010_1daf, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1010_1db5, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_1db8, 5); calld(Definitions.my_2_get_count, -0x7_6a55); /* call 0x1008b368 */
            ii(0x1010_1dbd, 7); add(memw_a32[ds, edx + 0x101c_a581], ax); /* add [edx+0x101ca581], ax */
            ii(0x1010_1dc4, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1010_1dc8, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1010_1dce, 5); calld(0x1010_1a26, -0x3ad);             /* call 0x10101a26 */
            ii(0x1010_1dd3, 6); lea(ebx, ebp - 0x118);                  /* lea ebx, [ebp-0x118] */
            ii(0x1010_1dd9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_1ddb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_1ddd, 5); calld(0x1008_8b44, -0x7_929e);          /* call 0x10088b44 */
            ii(0x1010_1de2, 5); calld(0x1010_2b84, 0xd9d);              /* call 0x10102b84 */
            ii(0x1010_1de7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_1dec, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1ded, 5); calld(0x1010_2ba4, 0xdb2);              /* call 0x10102ba4 */
            ii(0x1010_1df2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_1df7, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1df8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_1dfa, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1dfb, 7); movsx(eax, memw_a32[ss, ebp - 0x116]);  /* movsx eax, word [ebp-0x116] */
            ii(0x1010_1e02, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1e03, 7); movsx(eax, memw_a32[ss, ebp - 0x118]);  /* movsx eax, word [ebp-0x118] */
            ii(0x1010_1e0a, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1e0b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_1e0d, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1010_1e11, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x1010_1e16, 6); lea(eax, ebp - 0x120);                  /* lea eax, [ebp-0x120] */
            ii(0x1010_1e1c, 5); calld(0x1015_a2da, 0x5_84b9);           /* call 0x1015a2da */
            ii(0x1010_1e21, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_1e23, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_1e26, 5); calld(0x1008_ac18, -0x7_7213);          /* call 0x1008ac18 */
            ii(0x1010_1e2b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_1e2d, 6); lea(eax, ebp - 0x120);                  /* lea eax, [ebp-0x120] */
            ii(0x1010_1e33, 5); calld(0x1007_5f2c, -0x8_bf0c);          /* call 0x10075f2c */
            ii(0x1010_1e38, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_1e3b, 5); calld(0x1007_6574, -0x8_b8cc);          /* call 0x10076574 */
            ii(0x1010_1e40, 6); mov(memw_a32[ds, eax + 0x52], 0);       /* mov word [eax+0x52], 0x0 */
            ii(0x1010_1e46, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_1e4a, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_1e50, 7); inc(memw_a32[ds, eax + 0x101c_a57d]);   /* inc word [eax+0x101ca57d] */
            ii(0x1010_1e57, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_1e5b, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_1e61, 7); inc(memw_a32[ds, eax + 0x101c_a57f]);   /* inc word [eax+0x101ca57f] */
            ii(0x1010_1e68, 5); calld(0x1010_2b84, 0xd17);              /* call 0x10102b84 */
            ii(0x1010_1e6d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_1e72, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1e73, 5); calld(0x1010_2ba4, 0xd2c);              /* call 0x10102ba4 */
            ii(0x1010_1e78, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_1e7d, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1e7e, 5); mov(eax, memd_a32[ds, 0x101c_8529]);    /* mov eax, [0x101c8529] */
            ii(0x1010_1e83, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_1e85, 3); mov(dl, memb_a32[ds, eax + 0x1]);       /* mov dl, [eax+0x1] */
            ii(0x1010_1e88, 5); calld(/* sys */ 0x1016_5e9b, 0x6_400e); /* call 0x10165e9b */
            ii(0x1010_1e8d, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1010_1e90, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1010_1e93, 1); cwde();                                 /* cwde */
            ii(0x1010_1e94, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1e95, 7); movsx(eax, memw_a32[ss, ebp - 0x116]);  /* movsx eax, word [ebp-0x116] */
            ii(0x1010_1e9c, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1e9d, 7); movsx(eax, memw_a32[ss, ebp - 0x118]);  /* movsx eax, word [ebp-0x118] */
            ii(0x1010_1ea4, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1ea5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_1ea7, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1010_1eab, 5); mov(edx, 0x11);                         /* mov edx, 0x11 */
            ii(0x1010_1eb0, 6); lea(eax, ebp - 0x124);                  /* lea eax, [ebp-0x124] */
            ii(0x1010_1eb6, 5); calld(0x1015_a2da, 0x5_841f);           /* call 0x1015a2da */
            ii(0x1010_1ebb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_1ebd, 6); lea(eax, ebp - 0x124);                  /* lea eax, [ebp-0x124] */
            ii(0x1010_1ec3, 5); calld(0x1007_5f2c, -0x8_bf9c);          /* call 0x10075f2c */
            ii(0x1010_1ec8, 7); movsx(ebx, memw_a32[ss, ebp - 0x116]);  /* movsx ebx, word [ebp-0x116] */
            ii(0x1010_1ecf, 7); movsx(edx, memw_a32[ss, ebp - 0x118]);  /* movsx edx, word [ebp-0x118] */
            ii(0x1010_1ed6, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_1ed9, 5); calld(0x1008_abbc, -0x7_7322);          /* call 0x1008abbc */
            ii(0x1010_1ede, 5); calld(0x1016_3263, 0x6_1380);           /* call 0x10163263 */
            ii(0x1010_1ee3, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1010_1ee7, 6); lea(edx, ebp - 0x118);                  /* lea edx, [ebp-0x118] */
            ii(0x1010_1eed, 6); lea(eax, ebp - 0x128);                  /* lea eax, [ebp-0x128] */
            ii(0x1010_1ef3, 5); calld(0x1007_5e64, -0x8_c094);          /* call 0x10075e64 */
            ii(0x1010_1ef8, 6); lea(ecx, ebp - 0x12c);                  /* lea ecx, [ebp-0x12c] */
            ii(0x1010_1efe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_1f00, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1010_1f02, 5); calld(0x1010_1c16, -0x2f1);             /* call 0x10101c16 */
            ii(0x1010_1f07, 5); calld(0x1010_2b84, 0xc78);              /* call 0x10102b84 */
            ii(0x1010_1f0c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_1f11, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1f12, 5); calld(0x1010_2ba4, 0xc8d);              /* call 0x10102ba4 */
            ii(0x1010_1f17, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_1f1c, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1f1d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_1f1f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1f20, 7); movsx(eax, memw_a32[ss, ebp - 0x12a]);  /* movsx eax, word [ebp-0x12a] */
            ii(0x1010_1f27, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1f28, 7); movsx(eax, memw_a32[ss, ebp - 0x12c]);  /* movsx eax, word [ebp-0x12c] */
            ii(0x1010_1f2f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1f30, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_1f33, 5); calld(0x1007_6574, -0x8_b9c4);          /* call 0x10076574 */
            ii(0x1010_1f38, 5); calld(0x1007_6204, -0x8_bd39);          /* call 0x10076204 */
            ii(0x1010_1f3d, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1010_1f3f, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1010_1f43, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1010_1f48, 6); lea(eax, ebp - 0x130);                  /* lea eax, [ebp-0x130] */
            ii(0x1010_1f4e, 5); calld(0x1015_a2da, 0x5_8387);           /* call 0x1015a2da */
            ii(0x1010_1f53, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_1f55, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_1f58, 5); calld(0x1008_ac18, -0x7_7345);          /* call 0x1008ac18 */
            ii(0x1010_1f5d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_1f5f, 6); lea(eax, ebp - 0x130);                  /* lea eax, [ebp-0x130] */
            ii(0x1010_1f65, 5); calld(0x1007_5f2c, -0x8_c03e);          /* call 0x10075f2c */
            ii(0x1010_1f6a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_1f6d, 5); calld(0x1007_6574, -0x8_b9fe);          /* call 0x10076574 */
            ii(0x1010_1f72, 4); mov(memb_a32[ds, eax + 0x3d], 0x7);     /* mov byte [eax+0x3d], 0x7 */
            ii(0x1010_1f76, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_1f79, 5); calld(0x1007_6574, -0x8_ba0a);          /* call 0x10076574 */
            ii(0x1010_1f7e, 4); mov(memb_a32[ds, eax + 0x3e], 0);       /* mov byte [eax+0x3e], 0x0 */
            ii(0x1010_1f82, 5); calld(0x1010_2b84, 0xbfd);              /* call 0x10102b84 */
            ii(0x1010_1f87, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_1f8c, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1f8d, 5); calld(0x1010_2ba4, 0xc12);              /* call 0x10102ba4 */
            ii(0x1010_1f92, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_1f97, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1f98, 5); mov(eax, memd_a32[ds, 0x101c_855c]);    /* mov eax, [0x101c855c] */
            ii(0x1010_1f9d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_1f9f, 3); mov(dl, memb_a32[ds, eax + 0x1]);       /* mov dl, [eax+0x1] */
            ii(0x1010_1fa2, 5); calld(/* sys */ 0x1016_5e9b, 0x6_3ef4); /* call 0x10165e9b */
            ii(0x1010_1fa7, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1010_1faa, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1010_1fad, 1); cwde();                                 /* cwde */
            ii(0x1010_1fae, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1faf, 7); movsx(eax, memw_a32[ss, ebp - 0x12a]);  /* movsx eax, word [ebp-0x12a] */
            ii(0x1010_1fb6, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1fb7, 7); movsx(eax, memw_a32[ss, ebp - 0x12c]);  /* movsx eax, word [ebp-0x12c] */
            ii(0x1010_1fbe, 1); pushd(eax);                             /* push eax */
            ii(0x1010_1fbf, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_1fc1, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1010_1fc5, 5); mov(edx, 0x12);                         /* mov edx, 0x12 */
            ii(0x1010_1fca, 6); lea(eax, ebp - 0x134);                  /* lea eax, [ebp-0x134] */
            ii(0x1010_1fd0, 5); calld(0x1015_a2da, 0x5_8305);           /* call 0x1015a2da */
            ii(0x1010_1fd5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_1fd7, 6); lea(eax, ebp - 0x134);                  /* lea eax, [ebp-0x134] */
            ii(0x1010_1fdd, 5); calld(0x1007_5f2c, -0x8_c0b6);          /* call 0x10075f2c */
            ii(0x1010_1fe2, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_1fe5, 5); calld(0x1008_abbc, -0x7_742e);          /* call 0x1008abbc */
            ii(0x1010_1fea, 5); calld(0x1015_ec73, 0x5_cc84);           /* call 0x1015ec73 */
            ii(0x1010_1fef, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1010_1ff6, 2); jmpd(0x1010_1ffe, 0x6); goto l_0x1010_1ffe; /* jmp 0x10101ffe */
        l_0x1010_1ff8:
            ii(0x1010_1ff8, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_1ffb, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1010_1ffe:
            ii(0x1010_1ffe, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_2001, 5); calld(Definitions.my_2_get_count, -0x7_6c9e); /* call 0x1008b368 */
            ii(0x1010_2006, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1010_200a, 6); if(jled(0x1010_20de, 0xce)) goto l_0x1010_20de; /* jle 0x101020de */
            ii(0x1010_2010, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1010_2014, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_2017, 5); calld(0x1008_b228, -0x7_6df4);          /* call 0x1008b228 */
            ii(0x1010_201c, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1010_201f, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_2022, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1010_2025, 6); mov(memb_a32[ss, ebp - 0xea], al);      /* mov [ebp-0xea], al */
            ii(0x1010_202b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_202e, 7); mov(memw_a32[ss, ebp - 0x108], ax);     /* mov [ebp-0x108], ax */
            ii(0x1010_2035, 6); mov(eax, memd_a32[ss, ebp - 0x118]);    /* mov eax, [ebp-0x118] */
            ii(0x1010_203b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_203e, 6); mov(eax, memd_a32[ss, ebp - 0x116]);    /* mov eax, [ebp-0x116] */
            ii(0x1010_2044, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_2047, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_2049, 1); pushd(eax);                             /* push eax */
            ii(0x1010_204a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_204c, 1); pushd(eax);                             /* push eax */
            ii(0x1010_204d, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1010_2052, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_2055, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2056, 3); lea(ecx, ebp - 0xc);                    /* lea ecx, [ebp-0xc] */
            ii(0x1010_2059, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x1010_205c, 6); lea(edx, ebp - 0x110);                  /* lea edx, [ebp-0x110] */
            ii(0x1010_2062, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_2066, 5); calld(0x1007_0efa, -0x9_1171);          /* call 0x10070efa */
            ii(0x1010_206b, 5); calld(0x1010_2b84, 0xb14);              /* call 0x10102b84 */
            ii(0x1010_2070, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_2075, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2076, 5); calld(0x1010_2ba4, 0xb29);              /* call 0x10102ba4 */
            ii(0x1010_207b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_2080, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2081, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_2083, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2084, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_2088, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2089, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_208d, 1); pushd(eax);                             /* push eax */
            ii(0x1010_208e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_2090, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1010_2094, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1010_2098, 6); lea(eax, ebp - 0x138);                  /* lea eax, [ebp-0x138] */
            ii(0x1010_209e, 5); calld(0x1015_a2da, 0x5_8237);           /* call 0x1015a2da */
            ii(0x1010_20a3, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x1010_20a6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_20a8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_20aa, 5); calld(0x1008_ac18, -0x7_7497);          /* call 0x1008ac18 */
            ii(0x1010_20af, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_20b1, 6); lea(eax, ebp - 0x138);                  /* lea eax, [ebp-0x138] */
            ii(0x1010_20b7, 5); calld(0x1007_5f2c, -0x8_c190);          /* call 0x10075f2c */
            ii(0x1010_20bc, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1010_20c0, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_20c3, 5); calld(0x100e_08bc, -0x2_180c);          /* call 0x100e08bc */
            ii(0x1010_20c8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_20ca, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_20cd, 5); calld(0x1007_6574, -0x8_bb5e);          /* call 0x10076574 */
            ii(0x1010_20d2, 3); mov(dx, memw_a32[ds, edx]);             /* mov dx, [edx] */
            ii(0x1010_20d5, 4); mov(memw_a32[ds, eax + 0x52], dx);      /* mov [eax+0x52], dx */
            ii(0x1010_20d9, 5); jmpd(0x1010_1ff8, -0xe6); goto l_0x1010_1ff8; /* jmp 0x10101ff8 */
        l_0x1010_20de:
            ii(0x1010_20de, 7); mov(memb_a32[ds, 0x101c_391e], 0x7);    /* mov byte [0x101c391e], 0x7 */
            ii(0x1010_20e5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_20e7, 6); lea(eax, ebp - 0x110);                  /* lea eax, [ebp-0x110] */
            ii(0x1010_20ed, 5); calld(0x1014_97af, 0x4_76bd);           /* call 0x101497af */
            ii(0x1010_20f2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_20f4, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1010_20f7, 5); calld(0x1007_5f2c, -0x8_c1d0);          /* call 0x10075f2c */
            ii(0x1010_20fc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_20fe, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_2101, 5); calld(0x100e_0244, -0x2_1ec2);          /* call 0x100e0244 */
            ii(0x1010_2106, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_2108, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_210b, 5); calld(0x1008_8b04, -0x7_960c);          /* call 0x10088b04 */
            ii(0x1010_2110, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2112, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_2113, 1); popd(edi);                              /* pop edi */
            ii(0x1010_2114, 1); popd(esi);                              /* pop esi */
            ii(0x1010_2115, 1); popd(edx);                              /* pop edx */
            ii(0x1010_2116, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_2117, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_2118, 1); retd(); return;                         /* ret */
        }
    }
}
