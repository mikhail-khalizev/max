using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("afe9ab64-9050-48b7-8d11-89a70c5323a7")]
        public void Method_100e_bf7b()
        {
            ii(0x100e_bf7b, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100e_bf80, 5); calld(Definitions.sys_check_available_stack_size, 0x79dcd); /* call 0x10165d52 */
            ii(0x100e_bf85, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_bf86, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_bf87, 1); pushd(edx);                             /* push edx */
            ii(0x100e_bf88, 1); pushd(esi);                             /* push esi */
            ii(0x100e_bf89, 1); pushd(edi);                             /* push edi */
            ii(0x100e_bf8a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_bf8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_bf8d, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_bf93, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_bf96, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100e_bf9b, 5); calld(0x1007_6338, -0x75c68);           /* call 0x10076338 */
            ii(0x100e_bfa0, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100e_bfa3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_bfa5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_bfa7, 5); calld(0x1007_64b8, -0x75af4);           /* call 0x100764b8 */
            ii(0x100e_bfac, 2); jmpd(0x100e_bfb6, 0x8); goto l_0x100e_bfb6; /* jmp 0x100ebfb6 */
        l_0x100e_bfae:
            ii(0x100e_bfae, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_bfb1, 5); calld(0x1007_6bf8, -0x753be);           /* call 0x10076bf8 */
        l_0x100e_bfb6:
            ii(0x100e_bfb6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bfb8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_bfbb, 5); calld(0x1013_ad71, 0x4edb1);            /* call 0x1013ad71 */
            ii(0x100e_bfc0, 2); test(al, al);                           /* test al, al */
            ii(0x100e_bfc2, 2); if(jzd(0x100e_bfee, 0x2a)) goto l_0x100e_bfee; /* jz 0x100ebfee */
            ii(0x100e_bfc4, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_bfc7, 5); calld(0x1007_63a0, -0x75c2c);           /* call 0x100763a0 */
            ii(0x100e_bfcc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bfce, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_bfd1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_bfd5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_bfd7, 2); if(jnzd(0x100e_bfe8, 0xf)) goto l_0x100e_bfe8; /* jnz 0x100ebfe8 */
            ii(0x100e_bfd9, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_bfdc, 5); calld(0x1007_63a0, -0x75c41);           /* call 0x100763a0 */
            ii(0x100e_bfe1, 5); cmp(memw_a32[ds, eax + 0x8], 0x31);     /* cmp word [eax+0x8], 0x31 */
            ii(0x100e_bfe6, 2); if(jzd(0x100e_bfea, 0x2)) goto l_0x100e_bfea; /* jz 0x100ebfea */
        l_0x100e_bfe8:
            ii(0x100e_bfe8, 2); jmpd(0x100e_bfec, 0x2); goto l_0x100e_bfec; /* jmp 0x100ebfec */
        l_0x100e_bfea:
            ii(0x100e_bfea, 2); jmpd(0x100e_bfee, 0x2); goto l_0x100e_bfee; /* jmp 0x100ebfee */
        l_0x100e_bfec:
            ii(0x100e_bfec, 2); jmpd(0x100e_bfae, -0x40); goto l_0x100e_bfae; /* jmp 0x100ebfae */
        l_0x100e_bfee:
            ii(0x100e_bfee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bff0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_bff3, 5); calld(0x1013_ad11, 0x4ed19);            /* call 0x1013ad11 */
            ii(0x100e_bff8, 2); test(al, al);                           /* test al, al */
            ii(0x100e_bffa, 2); if(jzd(0x100e_c00f, 0x13)) goto l_0x100e_c00f; /* jz 0x100ec00f */
            ii(0x100e_bffc, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100e_c000, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c002, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c005, 5); calld(0x1007_5f6c, -0x7609e);           /* call 0x10075f6c */
            ii(0x100e_c00a, 5); jmpd(0x100e_c1b1, 0x1a2); goto l_0x100e_c1b1; /* jmp 0x100ec1b1 */
        l_0x100e_c00f:
            ii(0x100e_c00f, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100e_c014, 5); calld(0x1007_6338, -0x75ce1);           /* call 0x10076338 */
            ii(0x100e_c019, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100e_c01c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_c01e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_c020, 5); calld(0x1007_643c, -0x75be9);           /* call 0x1007643c */
            ii(0x100e_c025, 2); jmpd(0x100e_c02f, 0x8); goto l_0x100e_c02f; /* jmp 0x100ec02f */
        l_0x100e_c027:
            ii(0x100e_c027, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c02a, 5); calld(0x1007_6bf8, -0x75437);           /* call 0x10076bf8 */
        l_0x100e_c02f:
            ii(0x100e_c02f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c031, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c034, 5); calld(0x1013_ad71, 0x4ed38);            /* call 0x1013ad71 */
            ii(0x100e_c039, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c03b, 2); if(jzd(0x100e_c067, 0x2a)) goto l_0x100e_c067; /* jz 0x100ec067 */
            ii(0x100e_c03d, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c040, 5); calld(0x1007_63a0, -0x75ca5);           /* call 0x100763a0 */
            ii(0x100e_c045, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c047, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_c04a, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c04e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_c050, 2); if(jnzd(0x100e_c061, 0xf)) goto l_0x100e_c061; /* jnz 0x100ec061 */
            ii(0x100e_c052, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c055, 5); calld(0x1007_63a0, -0x75cba);           /* call 0x100763a0 */
            ii(0x100e_c05a, 5); cmp(memw_a32[ds, eax + 0x8], 0x3d);     /* cmp word [eax+0x8], 0x3d */
            ii(0x100e_c05f, 2); if(jzd(0x100e_c063, 0x2)) goto l_0x100e_c063; /* jz 0x100ec063 */
        l_0x100e_c061:
            ii(0x100e_c061, 2); jmpd(0x100e_c065, 0x2); goto l_0x100e_c065; /* jmp 0x100ec065 */
        l_0x100e_c063:
            ii(0x100e_c063, 2); jmpd(0x100e_c067, 0x2); goto l_0x100e_c067; /* jmp 0x100ec067 */
        l_0x100e_c065:
            ii(0x100e_c065, 2); jmpd(0x100e_c027, -0x40); goto l_0x100e_c027; /* jmp 0x100ec027 */
        l_0x100e_c067:
            ii(0x100e_c067, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c069, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c06c, 5); calld(0x1013_ad11, 0x4eca0);            /* call 0x1013ad11 */
            ii(0x100e_c071, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c073, 2); if(jzd(0x100e_c088, 0x13)) goto l_0x100e_c088; /* jz 0x100ec088 */
            ii(0x100e_c075, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100e_c079, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c07b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c07e, 5); calld(0x1007_5f6c, -0x76117);           /* call 0x10075f6c */
            ii(0x100e_c083, 5); jmpd(0x100e_c1b1, 0x129); goto l_0x100e_c1b1; /* jmp 0x100ec1b1 */
        l_0x100e_c088:
            ii(0x100e_c088, 7); mov(memd_a32[ss, ebp - 0x10], 0x26);    /* mov dword [ebp-0x10], 0x26 */
            ii(0x100e_c08f, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_c094, 5); calld(0x1007_6338, -0x75d61);           /* call 0x10076338 */
            ii(0x100e_c099, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100e_c09c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_c09e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_c0a0, 5); calld(0x1007_643c, -0x75c69);           /* call 0x1007643c */
            ii(0x100e_c0a5, 2); jmpd(0x100e_c0af, 0x8); goto l_0x100e_c0af; /* jmp 0x100ec0af */
        l_0x100e_c0a7:
            ii(0x100e_c0a7, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c0aa, 5); calld(0x1007_6bf8, -0x754b7);           /* call 0x10076bf8 */
        l_0x100e_c0af:
            ii(0x100e_c0af, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c0b1, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c0b4, 5); calld(0x1013_ad71, 0x4ecb8);            /* call 0x1013ad71 */
            ii(0x100e_c0b9, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c0bb, 2); if(jzd(0x100e_c0e7, 0x2a)) goto l_0x100e_c0e7; /* jz 0x100ec0e7 */
            ii(0x100e_c0bd, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c0c0, 5); calld(0x1007_63a0, -0x75d25);           /* call 0x100763a0 */
            ii(0x100e_c0c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c0c7, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_c0ca, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c0ce, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_c0d0, 2); if(jnzd(0x100e_c0e1, 0xf)) goto l_0x100e_c0e1; /* jnz 0x100ec0e1 */
            ii(0x100e_c0d2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c0d5, 5); calld(0x1007_63a0, -0x75d3a);           /* call 0x100763a0 */
            ii(0x100e_c0da, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100e_c0df, 2); if(jzd(0x100e_c0e3, 0x2)) goto l_0x100e_c0e3; /* jz 0x100ec0e3 */
        l_0x100e_c0e1:
            ii(0x100e_c0e1, 2); jmpd(0x100e_c0e5, 0x2); goto l_0x100e_c0e5; /* jmp 0x100ec0e5 */
        l_0x100e_c0e3:
            ii(0x100e_c0e3, 2); jmpd(0x100e_c0e7, 0x2); goto l_0x100e_c0e7; /* jmp 0x100ec0e7 */
        l_0x100e_c0e5:
            ii(0x100e_c0e5, 2); jmpd(0x100e_c0a7, -0x40); goto l_0x100e_c0a7; /* jmp 0x100ec0a7 */
        l_0x100e_c0e7:
            ii(0x100e_c0e7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c0e9, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c0ec, 5); calld(0x1013_ad71, 0x4ec80);            /* call 0x1013ad71 */
            ii(0x100e_c0f1, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c0f3, 2); if(jzd(0x100e_c0fc, 0x7)) goto l_0x100e_c0fc; /* jz 0x100ec0fc */
            ii(0x100e_c0f5, 7); mov(memd_a32[ss, ebp - 0x10], 0x8);     /* mov dword [ebp-0x10], 0x8 */
        l_0x100e_c0fc:
            ii(0x100e_c0fc, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_c101, 5); calld(0x1007_6338, -0x75dce);           /* call 0x10076338 */
            ii(0x100e_c106, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100e_c109, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_c10b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_c10d, 5); calld(0x1007_643c, -0x75cd6);           /* call 0x1007643c */
            ii(0x100e_c112, 2); jmpd(0x100e_c11c, 0x8); goto l_0x100e_c11c; /* jmp 0x100ec11c */
        l_0x100e_c114:
            ii(0x100e_c114, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c117, 5); calld(0x1007_6bf8, -0x75524);           /* call 0x10076bf8 */
        l_0x100e_c11c:
            ii(0x100e_c11c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c11e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c121, 5); calld(0x1013_ad71, 0x4ec4b);            /* call 0x1013ad71 */
            ii(0x100e_c126, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c128, 2); if(jzd(0x100e_c15d, 0x33)) goto l_0x100e_c15d; /* jz 0x100ec15d */
            ii(0x100e_c12a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c12d, 5); calld(0x1007_63a0, -0x75d92);           /* call 0x100763a0 */
            ii(0x100e_c132, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c134, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_c137, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c13b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_c13d, 2); if(jnzd(0x100e_c157, 0x18)) goto l_0x100e_c157; /* jnz 0x100ec157 */
            ii(0x100e_c13f, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c142, 5); calld(0x1007_63a0, -0x75da7);           /* call 0x100763a0 */
            ii(0x100e_c147, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100e_c14a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_c14d, 5); calld(0x1007_1f2e, -0x7a224);           /* call 0x10071f2e */
            ii(0x100e_c152, 1); cwde();                                 /* cwde */
            ii(0x100e_c153, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_c155, 2); if(jld(0x100e_c159, 0x2)) goto l_0x100e_c159; /* jl 0x100ec159 */
        l_0x100e_c157:
            ii(0x100e_c157, 2); jmpd(0x100e_c15b, 0x2); goto l_0x100e_c15b; /* jmp 0x100ec15b */
        l_0x100e_c159:
            ii(0x100e_c159, 2); jmpd(0x100e_c15d, 0x2); goto l_0x100e_c15d; /* jmp 0x100ec15d */
        l_0x100e_c15b:
            ii(0x100e_c15b, 2); jmpd(0x100e_c114, -0x49); goto l_0x100e_c114; /* jmp 0x100ec114 */
        l_0x100e_c15d:
            ii(0x100e_c15d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c15f, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c162, 5); calld(0x1013_ad71, 0x4ec0a);            /* call 0x1013ad71 */
            ii(0x100e_c167, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c169, 2); if(jzd(0x100e_c16f, 0x4)) goto l_0x100e_c16f; /* jz 0x100ec16f */
            ii(0x100e_c16b, 4); add(memd_a32[ss, ebp - 0x10], -0x8 /* 0xf8 */); /* add dword [ebp-0x10], 0xfffffff8 */
        l_0x100e_c16f:
            ii(0x100e_c16f, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100e_c173, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_c175, 2); if(jzd(0x100e_c18b, 0x14)) goto l_0x100e_c18b; /* jz 0x100ec18b */
            ii(0x100e_c177, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_c17c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c180, 5); calld(0x100e_bbf7, -0x58e);             /* call 0x100ebbf7 */
            ii(0x100e_c185, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100e_c189, 2); if(jld(0x100e_c191, 0x6)) goto l_0x100e_c191; /* jl 0x100ec191 */
        l_0x100e_c18b:
            ii(0x100e_c18b, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x100e_c18f, 2); jmpd(0x100e_c195, 0x4); goto l_0x100e_c195; /* jmp 0x100ec195 */
        l_0x100e_c191:
            ii(0x100e_c191, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x100e_c195:
            ii(0x100e_c195, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100e_c198, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100e_c19b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c19d, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c1a0, 5); calld(0x1007_5f6c, -0x76239);           /* call 0x10075f6c */
            ii(0x100e_c1a5, 2); jmpd(0x100e_c1b1, 0xa); goto l_0x100e_c1b1; /* jmp 0x100ec1b1 */
        //  ii(0x100e_c1a7, 10); Недостижимый код.
l_0x100e_c1b1:
            ii(0x100e_c1b1, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100e_c1b4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_c1b6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_c1b7, 1); popd(edi);                              /* pop edi */
            ii(0x100e_c1b8, 1); popd(esi);                              /* pop esi */
            ii(0x100e_c1b9, 1); popd(edx);                              /* pop edx */
            ii(0x100e_c1ba, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_c1bb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_c1bc, 1); retd(); return;                         /* ret */
        }
    }
}