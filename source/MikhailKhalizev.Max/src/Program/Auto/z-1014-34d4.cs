using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_34d4-5c90e249")]
        public void Method_1014_34d4()
        {
            ii(0x1014_34d4, 5); push(0x38);                             /* push 0x38 */
            ii(0x1014_34d9, 5); call(Definitions.sys_check_available_stack_size, 0x2_2874); /* call 0x10165d52 */
            ii(0x1014_34de, 1); push(ebx);                              /* push ebx */
            ii(0x1014_34df, 1); push(ecx);                              /* push ecx */
            ii(0x1014_34e0, 1); push(esi);                              /* push esi */
            ii(0x1014_34e1, 1); push(edi);                              /* push edi */
            ii(0x1014_34e2, 1); push(ebp);                              /* push ebp */
            ii(0x1014_34e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_34e5, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_34eb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_34ee, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_34f1, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x1014_34f5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_34f8, 5); call(0x1007_64fc, -0xc_d001);           /* call 0x100764fc */
            ii(0x1014_34fd, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_3500, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1014_3504, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_3507, 5); call(0x1007_20e6, -0xd_1426);           /* call 0x100720e6 */
            ii(0x1014_350c, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1014_3511, 5); call(0x1007_6338, -0xc_d1de);           /* call 0x10076338 */
            ii(0x1014_3516, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_3518, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_351b, 5); call(0x1007_643c, -0xc_d0e4);           /* call 0x1007643c */
        l_0x1014_3520:
            ii(0x1014_3520, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3522, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_3525, 5); call(0x1013_ad71, -0x87b9);             /* call 0x1013ad71 */
            ii(0x1014_352a, 2); test(al, al);                           /* test al, al */
            ii(0x1014_352c, 6); if(jz(0x1014_3604, 0xd2)) goto l_0x1014_3604; /* jz 0x10143604 */
            ii(0x1014_3532, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_3535, 5); call(0x1007_63a0, -0xc_d19a);           /* call 0x100763a0 */
            ii(0x1014_353a, 5); call(0x1007_6204, -0xc_d33b);           /* call 0x10076204 */
            ii(0x1014_353f, 3); cmp(eax, memd[ss, ebp - 0x8]);          /* cmp eax, [ebp-0x8] */
            ii(0x1014_3542, 2); if(jnz(0x1014_3552, 0xe)) goto l_0x1014_3552; /* jnz 0x10143552 */
            ii(0x1014_3544, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_3547, 5); call(0x1007_63a0, -0xc_d1ac);           /* call 0x100763a0 */
            ii(0x1014_354c, 4); cmp(memb[ds, eax + 0x3d], 0x8);         /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1014_3550, 2); if(jnz(0x1014_3554, 0x2)) goto l_0x1014_3554; /* jnz 0x10143554 */
        l_0x1014_3552:
            ii(0x1014_3552, 2); jmp(0x1014_3562, 0xe); goto l_0x1014_3562; /* jmp 0x10143562 */
        l_0x1014_3554:
            ii(0x1014_3554, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_3557, 5); call(0x1007_63a0, -0xc_d1bc);           /* call 0x100763a0 */
            ii(0x1014_355c, 4); cmp(memb[ds, eax + 0x3d], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1014_3560, 2); if(jnz(0x1014_3564, 0x2)) goto l_0x1014_3564; /* jnz 0x10143564 */
        l_0x1014_3562:
            ii(0x1014_3562, 2); jmp(0x1014_3572, 0xe); goto l_0x1014_3572; /* jmp 0x10143572 */
        l_0x1014_3564:
            ii(0x1014_3564, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_3567, 5); call(0x1007_63a0, -0xc_d1cc);           /* call 0x100763a0 */
            ii(0x1014_356c, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1014_3570, 2); if(jnz(0x1014_3577, 0x5)) goto l_0x1014_3577; /* jnz 0x10143577 */
        l_0x1014_3572:
            ii(0x1014_3572, 5); jmp(0x1014_35f7, 0x80); goto l_0x1014_35f7; /* jmp 0x101435f7 */
        l_0x1014_3577:
            ii(0x1014_3577, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_357a, 5); call(0x1007_20b1, -0xd_14ce);           /* call 0x100720b1 */
            ii(0x1014_357f, 5); call(0x1007_6014, -0xc_d570);           /* call 0x10076014 */
            ii(0x1014_3584, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_3586, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1014_3588, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1014_358b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_358e, 5); call(0x1007_6408, -0xc_d18b);           /* call 0x10076408 */
            ii(0x1014_3593, 5); call(0x1007_2388, -0xd_1210);           /* call 0x10072388 */
            ii(0x1014_3598, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_359b, 5); call(0x1007_63a0, -0xc_d200);           /* call 0x100763a0 */
            ii(0x1014_35a0, 5); cmp(memw[ds, eax + 0x8], 0x28);         /* cmp word [eax+0x8], 0x28 */
            ii(0x1014_35a5, 2); if(jnz(0x1014_35da, 0x33)) goto l_0x1014_35da; /* jnz 0x101435da */
            ii(0x1014_35a7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_35aa, 5); call(0x1007_63a0, -0xc_d20f);           /* call 0x100763a0 */
            ii(0x1014_35af, 3); mov(al, memb[ds, eax + 0x49]);          /* mov al, [eax+0x49] */
            ii(0x1014_35b2, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_35b4, 4); sub(memw[ss, ebp - 0x20], ax);          /* sub [ebp-0x20], ax */
            ii(0x1014_35b8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_35bb, 5); call(0x1007_63a0, -0xc_d220);           /* call 0x100763a0 */
            ii(0x1014_35c0, 3); mov(al, memb[ds, eax + 0x47]);          /* mov al, [eax+0x47] */
            ii(0x1014_35c3, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_35c5, 4); sub(memw[ss, ebp - 0x1e], ax);          /* sub [ebp-0x1e], ax */
            ii(0x1014_35c9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_35cc, 5); call(0x1007_63a0, -0xc_d231);           /* call 0x100763a0 */
            ii(0x1014_35d1, 3); mov(al, memb[ds, eax + 0x48]);          /* mov al, [eax+0x48] */
            ii(0x1014_35d4, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_35d6, 4); sub(memw[ss, ebp - 0x1c], ax);          /* sub [ebp-0x1c], ax */
        l_0x1014_35da:
            ii(0x1014_35da, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1014_35dd, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_35e0, 3); sub(memw[ds, edx], ax);                 /* sub [edx], ax */
            ii(0x1014_35e3, 3); mov(eax, memd[ss, ebp - 0x1e]);         /* mov eax, [ebp-0x1e] */
            ii(0x1014_35e6, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_35e9, 4); sub(memw[ds, edx + 0x2], ax);           /* sub [edx+0x2], ax */
            ii(0x1014_35ed, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_35f0, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_35f3, 4); sub(memw[ds, edx + 0x4], ax);           /* sub [edx+0x4], ax */
        l_0x1014_35f7:
            ii(0x1014_35f7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_35fa, 5); call(0x1007_6bf8, -0xc_ca07);           /* call 0x10076bf8 */
            ii(0x1014_35ff, 5); jmp(0x1014_3520, -0xe4); goto l_0x1014_3520; /* jmp 0x10143520 */
        l_0x1014_3604:
            ii(0x1014_3604, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3606, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_3609, 5); call(0x1007_5f6c, -0xc_d6a2);           /* call 0x10075f6c */
            ii(0x1014_360e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_3610, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_3611, 1); pop(edi);                               /* pop edi */
            ii(0x1014_3612, 1); pop(esi);                               /* pop esi */
            ii(0x1014_3613, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_3614, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_3615, 1); ret();                                  /* ret */
        }
    }
}
