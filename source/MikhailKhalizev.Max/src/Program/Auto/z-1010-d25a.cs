using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("71f2d94e-c42c-4509-b2f4-b6cb583cfb72")]
        public void Method_1010_d25a()
        {
            ii(0x1010_d25a, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1010_d25f, 5); calld(Definitions.sys_check_available_stack_size, 0x5_8aee); /* call 0x10165d52 */
            ii(0x1010_d264, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_d265, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_d266, 1); pushd(edx);                             /* push edx */
            ii(0x1010_d267, 1); pushd(esi);                             /* push esi */
            ii(0x1010_d268, 1); pushd(edi);                             /* push edi */
            ii(0x1010_d269, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_d26a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_d26c, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1010_d272, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_d275, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d278, 4); cmp(memd_a32[ds, eax + 0x18], 0);       /* cmp dword [eax+0x18], 0x0 */
            ii(0x1010_d27c, 2); if(jzd(0x1010_d2c2, 0x44)) goto l_0x1010_d2c2; /* jz 0x1010d2c2 */
            ii(0x1010_d27e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d281, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_d283, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d286, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1010_d289, 5); calld(0x100d_7f6c, -0x3_5322);          /* call 0x100d7f6c */
            ii(0x1010_d28e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d291, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1010_d294, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_d297, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1010_d29b, 2); if(jzd(0x1010_d2b1, 0x14)) goto l_0x1010_d2b1; /* jz 0x1010d2b1 */
            ii(0x1010_d29d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_d29f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_d2a2, 5); calld(Definitions.my_dtor_d3, -0x3_5574); /* call 0x100d7d33 */
            ii(0x1010_d2a7, 5); calld(Definitions.sys_delete, 0x5_8cb8); /* call 0x10165f64 */
            ii(0x1010_d2ac, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_d2af, 2); jmpd(0x1010_d2b8, 0x7); goto l_0x1010_d2b8; /* jmp 0x1010d2b8 */
        l_0x1010_d2b1:
            ii(0x1010_d2b1, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1010_d2b8:
            ii(0x1010_d2b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d2bb, 7); mov(memd_a32[ds, eax + 0x18], 0);       /* mov dword [eax+0x18], 0x0 */
        l_0x1010_d2c2:
            ii(0x1010_d2c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d2c5, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1010_d2c9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_d2cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d2cf, 4); cmp(memd_a32[ds, eax + 0x10], 0x7);     /* cmp dword [eax+0x10], 0x7 */
            ii(0x1010_d2d3, 2); if(jnzd(0x1010_d2db, 0x6)) goto l_0x1010_d2db; /* jnz 0x1010d2db */
            ii(0x1010_d2d5, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1010_d2d9, 2); jmpd(0x1010_d2df, 0x4); goto l_0x1010_d2df; /* jmp 0x1010d2df */
        l_0x1010_d2db:
            ii(0x1010_d2db, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
        l_0x1010_d2df:
            ii(0x1010_d2df, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1010_d2e2, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1010_d2e5, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1010_d2e9, 2); if(jzd(0x1010_d30f, 0x24)) goto l_0x1010_d30f; /* jz 0x1010d30f */
            ii(0x1010_d2eb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_d2ee, 3); mov(edx, memd_a32[ds, edx + 0xa]);      /* mov edx, [edx+0xa] */
            ii(0x1010_d2f1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_d2f4, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_d2f9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_d2fb, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_d2fe, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_d300, 3); imul(eax, eax, 0x6);                    /* imul eax, eax, 0x6 */
            ii(0x1010_d303, 3); lea(edx, eax + 0x6);                    /* lea edx, [eax+0x6] */
            ii(0x1010_d306, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d309, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
            ii(0x1010_d30d, 2); jmpd(0x1010_d331, 0x22); goto l_0x1010_d331; /* jmp 0x1010d331 */
        l_0x1010_d30f:
            ii(0x1010_d30f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_d312, 3); mov(edx, memd_a32[ds, edx + 0xa]);      /* mov edx, [edx+0xa] */
            ii(0x1010_d315, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_d318, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_d31d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_d31f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_d322, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_d324, 3); imul(eax, eax, 0x6);                    /* imul eax, eax, 0x6 */
            ii(0x1010_d327, 3); lea(edx, eax - 0x6);                    /* lea edx, [eax-0x6] */
            ii(0x1010_d32a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d32d, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
        l_0x1010_d331:
            ii(0x1010_d331, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d334, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1010_d337, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_d33a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_d33c, 2); if(jged(0x1010_d347, 0x9)) goto l_0x1010_d347; /* jge 0x1010d347 */
            ii(0x1010_d33e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d341, 6); mov(memw_a32[ds, eax + 0xc], 0x12);     /* mov word [eax+0xc], 0x12 */
        l_0x1010_d347:
            ii(0x1010_d347, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d34a, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1010_d34d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_d350, 3); cmp(eax, 0x17);                         /* cmp eax, 0x17 */
            ii(0x1010_d353, 2); if(jled(0x1010_d35e, 0x9)) goto l_0x1010_d35e; /* jle 0x1010d35e */
            ii(0x1010_d355, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d358, 6); mov(memw_a32[ds, eax + 0xc], 0);        /* mov word [eax+0xc], 0x0 */
        l_0x1010_d35e:
            ii(0x1010_d35e, 5); calld(/* sys */ 0x1016_be34, 0x5_ead1); /* call 0x1016be34 */
            ii(0x1010_d363, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_d365, 3); mov(cl, memb_a32[ss, ebp - 0x8]);       /* mov cl, [ebp-0x8] */
            ii(0x1010_d368, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d36b, 3); mov(ebx, memd_a32[ds, eax + 0xa]);      /* mov ebx, [eax+0xa] */
            ii(0x1010_d36e, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_d371, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1010_d375, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d378, 5); calld(0x1010_cfd2, -0x3ab);             /* call 0x1010cfd2 */
            ii(0x1010_d37d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_d382, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d385, 5); calld(0x1010_ca8c, -0x8fe);             /* call 0x1010ca8c */
            ii(0x1010_d38a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d38d, 5); calld(0x1010_cca5, -0x6ed);             /* call 0x1010cca5 */
            ii(0x1010_d392, 5); calld(/* sys */ 0x1016_bcc4, 0x5_e92d); /* call 0x1016bcc4 */
            ii(0x1010_d397, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_d399, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_d39a, 1); popd(edi);                              /* pop edi */
            ii(0x1010_d39b, 1); popd(esi);                              /* pop esi */
            ii(0x1010_d39c, 1); popd(edx);                              /* pop edx */
            ii(0x1010_d39d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_d39e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_d39f, 1); retd(); return;                         /* ret */
        }
    }
}
