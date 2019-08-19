using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_227f-8153a243")]
        public void Method_1012_227f()
        {
            ii(0x1012_227f, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1012_2284, 5); calld(Definitions.sys_check_available_stack_size, 0x4_3ac9); /* call 0x10165d52 */
            ii(0x1012_2289, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_228a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_228b, 1); pushd(edx);                             /* push edx */
            ii(0x1012_228c, 1); pushd(esi);                             /* push esi */
            ii(0x1012_228d, 1); pushd(edi);                             /* push edi */
            ii(0x1012_228e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_228f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_2291, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1012_2297, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_229a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_229d, 6); cmp(memw_a32[ds, eax + 0x40], 0x6cd);   /* cmp word [eax+0x40], 0x6cd */
            ii(0x1012_22a3, 2); if(jnzd(0x1012_22ae, 0x9)) goto l_0x1012_22ae; /* jnz 0x101222ae */
            ii(0x1012_22a5, 7); mov(memd_a32[ss, ebp - 0xc], 0x14);     /* mov dword [ebp-0xc], 0x14 */
            ii(0x1012_22ac, 2); jmpd(0x1012_22b5, 0x7); goto l_0x1012_22b5; /* jmp 0x101222b5 */
        l_0x1012_22ae:
            ii(0x1012_22ae, 7); mov(memd_a32[ss, ebp - 0xc], 0xffff_ffec); /* mov dword [ebp-0xc], 0xffffffec */
        l_0x1012_22b5:
            ii(0x1012_22b5, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_22bc, 2); jmpd(0x1012_22c4, 0x6); goto l_0x1012_22c4; /* jmp 0x101222c4 */
        l_0x1012_22be:
            ii(0x1012_22be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_22c1, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1012_22c4:
            ii(0x1012_22c4, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_22c8, 3); cmp(eax, 0x21);                         /* cmp eax, 0x21 */
            ii(0x1012_22cb, 6); if(jaed(0x1012_2455, 0x184)) goto l_0x1012_2455; /* jae 0x10122455 */
            ii(0x1012_22d1, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_22d5, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_22d8, 7); mov(ax, memw_a32[ds, eax + 0x101b_b062]); /* mov ax, [eax+0x101bb062] */
            ii(0x1012_22df, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_22e2, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_22e6, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_22e9, 6); mov(al, memb_a32[ds, eax + 0x101b_b061]); /* mov al, [eax+0x101bb061] */
            ii(0x1012_22ef, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1012_22f2, 4); cmp(memb_a32[ss, ebp - 0x10], 0x40);    /* cmp byte [ebp-0x10], 0x40 */
            ii(0x1012_22f6, 2); if(jnzd(0x1012_2307, 0xf)) goto l_0x1012_2307; /* jnz 0x10122307 */
            ii(0x1012_22f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_22fb, 6); cmp(memw_a32[ds, eax + 0x40], 0x6c1);   /* cmp word [eax+0x40], 0x6c1 */
            ii(0x1012_2301, 6); if(jnzd(0x1012_2450, 0x149)) goto l_0x1012_2450; /* jnz 0x10122450 */
        l_0x1012_2307:
            ii(0x1012_2307, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1012_230b, 3); cmp(eax, 0x19);                         /* cmp eax, 0x19 */
            ii(0x1012_230e, 2); if(jnzd(0x1012_2314, 0x4)) goto l_0x1012_2314; /* jnz 0x10122314 */
            ii(0x1012_2310, 4); add(memd_a32[ss, ebp - 0xc], 0x14);     /* add dword [ebp-0xc], 0x14 */
        l_0x1012_2314:
            ii(0x1012_2314, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_2318, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_231b, 7); cmp(memb_a32[ds, eax + 0x101b_b05c], 0); /* cmp byte [eax+0x101bb05c], 0x0 */
            ii(0x1012_2322, 6); if(jzd(0x1012_241b, 0xf3)) goto l_0x1012_241b; /* jz 0x1012241b */
            ii(0x1012_2328, 4); movsx(eax, memb_a32[ss, ebp - 0x10]);   /* movsx eax, byte [ebp-0x10] */
            ii(0x1012_232c, 5); calld(0x1007_5fdc, -0xa_c355);          /* call 0x10075fdc */
            ii(0x1012_2331, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1012_2335, 3); imul(edx, edx, 0x1c);                   /* imul edx, edx, 0x1c */
            ii(0x1012_2338, 7); mov(memw_a32[ds, edx + 0x101b_b074], ax); /* mov [edx+0x101bb074], ax */
            ii(0x1012_233f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_2343, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2346, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1012_234a, 3); imul(edx, edx, 0x1c);                   /* imul edx, edx, 0x1c */
            ii(0x1012_234d, 7); mov(ax, memw_a32[ds, eax + 0x101b_b074]); /* mov ax, [eax+0x101bb074] */
            ii(0x1012_2354, 7); mov(memw_a32[ds, edx + 0x101b_b076], ax); /* mov [edx+0x101bb076], ax */
            ii(0x1012_235b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_235f, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2362, 6); mov(al, memb_a32[ds, eax + 0x101b_b05c]); /* mov al, [eax+0x101bb05c] */
            ii(0x1012_2368, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1012_236b, 5); jmpd(0x1012_23fc, 0x8c); goto l_0x1012_23fc; /* jmp 0x101223fc */
        //  ii(0x1012_2370, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
        //  ii(0x1012_2374, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
        //  ii(0x1012_2378, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
        //  ii(0x1012_237c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
        //  ii(0x1012_237f, 5); calld(0x1012_19cb, -0x9b9);             /* call 0x101219cb */
        //  ii(0x1012_2384, 5); jmpd(0x1012_2419, 0x90); goto l_0x1012_2419; /* jmp 0x10122419 */
        //  ii(0x1012_2389, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
        //  ii(0x1012_238d, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
        //  ii(0x1012_2391, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
        //  ii(0x1012_2395, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
        //  ii(0x1012_2398, 5); calld(0x1012_1b8d, -0x810);             /* call 0x10121b8d */
        //  ii(0x1012_239d, 6); calld_abs(memd_a32[ds, 0x101b_ddf0]);   /* call dword [0x101bddf0] */
        //  ii(0x1012_23a3, 5); add(eax, 0x3);                          /* add eax, 0x3 */
        //  ii(0x1012_23a8, 5); mov(edx, 0x14);                         /* mov edx, 0x14 */
        //  ii(0x1012_23ad, 2); sub(edx, eax);                          /* sub edx, eax */
        //  ii(0x1012_23af, 2); mov(eax, edx);                          /* mov eax, edx */
        //  ii(0x1012_23b1, 3); sub(memd_a32[ss, ebp - 0xc], eax);      /* sub [ebp-0xc], eax */
        //  ii(0x1012_23b4, 2); jmpd(0x1012_2419, 0x63); goto l_0x1012_2419; /* jmp 0x10122419 */
        //  ii(0x1012_23b6, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
        //  ii(0x1012_23ba, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
        //  ii(0x1012_23be, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
        //  ii(0x1012_23c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
        //  ii(0x1012_23c5, 5); calld(0x1012_206a, -0x360);             /* call 0x1012206a */
        //  ii(0x1012_23ca, 2); jmpd(0x1012_2419, 0x4d); goto l_0x1012_2419; /* jmp 0x10122419 */
        //  ii(0x1012_23cc, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
        //  ii(0x1012_23d0, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
        //  ii(0x1012_23d4, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
        //  ii(0x1012_23d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
        //  ii(0x1012_23db, 5); calld(0x1012_1d38, -0x6a8);             /* call 0x10121d38 */
        //  ii(0x1012_23e0, 2); jmpd(0x1012_2419, 0x37); goto l_0x1012_2419; /* jmp 0x10122419 */
        l_0x1012_23e2:
            ii(0x1012_23e2, 2); jmpd(0x1012_2419, 0x35); goto l_0x1012_2419; /* jmp 0x10122419 */
        //  ii(0x1012_23e4, 2); mov(dh, 0x23);                          /* mov dh, 0x23 */
        //  ii(0x1012_23e6, 2); adc(dl, memb_a32[ds, eax]);             /* adc dl, [eax] */
        //  ii(0x1012_23e8, 1); int3();                                 /* int3 */
        //  ii(0x1012_23e9, 2); and(edx, memd_a32[ds, edx]);            /* and edx, [edx] */
        //  ii(0x1012_23eb, 2); adc(ah, cl);                            /* adc ah, cl */
        //  ii(0x1012_23ed, 2); and(edx, memd_a32[ds, edx]);            /* and edx, [edx] */
        //  ii(0x1012_23ef, 2); adc(ah, cl);                            /* adc ah, cl */
        //  ii(0x1012_23f1, 2); and(edx, memd_a32[ds, edx]);            /* and edx, [edx] */
        //  ii(0x1012_23f3, 3); adc(memb_a32[ds, eax + 0x23], dh);      /* adc [eax+0x23], dh */
        //  ii(0x1012_23f6, 2); adc(dl, memb_a32[ds, eax]);             /* adc dl, [eax] */
        //  ii(0x1012_23f8, 2); mov(memd_a32[ds, ebx], esp);            /* mov [ebx], esp */
        //  ii(0x1012_23fa, 2); adc(dl, memb_a32[ds, eax]);             /* adc dl, [eax] */
        l_0x1012_23fc:
            ii(0x1012_23fc, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1012_23ff, 2); dec(al);                                /* dec al */
            ii(0x1012_2401, 3); mov(memb_a32[ss, ebp - 0x1c], al);      /* mov [ebp-0x1c], al */
            ii(0x1012_2404, 4); cmp(memb_a32[ss, ebp - 0x1c], 0x5);     /* cmp byte [ebp-0x1c], 0x5 */
            ii(0x1012_2408, 2); if(jad(0x1012_23e2, -0x28)) goto l_0x1012_23e2; /* ja 0x101223e2 */
            ii(0x1012_240a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_240c, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x1012_240f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_2412, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1012_23e4])) return; /* jmp dword [cs:eax+0x101223e4] */
        l_0x1012_2419:
            ii(0x1012_2419, 2); jmpd(0x1012_2450, 0x35); goto l_0x1012_2450; /* jmp 0x10122450 */
        l_0x1012_241b:
            ii(0x1012_241b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_241e, 6); cmp(memw_a32[ds, eax + 0x40], 0x6c1);   /* cmp word [eax+0x40], 0x6c1 */
            ii(0x1012_2424, 2); if(jnzd(0x1012_242c, 0x6)) goto l_0x1012_242c; /* jnz 0x1012242c */
            ii(0x1012_2426, 4); cmp(memb_a32[ss, ebp - 0x10], 0x31);    /* cmp byte [ebp-0x10], 0x31 */
            ii(0x1012_242a, 2); if(jnzd(0x1012_242e, 0x2)) goto l_0x1012_242e; /* jnz 0x1012242e */
        l_0x1012_242c:
            ii(0x1012_242c, 2); jmpd(0x1012_243a, 0xc); goto l_0x1012_243a; /* jmp 0x1012243a */
        l_0x1012_242e:
            ii(0x1012_242e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2431, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_2434, 4); mov(memw_a32[ds, edx + 0x49], ax);      /* mov [edx+0x49], ax */
            ii(0x1012_2438, 2); jmpd(0x1012_2455, 0x1b); goto l_0x1012_2455; /* jmp 0x10122455 */
        l_0x1012_243a:
            ii(0x1012_243a, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1012_243e, 2); if(jnzd(0x1012_244c, 0xc)) goto l_0x1012_244c; /* jnz 0x1012244c */
            ii(0x1012_2440, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2443, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_2446, 4); mov(memw_a32[ds, edx + 0x49], ax);      /* mov [edx+0x49], ax */
            ii(0x1012_244a, 2); jmpd(0x1012_2455, 0x9); goto l_0x1012_2455; /* jmp 0x10122455 */
        l_0x1012_244c:
            ii(0x1012_244c, 4); add(memd_a32[ss, ebp - 0xc], 0x14);     /* add dword [ebp-0xc], 0x14 */
        l_0x1012_2450:
            ii(0x1012_2450, 5); jmpd(0x1012_22be, -0x197); goto l_0x1012_22be; /* jmp 0x101222be */
        l_0x1012_2455:
            ii(0x1012_2455, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_2457, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_2458, 1); popd(edi);                              /* pop edi */
            ii(0x1012_2459, 1); popd(esi);                              /* pop esi */
            ii(0x1012_245a, 1); popd(edx);                              /* pop edx */
            ii(0x1012_245b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_245c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_245d, 1); retd(); return;                         /* ret */
        }
    }
}
