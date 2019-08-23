using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_b6af-c09541e1")]
        public void Method_1012_b6af()
        {
            ii(0x1012_b6af, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1012_b6b4, 5); calld(Definitions.sys_check_available_stack_size, 0x3_a699); /* call 0x10165d52 */
            ii(0x1012_b6b9, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b6ba, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b6bb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b6bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b6be, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1012_b6c4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_b6c7, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_b6ca, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1012_b6cd, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1012_b6d0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_b6d4, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_b6d7, 7); test(memb_a32[ds, eax + 0x101c_81c1], 0x2); /* test byte [eax+0x101c81c1], 0x2 */
            ii(0x1012_b6de, 2); if(jzd(0x1012_b6e8, 0x8)) goto l_0x1012_b6e8; /* jz 0x1012b6e8 */
            ii(0x1012_b6e0, 6); mov(memw_a32[ss, ebp - 0x38], 0x2);     /* mov word [ebp-0x38], 0x2 */
            ii(0x1012_b6e6, 2); jmpd(0x1012_b6ee, 0x6); goto l_0x1012_b6ee; /* jmp 0x1012b6ee */
        l_0x1012_b6e8:
            ii(0x1012_b6e8, 6); mov(memw_a32[ss, ebp - 0x38], 0x1);     /* mov word [ebp-0x38], 0x1 */
        l_0x1012_b6ee:
            ii(0x1012_b6ee, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_b6f1, 3); mov(memd_a32[ss, ebp - 0x2e], eax);     /* mov [ebp-0x2e], eax */
            ii(0x1012_b6f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_b6f7, 4); mov(memw_a32[ss, ebp - 0x2a], ax);      /* mov [ebp-0x2a], ax */
            ii(0x1012_b6fb, 6); mov(memw_a32[ss, ebp - 0x14], 0);       /* mov word [ebp-0x14], 0x0 */
            ii(0x1012_b701, 6); mov(memw_a32[ss, ebp - 0x32], 0xff);    /* mov word [ebp-0x32], 0xff */
            ii(0x1012_b707, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_b70b, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_b711, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1012_b717, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1012_b71a, 3); mov(memd_a32[ss, ebp - 0x36], eax);     /* mov [ebp-0x36], eax */
            ii(0x1012_b71d, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_b721, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_b724, 7); mov(ax, memw_a32[ds, eax + 0x101c_81ce]); /* mov ax, [eax+0x101c81ce] */
            ii(0x1012_b72b, 4); mov(memw_a32[ss, ebp - 0x30], ax);      /* mov [ebp-0x30], ax */
            ii(0x1012_b72f, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1012_b732, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x1012_b736, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_b739, 4); mov(memw_a32[ss, ebp - 0x16], ax);      /* mov [ebp-0x16], ax */
            ii(0x1012_b73d, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1012_b741, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x1012_b744, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1012_b747, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1012_b74b, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x1012_b74e, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1012_b751, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1012_b754, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1012_b757, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1012_b75a, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1012_b75d, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1012_b760, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1012_b763, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1012_b766, 5); calld(0x100e_91ec, -0x4_257f);          /* call 0x100e91ec */
            ii(0x1012_b76b, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_b76f, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_b772, 7); test(memb_a32[ds, eax + 0x101c_81c3], 0xa); /* test byte [eax+0x101c81c3], 0xa */
            ii(0x1012_b779, 2); if(jzd(0x1012_b7d4, 0x59)) goto l_0x1012_b7d4; /* jz 0x1012b7d4 */
            ii(0x1012_b77b, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_b77f, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_b782, 6); mov(eax, memd_a32[ds, eax + 0x101c_81c6]); /* mov eax, [eax+0x101c81c6] */
            ii(0x1012_b788, 3); mov(eax, memd_a32[ds, eax + 0x9]);      /* mov eax, [eax+0x9] */
            ii(0x1012_b78b, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1012_b78e, 4); movsx(ecx, memw_a32[ss, ebp - 0x38]);   /* movsx ecx, word [ebp-0x38] */
            ii(0x1012_b792, 2); sar(eax, cl);                           /* sar eax, cl */
            ii(0x1012_b794, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_b796, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1012_b79a, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1012_b79c, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x1012_b7a0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_b7a4, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_b7a7, 6); mov(eax, memd_a32[ds, eax + 0x101c_81c6]); /* mov eax, [eax+0x101c81c6] */
            ii(0x1012_b7ad, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1012_b7b0, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1012_b7b3, 4); movsx(ecx, memw_a32[ss, ebp - 0x38]);   /* movsx ecx, word [ebp-0x38] */
            ii(0x1012_b7b7, 2); sar(eax, cl);                           /* sar eax, cl */
            ii(0x1012_b7b9, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_b7bb, 4); movsx(eax, memw_a32[ss, ebp - 0x16]);   /* movsx eax, word [ebp-0x16] */
            ii(0x1012_b7bf, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1012_b7c1, 4); mov(memw_a32[ss, ebp - 0x16], ax);      /* mov [ebp-0x16], ax */
            ii(0x1012_b7c5, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1012_b7c8, 4); inc(memw_a32[ss, ebp - 0x14]);          /* inc word [ebp-0x14] */
            ii(0x1012_b7cc, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1012_b7cf, 5); calld(0x100e_91ec, -0x4_25e8);          /* call 0x100e91ec */
        l_0x1012_b7d4:
            ii(0x1012_b7d4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b7d6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b7d7, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b7d8, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b7d9, 3); retd(0x8);                              /* ret 0x8 */
        }
    }
}
