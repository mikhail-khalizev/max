using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_8369-b0d6049a")]
        public void Method_100c_8369()
        {
            ii(0x100c_8369, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100c_836e, 5); call(Definitions.sys_check_available_stack_size, 0x9_d9df); /* call 0x10165d52 */
            ii(0x100c_8373, 1); push(ebx);                              /* push ebx */
            ii(0x100c_8374, 1); push(ecx);                              /* push ecx */
            ii(0x100c_8375, 1); push(edx);                              /* push edx */
            ii(0x100c_8376, 1); push(esi);                              /* push esi */
            ii(0x100c_8377, 1); push(edi);                              /* push edi */
            ii(0x100c_8378, 1); push(ebp);                              /* push ebp */
            ii(0x100c_8379, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_837b, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_8381, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_8384, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x100c_8389, 5); call(0x1007_5fdc, -0x5_23b2);           /* call 0x10075fdc */
            ii(0x100c_838e, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_8390, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_8393, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_8396, 3); mov(eax, memd[ds, eax + 0x13]);         /* mov eax, [eax+0x13] */
            ii(0x100c_8399, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_839c, 3); sub(eax, memd[ds, edx + 0xb]);          /* sub eax, [edx+0xb] */
            ii(0x100c_839f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_83a1, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100c_83a5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_83a7, 2); if(jg(0x100c_83bf, 0x16)) goto l_0x100c_83bf; /* jg 0x100c83bf */
            ii(0x100c_83a9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_83ac, 3); mov(eax, memd[ds, eax + 0x17]);         /* mov eax, [eax+0x17] */
            ii(0x100c_83af, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_83b2, 3); sub(eax, memd[ds, edx + 0xf]);          /* sub eax, [edx+0xf] */
            ii(0x100c_83b5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_83b7, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100c_83bb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_83bd, 2); if(jle(0x100c_83c1, 2)) goto l_0x100c_83c1; /* jle 0x100c83c1 */
        l_0x100c_83bf:
            ii(0x100c_83bf, 2); jmp(0x100c_83c7, 6); goto l_0x100c_83c7; /* jmp 0x100c83c7 */
        l_0x100c_83c1:
            ii(0x100c_83c1, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x100c_83c5, 2); jmp(0x100c_83cb, 4); goto l_0x100c_83cb; /* jmp 0x100c83cb */
        l_0x100c_83c7:
            ii(0x100c_83c7, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
        l_0x100c_83cb:
            ii(0x100c_83cb, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100c_83ce, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100c_83d1, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100c_83d4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_83d6, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_83d7, 1); pop(edi);                               /* pop edi */
            ii(0x100c_83d8, 1); pop(esi);                               /* pop esi */
            ii(0x100c_83d9, 1); pop(edx);                               /* pop edx */
            ii(0x100c_83da, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_83db, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_83dc, 1); ret();                                  /* ret */
        }
    }
}
