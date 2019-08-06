using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("432462c6-33e5-4ce8-9042-f3d38c4a84c9")]
        public void Method_1007_6f5d()
        {
            ii(0x1007_6f5d, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_6f62, 5); calld(Definitions.sys_check_available_stack_size, 0xeedeb); /* call 0x10165d52 */
            ii(0x1007_6f67, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6f68, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6f69, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6f6a, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6f6b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6f6c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6f6e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_6f74, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6f77, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_6f7a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6f7d, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1007_6f80, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_6f85, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_6f87, 2); if(jnzd(0x1007_6f92, 0x9)) goto l_0x1007_6f92; /* jnz 0x10076f92 */
            ii(0x1007_6f89, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_6f8d, 5); jmpd(0x1007_70d6, 0x144); goto l_0x1007_70d6; /* jmp 0x100770d6 */
        l_0x1007_6f92:
            ii(0x1007_6f92, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1007_6f97, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6f9a, 5); calld(0x100a_32c3, 0x2c324);            /* call 0x100a32c3 */
            ii(0x1007_6f9f, 2); test(al, al);                           /* test al, al */
            ii(0x1007_6fa1, 2); if(jzd(0x1007_6fac, 0x9)) goto l_0x1007_6fac; /* jz 0x10076fac */
            ii(0x1007_6fa3, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_6fa7, 5); jmpd(0x1007_70d6, 0x12a); goto l_0x1007_70d6; /* jmp 0x100770d6 */
        l_0x1007_6fac:
            ii(0x1007_6fac, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1007_6fb1, 5); calld(0x1007_6338, -0xc7e);             /* call 0x10076338 */
            ii(0x1007_6fb6, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1007_6fb9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_6fbb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_6fbd, 5); calld(0x1007_64b8, -0xb0a);             /* call 0x100764b8 */
            ii(0x1007_6fc2, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_6fc6, 2); jmpd(0x1007_6fd0, 0x8); goto l_0x1007_6fd0; /* jmp 0x10076fd0 */
        l_0x1007_6fc8:
            ii(0x1007_6fc8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_6fcb, 5); calld(0x1007_6bf8, -0x3d8);             /* call 0x10076bf8 */
        l_0x1007_6fd0:
            ii(0x1007_6fd0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_6fd2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_6fd5, 5); calld(0x1013_ad71, 0xc3d97);            /* call 0x1013ad71 */
            ii(0x1007_6fda, 2); test(al, al);                           /* test al, al */
            ii(0x1007_6fdc, 6); if(jzd(0x1007_709e, 0xbc)) goto l_0x1007_709e; /* jz 0x1007709e */
            ii(0x1007_6fe2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_6fe5, 5); calld(0x1007_63a0, -0xc4a);             /* call 0x100763a0 */
            ii(0x1007_6fea, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_6fed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6ff0, 3); cmp(dl, memb_a32[ds, eax + 0x26]);      /* cmp dl, [eax+0x26] */
            ii(0x1007_6ff3, 2); if(jnzd(0x1007_7011, 0x1c)) goto l_0x1007_7011; /* jnz 0x10077011 */
            ii(0x1007_6ff5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6ff8, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1007_6ffb, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_6ffd, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_7000, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_7003, 5); calld(0x1007_63a0, -0xc68);             /* call 0x100763a0 */
            ii(0x1007_7008, 5); calld(0x1007_6074, -0xf99);             /* call 0x10076074 */
            ii(0x1007_700d, 2); test(al, al);                           /* test al, al */
            ii(0x1007_700f, 2); if(jnzd(0x1007_7013, 0x2)) goto l_0x1007_7013; /* jnz 0x10077013 */
        l_0x1007_7011:
            ii(0x1007_7011, 2); jmpd(0x1007_7034, 0x21); goto l_0x1007_7034; /* jmp 0x10077034 */
        l_0x1007_7013:
            ii(0x1007_7013, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_7016, 5); calld(0x1007_63a0, -0xc7b);             /* call 0x100763a0 */
            ii(0x1007_701b, 5); calld(0x1007_623c, -0xde4);             /* call 0x1007623c */
            ii(0x1007_7020, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7022, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7025, 5); calld(0x1007_623c, -0xdee);             /* call 0x1007623c */
            ii(0x1007_702a, 4); mov(dx, memw_a32[ds, edx + 0x8]);       /* mov dx, [edx+0x8] */
            ii(0x1007_702e, 4); cmp(dx, memw_a32[ds, eax + 0x8]);       /* cmp dx, [eax+0x8] */
            ii(0x1007_7032, 2); if(jgd(0x1007_7036, 0x2)) goto l_0x1007_7036; /* jg 0x10077036 */
        l_0x1007_7034:
            ii(0x1007_7034, 2); jmpd(0x1007_704c, 0x16); goto l_0x1007_704c; /* jmp 0x1007704c */
        l_0x1007_7036:
            ii(0x1007_7036, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_7039, 5); calld(0x1007_636c, -0xcd2);             /* call 0x1007636c */
            ii(0x1007_703e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7040, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_7043, 5); calld(0x1007_4bde, -0x246a);            /* call 0x10074bde */
            ii(0x1007_7048, 2); test(al, al);                           /* test al, al */
            ii(0x1007_704a, 2); if(jnzd(0x1007_704e, 0x2)) goto l_0x1007_704e; /* jnz 0x1007704e */
        l_0x1007_704c:
            ii(0x1007_704c, 2); jmpd(0x1007_7095, 0x47); goto l_0x1007_7095; /* jmp 0x10077095 */
        l_0x1007_704e:
            ii(0x1007_704e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_7051, 5); calld(0x1007_623c, -0xe1a);             /* call 0x1007623c */
            ii(0x1007_7056, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7058, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_705b, 5); calld(0x1007_623c, -0xe24);             /* call 0x1007623c */
            ii(0x1007_7060, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_7062, 4); mov(ax, memw_a32[ds, edx + 0x12]);      /* mov ax, [edx+0x12] */
            ii(0x1007_7066, 4); add(ax, memw_a32[ds, ebx + 0x10]);      /* add ax, [ebx+0x10] */
            ii(0x1007_706a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1007_706d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_7070, 5); calld(0x1007_63a0, -0xcd5);             /* call 0x100763a0 */
            ii(0x1007_7075, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1007_7078, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_707b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_707e, 5); calld(0x1007_63a0, -0xce3);             /* call 0x100763a0 */
            ii(0x1007_7083, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1007_7086, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_7089, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_708c, 5); calld(0x1007_0d68, -0x6329);            /* call 0x10070d68 */
            ii(0x1007_7091, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_7093, 2); if(jnzd(0x1007_7097, 0x2)) goto l_0x1007_7097; /* jnz 0x10077097 */
        l_0x1007_7095:
            ii(0x1007_7095, 2); jmpd(0x1007_7099, 0x2); goto l_0x1007_7099; /* jmp 0x10077099 */
        l_0x1007_7097:
            ii(0x1007_7097, 2); jmpd(0x1007_709e, 0x5); goto l_0x1007_709e; /* jmp 0x1007709e */
        l_0x1007_7099:
            ii(0x1007_7099, 5); jmpd(0x1007_6fc8, -0xd6); goto l_0x1007_6fc8; /* jmp 0x10076fc8 */
        l_0x1007_709e:
            ii(0x1007_709e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_70a0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_70a3, 5); calld(0x1013_ad11, 0xc3c69);            /* call 0x1013ad11 */
            ii(0x1007_70a8, 2); test(al, al);                           /* test al, al */
            ii(0x1007_70aa, 2); if(jzd(0x1007_70bc, 0x10)) goto l_0x1007_70bc; /* jz 0x100770bc */
            ii(0x1007_70ac, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_70b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_70b2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_70b5, 5); calld(0x1007_5f6c, -0x114e);            /* call 0x10075f6c */
            ii(0x1007_70ba, 2); jmpd(0x1007_70d6, 0x1a); goto l_0x1007_70d6; /* jmp 0x100770d6 */
        l_0x1007_70bc:
            ii(0x1007_70bc, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_70c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_70c2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_70c5, 5); calld(0x1007_5f6c, -0x115e);            /* call 0x10075f6c */
            ii(0x1007_70ca, 2); jmpd(0x1007_70d6, 0xa); goto l_0x1007_70d6; /* jmp 0x100770d6 */
        //  ii(0x1007_70cc, 10); Недостижимый код.
        l_0x1007_70d6:
            ii(0x1007_70d6, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1007_70d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_70db, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_70dc, 1); popd(edi);                              /* pop edi */
            ii(0x1007_70dd, 1); popd(esi);                              /* pop esi */
            ii(0x1007_70de, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_70df, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_70e0, 1); retd(); return;                         /* ret */
        }
    }
}
