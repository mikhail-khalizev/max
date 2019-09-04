using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_cf16-1ac1a80b")]
        public void Method_1007_cf16()
        {
            ii(0x1007_cf16, 5); push(0x38);                             /* push 0x38 */
            ii(0x1007_cf1b, 5); call(Definitions.sys_check_available_stack_size, 0xe_8e32); /* call 0x10165d52 */
            ii(0x1007_cf20, 1); push(ecx);                              /* push ecx */
            ii(0x1007_cf21, 1); push(esi);                              /* push esi */
            ii(0x1007_cf22, 1); push(edi);                              /* push edi */
            ii(0x1007_cf23, 1); push(ebp);                              /* push ebp */
            ii(0x1007_cf24, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_cf26, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1007_cf2c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_cf2f, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1007_cf32, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1007_cf35, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_cf37, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1007_cf3a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_cf3d, 5); call(0x1015_2962, 0xd_5a20);            /* call 0x10152962 */
            ii(0x1007_cf42, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_cf46, 2); if(jz(0x1007_cf5d, 0x15)) goto l_0x1007_cf5d; /* jz 0x1007cf5d */
            ii(0x1007_cf48, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_cf4b, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1007_cf4e, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_cf51, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1007_cf54, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_cf57, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_cf5a, 3); call_abs(memd[ds, ebx + 84]);           /* call dword [ebx+0x54] */
        l_0x1007_cf5d:
            ii(0x1007_cf5d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_cf60, 5); call(0x1008_ad28, 0xddc3);              /* call 0x1008ad28 */
            ii(0x1007_cf65, 2); test(al, al);                           /* test al, al */
            ii(0x1007_cf67, 2); if(jnz(0x1007_cfbb, 0x52)) goto l_0x1007_cfbb; /* jnz 0x1007cfbb */
            ii(0x1007_cf69, 5); call(0x1008_a7bc, 0xd84e);              /* call 0x1008a7bc */
            ii(0x1007_cf6e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_cf73, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1007_cf76, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1007_cf7b, 5); call(Definitions.sys_new, 0xe_8e80);    /* call 0x10165e00 */
            ii(0x1007_cf80, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1007_cf83, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1007_cf86, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1007_cf89, 4); cmp(memd[ss, ebp - 28], 0);             /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1007_cf8d, 2); if(jz(0x1007_cfa5, 0x16)) goto l_0x1007_cfa5; /* jz 0x1007cfa5 */
            ii(0x1007_cf8f, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1007_cf92, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1007_cf95, 5); call(Definitions.my_ctor_c11, 0x2_692f); /* call 0x100a38c9 */
            ii(0x1007_cf9a, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1007_cf9d, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1007_cfa0, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1007_cfa3, 2); jmp(0x1007_cfab, 6); goto l_0x1007_cfab; /* jmp 0x1007cfab */
        l_0x1007_cfa5:
            ii(0x1007_cfa5, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1007_cfa8, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
        l_0x1007_cfab:
            ii(0x1007_cfab, 3); mov(edx, memd[ss, ebp - 36]);           /* mov edx, [ebp-0x24] */
            ii(0x1007_cfae, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_cfb3, 3); mov(ebx, memd[ss, ebp - 20]);           /* mov ebx, [ebp-0x14] */
            ii(0x1007_cfb6, 5); call(0x100a_4db6, 0x2_7dfb);            /* call 0x100a4db6 */
        l_0x1007_cfbb:
            ii(0x1007_cfbb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_cfbd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_cfbe, 1); pop(edi);                               /* pop edi */
            ii(0x1007_cfbf, 1); pop(esi);                               /* pop esi */
            ii(0x1007_cfc0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_cfc1, 1); ret();                                  /* ret */
        }
    }
}
