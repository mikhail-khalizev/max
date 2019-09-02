using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_35ac-b7e68fd1")]
        public void Method_1007_35ac()
        {
            ii(0x1007_35ac, 5); push(0x44);                             /* push 0x44 */
            ii(0x1007_35b1, 5); call(Definitions.sys_check_available_stack_size, 0xf_279c); /* call 0x10165d52 */
            ii(0x1007_35b6, 1); push(ebx);                              /* push ebx */
            ii(0x1007_35b7, 1); push(ecx);                              /* push ecx */
            ii(0x1007_35b8, 1); push(edx);                              /* push edx */
            ii(0x1007_35b9, 1); push(esi);                              /* push esi */
            ii(0x1007_35ba, 1); push(edi);                              /* push edi */
            ii(0x1007_35bb, 1); push(ebp);                              /* push ebp */
            ii(0x1007_35bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_35be, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1007_35c4, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_35c7, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x1007_35cb, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_35ce, 5); call(0x1007_64fc, 0x2f29);              /* call 0x100764fc */
            ii(0x1007_35d3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_35d6, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x1007_35da, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_35dd, 6); mov(memw[ds, eax + 8], 0);              /* mov word [eax+0x8], 0x0 */
            ii(0x1007_35e3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_35e6, 6); mov(memw[ds, eax + 0xa], 0);            /* mov word [eax+0xa], 0x0 */
            ii(0x1007_35ec, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_35ef, 6); mov(memw[ds, eax + 0xc], 0);            /* mov word [eax+0xc], 0x0 */
            ii(0x1007_35f5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_35f8, 6); mov(memw[ds, eax + 0xe], 0);            /* mov word [eax+0xe], 0x0 */
            ii(0x1007_35fe, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_3601, 6); mov(memw[ds, eax + 0x10], 0);           /* mov word [eax+0x10], 0x0 */
            ii(0x1007_3607, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1007_360c, 5); call(0x1007_6338, 0x2d27);              /* call 0x10076338 */
            ii(0x1007_3611, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_3613, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_3616, 5); call(0x1007_643c, 0x2e21);              /* call 0x1007643c */
            ii(0x1007_361b, 2); jmp(0x1007_3625, 8); goto l_0x1007_3625; /* jmp 0x10073625 */
        l_0x1007_361d:
            ii(0x1007_361d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_3620, 5); call(0x1007_6bf8, 0x35d3);              /* call 0x10076bf8 */
        l_0x1007_3625:
            ii(0x1007_3625, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3627, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_362a, 5); call(0x1013_ad71, 0xc_7742);            /* call 0x1013ad71 */
            ii(0x1007_362f, 2); test(al, al);                           /* test al, al */
            ii(0x1007_3631, 6); if(jz(0x1007_36c5, 0x8e)) goto l_0x1007_36c5; /* jz 0x100736c5 */
            ii(0x1007_3637, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_363a, 5); call(0x1007_63a0, 0x2d61);              /* call 0x100763a0 */
            ii(0x1007_363f, 5); call(0x1007_6204, 0x2bc0);              /* call 0x10076204 */
            ii(0x1007_3644, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1007_3647, 2); if(jnz(0x1007_36c0, 0x77)) goto l_0x1007_36c0; /* jnz 0x100736c0 */
            ii(0x1007_3649, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1007_364c, 5); call(0x1007_20b1, -0x15a0);             /* call 0x100720b1 */
            ii(0x1007_3651, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x1007_3654, 5); call(0x1007_20b1, -0x15a8);             /* call 0x100720b1 */
            ii(0x1007_3659, 5); call(0x1007_6014, 0x29b6);              /* call 0x10076014 */
            ii(0x1007_365e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_3660, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_3662, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x1007_3665, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_3668, 5); call(0x1007_6408, 0x2d9b);              /* call 0x10076408 */
            ii(0x1007_366d, 5); call(0x1007_2388, -0x12ea);             /* call 0x10072388 */
            ii(0x1007_3672, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x1007_3675, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_3678, 5); call(0x1007_6408, 0x2d8b);              /* call 0x10076408 */
            ii(0x1007_367d, 5); call(0x1007_21b6, -0x14cc);             /* call 0x100721b6 */
            ii(0x1007_3682, 3); lea(ebx, memd[ss, ebp - 0x1c]);         /* lea ebx, [ebp-0x1c] */
            ii(0x1007_3685, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_3687, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_3689, 5); call(0x1007_213f, -0x154f);             /* call 0x1007213f */
            ii(0x1007_368e, 3); mov(eax, memd[ss, ebp - 0x1a]);         /* mov eax, [ebp-0x1a] */
            ii(0x1007_3691, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_3694, 4); add(memw[ds, edx + 8], ax);             /* add [edx+0x8], ax */
            ii(0x1007_3698, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_369b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_369e, 4); add(memw[ds, edx + 0xa], ax);           /* add [edx+0xa], ax */
            ii(0x1007_36a2, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_36a5, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_36a8, 4); add(memw[ds, edx + 0xc], ax);           /* add [edx+0xc], ax */
            ii(0x1007_36ac, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1007_36af, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_36b2, 4); add(memw[ds, edx + 0xe], ax);           /* add [edx+0xe], ax */
            ii(0x1007_36b6, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_36b9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_36bc, 4); add(memw[ds, edx + 0x10], ax);          /* add [edx+0x10], ax */
        l_0x1007_36c0:
            ii(0x1007_36c0, 5); jmp(0x1007_361d, -0xa8); goto l_0x1007_361d; /* jmp 0x1007361d */
        l_0x1007_36c5:
            ii(0x1007_36c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_36c7, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_36ca, 5); call(0x1007_5f6c, 0x289d);              /* call 0x10075f6c */
            ii(0x1007_36cf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_36d1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_36d2, 1); pop(edi);                               /* pop edi */
            ii(0x1007_36d3, 1); pop(esi);                               /* pop esi */
            ii(0x1007_36d4, 1); pop(edx);                               /* pop edx */
            ii(0x1007_36d5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_36d6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_36d7, 1); ret();                                  /* ret */
        }
    }
}
