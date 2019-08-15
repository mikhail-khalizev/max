using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1373b9c0-cc14-4de0-ae24-fb5ffaf8d241")]
        public void Method_1015_f502()
        {
            ii(0x1015_f502, 5); pushd(0x7c);                            /* push 0x7c */
            ii(0x1015_f507, 5); calld(Definitions.sys_check_available_stack_size, 0x6846); /* call 0x10165d52 */
            ii(0x1015_f50c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_f50d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_f50e, 1); pushd(edx);                             /* push edx */
            ii(0x1015_f50f, 1); pushd(esi);                             /* push esi */
            ii(0x1015_f510, 1); pushd(edi);                             /* push edi */
            ii(0x1015_f511, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_f512, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_f514, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x1015_f51a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_f51d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_f51f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_f522, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1015_f525, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_f528, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f52b, 5); calld(0x1015_26ac, -0xce84);            /* call 0x101526ac */
            ii(0x1015_f530, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x1015_f533, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f535, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_f537, 5); calld(0x1008_b060, -0xd_44dc);          /* call 0x1008b060 */
            ii(0x1015_f53c, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1015_f540, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1015_f543, 5); calld(Definitions.my_ctor_0x101b38f8, -0xe_8e58); /* call 0x100766f0 */
            ii(0x1015_f548, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1015_f54b, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1015_f54f, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1015_f553, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_f556, 5); calld(Definitions.my_ctor_0x101b38f8, -0xe_8e6b); /* call 0x100766f0 */
            ii(0x1015_f55b, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1015_f55e, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1015_f562, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1015_f566, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1015_f569, 5); calld(Definitions.my_ctor_0x101b38f8, -0xe_8e7e); /* call 0x100766f0 */
            ii(0x1015_f56e, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1015_f571, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1015_f575, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f578, 4); mov(ax, memw_a32[ds, eax + 0x41]);      /* mov ax, [eax+0x41] */
            ii(0x1015_f57c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_f57f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f582, 4); mov(ax, memw_a32[ds, eax + 0x43]);      /* mov ax, [eax+0x43] */
            ii(0x1015_f586, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_f589, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f58c, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1015_f590, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_f593, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f596, 5); calld(0x1015_f2cc, -0x2cf);             /* call 0x1015f2cc */
            ii(0x1015_f59b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_f5a0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f5a1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_f5a3, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f5a4, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_f5a6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_f5a8, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1015_f5ac, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_f5b0, 5); calld(0x1007_4395, -0xe_b220);          /* call 0x10074395 */
            ii(0x1015_f5b5, 5); calld(0x1010_2b84, -0x5_ca36);          /* call 0x10102b84 */
            ii(0x1015_f5ba, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_f5bf, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f5c0, 5); calld(0x1010_2ba4, -0x5_ca21);          /* call 0x10102ba4 */
            ii(0x1015_f5c5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_f5ca, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f5cb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_f5cd, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f5ce, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1015_f5d2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f5d3, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_f5d7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f5d8, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_f5da, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1015_f5de, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x1015_f5e3, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1015_f5e6, 5); calld(0x1015_a2da, -0x5311);            /* call 0x1015a2da */
            ii(0x1015_f5eb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f5ed, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1015_f5f0, 5); calld(0x1008_ac18, -0xd_49dd);          /* call 0x1008ac18 */
            ii(0x1015_f5f5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f5f7, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1015_f5fa, 5); calld(0x1007_5f2c, -0xe_96d3);          /* call 0x10075f2c */
            ii(0x1015_f5ff, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_f602, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_f605, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_f608, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_f60b, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x1015_f60e, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1015_f611, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_f615, 5); calld(0x1015_a0f9, -0x5521);            /* call 0x1015a0f9 */
            ii(0x1015_f61a, 5); calld(0x1010_2b84, -0x5_ca9b);          /* call 0x10102b84 */
            ii(0x1015_f61f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_f624, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f625, 5); calld(0x1010_2ba4, -0x5_ca86);          /* call 0x10102ba4 */
            ii(0x1015_f62a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_f62f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f630, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_f632, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f633, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1015_f637, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f638, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_f63c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f63d, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1015_f640, 5); calld(0x1007_6574, -0xe_90d1);          /* call 0x10076574 */
            ii(0x1015_f645, 5); calld(0x1007_6204, -0xe_9446);          /* call 0x10076204 */
            ii(0x1015_f64a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_f64c, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1015_f650, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1015_f655, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1015_f658, 5); calld(0x1015_a2da, -0x5383);            /* call 0x1015a2da */
            ii(0x1015_f65d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f65f, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_f662, 5); calld(0x1008_ac18, -0xd_4a4f);          /* call 0x1008ac18 */
            ii(0x1015_f667, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f669, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1015_f66c, 5); calld(0x1007_5f2c, -0xe_9745);          /* call 0x10075f2c */
            ii(0x1015_f671, 5); calld(0x1010_2b84, -0x5_caf2);          /* call 0x10102b84 */
            ii(0x1015_f676, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_f67b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f67c, 5); calld(0x1010_2ba4, -0x5_cadd);          /* call 0x10102ba4 */
            ii(0x1015_f681, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_f686, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f687, 5); mov(eax, memd_a32[ds, 0x101c_855c]);    /* mov eax, [0x101c855c] */
            ii(0x1015_f68c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f68e, 3); mov(dl, memb_a32[ds, eax + 0x1]);       /* mov dl, [eax+0x1] */
            ii(0x1015_f691, 5); calld(/* sys */ 0x1016_5e9b, 0x6805);   /* call 0x10165e9b */
            ii(0x1015_f696, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1015_f699, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1015_f69c, 1); cwde();                                 /* cwde */
            ii(0x1015_f69d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f69e, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1015_f6a2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f6a3, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_f6a7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f6a8, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_f6aa, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1015_f6ae, 5); mov(edx, 0x12);                         /* mov edx, 0x12 */
            ii(0x1015_f6b3, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_f6b6, 5); calld(0x1015_a2da, -0x53e1);            /* call 0x1015a2da */
            ii(0x1015_f6bb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f6bd, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1015_f6c0, 5); calld(0x1008_ac18, -0xd_4aad);          /* call 0x1008ac18 */
            ii(0x1015_f6c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f6c7, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_f6ca, 5); calld(0x1007_5f2c, -0xe_97a3);          /* call 0x10075f2c */
            ii(0x1015_f6cf, 4); movsx(ebx, memw_a32[ss, ebp - 0x20]);   /* movsx ebx, word [ebp-0x20] */
            ii(0x1015_f6d3, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1015_f6d7, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1015_f6da, 5); calld(0x1008_abbc, -0xd_4b23);          /* call 0x1008abbc */
            ii(0x1015_f6df, 5); calld(0x1016_3263, 0x3b7f);             /* call 0x10163263 */
            ii(0x1015_f6e4, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1015_f6e7, 5); calld(0x1007_6574, -0xe_9178);          /* call 0x10076574 */
            ii(0x1015_f6ec, 4); mov(memb_a32[ds, eax + 0x2d], 0x4);     /* mov byte [eax+0x2d], 0x4 */
            ii(0x1015_f6f0, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1015_f6f3, 5); calld(0x1007_6574, -0xe_9184);          /* call 0x10076574 */
            ii(0x1015_f6f8, 4); mov(memb_a32[ds, eax + 0x2d], 0x4);     /* mov byte [eax+0x2d], 0x4 */
            ii(0x1015_f6fc, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_f6ff, 5); calld(0x1007_6574, -0xe_9190);          /* call 0x10076574 */
            ii(0x1015_f704, 4); mov(memb_a32[ds, eax + 0x2d], 0x4);     /* mov byte [eax+0x2d], 0x4 */
            ii(0x1015_f708, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1015_f70b, 5); calld(0x1007_6574, -0xe_919c);          /* call 0x10076574 */
            ii(0x1015_f710, 4); mov(memb_a32[ds, eax + 0x3d], 0x1);     /* mov byte [eax+0x3d], 0x1 */
            ii(0x1015_f714, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1015_f717, 5); calld(0x1007_6574, -0xe_91a8);          /* call 0x10076574 */
            ii(0x1015_f71c, 4); mov(memb_a32[ds, eax + 0x3e], 0x17);    /* mov byte [eax+0x3e], 0x17 */
            ii(0x1015_f720, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1015_f725, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1015_f728, 5); calld(0x1007_6600, -0xe_912d);          /* call 0x10076600 */
            ii(0x1015_f72d, 5); calld(0x1016_2f0a, 0x37d8);             /* call 0x10162f0a */
            ii(0x1015_f732, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1015_f737, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1015_f73a, 5); calld(0x1007_6600, -0xe_913f);          /* call 0x10076600 */
            ii(0x1015_f73f, 5); calld(0x1016_2f0a, 0x37c6);             /* call 0x10162f0a */
            ii(0x1015_f744, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1015_f749, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_f74c, 5); calld(0x1007_6600, -0xe_9151);          /* call 0x10076600 */
            ii(0x1015_f751, 5); calld(0x1016_2f0a, 0x37b4);             /* call 0x10162f0a */
            ii(0x1015_f756, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f758, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1015_f75b, 5); calld(0x1013_ad71, -0x2_49ef);          /* call 0x1013ad71 */
            ii(0x1015_f760, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f762, 2); if(jzd(0x1015_f79e, 0x3a)) goto l_0x1015_f79e; /* jz 0x1015f79e */
            ii(0x1015_f764, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1015_f767, 5); calld(0x1008_af84, -0xd_47e8);          /* call 0x1008af84 */
            ii(0x1015_f76c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f76e, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1015_f771, 5); calld(0x1007_6574, -0xe_9202);          /* call 0x10076574 */
            ii(0x1015_f776, 5); calld(0x1015_27ed, -0xcf8e);            /* call 0x101527ed */
            ii(0x1015_f77b, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1015_f77e, 5); calld(0x1008_af28, -0xd_485b);          /* call 0x1008af28 */
            ii(0x1015_f783, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1015_f786, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1015_f789, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1015_f78c, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_f78f, 5); calld(0x1007_65d0, -0xe_91c4);          /* call 0x100765d0 */
            ii(0x1015_f794, 3); mov(ecx, memd_a32[ss, ebp - 0x4c]);     /* mov ecx, [ebp-0x4c] */
            ii(0x1015_f797, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f799, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1015_f79b, 3); calld_abs(memd_a32[ds, ebx + 0x2c]);    /* call dword [ebx+0x2c] */
        l_0x1015_f79e:
            ii(0x1015_f79e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f7a0, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1015_f7a3, 5); calld(0x1007_5f2c, -0xe_987c);          /* call 0x10075f2c */
            ii(0x1015_f7a8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f7aa, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_f7ad, 5); calld(0x1007_5f2c, -0xe_9886);          /* call 0x10075f2c */
            ii(0x1015_f7b2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f7b4, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1015_f7b7, 5); calld(0x1007_5f2c, -0xe_9890);          /* call 0x10075f2c */
            ii(0x1015_f7bc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f7be, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1015_f7c1, 5); calld(0x1008_8b7c, -0xd_6c4a);          /* call 0x10088b7c */
            ii(0x1015_f7c6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_f7c8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_f7c9, 1); popd(edi);                              /* pop edi */
            ii(0x1015_f7ca, 1); popd(esi);                              /* pop esi */
            ii(0x1015_f7cb, 1); popd(edx);                              /* pop edx */
            ii(0x1015_f7cc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_f7cd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_f7ce, 1); retd(); return;                         /* ret */
        }
    }
}
