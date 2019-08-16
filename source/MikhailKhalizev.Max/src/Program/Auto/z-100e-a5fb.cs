using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("922e609c-b4e6-4e0d-bef6-7e933dd691f0")]
        public void Method_100e_a5fb()
        {
            ii(0x100e_a5fb, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100e_a600, 5); calld(Definitions.sys_check_available_stack_size, 0x7_b74d); /* call 0x10165d52 */
            ii(0x100e_a605, 1); pushd(esi);                             /* push esi */
            ii(0x100e_a606, 1); pushd(edi);                             /* push edi */
            ii(0x100e_a607, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_a608, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a60a, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100e_a610, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_a613, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100e_a616, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100e_a619, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100e_a61c, 5); calld(/* sys */ 0x1016_cc1c, 0x8_25fb); /* call 0x1016cc1c */
            ii(0x100e_a621, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_a624, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_a627, 3); add(eax, memd_a32[ss, ebp + 0x10]);     /* add eax, [ebp+0x10] */
            ii(0x100e_a62a, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_a62d, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100e_a634, 2); jmpd(0x100e_a63c, 0x6); goto l_0x100e_a63c; /* jmp 0x100ea63c */
        l_0x100e_a636:
            ii(0x100e_a636, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_a639, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
        l_0x100e_a63c:
            ii(0x100e_a63c, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_a640, 5); cmp(eax, 0x100);                        /* cmp eax, 0x100 */
            ii(0x100e_a645, 6); if(jged(0x100e_a75b, 0x110)) goto l_0x100e_a75b; /* jge 0x100ea75b */
            ii(0x100e_a64b, 3); mov(al, memb_a32[ss, ebp - 0x2c]);      /* mov al, [ebp-0x2c] */
            ii(0x100e_a64e, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100e_a651, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_a655, 3); lea(eax, eax + eax * 2);                /* lea eax, [eax+eax*2] */
            ii(0x100e_a658, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_a65b, 3); movsx(edx, memb_a32[ds, eax]);          /* movsx edx, byte [eax] */
            ii(0x100e_a65e, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100e_a662, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_a665, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x100e_a669, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_a66d, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x100e_a670, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_a672, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_a676, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_a678, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_a67b, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_a67d, 3); mov(memb_a32[ss, ebp - 0x30], al);      /* mov [ebp-0x30], al */
            ii(0x100e_a680, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_a684, 3); lea(eax, eax + eax * 2);                /* lea eax, [eax+eax*2] */
            ii(0x100e_a687, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x100e_a68a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_a68c, 4); movsx(edx, memb_a32[ds, edx + 0x2]);    /* movsx edx, byte [edx+0x2] */
            ii(0x100e_a690, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100e_a694, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_a697, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100e_a699, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_a69d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_a6a1, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_a6a4, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100e_a6a6, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_a6aa, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_a6ac, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_a6af, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_a6b1, 3); mov(memb_a32[ss, ebp - 0x2e], al);      /* mov [ebp-0x2e], al */
            ii(0x100e_a6b4, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_a6b8, 3); lea(eax, eax + eax * 2);                /* lea eax, [eax+eax*2] */
            ii(0x100e_a6bb, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_a6be, 4); movsx(edx, memb_a32[ds, eax + 0x1]);    /* movsx edx, byte [eax+0x1] */
            ii(0x100e_a6c2, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100e_a6c6, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_a6c9, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100e_a6cd, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100e_a6d1, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x100e_a6d4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_a6d6, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_a6da, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_a6dc, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_a6df, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_a6e1, 3); mov(memb_a32[ss, ebp - 0x2f], al);      /* mov [ebp-0x2f], al */
            ii(0x100e_a6e4, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100e_a6e7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_a6e9, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100e_a6ec, 3); lea(eax, eax + eax * 2);                /* lea eax, [eax+eax*2] */
            ii(0x100e_a6ef, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_a6f2, 5); calld(0x100e_9fe3, -0x714);             /* call 0x100e9fe3 */
            ii(0x100e_a6f7, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_a6fa, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x100e_a701, 2); jmpd(0x100e_a709, 0x6); goto l_0x100e_a709; /* jmp 0x100ea709 */
        l_0x100e_a703:
            ii(0x100e_a703, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_a706, 3); inc(memd_a32[ss, ebp - 0x24]);          /* inc dword [ebp-0x24] */
        l_0x100e_a709:
            ii(0x100e_a709, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_a70d, 5); cmp(eax, 0x100);                        /* cmp eax, 0x100 */
            ii(0x100e_a712, 2); if(jged(0x100e_a71c, 0x8)) goto l_0x100e_a71c; /* jge 0x100ea71c */
            ii(0x100e_a714, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_a718, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_a71a, 2); if(jgd(0x100e_a71e, 0x2)) goto l_0x100e_a71e; /* jg 0x100ea71e */
        l_0x100e_a71c:
            ii(0x100e_a71c, 2); jmpd(0x100e_a74a, 0x2c); goto l_0x100e_a74a; /* jmp 0x100ea74a */
        l_0x100e_a71e:
            ii(0x100e_a71e, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100e_a721, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_a725, 3); lea(eax, eax + eax * 2);                /* lea eax, [eax+eax*2] */
            ii(0x100e_a728, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_a72b, 5); calld(0x100e_9fe3, -0x74d);             /* call 0x100e9fe3 */
            ii(0x100e_a730, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_a733, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_a736, 4); cmp(ax, memw_a32[ss, ebp - 0x1c]);      /* cmp ax, [ebp-0x1c] */
            ii(0x100e_a73a, 2); if(jged(0x100e_a748, 0xc)) goto l_0x100e_a748; /* jge 0x100ea748 */
            ii(0x100e_a73c, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_a73f, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_a742, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x100e_a745, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
        l_0x100e_a748:
            ii(0x100e_a748, 2); jmpd(0x100e_a703, -0x47); goto l_0x100e_a703; /* jmp 0x100ea703 */
        l_0x100e_a74a:
            ii(0x100e_a74a, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x100e_a74e, 3); add(edx, memd_a32[ss, ebp + 0x14]);     /* add edx, [ebp+0x14] */
            ii(0x100e_a751, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100e_a754, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x100e_a756, 5); jmpd(0x100e_a636, -0x125); goto l_0x100e_a636; /* jmp 0x100ea636 */
        l_0x100e_a75b:
            ii(0x100e_a75b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_a75d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_a75e, 1); popd(edi);                              /* pop edi */
            ii(0x100e_a75f, 1); popd(esi);                              /* pop esi */
            ii(0x100e_a760, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}