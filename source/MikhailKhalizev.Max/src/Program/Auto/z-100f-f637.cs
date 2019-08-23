using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_f637-a6b7d21b")]
        public void Method_100f_f637()
        {
            ii(0x100f_f637, 5); push(0xcc);                             /* push 0xcc */
            ii(0x100f_f63c, 5); call(Definitions.sys_check_available_stack_size, 0x6_6711); /* call 0x10165d52 */
            ii(0x100f_f641, 1); push(ebx);                              /* push ebx */
            ii(0x100f_f642, 1); push(ecx);                              /* push ecx */
            ii(0x100f_f643, 1); push(edx);                              /* push edx */
            ii(0x100f_f644, 1); push(esi);                              /* push esi */
            ii(0x100f_f645, 1); push(edi);                              /* push edi */
            ii(0x100f_f646, 1); push(ebp);                              /* push ebp */
            ii(0x100f_f647, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_f649, 6); sub(esp, 0xa4);                         /* sub esp, 0xa4 */
            ii(0x100f_f64f, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_f652, 7); cmp(memb[ds, 0x101c_3919], 0);          /* cmp byte [0x101c3919], 0x0 */
            ii(0x100f_f659, 6); if(jz(0x100f_fa67, 0x408)) goto l_0x100f_fa67; /* jz 0x100ffa67 */
            ii(0x100f_f65f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_f661, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_f666, 5); call(0x1013_ad71, 0x3_b706);            /* call 0x1013ad71 */
            ii(0x100f_f66b, 2); test(al, al);                           /* test al, al */
            ii(0x100f_f66d, 2); if(jz(0x100f_f680, 0x11)) goto l_0x100f_f680; /* jz 0x100ff680 */
            ii(0x100f_f66f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_f672, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_f677, 5); call(0x1008_b4ec, -0x7_4190);           /* call 0x1008b4ec */
            ii(0x100f_f67c, 2); test(al, al);                           /* test al, al */
            ii(0x100f_f67e, 2); if(jnz(0x100f_f682, 0x2)) goto l_0x100f_f682; /* jnz 0x100ff682 */
        l_0x100f_f680:
            ii(0x100f_f680, 2); jmp(0x100f_f6b2, 0x30); goto l_0x100f_f6b2; /* jmp 0x100ff6b2 */
        l_0x100f_f682:
            ii(0x100f_f682, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_f687, 5); call(0x1007_6574, -0x8_9118);           /* call 0x10076574 */
            ii(0x100f_f68c, 5); call(0x1014_9fa8, 0x4_a917);            /* call 0x10149fa8 */
            ii(0x100f_f691, 5); call(0x1010_2bf8, 0x3562);              /* call 0x10102bf8 */
            ii(0x100f_f696, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_f698, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_f69a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_f69c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_f6a1, 5); call(0x1007_6600, -0x8_90a6);           /* call 0x10076600 */
            ii(0x100f_f6a6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_f6a8, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_f6ad, 5); call(0x1013_d5c0, 0x3_df0e);            /* call 0x1013d5c0 */
        l_0x100f_f6b2:
            ii(0x100f_f6b2, 5); call(0x100d_51e4, -0x2_a4d3);           /* call 0x100d51e4 */
            ii(0x100f_f6b7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_f6bc, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_f6bf, 4); cmp(memd[ss, ebp - 0x4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100f_f6c3, 2); if(jz(0x100f_f6d8, 0x13)) goto l_0x100f_f6d8; /* jz 0x100ff6d8 */
            ii(0x100f_f6c5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f6c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_f6ca, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100f_f6cd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f6cf, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_f6d4, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_f6d6, 2); if(jz(0x100f_f6da, 0x2)) goto l_0x100f_f6da; /* jz 0x100ff6da */
        l_0x100f_f6d8:
            ii(0x100f_f6d8, 2); jmp(0x100f_f6e0, 0x6); goto l_0x100f_f6e0; /* jmp 0x100ff6e0 */
        l_0x100f_f6da:
            ii(0x100f_f6da, 4); mov(memb[ss, ebp - 0x18], 0x1);         /* mov byte [ebp-0x18], 0x1 */
            ii(0x100f_f6de, 2); jmp(0x100f_f6e4, 0x4); goto l_0x100f_f6e4; /* jmp 0x100ff6e4 */
        l_0x100f_f6e0:
            ii(0x100f_f6e0, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x100f_f6e4:
            ii(0x100f_f6e4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_f6e6, 3); mov(dl, memb[ss, ebp - 0x18]);          /* mov dl, [ebp-0x18] */
            ii(0x100f_f6e9, 5); mov(eax, memd[ds, 0x101c_393c]);        /* mov eax, [0x101c393c] */
            ii(0x100f_f6ee, 3); mov(ebx, memd[ss, ebp - 0x1c]);         /* mov ebx, [ebp-0x1c] */
            ii(0x100f_f6f1, 5); call(0x100c_fa7c, -0x2_fc7a);           /* call 0x100cfa7c */
            ii(0x100f_f6f6, 7); cmp(memd[ds, 0x101c_3940], 0);          /* cmp dword [0x101c3940], 0x0 */
            ii(0x100f_f6fd, 2); if(jz(0x100f_f732, 0x33)) goto l_0x100f_f732; /* jz 0x100ff732 */
            ii(0x100f_f6ff, 5); mov(eax, memd[ds, 0x101c_3940]);        /* mov eax, [0x101c3940] */
            ii(0x100f_f704, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100f_f707, 4); cmp(memd[ss, ebp - 0x20], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100f_f70b, 2); if(jz(0x100f_f721, 0x14)) goto l_0x100f_f721; /* jz 0x100ff721 */
            ii(0x100f_f70d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_f70f, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100f_f712, 5); call(Definitions.my_dtor_d6, -0x1_4640); /* call 0x100eb0d7 */
            ii(0x100f_f717, 5); call(Definitions.sys_delete, 0x6_6848); /* call 0x10165f64 */
            ii(0x100f_f71c, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100f_f71f, 2); jmp(0x100f_f728, 0x7); goto l_0x100f_f728; /* jmp 0x100ff728 */
        l_0x100f_f721:
            ii(0x100f_f721, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
        l_0x100f_f728:
            ii(0x100f_f728, 10); mov(memd[ds, 0x101c_3940], 0);         /* mov dword [0x101c3940], 0x0 */
        l_0x100f_f732:
            ii(0x100f_f732, 4); cmp(memd[ss, ebp - 0x4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100f_f736, 2); if(jnz(0x100f_f777, 0x3f)) goto l_0x100f_f777; /* jnz 0x100ff777 */
            ii(0x100f_f738, 5); call(0x100f_a835, -0x4f08);             /* call 0x100fa835 */
            ii(0x100f_f73d, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_f742, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_f744, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x100f_f749, 5); call(0x100f_fca3, 0x555);               /* call 0x100ffca3 */
            ii(0x100f_f74e, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_f753, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_f755, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x100f_f75a, 5); call(0x100f_fca3, 0x544);               /* call 0x100ffca3 */
            ii(0x100f_f75f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f761, 5); call(0x100f_448c, -0xb2da);             /* call 0x100f448c */
            ii(0x100f_f766, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_f768, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_f76d, 5); call(0x1007_6630, -0x8_9142);           /* call 0x10076630 */
            ii(0x100f_f772, 5); jmp(0x100f_fa67, 0x2f0); goto l_0x100f_fa67; /* jmp 0x100ffa67 */
        l_0x100f_f777:
            ii(0x100f_f777, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f77a, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_f77d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_f780, 3); imul(edx, eax, 0x33);                   /* imul edx, eax, 0x33 */
            ii(0x100f_f783, 5); mov(eax, 0x101c_81c0);                  /* mov eax, 0x101c81c0 */
            ii(0x100f_f788, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_f78a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_f78d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f790, 4); mov(memb[ds, eax + 0x55], 0);           /* mov byte [eax+0x55], 0x0 */
            ii(0x100f_f794, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f797, 4); mov(memb[ds, eax + 0x56], 0);           /* mov byte [eax+0x56], 0x0 */
            ii(0x100f_f79b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f79e, 4); mov(memb[ds, eax + 0x57], 0);           /* mov byte [eax+0x57], 0x0 */
            ii(0x100f_f7a2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f7a5, 5); call(0x1007_0b11, -0x8_ec99);           /* call 0x10070b11 */
            ii(0x100f_f7aa, 5); mov(memb[ds, 0x101c_3912], al);         /* mov [0x101c3912], al */
            ii(0x100f_f7af, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f7b1, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100f_f7b6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_f7b8, 2); if(jz(0x100f_f7d9, 0x1f)) goto l_0x100f_f7d9; /* jz 0x100ff7d9 */
            ii(0x100f_f7ba, 7); cmp(memb[ds, 0x101c_391e], 0x8);        /* cmp byte [0x101c391e], 0x8 */
            ii(0x100f_f7c1, 2); if(jnz(0x100f_f7c9, 0x6)) goto l_0x100f_f7c9; /* jnz 0x100ff7c9 */
            ii(0x100f_f7c3, 4); mov(memb[ss, ebp - 0x28], 0x1);         /* mov byte [ebp-0x28], 0x1 */
            ii(0x100f_f7c7, 2); jmp(0x100f_f7cd, 0x4); goto l_0x100f_f7cd; /* jmp 0x100ff7cd */
        l_0x100f_f7c9:
            ii(0x100f_f7c9, 4); mov(memb[ss, ebp - 0x28], 0);           /* mov byte [ebp-0x28], 0x0 */
        l_0x100f_f7cd:
            ii(0x100f_f7cd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f7cf, 3); mov(al, memb[ss, ebp - 0x28]);          /* mov al, [ebp-0x28] */
            ii(0x100f_f7d2, 5); call(0x100f_4fa2, -0xa835);             /* call 0x100f4fa2 */
            ii(0x100f_f7d7, 2); jmp(0x100f_f80a, 0x31); goto l_0x100f_f80a; /* jmp 0x100ff80a */
        l_0x100f_f7d9:
            ii(0x100f_f7d9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f7db, 5); mov(al, memb[ds, 0x101c_37c8]);         /* mov al, [0x101c37c8] */
            ii(0x100f_f7e0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_f7e6, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100f_f7ec, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_f7f1, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_f7f4, 2); if(jnz(0x100f_f7fc, 0x6)) goto l_0x100f_f7fc; /* jnz 0x100ff7fc */
            ii(0x100f_f7f6, 4); mov(memb[ss, ebp - 0x2c], 0x1);         /* mov byte [ebp-0x2c], 0x1 */
            ii(0x100f_f7fa, 2); jmp(0x100f_f800, 0x4); goto l_0x100f_f800; /* jmp 0x100ff800 */
        l_0x100f_f7fc:
            ii(0x100f_f7fc, 4); mov(memb[ss, ebp - 0x2c], 0);           /* mov byte [ebp-0x2c], 0x0 */
        l_0x100f_f800:
            ii(0x100f_f800, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f802, 3); mov(al, memb[ss, ebp - 0x2c]);          /* mov al, [ebp-0x2c] */
            ii(0x100f_f805, 5); call(0x100f_4fa2, -0xa868);             /* call 0x100f4fa2 */
        l_0x100f_f80a:
            ii(0x100f_f80a, 5); call(0x100f_a835, -0x4fda);             /* call 0x100fa835 */
            ii(0x100f_f80f, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x100f_f814, 5); call(0x100e_883d, -0x1_6fdc);           /* call 0x100e883d */
            ii(0x100f_f819, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100f_f81c, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100f_f81f, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100f_f822, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_f825, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100f_f828, 4); mov(ax, memw[ds, eax + 0x4]);           /* mov ax, [eax+0x4] */
            ii(0x100f_f82c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_f82f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f831, 5); call(0x100e_883d, -0x1_6ff9);           /* call 0x100e883d */
            ii(0x100f_f836, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100f_f839, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f83b, 1); push(eax);                              /* push eax */
            ii(0x100f_f83c, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_f841, 1); push(eax);                              /* push eax */
            ii(0x100f_f842, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_f846, 1); push(eax);                              /* push eax */
            ii(0x100f_f847, 4); movsx(ecx, memw[ss, ebp - 0xc]);        /* movsx ecx, word [ebp-0xc] */
            ii(0x100f_f84b, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x100f_f850, 3); mov(edx, memd[ss, ebp - 0x30]);         /* mov edx, [ebp-0x30] */
            ii(0x100f_f853, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_f856, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_f859, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_f85c, 5); call(0x100f_04d8, -0xf389);             /* call 0x100f04d8 */
            ii(0x100f_f861, 5); mov(memd[ds, 0x101c_37e0], eax);        /* mov [0x101c37e0], eax */
            ii(0x100f_f866, 6); lea(edx, memd[ss, ebp - 0x94]);         /* lea edx, [ebp-0x94] */
            ii(0x100f_f86c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f86f, 5); call(0x1014_fa43, 0x5_01cf);            /* call 0x1014fa43 */
            ii(0x100f_f874, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x100f_f879, 5); call(0x100e_883d, -0x1_7041);           /* call 0x100e883d */
            ii(0x100f_f87e, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100f_f881, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_f886, 5); call(/* sys */ 0x1016_a24c, 0x6_a9c1);  /* call 0x1016a24c */
            ii(0x100f_f88b, 5); push(0x500_0002);                       /* push 0x5000002 */
            ii(0x100f_f890, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100f_f893, 3); push(memd[ds, eax + 0x4]);              /* push dword [eax+0x4] */
            ii(0x100f_f896, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100f_f899, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x100f_f89b, 5); mov(ebx, 0x80);                         /* mov ebx, 0x80 */
            ii(0x100f_f8a0, 6); lea(edx, memd[ss, ebp - 0x94]);         /* lea edx, [ebp-0x94] */
            ii(0x100f_f8a6, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100f_f8a9, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x100f_f8ac, 5); call(/* sys */ 0x1016_6d74, 0x6_74c3);  /* call 0x10166d74 */
            ii(0x100f_f8b1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f8b4, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x100f_f8b9, 6); if(jnz(0x100f_f9c1, 0x102)) goto l_0x100f_f9c1; /* jnz 0x100ff9c1 */
            ii(0x100f_f8bf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f8c2, 5); call(0x1015_0369, 0x5_0aa2);            /* call 0x10150369 */
            ii(0x100f_f8c7, 6); mov(memd[ss, ebp - 0x98], eax);         /* mov [ebp-0x98], eax */
            ii(0x100f_f8cd, 7); movsx(eax, memw[ss, ebp - 0x98]);       /* movsx eax, word [ebp-0x98] */
            ii(0x100f_f8d4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_f8d6, 2); if(jg(0x100f_f8ed, 0x15)) goto l_0x100f_f8ed; /* jg 0x100ff8ed */
            ii(0x100f_f8d8, 5); mov(edx, StringDefinitions.Rookie);     /* mov edx, 0x101a2afb */
            ii(0x100f_f8dd, 6); lea(eax, memd[ss, ebp - 0x94]);         /* lea eax, [ebp-0x94] */
            ii(0x100f_f8e3, 5); call(Definitions.sys_strcpy, 0x6_65e7); /* call 0x10165ecf */
            ii(0x100f_f8e8, 5); jmp(0x100f_f957, 0x6a); goto l_0x100f_f957; /* jmp 0x100ff957 */
        l_0x100f_f8ed:
            ii(0x100f_f8ed, 7); movsx(eax, memw[ss, ebp - 0x98]);       /* movsx eax, word [ebp-0x98] */
            ii(0x100f_f8f4, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100f_f8f7, 2); if(jg(0x100f_f90b, 0x12)) goto l_0x100f_f90b; /* jg 0x100ff90b */
            ii(0x100f_f8f9, 5); mov(edx, StringDefinitions.Average);    /* mov edx, 0x101a2b02 */
            ii(0x100f_f8fe, 6); lea(eax, memd[ss, ebp - 0x94]);         /* lea eax, [ebp-0x94] */
            ii(0x100f_f904, 5); call(Definitions.sys_strcpy, 0x6_65c6); /* call 0x10165ecf */
            ii(0x100f_f909, 2); jmp(0x100f_f957, 0x4c); goto l_0x100f_f957; /* jmp 0x100ff957 */
        l_0x100f_f90b:
            ii(0x100f_f90b, 7); movsx(eax, memw[ss, ebp - 0x98]);       /* movsx eax, word [ebp-0x98] */
            ii(0x100f_f912, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x100f_f915, 2); if(jg(0x100f_f929, 0x12)) goto l_0x100f_f929; /* jg 0x100ff929 */
            ii(0x100f_f917, 5); mov(edx, StringDefinitions.Veteran);    /* mov edx, 0x101a2b0a */
            ii(0x100f_f91c, 6); lea(eax, memd[ss, ebp - 0x94]);         /* lea eax, [ebp-0x94] */
            ii(0x100f_f922, 5); call(Definitions.sys_strcpy, 0x6_65a8); /* call 0x10165ecf */
            ii(0x100f_f927, 2); jmp(0x100f_f957, 0x2e); goto l_0x100f_f957; /* jmp 0x100ff957 */
        l_0x100f_f929:
            ii(0x100f_f929, 7); movsx(eax, memw[ss, ebp - 0x98]);       /* movsx eax, word [ebp-0x98] */
            ii(0x100f_f930, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100f_f933, 2); if(jg(0x100f_f947, 0x12)) goto l_0x100f_f947; /* jg 0x100ff947 */
            ii(0x100f_f935, 5); mov(edx, StringDefinitions.Crack);      /* mov edx, 0x101a2b12 */
            ii(0x100f_f93a, 6); lea(eax, memd[ss, ebp - 0x94]);         /* lea eax, [ebp-0x94] */
            ii(0x100f_f940, 5); call(Definitions.sys_strcpy, 0x6_658a); /* call 0x10165ecf */
            ii(0x100f_f945, 2); jmp(0x100f_f957, 0x10); goto l_0x100f_f957; /* jmp 0x100ff957 */
        l_0x100f_f947:
            ii(0x100f_f947, 5); mov(edx, StringDefinitions.Elite);      /* mov edx, 0x101a2b18 */
            ii(0x100f_f94c, 6); lea(eax, memd[ss, ebp - 0x94]);         /* lea eax, [ebp-0x94] */
            ii(0x100f_f952, 5); call(Definitions.sys_strcpy, 0x6_6578); /* call 0x10165ecf */
        l_0x100f_f957:
            ii(0x100f_f957, 7); movsx(eax, memw[ss, ebp - 0x98]);       /* movsx eax, word [ebp-0x98] */
            ii(0x100f_f95e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_f960, 2); if(jle(0x100f_f990, 0x2e)) goto l_0x100f_f990; /* jle 0x100ff990 */
            ii(0x100f_f962, 7); movsx(eax, memw[ss, ebp - 0x98]);       /* movsx eax, word [ebp-0x98] */
            ii(0x100f_f969, 1); push(eax);                              /* push eax */
            ii(0x100f_f96a, 5); mov(eax, StringDefinitions.I);          /* mov eax, 0x101a2b1e */
            ii(0x100f_f96f, 1); push(eax);                              /* push eax */
            ii(0x100f_f970, 6); lea(eax, memd[ss, ebp - 0xa4]);         /* lea eax, [ebp-0xa4] */
            ii(0x100f_f976, 1); push(eax);                              /* push eax */
            ii(0x100f_f977, 5); call(Definitions.sys_sprintf, 0x6_6585); /* call 0x10165f01 */
            ii(0x100f_f97c, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_f97f, 6); lea(edx, memd[ss, ebp - 0xa4]);         /* lea edx, [ebp-0xa4] */
            ii(0x100f_f985, 6); lea(eax, memd[ss, ebp - 0x94]);         /* lea eax, [ebp-0x94] */
            ii(0x100f_f98b, 5); call(Definitions.sys_strcat, 0x6_65a1); /* call 0x10165f31 */
        l_0x100f_f990:
            ii(0x100f_f990, 5); push(0x500_0002);                       /* push 0x5000002 */
            ii(0x100f_f995, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x100f_f99b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_f99d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_f99f, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100f_f9a2, 3); add(edx, memd[ds, eax + 0x4]);          /* add edx, [eax+0x4] */
            ii(0x100f_f9a5, 1); push(edx);                              /* push edx */
            ii(0x100f_f9a6, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100f_f9a9, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x100f_f9ab, 5); mov(ebx, 0x80);                         /* mov ebx, 0x80 */
            ii(0x100f_f9b0, 6); lea(edx, memd[ss, ebp - 0x94]);         /* lea edx, [ebp-0x94] */
            ii(0x100f_f9b6, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100f_f9b9, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x100f_f9bc, 5); call(/* sys */ 0x1016_6d74, 0x6_73b3);  /* call 0x10166d74 */
        l_0x100f_f9c1:
            ii(0x100f_f9c1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f9c4, 5); call(0x1010_094d, 0xf84);               /* call 0x1010094d */
            ii(0x100f_f9c9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f9cc, 5); call(0x1014_9fa8, 0x4_a5d7);            /* call 0x10149fa8 */
            ii(0x100f_f9d1, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x100f_f9d5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f9d8, 4); cmp(memb[ds, eax + 0x3d], 0x4);         /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100f_f9dc, 2); if(jnz(0x100f_f9f2, 0x14)) goto l_0x100f_f9f2; /* jnz 0x100ff9f2 */
            ii(0x100f_f9de, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f9e1, 4); cmp(memb[ds, eax + 0x3e], 0xb);         /* cmp byte [eax+0x3e], 0xb */
            ii(0x100f_f9e5, 2); if(jz(0x100f_f9f0, 0x9)) goto l_0x100f_f9f0; /* jz 0x100ff9f0 */
            ii(0x100f_f9e7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f9ea, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_f9ee, 2); if(jnz(0x100f_f9f2, 0x2)) goto l_0x100f_f9f2; /* jnz 0x100ff9f2 */
        l_0x100f_f9f0:
            ii(0x100f_f9f0, 2); jmp(0x100f_f9f4, 0x2); goto l_0x100f_f9f4; /* jmp 0x100ff9f4 */
        l_0x100f_f9f2:
            ii(0x100f_f9f2, 2); jmp(0x100f_f9fa, 0x6); goto l_0x100f_f9fa; /* jmp 0x100ff9fa */
        l_0x100f_f9f4:
            ii(0x100f_f9f4, 4); mov(memb[ss, ebp - 0x8], 0x8);          /* mov byte [ebp-0x8], 0x8 */
            ii(0x100f_f9f8, 2); jmp(0x100f_fa2c, 0x32); goto l_0x100f_fa2c; /* jmp 0x100ffa2c */
        l_0x100f_f9fa:
            ii(0x100f_f9fa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f9fd, 4); cmp(memb[ds, eax + 0x3d], 0xb);         /* cmp byte [eax+0x3d], 0xb */
            ii(0x100f_fa01, 2); if(jnz(0x100f_fa0c, 0x9)) goto l_0x100f_fa0c; /* jnz 0x100ffa0c */
            ii(0x100f_fa03, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_fa06, 4); cmp(memb[ds, eax + 0x3e], 0x5);         /* cmp byte [eax+0x3e], 0x5 */
            ii(0x100f_fa0a, 2); if(jz(0x100f_fa0e, 0x2)) goto l_0x100f_fa0e; /* jz 0x100ffa0e */
        l_0x100f_fa0c:
            ii(0x100f_fa0c, 2); jmp(0x100f_fa14, 0x6); goto l_0x100f_fa14; /* jmp 0x100ffa14 */
        l_0x100f_fa0e:
            ii(0x100f_fa0e, 4); mov(memb[ss, ebp - 0x8], 0x8);          /* mov byte [ebp-0x8], 0x8 */
            ii(0x100f_fa12, 2); jmp(0x100f_fa2c, 0x18); goto l_0x100f_fa2c; /* jmp 0x100ffa2c */
        l_0x100f_fa14:
            ii(0x100f_fa14, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_fa17, 4); cmp(memb[ds, eax + 0x3d], 0x7);         /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100f_fa1b, 2); if(jnz(0x100f_fa26, 0x9)) goto l_0x100f_fa26; /* jnz 0x100ffa26 */
            ii(0x100f_fa1d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_fa20, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_fa24, 2); if(jz(0x100f_fa28, 0x2)) goto l_0x100f_fa28; /* jz 0x100ffa28 */
        l_0x100f_fa26:
            ii(0x100f_fa26, 2); jmp(0x100f_fa2c, 0x4); goto l_0x100f_fa2c; /* jmp 0x100ffa2c */
        l_0x100f_fa28:
            ii(0x100f_fa28, 4); mov(memb[ss, ebp - 0x8], 0x8);          /* mov byte [ebp-0x8], 0x8 */
        l_0x100f_fa2c:
            ii(0x100f_fa2c, 5); call(0x1010_2bf8, 0x31c7);              /* call 0x10102bf8 */
            ii(0x100f_fa31, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_fa33, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_fa35, 4); movsx(ebx, memb[ss, ebp - 0x8]);        /* movsx ebx, byte [ebp-0x8] */
            ii(0x100f_fa39, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_fa3c, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_fa41, 5); call(0x1013_d5c0, 0x3_db7a);            /* call 0x1013d5c0 */
            ii(0x100f_fa46, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_fa49, 5); call(0x1007_61d4, -0x8_987a);           /* call 0x100761d4 */
            ii(0x100f_fa4e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_fa50, 2); if(jz(0x100f_fa5a, 0x8)) goto l_0x100f_fa5a; /* jz 0x100ffa5a */
            ii(0x100f_fa52, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_fa55, 5); call(0x1014_b77e, 0x4_bd24);            /* call 0x1014b77e */
        l_0x100f_fa5a:
            ii(0x100f_fa5a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_fa5d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_fa62, 5); call(0x1007_6630, -0x8_9437);           /* call 0x10076630 */
        l_0x100f_fa67:
            ii(0x100f_fa67, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_fa69, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_fa6a, 1); pop(edi);                               /* pop edi */
            ii(0x100f_fa6b, 1); pop(esi);                               /* pop esi */
            ii(0x100f_fa6c, 1); pop(edx);                               /* pop edx */
            ii(0x100f_fa6d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_fa6e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_fa6f, 1); ret();                                  /* ret */
        }
    }
}
