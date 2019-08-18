using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_343a-cbb28edd")]
        public void Method_100c_343a()
        {
            ii(0x100c_343a, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100c_343f, 5); calld(Definitions.sys_check_available_stack_size, 0xa_290e); /* call 0x10165d52 */
            ii(0x100c_3444, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_3445, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_3446, 1); pushd(esi);                             /* push esi */
            ii(0x100c_3447, 1); pushd(edi);                             /* push edi */
            ii(0x100c_3448, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_3449, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_344b, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100c_3451, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_3454, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_3457, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_345a, 5); calld(0x1007_623c, -0x4_d223);          /* call 0x1007623c */
            ii(0x100c_345f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_3462, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_3465, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100c_3468, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_346b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_346e, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_3471, 6); imul(ebx, ebx, 0x247);                  /* imul ebx, ebx, 0x247 */
            ii(0x100c_3477, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100c_347c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_347e, 5); calld(0x100d_fd2c, 0x1_c8a9);           /* call 0x100dfd2c */
            ii(0x100c_3483, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_3486, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_3489, 3); cmp(eax, memd_a32[ss, ebp - 0x10]);     /* cmp eax, [ebp-0x10] */
            ii(0x100c_348c, 2); if(jnzd(0x100c_3497, 0x9)) goto l_0x100c_3497; /* jnz 0x100c3497 */
            ii(0x100c_348e, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100c_3492, 5); jmpd(0x100c_35da, 0x143); goto l_0x100c_35da; /* jmp 0x100c35da */
        l_0x100c_3497:
            ii(0x100c_3497, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_349a, 4); mov(dx, memw_a32[ds, eax + 0xa]);       /* mov dx, [eax+0xa] */
            ii(0x100c_349e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_34a1, 4); cmp(dx, memw_a32[ds, eax + 0x8]);       /* cmp dx, [eax+0x8] */
            ii(0x100c_34a5, 2); if(jnzd(0x100c_34b0, 0x9)) goto l_0x100c_34b0; /* jnz 0x100c34b0 */
            ii(0x100c_34a7, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100c_34ab, 5); jmpd(0x100c_35da, 0x12a); goto l_0x100c_35da; /* jmp 0x100c35da */
        l_0x100c_34b0:
            ii(0x100c_34b0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_34b3, 4); test(memb_a32[ds, eax + 0x15], 0x10);   /* test byte [eax+0x15], 0x10 */
            ii(0x100c_34b7, 2); if(jzd(0x100c_34c2, 0x9)) goto l_0x100c_34c2; /* jz 0x100c34c2 */
            ii(0x100c_34b9, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100c_34bd, 5); jmpd(0x100c_35da, 0x118); goto l_0x100c_35da; /* jmp 0x100c35da */
        l_0x100c_34c2:
            ii(0x100c_34c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_34c5, 5); cmp(memw_a32[ds, eax + 0x8], 0x31);     /* cmp word [eax+0x8], 0x31 */
            ii(0x100c_34ca, 2); if(jzd(0x100c_34d6, 0xa)) goto l_0x100c_34d6; /* jz 0x100c34d6 */
            ii(0x100c_34cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_34cf, 5); cmp(memw_a32[ds, eax + 0x8], 0x3d);     /* cmp word [eax+0x8], 0x3d */
            ii(0x100c_34d4, 2); if(jnzd(0x100c_34d8, 0x2)) goto l_0x100c_34d8; /* jnz 0x100c34d8 */
        l_0x100c_34d6:
            ii(0x100c_34d6, 2); jmpd(0x100c_34e2, 0xa); goto l_0x100c_34e2; /* jmp 0x100c34e2 */
        l_0x100c_34d8:
            ii(0x100c_34d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_34db, 5); cmp(memw_a32[ds, eax + 0x8], 0x3e);     /* cmp word [eax+0x8], 0x3e */
            ii(0x100c_34e0, 2); if(jnzd(0x100c_34e4, 0x2)) goto l_0x100c_34e4; /* jnz 0x100c34e4 */
        l_0x100c_34e2:
            ii(0x100c_34e2, 2); jmpd(0x100c_34ee, 0xa); goto l_0x100c_34ee; /* jmp 0x100c34ee */
        l_0x100c_34e4:
            ii(0x100c_34e4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_34e7, 5); cmp(memw_a32[ds, eax + 0x8], 0x38);     /* cmp word [eax+0x8], 0x38 */
            ii(0x100c_34ec, 2); if(jnzd(0x100c_34f7, 0x9)) goto l_0x100c_34f7; /* jnz 0x100c34f7 */
        l_0x100c_34ee:
            ii(0x100c_34ee, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100c_34f2, 5); jmpd(0x100c_35da, 0xe3); goto l_0x100c_35da; /* jmp 0x100c35da */
        l_0x100c_34f7:
            ii(0x100c_34f7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_34fa, 4); mov(dx, memw_a32[ds, eax + 0x12]);      /* mov dx, [eax+0x12] */
            ii(0x100c_34fe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_3501, 4); cmp(dx, memw_a32[ds, eax + 0x12]);      /* cmp dx, [eax+0x12] */
            ii(0x100c_3505, 2); if(jged(0x100c_3510, 0x9)) goto l_0x100c_3510; /* jge 0x100c3510 */
            ii(0x100c_3507, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_350b, 5); jmpd(0x100c_35da, 0xca); goto l_0x100c_35da; /* jmp 0x100c35da */
        l_0x100c_3510:
            ii(0x100c_3510, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_3513, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_3516, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_3519, 3); imul(edx, eax, 0xd);                    /* imul edx, eax, 0xd */
            ii(0x100c_351c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_351f, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_3522, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_3525, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x100c_3528, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_352a, 2); if(jged(0x100c_3535, 0x9)) goto l_0x100c_3535; /* jge 0x100c3535 */
            ii(0x100c_352c, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_3530, 5); jmpd(0x100c_35da, 0xa5); goto l_0x100c_35da; /* jmp 0x100c35da */
        l_0x100c_3535:
            ii(0x100c_3535, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_3538, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100c_353b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_353e, 3); imul(edx, eax, 0xc);                    /* imul edx, eax, 0xc */
            ii(0x100c_3541, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_3544, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100c_3547, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_354a, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x100c_354d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_354f, 2); if(jged(0x100c_355a, 0x9)) goto l_0x100c_355a; /* jge 0x100c355a */
            ii(0x100c_3551, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_3555, 5); jmpd(0x100c_35da, 0x80); goto l_0x100c_35da; /* jmp 0x100c35da */
        l_0x100c_355a:
            ii(0x100c_355a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_355d, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100c_3560, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_3563, 3); imul(edx, eax, 0xd);                    /* imul edx, eax, 0xd */
            ii(0x100c_3566, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_3569, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100c_356c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_356f, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x100c_3572, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_3574, 2); if(jged(0x100c_357c, 0x6)) goto l_0x100c_357c; /* jge 0x100c357c */
            ii(0x100c_3576, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_357a, 2); jmpd(0x100c_35da, 0x5e); goto l_0x100c_35da; /* jmp 0x100c35da */
        l_0x100c_357c:
            ii(0x100c_357c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_357f, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100c_3582, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_3585, 3); imul(edx, eax, 0xd);                    /* imul edx, eax, 0xd */
            ii(0x100c_3588, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_358b, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100c_358e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_3591, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x100c_3594, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_3596, 2); if(jged(0x100c_359e, 0x6)) goto l_0x100c_359e; /* jge 0x100c359e */
            ii(0x100c_3598, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_359c, 2); jmpd(0x100c_35da, 0x3c); goto l_0x100c_35da; /* jmp 0x100c35da */
        l_0x100c_359e:
            ii(0x100c_359e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_35a1, 4); mov(dx, memw_a32[ds, eax + 0x14]);      /* mov dx, [eax+0x14] */
            ii(0x100c_35a5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_35a8, 4); cmp(dx, memw_a32[ds, eax + 0x14]);      /* cmp dx, [eax+0x14] */
            ii(0x100c_35ac, 2); if(jged(0x100c_35b4, 0x6)) goto l_0x100c_35b4; /* jge 0x100c35b4 */
            ii(0x100c_35ae, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_35b2, 2); jmpd(0x100c_35da, 0x26); goto l_0x100c_35da; /* jmp 0x100c35da */
        l_0x100c_35b4:
            ii(0x100c_35b4, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_35b7, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x100c_35ba, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_35bd, 3); imul(edx, eax, 0xc);                    /* imul edx, eax, 0xc */
            ii(0x100c_35c0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_35c3, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x100c_35c6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_35c9, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x100c_35cc, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_35ce, 2); if(jged(0x100c_35d6, 0x6)) goto l_0x100c_35d6; /* jge 0x100c35d6 */
            ii(0x100c_35d0, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_35d4, 2); jmpd(0x100c_35da, 0x4); goto l_0x100c_35da; /* jmp 0x100c35da */
        l_0x100c_35d6:
            ii(0x100c_35d6, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x100c_35da:
            ii(0x100c_35da, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100c_35dd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_35df, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_35e0, 1); popd(edi);                              /* pop edi */
            ii(0x100c_35e1, 1); popd(esi);                              /* pop esi */
            ii(0x100c_35e2, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_35e3, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_35e4, 1); retd(); return;                         /* ret */
        }
    }
}
