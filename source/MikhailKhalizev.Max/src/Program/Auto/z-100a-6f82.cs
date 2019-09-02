using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_6f82-52445f27")]
        public void Method_100a_6f82()
        {
            ii(0x100a_6f82, 5); push(0x34);                             /* push 0x34 */
            ii(0x100a_6f87, 5); call(Definitions.sys_check_available_stack_size, 0xb_edc6); /* call 0x10165d52 */
            ii(0x100a_6f8c, 1); push(ebx);                              /* push ebx */
            ii(0x100a_6f8d, 1); push(ecx);                              /* push ecx */
            ii(0x100a_6f8e, 1); push(edx);                              /* push edx */
            ii(0x100a_6f8f, 1); push(esi);                              /* push esi */
            ii(0x100a_6f90, 1); push(edi);                              /* push edi */
            ii(0x100a_6f91, 1); push(ebp);                              /* push ebp */
            ii(0x100a_6f92, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6f94, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100a_6f9a, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_6f9d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_6fa0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6fa3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6fa6, 5); call(0x1007_6574, -0x3_0a37);           /* call 0x10076574 */
            ii(0x100a_6fab, 5); call(0x1015_27ed, 0xa_b83d);            /* call 0x101527ed */
            ii(0x100a_6fb0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6fb3, 5); call(0x1008_acf8, -0x1_c2c0);           /* call 0x1008acf8 */
            ii(0x100a_6fb8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_6fba, 2); if(jnz(0x100a_700e, 0x52)) goto l_0x100a_700e; /* jnz 0x100a700e */
            ii(0x100a_6fbc, 5); call(0x1008_a7bc, -0x1_c805);           /* call 0x1008a7bc */
            ii(0x100a_6fc1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_6fc6, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_6fc9, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100a_6fce, 5); call(Definitions.sys_new, 0xb_ee2d);    /* call 0x10165e00 */
            ii(0x100a_6fd3, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_6fd6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_6fd9, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_6fdc, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100a_6fe0, 2); if(jz(0x100a_6ff8, 0x16)) goto l_0x100a_6ff8; /* jz 0x100a6ff8 */
            ii(0x100a_6fe2, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_6fe5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_6fe8, 5); call(0x100a_3711, -0x38dc);             /* call 0x100a3711 */
            ii(0x100a_6fed, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100a_6ff0, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_6ff3, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100a_6ff6, 2); jmp(0x100a_6ffe, 6); goto l_0x100a_6ffe; /* jmp 0x100a6ffe */
        l_0x100a_6ff8:
            ii(0x100a_6ff8, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_6ffb, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
        l_0x100a_6ffe:
            ii(0x100a_6ffe, 3); mov(edx, memd[ss, ebp - 24]);           /* mov edx, [ebp-0x18] */
            ii(0x100a_7001, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_7006, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100a_7009, 5); call(0x100a_4db6, -0x2258);             /* call 0x100a4db6 */
        l_0x100a_700e:
            ii(0x100a_700e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_7010, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_7011, 1); pop(edi);                               /* pop edi */
            ii(0x100a_7012, 1); pop(esi);                               /* pop esi */
            ii(0x100a_7013, 1); pop(edx);                               /* pop edx */
            ii(0x100a_7014, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_7015, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_7016, 1); ret();                                  /* ret */
        }
    }
}
