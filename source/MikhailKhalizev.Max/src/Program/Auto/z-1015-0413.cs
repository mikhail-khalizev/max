using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("997fd25c-abf7-4d35-85fd-85a6fec752aa")]
        public void Method_1015_0413()
        {
            ii(0x1015_0413, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1015_0418, 5); calld(Definitions.sys_check_available_stack_size, 0x1_5935); /* call 0x10165d52 */
            ii(0x1015_041d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_041e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_041f, 1); pushd(edx);                             /* push edx */
            ii(0x1015_0420, 1); pushd(esi);                             /* push esi */
            ii(0x1015_0421, 1); pushd(edi);                             /* push edi */
            ii(0x1015_0422, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_0423, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_0425, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1015_042b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_042e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0431, 4); mov(memb_a32[ds, eax + 0x7b], 0);       /* mov byte [eax+0x7b], 0x0 */
            ii(0x1015_0435, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0438, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_043c, 2); if(jnzd(0x1015_0447, 0x9)) goto l_0x1015_0447; /* jnz 0x10150447 */
            ii(0x1015_043e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0441, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1015_0445, 2); if(jnzd(0x1015_044c, 0x5)) goto l_0x1015_044c; /* jnz 0x1015044c */
        l_0x1015_0447:
            ii(0x1015_0447, 5); jmpd(0x1015_0523, 0xd7); goto l_0x1015_0523; /* jmp 0x10150523 */
        l_0x1015_044c:
            ii(0x1015_044c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_044f, 4); test(memb_a32[ds, eax + 0x13], 0x1);    /* test byte [eax+0x13], 0x1 */
            ii(0x1015_0453, 6); if(jzd(0x1015_0523, 0xca)) goto l_0x1015_0523; /* jz 0x10150523 */
            ii(0x1015_0459, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_045c, 3); mov(ebx, memd_a32[ds, eax + 0x50]);     /* mov ebx, [eax+0x50] */
            ii(0x1015_045f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_0462, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0465, 3); mov(al, memb_a32[ds, eax + 0x45]);      /* mov al, [eax+0x45] */
            ii(0x1015_0468, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_046a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_046d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0470, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_0473, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_0476, 5); calld(0x100d_4c69, -0x7_b812);          /* call 0x100d4c69 */
            ii(0x1015_047b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_047e, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1015_0482, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0485, 3); mov(eax, memd_a32[ds, eax + 0x76]);     /* mov eax, [eax+0x76] */
            ii(0x1015_0488, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_048b, 5); calld(Definitions.my_min, -0xc_6d0c);   /* call 0x10089784 */
            ii(0x1015_0490, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_0492, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0495, 4); mov(memw_a32[ds, eax + 0x78], dx);      /* mov [eax+0x78], dx */
            ii(0x1015_0499, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_049c, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_049f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_04a4, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_04aa, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1015_04b0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_04b5, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1015_04b8, 2); if(jnzd(0x1015_04c9, 0xf)) goto l_0x1015_04c9; /* jnz 0x101504c9 */
            ii(0x1015_04ba, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1015_04bf, 5); calld(0x1007_5fdc, -0xd_a4e8);          /* call 0x10075fdc */
            ii(0x1015_04c4, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1015_04c7, 2); if(jged(0x1015_04cb, 0x2)) goto l_0x1015_04cb; /* jge 0x101504cb */
        l_0x1015_04c9:
            ii(0x1015_04c9, 2); jmpd(0x1015_0503, 0x38); goto l_0x1015_0503; /* jmp 0x10150503 */
        l_0x1015_04cb:
            ii(0x1015_04cb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_04cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_04d0, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_04d3, 5); calld(0x1008_b228, -0xc_52b0);          /* call 0x1008b228 */
            ii(0x1015_04d8, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1015_04db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_04de, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_04e1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_04e6, 6); imul(ebx, eax, 0x247);                  /* imul ebx, eax, 0x247 */
            ii(0x1015_04ec, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1015_04f1, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_04f3, 5); calld(0x100d_fd2c, -0x7_07cc);          /* call 0x100dfd2c */
            ii(0x1015_04f8, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_04fb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_04fe, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_0501, 2); if(jled(0x1015_0523, 0x20)) goto l_0x1015_0523; /* jle 0x10150523 */
        l_0x1015_0503:
            ii(0x1015_0503, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0506, 3); mov(edx, memd_a32[ds, eax + 0x76]);     /* mov edx, [eax+0x76] */
            ii(0x1015_0509, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_050c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_050f, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_0512, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_0515, 5); calld(0x1007_1e00, -0xd_e71a);          /* call 0x10071e00 */
            ii(0x1015_051a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_051c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_051f, 4); sub(memw_a32[ds, eax + 0x52], dx);      /* sub [eax+0x52], dx */
        l_0x1015_0523:
            ii(0x1015_0523, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0526, 5); cmp(memw_a32[ds, eax + 0x8], 0);        /* cmp word [eax+0x8], 0x0 */
            ii(0x1015_052b, 2); if(jnzd(0x1015_0536, 0x9)) goto l_0x1015_0536; /* jnz 0x10150536 */
            ii(0x1015_052d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0530, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x1015_0534, 2); if(jzd(0x1015_053b, 0x5)) goto l_0x1015_053b; /* jz 0x1015053b */
        l_0x1015_0536:
            ii(0x1015_0536, 5); jmpd(0x1015_05c4, 0x89); goto l_0x1015_05c4; /* jmp 0x101505c4 */
        l_0x1015_053b:
            ii(0x1015_053b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_053e, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_0541, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_0546, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_054c, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1015_0552, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_0555, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_0558, 5); calld(0x100c_b67c, -0x8_4ee1);          /* call 0x100cb67c */
            ii(0x1015_055d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_0560, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0563, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_0566, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_0569, 5); calld(0x1007_2073, -0xd_e4fb);          /* call 0x10072073 */
            ii(0x1015_056e, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_0571, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_0574, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_0577, 5); calld(0x100c_b60c, -0x8_4f70);          /* call 0x100cb60c */
            ii(0x1015_057c, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_0580, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_0582, 2); if(jnzd(0x1015_0597, 0x13)) goto l_0x1015_0597; /* jnz 0x10150597 */
            ii(0x1015_0584, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0587, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_0589, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_058c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_058e, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_0593, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_0595, 2); if(jzd(0x1015_0599, 0x2)) goto l_0x1015_0599; /* jz 0x10150599 */
        l_0x1015_0597:
            ii(0x1015_0597, 2); jmpd(0x1015_05a6, 0xd); goto l_0x1015_05a6; /* jmp 0x101505a6 */
        l_0x1015_0599:
            ii(0x1015_0599, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_059c, 5); calld(0x100c_b67c, -0x8_4f25);          /* call 0x100cb67c */
            ii(0x1015_05a1, 1); cwde();                                 /* cwde */
            ii(0x1015_05a2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_05a4, 2); if(jgd(0x1015_05a8, 0x2)) goto l_0x1015_05a8; /* jg 0x101505a8 */
        l_0x1015_05a6:
            ii(0x1015_05a6, 2); jmpd(0x1015_05c4, 0x1c); goto l_0x1015_05c4; /* jmp 0x101505c4 */
        l_0x1015_05a8:
            ii(0x1015_05a8, 5); calld(0x100d_5470, -0x7_b13d);          /* call 0x100d5470 */
            ii(0x1015_05ad, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1015_05b0, 5); mov(ebx, 0x45d);                        /* mov ebx, 0x45d */
            ii(0x1015_05b5, 5); mov(edx, 0x45c);                        /* mov edx, 0x45c */
            ii(0x1015_05ba, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_05bf, 5); calld(0x1013_daea, -0x1_2ada);          /* call 0x1013daea */
        l_0x1015_05c4:
            ii(0x1015_05c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_05c7, 5); cmp(memw_a32[ds, eax + 0x8], 0x1e);     /* cmp word [eax+0x8], 0x1e */
            ii(0x1015_05cc, 2); if(jnzd(0x1015_05d7, 0x9)) goto l_0x1015_05d7; /* jnz 0x101505d7 */
            ii(0x1015_05ce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_05d1, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x1015_05d5, 2); if(jzd(0x1015_05dc, 0x5)) goto l_0x1015_05dc; /* jz 0x101505dc */
        l_0x1015_05d7:
            ii(0x1015_05d7, 5); jmpd(0x1015_066a, 0x8e); goto l_0x1015_066a; /* jmp 0x1015066a */
        l_0x1015_05dc:
            ii(0x1015_05dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_05df, 4); inc(memw_a32[ds, eax + 0x52]);          /* inc word [eax+0x52] */
            ii(0x1015_05e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_05e6, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_05e9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_05ee, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_05f4, 6); inc(memd_a32[ds, eax + 0x101c_a550]);   /* inc dword [eax+0x101ca550] */
            ii(0x1015_05fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_05fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_05ff, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_0602, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_0604, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_0609, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_060b, 2); if(jzd(0x1015_0627, 0x1a)) goto l_0x1015_0627; /* jz 0x10150627 */
            ii(0x1015_060d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0610, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_0613, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_0618, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_061e, 7); cmp(memd_a32[ds, eax + 0x101c_a550], 0x1); /* cmp dword [eax+0x101ca550], 0x1 */
            ii(0x1015_0625, 2); if(jzd(0x1015_0629, 0x2)) goto l_0x1015_0629; /* jz 0x10150629 */
        l_0x1015_0627:
            ii(0x1015_0627, 2); jmpd(0x1015_066a, 0x41); goto l_0x1015_066a; /* jmp 0x1015066a */
        l_0x1015_0629:
            ii(0x1015_0629, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x1015_0630, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0633, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_0636, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_0638, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1015_063b, 1); inc(edx);                               /* inc edx */
            ii(0x1015_063c, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1015_063f, 5); add(eax, 0x43b);                        /* add eax, 0x43b */
            ii(0x1015_0644, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_0647, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_064a, 3); add(eax, memd_a32[ss, ebp - 0x14]);     /* add eax, [ebp-0x14] */
            ii(0x1015_064d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_0650, 5); calld(0x100d_5470, -0x7_b1e5);          /* call 0x100d5470 */
            ii(0x1015_0655, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1015_0658, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x1015_065c, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1015_0660, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_0665, 5); calld(0x1013_daea, -0x1_2b80);          /* call 0x1013daea */
        l_0x1015_066a:
            ii(0x1015_066a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_066d, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0670, 5); calld(0x1007_6730, -0xd_9f45);          /* call 0x10076730 */
            ii(0x1015_0675, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1015_0678, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_067b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_067d, 6); if(jzd(0x1015_0727, 0xa4)) goto l_0x1015_0727; /* jz 0x10150727 */
            ii(0x1015_0683, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0686, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0689, 5); calld(0x1007_6730, -0xd_9f5e);          /* call 0x10076730 */
            ii(0x1015_068e, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x1015_0691, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_0694, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0697, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1015_069a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_069f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_06a1, 2); if(jled(0x1015_06f3, 0x50)) goto l_0x1015_06f3; /* jle 0x101506f3 */
            ii(0x1015_06a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_06a6, 3); mov(dl, memb_a32[ds, eax + 0x54]);      /* mov dl, [eax+0x54] */
            ii(0x1015_06a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_06ac, 3); mov(memb_a32[ds, eax + 0x50], dl);      /* mov [eax+0x50], dl */
            ii(0x1015_06af, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_06b4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_06b7, 5); calld(0x1007_6d98, -0xd_9924);          /* call 0x10076d98 */
            ii(0x1015_06bc, 2); test(al, al);                           /* test al, al */
            ii(0x1015_06be, 2); if(jzd(0x1015_06d3, 0x13)) goto l_0x1015_06d3; /* jz 0x101506d3 */
            ii(0x1015_06c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_06c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_06c5, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_06c8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_06ca, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_06cf, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_06d1, 2); if(jzd(0x1015_06d5, 0x2)) goto l_0x1015_06d5; /* jz 0x101506d5 */
        l_0x1015_06d3:
            ii(0x1015_06d3, 2); jmpd(0x1015_06f1, 0x1c); goto l_0x1015_06f1; /* jmp 0x101506f1 */
        l_0x1015_06d5:
            ii(0x1015_06d5, 5); calld(0x100d_5470, -0x7_b26a);          /* call 0x100d5470 */
            ii(0x1015_06da, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1015_06dd, 5); mov(ebx, 0x412);                        /* mov ebx, 0x412 */
            ii(0x1015_06e2, 5); mov(edx, 0x40f);                        /* mov edx, 0x40f */
            ii(0x1015_06e7, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_06ec, 5); calld(0x1013_daea, -0x1_2c07);          /* call 0x1013daea */
        l_0x1015_06f1:
            ii(0x1015_06f1, 2); jmpd(0x1015_0727, 0x34); goto l_0x1015_0727; /* jmp 0x10150727 */
        l_0x1015_06f3:
            ii(0x1015_06f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_06f6, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_06f9, 5); calld(0x1007_6730, -0xd_9fce);          /* call 0x10076730 */
            ii(0x1015_06fe, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x1015_0701, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_0704, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0707, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x1015_070a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_070f, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1015_0711, 2); if(jzd(0x1015_0727, 0x14)) goto l_0x1015_0727; /* jz 0x10150727 */
            ii(0x1015_0713, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0716, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0719, 5); calld(0x1007_6730, -0xd_9fee);          /* call 0x10076730 */
            ii(0x1015_071e, 3); mov(dl, memb_a32[ds, eax + 0x14]);      /* mov dl, [eax+0x14] */
            ii(0x1015_0721, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0724, 3); mov(memb_a32[ds, eax + 0x50], dl);      /* mov [eax+0x50], dl */
        l_0x1015_0727:
            ii(0x1015_0727, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_072a, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_072d, 5); calld(0x1007_6730, -0xd_a002);          /* call 0x10076730 */
            ii(0x1015_0732, 3); mov(dl, memb_a32[ds, eax + 0x10]);      /* mov dl, [eax+0x10] */
            ii(0x1015_0735, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0738, 3); mov(memb_a32[ds, eax + 0x4e], dl);      /* mov [eax+0x4e], dl */
            ii(0x1015_073b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_073e, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1015_0741, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_0746, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_0748, 2); if(jled(0x1015_0772, 0x28)) goto l_0x1015_0772; /* jle 0x10150772 */
            ii(0x1015_074a, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1015_0751, 2); jmpd(0x1015_0759, 0x6); goto l_0x1015_0759; /* jmp 0x10150759 */
        l_0x1015_0753:
            ii(0x1015_0753, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_0756, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x1015_0759:
            ii(0x1015_0759, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1015_075d, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1015_0760, 2); if(jged(0x1015_0772, 0x10)) goto l_0x1015_0772; /* jge 0x10150772 */
            ii(0x1015_0762, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1015_0766, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1015_0769, 7); mov(memb_a32[ds, eax + 0xb0], 0);       /* mov byte [eax+0xb0], 0x0 */
            ii(0x1015_0770, 2); jmpd(0x1015_0753, -0x1f); goto l_0x1015_0753; /* jmp 0x10150753 */
        l_0x1015_0772:
            ii(0x1015_0772, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0775, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1015_0779, 2); if(jzd(0x1015_078f, 0x14)) goto l_0x1015_078f; /* jz 0x1015078f */
            ii(0x1015_077b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_077e, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1015_0782, 2); if(jnzd(0x1015_078d, 0x9)) goto l_0x1015_078d; /* jnz 0x1015078d */
            ii(0x1015_0784, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0787, 4); cmp(memb_a32[ds, eax + 0x3f], 0x1a);    /* cmp byte [eax+0x3f], 0x1a */
            ii(0x1015_078b, 2); if(jzd(0x1015_078f, 0x2)) goto l_0x1015_078f; /* jz 0x1015078f */
        l_0x1015_078d:
            ii(0x1015_078d, 2); jmpd(0x1015_079f, 0x10); goto l_0x1015_079f; /* jmp 0x1015079f */
        l_0x1015_078f:
            ii(0x1015_078f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0792, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_0795, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_079a, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1015_079d, 2); if(jnzd(0x1015_07a4, 0x5)) goto l_0x1015_07a4; /* jnz 0x101507a4 */
        l_0x1015_079f:
            ii(0x1015_079f, 5); jmpd(0x1015_083e, 0x9a); goto l_0x1015_083e; /* jmp 0x1015083e */
        l_0x1015_07a4:
            ii(0x1015_07a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_07a7, 3); dec(memb_a32[ds, eax + 0x58]);          /* dec byte [eax+0x58] */
            ii(0x1015_07aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_07ad, 3); mov(al, memb_a32[ds, eax + 0x58]);      /* mov al, [eax+0x58] */
            ii(0x1015_07b0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_07b5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_07b7, 6); if(jgd(0x1015_083e, 0x81)) goto l_0x1015_083e; /* jg 0x1015083e */
            ii(0x1015_07bd, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1015_07c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_07c3, 5); calld(0x1014_edfa, -0x19ce);            /* call 0x1014edfa */
            ii(0x1015_07c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_07cb, 4); mov(memb_a32[ds, eax + 0x58], 0);       /* mov byte [eax+0x58], 0x0 */
            ii(0x1015_07cf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_07d2, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1015_07d6, 2); if(jnzd(0x1015_07e8, 0x10)) goto l_0x1015_07e8; /* jnz 0x101507e8 */
            ii(0x1015_07d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_07db, 4); mov(memb_a32[ds, eax + 0x3f], 0);       /* mov byte [eax+0x3f], 0x0 */
            ii(0x1015_07df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_07e2, 4); mov(memb_a32[ds, eax + 0x40], 0x1);     /* mov byte [eax+0x40], 0x1 */
            ii(0x1015_07e6, 2); jmpd(0x1015_0834, 0x4c); goto l_0x1015_0834; /* jmp 0x10150834 */
        l_0x1015_07e8:
            ii(0x1015_07e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_07eb, 5); calld(0x1014_f08b, -0x1765);            /* call 0x1014f08b */
            ii(0x1015_07f0, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_07f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_07f8, 5); calld(0x1007_1838, -0xd_efc5);          /* call 0x10071838 */
            ii(0x1015_07fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_07ff, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_0802, 5); calld(0x1007_6600, -0xd_a207);          /* call 0x10076600 */
            ii(0x1015_0807, 5); calld(0x1007_1838, -0xd_efd4);          /* call 0x10071838 */
            ii(0x1015_080c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_080f, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_0812, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_0817, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_081d, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1015_0823, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_0828, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_082b, 2); if(jnzd(0x1015_0834, 0x7)) goto l_0x1015_0834; /* jnz 0x10150834 */
            ii(0x1015_082d, 7); mov(memb_a32[ds, 0x101c_391b], 0x1);    /* mov byte [0x101c391b], 0x1 */
        l_0x1015_0834:
            ii(0x1015_0834, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_0836, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_0839, 5); calld(0x1007_5f2c, -0xd_a912);          /* call 0x10075f2c */
        l_0x1015_083e:
            ii(0x1015_083e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0841, 4); cmp(memb_a32[ds, eax + 0x3e], 0x2);     /* cmp byte [eax+0x3e], 0x2 */
            ii(0x1015_0845, 2); if(jnzd(0x1015_084e, 0x7)) goto l_0x1015_084e; /* jnz 0x1015084e */
            ii(0x1015_0847, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_084a, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
        l_0x1015_084e:
            ii(0x1015_084e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_0850, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0853, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_0856, 5); calld(0x1013_ad71, -0x1_5aea);          /* call 0x1013ad71 */
            ii(0x1015_085b, 2); test(al, al);                           /* test al, al */
            ii(0x1015_085d, 2); if(jzd(0x1015_0874, 0x15)) goto l_0x1015_0874; /* jz 0x10150874 */
            ii(0x1015_085f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0862, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_0865, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_0868, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_086b, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0); /* cmp byte [eax+0x101c81d5], 0x0 */
            ii(0x1015_0872, 2); if(jnzd(0x1015_0879, 0x5)) goto l_0x1015_0879; /* jnz 0x10150879 */
        l_0x1015_0874:
            ii(0x1015_0874, 5); jmpd(0x1015_099d, 0x124); goto l_0x1015_099d; /* jmp 0x1015099d */
        l_0x1015_0879:
            ii(0x1015_0879, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_087c, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_087f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_0882, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_0885, 6); mov(al, memb_a32[ds, eax + 0x101c_81d5]); /* mov al, [eax+0x101c81d5] */
            ii(0x1015_088b, 3); mov(memb_a32[ss, ebp - 0x28], al);      /* mov [ebp-0x28], al */
            ii(0x1015_088e, 5); jmpd(0x1015_0973, 0xe0); goto l_0x1015_0973; /* jmp 0x10150973 */
        l_0x1015_0893:
            ii(0x1015_0893, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0896, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0899, 5); calld(0x1007_6730, -0xd_a16e);          /* call 0x10076730 */
            ii(0x1015_089e, 3); mov(edx, memd_a32[ds, eax + 0x17]);     /* mov edx, [eax+0x17] */
            ii(0x1015_08a1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_08a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_08a7, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_08aa, 5); calld(0x1007_6884, -0xd_a02b);          /* call 0x10076884 */
            ii(0x1015_08af, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_08b2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_08b5, 5); calld(Definitions.my_min, -0xc_7136);   /* call 0x10089784 */
            ii(0x1015_08ba, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_08bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_08bf, 4); mov(memw_a32[ds, eax + 0x52], dx);      /* mov [eax+0x52], dx */
            ii(0x1015_08c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_08c6, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_08c9, 5); calld(0x1007_6884, -0xd_a04a);          /* call 0x10076884 */
            ii(0x1015_08ce, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_08d1, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x1015_08d5, 4); sub(memw_a32[ds, eax + 0x8], dx);       /* sub [eax+0x8], dx */
            ii(0x1015_08d9, 5); jmpd(0x1015_099d, 0xbf); goto l_0x1015_099d; /* jmp 0x1015099d */
        l_0x1015_08de:
            ii(0x1015_08de, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_08e1, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_08e4, 5); calld(0x1007_6730, -0xd_a1b9);          /* call 0x10076730 */
            ii(0x1015_08e9, 3); mov(edx, memd_a32[ds, eax + 0x17]);     /* mov edx, [eax+0x17] */
            ii(0x1015_08ec, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_08ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_08f2, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_08f5, 5); calld(0x1007_6884, -0xd_a076);          /* call 0x10076884 */
            ii(0x1015_08fa, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1015_08fd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_0900, 5); calld(Definitions.my_min, -0xc_7181);   /* call 0x10089784 */
            ii(0x1015_0905, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_0907, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_090a, 4); mov(memw_a32[ds, eax + 0x52], dx);      /* mov [eax+0x52], dx */
            ii(0x1015_090e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0911, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_0914, 5); calld(0x1007_6884, -0xd_a095);          /* call 0x10076884 */
            ii(0x1015_0919, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_091c, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x1015_0920, 4); sub(memw_a32[ds, eax + 0xa], dx);       /* sub [eax+0xa], dx */
            ii(0x1015_0924, 5); jmpd(0x1015_099d, 0x74); goto l_0x1015_099d; /* jmp 0x1015099d */
        l_0x1015_0929:
            ii(0x1015_0929, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_092c, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_092f, 5); calld(0x1007_6730, -0xd_a204);          /* call 0x10076730 */
            ii(0x1015_0934, 3); mov(edx, memd_a32[ds, eax + 0x17]);     /* mov edx, [eax+0x17] */
            ii(0x1015_0937, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_093a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_093d, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_0940, 5); calld(0x1007_6884, -0xd_a0c1);          /* call 0x10076884 */
            ii(0x1015_0945, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1015_0948, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_094b, 5); calld(Definitions.my_min, -0xc_71cc);   /* call 0x10089784 */
            ii(0x1015_0950, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_0952, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0955, 4); mov(memw_a32[ds, eax + 0x52], dx);      /* mov [eax+0x52], dx */
            ii(0x1015_0959, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_095c, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_095f, 5); calld(0x1007_6884, -0xd_a0e0);          /* call 0x10076884 */
            ii(0x1015_0964, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_0967, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x1015_096b, 4); sub(memw_a32[ds, eax + 0xc], dx);       /* sub [eax+0xc], dx */
            ii(0x1015_096f, 2); jmpd(0x1015_099d, 0x2c); goto l_0x1015_099d; /* jmp 0x1015099d */
        l_0x1015_0971:
            ii(0x1015_0971, 2); jmpd(0x1015_099d, 0x2a); goto l_0x1015_099d; /* jmp 0x1015099d */
        l_0x1015_0973:
            ii(0x1015_0973, 3); mov(al, memb_a32[ss, ebp - 0x28]);      /* mov al, [ebp-0x28] */
            ii(0x1015_0976, 3); mov(memb_a32[ss, ebp - 0x2c], al);      /* mov [ebp-0x2c], al */
            ii(0x1015_0979, 4); cmp(memb_a32[ss, ebp - 0x2c], 0x2);     /* cmp byte [ebp-0x2c], 0x2 */
            ii(0x1015_097d, 2); if(jbd(0x1015_0991, 0x12)) goto l_0x1015_0991; /* jb 0x10150991 */
            ii(0x1015_097f, 4); cmp(memb_a32[ss, ebp - 0x2c], 0x2);     /* cmp byte [ebp-0x2c], 0x2 */
            ii(0x1015_0983, 6); if(jbed(0x1015_08de, -0xab)) goto l_0x1015_08de; /* jbe 0x101508de */
            ii(0x1015_0989, 4); cmp(memb_a32[ss, ebp - 0x2c], 0x3);     /* cmp byte [ebp-0x2c], 0x3 */
            ii(0x1015_098d, 2); if(jzd(0x1015_0929, -0x66)) goto l_0x1015_0929; /* jz 0x10150929 */
            ii(0x1015_098f, 2); jmpd(0x1015_0971, -0x20); goto l_0x1015_0971; /* jmp 0x10150971 */
        l_0x1015_0991:
            ii(0x1015_0991, 4); cmp(memb_a32[ss, ebp - 0x2c], 0x1);     /* cmp byte [ebp-0x2c], 0x1 */
            ii(0x1015_0995, 6); if(jzd(0x1015_0893, -0x108)) goto l_0x1015_0893; /* jz 0x10150893 */
            ii(0x1015_099b, 2); jmpd(0x1015_0971, -0x2c); goto l_0x1015_0971; /* jmp 0x10150971 */
        l_0x1015_099d:
            ii(0x1015_099d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_099f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_09a0, 1); popd(edi);                              /* pop edi */
            ii(0x1015_09a1, 1); popd(esi);                              /* pop esi */
            ii(0x1015_09a2, 1); popd(edx);                              /* pop edx */
            ii(0x1015_09a3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_09a4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_09a5, 1); retd(); return;                         /* ret */
        }
    }
}
