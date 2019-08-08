using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7468552e-08f0-4545-989b-f573bec3363a")]
        public void Method_1010_3541()
        {
            ii(0x1010_3541, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1010_3546, 5); calld(Definitions.sys_check_available_stack_size, 0x6_2807); /* call 0x10165d52 */
            ii(0x1010_354b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_354c, 1); pushd(esi);                             /* push esi */
            ii(0x1010_354d, 1); pushd(edi);                             /* push edi */
            ii(0x1010_354e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_354f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3551, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1010_3557, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_355a, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_355d, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1010_3560, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_3563, 2); mov(ecx, memd_a32[ds, edx]);            /* mov ecx, [edx] */
            ii(0x1010_3565, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1010_3568, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_356c, 2); shl(edx, cl);                           /* shl edx, cl */
            ii(0x1010_356e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_3572, 2); xor(edx, eax);                          /* xor edx, eax */
            ii(0x1010_3574, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_3577, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1010_357a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_357c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_357f, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x1010_3581, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1010_3584, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_3588, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1010_358b, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_358e, 3); mov(edx, memd_a32[ds, edx + 0x4]);      /* mov edx, [edx+0x4] */
            ii(0x1010_3591, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_3593, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x1010_3596, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_3599, 5); calld(0x1010_46a4, 0x1106);             /* call 0x101046a4 */
            ii(0x1010_359e, 3); lea(ecx, ebp - 0x18);                   /* lea ecx, [ebp-0x18] */
            ii(0x1010_35a1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_35a3, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1010_35a5, 5); calld(0x1010_4590, 0xfe6);              /* call 0x10104590 */
        l_0x1010_35aa:
            ii(0x1010_35aa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_35ac, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_35af, 5); calld(0x1013_ad71, 0x3_77bd);           /* call 0x1013ad71 */
            ii(0x1010_35b4, 2); test(al, al);                           /* test al, al */
            ii(0x1010_35b6, 2); if(jzd(0x1010_35e0, 0x28)) goto l_0x1010_35e0; /* jz 0x101035e0 */
            ii(0x1010_35b8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_35bb, 5); calld(0x1010_44b0, 0xef0);              /* call 0x101044b0 */
            ii(0x1010_35c0, 5); calld(0x1010_4790, 0x11cb);             /* call 0x10104790 */
            ii(0x1010_35c5, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1010_35c9, 2); if(jnzd(0x1010_35de, 0x13)) goto l_0x1010_35de; /* jnz 0x101035de */
            ii(0x1010_35cb, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_35ce, 5); calld(0x1010_44b0, 0xedd);              /* call 0x101044b0 */
            ii(0x1010_35d3, 5); calld(0x1010_475c, 0x1184);             /* call 0x1010475c */
            ii(0x1010_35d8, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1010_35dc, 2); if(jzd(0x1010_35e0, 0x2)) goto l_0x1010_35e0; /* jz 0x101035e0 */
        l_0x1010_35de:
            ii(0x1010_35de, 2); jmpd(0x1010_35e2, 0x2); goto l_0x1010_35e2; /* jmp 0x101035e2 */
        l_0x1010_35e0:
            ii(0x1010_35e0, 2); jmpd(0x1010_35ec, 0xa); goto l_0x1010_35ec; /* jmp 0x101035ec */
        l_0x1010_35e2:
            ii(0x1010_35e2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_35e5, 5); calld(0x1007_6bf8, -0x8_c9f2);          /* call 0x10076bf8 */
            ii(0x1010_35ea, 2); jmpd(0x1010_35aa, -0x42); goto l_0x1010_35aa; /* jmp 0x101035aa */
        l_0x1010_35ec:
            ii(0x1010_35ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_35ee, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_35f1, 5); calld(0x1013_ad11, 0x3_771b);           /* call 0x1013ad11 */
            ii(0x1010_35f6, 2); test(al, al);                           /* test al, al */
            ii(0x1010_35f8, 2); if(jzd(0x1010_360d, 0x13)) goto l_0x1010_360d; /* jz 0x1010360d */
            ii(0x1010_35fa, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1010_3601, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3603, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_3606, 5); calld(0x1010_4470, 0xe65);              /* call 0x10104470 */
            ii(0x1010_360b, 2); jmpd(0x1010_3638, 0x2b); goto l_0x1010_3638; /* jmp 0x10103638 */
        l_0x1010_360d:
            ii(0x1010_360d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_3610, 5); calld(0x1010_44b0, 0xe9b);              /* call 0x101044b0 */
            ii(0x1010_3615, 5); calld(0x1010_47c4, 0x11aa);             /* call 0x101047c4 */
            ii(0x1010_361a, 5); calld(0x1007_6338, -0x8_d2e7);          /* call 0x10076338 */
            ii(0x1010_361f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_3622, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3624, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_3627, 5); calld(0x1010_4470, 0xe44);              /* call 0x10104470 */
            ii(0x1010_362c, 2); jmpd(0x1010_3638, 0xa); goto l_0x1010_3638; /* jmp 0x10103638 */
        //    ii(0x1010_362e, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1010_3630, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //    ii(0x1010_3633, 5); calld(0x1010_4470, 0xe38);              /* call 0x10104470 */
        l_0x1010_3638:
            ii(0x1010_3638, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_363b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_363d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_363e, 1); popd(edi);                              /* pop edi */
            ii(0x1010_363f, 1); popd(esi);                              /* pop esi */
            ii(0x1010_3640, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_3641, 1); retd(); return;                         /* ret */
        }
    }
}
