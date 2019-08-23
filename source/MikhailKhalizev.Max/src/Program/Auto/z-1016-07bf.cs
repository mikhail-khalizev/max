using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_07bf-1a213005")]
        public void Method_1016_07bf()
        {
            ii(0x1016_07bf, 5); pushd(0x80);                            /* push 0x80 */
            ii(0x1016_07c4, 5); calld(Definitions.sys_check_available_stack_size, 0x5589); /* call 0x10165d52 */
            ii(0x1016_07c9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_07ca, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_07cb, 1); pushd(esi);                             /* push esi */
            ii(0x1016_07cc, 1); pushd(edi);                             /* push edi */
            ii(0x1016_07cd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_07ce, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_07d0, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1016_07d6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_07d9, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_07dc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_07df, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1016_07e3, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1016_07e6, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1016_07ea, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1016_07ed, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x1016_07f2, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_07f4, 3); mov(memd_a32[ss, ebp - 0x34], edx);     /* mov [ebp-0x34], edx */
            ii(0x1016_07f7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_07f9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_07fc, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1016_07ff, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1016_0802, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0805, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1016_0808, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1016_080b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_080e, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1016_0812, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1016_0815, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0818, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1016_081c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_081f, 7); mov(memd_a32[ss, ebp - 0x14], 0xffff_ffff); /* mov dword [ebp-0x14], 0xffffffff */
            ii(0x1016_0826, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1016_082d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0830, 5); movsx(ax, memb_a32[ds, eax + 0x3d]);    /* movsx ax, byte [eax+0x3d] */
            ii(0x1016_0835, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1016_0838, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_083b, 5); calld(0x1014_9fa8, -0x1_6898);          /* call 0x10149fa8 */
            ii(0x1016_0840, 7); test(memd_a32[ss, ebp - 0x30], 0x200);  /* test dword [ebp-0x30], 0x200 */
            ii(0x1016_0847, 2); if(jzd(0x1016_08a1, 0x58)) goto l_0x1016_08a1; /* jz 0x101608a1 */
            ii(0x1016_0849, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_084c, 5); calld(0x1015_bdae, -0x4aa3);            /* call 0x1015bdae */
            ii(0x1016_0851, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0854, 5); cmp(memw_a32[ds, eax + 0x8], 0x1d);     /* cmp word [eax+0x8], 0x1d */
            ii(0x1016_0859, 2); if(jnzd(0x1016_0877, 0x1c)) goto l_0x1016_0877; /* jnz 0x10160877 */
            ii(0x1016_085b, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1016_0860, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0863, 3); mov(edx, memd_a32[ds, eax + 0x5a]);     /* mov edx, [eax+0x5a] */
            ii(0x1016_0866, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1016_0869, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_086c, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1016_086f, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_0871, 1); cwde();                                 /* cwde */
            ii(0x1016_0872, 5); calld(0x1013_322d, -0x2_d64a);          /* call 0x1013322d */
        l_0x1016_0877:
            ii(0x1016_0877, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_087a, 5); cmp(memw_a32[ds, eax + 0x8], 0x1e);     /* cmp word [eax+0x8], 0x1e */
            ii(0x1016_087f, 2); if(jnzd(0x1016_08a1, 0x20)) goto l_0x1016_08a1; /* jnz 0x101608a1 */
            ii(0x1016_0881, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0884, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1016_0887, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_088c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1016_0892, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_0895, 3); mov(edx, memd_a32[ds, edx + 0x50]);     /* mov edx, [edx+0x50] */
            ii(0x1016_0898, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_089b, 6); sub(memd_a32[ds, eax + 0x101c_a550], edx); /* sub [eax+0x101ca550], edx */
        l_0x1016_08a1:
            ii(0x1016_08a1, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1016_08a5, 2); if(jzd(0x1016_08b1, 0xa)) goto l_0x1016_08b1; /* jz 0x101608b1 */
            ii(0x1016_08a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_08aa, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1016_08af, 2); if(jnzd(0x1016_08b3, 0x2)) goto l_0x1016_08b3; /* jnz 0x101608b3 */
        l_0x1016_08b1:
            ii(0x1016_08b1, 2); jmpd(0x1016_08bd, 0xa); goto l_0x1016_08bd; /* jmp 0x101608bd */
        l_0x1016_08b3:
            ii(0x1016_08b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_08b6, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x1016_08bb, 2); if(jnzd(0x1016_08bf, 0x2)) goto l_0x1016_08bf; /* jnz 0x101608bf */
        l_0x1016_08bd:
            ii(0x1016_08bd, 2); jmpd(0x1016_08c8, 0x9); goto l_0x1016_08c8; /* jmp 0x101608c8 */
        l_0x1016_08bf:
            ii(0x1016_08bf, 7); test(memd_a32[ss, ebp - 0x30], 0x1_0008); /* test dword [ebp-0x30], 0x10008 */
            ii(0x1016_08c6, 2); if(jzd(0x1016_08ca, 0x2)) goto l_0x1016_08ca; /* jz 0x101608ca */
        l_0x1016_08c8:
            ii(0x1016_08c8, 2); jmpd(0x1016_08de, 0x14); goto l_0x1016_08de; /* jmp 0x101608de */
        l_0x1016_08ca:
            ii(0x1016_08ca, 3); mov(ebx, memd_a32[ss, ebp - 0x30]);     /* mov ebx, [ebp-0x30] */
            ii(0x1016_08cd, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1016_08d1, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1016_08d5, 5); calld(0x1007_4112, -0xe_c7c8);          /* call 0x10074112 */
            ii(0x1016_08da, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_08dc, 2); if(jnzd(0x1016_08e0, 0x2)) goto l_0x1016_08e0; /* jnz 0x101608e0 */
        l_0x1016_08de:
            ii(0x1016_08de, 2); jmpd(0x1016_0935, 0x55); goto l_0x1016_0935; /* jmp 0x10160935 */
        l_0x1016_08e0:
            ii(0x1016_08e0, 7); test(memd_a32[ss, ebp - 0x30], 0x10);   /* test dword [ebp-0x30], 0x10 */
            ii(0x1016_08e7, 2); if(jzd(0x1016_08f2, 0x9)) goto l_0x1016_08f2; /* jz 0x101608f2 */
            ii(0x1016_08e9, 7); mov(memd_a32[ss, ebp - 0x3c], 0xd);     /* mov dword [ebp-0x3c], 0xd */
            ii(0x1016_08f0, 2); jmpd(0x1016_08f9, 0x7); goto l_0x1016_08f9; /* jmp 0x101608f9 */
        l_0x1016_08f2:
            ii(0x1016_08f2, 7); mov(memd_a32[ss, ebp - 0x3c], 0xe);     /* mov dword [ebp-0x3c], 0xe */
        l_0x1016_08f9:
            ii(0x1016_08f9, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1016_08fc, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1016_08ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0902, 5); calld(0x1015_09a6, -0xff61);            /* call 0x101509a6 */
            ii(0x1016_0907, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_090a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_090c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_090f, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_0911, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1016_0913, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1016_0916, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0919, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1016_091c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_091f, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1016_0922, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x1016_0929, 2); if(jnzd(0x1016_0935, 0xa)) goto l_0x1016_0935; /* jnz 0x10160935 */
            ii(0x1016_092b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_092e, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1016_0932, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
        l_0x1016_0935:
            ii(0x1016_0935, 7); test(memd_a32[ss, ebp - 0x30], 0x340);  /* test dword [ebp-0x30], 0x340 */
            ii(0x1016_093c, 2); if(jzd(0x1016_0947, 0x9)) goto l_0x1016_0947; /* jz 0x10160947 */
            ii(0x1016_093e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0941, 4); test(memb_a32[ds, eax + 0x14], 0x1);    /* test byte [eax+0x14], 0x1 */
            ii(0x1016_0945, 2); if(jzd(0x1016_0949, 0x2)) goto l_0x1016_0949; /* jz 0x10160949 */
        l_0x1016_0947:
            ii(0x1016_0947, 2); jmpd(0x1016_098e, 0x45); goto l_0x1016_098e; /* jmp 0x1016098e */
        l_0x1016_0949:
            ii(0x1016_0949, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1016_094d, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1016_0951, 5); calld(0x1007_44db, -0xe_c47b);          /* call 0x100744db */
            ii(0x1016_0956, 7); test(memd_a32[ss, ebp - 0x30], 0x10);   /* test dword [ebp-0x30], 0x10 */
            ii(0x1016_095d, 2); if(jzd(0x1016_098e, 0x2f)) goto l_0x1016_098e; /* jz 0x1016098e */
            ii(0x1016_095f, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1016_0963, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1016_0966, 1); inc(eax);                               /* inc eax */
            ii(0x1016_0967, 1); cwde();                                 /* cwde */
            ii(0x1016_0968, 5); calld(0x1007_44db, -0xe_c492);          /* call 0x100744db */
            ii(0x1016_096d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_0970, 1); inc(eax);                               /* inc eax */
            ii(0x1016_0971, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_0974, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1016_0978, 5); calld(0x1007_44db, -0xe_c4a2);          /* call 0x100744db */
            ii(0x1016_097d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_0980, 1); inc(eax);                               /* inc eax */
            ii(0x1016_0981, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_0984, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1016_0987, 1); inc(eax);                               /* inc eax */
            ii(0x1016_0988, 1); cwde();                                 /* cwde */
            ii(0x1016_0989, 5); calld(0x1007_44db, -0xe_c4b3);          /* call 0x100744db */
        l_0x1016_098e:
            ii(0x1016_098e, 5); cmp(memw_a32[ss, ebp - 0x24], 0x29);    /* cmp word [ebp-0x24], 0x29 */
            ii(0x1016_0993, 2); if(jzd(0x1016_09a0, 0xb)) goto l_0x1016_09a0; /* jz 0x101609a0 */
            ii(0x1016_0995, 5); cmp(memw_a32[ss, ebp - 0x24], 0x2a);    /* cmp word [ebp-0x24], 0x2a */
            ii(0x1016_099a, 6); if(jnzd(0x1016_0a4b, 0xab)) goto l_0x1016_0a4b; /* jnz 0x10160a4b */
        l_0x1016_09a0:
            ii(0x1016_09a0, 5); mov(ecx, 0x180);                        /* mov ecx, 0x180 */
            ii(0x1016_09a5, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1016_09a9, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1016_09ad, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1016_09b1, 5); calld(0x1007_459a, -0xe_c41c);          /* call 0x1007459a */
            ii(0x1016_09b6, 3); lea(ebx, ebp - 0x40);                   /* lea ebx, [ebp-0x40] */
            ii(0x1016_09b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_09bb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_09bd, 5); calld(0x1007_66ac, -0xe_a316);          /* call 0x100766ac */
            ii(0x1016_09c2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_09c4, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1016_09c7, 5); calld(0x1013_ad11, -0x2_5cbb);          /* call 0x1013ad11 */
            ii(0x1016_09cc, 2); test(al, al);                           /* test al, al */
            ii(0x1016_09ce, 2); if(jzd(0x1016_09ea, 0x1a)) goto l_0x1016_09ea; /* jz 0x101609ea */
            ii(0x1016_09d0, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1016_09d4, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1016_09d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_09db, 5); calld(0x1007_4f1e, -0xe_bac2);          /* call 0x10074f1e */
            ii(0x1016_09e0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_09e2, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1016_09e5, 5); calld(0x1007_6630, -0xe_a3ba);          /* call 0x10076630 */
        l_0x1016_09ea:
            ii(0x1016_09ea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_09ec, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1016_09ef, 5); calld(0x1013_ad71, -0x2_5c83);          /* call 0x1013ad71 */
            ii(0x1016_09f4, 2); test(al, al);                           /* test al, al */
            ii(0x1016_09f6, 2); if(jzd(0x1016_0a3a, 0x42)) goto l_0x1016_0a3a; /* jz 0x10160a3a */
            ii(0x1016_09f8, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1016_09fc, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1016_09ff, 5); calld(0x1007_6574, -0xe_a490);          /* call 0x10076574 */
            ii(0x1016_0a04, 5); calld(0x1014_f634, -0x1_13d5);          /* call 0x1014f634 */
            ii(0x1016_0a09, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1016_0a0c, 5); calld(0x1007_6574, -0xe_a49d);          /* call 0x10076574 */
            ii(0x1016_0a11, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_0a13, 3); mov(dl, memb_a32[ds, eax + 0x29]);      /* mov dl, [eax+0x29] */
            ii(0x1016_0a16, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1016_0a19, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x1016_0a1e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_0a20, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_0a23, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1016_0a25, 3); movsx(ecx, dx);                         /* movsx ecx, dx */
            ii(0x1016_0a28, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_0a2a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_0a2d, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1016_0a30, 5); calld(0x1007_6574, -0xe_a4c1);          /* call 0x10076574 */
            ii(0x1016_0a35, 5); calld(0x1014_a8f2, -0x1_6148);          /* call 0x1014a8f2 */
        l_0x1016_0a3a:
            ii(0x1016_0a3a, 7); mov(memd_a32[ss, ebp - 0x14], 0xffff_ffff); /* mov dword [ebp-0x14], 0xffffffff */
            ii(0x1016_0a41, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_0a43, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1016_0a46, 5); calld(0x1007_5f2c, -0xe_ab1f);          /* call 0x10075f2c */
        l_0x1016_0a4b:
            ii(0x1016_0a4b, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1016_0a4f, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1016_0a52, 5); calld(0x1007_64fc, -0xe_a55b);          /* call 0x100764fc */
            ii(0x1016_0a57, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1016_0a5a, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1016_0a5e, 5); cmp(memw_a32[ss, ebp - 0x24], 0xa);     /* cmp word [ebp-0x24], 0xa */
            ii(0x1016_0a63, 2); if(jzd(0x1016_0a6c, 0x7)) goto l_0x1016_0a6c; /* jz 0x10160a6c */
            ii(0x1016_0a65, 5); cmp(memw_a32[ss, ebp - 0x24], 0x1b);    /* cmp word [ebp-0x24], 0x1b */
            ii(0x1016_0a6a, 2); if(jnzd(0x1016_0a84, 0x18)) goto l_0x1016_0a84; /* jnz 0x10160a84 */
        l_0x1016_0a6c:
            ii(0x1016_0a6c, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1016_0a71, 5); calld(0x1007_6338, -0xe_a73e);          /* call 0x10076338 */
            ii(0x1016_0a76, 3); lea(ebx, ebp - 0x38);                   /* lea ebx, [ebp-0x38] */
            ii(0x1016_0a79, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_0a7b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_0a7d, 5); calld(0x1007_643c, -0xe_a646);          /* call 0x1007643c */
            ii(0x1016_0a82, 2); jmpd(0x1016_0a9a, 0x16); goto l_0x1016_0a9a; /* jmp 0x10160a9a */
        l_0x1016_0a84:
            ii(0x1016_0a84, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1016_0a89, 5); calld(0x1007_6338, -0xe_a756);          /* call 0x10076338 */
            ii(0x1016_0a8e, 3); lea(ebx, ebp - 0x38);                   /* lea ebx, [ebp-0x38] */
            ii(0x1016_0a91, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_0a93, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_0a95, 5); calld(0x1007_643c, -0xe_a65e);          /* call 0x1007643c */
        l_0x1016_0a9a:
            ii(0x1016_0a9a, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1016_0a9d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0aa0, 5); calld(0x1007_2eb4, -0xe_dbf1);          /* call 0x10072eb4 */
            ii(0x1016_0aa5, 2); test(al, al);                           /* test al, al */
            ii(0x1016_0aa7, 6); if(jzd(0x1016_0b8f, 0xe2)) goto l_0x1016_0b8f; /* jz 0x10160b8f */
            ii(0x1016_0aad, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1016_0ab0, 5); calld(0x1007_63a0, -0xe_a715);          /* call 0x100763a0 */
            ii(0x1016_0ab5, 5); cmp(memw_a32[ds, eax + 0x8], 0x48);     /* cmp word [eax+0x8], 0x48 */
            ii(0x1016_0aba, 2); if(jzd(0x1016_0acb, 0xf)) goto l_0x1016_0acb; /* jz 0x10160acb */
            ii(0x1016_0abc, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1016_0abf, 5); calld(0x1007_63a0, -0xe_a724);          /* call 0x100763a0 */
            ii(0x1016_0ac4, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x1016_0ac9, 2); if(jnzd(0x1016_0acd, 0x2)) goto l_0x1016_0acd; /* jnz 0x10160acd */
        l_0x1016_0acb:
            ii(0x1016_0acb, 2); jmpd(0x1016_0adc, 0xf); goto l_0x1016_0adc; /* jmp 0x10160adc */
        l_0x1016_0acd:
            ii(0x1016_0acd, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1016_0ad0, 5); calld(0x1007_63a0, -0xe_a735);          /* call 0x100763a0 */
            ii(0x1016_0ad5, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x1016_0ada, 2); if(jnzd(0x1016_0b4e, 0x72)) goto l_0x1016_0b4e; /* jnz 0x10160b4e */
        l_0x1016_0adc:
            ii(0x1016_0adc, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1016_0ae1, 5); calld(0x1007_6338, -0xe_a7ae);          /* call 0x10076338 */
            ii(0x1016_0ae6, 3); lea(ebx, ebp - 0x44);                   /* lea ebx, [ebp-0x44] */
            ii(0x1016_0ae9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_0aeb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_0aed, 5); calld(0x1007_64b8, -0xe_a63a);          /* call 0x100764b8 */
        l_0x1016_0af2:
            ii(0x1016_0af2, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x1016_0af5, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1016_0af8, 5); calld(0x1007_6408, -0xe_a6f5);          /* call 0x10076408 */
            ii(0x1016_0afd, 5); calld(0x1007_2eb4, -0xe_dc4e);          /* call 0x10072eb4 */
            ii(0x1016_0b02, 2); test(al, al);                           /* test al, al */
            ii(0x1016_0b04, 2); if(jzd(0x1016_0b44, 0x3e)) goto l_0x1016_0b44; /* jz 0x10160b44 */
            ii(0x1016_0b06, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1016_0b09, 5); calld(0x1007_63a0, -0xe_a76e);          /* call 0x100763a0 */
            ii(0x1016_0b0e, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1016_0b11, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_0b16, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x1016_0b1c, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1016_0b1f, 5); calld(0x1007_63a0, -0xe_a784);          /* call 0x100763a0 */
            ii(0x1016_0b24, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1016_0b27, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_0b2a, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_0b2c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_0b2e, 7); inc(memw_a32[ds, eax + 0x101c_a5e9]);   /* inc word [eax+0x101ca5e9] */
            ii(0x1016_0b35, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1016_0b38, 5); calld(0x1007_6408, -0xe_a735);          /* call 0x10076408 */
            ii(0x1016_0b3d, 5); calld(0x1015_f2cc, -0x1876);            /* call 0x1015f2cc */
            ii(0x1016_0b42, 2); jmpd(0x1016_0af2, -0x52); goto l_0x1016_0af2; /* jmp 0x10160af2 */
        l_0x1016_0b44:
            ii(0x1016_0b44, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_0b46, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1016_0b49, 5); calld(0x1007_5f6c, -0xe_abe2);          /* call 0x10075f6c */
        l_0x1016_0b4e:
            ii(0x1016_0b4e, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1016_0b51, 5); calld(0x1007_63a0, -0xe_a7b6);          /* call 0x100763a0 */
            ii(0x1016_0b56, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1016_0b59, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_0b5e, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x1016_0b64, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1016_0b67, 5); calld(0x1007_63a0, -0xe_a7cc);          /* call 0x100763a0 */
            ii(0x1016_0b6c, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1016_0b6f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_0b72, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_0b74, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_0b76, 7); inc(memw_a32[ds, eax + 0x101c_a5e9]);   /* inc word [eax+0x101ca5e9] */
            ii(0x1016_0b7d, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1016_0b80, 5); calld(0x1007_6408, -0xe_a77d);          /* call 0x10076408 */
            ii(0x1016_0b85, 5); calld(0x1015_f2cc, -0x18be);            /* call 0x1015f2cc */
            ii(0x1016_0b8a, 5); jmpd(0x1016_0a9a, -0xf5); goto l_0x1016_0a9a; /* jmp 0x10160a9a */
        l_0x1016_0b8f:
            ii(0x1016_0b8f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0b92, 5); calld(0x1015_f2cc, -0x18cb);            /* call 0x1015f2cc */
            ii(0x1016_0b97, 7); test(memd_a32[ss, ebp - 0x30], 0x200);  /* test dword [ebp-0x30], 0x200 */
            ii(0x1016_0b9e, 2); if(jzd(0x1016_0bba, 0x1a)) goto l_0x1016_0bba; /* jz 0x10160bba */
            ii(0x1016_0ba0, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1016_0ba4, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1016_0baa, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1016_0bb0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_0bb5, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1016_0bb8, 2); if(jnzd(0x1016_0bbc, 0x2)) goto l_0x1016_0bbc; /* jnz 0x10160bbc */
        l_0x1016_0bba:
            ii(0x1016_0bba, 2); jmpd(0x1016_0bd5, 0x19); goto l_0x1016_0bd5; /* jmp 0x10160bd5 */
        l_0x1016_0bbc:
            ii(0x1016_0bbc, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1016_0bc0, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1016_0bc4, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1016_0bca, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1016_0bd0, 5); calld(0x100d_f3dc, -0x8_17f9);          /* call 0x100df3dc */
        l_0x1016_0bd5:
            ii(0x1016_0bd5, 7); test(memd_a32[ss, ebp - 0x30], 0x80_0010); /* test dword [ebp-0x30], 0x800010 */
            ii(0x1016_0bdc, 2); if(jnzd(0x1016_0be7, 0x9)) goto l_0x1016_0be7; /* jnz 0x10160be7 */
            ii(0x1016_0bde, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1016_0be2, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1016_0be5, 2); if(jnzd(0x1016_0be9, 0x2)) goto l_0x1016_0be9; /* jnz 0x10160be9 */
        l_0x1016_0be7:
            ii(0x1016_0be7, 2); jmpd(0x1016_0bf6, 0xd); goto l_0x1016_0bf6; /* jmp 0x10160bf6 */
        l_0x1016_0be9:
            ii(0x1016_0be9, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1016_0bed, 3); cmp(eax, 0xb);                          /* cmp eax, 0xb */
            ii(0x1016_0bf0, 6); if(jnzd(0x1016_0c7a, 0x84)) goto l_0x1016_0c7a; /* jnz 0x10160c7a */
        l_0x1016_0bf6:
            ii(0x1016_0bf6, 5); cmp(memw_a32[ss, ebp - 0x24], 0x31);    /* cmp word [ebp-0x24], 0x31 */
            ii(0x1016_0bfb, 2); if(jnzd(0x1016_0c06, 0x9)) goto l_0x1016_0c06; /* jnz 0x10160c06 */
            ii(0x1016_0bfd, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1016_0c01, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1016_0c04, 2); if(jzd(0x1016_0c08, 0x2)) goto l_0x1016_0c08; /* jz 0x10160c08 */
        l_0x1016_0c06:
            ii(0x1016_0c06, 2); jmpd(0x1016_0c0f, 0x7); goto l_0x1016_0c0f; /* jmp 0x10160c0f */
        l_0x1016_0c08:
            ii(0x1016_0c08, 5); cmp(memw_a32[ss, ebp - 0x14], 0xe);     /* cmp word [ebp-0x14], 0xe */
            ii(0x1016_0c0d, 2); if(jzd(0x1016_0c11, 0x2)) goto l_0x1016_0c11; /* jz 0x10160c11 */
        l_0x1016_0c0f:
            ii(0x1016_0c0f, 2); jmpd(0x1016_0c5d, 0x4c); goto l_0x1016_0c5d; /* jmp 0x10160c5d */
        l_0x1016_0c11:
            ii(0x1016_0c11, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1016_0c15, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1016_0c19, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1016_0c1d, 5); calld(0x1007_3f48, -0xe_ccda);          /* call 0x10073f48 */
            ii(0x1016_0c22, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x1016_0c25, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_0c27, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_0c29, 5); calld(0x1007_66ac, -0xe_a582);          /* call 0x100766ac */
            ii(0x1016_0c2e, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1016_0c31, 5); calld(0x1007_6574, -0xe_a6c2);          /* call 0x10076574 */
            ii(0x1016_0c36, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1016_0c3a, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1016_0c3d, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1016_0c40, 5); calld(0x1007_6574, -0xe_a6d1);          /* call 0x10076574 */
            ii(0x1016_0c45, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1016_0c49, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_0c4c, 7); mov(memd_a32[ss, ebp - 0x14], 0xd);     /* mov dword [ebp-0x14], 0xd */
            ii(0x1016_0c53, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_0c55, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1016_0c58, 5); calld(0x1007_5f2c, -0xe_ad31);          /* call 0x10075f2c */
        l_0x1016_0c5d:
            ii(0x1016_0c5d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_0c5f, 1); pushd(eax);                             /* push eax */
            ii(0x1016_0c60, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_0c62, 1); pushd(eax);                             /* push eax */
            ii(0x1016_0c63, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_0c68, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_0c6d, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1016_0c71, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1016_0c75, 5); calld(0x1007_4395, -0xe_c8e5);          /* call 0x10074395 */
        l_0x1016_0c7a:
            ii(0x1016_0c7a, 5); cmp(memw_a32[ss, ebp - 0x14], -0x1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x1016_0c7f, 2); if(jzd(0x1016_0cfd, 0x7c)) goto l_0x1016_0cfd; /* jz 0x10160cfd */
            ii(0x1016_0c81, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1016_0c85, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1016_0c88, 6); mov(eax, memd_a32[ds, eax + 0x101c_81c6]); /* mov eax, [eax+0x101c81c6] */
            ii(0x1016_0c8e, 3); mov(al, memb_a32[ds, eax + 0x1]);       /* mov al, [eax+0x1] */
            ii(0x1016_0c91, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_0c93, 1); dec(eax);                               /* dec eax */
            ii(0x1016_0c94, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1016_0c97, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1016_0c9b, 5); calld(/* sys */ 0x1016_5e9b, 0x51fb);   /* call 0x10165e9b */
            ii(0x1016_0ca0, 1); inc(edx);                               /* inc edx */
            ii(0x1016_0ca1, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1016_0ca4, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1016_0ca7, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1016_0caa, 5); calld(0x1010_2b84, -0x5_e12b);          /* call 0x10102b84 */
            ii(0x1016_0caf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_0cb4, 1); pushd(eax);                             /* push eax */
            ii(0x1016_0cb5, 5); calld(0x1010_2ba4, -0x5_e116);          /* call 0x10102ba4 */
            ii(0x1016_0cba, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_0cbf, 1); pushd(eax);                             /* push eax */
            ii(0x1016_0cc0, 4); movsx(eax, memw_a32[ss, ebp - 0x4c]);   /* movsx eax, word [ebp-0x4c] */
            ii(0x1016_0cc4, 1); pushd(eax);                             /* push eax */
            ii(0x1016_0cc5, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1016_0cc9, 1); pushd(eax);                             /* push eax */
            ii(0x1016_0cca, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1016_0cce, 1); pushd(eax);                             /* push eax */
            ii(0x1016_0ccf, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_0cd1, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x1016_0cd5, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1016_0cd9, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1016_0cdc, 5); calld(0x1015_a2da, -0x6a07);            /* call 0x1015a2da */
            ii(0x1016_0ce1, 5); calld(0x1007_65d0, -0xe_a716);          /* call 0x100765d0 */
            ii(0x1016_0ce6, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1016_0ce9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_0ceb, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1016_0cee, 5); calld(0x1007_5f2c, -0xe_adc7);          /* call 0x10075f2c */
            ii(0x1016_0cf3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1016_0cf6, 3); mov(edx, memd_a32[ss, ebp - 0x54]);     /* mov edx, [ebp-0x54] */
            ii(0x1016_0cf9, 4); mov(memw_a32[ds, edx + 0x52], ax);      /* mov [edx+0x52], ax */
        l_0x1016_0cfd:
            ii(0x1016_0cfd, 7); mov(memb_a32[ds, 0x101c_391b], 0x1);    /* mov byte [0x101c391b], 0x1 */
            ii(0x1016_0d04, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_0d06, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1016_0d09, 5); calld(0x1007_5f6c, -0xe_ada2);          /* call 0x10075f6c */
            ii(0x1016_0d0e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_0d10, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_0d11, 1); popd(edi);                              /* pop edi */
            ii(0x1016_0d12, 1); popd(esi);                              /* pop esi */
            ii(0x1016_0d13, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_0d14, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_0d15, 1); retd();                                 /* ret */
        }
    }
}
