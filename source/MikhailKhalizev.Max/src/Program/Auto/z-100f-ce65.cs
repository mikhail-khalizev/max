using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c623c2f1-dc08-4a51-a3b2-21f1f2f66a45")]
        public void Method_100f_ce65()
        {
            ii(0x100f_ce65, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100f_ce6a, 5); calld(Definitions.sys_check_available_stack_size, 0x6_8ee3); /* call 0x10165d52 */
            ii(0x100f_ce6f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_ce70, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_ce71, 1); pushd(esi);                             /* push esi */
            ii(0x100f_ce72, 1); pushd(edi);                             /* push edi */
            ii(0x100f_ce73, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_ce74, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_ce76, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100f_ce7c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_ce7f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100f_ce82, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100f_ce85, 5); calld(Definitions.my_ctor_0x101b4184, -0x8_639a); /* call 0x10076af0 */
            ii(0x100f_ce8a, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x100f_ce8f, 5); calld(0x1007_5fdc, -0x8_6eb8);          /* call 0x10075fdc */
            ii(0x100f_ce94, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_ce97, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_ce9a, 5); calld(Definitions.my_ctor_0x101b4184, -0x8_63af); /* call 0x10076af0 */
            ii(0x100f_ce9f, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x100f_cea4, 5); calld(0x1007_5fdc, -0x8_6ecd);          /* call 0x10075fdc */
            ii(0x100f_cea9, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_ceac, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_ceb0, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100f_ceb5, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_ceb7, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_ceba, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_cebc, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100f_cebf, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_cec3, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_cec7, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_ceca, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100f_cecf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_ced1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_ced4, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_ced6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_ced8, 5); calld(/* sys */ 0x1016_5e9b, 0x6_8fbe); /* call 0x10165e9b */
            ii(0x100f_cedd, 1); inc(edx);                               /* inc edx */
            ii(0x100f_cede, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_cee1, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_cee4, 4); mov(memw_a32[ss, ebp - 0x28], ax);      /* mov [ebp-0x28], ax */
            ii(0x100f_cee8, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_ceec, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_ceee, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_cef1, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_cef3, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100f_cef5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_cef7, 5); calld(/* sys */ 0x1016_5e9b, 0x6_8f9f); /* call 0x10165e9b */
            ii(0x100f_cefc, 1); inc(edx);                               /* inc edx */
            ii(0x100f_cefd, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_cf00, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_cf03, 4); mov(memw_a32[ss, ebp - 0x26], ax);      /* mov [ebp-0x26], ax */
            ii(0x100f_cf07, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_cf0a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_cf0d, 2); jmpd(0x100f_cf2b, 0x1c); goto l_0x100f_cf2b; /* jmp 0x100fcf2b */
        l_0x100f_cf0f:
            ii(0x100f_cf0f, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_cf13, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_cf16, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100f_cf1b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_cf1d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_cf20, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_cf22, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100f_cf26, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_cf28, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
        l_0x100f_cf2b:
            ii(0x100f_cf2b, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_cf2e, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100f_cf35, 6); if(jged(0x100f_d03d, 0x102)) goto l_0x100f_d03d; /* jge 0x100fd03d */
            ii(0x100f_cf3b, 3); mov(eax, memd_a32[ss, ebp - 0x26]);     /* mov eax, [ebp-0x26] */
            ii(0x100f_cf3e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_cf41, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_cf45, 2); if(jzd(0x100f_cf5d, 0x16)) goto l_0x100f_cf5d; /* jz 0x100fcf5d */
            ii(0x100f_cf47, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_cf4b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_cf4d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_cf50, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_cf52, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100f_cf54, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100f_cf58, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_cf5a, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
        l_0x100f_cf5d:
            ii(0x100f_cf5d, 2); jmpd(0x100f_cf65, 0x6); goto l_0x100f_cf65; /* jmp 0x100fcf65 */
        l_0x100f_cf5f:
            ii(0x100f_cf5f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_cf62, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
        l_0x100f_cf65:
            ii(0x100f_cf65, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_cf68, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x100f_cf6f, 6); if(jged(0x100f_d022, 0xad)) goto l_0x100f_d022; /* jge 0x100fd022 */
            ii(0x100f_cf75, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100f_cf79, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100f_cf7d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_cf7f, 5); calld(/* sys */ 0x1016_5e9b, 0x6_8f17); /* call 0x10165e9b */
            ii(0x100f_cf84, 1); inc(edx);                               /* inc edx */
            ii(0x100f_cf85, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_cf88, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_cf8b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_cf8d, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100f_cf91, 2); neg(eax);                               /* neg eax */
            ii(0x100f_cf93, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_cf95, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100f_cf99, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_cf9b, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
            ii(0x100f_cf9f, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100f_cfa3, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100f_cfa7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_cfa9, 5); calld(/* sys */ 0x1016_5e9b, 0x6_8eed); /* call 0x10165e9b */
            ii(0x100f_cfae, 1); inc(edx);                               /* inc edx */
            ii(0x100f_cfaf, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_cfb2, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_cfb5, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100f_cfb9, 2); neg(edx);                               /* neg edx */
            ii(0x100f_cfbb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_cfbd, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100f_cfc1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_cfc3, 4); mov(memw_a32[ss, ebp - 0x22], ax);      /* mov [ebp-0x22], ax */
            ii(0x100f_cfc7, 4); movsx(ecx, memw_a32[ss, ebp - 0x10]);   /* movsx ecx, word [ebp-0x10] */
            ii(0x100f_cfcb, 5); calld(/* sys */ 0x1016_5e9b, 0x6_8ecb); /* call 0x10165e9b */
            ii(0x100f_cfd0, 3); lea(eax, eax + eax * 4);                /* lea eax, [eax+eax*4] */
            ii(0x100f_cfd3, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_cfd6, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100f_cfd9, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_cfdc, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100f_cfdf, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_cfe2, 5); calld(0x1007_5e64, -0x8_7183);          /* call 0x10075e64 */
            ii(0x100f_cfe7, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x100f_cfea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_cfec, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100f_cfee, 5); calld(0x100f_c6f6, -0x8fd);             /* call 0x100fc6f6 */
            ii(0x100f_cff3, 4); movsx(ecx, memw_a32[ss, ebp - 0x10]);   /* movsx ecx, word [ebp-0x10] */
            ii(0x100f_cff7, 5); calld(/* sys */ 0x1016_5e9b, 0x6_8e9f); /* call 0x10165e9b */
            ii(0x100f_cffc, 3); lea(eax, eax + eax * 4);                /* lea eax, [eax+eax*4] */
            ii(0x100f_cfff, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_d002, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100f_d005, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_d008, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100f_d00b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_d00e, 5); calld(0x1007_5e64, -0x8_71af);          /* call 0x10075e64 */
            ii(0x100f_d013, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d015, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d018, 5); calld(0x100f_c6f6, -0x927);             /* call 0x100fc6f6 */
            ii(0x100f_d01d, 5); jmpd(0x100f_cf5f, -0xc3); goto l_0x100f_cf5f; /* jmp 0x100fcf5f */
        l_0x100f_d022:
            ii(0x100f_d022, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_d026, 2); if(jnzd(0x100f_d02e, 0x6)) goto l_0x100f_d02e; /* jnz 0x100fd02e */
            ii(0x100f_d028, 4); mov(memb_a32[ss, ebp - 0x34], 0x1);     /* mov byte [ebp-0x34], 0x1 */
            ii(0x100f_d02c, 2); jmpd(0x100f_d032, 0x4); goto l_0x100f_d032; /* jmp 0x100fd032 */
        l_0x100f_d02e:
            ii(0x100f_d02e, 4); mov(memb_a32[ss, ebp - 0x34], 0);       /* mov byte [ebp-0x34], 0x0 */
        l_0x100f_d032:
            ii(0x100f_d032, 3); mov(al, memb_a32[ss, ebp - 0x34]);      /* mov al, [ebp-0x34] */
            ii(0x100f_d035, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100f_d038, 5); jmpd(0x100f_cf0f, -0x12e); goto l_0x100f_cf0f; /* jmp 0x100fcf0f */
        l_0x100f_d03d:
            ii(0x100f_d03d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_d03f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_d040, 1); popd(edi);                              /* pop edi */
            ii(0x100f_d041, 1); popd(esi);                              /* pop esi */
            ii(0x100f_d042, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_d043, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_d044, 1); retd(); return;                         /* ret */
        }
    }
}
