using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9f92f20b-a343-4ad9-b6e7-7d7a5a42dce3")]
        public void Method_100b_6037()
        {
            ii(0x100b_6037, 5); pushd(0x74);                            /* push 0x74 */
            ii(0x100b_603c, 5); calld(Definitions.sys_check_available_stack_size, 0xa_fd11); /* call 0x10165d52 */
            ii(0x100b_6041, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_6042, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_6043, 1); pushd(edx);                             /* push edx */
            ii(0x100b_6044, 1); pushd(esi);                             /* push esi */
            ii(0x100b_6045, 1); pushd(edi);                             /* push edi */
            ii(0x100b_6046, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_6047, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_6049, 6); sub(esp, 0x58);                         /* sub esp, 0x58 */
            ii(0x100b_604f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_6052, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100b_6056, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6059, 5); calld(0x1007_64fc, -0x3_fb62);          /* call 0x100764fc */
            ii(0x100b_605e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_6061, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100b_6065, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100b_606c, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_6073, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_6078, 5); calld(0x1008_a768, -0x2_b915);          /* call 0x1008a768 */
            ii(0x100b_607d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_607f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_6082, 5); calld(0x1008_ae70, -0x2_b217);          /* call 0x1008ae70 */
            ii(0x100b_6087, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x100b_608c, 5); calld(0x100c_dec2, 0x1_7e31);           /* call 0x100cdec2 */
            ii(0x100b_6091, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_6093, 6); if(jzd(0x100b_62c8, 0x22f)) goto l_0x100b_62c8; /* jz 0x100b62c8 */
            ii(0x100b_6099, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100b_609d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_60a0, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_60a3, 5); calld(0x1007_6338, -0x3_fd70);          /* call 0x10076338 */
            ii(0x100b_60a8, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x100b_60ab, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_60ad, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_60af, 5); calld(0x1007_643c, -0x3_fc78);          /* call 0x1007643c */
            ii(0x100b_60b4, 2); jmpd(0x100b_60be, 0x8); goto l_0x100b_60be; /* jmp 0x100b60be */
        l_0x100b_60b6:
            ii(0x100b_60b6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_60b9, 5); calld(0x1007_6bf8, -0x3_f4c6);          /* call 0x10076bf8 */
        l_0x100b_60be:
            ii(0x100b_60be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_60c0, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_60c3, 5); calld(0x1013_ad71, 0x8_4ca9);           /* call 0x1013ad71 */
            ii(0x100b_60c8, 2); test(al, al);                           /* test al, al */
            ii(0x100b_60ca, 2); if(jzd(0x100b_60f5, 0x29)) goto l_0x100b_60f5; /* jz 0x100b60f5 */
            ii(0x100b_60cc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_60cf, 5); calld(0x1007_63a0, -0x3_fd34);          /* call 0x100763a0 */
            ii(0x100b_60d4, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_60d9, 2); if(jnzd(0x100b_60ed, 0x12)) goto l_0x100b_60ed; /* jnz 0x100b60ed */
            ii(0x100b_60db, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_60de, 5); calld(0x1007_63a0, -0x3_fd43);          /* call 0x100763a0 */
            ii(0x100b_60e3, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100b_60e6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_60e9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_60eb, 2); if(jzd(0x100b_60ef, 0x2)) goto l_0x100b_60ef; /* jz 0x100b60ef */
        l_0x100b_60ed:
            ii(0x100b_60ed, 2); jmpd(0x100b_60f3, 0x4); goto l_0x100b_60f3; /* jmp 0x100b60f3 */
        l_0x100b_60ef:
            ii(0x100b_60ef, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100b_60f3:
            ii(0x100b_60f3, 2); jmpd(0x100b_60b6, -0x3f); goto l_0x100b_60b6; /* jmp 0x100b60b6 */
        l_0x100b_60f5:
            ii(0x100b_60f5, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100b_60f9, 6); if(jnzd(0x100b_62c8, 0x1c9)) goto l_0x100b_62c8; /* jnz 0x100b62c8 */
            ii(0x100b_60ff, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_6104, 5); calld(0x1007_6338, -0x3_fdd1);          /* call 0x10076338 */
            ii(0x100b_6109, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x100b_610c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_610e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_6110, 5); calld(0x1007_643c, -0x3_fcd9);          /* call 0x1007643c */
            ii(0x100b_6115, 2); jmpd(0x100b_611f, 0x8); goto l_0x100b_611f; /* jmp 0x100b611f */
        l_0x100b_6117:
            ii(0x100b_6117, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_611a, 5); calld(0x1007_6bf8, -0x3_f527);          /* call 0x10076bf8 */
        l_0x100b_611f:
            ii(0x100b_611f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6121, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6124, 5); calld(0x1013_ad71, 0x8_4c48);           /* call 0x1013ad71 */
            ii(0x100b_6129, 2); test(al, al);                           /* test al, al */
            ii(0x100b_612b, 2); if(jzd(0x100b_615f, 0x32)) goto l_0x100b_615f; /* jz 0x100b615f */
            ii(0x100b_612d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6130, 5); calld(0x1007_63a0, -0x3_fd95);          /* call 0x100763a0 */
            ii(0x100b_6135, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6137, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_613a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_613d, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_6140, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_6143, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_6145, 2); if(jnzd(0x100b_6155, 0xe)) goto l_0x100b_6155; /* jnz 0x100b6155 */
            ii(0x100b_6147, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_614a, 5); calld(0x1007_63a0, -0x3_fdaf);          /* call 0x100763a0 */
            ii(0x100b_614f, 4); test(memb_a32[ds, eax + 0x13], 0x1);    /* test byte [eax+0x13], 0x1 */
            ii(0x100b_6153, 2); if(jnzd(0x100b_6157, 0x2)) goto l_0x100b_6157; /* jnz 0x100b6157 */
        l_0x100b_6155:
            ii(0x100b_6155, 2); jmpd(0x100b_615d, 0x6); goto l_0x100b_615d; /* jmp 0x100b615d */
        l_0x100b_6157:
            ii(0x100b_6157, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_615a, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100b_615d:
            ii(0x100b_615d, 2); jmpd(0x100b_6117, -0x48); goto l_0x100b_6117; /* jmp 0x100b6117 */
        l_0x100b_615f:
            ii(0x100b_615f, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100b_6164, 5); calld(0x1007_6338, -0x3_fe31);          /* call 0x10076338 */
            ii(0x100b_6169, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x100b_616c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_616e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_6170, 5); calld(0x1007_643c, -0x3_fd39);          /* call 0x1007643c */
            ii(0x100b_6175, 2); jmpd(0x100b_617f, 0x8); goto l_0x100b_617f; /* jmp 0x100b617f */
        l_0x100b_6177:
            ii(0x100b_6177, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_617a, 5); calld(0x1007_6bf8, -0x3_f587);          /* call 0x10076bf8 */
        l_0x100b_617f:
            ii(0x100b_617f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6181, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6184, 5); calld(0x1013_ad71, 0x8_4be8);           /* call 0x1013ad71 */
            ii(0x100b_6189, 2); test(al, al);                           /* test al, al */
            ii(0x100b_618b, 2); if(jzd(0x100b_61c0, 0x33)) goto l_0x100b_61c0; /* jz 0x100b61c0 */
            ii(0x100b_618d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6190, 5); calld(0x1007_63a0, -0x3_fdf5);          /* call 0x100763a0 */
            ii(0x100b_6195, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6197, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_619a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_619d, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_61a0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_61a3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_61a5, 2); if(jnzd(0x100b_61b6, 0xf)) goto l_0x100b_61b6; /* jnz 0x100b61b6 */
            ii(0x100b_61a7, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_61aa, 5); calld(0x1007_63a0, -0x3_fe0f);          /* call 0x100763a0 */
            ii(0x100b_61af, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_61b4, 2); if(jzd(0x100b_61b8, 0x2)) goto l_0x100b_61b8; /* jz 0x100b61b8 */
        l_0x100b_61b6:
            ii(0x100b_61b6, 2); jmpd(0x100b_61be, 0x6); goto l_0x100b_61be; /* jmp 0x100b61be */
        l_0x100b_61b8:
            ii(0x100b_61b8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_61bb, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_61be:
            ii(0x100b_61be, 2); jmpd(0x100b_6177, -0x49); goto l_0x100b_6177; /* jmp 0x100b6177 */
        l_0x100b_61c0:
            ii(0x100b_61c0, 2); jmpd(0x100b_61ca, 0x8); goto l_0x100b_61ca; /* jmp 0x100b61ca */
        l_0x100b_61c2:
            ii(0x100b_61c2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_61c5, 5); calld(0x1007_6bf8, -0x3_f5d2);          /* call 0x10076bf8 */
        l_0x100b_61ca:
            ii(0x100b_61ca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_61cc, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_61cf, 5); calld(0x1013_ad71, 0x8_4b9d);           /* call 0x1013ad71 */
            ii(0x100b_61d4, 2); test(al, al);                           /* test al, al */
            ii(0x100b_61d6, 2); if(jzd(0x100b_622e, 0x56)) goto l_0x100b_622e; /* jz 0x100b622e */
            ii(0x100b_61d8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_61db, 5); calld(0x1008_adc4, -0x2_b41c);          /* call 0x1008adc4 */
            ii(0x100b_61e0, 5); calld(0x1008_ad90, -0x2_b455);          /* call 0x1008ad90 */
            ii(0x100b_61e5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_61e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_61ea, 4); cmp(dx, memw_a32[ds, eax + 0x9]);       /* cmp dx, [eax+0x9] */
            ii(0x100b_61ee, 2); if(jnzd(0x100b_620b, 0x1b)) goto l_0x100b_620b; /* jnz 0x100b620b */
            ii(0x100b_61f0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_61f3, 5); calld(0x1008_adc4, -0x2_b434);          /* call 0x1008adc4 */
            ii(0x100b_61f8, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100b_61fb, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100b_61fe, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_6201, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100b_6204, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100b_6207, 2); cmp(al, 0x8);                           /* cmp al, 0x8 */
            ii(0x100b_6209, 2); if(jzd(0x100b_620d, 0x2)) goto l_0x100b_620d; /* jz 0x100b620d */
        l_0x100b_620b:
            ii(0x100b_620b, 2); jmpd(0x100b_622c, 0x1f); goto l_0x100b_622c; /* jmp 0x100b622c */
        l_0x100b_620d:
            ii(0x100b_620d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_6210, 5); calld(0x1008_adf8, -0x2_b41d);          /* call 0x1008adf8 */
            ii(0x100b_6215, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100b_6218, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_621b, 5); calld(0x1009_c4c4, -0x1_9d5c);          /* call 0x1009c4c4 */
            ii(0x100b_6220, 4); cmp(ax, 0x4e);                          /* cmp ax, 0x4e */
            ii(0x100b_6224, 2); if(jnzd(0x100b_622c, 0x6)) goto l_0x100b_622c; /* jnz 0x100b622c */
            ii(0x100b_6226, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_6229, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_622c:
            ii(0x100b_622c, 2); jmpd(0x100b_61c2, -0x6c); goto l_0x100b_61c2; /* jmp 0x100b61c2 */
        l_0x100b_622e:
            ii(0x100b_622e, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100b_6232, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x100b_6235, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x100b_623a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_623c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_623f, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100b_6241, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_6245, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_6247, 6); if(jged(0x100b_62c8, 0x7b)) goto l_0x100b_62c8; /* jge 0x100b62c8 */
            ii(0x100b_624d, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100b_6252, 5); calld(Definitions.sys_new, 0xa_fba9);   /* call 0x10165e00 */
            ii(0x100b_6257, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100b_625a, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100b_625d, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100b_6260, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100b_6264, 2); if(jzd(0x100b_62b5, 0x4f)) goto l_0x100b_62b5; /* jz 0x100b62b5 */
            ii(0x100b_6266, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x100b_626c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_626f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_6271, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_6274, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100b_6276, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100b_6278, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100b_627b, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100b_6281, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_6284, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_6286, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_6289, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100b_628b, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100b_628d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_6290, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_6293, 5); calld(0x1007_6aac, -0x3_f7ec);          /* call 0x10076aac */
            ii(0x100b_6298, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_629a, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_629d, 5); mov(edx, 0x4e);                         /* mov edx, 0x4e */
            ii(0x100b_62a2, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100b_62a5, 5); calld(0x1009_87c5, -0x1_dae5);          /* call 0x100987c5 */
            ii(0x100b_62aa, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100b_62ad, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100b_62b0, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100b_62b3, 2); jmpd(0x100b_62bb, 0x6); goto l_0x100b_62bb; /* jmp 0x100b62bb */
        l_0x100b_62b5:
            ii(0x100b_62b5, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100b_62b8, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        l_0x100b_62bb:
            ii(0x100b_62bb, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x100b_62be, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_62c3, 5); calld(0x100a_4d50, -0x1_1578);          /* call 0x100a4d50 */
        l_0x100b_62c8:
            ii(0x100b_62c8, 5); mov(eax, 0x41);                         /* mov eax, 0x41 */
            ii(0x100b_62cd, 5); calld(0x100c_dec2, 0x1_7bf0);           /* call 0x100cdec2 */
            ii(0x100b_62d2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_62d4, 6); if(jzd(0x100b_64f1, 0x217)) goto l_0x100b_64f1; /* jz 0x100b64f1 */
            ii(0x100b_62da, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100b_62e1, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_62e8, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100b_62ec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_62ef, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_62f2, 5); calld(0x1007_6338, -0x3_ffbf);          /* call 0x10076338 */
            ii(0x100b_62f7, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x100b_62fa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_62fc, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_62fe, 5); calld(0x1007_643c, -0x3_fec7);          /* call 0x1007643c */
            ii(0x100b_6303, 2); jmpd(0x100b_630d, 0x8); goto l_0x100b_630d; /* jmp 0x100b630d */
        l_0x100b_6305:
            ii(0x100b_6305, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6308, 5); calld(0x1007_6bf8, -0x3_f715);          /* call 0x10076bf8 */
        l_0x100b_630d:
            ii(0x100b_630d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_630f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6312, 5); calld(0x1013_ad71, 0x8_4a5a);           /* call 0x1013ad71 */
            ii(0x100b_6317, 2); test(al, al);                           /* test al, al */
            ii(0x100b_6319, 2); if(jzd(0x100b_6344, 0x29)) goto l_0x100b_6344; /* jz 0x100b6344 */
            ii(0x100b_631b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_631e, 5); calld(0x1007_63a0, -0x3_ff83);          /* call 0x100763a0 */
            ii(0x100b_6323, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x100b_6328, 2); if(jnzd(0x100b_633c, 0x12)) goto l_0x100b_633c; /* jnz 0x100b633c */
            ii(0x100b_632a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_632d, 5); calld(0x1007_63a0, -0x3_ff92);          /* call 0x100763a0 */
            ii(0x100b_6332, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100b_6335, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_6338, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_633a, 2); if(jzd(0x100b_633e, 0x2)) goto l_0x100b_633e; /* jz 0x100b633e */
        l_0x100b_633c:
            ii(0x100b_633c, 2); jmpd(0x100b_6342, 0x4); goto l_0x100b_6342; /* jmp 0x100b6342 */
        l_0x100b_633e:
            ii(0x100b_633e, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100b_6342:
            ii(0x100b_6342, 2); jmpd(0x100b_6305, -0x3f); goto l_0x100b_6305; /* jmp 0x100b6305 */
        l_0x100b_6344:
            ii(0x100b_6344, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100b_6348, 6); if(jnzd(0x100b_64f1, 0x1a3)) goto l_0x100b_64f1; /* jnz 0x100b64f1 */
            ii(0x100b_634e, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_6353, 5); calld(0x1007_6338, -0x4_0020);          /* call 0x10076338 */
            ii(0x100b_6358, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x100b_635b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_635d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_635f, 5); calld(0x1007_643c, -0x3_ff28);          /* call 0x1007643c */
            ii(0x100b_6364, 2); jmpd(0x100b_636e, 0x8); goto l_0x100b_636e; /* jmp 0x100b636e */
        l_0x100b_6366:
            ii(0x100b_6366, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6369, 5); calld(0x1007_6bf8, -0x3_f776);          /* call 0x10076bf8 */
        l_0x100b_636e:
            ii(0x100b_636e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6370, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6373, 5); calld(0x1013_ad71, 0x8_49f9);           /* call 0x1013ad71 */
            ii(0x100b_6378, 2); test(al, al);                           /* test al, al */
            ii(0x100b_637a, 2); if(jzd(0x100b_63d3, 0x57)) goto l_0x100b_63d3; /* jz 0x100b63d3 */
            ii(0x100b_637c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_637f, 5); calld(0x1007_63a0, -0x3_ffe4);          /* call 0x100763a0 */
            ii(0x100b_6384, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6386, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_6389, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_638c, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_638f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_6392, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_6394, 2); if(jnzd(0x100b_63d1, 0x3b)) goto l_0x100b_63d1; /* jnz 0x100b63d1 */
            ii(0x100b_6396, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6399, 5); calld(0x1007_63a0, -0x3_fffe);          /* call 0x100763a0 */
            ii(0x100b_639e, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x100b_63a3, 2); if(jzd(0x100b_63b4, 0xf)) goto l_0x100b_63b4; /* jz 0x100b63b4 */
            ii(0x100b_63a5, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_63a8, 5); calld(0x1007_63a0, -0x4_000d);          /* call 0x100763a0 */
            ii(0x100b_63ad, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x100b_63b2, 2); if(jnzd(0x100b_63bc, 0x8)) goto l_0x100b_63bc; /* jnz 0x100b63bc */
        l_0x100b_63b4:
            ii(0x100b_63b4, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_63b7, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
            ii(0x100b_63ba, 2); jmpd(0x100b_63d1, 0x15); goto l_0x100b_63d1; /* jmp 0x100b63d1 */
        l_0x100b_63bc:
            ii(0x100b_63bc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_63bf, 5); calld(0x1007_63a0, -0x4_0024);          /* call 0x100763a0 */
            ii(0x100b_63c4, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x100b_63c9, 2); if(jnzd(0x100b_63d1, 0x6)) goto l_0x100b_63d1; /* jnz 0x100b63d1 */
            ii(0x100b_63cb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_63ce, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_63d1:
            ii(0x100b_63d1, 2); jmpd(0x100b_6366, -0x6d); goto l_0x100b_6366; /* jmp 0x100b6366 */
        l_0x100b_63d3:
            ii(0x100b_63d3, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_63d8, 5); calld(0x1008_a768, -0x2_bc75);          /* call 0x1008a768 */
            ii(0x100b_63dd, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100b_63e0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_63e2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_63e4, 5); calld(0x100a_b1f8, -0xb1f1);            /* call 0x100ab1f8 */
            ii(0x100b_63e9, 2); jmpd(0x100b_63f3, 0x8); goto l_0x100b_63f3; /* jmp 0x100b63f3 */
        l_0x100b_63eb:
            ii(0x100b_63eb, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_63ee, 5); calld(0x1007_6bf8, -0x3_f7fb);          /* call 0x10076bf8 */
        l_0x100b_63f3:
            ii(0x100b_63f3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_63f5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_63f8, 5); calld(0x1013_ad71, 0x8_4974);           /* call 0x1013ad71 */
            ii(0x100b_63fd, 2); test(al, al);                           /* test al, al */
            ii(0x100b_63ff, 2); if(jzd(0x100b_6457, 0x56)) goto l_0x100b_6457; /* jz 0x100b6457 */
            ii(0x100b_6401, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_6404, 5); calld(0x1008_adc4, -0x2_b645);          /* call 0x1008adc4 */
            ii(0x100b_6409, 5); calld(0x1008_ad90, -0x2_b67e);          /* call 0x1008ad90 */
            ii(0x100b_640e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6410, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6413, 4); cmp(dx, memw_a32[ds, eax + 0x9]);       /* cmp dx, [eax+0x9] */
            ii(0x100b_6417, 2); if(jnzd(0x100b_6434, 0x1b)) goto l_0x100b_6434; /* jnz 0x100b6434 */
            ii(0x100b_6419, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_641c, 5); calld(0x1008_adc4, -0x2_b65d);          /* call 0x1008adc4 */
            ii(0x100b_6421, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100b_6424, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100b_6427, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_642a, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100b_642d, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100b_6430, 2); cmp(al, 0x8);                           /* cmp al, 0x8 */
            ii(0x100b_6432, 2); if(jzd(0x100b_6436, 0x2)) goto l_0x100b_6436; /* jz 0x100b6436 */
        l_0x100b_6434:
            ii(0x100b_6434, 2); jmpd(0x100b_6455, 0x1f); goto l_0x100b_6455; /* jmp 0x100b6455 */
        l_0x100b_6436:
            ii(0x100b_6436, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_6439, 5); calld(0x1008_adf8, -0x2_b646);          /* call 0x1008adf8 */
            ii(0x100b_643e, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100b_6441, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100b_6444, 5); calld(0x1009_c4c4, -0x1_9f85);          /* call 0x1009c4c4 */
            ii(0x100b_6449, 4); cmp(ax, 0x41);                          /* cmp ax, 0x41 */
            ii(0x100b_644d, 2); if(jnzd(0x100b_6455, 0x6)) goto l_0x100b_6455; /* jnz 0x100b6455 */
            ii(0x100b_644f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_6452, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_6455:
            ii(0x100b_6455, 2); jmpd(0x100b_63eb, -0x6c); goto l_0x100b_63eb; /* jmp 0x100b63eb */
        l_0x100b_6457:
            ii(0x100b_6457, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100b_645b, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x100b_645e, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x100b_6463, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_6465, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_6468, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100b_646a, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_646e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_6470, 6); if(jged(0x100b_64f1, 0x7b)) goto l_0x100b_64f1; /* jge 0x100b64f1 */
            ii(0x100b_6476, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100b_647b, 5); calld(Definitions.sys_new, 0xa_f980);   /* call 0x10165e00 */
            ii(0x100b_6480, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100b_6483, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100b_6486, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100b_6489, 4); cmp(memd_a32[ss, ebp - 0x4c], 0);       /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x100b_648d, 2); if(jzd(0x100b_64de, 0x4f)) goto l_0x100b_64de; /* jz 0x100b64de */
            ii(0x100b_648f, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x100b_6495, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_6498, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_649a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_649d, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100b_649f, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100b_64a1, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100b_64a4, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100b_64aa, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_64ad, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_64af, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_64b2, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100b_64b4, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100b_64b6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_64b9, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100b_64bc, 5); calld(0x1007_6aac, -0x3_fa15);          /* call 0x10076aac */
            ii(0x100b_64c1, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_64c3, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_64c6, 5); mov(edx, 0x41);                         /* mov edx, 0x41 */
            ii(0x100b_64cb, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100b_64ce, 5); calld(0x1009_87c5, -0x1_dd0e);          /* call 0x100987c5 */
            ii(0x100b_64d3, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100b_64d6, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100b_64d9, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100b_64dc, 2); jmpd(0x100b_64e4, 0x6); goto l_0x100b_64e4; /* jmp 0x100b64e4 */
        l_0x100b_64de:
            ii(0x100b_64de, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100b_64e1, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
        l_0x100b_64e4:
            ii(0x100b_64e4, 3); mov(edx, memd_a32[ss, ebp - 0x58]);     /* mov edx, [ebp-0x58] */
            ii(0x100b_64e7, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_64ec, 5); calld(0x100a_4d50, -0x1_17a1);          /* call 0x100a4d50 */
        l_0x100b_64f1:
            ii(0x100b_64f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_64f3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_64f6, 5); calld(0x1008_8bbc, -0x2_d93f);          /* call 0x10088bbc */
            ii(0x100b_64fb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_64fd, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6500, 5); calld(0x1007_5f6c, -0x4_0599);          /* call 0x10075f6c */
            ii(0x100b_6505, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_6507, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_6508, 1); popd(edi);                              /* pop edi */
            ii(0x100b_6509, 1); popd(esi);                              /* pop esi */
            ii(0x100b_650a, 1); popd(edx);                              /* pop edx */
            ii(0x100b_650b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_650c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_650d, 1); retd(); return;                         /* ret */
        }
    }
}
