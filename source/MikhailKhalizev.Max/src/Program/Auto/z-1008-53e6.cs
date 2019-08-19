using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_53e6-d48c1301")]
        public void Method_1008_53e6()
        {
            ii(0x1008_53e6, 5); pushd(0x94);                            /* push 0x94 */
            ii(0x1008_53eb, 5); calld(Definitions.sys_check_available_stack_size, 0xe_0962); /* call 0x10165d52 */
            ii(0x1008_53f0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_53f1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_53f2, 1); pushd(esi);                             /* push esi */
            ii(0x1008_53f3, 1); pushd(edi);                             /* push edi */
            ii(0x1008_53f4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_53f5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_53f7, 6); sub(esp, 0x7c);                         /* sub esp, 0x7c */
            ii(0x1008_53fd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_5400, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_5403, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_5407, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_540a, 5); calld(0x1008_bbed, 0x67de);             /* call 0x1008bbed */
            ii(0x1008_540f, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1008_5412, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_5416, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_5419, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_541c, 5); calld(0x1008_9d08, 0x48e7);             /* call 0x10089d08 */
            ii(0x1008_5421, 3); lea(ebx, ebp - 0x58);                   /* lea ebx, [ebp-0x58] */
            ii(0x1008_5424, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_5426, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_5428, 5); calld(0x1008_9be4, 0x47b7);             /* call 0x10089be4 */
            ii(0x1008_542d, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_5431, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_5434, 5); calld(0x1007_64fc, -0xef3d);            /* call 0x100764fc */
            ii(0x1008_5439, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1008_543c, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_5440, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_5443, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_5446, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_5449, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1008_544f, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x1008_5454, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_5456, 5); calld(0x1008_a0c8, 0x4c6d);             /* call 0x1008a0c8 */
            ii(0x1008_545b, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1008_545e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_5461, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1008_5464, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_5469, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_546b, 2); if(jnzd(0x1008_5473, 0x6)) goto l_0x1008_5473; /* jnz 0x10085473 */
            ii(0x1008_546d, 4); mov(memb_a32[ss, ebp - 0x10], 0x3);     /* mov byte [ebp-0x10], 0x3 */
            ii(0x1008_5471, 2); jmpd(0x1008_5477, 0x4); goto l_0x1008_5477; /* jmp 0x10085477 */
        l_0x1008_5473:
            ii(0x1008_5473, 4); mov(memb_a32[ss, ebp - 0x10], 0x2);     /* mov byte [ebp-0x10], 0x2 */
        l_0x1008_5477:
            ii(0x1008_5477, 4); movsx(ecx, memb_a32[ss, ebp - 0x10]);   /* movsx ecx, byte [ebp-0x10] */
            ii(0x1008_547b, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1008_5480, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_5483, 5); calld(0x1008_a6f8, 0x5270);             /* call 0x1008a6f8 */
            ii(0x1008_5488, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_548a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_548d, 5); calld(0x1011_ef28, 0x9_9a96);           /* call 0x1011ef28 */
            ii(0x1008_5492, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_5495, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_5498, 5); calld(0x1008_9d08, 0x486b);             /* call 0x10089d08 */
            ii(0x1008_549d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_549f, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_54a2, 5); calld(0x1008_9b68, 0x46c1);             /* call 0x10089b68 */
            ii(0x1008_54a7, 2); jmpd(0x1008_54b1, 0x8); goto l_0x1008_54b1; /* jmp 0x100854b1 */
        l_0x1008_54a9:
            ii(0x1008_54a9, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_54ac, 5); calld(0x1007_6bf8, -0xe8b9);            /* call 0x10076bf8 */
        l_0x1008_54b1:
            ii(0x1008_54b1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_54b3, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_54b6, 5); calld(0x1013_ad71, 0xb_58b6);           /* call 0x1013ad71 */
            ii(0x1008_54bb, 2); test(al, al);                           /* test al, al */
            ii(0x1008_54bd, 2); if(jzd(0x1008_5528, 0x69)) goto l_0x1008_5528; /* jz 0x10085528 */
            ii(0x1008_54bf, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_54c2, 5); calld(0x1008_9acc, 0x4605);             /* call 0x10089acc */
            ii(0x1008_54c7, 5); calld(0x1008_9fc4, 0x4af8);             /* call 0x10089fc4 */
            ii(0x1008_54cc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_54ce, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_54d1, 5); calld(0x1007_643c, -0xf09a);            /* call 0x1007643c */
            ii(0x1008_54d6, 2); jmpd(0x1008_54e0, 0x8); goto l_0x1008_54e0; /* jmp 0x100854e0 */
        l_0x1008_54d8:
            ii(0x1008_54d8, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_54db, 5); calld(0x1007_6bf8, -0xe8e8);            /* call 0x10076bf8 */
        l_0x1008_54e0:
            ii(0x1008_54e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_54e2, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_54e5, 5); calld(0x1013_ad71, 0xb_5887);           /* call 0x1013ad71 */
            ii(0x1008_54ea, 2); test(al, al);                           /* test al, al */
            ii(0x1008_54ec, 2); if(jzd(0x1008_5526, 0x38)) goto l_0x1008_5526; /* jz 0x10085526 */
            ii(0x1008_54ee, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_54f1, 5); calld(0x1007_6408, -0xf0ee);            /* call 0x10076408 */
            ii(0x1008_54f6, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_54f9, 2); if(jzd(0x1008_5524, 0x29)) goto l_0x1008_5524; /* jz 0x10085524 */
            ii(0x1008_54fb, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_54fe, 5); calld(0x1007_63a0, -0xf163);            /* call 0x100763a0 */
            ii(0x1008_5503, 3); mov(ebx, memd_a32[ds, eax + 0x1e]);     /* mov ebx, [eax+0x1e] */
            ii(0x1008_5506, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_5509, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_550c, 5); calld(0x1007_63a0, -0xf171);            /* call 0x100763a0 */
            ii(0x1008_5511, 3); mov(edx, memd_a32[ds, eax + 0x1c]);     /* mov edx, [eax+0x1c] */
            ii(0x1008_5514, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_5517, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_551a, 5); calld(0x1008_a728, 0x5209);             /* call 0x1008a728 */
            ii(0x1008_551f, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_5521, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x1008_5524:
            ii(0x1008_5524, 2); jmpd(0x1008_54d8, -0x4e); goto l_0x1008_54d8; /* jmp 0x100854d8 */
        l_0x1008_5526:
            ii(0x1008_5526, 2); jmpd(0x1008_54a9, -0x7f); goto l_0x1008_54a9; /* jmp 0x100854a9 */
        l_0x1008_5528:
            ii(0x1008_5528, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_552a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_552d, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_5530, 5); calld(0x1013_ad71, 0xb_583c);           /* call 0x1013ad71 */
            ii(0x1008_5535, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5537, 2); if(jzd(0x1008_55a3, 0x6a)) goto l_0x1008_55a3; /* jz 0x100855a3 */
            ii(0x1008_5539, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_553c, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_553f, 5); calld(0x1008_9970, 0x442c);             /* call 0x10089970 */
            ii(0x1008_5544, 5); calld(0x1008_9a74, 0x452b);             /* call 0x10089a74 */
            ii(0x1008_5549, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_554b, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_554e, 5); calld(0x1007_643c, -0xf117);            /* call 0x1007643c */
            ii(0x1008_5553, 2); jmpd(0x1008_555d, 0x8); goto l_0x1008_555d; /* jmp 0x1008555d */
        l_0x1008_5555:
            ii(0x1008_5555, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_5558, 5); calld(0x1007_6bf8, -0xe965);            /* call 0x10076bf8 */
        l_0x1008_555d:
            ii(0x1008_555d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_555f, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_5562, 5); calld(0x1013_ad71, 0xb_580a);           /* call 0x1013ad71 */
            ii(0x1008_5567, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5569, 2); if(jzd(0x1008_55a3, 0x38)) goto l_0x1008_55a3; /* jz 0x100855a3 */
            ii(0x1008_556b, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_556e, 5); calld(0x1007_6408, -0xf16b);            /* call 0x10076408 */
            ii(0x1008_5573, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_5576, 2); if(jzd(0x1008_55a1, 0x29)) goto l_0x1008_55a1; /* jz 0x100855a1 */
            ii(0x1008_5578, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_557b, 5); calld(0x1007_63a0, -0xf1e0);            /* call 0x100763a0 */
            ii(0x1008_5580, 3); mov(ebx, memd_a32[ds, eax + 0x1e]);     /* mov ebx, [eax+0x1e] */
            ii(0x1008_5583, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_5586, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_5589, 5); calld(0x1007_63a0, -0xf1ee);            /* call 0x100763a0 */
            ii(0x1008_558e, 3); mov(edx, memd_a32[ds, eax + 0x1c]);     /* mov edx, [eax+0x1c] */
            ii(0x1008_5591, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_5594, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_5597, 5); calld(0x1008_a728, 0x518c);             /* call 0x1008a728 */
            ii(0x1008_559c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_559e, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x1008_55a1:
            ii(0x1008_55a1, 2); jmpd(0x1008_5555, -0x4e); goto l_0x1008_5555; /* jmp 0x10085555 */
        l_0x1008_55a3:
            ii(0x1008_55a3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_55a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_55a9, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_55ac, 5); calld(0x1008_b4ec, 0x5f3b);             /* call 0x1008b4ec */
            ii(0x1008_55b1, 2); test(al, al);                           /* test al, al */
            ii(0x1008_55b3, 2); if(jzd(0x1008_55c6, 0x11)) goto l_0x1008_55c6; /* jz 0x100855c6 */
            ii(0x1008_55b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_55b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_55ba, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_55bd, 5); calld(0x1013_ad71, 0xb_57af);           /* call 0x1013ad71 */
            ii(0x1008_55c2, 2); test(al, al);                           /* test al, al */
            ii(0x1008_55c4, 2); if(jnzd(0x1008_55c8, 0x2)) goto l_0x1008_55c8; /* jnz 0x100855c8 */
        l_0x1008_55c6:
            ii(0x1008_55c6, 2); jmpd(0x1008_55f7, 0x2f); goto l_0x1008_55f7; /* jmp 0x100855f7 */
        l_0x1008_55c8:
            ii(0x1008_55c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_55cb, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_55ce, 5); calld(0x1007_6574, -0xf05f);            /* call 0x10076574 */
            ii(0x1008_55d3, 3); mov(ebx, memd_a32[ds, eax + 0x1e]);     /* mov ebx, [eax+0x1e] */
            ii(0x1008_55d6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_55d9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_55dc, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_55df, 5); calld(0x1007_6574, -0xf070);            /* call 0x10076574 */
            ii(0x1008_55e4, 3); mov(edx, memd_a32[ds, eax + 0x1c]);     /* mov edx, [eax+0x1c] */
            ii(0x1008_55e7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_55ea, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_55ed, 5); calld(0x1008_a728, 0x5136);             /* call 0x1008a728 */
            ii(0x1008_55f2, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_55f4, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x1008_55f7:
            ii(0x1008_55f7, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_55fa, 5); calld(Definitions.my_ctor_0x101b_4184, -0xeb0f); /* call 0x10076af0 */
            ii(0x1008_55ff, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x1008_5602, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_5605, 5); calld(0x1008_527a, -0x390);             /* call 0x1008527a */
            ii(0x1008_560a, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1008_560d, 3); mov(ebx, memd_a32[ds, ebx + 0x1a]);     /* mov ebx, [ebx+0x1a] */
            ii(0x1008_5610, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_5613, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_5616, 3); mov(edx, memd_a32[ds, edx + 0x18]);     /* mov edx, [edx+0x18] */
            ii(0x1008_5619, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_561c, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1008_561f, 5); calld(0x1007_6aac, -0xeb78);            /* call 0x10076aac */
            ii(0x1008_5624, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1008_5627, 3); mov(ebx, memd_a32[ds, ebx + 0x1a]);     /* mov ebx, [ebx+0x1a] */
            ii(0x1008_562a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_562d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_5630, 3); mov(edx, memd_a32[ds, edx + 0x18]);     /* mov edx, [edx+0x18] */
            ii(0x1008_5633, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_5636, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_5639, 5); calld(0x1007_6aac, -0xeb92);            /* call 0x10076aac */
            ii(0x1008_563e, 3); mov(eax, memd_a32[ss, ebp - 0x42]);     /* mov eax, [ebp-0x42] */
            ii(0x1008_5641, 3); sub(eax, memd_a32[ss, ebp - 0x3e]);     /* sub eax, [ebp-0x3e] */
            ii(0x1008_5644, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_5647, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1008_564a, 3); sub(eax, memd_a32[ss, ebp - 0x40]);     /* sub eax, [ebp-0x40] */
            ii(0x1008_564d, 1); cwde();                                 /* cwde */
            ii(0x1008_564e, 5); calld(0x1015_c339, 0xd_6ce6);           /* call 0x1015c339 */
            ii(0x1008_5653, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1008_5656, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x1008_5659, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_565c, 5); calld(0x1007_5e64, -0xf7fd);            /* call 0x10075e64 */
            ii(0x1008_5661, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_5663, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x1008_5666, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1008_5669, 5); calld(0x1007_5e64, -0xf80a);            /* call 0x10075e64 */
            ii(0x1008_566e, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_5670, 5); calld(0x100a_5fca, 0x2_0955);           /* call 0x100a5fca */
            ii(0x1008_5675, 3); imul(eax, eax, 0x32);                   /* imul eax, eax, 0x32 */
            ii(0x1008_5678, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_567b, 7); mov(memd_a32[ss, ebp - 0x28], 0x1);     /* mov dword [ebp-0x28], 0x1 */
            ii(0x1008_5682, 2); jmpd(0x1008_568a, 0x6); goto l_0x1008_568a; /* jmp 0x1008568a */
        l_0x1008_5684:
            ii(0x1008_5684, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1008_5687, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
        l_0x1008_568a:
            ii(0x1008_568a, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1008_568e, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1008_5693, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1008_5695, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1008_5698, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1008_569a, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1008_569e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_56a0, 6); if(jged(0x1008_589c, 0x1f6)) goto l_0x1008_589c; /* jge 0x1008589c */
            ii(0x1008_56a6, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1008_56a9, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1008_56ae, 5); and(eax, 0x7);                          /* and eax, 0x7 */
            ii(0x1008_56b3, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_56b6, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1008_56ba, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_56bd, 7); mov(ax, memw_a32[ds, eax + 0x101c_5348]); /* mov ax, [eax+0x101c5348] */
            ii(0x1008_56c4, 4); imul(eax, memd_a32[ss, ebp - 0x28]);    /* imul eax, [ebp-0x28] */
            ii(0x1008_56c8, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x1008_56cb, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_56cd, 4); mov(memw_a32[ss, ebp - 0x48], dx);      /* mov [ebp-0x48], dx */
            ii(0x1008_56d1, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1008_56d5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_56d8, 7); mov(ax, memw_a32[ds, eax + 0x101c_534a]); /* mov ax, [eax+0x101c534a] */
            ii(0x1008_56df, 4); imul(eax, memd_a32[ss, ebp - 0x28]);    /* imul eax, [ebp-0x28] */
            ii(0x1008_56e3, 3); mov(edx, memd_a32[ss, ebp - 0x42]);     /* mov edx, [ebp-0x42] */
            ii(0x1008_56e6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_56e8, 4); mov(memw_a32[ss, ebp - 0x46], dx);      /* mov [ebp-0x46], dx */
            ii(0x1008_56ec, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_56ef, 5); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x1008_56f4, 5); and(eax, 0x6);                          /* and eax, 0x6 */
            ii(0x1008_56f9, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_56fc, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1008_56ff, 5); and(eax, 0x1);                          /* and eax, 0x1 */
            ii(0x1008_5704, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1008_5707, 2); jmpd(0x1008_570d, 0x4); goto l_0x1008_570d; /* jmp 0x1008570d */
        l_0x1008_5709:
            ii(0x1008_5709, 4); add(memd_a32[ss, ebp - 0x24], 0x2);     /* add dword [ebp-0x24], 0x2 */
        l_0x1008_570d:
            ii(0x1008_570d, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1008_5711, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1008_5714, 6); if(jged(0x1008_5897, 0x17d)) goto l_0x1008_5897; /* jge 0x10085897 */
            ii(0x1008_571a, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1008_571d, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1008_5720, 2); jmpd(0x1008_5760, 0x3e); goto l_0x1008_5760; /* jmp 0x10085760 */
        //  ii(0x1008_5722, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
        //  ii(0x1008_5725, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        //  ii(0x1008_5728, 2); jmpd(0x1008_577d, 0x53); goto l_0x1008_577d; /* jmp 0x1008577d */
        //  ii(0x1008_572a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
        //  ii(0x1008_572d, 2); add(eax, eax);                          /* add eax, eax */
        //  ii(0x1008_572f, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        //  ii(0x1008_5732, 2); jmpd(0x1008_577d, 0x49); goto l_0x1008_577d; /* jmp 0x1008577d */
        //  ii(0x1008_5734, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
        //  ii(0x1008_5737, 2); add(eax, eax);                          /* add eax, eax */
        //  ii(0x1008_5739, 1); inc(eax);                               /* inc eax */
        //  ii(0x1008_573a, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        //  ii(0x1008_573d, 2); jmpd(0x1008_577d, 0x3e); goto l_0x1008_577d; /* jmp 0x1008577d */
        //  ii(0x1008_573f, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
        //  ii(0x1008_5742, 1); inc(eax);                               /* inc eax */
        //  ii(0x1008_5743, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        //  ii(0x1008_5746, 2); jmpd(0x1008_577d, 0x35); goto l_0x1008_577d; /* jmp 0x1008577d */
        l_0x1008_5748:
            ii(0x1008_5748, 2); jmpd(0x1008_577d, 0x33); goto l_0x1008_577d; /* jmp 0x1008577d */
        //  ii(0x1008_574a, 2); mov(eax, eax);                          /* mov eax, eax */
        //  ii(0x1008_574c, 3); and(dl, memb_a32[ds, edi + 0x8]);       /* and dl, [edi+0x8] */
        //  ii(0x1008_574f, 2); adc(memb_a32[ds, edx], ch);             /* adc [edx], ch */
        //  ii(0x1008_5751, 1); pushd(edi);                             /* push edi */
        //  ii(0x1008_5752, 2); or(memb_a32[ds, eax], dl);              /* or [eax], dl */
        //  ii(0x1008_5754, 3); sub(dl, memb_a32[ds, edi + 0x8]);       /* sub dl, [edi+0x8] */
        //  ii(0x1008_5757, 3); adc(memb_a32[ds, edi + edx * 2], dh);   /* adc [edi+edx*2], dh */
        //  ii(0x1008_575a, 2); or(memb_a32[ds, eax], dl);              /* or [eax], dl */
        //  ii(0x1008_575c, 1); aas();                                  /* aas */
        //  ii(0x1008_575d, 1); pushd(edi);                             /* push edi */
        //  ii(0x1008_575e, 2); or(memb_a32[ds, eax], dl);              /* or [eax], dl */
        l_0x1008_5760:
            ii(0x1008_5760, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1008_5763, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x1008_5766, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x4);     /* cmp word [ebp-0x6c], 0x4 */
            ii(0x1008_576b, 2); if(jad(0x1008_5748, -0x25)) goto l_0x1008_5748; /* ja 0x10085748 */
            ii(0x1008_576d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_576f, 4); mov(ax, memw_a32[ss, ebp - 0x6c]);      /* mov ax, [ebp-0x6c] */
            ii(0x1008_5773, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_5776, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1008_574c])) return; /* jmp dword [cs:eax+0x1008574c] */
        l_0x1008_577d:
            ii(0x1008_577d, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1008_5784, 2); jmpd(0x1008_578c, 0x6); goto l_0x1008_578c; /* jmp 0x1008578c */
        l_0x1008_5786:
            ii(0x1008_5786, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_5789, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1008_578c:
            ii(0x1008_578c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_578f, 4); cmp(ax, memw_a32[ss, ebp - 0x2c]);      /* cmp ax, [ebp-0x2c] */
            ii(0x1008_5793, 6); if(jged(0x1008_5882, 0xe9)) goto l_0x1008_5882; /* jge 0x10085882 */
            ii(0x1008_5799, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x1008_579d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_579f, 2); if(jld(0x1008_57ad, 0xc)) goto l_0x1008_57ad; /* jl 0x100857ad */
            ii(0x1008_57a1, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1008_57a4, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1008_57ab, 2); if(jld(0x1008_57af, 0x2)) goto l_0x1008_57af; /* jl 0x100857af */
        l_0x1008_57ad:
            ii(0x1008_57ad, 2); jmpd(0x1008_57b7, 0x8); goto l_0x1008_57b7; /* jmp 0x100857b7 */
        l_0x1008_57af:
            ii(0x1008_57af, 4); movsx(eax, memw_a32[ss, ebp - 0x46]);   /* movsx eax, word [ebp-0x46] */
            ii(0x1008_57b3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_57b5, 2); if(jged(0x1008_57b9, 0x2)) goto l_0x1008_57b9; /* jge 0x100857b9 */
        l_0x1008_57b7:
            ii(0x1008_57b7, 2); jmpd(0x1008_57c5, 0xc); goto l_0x1008_57c5; /* jmp 0x100857c5 */
        l_0x1008_57b9:
            ii(0x1008_57b9, 3); mov(eax, memd_a32[ss, ebp - 0x46]);     /* mov eax, [ebp-0x46] */
            ii(0x1008_57bc, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1008_57c3, 2); if(jld(0x1008_57c7, 0x2)) goto l_0x1008_57c7; /* jl 0x100857c7 */
        l_0x1008_57c5:
            ii(0x1008_57c5, 2); jmpd(0x1008_57e4, 0x1d); goto l_0x1008_57e4; /* jmp 0x100857e4 */
        l_0x1008_57c7:
            ii(0x1008_57c7, 4); movsx(ebx, memw_a32[ss, ebp - 0x46]);   /* movsx ebx, word [ebp-0x46] */
            ii(0x1008_57cb, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x1008_57cf, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_57d2, 5); calld(0x1008_a728, 0x4f51);             /* call 0x1008a728 */
            ii(0x1008_57d7, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_57d9, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1008_57db, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_57e0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_57e2, 2); if(jgd(0x1008_57e6, 0x2)) goto l_0x1008_57e6; /* jg 0x100857e6 */
        l_0x1008_57e4:
            ii(0x1008_57e4, 2); jmpd(0x1008_5805, 0x1f); goto l_0x1008_5805; /* jmp 0x10085805 */
        l_0x1008_57e6:
            ii(0x1008_57e6, 4); cmp(memd_a32[ss, ebp - 0x4c], 0);       /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x1008_57ea, 2); if(jzd(0x1008_5803, 0x17)) goto l_0x1008_5803; /* jz 0x10085803 */
            ii(0x1008_57ec, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x1008_57f0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_57f3, 3); add(eax, memd_a32[ss, ebp - 0x4c]);     /* add eax, [ebp-0x4c] */
            ii(0x1008_57f6, 4); movsx(edx, memw_a32[ss, ebp - 0x46]);   /* movsx edx, word [ebp-0x46] */
            ii(0x1008_57fa, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_57fc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_57fe, 3); test(memb_a32[ds, eax], 0x8);           /* test byte [eax], 0x8 */
            ii(0x1008_5801, 2); if(jnzd(0x1008_5805, 0x2)) goto l_0x1008_5805; /* jnz 0x10085805 */
        l_0x1008_5803:
            ii(0x1008_5803, 2); jmpd(0x1008_5807, 0x2); goto l_0x1008_5807; /* jmp 0x10085807 */
        l_0x1008_5805:
            ii(0x1008_5805, 2); jmpd(0x1008_5867, 0x60); goto l_0x1008_5867; /* jmp 0x10085867 */
        l_0x1008_5807:
            ii(0x1008_5807, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x1008_580a, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1008_580d, 5); calld(0x1007_5e64, -0xf9ae);            /* call 0x10075e64 */
            ii(0x1008_5812, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_5814, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x1008_5817, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x1008_581a, 5); calld(0x1007_5e64, -0xf9bb);            /* call 0x10075e64 */
            ii(0x1008_581f, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_5821, 5); calld(0x100a_5fca, 0x2_07a4);           /* call 0x100a5fca */
            ii(0x1008_5826, 3); imul(ecx, eax, 0x32);                   /* imul ecx, eax, 0x32 */
            ii(0x1008_5829, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x1008_582c, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1008_582f, 5); calld(0x1007_5e64, -0xf9d0);            /* call 0x10075e64 */
            ii(0x1008_5834, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_5836, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x1008_5839, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1008_583c, 5); calld(0x1007_5e64, -0xf9dd);            /* call 0x10075e64 */
            ii(0x1008_5841, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_5843, 5); calld(0x100a_5fca, 0x2_0782);           /* call 0x100a5fca */
            ii(0x1008_5848, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1008_584a, 3); mov(memd_a32[ss, ebp - 0x14], ecx);     /* mov [ebp-0x14], ecx */
            ii(0x1008_584d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_5850, 4); cmp(ax, memw_a32[ss, ebp - 0x1c]);      /* cmp ax, [ebp-0x1c] */
            ii(0x1008_5854, 2); if(jged(0x1008_5867, 0x11)) goto l_0x1008_5867; /* jge 0x10085867 */
            ii(0x1008_5856, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_5859, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_585c, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x1008_585f, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_5862, 5); calld(0x1008_8b44, 0x32dd);             /* call 0x10088b44 */
        l_0x1008_5867:
            ii(0x1008_5867, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1008_586b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_586e, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1008_5873, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_5875, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_5878, 5); calld(0x1008_b1a4, 0x5927);             /* call 0x1008b1a4 */
            ii(0x1008_587d, 5); jmpd(0x1008_5786, -0xfc); goto l_0x1008_5786; /* jmp 0x10085786 */
        l_0x1008_5882:
            ii(0x1008_5882, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_5885, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1008_588a, 5); and(eax, 0x7);                          /* and eax, 0x7 */
            ii(0x1008_588f, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_5892, 5); jmpd(0x1008_5709, -0x18e); goto l_0x1008_5709; /* jmp 0x10085709 */
        l_0x1008_5897:
            ii(0x1008_5897, 5); jmpd(0x1008_5684, -0x218); goto l_0x1008_5684; /* jmp 0x10085684 */
        l_0x1008_589c:
            ii(0x1008_589c, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1008_589f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_58a2, 4); mov(memw_a32[ds, edx + 0x1e], ax);      /* mov [edx+0x1e], ax */
            ii(0x1008_58a6, 3); mov(eax, memd_a32[ss, ebp - 0x3a]);     /* mov eax, [ebp-0x3a] */
            ii(0x1008_58a9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_58ac, 4); mov(memw_a32[ds, edx + 0x20], ax);      /* mov [edx+0x20], ax */
            ii(0x1008_58b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_58b2, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_58b5, 5); calld(0x1007_5f6c, -0xf94e);            /* call 0x10075f6c */
            ii(0x1008_58ba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_58bc, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_58bf, 5); calld(0x1008_9044, 0x3780);             /* call 0x10089044 */
            ii(0x1008_58c4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_58c6, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_58c9, 5); calld(0x1008_bc9f, 0x63d1);             /* call 0x1008bc9f */
            ii(0x1008_58ce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_58d0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_58d1, 1); popd(edi);                              /* pop edi */
            ii(0x1008_58d2, 1); popd(esi);                              /* pop esi */
            ii(0x1008_58d3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_58d4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_58d5, 1); retd(); return;                         /* ret */
        }
    }
}
