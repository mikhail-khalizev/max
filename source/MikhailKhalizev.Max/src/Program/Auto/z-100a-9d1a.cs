using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9d1a-9b473bc1")]
        public void Method_100a_9d1a()
        {
            ii(0x100a_9d1a, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_9d1f, 5); call(Definitions.sys_check_available_stack_size, 0xb_c02e); /* call 0x10165d52 */
            ii(0x100a_9d24, 1); push(ebx);                              /* push ebx */
            ii(0x100a_9d25, 1); push(ecx);                              /* push ecx */
            ii(0x100a_9d26, 1); push(edx);                              /* push edx */
            ii(0x100a_9d27, 1); push(esi);                              /* push esi */
            ii(0x100a_9d28, 1); push(edi);                              /* push edi */
            ii(0x100a_9d29, 1); push(ebp);                              /* push ebp */
            ii(0x100a_9d2a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9d2c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_9d32, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_9d35, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9d38, 5); call(0x1008_aa80, -0x1_f2bd);           /* call 0x1008aa80 */
            ii(0x100a_9d3d, 2); test(al, 1);                            /* test al, 0x1 */
            ii(0x100a_9d3f, 2); if(jz(0x100a_9d47, 6)) goto l_0x100a_9d47; /* jz 0x100a9d47 */
            ii(0x100a_9d41, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_9d45, 2); jmp(0x100a_9d76, 0x2f); goto l_0x100a_9d76; /* jmp 0x100a9d76 */
        l_0x100a_9d47:
            ii(0x100a_9d47, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9d4a, 5); call(0x1015_26ac, 0xa_895d);            /* call 0x101526ac */
            ii(0x100a_9d4f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_9d51, 2); if(jnz(0x100a_9d59, 6)) goto l_0x100a_9d59; /* jnz 0x100a9d59 */
            ii(0x100a_9d53, 4); mov(memb[ss, ebp - 8], 2);              /* mov byte [ebp-0x8], 0x2 */
            ii(0x100a_9d57, 2); jmp(0x100a_9d76, 0x1d); goto l_0x100a_9d76; /* jmp 0x100a9d76 */
        l_0x100a_9d59:
            ii(0x100a_9d59, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9d5c, 5); call(0x1015_26ac, 0xa_894b);            /* call 0x101526ac */
            ii(0x100a_9d61, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_9d64, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_9d67, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x100a_9d6a, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9d6d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_9d70, 3); call_abs(memd[ds, ebx + 12]);           /* call dword [ebx+0xc] */
            ii(0x100a_9d73, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
        l_0x100a_9d76:
            ii(0x100a_9d76, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100a_9d79, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9d7b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_9d7c, 1); pop(edi);                               /* pop edi */
            ii(0x100a_9d7d, 1); pop(esi);                               /* pop esi */
            ii(0x100a_9d7e, 1); pop(edx);                               /* pop edx */
            ii(0x100a_9d7f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_9d80, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_9d81, 1); ret();                                  /* ret */
        }
    }
}
