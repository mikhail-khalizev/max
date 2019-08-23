using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_939e-1c086b3e")]
        public void Method_100f_939e()
        {
            ii(0x100f_939e, 5); push(0x20);                             /* push 0x20 */
            ii(0x100f_93a3, 5); call(Definitions.sys_check_available_stack_size, 0x6_c9aa); /* call 0x10165d52 */
            ii(0x100f_93a8, 1); push(esi);                              /* push esi */
            ii(0x100f_93a9, 1); push(edi);                              /* push edi */
            ii(0x100f_93aa, 1); push(ebp);                              /* push ebp */
            ii(0x100f_93ab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_93ad, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_93b3, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_93b6, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100f_93b9, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100f_93bc, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100f_93bf, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_93c2, 3); cmp(eax, memd[ss, ebp - 0xc]);          /* cmp eax, [ebp-0xc] */
            ii(0x100f_93c5, 6); if(jnz(0x100f_944f, 0x84)) goto l_0x100f_944f; /* jnz 0x100f944f */
            ii(0x100f_93cb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_93ce, 5); call(0x1014_b6bd, 0x5_22ea);            /* call 0x1014b6bd */
            ii(0x100f_93d3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_93d6, 5); call(0x100f_28a2, -0x6b39);             /* call 0x100f28a2 */
            ii(0x100f_93db, 7); cmp(memb[ds, 0x101c_37e4], 0);          /* cmp byte [0x101c37e4], 0x0 */
            ii(0x100f_93e2, 2); if(jz(0x100f_93ed, 0x9)) goto l_0x100f_93ed; /* jz 0x100f93ed */
            ii(0x100f_93e4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_93e6, 5); call(0x100f_448c, -0x4f5f);             /* call 0x100f448c */
            ii(0x100f_93eb, 2); jmp(0x100f_940e, 0x21); goto l_0x100f_940e; /* jmp 0x100f940e */
        l_0x100f_93ed:
            ii(0x100f_93ed, 7); cmp(memb[ds, 0x101c_391e], 0x9);        /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_93f4, 2); if(jnz(0x100f_9402, 0xc)) goto l_0x100f_9402; /* jnz 0x100f9402 */
            ii(0x100f_93f6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_93f8, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100f_93fd, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_9400, 2); if(jnz(0x100f_940e, 0xc)) goto l_0x100f_940e; /* jnz 0x100f940e */
        l_0x100f_9402:
            ii(0x100f_9402, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_9405, 5); call(0x100f_40f6, -0x5314);             /* call 0x100f40f6 */
            ii(0x100f_940a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_940c, 2); if(jnz(0x100f_945f, 0x51)) goto l_0x100f_945f; /* jnz 0x100f945f */
        l_0x100f_940e:
            ii(0x100f_940e, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_9412, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_9416, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_9419, 5); call(0x1007_284b, -0x8_6bd3);           /* call 0x1007284b */
            ii(0x100f_941e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_9421, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_9424, 3); cmp(eax, memd[ss, ebp - 0xc]);          /* cmp eax, [ebp-0xc] */
            ii(0x100f_9427, 2); if(jz(0x100f_942f, 0x6)) goto l_0x100f_942f; /* jz 0x100f942f */
            ii(0x100f_9429, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100f_942d, 2); if(jnz(0x100f_9431, 0x2)) goto l_0x100f_9431; /* jnz 0x100f9431 */
        l_0x100f_942f:
            ii(0x100f_942f, 2); jmp(0x100f_944d, 0x1c); goto l_0x100f_944d; /* jmp 0x100f944d */
        l_0x100f_9431:
            ii(0x100f_9431, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_9434, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100f_9437, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100f_9439, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_943c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_943f, 5); call(0x1007_6074, -0x8_33d0);           /* call 0x10076074 */
            ii(0x100f_9444, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_9449, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_944b, 2); if(jnz(0x100f_944f, 0x2)) goto l_0x100f_944f; /* jnz 0x100f944f */
        l_0x100f_944d:
            ii(0x100f_944d, 2); jmp(0x100f_945f, 0x10); goto l_0x100f_945f; /* jmp 0x100f945f */
        l_0x100f_944f:
            ii(0x100f_944f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_9452, 5); call(0x1014_b6bd, 0x5_2266);            /* call 0x1014b6bd */
            ii(0x100f_9457, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_945a, 5); call(0x100f_92fe, -0x161);              /* call 0x100f92fe */
        l_0x100f_945f:
            ii(0x100f_945f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_9461, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_9462, 1); pop(edi);                               /* pop edi */
            ii(0x100f_9463, 1); pop(esi);                               /* pop esi */
            ii(0x100f_9464, 1); ret();                                  /* ret */
        }
    }
}
