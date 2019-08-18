using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f2797663-3711-4a1d-82b3-b88635718f8a")]
        public void Method_1007_02b9()
        {
            ii(0x1007_02b9, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1007_02be, 5); calld(Definitions.sys_check_available_stack_size, 0xf_5a8f); /* call 0x10165d52 */
            ii(0x1007_02c3, 1); pushd(esi);                             /* push esi */
            ii(0x1007_02c4, 1); pushd(edi);                             /* push edi */
            ii(0x1007_02c5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_02c6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_02c8, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1007_02ce, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_02d1, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1007_02d4, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1007_02d7, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1007_02da, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1007_02de, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1007_02e1, 7); mov(ax, memw_a32[ds, eax + 0x101c_81c0]); /* mov ax, [eax+0x101c81c0] */
            ii(0x1007_02e8, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_02eb, 4); or(memb_a32[ss, ebp - 0x1c], 0x1);      /* or byte [ebp-0x1c], 0x1 */
            ii(0x1007_02ef, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_02f2, 5); calld(0x1007_64fc, 0x6205);             /* call 0x100764fc */
            ii(0x1007_02f7, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1007_02fa, 4); and(memb_a32[ss, ebp - 0x1c], -0x2 /* 0xfe */); /* and byte [ebp-0x1c], 0xfe */
            ii(0x1007_02fe, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_0302, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_0306, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_0308, 2); if(jld(0x1007_0316, 0xc)) goto l_0x1007_0316; /* jl 0x10070316 */
            ii(0x1007_030a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_030d, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_0314, 2); if(jld(0x1007_0318, 0x2)) goto l_0x1007_0318; /* jl 0x10070318 */
        l_0x1007_0316:
            ii(0x1007_0316, 2); jmpd(0x1007_0320, 0x8); goto l_0x1007_0320; /* jmp 0x10070320 */
        l_0x1007_0318:
            ii(0x1007_0318, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_031c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_031e, 2); if(jged(0x1007_0322, 0x2)) goto l_0x1007_0322; /* jge 0x10070322 */
        l_0x1007_0320:
            ii(0x1007_0320, 2); jmpd(0x1007_032e, 0xc); goto l_0x1007_032e; /* jmp 0x1007032e */
        l_0x1007_0322:
            ii(0x1007_0322, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_0325, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_032c, 2); if(jld(0x1007_0344, 0x16)) goto l_0x1007_0344; /* jl 0x10070344 */
        l_0x1007_032e:
            ii(0x1007_032e, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_0335, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0337, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_033a, 5); calld(0x1007_5f6c, 0x5c2d);             /* call 0x10075f6c */
            ii(0x1007_033f, 5); jmpd(0x1007_07e2, 0x49e); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        l_0x1007_0344:
            ii(0x1007_0344, 7); mov(memd_a32[ss, ebp - 0x2c], 0x4);     /* mov dword [ebp-0x2c], 0x4 */
            ii(0x1007_034b, 4); test(memb_a32[ss, ebp + 0x10], 0x20);   /* test byte [ebp+0x10], 0x20 */
            ii(0x1007_034f, 2); if(jzd(0x1007_0366, 0x15)) goto l_0x1007_0366; /* jz 0x10070366 */
            ii(0x1007_0351, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1007_0354, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1007_0357, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0359, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_035c, 5); calld(0x1007_5f6c, 0x5c0b);             /* call 0x10075f6c */
            ii(0x1007_0361, 5); jmpd(0x1007_07e2, 0x47c); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        l_0x1007_0366:
            ii(0x1007_0366, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_036a, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_036e, 5); calld(0x1007_3d48, 0x39d5);             /* call 0x10073d48 */
            ii(0x1007_0373, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1007_0376, 6); test(memw_a32[ss, ebp - 0x30], 0x2);    /* test word [ebp-0x30], 0x2 */
            ii(0x1007_037c, 2); if(jzd(0x1007_0386, 0x8)) goto l_0x1007_0386; /* jz 0x10070386 */
            ii(0x1007_037e, 6); test(memw_a32[ss, ebp - 0x18], 0x100);  /* test word [ebp-0x18], 0x100 */
            ii(0x1007_0384, 2); if(jnzd(0x1007_0388, 0x2)) goto l_0x1007_0388; /* jnz 0x10070388 */
        l_0x1007_0386:
            ii(0x1007_0386, 2); jmpd(0x1007_038f, 0x7); goto l_0x1007_038f; /* jmp 0x1007038f */
        l_0x1007_0388:
            ii(0x1007_0388, 5); cmp(memw_a32[ss, ebp - 0xc], 0x39);     /* cmp word [ebp-0xc], 0x39 */
            ii(0x1007_038d, 2); if(jnzd(0x1007_0391, 0x2)) goto l_0x1007_0391; /* jnz 0x10070391 */
        l_0x1007_038f:
            ii(0x1007_038f, 2); jmpd(0x1007_0398, 0x7); goto l_0x1007_0398; /* jmp 0x10070398 */
        l_0x1007_0391:
            ii(0x1007_0391, 7); mov(memd_a32[ss, ebp - 0x2c], 0xc);     /* mov dword [ebp-0x2c], 0xc */
        l_0x1007_0398:
            ii(0x1007_0398, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1007_039c, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_03a0, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_03a5, 5); calld(0x1010_3541, 0x9_3197);           /* call 0x10103541 */
            ii(0x1007_03aa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_03ac, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_03af, 5); calld(0x1007_643c, 0x6088);             /* call 0x1007643c */
            ii(0x1007_03b4, 2); jmpd(0x1007_03be, 0x8); goto l_0x1007_03be; /* jmp 0x100703be */
        l_0x1007_03b6:
            ii(0x1007_03b6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_03b9, 5); calld(0x1007_6bf8, 0x683a);             /* call 0x10076bf8 */
        l_0x1007_03be:
            ii(0x1007_03be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_03c0, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_03c3, 5); calld(0x1013_ad71, 0xc_a9a9);           /* call 0x1013ad71 */
            ii(0x1007_03c8, 2); test(al, al);                           /* test al, al */
            ii(0x1007_03ca, 6); if(jzd(0x1007_078d, 0x3bd)) goto l_0x1007_078d; /* jz 0x1007078d */
            ii(0x1007_03d0, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1007_03d4, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_03d7, 5); calld(0x1007_63a0, 0x5fc4);             /* call 0x100763a0 */
            ii(0x1007_03dc, 5); calld(0x1007_6074, 0x5c93);             /* call 0x10076074 */
            ii(0x1007_03e1, 2); test(al, al);                           /* test al, al */
            ii(0x1007_03e3, 2); if(jnzd(0x1007_03eb, 0x6)) goto l_0x1007_03eb; /* jnz 0x100703eb */
            ii(0x1007_03e5, 4); test(memb_a32[ss, ebp + 0x10], 0x10);   /* test byte [ebp+0x10], 0x10 */
            ii(0x1007_03e9, 2); if(jzd(0x1007_03ed, 0x2)) goto l_0x1007_03ed; /* jz 0x100703ed */
        l_0x1007_03eb:
            ii(0x1007_03eb, 2); jmpd(0x1007_0412, 0x25); goto l_0x1007_0412; /* jmp 0x10070412 */
        l_0x1007_03ed:
            ii(0x1007_03ed, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1007_03f1, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_03f4, 5); calld(0x1007_63a0, 0x5fa7);             /* call 0x100763a0 */
            ii(0x1007_03f9, 5); calld(0x1007_6274, 0x5e76);             /* call 0x10076274 */
            ii(0x1007_03fe, 2); test(al, al);                           /* test al, al */
            ii(0x1007_0400, 2); if(jzd(0x1007_0410, 0xe)) goto l_0x1007_0410; /* jz 0x10070410 */
            ii(0x1007_0402, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0405, 5); calld(0x1007_63a0, 0x5f96);             /* call 0x100763a0 */
            ii(0x1007_040a, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1007_040e, 2); if(jnzd(0x1007_0412, 0x2)) goto l_0x1007_0412; /* jnz 0x10070412 */
        l_0x1007_0410:
            ii(0x1007_0410, 2); jmpd(0x1007_0430, 0x1e); goto l_0x1007_0430; /* jmp 0x10070430 */
        l_0x1007_0412:
            ii(0x1007_0412, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0415, 5); calld(0x1007_63a0, 0x5f86);             /* call 0x100763a0 */
            ii(0x1007_041a, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_041e, 2); if(jnzd(0x1007_042e, 0xe)) goto l_0x1007_042e; /* jnz 0x1007042e */
            ii(0x1007_0420, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0423, 5); calld(0x1007_63a0, 0x5f78);             /* call 0x100763a0 */
            ii(0x1007_0428, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1007_042c, 2); if(jzd(0x1007_0430, 0x2)) goto l_0x1007_0430; /* jz 0x10070430 */
        l_0x1007_042e:
            ii(0x1007_042e, 2); jmpd(0x1007_0435, 0x5); goto l_0x1007_0435; /* jmp 0x10070435 */
        l_0x1007_0430:
            ii(0x1007_0430, 5); jmpd(0x1007_0788, 0x353); goto l_0x1007_0788; /* jmp 0x10070788 */
        l_0x1007_0435:
            ii(0x1007_0435, 6); test(memw_a32[ss, ebp - 0x18], 0x40);   /* test word [ebp-0x18], 0x40 */
            ii(0x1007_043b, 2); if(jzd(0x1007_0489, 0x4c)) goto l_0x1007_0489; /* jz 0x10070489 */
            ii(0x1007_043d, 4); test(memb_a32[ss, ebp + 0x10], 0x2);    /* test byte [ebp+0x10], 0x2 */
            ii(0x1007_0441, 2); if(jnzd(0x1007_0460, 0x1d)) goto l_0x1007_0460; /* jnz 0x10070460 */
            ii(0x1007_0443, 4); test(memb_a32[ss, ebp + 0x10], 0x1);    /* test byte [ebp+0x10], 0x1 */
            ii(0x1007_0447, 2); if(jzd(0x1007_045e, 0x15)) goto l_0x1007_045e; /* jz 0x1007045e */
            ii(0x1007_0449, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_044c, 5); calld(0x1007_63a0, 0x5f4f);             /* call 0x100763a0 */
            ii(0x1007_0451, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0453, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_0456, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1007_045a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_045c, 2); if(jnzd(0x1007_0460, 0x2)) goto l_0x1007_0460; /* jnz 0x10070460 */
        l_0x1007_045e:
            ii(0x1007_045e, 2); jmpd(0x1007_0484, 0x24); goto l_0x1007_0484; /* jmp 0x10070484 */
        l_0x1007_0460:
            ii(0x1007_0460, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0463, 5); calld(0x1007_63a0, 0x5f38);             /* call 0x100763a0 */
            ii(0x1007_0468, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1007_046c, 2); if(jzd(0x1007_0484, 0x16)) goto l_0x1007_0484; /* jz 0x10070484 */
            ii(0x1007_046e, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_0475, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0477, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_047a, 5); calld(0x1007_5f6c, 0x5aed);             /* call 0x10075f6c */
            ii(0x1007_047f, 5); jmpd(0x1007_07e2, 0x35e); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        l_0x1007_0484:
            ii(0x1007_0484, 5); jmpd(0x1007_0788, 0x2ff); goto l_0x1007_0788; /* jmp 0x10070788 */
        l_0x1007_0489:
            ii(0x1007_0489, 4); test(memb_a32[ss, ebp + 0x10], 0x2);    /* test byte [ebp+0x10], 0x2 */
            ii(0x1007_048d, 2); if(jnzd(0x1007_04ac, 0x1d)) goto l_0x1007_04ac; /* jnz 0x100704ac */
            ii(0x1007_048f, 4); test(memb_a32[ss, ebp + 0x10], 0x1);    /* test byte [ebp+0x10], 0x1 */
            ii(0x1007_0493, 2); if(jzd(0x1007_04aa, 0x15)) goto l_0x1007_04aa; /* jz 0x100704aa */
            ii(0x1007_0495, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0498, 5); calld(0x1007_63a0, 0x5f03);             /* call 0x100763a0 */
            ii(0x1007_049d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_049f, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_04a2, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1007_04a6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_04a8, 2); if(jnzd(0x1007_04ac, 0x2)) goto l_0x1007_04ac; /* jnz 0x100704ac */
        l_0x1007_04aa:
            ii(0x1007_04aa, 2); jmpd(0x1007_04d2, 0x26); goto l_0x1007_04d2; /* jmp 0x100704d2 */
        l_0x1007_04ac:
            ii(0x1007_04ac, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_04af, 5); calld(0x1007_63a0, 0x5eec);             /* call 0x100763a0 */
            ii(0x1007_04b4, 6); test(memw_a32[ds, eax + 0x12], 0x180);  /* test word [eax+0x12], 0x180 */
            ii(0x1007_04ba, 2); if(jzd(0x1007_04d2, 0x16)) goto l_0x1007_04d2; /* jz 0x100704d2 */
            ii(0x1007_04bc, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_04c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_04c5, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_04c8, 5); calld(0x1007_5f6c, 0x5a9f);             /* call 0x10075f6c */
            ii(0x1007_04cd, 5); jmpd(0x1007_07e2, 0x310); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        l_0x1007_04d2:
            ii(0x1007_04d2, 6); test(memw_a32[ss, ebp - 0x18], 0x200);  /* test word [ebp-0x18], 0x200 */
            ii(0x1007_04d8, 2); if(jzd(0x1007_04e1, 0x7)) goto l_0x1007_04e1; /* jz 0x100704e1 */
            ii(0x1007_04da, 5); cmp(memw_a32[ss, ebp - 0xc], 0xc);      /* cmp word [ebp-0xc], 0xc */
            ii(0x1007_04df, 2); if(jnzd(0x1007_04e6, 0x5)) goto l_0x1007_04e6; /* jnz 0x100704e6 */
        l_0x1007_04e1:
            ii(0x1007_04e1, 5); jmpd(0x1007_054d, 0x67); goto l_0x1007_054d; /* jmp 0x1007054d */
        l_0x1007_04e6:
            ii(0x1007_04e6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_04e9, 5); calld(0x1007_63a0, 0x5eb2);             /* call 0x100763a0 */
            ii(0x1007_04ee, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1007_04f3, 2); if(jzd(0x1007_0515, 0x20)) goto l_0x1007_0515; /* jz 0x10070515 */
            ii(0x1007_04f5, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_04f8, 5); calld(0x1007_63a0, 0x5ea3);             /* call 0x100763a0 */
            ii(0x1007_04fd, 5); cmp(memw_a32[ds, eax + 0x8], 0xd);      /* cmp word [eax+0x8], 0xd */
            ii(0x1007_0502, 2); if(jld(0x1007_0513, 0xf)) goto l_0x1007_0513; /* jl 0x10070513 */
            ii(0x1007_0504, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0507, 5); calld(0x1007_63a0, 0x5e94);             /* call 0x100763a0 */
            ii(0x1007_050c, 5); cmp(memw_a32[ds, eax + 0x8], 0x14);     /* cmp word [eax+0x8], 0x14 */
            ii(0x1007_0511, 2); if(jled(0x1007_0515, 0x2)) goto l_0x1007_0515; /* jle 0x10070515 */
        l_0x1007_0513:
            ii(0x1007_0513, 2); jmpd(0x1007_0517, 0x2); goto l_0x1007_0517; /* jmp 0x10070517 */
        l_0x1007_0515:
            ii(0x1007_0515, 2); jmpd(0x1007_0526, 0xf); goto l_0x1007_0526; /* jmp 0x10070526 */
        l_0x1007_0517:
            ii(0x1007_0517, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_051a, 5); calld(0x1007_63a0, 0x5e81);             /* call 0x100763a0 */
            ii(0x1007_051f, 5); cmp(memw_a32[ds, eax + 0x8], 0x29);     /* cmp word [eax+0x8], 0x29 */
            ii(0x1007_0524, 2); if(jnzd(0x1007_0528, 0x2)) goto l_0x1007_0528; /* jnz 0x10070528 */
        l_0x1007_0526:
            ii(0x1007_0526, 2); jmpd(0x1007_0537, 0xf); goto l_0x1007_0537; /* jmp 0x10070537 */
        l_0x1007_0528:
            ii(0x1007_0528, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_052b, 5); calld(0x1007_63a0, 0x5e70);             /* call 0x100763a0 */
            ii(0x1007_0530, 5); cmp(memw_a32[ds, eax + 0x8], 0x2a);     /* cmp word [eax+0x8], 0x2a */
            ii(0x1007_0535, 2); if(jnzd(0x1007_054d, 0x16)) goto l_0x1007_054d; /* jnz 0x1007054d */
        l_0x1007_0537:
            ii(0x1007_0537, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_053e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0540, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0543, 5); calld(0x1007_5f6c, 0x5a24);             /* call 0x10075f6c */
            ii(0x1007_0548, 5); jmpd(0x1007_07e2, 0x295); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        l_0x1007_054d:
            ii(0x1007_054d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0550, 5); calld(0x1007_63a0, 0x5e4b);             /* call 0x100763a0 */
            ii(0x1007_0555, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1007_0559, 6); if(jzd(0x1007_0788, 0x229)) goto l_0x1007_0788; /* jz 0x10070788 */
            ii(0x1007_055f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0562, 5); calld(0x1007_63a0, 0x5e39);             /* call 0x100763a0 */
            ii(0x1007_0567, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1007_056b, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1007_056e, 5); jmpd(0x1007_06fa, 0x187); goto l_0x1007_06fa; /* jmp 0x100706fa */
        l_0x1007_0573:
            ii(0x1007_0573, 7); mov(memd_a32[ss, ebp - 0x30], 0x1);     /* mov dword [ebp-0x30], 0x1 */
            ii(0x1007_057a, 5); jmpd(0x1007_0788, 0x209); goto l_0x1007_0788; /* jmp 0x10070788 */
        l_0x1007_057f:
            ii(0x1007_057f, 7); mov(memd_a32[ss, ebp - 0x2c], 0x4);     /* mov dword [ebp-0x2c], 0x4 */
            ii(0x1007_0586, 6); test(memw_a32[ss, ebp - 0x18], 0x100);  /* test word [ebp-0x18], 0x100 */
            ii(0x1007_058c, 2); if(jzd(0x1007_05be, 0x30)) goto l_0x1007_05be; /* jz 0x100705be */
            ii(0x1007_058e, 7); mov(memd_a32[ss, ebp - 0x2c], 0x2);     /* mov dword [ebp-0x2c], 0x2 */
            ii(0x1007_0595, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0598, 5); calld(0x1007_63a0, 0x5e03);             /* call 0x100763a0 */
            ii(0x1007_059d, 5); calld(0x1015_2b8c, 0xe_25ea);           /* call 0x10152b8c */
            ii(0x1007_05a2, 2); test(al, al);                           /* test al, al */
            ii(0x1007_05a4, 2); if(jzd(0x1007_05ac, 0x6)) goto l_0x1007_05ac; /* jz 0x100705ac */
            ii(0x1007_05a6, 4); test(memb_a32[ss, ebp + 0x10], 0x8);    /* test byte [ebp+0x10], 0x8 */
            ii(0x1007_05aa, 2); if(jnzd(0x1007_05b5, 0x9)) goto l_0x1007_05b5; /* jnz 0x100705b5 */
        l_0x1007_05ac:
            ii(0x1007_05ac, 7); mov(memd_a32[ss, ebp - 0x30], 0x1);     /* mov dword [ebp-0x30], 0x1 */
            ii(0x1007_05b3, 2); jmpd(0x1007_05bc, 0x7); goto l_0x1007_05bc; /* jmp 0x100705bc */
        l_0x1007_05b5:
            ii(0x1007_05b5, 7); mov(memd_a32[ss, ebp - 0x30], 0x2);     /* mov dword [ebp-0x30], 0x2 */
        l_0x1007_05bc:
            ii(0x1007_05bc, 2); jmpd(0x1007_05e5, 0x27); goto l_0x1007_05e5; /* jmp 0x100705e5 */
        l_0x1007_05be:
            ii(0x1007_05be, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_05c1, 5); calld(0x1007_63a0, 0x5dda);             /* call 0x100763a0 */
            ii(0x1007_05c6, 5); calld(0x1015_2b8c, 0xe_25c1);           /* call 0x10152b8c */
            ii(0x1007_05cb, 2); test(al, al);                           /* test al, al */
            ii(0x1007_05cd, 2); if(jnzd(0x1007_05d5, 0x6)) goto l_0x1007_05d5; /* jnz 0x100705d5 */
            ii(0x1007_05cf, 4); test(memb_a32[ss, ebp + 0x10], 0x8);    /* test byte [ebp+0x10], 0x8 */
            ii(0x1007_05d3, 2); if(jnzd(0x1007_05de, 0x9)) goto l_0x1007_05de; /* jnz 0x100705de */
        l_0x1007_05d5:
            ii(0x1007_05d5, 7); mov(memd_a32[ss, ebp - 0x30], 0x2);     /* mov dword [ebp-0x30], 0x2 */
            ii(0x1007_05dc, 2); jmpd(0x1007_05e5, 0x7); goto l_0x1007_05e5; /* jmp 0x100705e5 */
        l_0x1007_05de:
            ii(0x1007_05de, 7); mov(memd_a32[ss, ebp - 0x30], 0x1);     /* mov dword [ebp-0x30], 0x1 */
        l_0x1007_05e5:
            ii(0x1007_05e5, 5); jmpd(0x1007_0788, 0x19e); goto l_0x1007_0788; /* jmp 0x10070788 */
        l_0x1007_05ea:
            ii(0x1007_05ea, 7); mov(memd_a32[ss, ebp - 0x30], 0x1);     /* mov dword [ebp-0x30], 0x1 */
            ii(0x1007_05f1, 7); mov(memd_a32[ss, ebp - 0x2c], 0x4);     /* mov dword [ebp-0x2c], 0x4 */
            ii(0x1007_05f8, 5); jmpd(0x1007_0788, 0x18b); goto l_0x1007_0788; /* jmp 0x10070788 */
        l_0x1007_05fd:
            ii(0x1007_05fd, 5); cmp(memw_a32[ss, ebp - 0xc], 0xc);      /* cmp word [ebp-0xc], 0xc */
            ii(0x1007_0602, 2); if(jnzd(0x1007_061a, 0x16)) goto l_0x1007_061a; /* jnz 0x1007061a */
            ii(0x1007_0604, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_060b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_060d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0610, 5); calld(0x1007_5f6c, 0x5957);             /* call 0x10075f6c */
            ii(0x1007_0615, 5); jmpd(0x1007_07e2, 0x1c8); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        l_0x1007_061a:
            ii(0x1007_061a, 6); test(memw_a32[ss, ebp - 0x18], 0x200);  /* test word [ebp-0x18], 0x200 */
            ii(0x1007_0620, 2); if(jzd(0x1007_0637, 0x15)) goto l_0x1007_0637; /* jz 0x10070637 */
            ii(0x1007_0622, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0625, 5); calld(0x1007_63a0, 0x5d76);             /* call 0x100763a0 */
            ii(0x1007_062a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_062c, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_062f, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1007_0633, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_0635, 2); if(jnzd(0x1007_0639, 0x2)) goto l_0x1007_0639; /* jnz 0x10070639 */
        l_0x1007_0637:
            ii(0x1007_0637, 2); jmpd(0x1007_0640, 0x7); goto l_0x1007_0640; /* jmp 0x10070640 */
        l_0x1007_0639:
            ii(0x1007_0639, 5); cmp(memw_a32[ss, ebp - 0xc], 0x21);     /* cmp word [ebp-0xc], 0x21 */
            ii(0x1007_063e, 2); if(jnzd(0x1007_0642, 0x2)) goto l_0x1007_0642; /* jnz 0x10070642 */
        l_0x1007_0640:
            ii(0x1007_0640, 2); jmpd(0x1007_0649, 0x7); goto l_0x1007_0649; /* jmp 0x10070649 */
        l_0x1007_0642:
            ii(0x1007_0642, 5); cmp(memw_a32[ss, ebp - 0xc], 0x27);     /* cmp word [ebp-0xc], 0x27 */
            ii(0x1007_0647, 2); if(jnzd(0x1007_064b, 0x2)) goto l_0x1007_064b; /* jnz 0x1007064b */
        l_0x1007_0649:
            ii(0x1007_0649, 2); jmpd(0x1007_0652, 0x7); goto l_0x1007_0652; /* jmp 0x10070652 */
        l_0x1007_064b:
            ii(0x1007_064b, 5); cmp(memw_a32[ss, ebp - 0xc], 0x15);     /* cmp word [ebp-0xc], 0x15 */
            ii(0x1007_0650, 2); if(jnzd(0x1007_0654, 0x2)) goto l_0x1007_0654; /* jnz 0x10070654 */
        l_0x1007_0652:
            ii(0x1007_0652, 2); jmpd(0x1007_066a, 0x16); goto l_0x1007_066a; /* jmp 0x1007066a */
        l_0x1007_0654:
            ii(0x1007_0654, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_065b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_065d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0660, 5); calld(0x1007_5f6c, 0x5907);             /* call 0x10075f6c */
            ii(0x1007_0665, 5); jmpd(0x1007_07e2, 0x178); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        l_0x1007_066a:
            ii(0x1007_066a, 5); jmpd(0x1007_0788, 0x119); goto l_0x1007_0788; /* jmp 0x10070788 */
        l_0x1007_066f:
            ii(0x1007_066f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_0672, 5); calld(0x1007_63a0, 0x5d29);             /* call 0x100763a0 */
            ii(0x1007_0677, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0679, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_067c, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1007_0680, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_0682, 2); if(jzd(0x1007_0699, 0x15)) goto l_0x1007_0699; /* jz 0x10070699 */
            ii(0x1007_0684, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1007_0688, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_068b, 5); calld(0x1007_63a0, 0x5d10);             /* call 0x100763a0 */
            ii(0x1007_0690, 5); calld(0x1007_6274, 0x5bdf);             /* call 0x10076274 */
            ii(0x1007_0695, 2); test(al, al);                           /* test al, al */
            ii(0x1007_0697, 2); if(jnzd(0x1007_069b, 0x2)) goto l_0x1007_069b; /* jnz 0x1007069b */
        l_0x1007_0699:
            ii(0x1007_0699, 2); jmpd(0x1007_06b1, 0x16); goto l_0x1007_06b1; /* jmp 0x100706b1 */
        l_0x1007_069b:
            ii(0x1007_069b, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_06a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_06a4, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_06a7, 5); calld(0x1007_5f6c, 0x58c0);             /* call 0x10075f6c */
            ii(0x1007_06ac, 5); jmpd(0x1007_07e2, 0x131); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        l_0x1007_06b1:
            ii(0x1007_06b1, 5); jmpd(0x1007_0788, 0xd2); goto l_0x1007_0788; /* jmp 0x10070788 */
        l_0x1007_06b6:
            ii(0x1007_06b6, 5); cmp(memw_a32[ss, ebp - 0xc], 0x15);     /* cmp word [ebp-0xc], 0x15 */
            ii(0x1007_06bb, 2); if(jnzd(0x1007_06d3, 0x16)) goto l_0x1007_06d3; /* jnz 0x100706d3 */
            ii(0x1007_06bd, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_06c4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_06c6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_06c9, 5); calld(0x1007_5f6c, 0x589e);             /* call 0x10075f6c */
            ii(0x1007_06ce, 5); jmpd(0x1007_07e2, 0x10f); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        l_0x1007_06d3:
            ii(0x1007_06d3, 7); mov(memd_a32[ss, ebp - 0x2c], 0x2);     /* mov dword [ebp-0x2c], 0x2 */
            ii(0x1007_06da, 5); jmpd(0x1007_0788, 0xa9); goto l_0x1007_0788; /* jmp 0x10070788 */
        l_0x1007_06df:
            ii(0x1007_06df, 5); jmpd(0x1007_0788, 0xa4); goto l_0x1007_0788; /* jmp 0x10070788 */
        l_0x1007_06e4:
            ii(0x1007_06e4, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_06eb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_06ed, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_06f0, 5); calld(0x1007_5f6c, 0x5877);             /* call 0x10075f6c */
            ii(0x1007_06f5, 5); jmpd(0x1007_07e2, 0xe8); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        l_0x1007_06fa:
            ii(0x1007_06fa, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1007_06fd, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1007_0700, 5); cmp(memw_a32[ss, ebp - 0x38], 0x15);    /* cmp word [ebp-0x38], 0x15 */
            ii(0x1007_0705, 2); if(jbd(0x1007_074a, 0x43)) goto l_0x1007_074a; /* jb 0x1007074a */
            ii(0x1007_0707, 5); cmp(memw_a32[ss, ebp - 0x38], 0x15);    /* cmp word [ebp-0x38], 0x15 */
            ii(0x1007_070c, 2); if(jbed(0x1007_06b6, -0x58)) goto l_0x1007_06b6; /* jbe 0x100706b6 */
            ii(0x1007_070e, 5); cmp(memw_a32[ss, ebp - 0x38], 0x27);    /* cmp word [ebp-0x38], 0x27 */
            ii(0x1007_0713, 2); if(jbd(0x1007_073d, 0x28)) goto l_0x1007_073d; /* jb 0x1007073d */
            ii(0x1007_0715, 5); cmp(memw_a32[ss, ebp - 0x38], 0x27);    /* cmp word [ebp-0x38], 0x27 */
            ii(0x1007_071a, 6); if(jbed(0x1007_057f, -0x1a1)) goto l_0x1007_057f; /* jbe 0x1007057f */
            ii(0x1007_0720, 5); cmp(memw_a32[ss, ebp - 0x38], 0x29);    /* cmp word [ebp-0x38], 0x29 */
            ii(0x1007_0725, 2); if(jbd(0x1007_073b, 0x14)) goto l_0x1007_073b; /* jb 0x1007073b */
            ii(0x1007_0727, 5); cmp(memw_a32[ss, ebp - 0x38], 0x2a);    /* cmp word [ebp-0x38], 0x2a */
            ii(0x1007_072c, 6); if(jbed(0x1007_066f, -0xc3)) goto l_0x1007_066f; /* jbe 0x1007066f */
            ii(0x1007_0732, 5); cmp(memw_a32[ss, ebp - 0x38], 0x5c);    /* cmp word [ebp-0x38], 0x5c */
            ii(0x1007_0737, 2); if(jzd(0x1007_06df, -0x5a)) goto l_0x1007_06df; /* jz 0x100706df */
            ii(0x1007_0739, 2); jmpd(0x1007_06e4, -0x57); goto l_0x1007_06e4; /* jmp 0x100706e4 */
        l_0x1007_073b:
            ii(0x1007_073b, 2); jmpd(0x1007_06e4, -0x59); goto l_0x1007_06e4; /* jmp 0x100706e4 */
        l_0x1007_073d:
            ii(0x1007_073d, 5); cmp(memw_a32[ss, ebp - 0x38], 0x21);    /* cmp word [ebp-0x38], 0x21 */
            ii(0x1007_0742, 6); if(jzd(0x1007_05ea, -0x15e)) goto l_0x1007_05ea; /* jz 0x100705ea */
            ii(0x1007_0748, 2); jmpd(0x1007_06e4, -0x66); goto l_0x1007_06e4; /* jmp 0x100706e4 */
        l_0x1007_074a:
            ii(0x1007_074a, 5); cmp(memw_a32[ss, ebp - 0x38], 0xd);     /* cmp word [ebp-0x38], 0xd */
            ii(0x1007_074f, 2); if(jbd(0x1007_0778, 0x27)) goto l_0x1007_0778; /* jb 0x10070778 */
            ii(0x1007_0751, 5); cmp(memw_a32[ss, ebp - 0x38], 0xe);     /* cmp word [ebp-0x38], 0xe */
            ii(0x1007_0756, 6); if(jbed(0x1007_0573, -0x1e9)) goto l_0x1007_0573; /* jbe 0x10070573 */
            ii(0x1007_075c, 5); cmp(memw_a32[ss, ebp - 0x38], 0x11);    /* cmp word [ebp-0x38], 0x11 */
            ii(0x1007_0761, 2); if(jbd(0x1007_0773, 0x10)) goto l_0x1007_0773; /* jb 0x10070773 */
            ii(0x1007_0763, 5); cmp(memw_a32[ss, ebp - 0x38], 0x12);    /* cmp word [ebp-0x38], 0x12 */
            ii(0x1007_0768, 6); if(jbed(0x1007_06b6, -0xb8)) goto l_0x1007_06b6; /* jbe 0x100706b6 */
            ii(0x1007_076e, 5); jmpd(0x1007_06e4, -0x8f); goto l_0x1007_06e4; /* jmp 0x100706e4 */
        l_0x1007_0773:
            ii(0x1007_0773, 5); jmpd(0x1007_06e4, -0x94); goto l_0x1007_06e4; /* jmp 0x100706e4 */
        l_0x1007_0778:
            ii(0x1007_0778, 5); cmp(memw_a32[ss, ebp - 0x38], 0xc);     /* cmp word [ebp-0x38], 0xc */
            ii(0x1007_077d, 6); if(jzd(0x1007_05fd, -0x186)) goto l_0x1007_05fd; /* jz 0x100705fd */
            ii(0x1007_0783, 5); jmpd(0x1007_06e4, -0xa4); goto l_0x1007_06e4; /* jmp 0x100706e4 */
        l_0x1007_0788:
            ii(0x1007_0788, 5); jmpd(0x1007_03b6, -0x3d7); goto l_0x1007_03b6; /* jmp 0x100703b6 */
        l_0x1007_078d:
            ii(0x1007_078d, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1007_0791, 2); if(jzd(0x1007_079a, 0x7)) goto l_0x1007_079a; /* jz 0x1007079a */
            ii(0x1007_0793, 7); mov(memd_a32[ss, ebp - 0x2c], 0x8);     /* mov dword [ebp-0x2c], 0x8 */
        l_0x1007_079a:
            ii(0x1007_079a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1007_079e, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1007_07a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_07a3, 6); mov(dl, memb_a32[ds, eax + 0x101c_81d4]); /* mov dl, [eax+0x101c81d4] */
            ii(0x1007_07a9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_07ab, 4); mov(ax, memw_a32[ss, ebp - 0x30]);      /* mov ax, [ebp-0x30] */
            ii(0x1007_07af, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1007_07b1, 2); if(jnzd(0x1007_07c6, 0x13)) goto l_0x1007_07c6; /* jnz 0x100707c6 */
            ii(0x1007_07b3, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_07ba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_07bc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_07bf, 5); calld(0x1007_5f6c, 0x57a8);             /* call 0x10075f6c */
            ii(0x1007_07c4, 2); jmpd(0x1007_07e2, 0x1c); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        l_0x1007_07c6:
            ii(0x1007_07c6, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1007_07c9, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1007_07cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_07ce, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_07d1, 5); calld(0x1007_5f6c, 0x5796);             /* call 0x10075f6c */
            ii(0x1007_07d6, 2); jmpd(0x1007_07e2, 0xa); goto l_0x1007_07e2; /* jmp 0x100707e2 */
        //    ii(0x1007_07d8, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1007_07da, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
        //    ii(0x1007_07dd, 5); calld(0x1007_5f6c, 0x578a);             /* call 0x10075f6c */
        l_0x1007_07e2:
            ii(0x1007_07e2, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1007_07e5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_07e7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_07e8, 1); popd(edi);                              /* pop edi */
            ii(0x1007_07e9, 1); popd(esi);                              /* pop esi */
            ii(0x1007_07ea, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
