using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_3558-856679e8")]
        public void Method_1008_3558()
        {
            ii(0x1008_3558, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1008_355d, 5); calld(Definitions.sys_check_available_stack_size, 0xe_27f0); /* call 0x10165d52 */
            ii(0x1008_3562, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_3563, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_3564, 1); pushd(edx);                             /* push edx */
            ii(0x1008_3565, 1); pushd(esi);                             /* push esi */
            ii(0x1008_3566, 1); pushd(edi);                             /* push edi */
            ii(0x1008_3567, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_3568, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_356a, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1008_3570, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_3573, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_3577, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_357a, 5); calld(0x1008_9c28, 0x66a9);             /* call 0x10089c28 */
            ii(0x1008_357f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_3582, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_3586, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_358a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_358d, 5); calld(0x1007_64fc, -0xd096);            /* call 0x100764fc */
            ii(0x1008_3592, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_3595, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_3599, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_359c, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_359f, 5); calld(0x1007_6b90, -0xca14);            /* call 0x10076b90 */
            ii(0x1008_35a4, 1); cwde();                                 /* cwde */
            ii(0x1008_35a5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_35a7, 2); if(jnzd(0x1008_35c6, 0x1d)) goto l_0x1008_35c6; /* jnz 0x100835c6 */
            ii(0x1008_35a9, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_35ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_35af, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_35b2, 5); calld(0x1007_5f6c, -0xd64b);            /* call 0x10075f6c */
            ii(0x1008_35b7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_35b9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_35bc, 5); calld(0x1008_9044, 0x5a83);             /* call 0x10089044 */
            ii(0x1008_35c1, 5); jmpd(0x1008_36a1, 0xdb); goto l_0x1008_36a1; /* jmp 0x100836a1 */
        l_0x1008_35c6:
            ii(0x1008_35c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_35c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_35cb, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_35ce, 5); calld(0x1008_9c68, 0x6695);             /* call 0x10089c68 */
            ii(0x1008_35d3, 5); calld(0x1008_9f70, 0x6998);             /* call 0x10089f70 */
            ii(0x1008_35d8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_35da, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_35dc, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1008_35df, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_35e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_35e5, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_35e8, 5); calld(0x1008_9d08, 0x671b);             /* call 0x10089d08 */
            ii(0x1008_35ed, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1008_35f0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_35f2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_35f4, 5); calld(0x1008_9b68, 0x656f);             /* call 0x10089b68 */
            ii(0x1008_35f9, 2); jmpd(0x1008_3603, 0x8); goto l_0x1008_3603; /* jmp 0x10083603 */
        l_0x1008_35fb:
            ii(0x1008_35fb, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_35fe, 5); calld(0x1007_6bf8, -0xca0b);            /* call 0x10076bf8 */
        l_0x1008_3603:
            ii(0x1008_3603, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3605, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_3608, 5); calld(0x1013_ad71, 0xb_7764);           /* call 0x1013ad71 */
            ii(0x1008_360d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_360f, 2); if(jzd(0x1008_3673, 0x62)) goto l_0x1008_3673; /* jz 0x10083673 */
            ii(0x1008_3611, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_3614, 5); calld(0x1008_9acc, 0x64b3);             /* call 0x10089acc */
            ii(0x1008_3619, 5); calld(0x1008_9fc4, 0x69a6);             /* call 0x10089fc4 */
            ii(0x1008_361e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_3620, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_3623, 5); calld(0x1007_643c, -0xd1ec);            /* call 0x1007643c */
            ii(0x1008_3628, 2); jmpd(0x1008_3632, 0x8); goto l_0x1008_3632; /* jmp 0x10083632 */
        l_0x1008_362a:
            ii(0x1008_362a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_362d, 5); calld(0x1007_6bf8, -0xca3a);            /* call 0x10076bf8 */
        l_0x1008_3632:
            ii(0x1008_3632, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3634, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_3637, 5); calld(0x1013_ad71, 0xb_7735);           /* call 0x1013ad71 */
            ii(0x1008_363c, 2); test(al, al);                           /* test al, al */
            ii(0x1008_363e, 2); if(jzd(0x1008_3671, 0x31)) goto l_0x1008_3671; /* jz 0x10083671 */
            ii(0x1008_3640, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1008_3644, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_3647, 5); calld(0x1007_63a0, -0xd2ac);            /* call 0x100763a0 */
            ii(0x1008_364c, 5); calld(0x1007_6074, -0xd5dd);            /* call 0x10076074 */
            ii(0x1008_3651, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3653, 2); if(jzd(0x1008_366f, 0x1a)) goto l_0x1008_366f; /* jz 0x1008366f */
            ii(0x1008_3655, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_3659, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_365b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_365e, 5); calld(0x1007_5f6c, -0xd6f7);            /* call 0x10075f6c */
            ii(0x1008_3663, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3665, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_3668, 5); calld(0x1008_9044, 0x59d7);             /* call 0x10089044 */
            ii(0x1008_366d, 2); jmpd(0x1008_36a1, 0x32); goto l_0x1008_36a1; /* jmp 0x100836a1 */
        l_0x1008_366f:
            ii(0x1008_366f, 2); jmpd(0x1008_362a, -0x47); goto l_0x1008_362a; /* jmp 0x1008362a */
        l_0x1008_3671:
            ii(0x1008_3671, 2); jmpd(0x1008_35fb, -0x78); goto l_0x1008_35fb; /* jmp 0x100835fb */
        l_0x1008_3673:
            ii(0x1008_3673, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_3677, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3679, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_367c, 5); calld(0x1007_5f6c, -0xd715);            /* call 0x10075f6c */
            ii(0x1008_3681, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3683, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_3686, 5); calld(0x1008_9044, 0x59b9);             /* call 0x10089044 */
            ii(0x1008_368b, 2); jmpd(0x1008_36a1, 0x14); goto l_0x1008_36a1; /* jmp 0x100836a1 */
        //  ii(0x1008_368d, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_368f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //  ii(0x1008_3692, 5); calld(0x1007_5f6c, -0xd72b);            /* call 0x10075f6c */
        //  ii(0x1008_3697, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_3699, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
        //  ii(0x1008_369c, 5); calld(0x1008_9044, 0x59a3);             /* call 0x10089044 */
        l_0x1008_36a1:
            ii(0x1008_36a1, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_36a4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_36a6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_36a7, 1); popd(edi);                              /* pop edi */
            ii(0x1008_36a8, 1); popd(esi);                              /* pop esi */
            ii(0x1008_36a9, 1); popd(edx);                              /* pop edx */
            ii(0x1008_36aa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_36ab, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_36ac, 1); retd(); return;                         /* ret */
        }
    }
}
