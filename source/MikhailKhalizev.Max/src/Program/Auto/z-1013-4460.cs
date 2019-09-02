using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_4460-4ff2d7c")]
        public void Method_1013_4460()
        {
            ii(0x1013_4460, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_4465, 5); call(Definitions.sys_check_available_stack_size, 0x3_18e8); /* call 0x10165d52 */
            ii(0x1013_446a, 1); push(ebx);                              /* push ebx */
            ii(0x1013_446b, 1); push(ecx);                              /* push ecx */
            ii(0x1013_446c, 1); push(edx);                              /* push edx */
            ii(0x1013_446d, 1); push(esi);                              /* push esi */
            ii(0x1013_446e, 1); push(edi);                              /* push edi */
            ii(0x1013_446f, 1); push(ebp);                              /* push ebp */
            ii(0x1013_4470, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_4472, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_4478, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_447b, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_447f, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1013_4482, 2); if(jnz(0x1013_448d, 9)) goto l_0x1013_448d; /* jnz 0x1013448d */
            ii(0x1013_4484, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_448b, 2); jmp(0x1013_44c9, 0x3c); goto l_0x1013_44c9; /* jmp 0x101344c9 */
        l_0x1013_448d:
            ii(0x1013_448d, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_4491, 3); imul(edx, eax, 7);                      /* imul edx, eax, 0x7 */
            ii(0x1013_4494, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_4499, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_449b, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1013_449e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_44a1, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1013_44a5, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1013_44a8, 2); if(jnz(0x1013_44b3, 9)) goto l_0x1013_44b3; /* jnz 0x101344b3 */
            ii(0x1013_44aa, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_44b1, 2); jmp(0x1013_44c9, 0x16); goto l_0x1013_44c9; /* jmp 0x101344c9 */
        l_0x1013_44b3:
            ii(0x1013_44b3, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1013_44b7, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1013_44ba, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_44bc, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta]); /* mov eax, [0x101c70f0] */
            ii(0x1013_44c1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_44c3, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x1013_44c6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x1013_44c9:
            ii(0x1013_44c9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_44cc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_44ce, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_44cf, 1); pop(edi);                               /* pop edi */
            ii(0x1013_44d0, 1); pop(esi);                               /* pop esi */
            ii(0x1013_44d1, 1); pop(edx);                               /* pop edx */
            ii(0x1013_44d2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_44d3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_44d4, 1); ret();                                  /* ret */
        }
    }
}
