using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_6666-a58775c3")]
        public void Method_1009_6666()
        {
            ii(0x1009_6666, 5); push(0x80);                             /* push 0x80 */
            ii(0x1009_666b, 5); call(Definitions.sys_check_available_stack_size, 0xc_f6e2); /* call 0x10165d52 */
            ii(0x1009_6670, 1); push(ecx);                              /* push ecx */
            ii(0x1009_6671, 1); push(esi);                              /* push esi */
            ii(0x1009_6672, 1); push(edi);                              /* push edi */
            ii(0x1009_6673, 1); push(ebp);                              /* push ebp */
            ii(0x1009_6674, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_6676, 6); sub(esp, 0x6c);                         /* sub esp, 0x6c */
            ii(0x1009_667c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_667f, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1009_6682, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1009_6685, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_6688, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_668b, 5); call(0x1007_6338, -0x2_0358);           /* call 0x10076338 */
            ii(0x1009_6690, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6692, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_6695, 5); call(0x1007_64b8, -0x2_01e2);           /* call 0x100764b8 */
            ii(0x1009_669a, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1009_669f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_66a2, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1009_66a5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_66a8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_66ae, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1009_66b4, 5); call(0x1008_b104, -0xb5b5);             /* call 0x1008b104 */
            ii(0x1009_66b9, 4); mov(ax, memw[ds, eax + 0x17]);          /* mov ax, [eax+0x17] */
            ii(0x1009_66bd, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_66c0, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_66c4, 2); jmp(0x1009_66ce, 8); goto l_0x1009_66ce; /* jmp 0x100966ce */
        l_0x1009_66c6:
            ii(0x1009_66c6, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_66c9, 5); call(0x1007_6bf8, -0x1_fad6);           /* call 0x10076bf8 */
        l_0x1009_66ce:
            ii(0x1009_66ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_66d0, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_66d3, 5); call(0x1013_ad71, 0xa_4699);            /* call 0x1013ad71 */
            ii(0x1009_66d8, 2); test(al, al);                           /* test al, al */
            ii(0x1009_66da, 6); if(jz(0x1009_6800, 0x120)) goto l_0x1009_6800; /* jz 0x10096800 */
            ii(0x1009_66e0, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_66e3, 5); call(0x1007_63a0, -0x2_0348);           /* call 0x100763a0 */
            ii(0x1009_66e8, 5); call(0x1007_623c, -0x2_04b1);           /* call 0x1007623c */
            ii(0x1009_66ed, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1009_66f0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_66f3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_66f5, 6); if(jle(0x1009_67fb, 0x100)) goto l_0x1009_67fb; /* jle 0x100967fb */
            ii(0x1009_66fb, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_66fe, 5); call(0x1007_63a0, -0x2_0363);           /* call 0x100763a0 */
            ii(0x1009_6703, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1009_6706, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_6709, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_670c, 5); call(0x1007_63a0, -0x2_0371);           /* call 0x100763a0 */
            ii(0x1009_6711, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1009_6714, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_6717, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_671a, 5); call(0x1007_6aac, -0x1_fc73);           /* call 0x10076aac */
            ii(0x1009_671f, 3); mov(ecx, memd[ss, ebp - 4]);            /* mov ecx, [ebp-0x4] */
            ii(0x1009_6722, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_6725, 5); call(0x1007_63a0, -0x2_038a);           /* call 0x100763a0 */
            ii(0x1009_672a, 5); call(0x1007_623c, -0x2_04f3);           /* call 0x1007623c */
            ii(0x1009_672f, 3); mov(ebx, memd[ds, eax + 0x10]);         /* mov ebx, [eax+0x10] */
            ii(0x1009_6732, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_6735, 3); lea(edx, memd[ss, ebp - 0x24]);         /* lea edx, [ebp-0x24] */
            ii(0x1009_6738, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x1009_673b, 5); call(0x1007_5e64, -0x2_08dc);           /* call 0x10075e64 */
            ii(0x1009_6740, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6742, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_6745, 5); call(0x1009_625f, -0x4eb);              /* call 0x1009625f */
            ii(0x1009_674a, 2); test(al, al);                           /* test al, al */
            ii(0x1009_674c, 6); if(jnz(0x1009_67fb, 0xa9)) goto l_0x1009_67fb; /* jnz 0x100967fb */
            ii(0x1009_6752, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_6755, 5); call(0x1007_63a0, -0x2_03ba);           /* call 0x100763a0 */
            ii(0x1009_675a, 5); call(0x1007_623c, -0x2_0523);           /* call 0x1007623c */
            ii(0x1009_675f, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1009_6762, 4); sub(dx, memw[ds, eax + 0x12]);          /* sub dx, [eax+0x12] */
            ii(0x1009_6766, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_6768, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_676b, 3); lea(edx, memd[ss, ebp - 0x24]);         /* lea edx, [ebp-0x24] */
            ii(0x1009_676e, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1009_6771, 5); call(0x1007_5e64, -0x2_0912);           /* call 0x10075e64 */
            ii(0x1009_6776, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6778, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1009_677b, 5); call(0x100a_95c1, 0x1_2e41);            /* call 0x100a95c1 */
            ii(0x1009_6780, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
        l_0x1009_6784:
            ii(0x1009_6784, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_6787, 3); mov(ebx, memd[ds, eax + 7]);            /* mov ebx, [eax+0x7] */
            ii(0x1009_678a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_678d, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1009_6790, 5); call(0x1008_9894, -0xcf01);             /* call 0x10089894 */
            ii(0x1009_6795, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6797, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1009_679a, 5); call(0x1007_5e64, -0x2_093b);           /* call 0x10075e64 */
            ii(0x1009_679f, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_67a1, 5); call(0x1008_b934, -0xae72);             /* call 0x1008b934 */
            ii(0x1009_67a6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_67a8, 2); if(jnz(0x1009_67cd, 0x23)) goto l_0x1009_67cd; /* jnz 0x100967cd */
            ii(0x1009_67aa, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1009_67ad, 5); call(0x1008_982c, -0xcf86);             /* call 0x1008982c */
            ii(0x1009_67b2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_67b5, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1009_67b8, 5); call(0x1008_9860, -0xcf5d);             /* call 0x10089860 */
            ii(0x1009_67bd, 1); cwde();                                 /* cwde */
            ii(0x1009_67be, 5); call(0x1007_3d48, -0x2_2a7b);           /* call 0x10073d48 */
            ii(0x1009_67c3, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1009_67c8, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1009_67cb, 2); if(jnz(0x1009_67cf, 2)) goto l_0x1009_67cf; /* jnz 0x100967cf */
        l_0x1009_67cd:
            ii(0x1009_67cd, 2); jmp(0x1009_67ef, 0x20); goto l_0x1009_67ef; /* jmp 0x100967ef */
        l_0x1009_67cf:
            ii(0x1009_67cf, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1009_67d2, 5); call(0x1008_9860, -0xcf77);             /* call 0x10089860 */
            ii(0x1009_67d7, 1); cwde();                                 /* cwde */
            ii(0x1009_67d8, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_67db, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_67de, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_67e0, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1009_67e3, 5); call(0x1008_982c, -0xcfbc);             /* call 0x1008982c */
            ii(0x1009_67e8, 1); cwde();                                 /* cwde */
            ii(0x1009_67e9, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1009_67eb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_67ed, 2); inc(memb[ds, eax]);                     /* inc byte [eax] */
        l_0x1009_67ef:
            ii(0x1009_67ef, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1009_67f2, 5); call(0x100a_96db, 0x1_2ee4);            /* call 0x100a96db */
            ii(0x1009_67f7, 2); test(al, al);                           /* test al, al */
            ii(0x1009_67f9, 2); if(jnz(0x1009_6784, -0x77)) goto l_0x1009_6784; /* jnz 0x10096784 */
        l_0x1009_67fb:
            ii(0x1009_67fb, 5); jmp(0x1009_66c6, -0x13a); goto l_0x1009_66c6; /* jmp 0x100966c6 */
        l_0x1009_6800:
            ii(0x1009_6800, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_6803, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_6806, 5); call(0x1009_c6c8, 0x5ebd);              /* call 0x1009c6c8 */
            ii(0x1009_680b, 3); lea(ebx, memd[ss, ebp - 0x1c]);         /* lea ebx, [ebp-0x1c] */
            ii(0x1009_680e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6810, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_6812, 5); call(0x1009_c5dc, 0x5dc5);              /* call 0x1009c5dc */
            ii(0x1009_6817, 2); jmp(0x1009_6821, 8); goto l_0x1009_6821; /* jmp 0x10096821 */
        l_0x1009_6819:
            ii(0x1009_6819, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_681c, 5); call(0x1007_6bf8, -0x1_fc29);           /* call 0x10076bf8 */
        l_0x1009_6821:
            ii(0x1009_6821, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6823, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_6826, 5); call(0x1013_ad71, 0xa_4546);            /* call 0x1013ad71 */
            ii(0x1009_682b, 2); test(al, al);                           /* test al, al */
            ii(0x1009_682d, 6); if(jz(0x1009_698e, 0x15b)) goto l_0x1009_698e; /* jz 0x1009698e */
            ii(0x1009_6833, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_6836, 5); call(0x1009_c4f8, 0x5cbd);              /* call 0x1009c4f8 */
            ii(0x1009_683b, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1009_683e, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1009_6841, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1009_6844, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1009_6847, 3); call_abs(memd[ds, edx + 0x70]);         /* call dword [edx+0x70] */
            ii(0x1009_684a, 2); test(al, al);                           /* test al, al */
            ii(0x1009_684c, 6); if(jz(0x1009_6989, 0x137)) goto l_0x1009_6989; /* jz 0x10096989 */
            ii(0x1009_6852, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_6855, 5); call(0x1009_c4f8, 0x5c9e);              /* call 0x1009c4f8 */
            ii(0x1009_685a, 5); call(0x1009_c4c4, 0x5c65);              /* call 0x1009c4c4 */
            ii(0x1009_685f, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1009_6862, 3); lea(edx, memd[ss, ebp - 0x4c]);         /* lea edx, [ebp-0x4c] */
            ii(0x1009_6865, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_6868, 5); call(0x1009_c4f8, 0x5c8b);              /* call 0x1009c4f8 */
            ii(0x1009_686d, 5); call(0x100a_2d3d, 0xc4cb);              /* call 0x100a2d3d */
            ii(0x1009_6872, 4); movsx(edx, memw[ss, ebp - 0x48]);       /* movsx edx, word [ebp-0x48] */
            ii(0x1009_6876, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_6879, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1009_687c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_687f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_6885, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1009_688b, 5); call(0x1008_b104, -0xb78c);             /* call 0x1008b104 */
            ii(0x1009_6890, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6892, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x1009_6895, 5); call(0x1007_6800, -0x2_009a);           /* call 0x10076800 */
            ii(0x1009_689a, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x1009_689d, 5); call(0x1007_6730, -0x2_0172);           /* call 0x10076730 */
            ii(0x1009_68a2, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1009_68a5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_68a8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_68aa, 2); if(jle(0x1009_68d6, 0x2a)) goto l_0x1009_68d6; /* jle 0x100968d6 */
            ii(0x1009_68ac, 3); mov(ecx, memd[ss, ebp - 4]);            /* mov ecx, [ebp-0x4] */
            ii(0x1009_68af, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x1009_68b2, 5); call(0x1007_6730, -0x2_0187);           /* call 0x10076730 */
            ii(0x1009_68b7, 3); mov(ebx, memd[ds, eax + 0x10]);         /* mov ebx, [eax+0x10] */
            ii(0x1009_68ba, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_68bd, 3); lea(edx, memd[ss, ebp - 0x4c]);         /* lea edx, [ebp-0x4c] */
            ii(0x1009_68c0, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1009_68c3, 5); call(0x1007_5e64, -0x2_0a64);           /* call 0x10075e64 */
            ii(0x1009_68c8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_68ca, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_68cd, 5); call(0x1009_625f, -0x673);              /* call 0x1009625f */
            ii(0x1009_68d2, 2); test(al, al);                           /* test al, al */
            ii(0x1009_68d4, 2); if(jz(0x1009_68db, 5)) goto l_0x1009_68db; /* jz 0x100968db */
        l_0x1009_68d6:
            ii(0x1009_68d6, 5); jmp(0x1009_697f, 0xa4); goto l_0x1009_697f; /* jmp 0x1009697f */
        l_0x1009_68db:
            ii(0x1009_68db, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x1009_68de, 5); call(0x1007_6730, -0x2_01b3);           /* call 0x10076730 */
            ii(0x1009_68e3, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1009_68e6, 4); sub(dx, memw[ds, eax + 0x12]);          /* sub dx, [eax+0x12] */
            ii(0x1009_68ea, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_68ec, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_68ef, 3); lea(edx, memd[ss, ebp - 0x4c]);         /* lea edx, [ebp-0x4c] */
            ii(0x1009_68f2, 3); lea(eax, memd[ss, ebp - 0x58]);         /* lea eax, [ebp-0x58] */
            ii(0x1009_68f5, 5); call(0x1007_5e64, -0x2_0a96);           /* call 0x10075e64 */
            ii(0x1009_68fa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_68fc, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x1009_68ff, 5); call(0x100a_95c1, 0x1_2cbd);            /* call 0x100a95c1 */
            ii(0x1009_6904, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
        l_0x1009_6908:
            ii(0x1009_6908, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_690b, 3); mov(ebx, memd[ds, eax + 7]);            /* mov ebx, [eax+0x7] */
            ii(0x1009_690e, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_6911, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x1009_6914, 5); call(0x1008_9894, -0xd085);             /* call 0x10089894 */
            ii(0x1009_6919, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_691b, 3); lea(eax, memd[ss, ebp - 0x6c]);         /* lea eax, [ebp-0x6c] */
            ii(0x1009_691e, 5); call(0x1007_5e64, -0x2_0abf);           /* call 0x10075e64 */
            ii(0x1009_6923, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_6925, 5); call(0x1008_b934, -0xaff6);             /* call 0x1008b934 */
            ii(0x1009_692a, 2); test(al, al);                           /* test al, al */
            ii(0x1009_692c, 2); if(jnz(0x1009_6951, 0x23)) goto l_0x1009_6951; /* jnz 0x10096951 */
            ii(0x1009_692e, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x1009_6931, 5); call(0x1008_982c, -0xd10a);             /* call 0x1008982c */
            ii(0x1009_6936, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_6939, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x1009_693c, 5); call(0x1008_9860, -0xd0e1);             /* call 0x10089860 */
            ii(0x1009_6941, 1); cwde();                                 /* cwde */
            ii(0x1009_6942, 5); call(0x1007_3d48, -0x2_2bff);           /* call 0x10073d48 */
            ii(0x1009_6947, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1009_694c, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1009_694f, 2); if(jnz(0x1009_6953, 2)) goto l_0x1009_6953; /* jnz 0x10096953 */
        l_0x1009_6951:
            ii(0x1009_6951, 2); jmp(0x1009_6973, 0x20); goto l_0x1009_6973; /* jmp 0x10096973 */
        l_0x1009_6953:
            ii(0x1009_6953, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x1009_6956, 5); call(0x1008_9860, -0xd0fb);             /* call 0x10089860 */
            ii(0x1009_695b, 1); cwde();                                 /* cwde */
            ii(0x1009_695c, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_695f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_6962, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_6964, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x1009_6967, 5); call(0x1008_982c, -0xd140);             /* call 0x1008982c */
            ii(0x1009_696c, 1); cwde();                                 /* cwde */
            ii(0x1009_696d, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1009_696f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_6971, 2); inc(memb[ds, eax]);                     /* inc byte [eax] */
        l_0x1009_6973:
            ii(0x1009_6973, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x1009_6976, 5); call(0x100a_96db, 0x1_2d60);            /* call 0x100a96db */
            ii(0x1009_697b, 2); test(al, al);                           /* test al, al */
            ii(0x1009_697d, 2); if(jnz(0x1009_6908, -0x77)) goto l_0x1009_6908; /* jnz 0x10096908 */
        l_0x1009_697f:
            ii(0x1009_697f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6981, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x1009_6984, 5); call(0x1007_5eec, -0x2_0a9d);           /* call 0x10075eec */
        l_0x1009_6989:
            ii(0x1009_6989, 5); jmp(0x1009_6819, -0x175); goto l_0x1009_6819; /* jmp 0x10096819 */
        l_0x1009_698e:
            ii(0x1009_698e, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1009_6992, 2); if(jnz(0x1009_69ae, 0x1a)) goto l_0x1009_69ae; /* jnz 0x100969ae */
            ii(0x1009_6994, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1009_6998, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_699a, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_699d, 5); call(0x1009_ba6c, 0x50ca);              /* call 0x1009ba6c */
            ii(0x1009_69a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_69a4, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_69a7, 5); call(0x1007_5f6c, -0x2_0a40);           /* call 0x10075f6c */
            ii(0x1009_69ac, 2); jmp(0x1009_6a08, 0x5a); goto l_0x1009_6a08; /* jmp 0x10096a08 */
        l_0x1009_69ae:
            ii(0x1009_69ae, 3); mov(ecx, memd[ss, ebp - 4]);            /* mov ecx, [ebp-0x4] */
            ii(0x1009_69b1, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1009_69b6, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_69b9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_69bc, 5); call(0x1009_55d3, -0x13ee);             /* call 0x100955d3 */
            ii(0x1009_69c1, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_69c4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_69c7, 5); call(0x1009_5881, -0x114b);             /* call 0x10095881 */
            ii(0x1009_69cc, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1009_69cf, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_69d2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_69d5, 5); call(0x1009_6478, -0x562);              /* call 0x10096478 */
            ii(0x1009_69da, 4); mov(memb[ss, ebp - 0x10], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1009_69de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_69e0, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_69e3, 5); call(0x1009_ba6c, 0x5084);              /* call 0x1009ba6c */
            ii(0x1009_69e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_69ea, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_69ed, 5); call(0x1007_5f6c, -0x2_0a86);           /* call 0x10075f6c */
            ii(0x1009_69f2, 2); jmp(0x1009_6a08, 0x14); goto l_0x1009_6a08; /* jmp 0x10096a08 */
        //  ii(0x1009_69f4, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1009_69f6, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
        //  ii(0x1009_69f9, 5); call(0x1009_ba6c, 0x506e);              /* call 0x1009ba6c */
        //  ii(0x1009_69fe, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1009_6a00, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
        //  ii(0x1009_6a03, 5); call(0x1007_5f6c, -0x2_0a9c);           /* call 0x10075f6c */
        l_0x1009_6a08:
            ii(0x1009_6a08, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1009_6a0b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_6a0d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_6a0e, 1); pop(edi);                               /* pop edi */
            ii(0x1009_6a0f, 1); pop(esi);                               /* pop esi */
            ii(0x1009_6a10, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_6a11, 1); ret();                                  /* ret */
        }
    }
}
