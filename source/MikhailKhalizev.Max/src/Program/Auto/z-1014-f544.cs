using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f544-a9ca0f5a")]
        public void Method_1014_f544()
        {
            ii(0x1014_f544, 5); push(0x20);                             /* push 0x20 */
            ii(0x1014_f549, 5); call(Definitions.sys_check_available_stack_size, 0x1_6804); /* call 0x10165d52 */
            ii(0x1014_f54e, 1); push(ebx);                              /* push ebx */
            ii(0x1014_f54f, 1); push(ecx);                              /* push ecx */
            ii(0x1014_f550, 1); push(edx);                              /* push edx */
            ii(0x1014_f551, 1); push(esi);                              /* push esi */
            ii(0x1014_f552, 1); push(edi);                              /* push edi */
            ii(0x1014_f553, 1); push(ebp);                              /* push ebp */
            ii(0x1014_f554, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_f556, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1014_f55c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_f55f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_f562, 4); cmp(memb[ds, eax + 61], 4);             /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1014_f566, 2); if(jz(0x1014_f571, 9)) goto l_0x1014_f571; /* jz 0x1014f571 */
            ii(0x1014_f568, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_f56b, 4); cmp(memb[ds, eax + 61], 0xb);           /* cmp byte [eax+0x3d], 0xb */
            ii(0x1014_f56f, 2); if(jnz(0x1014_f573, 2)) goto l_0x1014_f573; /* jnz 0x1014f573 */
        l_0x1014_f571:
            ii(0x1014_f571, 2); jmp(0x1014_f594, 0x21); goto l_0x1014_f594; /* jmp 0x1014f594 */
        l_0x1014_f573:
            ii(0x1014_f573, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_f576, 4); test(memb[ds, eax + 19], 2);            /* test byte [eax+0x13], 0x2 */
            ii(0x1014_f57a, 2); if(jz(0x1014_f586, 0xa)) goto l_0x1014_f586; /* jz 0x1014f586 */
            ii(0x1014_f57c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_f57f, 5); cmp(memw[ds, eax + 8], 0x29);           /* cmp word [eax+0x8], 0x29 */
            ii(0x1014_f584, 2); if(jnz(0x1014_f588, 2)) goto l_0x1014_f588; /* jnz 0x1014f588 */
        l_0x1014_f586:
            ii(0x1014_f586, 2); jmp(0x1014_f592, 0xa); goto l_0x1014_f592; /* jmp 0x1014f592 */
        l_0x1014_f588:
            ii(0x1014_f588, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_f58b, 5); cmp(memw[ds, eax + 8], 0x2a);           /* cmp word [eax+0x8], 0x2a */
            ii(0x1014_f590, 2); if(jnz(0x1014_f594, 2)) goto l_0x1014_f594; /* jnz 0x1014f594 */
        l_0x1014_f592:
            ii(0x1014_f592, 2); jmp(0x1014_f596, 2); goto l_0x1014_f596; /* jmp 0x1014f596 */
        l_0x1014_f594:
            ii(0x1014_f594, 2); jmp(0x1014_f5b8, 0x22); goto l_0x1014_f5b8; /* jmp 0x1014f5b8 */
        l_0x1014_f596:
            ii(0x1014_f596, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_f599, 4); test(memb[ds, eax + 20], 0x40);         /* test byte [eax+0x14], 0x40 */
            ii(0x1014_f59d, 2); if(jz(0x1014_f5b8, 0x19)) goto l_0x1014_f5b8; /* jz 0x1014f5b8 */
            ii(0x1014_f59f, 5); mov(edx, 0x4db);                        /* mov edx, 0x4db */
            ii(0x1014_f5a4, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1014_f5a9, 5); call(0x1013_dc59, -0x1_1955);           /* call 0x1013dc59 */
            ii(0x1014_f5ae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_f5b0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_f5b3, 5); call(0x100f_3c32, -0x5_b986);           /* call 0x100f3c32 */
        l_0x1014_f5b8:
            ii(0x1014_f5b8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_f5ba, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_f5bb, 1); pop(edi);                               /* pop edi */
            ii(0x1014_f5bc, 1); pop(esi);                               /* pop esi */
            ii(0x1014_f5bd, 1); pop(edx);                               /* pop edx */
            ii(0x1014_f5be, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_f5bf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_f5c0, 1); ret();                                  /* ret */
        }
    }
}
