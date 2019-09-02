using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_c242-a60b5a21")]
        public void my_dtor_d7()
        {
            ii(0x1011_c242, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_c247, 5); call(Definitions.sys_check_available_stack_size, 0x4_9b06); /* call 0x10165d52 */
            ii(0x1011_c24c, 1); push(ebx);                              /* push ebx */
            ii(0x1011_c24d, 1); push(ecx);                              /* push ecx */
            ii(0x1011_c24e, 1); push(esi);                              /* push esi */
            ii(0x1011_c24f, 1); push(edi);                              /* push edi */
            ii(0x1011_c250, 1); push(ebp);                              /* push ebp */
            ii(0x1011_c251, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_c253, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_c259, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_c25c, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_c25f, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_c266, 2); jmp(0x1011_c26e, 6); goto l_0x1011_c26e; /* jmp 0x1011c26e */
        l_0x1011_c268:
            ii(0x1011_c268, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_c26b, 3); inc(memd[ss, ebp - 12]);                /* inc dword [ebp-0xc] */
        l_0x1011_c26e:
            ii(0x1011_c26e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_c271, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1011_c278, 2); if(jge(0x1011_c2a9, 0x2f)) goto l_0x1011_c2a9; /* jge 0x1011c2a9 */
            ii(0x1011_c27a, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1011_c27e, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1011_c281, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_c283, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_c286, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_c288, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_c28a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_c28c, 5); call(Definitions.sys_delete, 0x4_9cd3); /* call 0x10165f64 */
            ii(0x1011_c291, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1011_c295, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1011_c298, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_c29b, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1011_c29e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_c2a0, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_c2a2, 5); call(Definitions.sys_delete, 0x4_9cbd); /* call 0x10165f64 */
            ii(0x1011_c2a7, 2); jmp(0x1011_c268, -0x41); goto l_0x1011_c268; /* jmp 0x1011c268 */
        l_0x1011_c2a9:
            ii(0x1011_c2a9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_c2ac, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_c2ae, 5); call(Definitions.sys_delete, 0x4_9cb1); /* call 0x10165f64 */
            ii(0x1011_c2b3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_c2b6, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1011_c2b9, 5); call(Definitions.sys_delete, 0x4_9ca6); /* call 0x10165f64 */
            ii(0x1011_c2be, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_c2c1, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x1011_c2c4, 5); call(Definitions.sys_delete, 0x4_9c9b); /* call 0x10165f64 */
            ii(0x1011_c2c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_c2cb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_c2ce, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_c2d1, 5); call(0x1012_04dc, 0x4206);              /* call 0x101204dc */
            ii(0x1011_c2d6, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1011_c2d9, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_c2dc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_c2df, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1011_c2e2, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_c2e5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_c2e7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_c2e8, 1); pop(edi);                               /* pop edi */
            ii(0x1011_c2e9, 1); pop(esi);                               /* pop esi */
            ii(0x1011_c2ea, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_c2eb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_c2ec, 1); ret();                                  /* ret */
        }
    }
}
