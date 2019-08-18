using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_cf16-1ac1a80b")]
        public void Method_1007_cf16()
        {
            ii(0x1007_cf16, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1007_cf1b, 5); calld(Definitions.sys_check_available_stack_size, 0xe_8e32); /* call 0x10165d52 */
            ii(0x1007_cf20, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_cf21, 1); pushd(esi);                             /* push esi */
            ii(0x1007_cf22, 1); pushd(edi);                             /* push edi */
            ii(0x1007_cf23, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_cf24, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_cf26, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1007_cf2c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_cf2f, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_cf32, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1007_cf35, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_cf37, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1007_cf3a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_cf3d, 5); calld(0x1015_2962, 0xd_5a20);           /* call 0x10152962 */
            ii(0x1007_cf42, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_cf46, 2); if(jzd(0x1007_cf5d, 0x15)) goto l_0x1007_cf5d; /* jz 0x1007cf5d */
            ii(0x1007_cf48, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_cf4b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_cf4e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_cf51, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1007_cf54, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_cf57, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_cf5a, 3); calld_abs(memd_a32[ds, ebx + 0x54]);    /* call dword [ebx+0x54] */
        l_0x1007_cf5d:
            ii(0x1007_cf5d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_cf60, 5); calld(0x1008_ad28, 0xddc3);             /* call 0x1008ad28 */
            ii(0x1007_cf65, 2); test(al, al);                           /* test al, al */
            ii(0x1007_cf67, 2); if(jnzd(0x1007_cfbb, 0x52)) goto l_0x1007_cfbb; /* jnz 0x1007cfbb */
            ii(0x1007_cf69, 5); calld(0x1008_a7bc, 0xd84e);             /* call 0x1008a7bc */
            ii(0x1007_cf6e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_cf73, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_cf76, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1007_cf7b, 5); calld(Definitions.sys_new, 0xe_8e80);   /* call 0x10165e00 */
            ii(0x1007_cf80, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_cf83, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_cf86, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_cf89, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1007_cf8d, 2); if(jzd(0x1007_cfa5, 0x16)) goto l_0x1007_cfa5; /* jz 0x1007cfa5 */
            ii(0x1007_cf8f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1007_cf92, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_cf95, 5); calld(Definitions.my_ctor_c11, 0x2_692f); /* call 0x100a38c9 */
            ii(0x1007_cf9a, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1007_cf9d, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1007_cfa0, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1007_cfa3, 2); jmpd(0x1007_cfab, 0x6); goto l_0x1007_cfab; /* jmp 0x1007cfab */
        l_0x1007_cfa5:
            ii(0x1007_cfa5, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_cfa8, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x1007_cfab:
            ii(0x1007_cfab, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x1007_cfae, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_cfb3, 3); mov(ebx, memd_a32[ss, ebp - 0x14]);     /* mov ebx, [ebp-0x14] */
            ii(0x1007_cfb6, 5); calld(0x100a_4db6, 0x2_7dfb);           /* call 0x100a4db6 */
        l_0x1007_cfbb:
            ii(0x1007_cfbb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_cfbd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_cfbe, 1); popd(edi);                              /* pop edi */
            ii(0x1007_cfbf, 1); popd(esi);                              /* pop esi */
            ii(0x1007_cfc0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_cfc1, 1); retd(); return;                         /* ret */
        }
    }
}
