using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a8561d21-b86c-44d8-93ab-5c822d5b9b6e")]
        public void Method_100a_346a()
        {
            ii(0x100a_346a, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x100a_346f, 5); calld(Definitions.sys_check_available_stack_size, 0xc28de); /* call 0x10165d52 */
            ii(0x100a_3474, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3475, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3476, 1); pushd(edi);                             /* push edi */
            ii(0x100a_3477, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_3478, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_347a, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100a_3480, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_3483, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_3486, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100a_3489, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_348d, 2); if(jzd(0x100a_349b, 0xc)) goto l_0x100a_349b; /* jz 0x100a349b */
            ii(0x100a_348f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3492, 5); calld(0x1008_aa80, -0x18a17);           /* call 0x1008aa80 */
            ii(0x100a_3497, 2); test(al, 0x1);                          /* test al, 0x1 */
            ii(0x100a_3499, 2); if(jzd(0x100a_34a4, 0x9)) goto l_0x100a_34a4; /* jz 0x100a34a4 */
        l_0x100a_349b:
            ii(0x100a_349b, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_349f, 5); jmpd(0x100a_3667, 0x1c3); goto l_0x100a_3667; /* jmp 0x100a3667 */
        l_0x100a_34a4:
            ii(0x100a_34a4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_34a7, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100a_34aa, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_34af, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_34b1, 2); if(jnzd(0x100a_34bc, 0x9)) goto l_0x100a_34bc; /* jnz 0x100a34bc */
            ii(0x100a_34b3, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_34b7, 5); jmpd(0x100a_3667, 0x1ab); goto l_0x100a_3667; /* jmp 0x100a3667 */
        l_0x100a_34bc:
            ii(0x100a_34bc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_34bf, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x100a_34c2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_34c7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_34c9, 2); if(jnzd(0x100a_34dd, 0x12)) goto l_0x100a_34dd; /* jnz 0x100a34dd */
            ii(0x100a_34cb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_34ce, 5); calld(0x1007_623c, -0x2d297);           /* call 0x1007623c */
            ii(0x100a_34d3, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100a_34d6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_34d9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_34db, 2); if(jgd(0x100a_34df, 0x2)) goto l_0x100a_34df; /* jg 0x100a34df */
        l_0x100a_34dd:
            ii(0x100a_34dd, 2); jmpd(0x100a_34e3, 0x4); goto l_0x100a_34e3; /* jmp 0x100a34e3 */
        l_0x100a_34df:
            ii(0x100a_34df, 4); mov(memb_a32[ss, ebp - 0x4], 0x3);      /* mov byte [ebp-0x4], 0x3 */
        l_0x100a_34e3:
            ii(0x100a_34e3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_34e6, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100a_34e9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_34ee, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_34f0, 2); if(jnzd(0x100a_3500, 0xe)) goto l_0x100a_3500; /* jnz 0x100a3500 */
            ii(0x100a_34f2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_34f5, 5); calld(0x1007_623c, -0x2d2be);           /* call 0x1007623c */
            ii(0x100a_34fa, 4); cmp(memb_a32[ds, eax + 0x16], 0);       /* cmp byte [eax+0x16], 0x0 */
            ii(0x100a_34fe, 2); if(jnzd(0x100a_3502, 0x2)) goto l_0x100a_3502; /* jnz 0x100a3502 */
        l_0x100a_3500:
            ii(0x100a_3500, 2); jmpd(0x100a_3511, 0xf); goto l_0x100a_3511; /* jmp 0x100a3511 */
        l_0x100a_3502:
            ii(0x100a_3502, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100a_3507, 5); calld(0x1007_5fdc, -0x2d530);           /* call 0x10075fdc */
            ii(0x100a_350c, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_350f, 2); if(jged(0x100a_3513, 0x2)) goto l_0x100a_3513; /* jge 0x100a3513 */
        l_0x100a_3511:
            ii(0x100a_3511, 2); jmpd(0x100a_3517, 0x4); goto l_0x100a_3517; /* jmp 0x100a3517 */
        l_0x100a_3513:
            ii(0x100a_3513, 4); mov(memb_a32[ss, ebp - 0x4], 0x3);      /* mov byte [ebp-0x4], 0x3 */
        l_0x100a_3517:
            ii(0x100a_3517, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_351a, 3); mov(ebx, memd_a32[ds, edx + 0x1a]);     /* mov ebx, [edx+0x1a] */
            ii(0x100a_351d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_3520, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_3523, 3); mov(edx, memd_a32[ds, edx + 0x18]);     /* mov edx, [edx+0x18] */
            ii(0x100a_3526, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_3529, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_352c, 5); calld(0x1007_6aac, -0x2ca85);           /* call 0x10076aac */
            ii(0x100a_3531, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_3533, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_3536, 3); mov(al, memb_a32[ds, edx + 0x4d]);      /* mov al, [edx+0x4d] */
            ii(0x100a_3539, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_353c, 4); cmp(memb_a32[ss, ebp - 0x4], 0x3);      /* cmp byte [ebp-0x4], 0x3 */
            ii(0x100a_3540, 2); if(jnzd(0x100a_3549, 0x7)) goto l_0x100a_3549; /* jnz 0x100a3549 */
            ii(0x100a_3542, 7); mov(memd_a32[ss, ebp - 0x18], 0x1);     /* mov dword [ebp-0x18], 0x1 */
        l_0x100a_3549:
            ii(0x100a_3549, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_354b, 1); pushd(eax);                             /* push eax */
            ii(0x100a_354c, 4); movsx(ecx, memb_a32[ss, ebp - 0x4]);    /* movsx ecx, byte [ebp-0x4] */
            ii(0x100a_3550, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100a_3553, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100a_3556, 5); calld(0x1007_5e64, -0x2d6f7);           /* call 0x10075e64 */
            ii(0x100a_355b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_355d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_3560, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3563, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100a_3566, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_356b, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_3571, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x100a_3576, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100a_3578, 5); calld(0x100c_20df, 0x1eb62);            /* call 0x100c20df */
            ii(0x100a_357d, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x100a_3581, 6); if(jld(0x100a_3663, 0xdc)) goto l_0x100a_3663; /* jl 0x100a3663 */
            ii(0x100a_3587, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_358a, 5); calld(0x1007_623c, -0x2d353);           /* call 0x1007623c */
            ii(0x100a_358f, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100a_3592, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_3595, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_3597, 2); if(jled(0x100a_35c9, 0x30)) goto l_0x100a_35c9; /* jle 0x100a35c9 */
            ii(0x100a_3599, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_359c, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100a_359f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_35a4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_35a6, 2); if(jgd(0x100a_35b6, 0xe)) goto l_0x100a_35b6; /* jg 0x100a35b6 */
            ii(0x100a_35a8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_35ab, 5); calld(0x1007_623c, -0x2d374);           /* call 0x1007623c */
            ii(0x100a_35b0, 4); cmp(memb_a32[ds, eax + 0x16], 0);       /* cmp byte [eax+0x16], 0x0 */
            ii(0x100a_35b4, 2); if(jnzd(0x100a_35b8, 0x2)) goto l_0x100a_35b8; /* jnz 0x100a35b8 */
        l_0x100a_35b6:
            ii(0x100a_35b6, 2); jmpd(0x100a_35c7, 0xf); goto l_0x100a_35c7; /* jmp 0x100a35c7 */
        l_0x100a_35b8:
            ii(0x100a_35b8, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100a_35bd, 5); calld(0x1007_5fdc, -0x2d5e6);           /* call 0x10075fdc */
            ii(0x100a_35c2, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_35c5, 2); if(jged(0x100a_35c9, 0x2)) goto l_0x100a_35c9; /* jge 0x100a35c9 */
        l_0x100a_35c7:
            ii(0x100a_35c7, 2); jmpd(0x100a_35cb, 0x2); goto l_0x100a_35cb; /* jmp 0x100a35cb */
        l_0x100a_35c9:
            ii(0x100a_35c9, 2); jmpd(0x100a_35db, 0x10); goto l_0x100a_35db; /* jmp 0x100a35db */
        l_0x100a_35cb:
            ii(0x100a_35cb, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100a_35cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_35d2, 5); calld(0x100a_32c3, -0x314);             /* call 0x100a32c3 */
            ii(0x100a_35d7, 2); test(al, al);                           /* test al, al */
            ii(0x100a_35d9, 2); if(jnzd(0x100a_35dd, 0x2)) goto l_0x100a_35dd; /* jnz 0x100a35dd */
        l_0x100a_35db:
            ii(0x100a_35db, 2); jmpd(0x100a_35f5, 0x18); goto l_0x100a_35f5; /* jmp 0x100a35f5 */
        l_0x100a_35dd:
            ii(0x100a_35dd, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_35e2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_35e7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_35ea, 5); calld(0x100a_b120, 0x7b31);             /* call 0x100ab120 */
            ii(0x100a_35ef, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_35f3, 2); jmpd(0x100a_3667, 0x72); goto l_0x100a_3667; /* jmp 0x100a3667 */
        l_0x100a_35f5:
            ii(0x100a_35f5, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x100a_35fa, 5); calld(Definitions.sys_new, 0xc2801);    /* call 0x10165e00 */
            ii(0x100a_35ff, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_3602, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100a_3605, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100a_3608, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100a_360c, 2); if(jzd(0x100a_362e, 0x20)) goto l_0x100a_362e; /* jz 0x100a362e */
            ii(0x100a_360e, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x100a_3612, 1); pushd(eax);                             /* push eax */
            ii(0x100a_3613, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100a_3615, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100a_3618, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_361b, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100a_361e, 5); calld(0x100b_3060, 0xfa3d);             /* call 0x100b3060 */
            ii(0x100a_3623, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100a_3626, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100a_3629, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100a_362c, 2); jmpd(0x100a_3634, 0x6); goto l_0x100a_3634; /* jmp 0x100a3634 */
        l_0x100a_362e:
            ii(0x100a_362e, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100a_3631, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x100a_3634:
            ii(0x100a_3634, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100a_3637, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_363a, 5); calld(0x1008_b060, -0x185df);           /* call 0x1008b060 */
            ii(0x100a_363f, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_3642, 5); calld(0x1008_af84, -0x186c3);           /* call 0x1008af84 */
            ii(0x100a_3647, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_3649, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_364e, 5); calld(0x100a_4d50, 0x16fd);             /* call 0x100a4d50 */
            ii(0x100a_3653, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_3657, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_3659, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_365c, 5); calld(0x1008_8b7c, -0x1aae5);           /* call 0x10088b7c */
            ii(0x100a_3661, 2); jmpd(0x100a_3667, 0x4); goto l_0x100a_3667; /* jmp 0x100a3667 */
        l_0x100a_3663:
            ii(0x100a_3663, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x100a_3667:
            ii(0x100a_3667, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100a_366a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_366c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_366d, 1); popd(edi);                              /* pop edi */
            ii(0x100a_366e, 1); popd(esi);                              /* pop esi */
            ii(0x100a_366f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_3670, 1); retd(); return;                         /* ret */
        }
    }
}
