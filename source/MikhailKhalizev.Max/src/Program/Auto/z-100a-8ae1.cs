using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_8ae1-1e2b877e")]
        public void Method_100a_8ae1()
        {
            ii(0x100a_8ae1, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_8ae6, 5); call(Definitions.sys_check_available_stack_size, 0xb_d267); /* call 0x10165d52 */
            ii(0x100a_8aeb, 1); push(ebx);                              /* push ebx */
            ii(0x100a_8aec, 1); push(ecx);                              /* push ecx */
            ii(0x100a_8aed, 1); push(edx);                              /* push edx */
            ii(0x100a_8aee, 1); push(esi);                              /* push esi */
            ii(0x100a_8aef, 1); push(edi);                              /* push edi */
            ii(0x100a_8af0, 1); push(ebp);                              /* push ebp */
            ii(0x100a_8af1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_8af3, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_8af9, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_8afe, 5); call(0x100a_5307, -0x37fc);             /* call 0x100a5307 */
            ii(0x100a_8b03, 5); mov(eax, 0x101c_34d8);                  /* mov eax, 0x101c34d8 */
            ii(0x100a_8b08, 5); call(0x100c_8a87, 0x1_ff7a);            /* call 0x100c8a87 */
            ii(0x100a_8b0d, 7); mov(memd[ss, ebp - 0x4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x100a_8b14, 2); jmp(0x100a_8b1c, 0x6); goto l_0x100a_8b1c; /* jmp 0x100a8b1c */
        l_0x100a_8b16:
            ii(0x100a_8b16, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_8b19, 3); inc(memd[ss, ebp - 0x4]);               /* inc dword [ebp-0x4] */
        l_0x100a_8b1c:
            ii(0x100a_8b1c, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_8b20, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100a_8b23, 2); if(jge(0x100a_8b41, 0x1c)) goto l_0x100a_8b41; /* jge 0x100a8b41 */
            ii(0x100a_8b25, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100a_8b29, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_8b2d, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_8b33, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100a_8b38, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_8b3a, 5); call(0x100b_e62b, 0x1_5aec);            /* call 0x100be62b */
            ii(0x100a_8b3f, 2); jmp(0x100a_8b16, -0x2b); goto l_0x100a_8b16; /* jmp 0x100a8b16 */
        l_0x100a_8b41:
            ii(0x100a_8b41, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_8b43, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_8b44, 1); pop(edi);                               /* pop edi */
            ii(0x100a_8b45, 1); pop(esi);                               /* pop esi */
            ii(0x100a_8b46, 1); pop(edx);                               /* pop edx */
            ii(0x100a_8b47, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_8b48, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_8b49, 1); ret();                                  /* ret */
        }
    }
}
