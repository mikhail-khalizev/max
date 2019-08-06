using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("48ba4cf0-5391-4d50-8d1e-b53e3c787807")]
        public void Method_100e_55f8()
        {
            ii(0x100e_55f8, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x100e_55fd, 5); calld(Definitions.sys_check_available_stack_size, 0x80750); /* call 0x10165d52 */
            ii(0x100e_5602, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_5603, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_5604, 1); pushd(edx);                             /* push edx */
            ii(0x100e_5605, 1); pushd(esi);                             /* push esi */
            ii(0x100e_5606, 1); pushd(edi);                             /* push edi */
            ii(0x100e_5607, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_5608, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_560a, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100e_5610, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_5613, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_5616, 5); calld(Definitions.my_ctor_0x101b4184, -0x6eb2b); /* call 0x10076af0 */
            ii(0x100e_561b, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100e_561f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_5622, 5); calld(0x1007_64fc, -0x6f12b);           /* call 0x100764fc */
            ii(0x100e_5627, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_562a, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100e_562e, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x100e_5633, 5); calld(0x1007_6b90, -0x6eaa8);           /* call 0x10076b90 */
            ii(0x100e_5638, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_563a, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100e_563f, 5); calld(0x1007_6b90, -0x6eab4);           /* call 0x10076b90 */
            ii(0x100e_5644, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_5646, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_564b, 5); calld(0x1007_6b90, -0x6eac0);           /* call 0x10076b90 */
            ii(0x100e_5650, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_5652, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100e_5657, 5); calld(0x1007_6b90, -0x6eacc);           /* call 0x10076b90 */
            ii(0x100e_565c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_565e, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x100e_5663, 5); calld(0x1007_6b90, -0x6ead8);           /* call 0x10076b90 */
            ii(0x100e_5668, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_566a, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x100e_566d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_566f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_5672, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_5674, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100e_5677, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100e_567a, 5); calld(0x1007_6e7c, -0x6e803);           /* call 0x10076e7c */
            ii(0x100e_567f, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_5682, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_5684, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_5687, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x100e_568a, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100e_568d, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100e_5690, 5); calld(0x1007_6e7c, -0x6e819);           /* call 0x10076e7c */
            ii(0x100e_5695, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_5698, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100e_569e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_56a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_56a4, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_56a7, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_56aa, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100e_56ad, 1); inc(eax);                               /* inc eax */
            ii(0x100e_56ae, 5); calld(Definitions.my_min, -0x5bf2f);    /* call 0x10089784 */
            ii(0x100e_56b3, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100e_56b6, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x100e_56bc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_56bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_56c2, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_56c5, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_56c8, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100e_56cb, 1); inc(eax);                               /* inc eax */
            ii(0x100e_56cc, 5); calld(Definitions.my_min, -0x5bf4d);    /* call 0x10089784 */
            ii(0x100e_56d1, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_56d4, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_56d7, 3); sub(eax, memd_a32[ss, ebp - 0x30]);     /* sub eax, [ebp-0x30] */
            ii(0x100e_56da, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100e_56dd, 3); sub(edx, memd_a32[ss, ebp - 0x34]);     /* sub edx, [ebp-0x34] */
            ii(0x100e_56e0, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_56e3, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100e_56e5, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100e_56e9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_56eb, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_56ee, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_56f0, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_56f2, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x100e_56f4, 2); if(jled(0x100e_5709, 0x13)) goto l_0x100e_5709; /* jle 0x100e5709 */
            ii(0x100e_56f6, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100e_56fa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_56fc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_56ff, 5); calld(0x1007_5f6c, -0x6f798);           /* call 0x10075f6c */
            ii(0x100e_5704, 5); jmpd(0x100e_59f3, 0x2ea); goto l_0x100e_59f3; /* jmp 0x100e59f3 */
        l_0x100e_5709:
            ii(0x100e_5709, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_570c, 4); mov(memw_a32[ss, ebp - 0x22], ax);      /* mov [ebp-0x22], ax */
            ii(0x100e_5710, 2); jmpd(0x100e_5719, 0x7); goto l_0x100e_5719; /* jmp 0x100e5719 */
        l_0x100e_5712:
            ii(0x100e_5712, 3); mov(eax, memd_a32[ss, ebp - 0x22]);     /* mov eax, [ebp-0x22] */
            ii(0x100e_5715, 4); inc(memw_a32[ss, ebp - 0x22]);          /* inc word [ebp-0x22] */
        l_0x100e_5719:
            ii(0x100e_5719, 4); movsx(eax, memw_a32[ss, ebp - 0x22]);   /* movsx eax, word [ebp-0x22] */
            ii(0x100e_571d, 3); cmp(eax, memd_a32[ss, ebp - 0x28]);     /* cmp eax, [ebp-0x28] */
            ii(0x100e_5720, 6); if(jged(0x100e_59d9, 0x2b3)) goto l_0x100e_59d9; /* jge 0x100e59d9 */
            ii(0x100e_5726, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100e_5729, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
            ii(0x100e_572d, 2); jmpd(0x100e_5736, 0x7); goto l_0x100e_5736; /* jmp 0x100e5736 */
        l_0x100e_572f:
            ii(0x100e_572f, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_5732, 4); inc(memw_a32[ss, ebp - 0x24]);          /* inc word [ebp-0x24] */
        l_0x100e_5736:
            ii(0x100e_5736, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_573a, 3); cmp(eax, memd_a32[ss, ebp - 0x2c]);     /* cmp eax, [ebp-0x2c] */
            ii(0x100e_573d, 6); if(jged(0x100e_59d4, 0x291)) goto l_0x100e_59d4; /* jge 0x100e59d4 */
            ii(0x100e_5743, 4); movsx(ebx, memw_a32[ss, ebp - 0x22]);   /* movsx ebx, word [ebp-0x22] */
            ii(0x100e_5747, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100e_574b, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x100e_5750, 5); calld(0x1010_3541, 0x1ddec);            /* call 0x10103541 */
            ii(0x100e_5755, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_5757, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_575a, 5); calld(0x1007_643c, -0x6f323);           /* call 0x1007643c */
            ii(0x100e_575f, 2); jmpd(0x100e_5769, 0x8); goto l_0x100e_5769; /* jmp 0x100e5769 */
        l_0x100e_5761:
            ii(0x100e_5761, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_5764, 5); calld(0x1007_6bf8, -0x6eb71);           /* call 0x10076bf8 */
        l_0x100e_5769:
            ii(0x100e_5769, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_576b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_576e, 5); calld(0x1013_ad71, 0x555fe);            /* call 0x1013ad71 */
            ii(0x100e_5773, 2); test(al, al);                           /* test al, al */
            ii(0x100e_5775, 6); if(jzd(0x100e_59cf, 0x254)) goto l_0x100e_59cf; /* jz 0x100e59cf */
            ii(0x100e_577b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_577e, 5); calld(0x1007_63d4, -0x6f3af);           /* call 0x100763d4 */
            ii(0x100e_5783, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_5786, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_5789, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_578c, 5); calld(0x100e_5408, -0x389);             /* call 0x100e5408 */
            ii(0x100e_5791, 2); test(al, al);                           /* test al, al */
            ii(0x100e_5793, 6); if(jzd(0x100e_59ca, 0x231)) goto l_0x100e_59ca; /* jz 0x100e59ca */
            ii(0x100e_5799, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_579c, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x100e_57a0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_57a3, 6); test(memw_a32[ss, ebp - 0x10], 0x180);  /* test word [ebp-0x10], 0x180 */
            ii(0x100e_57a9, 2); if(jzd(0x100e_57be, 0x13)) goto l_0x100e_57be; /* jz 0x100e57be */
            ii(0x100e_57ab, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_57ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_57b1, 3); add(eax, 0x5c);                         /* add eax, 0x5c */
            ii(0x100e_57b4, 5); calld(0x100e_53a8, -0x411);             /* call 0x100e53a8 */
            ii(0x100e_57b9, 5); jmpd(0x100e_59ca, 0x20c); goto l_0x100e_59ca; /* jmp 0x100e59ca */
        l_0x100e_57be:
            ii(0x100e_57be, 6); test(memw_a32[ss, ebp - 0x10], 0x1);    /* test word [ebp-0x10], 0x1 */
            ii(0x100e_57c4, 6); if(jzd(0x100e_591d, 0x153)) goto l_0x100e_591d; /* jz 0x100e591d */
            ii(0x100e_57ca, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_57cd, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100e_57d1, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100e_57d4, 5); jmpd(0x100e_586a, 0x91); goto l_0x100e_586a; /* jmp 0x100e586a */
        l_0x100e_57d9:
            ii(0x100e_57d9, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_57dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_57df, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x100e_57e2, 5); calld(0x100e_53a8, -0x43f);             /* call 0x100e53a8 */
            ii(0x100e_57e7, 5); jmpd(0x100e_5918, 0x12c); goto l_0x100e_5918; /* jmp 0x100e5918 */
        l_0x100e_57ec:
            ii(0x100e_57ec, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_57ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_57f2, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100e_57f5, 5); calld(0x100e_53a8, -0x452);             /* call 0x100e53a8 */
            ii(0x100e_57fa, 5); jmpd(0x100e_5918, 0x119); goto l_0x100e_5918; /* jmp 0x100e5918 */
        l_0x100e_57ff:
            ii(0x100e_57ff, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_5802, 5); calld(0x1015_2b8c, 0x6d385);            /* call 0x10152b8c */
            ii(0x100e_5807, 2); test(al, al);                           /* test al, al */
            ii(0x100e_5809, 2); if(jzd(0x100e_581e, 0x13)) goto l_0x100e_581e; /* jz 0x100e581e */
            ii(0x100e_580b, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_580e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_5811, 3); add(eax, 0x66);                         /* add eax, 0x66 */
            ii(0x100e_5814, 5); calld(0x100e_53a8, -0x471);             /* call 0x100e53a8 */
            ii(0x100e_5819, 5); jmpd(0x100e_5918, 0xfa); goto l_0x100e_5918; /* jmp 0x100e5918 */
        l_0x100e_581e:
            ii(0x100e_581e, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_5821, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_5824, 3); add(eax, 0x34);                         /* add eax, 0x34 */
            ii(0x100e_5827, 5); calld(0x100e_53a8, -0x484);             /* call 0x100e53a8 */
            ii(0x100e_582c, 5); jmpd(0x100e_5918, 0xe7); goto l_0x100e_5918; /* jmp 0x100e5918 */
        l_0x100e_5831:
            ii(0x100e_5831, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_5834, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_5837, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100e_583a, 5); calld(0x100e_53a8, -0x497);             /* call 0x100e53a8 */
            ii(0x100e_583f, 5); jmpd(0x100e_5918, 0xd4); goto l_0x100e_5918; /* jmp 0x100e5918 */
        l_0x100e_5844:
            ii(0x100e_5844, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_5847, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_584a, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100e_584d, 5); calld(0x100e_53a8, -0x4aa);             /* call 0x100e53a8 */
            ii(0x100e_5852, 5); jmpd(0x100e_5918, 0xc1); goto l_0x100e_5918; /* jmp 0x100e5918 */
        l_0x100e_5857:
            ii(0x100e_5857, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_585a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_585d, 3); add(eax, 0x52);                         /* add eax, 0x52 */
            ii(0x100e_5860, 5); calld(0x100e_53a8, -0x4bd);             /* call 0x100e53a8 */
            ii(0x100e_5865, 5); jmpd(0x100e_5918, 0xae); goto l_0x100e_5918; /* jmp 0x100e5918 */
        l_0x100e_586a:
            ii(0x100e_586a, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100e_586d, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100e_5870, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x27);    /* cmp word [ebp-0x3c], 0x27 */
            ii(0x100e_5875, 2); if(jbd(0x100e_58c3, 0x4c)) goto l_0x100e_58c3; /* jb 0x100e58c3 */
            ii(0x100e_5877, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x27);    /* cmp word [ebp-0x3c], 0x27 */
            ii(0x100e_587c, 2); if(jbed(0x100e_57ff, -0x7f)) goto l_0x100e_57ff; /* jbe 0x100e57ff */
            ii(0x100e_587e, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x55);    /* cmp word [ebp-0x3c], 0x55 */
            ii(0x100e_5883, 2); if(jbd(0x100e_58b1, 0x2c)) goto l_0x100e_58b1; /* jb 0x100e58b1 */
            ii(0x100e_5885, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x55);    /* cmp word [ebp-0x3c], 0x55 */
            ii(0x100e_588a, 6); if(jbed(0x100e_57d9, -0xb7)) goto l_0x100e_57d9; /* jbe 0x100e57d9 */
            ii(0x100e_5890, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x5a);    /* cmp word [ebp-0x3c], 0x5a */
            ii(0x100e_5895, 2); if(jbd(0x100e_58af, 0x18)) goto l_0x100e_58af; /* jb 0x100e58af */
            ii(0x100e_5897, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x5a);    /* cmp word [ebp-0x3c], 0x5a */
            ii(0x100e_589c, 6); if(jbed(0x100e_57d9, -0xc9)) goto l_0x100e_57d9; /* jbe 0x100e57d9 */
            ii(0x100e_58a2, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x5c);    /* cmp word [ebp-0x3c], 0x5c */
            ii(0x100e_58a7, 6); if(jzd(0x100e_581e, -0x8f)) goto l_0x100e_581e; /* jz 0x100e581e */
            ii(0x100e_58ad, 2); jmpd(0x100e_5857, -0x58); goto l_0x100e_5857; /* jmp 0x100e5857 */
        l_0x100e_58af:
            ii(0x100e_58af, 2); jmpd(0x100e_5857, -0x5a); goto l_0x100e_5857; /* jmp 0x100e5857 */
        l_0x100e_58b1:
            ii(0x100e_58b1, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x29);    /* cmp word [ebp-0x3c], 0x29 */
            ii(0x100e_58b6, 2); if(jbd(0x100e_58c1, 0x9)) goto l_0x100e_58c1; /* jb 0x100e58c1 */
            ii(0x100e_58b8, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x2a);    /* cmp word [ebp-0x3c], 0x2a */
            ii(0x100e_58bd, 2); if(jbed(0x100e_5844, -0x7b)) goto l_0x100e_5844; /* jbe 0x100e5844 */
            ii(0x100e_58bf, 2); jmpd(0x100e_5857, -0x6a); goto l_0x100e_5857; /* jmp 0x100e5857 */
        l_0x100e_58c1:
            ii(0x100e_58c1, 2); jmpd(0x100e_5857, -0x6c); goto l_0x100e_5857; /* jmp 0x100e5857 */
        l_0x100e_58c3:
            ii(0x100e_58c3, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x11);    /* cmp word [ebp-0x3c], 0x11 */
            ii(0x100e_58c8, 2); if(jbd(0x100e_58fc, 0x32)) goto l_0x100e_58fc; /* jb 0x100e58fc */
            ii(0x100e_58ca, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x12);    /* cmp word [ebp-0x3c], 0x12 */
            ii(0x100e_58cf, 6); if(jbed(0x100e_581e, -0xb7)) goto l_0x100e_581e; /* jbe 0x100e581e */
            ii(0x100e_58d5, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x15);    /* cmp word [ebp-0x3c], 0x15 */
            ii(0x100e_58da, 2); if(jbd(0x100e_58f7, 0x1b)) goto l_0x100e_58f7; /* jb 0x100e58f7 */
            ii(0x100e_58dc, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x15);    /* cmp word [ebp-0x3c], 0x15 */
            ii(0x100e_58e1, 6); if(jbed(0x100e_581e, -0xc9)) goto l_0x100e_581e; /* jbe 0x100e581e */
            ii(0x100e_58e7, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x21);    /* cmp word [ebp-0x3c], 0x21 */
            ii(0x100e_58ec, 6); if(jzd(0x100e_57ec, -0x106)) goto l_0x100e_57ec; /* jz 0x100e57ec */
            ii(0x100e_58f2, 5); jmpd(0x100e_5857, -0xa0); goto l_0x100e_5857; /* jmp 0x100e5857 */
        l_0x100e_58f7:
            ii(0x100e_58f7, 5); jmpd(0x100e_5857, -0xa5); goto l_0x100e_5857; /* jmp 0x100e5857 */
        l_0x100e_58fc:
            ii(0x100e_58fc, 5); cmp(memw_a32[ss, ebp - 0x3c], 0xd);     /* cmp word [ebp-0x3c], 0xd */
            ii(0x100e_5901, 2); if(jbd(0x100e_5913, 0x10)) goto l_0x100e_5913; /* jb 0x100e5913 */
            ii(0x100e_5903, 5); cmp(memw_a32[ss, ebp - 0x3c], 0xe);     /* cmp word [ebp-0x3c], 0xe */
            ii(0x100e_5908, 6); if(jbed(0x100e_5831, -0xdd)) goto l_0x100e_5831; /* jbe 0x100e5831 */
            ii(0x100e_590e, 5); jmpd(0x100e_5857, -0xbc); goto l_0x100e_5857; /* jmp 0x100e5857 */
        l_0x100e_5913:
            ii(0x100e_5913, 5); jmpd(0x100e_5857, -0xc1); goto l_0x100e_5857; /* jmp 0x100e5857 */
        l_0x100e_5918:
            ii(0x100e_5918, 5); jmpd(0x100e_59ca, 0xad); goto l_0x100e_59ca; /* jmp 0x100e59ca */
        l_0x100e_591d:
            ii(0x100e_591d, 6); test(memw_a32[ss, ebp - 0x10], 0x200);  /* test word [ebp-0x10], 0x200 */
            ii(0x100e_5923, 2); if(jzd(0x100e_5952, 0x2d)) goto l_0x100e_5952; /* jz 0x100e5952 */
            ii(0x100e_5925, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_5928, 5); cmp(memw_a32[ds, eax + 0x8], 0x16);     /* cmp word [eax+0x8], 0x16 */
            ii(0x100e_592d, 2); if(jnzd(0x100e_593f, 0x10)) goto l_0x100e_593f; /* jnz 0x100e593f */
            ii(0x100e_592f, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_5932, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_5935, 3); add(eax, 0x52);                         /* add eax, 0x52 */
            ii(0x100e_5938, 5); calld(0x100e_53a8, -0x595);             /* call 0x100e53a8 */
            ii(0x100e_593d, 2); jmpd(0x100e_594d, 0xe); goto l_0x100e_594d; /* jmp 0x100e594d */
        l_0x100e_593f:
            ii(0x100e_593f, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_5942, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_5945, 3); add(eax, 0x66);                         /* add eax, 0x66 */
            ii(0x100e_5948, 5); calld(0x100e_53a8, -0x5a5);             /* call 0x100e53a8 */
        l_0x100e_594d:
            ii(0x100e_594d, 5); jmpd(0x100e_59ca, 0x78); goto l_0x100e_59ca; /* jmp 0x100e59ca */
        l_0x100e_5952:
            ii(0x100e_5952, 6); test(memw_a32[ss, ebp - 0x10], 0x20);   /* test word [ebp-0x10], 0x20 */
            ii(0x100e_5958, 2); if(jzd(0x100e_5990, 0x36)) goto l_0x100e_5990; /* jz 0x100e5990 */
            ii(0x100e_595a, 6); test(memw_a32[ss, ebp - 0x10], 0x2);    /* test word [ebp-0x10], 0x2 */
            ii(0x100e_5960, 2); if(jzd(0x100e_596c, 0xa)) goto l_0x100e_596c; /* jz 0x100e596c */
            ii(0x100e_5962, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_5965, 5); cmp(memw_a32[ds, eax + 0x8], 0x59);     /* cmp word [eax+0x8], 0x59 */
            ii(0x100e_596a, 2); if(jnzd(0x100e_597e, 0x12)) goto l_0x100e_597e; /* jnz 0x100e597e */
        l_0x100e_596c:
            ii(0x100e_596c, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_596f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_5972, 5); add(eax, 0x8e);                         /* add eax, 0x8e */
            ii(0x100e_5977, 5); calld(0x100e_53a8, -0x5d4);             /* call 0x100e53a8 */
            ii(0x100e_597c, 2); jmpd(0x100e_598e, 0x10); goto l_0x100e_598e; /* jmp 0x100e598e */
        l_0x100e_597e:
            ii(0x100e_597e, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_5981, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_5984, 5); add(eax, 0x84);                         /* add eax, 0x84 */
            ii(0x100e_5989, 5); calld(0x100e_53a8, -0x5e6);             /* call 0x100e53a8 */
        l_0x100e_598e:
            ii(0x100e_598e, 2); jmpd(0x100e_59ca, 0x3a); goto l_0x100e_59ca; /* jmp 0x100e59ca */
        l_0x100e_5990:
            ii(0x100e_5990, 6); test(memw_a32[ss, ebp - 0x10], 0x40);   /* test word [ebp-0x10], 0x40 */
            ii(0x100e_5996, 2); if(jzd(0x100e_59ca, 0x32)) goto l_0x100e_59ca; /* jz 0x100e59ca */
            ii(0x100e_5998, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100e_599c, 5); test(eax, 0x1_0000);                    /* test eax, 0x10000 */
            ii(0x100e_59a1, 2); if(jnzd(0x100e_59ac, 0x9)) goto l_0x100e_59ac; /* jnz 0x100e59ac */
            ii(0x100e_59a3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_59a6, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100e_59aa, 2); if(jnzd(0x100e_59bc, 0x10)) goto l_0x100e_59bc; /* jnz 0x100e59bc */
        l_0x100e_59ac:
            ii(0x100e_59ac, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_59af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_59b2, 3); add(eax, 0x7a);                         /* add eax, 0x7a */
            ii(0x100e_59b5, 5); calld(0x100e_53a8, -0x612);             /* call 0x100e53a8 */
            ii(0x100e_59ba, 2); jmpd(0x100e_59ca, 0xe); goto l_0x100e_59ca; /* jmp 0x100e59ca */
        l_0x100e_59bc:
            ii(0x100e_59bc, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_59bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_59c2, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x100e_59c5, 5); calld(0x100e_53a8, -0x622);             /* call 0x100e53a8 */
        l_0x100e_59ca:
            ii(0x100e_59ca, 5); jmpd(0x100e_5761, -0x26e); goto l_0x100e_5761; /* jmp 0x100e5761 */
        l_0x100e_59cf:
            ii(0x100e_59cf, 5); jmpd(0x100e_572f, -0x2a5); goto l_0x100e_572f; /* jmp 0x100e572f */
        l_0x100e_59d4:
            ii(0x100e_59d4, 5); jmpd(0x100e_5712, -0x2c7); goto l_0x100e_5712; /* jmp 0x100e5712 */
        l_0x100e_59d9:
            ii(0x100e_59d9, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100e_59dd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_59df, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_59e2, 5); calld(0x1007_5f6c, -0x6fa7b);           /* call 0x10075f6c */
            ii(0x100e_59e7, 2); jmpd(0x100e_59f3, 0xa); goto l_0x100e_59f3; /* jmp 0x100e59f3 */
        //  ii(0x100e_59e9, 10); Недостижимый код.
        l_0x100e_59f3:
            ii(0x100e_59f3, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100e_59f6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_59f8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_59f9, 1); popd(edi);                              /* pop edi */
            ii(0x100e_59fa, 1); popd(esi);                              /* pop esi */
            ii(0x100e_59fb, 1); popd(edx);                              /* pop edx */
            ii(0x100e_59fc, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_59fd, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_59fe, 1); retd(); return;                         /* ret */
        }
    }
}
